using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002164 RID: 8548
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailInformationItem : UiPanelBase
{
	// Token: 0x06014FC4 RID: 85956 RVA: 0x0061D0EC File Offset: 0x0061B2EC
	public TowerDetailInformationItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06014FC5 RID: 85957 RVA: 0x0061D104 File Offset: 0x0061B304
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014FC6 RID: 85958 RVA: 0x0061D1AF File Offset: 0x0061B3AF
	protected override void OnStart()
	{
		this.BuffItem = new TowerDetailInformationBuffItem(base.GetItem(1));
		this.MonsterItem = new TowerDetailInformationMonsterItem(base.GetItem(2));
	}

	// Token: 0x06014FC7 RID: 85959 RVA: 0x0061D1D5 File Offset: 0x0061B3D5
	private void HideAllView()
	{
		base.GetItem(1).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x06014FC8 RID: 85960 RVA: 0x0061D1F4 File Offset: 0x0061B3F4
	public void Update(TowerInformationData data)
	{
		this.HideAllView();
		if (data.Type == ETowerDetailInformationType.Buff)
		{
			base.GetItem(1).SetUIActive(true);
			this.BuffItem.Update(data.TowerDetailBuffData);
		}
		else
		{
			base.GetItem(2).SetUIActive(true);
			this.MonsterItem.Update(data.MonsterData, data.Type);
		}
		this.RefreshAttributeText(data);
		this.RefreshAttributeItem(data.Type);
	}

	// Token: 0x06014FC9 RID: 85961 RVA: 0x0061D266 File Offset: 0x0061B466
	protected override void OnBeforeDestroy()
	{
		this.MonsterItem.Destroy(null);
		this.MonsterItem = null;
		this.BuffItem.Destroy(null);
		this.BuffItem = null;
	}

	// Token: 0x06014FCA RID: 85962 RVA: 0x0061D28E File Offset: 0x0061B48E
	private void RefreshAttributeText(TowerInformationData data)
	{
		base.GetText(0).SetText(data.Title, true);
	}

	// Token: 0x06014FCB RID: 85963 RVA: 0x0061D2A4 File Offset: 0x0061B4A4
	private void RefreshAttributeItem(ETowerDetailInformationType type)
	{
		bool uiactive = false;
		if (type == ETowerDetailInformationType.Buff || type == ETowerDetailInformationType.Monster)
		{
			uiactive = true;
		}
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0400B2C9 RID: 45769
	[Nullable(2)]
	private TowerDetailInformationBuffItem BuffItem;

	// Token: 0x0400B2CA RID: 45770
	[Nullable(2)]
	private TowerDetailInformationMonsterItem MonsterItem;

	// Token: 0x020083E9 RID: 33769
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402A908 RID: 174344
		public const int AttirbuteText = 0;

		// Token: 0x0402A909 RID: 174345
		public const int BuffItem = 1;

		// Token: 0x0402A90A RID: 174346
		public const int MonsterItem = 2;

		// Token: 0x0402A90B RID: 174347
		public const int AttributeItem = 3;
	}
}
