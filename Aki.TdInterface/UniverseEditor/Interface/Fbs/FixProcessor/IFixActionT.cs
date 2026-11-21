using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BBD RID: 19389
	public class IFixActionT
	{
		// Token: 0x17008940 RID: 35136
		// (get) Token: 0x0601D97E RID: 121214 RVA: 0x00427941 File Offset: 0x00425B41
		// (set) Token: 0x0601D97F RID: 121215 RVA: 0x00427949 File Offset: 0x00425B49
		public string Timing { get; set; }

		// Token: 0x17008941 RID: 35137
		// (get) Token: 0x0601D980 RID: 121216 RVA: 0x00427952 File Offset: 0x00425B52
		// (set) Token: 0x0601D981 RID: 121217 RVA: 0x0042795A File Offset: 0x00425B5A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17008942 RID: 35138
		// (get) Token: 0x0601D982 RID: 121218 RVA: 0x00427963 File Offset: 0x00425B63
		// (set) Token: 0x0601D983 RID: 121219 RVA: 0x0042796B File Offset: 0x00425B6B
		public List<IActionInfoT> ThenActions { get; set; }

		// Token: 0x17008943 RID: 35139
		// (get) Token: 0x0601D984 RID: 121220 RVA: 0x00427974 File Offset: 0x00425B74
		// (set) Token: 0x0601D985 RID: 121221 RVA: 0x0042797C File Offset: 0x00425B7C
		public bool Period { get; set; }

		// Token: 0x17008944 RID: 35140
		// (get) Token: 0x0601D986 RID: 121222 RVA: 0x00427985 File Offset: 0x00425B85
		// (set) Token: 0x0601D987 RID: 121223 RVA: 0x0042798D File Offset: 0x00425B8D
		public float CheckPeriod { get; set; }

		// Token: 0x17008945 RID: 35141
		// (get) Token: 0x0601D988 RID: 121224 RVA: 0x00427996 File Offset: 0x00425B96
		// (set) Token: 0x0601D989 RID: 121225 RVA: 0x0042799E File Offset: 0x00425B9E
		public byte NullMask { get; set; }

		// Token: 0x0601D98A RID: 121226 RVA: 0x004279A7 File Offset: 0x00425BA7
		public IFixActionT()
		{
			this.Timing = null;
			this.Condition = null;
			this.ThenActions = null;
			this.Period = false;
			this.CheckPeriod = 0f;
			this.NullMask = 0;
		}
	}
}
