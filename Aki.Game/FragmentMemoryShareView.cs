using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010DE RID: 4318
public class FragmentMemoryShareView : UiPanelBase
{
	// Token: 0x0600AC43 RID: 44099 RVA: 0x0032B854 File Offset: 0x00329A54
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

	// Token: 0x0600AC44 RID: 44100 RVA: 0x0032B8FF File Offset: 0x00329AFF
	protected override void OnStart()
	{
		this.RefreshView();
	}

	// Token: 0x0600AC45 RID: 44101 RVA: 0x0032B907 File Offset: 0x00329B07
	private void RefreshView()
	{
		this.CurrentData = (this.OpenParam as FragmentMemoryCollectData);
		this.RefreshTexture();
		this.RefreshName();
		this.RefreshDesc();
		this.RefreshTime();
	}

	// Token: 0x0600AC46 RID: 44102 RVA: 0x0032B932 File Offset: 0x00329B32
	private void RefreshTime()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "FragmentMemoryCollectTime", new <>z__ReadOnlySingleElementList<object>(this.CurrentData.GetTimeText()));
	}

	// Token: 0x0600AC47 RID: 44103 RVA: 0x0032B95C File Offset: 0x00329B5C
	private void RefreshTexture()
	{
		base.SetTextureByPath(this.CurrentData.GetBgResource(), base.GetTexture(0), null, null);
	}

	// Token: 0x0600AC48 RID: 44104 RVA: 0x0032B98B File Offset: 0x00329B8B
	private void RefreshName()
	{
		base.GetText(1).ShowTextNew(this.CurrentData.GetTitle());
	}

	// Token: 0x0600AC49 RID: 44105 RVA: 0x0032B9A4 File Offset: 0x00329BA4
	private void RefreshDesc()
	{
		base.GetText(3).ShowTextNew(this.CurrentData.GetDesc());
	}

	// Token: 0x04006366 RID: 25446
	[Nullable(2)]
	private FragmentMemoryCollectData CurrentData;

	// Token: 0x02007361 RID: 29537
	private class EComponents
	{
		// Token: 0x0402592F RID: 153903
		public const int Texture = 0;

		// Token: 0x04025930 RID: 153904
		public const int Name = 1;

		// Token: 0x04025931 RID: 153905
		public const int Time = 2;

		// Token: 0x04025932 RID: 153906
		public const int Desc = 3;
	}
}
