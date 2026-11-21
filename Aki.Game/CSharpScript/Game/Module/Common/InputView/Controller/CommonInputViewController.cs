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
	// Token: 0x02004B63 RID: 19299
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CommonInputViewController : UiControllerBase
	{
		// Token: 0x060303AF RID: 197551 RVA: 0x00D70E14 File Offset: 0x00D6F014
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

		// Token: 0x060303B0 RID: 197552 RVA: 0x00D70EB8 File Offset: 0x00D6F0B8
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

		// Token: 0x060303B1 RID: 197553 RVA: 0x00D70FC0 File Offset: 0x00D6F1C0
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

		// Token: 0x060303B2 RID: 197554 RVA: 0x00D71068 File Offset: 0x00D6F268
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

		// Token: 0x060303B3 RID: 197555 RVA: 0x00D71114 File Offset: 0x00D6F314
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

		// Token: 0x060303B4 RID: 197556 RVA: 0x00D711B0 File Offset: 0x00D6F3B0
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

		// Token: 0x060303B5 RID: 197557 RVA: 0x00D71244 File Offset: 0x00D6F444
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

		// Token: 0x060303B6 RID: 197558 RVA: 0x00D712E0 File Offset: 0x00D6F4E0
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

		// Token: 0x060303B7 RID: 197559 RVA: 0x00D7137C File Offset: 0x00D6F57C
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

		// Token: 0x060303B8 RID: 197560 RVA: 0x00D71428 File Offset: 0x00D6F628
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

		// Token: 0x170060A1 RID: 24737
		// (get) Token: 0x060303B9 RID: 197561 RVA: 0x00D714DE File Offset: 0x00D6F6DE
		public static CommonInputViewController Instance
		{
			get
			{
				return CommonInputViewController._Instance;
			}
		}

		// Token: 0x060303BA RID: 197562 RVA: 0x00D714E5 File Offset: 0x00D6F6E5
		public static CommonInputViewController GetOrCreateInstance()
		{
			if (CommonInputViewController._Instance == null)
			{
				CommonInputViewController.CreateInstance();
			}
			return CommonInputViewController._Instance;
		}

		// Token: 0x060303BB RID: 197563 RVA: 0x00D714F9 File Offset: 0x00D6F6F9
		public static bool CreateInstance()
		{
			if (CommonInputViewController._Instance != null)
			{
				return true;
			}
			CommonInputViewController._Instance = new CommonInputViewController();
			return true;
		}

		// Token: 0x060303BC RID: 197564 RVA: 0x00D7150F File Offset: 0x00D6F70F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060303BD RID: 197565 RVA: 0x00D71511 File Offset: 0x00D6F711
		public static void ResetStaticDefaultValue()
		{
			CommonInputViewController._Instance = null;
		}

		// Token: 0x060303BE RID: 197566 RVA: 0x00D71519 File Offset: 0x00D6F719
		static CommonInputViewController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonInputViewController.CreateStaticDefaultValue), new Action(CommonInputViewController.ResetStaticDefaultValue));
		}

		// Token: 0x0401991D RID: 104733
		[Nullable(2)]
		private static CommonInputViewController _Instance;
	}
}
