using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D37 RID: 23863
	[NullableContext(1)]
	[Nullable(0)]
	public class HeadIconEnergyBarFuLuoLuo : HeadIconEnergyBarBase
	{
		// Token: 0x0603C85E RID: 247902 RVA: 0x00E85364 File Offset: 0x00E83564
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

		// Token: 0x0603C85F RID: 247903 RVA: 0x00E85454 File Offset: 0x00E83654
		protected override UniTask OnBeforeStartAsync()
		{
			HeadIconEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HeadIconEnergyBarFuLuoLuo.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C860 RID: 247904 RVA: 0x00E85497 File Offset: 0x00E83697
		protected override void OnStart()
		{
		}

		// Token: 0x0603C861 RID: 247905 RVA: 0x00E85499 File Offset: 0x00E83699
		public override void Tick(float delta)
		{
		}

		// Token: 0x0603C862 RID: 247906 RVA: 0x00E8549B File Offset: 0x00E8369B
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetBurstState(tagComponent != null && tagComponent.HasTag(HeadIconEnergyBarFuLuoLuo.BurstTag));
			this.RefreshAttribute();
			this.RefreshEnergy();
		}

		// Token: 0x0603C863 RID: 247907 RVA: 0x00E854CC File Offset: 0x00E836CC
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(HeadIconEnergyBarFuLuoLuo.BurstTag, new BaseTagComponent.TTagSwitchedCallback(this.OnBurstTagChange));
		}

		// Token: 0x0603C864 RID: 247908 RVA: 0x00E854EB File Offset: 0x00E836EB
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenTagAddOrRemove(HeadIconEnergyBarFuLuoLuo.BurstTag);
		}

		// Token: 0x0603C865 RID: 247909 RVA: 0x00E854FE File Offset: 0x00E836FE
		private void OnBurstTagChange(int tagId, bool tagExist)
		{
			this.SetBurstState(tagExist);
			this.RefreshEnergy();
		}

		// Token: 0x0603C866 RID: 247910 RVA: 0x00E8550D File Offset: 0x00E8370D
		protected override void OnAttributeChanged()
		{
			this.RefreshAttribute();
			this.RefreshEnergy();
		}

		// Token: 0x0603C867 RID: 247911 RVA: 0x00E8551C File Offset: 0x00E8371C
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

		// Token: 0x0603C868 RID: 247912 RVA: 0x00E85554 File Offset: 0x00E83754
		private void SetBurstState(bool state)
		{
			if (this.BurstState == state)
			{
				return;
			}
			this.BurstState = state;
			this.DirtyMark = true;
		}

		// Token: 0x0603C869 RID: 247913 RVA: 0x00E8556E File Offset: 0x00E8376E
		private void RefreshEnergy()
		{
			if (!this.DirtyMark)
			{
				return;
			}
			this.RefreshAllNoteItemEnergyType();
			this.DirtyMark = false;
		}

		// Token: 0x0603C86A RID: 247914 RVA: 0x00E85588 File Offset: 0x00E83788
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

		// Token: 0x0401F880 RID: 129152
		private const int SPECIAL_ENERGY_COUNT = 6;

		// Token: 0x0401F881 RID: 129153
		private static readonly int BurstTag = GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.大招状态"];

		// Token: 0x0401F882 RID: 129154
		private const string NOTE_ITEM_PATH = "/Game/Aki/UI/UIResources/UiFight/Prefabs/EnergyBar/UiItem_BarFuLuoLuoAPoint.UiItem_BarFuLuoLuoAPoint";

		// Token: 0x0401F883 RID: 129155
		private readonly UUIItem[] SlotItemList = new UUIItem[6];

		// Token: 0x0401F884 RID: 129156
		private readonly HeadIconEnergyBarFuLuoLuoNoteItem[] NoteItemList = new HeadIconEnergyBarFuLuoLuoNoteItem[6];

		// Token: 0x0401F885 RID: 129157
		private readonly int[] SpecialEnergyTypeList = new int[6];

		// Token: 0x0401F886 RID: 129158
		private double AttributeValue;

		// Token: 0x0401F887 RID: 129159
		private bool BurstState;

		// Token: 0x0401F888 RID: 129160
		private bool DirtyMark;

		// Token: 0x0200BFD2 RID: 49106
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039DEC RID: 237036
			SlotItem1,
			// Token: 0x04039DED RID: 237037
			SlotItem2,
			// Token: 0x04039DEE RID: 237038
			SlotItem3,
			// Token: 0x04039DEF RID: 237039
			SlotItem4,
			// Token: 0x04039DF0 RID: 237040
			SlotItem5,
			// Token: 0x04039DF1 RID: 237041
			SlotItem6
		}
	}
}
