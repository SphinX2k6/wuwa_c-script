using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039D0 RID: 14800
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingSlotData
	{
		// Token: 0x0602622F RID: 156207 RVA: 0x00AB27EA File Offset: 0x00AB09EA
		public static TrapDefenseBuildingSlotData Create(int index)
		{
			return new TrapDefenseBuildingSlotData(index);
		}

		// Token: 0x06026230 RID: 156208 RVA: 0x00AB27F2 File Offset: 0x00AB09F2
		private TrapDefenseBuildingSlotData(int index)
		{
			this.Index = index;
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x06026231 RID: 156209 RVA: 0x00AB2801 File Offset: 0x00AB0A01
		public int Index { get; }

		// Token: 0x06026232 RID: 156210 RVA: 0x00AB2809 File Offset: 0x00AB0A09
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x06026233 RID: 156211 RVA: 0x00AB2811 File Offset: 0x00AB0A11
		[NullableContext(2)]
		public TrapDefenseBuildingDevelopItemData GetSlotData()
		{
			return this.SlotData;
		}

		// Token: 0x06026234 RID: 156212 RVA: 0x00AB2819 File Offset: 0x00AB0A19
		[NullableContext(2)]
		public void InitSlotData(TrapDefenseBuildingDevelopItemData data = null)
		{
			this.Dirty = false;
			this.TmpData = null;
			this.SlotData = data;
		}

		// Token: 0x06026235 RID: 156213 RVA: 0x00AB2830 File Offset: 0x00AB0A30
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

		// Token: 0x06026236 RID: 156214 RVA: 0x00AB28C8 File Offset: 0x00AB0AC8
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

		// Token: 0x06026237 RID: 156215 RVA: 0x00AB2979 File Offset: 0x00AB0B79
		public TrapDefenseBuildingDevelopItemData GetUploadData()
		{
			if (!this.Dirty)
			{
				return this.SlotData;
			}
			return this.TmpData;
		}

		// Token: 0x06026238 RID: 156216 RVA: 0x00AB2990 File Offset: 0x00AB0B90
		public void ApplySlotData(bool isSuccess)
		{
			if (this.Dirty && isSuccess)
			{
				this.SlotData = this.TmpData;
			}
			this.TmpData = null;
			this.Dirty = false;
		}

		// Token: 0x06026239 RID: 156217 RVA: 0x00AB29B7 File Offset: 0x00AB0BB7
		private bool CanSetSlot()
		{
			return this.SlotData == null || !this.SlotData.GetLockInBattle();
		}

		// Token: 0x04014EE6 RID: 85734
		[Nullable(2)]
		private TrapDefenseBuildingDevelopItemData SlotData;

		// Token: 0x04014EE7 RID: 85735
		[Nullable(2)]
		private TrapDefenseBuildingDevelopItemData TmpData;

		// Token: 0x04014EE8 RID: 85736
		private bool Dirty;
	}
}
