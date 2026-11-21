using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using CSharpScript.Game.LevelGamePlay.SceneInteract.View;
using CSharpScript.Game.NewWorld.Player.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.NewWorld.Player.Ability
{
	// Token: 0x020061DB RID: 25051
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSceneInteractPointViewAbility : LevelEntityAbilityBase, IStaticVariableResetter
	{
		// Token: 0x0603C1FC RID: 246268 RVA: 0x0111D1D0 File Offset: 0x0111B3D0
		static PlayerSceneInteractPointViewAbility()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerSceneInteractPointViewAbility.CreateStaticDefaultValue), new Action(PlayerSceneInteractPointViewAbility.ResetStaticDefaultValue));
		}

		// Token: 0x0603C1FD RID: 246269 RVA: 0x0111D1EF File Offset: 0x0111B3EF
		public PlayerSceneInteractPointViewAbility(ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) : base(type, tickPhase, tickOrder, needTickActivate)
		{
		}

		// Token: 0x0603C1FE RID: 246270 RVA: 0x0111D1FC File Offset: 0x0111B3FC
		public override bool ShouldActivate(Entity entity)
		{
			return this.ShouldShowInteractPoint(entity);
		}

		// Token: 0x0603C1FF RID: 246271 RVA: 0x0111D205 File Offset: 0x0111B405
		public override bool ShouldDeactivate(Entity entity)
		{
			return !this.ShouldShowInteractPoint(entity);
		}

		// Token: 0x0603C200 RID: 246272 RVA: 0x0111D211 File Offset: 0x0111B411
		public override void OnActivated(Entity entity)
		{
			this.CacheTargetLocation(entity);
			this.TryActivateInteractPoint(this.GetBestInteractType(entity)).Forget();
		}

		// Token: 0x0603C201 RID: 246273 RVA: 0x0111D22C File Offset: 0x0111B42C
		public override void OnDeactivated(Entity entity)
		{
			this.CacheTargetLocation(entity);
			this.TryDeactivateInteractPoint();
		}

		// Token: 0x0603C202 RID: 246274 RVA: 0x0111D23C File Offset: 0x0111B43C
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			this.CacheTargetLocation(entity);
			ESceneInteractType bestInteractType = this.GetBestInteractType(entity);
			if (this.CurrentInteractType != null)
			{
				ESceneInteractType? currentInteractType = this.CurrentInteractType;
				ESceneInteractType esceneInteractType = bestInteractType;
				if (!(currentInteractType.GetValueOrDefault() == esceneInteractType & currentInteractType != null))
				{
					this.TryDeactivateInteractPoint();
					this.TryActivateInteractPoint(bestInteractType).Forget();
					return;
				}
			}
			if (this.InteractPoint != null && this.TargetLocation != null)
			{
				this.InteractPoint.UpdateTargetLocation(this.TargetLocation);
				this.InteractPoint.RefreshPosition();
			}
		}

		// Token: 0x0603C203 RID: 246275 RVA: 0x0111D2C1 File Offset: 0x0111B4C1
		private bool ShouldShowInteractPoint(Entity entity)
		{
			if (SceneInteractPointManager.Instance.PointSize == 0)
			{
				return false;
			}
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			return ((component != null) ? component.GetBestInteractPoint() : null) != null;
		}

		// Token: 0x0603C204 RID: 246276 RVA: 0x0111D2E6 File Offset: 0x0111B4E6
		[return: Nullable(2)]
		private ISceneInteractPoint GetBestInteractPoint(Entity entity)
		{
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			if (component == null)
			{
				return null;
			}
			return component.GetBestInteractPoint();
		}

		// Token: 0x0603C205 RID: 246277 RVA: 0x0111D2F9 File Offset: 0x0111B4F9
		private ESceneInteractType GetBestInteractType(Entity entity)
		{
			ISceneInteractPoint bestInteractPoint = this.GetBestInteractPoint(entity);
			if (bestInteractPoint == null)
			{
				return ESceneInteractType.None;
			}
			return bestInteractPoint.GetInteractType();
		}

		// Token: 0x0603C206 RID: 246278 RVA: 0x0111D30D File Offset: 0x0111B50D
		private void CacheTargetLocation(Entity entity)
		{
			ISceneInteractPoint bestInteractPoint = this.GetBestInteractPoint(entity);
			this.TargetLocation = ((bestInteractPoint != null) ? bestInteractPoint.GetLocation() : null);
		}

		// Token: 0x0603C207 RID: 246279 RVA: 0x0111D328 File Offset: 0x0111B528
		private UniTask TryActivateInteractPoint(ESceneInteractType interactType)
		{
			PlayerSceneInteractPointViewAbility.<TryActivateInteractPoint>d__16 <TryActivateInteractPoint>d__;
			<TryActivateInteractPoint>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryActivateInteractPoint>d__.<>4__this = this;
			<TryActivateInteractPoint>d__.interactType = interactType;
			<TryActivateInteractPoint>d__.<>1__state = -1;
			<TryActivateInteractPoint>d__.<>t__builder.Start<PlayerSceneInteractPointViewAbility.<TryActivateInteractPoint>d__16>(ref <TryActivateInteractPoint>d__);
			return <TryActivateInteractPoint>d__.<>t__builder.Task;
		}

		// Token: 0x0603C208 RID: 246280 RVA: 0x0111D373 File Offset: 0x0111B573
		private void TryDeactivateInteractPoint()
		{
			if (this.InteractPoint != null)
			{
				this.InteractPoint.Destroy(null);
				this.InteractPoint = null;
			}
			this.CurrentInteractType = null;
		}

		// Token: 0x0603C209 RID: 246281 RVA: 0x0111D39C File Offset: 0x0111B59C
		public static void CreateStaticDefaultValue()
		{
			Dictionary<ESceneInteractType, PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo> dictionary = new Dictionary<ESceneInteractType, PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo>();
			ESceneInteractType key = ESceneInteractType.None;
			PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo sceneInteractPointViewCreateInfo = new PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo();
			sceneInteractPointViewCreateInfo.ResourceId = "UiItem_Gousuo";
			sceneInteractPointViewCreateInfo.CreateView = (() => new SceneInteractPointView());
			dictionary[key] = sceneInteractPointViewCreateInfo;
			ESceneInteractType key2 = ESceneInteractType.FoxJumping;
			PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo sceneInteractPointViewCreateInfo2 = new PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo();
			sceneInteractPointViewCreateInfo2.ResourceId = "UiItem_TrackedMarkJump";
			sceneInteractPointViewCreateInfo2.CreateView = (() => new SceneInteractTrackedMarkJumpView());
			dictionary[key2] = sceneInteractPointViewCreateInfo2;
			PlayerSceneInteractPointViewAbility.interactPointViewCreateInfos = dictionary;
		}

		// Token: 0x0603C20A RID: 246282 RVA: 0x0111D42B File Offset: 0x0111B62B
		public static void ResetStaticDefaultValue()
		{
			PlayerSceneInteractPointViewAbility.interactPointViewCreateInfos = null;
		}

		// Token: 0x17007173 RID: 29043
		// (get) Token: 0x0603C20B RID: 246283 RVA: 0x0111D433 File Offset: 0x0111B633
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FD1A RID: 130330
		private static Dictionary<ESceneInteractType, PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo> interactPointViewCreateInfos;

		// Token: 0x0401FD1B RID: 130331
		[Nullable(2)]
		protected SceneInteractPointViewBase InteractPoint;

		// Token: 0x0401FD1C RID: 130332
		[Nullable(2)]
		protected Vector TargetLocation;

		// Token: 0x0401FD1D RID: 130333
		private ESceneInteractType? CurrentInteractType;

		// Token: 0x0200BA1E RID: 47646
		[Nullable(0)]
		private class SceneInteractPointViewCreateInfo
		{
			// Token: 0x040395BA RID: 234938
			public string ResourceId;

			// Token: 0x040395BB RID: 234939
			public Func<SceneInteractPointViewBase> CreateView;
		}
	}
}
