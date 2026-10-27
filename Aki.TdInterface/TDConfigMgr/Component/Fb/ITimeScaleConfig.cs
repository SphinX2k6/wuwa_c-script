using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AA6 RID: 2726
	public class ITimeScaleConfig
	{
		// Token: 0x06003EC7 RID: 16071 RVA: 0x000A08EE File Offset: 0x0009EAEE
		[NullableContext(1)]
		public static ITimeScaleConfig Create(ITimeScaleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x000A090D File Offset: 0x0009EB0D
		public virtual bool IgnoreGlobalTimeScale
		{
			get
			{
				return this.Instance.IgnoreGlobalTimeScale;
			}
		}

		// Token: 0x040022DD RID: 8925
		private ITimeScaleConfig Instance;
	}
}
