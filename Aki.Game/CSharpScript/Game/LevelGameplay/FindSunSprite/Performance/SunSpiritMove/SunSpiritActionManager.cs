using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.FindSunSpirit;
using CSharpScript.Game.LevelGamePlay.Common.GameplayAction;
using CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove
{
	// Token: 0x02005FD9 RID: 24537
	[NullableContext(2)]
	[Nullable(0)]
	public class SunSpiritActionManager : GameplayActionManager
	{
		// Token: 0x0603AF1E RID: 241438 RVA: 0x010A82E8 File Offset: 0x010A64E8
		[NullableContext(1)]
		public void InitByConfig(BP_FindSunSpiritGlobalConfig_C config)
		{
			this.JumpMontage = config.跳跃蒙太奇;
			this.JumpConfig = new JumpConfig
			{
				RotateSpeed = (float)config.跳跃旋转速度,
				JumpTime = (float)config.跳跃时间,
				MoveBaseHeightOffset = (float)config.跳跃高度偏移基准,
				MaxRiseHeightEdge = (float)Math.Abs(config.跳跃上升偏移曲线高度范围),
				MaxFallHeightEdge = (float)Math.Abs(config.跳跃下降偏移曲线高度范围),
				MoveRiseCurve = config.跳跃上升偏移曲线,
				MoveFallCurve = config.跳跃下降偏移曲线
			};
			this.RunMontage = config.奔跑蒙太奇;
			this.RunConfig = new RunConfig
			{
				RotateSpeed = (float)config.奔跑旋转速度,
				MoveSpeed = (float)config.奔跑移动速度
			};
			this.RunWaitNextTime = config.奔跑结束停顿时间;
			this.FailMontage = config.寻路失败蒙太奇;
			this.SuccessMontage = config.到达终点蒙太奇;
			this.EndMontage = config.终点待机蒙太奇;
			base.Init(new SunSpiritActionTicker());
		}

		// Token: 0x0603AF1F RID: 241439 RVA: 0x010A83DB File Offset: 0x010A65DB
		public override void Clear()
		{
			base.Clear();
			this.JumpMontage = null;
			this.JumpConfig = null;
			this.RunMontage = null;
			this.RunConfig = null;
			this.FailMontage = null;
			this.SuccessMontage = null;
			this.EndMontage = null;
		}

		// Token: 0x0603AF20 RID: 241440 RVA: 0x010A8414 File Offset: 0x010A6614
		[NullableContext(1)]
		public void ExecuteSunSpiritMove(IReadOnlyList<ISunSpiritMoveParams> paramsList, Action onFinish)
		{
			if (paramsList.Count <= 0)
			{
				onFinish();
				return;
			}
			List<GameplayActionGroup> list = new List<GameplayActionGroup>();
			foreach (ISunSpiritMoveParams @params in paramsList)
			{
				foreach (GameplayActionGroup item in this.CreateMoveActionGroup(@params))
				{
					list.Add(item);
				}
			}
			base.ExecuteActionGroups(list, onFinish);
		}

		// Token: 0x0603AF21 RID: 241441 RVA: 0x010A84B8 File Offset: 0x010A66B8
		[NullableContext(1)]
		public void ExecuteSunSpiritFail(EntityHandle entityHandle, Action onFinish)
		{
			List<GameplayActionGroup> list = new List<GameplayActionGroup>();
			GameplayActionGroup gameplayActionGroup = new GameplayActionGroup();
			NpcPlayMontageAction npcPlayMontageAction = new NpcPlayMontageAction();
			npcPlayMontageAction.Init(entityHandle, this.FailMontage, false, true);
			gameplayActionGroup.PushAction(npcPlayMontageAction);
			list.Add(gameplayActionGroup);
			base.ExecuteActionGroups(list, onFinish);
		}

		// Token: 0x0603AF22 RID: 241442 RVA: 0x010A84FC File Offset: 0x010A66FC
		[NullableContext(1)]
		public void ExecuteSunSpiritStopEndMontage(EntityHandle entityHandle)
		{
			List<GameplayActionGroup> list = new List<GameplayActionGroup>();
			GameplayActionGroup gameplayActionGroup = new GameplayActionGroup();
			NpcStopMontageAction npcStopMontageAction = new NpcStopMontageAction();
			npcStopMontageAction.Init(entityHandle, this.EndMontage, 0.1f);
			gameplayActionGroup.PushAction(npcStopMontageAction);
			list.Add(gameplayActionGroup);
			base.ExecuteActionGroups(list, null);
		}

		// Token: 0x0603AF23 RID: 241443 RVA: 0x010A8544 File Offset: 0x010A6744
		[NullableContext(1)]
		private List<GameplayActionGroup> CreateMoveActionGroup(ISunSpiritMoveParams @params)
		{
			EntityHandle moveTarget = @params.MoveTarget;
			ESunSpiritMovePerformType performType = @params.PerformType;
			List<GameplayActionGroup> list = new List<GameplayActionGroup>();
			if (performType == ESunSpiritMovePerformType.Run)
			{
				GameplayActionGroup gameplayActionGroup = new GameplayActionGroup();
				EntityRunAction entityRunAction = new EntityRunAction();
				entityRunAction.Init(moveTarget, this.RunConfig, @params.TargetLocation, @params.TargetRotator);
				gameplayActionGroup.PushAction(entityRunAction);
				NpcPlayMontageAction npcPlayMontageAction = new NpcPlayMontageAction();
				npcPlayMontageAction.Init(moveTarget, this.RunMontage, true, true);
				gameplayActionGroup.PushAction(npcPlayMontageAction);
				list.Add(gameplayActionGroup);
				int runWaitNextTime = this.RunWaitNextTime;
				if (runWaitNextTime > 0)
				{
					GameplayActionGroup gameplayActionGroup2 = new GameplayActionGroup();
					WaitAction waitAction = new WaitAction();
					waitAction.Init((float)runWaitNextTime);
					gameplayActionGroup2.PushAction(waitAction);
					list.Add(gameplayActionGroup2);
				}
			}
			else if (performType == ESunSpiritMovePerformType.Jump)
			{
				GameplayActionGroup gameplayActionGroup3 = new GameplayActionGroup();
				EntityJumpFixTimeAction entityJumpFixTimeAction = new EntityJumpFixTimeAction();
				entityJumpFixTimeAction.Init(moveTarget, this.JumpConfig, @params.TargetLocation, @params.TargetRotator);
				gameplayActionGroup3.PushAction(entityJumpFixTimeAction);
				NpcPlayMontageAction npcPlayMontageAction2 = new NpcPlayMontageAction();
				npcPlayMontageAction2.Init(moveTarget, this.JumpMontage, false, true);
				gameplayActionGroup3.PushAction(npcPlayMontageAction2);
				list.Add(gameplayActionGroup3);
			}
			if (@params.SuccessPerform.GetValueOrDefault())
			{
				GameplayActionGroup gameplayActionGroup4 = new GameplayActionGroup();
				NpcPlayMontageAction npcPlayMontageAction3 = new NpcPlayMontageAction();
				npcPlayMontageAction3.Init(moveTarget, this.SuccessMontage, false, true);
				gameplayActionGroup4.PushAction(npcPlayMontageAction3);
				list.Add(gameplayActionGroup4);
				GameplayActionGroup gameplayActionGroup5 = new GameplayActionGroup();
				NpcPlayMontageAction npcPlayMontageAction4 = new NpcPlayMontageAction();
				npcPlayMontageAction4.Init(moveTarget, this.EndMontage, true, false);
				gameplayActionGroup5.PushAction(npcPlayMontageAction4);
				list.Add(gameplayActionGroup5);
			}
			return list;
		}

		// Token: 0x0401EFDB RID: 126939
		private UAnimMontage JumpMontage;

		// Token: 0x0401EFDC RID: 126940
		private IJumpConfig JumpConfig;

		// Token: 0x0401EFDD RID: 126941
		private UAnimMontage RunMontage;

		// Token: 0x0401EFDE RID: 126942
		private IRunConfig RunConfig;

		// Token: 0x0401EFDF RID: 126943
		private int RunWaitNextTime;

		// Token: 0x0401EFE0 RID: 126944
		private UAnimMontage FailMontage;

		// Token: 0x0401EFE1 RID: 126945
		private UAnimMontage SuccessMontage;

		// Token: 0x0401EFE2 RID: 126946
		private UAnimMontage EndMontage;
	}
}
