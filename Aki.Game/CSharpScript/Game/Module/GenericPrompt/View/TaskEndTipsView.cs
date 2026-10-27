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
	// Token: 0x020059AF RID: 22959
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskEndTipsView : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A393 RID: 238483 RVA: 0x00DD67D4 File Offset: 0x00DD49D4
		public TaskEndTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A394 RID: 238484 RVA: 0x00DD67DD File Offset: 0x00DD49DD
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0603A395 RID: 238485 RVA: 0x00DD6800 File Offset: 0x00DD4A00
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

		// Token: 0x0603A396 RID: 238486 RVA: 0x00DD6887 File Offset: 0x00DD4A87
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

		// Token: 0x0603A397 RID: 238487 RVA: 0x00DD68B2 File Offset: 0x00DD4AB2
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

		// Token: 0x0603A398 RID: 238488 RVA: 0x00DD68C8 File Offset: 0x00DD4AC8
		protected override UniTask OnBeforeStartAsync()
		{
			TaskEndTipsView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TaskEndTipsView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401E5F0 RID: 124400
		private const int IconIndex = 2;

		// Token: 0x0401E5F1 RID: 124401
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

		// Token: 0x0401E5F2 RID: 124402
		[Nullable(2)]
		private TaskEndTipsViewData _viewData;
	}
}
