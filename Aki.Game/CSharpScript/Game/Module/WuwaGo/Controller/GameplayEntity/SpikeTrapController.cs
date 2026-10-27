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
	// Token: 0x02004778 RID: 18296
	[NullableContext(1)]
	[Nullable(0)]
	public class SpikeTrapController : GameplayEntityControllerBase
	{
		// Token: 0x0602FD4D RID: 195917 RVA: 0x00B153E8 File Offset: 0x00B135E8
		public SpikeTrapController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x17007776 RID: 30582
		// (get) Token: 0x0602FD4E RID: 195918 RVA: 0x00B153F3 File Offset: 0x00B135F3
		private WuWaGoSpikeTrapEntity SpikeTrap
		{
			get
			{
				return this.Entity as WuWaGoSpikeTrapEntity;
			}
		}

		// Token: 0x0602FD4F RID: 195919 RVA: 0x00B15400 File Offset: 0x00B13600
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

		// Token: 0x0602FD50 RID: 195920 RVA: 0x00B15467 File Offset: 0x00B13667
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.IsDestroyed = true;
			this.SinkPresentationCancelToken++;
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x0602FD51 RID: 195921 RVA: 0x00B1548A File Offset: 0x00B1368A
		public override void OnRollbackRestore()
		{
			this.SinkPresentationCancelToken++;
		}

		// Token: 0x0602FD52 RID: 195922 RVA: 0x00B1549C File Offset: 0x00B1369C
		protected override UniTask OnExecuteAction()
		{
			SpikeTrapController.<OnExecuteAction>d__14 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<SpikeTrapController.<OnExecuteAction>d__14>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD53 RID: 195923 RVA: 0x00B154E0 File Offset: 0x00B136E0
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

		// Token: 0x0602FD54 RID: 195924 RVA: 0x00B1552C File Offset: 0x00B1372C
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

		// Token: 0x0602FD55 RID: 195925 RVA: 0x00B15578 File Offset: 0x00B13778
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

		// Token: 0x0602FD56 RID: 195926 RVA: 0x00B155D4 File Offset: 0x00B137D4
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

		// Token: 0x0602FD57 RID: 195927 RVA: 0x00B15620 File Offset: 0x00B13820
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

		// Token: 0x0602FD58 RID: 195928 RVA: 0x00B156A4 File Offset: 0x00B138A4
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

		// Token: 0x04019CD0 RID: 105680
		private static readonly int SinkStartDelayMs = 300;

		// Token: 0x04019CD1 RID: 105681
		private static readonly int DefaultFirstSinkDepthCm = 40;

		// Token: 0x04019CD2 RID: 105682
		private static readonly int FirstSinkDurationMs = 50;

		// Token: 0x04019CD3 RID: 105683
		private static readonly int FallSinkDepthCm = 180;

		// Token: 0x04019CD4 RID: 105684
		private static readonly int FallSinkDurationMs = 100;

		// Token: 0x04019CD5 RID: 105685
		private static readonly int SinkTickIntervalMs = 20;

		// Token: 0x04019CD6 RID: 105686
		private bool IsDestroyed;

		// Token: 0x04019CD7 RID: 105687
		private int SinkPresentationCancelToken;
	}
}
