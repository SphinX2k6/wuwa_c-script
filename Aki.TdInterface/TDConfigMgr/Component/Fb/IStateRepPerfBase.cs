using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A90 RID: 2704
	public class IStateRepPerfBase
	{
		// Token: 0x06003E37 RID: 15927 RVA: 0x0009F58E File Offset: 0x0009D78E
		[NullableContext(1)]
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

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x0009F5AD File Offset: 0x0009D7AD
		public virtual EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x040022A9 RID: 8873
		private IStateRepPerfBase Instance;
	}
}
