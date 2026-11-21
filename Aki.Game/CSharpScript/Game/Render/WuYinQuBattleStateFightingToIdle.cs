using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034BF RID: 13503
	public class WuYinQuBattleStateFightingToIdle : WuYinQuBattleStateBase
	{
		// Token: 0x060225F3 RID: 140787 RVA: 0x009BC800 File Offset: 0x009BAA00
		[NullableContext(1)]
		public WuYinQuBattleStateFightingToIdle(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x060225F4 RID: 140788 RVA: 0x009BC814 File Offset: 0x009BAA14
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			AKuroLevelSequenceActor levelSequenceActor = this.Owner.GetKuroLevelSequenceActor();
			if (levelSequenceActor != null && levelSequenceActor.IsValid())
			{
				ULevelSequencePlayer sequencePlayer = levelSequenceActor.SequencePlayer;
				if (sequencePlayer != null && sequencePlayer.IsValid())
				{
					this.SeqenceData = levelSequenceActor.GetSequence();
					ULevelSequence seqenceData = this.SeqenceData;
					if (seqenceData != null && seqenceData.IsValid())
					{
						levelSequenceActor.SetSequence(this.SeqenceData);
						this.OnEnterAsync();
						return;
					}
					Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.ZWY, "进入Fighting2Idle过度状态没有Sequence资源，开始资源加载。", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.SeqenceDataLoading = ResourceSystem.Instance.LoadAsync<ULevelSequence>(levelSequenceActor.LevelSequence.AssetPathName.ToString(), delegate([Nullable(2)] ULevelSequence data, string path)
					{
						this.SeqenceDataLoading = -1;
						if (data != null && data.IsValid())
						{
							this.SeqenceData = data;
							levelSequenceActor.SetSequence(this.SeqenceData);
							this.OnEnterAsync();
							return;
						}
						Log instance = Log.Instance;
						ELogModule module = ELogModule.RenderBattle;
						ELogAuthor author = ELogAuthor.ZWY;
						string message = "进入Fighting2Idle过度状态没有Sequence资源，资源加载失败。";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WuYinQuBattleActor", this.Owner);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}, 100, "js_undefined");
					return;
				}
			}
		}

		// Token: 0x060225F5 RID: 140789 RVA: 0x009BC90C File Offset: 0x009BAB0C
		private void OnEnterAsync()
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入Fighting2Idle过度状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			RenderModuleController.Instance.DecBattleReference();
			this.Owner.当前状态 = "战斗阶段到静止状态";
			PDA_WuYinQuBattleData_C wuYinQuFightingData = this.Owner.WuYinQuFightingData;
			AKuroLevelSequenceActor kuroLevelSequenceActor = this.Owner.GetKuroLevelSequenceActor();
			if (kuroLevelSequenceActor != null && kuroLevelSequenceActor.IsValid())
			{
				ULevelSequence sequence = kuroLevelSequenceActor.GetSequence();
				if (sequence != null && sequence.IsValid())
				{
					ULevelSequencePlayer sequencePlayer = kuroLevelSequenceActor.SequencePlayer;
					if (sequencePlayer != null && sequencePlayer.IsValid())
					{
						kuroLevelSequenceActor.SequencePlayer.Play();
						kuroLevelSequenceActor.SequencePlayer.JumpToMarkedFrame("FightingOverStart");
					}
				}
			}
			if (wuYinQuFightingData.FightingToIdleTransitionTime > 0f)
			{
				UCurveFloat fightingToIdleCurve = wuYinQuFightingData.FightingToIdleCurve;
				if (fightingToIdleCurve != null && fightingToIdleCurve.IsValid())
				{
					this.Timer = 0f;
					return;
				}
			}
			this.StateMachine.Switch(EWuYinQuBattleState.Idle);
		}

		// Token: 0x060225F6 RID: 140790 RVA: 0x009BC9F4 File Offset: 0x009BABF4
		protected override void OnUpdate(float delta)
		{
			if (this.Timer <= this.Owner.WuYinQuFightingData.FightingToIdleTransitionTime)
			{
				this.Timer += delta / 1000f;
				float inTime = MathUtils.Instance.Clamp(this.Timer / this.Owner.WuYinQuFightingData.FightingToIdleTransitionTime, 0f, 1f);
				float num = MathUtils.Instance.Clamp(this.Owner.WuYinQuFightingData.FightingToIdleCurve.GetFloatValue(inTime), 0f, 1f);
				PDA_WuYinQuBattleData_C wuYinQuFightingData = this.Owner.WuYinQuFightingData;
				UMaterialParameterCollection globalMPC = wuYinQuFightingData.GlobalMPC;
				if (globalMPC != null)
				{
					float floatValue = wuYinQuFightingData.LandscapeFadingRadiusCurve.GetFloatValue(inTime);
					FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
					UObject world = this.Owner.GetWorld();
					UMaterialParameterCollection collection = globalMPC;
					FName globalLandscapeCenterAndIntensity = WuYinQuBattleNameDefines.GlobalLandscapeCenterAndIntensity;
					FLinearColor flinearColor = new FLinearColor((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z, 1f);
					UKismetMaterialLibrary.SetVectorParameterValue(world, collection, globalLandscapeCenterAndIntensity, flinearColor);
					UObject world2 = this.Owner.GetWorld();
					UMaterialParameterCollection collection2 = globalMPC;
					FName globalLandscapeRadiusAndHardness = WuYinQuBattleNameDefines.GlobalLandscapeRadiusAndHardness;
					flinearColor = new FLinearColor(floatValue, 0.0001f, 0f, 0f);
					UKismetMaterialLibrary.SetVectorParameterValue(world2, collection2, globalLandscapeRadiusAndHardness, flinearColor);
					UKismetMaterialLibrary.SetScalarParameterValue(this.Owner.GetWorld(), globalMPC, WuYinQuBattleNameDefines.GlobalBlackStoneErosion, 1f - num);
				}
				return;
			}
			StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> stateMachine = this.StateMachine;
			if (stateMachine == null)
			{
				return;
			}
			stateMachine.Switch(EWuYinQuBattleState.Idle);
		}

		// Token: 0x060225F7 RID: 140791 RVA: 0x009BCB54 File Offset: 0x009BAD54
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出Fighting2Idle过度状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			UMaterialParameterCollection globalMPC = this.Owner.WuYinQuFightingData.GlobalMPC;
			if (globalMPC != null)
			{
				FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
				UObject world = this.Owner.GetWorld();
				UMaterialParameterCollection collection = globalMPC;
				FName globalLandscapeCenterAndIntensity = WuYinQuBattleNameDefines.GlobalLandscapeCenterAndIntensity;
				FLinearColor flinearColor = new FLinearColor((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z, 0f);
				UKismetMaterialLibrary.SetVectorParameterValue(world, collection, globalLandscapeCenterAndIntensity, flinearColor);
			}
			this.SeqenceData = null;
			if (this.SeqenceDataLoading != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SeqenceDataLoading);
				this.SeqenceDataLoading = -1;
				Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.ZWY, "退出Fighting2Idle过度状态时还在加载资源，取消资源加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x04012E99 RID: 77465
		private float Timer;

		// Token: 0x04012E9A RID: 77466
		[Nullable(2)]
		private ULevelSequence SeqenceData;

		// Token: 0x04012E9B RID: 77467
		private int SeqenceDataLoading = -1;
	}
}
