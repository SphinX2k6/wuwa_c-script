using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CC RID: 26572
	public class IFixedCameraConfigT
	{
		// Token: 0x1700C541 RID: 50497
		// (get) Token: 0x0602E41F RID: 189471 RVA: 0x00651336 File Offset: 0x0064F536
		// (set) Token: 0x0602E420 RID: 189472 RVA: 0x0065133E File Offset: 0x0064F53E
		public float FadeInTime { get; set; }

		// Token: 0x1700C542 RID: 50498
		// (get) Token: 0x0602E421 RID: 189473 RVA: 0x00651347 File Offset: 0x0064F547
		// (set) Token: 0x0602E422 RID: 189474 RVA: 0x0065134F File Offset: 0x0064F54F
		public float FadeOutTime { get; set; }

		// Token: 0x1700C543 RID: 50499
		// (get) Token: 0x0602E423 RID: 189475 RVA: 0x00651358 File Offset: 0x0064F558
		// (set) Token: 0x0602E424 RID: 189476 RVA: 0x00651360 File Offset: 0x0064F560
		public float Fov { get; set; }

		// Token: 0x1700C544 RID: 50500
		// (get) Token: 0x0602E425 RID: 189477 RVA: 0x00651369 File Offset: 0x0064F569
		// (set) Token: 0x0602E426 RID: 189478 RVA: 0x00651371 File Offset: 0x0064F571
		public bool IsDisableCollision { get; set; }

		// Token: 0x1700C545 RID: 50501
		// (get) Token: 0x0602E427 RID: 189479 RVA: 0x0065137A File Offset: 0x0064F57A
		// (set) Token: 0x0602E428 RID: 189480 RVA: 0x00651382 File Offset: 0x0064F582
		public bool IsDisableDither { get; set; }

		// Token: 0x1700C546 RID: 50502
		// (get) Token: 0x0602E429 RID: 189481 RVA: 0x0065138B File Offset: 0x0064F58B
		// (set) Token: 0x0602E42A RID: 189482 RVA: 0x00651393 File Offset: 0x0064F593
		public IVectorInfoT CenterPos { get; set; }

		// Token: 0x1700C547 RID: 50503
		// (get) Token: 0x0602E42B RID: 189483 RVA: 0x0065139C File Offset: 0x0064F59C
		// (set) Token: 0x0602E42C RID: 189484 RVA: 0x006513A4 File Offset: 0x0064F5A4
		public IVectorInfoT CenterRot { get; set; }

		// Token: 0x1700C548 RID: 50504
		// (get) Token: 0x0602E42D RID: 189485 RVA: 0x006513AD File Offset: 0x0064F5AD
		// (set) Token: 0x0602E42E RID: 189486 RVA: 0x006513B5 File Offset: 0x0064F5B5
		public byte NullMask { get; set; }

		// Token: 0x0602E42F RID: 189487 RVA: 0x006513C0 File Offset: 0x0064F5C0
		public IFixedCameraConfigT()
		{
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.Fov = 0f;
			this.IsDisableCollision = false;
			this.IsDisableDither = false;
			this.CenterPos = null;
			this.CenterRot = null;
			this.NullMask = 0;
		}
	}
}
