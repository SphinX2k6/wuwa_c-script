using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C1F RID: 7199
public class FragmentMemoryShareView : UiPanelBase
{
	// Token: 0x0600D82D RID: 55341 RVA: 0x0032047C File Offset: 0x0031E67C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D82E RID: 55342 RVA: 0x00320527 File Offset: 0x0031E727
	protected override void OnStart()
	{
		this.RefreshView();
	}

	// Token: 0x0600D82F RID: 55343 RVA: 0x0032052F File Offset: 0x0031E72F
	private void RefreshView()
	{
		this.CurrentData = (this.OpenParam as FragmentMemoryCollectData);
		this.RefreshTexture();
		this.RefreshName();
		this.RefreshDesc();
		this.RefreshTime();
	}

	// Token: 0x0600D830 RID: 55344 RVA: 0x0032055A File Offset: 0x0031E75A
	private void RefreshTime()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "FragmentMemoryCollectTime", new <>z__ReadOnlySingleElementList<object>(this.CurrentData.GetTimeText()));
	}

	// Token: 0x0600D831 RID: 55345 RVA: 0x00320584 File Offset: 0x0031E784
	private void RefreshTexture()
	{
		base.SetTextureByPath(this.CurrentData.GetBgResource(), base.GetTexture(0), null, null);
	}

	// Token: 0x0600D832 RID: 55346 RVA: 0x003205B3 File Offset: 0x0031E7B3
	private void RefreshName()
	{
		base.GetText(1).ShowTextNew(this.CurrentData.GetTitle());
	}

	// Token: 0x0600D833 RID: 55347 RVA: 0x003205CC File Offset: 0x0031E7CC
	private void RefreshDesc()
	{
		base.GetText(3).ShowTextNew(this.CurrentData.GetDesc());
	}

	// Token: 0x04006294 RID: 25236
	[Nullable(2)]
	private FragmentMemoryCollectData CurrentData;

	// Token: 0x020081D8 RID: 33240
	private class EComponents
	{
		// Token: 0x0402A608 RID: 173576
		public const int Texture = 0;

		// Token: 0x0402A609 RID: 173577
		public const int Name = 1;

		// Token: 0x0402A60A RID: 173578
		public const int Time = 2;

		// Token: 0x0402A60B RID: 173579
		public const int Desc = 3;
	}
}
