using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C93 RID: 11411
	public class IVillageInfrTreeProcess : IVillageInfrBuildOption
	{
		// Token: 0x0600FA89 RID: 64137 RVA: 0x002454EC File Offset: 0x002436EC
		public static IVillageInfrTreeProcess Create(IVillageInfrTreeProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrTreeProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x0600FA8A RID: 64138 RVA: 0x0024550B File Offset: 0x0024370B
		public override EVillageInfrBuildType Type
		{
			get
			{
				return (EVillageInfrBuildType)this.Instance.Type;
			}
		}

		// Token: 0x17004E12 RID: 19986
		// (get) Token: 0x0600FA8B RID: 64139 RVA: 0x00245518 File Offset: 0x00243718
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040088DD RID: 35037
		private IVillageInfrTreeProcess Instance;
	}
}
