using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006523 RID: 25891
	public class ICycleMoveToPointsT
	{
		// Token: 0x1700C085 RID: 49285
		// (get) Token: 0x0602CEB3 RID: 183987 RVA: 0x0062B41C File Offset: 0x0062961C
		// (set) Token: 0x0602CEB4 RID: 183988 RVA: 0x0062B424 File Offset: 0x00629624
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700C086 RID: 49286
		// (get) Token: 0x0602CEB5 RID: 183989 RVA: 0x0062B42D File Offset: 0x0062962D
		// (set) Token: 0x0602CEB6 RID: 183990 RVA: 0x0062B435 File Offset: 0x00629635
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x1700C087 RID: 49287
		// (get) Token: 0x0602CEB7 RID: 183991 RVA: 0x0062B43E File Offset: 0x0062963E
		// (set) Token: 0x0602CEB8 RID: 183992 RVA: 0x0062B446 File Offset: 0x00629646
		public bool IsLoop { get; set; }

		// Token: 0x1700C088 RID: 49288
		// (get) Token: 0x0602CEB9 RID: 183993 RVA: 0x0062B44F File Offset: 0x0062964F
		// (set) Token: 0x0602CEBA RID: 183994 RVA: 0x0062B457 File Offset: 0x00629657
		public float StopTime { get; set; }

		// Token: 0x1700C089 RID: 49289
		// (get) Token: 0x0602CEBB RID: 183995 RVA: 0x0062B460 File Offset: 0x00629660
		// (set) Token: 0x0602CEBC RID: 183996 RVA: 0x0062B468 File Offset: 0x00629668
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x1700C08A RID: 49290
		// (get) Token: 0x0602CEBD RID: 183997 RVA: 0x0062B471 File Offset: 0x00629671
		// (set) Token: 0x0602CEBE RID: 183998 RVA: 0x0062B479 File Offset: 0x00629679
		public byte NullMask { get; set; }

		// Token: 0x0602CEBF RID: 183999 RVA: 0x0062B482 File Offset: 0x00629682
		public ICycleMoveToPointsT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.Points = null;
			this.IsLoop = false;
			this.StopTime = 0f;
			this.MoveMotion = null;
			this.NullMask = 0;
		}
	}
}
