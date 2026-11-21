using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FE RID: 26366
	public class IActorFaceExpressionT
	{
		// Token: 0x1700BFA9 RID: 49065
		// (get) Token: 0x0602CA57 RID: 182871 RVA: 0x0061C09F File Offset: 0x0061A29F
		// (set) Token: 0x0602CA58 RID: 182872 RVA: 0x0061C0A7 File Offset: 0x0061A2A7
		public int ActorIndex { get; set; }

		// Token: 0x1700BFAA RID: 49066
		// (get) Token: 0x0602CA59 RID: 182873 RVA: 0x0061C0B0 File Offset: 0x0061A2B0
		// (set) Token: 0x0602CA5A RID: 182874 RVA: 0x0061C0B8 File Offset: 0x0061A2B8
		public TActorFaceExpressionUnion FaceExpression { get; set; }

		// Token: 0x0602CA5B RID: 182875 RVA: 0x0061C0C1 File Offset: 0x0061A2C1
		public IActorFaceExpressionT()
		{
			this.ActorIndex = 0;
			this.FaceExpression = null;
		}
	}
}
