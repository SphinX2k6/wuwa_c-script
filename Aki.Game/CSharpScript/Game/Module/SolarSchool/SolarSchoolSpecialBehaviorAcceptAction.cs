using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C3 RID: 22723
	public class SolarSchoolSpecialBehaviorAcceptAction : SolarSchoolActionBase
	{
		// Token: 0x06037F48 RID: 229192 RVA: 0x00FA449F File Offset: 0x00FA269F
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.BehaviorId = ActivityActionBase.GetParamInt(parameters, "SolarSchoolBehaviorId", this.BehaviorId);
		}

		// Token: 0x06037F49 RID: 229193 RVA: 0x00FA44B8 File Offset: 0x00FA26B8
		protected unsafe override void OnStart()
		{
			if (this.BehaviorId <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 特批接取 Action 参数非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("behaviorId", this.BehaviorId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.MarkFailed();
				return;
			}
			SolarSchoolSpecialBehaviorCenter.Instance.MarkSpecialTalkViewed(this.BehaviorId);
			this.ViewOpened = true;
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolSpecialBehaviorAcceptView, new SolarSchoolSpecialBehaviorAcceptParam
			{
				BehaviorId = this.BehaviorId,
				HideClose = true,
				OnAccepted = new Action(this.OnAccepted)
			}, null);
		}

		// Token: 0x06037F4A RID: 229194 RVA: 0x00FA4590 File Offset: 0x00FA2790
		private void OnAccepted()
		{
			this.ViewOpened = false;
			base.MarkDone();
		}

		// Token: 0x06037F4B RID: 229195 RVA: 0x00FA459F File Offset: 0x00FA279F
		protected override void OnDelete()
		{
			this.CloseOpenedView();
		}

		// Token: 0x06037F4C RID: 229196 RVA: 0x00FA45A7 File Offset: 0x00FA27A7
		private void CloseOpenedView()
		{
			if (!this.ViewOpened)
			{
				return;
			}
			this.ViewOpened = false;
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolSpecialBehaviorAcceptView, null);
		}

		// Token: 0x0401D849 RID: 120905
		private int BehaviorId;

		// Token: 0x0401D84A RID: 120906
		private bool ViewOpened;
	}
}
