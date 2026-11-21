using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004988 RID: 18824
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskEndTipsView : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F2B9 RID: 193209 RVA: 0x00D25C64 File Offset: 0x00D23E64
		public TaskEndTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2BA RID: 193210 RVA: 0x00D25C6D File Offset: 0x00D23E6D
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0602F2BB RID: 193211 RVA: 0x00D25C90 File Offset: 0x00D23E90
		protected override void OnBeforeCreate()
		{
			this._viewData = (this.OpenParam as TaskEndTipsViewData);
			TaskEndTipsViewData viewData = this._viewData;
			float? duration = (viewData != null && viewData.Duration != null) ? new float?((float)this._viewData.Duration.Value) : null;
			PromptParamHub<object> openParam = new PromptParamHub<object>
			{
				TypeId = 12,
				Duration = duration
			};
			this.OpenParam = openParam;
			base.OnBeforeCreate();
			this.OpenParam = this._viewData;
		}

		// Token: 0x0602F2BC RID: 193212 RVA: 0x00D25D17 File Offset: 0x00D23F17
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			if (this._viewData == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.MainText, this._viewData.TipTextKey, Array.Empty<object>());
		}

		// Token: 0x0602F2BD RID: 193213 RVA: 0x00D25D42 File Offset: 0x00D23F42
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
			UUIText extraText = base.ExtraText;
			if (extraText == null)
			{
				return;
			}
			extraText.SetUIActive(false);
		}

		// Token: 0x0602F2BE RID: 193214 RVA: 0x00D25D58 File Offset: 0x00D23F58
		protected override UniTask OnBeforeStartAsync()
		{
			TaskEndTipsView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TaskEndTipsView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401908E RID: 102542
		private const int IconIndex = 2;

		// Token: 0x0401908F RID: 102543
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyDictionary<EQuestCommonTipType, string> TaskEndIconSp = new Dictionary<EQuestCommonTipType, string>
		{
			{
				EQuestCommonTipType.Branch,
				"SP_IconMap_Task_02_3_UI"
			},
			{
				EQuestCommonTipType.Role,
				"SP_IconMap_Task_03_3_UI"
			},
			{
				EQuestCommonTipType.Guide,
				"SP_IconMap_Task_11_3_UI"
			},
			{
				EQuestCommonTipType.POI,
				"SP_IconMap_Task_10_4_UI"
			},
			{
				EQuestCommonTipType.Activity,
				"SP_IconMap_Task_14_3_UI"
			},
			{
				EQuestCommonTipType.Daily,
				"SP_IconMap_Task_06_UI"
			},
			{
				EQuestCommonTipType.Tale,
				"SP_IconMap_Task_18_3_UI"
			}
		};

		// Token: 0x04019090 RID: 102544
		[Nullable(2)]
		private TaskEndTipsViewData _viewData;
	}
}
