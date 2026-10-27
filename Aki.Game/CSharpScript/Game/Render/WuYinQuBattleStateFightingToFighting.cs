using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004596 RID: 17814
	public class WuYinQuBattleStateFightingToFighting : WuYinQuBattleStateBase
	{
		// Token: 0x0602DF04 RID: 188164 RVA: 0x00A9014C File Offset: 0x00A8E34C
		[NullableContext(1)]
		public WuYinQuBattleStateFightingToFighting(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x0602DF05 RID: 188165 RVA: 0x00A90160 File Offset: 0x00A8E360
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
					Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.ZWY, "进入战斗过渡状态时没有Sequence资源，开始资源加载。", default(ReadOnlySpan<ValueTuple<string, object>>));
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
						string message = "进入战斗过渡状态时没有Sequence资源，资源加载失败。";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WuYinQuBattleActor", this.Owner);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}, 100, "js_undefined");
					return;
				}
			}
		}

		// Token: 0x0602DF06 RID: 188166 RVA: 0x00A90258 File Offset: 0x00A8E458
		private void OnEnterAsync()
		{
			this.Timer = 0f;
			EWuYinQuState lastBattleState = this.Owner.GetLastBattleState();
			EWuYinQuState currentBattleState = this.Owner.GetCurrentBattleState();
			string text;
			switch (lastBattleState)
			{
			case EWuYinQuState.StateFighting1:
				text = "战斗阶段1";
				break;
			case EWuYinQuState.StateFighting2:
				text = "战斗阶段2";
				break;
			case EWuYinQuState.StateFighting3:
				text = "战斗阶段3";
				break;
			default:
				text = "未知状态";
				break;
			}
			string str = text;
			AKuroLevelSequenceActor kuroLevelSequenceActor = this.Owner.GetKuroLevelSequenceActor();
			string str2 = "未知状态";
			if (currentBattleState == EWuYinQuState.StateFighting1)
			{
				str2 = "战斗阶段1";
				if (kuroLevelSequenceActor != null && kuroLevelSequenceActor.IsValid())
				{
					ULevelSequence sequence = kuroLevelSequenceActor.GetSequence();
					if (sequence != null && sequence.IsValid())
					{
						ULevelSequencePlayer sequencePlayer = kuroLevelSequenceActor.SequencePlayer;
						if (sequencePlayer != null && sequencePlayer.IsValid())
						{
							kuroLevelSequenceActor.SequencePlayer.JumpToMarkedFrame("FightingStart1");
							kuroLevelSequenceActor.SequencePlayer.Play();
						}
					}
				}
			}
			else if (currentBattleState == EWuYinQuState.StateFighting2)
			{
				str2 = "战斗阶段2";
				if (kuroLevelSequenceActor != null && kuroLevelSequenceActor.IsValid())
				{
					ULevelSequence sequence2 = kuroLevelSequenceActor.GetSequence();
					if (sequence2 != null && sequence2.IsValid())
					{
						ULevelSequencePlayer sequencePlayer2 = kuroLevelSequenceActor.SequencePlayer;
						if (sequencePlayer2 != null && sequencePlayer2.IsValid())
						{
							kuroLevelSequenceActor.SequencePlayer.JumpToMarkedFrame("FightingStart2");
							kuroLevelSequenceActor.SequencePlayer.Play();
						}
					}
				}
			}
			else if (currentBattleState == EWuYinQuState.StateFighting3)
			{
				str2 = "战斗阶段3";
				if (kuroLevelSequenceActor != null && kuroLevelSequenceActor.IsValid())
				{
					ULevelSequence sequence3 = kuroLevelSequenceActor.GetSequence();
					if (sequence3 != null && sequence3.IsValid())
					{
						ULevelSequencePlayer sequencePlayer3 = kuroLevelSequenceActor.SequencePlayer;
						if (sequencePlayer3 != null && sequencePlayer3.IsValid())
						{
							kuroLevelSequenceActor.SequencePlayer.JumpToMarkedFrame("FightingStart3");
							kuroLevelSequenceActor.SequencePlayer.Play();
						}
					}
				}
			}
			UMaterialParameterCollection globalMPC = this.Owner.WuYinQuFightingData.GlobalMPC;
			PDA_WuYinQuBattleData_C wuYinQuFightingData = this.Owner.WuYinQuFightingData;
			if (globalMPC != null)
			{
				FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
				UObject world = this.Owner.GetWorld();
				UMaterialParameterCollection collection = globalMPC;
				FName globalLandscapeCenterAndIntensity = WuYinQuBattleNameDefines.GlobalLandscapeCenterAndIntensity;
				FLinearColor flinearColor = new FLinearColor((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z, 1f);
				UKismetMaterialLibrary.SetVectorParameterValue(world, collection, globalLandscapeCenterAndIntensity, flinearColor);
				UObject world2 = this.Owner.GetWorld();
				UMaterialParameterCollection collection2 = globalMPC;
				FName globalLandscapeRadiusAndHardness = WuYinQuBattleNameDefines.GlobalLandscapeRadiusAndHardness;
				flinearColor = new FLinearColor(wuYinQuFightingData.LandscapeShowingRadiusCurve.GetFloatValue(1f), 0.0001f, 0f, 0f);
				UKismetMaterialLibrary.SetVectorParameterValue(world2, collection2, globalLandscapeRadiusAndHardness, flinearColor);
			}
			this.Owner.当前状态 = "从:" + str + "到:" + str2;
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入战斗过度阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602DF07 RID: 188167 RVA: 0x00A904EC File Offset: 0x00A8E6EC
		protected override void OnUpdate(float delta)
		{
			EWuYinQuState currentBattleState = this.Owner.GetCurrentBattleState();
			if (this.Timer > this.Owner.WuYinQuFightingData.FightingTransitionTime)
			{
				if (currentBattleState == EWuYinQuState.StateFighting2)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting2);
					return;
				}
				if (currentBattleState == EWuYinQuState.StateFighting3)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting3);
					return;
				}
				Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.HCS, "战斗过度状态错误!!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.Timer += delta / 1000f;
		}

		// Token: 0x0602DF08 RID: 188168 RVA: 0x00A90574 File Offset: 0x00A8E774
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出战斗过度阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SeqenceData = null;
			if (this.SeqenceDataLoading != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SeqenceDataLoading);
				this.SeqenceDataLoading = -1;
				Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.ZWY, "退出战斗过渡状态时还在加载资源，取消资源加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x04018859 RID: 100441
		protected float Timer;

		// Token: 0x0401885A RID: 100442
		protected bool LastUseFlowmapSky;

		// Token: 0x0401885B RID: 100443
		protected bool CurrentUseFlowmapSky;

		// Token: 0x0401885C RID: 100444
		[Nullable(2)]
		private ULevelSequence SeqenceData;

		// Token: 0x0401885D RID: 100445
		private int SeqenceDataLoading = -1;
	}
}
