using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A9 RID: 13993
	[NullableContext(1)]
	[Nullable(0)]
	public class SpikeTrapController : GameplayEntityControllerBase
	{
		// Token: 0x06024517 RID: 148759 RVA: 0x00A45448 File Offset: 0x00A43648
		public SpikeTrapController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x06024518 RID: 148760 RVA: 0x00A45453 File Offset: 0x00A43653
		private WuWaGoSpikeTrapEntity SpikeTrap
		{
			get
			{
				return this.Entity as WuWaGoSpikeTrapEntity;
			}
		}

		// Token: 0x06024519 RID: 148761 RVA: 0x00A45460 File Offset: 0x00A43660
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			this.IsDestroyed = false;
			WuWaGoGrid gridById = this.GameData.GetGridById(this.Entity.StandGridId);
			int? num = (gridById != null) ? new int?(gridById.OccupiedUnitId) : null;
			this.SpikeTrap.ResetOccupantTrackingBaseline(num.GetValueOrDefault());
			base.RegisterAttachedGridMoveParticipant();
			return true;
		}

		// Token: 0x0602451A RID: 148762 RVA: 0x00A454C7 File Offset: 0x00A436C7
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.IsDestroyed = true;
			this.SinkPresentationCancelToken++;
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x0602451B RID: 148763 RVA: 0x00A454EA File Offset: 0x00A436EA
		public override void OnRollbackRestore()
		{
			this.SinkPresentationCancelToken++;
		}

		// Token: 0x0602451C RID: 148764 RVA: 0x00A454FC File Offset: 0x00A436FC
		protected override UniTask OnExecuteAction()
		{
			SpikeTrapController.<OnExecuteAction>d__14 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<SpikeTrapController.<OnExecuteAction>d__14>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602451D RID: 148765 RVA: 0x00A45540 File Offset: 0x00A43740
		private int GetFirstSinkDepthCm()
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int? num = (setting != null) ? new int?(setting.SpikeFallHeight) : null;
			if (num != null && num.GetValueOrDefault() > 0)
			{
				return num.Value;
			}
			return SpikeTrapController.DefaultFirstSinkDepthCm;
		}

		// Token: 0x0602451E RID: 148766 RVA: 0x00A4558C File Offset: 0x00A4378C
		private UniTask TakeAttackOnRole(WuWaGoRole role)
		{
			SpikeTrapController.<TakeAttackOnRole>d__16 <TakeAttackOnRole>d__;
			<TakeAttackOnRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TakeAttackOnRole>d__.<>4__this = this;
			<TakeAttackOnRole>d__.role = role;
			<TakeAttackOnRole>d__.<>1__state = -1;
			<TakeAttackOnRole>d__.<>t__builder.Start<SpikeTrapController.<TakeAttackOnRole>d__16>(ref <TakeAttackOnRole>d__);
			return <TakeAttackOnRole>d__.<>t__builder.Task;
		}

		// Token: 0x0602451F RID: 148767 RVA: 0x00A455D8 File Offset: 0x00A437D8
		private UniTask PlaySinkOnRole(WuWaGoRole role, int depthCm, int durationMs)
		{
			SpikeTrapController.<PlaySinkOnRole>d__17 <PlaySinkOnRole>d__;
			<PlaySinkOnRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySinkOnRole>d__.<>4__this = this;
			<PlaySinkOnRole>d__.role = role;
			<PlaySinkOnRole>d__.depthCm = depthCm;
			<PlaySinkOnRole>d__.durationMs = durationMs;
			<PlaySinkOnRole>d__.<>1__state = -1;
			<PlaySinkOnRole>d__.<>t__builder.Start<SpikeTrapController.<PlaySinkOnRole>d__17>(ref <PlaySinkOnRole>d__);
			return <PlaySinkOnRole>d__.<>t__builder.Task;
		}

		// Token: 0x06024520 RID: 148768 RVA: 0x00A45634 File Offset: 0x00A43834
		[NullableContext(0)]
		private UniTask<bool> WaitSinkStartDelay(int expectedToken)
		{
			SpikeTrapController.<WaitSinkStartDelay>d__18 <WaitSinkStartDelay>d__;
			<WaitSinkStartDelay>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WaitSinkStartDelay>d__.<>4__this = this;
			<WaitSinkStartDelay>d__.expectedToken = expectedToken;
			<WaitSinkStartDelay>d__.<>1__state = -1;
			<WaitSinkStartDelay>d__.<>t__builder.Start<SpikeTrapController.<WaitSinkStartDelay>d__18>(ref <WaitSinkStartDelay>d__);
			return <WaitSinkStartDelay>d__.<>t__builder.Task;
		}

		// Token: 0x06024521 RID: 148769 RVA: 0x00A45680 File Offset: 0x00A43880
		private bool TryResolveSinkTargetWorldPosition(WuWaGoRole role, int depthCm, Vector @out)
		{
			WuWaGoGrid gridById = this.GameData.GetGridById(role.StandGridId);
			Transform originTransform = this.GameData.OriginTransform;
			if (gridById == null || originTransform == null || depthCm <= 0)
			{
				return false;
			}
			Vector vector = Vector.Create();
			if (!this.TryResolveGridSurfaceNormalLocal(gridById, vector))
			{
				return false;
			}
			Vector v = vector.Multiply((double)(-(double)depthCm), Vector.Create());
			Vector vector2 = Vector.Create();
			originTransform.TransformVector(v, vector2);
			Vector.Create(role.GetWorldLocation()).Addition(vector2, @out);
			return true;
		}

		// Token: 0x06024522 RID: 148770 RVA: 0x00A45704 File Offset: 0x00A43904
		private bool TryResolveGridSurfaceNormalLocal(WuWaGoGrid grid, Vector @out)
		{
			EGridShape gridShape = grid.GridShape;
			if (gridShape != EGridShape.Vertical)
			{
				if (gridShape == EGridShape.Horizontal)
				{
					@out.DeepCopy(Vector.UpVectorProxy);
					return true;
				}
				return false;
			}
			else
			{
				if (grid.WallFrame == null)
				{
					return false;
				}
				@out.Set((double)(-(double)grid.WallFrame.WallNormalX * grid.WallFrame.OwnerSign), (double)(-(double)grid.WallFrame.WallNormalY * grid.WallFrame.OwnerSign), 0.0);
				return true;
			}
		}

		// Token: 0x04014380 RID: 82816
		private static readonly int SinkStartDelayMs = 300;

		// Token: 0x04014381 RID: 82817
		private static readonly int DefaultFirstSinkDepthCm = 40;

		// Token: 0x04014382 RID: 82818
		private static readonly int FirstSinkDurationMs = 50;

		// Token: 0x04014383 RID: 82819
		private static readonly int FallSinkDepthCm = 180;

		// Token: 0x04014384 RID: 82820
		private static readonly int FallSinkDurationMs = 100;

		// Token: 0x04014385 RID: 82821
		private static readonly int SinkTickIntervalMs = 20;

		// Token: 0x04014386 RID: 82822
		private bool IsDestroyed;

		// Token: 0x04014387 RID: 82823
		private int SinkPresentationCancelToken;
	}
}
