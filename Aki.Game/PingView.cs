using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D52 RID: 7506
[NullableContext(1)]
[Nullable(0)]
public class PingView : UiViewBase
{
	// Token: 0x0600E3AD RID: 58285 RVA: 0x00357703 File Offset: 0x00355903
	public PingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E3AE RID: 58286 RVA: 0x00357724 File Offset: 0x00355924
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E3AF RID: 58287 RVA: 0x003577B0 File Offset: 0x003559B0
	protected override void OnStart()
	{
		base.GetItem(1).SetUIActive(false);
		this.LastTimeReconnectState = false;
		this.PingUnChangeValue = CommonConfig.Instance.GetPingUnChangeValue().Value;
	}

	// Token: 0x0600E3B0 RID: 58288 RVA: 0x003577E9 File Offset: 0x003559E9
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnCheckGamePing, new Action<int>(this.OnRefreshPing));
	}

	// Token: 0x0600E3B1 RID: 58289 RVA: 0x00357807 File Offset: 0x00355A07
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCheckGamePing, new Action<int>(this.OnRefreshPing));
	}

	// Token: 0x0600E3B2 RID: 58290 RVA: 0x00357828 File Offset: 0x00355A28
	private void OnRefreshPing(int pingTime)
	{
		if (Math.Abs(pingTime - this.LastTimeShowPing) < this.PingUnChangeValue)
		{
			return;
		}
		this.LastTimeShowPing = pingTime;
		bool flag = pingTime > 500;
		if (flag != this.LastTimeReconnectState)
		{
			base.GetSprite(0).SetUIActive(!flag);
			base.GetItem(1).SetUIActive(flag);
			this.RefreshReconnectAnimation(flag);
			this.LastTimeReconnectState = flag;
		}
		ValueTuple<string, string> spriteAndColorByPing = this.GetSpriteAndColorByPing(pingTime);
		if (this.LastSpritePath != spriteAndColorByPing.Item1)
		{
			this.SetSpriteByPath(spriteAndColorByPing.Item1, base.GetSprite(0), false, null, null);
			this.LastSpritePath = spriteAndColorByPing.Item1;
			base.GetText(2).SetColor(FColor.FromHex(spriteAndColorByPing.Item2));
		}
		LguiUtil.Instance.SetLocalText(base.GetText(2), "PingStr", new <>z__ReadOnlySingleElementList<object>(pingTime.ToString()));
	}

	// Token: 0x0600E3B3 RID: 58291 RVA: 0x0035790D File Offset: 0x00355B0D
	protected override void OnAfterShow()
	{
		this.OnRefreshPing(GamePingModel.Instance.CurrentPing);
	}

	// Token: 0x0600E3B4 RID: 58292 RVA: 0x0035791F File Offset: 0x00355B1F
	private void RefreshReconnectAnimation(bool reconnectState)
	{
		if (reconnectState)
		{
			this.UiViewSequence.PlaySequencePurely("Loop", false, false);
			return;
		}
		this.UiViewSequence.StopSequenceByKey("Loop", false, false);
	}

	// Token: 0x0600E3B5 RID: 58293 RVA: 0x0035794C File Offset: 0x00355B4C
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<string, string> GetSpriteAndColorByPing(int pingTime)
	{
		if (pingTime <= 100)
		{
			return new ValueTuple<string, string>(this.GetGoodPingSprite(), "30D82DFF");
		}
		if (pingTime > 100 && pingTime <= 200)
		{
			return new ValueTuple<string, string>(this.GetMiddlePingSprite(), "FFD12FFF");
		}
		return new ValueTuple<string, string>(this.GetBadPingSprite(), "FF1F1EFF");
	}

	// Token: 0x0600E3B6 RID: 58294 RVA: 0x0035799D File Offset: 0x00355B9D
	[NullableContext(2)]
	private string GetGoodPingSprite()
	{
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return CommonConfig.Instance.GetNetGoodSprite();
		}
		if (UKuroLauncherLibrary.GetNetworkConnectionType() == 4)
		{
			return CommonConfig.Instance.GetNetGoodSpriteMobile();
		}
		return CommonConfig.Instance.GetNetGoodSprite();
	}

	// Token: 0x0600E3B7 RID: 58295 RVA: 0x003579D3 File Offset: 0x00355BD3
	[NullableContext(2)]
	private string GetMiddlePingSprite()
	{
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return CommonConfig.Instance.GetNetMiddleSprite();
		}
		if (UKuroLauncherLibrary.GetNetworkConnectionType() == 4)
		{
			return CommonConfig.Instance.GetNetMiddleSpriteMobile();
		}
		return CommonConfig.Instance.GetNetMiddleSprite();
	}

	// Token: 0x0600E3B8 RID: 58296 RVA: 0x00357A09 File Offset: 0x00355C09
	[NullableContext(2)]
	private string GetBadPingSprite()
	{
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return CommonConfig.Instance.GetNetBadSprite();
		}
		if (UKuroLauncherLibrary.GetNetworkConnectionType() == 4)
		{
			return CommonConfig.Instance.GetNetBadSpriteMobile();
		}
		return CommonConfig.Instance.GetNetBadSprite();
	}

	// Token: 0x04006914 RID: 26900
	private const int GOODPING = 100;

	// Token: 0x04006915 RID: 26901
	private const int MIDDLEPING = 200;

	// Token: 0x04006916 RID: 26902
	private const int LOOPPING = 500;

	// Token: 0x04006917 RID: 26903
	private const string BADCOLOR = "FF1F1EFF";

	// Token: 0x04006918 RID: 26904
	private const string MIDDLECOLOR = "FFD12FFF";

	// Token: 0x04006919 RID: 26905
	private const string GOODCOLOR = "30D82DFF";

	// Token: 0x0400691A RID: 26906
	private string LastSpritePath = string.Empty;

	// Token: 0x0400691B RID: 26907
	private bool LastTimeReconnectState;

	// Token: 0x0400691C RID: 26908
	private int LastTimeShowPing = -9999;

	// Token: 0x0400691D RID: 26909
	private int PingUnChangeValue;

	// Token: 0x02008366 RID: 33638
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402AD58 RID: 175448
		NetStateSprite,
		// Token: 0x0402AD59 RID: 175449
		ReconnectItem,
		// Token: 0x0402AD5A RID: 175450
		PingText
	}
}
