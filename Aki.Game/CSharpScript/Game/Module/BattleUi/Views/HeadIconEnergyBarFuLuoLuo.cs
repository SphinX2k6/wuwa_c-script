using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D19 RID: 19737
	[NullableContext(1)]
	[Nullable(0)]
	public class HeadIconEnergyBarFuLuoLuo : HeadIconEnergyBarBase
	{
		// Token: 0x060317B7 RID: 202679 RVA: 0x00DD5B04 File Offset: 0x00DD3D04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060317B8 RID: 202680 RVA: 0x00DD5BF4 File Offset: 0x00DD3DF4
		protected override UniTask OnBeforeStartAsync()
		{
			HeadIconEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HeadIconEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060317B9 RID: 202681 RVA: 0x00DD5C37 File Offset: 0x00DD3E37
		protected override void OnStart()
		{
		}

		// Token: 0x060317BA RID: 202682 RVA: 0x00DD5C39 File Offset: 0x00DD3E39
		public override void Tick(float delta)
		{
		}

		// Token: 0x060317BB RID: 202683 RVA: 0x00DD5C3B File Offset: 0x00DD3E3B
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetBurstState(tagComponent != null && tagComponent.HasTag(HeadIconEnergyBarFuLuoLuo.BurstTag));
			this.RefreshAttribute();
			this.RefreshEnergy();
		}

		// Token: 0x060317BC RID: 202684 RVA: 0x00DD5C6C File Offset: 0x00DD3E6C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(HeadIconEnergyBarFuLuoLuo.BurstTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBurstTagChange));
		}

		// Token: 0x060317BD RID: 202685 RVA: 0x00DD5C8B File Offset: 0x00DD3E8B
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenTagAddOrRemove(HeadIconEnergyBarFuLuoLuo.BurstTag);
		}

		// Token: 0x060317BE RID: 202686 RVA: 0x00DD5C9E File Offset: 0x00DD3E9E
		private void OnBurstTagChange(int tagId, bool tagExist)
		{
			this.SetBurstState(tagExist);
			this.RefreshEnergy();
		}

		// Token: 0x060317BF RID: 202687 RVA: 0x00DD5CAD File Offset: 0x00DD3EAD
		protected override void OnAttributeChanged()
		{
			this.RefreshAttribute();
			this.RefreshEnergy();
		}

		// Token: 0x060317C0 RID: 202688 RVA: 0x00DD5CBC File Offset: 0x00DD3EBC
		private void RefreshAttribute()
		{
			double num = (double)this.AttributeComponent.GetCurrentValue(this.AttributeId);
			if (num == this.AttributeValue)
			{
				return;
			}
			this.AttributeValue = num;
			this.DirtyMark = true;
		}

		// Token: 0x060317C1 RID: 202689 RVA: 0x00DD5CF4 File Offset: 0x00DD3EF4
		private void SetBurstState(bool state)
		{
			if (this.BurstState == state)
			{
				return;
			}
			this.BurstState = state;
			this.DirtyMark = true;
		}

		// Token: 0x060317C2 RID: 202690 RVA: 0x00DD5D0E File Offset: 0x00DD3F0E
		private void RefreshEnergy()
		{
			if (!this.DirtyMark)
			{
				return;
			}
			this.RefreshAllNoteItemEnergyType();
			this.DirtyMark = false;
		}

		// Token: 0x060317C3 RID: 202691 RVA: 0x00DD5D28 File Offset: 0x00DD3F28
		private void RefreshAllNoteItemEnergyType()
		{
			int num = 0;
			for (int i = 0; i < 6; i++)
			{
				int num2 = (6 - i - 1) * 2;
				int num3 = ((int)this.AttributeValue & 3 << num2) >> num2;
				if (this.BurstState || num3 > 0)
				{
					this.SpecialEnergyTypeList[num] = num3;
					num++;
				}
			}
			for (int j = 0; j < this.NoteItemList.Length; j++)
			{
				HeadIconEnergyBarFuLuoLuoNoteItem headIconEnergyBarFuLuoLuoNoteItem = this.NoteItemList[j];
				int energyType = (j < num) ? this.SpecialEnergyTypeList[j] : 0;
				headIconEnergyBarFuLuoLuoNoteItem.SetEnergyType(energyType);
			}
		}

		// Token: 0x0401A339 RID: 107321
		private const int SPECIAL_ENERGY_COUNT = 6;

		// Token: 0x0401A33A RID: 107322
		private static readonly int BurstTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.大招状态"];

		// Token: 0x0401A33B RID: 107323
		private const string NOTE_ITEM_PATH = "/Game/Aki/UI/UIResources/UiFight/Prefabs/EnergyBar/UiItem_BarFuLuoLuoAPoint.UiItem_BarFuLuoLuoAPoint";

		// Token: 0x0401A33C RID: 107324
		private readonly UUIItem[] SlotItemList = new UUIItem[6];

		// Token: 0x0401A33D RID: 107325
		private readonly HeadIconEnergyBarFuLuoLuoNoteItem[] NoteItemList = new HeadIconEnergyBarFuLuoLuoNoteItem[6];

		// Token: 0x0401A33E RID: 107326
		private readonly int[] SpecialEnergyTypeList = new int[6];

		// Token: 0x0401A33F RID: 107327
		private double AttributeValue;

		// Token: 0x0401A340 RID: 107328
		private bool BurstState;

		// Token: 0x0401A341 RID: 107329
		private bool DirtyMark;

		// Token: 0x0200A9D8 RID: 43480
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040347AE RID: 214958
			SlotItem1,
			// Token: 0x040347AF RID: 214959
			SlotItem2,
			// Token: 0x040347B0 RID: 214960
			SlotItem3,
			// Token: 0x040347B1 RID: 214961
			SlotItem4,
			// Token: 0x040347B2 RID: 214962
			SlotItem5,
			// Token: 0x040347B3 RID: 214963
			SlotItem6
		}
	}
}
