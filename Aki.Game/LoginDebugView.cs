using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F43 RID: 3907
[NullableContext(1)]
[Nullable(0)]
public class LoginDebugView : UiViewBase
{
	// Token: 0x06009C20 RID: 39968 RVA: 0x002E4516 File Offset: 0x002E2716
	public LoginDebugView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009C21 RID: 39969 RVA: 0x002E4528 File Offset: 0x002E2728
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIDropdownComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIDropdownComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIDropdownComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIDropdownComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIDropdownComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITextInputComponent));
		this.ComponentRegisterInfos = list;
		num2 = 7;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.QuitBtnClickCallBack));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.LoginBtnClickCallBack));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.QuickLoginUseNewBtnClickCallBack));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.QuickLoginUseCurBtnClickCallBack));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.ToggleStateChange));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.CloudToggleChanged));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action<EToggleState>(this.SkipPlotToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009C22 RID: 39970 RVA: 0x002E4900 File Offset: 0x002E2B00
	protected override void OnStart()
	{
		this.IcmpPingCallBack = DelegateUtils.ToManualReleaseDelegate<FPingCallExDelegate>(new Action<string, float, int>(this.IcmpCallBack));
		this.IcmpPingCallBack.Bind(new Action<string, float, int>(this.IcmpCallBack));
		LoginModel.Instance.InitConfig();
		LoginModel.Instance.FixLoginFailInfo();
		LoginModel.Instance.InitRecentlyAccountList();
		this.InitCopyAccountLoginDropDown();
		this.OrigiMapData = new TArray<FUIDropdownOptionData>();
		this.ToShowMapData = new TArray<FUIDropdownOptionData>();
		base.GetInputText(13).OnTextChange.Bind(new Action<string>(this.SearchMap));
		base.GetDropdown(3).OnSelectChange.Bind(new Action<int>(this.OnSelectServer));
		this.RefreshServerIpInputText();
		base.GetInputText(2).SetText(LoginModel.Instance.GetAccount(), false);
		this.HttpLogin();
	}

	// Token: 0x06009C23 RID: 39971 RVA: 0x002E49D4 File Offset: 0x002E2BD4
	private void OnHttpLoginInit()
	{
		this.InitServer();
		this.InitMap();
		this.InitSex();
		this.InitCloud();
		this.InitSkip();
		if (GlobalData.IsPlayInEditor && !UiManager.Instance.IsViewShow(EUiViewName.LoginStatusView))
		{
			UiManager.Instance.OpenView(EUiViewName.LoginStatusView, null, null);
		}
		this.InitGmCountDropDown();
		this.InitRecentlyAccountDropDown();
		LoginModel.Instance.SmokeTestReady = true;
	}

	// Token: 0x06009C24 RID: 39972 RVA: 0x002E4A40 File Offset: 0x002E2C40
	private unsafe void InitServer()
	{
		UUIDropdownComponent dropdown = base.GetDropdown(3);
		if (dropdown != null)
		{
			ULGUISpriteData_BaseObject sprite = dropdown.GetOption(0).Sprite;
			dropdown.Options.Empty(true);
			List<ServerConfig> serverInfoList = LoginModel.Instance.GetServerInfoList();
			string serverIp = this.GetServerIp();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "debug 登录信息";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverIp", serverIp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("serverInfoList", serverInfoList);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			bool flag = false;
			if (serverInfoList != null)
			{
				for (int i = 0; i < serverInfoList.Count; i++)
				{
					ServerConfig serverConfig = serverInfoList[i];
					dropdown.Options.Add(new FUIDropdownOptionData
					{
						TextOrConfigTableName = serverConfig.Name,
						Sprite = sprite,
						TextId = 0
					});
					if (serverConfig.Ip == serverIp)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Login;
						ELogAuthor author2 = ELogAuthor.XXJ;
						string message2 = "设置服务器下拉列表";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", i);
						instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						dropdown.Value = i;
						dropdown.CaptionText.Get().UIText.SetText(serverConfig.Name, true);
						this.RefreshServerIpInputText();
						flag = true;
					}
				}
			}
			if (!flag && serverInfoList != null && serverInfoList.Count > 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Login;
				ELogAuthor author3 = ELogAuthor.XXJ;
				string message3 = "设置服务器下拉列表";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Value", 0);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				dropdown.Value = 0;
				ServerConfig serverConfig2 = serverInfoList[0];
				dropdown.CaptionText.Get().UIText.SetText(serverConfig2.Name, true);
			}
		}
	}

	// Token: 0x06009C25 RID: 39973 RVA: 0x002E4C1C File Offset: 0x002E2E1C
	private void RefreshServerIpInputText()
	{
		string text = this.GetServerIp() ?? "";
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "设置服务器IP";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ServerIp", text);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		base.GetInputText(14).SetText(text, false);
	}

	// Token: 0x06009C26 RID: 39974 RVA: 0x002E4C70 File Offset: 0x002E2E70
	private void InitMap()
	{
		UUIDropdownComponent dropdown = base.GetDropdown(4);
		if (dropdown != null)
		{
			ULGUISpriteData_BaseObject sprite = dropdown.GetOption(0).Sprite;
			dropdown.Options.Empty(true);
			List<LoginMapConfig> singleMapList = LoginModel.Instance.GetSingleMapList();
			int singleMapId = LoginModel.Instance.GetSingleMapId();
			int? defaultSingleMapId = LoginConfig.Instance.GetDefaultSingleMapId();
			int? num = null;
			bool flag = false;
			if (singleMapList != null)
			{
				for (int i = 0; i < singleMapList.Count; i++)
				{
					LoginMapConfig loginMapConfig = singleMapList[i];
					string text = loginMapConfig.MapId.ToString() + "-" + loginMapConfig.MapName;
					FUIDropdownOptionData value = new FUIDropdownOptionData
					{
						TextOrConfigTableName = text,
						Sprite = sprite
					};
					this.OrigiMapData.Add(value);
					dropdown.Options.Add(value);
					if (loginMapConfig.MapId == singleMapId)
					{
						dropdown.Value = i;
						dropdown.CaptionText.Get().UIText.SetText(text, true);
						flag = true;
					}
					int mapId = loginMapConfig.MapId;
					int? num2 = defaultSingleMapId;
					if (mapId == num2.GetValueOrDefault() & num2 != null)
					{
						num = new int?(i);
					}
				}
			}
			if (!flag)
			{
				int valueOrDefault = num.GetValueOrDefault();
				if (singleMapList != null && singleMapList.Count > valueOrDefault)
				{
					dropdown.Value = valueOrDefault;
					LoginMapConfig loginMapConfig2 = singleMapList[valueOrDefault];
					string newText = loginMapConfig2.MapId.ToString() + "-" + loginMapConfig2.MapName;
					dropdown.CaptionText.Get().UIText.SetText(newText, true);
				}
			}
		}
	}

	// Token: 0x06009C27 RID: 39975 RVA: 0x002E4E0C File Offset: 0x002E300C
	private void InitSex()
	{
		if (base.GetExtendToggle(7) != null)
		{
			EToggleState state = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.LoginSex, true) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(7).SetToggleState(state, false, false, false);
			this.ToggleStateChange(state);
		}
	}

	// Token: 0x06009C28 RID: 39976 RVA: 0x002E4E48 File Offset: 0x002E3048
	private void InitCloud()
	{
		if (base.GetExtendToggle(9) != null)
		{
			EToggleState state = EToggleState.ETT_UnChecked;
			base.GetExtendToggle(9).SetToggleState(state, false, false, false);
			this.CloudToggleChanged(state);
		}
	}

	// Token: 0x06009C29 RID: 39977 RVA: 0x002E4E7C File Offset: 0x002E307C
	private void InitSkip()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(11);
		if (extendToggle != null)
		{
			EToggleState state = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.SkipPlot, false) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleState(state, false, false, false);
			this.SkipPlotToggle(state);
			extendToggle.GetRootComponent().SetUIActive(false);
		}
	}

	// Token: 0x06009C2A RID: 39978 RVA: 0x002E4EC4 File Offset: 0x002E30C4
	protected override void OnBeforeDestroy()
	{
		if (this.IcmpPingCallBack != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<string, float, int>(this.IcmpCallBack));
			this.IcmpPingCallBack = null;
		}
		base.GetDropdown(15).OnSelectChange.Unbind();
		base.GetDropdown(18).OnSelectChange.Unbind();
		LoginModel.Instance.SaveRecentlyAccountList();
		LoginModel.Instance.CleanConfig();
		LoginModel.Instance.SetServerId(base.GetInputText(19).GetText());
	}

	// Token: 0x06009C2B RID: 39979 RVA: 0x002E4F40 File Offset: 0x002E3140
	private void InitCopyAccountLoginDropDown()
	{
		UUIDropdownComponent dropdown = base.GetDropdown(18);
		ULGUISpriteData_BaseObject sprite = dropdown.GetOption(0).Sprite;
		dropdown.Options.Empty(true);
		foreach (string textOrConfigTableName in new string[]
		{
			"新号登录",
			"复制账号",
			"复制账号（快速编队）"
		})
		{
			dropdown.Options.Add(new FUIDropdownOptionData
			{
				TextOrConfigTableName = textOrConfigTableName,
				Sprite = sprite
			});
		}
		LoginDefine.EAccountLoginMode eaccountLoginMode = LoginDefine.EAccountLoginMode.CopyAccount;
		if (GlobalData.IsPlayInEditor)
		{
			eaccountLoginMode = LoginDefine.EAccountLoginMode.CopyAccountQuickFormation;
		}
		int num = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.LoginDebugAccountLoginMode, (int)eaccountLoginMode);
		if (num < 0 || num > 2)
		{
			num = (int)eaccountLoginMode;
		}
		dropdown.SetValue(-1, false);
		dropdown.SetValue(num, false);
		this.OnCopyAccountLoginModeChanged(num);
		dropdown.OnSelectChange.Bind(new Action<int>(this.OnCopyAccountLoginModeChanged));
	}

	// Token: 0x06009C2C RID: 39980 RVA: 0x002E5018 File Offset: 0x002E3218
	private void InitRecentlyAccountDropDown()
	{
		UUIDropdownComponent dropdown = base.GetDropdown(16);
		if (dropdown == null)
		{
			return;
		}
		dropdown.CaptionText.Get().UIText.SetText("选择最近登录账号", true);
		ULGUISpriteData_BaseObject sprite = dropdown.GetOption(0).Sprite;
		dropdown.Options.Empty(true);
		List<string> recentlyAccountList = LoginModel.Instance.GetRecentlyAccountList();
		if (recentlyAccountList != null)
		{
			foreach (string textOrConfigTableName in recentlyAccountList)
			{
				dropdown.Options.Add(new FUIDropdownOptionData
				{
					TextOrConfigTableName = textOrConfigTableName,
					Sprite = sprite
				});
			}
		}
		dropdown.OnSelectChange.Bind(new Action<int>(this.OnRecentlyAccountSelectChange));
	}

	// Token: 0x06009C2D RID: 39981 RVA: 0x002E50EC File Offset: 0x002E32EC
	private void InitGmCountDropDown()
	{
		UUIDropdownComponent dropdown = base.GetDropdown(15);
		if (dropdown == null)
		{
			return;
		}
		ULGUISpriteData_BaseObject sprite = dropdown.GetOption(0).Sprite;
		dropdown.Options.Empty(true);
		foreach (GmAccount gmAccount in ConfigGmAccountAll.GetConfigList(true))
		{
			dropdown.Options.Add(new FUIDropdownOptionData
			{
				TextOrConfigTableName = gmAccount.GmName,
				Sprite = sprite
			});
		}
		dropdown.CaptionText.Get().UIText.SetText("创建指定GM账号", true);
		dropdown.OnSelectChange.Bind(new Action<int>(this.OnGmAccountSelectChange));
	}

	// Token: 0x06009C2E RID: 39982 RVA: 0x002E51B4 File Offset: 0x002E33B4
	private void CheckPakKeyAndLogin()
	{
		PakKeyUpdate.Instance.CheckPakKey(delegate
		{
			LoginController.Instance.GetHttp(true, true);
		}, null).Forget(delegate(Exception error)
		{
		}, true);
	}

	// Token: 0x06009C2F RID: 39983 RVA: 0x002E5210 File Offset: 0x002E3410
	private void QuitBtnClickCallBack()
	{
		ReConnectController.Instance.Logout(ELogoutReason.LoginViewQuit);
	}

	// Token: 0x06009C30 RID: 39984 RVA: 0x002E5220 File Offset: 0x002E3420
	private void LoginBtnClickCallBack()
	{
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.ZJC, "正在登录中, 请勿重复操作！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (base.GetInputText(2).Text == "")
		{
			ScrollingTipsController.Instance.ShowTipsById("LoginFailEmptyAccount", Array.Empty<object>());
			return;
		}
		this.SetLoginData(delegate
		{
			if (!Platform.Instance.IsWindowsPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DepthOfFieldQuality 1", null);
			}
			base.CloseMe(delegate(bool success)
			{
				if (success)
				{
					UiManager.Instance.OpenView(EUiViewName.LoginView, null, null);
				}
			});
		});
	}

	// Token: 0x06009C31 RID: 39985 RVA: 0x002E5298 File Offset: 0x002E3498
	private void QuickLoginUseCurBtnClickCallBack()
	{
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.ZJC, "正在登录中, 请勿重复操作！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (base.GetInputText(2).Text == "")
		{
			ScrollingTipsController.Instance.ShowTipsById("LoginFailEmptyAccount", Array.Empty<object>());
			return;
		}
		this.SetLoginData(delegate
		{
			if (!Platform.Instance.IsWindowsPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DepthOfFieldQuality 1", null);
			}
			LoginModel.Instance.SetPlayerName("一键登录账号");
			this.CheckPakKeyAndLogin();
		});
	}

	// Token: 0x06009C32 RID: 39986 RVA: 0x002E5310 File Offset: 0x002E3510
	private void QuickLoginUseNewBtnClickCallBack()
	{
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.ZJC, "正在登录中, 请勿重复操作！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SetLoginData(delegate
		{
			if (!Platform.Instance.IsWindowsPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DepthOfFieldQuality 1", null);
			}
			string newAccount = this.GetNewAccount();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "生成账号";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ip", newAccount);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetInputText(2).SetText(newAccount, false);
			LoginModel.Instance.SetAccount(newAccount);
			LoginModel.Instance.SetPlayerName("一键登录账号");
			this.CheckPakKeyAndLogin();
		});
	}

	// Token: 0x06009C33 RID: 39987 RVA: 0x002E5358 File Offset: 0x002E3558
	private void ToggleStateChange(EToggleState state)
	{
		base.GetSprite(8).SetUIActive(state == EToggleState.ETT_Checked);
	}

	// Token: 0x06009C34 RID: 39988 RVA: 0x002E536A File Offset: 0x002E356A
	private void CloudToggleChanged(EToggleState state)
	{
		base.GetSprite(10).SetUIActive(state == EToggleState.ETT_Checked);
		Platform.Instance.IsFakeCloudGame = (state == EToggleState.ETT_Checked);
		GameSettingsManager.Instance.Clear();
	}

	// Token: 0x06009C35 RID: 39989 RVA: 0x002E5395 File Offset: 0x002E3595
	private void SkipPlotToggle(EToggleState state)
	{
		base.GetSprite(12).SetUIActive(state == EToggleState.ETT_Checked);
	}

	// Token: 0x06009C36 RID: 39990 RVA: 0x002E53A8 File Offset: 0x002E35A8
	private void OnCopyAccountLoginModeChanged(int index)
	{
		if (index < 0 || index > 2)
		{
			return;
		}
		LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.LoginDebugAccountLoginMode, index);
		LoginModel.Instance.SelectedAccountLoginMode = (LoginDefine.EAccountLoginMode)index;
	}

	// Token: 0x06009C37 RID: 39991 RVA: 0x002E53D8 File Offset: 0x002E35D8
	private void OnRecentlyAccountSelectChange(int index)
	{
		if (index == -1)
		{
			return;
		}
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.ZJC, "正在登录中, 请勿重复操作！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<string> recentlyAccountList = LoginModel.Instance.GetRecentlyAccountList();
		base.GetInputText(2).SetText(recentlyAccountList[index], false);
		if (base.GetInputText(2).Text == "")
		{
			ScrollingTipsController.Instance.ShowTipsById("LoginFailEmptyAccount", Array.Empty<object>());
			return;
		}
		this.SetLoginData(delegate
		{
			this.CheckPakKeyAndLogin();
		});
	}

	// Token: 0x06009C38 RID: 39992 RVA: 0x002E5474 File Offset: 0x002E3674
	private void OnGmAccountSelectChange(int index)
	{
		this.GmAccountIndex = index;
		if (index == -1)
		{
			return;
		}
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.Init))
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.ZJC, "正在登录中, 请勿重复操作！", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UiManager.Instance.OpenView(EUiViewName.LoginDebugPlayerNameView, new Action(this.OnGmAccountSetName), null);
	}

	// Token: 0x06009C39 RID: 39993 RVA: 0x002E54D4 File Offset: 0x002E36D4
	private void OnGmAccountSetName()
	{
		int gmAccountIndex = this.GmAccountIndex;
		if (gmAccountIndex < 0)
		{
			return;
		}
		string playerName = LoginModel.Instance.GetPlayerName();
		IReadOnlyList<GmAccount> configList = ConfigGmAccountAll.GetConfigList(true);
		string firstName = configList[gmAccountIndex].FirstName;
		string newAccount = this.GetNewAccount();
		base.GetInputText(2).SetText(playerName + firstName + "-" + newAccount, false);
		SundryModel.Instance.AccountGmId = configList[gmAccountIndex].GmOrderListId;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "创建新的GM账号";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "index";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(gmAccountIndex);
		ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item2 = "配置id";
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(configList[gmAccountIndex].Id);
		ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (base.GetInputText(2).Text == "")
		{
			ScrollingTipsController.Instance.ShowTipsById("LoginFailEmptyAccount", Array.Empty<object>());
			return;
		}
		this.SetLoginData(delegate
		{
			this.CheckPakKeyAndLogin();
		});
	}

	// Token: 0x06009C3A RID: 39994 RVA: 0x002E561C File Offset: 0x002E381C
	private void SearchMap(string value)
	{
		string text = base.GetInputText(13).GetText();
		UUIDropdownComponent dropdown = base.GetDropdown(4);
		if (StringUtils.IsEmpty(text))
		{
			dropdown.SetOptions(this.OrigiMapData);
			return;
		}
		this.ToShowMapData.Empty(true);
		for (int i = 0; i < this.OrigiMapData.Num(); i++)
		{
			FUIDropdownOptionData fuidropdownOptionData = this.OrigiMapData.Get(i);
			if (fuidropdownOptionData.TextOrConfigTableName.Contains(text))
			{
				this.ToShowMapData.Add(fuidropdownOptionData);
			}
		}
		if (this.ToShowMapData.Num() == 0)
		{
			return;
		}
		dropdown.Options.Empty(true);
		dropdown.SetOptions(this.ToShowMapData);
	}

	// Token: 0x06009C3B RID: 39995 RVA: 0x002E56C4 File Offset: 0x002E38C4
	private void OnSelectServer(int index)
	{
		if (index < 0)
		{
			return;
		}
		List<ServerConfig> serverInfoList = LoginModel.Instance.GetServerInfoList();
		if (serverInfoList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "切换服务器IP失败, 服务器列表为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SelectIndex", index);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		ServerConfig serverConfig = serverInfoList[index];
		if (serverConfig != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Login;
			ELogAuthor author2 = ELogAuthor.LRX;
			string message2 = "切换服务器IP";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ServerIp", serverConfig.Ip);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.GetInputText(14).SetText(serverConfig.Ip, false);
		}
	}

	// Token: 0x06009C3C RID: 39996 RVA: 0x002E575C File Offset: 0x002E395C
	private string GetNewAccount()
	{
		return PublicUtil.Instance.GetLocalHost() + "[" + TimeUtil.Instance.DateFormat(DateTime.Now) + "]";
	}

	// Token: 0x06009C3D RID: 39997 RVA: 0x002E5788 File Offset: 0x002E3988
	[return: Nullable(2)]
	private LoginDebugView.IpPortInfo ParseServerIpAndPort(string str)
	{
		str = str.Trim();
		str = Regex.Replace(str, "^https?://", "");
		str = str.TrimEnd('/');
		if (StringUtils.IsEmpty(str))
		{
			return null;
		}
		if (str.StartsWith("["))
		{
			int num = str.IndexOf(']');
			if (num < 0)
			{
				return null;
			}
			string text = str.Substring(num + 1);
			return new LoginDebugView.IpPortInfo
			{
				Ip = str.Substring(0, num + 1),
				Port = (text.StartsWith(":") ? text.Substring(1) : null)
			};
		}
		else
		{
			int num2 = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == ':')
				{
					num2++;
				}
			}
			if (num2 >= 2)
			{
				return new LoginDebugView.IpPortInfo
				{
					Ip = "[" + str + "]"
				};
			}
			int num3 = str.IndexOf(':');
			if (num3 >= 0)
			{
				return new LoginDebugView.IpPortInfo
				{
					Ip = str.Substring(0, num3),
					Port = str.Substring(num3 + 1)
				};
			}
			return new LoginDebugView.IpPortInfo
			{
				Ip = str
			};
		}
	}

	// Token: 0x06009C3E RID: 39998 RVA: 0x002E589F File Offset: 0x002E3A9F
	private static bool IsIpAddress(string host)
	{
		return host.StartsWith("[") || Regex.IsMatch(host, "^(\\d{1,3}\\.){3}\\d{1,3}$");
	}

	// Token: 0x06009C3F RID: 39999 RVA: 0x002E58BC File Offset: 0x002E3ABC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private static UniTask<string> ResolveDomainToIp(string domain)
	{
		LoginDebugView.<ResolveDomainToIp>d__38 <ResolveDomainToIp>d__;
		<ResolveDomainToIp>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<ResolveDomainToIp>d__.domain = domain;
		<ResolveDomainToIp>d__.<>1__state = -1;
		<ResolveDomainToIp>d__.<>t__builder.Start<LoginDebugView.<ResolveDomainToIp>d__38>(ref <ResolveDomainToIp>d__);
		return <ResolveDomainToIp>d__.<>t__builder.Task;
	}

	// Token: 0x06009C40 RID: 40000 RVA: 0x002E5900 File Offset: 0x002E3B00
	private UniTask ResolveDomainThenApply(string domain, Action onDone)
	{
		LoginDebugView.<ResolveDomainThenApply>d__39 <ResolveDomainThenApply>d__;
		<ResolveDomainThenApply>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ResolveDomainThenApply>d__.<>4__this = this;
		<ResolveDomainThenApply>d__.domain = domain;
		<ResolveDomainThenApply>d__.onDone = onDone;
		<ResolveDomainThenApply>d__.<>1__state = -1;
		<ResolveDomainThenApply>d__.<>t__builder.Start<LoginDebugView.<ResolveDomainThenApply>d__39>(ref <ResolveDomainThenApply>d__);
		return <ResolveDomainThenApply>d__.<>t__builder.Task;
	}

	// Token: 0x06009C41 RID: 40001 RVA: 0x002E5953 File Offset: 0x002E3B53
	private void ApplyCustomServer(string ip, [Nullable(2)] string port)
	{
		LoginModel.Instance.SetServerName("手动输入IP地址服务器");
		this.SetServerIp(ip, 2);
		LoginModel.Instance.TrySetCustomServerPort(port, 2);
	}

	// Token: 0x06009C42 RID: 40002 RVA: 0x002E5978 File Offset: 0x002E3B78
	private unsafe void SetLoginData(Action onDone)
	{
		UUIDropdownComponent dropdown = base.GetDropdown(4);
		int num = (dropdown != null) ? dropdown.Value : 0;
		if (num == -1)
		{
			num = 0;
		}
		FUIDropdownOptionData option = dropdown.GetOption(num);
		int num2 = -1;
		for (int i = 0; i < this.OrigiMapData.Num(); i++)
		{
			if (this.OrigiMapData.Get(i).TextOrConfigTableName == option.TextOrConfigTableName)
			{
				num2 = i;
				break;
			}
		}
		if (num2 == -1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "当前选择的地图 在初始地图数据集合里 不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("地图名称", option.TextOrConfigTableName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			num2 = 0;
		}
		if (num2 >= 0)
		{
			int? singleMapIp = LoginModel.Instance.GetSingleMapIp(num2);
			if (singleMapIp != null)
			{
				LoginModel.Instance.SetSingleMapId(singleMapIp.Value);
			}
		}
		UUIDropdownComponent dropdown2 = base.GetDropdown(3);
		if (dropdown2 != null)
		{
			int num3 = dropdown2.GetValue();
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Login;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "获取服务器下拉列表当前设置值";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("serverValue", num3);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			if (num3 < 0)
			{
				Log.Instance.Warn(ELogModule.Login, ELogAuthor.XXJ, "服务器下拉列表当前设置值不符合预期,默认为0", default(ReadOnlySpan<ValueTuple<string, object>>));
				num3 = 0;
			}
			ServerConfig serverInfo = LoginModel.Instance.GetServerInfo(num3);
			if (serverInfo != null)
			{
				LoginModel.Instance.SetServerName(serverInfo.Name);
				this.SetServerIp(serverInfo.Ip, 1);
			}
			else
			{
				List<ServerConfig> serverInfoList = LoginModel.Instance.GetServerInfoList();
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Login;
				ELogAuthor author3 = ELogAuthor.XXJ;
				string message3 = "获取服务器数据为空";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("serverInfoList", serverInfoList);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
		}
		else
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "服务器下拉列表节点获取不到", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		string text = null;
		string text2 = base.GetInputText(14).GetText();
		if (!StringUtils.IsEmpty(text2))
		{
			LoginDebugView.IpPortInfo ipPortInfo = this.ParseServerIpAndPort(text2);
			if (ipPortInfo != null)
			{
				if (LoginDebugView.IsIpAddress(ipPortInfo.Ip))
				{
					this.ApplyCustomServer(ipPortInfo.Ip, ipPortInfo.Port);
				}
				else
				{
					text = ipPortInfo.Ip;
				}
			}
		}
		LoginDefine.ELoginSex eloginSex = (base.GetExtendToggle(7).ToggleState == EToggleState.ETT_Checked) ? LoginDefine.ELoginSex.Girl : LoginDefine.ELoginSex.Boy;
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.LoginSex, eloginSex == LoginDefine.ELoginSex.Girl);
		LoginModel.Instance.SetPlayerSex(eloginSex);
		LoginModel.Instance.SetAccount(base.GetInputText(2).Text);
		LoginModel.Instance.SetSourceAccount(base.GetInputText(17).Text);
		bool value = base.GetExtendToggle(11).ToggleState == EToggleState.ETT_Checked;
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.SkipPlot, value);
		Log instance4 = Log.Instance;
		ELogModule module4 = ELogModule.Login;
		ELogAuthor author4 = ELogAuthor.ZJC;
		string message4 = "已保存登录数据";
		<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ServerIp", this.GetServerIp());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CustomServerPort", LoginModel.Instance.GetCustomServerPort());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SingleId", LoginModel.Instance.GetSingleMapId());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("MultiMapId", LoginModel.Instance.GetMultiMapId());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Account", LoginModel.Instance.GetAccount());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("LoginSex", eloginSex);
		instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
		if (text != null)
		{
			this.ResolveDomainThenApply(text, onDone).Forget();
			return;
		}
		onDone();
	}

	// Token: 0x06009C43 RID: 40003 RVA: 0x002E5D04 File Offset: 0x002E3F04
	private void HttpLogin()
	{
		if (!KuroSdkController.Instance.CanUseSdk())
		{
			IPrivateServersData privateServers = BaseConfigController.Instance.GetPrivateServers();
			if (privateServers == null)
			{
				return;
			}
			LoginModel.Instance.AddServerInfoByCdn();
			if (privateServers.enable)
			{
				MatchCollection matchCollection = Regex.Matches(privateServers.serverUrl, "://.*?/");
				string[] array = new string[matchCollection.Count];
				for (int i = 0; i < matchCollection.Count; i++)
				{
					array[i] = matchCollection[i].Value;
				}
				if (array.Length >= 0)
				{
					string text = array[0];
					UKuroStaticLibrary.IcmpPing(text.Substring(3, text.Length - 4), 5f, this.IcmpPingCallBack);
					return;
				}
				ErrorCodeController.Instance.OpenConfirmBoxByText("私服域名截取失败[" + privateServers.serverUrl + "]");
				return;
			}
			else
			{
				this.HttpCallBackInternal(false, null, null, false);
			}
		}
	}

	// Token: 0x06009C44 RID: 40004 RVA: 0x002E5DE8 File Offset: 0x002E3FE8
	private void IcmpCallBack(string ipAddress, float time, int responseState)
	{
		if (responseState == 0)
		{
			IPrivateServersData privateServers = BaseConfigController.Instance.GetPrivateServers();
			if (privateServers == null)
			{
				return;
			}
			Http.Get(privateServers.serverUrl, null, new Action<bool, int, string>(this.HttpCallBack), null);
			this.TimerId = TimerSystem.Instance.Delay(delegate(float t)
			{
				this.TimerId = null;
				this.HttpCallBackInternal(false, null, null, true);
			}, (float)(TimeUtil.Instance.InverseMillisecond * 5), null, null, true, 1f);
			return;
		}
		else
		{
			if (responseState == 3)
			{
				ErrorCodeController.Instance.OpenConfirmBoxByText("私服列表域名解析失败[" + ipAddress + "], 可能是本地开了VPN, 请关闭后重试");
				return;
			}
			Action<string> openConfirmBoxByText = ErrorCodeController.Instance.OpenConfirmBoxByText;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
			defaultInterpolatedStringHandler.AppendLiteral("私服列表获取失败[");
			defaultInterpolatedStringHandler.AppendFormatted(ipAddress);
			defaultInterpolatedStringHandler.AppendLiteral("], EIcmpResponseStatus:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(responseState);
			openConfirmBoxByText(defaultInterpolatedStringHandler.ToStringAndClear());
			return;
		}
	}

	// Token: 0x06009C45 RID: 40005 RVA: 0x002E5EC6 File Offset: 0x002E40C6
	private void HttpCallBack(bool success, int code, string data)
	{
		this.HttpCallBackInternal(success, new int?(code), data, true);
	}

	// Token: 0x06009C46 RID: 40006 RVA: 0x002E5ED8 File Offset: 0x002E40D8
	[NullableContext(2)]
	private void HttpCallBackInternal(bool success = false, int? code = null, string data = null, bool addDataTableServers = true)
	{
		if (this.TimerId != null)
		{
			TimerSystem.Instance.Remove(this.TimerId);
			this.TimerId = null;
		}
		LoginModel.Instance.AddExtraServer();
		if (data != null)
		{
			ServerInfo[] array = Json.Parse<ServerInfo[]>(data, null);
			if (array != null)
			{
				LoginModel.Instance.AddServerInfos(array);
			}
		}
		if (addDataTableServers)
		{
			LoginModel.Instance.AddDataTableServers();
		}
		this.OnHttpLoginInit();
	}

	// Token: 0x06009C47 RID: 40007 RVA: 0x002E5F3C File Offset: 0x002E413C
	private void SetServerIp(string serverIp, int reason)
	{
		LoginModel.Instance.SetServerIp(serverIp, reason);
		LocalStorage.SetGlobal<string>(ELocalStorageGlobalKey.LoginDebugServerIp, serverIp);
	}

	// Token: 0x06009C48 RID: 40008 RVA: 0x002E5F54 File Offset: 0x002E4154
	[NullableContext(2)]
	private string GetServerIp()
	{
		string global = LocalStorage.GetGlobal<string>(ELocalStorageGlobalKey.LoginDebugServerIp, "-1");
		if (global == "-1")
		{
			return LoginModel.Instance.GetServerIp();
		}
		return global;
	}

	// Token: 0x06009C49 RID: 40009 RVA: 0x002E5F87 File Offset: 0x002E4187
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.LoginRequestResult, new Action<bool>(this.CreateCharacterResult));
	}

	// Token: 0x06009C4A RID: 40010 RVA: 0x002E5FA2 File Offset: 0x002E41A2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LoginRequestResult, new Action<bool>(this.CreateCharacterResult));
	}

	// Token: 0x06009C4B RID: 40011 RVA: 0x002E5FBD File Offset: 0x002E41BD
	private void CreateCharacterResult(bool result)
	{
		if (!result)
		{
			return;
		}
		BlackScreenController.Instance.AddBlackScreen("None", "LoginFinish", "Black", "Default");
	}

	// Token: 0x04005D2C RID: 23852
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x04005D2D RID: 23853
	private int GmAccountIndex = -1;

	// Token: 0x04005D2E RID: 23854
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<FUIDropdownOptionData> OrigiMapData;

	// Token: 0x04005D2F RID: 23855
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<FUIDropdownOptionData> ToShowMapData;

	// Token: 0x04005D30 RID: 23856
	[Nullable(2)]
	private FPingCallExDelegate IcmpPingCallBack;

	// Token: 0x02007170 RID: 29040
	[NullableContext(0)]
	private class ELoginChildCom
	{
		// Token: 0x04024F2B RID: 151339
		public const int QuitBtn = 0;

		// Token: 0x04024F2C RID: 151340
		public const int LoginBtn = 1;

		// Token: 0x04024F2D RID: 151341
		public const int AccountTextInput = 2;

		// Token: 0x04024F2E RID: 151342
		public const int ServerComboBox = 3;

		// Token: 0x04024F2F RID: 151343
		public const int SingleMapComboBox = 4;

		// Token: 0x04024F30 RID: 151344
		public const int QuickLoginUseNewBtn = 5;

		// Token: 0x04024F31 RID: 151345
		public const int QuickLoginUseCurBtn = 6;

		// Token: 0x04024F32 RID: 151346
		public const int SexToggle = 7;

		// Token: 0x04024F33 RID: 151347
		public const int SexSprite = 8;

		// Token: 0x04024F34 RID: 151348
		public const int CloudToggle = 9;

		// Token: 0x04024F35 RID: 151349
		public const int CloudSprite = 10;

		// Token: 0x04024F36 RID: 151350
		public const int SkipPlotToggle = 11;

		// Token: 0x04024F37 RID: 151351
		public const int SkipPlotSprite = 12;

		// Token: 0x04024F38 RID: 151352
		public const int SearchMapInput = 13;

		// Token: 0x04024F39 RID: 151353
		public const int TargetIPInput = 14;

		// Token: 0x04024F3A RID: 151354
		public const int GmAccountDropDown = 15;

		// Token: 0x04024F3B RID: 151355
		public const int RecentlyAccountDropDown = 16;

		// Token: 0x04024F3C RID: 151356
		public const int SourceAccountTextInput = 17;

		// Token: 0x04024F3D RID: 151357
		public const int CopyAccountLoginDropDown = 18;

		// Token: 0x04024F3E RID: 151358
		public const int ServerIpInput = 19;
	}

	// Token: 0x02007171 RID: 29041
	[Nullable(0)]
	private class IpPortInfo
	{
		// Token: 0x17007804 RID: 30724
		// (get) Token: 0x06040244 RID: 262724 RVA: 0x012CB63E File Offset: 0x012C983E
		// (set) Token: 0x06040245 RID: 262725 RVA: 0x012CB646 File Offset: 0x012C9846
		public string Ip { get; set; } = "";

		// Token: 0x17007805 RID: 30725
		// (get) Token: 0x06040246 RID: 262726 RVA: 0x012CB64F File Offset: 0x012C984F
		// (set) Token: 0x06040247 RID: 262727 RVA: 0x012CB657 File Offset: 0x012C9857
		[Nullable(2)]
		public string Port { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
