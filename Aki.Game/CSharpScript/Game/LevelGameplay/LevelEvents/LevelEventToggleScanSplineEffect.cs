using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B99 RID: 27545
	public class LevelEventToggleScanSplineEffect : LevelEventBase
	{
		// Token: 0x060442D9 RID: 279257 RVA: 0x010CD2B0 File Offset: 0x010CB4B0
		public LevelEventToggleScanSplineEffect(int id) : base(id)
		{
		}

		// Token: 0x060442DA RID: 279258 RVA: 0x010CD2BC File Offset: 0x010CB4BC
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CH, "参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (context.Type.GetValueOrDefault() == EGeneralContextType.GeneralLogicTree)
			{
				GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
				if (generalLogicTreeContext != null && generalLogicTreeContext.BtType == BtType.Quest)
				{
					goto IL_7E;
				}
				GeneralLogicTreeContext generalLogicTreeContext2 = context as GeneralLogicTreeContext;
				if (generalLogicTreeContext2 != null && generalLogicTreeContext2.BtType == BtType.Recall)
				{
					goto IL_7E;
				}
			}
			global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CH, "该事件仅用于任务/回顾任务行为树内配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			IL_7E:
			GeneralLogicTreeContext generalLogicTreeContext3 = context as GeneralLogicTreeContext;
			ToggleScanSplineEffect toggleScanSplineEffect = inParams as ToggleScanSplineEffect;
			ETraceSplineOptionType type = toggleScanSplineEffect.Type;
			if (type == ETraceSplineOptionType.Open)
			{
				IOpenTraceSpline openTraceSpline = toggleScanSplineEffect as IOpenTraceSpline;
				QuestNewController.Instance.AddQuestTraceEffect(generalLogicTreeContext3.TreeConfigId, openTraceSpline.Duration, openTraceSpline.SplineEntityId);
				return;
			}
			if (type != ETraceSplineOptionType.Close)
			{
				return;
			}
			ICloseTraceSpline closeTraceSpline = toggleScanSplineEffect as ICloseTraceSpline;
			QuestNewController.Instance.RemoveQuestTraceEffect(generalLogicTreeContext3.TreeConfigId, closeTraceSpline.SplineEntityId);
		}
	}
}
