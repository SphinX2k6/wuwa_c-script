using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x02004802 RID: 18434
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemModel : ModelBase
	{
		// Token: 0x0602E47B RID: 189563 RVA: 0x00CE84C0 File Offset: 0x00CE66C0
		protected override bool OnInit()
		{
			this.LastCloseTimeStamp = 0.0;
			this.WaitPhantomList = new List<int>();
			this.WaitVillageInfrTreeList = new List<int>();
			return true;
		}

		// Token: 0x0602E47C RID: 189564 RVA: 0x00CE84E8 File Offset: 0x00CE66E8
		protected override bool OnClear()
		{
			this.WaitItemList.Clear();
			this.GetItemConfigIdList.Clear();
			this.WaitPhantomList.Clear();
			this.WaitVillageInfrTreeList.Clear();
			return true;
		}

		// Token: 0x0602E47D RID: 189565 RVA: 0x00CE8517 File Offset: 0x00CE6717
		public void LoadGetItemConfigIdList()
		{
			this.GetItemConfigIdList = (LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.GetItemConfigListSaveKey, null) ?? new List<int>());
		}

		// Token: 0x0602E47E RID: 189566 RVA: 0x00CE8530 File Offset: 0x00CE6730
		public void AddGetItemConfigIdList(int configId)
		{
			this.GetItemConfigIdList.Add(configId);
			this.SaveGetItemConfigIdList();
		}

		// Token: 0x0602E47F RID: 189567 RVA: 0x00CE8544 File Offset: 0x00CE6744
		public bool IsGotItem(int configId)
		{
			return this.GetItemConfigIdList.Contains(configId);
		}

		// Token: 0x0602E480 RID: 189568 RVA: 0x00CE8552 File Offset: 0x00CE6752
		public void SaveGetItemConfigIdList()
		{
			LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.GetItemConfigListSaveKey, this.GetItemConfigIdList);
		}

		// Token: 0x0602E481 RID: 189569 RVA: 0x00CE8562 File Offset: 0x00CE6762
		public bool IsWaitItemListEmpty()
		{
			return this.WaitItemList.Count == 0;
		}

		// Token: 0x0602E482 RID: 189570 RVA: 0x00CE8572 File Offset: 0x00CE6772
		public void PushWaitItemList(int itemId)
		{
			this.WaitItemList.Add(itemId);
		}

		// Token: 0x0602E483 RID: 189571 RVA: 0x00CE8580 File Offset: 0x00CE6780
		public int? ShiftWaitItemList()
		{
			if (this.WaitItemList.Count == 0)
			{
				return null;
			}
			int value = this.WaitItemList[0];
			this.WaitItemList.RemoveAt(0);
			return new int?(value);
		}

		// Token: 0x0602E484 RID: 189572 RVA: 0x00CE85C1 File Offset: 0x00CE67C1
		public bool IsWaitPhantomListEmpty()
		{
			return this.WaitPhantomList.Count == 0;
		}

		// Token: 0x0602E485 RID: 189573 RVA: 0x00CE85D1 File Offset: 0x00CE67D1
		public void PushWaitPhantomItem(int uniqueId)
		{
			this.WaitPhantomList.Add(uniqueId);
		}

		// Token: 0x0602E486 RID: 189574 RVA: 0x00CE85E0 File Offset: 0x00CE67E0
		public int? ShiftWaitPhantomList()
		{
			if (this.WaitPhantomList.Count == 0)
			{
				return null;
			}
			int value = this.WaitPhantomList[0];
			this.WaitPhantomList.RemoveAt(0);
			return new int?(value);
		}

		// Token: 0x0602E487 RID: 189575 RVA: 0x00CE8621 File Offset: 0x00CE6821
		public bool IsWaitVillageInfrTreeListEmpty()
		{
			return this.WaitVillageInfrTreeList.Count == 0;
		}

		// Token: 0x0602E488 RID: 189576 RVA: 0x00CE8631 File Offset: 0x00CE6831
		public void PushWaitVillageInfrTree(int treeId)
		{
			this.WaitVillageInfrTreeList.Add(treeId);
		}

		// Token: 0x0602E489 RID: 189577 RVA: 0x00CE8640 File Offset: 0x00CE6840
		public int? ShiftWaitVillageInfrTree()
		{
			if (this.WaitVillageInfrTreeList.Count == 0)
			{
				return null;
			}
			int value = this.WaitVillageInfrTreeList[0];
			this.WaitVillageInfrTreeList.RemoveAt(0);
			return new int?(value);
		}

		// Token: 0x0602E48A RID: 189578 RVA: 0x00CE8681 File Offset: 0x00CE6881
		public void GmClearWaitItemList()
		{
			this.WaitItemList = new List<int>();
		}

		// Token: 0x17005DF5 RID: 24053
		// (get) Token: 0x0602E48B RID: 189579 RVA: 0x00CE868E File Offset: 0x00CE688E
		public static ItemModel Instance
		{
			get
			{
				return ItemModel._Instance;
			}
		}

		// Token: 0x0602E48C RID: 189580 RVA: 0x00CE8695 File Offset: 0x00CE6895
		public static ItemModel GetOrCreateInstance()
		{
			if (ItemModel._Instance == null)
			{
				ItemModel.CreateInstance();
			}
			return ItemModel._Instance;
		}

		// Token: 0x0602E48D RID: 189581 RVA: 0x00CE86A9 File Offset: 0x00CE68A9
		public static bool CreateInstance()
		{
			if (ItemModel._Instance != null)
			{
				return true;
			}
			ItemModel._Instance = new ItemModel();
			return true;
		}

		// Token: 0x0602E48E RID: 189582 RVA: 0x00CE86BF File Offset: 0x00CE68BF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E48F RID: 189583 RVA: 0x00CE86C1 File Offset: 0x00CE68C1
		public static void ResetStaticDefaultValue()
		{
			ItemModel._Instance = null;
		}

		// Token: 0x0602E490 RID: 189584 RVA: 0x00CE86C9 File Offset: 0x00CE68C9
		static ItemModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemModel.CreateStaticDefaultValue), new Action(ItemModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018A6D RID: 100973
		public double LastCloseTimeStamp;

		// Token: 0x04018A6E RID: 100974
		private List<int> WaitItemList = new List<int>();

		// Token: 0x04018A6F RID: 100975
		private List<int> WaitPhantomList = new List<int>();

		// Token: 0x04018A70 RID: 100976
		private List<int> WaitVillageInfrTreeList = new List<int>();

		// Token: 0x04018A71 RID: 100977
		private List<int> GetItemConfigIdList = new List<int>();

		// Token: 0x04018A72 RID: 100978
		[Nullable(2)]
		private static ItemModel _Instance;
	}
}
