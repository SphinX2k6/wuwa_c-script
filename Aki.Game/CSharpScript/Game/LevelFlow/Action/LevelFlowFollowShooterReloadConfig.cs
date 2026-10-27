using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F8B RID: 28555
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowFollowShooterReloadConfig : LevelFlowActionBase
	{
		// Token: 0x06045713 RID: 284435 RVA: 0x01138575 File Offset: 0x01136775
		public LevelFlowFollowShooterReloadConfig Init(string configPath)
		{
			this.ConfigPath = configPath;
			return this;
		}

		// Token: 0x06045714 RID: 284436 RVA: 0x01138580 File Offset: 0x01136780
		protected override void OnExecute()
		{
			Entity entity = Global.BaseCharacter.CharacterActorComponent.Entity;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null;
			if (characterDriveVehicleComponent == null || characterDriveVehicleComponent.VehicleEntity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(96, 1);
				defaultInterpolatedStringHandler.AppendLiteral("LevelFlowFollowShooterReloadConfig OnExecute entityId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int?>((entity != null) ? new int?(entity.Id) : null);
				defaultInterpolatedStringHandler.AppendLiteral(" not found CharacterDriveVehicleComponent");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			EntityHandle playerFollowShooter = FollowUtils.GetPlayerFollowShooter(CreatureModel.Instance.GetPlayerId());
			FollowShooterComponent followShooterComponent;
			if (playerFollowShooter == null)
			{
				followShooterComponent = null;
			}
			else
			{
				WorldEntity entity2 = playerFollowShooter.Entity;
				followShooterComponent = ((entity2 != null) ? entity2.GetComponent<FollowShooterComponent>() : null);
			}
			FollowShooterComponent followShooterComponent2 = followShooterComponent;
			if (followShooterComponent2 == null)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "LevelFlowFollowShooterReloadConfig: shooterComp is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			followShooterComponent2.AsyncReloadConfig(this.ConfigPath);
			base.FinishExecute(true);
		}

		// Token: 0x06045715 RID: 284437 RVA: 0x0113868C File Offset: 0x0113688C
		protected unsafe override void LogExecuteInfo()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ConfigPath", this.ConfigPath);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x040243BD RID: 148413
		private string ConfigPath = string.Empty;
	}
}
