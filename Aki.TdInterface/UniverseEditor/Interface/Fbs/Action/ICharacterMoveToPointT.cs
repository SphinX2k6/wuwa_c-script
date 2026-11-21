using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C4 RID: 27076
	public class ICharacterMoveToPointT
	{
		// Token: 0x1700C73C RID: 51004
		// (get) Token: 0x0602E72B RID: 190251 RVA: 0x006567FD File Offset: 0x006549FD
		// (set) Token: 0x0602E72C RID: 190252 RVA: 0x00656805 File Offset: 0x00654A05
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700C73D RID: 51005
		// (get) Token: 0x0602E72D RID: 190253 RVA: 0x0065680E File Offset: 0x00654A0E
		// (set) Token: 0x0602E72E RID: 190254 RVA: 0x00656816 File Offset: 0x00654A16
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C73E RID: 51006
		// (get) Token: 0x0602E72F RID: 190255 RVA: 0x0065681F File Offset: 0x00654A1F
		// (set) Token: 0x0602E730 RID: 190256 RVA: 0x00656827 File Offset: 0x00654A27
		public ECharacterMoveToPointType MoveType { get; set; }

		// Token: 0x0602E731 RID: 190257 RVA: 0x00656830 File Offset: 0x00654A30
		public ICharacterMoveToPointT()
		{
			this.Target = null;
			this.Pos = null;
			this.MoveType = ECharacterMoveToPointType.Walk;
		}
	}
}
