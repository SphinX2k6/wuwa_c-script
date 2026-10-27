using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x02005819 RID: 22553
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemDeliverModel : ModelBase
	{
		// Token: 0x060394F5 RID: 234741 RVA: 0x00D9780E File Offset: 0x00D95A0E
		protected override bool OnClear()
		{
			this.ItemDeliverData = null;
			return true;
		}

		// Token: 0x060394F6 RID: 234742 RVA: 0x00D97818 File Offset: 0x00D95A18
		[NullableContext(2)]
		public void SetItemDeliverData(DeliverData itemDeliverData)
		{
			this.ItemDeliverData = itemDeliverData;
		}

		// Token: 0x060394F7 RID: 234743 RVA: 0x00D97821 File Offset: 0x00D95A21
		public DeliverData GetItemDeliverData()
		{
			return this.ItemDeliverData;
		}

		// Token: 0x17008A28 RID: 35368
		// (get) Token: 0x060394F8 RID: 234744 RVA: 0x00D97829 File Offset: 0x00D95A29
		public static ItemDeliverModel Instance
		{
			get
			{
				return ItemDeliverModel._Instance;
			}
		}

		// Token: 0x060394F9 RID: 234745 RVA: 0x00D97830 File Offset: 0x00D95A30
		public static ItemDeliverModel GetOrCreateInstance()
		{
			if (ItemDeliverModel._Instance == null)
			{
				ItemDeliverModel.CreateInstance();
			}
			return ItemDeliverModel._Instance;
		}

		// Token: 0x060394FA RID: 234746 RVA: 0x00D97844 File Offset: 0x00D95A44
		public static bool CreateInstance()
		{
			if (ItemDeliverModel._Instance != null)
			{
				return true;
			}
			ItemDeliverModel._Instance = new ItemDeliverModel();
			return true;
		}

		// Token: 0x060394FB RID: 234747 RVA: 0x00D9785A File Offset: 0x00D95A5A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060394FC RID: 234748 RVA: 0x00D9785C File Offset: 0x00D95A5C
		public static void ResetStaticDefaultValue()
		{
			ItemDeliverModel._Instance = null;
		}

		// Token: 0x060394FD RID: 234749 RVA: 0x00D97864 File Offset: 0x00D95A64
		static ItemDeliverModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemDeliverModel.CreateStaticDefaultValue), new Action(ItemDeliverModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DF83 RID: 122755
		[Nullable(2)]
		private DeliverData ItemDeliverData;

		// Token: 0x0401DF84 RID: 122756
		[Nullable(2)]
		private static ItemDeliverModel _Instance;
	}
}
