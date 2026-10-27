using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A7A RID: 10874
public class SoundAreaPlayTips : UiTickViewBase
{
	// Token: 0x06016A40 RID: 92736 RVA: 0x005BC8D3 File Offset: 0x005BAAD3
	[NullableContext(1)]
	public SoundAreaPlayTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016A41 RID: 92737 RVA: 0x005BC8DC File Offset: 0x005BAADC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06016A42 RID: 92738 RVA: 0x005BCA72 File Offset: 0x005BAC72
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SilentTipsRefresh, new Action<int>(this.OnSilentTipsRefresh));
	}

	// Token: 0x06016A43 RID: 92739 RVA: 0x005BCA90 File Offset: 0x005BAC90
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SilentTipsRefresh, new Action<int>(this.OnSilentTipsRefresh));
	}

	// Token: 0x06016A44 RID: 92740 RVA: 0x005BCAAE File Offset: 0x005BACAE
	protected override void OnStart()
	{
		this.SetBuffInfo((int)this.OpenParam);
	}

	// Token: 0x06016A45 RID: 92741 RVA: 0x005BCAC4 File Offset: 0x005BACC4
	public void SetBuffInfo(int buffId)
	{
		SoundAreaPlayInfo value = ConfigSoundAreaPlayInfoById.GetConfig(buffId, true).Value;
		if (value.ShowTitle)
		{
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.BuffTitle, Array.Empty<object>());
		}
		else
		{
			base.GetItem(3).SetUIActive(false);
			base.GetItem(4).SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.BuffDescription, Array.Empty<object>());
		if (value.Time > 0)
		{
			this.CloseTime = TimeUtil.Instance.GetServerTimeStamp() + (double)(value.Time * TimeUtil.Instance.InverseMillisecond);
		}
		if (value.MaxCount > 0)
		{
			SoundAreaPlayTipsModel.Instance.AddShowInfoIdCount(value.Id);
		}
	}

	// Token: 0x06016A46 RID: 92742 RVA: 0x005BCBA3 File Offset: 0x005BADA3
	protected override void OnTick(float delta)
	{
		if (this.CloseTime > 0.0 && TimeUtil.Instance.GetServerTimeStamp() > this.CloseTime)
		{
			base.CloseMe(null);
			this.CloseTime = 0.0;
		}
	}

	// Token: 0x06016A47 RID: 92743 RVA: 0x005BCBDE File Offset: 0x005BADDE
	protected override void OnAfterPlayStartSequence()
	{
		if (this.CloseTime == 0.0)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06016A48 RID: 92744 RVA: 0x005BCBF8 File Offset: 0x005BADF8
	private void OnSilentTipsRefresh(int configId)
	{
		this.SetBuffInfo(configId);
	}

	// Token: 0x0400A816 RID: 43030
	private double CloseTime;

	// Token: 0x020090A6 RID: 37030
	private enum EChildType
	{
		// Token: 0x0402EDED RID: 191981
		TitleText = 1,
		// Token: 0x0402EDEE RID: 191982
		DesText,
		// Token: 0x0402EDEF RID: 191983
		PanelHaveTitle,
		// Token: 0x0402EDF0 RID: 191984
		PanelNoTitle,
		// Token: 0x0402EDF1 RID: 191985
		ItemTagNew,
		// Token: 0x0402EDF2 RID: 191986
		SpriteTagBg,
		// Token: 0x0402EDF3 RID: 191987
		PanelClockIcon,
		// Token: 0x0402EDF4 RID: 191988
		TxtNew,
		// Token: 0x0402EDF5 RID: 191989
		ItemCheck,
		// Token: 0x0402EDF6 RID: 191990
		ItemInvalid,
		// Token: 0x0402EDF7 RID: 191991
		ItemInvalidLine
	}
}
