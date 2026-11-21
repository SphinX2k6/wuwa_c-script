using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001214 RID: 4628
[NullableContext(1)]
[Nullable(0)]
public class PingView : UiViewBase
{
	// Token: 0x0600B7CA RID: 47050 RVA: 0x00363173 File Offset: 0x00361373
	public PingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B7CB RID: 47051 RVA: 0x00363194 File Offset: 0x00361394
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

	// Token: 0x0600B7CC RID: 47052 RVA: 0x00363220 File Offset: 0x00361420
	protected override void OnStart()
	{
		base.GetItem(1).SetUIActive(false);
		this.LastTimeReconnectState = false;
		this.PingUnChangeValue = CommonConfig.Instance.GetPingUnChangeValue().Value;
	}

	// Token: 0x0600B7CD RID: 47053 RVA: 0x00363259 File Offset: 0x00361459
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnCheckGamePing, new Action<int>(this.OnRefreshPing));
	}

	// Token: 0x0600B7CE RID: 47054 RVA: 0x00363277 File Offset: 0x00361477
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCheckGamePing, new Action<int>(this.OnRefreshPing));
	}

	// Token: 0x0600B7CF RID: 47055 RVA: 0x00363298 File Offset: 0x00361498
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

	// Token: 0x0600B7D0 RID: 47056 RVA: 0x0036337D File Offset: 0x0036157D
	protected override void OnAfterShow()
	{
		this.OnRefreshPing(GamePingModel.Instance.CurrentPing);
	}

	// Token: 0x0600B7D1 RID: 47057 RVA: 0x0036338F File Offset: 0x0036158F
	private void RefreshReconnectAnimation(bool reconnectState)
	{
		if (reconnectState)
		{
			this.UiViewSequence.PlaySequencePurely("Loop", false, false);
			return;
		}
		this.UiViewSequence.StopSequenceByKey("Loop", false, false);
	}

	// Token: 0x0600B7D2 RID: 47058 RVA: 0x003633BC File Offset: 0x003615BC
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

	// Token: 0x0600B7D3 RID: 47059 RVA: 0x0036340D File Offset: 0x0036160D
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

	// Token: 0x0600B7D4 RID: 47060 RVA: 0x00363443 File Offset: 0x00361643
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

	// Token: 0x0600B7D5 RID: 47061 RVA: 0x00363479 File Offset: 0x00361679
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

	// Token: 0x040069F3 RID: 27123
	private const int GOODPING = 100;

	// Token: 0x040069F4 RID: 27124
	private const int MIDDLEPING = 200;

	// Token: 0x040069F5 RID: 27125
	private const int LOOPPING = 500;

	// Token: 0x040069F6 RID: 27126
	private const string BADCOLOR = "FF1F1EFF";

	// Token: 0x040069F7 RID: 27127
	private const string MIDDLECOLOR = "FFD12FFF";

	// Token: 0x040069F8 RID: 27128
	private const string GOODCOLOR = "30D82DFF";

	// Token: 0x040069F9 RID: 27129
	private string LastSpritePath = string.Empty;

	// Token: 0x040069FA RID: 27130
	private bool LastTimeReconnectState;

	// Token: 0x040069FB RID: 27131
	private int LastTimeShowPing = -9999;

	// Token: 0x040069FC RID: 27132
	private int PingUnChangeValue;

	// Token: 0x020074EF RID: 29935
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026080 RID: 155776
		NetStateSprite,
		// Token: 0x04026081 RID: 155777
		ReconnectItem,
		// Token: 0x04026082 RID: 155778
		PingText
	}
}
