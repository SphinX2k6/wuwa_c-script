using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054F3 RID: 21747
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportMarkItem : ConfigMarkItem
	{
		// Token: 0x060378D0 RID: 227536 RVA: 0x00D30642 File Offset: 0x00D2E842
		public PunishReportMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x060378D1 RID: 227537 RVA: 0x00D30658 File Offset: 0x00D2E858
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.PunishReportMarkItemView;
		}

		// Token: 0x060378D2 RID: 227538 RVA: 0x00D3065C File Offset: 0x00D2E85C
		[PreserveBaseOverrides]
		protected new virtual PunishReportMarkItemView CreateView()
		{
			return new PunishReportMarkItemView(this);
		}

		// Token: 0x060378D3 RID: 227539 RVA: 0x00D30664 File Offset: 0x00D2E864
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateGamePlayState();
			EventSystem.Instance.Add<IReadOnlyDictionary<string, VarDefinePb>>(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
		}

		// Token: 0x060378D4 RID: 227540 RVA: 0x00D3068E File Offset: 0x00D2E88E
		protected override void OnDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
			base.OnDestroy();
		}

		// Token: 0x060378D5 RID: 227541 RVA: 0x00D306B2 File Offset: 0x00D2E8B2
		private void OnReceivePlayerVar(IReadOnlyDictionary<string, VarDefinePb> readOnlyDictionary)
		{
			this.ReportTarget = this.GetPunishReportTarget();
			this.UpdateGamePlayState();
		}

		// Token: 0x060378D6 RID: 227542 RVA: 0x00D306C8 File Offset: 0x00D2E8C8
		public EPunishReportMarkStateType GetPunishMarkState()
		{
			if (this.ReportTarget == null)
			{
				this.ReportTarget = this.GetPunishReportTarget();
			}
			EPunishReportMarkStateType result = EPunishReportMarkStateType.Complete;
			using (List<EPunishReportTargetState>.Enumerator enumerator = this.ReportTarget.States.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != EPunishReportTargetState.Achieve)
					{
						result = EPunishReportMarkStateType.Proceed;
					}
				}
			}
			return result;
		}

		// Token: 0x060378D7 RID: 227543 RVA: 0x00D30734 File Offset: 0x00D2E934
		public bool IsPunishReportFinish()
		{
			return this.GetPunishMarkState() == EPunishReportMarkStateType.Complete;
		}

		// Token: 0x060378D8 RID: 227544 RVA: 0x00D30740 File Offset: 0x00D2E940
		private void UpdateGamePlayState()
		{
			EPunishReportMarkStateType punishMarkState = this.GetPunishMarkState();
			base.MarkItemEntity.GetComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay).GamePlayState = ((punishMarkState == EPunishReportMarkStateType.Complete) ? EMarkGamePlayState.Finish : EMarkGamePlayState.Lock);
		}

		// Token: 0x060378D9 RID: 227545 RVA: 0x00D30774 File Offset: 0x00D2E974
		public bool CanGetReward()
		{
			int num = 0;
			PunishReportTarget punishReportTarget = this.GetPunishReportTarget();
			using (List<EPunishReportTargetState>.Enumerator enumerator = punishReportTarget.States.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == EPunishReportTargetState.Achieve)
					{
						num++;
					}
				}
			}
			return (long)num > punishReportTarget.GetBoxNum;
		}

		// Token: 0x060378DA RID: 227546 RVA: 0x00D307DC File Offset: 0x00D2E9DC
		public PunishReportTarget GetPunishReportTarget()
		{
			PunishReportTarget punishReportTarget = new PunishReportTarget
			{
				States = new List<EPunishReportTargetState>(),
				ConditionTxtIds = new List<string>(),
				GetBoxNum = 0L
			};
			int relativeId = this.MarkConfig.Value.RelativeId;
			PunishReport? punishReportConfig = WorldMapConfig.Instance.GetPunishReportConfig(relativeId);
			if (punishReportConfig == null)
			{
				object key = relativeId;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[地图系统]->讨伐报告标记获取配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelPlayId", relativeId);
				MapLogger.ErrorOnce(key, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return punishReportTarget;
			}
			bool worldStateBool = WorldModel.Instance.GetWorldStateBool(punishReportConfig.Value.Cond1Key);
			bool worldStateBool2 = WorldModel.Instance.GetWorldStateBool(punishReportConfig.Value.Cond2ey);
			bool worldStateBool3 = WorldModel.Instance.GetWorldStateBool(punishReportConfig.Value.Cond3Key);
			bool[] array = new bool[]
			{
				worldStateBool,
				worldStateBool2,
				worldStateBool3
			};
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i])
				{
					punishReportTarget.States.Add(EPunishReportTargetState.Achieve);
				}
				else
				{
					punishReportTarget.States.Add(EPunishReportTargetState.UnAchieve);
				}
			}
			string condDescription = punishReportConfig.Value.CondDescription1;
			string condDescription2 = punishReportConfig.Value.CondDescription2;
			string condDescription3 = punishReportConfig.Value.CondDescription3;
			punishReportTarget.ConditionTxtIds.Add(condDescription);
			punishReportTarget.ConditionTxtIds.Add(condDescription2);
			punishReportTarget.ConditionTxtIds.Add(condDescription3);
			long valueOrDefault = WorldModel.Instance.GetWorldStateLong(punishReportConfig.Value.GetBoxKey).GetValueOrDefault();
			punishReportTarget.GetBoxNum = valueOrDefault;
			return punishReportTarget;
		}

		// Token: 0x060378DB RID: 227547 RVA: 0x00D3098C File Offset: 0x00D2EB8C
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x060378DC RID: 227548 RVA: 0x00D30994 File Offset: 0x00D2EB94
		public override void UpdateIconPath()
		{
			this.IconPath = this.MarkConfig.Value.UnlockMarkPic;
		}

		// Token: 0x060378DD RID: 227549 RVA: 0x00D309BA File Offset: 0x00D2EBBA
		protected override bool GamePlayIsFinish()
		{
			return this.IsPunishReportFinish();
		}

		// Token: 0x0401D3CE RID: 119758
		[Nullable(2)]
		private PunishReportTarget ReportTarget;
	}
}
