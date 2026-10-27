using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005791 RID: 22417
	public class IProceduralVisualBaseT
	{
		// Token: 0x1700A731 RID: 42801
		// (get) Token: 0x06025955 RID: 153941 RVA: 0x0052F0BF File Offset: 0x0052D2BF
		// (set) Token: 0x06025956 RID: 153942 RVA: 0x0052F0C7 File Offset: 0x0052D2C7
		public EProceduralVisualType Type { get; set; }

		// Token: 0x1700A732 RID: 42802
		// (get) Token: 0x06025957 RID: 153943 RVA: 0x0052F0D0 File Offset: 0x0052D2D0
		// (set) Token: 0x06025958 RID: 153944 RVA: 0x0052F0D8 File Offset: 0x0052D2D8
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06025959 RID: 153945 RVA: 0x0052F0E1 File Offset: 0x0052D2E1
		public IProceduralVisualBaseT()
		{
			this.Type = EProceduralVisualType.LookAt;
			this.Condition = null;
		}
	}
}
