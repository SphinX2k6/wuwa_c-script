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
	// Token: 0x02004A0A RID: 18954
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class HomeBtnController : ControllerBase
	{
		// Token: 0x060312F7 RID: 201463 RVA: 0x00B6864C File Offset: 0x00B6684C
		public void AddExtraAsyncCallback(EUiViewName viewName, Func<UniTask> callback)
		{
			this.ExtraCallback[viewName] = callback;
		}

		// Token: 0x060312F8 RID: 201464 RVA: 0x00B6865C File Offset: 0x00B6685C
		public void AddExtraCallback(EUiViewName viewName, Action callback)
		{
			Func<UniTask> value = delegate()
			{
				callback();
				return UniTask.CompletedTask;
			};
			this.ExtraCallback[viewName] = value;
		}

		// Token: 0x060312F9 RID: 201465 RVA: 0x00B6868E File Offset: 0x00B6688E
		public void RemoveExtraCallback(EUiViewName viewName)
		{
			this.ExtraCallback.Remove(viewName);
		}

		// Token: 0x060312FA RID: 201466 RVA: 0x00B6869D File Offset: 0x00B6689D
		protected override bool OnClear()
		{
			this.ExtraCallback.Clear();
			return true;
		}

		// Token: 0x060312FB RID: 201467 RVA: 0x00B686AB File Offset: 0x00B668AB
		public void ExecuteBtnClick()
		{
			if (HomeBtnModel.Instance.EnableHomeBtnLogic)
			{
				this.OnResetToBattleView().Forget();
				return;
			}
			this.OnShowPrompt();
		}

		// Token: 0x060312FC RID: 201468 RVA: 0x00B686CC File Offset: 0x00B668CC
		private UniTask OnResetToBattleView()
		{
			HomeBtnController.<OnResetToBattleView>d__6 <OnResetToBattleView>d__;
			<OnResetToBattleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnResetToBattleView>d__.<>4__this = this;
			<OnResetToBattleView>d__.<>1__state = -1;
			<OnResetToBattleView>d__.<>t__builder.Start<HomeBtnController.<OnResetToBattleView>d__6>(ref <OnResetToBattleView>d__);
			return <OnResetToBattleView>d__.<>t__builder.Task;
		}

		// Token: 0x060312FD RID: 201469 RVA: 0x00B68710 File Offset: 0x00B66910
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

		// Token: 0x060312FE RID: 201470 RVA: 0x00B68753 File Offset: 0x00B66953
		private void OnShowPrompt()
		{
			GenericPromptController.Instance.ShowPromptByCode("HomeBtnTips_Unavailable", Array.Empty<object>());
		}

		// Token: 0x060312FF RID: 201471 RVA: 0x00B6876C File Offset: 0x00B6696C
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

		// Token: 0x06031300 RID: 201472 RVA: 0x00B68848 File Offset: 0x00B66A48
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

		// Token: 0x06031301 RID: 201473 RVA: 0x00B688E8 File Offset: 0x00B66AE8
		private int GetHomeBtnStyle(EUiViewName viewName)
		{
			UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(viewName);
			if (uiShowConfig == null)
			{
				return 1;
			}
			return uiShowConfig.GetValueOrDefault().HomeBtnStyle;
		}

		// Token: 0x170079ED RID: 31213
		// (get) Token: 0x06031302 RID: 201474 RVA: 0x00B6891B File Offset: 0x00B66B1B
		public static HomeBtnController Instance
		{
			get
			{
				return HomeBtnController._Instance;
			}
		}

		// Token: 0x06031303 RID: 201475 RVA: 0x00B68922 File Offset: 0x00B66B22
		public static HomeBtnController GetOrCreateInstance()
		{
			if (HomeBtnController._Instance == null)
			{
				HomeBtnController.CreateInstance();
			}
			return HomeBtnController._Instance;
		}

		// Token: 0x06031304 RID: 201476 RVA: 0x00B68936 File Offset: 0x00B66B36
		public static bool CreateInstance()
		{
			if (HomeBtnController._Instance != null)
			{
				return true;
			}
			HomeBtnController._Instance = new HomeBtnController();
			return true;
		}

		// Token: 0x06031305 RID: 201477 RVA: 0x00B6894C File Offset: 0x00B66B4C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031306 RID: 201478 RVA: 0x00B6894E File Offset: 0x00B66B4E
		public static void ResetStaticDefaultValue()
		{
			HomeBtnController._Instance = null;
		}

		// Token: 0x06031307 RID: 201479 RVA: 0x00B68956 File Offset: 0x00B66B56
		static HomeBtnController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HomeBtnController.CreateStaticDefaultValue), new Action(HomeBtnController.ResetStaticDefaultValue));
		}

		// Token: 0x0401A4F0 RID: 107760
		private readonly Dictionary<EUiViewName, Func<UniTask>> ExtraCallback = new Dictionary<EUiViewName, Func<UniTask>>();

		// Token: 0x0401A4F1 RID: 107761
		[Nullable(2)]
		private static HomeBtnController _Instance;
	}
}
