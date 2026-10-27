using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072B3 RID: 29363
	public class CameraSpecificLockEntity : CameraSpecificLockTarget
	{
		// Token: 0x0604808B RID: 295051 RVA: 0x0127759B File Offset: 0x0127579B
		public CameraSpecificLockEntity(int entityId, int priority, int id, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal) : base(ECameraSpecificLockType.Entity, id, priority, group)
		{
		}

		// Token: 0x17009F0B RID: 40715
		// (get) Token: 0x0604808C RID: 295052 RVA: 0x012775AF File Offset: 0x012757AF
		public int EntityId { get; } = entityId;

		// Token: 0x0604808D RID: 295053 RVA: 0x012775B7 File Offset: 0x012757B7
		public override bool IsValid()
		{
			EntityHandle handle = CharacterModel.Instance.GetHandle(this.EntityId);
			return handle != null && handle.Valid;
		}
	}
}
