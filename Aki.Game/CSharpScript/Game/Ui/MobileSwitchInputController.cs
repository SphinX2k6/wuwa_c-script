using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B3 RID: 18099
	[NullableContext(1)]
	[Nullable(0)]
	public class MobileSwitchInputController : Singleton
	{
		// Token: 0x0602EAD2 RID: 191186 RVA: 0x00ACD8E9 File Offset: 0x00ACBAE9
		private void ResetState()
		{
			this.IsInSwitching = false;
		}

		// Token: 0x0602EAD3 RID: 191187 RVA: 0x00ACD8F4 File Offset: 0x00ACBAF4
		private void ChooseSwitch()
		{
			if (GameSettingsManager.Instance.GetCurrentValue(EFunction.MobileGamepadMode, true, true).GetValueOrDefault() != 1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Controler_Notconnect_tips", Array.Empty<object>());
				return;
			}
			this.NeedSwitch = true;
		}

		// Token: 0x0602EAD4 RID: 191188 RVA: 0x00ACD93C File Offset: 0x00ACBB3C
		private void ShowMobileSwitchInputView()
		{
			EInputControllerType? inputControllerType = this.CacheInputControllerType;
			this.CacheInputControllerType = null;
			this.IsInSwitching = false;
			if (!this.NeedSwitch)
			{
				return;
			}
			this.NeedSwitch = false;
			this.ClearAllView().ContinueWith(delegate()
			{
				this.OpenMobileSwitchInputView(true);
				Info.Instance.SwitchInputControllerType(inputControllerType.Value, "MobileSwitch");
			});
		}

		// Token: 0x0602EAD5 RID: 191189 RVA: 0x00ACD9A0 File Offset: 0x00ACBBA0
		private UniTask ClearAllView()
		{
			MobileSwitchInputController.<ClearAllView>d__9 <ClearAllView>d__;
			<ClearAllView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAllView>d__.<>1__state = -1;
			<ClearAllView>d__.<>t__builder.Start<MobileSwitchInputController.<ClearAllView>d__9>(ref <ClearAllView>d__);
			return <ClearAllView>d__.<>t__builder.Task;
		}

		// Token: 0x0602EAD6 RID: 191190 RVA: 0x00ACD9DC File Offset: 0x00ACBBDC
		[NullableContext(2)]
		private bool CheckOpenViewInMobileSwitch(EUiViewName viewName, object param)
		{
			if (viewName == EUiViewName.MobileSwitchInputView)
			{
				return true;
			}
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo != null && (uiViewInfo.Type & (ELayerType.NetWork | ELayerType.CG)) > (ELayerType)0)
			{
				return true;
			}
			this.CacheOpenViewMap[viewName] = new MobileSwitchInputController.CacheData
			{
				UiViewName = viewName,
				Param = param
			};
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MobileInputSwitch;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "缓存切换期间打开的界面数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}

		// Token: 0x0602EAD7 RID: 191191 RVA: 0x00ACDA68 File Offset: 0x00ACBC68
		private void ReOpenCacheView()
		{
			foreach (MobileSwitchInputController.ICacheData cacheData in this.CacheOpenViewMap.Values)
			{
				UiManager.Instance.OpenView(cacheData.UiViewName, cacheData.Param, null);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MobileInputSwitch;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "重新打开切换期间打开的界面数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", cacheData.UiViewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.CacheOpenViewMap.Clear();
		}

		// Token: 0x0602EAD8 RID: 191192 RVA: 0x00ACDB10 File Offset: 0x00ACBD10
		private void OpenMobileSwitchInputView(bool isSwitchToGamepad)
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.CheckOpenViewInMobileSwitch), "MobileSwitchInput");
			UiManager.Instance.OpenView(EUiViewName.MobileSwitchInputView, isSwitchToGamepad, null);
		}

		// Token: 0x0602EAD9 RID: 191193 RVA: 0x00ACDB48 File Offset: 0x00ACBD48
		private bool CanMobileSwitchInputCondition()
		{
			if (!Info.Instance.IsMobileInputModel())
			{
				return false;
			}
			if (!UiModel.Instance.IsInMainView)
			{
				return false;
			}
			BattleUiModel instance = BattleUiModel.Instance;
			return instance != null && instance.IsEnableChangeInputControllerOnMobile() && InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag("FightInputRoot", false);
		}

		// Token: 0x0602EADA RID: 191194 RVA: 0x00ACDBA0 File Offset: 0x00ACBDA0
		public void ReOpenBattleView(bool _)
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.CheckOpenViewInMobileSwitch));
			BattleUiControl.Instance.OpenMainView();
			if (!CloudGameManager.Instance.IsCloudGame)
			{
				UiManager.Instance.OpenView(EUiViewName.PingView, null, null);
			}
			this.ReOpenCacheView();
		}

		// Token: 0x0602EADB RID: 191195 RVA: 0x00ACDBF8 File Offset: 0x00ACBDF8
		public void SwitchToGamepadByMenuSetting()
		{
			if (!Info.Instance.IsMobileInputModel())
			{
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				return;
			}
			Log.Instance.Info(ELogModule.MobileInputSwitch, ELogAuthor.XXJ, "[MenuSetting]触屏切换手柄", default(ReadOnlySpan<ValueTuple<string, object>>));
			EInputControllerType inputControllerType = PlatformModel.Instance.GetCurrentDeviceInputController();
			this.ClearAllView().ContinueWith(delegate()
			{
				this.OpenMobileSwitchInputView(true);
				Info.Instance.SwitchInputControllerType(inputControllerType, "MenuSetting");
			});
		}

		// Token: 0x0602EADC RID: 191196 RVA: 0x00ACDC74 File Offset: 0x00ACBE74
		public void SwitchToGamepad(EInputControllerType? inputType, string reason)
		{
			if (inputType == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MobileInputSwitch;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "触屏切换手柄异常,传入无效的输入设备类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!this.CanMobileSwitchInputCondition())
			{
				return;
			}
			this.CacheInputControllerType = inputType;
			if (Info.Instance.IsInGamepad())
			{
				return;
			}
			if (this.IsInSwitching)
			{
				return;
			}
			Log.Instance.Info(ELogModule.MobileInputSwitch, ELogAuthor.XXJ, "触屏切换手柄", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInSwitching = true;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MobileInputSwitch);
			confirmBoxDataNew.FunctionMap[1] = new Action(this.ResetState);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.ChooseSwitch);
			confirmBoxDataNew.SetCloseFunction(new Action(this.ShowMobileSwitchInputView));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602EADD RID: 191197 RVA: 0x00ACDD5C File Offset: 0x00ACBF5C
		public void SwitchToTouch()
		{
			if (!Info.Instance.IsMobileInputModel())
			{
				return;
			}
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			Log.Instance.Info(ELogModule.MobileInputSwitch, ELogAuthor.XXJ, "手柄切换触屏", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ClearAllView().ContinueWith(delegate()
			{
				EventSystem.Instance.Emit(EEventName.MobileGamepadDisconnect);
				this.OpenMobileSwitchInputView(false);
				Info.Instance.SwitchInputControllerType(EInputControllerType.Touch, "MobileSwitch");
			});
		}

		// Token: 0x0602EADE RID: 191198 RVA: 0x00ACDDBC File Offset: 0x00ACBFBC
		public bool SwitchToTouchByDisconnectGamepad()
		{
			if (!this.CanMobileSwitchInputCondition())
			{
				return false;
			}
			if (Info.Instance.IsInTouch())
			{
				return false;
			}
			Log.Instance.Info(ELogModule.MobileInputSwitch, ELogAuthor.XXJ, "手柄切换触屏DisconnectGamepad", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ClearAllView().ContinueWith(delegate()
			{
				EventSystem.Instance.Emit(EEventName.MobileGamepadDisconnect);
				this.OpenMobileSwitchInputView(false);
				Info.Instance.SwitchInputControllerType(EInputControllerType.Touch, "MobileSwitch");
			});
			return true;
		}

		// Token: 0x1700765F RID: 30303
		// (get) Token: 0x0602EADF RID: 191199 RVA: 0x00ACDE19 File Offset: 0x00ACC019
		public static MobileSwitchInputController Instance
		{
			get
			{
				if (MobileSwitchInputController._instance == null)
				{
					MobileSwitchInputController._instance = new MobileSwitchInputController();
					MobileSwitchInputController._instance.OnInit();
				}
				return MobileSwitchInputController._instance;
			}
		}

		// Token: 0x0602EAE0 RID: 191200 RVA: 0x00ACDE3C File Offset: 0x00ACC03C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EAE1 RID: 191201 RVA: 0x00ACDE3E File Offset: 0x00ACC03E
		public static void ResetStaticDefaultValue()
		{
			MobileSwitchInputController instance = MobileSwitchInputController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MobileSwitchInputController._instance = null;
		}

		// Token: 0x0602EAE2 RID: 191202 RVA: 0x00ACDE57 File Offset: 0x00ACC057
		static MobileSwitchInputController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MobileSwitchInputController.CreateStaticDefaultValue), new Action(MobileSwitchInputController.ResetStaticDefaultValue));
		}

		// Token: 0x040196A9 RID: 104105
		private bool NeedSwitch;

		// Token: 0x040196AA RID: 104106
		private bool IsInSwitching;

		// Token: 0x040196AB RID: 104107
		private EInputControllerType? CacheInputControllerType;

		// Token: 0x040196AC RID: 104108
		private readonly Dictionary<EUiViewName, MobileSwitchInputController.ICacheData> CacheOpenViewMap = new Dictionary<EUiViewName, MobileSwitchInputController.ICacheData>();

		// Token: 0x040196AD RID: 104109
		[Nullable(2)]
		private static MobileSwitchInputController _instance;

		// Token: 0x0200A8EE RID: 43246
		[NullableContext(2)]
		private interface ICacheData
		{
			// Token: 0x1700A14F RID: 41295
			// (get) Token: 0x0604D590 RID: 316816
			// (set) Token: 0x0604D591 RID: 316817
			EUiViewName UiViewName { get; set; }

			// Token: 0x1700A150 RID: 41296
			// (get) Token: 0x0604D592 RID: 316818
			// (set) Token: 0x0604D593 RID: 316819
			object Param { get; set; }
		}

		// Token: 0x0200A8EF RID: 43247
		[NullableContext(2)]
		[Nullable(0)]
		private class CacheData : MobileSwitchInputController.ICacheData
		{
			// Token: 0x1700A151 RID: 41297
			// (get) Token: 0x0604D594 RID: 316820 RVA: 0x01454ABD File Offset: 0x01452CBD
			// (set) Token: 0x0604D595 RID: 316821 RVA: 0x01454AC5 File Offset: 0x01452CC5
			public EUiViewName UiViewName { get; set; }

			// Token: 0x1700A152 RID: 41298
			// (get) Token: 0x0604D596 RID: 316822 RVA: 0x01454ACE File Offset: 0x01452CCE
			// (set) Token: 0x0604D597 RID: 316823 RVA: 0x01454AD6 File Offset: 0x01452CD6
			public object Param { get; set; }
		}
	}
}
