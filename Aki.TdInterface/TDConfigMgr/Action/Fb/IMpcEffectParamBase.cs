using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028AD RID: 10413
	public class IMpcEffectParamBase
	{
		// Token: 0x0600E7FF RID: 59391 RVA: 0x00224CC3 File Offset: 0x00222EC3
		public static IMpcEffectParamBase Create(IMpcEffectParamBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMpcEffectParamBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x0600E800 RID: 59392 RVA: 0x00224CE2 File Offset: 0x00222EE2
		public virtual EMpcEffectParamType Type
		{
			get
			{
				return (EMpcEffectParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007FC1 RID: 32705
		private IMpcEffectParamBase Instance;
	}
}
