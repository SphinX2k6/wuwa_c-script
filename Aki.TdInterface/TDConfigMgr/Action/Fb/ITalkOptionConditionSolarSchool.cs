using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200250E RID: 9486
	public class ITalkOptionConditionSolarSchool : ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600D39A RID: 54170 RVA: 0x001F5B68 File Offset: 0x001F3D68
		[NullableContext(1)]
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

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0600D39B RID: 54171 RVA: 0x001F5B87 File Offset: 0x001F3D87
		public override ETalkOptionConditionSystem Type
		{
			get
			{
				return (ETalkOptionConditionSystem)this.Instance.Type;
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0600D39C RID: 54172 RVA: 0x001F5B94 File Offset: 0x001F3D94
		public virtual int ConditionGroupId
		{
			get
			{
				return this.Instance.ConditionGroupId;
			}
		}

		// Token: 0x040073FE RID: 29694
		private ITalkOptionConditionSolarSchool Instance;
	}
}
