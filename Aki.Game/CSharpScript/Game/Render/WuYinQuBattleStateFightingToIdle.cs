using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004597 RID: 17815
	public class WuYinQuBattleStateFightingToIdle : WuYinQuBattleStateBase
	{
		// Token: 0x0602DF09 RID: 188169 RVA: 0x00A905E0 File Offset: 0x00A8E7E0
		[NullableContext(1)]
		public WuYinQuBattleStateFightingToIdle(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x0602DF0A RID: 188170 RVA: 0x00A905F4 File Offset: 0x00A8E7F4
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

		// Token: 0x0602DF0B RID: 188171 RVA: 0x00A906EC File Offset: 0x00A8E8EC
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

		// Token: 0x0602DF0C RID: 188172 RVA: 0x00A907D4 File Offset: 0x00A8E9D4
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

		// Token: 0x0602DF0D RID: 188173 RVA: 0x00A90934 File Offset: 0x00A8EB34
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

		// Token: 0x0401885E RID: 100446
		private float Timer;

		// Token: 0x0401885F RID: 100447
		[Nullable(2)]
		private ULevelSequence SeqenceData;

		// Token: 0x04018860 RID: 100448
		private int SeqenceDataLoading = -1;
	}
}
