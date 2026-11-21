using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006434 RID: 25652
	public abstract class CameraSpecificLockTarget
	{
		// Token: 0x0603E476 RID: 255094 RVA: 0x0121986C File Offset: 0x01217A6C
		protected CameraSpecificLockTarget(ECameraSpecificLockType type, int id, int priority, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal)
		{
		}

		// Token: 0x1700766E RID: 30318
		// (get) Token: 0x0603E477 RID: 255095 RVA: 0x01219891 File Offset: 0x01217A91
		public ECameraSpecificLockType Type { get; } = type;

		// Token: 0x1700766F RID: 30319
		// (get) Token: 0x0603E478 RID: 255096 RVA: 0x01219899 File Offset: 0x01217A99
		public int Id { get; } = id;

		// Token: 0x17007670 RID: 30320
		// (get) Token: 0x0603E479 RID: 255097 RVA: 0x012198A1 File Offset: 0x01217AA1
		public int Priority { get; } = priority;

		// Token: 0x17007671 RID: 30321
		// (get) Token: 0x0603E47A RID: 255098 RVA: 0x012198A9 File Offset: 0x01217AA9
		public ECameraSpecificLockGroup Group { get; } = group;

		// Token: 0x0603E47B RID: 255099 RVA: 0x012198B1 File Offset: 0x01217AB1
		public virtual bool IsValid()
		{
			return true;
		}

		// Token: 0x040212A4 RID: 135844
		public bool MarkDelete;
	}
}
