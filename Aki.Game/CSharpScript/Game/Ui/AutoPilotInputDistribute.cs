using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoPilot;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200467F RID: 18047
	public class AutoPilotInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E978 RID: 190840 RVA: 0x00AC9378 File Offset: 0x00AC7578
		public override bool OnRefresh()
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			if (!((instance != null) ? new bool?(instance.GetIsInAutoPilot()) : null).GetValueOrDefault())
			{
				return false;
			}
			AutoPilotModel instance2 = AutoPilotModel.Instance;
			if (((instance2 != null) ? new bool?(instance2.GetIsInMovieMode()) : null).GetValueOrDefault())
			{
				this.TagNames.Clear();
				this.TagNames.Add("UiInputRoot");
				this.TagNames.Add("FightInputRoot.FightInput.ActionInput.VehicleMusicInputTag");
				base.SetInputDistributeTags(this.TagNames);
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[InputDistribute] 自动巡航电影模式下允许的输入";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagNames", this.TagNames);
				instance3.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return true;
			}
			this.TagNames.Clear();
			this.TagNames.Add("UiInputRoot");
			this.TagNames.Add("FightInputRoot.FightInput.AxisInput.CameraInput");
			this.TagNames.Add("FightInputRoot.FightInput.ActionInput.VehicleMusicInputTag");
			if (AutoPilotModel.Instance.IsAllowExitByMove)
			{
				this.TagNames.Add("FightInputRoot.FightInput.AxisInput.MoveInput");
			}
			base.SetInputDistributeTags(this.TagNames);
			Log instance4 = Log.Instance;
			ELogModule module2 = ELogModule.Input;
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "[InputDistribute] 自动巡航下允许的输入";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("tagNames", this.TagNames);
			instance4.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return true;
		}

		// Token: 0x04019541 RID: 103745
		[Nullable(1)]
		private readonly List<string> TagNames = new List<string>();
	}
}
