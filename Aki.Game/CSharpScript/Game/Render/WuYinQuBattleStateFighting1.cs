using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034BB RID: 13499
	public class WuYinQuBattleStateFighting1 : WuYinQuBattleStateBase
	{
		// Token: 0x060225E1 RID: 140769 RVA: 0x009BC110 File Offset: 0x009BA310
		[NullableContext(1)]
		public WuYinQuBattleStateFighting1(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x060225E2 RID: 140770 RVA: 0x009BC11B File Offset: 0x009BA31B
		[NullableContext(2)]
		protected virtual PDA_WuYinQuBattleFightingData_C GetFightingData()
		{
			PDA_WuYinQuBattleData_C wuYinQuFightingData = this.Owner.WuYinQuFightingData;
			if (wuYinQuFightingData == null)
			{
				return null;
			}
			return wuYinQuFightingData.WuYinQuFightingData1;
		}

		// Token: 0x060225E3 RID: 140771 RVA: 0x009BC134 File Offset: 0x009BA334
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入战斗阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Owner.当前状态 = "战斗阶段1";
			PDA_WuYinQuBattleFightingData_C fightingData = this.GetFightingData();
			this.Timer = 0f;
			if (fightingData != null && fightingData.IsValid())
			{
				UMaterialParameterCollection globalMPC = this.Owner.WuYinQuFightingData.GlobalMPC;
				PDA_WuYinQuBattleData_C wuYinQuFightingData = this.Owner.WuYinQuFightingData;
				if (globalMPC != null)
				{
					UObject world = this.Owner.GetWorld();
					UMaterialParameterCollection collection = globalMPC;
					FName globalLandscapeRadiusAndHardness = WuYinQuBattleNameDefines.GlobalLandscapeRadiusAndHardness;
					FLinearColor flinearColor = new FLinearColor(wuYinQuFightingData.LandscapeShowingRadiusCurve.GetFloatValue(1f), 0.0001f, 0f, 0f);
					UKismetMaterialLibrary.SetVectorParameterValue(world, collection, globalLandscapeRadiusAndHardness, flinearColor);
					UKismetMaterialLibrary.SetScalarParameterValue(this.Owner.GetWorld(), globalMPC, WuYinQuBattleNameDefines.GlobalBlackStoneErosion, 1f);
					return;
				}
			}
			else
			{
				Log.Instance.Warn(ELogModule.RenderBattle, ELogAuthor.HCS, "没有配置有效的战斗氛围数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x060225E4 RID: 140772 RVA: 0x009BC221 File Offset: 0x009BA421
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x060225E5 RID: 140773 RVA: 0x009BC224 File Offset: 0x009BA424
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出战斗阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x04012E93 RID: 77459
		protected float Timer;
	}
}
