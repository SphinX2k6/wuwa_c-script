using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C91 RID: 11409
	public class IVillageInfrBuildOption
	{
		// Token: 0x0600FA82 RID: 64130 RVA: 0x00245477 File Offset: 0x00243677
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

		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x0600FA83 RID: 64131 RVA: 0x00245496 File Offset: 0x00243696
		public virtual EVillageInfrBuildType Type
		{
			get
			{
				return (EVillageInfrBuildType)this.Instance.Type;
			}
		}

		// Token: 0x040088DB RID: 35035
		private IVillageInfrBuildOption Instance;
	}
}
