using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiComponent.UiHomeButton
{
	// Token: 0x02003989 RID: 14729
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class HomeBtnModel : ModelBase
	{
		// Token: 0x06025E60 RID: 155232 RVA: 0x00AA42B5 File Offset: 0x00AA24B5
		protected override bool OnInit()
		{
			EventSystem.Instance.AddWithTarget<bool>(this, EEventName.BtnStateUpdate, new Action<bool>(this.OnHomeBtnStateUpdate));
			return true;
		}

		// Token: 0x06025E61 RID: 155233 RVA: 0x00AA42D5 File Offset: 0x00AA24D5
		private void OnHomeBtnStateUpdate(bool enable)
		{
			this.EnableHomeBtnFunctionInternal = enable;
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x06025E62 RID: 155234 RVA: 0x00AA42E0 File Offset: 0x00AA24E0
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

		// Token: 0x06025E63 RID: 155235 RVA: 0x00AA44BC File Offset: 0x00AA26BC
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

		// Token: 0x17004D57 RID: 19799
		// (get) Token: 0x06025E64 RID: 155236 RVA: 0x00AA453D File Offset: 0x00AA273D
		// (set) Token: 0x06025E65 RID: 155237 RVA: 0x00AA4545 File Offset: 0x00AA2745
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

		// Token: 0x06025E66 RID: 155238 RVA: 0x00AA454E File Offset: 0x00AA274E
		public void GmSetHomeBtnShow(EUiViewName viewName, bool value)
		{
			this.GmViewNameToHomeBtnShow[viewName] = value;
		}

		// Token: 0x06025E67 RID: 155239 RVA: 0x00AA455D File Offset: 0x00AA275D
		public void AddViewNameToNoFindComponent(string viewName)
		{
			this.ViewNameNoFindComponent.Add(viewName);
		}

		// Token: 0x06025E68 RID: 155240 RVA: 0x00AA456C File Offset: 0x00AA276C
		public bool GetNeedFindComponent(string viewName)
		{
			return !this.ViewNameNoFindComponent.Contains(viewName);
		}

		// Token: 0x06025E69 RID: 155241 RVA: 0x00AA457D File Offset: 0x00AA277D
		protected override bool OnClear()
		{
			EventSystem.Instance.RemoveWithTarget<bool>(this, EEventName.BtnStateUpdate, new Action<bool>(this.OnHomeBtnStateUpdate));
			this.GmViewNameToHomeBtnShow.Clear();
			this.ViewNameNoFindComponent.Clear();
			return true;
		}

		// Token: 0x17004D58 RID: 19800
		// (get) Token: 0x06025E6A RID: 155242 RVA: 0x00AA45B3 File Offset: 0x00AA27B3
		public static HomeBtnModel Instance
		{
			get
			{
				return HomeBtnModel._Instance;
			}
		}

		// Token: 0x06025E6B RID: 155243 RVA: 0x00AA45BA File Offset: 0x00AA27BA
		public static HomeBtnModel GetOrCreateInstance()
		{
			if (HomeBtnModel._Instance == null)
			{
				HomeBtnModel.CreateInstance();
			}
			return HomeBtnModel._Instance;
		}

		// Token: 0x06025E6C RID: 155244 RVA: 0x00AA45CE File Offset: 0x00AA27CE
		public static bool CreateInstance()
		{
			if (HomeBtnModel._Instance != null)
			{
				return true;
			}
			HomeBtnModel._Instance = new HomeBtnModel();
			return true;
		}

		// Token: 0x06025E6D RID: 155245 RVA: 0x00AA45E4 File Offset: 0x00AA27E4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025E6E RID: 155246 RVA: 0x00AA45E6 File Offset: 0x00AA27E6
		public static void ResetStaticDefaultValue()
		{
			HomeBtnModel._Instance = null;
		}

		// Token: 0x06025E6F RID: 155247 RVA: 0x00AA45EE File Offset: 0x00AA27EE
		static HomeBtnModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HomeBtnModel.CreateStaticDefaultValue), new Action(HomeBtnModel.ResetStaticDefaultValue));
		}

		// Token: 0x04014D7F RID: 85375
		private bool EnableHomeBtnFunctionInternal = true;

		// Token: 0x04014D80 RID: 85376
		private readonly Dictionary<EUiViewName, bool> GmViewNameToHomeBtnShow = new Dictionary<EUiViewName, bool>();

		// Token: 0x04014D81 RID: 85377
		private readonly HashSet<string> ViewNameNoFindComponent = new HashSet<string>();

		// Token: 0x04014D82 RID: 85378
		[Nullable(2)]
		private static HomeBtnModel _Instance;
	}
}
