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
	// Token: 0x020035E4 RID: 13796
	[NullableContext(1)]
	[Nullable(0)]
	public class MobileSwitchInputController : Singleton
	{
		// Token: 0x0602321E RID: 143902 RVA: 0x009FC1BD File Offset: 0x009FA3BD
		private void ResetState()
		{
			this.IsInSwitching = false;
		}

		// Token: 0x0602321F RID: 143903 RVA: 0x009FC1C8 File Offset: 0x009FA3C8
		private void ChooseSwitch()
		{
			if (GameSettingsManager.Instance.GetCurrentValue(EFunction.MobileGamepadMode, true, true).GetValueOrDefault() != 1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Controler_Notconnect_tips", Array.Empty<object>());
				return;
			}
			this.NeedSwitch = true;
		}

		// Token: 0x06023220 RID: 143904 RVA: 0x009FC210 File Offset: 0x009FA410
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

		// Token: 0x06023221 RID: 143905 RVA: 0x009FC274 File Offset: 0x009FA474
		private UniTask ClearAllView()
		{
			MobileSwitchInputController.<ClearAllView>d__9 <ClearAllView>d__;
			<ClearAllView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearAllView>d__.<>1__state = -1;
			<ClearAllView>d__.<>t__builder.Start<MobileSwitchInputController.<ClearAllView>d__9>(ref <ClearAllView>d__);
			return <ClearAllView>d__.<>t__builder.Task;
		}

		// Token: 0x06023222 RID: 143906 RVA: 0x009FC2B0 File Offset: 0x009FA4B0
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

		// Token: 0x06023223 RID: 143907 RVA: 0x009FC33C File Offset: 0x009FA53C
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

		// Token: 0x06023224 RID: 143908 RVA: 0x009FC3E4 File Offset: 0x009FA5E4
		private void OpenMobileSwitchInputView(bool isSwitchToGamepad)
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.CheckOpenViewInMobileSwitch), "MobileSwitchInput");
			UiManager.Instance.OpenView(EUiViewName.MobileSwitchInputView, isSwitchToGamepad, null);
		}

		// Token: 0x06023225 RID: 143909 RVA: 0x009FC41C File Offset: 0x009FA61C
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

		// Token: 0x06023226 RID: 143910 RVA: 0x009FC474 File Offset: 0x009FA674
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

		// Token: 0x06023227 RID: 143911 RVA: 0x009FC4CC File Offset: 0x009FA6CC
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

		// Token: 0x06023228 RID: 143912 RVA: 0x009FC548 File Offset: 0x009FA748
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

		// Token: 0x06023229 RID: 143913 RVA: 0x009FC630 File Offset: 0x009FA830
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

		// Token: 0x0602322A RID: 143914 RVA: 0x009FC690 File Offset: 0x009FA890
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

		// Token: 0x1700491B RID: 18715
		// (get) Token: 0x0602322B RID: 143915 RVA: 0x009FC6ED File Offset: 0x009FA8ED
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

		// Token: 0x0602322C RID: 143916 RVA: 0x009FC710 File Offset: 0x009FA910
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602322D RID: 143917 RVA: 0x009FC712 File Offset: 0x009FA912
		public static void ResetStaticDefaultValue()
		{
			MobileSwitchInputController instance = MobileSwitchInputController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MobileSwitchInputController._instance = null;
		}

		// Token: 0x0602322E RID: 143918 RVA: 0x009FC72B File Offset: 0x009FA92B
		static MobileSwitchInputController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MobileSwitchInputController.CreateStaticDefaultValue), new Action(MobileSwitchInputController.ResetStaticDefaultValue));
		}

		// Token: 0x04013D4E RID: 81230
		private bool NeedSwitch;

		// Token: 0x04013D4F RID: 81231
		private bool IsInSwitching;

		// Token: 0x04013D50 RID: 81232
		private EInputControllerType? CacheInputControllerType;

		// Token: 0x04013D51 RID: 81233
		private readonly Dictionary<EUiViewName, MobileSwitchInputController.ICacheData> CacheOpenViewMap = new Dictionary<EUiViewName, MobileSwitchInputController.ICacheData>();

		// Token: 0x04013D52 RID: 81234
		[Nullable(2)]
		private static MobileSwitchInputController _instance;

		// Token: 0x020092A9 RID: 37545
		[NullableContext(2)]
		private interface ICacheData
		{
			// Token: 0x170078E5 RID: 30949
			// (get) Token: 0x06043ABD RID: 277181
			// (set) Token: 0x06043ABE RID: 277182
			EUiViewName UiViewName { get; set; }

			// Token: 0x170078E6 RID: 30950
			// (get) Token: 0x06043ABF RID: 277183
			// (set) Token: 0x06043AC0 RID: 277184
			object Param { get; set; }
		}

		// Token: 0x020092AA RID: 37546
		[NullableContext(2)]
		[Nullable(0)]
		private class CacheData : MobileSwitchInputController.ICacheData
		{
			// Token: 0x170078E7 RID: 30951
			// (get) Token: 0x06043AC1 RID: 277185 RVA: 0x01402F65 File Offset: 0x01401165
			// (set) Token: 0x06043AC2 RID: 277186 RVA: 0x01402F6D File Offset: 0x0140116D
			public EUiViewName UiViewName { get; set; }

			// Token: 0x170078E8 RID: 30952
			// (get) Token: 0x06043AC3 RID: 277187 RVA: 0x01402F76 File Offset: 0x01401176
			// (set) Token: 0x06043AC4 RID: 277188 RVA: 0x01402F7E File Offset: 0x0140117E
			public object Param { get; set; }
		}
	}
}
