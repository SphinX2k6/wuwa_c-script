using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x0200582B RID: 22571
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemModel : ModelBase
	{
		// Token: 0x06039567 RID: 234855 RVA: 0x00D9962C File Offset: 0x00D9782C
		protected override bool OnInit()
		{
			this.LastCloseTimeStamp = 0.0;
			this.WaitPhantomList = new List<int>();
			this.WaitVillageInfrTreeList = new List<int>();
			return true;
		}

		// Token: 0x06039568 RID: 234856 RVA: 0x00D99654 File Offset: 0x00D97854
		protected override bool OnClear()
		{
			this.WaitItemList.Clear();
			this.GetItemConfigIdList.Clear();
			this.WaitPhantomList.Clear();
			this.WaitVillageInfrTreeList.Clear();
			return true;
		}

		// Token: 0x06039569 RID: 234857 RVA: 0x00D99683 File Offset: 0x00D97883
		public void LoadGetItemConfigIdList()
		{
			this.GetItemConfigIdList = (LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.GetItemConfigListSaveKey, null) ?? new List<int>());
		}

		// Token: 0x0603956A RID: 234858 RVA: 0x00D9969C File Offset: 0x00D9789C
		public void AddGetItemConfigIdList(int configId)
		{
			this.GetItemConfigIdList.Add(configId);
			this.SaveGetItemConfigIdList();
		}

		// Token: 0x0603956B RID: 234859 RVA: 0x00D996B0 File Offset: 0x00D978B0
		public bool IsGotItem(int configId)
		{
			return this.GetItemConfigIdList.Contains(configId);
		}

		// Token: 0x0603956C RID: 234860 RVA: 0x00D996BE File Offset: 0x00D978BE
		public void SaveGetItemConfigIdList()
		{
			LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.GetItemConfigListSaveKey, this.GetItemConfigIdList);
		}

		// Token: 0x0603956D RID: 234861 RVA: 0x00D996CE File Offset: 0x00D978CE
		public bool IsWaitItemListEmpty()
		{
			return this.WaitItemList.Count == 0;
		}

		// Token: 0x0603956E RID: 234862 RVA: 0x00D996DE File Offset: 0x00D978DE
		public void PushWaitItemList(int itemId)
		{
			this.WaitItemList.Add(itemId);
		}

		// Token: 0x0603956F RID: 234863 RVA: 0x00D996EC File Offset: 0x00D978EC
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

		// Token: 0x06039570 RID: 234864 RVA: 0x00D9972D File Offset: 0x00D9792D
		public bool IsWaitPhantomListEmpty()
		{
			return this.WaitPhantomList.Count == 0;
		}

		// Token: 0x06039571 RID: 234865 RVA: 0x00D9973D File Offset: 0x00D9793D
		public void PushWaitPhantomItem(int uniqueId)
		{
			this.WaitPhantomList.Add(uniqueId);
		}

		// Token: 0x06039572 RID: 234866 RVA: 0x00D9974C File Offset: 0x00D9794C
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

		// Token: 0x06039573 RID: 234867 RVA: 0x00D9978D File Offset: 0x00D9798D
		public bool IsWaitVillageInfrTreeListEmpty()
		{
			return this.WaitVillageInfrTreeList.Count == 0;
		}

		// Token: 0x06039574 RID: 234868 RVA: 0x00D9979D File Offset: 0x00D9799D
		public void PushWaitVillageInfrTree(int treeId)
		{
			this.WaitVillageInfrTreeList.Add(treeId);
		}

		// Token: 0x06039575 RID: 234869 RVA: 0x00D997AC File Offset: 0x00D979AC
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

		// Token: 0x06039576 RID: 234870 RVA: 0x00D997ED File Offset: 0x00D979ED
		public void GmClearWaitItemList()
		{
			this.WaitItemList = new List<int>();
		}

		// Token: 0x17008A2B RID: 35371
		// (get) Token: 0x06039577 RID: 234871 RVA: 0x00D997FA File Offset: 0x00D979FA
		public static ItemModel Instance
		{
			get
			{
				return ItemModel._Instance;
			}
		}

		// Token: 0x06039578 RID: 234872 RVA: 0x00D99801 File Offset: 0x00D97A01
		public static ItemModel GetOrCreateInstance()
		{
			if (ItemModel._Instance == null)
			{
				ItemModel.CreateInstance();
			}
			return ItemModel._Instance;
		}

		// Token: 0x06039579 RID: 234873 RVA: 0x00D99815 File Offset: 0x00D97A15
		public static bool CreateInstance()
		{
			if (ItemModel._Instance != null)
			{
				return true;
			}
			ItemModel._Instance = new ItemModel();
			return true;
		}

		// Token: 0x0603957A RID: 234874 RVA: 0x00D9982B File Offset: 0x00D97A2B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603957B RID: 234875 RVA: 0x00D9982D File Offset: 0x00D97A2D
		public static void ResetStaticDefaultValue()
		{
			ItemModel._Instance = null;
		}

		// Token: 0x0603957C RID: 234876 RVA: 0x00D99835 File Offset: 0x00D97A35
		static ItemModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemModel.CreateStaticDefaultValue), new Action(ItemModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DFD5 RID: 122837
		public double LastCloseTimeStamp;

		// Token: 0x0401DFD6 RID: 122838
		private List<int> WaitItemList = new List<int>();

		// Token: 0x0401DFD7 RID: 122839
		private List<int> WaitPhantomList = new List<int>();

		// Token: 0x0401DFD8 RID: 122840
		private List<int> WaitVillageInfrTreeList = new List<int>();

		// Token: 0x0401DFD9 RID: 122841
		private List<int> GetItemConfigIdList = new List<int>();

		// Token: 0x0401DFDA RID: 122842
		[Nullable(2)]
		private static ItemModel _Instance;
	}
}
