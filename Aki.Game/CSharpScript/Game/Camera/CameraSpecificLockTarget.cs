using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072B2 RID: 29362
	public abstract class CameraSpecificLockTarget
	{
		// Token: 0x06048085 RID: 295045 RVA: 0x01277553 File Offset: 0x01275753
		protected CameraSpecificLockTarget(ECameraSpecificLockType type, int id, int priority, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal)
		{
		}

		// Token: 0x17009F07 RID: 40711
		// (get) Token: 0x06048086 RID: 295046 RVA: 0x01277578 File Offset: 0x01275778
		public ECameraSpecificLockType Type { get; } = type;

		// Token: 0x17009F08 RID: 40712
		// (get) Token: 0x06048087 RID: 295047 RVA: 0x01277580 File Offset: 0x01275780
		public int Id { get; } = id;

		// Token: 0x17009F09 RID: 40713
		// (get) Token: 0x06048088 RID: 295048 RVA: 0x01277588 File Offset: 0x01275788
		public int Priority { get; } = priority;

		// Token: 0x17009F0A RID: 40714
		// (get) Token: 0x06048089 RID: 295049 RVA: 0x01277590 File Offset: 0x01275790
		public ECameraSpecificLockGroup Group { get; } = group;

		// Token: 0x0604808A RID: 295050 RVA: 0x01277598 File Offset: 0x01275798
		public virtual bool IsValid()
		{
			return true;
		}

		// Token: 0x04025FC4 RID: 155588
		public bool MarkDelete;
	}
}
