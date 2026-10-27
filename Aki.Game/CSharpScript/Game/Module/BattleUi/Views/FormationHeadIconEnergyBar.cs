using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D33 RID: 23859
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationHeadIconEnergyBar
	{
		// Token: 0x0603C825 RID: 247845 RVA: 0x00E844B0 File Offset: 0x00E826B0
		public void InitParentItem(int index, UUIItem parentItem)
		{
			if (index >= this.ParentItemList.Length)
			{
				UUIItem[] array = new UUIItem[index + 1];
				for (int i = 0; i < this.ParentItemList.Length; i++)
				{
					array[i] = this.ParentItemList[i];
				}
				this.ParentItemList = array;
			}
			this.ParentItemList[index] = parentItem;
		}

		// Token: 0x0603C826 RID: 247846 RVA: 0x00E84500 File Offset: 0x00E82700
		public void RemoveEntity(int entityId)
		{
			HeadIconEnergyBarBase headIconEnergyBarBase;
			if (this.EnergyBarMap.Remove(entityId, out headIconEnergyBarBase))
			{
				headIconEnergyBarBase.Destroy(null);
				return;
			}
			this.DisableEntityIdSet.Remove(entityId);
		}

		// Token: 0x0603C827 RID: 247847 RVA: 0x00E84534 File Offset: 0x00E82734
		public void InitData(int position, FormationItemData formationItemData, [Nullable(2)] BattleUiRoleData roleData, int parentItemIndex)
		{
			int? num;
			if (roleData == null)
			{
				num = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				num = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			}
			int? num2 = num;
			if (num2 == null)
			{
				return;
			}
			if (this.DisableEntityIdSet.Contains(num2.Value))
			{
				return;
			}
			if (this.EnergyBarMap.ContainsKey(num2.Value))
			{
				this.RefreshVisible(num2.Value, roleData.IsCurEntity, parentItemIndex);
				return;
			}
			HeadIconEnergyBar? headIconEnergyBarConfig = roleData.HeadIconEnergyBarConfig;
			if (headIconEnergyBarConfig == null)
			{
				this.DisableEntityIdSet.Add(num2.Value);
				return;
			}
			int playerId = formationItemData.PlayerId;
			int? id = PlayerInfoModel.Instance.GetId();
			bool flag = playerId == id.GetValueOrDefault() & id != null;
			if (!headIconEnergyBarConfig.Value.FormationVisible && !flag)
			{
				this.DisableEntityIdSet.Add(num2.Value);
				return;
			}
			UUIItem parentItem = (parentItemIndex >= 0) ? this.ParentItemList[parentItemIndex] : this.ParentItemList[0];
			this.LoadByConfig(parentItem, roleData, num2.Value, headIconEnergyBarConfig.Value);
			this.RefreshVisible(num2.Value, roleData.IsCurEntity, -1);
		}

		// Token: 0x0603C828 RID: 247848 RVA: 0x00E84670 File Offset: 0x00E82870
		public void RefreshVisible(int entityId, bool isCurEntity, int parentItemIndex = -1)
		{
			if (entityId == 0)
			{
				return;
			}
			HeadIconEnergyBarBase valueOrDefault = this.EnergyBarMap.GetValueOrDefault(entityId);
			if (valueOrDefault != null)
			{
				if (isCurEntity)
				{
					valueOrDefault.SetVisible(false, 1);
					return;
				}
				valueOrDefault.SetVisible(true, 1);
				if (parentItemIndex >= 0)
				{
					UUIItem valueOrDefault2 = this.ParentItemList.GetValueOrDefault(parentItemIndex);
					if (valueOrDefault2 != null)
					{
						valueOrDefault.ChangeParent(valueOrDefault2);
					}
				}
			}
		}

		// Token: 0x0603C829 RID: 247849 RVA: 0x00E846C0 File Offset: 0x00E828C0
		public void Destroy()
		{
			foreach (HeadIconEnergyBarBase headIconEnergyBarBase in this.EnergyBarMap.Values)
			{
				headIconEnergyBarBase.Destroy(null);
			}
			this.EnergyBarMap.Clear();
			this.DisableEntityIdSet.Clear();
		}

		// Token: 0x0603C82A RID: 247850 RVA: 0x00E8472C File Offset: 0x00E8292C
		public void Tick(float delta)
		{
			foreach (HeadIconEnergyBarBase headIconEnergyBarBase in this.EnergyBarMap.Values)
			{
				headIconEnergyBarBase.Tick(delta);
			}
		}

		// Token: 0x0603C82B RID: 247851 RVA: 0x00E84784 File Offset: 0x00E82984
		private void LoadByConfig(UUIItem parentItem, BattleUiRoleData roleData, int entityId, HeadIconEnergyBar config)
		{
			Func<HeadIconEnergyBarBase> func;
			HeadIconEnergyBarBase headIconEnergyBarBase = FormationHeadIconEnergyBar.EnergyBarClassMap.TryGetValue(config.Type, out func) ? func() : new HeadIconEnergyBarCommon();
			headIconEnergyBarBase.InitData(roleData, config);
			this.EnergyBarMap[entityId] = headIconEnergyBarBase;
			headIconEnergyBarBase.InitByPath(parentItem, config.PrefabPath);
			headIconEnergyBarBase.SetVisible(true, 0);
		}

		// Token: 0x0603C82D RID: 247853 RVA: 0x00E8480C File Offset: 0x00E82A0C
		// Note: this type is marked as 'beforefieldinit'.
		static FormationHeadIconEnergyBar()
		{
			Dictionary<int, Func<HeadIconEnergyBarBase>> dictionary = new Dictionary<int, Func<HeadIconEnergyBarBase>>();
			dictionary[0] = (() => new HeadIconEnergyBarCommon());
			dictionary[1] = (() => new HeadIconEnergyBarFuLuoLuo());
			dictionary[2] = (() => new HeadIconEnergyBarJiaBeiLiNa());
			dictionary[3] = (() => new HeadIconEnergyBarDaniya());
			dictionary[4] = (() => new HeadIconEnergyBarXigelika());
			dictionary[5] = (() => new HeadIconEnergyBarRuibeika());
			dictionary[6] = (() => new HeadIconEnergyBarSuisui());
			FormationHeadIconEnergyBar.EnergyBarClassMap = dictionary;
		}

		// Token: 0x0401F868 RID: 129128
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Func<HeadIconEnergyBarBase>> EnergyBarClassMap;

		// Token: 0x0401F869 RID: 129129
		private UUIItem[] ParentItemList = Array.Empty<UUIItem>();

		// Token: 0x0401F86A RID: 129130
		private readonly Dictionary<int, HeadIconEnergyBarBase> EnergyBarMap = new Dictionary<int, HeadIconEnergyBarBase>();

		// Token: 0x0401F86B RID: 129131
		private readonly HashSet<int> DisableEntityIdSet = new HashSet<int>();

		// Token: 0x0200BFCC RID: 49100
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04039DCB RID: 237003
			Default,
			// Token: 0x04039DCC RID: 237004
			RoleForeground
		}

		// Token: 0x0200BFCD RID: 49101
		[NullableContext(0)]
		private enum EHeadIconEnergyBarType
		{
			// Token: 0x04039DCE RID: 237006
			Common,
			// Token: 0x04039DCF RID: 237007
			FuLuoLuo,
			// Token: 0x04039DD0 RID: 237008
			JiaBeiLiNa,
			// Token: 0x04039DD1 RID: 237009
			Daniya,
			// Token: 0x04039DD2 RID: 237010
			Xigelika,
			// Token: 0x04039DD3 RID: 237011
			Ruibeika,
			// Token: 0x04039DD4 RID: 237012
			Suisui
		}
	}
}
