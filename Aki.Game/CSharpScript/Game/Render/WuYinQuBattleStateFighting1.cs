using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004593 RID: 17811
	public class WuYinQuBattleStateFighting1 : WuYinQuBattleStateBase
	{
		// Token: 0x0602DEF7 RID: 188151 RVA: 0x00A8FEF0 File Offset: 0x00A8E0F0
		[NullableContext(1)]
		public WuYinQuBattleStateFighting1(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x0602DEF8 RID: 188152 RVA: 0x00A8FEFB File Offset: 0x00A8E0FB
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

		// Token: 0x0602DEF9 RID: 188153 RVA: 0x00A8FF14 File Offset: 0x00A8E114
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

		// Token: 0x0602DEFA RID: 188154 RVA: 0x00A90001 File Offset: 0x00A8E201
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x0602DEFB RID: 188155 RVA: 0x00A90004 File Offset: 0x00A8E204
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出战斗阶段", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x04018858 RID: 100440
		protected float Timer;
	}
}
