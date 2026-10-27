using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057EE RID: 22510
	public class RewardItemData
	{
		// Token: 0x06039371 RID: 234353 RVA: 0x00D91488 File Offset: 0x00D8F688
		public RewardItemData(int configId, int count, int? uniqueId = null, EDropItemType dropItemType = EDropItemType.Normal)
		{
			this.ConfigId = configId;
			this.Count = count;
			this.UniqueId = uniqueId.GetValueOrDefault();
			this.DropItemType = dropItemType;
			InventoryConfig instance = InventoryConfig.Instance;
			this.Config = instance.GetItemConfigData(configId);
			if (this.Config == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.RewardItem;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "生成奖励物品数据时，没有在d.道具中找到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", configId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.TypeConfig = ((this.Config.ItemType != null) ? instance.GetItemTypeConfig((int)this.Config.ItemType.Value) : null);
			this.TypeSortIndex = ((this.TypeConfig != null) ? this.TypeConfig.GetValueOrDefault().SortIndex : 0);
			this.QualityId = this.Config.QualityId;
		}

		// Token: 0x06039372 RID: 234354 RVA: 0x00D91575 File Offset: 0x00D8F775
		[NullableContext(1)]
		public ItemConfig GetConfig()
		{
			return this.Config;
		}

		// Token: 0x06039373 RID: 234355 RVA: 0x00D9157D File Offset: 0x00D8F77D
		public int GetTypeSortIndex()
		{
			return this.TypeSortIndex;
		}

		// Token: 0x06039374 RID: 234356 RVA: 0x00D91585 File Offset: 0x00D8F785
		public int GetQualityId()
		{
			return this.QualityId;
		}

		// Token: 0x06039375 RID: 234357 RVA: 0x00D9158D File Offset: 0x00D8F78D
		public EDropItemType GetDropItemType()
		{
			return this.DropItemType;
		}

		// Token: 0x06039376 RID: 234358 RVA: 0x00D91595 File Offset: 0x00D8F795
		public ERoleDevelopStateTagType? GetRoleDevelopStateTagType()
		{
			return this.RoleDevelopStateTagTypeValue;
		}

		// Token: 0x06039377 RID: 234359 RVA: 0x00D9159D File Offset: 0x00D8F79D
		public void SetRoleDevelopStateTagType(ERoleDevelopStateTagType? value)
		{
			this.RoleDevelopStateTagTypeValue = value;
		}

		// Token: 0x06039378 RID: 234360 RVA: 0x00D915A6 File Offset: 0x00D8F7A6
		public void SetShowTimeFlag(bool value)
		{
			this.ShowTimeFlagValue = value;
		}

		// Token: 0x06039379 RID: 234361 RVA: 0x00D915AF File Offset: 0x00D8F7AF
		public bool GetShowTimeFlag()
		{
			return this.ShowTimeFlagValue;
		}

		// Token: 0x0401DEF9 RID: 122617
		public readonly int ConfigId;

		// Token: 0x0401DEFA RID: 122618
		public readonly int UniqueId;

		// Token: 0x0401DEFB RID: 122619
		public int Count;

		// Token: 0x0401DEFC RID: 122620
		[Nullable(2)]
		private readonly ItemConfig Config;

		// Token: 0x0401DEFD RID: 122621
		private readonly TypeInfo? TypeConfig;

		// Token: 0x0401DEFE RID: 122622
		private readonly int TypeSortIndex;

		// Token: 0x0401DEFF RID: 122623
		private readonly int QualityId;

		// Token: 0x0401DF00 RID: 122624
		private readonly EDropItemType DropItemType;

		// Token: 0x0401DF01 RID: 122625
		private ERoleDevelopStateTagType? RoleDevelopStateTagTypeValue;

		// Token: 0x0401DF02 RID: 122626
		private bool ShowTimeFlagValue;
	}
}
