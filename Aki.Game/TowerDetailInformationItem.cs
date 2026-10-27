using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BE9 RID: 11241
[NullableContext(1)]
[Nullable(0)]
public class TowerDetailInformationItem : UiPanelBase
{
	// Token: 0x06017593 RID: 95635 RVA: 0x005F058C File Offset: 0x005EE78C
	public TowerDetailInformationItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06017594 RID: 95636 RVA: 0x005F05A4 File Offset: 0x005EE7A4
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

	// Token: 0x06017595 RID: 95637 RVA: 0x005F064F File Offset: 0x005EE84F
	protected override void OnStart()
	{
		this.BuffItem = new TowerDetailInformationBuffItem(base.GetItem(1));
		this.MonsterItem = new TowerDetailInformationMonsterItem(base.GetItem(2));
	}

	// Token: 0x06017596 RID: 95638 RVA: 0x005F0675 File Offset: 0x005EE875
	private void HideAllView()
	{
		base.GetItem(1).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x06017597 RID: 95639 RVA: 0x005F0694 File Offset: 0x005EE894
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

	// Token: 0x06017598 RID: 95640 RVA: 0x005F0706 File Offset: 0x005EE906
	protected override void OnBeforeDestroy()
	{
		this.MonsterItem.Destroy(null);
		this.MonsterItem = null;
		this.BuffItem.Destroy(null);
		this.BuffItem = null;
	}

	// Token: 0x06017599 RID: 95641 RVA: 0x005F072E File Offset: 0x005EE92E
	private void RefreshAttributeText(TowerInformationData data)
	{
		base.GetText(0).SetText(data.Title, true);
	}

	// Token: 0x0601759A RID: 95642 RVA: 0x005F0744 File Offset: 0x005EE944
	private void RefreshAttributeItem(ETowerDetailInformationType type)
	{
		bool uiactive = false;
		if (type == ETowerDetailInformationType.Buff || type == ETowerDetailInformationType.Monster)
		{
			uiactive = true;
		}
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x0400AEC4 RID: 44740
	[Nullable(2)]
	private TowerDetailInformationBuffItem BuffItem;

	// Token: 0x0400AEC5 RID: 44741
	[Nullable(2)]
	private TowerDetailInformationMonsterItem MonsterItem;

	// Token: 0x020091A6 RID: 37286
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F207 RID: 193031
		public const int AttirbuteText = 0;

		// Token: 0x0402F208 RID: 193032
		public const int BuffItem = 1;

		// Token: 0x0402F209 RID: 193033
		public const int MonsterItem = 2;

		// Token: 0x0402F20A RID: 193034
		public const int AttributeItem = 3;
	}
}
