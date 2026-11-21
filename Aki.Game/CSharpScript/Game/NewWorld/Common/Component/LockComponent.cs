using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006208 RID: 25096
	[NullableContext(2)]
	[Nullable(0)]
	public class LockComponent : EntityComponent
	{
		// Token: 0x0603C4C2 RID: 246978 RVA: 0x01130C70 File Offset: 0x0112EE70
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

		// Token: 0x0603C4C3 RID: 246979 RVA: 0x01130D68 File Offset: 0x0112EF68
		public void ChangeLockTag(int tagId)
		{
			int curLockTagId = this.CurLockTagId;
			this.CurLockTagId = tagId;
			this.LevelTagComponent.ChangeLocalLevelTag(this.CurLockTagId, curLockTagId);
		}

		// Token: 0x0603C4C4 RID: 246980 RVA: 0x01130D98 File Offset: 0x0112EF98
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			LockComponent lockComponent = (LockComponent)componentTemplate;
			if (lockComponent.LevelTagComponent == null)
			{
				this.LevelTagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LevelTagComponent), "LevelTagComponent"))
			{
				return false;
			}
			if (lockComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
			this.CurLockTagId = lockComponent.CurLockTagId;
			return true;
		}

		// Token: 0x170071CE RID: 29134
		// (get) Token: 0x0603C4C5 RID: 246981 RVA: 0x01130E1A File Offset: 0x0112F01A
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEC8 RID: 130760
		private LevelTagComponent LevelTagComponent;

		// Token: 0x0401FEC9 RID: 130761
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x0401FECA RID: 130762
		private int CurLockTagId;
	}
}
