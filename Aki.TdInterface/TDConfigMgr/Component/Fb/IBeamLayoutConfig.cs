using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE7 RID: 3559
	public class IBeamLayoutConfig
	{
		// Token: 0x060050AE RID: 20654 RVA: 0x000C81B2 File Offset: 0x000C63B2
		public static IBeamLayoutConfig Create(IBeamLayoutConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBeamLayoutConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x000C81D1 File Offset: 0x000C63D1
		public virtual EBeamLayoutType Type
		{
			get
			{
				return (EBeamLayoutType)this.Instance.Type;
			}
		}

		// Token: 0x04002DF4 RID: 11764
		private IBeamLayoutConfig Instance;
	}
}
