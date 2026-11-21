using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E78 RID: 3704
	public class IQteType
	{
		// Token: 0x060053B1 RID: 21425 RVA: 0x000CE645 File Offset: 0x000CC845
		public static IQteType Create(IQteType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x060053B2 RID: 21426 RVA: 0x000CE664 File Offset: 0x000CC864
		public virtual EQteType Type
		{
			get
			{
				return (EQteType)this.Instance.Type;
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x060053B3 RID: 21427 RVA: 0x000CE671 File Offset: 0x000CC871
		public virtual int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x04002FDD RID: 12253
		private IQteType Instance;
	}
}
