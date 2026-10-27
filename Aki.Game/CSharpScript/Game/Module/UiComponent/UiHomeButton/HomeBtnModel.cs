using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiComponent.UiHomeButton
{
	// Token: 0x02004A0D RID: 18957
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class HomeBtnModel : ModelBase
	{
		// Token: 0x06031310 RID: 201488 RVA: 0x00B68AAD File Offset: 0x00B66CAD
		protected override bool OnInit()
		{
			EventSystem.Instance.AddWithTarget<bool>(this, EEventName.BtnStateUpdate, new Action<bool>(this.OnHomeBtnStateUpdate));
			return true;
		}

		// Token: 0x06031311 RID: 201489 RVA: 0x00B68ACD File Offset: 0x00B66CCD
		private void OnHomeBtnStateUpdate(bool enable)
		{
			this.EnableHomeBtnFunctionInternal = enable;
		}

		// Token: 0x170079EE RID: 31214
		// (get) Token: 0x06031312 RID: 201490 RVA: 0x00B68AD8 File Offset: 0x00B66CD8
		public bool EnableHomeBtnLogic
		{
			get
			{
				if (!this.EnableHomeBtnFunctionInternal)
				{
					return false;
				}
				foreach (UiViewBase uiViewBase in UiModel.Instance.NormalStack)
				{
					UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(uiViewBase.ViewInfo.Name);
					int? num = (uiShowConfig != null) ? new int?(uiShowConfig.GetValueOrDefault().HomeBtnShowType) : null;
					int num2 = 0;
					if (num.GetValueOrDefault() == num2 & num != null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.HomeBtn;
						ELogAuthor author = ELogAuthor.CB;
						string message = "当前有UI界面不支持显示Home键";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName:", uiViewBase.ViewInfo.Name);
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return false;
					}
				}
				foreach (UiViewBase uiViewBase2 in UiModel.Instance.PopList)
				{
					UiShow? uiShowConfig2 = UiViewConfig.Instance.GetUiShowConfig(uiViewBase2.ViewInfo.Name);
					int? num = (uiShowConfig2 != null) ? new int?(uiShowConfig2.GetValueOrDefault().HomeBtnShowType) : null;
					int num2 = 0;
					if (num.GetValueOrDefault() == num2 & num != null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.HomeBtn;
						ELogAuthor author2 = ELogAuthor.CB;
						string message2 = "当前有UI界面不支持返回主界面";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ViewName:", uiViewBase2.ViewInfo.Name);
						instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x06031313 RID: 201491 RVA: 0x00B68CB4 File Offset: 0x00B66EB4
		public bool GetShowHomeBtn(EUiViewName viewName)
		{
			if (!this.EnableHomeBtnFunctionInternal)
			{
				return false;
			}
			bool result;
			if (this.GmViewNameToHomeBtnShow.TryGetValue(viewName, out result))
			{
				return result;
			}
			UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(viewName);
			if (uiShowConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HomeBtn;
				ELogAuthor author = ELogAuthor.CB;
				string message = "未找到UI界面配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName:", viewName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return uiShowConfig.Value.HomeBtnShowType == 1;
		}

		// Token: 0x170079EF RID: 31215
		// (get) Token: 0x06031314 RID: 201492 RVA: 0x00B68D35 File Offset: 0x00B66F35
		// (set) Token: 0x06031315 RID: 201493 RVA: 0x00B68D3D File Offset: 0x00B66F3D
		public bool EnableHomeBtnFunction
		{
			get
			{
				return this.EnableHomeBtnFunctionInternal;
			}
			set
			{
				this.EnableHomeBtnFunctionInternal = value;
			}
		}

		// Token: 0x06031316 RID: 201494 RVA: 0x00B68D46 File Offset: 0x00B66F46
		public void GmSetHomeBtnShow(EUiViewName viewName, bool value)
		{
			this.GmViewNameToHomeBtnShow[viewName] = value;
		}

		// Token: 0x06031317 RID: 201495 RVA: 0x00B68D55 File Offset: 0x00B66F55
		public void AddViewNameToNoFindComponent(string viewName)
		{
			this.ViewNameNoFindComponent.Add(viewName);
		}

		// Token: 0x06031318 RID: 201496 RVA: 0x00B68D64 File Offset: 0x00B66F64
		public bool GetNeedFindComponent(string viewName)
		{
			return !this.ViewNameNoFindComponent.Contains(viewName);
		}

		// Token: 0x06031319 RID: 201497 RVA: 0x00B68D75 File Offset: 0x00B66F75
		protected override bool OnClear()
		{
			EventSystem.Instance.RemoveWithTarget<bool>(this, EEventName.BtnStateUpdate, new Action<bool>(this.OnHomeBtnStateUpdate));
			this.GmViewNameToHomeBtnShow.Clear();
			this.ViewNameNoFindComponent.Clear();
			return true;
		}

		// Token: 0x170079F0 RID: 31216
		// (get) Token: 0x0603131A RID: 201498 RVA: 0x00B68DAB File Offset: 0x00B66FAB
		public static HomeBtnModel Instance
		{
			get
			{
				return HomeBtnModel._Instance;
			}
		}

		// Token: 0x0603131B RID: 201499 RVA: 0x00B68DB2 File Offset: 0x00B66FB2
		public static HomeBtnModel GetOrCreateInstance()
		{
			if (HomeBtnModel._Instance == null)
			{
				HomeBtnModel.CreateInstance();
			}
			return HomeBtnModel._Instance;
		}

		// Token: 0x0603131C RID: 201500 RVA: 0x00B68DC6 File Offset: 0x00B66FC6
		public static bool CreateInstance()
		{
			if (HomeBtnModel._Instance != null)
			{
				return true;
			}
			HomeBtnModel._Instance = new HomeBtnModel();
			return true;
		}

		// Token: 0x0603131D RID: 201501 RVA: 0x00B68DDC File Offset: 0x00B66FDC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603131E RID: 201502 RVA: 0x00B68DDE File Offset: 0x00B66FDE
		public static void ResetStaticDefaultValue()
		{
			HomeBtnModel._Instance = null;
		}

		// Token: 0x0603131F RID: 201503 RVA: 0x00B68DE6 File Offset: 0x00B66FE6
		static HomeBtnModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HomeBtnModel.CreateStaticDefaultValue), new Action(HomeBtnModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401A4F9 RID: 107769
		private bool EnableHomeBtnFunctionInternal = true;

		// Token: 0x0401A4FA RID: 107770
		private readonly Dictionary<EUiViewName, bool> GmViewNameToHomeBtnShow = new Dictionary<EUiViewName, bool>();

		// Token: 0x0401A4FB RID: 107771
		private readonly HashSet<string> ViewNameNoFindComponent = new HashSet<string>();

		// Token: 0x0401A4FC RID: 107772
		[Nullable(2)]
		private static HomeBtnModel _Instance;
	}
}
