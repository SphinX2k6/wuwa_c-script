using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A4 RID: 10660
	public class IVillageInfrBuildOption
	{
		// Token: 0x0600EBEB RID: 60395 RVA: 0x00227AF2 File Offset: 0x00225CF2
		[NullableContext(1)]
		public static IVillageInfrBuildOption Create(IVillageInfrBuildOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrBuildOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x0600EBEC RID: 60396 RVA: 0x00227B11 File Offset: 0x00225D11
		public virtual EVillageInfrBuildType Type
		{
			get
			{
				return (EVillageInfrBuildType)this.Instance.Type;
			}
		}

		// Token: 0x040081EA RID: 33258
		private IVillageInfrBuildOption Instance;
	}
}
