using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1D RID: 10781
	public class IWhiteCatWarning : ICommonTipType
	{
		// Token: 0x0600EE3D RID: 60989 RVA: 0x0022F8AC File Offset: 0x0022DAAC
		public static IWhiteCatWarning Create(IWhiteCatWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWhiteCatWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x0600EE3E RID: 60990 RVA: 0x0022F8CB File Offset: 0x0022DACB
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x0600EE3F RID: 60991 RVA: 0x0022F8D8 File Offset: 0x0022DAD8
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x040082FD RID: 33533
		private IWhiteCatWarning Instance;
	}
}
