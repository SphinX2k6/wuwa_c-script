using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiComponent.UiHomeButton
{
	// Token: 0x02003986 RID: 14726
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class HomeBtnController : ControllerBase
	{
		// Token: 0x06025E47 RID: 155207 RVA: 0x00AA3E52 File Offset: 0x00AA2052
		public void AddExtraAsyncCallback(EUiViewName viewName, Func<UniTask> callback)
		{
			this.ExtraCallback[viewName] = callback;
		}

		// Token: 0x06025E48 RID: 155208 RVA: 0x00AA3E64 File Offset: 0x00AA2064
		public void AddExtraCallback(EUiViewName viewName, Action callback)
		{
			Func<UniTask> value = delegate()
			{
				callback();
				return UniTask.CompletedTask;
			};
			this.ExtraCallback[viewName] = value;
		}

		// Token: 0x06025E49 RID: 155209 RVA: 0x00AA3E96 File Offset: 0x00AA2096
		public void RemoveExtraCallback(EUiViewName viewName)
		{
			this.ExtraCallback.Remove(viewName);
		}

		// Token: 0x06025E4A RID: 155210 RVA: 0x00AA3EA5 File Offset: 0x00AA20A5
		protected override bool OnClear()
		{
			this.ExtraCallback.Clear();
			return true;
		}

		// Token: 0x06025E4B RID: 155211 RVA: 0x00AA3EB3 File Offset: 0x00AA20B3
		public void ExecuteBtnClick()
		{
			if (HomeBtnModel.Instance.EnableHomeBtnLogic)
			{
				this.OnResetToBattleView().Forget();
				return;
			}
			this.OnShowPrompt();
		}

		// Token: 0x06025E4C RID: 155212 RVA: 0x00AA3ED4 File Offset: 0x00AA20D4
		private UniTask OnResetToBattleView()
		{
			HomeBtnController.<OnResetToBattleView>d__6 <OnResetToBattleView>d__;
			<OnResetToBattleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnResetToBattleView>d__.<>4__this = this;
			<OnResetToBattleView>d__.<>1__state = -1;
			<OnResetToBattleView>d__.<>t__builder.Start<HomeBtnController.<OnResetToBattleView>d__6>(ref <OnResetToBattleView>d__);
			return <OnResetToBattleView>d__.<>t__builder.Task;
		}

		// Token: 0x06025E4D RID: 155213 RVA: 0x00AA3F18 File Offset: 0x00AA2118
		private UniTask OnAfterResetToBattleView([Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<EUiViewName, Func<UniTask>> extraCallback)
		{
			HomeBtnController.<OnAfterResetToBattleView>d__7 <OnAfterResetToBattleView>d__;
			<OnAfterResetToBattleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnAfterResetToBattleView>d__.extraCallback = extraCallback;
			<OnAfterResetToBattleView>d__.<>1__state = -1;
			<OnAfterResetToBattleView>d__.<>t__builder.Start<HomeBtnController.<OnAfterResetToBattleView>d__7>(ref <OnAfterResetToBattleView>d__);
			return <OnAfterResetToBattleView>d__.<>t__builder.Task;
		}

		// Token: 0x06025E4E RID: 155214 RVA: 0x00AA3F5B File Offset: 0x00AA215B
		private void OnShowPrompt()
		{
			GenericPromptController.Instance.ShowPromptByCode("HomeBtnTips_Unavailable", Array.Empty<object>());
		}

		// Token: 0x06025E4F RID: 155215 RVA: 0x00AA3F74 File Offset: 0x00AA2174
		public unsafe void CreateHomeBtnFromUiItem(UUIItem parent, EUiViewName viewName, [Nullable(2)] string tag = null, bool snapSize = false)
		{
			if (!HomeBtnModel.Instance.GetShowHomeBtn(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HomeBtn;
				ELogAuthor author = ELogAuthor.CB;
				string message = "传入的viewName不支持配置Home键或Home键功能被关闭";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tag", tag);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			AActor owner = parent.GetOwner();
			TsUiHomeHelper tsUiHomeHelper = ((owner != null) ? owner.GetComponentByClass(TsUiHomeHelper.StaticClass()) : null) as TsUiHomeHelper;
			if (tsUiHomeHelper == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.HomeBtn;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "父节点没有TsUiHomeHelper";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("displayName", parent.GetDisplayName());
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int homeBtnStyle = this.GetHomeBtnStyle(viewName);
			tsUiHomeHelper.CreateHomeBtn(homeBtnStyle, snapSize);
		}

		// Token: 0x06025E50 RID: 155216 RVA: 0x00AA4050 File Offset: 0x00AA2250
		public void CreateHomeBtnFromView(UiViewBase view)
		{
			EUiViewName name = view.ViewInfo.Name;
			if (!HomeBtnModel.Instance.GetShowHomeBtn(name))
			{
				return;
			}
			if (view.ViewInfo.Type != ELayerType.Normal && view.ViewInfo.Type != ELayerType.Pop)
			{
				return;
			}
			if (!HomeBtnModel.Instance.GetNeedFindComponent(name))
			{
				return;
			}
			TsUiHomeHelper tsUiHomeHelper = ULGUIBPLibrary.GetComponentInChildren(view.GetRootActor(), TsUiHomeHelper.StaticClass(), false) as TsUiHomeHelper;
			if (tsUiHomeHelper == null)
			{
				HomeBtnModel.Instance.AddViewNameToNoFindComponent(name);
				return;
			}
			int homeBtnStyle = this.GetHomeBtnStyle(name);
			tsUiHomeHelper.CreateHomeBtn(homeBtnStyle, false);
		}

		// Token: 0x06025E51 RID: 155217 RVA: 0x00AA40F0 File Offset: 0x00AA22F0
		private int GetHomeBtnStyle(EUiViewName viewName)
		{
			UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(viewName);
			if (uiShowConfig == null)
			{
				return 1;
			}
			return uiShowConfig.GetValueOrDefault().HomeBtnStyle;
		}

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x06025E52 RID: 155218 RVA: 0x00AA4123 File Offset: 0x00AA2323
		public static HomeBtnController Instance
		{
			get
			{
				return HomeBtnController._Instance;
			}
		}

		// Token: 0x06025E53 RID: 155219 RVA: 0x00AA412A File Offset: 0x00AA232A
		public static HomeBtnController GetOrCreateInstance()
		{
			if (HomeBtnController._Instance == null)
			{
				HomeBtnController.CreateInstance();
			}
			return HomeBtnController._Instance;
		}

		// Token: 0x06025E54 RID: 155220 RVA: 0x00AA413E File Offset: 0x00AA233E
		public static bool CreateInstance()
		{
			if (HomeBtnController._Instance != null)
			{
				return true;
			}
			HomeBtnController._Instance = new HomeBtnController();
			return true;
		}

		// Token: 0x06025E55 RID: 155221 RVA: 0x00AA4154 File Offset: 0x00AA2354
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025E56 RID: 155222 RVA: 0x00AA4156 File Offset: 0x00AA2356
		public static void ResetStaticDefaultValue()
		{
			HomeBtnController._Instance = null;
		}

		// Token: 0x06025E57 RID: 155223 RVA: 0x00AA415E File Offset: 0x00AA235E
		static HomeBtnController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HomeBtnController.CreateStaticDefaultValue), new Action(HomeBtnController.ResetStaticDefaultValue));
		}

		// Token: 0x04014D76 RID: 85366
		private readonly Dictionary<EUiViewName, Func<UniTask>> ExtraCallback = new Dictionary<EUiViewName, Func<UniTask>>();

		// Token: 0x04014D77 RID: 85367
		[Nullable(2)]
		private static HomeBtnController _Instance;
	}
}
