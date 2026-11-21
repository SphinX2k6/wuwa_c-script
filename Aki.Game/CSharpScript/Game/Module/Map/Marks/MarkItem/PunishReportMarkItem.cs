using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C6 RID: 17606
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C79C RID: 182172 RVA: 0x00C7E596 File Offset: 0x00C7C796
		public PunishReportMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C79D RID: 182173 RVA: 0x00C7E5AC File Offset: 0x00C7C7AC
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.PunishReportMarkItemView;
		}

		// Token: 0x0602C79E RID: 182174 RVA: 0x00C7E5B0 File Offset: 0x00C7C7B0
		[PreserveBaseOverrides]
		protected new virtual PunishReportMarkItemView CreateView()
		{
			return new PunishReportMarkItemView(this);
		}

		// Token: 0x0602C79F RID: 182175 RVA: 0x00C7E5B8 File Offset: 0x00C7C7B8
		protected override void OnInitialize()
		{
			base.OnInitialize();
			EventSystem.Instance.Add<IReadOnlyDictionary<string, VarDefinePb>>(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
		}

		// Token: 0x0602C7A0 RID: 182176 RVA: 0x00C7E5DC File Offset: 0x00C7C7DC
		protected override void OnDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
			base.OnDestroy();
		}

		// Token: 0x0602C7A1 RID: 182177 RVA: 0x00C7E600 File Offset: 0x00C7C800
		private void OnReceivePlayerVar(IReadOnlyDictionary<string, VarDefinePb> readOnlyDictionary)
		{
			this.ReportTarget = this.GetPunishReportTarget();
		}

		// Token: 0x0602C7A2 RID: 182178 RVA: 0x00C7E610 File Offset: 0x00C7C810
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

		// Token: 0x0602C7A3 RID: 182179 RVA: 0x00C7E67C File Offset: 0x00C7C87C
		public bool IsPunishReportFinish()
		{
			return this.GetPunishMarkState() == EPunishReportMarkStateType.Complete;
		}

		// Token: 0x0602C7A4 RID: 182180 RVA: 0x00C7E688 File Offset: 0x00C7C888
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

		// Token: 0x0602C7A5 RID: 182181 RVA: 0x00C7E6F0 File Offset: 0x00C7C8F0
		public PunishReportTarget GetPunishReportTarget()
		{
			PunishReportTarget punishReportTarget = new PunishReportTarget
			{
				States = new List<EPunishReportTargetState>(),
				ConditionTxtIds = new List<string>(),
				GetBoxNum = 0L
			};
			int relativeId = base.MarkConfig.Value.RelativeId;
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

		// Token: 0x0602C7A6 RID: 182182 RVA: 0x00C7E8A4 File Offset: 0x00C7CAA4
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x0602C7A7 RID: 182183 RVA: 0x00C7E8AC File Offset: 0x00C7CAAC
		public override void UpdateIconPath()
		{
			this.IconPath = base.MarkConfig.Value.UnlockMarkPic;
		}

		// Token: 0x0602C7A8 RID: 182184 RVA: 0x00C7E8D5 File Offset: 0x00C7CAD5
		public override bool IsMarkDisabled()
		{
			return false;
		}

		// Token: 0x0602C7A9 RID: 182185 RVA: 0x00C7E8D8 File Offset: 0x00C7CAD8
		protected override bool IsGamePlayFinishRaw()
		{
			return this.IsPunishReportFinish();
		}

		// Token: 0x04017E57 RID: 97879
		[Nullable(2)]
		private PunishReportTarget ReportTarget;
	}
}
