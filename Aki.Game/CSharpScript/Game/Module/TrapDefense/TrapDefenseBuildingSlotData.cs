using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A28 RID: 18984
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingSlotData
	{
		// Token: 0x0603149F RID: 201887 RVA: 0x00B6E846 File Offset: 0x00B6CA46
		public static TrapDefenseBuildingSlotData Create(int index)
		{
			return new TrapDefenseBuildingSlotData(index);
		}

		// Token: 0x060314A0 RID: 201888 RVA: 0x00B6E84E File Offset: 0x00B6CA4E
		private TrapDefenseBuildingSlotData(int index)
		{
			this.Index = index;
		}

		// Token: 0x17007A2E RID: 31278
		// (get) Token: 0x060314A1 RID: 201889 RVA: 0x00B6E85D File Offset: 0x00B6CA5D
		public int Index { get; }

		// Token: 0x060314A2 RID: 201890 RVA: 0x00B6E865 File Offset: 0x00B6CA65
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x060314A3 RID: 201891 RVA: 0x00B6E86D File Offset: 0x00B6CA6D
		[NullableContext(2)]
		public TrapDefenseBuildingDevelopItemData GetSlotData()
		{
			return this.SlotData;
		}

		// Token: 0x060314A4 RID: 201892 RVA: 0x00B6E875 File Offset: 0x00B6CA75
		[NullableContext(2)]
		public void InitSlotData(TrapDefenseBuildingDevelopItemData data = null)
		{
			this.Dirty = false;
			this.TmpData = null;
			this.SlotData = data;
		}

		// Token: 0x060314A5 RID: 201893 RVA: 0x00B6E88C File Offset: 0x00B6CA8C
		public bool SetSlotData(TrapDefenseBuildingDevelopItemData data = null, bool fromSlot = false)
		{
			if (!this.CanSetSlot() && data == null && !fromSlot)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Battle_SlotLock", Array.Empty<object>());
				return false;
			}
			if (data != null && !fromSlot && !this.CheckCanSetData(data))
			{
				return false;
			}
			if (data == null)
			{
				TrapDefenseBuildingDevelopItemData slotData = this.SlotData;
				if ((slotData == null || !slotData.IsBuilding) && !fromSlot && !TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckAuxiliarySlot(false))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Battle_AuxiliaryNeed", Array.Empty<object>());
					return false;
				}
			}
			this.TmpData = data;
			this.Dirty = true;
			return true;
		}

		// Token: 0x060314A6 RID: 201894 RVA: 0x00B6E924 File Offset: 0x00B6CB24
		private bool CheckCanSetData(TrapDefenseBuildingDevelopItemData data)
		{
			TrapDefenseBuildingSlotData trapDefenseBuildingSlotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.IsSlotData(data);
			if (trapDefenseBuildingSlotData != null)
			{
				trapDefenseBuildingSlotData.SetSlotData(this.SlotData, true);
				return true;
			}
			bool flag = this.SlotData != null && !this.SlotData.IsBuilding;
			if (!data.IsBuilding && !flag)
			{
				if (!TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckAuxiliarySlot(true))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Battle_AuxiliaryMax", Array.Empty<object>());
					return false;
				}
			}
			else if (data.IsBuilding && flag && !TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckAuxiliarySlot(false))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Battle_AuxiliaryNeed", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x060314A7 RID: 201895 RVA: 0x00B6E9D5 File Offset: 0x00B6CBD5
		public TrapDefenseBuildingDevelopItemData GetUploadData()
		{
			if (!this.Dirty)
			{
				return this.SlotData;
			}
			return this.TmpData;
		}

		// Token: 0x060314A8 RID: 201896 RVA: 0x00B6E9EC File Offset: 0x00B6CBEC
		public void ApplySlotData(bool isSuccess)
		{
			if (this.Dirty && isSuccess)
			{
				this.SlotData = this.TmpData;
			}
			this.TmpData = null;
			this.Dirty = false;
		}

		// Token: 0x060314A9 RID: 201897 RVA: 0x00B6EA13 File Offset: 0x00B6CC13
		private bool CanSetSlot()
		{
			return this.SlotData == null || !this.SlotData.GetLockInBattle();
		}

		// Token: 0x0401A58F RID: 107919
		[Nullable(2)]
		private TrapDefenseBuildingDevelopItemData SlotData;

		// Token: 0x0401A590 RID: 107920
		[Nullable(2)]
		private TrapDefenseBuildingDevelopItemData TmpData;

		// Token: 0x0401A591 RID: 107921
		private bool Dirty;
	}
}
