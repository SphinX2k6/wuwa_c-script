using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200610C RID: 24844
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowFollowShooterReloadConfig : LevelFlowActionBase
	{
		// Token: 0x0603B8C1 RID: 243905 RVA: 0x010E2379 File Offset: 0x010E0579
		public LevelFlowFollowShooterReloadConfig Init(string configPath)
		{
			this.ConfigPath = configPath;
			return this;
		}

		// Token: 0x0603B8C2 RID: 243906 RVA: 0x010E2384 File Offset: 0x010E0584
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

		// Token: 0x0603B8C3 RID: 243907 RVA: 0x010E2490 File Offset: 0x010E0690
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

		// Token: 0x0401F672 RID: 128626
		private string ConfigPath = string.Empty;
	}
}
