using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6B RID: 23147
	public class IThrowMotionFreeFallT
	{
		// Token: 0x1700AE30 RID: 44592
		// (get) Token: 0x06027647 RID: 161351 RVA: 0x0056BBC9 File Offset: 0x00569DC9
		// (set) Token: 0x06027648 RID: 161352 RVA: 0x0056BBD1 File Offset: 0x00569DD1
		public EThrowMotion Type { get; set; }

		// Token: 0x1700AE31 RID: 44593
		// (get) Token: 0x06027649 RID: 161353 RVA: 0x0056BBDA File Offset: 0x00569DDA
		// (set) Token: 0x0602764A RID: 161354 RVA: 0x0056BBE2 File Offset: 0x00569DE2
		public IVectorInfoT Velocity { get; set; }

		// Token: 0x1700AE32 RID: 44594
		// (get) Token: 0x0602764B RID: 161355 RVA: 0x0056BBEB File Offset: 0x00569DEB
		// (set) Token: 0x0602764C RID: 161356 RVA: 0x0056BBF3 File Offset: 0x00569DF3
		public IAngularVelocityConfigT AngularVelocity { get; set; }

		// Token: 0x0602764D RID: 161357 RVA: 0x0056BBFC File Offset: 0x00569DFC
		public IThrowMotionFreeFallT()
		{
			this.Type = EThrowMotion.Projectile;
			this.Velocity = null;
			this.AngularVelocity = null;
		}
	}
}
