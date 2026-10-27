using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.InputView.Model;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Common.InputView.Controller
{
	// Token: 0x02005B83 RID: 23427
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CommonInputViewController : UiControllerBase
	{
		// Token: 0x0603B462 RID: 242786 RVA: 0x00E208A0 File Offset: 0x00E1EAA0
		public void OpenSetRoleNameInputView()
		{
			string playerName = FunctionModel.Instance.GetPlayerName();
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("SetName");
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew(textContentIdById, Array.Empty<object>()),
				ConfirmFunc = new Func<string, UniTask<Aki.Protocol.ErrorCode>>(PersonalController.Instance.RequestModifyName),
				InputText = playerName,
				DefaultText = ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_3848209236_Text", null),
				IsCheckNone = true,
				NeedFunctionButton = false,
				BottomTipsText = string.Empty,
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.CommonModifyNameInputView, param, null);
		}

		// Token: 0x0603B463 RID: 242787 RVA: 0x00E20944 File Offset: 0x00E1EB44
		public void OpenSetPlayerRemarkNameInputView()
		{
			Func<string, UniTask<Aki.Protocol.ErrorCode>> confirmFunc = delegate([Nullable(1)] string input)
			{
				CommonInputViewController.<>c.<<OpenSetPlayerRemarkNameInputView>b__1_0>d <<OpenSetPlayerRemarkNameInputView>b__1_0>d;
				<<OpenSetPlayerRemarkNameInputView>b__1_0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
				<<OpenSetPlayerRemarkNameInputView>b__1_0>d.input = input;
				<<OpenSetPlayerRemarkNameInputView>b__1_0>d.<>1__state = -1;
				<<OpenSetPlayerRemarkNameInputView>b__1_0>d.<>t__builder.Start<CommonInputViewController.<>c.<<OpenSetPlayerRemarkNameInputView>b__1_0>d>(ref <<OpenSetPlayerRemarkNameInputView>b__1_0>d);
				return <<OpenSetPlayerRemarkNameInputView>b__1_0>d.<>t__builder.Task;
			};
			FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
			string text = (selectedPlayerOrItemInstance != null) ? selectedPlayerOrItemInstance.FriendRemark : null;
			if (StringUtils.IsEmpty(text))
			{
				FriendData selectedPlayerOrItemInstance2 = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
				text = ((selectedPlayerOrItemInstance2 != null) ? selectedPlayerOrItemInstance2.PlayerName : null);
			}
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("SetRemark");
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew(textContentIdById, Array.Empty<object>()),
				ConfirmFunc = confirmFunc,
				InputText = text,
				DefaultText = ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_3848209236_Text", null),
				IsCheckNone = false,
				NeedFunctionButton = false,
				BottomTipsText = string.Empty,
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.CommonSingleInputView, param, null);
		}

		// Token: 0x0603B464 RID: 242788 RVA: 0x00E20A4C File Offset: 0x00E1EC4C
		public void OpenPersonalSignInputView()
		{
			string signature = PersonalModel.Instance.GetSignature();
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("SetSign");
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew(textContentIdById, Array.Empty<object>()),
				ConfirmFunc = new Func<string, UniTask<Aki.Protocol.ErrorCode>>(PersonalController.Instance.RequestModifySignature),
				DefaultText = TextConfig.Instance.GetTextById("ComplianceWithTheLaw"),
				InputText = signature,
				IsCheckNone = false,
				NeedFunctionButton = false,
				BottomTipsText = string.Empty,
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.CommonMultiInputView, param, null);
		}

		// Token: 0x0603B465 RID: 242789 RVA: 0x00E20AF4 File Offset: 0x00E1ECF4
		public void OpenCdKeyInputView()
		{
			Func<string, UniTask<Aki.Protocol.ErrorCode>> confirmFunc = delegate([Nullable(1)] string input)
			{
				CommonInputViewController.<>c.<<OpenCdKeyInputView>b__3_0>d <<OpenCdKeyInputView>b__3_0>d;
				<<OpenCdKeyInputView>b__3_0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
				<<OpenCdKeyInputView>b__3_0>d.input = input;
				<<OpenCdKeyInputView>b__3_0>d.<>1__state = -1;
				<<OpenCdKeyInputView>b__3_0>d.<>t__builder.Start<CommonInputViewController.<>c.<<OpenCdKeyInputView>b__3_0>d>(ref <<OpenCdKeyInputView>b__3_0>d);
				return <<OpenCdKeyInputView>b__3_0>d.<>t__builder.Task;
			};
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew("PrefabTextItem_CDKey_Title", Array.Empty<object>()),
				ConfirmFunc = confirmFunc,
				DefaultText = (ConfigMultiTextLang.GetLocalTextNew("CDKey_InputEmpty", null) ?? string.Empty),
				InputText = string.Empty,
				IsCheckNone = true,
				NeedFunctionButton = true,
				BottomTipsText = string.Empty,
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.CdKeyInputView, param, null);
		}

		// Token: 0x0603B466 RID: 242790 RVA: 0x00E20BA0 File Offset: 0x00E1EDA0
		public void OpenSetVisionEquipGroupName(string bottomText, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack, string startInputText = "")
		{
			CommonInputViewController.<>c__DisplayClass4_0 CS$<>8__locals1 = new CommonInputViewController.<>c__DisplayClass4_0();
			CS$<>8__locals1.callBack = callBack;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> confirmFunc = delegate([Nullable(1)] string input)
			{
				CommonInputViewController.<>c__DisplayClass4_0.<<OpenSetVisionEquipGroupName>b__0>d <<OpenSetVisionEquipGroupName>b__0>d;
				<<OpenSetVisionEquipGroupName>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
				<<OpenSetVisionEquipGroupName>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenSetVisionEquipGroupName>b__0>d.input = input;
				<<OpenSetVisionEquipGroupName>b__0>d.<>1__state = -1;
				<<OpenSetVisionEquipGroupName>b__0>d.<>t__builder.Start<CommonInputViewController.<>c__DisplayClass4_0.<<OpenSetVisionEquipGroupName>b__0>d>(ref <<OpenSetVisionEquipGroupName>b__0>d);
				return <<OpenSetVisionEquipGroupName>b__0>d.<>t__builder.Task;
			};
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew("VisionAssembleSaveTips", Array.Empty<object>()),
				ConfirmFunc = confirmFunc,
				InputText = startInputText,
				DefaultText = ConfigMultiTextLang.GetLocalTextNew("VisionAssembleInputTips", null),
				IsCheckNone = true,
				NeedFunctionButton = false,
				BottomTipsText = bottomText,
				BottomTipsColor = "000000",
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.VisionAssembleInputView, param, null);
		}

		// Token: 0x0603B467 RID: 242791 RVA: 0x00E20C3C File Offset: 0x00E1EE3C
		public void OpenChangeVisionEquipGroupName(string bottomText, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack)
		{
			CommonInputViewController.<>c__DisplayClass5_0 CS$<>8__locals1 = new CommonInputViewController.<>c__DisplayClass5_0();
			CS$<>8__locals1.callBack = callBack;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> confirmFunc = delegate([Nullable(1)] string input)
			{
				CommonInputViewController.<>c__DisplayClass5_0.<<OpenChangeVisionEquipGroupName>b__0>d <<OpenChangeVisionEquipGroupName>b__0>d;
				<<OpenChangeVisionEquipGroupName>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
				<<OpenChangeVisionEquipGroupName>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenChangeVisionEquipGroupName>b__0>d.input = input;
				<<OpenChangeVisionEquipGroupName>b__0>d.<>1__state = -1;
				<<OpenChangeVisionEquipGroupName>b__0>d.<>t__builder.Start<CommonInputViewController.<>c__DisplayClass5_0.<<OpenChangeVisionEquipGroupName>b__0>d>(ref <<OpenChangeVisionEquipGroupName>b__0>d);
				return <<OpenChangeVisionEquipGroupName>b__0>d.<>t__builder.Task;
			};
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew("VisionAssembleChangeNameTips", Array.Empty<object>()),
				ConfirmFunc = confirmFunc,
				InputText = string.Empty,
				DefaultText = ConfigMultiTextLang.GetLocalTextNew("VisionAssembleInputTips", null),
				IsCheckNone = false,
				NeedFunctionButton = false,
				BottomTipsText = bottomText,
				BottomTipsColor = "000000"
			};
			UiManager.Instance.OpenView(EUiViewName.CommonSingleInputView, param, null);
		}

		// Token: 0x0603B468 RID: 242792 RVA: 0x00E20CD0 File Offset: 0x00E1EED0
		public void OpenSetPhantomArenaDeckName(string bottomText, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack, string startInputText = "")
		{
			CommonInputViewController.<>c__DisplayClass6_0 CS$<>8__locals1 = new CommonInputViewController.<>c__DisplayClass6_0();
			CS$<>8__locals1.callBack = callBack;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> confirmFunc = delegate([Nullable(1)] string input)
			{
				CommonInputViewController.<>c__DisplayClass6_0.<<OpenSetPhantomArenaDeckName>b__0>d <<OpenSetPhantomArenaDeckName>b__0>d;
				<<OpenSetPhantomArenaDeckName>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
				<<OpenSetPhantomArenaDeckName>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenSetPhantomArenaDeckName>b__0>d.input = input;
				<<OpenSetPhantomArenaDeckName>b__0>d.<>1__state = -1;
				<<OpenSetPhantomArenaDeckName>b__0>d.<>t__builder.Start<CommonInputViewController.<>c__DisplayClass6_0.<<OpenSetPhantomArenaDeckName>b__0>d>(ref <<OpenSetPhantomArenaDeckName>b__0>d);
				return <<OpenSetPhantomArenaDeckName>b__0>d.<>t__builder.Task;
			};
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew("PhantomBattle_1076", Array.Empty<object>()),
				ConfirmFunc = confirmFunc,
				InputText = startInputText,
				DefaultText = ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1077", null),
				IsCheckNone = true,
				NeedFunctionButton = false,
				BottomTipsText = bottomText,
				BottomTipsColor = "000000",
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.DeckRenameInputView, param, null);
		}

		// Token: 0x0603B469 RID: 242793 RVA: 0x00E20D6C File Offset: 0x00E1EF6C
		public void OpenSetPhantomManageConfigName(string inputText, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack, string bottomText = "")
		{
			CommonInputViewController.<>c__DisplayClass7_0 CS$<>8__locals1 = new CommonInputViewController.<>c__DisplayClass7_0();
			CS$<>8__locals1.callBack = callBack;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> confirmFunc = delegate([Nullable(1)] string input)
			{
				CommonInputViewController.<>c__DisplayClass7_0.<<OpenSetPhantomManageConfigName>b__0>d <<OpenSetPhantomManageConfigName>b__0>d;
				<<OpenSetPhantomManageConfigName>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
				<<OpenSetPhantomManageConfigName>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenSetPhantomManageConfigName>b__0>d.input = input;
				<<OpenSetPhantomManageConfigName>b__0>d.<>1__state = -1;
				<<OpenSetPhantomManageConfigName>b__0>d.<>t__builder.Start<CommonInputViewController.<>c__DisplayClass7_0.<<OpenSetPhantomManageConfigName>b__0>d>(ref <<OpenSetPhantomManageConfigName>b__0>d);
				return <<OpenSetPhantomManageConfigName>b__0>d.<>t__builder.Task;
			};
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew("PhantomProject_Name", Array.Empty<object>()),
				ConfirmFunc = confirmFunc,
				InputText = inputText,
				DefaultText = ConfigMultiTextLang.GetLocalTextNew("PhantomProject_Tips01", null),
				IsCheckNone = true,
				NeedFunctionButton = false,
				BottomTipsText = bottomText,
				BottomTipsColor = "000000",
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomManageConfigRenameInputView, param, null);
		}

		// Token: 0x0603B46A RID: 242794 RVA: 0x00E20E08 File Offset: 0x00E1F008
		public void OpenMotorcycleDiyNameInputView([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack, string initialInputText = "")
		{
			CommonInputViewController.<>c__DisplayClass8_0 CS$<>8__locals1 = new CommonInputViewController.<>c__DisplayClass8_0();
			CS$<>8__locals1.callBack = callBack;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> confirmFunc = delegate([Nullable(1)] string input)
			{
				CommonInputViewController.<>c__DisplayClass8_0.<<OpenMotorcycleDiyNameInputView>b__0>d <<OpenMotorcycleDiyNameInputView>b__0>d;
				<<OpenMotorcycleDiyNameInputView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
				<<OpenMotorcycleDiyNameInputView>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenMotorcycleDiyNameInputView>b__0>d.input = input;
				<<OpenMotorcycleDiyNameInputView>b__0>d.<>1__state = -1;
				<<OpenMotorcycleDiyNameInputView>b__0>d.<>t__builder.Start<CommonInputViewController.<>c__DisplayClass8_0.<<OpenMotorcycleDiyNameInputView>b__0>d>(ref <<OpenMotorcycleDiyNameInputView>b__0>d);
				return <<OpenMotorcycleDiyNameInputView>b__0>d.<>t__builder.Task;
			};
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew("DIYProjectEditName", Array.Empty<object>()),
				ConfirmFunc = confirmFunc,
				DefaultText = (ConfigMultiTextLang.GetLocalTextNew("DIYProjectDefaultName", null) ?? string.Empty),
				InputText = initialInputText,
				IsCheckNone = true,
				NeedFunctionButton = false,
				BottomTipsText = string.Empty,
				BottomTipsColor = "000000",
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyNameInputView, param, null);
		}

		// Token: 0x0603B46B RID: 242795 RVA: 0x00E20EB4 File Offset: 0x00E1F0B4
		public void OpenRenameFormationInputView([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack, string startInputText = "", [Nullable(2)] string currentDisplayName = null)
		{
			ICommonInputViewData param = new CommonInputViewData
			{
				TitleTextArgs = new TableTextArgNew("Team_EditNameBox", Array.Empty<object>()),
				ConfirmFunc = callBack,
				InputText = startInputText,
				DefaultText = (ConfigMultiTextLang.GetLocalTextNew("PrefabTextItem_3848209236_Text", null) ?? string.Empty),
				IsCheckNone = false,
				NeedFunctionButton = false,
				BottomTipsText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Team_EditName", null) ?? string.Empty, new string[]
				{
					currentDisplayName ?? startInputText
				}),
				BottomTipsColor = "000000",
				NeedCheckBlank = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.CommonSingleInputView, param, null);
		}

		// Token: 0x17008CCF RID: 36047
		// (get) Token: 0x0603B46C RID: 242796 RVA: 0x00E20F6A File Offset: 0x00E1F16A
		public static CommonInputViewController Instance
		{
			get
			{
				return CommonInputViewController._Instance;
			}
		}

		// Token: 0x0603B46D RID: 242797 RVA: 0x00E20F71 File Offset: 0x00E1F171
		public static CommonInputViewController GetOrCreateInstance()
		{
			if (CommonInputViewController._Instance == null)
			{
				CommonInputViewController.CreateInstance();
			}
			return CommonInputViewController._Instance;
		}

		// Token: 0x0603B46E RID: 242798 RVA: 0x00E20F85 File Offset: 0x00E1F185
		public static bool CreateInstance()
		{
			if (CommonInputViewController._Instance != null)
			{
				return true;
			}
			CommonInputViewController._Instance = new CommonInputViewController();
			return true;
		}

		// Token: 0x0603B46F RID: 242799 RVA: 0x00E20F9B File Offset: 0x00E1F19B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B470 RID: 242800 RVA: 0x00E20F9D File Offset: 0x00E1F19D
		public static void ResetStaticDefaultValue()
		{
			CommonInputViewController._Instance = null;
		}

		// Token: 0x0603B471 RID: 242801 RVA: 0x00E20FA5 File Offset: 0x00E1F1A5
		static CommonInputViewController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonInputViewController.CreateStaticDefaultValue), new Action(CommonInputViewController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE6C RID: 126572
		[Nullable(2)]
		private static CommonInputViewController _Instance;
	}
}
