using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E98 RID: 3736
	public class ICurveControlConfig
	{
		// Token: 0x0600545B RID: 21595 RVA: 0x000CFE8E File Offset: 0x000CE08E
		public static ICurveControlConfig Create(ICurveControlConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurveControlConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x0600545C RID: 21596 RVA: 0x000CFEAD File Offset: 0x000CE0AD
		public virtual ECurveControlType Type
		{
			get
			{
				return (ECurveControlType)this.Instance.Type;
			}
		}

		// Token: 0x04003043 RID: 12355
		private ICurveControlConfig Instance;
	}
}
