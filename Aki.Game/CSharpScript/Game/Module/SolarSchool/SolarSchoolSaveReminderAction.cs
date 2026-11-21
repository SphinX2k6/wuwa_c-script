using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C0 RID: 22720
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolSaveReminderAction : SolarSchoolActionBase
	{
		// Token: 0x06037F3C RID: 229180 RVA: 0x00FA4234 File Offset: 0x00FA2434
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.ConfirmId = ActivityActionBase.GetParamInt(parameters, "ConfirmId", 0);
		}

		// Token: 0x06037F3D RID: 229181 RVA: 0x00FA4248 File Offset: 0x00FA2448
		protected unsafe override void OnStart()
		{
			if (this.ConfirmId <= 0)
			{
				this.OpenSaveView();
				return;
			}
			if (ConfirmBoxConfig.Instance.GetConfirmBoxConfig(this.ConfirmId) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] SaveReminderAction 确认框配置缺失";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("confirmId", this.ConfirmId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.MarkFailed();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)this.ConfirmId)
			{
				DestroyFunction = new Action(this.OnConfirmBoxDestroyed)
			};
			confirmBoxDataNew.FunctionMap[2] = new Action(this.OpenSaveView);
			this.ConfirmBoxOpened = true;
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolConfirmPopupView, confirmBoxDataNew, null);
		}

		// Token: 0x06037F3E RID: 229182 RVA: 0x00FA4340 File Offset: 0x00FA2540
		private void OpenSaveView()
		{
			SolarSchoolSaveViewParam param = new SolarSchoolSaveViewParam(SolarSchoolGamePlayModel.Instance.ActivityId, ESolarSchoolSaveViewMode.Save, false, true, new Action(this.OnSaveViewClosed));
			this.SaveViewOpened = true;
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolSaveView, param, null);
		}

		// Token: 0x06037F3F RID: 229183 RVA: 0x00FA4384 File Offset: 0x00FA2584
		private void OnConfirmBoxDestroyed()
		{
			this.ConfirmBoxOpened = false;
			if (this.SaveViewOpened)
			{
				return;
			}
			base.MarkDone();
		}

		// Token: 0x06037F40 RID: 229184 RVA: 0x00FA439C File Offset: 0x00FA259C
		private void OnSaveViewClosed()
		{
			this.SaveViewOpened = false;
			base.MarkDone();
		}

		// Token: 0x06037F41 RID: 229185 RVA: 0x00FA43AC File Offset: 0x00FA25AC
		protected override void OnDelete()
		{
			if (this.ConfirmBoxOpened)
			{
				this.ConfirmBoxOpened = false;
				UiManager.Instance.CloseView(EUiViewName.SolarSchoolConfirmPopupView, null);
			}
			if (!this.SaveViewOpened)
			{
				return;
			}
			this.SaveViewOpened = false;
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolSaveView, null);
		}

		// Token: 0x0401D843 RID: 120899
		public const string ParamKeyConfirmId = "ConfirmId";

		// Token: 0x0401D844 RID: 120900
		private int ConfirmId;

		// Token: 0x0401D845 RID: 120901
		private bool ConfirmBoxOpened;

		// Token: 0x0401D846 RID: 120902
		private bool SaveViewOpened;
	}
}
