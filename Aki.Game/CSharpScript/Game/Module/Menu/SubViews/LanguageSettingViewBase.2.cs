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
	// Token: 0x020043FF RID: 17407
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageSettingViewBase<[Nullable(0)] T> : UiViewBase where T : LanguageToggleBase
	{
		// Token: 0x0602BFA2 RID: 180130 RVA: 0x00C58F50 File Offset: 0x00C57150
		public LanguageSettingViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BFA3 RID: 180131 RVA: 0x00C58F5C File Offset: 0x00C5715C
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

		// Token: 0x0602BFA4 RID: 180132 RVA: 0x00C59024 File Offset: 0x00C57224
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

		// Token: 0x0602BFA5 RID: 180133 RVA: 0x00C5919C File Offset: 0x00C5739C
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

		// Token: 0x0602BFA6 RID: 180134 RVA: 0x00C59230 File Offset: 0x00C57430
		private void DoClose(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BFA7 RID: 180135 RVA: 0x00C59239 File Offset: 0x00C57439
		private void DoConfirm(int _)
		{
			this.IsConfirm = true;
			this.DoClose(0);
		}

		// Token: 0x0602BFA8 RID: 180136 RVA: 0x00C5924C File Offset: 0x00C5744C
		protected override void OnAfterHide()
		{
			int targetConfig = MenuController.Instance.GetTargetConfig(this.MenuDataIns.FunctionId);
			if (this.IsConfirm && this.SelectedToggle.GetIndex() != targetConfig && this.MenuChangeParam != null && this.MenuDataIns != null && LanguageSettingViewBase.ApplyValueFunc != null)
			{
				LanguageSettingViewBase.ApplyValueFunc((int)this.MenuDataIns.FunctionId, (float)this.SelectedToggle.GetIndex());
			}
			this.IsConfirm = false;
		}

		// Token: 0x0602BFA9 RID: 180137 RVA: 0x00C592CE File Offset: 0x00C574CE
		protected override void OnBeforeDestroyImplement()
		{
			if (this.ScrollView != null)
			{
				this.ScrollView.ClearChildren();
				this.ScrollView = null;
			}
		}

		// Token: 0x0602BFAA RID: 180138 RVA: 0x00C592EC File Offset: 0x00C574EC
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

		// Token: 0x0602BFAB RID: 180139 RVA: 0x00C59340 File Offset: 0x00C57540
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

		// Token: 0x0602BFAC RID: 180140 RVA: 0x00C594C8 File Offset: 0x00C576C8
		[return: Nullable(2)]
		protected virtual T CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			Log.Instance.Error(ELogModule.Menu, ELogAuthor.WZ, "必须重写CreateToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
			return default(T);
		}

		// Token: 0x0602BFAD RID: 180141 RVA: 0x00C594FC File Offset: 0x00C576FC
		protected virtual void OnRefreshView(T newToggle)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, this.MenuDataIns.FunctionName ?? "", Array.Empty<object>());
		}

		// Token: 0x0602BFAE RID: 180142 RVA: 0x00C59535 File Offset: 0x00C57735
		protected virtual void OnSelected(T newToggle, EToggleState newToggleState)
		{
		}

		// Token: 0x04017B08 RID: 97032
		[Nullable(2)]
		protected MenuData MenuDataIns;

		// Token: 0x04017B09 RID: 97033
		[Nullable(2)]
		protected ButtonItem CancelButton;

		// Token: 0x04017B0A RID: 97034
		[Nullable(2)]
		protected ButtonItem ConfirmButton;

		// Token: 0x04017B0B RID: 97035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericScrollView<UiPanelBase> ScrollView;

		// Token: 0x04017B0C RID: 97036
		[Nullable(2)]
		protected T SelectedToggle;

		// Token: 0x04017B0D RID: 97037
		[Nullable(2)]
		private IReadOnlyList<object> MenuChangeParam;

		// Token: 0x04017B0E RID: 97038
		protected bool IsConfirm;

		// Token: 0x04017B0F RID: 97039
		protected UUIExtendToggle CoverRoleLangToggle;

		// Token: 0x04017B10 RID: 97040
		protected UUIText CoverRoleTxt;

		// Token: 0x04017B11 RID: 97041
		protected UUIItem RoleLangDeleteHint;

		// Token: 0x04017B12 RID: 97042
		protected UUIText RoleLangDeleteHintTxt;
	}
}
