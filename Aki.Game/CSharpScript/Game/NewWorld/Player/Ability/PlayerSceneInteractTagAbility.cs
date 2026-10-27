using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using CSharpScript.Game.NewWorld.Player.Component;

namespace CSharpScript.Game.NewWorld.Player.Ability
{
	// Token: 0x0200705B RID: 28763
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSceneInteractTagAbility : LevelEntityAbilityBase
	{
		// Token: 0x06046015 RID: 286741 RVA: 0x0117383B File Offset: 0x01171A3B
		public PlayerSceneInteractTagAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06046016 RID: 286742 RVA: 0x01173848 File Offset: 0x01171A48
		public override bool ShouldActivate(Entity entity)
		{
			return this.GetBestInteractTagId(entity) != null;
		}

		// Token: 0x06046017 RID: 286743 RVA: 0x01173864 File Offset: 0x01171A64
		public override bool ShouldDeactivate(Entity entity)
		{
			return this.GetBestInteractTagId(entity) == null;
		}

		// Token: 0x06046018 RID: 286744 RVA: 0x01173883 File Offset: 0x01171A83
		public override void OnActivated(Entity entity)
		{
			this.SyncTag(entity, this.GetBestInteractTagId(entity));
		}

		// Token: 0x06046019 RID: 286745 RVA: 0x01173893 File Offset: 0x01171A93
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			this.SyncTag(entity, this.GetBestInteractTagId(entity));
		}

		// Token: 0x0604601A RID: 286746 RVA: 0x011738A4 File Offset: 0x01171AA4
		public override void OnDeactivated(Entity entity)
		{
			this.SyncTag(entity, null);
		}

		// Token: 0x0604601B RID: 286747 RVA: 0x011738C4 File Offset: 0x01171AC4
		public override void OnDestroy(Entity entity)
		{
			this.SyncTag(entity, null);
		}

		// Token: 0x0604601C RID: 286748 RVA: 0x011738E4 File Offset: 0x01171AE4
		private int? GetBestInteractTagId(Entity entity)
		{
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			ISceneInteractPoint sceneInteractPoint = (component != null) ? component.GetBestInteractPoint() : null;
			if (sceneInteractPoint == null || !PlayerSceneInteractTagAbility.ImplementsSceneInteractTag(sceneInteractPoint))
			{
				return null;
			}
			return new int?((sceneInteractPoint as ISceneInteractTag).GetInteractTagId());
		}

		// Token: 0x0604601D RID: 286749 RVA: 0x0117392C File Offset: 0x01171B2C
		private void SyncTag(Entity entity, int? desiredTagId)
		{
			int? appliedTagId = this.AppliedTagId;
			int? num = desiredTagId;
			if (appliedTagId.GetValueOrDefault() == num.GetValueOrDefault() & appliedTagId != null == (num != null))
			{
				return;
			}
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				return;
			}
			if (this.AppliedTagId != null)
			{
				component.RemoveTag(this.AppliedTagId);
			}
			if (desiredTagId != null)
			{
				component.AddTag(desiredTagId);
			}
			this.AppliedTagId = desiredTagId;
		}

		// Token: 0x0604601E RID: 286750 RVA: 0x011739A2 File Offset: 0x01171BA2
		private static bool ImplementsSceneInteractTag(ISceneInteractPoint point)
		{
			return point is ISceneInteractTag;
		}

		// Token: 0x04024A68 RID: 150120
		private int? AppliedTagId;
	}
}
