using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200263E RID: 9790
	public class IDestroyItemData : IItemData
	{
		// Token: 0x0600DBAC RID: 56236 RVA: 0x0020B270 File Offset: 0x00209470
		[NullableContext(1)]
		public static IDestroyItemData Create(IDestroyItemData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyItemData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x0600DBAD RID: 56237 RVA: 0x0020B28F File Offset: 0x0020948F
		public override int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x0600DBAE RID: 56238 RVA: 0x0020B29C File Offset: 0x0020949C
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x0600DBAF RID: 56239 RVA: 0x0020B2A9 File Offset: 0x002094A9
		public virtual bool IsAll
		{
			get
			{
				return this.Instance.IsAll;
			}
		}

		// Token: 0x04007A12 RID: 31250
		private IDestroyItemData Instance;
	}
}
