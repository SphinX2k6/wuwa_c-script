using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034C1 RID: 13505
	public class WuYinQuBattleStateIdleToFighting : WuYinQuBattleStateBase
	{
		// Token: 0x060225FD RID: 140797 RVA: 0x009BCC71 File Offset: 0x009BAE71
		[NullableContext(1)]
		public WuYinQuBattleStateIdleToFighting(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x060225FE RID: 140798 RVA: 0x009BCC84 File Offset: 0x009BAE84
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
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderBattle;
					ELogAuthor author = ELogAuthor.ZWY;
					string message = "进入Idle2Fighting的过度状态时没有Sequence资源，开始资源加载。";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WuYinQuBattleActor", this.Owner);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					string path = levelSequenceActor.LevelSequence.AssetPathName.ToString();
					this.SeqenceDataLoading = ResourceSystem.Instance.LoadAsync<ULevelSequence>(path, delegate([Nullable(2)] ULevelSequence data, string _)
					{
						this.SeqenceDataLoading = -1;
						if (data != null && data.IsValid())
						{
							this.SeqenceData = data;
							levelSequenceActor.SetSequence(this.SeqenceData);
							this.OnEnterAsync();
							return;
						}
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.RenderBattle;
						ELogAuthor author2 = ELogAuthor.ZWY;
						string message2 = "进入Idle2Fighting的过度状态时没有Sequence资源，资源加载失败。";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("WuYinQuBattleActor", this.Owner);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}, 100, "js_undefined");
					return;
				}
			}
		}

		// Token: 0x060225FF RID: 140799 RVA: 0x009BCD90 File Offset: 0x009BAF90
		private void OnEnterAsync()
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入Idle2Fighting的过度状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Owner.当前状态 = "静止状态到战斗阶段1";
			PDA_WuYinQuBattleData_C wuYinQuFightingData = this.Owner.WuYinQuFightingData;
			FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
			RenderModuleController.Instance.AddBattleReference(fvectorDouble);
			AKuroLevelSequenceActor kuroLevelSequenceActor = this.Owner.GetKuroLevelSequenceActor();
			if (kuroLevelSequenceActor != null && kuroLevelSequenceActor.IsValid())
			{
				ULevelSequence sequence = kuroLevelSequenceActor.GetSequence();
				if (sequence != null && sequence.IsValid())
				{
					ULevelSequencePlayer sequencePlayer = kuroLevelSequenceActor.SequencePlayer;
					if (sequencePlayer != null && sequencePlayer.IsValid())
					{
						if (kuroLevelSequenceActor.SequencePlayer.IsPlaying())
						{
							kuroLevelSequenceActor.SequencePlayer.Stop();
						}
						kuroLevelSequenceActor.SequencePlayer.Play();
						kuroLevelSequenceActor.SequencePlayer.JumpToMarkedFrame("FightingStart1");
					}
				}
			}
			if (wuYinQuFightingData.IdleToFightingTransitionTime > 0f)
			{
				UCurveFloat idleToFightingCurve = wuYinQuFightingData.IdleToFightingCurve;
				if (idleToFightingCurve != null && idleToFightingCurve.IsValid())
				{
					this.Timer = 0f;
					UMaterialParameterCollection globalMPC = this.Owner.WuYinQuFightingData.GlobalMPC;
					if (globalMPC != null)
					{
						UObject world = this.Owner.GetWorld();
						UMaterialParameterCollection collection = globalMPC;
						FName globalLandscapeCenterAndIntensity = WuYinQuBattleNameDefines.GlobalLandscapeCenterAndIntensity;
						FLinearColor flinearColor = new FLinearColor((float)fvectorDouble.X, (float)fvectorDouble.Y, (float)fvectorDouble.Z, 1f);
						UKismetMaterialLibrary.SetVectorParameterValue(world, collection, globalLandscapeCenterAndIntensity, flinearColor);
						UObject world2 = this.Owner.GetWorld();
						UMaterialParameterCollection collection2 = globalMPC;
						FName globalLandscapeRadiusAndHardness = WuYinQuBattleNameDefines.GlobalLandscapeRadiusAndHardness;
						flinearColor = new FLinearColor(0f, 0.0001f, 0f, 0f);
						UKismetMaterialLibrary.SetVectorParameterValue(world2, collection2, globalLandscapeRadiusAndHardness, flinearColor);
						UKismetMaterialLibrary.SetScalarParameterValue(this.Owner.GetWorld(), globalMPC, WuYinQuBattleNameDefines.GlobalBlackStoneErosion, 0f);
					}
					return;
				}
			}
			StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> stateMachine = this.StateMachine;
			if (stateMachine == null)
			{
				return;
			}
			stateMachine.Switch(EWuYinQuBattleState.Fighting1);
		}

		// Token: 0x06022600 RID: 140800 RVA: 0x009BCF44 File Offset: 0x009BB144
		protected override void OnUpdate(float delta)
		{
			if (this.Timer > this.Owner.WuYinQuFightingData.IdleToFightingTransitionTime)
			{
				this.StateMachine.Switch(EWuYinQuBattleState.Fighting1);
				return;
			}
			this.Timer += delta / 1000f;
			float inTime = MathUtils.Instance.Clamp(this.Timer / this.Owner.WuYinQuFightingData.IdleToFightingTransitionTime, 0f, 1f);
			float parameterValue = MathUtils.Instance.Clamp(this.Owner.WuYinQuFightingData.IdleToFightingCurve.GetFloatValue(inTime), 0f, 1f);
			PDA_WuYinQuBattleData_C wuYinQuFightingData = this.Owner.WuYinQuFightingData;
			float floatValue = wuYinQuFightingData.LandscapeShowingRadiusCurve.GetFloatValue(inTime);
			UMaterialParameterCollection globalMPC = wuYinQuFightingData.GlobalMPC;
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
				flinearColor = new FLinearColor(floatValue, 0.0001f, 0f, 0f);
				UKismetMaterialLibrary.SetVectorParameterValue(world2, collection2, globalLandscapeRadiusAndHardness, flinearColor);
				UKismetMaterialLibrary.SetScalarParameterValue(this.Owner.GetWorld(), globalMPC, WuYinQuBattleNameDefines.GlobalBlackStoneErosion, parameterValue);
			}
		}

		// Token: 0x06022601 RID: 140801 RVA: 0x009BD098 File Offset: 0x009BB298
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出Idle2Fighting的过度状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SeqenceData = null;
			if (this.SeqenceDataLoading != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SeqenceDataLoading);
				this.SeqenceDataLoading = -1;
				Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.ZWY, "退出Idle2Fighting的过度状态时还在加载资源，取消资源加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x04012E9C RID: 77468
		private float Timer;

		// Token: 0x04012E9D RID: 77469
		[Nullable(2)]
		private ULevelSequence SeqenceData;

		// Token: 0x04012E9E RID: 77470
		private int SeqenceDataLoading = -1;
	}
}
