using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FF6 RID: 8182
public class SoundAreaPlayTips : UiTickViewBase
{
	// Token: 0x06014465 RID: 83045 RVA: 0x005E8B01 File Offset: 0x005E6D01
	[NullableContext(1)]
	public SoundAreaPlayTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014466 RID: 83046 RVA: 0x005E8B0C File Offset: 0x005E6D0C
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

	// Token: 0x06014467 RID: 83047 RVA: 0x005E8CA2 File Offset: 0x005E6EA2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SilentTipsRefresh, new Action<int>(this.OnSilentTipsRefresh));
	}

	// Token: 0x06014468 RID: 83048 RVA: 0x005E8CC0 File Offset: 0x005E6EC0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SilentTipsRefresh, new Action<int>(this.OnSilentTipsRefresh));
	}

	// Token: 0x06014469 RID: 83049 RVA: 0x005E8CDE File Offset: 0x005E6EDE
	protected override void OnStart()
	{
		this.SetBuffInfo((int)this.OpenParam);
	}

	// Token: 0x0601446A RID: 83050 RVA: 0x005E8CF4 File Offset: 0x005E6EF4
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

	// Token: 0x0601446B RID: 83051 RVA: 0x005E8DD3 File Offset: 0x005E6FD3
	protected override void OnTick(float delta)
	{
		if (this.CloseTime > 0.0 && TimeUtil.Instance.GetServerTimeStamp() > this.CloseTime)
		{
			base.CloseMe(null);
			this.CloseTime = 0.0;
		}
	}

	// Token: 0x0601446C RID: 83052 RVA: 0x005E8E0E File Offset: 0x005E700E
	protected override void OnAfterPlayStartSequence()
	{
		if (this.CloseTime == 0.0)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0601446D RID: 83053 RVA: 0x005E8E28 File Offset: 0x005E7028
	private void OnSilentTipsRefresh(int configId)
	{
		this.SetBuffInfo(configId);
	}

	// Token: 0x0400AC1B RID: 44059
	private double CloseTime;

	// Token: 0x020082ED RID: 33517
	private enum EChildType
	{
		// Token: 0x0402A4E7 RID: 173287
		TitleText = 1,
		// Token: 0x0402A4E8 RID: 173288
		DesText,
		// Token: 0x0402A4E9 RID: 173289
		PanelHaveTitle,
		// Token: 0x0402A4EA RID: 173290
		PanelNoTitle,
		// Token: 0x0402A4EB RID: 173291
		ItemTagNew,
		// Token: 0x0402A4EC RID: 173292
		SpriteTagBg,
		// Token: 0x0402A4ED RID: 173293
		PanelClockIcon,
		// Token: 0x0402A4EE RID: 173294
		TxtNew,
		// Token: 0x0402A4EF RID: 173295
		ItemCheck,
		// Token: 0x0402A4F0 RID: 173296
		ItemInvalid,
		// Token: 0x0402A4F1 RID: 173297
		ItemInvalidLine
	}
}
