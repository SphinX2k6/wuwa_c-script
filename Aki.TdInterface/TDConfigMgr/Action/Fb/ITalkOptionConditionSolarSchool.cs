using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B4 RID: 10164
	public class ITalkOptionConditionSolarSchool : ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600E0F6 RID: 57590 RVA: 0x00211560 File Offset: 0x0020F760
		public static ITalkOptionConditionSolarSchool Create(ITalkOptionConditionSolarSchool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionConditionSolarSchool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600E0F7 RID: 57591 RVA: 0x0021157F File Offset: 0x0020F77F
		public override ETalkOptionConditionSystem Type
		{
			get
			{
				return (ETalkOptionConditionSystem)this.Instance.Type;
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x0021158C File Offset: 0x0020F78C
		public virtual int ConditionGroupId
		{
			get
			{
				return this.Instance.ConditionGroupId;
			}
		}

		// Token: 0x04007A50 RID: 31312
		private ITalkOptionConditionSolarSchool Instance;
	}
}
