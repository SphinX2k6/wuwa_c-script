using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x020047F0 RID: 18416
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ItemDeliverModel : ModelBase
	{
		// Token: 0x0602E409 RID: 189449 RVA: 0x00CE669E File Offset: 0x00CE489E
		protected override bool OnClear()
		{
			this.ItemDeliverData = null;
			return true;
		}

		// Token: 0x0602E40A RID: 189450 RVA: 0x00CE66A8 File Offset: 0x00CE48A8
		[NullableContext(2)]
		public void SetItemDeliverData(DeliverData itemDeliverData)
		{
			this.ItemDeliverData = itemDeliverData;
		}

		// Token: 0x0602E40B RID: 189451 RVA: 0x00CE66B1 File Offset: 0x00CE48B1
		public DeliverData GetItemDeliverData()
		{
			return this.ItemDeliverData;
		}

		// Token: 0x17005DF2 RID: 24050
		// (get) Token: 0x0602E40C RID: 189452 RVA: 0x00CE66B9 File Offset: 0x00CE48B9
		public static ItemDeliverModel Instance
		{
			get
			{
				return ItemDeliverModel._Instance;
			}
		}

		// Token: 0x0602E40D RID: 189453 RVA: 0x00CE66C0 File Offset: 0x00CE48C0
		public static ItemDeliverModel GetOrCreateInstance()
		{
			if (ItemDeliverModel._Instance == null)
			{
				ItemDeliverModel.CreateInstance();
			}
			return ItemDeliverModel._Instance;
		}

		// Token: 0x0602E40E RID: 189454 RVA: 0x00CE66D4 File Offset: 0x00CE48D4
		public static bool CreateInstance()
		{
			if (ItemDeliverModel._Instance != null)
			{
				return true;
			}
			ItemDeliverModel._Instance = new ItemDeliverModel();
			return true;
		}

		// Token: 0x0602E40F RID: 189455 RVA: 0x00CE66EA File Offset: 0x00CE48EA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E410 RID: 189456 RVA: 0x00CE66EC File Offset: 0x00CE48EC
		public static void ResetStaticDefaultValue()
		{
			ItemDeliverModel._Instance = null;
		}

		// Token: 0x0602E411 RID: 189457 RVA: 0x00CE66F4 File Offset: 0x00CE48F4
		static ItemDeliverModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemDeliverModel.CreateStaticDefaultValue), new Action(ItemDeliverModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018A1A RID: 100890
		[Nullable(2)]
		private DeliverData ItemDeliverData;

		// Token: 0x04018A1B RID: 100891
		[Nullable(2)]
		private static ItemDeliverModel _Instance;
	}
}
