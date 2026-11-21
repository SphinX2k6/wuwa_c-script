using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using CSharpScript.Game.NewWorld.Player.Component;

namespace CSharpScript.Game.NewWorld.Player.Ability
{
	// Token: 0x020061DC RID: 25052
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSceneInteractTagAbility : LevelEntityAbilityBase
	{
		// Token: 0x0603C20C RID: 246284 RVA: 0x0111D436 File Offset: 0x0111B636
		public PlayerSceneInteractTagAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603C20D RID: 246285 RVA: 0x0111D444 File Offset: 0x0111B644
		public override bool ShouldActivate(Entity entity)
		{
			return this.GetBestInteractTagId(entity) != null;
		}

		// Token: 0x0603C20E RID: 246286 RVA: 0x0111D460 File Offset: 0x0111B660
		public override bool ShouldDeactivate(Entity entity)
		{
			return this.GetBestInteractTagId(entity) == null;
		}

		// Token: 0x0603C20F RID: 246287 RVA: 0x0111D47F File Offset: 0x0111B67F
		public override void OnActivated(Entity entity)
		{
			this.SyncTag(entity, this.GetBestInteractTagId(entity));
		}

		// Token: 0x0603C210 RID: 246288 RVA: 0x0111D48F File Offset: 0x0111B68F
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			this.SyncTag(entity, this.GetBestInteractTagId(entity));
		}

		// Token: 0x0603C211 RID: 246289 RVA: 0x0111D4A0 File Offset: 0x0111B6A0
		public override void OnDeactivated(Entity entity)
		{
			this.SyncTag(entity, null);
		}

		// Token: 0x0603C212 RID: 246290 RVA: 0x0111D4C0 File Offset: 0x0111B6C0
		public override void OnDestroy(Entity entity)
		{
			this.SyncTag(entity, null);
		}

		// Token: 0x0603C213 RID: 246291 RVA: 0x0111D4E0 File Offset: 0x0111B6E0
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

		// Token: 0x0603C214 RID: 246292 RVA: 0x0111D528 File Offset: 0x0111B728
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

		// Token: 0x0603C215 RID: 246293 RVA: 0x0111D59E File Offset: 0x0111B79E
		private static bool ImplementsSceneInteractTag(ISceneInteractPoint point)
		{
			return point is ISceneInteractTag;
		}

		// Token: 0x17007174 RID: 29044
		// (get) Token: 0x0603C216 RID: 246294 RVA: 0x0111D5A9 File Offset: 0x0111B7A9
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FD1E RID: 130334
		private int? AppliedTagId;
	}
}
