using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B24 RID: 19236
	public class ICheckSceneItemDirectionConditionT
	{
		// Token: 0x17008B8A RID: 35722
		// (get) Token: 0x0601E434 RID: 123956 RVA: 0x0043DF72 File Offset: 0x0043C172
		// (set) Token: 0x0601E435 RID: 123957 RVA: 0x0043DF7A File Offset: 0x0043C17A
		public ECondition Type { get; set; }

		// Token: 0x17008B8B RID: 35723
		// (get) Token: 0x0601E436 RID: 123958 RVA: 0x0043DF83 File Offset: 0x0043C183
		// (set) Token: 0x0601E437 RID: 123959 RVA: 0x0043DF8B File Offset: 0x0043C18B
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17008B8C RID: 35724
		// (get) Token: 0x0601E438 RID: 123960 RVA: 0x0043DF94 File Offset: 0x0043C194
		// (set) Token: 0x0601E439 RID: 123961 RVA: 0x0043DF9C File Offset: 0x0043C19C
		public string RotatePoint { get; set; }

		// Token: 0x17008B8D RID: 35725
		// (get) Token: 0x0601E43A RID: 123962 RVA: 0x0043DFA5 File Offset: 0x0043C1A5
		// (set) Token: 0x0601E43B RID: 123963 RVA: 0x0043DFAD File Offset: 0x0043C1AD
		public IVectorInfoT Direction { get; set; }

		// Token: 0x17008B8E RID: 35726
		// (get) Token: 0x0601E43C RID: 123964 RVA: 0x0043DFB6 File Offset: 0x0043C1B6
		// (set) Token: 0x0601E43D RID: 123965 RVA: 0x0043DFBE File Offset: 0x0043C1BE
		public float AngleInterval { get; set; }

		// Token: 0x0601E43E RID: 123966 RVA: 0x0043DFC7 File Offset: 0x0043C1C7
		public ICheckSceneItemDirectionConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.RotatePoint = null;
			this.Direction = null;
			this.AngleInterval = 0f;
		}
	}
}
