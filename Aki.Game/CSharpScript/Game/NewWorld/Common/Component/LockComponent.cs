using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02007087 RID: 28807
	[NullableContext(2)]
	[Nullable(0)]
	public class LockComponent : EntityComponent
	{
		// Token: 0x0604629F RID: 287391 RVA: 0x01187748 File Offset: 0x01185948
		protected override bool OnStart()
		{
			this.LevelTagComponent = base.Entity.GetComponent<LevelTagComponent>();
			this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
			EntranceState? entityEnterComponentState = this.CreatureDataComponent.GetEntityEnterComponentState();
			if (entityEnterComponentState != null)
			{
				if (entityEnterComponentState != null)
				{
					switch (entityEnterComponentState.GetValueOrDefault())
					{
					case EntranceState.NotUnlock:
						this.CurLockTagId = GameplayTagDefine.EGameplayTagId["物体.物体阶段.不可解锁"];
						goto IL_B6;
					case EntranceState.Unlockable:
						this.CurLockTagId = GameplayTagDefine.EGameplayTagId["物体.物体阶段.可解锁"];
						goto IL_B6;
					case EntranceState.Unlocked:
						this.CurLockTagId = GameplayTagDefine.EGameplayTagId["物体.物体阶段.已解锁"];
						goto IL_B6;
					}
				}
				this.CurLockTagId = GameplayTagDefine.EGameplayTagId["物体.物体阶段.不可解锁"];
			}
			IL_B6:
			if (this.CurLockTagId == 0)
			{
				this.CurLockTagId = GameplayTagDefine.EGameplayTagId["物体.物体阶段.不可解锁"];
			}
			this.LevelTagComponent.AddTag(new int?(this.CurLockTagId));
			return true;
		}

		// Token: 0x060462A0 RID: 287392 RVA: 0x01187840 File Offset: 0x01185A40
		public void ChangeLockTag(int tagId)
		{
			int curLockTagId = this.CurLockTagId;
			this.CurLockTagId = tagId;
			this.LevelTagComponent.ChangeLocalLevelTag(this.CurLockTagId, curLockTagId);
		}

		// Token: 0x060462A1 RID: 287393 RVA: 0x01187870 File Offset: 0x01185A70
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			LockComponent lockComponent = (LockComponent)componentTemplate;
			if (base.CanResetComponentProperty("LevelTagComponent"))
			{
				if (lockComponent.LevelTagComponent == null)
				{
					this.LevelTagComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.LevelTagComponent), "LevelTagComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComponent"))
			{
				if (lockComponent.CreatureDataComponent == null)
				{
					this.CreatureDataComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurLockTagId"))
			{
				this.CurLockTagId = lockComponent.CurLockTagId;
			}
			return true;
		}

		// Token: 0x04024C0D RID: 150541
		private LevelTagComponent LevelTagComponent;

		// Token: 0x04024C0E RID: 150542
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x04024C0F RID: 150543
		private int CurLockTagId;
	}
}
