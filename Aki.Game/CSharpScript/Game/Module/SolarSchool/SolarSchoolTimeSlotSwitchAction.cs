using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C4 RID: 22724
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolTimeSlotSwitchAction : SolarSchoolActionBase
	{
		// Token: 0x06037F4E RID: 229198 RVA: 0x00FA45D1 File Offset: 0x00FA27D1
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.TargetSlot = (ESolarSchoolTimeSlot)ActivityActionBase.GetParamInt(parameters, "SolarSchoolTimeSlot", (int)this.TargetSlot);
			this.Silent = (ActivityActionBase.GetParamInt(parameters, "SolarSchoolTimeSlotSilent", (this.Silent > false) ? 1 : 0) != 0);
		}

		// Token: 0x06037F4F RID: 229199 RVA: 0x00FA4608 File Offset: 0x00FA2808
		protected override void OnStart()
		{
			if (this.TargetSlot == ESolarSchoolTimeSlot.None)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] TimeSlotSwitchAction 缺少有效 TargetSlot", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.MarkFailed();
				return;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolTimeData timeData = instance.TimeData;
			if (this.Silent)
			{
				timeData.SetTimeSlot(this.TargetSlot, false);
				base.MarkDone();
				return;
			}
			ESolarSchoolMapTimePhase mapTimePhase = SolarSchoolTimeData.GetMapTimePhase(this.TargetSlot);
			if (instance.ShouldPlaySlotTransition(timeData.CurrentSlot, this.TargetSlot) && timeData.DisplayMapTimePhase != mapTimePhase)
			{
				instance.SetSlotTransitionUnplayed();
			}
			timeData.SetTimeSlot(this.TargetSlot, true);
			if (!instance.HasSlotTransitionUnplayed)
			{
				SolarSchoolRootViewModel rootViewModel = instance.RootViewModel;
				if (rootViewModel != null)
				{
					Action<ESolarSchoolMapTimePhase> snapTimeSlotPhase = rootViewModel.SnapTimeSlotPhase;
					if (snapTimeSlotPhase != null)
					{
						snapTimeSlotPhase(mapTimePhase);
					}
				}
			}
			base.MarkDone();
		}

		// Token: 0x06037F50 RID: 229200 RVA: 0x00FA46D3 File Offset: 0x00FA28D3
		protected override void OnDelete()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			instance.ClearSlotTransitionUnplayed();
			SolarSchoolRootViewModel rootViewModel = instance.RootViewModel;
			if (rootViewModel == null)
			{
				return;
			}
			Action stopTimeSlotTransition = rootViewModel.StopTimeSlotTransition;
			if (stopTimeSlotTransition == null)
			{
				return;
			}
			stopTimeSlotTransition();
		}

		// Token: 0x0401D84B RID: 120907
		public const string ParamKeyTimeSlot = "SolarSchoolTimeSlot";

		// Token: 0x0401D84C RID: 120908
		public const string ParamKeySilent = "SolarSchoolTimeSlotSilent";

		// Token: 0x0401D84D RID: 120909
		private ESolarSchoolTimeSlot TargetSlot;

		// Token: 0x0401D84E RID: 120910
		private bool Silent;
	}
}
