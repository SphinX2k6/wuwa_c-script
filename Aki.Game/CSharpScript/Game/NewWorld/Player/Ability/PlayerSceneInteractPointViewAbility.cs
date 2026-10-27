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
	// Token: 0x0200705A RID: 28762
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSceneInteractPointViewAbility : LevelEntityAbilityBase, IStaticVariableResetter
	{
		// Token: 0x06046006 RID: 286726 RVA: 0x011735D6 File Offset: 0x011717D6
		static PlayerSceneInteractPointViewAbility()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerSceneInteractPointViewAbility.CreateStaticDefaultValue), new Action(PlayerSceneInteractPointViewAbility.ResetStaticDefaultValue));
		}

		// Token: 0x06046007 RID: 286727 RVA: 0x011735F5 File Offset: 0x011717F5
		public PlayerSceneInteractPointViewAbility(ELevelEntityAbilityType type, EAbilityTickPhase tickPhase, int tickOrder, bool needTickActivate) : base(type, tickPhase, tickOrder, needTickActivate)
		{
		}

		// Token: 0x06046008 RID: 286728 RVA: 0x01173602 File Offset: 0x01171802
		public override bool ShouldActivate(Entity entity)
		{
			return this.ShouldShowInteractPoint(entity);
		}

		// Token: 0x06046009 RID: 286729 RVA: 0x0117360B File Offset: 0x0117180B
		public override bool ShouldDeactivate(Entity entity)
		{
			return !this.ShouldShowInteractPoint(entity);
		}

		// Token: 0x0604600A RID: 286730 RVA: 0x01173617 File Offset: 0x01171817
		public override void OnActivated(Entity entity)
		{
			this.CacheTargetLocation(entity);
			this.TryActivateInteractPoint(this.GetBestInteractType(entity)).Forget();
		}

		// Token: 0x0604600B RID: 286731 RVA: 0x01173632 File Offset: 0x01171832
		public override void OnDeactivated(Entity entity)
		{
			this.CacheTargetLocation(entity);
			this.TryDeactivateInteractPoint();
		}

		// Token: 0x0604600C RID: 286732 RVA: 0x01173644 File Offset: 0x01171844
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

		// Token: 0x0604600D RID: 286733 RVA: 0x011736C9 File Offset: 0x011718C9
		private bool ShouldShowInteractPoint(Entity entity)
		{
			if (SceneInteractPointManager.Instance.PointSize == 0)
			{
				return false;
			}
			PlayerSceneInteractComponent component = entity.GetComponent<PlayerSceneInteractComponent>();
			return ((component != null) ? component.GetBestInteractPoint() : null) != null;
		}

		// Token: 0x0604600E RID: 286734 RVA: 0x011736EE File Offset: 0x011718EE
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

		// Token: 0x0604600F RID: 286735 RVA: 0x01173701 File Offset: 0x01171901
		private ESceneInteractType GetBestInteractType(Entity entity)
		{
			ISceneInteractPoint bestInteractPoint = this.GetBestInteractPoint(entity);
			if (bestInteractPoint == null)
			{
				return ESceneInteractType.None;
			}
			return bestInteractPoint.GetInteractType();
		}

		// Token: 0x06046010 RID: 286736 RVA: 0x01173715 File Offset: 0x01171915
		private void CacheTargetLocation(Entity entity)
		{
			ISceneInteractPoint bestInteractPoint = this.GetBestInteractPoint(entity);
			this.TargetLocation = ((bestInteractPoint != null) ? bestInteractPoint.GetLocation() : null);
		}

		// Token: 0x06046011 RID: 286737 RVA: 0x01173730 File Offset: 0x01171930
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

		// Token: 0x06046012 RID: 286738 RVA: 0x0117377B File Offset: 0x0117197B
		private void TryDeactivateInteractPoint()
		{
			if (this.InteractPoint != null)
			{
				this.InteractPoint.Destroy(null);
				this.InteractPoint = null;
			}
			this.CurrentInteractType = null;
		}

		// Token: 0x06046013 RID: 286739 RVA: 0x011737A4 File Offset: 0x011719A4
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

		// Token: 0x06046014 RID: 286740 RVA: 0x01173833 File Offset: 0x01171A33
		public static void ResetStaticDefaultValue()
		{
			PlayerSceneInteractPointViewAbility.interactPointViewCreateInfos = null;
		}

		// Token: 0x04024A64 RID: 150116
		private static Dictionary<ESceneInteractType, PlayerSceneInteractPointViewAbility.SceneInteractPointViewCreateInfo> interactPointViewCreateInfos;

		// Token: 0x04024A65 RID: 150117
		[Nullable(2)]
		protected SceneInteractPointViewBase InteractPoint;

		// Token: 0x04024A66 RID: 150118
		[Nullable(2)]
		protected Vector TargetLocation;

		// Token: 0x04024A67 RID: 150119
		private ESceneInteractType? CurrentInteractType;

		// Token: 0x0200CE2D RID: 52781
		[Nullable(0)]
		private class SceneInteractPointViewCreateInfo
		{
			// Token: 0x0403E18F RID: 254351
			public string ResourceId;

			// Token: 0x0403E190 RID: 254352
			public Func<SceneInteractPointViewBase> CreateView;
		}
	}
}
