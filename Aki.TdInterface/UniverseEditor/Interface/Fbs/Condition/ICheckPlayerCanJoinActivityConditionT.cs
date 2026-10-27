using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD9 RID: 19161
	public class ICheckPlayerCanJoinActivityConditionT
	{
		// Token: 0x17008AEF RID: 35567
		// (get) Token: 0x0601E198 RID: 123288 RVA: 0x00438FDF File Offset: 0x004371DF
		// (set) Token: 0x0601E199 RID: 123289 RVA: 0x00438FE7 File Offset: 0x004371E7
		public ECondition Type { get; set; }

		// Token: 0x17008AF0 RID: 35568
		// (get) Token: 0x0601E19A RID: 123290 RVA: 0x00438FF0 File Offset: 0x004371F0
		// (set) Token: 0x0601E19B RID: 123291 RVA: 0x00438FF8 File Offset: 0x004371F8
		public ICheckPlayerCanJoinRogueT Config { get; set; }

		// Token: 0x0601E19C RID: 123292 RVA: 0x00439001 File Offset: 0x00437201
		public ICheckPlayerCanJoinActivityConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Config = null;
		}
	}
}
