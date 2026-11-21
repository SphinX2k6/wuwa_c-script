using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058BB RID: 22715
	public sealed class SolarSchoolItemGetPopupAction : SolarSchoolActionBase
	{
		// Token: 0x06037F10 RID: 229136 RVA: 0x00FA2DD9 File Offset: 0x00FA0FD9
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.ItemId = ActivityActionBase.GetParamInt(parameters, "ItemId", 0);
			this.Count = ActivityActionBase.GetParamInt(parameters, "Count", 0);
		}

		// Token: 0x06037F11 RID: 229137 RVA: 0x00FA2E00 File Offset: 0x00FA1000
		protected unsafe override void OnStart()
		{
			if (this.ItemId <= 0 || this.Count < 0 || SolarSchoolConfig.Instance.GetItem(this.ItemId) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] ItemGetPopupAction 参数非法";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemId", this.ItemId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("count", this.Count);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				base.MarkFailed();
				return;
			}
			this.IsPopupOpened = true;
			SolarSchoolUtils.ShowTipsPopup(this.ItemId, this.Count, new Action(this.OnPopupClosed));
		}

		// Token: 0x06037F12 RID: 229138 RVA: 0x00FA2EF3 File Offset: 0x00FA10F3
		private void OnPopupClosed()
		{
			this.IsPopupOpened = false;
			base.MarkDone();
		}

		// Token: 0x06037F13 RID: 229139 RVA: 0x00FA2F02 File Offset: 0x00FA1102
		protected override void OnDelete()
		{
			if (!this.IsPopupOpened)
			{
				return;
			}
			this.IsPopupOpened = false;
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolTipsPopupView, null);
		}

		// Token: 0x0401D81E RID: 120862
		private int ItemId;

		// Token: 0x0401D81F RID: 120863
		private int Count;

		// Token: 0x0401D820 RID: 120864
		private bool IsPopupOpened;
	}
}
