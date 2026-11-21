using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047C5 RID: 18373
	public class RewardItemData
	{
		// Token: 0x0602E285 RID: 189061 RVA: 0x00CE02D0 File Offset: 0x00CDE4D0
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

		// Token: 0x0602E286 RID: 189062 RVA: 0x00CE03BD File Offset: 0x00CDE5BD
		[NullableContext(1)]
		public ItemConfig GetConfig()
		{
			return this.Config;
		}

		// Token: 0x0602E287 RID: 189063 RVA: 0x00CE03C5 File Offset: 0x00CDE5C5
		public int GetTypeSortIndex()
		{
			return this.TypeSortIndex;
		}

		// Token: 0x0602E288 RID: 189064 RVA: 0x00CE03CD File Offset: 0x00CDE5CD
		public int GetQualityId()
		{
			return this.QualityId;
		}

		// Token: 0x0602E289 RID: 189065 RVA: 0x00CE03D5 File Offset: 0x00CDE5D5
		public EDropItemType GetDropItemType()
		{
			return this.DropItemType;
		}

		// Token: 0x0602E28A RID: 189066 RVA: 0x00CE03DD File Offset: 0x00CDE5DD
		public ERoleDevelopStateTagType? GetRoleDevelopStateTagType()
		{
			return this.RoleDevelopStateTagTypeValue;
		}

		// Token: 0x0602E28B RID: 189067 RVA: 0x00CE03E5 File Offset: 0x00CDE5E5
		public void SetRoleDevelopStateTagType(ERoleDevelopStateTagType? value)
		{
			this.RoleDevelopStateTagTypeValue = value;
		}

		// Token: 0x0602E28C RID: 189068 RVA: 0x00CE03EE File Offset: 0x00CDE5EE
		public void SetShowTimeFlag(bool value)
		{
			this.ShowTimeFlagValue = value;
		}

		// Token: 0x0602E28D RID: 189069 RVA: 0x00CE03F7 File Offset: 0x00CDE5F7
		public bool GetShowTimeFlag()
		{
			return this.ShowTimeFlagValue;
		}

		// Token: 0x04018990 RID: 100752
		public readonly int ConfigId;

		// Token: 0x04018991 RID: 100753
		public readonly int UniqueId;

		// Token: 0x04018992 RID: 100754
		public int Count;

		// Token: 0x04018993 RID: 100755
		[Nullable(2)]
		private readonly ItemConfig Config;

		// Token: 0x04018994 RID: 100756
		private readonly TypeInfo? TypeConfig;

		// Token: 0x04018995 RID: 100757
		private readonly int TypeSortIndex;

		// Token: 0x04018996 RID: 100758
		private readonly int QualityId;

		// Token: 0x04018997 RID: 100759
		private readonly EDropItemType DropItemType;

		// Token: 0x04018998 RID: 100760
		private ERoleDevelopStateTagType? RoleDevelopStateTagTypeValue;

		// Token: 0x04018999 RID: 100761
		private bool ShowTimeFlagValue;
	}
}
