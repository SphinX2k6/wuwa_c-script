using System;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200639C RID: 25500
	public class SplineRailDataImpl : ISplineRailData, IRailParam
	{
		// Token: 0x1700754A RID: 30026
		// (get) Token: 0x0603DD31 RID: 253233 RVA: 0x011F1A28 File Offset: 0x011EFC28
		// (set) Token: 0x0603DD32 RID: 253234 RVA: 0x011F1A30 File Offset: 0x011EFC30
		public ERailMoveType RailType { get; set; }

		// Token: 0x1700754B RID: 30027
		// (get) Token: 0x0603DD33 RID: 253235 RVA: 0x011F1A39 File Offset: 0x011EFC39
		// (set) Token: 0x0603DD34 RID: 253236 RVA: 0x011F1A41 File Offset: 0x011EFC41
		public ERailJumpType JumpType { get; set; }

		// Token: 0x1700754C RID: 30028
		// (get) Token: 0x0603DD35 RID: 253237 RVA: 0x011F1A4A File Offset: 0x011EFC4A
		// (set) Token: 0x0603DD36 RID: 253238 RVA: 0x011F1A52 File Offset: 0x011EFC52
		public int DefaultNextRailId { get; set; }

		// Token: 0x1700754D RID: 30029
		// (get) Token: 0x0603DD37 RID: 253239 RVA: 0x011F1A5B File Offset: 0x011EFC5B
		// (set) Token: 0x0603DD38 RID: 253240 RVA: 0x011F1A63 File Offset: 0x011EFC63
		public ETriggerKey DefaultTriggerKey { get; set; }

		// Token: 0x1700754E RID: 30030
		// (get) Token: 0x0603DD39 RID: 253241 RVA: 0x011F1A6C File Offset: 0x011EFC6C
		// (set) Token: 0x0603DD3A RID: 253242 RVA: 0x011F1A74 File Offset: 0x011EFC74
		public int RailId { get; set; }
	}
}
