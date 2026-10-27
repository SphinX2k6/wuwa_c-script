using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200541C RID: 21532
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageSettingViewBase<[Nullable(0)] T> : UiViewBase where T : LanguageToggleBase
	{
		// Token: 0x06037059 RID: 225369 RVA: 0x00D09B30 File Offset: 0x00D07D30
		public LanguageSettingViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603705A RID: 225370 RVA: 0x00D09B3C File Offset: 0x00D07D3C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x0603705B RID: 225371 RVA: 0x00D09C04 File Offset: 0x00D07E04
		protected override void OnStart()
		{
			this.CoverRoleLangToggle = base.GetExtendToggle(6);
			this.CoverRoleTxt = base.GetText(7);
			this.RoleLangDeleteHint = base.GetItem(4);
			this.RoleLangDeleteHintTxt = base.GetText(5);
			this.MenuChangeParam = (this.OpenParam as IReadOnlyList<object>);
			this.MenuDataIns = ((this.MenuChangeParam != null && this.MenuChangeParam.Count > 0) ? (this.MenuChangeParam[0] as MenuData) : null);
			if (this.MenuChangeParam != null && this.MenuChangeParam.Count > 1)
			{
				Action<int, float> action = this.MenuChangeParam[1] as Action<int, float>;
				if (action != null)
				{
					LanguageSettingViewBase.ApplyValueFunc = action;
				}
			}
			this.CancelButton = new ButtonItem(base.GetItem(1));
			this.ConfirmButton = new ButtonItem(base.GetItem(2));
			this.CancelButton.SetFunction(new Action<int>(this.DoClose));
			this.ConfirmButton.SetFunction(new Action<int>(this.DoConfirm));
			this.ScrollView = new GenericScrollView<UiPanelBase>(base.GetScrollViewWithScrollbar(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<UiPanelBase>(this.DoRefreshScrollView), null);
			this.InitScrollViewData();
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, this.MenuDataIns.FunctionName ?? "", Array.Empty<object>());
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.PopItem.OverrideBackBtnCallBack(delegate
			{
				this.DoClose(0);
			});
		}

		// Token: 0x0603705C RID: 225372 RVA: 0x00D09D7C File Offset: 0x00D07F7C
		protected virtual void InitScrollViewData()
		{
			List<int> list = new List<int>();
			foreach (LanguageDefine languageDefine in MenuTool.GetLanguageDefineData())
			{
				list.Add(languageDefine.LanguageType);
			}
			list.Sort((int a, int b) => a - b);
			this.ScrollView.RefreshByData<int>(list, null);
		}

		// Token: 0x0603705D RID: 225373 RVA: 0x00D09E10 File Offset: 0x00D08010
		private void DoClose(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x0603705E RID: 225374 RVA: 0x00D09E19 File Offset: 0x00D08019
		private void DoConfirm(int _)
		{
			this.IsConfirm = true;
			this.DoClose(0);
		}

		// Token: 0x0603705F RID: 225375 RVA: 0x00D09E2C File Offset: 0x00D0802C
		protected override void OnAfterHide()
		{
			int targetConfig = MenuController.Instance.GetTargetConfig(this.MenuDataIns.FunctionId);
			if (this.IsConfirm && this.SelectedToggle.GetIndex() != targetConfig && this.MenuChangeParam != null && this.MenuDataIns != null && LanguageSettingViewBase.ApplyValueFunc != null)
			{
				LanguageSettingViewBase.ApplyValueFunc((int)this.MenuDataIns.FunctionId, (float)this.SelectedToggle.GetIndex());
			}
			this.IsConfirm = false;
		}

		// Token: 0x06037060 RID: 225376 RVA: 0x00D09EAE File Offset: 0x00D080AE
		protected override void OnBeforeDestroyImplement()
		{
			if (this.ScrollView != null)
			{
				this.ScrollView.ClearChildren();
				this.ScrollView = null;
			}
		}

		// Token: 0x06037061 RID: 225377 RVA: 0x00D09ECC File Offset: 0x00D080CC
		protected void DoSelected(LanguageToggleBase newToggle, EToggleState newToggleState)
		{
			if (this.SelectedToggle != newToggle && newToggleState == EToggleState.ETT_Checked)
			{
				T t = this.SelectedToggle;
				if (t != null)
				{
					t.UnSelect();
				}
			}
			this.SelectedToggle = (newToggle as T);
			this.OnSelected(this.SelectedToggle, newToggleState);
		}

		// Token: 0x06037062 RID: 225378 RVA: 0x00D09F20 File Offset: 0x00D08120
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		protected unsafe virtual ILayoutItem<UiPanelBase> DoRefreshScrollView(object index, UUIItem uiItem, int _)
		{
			string audioCodeById = GameSettingsManager.Instance.GetAudioCodeById((int)index);
			LanguageUpdater updater = LanguageUpdateManager.Instance.GetUpdater(audioCodeById);
			if (updater != null)
			{
				updater.CalculateDownloadStatus("LanguageSettingViewBase DoRefreshScrollView");
			}
			int targetConfig = MenuController.Instance.GetTargetConfig(EFunction.VOICELANGUAGE);
			bool flag = (int)index == targetConfig && updater != null && updater.Status == ELanguageDownloadStatus.Done;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "[语音下载] DoRefreshScrollView";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("index", (int)index);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetIndex", targetConfig);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("languageCode", audioCodeById);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("updaterStatus", (updater != null) ? new ELanguageDownloadStatus?(updater.Status) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("isToggled", flag);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			T t = this.CreateToggle(uiItem, (int)index, flag);
			if (t == null)
			{
				return null;
			}
			if (flag)
			{
				this.SelectedToggle = t;
			}
			else
			{
				t.UnSelect();
			}
			t.SetSelectedCallBack(new Action<LanguageToggleBase, EToggleState>(this.DoSelected));
			this.OnRefreshView(t);
			return null;
		}

		// Token: 0x06037063 RID: 225379 RVA: 0x00D0A0A8 File Offset: 0x00D082A8
		[return: Nullable(2)]
		protected virtual T CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			Log.Instance.Error(ELogModule.Menu, ELogAuthor.WZ, "必须重写CreateToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}

		// Token: 0x06037064 RID: 225380 RVA: 0x00D0A0DC File Offset: 0x00D082DC
		protected virtual void OnRefreshView(T newToggle)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, this.MenuDataIns.FunctionName ?? "", Array.Empty<object>());
		}

		// Token: 0x06037065 RID: 225381 RVA: 0x00D0A115 File Offset: 0x00D08315
		protected virtual void OnSelected(T newToggle, EToggleState newToggleState)
		{
		}

		// Token: 0x0401D06F RID: 118895
		[Nullable(2)]
		protected MenuData MenuDataIns;

		// Token: 0x0401D070 RID: 118896
		[Nullable(2)]
		protected ButtonItem CancelButton;

		// Token: 0x0401D071 RID: 118897
		[Nullable(2)]
		protected ButtonItem ConfirmButton;

		// Token: 0x0401D072 RID: 118898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericScrollView<UiPanelBase> ScrollView;

		// Token: 0x0401D073 RID: 118899
		[Nullable(2)]
		protected T SelectedToggle;

		// Token: 0x0401D074 RID: 118900
		[Nullable(2)]
		private IReadOnlyList<object> MenuChangeParam;

		// Token: 0x0401D075 RID: 118901
		protected bool IsConfirm;

		// Token: 0x0401D076 RID: 118902
		protected UUIExtendToggle CoverRoleLangToggle;

		// Token: 0x0401D077 RID: 118903
		protected UUIText CoverRoleTxt;

		// Token: 0x0401D078 RID: 118904
		protected UUIItem RoleLangDeleteHint;

		// Token: 0x0401D079 RID: 118905
		protected UUIText RoleLangDeleteHintTxt;
	}
}
