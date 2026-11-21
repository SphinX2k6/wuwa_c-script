using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C0D RID: 11277
	public class EnableFunction : ActionParams
	{
		// Token: 0x0600F846 RID: 63558 RVA: 0x002419AB File Offset: 0x0023FBAB
		public static EnableFunction Create(IEnableFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CDA RID: 19674
		// (get) Token: 0x0600F847 RID: 63559 RVA: 0x002419CA File Offset: 0x0023FBCA
		public virtual EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x040087D9 RID: 34777
		private IEnableFunction Instance;
	}
}
