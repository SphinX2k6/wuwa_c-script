using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C92 RID: 11410
	public class IVillageInfrVillageLevel : IVillageInfrBuildOption
	{
		// Token: 0x0600FA85 RID: 64133 RVA: 0x002454AB File Offset: 0x002436AB
		public static IVillageInfrVillageLevel Create(IVillageInfrVillageLevel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrVillageLevel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x0600FA86 RID: 64134 RVA: 0x002454CA File Offset: 0x002436CA
		public override EVillageInfrBuildType Type
		{
			get
			{
				return (EVillageInfrBuildType)this.Instance.Type;
			}
		}

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x0600FA87 RID: 64135 RVA: 0x002454D7 File Offset: 0x002436D7
		public virtual int Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x040088DC RID: 35036
		private IVillageInfrVillageLevel Instance;
	}
}
