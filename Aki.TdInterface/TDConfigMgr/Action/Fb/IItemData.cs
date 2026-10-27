using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200263F RID: 9791
	public class IItemData
	{
		// Token: 0x0600DBB1 RID: 56241 RVA: 0x0020B2BE File Offset: 0x002094BE
		[NullableContext(1)]
		public static IItemData Create(IItemData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x0600DBB2 RID: 56242 RVA: 0x0020B2DD File Offset: 0x002094DD
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x0020B2EA File Offset: 0x002094EA
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x04007A13 RID: 31251
		private IItemData Instance;
	}
}
