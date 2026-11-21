using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D15 RID: 19733
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationHeadIconEnergyBar
	{
		// Token: 0x0603177E RID: 202622 RVA: 0x00DD4C50 File Offset: 0x00DD2E50
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

		// Token: 0x0603177F RID: 202623 RVA: 0x00DD4CA0 File Offset: 0x00DD2EA0
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

		// Token: 0x06031780 RID: 202624 RVA: 0x00DD4CD4 File Offset: 0x00DD2ED4
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

		// Token: 0x06031781 RID: 202625 RVA: 0x00DD4E10 File Offset: 0x00DD3010
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

		// Token: 0x06031782 RID: 202626 RVA: 0x00DD4E60 File Offset: 0x00DD3060
		public void Destroy()
		{
			foreach (HeadIconEnergyBarBase headIconEnergyBarBase in this.EnergyBarMap.Values)
			{
				headIconEnergyBarBase.Destroy(null);
			}
			this.EnergyBarMap.Clear();
			this.DisableEntityIdSet.Clear();
		}

		// Token: 0x06031783 RID: 202627 RVA: 0x00DD4ECC File Offset: 0x00DD30CC
		public void Tick(float delta)
		{
			foreach (HeadIconEnergyBarBase headIconEnergyBarBase in this.EnergyBarMap.Values)
			{
				headIconEnergyBarBase.Tick(delta);
			}
		}

		// Token: 0x06031784 RID: 202628 RVA: 0x00DD4F24 File Offset: 0x00DD3124
		private void LoadByConfig(UUIItem parentItem, BattleUiRoleData roleData, int entityId, HeadIconEnergyBar config)
		{
			Func<HeadIconEnergyBarBase> func;
			HeadIconEnergyBarBase headIconEnergyBarBase = FormationHeadIconEnergyBar.EnergyBarClassMap.TryGetValue(config.Type, out func) ? func() : new HeadIconEnergyBarCommon();
			headIconEnergyBarBase.InitData(roleData, config);
			this.EnergyBarMap[entityId] = headIconEnergyBarBase;
			headIconEnergyBarBase.InitByPath(parentItem, config.PrefabPath);
			headIconEnergyBarBase.SetVisible(true, 0);
		}

		// Token: 0x06031786 RID: 202630 RVA: 0x00DD4FAC File Offset: 0x00DD31AC
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

		// Token: 0x0401A321 RID: 107297
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Func<HeadIconEnergyBarBase>> EnergyBarClassMap;

		// Token: 0x0401A322 RID: 107298
		private UUIItem[] ParentItemList = Array.Empty<UUIItem>();

		// Token: 0x0401A323 RID: 107299
		private readonly Dictionary<int, HeadIconEnergyBarBase> EnergyBarMap = new Dictionary<int, HeadIconEnergyBarBase>();

		// Token: 0x0401A324 RID: 107300
		private readonly HashSet<int> DisableEntityIdSet = new HashSet<int>();

		// Token: 0x0200A9D2 RID: 43474
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x0403478D RID: 214925
			Default,
			// Token: 0x0403478E RID: 214926
			RoleForeground
		}

		// Token: 0x0200A9D3 RID: 43475
		[NullableContext(0)]
		private enum EHeadIconEnergyBarType
		{
			// Token: 0x04034790 RID: 214928
			Common,
			// Token: 0x04034791 RID: 214929
			FuLuoLuo,
			// Token: 0x04034792 RID: 214930
			JiaBeiLiNa,
			// Token: 0x04034793 RID: 214931
			Daniya,
			// Token: 0x04034794 RID: 214932
			Xigelika,
			// Token: 0x04034795 RID: 214933
			Ruibeika,
			// Token: 0x04034796 RID: 214934
			Suisui
		}
	}
}
