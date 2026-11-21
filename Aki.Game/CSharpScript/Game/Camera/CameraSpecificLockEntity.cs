using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006435 RID: 25653
	public class CameraSpecificLockEntity : CameraSpecificLockTarget
	{
		// Token: 0x0603E47C RID: 255100 RVA: 0x012198B4 File Offset: 0x01217AB4
		public CameraSpecificLockEntity(int entityId, int priority, int id, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal) : base(ECameraSpecificLockType.Entity, id, priority, group)
		{
		}

		// Token: 0x17007672 RID: 30322
		// (get) Token: 0x0603E47D RID: 255101 RVA: 0x012198C8 File Offset: 0x01217AC8
		public int EntityId { get; } = entityId;

		// Token: 0x0603E47E RID: 255102 RVA: 0x012198D0 File Offset: 0x01217AD0
		public override bool IsValid()
		{
			EntityHandle handle = CharacterModel.Instance.GetHandle(this.EntityId);
			return handle != null && handle.Valid;
		}
	}
}
