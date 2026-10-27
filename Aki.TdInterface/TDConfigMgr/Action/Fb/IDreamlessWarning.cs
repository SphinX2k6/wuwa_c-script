using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200274F RID: 10063
	[NullableContext(1)]
	[Nullable(0)]
	public class IDreamlessWarning : ICommonTipType
	{
		// Token: 0x0600E035 RID: 57397 RVA: 0x00212CF2 File Offset: 0x00210EF2
		public static IDreamlessWarning Create(IDreamlessWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDreamlessWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x0600E036 RID: 57398 RVA: 0x00212D11 File Offset: 0x00210F11
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x0600E037 RID: 57399 RVA: 0x00212D1E File Offset: 0x00210F1E
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x04007C4D RID: 31821
		private IDreamlessWarning Instance;
	}
}
