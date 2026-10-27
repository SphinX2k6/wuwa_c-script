using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B17 RID: 27415
	public class LevelEventEnableKey4Func : LevelEventBase
	{
		// Token: 0x060440A5 RID: 278693 RVA: 0x010B96A0 File Offset: 0x010B78A0
		public LevelEventEnableKey4Func(int id) : base(id)
		{
		}

		// Token: 0x060440A6 RID: 278694 RVA: 0x010B96AC File Offset: 0x010B78AC
		[NullableContext(1)]
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			EnableKey4Func enableKey4Func = inParams as EnableKey4Func;
			if (enableKey4Func == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Photograph;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[LevelEventEnableKey4Func]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Enable", enableKey4Func.IsEnable);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FuncKey", enableKey4Func.FuncKey);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.Enable = enableKey4Func.IsEnable;
			if (enableKey4Func.FuncKey == EEnableKey4FuncKey.TimeScaled)
			{
				BattleUiModel.Instance.SetTimeDilationSkillButtonEnable(enableKey4Func.IsEnable);
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060440A7 RID: 278695 RVA: 0x010B9764 File Offset: 0x010B7964
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.DisableKey4Func
			};
			if (this.Enable)
			{
				EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, null);
				return;
			}
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p, null);
		}

		// Token: 0x040238E3 RID: 145635
		private bool Enable;
	}
}
