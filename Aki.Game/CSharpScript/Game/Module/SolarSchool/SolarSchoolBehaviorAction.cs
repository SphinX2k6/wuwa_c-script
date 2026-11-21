using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B1 RID: 22705
	public class SolarSchoolBehaviorAction : SolarSchoolActionBase
	{
		// Token: 0x17006B54 RID: 27476
		// (get) Token: 0x06037ED3 RID: 229075 RVA: 0x00FA1D6F File Offset: 0x00F9FF6F
		public override bool ConsumesActionPoint
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037ED4 RID: 229076 RVA: 0x00FA1D72 File Offset: 0x00F9FF72
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.BehaviorId = ActivityActionBase.GetParamInt(parameters, "SolarSchoolBehaviorId", this.BehaviorId);
		}

		// Token: 0x06037ED5 RID: 229077 RVA: 0x00FA1D8C File Offset: 0x00F9FF8C
		protected override void OnStart()
		{
			this.Settled = false;
			this.ViewOpened = false;
			this.ResultSettled = false;
			if (this.BehaviorId <= 0)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] BehaviorAction 缺少有效 BehaviorId", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.MarkFailed();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] BehaviorAction 开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", this.BehaviorId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			SolarSchoolGamePlayModel instance2 = SolarSchoolGamePlayModel.Instance;
			SolarSchoolBehavior? currentLevelRow = instance2.PlayerData.GetCurrentLevelRow(this.BehaviorId);
			this.EnterBehaviorLocation((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().Location : 0);
			instance2.RecordExecutedBehavior(this.BehaviorId);
			bool flag = instance2.RollBehaviorResult(this.BehaviorId);
			this.IsSuccess = flag;
			if (this.IsRoleBehavior(currentLevelRow))
			{
				this.SettleResult();
				this.Settle();
				return;
			}
			this.ViewOpened = true;
			this.OpenExecuteViewAsync((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().Level : 0, flag).Forget();
		}

		// Token: 0x06037ED6 RID: 229078 RVA: 0x00FA1EB0 File Offset: 0x00FA00B0
		private bool IsRoleBehavior(SolarSchoolBehavior? row)
		{
			return row != null && row.Value.BehaviorType == 3 && row.Value.RoleId != 0;
		}

		// Token: 0x06037ED7 RID: 229079 RVA: 0x00FA1EEC File Offset: 0x00FA00EC
		private UniTask OpenExecuteViewAsync(int level, bool success)
		{
			SolarSchoolBehaviorAction.<OpenExecuteViewAsync>d__10 <OpenExecuteViewAsync>d__;
			<OpenExecuteViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenExecuteViewAsync>d__.<>4__this = this;
			<OpenExecuteViewAsync>d__.level = level;
			<OpenExecuteViewAsync>d__.success = success;
			<OpenExecuteViewAsync>d__.<>1__state = -1;
			<OpenExecuteViewAsync>d__.<>t__builder.Start<SolarSchoolBehaviorAction.<OpenExecuteViewAsync>d__10>(ref <OpenExecuteViewAsync>d__);
			return <OpenExecuteViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037ED8 RID: 229080 RVA: 0x00FA1F3F File Offset: 0x00FA013F
		private void SettleResult()
		{
			if (this.ResultSettled)
			{
				return;
			}
			this.ResultSettled = true;
			SolarSchoolGamePlayModel.Instance.SettleBehaviorResult(this.BehaviorId, this.IsSuccess);
		}

		// Token: 0x06037ED9 RID: 229081 RVA: 0x00FA1F67 File Offset: 0x00FA0167
		private void EnterBehaviorLocation(int locationId)
		{
			if (locationId == 0)
			{
				return;
			}
			SolarSchoolGamePlayModel.Instance.MapData.SetCurrentLocation(locationId);
		}

		// Token: 0x06037EDA RID: 229082 RVA: 0x00FA1F7D File Offset: 0x00FA017D
		private void OnViewFinished()
		{
			this.ViewOpened = false;
			this.Settle();
		}

		// Token: 0x06037EDB RID: 229083 RVA: 0x00FA1F8C File Offset: 0x00FA018C
		private void Settle()
		{
			if (this.Settled)
			{
				return;
			}
			this.Settled = true;
			base.MarkDone();
		}

		// Token: 0x06037EDC RID: 229084 RVA: 0x00FA1FA4 File Offset: 0x00FA01A4
		protected override void OnDelete()
		{
			if (!this.ViewOpened)
			{
				return;
			}
			this.ViewOpened = false;
			this.SettleResult();
			this.Settled = true;
			SolarSchoolGamePlayModel.Instance.CloseBehaviorExecuteView();
		}

		// Token: 0x0401D806 RID: 120838
		private int BehaviorId;

		// Token: 0x0401D807 RID: 120839
		private bool Settled;

		// Token: 0x0401D808 RID: 120840
		private bool ViewOpened;

		// Token: 0x0401D809 RID: 120841
		private bool IsSuccess;

		// Token: 0x0401D80A RID: 120842
		private bool ResultSettled;
	}
}
