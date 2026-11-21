using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5A RID: 2906
	public class IStateRepPerfBase
	{
		// Token: 0x06004260 RID: 16992 RVA: 0x000A8B46 File Offset: 0x000A6D46
		public static IStateRepPerfBase Create(IStateRepPerfBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x000A8B65 File Offset: 0x000A6D65
		public virtual EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x040024C5 RID: 9413
		private IStateRepPerfBase Instance;
	}
}
