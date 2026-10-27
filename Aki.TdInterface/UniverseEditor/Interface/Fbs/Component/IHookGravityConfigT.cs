using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C0 RID: 21440
	public class IHookGravityConfigT
	{
		// Token: 0x17009D96 RID: 40342
		// (get) Token: 0x0602323A RID: 143930 RVA: 0x004DD3D7 File Offset: 0x004DB5D7
		// (set) Token: 0x0602323B RID: 143931 RVA: 0x004DD3DF File Offset: 0x004DB5DF
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x17009D97 RID: 40343
		// (get) Token: 0x0602323C RID: 143932 RVA: 0x004DD3E8 File Offset: 0x004DB5E8
		// (set) Token: 0x0602323D RID: 143933 RVA: 0x004DD3F0 File Offset: 0x004DB5F0
		public int SafePointId { get; set; }

		// Token: 0x17009D98 RID: 40344
		// (get) Token: 0x0602323E RID: 143934 RVA: 0x004DD3F9 File Offset: 0x004DB5F9
		// (set) Token: 0x0602323F RID: 143935 RVA: 0x004DD401 File Offset: 0x004DB601
		public int CameraLookAtPointId { get; set; }

		// Token: 0x17009D99 RID: 40345
		// (get) Token: 0x06023240 RID: 143936 RVA: 0x004DD40A File Offset: 0x004DB60A
		// (set) Token: 0x06023241 RID: 143937 RVA: 0x004DD412 File Offset: 0x004DB612
		public byte NullMask { get; set; }

		// Token: 0x06023242 RID: 143938 RVA: 0x004DD41B File Offset: 0x004DB61B
		public IHookGravityConfigT()
		{
			this.GravityDirection = null;
			this.SafePointId = 0;
			this.CameraLookAtPointId = 0;
			this.NullMask = 0;
		}
	}
}
