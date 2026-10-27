using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001A84 RID: 6788
[NullableContext(1)]
[Nullable(0)]
public class LoginDebugView : UiViewBase
{
	// Token: 0x0600C810 RID: 51216 RVA: 0x002D93FA File Offset: 0x002D75FA
	public LoginDebugView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C811 RID: 51217 RVA: 0x002D940C File Offset: 0x002D760C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 21;
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
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITextInputComponent));
		this.ComponentRegisterInfos = list;
		num2 = 8;
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
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action<EToggleState>(this.OnClickUseCopySourceAccountToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C812 RID: 51218 RVA: 0x002D982C File Offset: 0x002D7A2C
	protected override void OnStart()
	{
		this.IcmpPingCallBack = DelegateUtils.ToManualReleaseDelegate<FPingCallExDelegate>(new Action<string, float, int>(this.IcmpCallBack));
		this.IcmpPingCallBack.Bind(new Action<string, float, int>(this.IcmpCallBack));
		LoginModel.Instance.InitConfig();
		LoginModel.Instance.FixLoginFailInfo();
		LoginModel.Instance.InitRecentlyAccountList();
		UUIExtendToggle extendToggle = base.GetExtendToggle(18);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIItem item = base.GetItem(19);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.OrigiMapData = new TArray<FUIDropdownOptionData>();
		this.ToShowMapData = new TArray<FUIDropdownOptionData>();
		base.GetInputText(13).OnTextChange.Bind(new Action<string>(this.SearchMap));
		base.GetDropdown(3).OnSelectChange.Bind(new Action<int>(this.OnSelectServer));
		this.RefreshServerIpInputText();
		base.GetInputText(2).SetText(LoginModel.Instance.GetAccount(), false);
		this.HttpLogin();
	}

	// Token: 0x0600C813 RID: 51219 RVA: 0x002D9928 File Offset: 0x002D7B28
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

	// Token: 0x0600C814 RID: 51220 RVA: 0x002D9994 File Offset: 0x002D7B94
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
					dropdown.Options.Add(new FUIDropdownOptionData(serverConfig.Name, sprite, 0, ""));
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

	// Token: 0x0600C815 RID: 51221 RVA: 0x002D9B60 File Offset: 0x002D7D60
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

	// Token: 0x0600C816 RID: 51222 RVA: 0x002D9BB4 File Offset: 0x002D7DB4
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
					FUIDropdownOptionData value = new FUIDropdownOptionData(text, sprite, 0, "");
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

	// Token: 0x0600C817 RID: 51223 RVA: 0x002D9D48 File Offset: 0x002D7F48
	private void InitSex()
	{
		if (base.GetExtendToggle(7) != null)
		{
			EToggleState state = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.LoginSex, true) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(7).SetToggleState(state, false, false, false);
			this.ToggleStateChange(state);
		}
	}

	// Token: 0x0600C818 RID: 51224 RVA: 0x002D9D84 File Offset: 0x002D7F84
	private void InitCloud()
	{
		if (base.GetExtendToggle(9) != null)
		{
			EToggleState state = EToggleState.ETT_UnChecked;
			base.GetExtendToggle(9).SetToggleState(state, false, false, false);
			this.CloudToggleChanged(state);
		}
	}

	// Token: 0x0600C819 RID: 51225 RVA: 0x002D9DB8 File Offset: 0x002D7FB8
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

	// Token: 0x0600C81A RID: 51226 RVA: 0x002D9E00 File Offset: 0x002D8000
	protected override void OnBeforeDestroy()
	{
		if (this.IcmpPingCallBack != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<string, float, int>(this.IcmpCallBack));
			this.IcmpPingCallBack = null;
		}
		base.GetDropdown(15).OnSelectChange.Unbind();
		LoginModel.Instance.SaveRecentlyAccountList();
		LoginModel.Instance.CleanConfig();
		LoginModel.Instance.SetServerId(base.GetInputText(20).GetText());
	}

	// Token: 0x0600C81B RID: 51227 RVA: 0x002D9E6C File Offset: 0x002D806C
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
				dropdown.Options.Add(new FUIDropdownOptionData(textOrConfigTableName, sprite, 0, ""));
			}
		}
		dropdown.OnSelectChange.Bind(new Action<int>(this.OnRecentlyAccountSelectChange));
	}

	// Token: 0x0600C81C RID: 51228 RVA: 0x002D9F38 File Offset: 0x002D8138
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
			dropdown.Options.Add(new FUIDropdownOptionData(gmAccount.GmName, sprite, 0, ""));
		}
		dropdown.CaptionText.Get().UIText.SetText("创建指定GM账号", true);
		dropdown.OnSelectChange.Bind(new Action<int>(this.OnGmAccountSelectChange));
	}

	// Token: 0x0600C81D RID: 51229 RVA: 0x002D9FF8 File Offset: 0x002D81F8
	private void CheckPakKeyAndLogin()
	{
		PakKeyUpdate.Instance.CheckPakKey(delegate
		{
			if (UKuroPakKeyLibrary.HasPendingEncryptedPaks() && !BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip())
			{
				Log.Instance.Info(ELogModule.Login, ELogAuthor.LRA, "存在未成功挂载的Pak包！", default(ReadOnlySpan<ValueTuple<string, object>>));
				LoginController.Instance.GetAndShowStopServerNotice();
				return;
			}
			LoginController.Instance.GetHttp(true, true);
		}, null).Forget(delegate(Exception error)
		{
		}, true);
	}

	// Token: 0x0600C81E RID: 51230 RVA: 0x002DA054 File Offset: 0x002D8254
	private void QuitBtnClickCallBack()
	{
		ReConnectController.Instance.Logout(ELogoutReason.LoginViewQuit);
	}

	// Token: 0x0600C81F RID: 51231 RVA: 0x002DA064 File Offset: 0x002D8264
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

	// Token: 0x0600C820 RID: 51232 RVA: 0x002DA0DC File Offset: 0x002D82DC
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

	// Token: 0x0600C821 RID: 51233 RVA: 0x002DA154 File Offset: 0x002D8354
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

	// Token: 0x0600C822 RID: 51234 RVA: 0x002DA19C File Offset: 0x002D839C
	private void ToggleStateChange(EToggleState state)
	{
		base.GetSprite(8).SetUIActive(state == EToggleState.ETT_Checked);
	}

	// Token: 0x0600C823 RID: 51235 RVA: 0x002DA1AE File Offset: 0x002D83AE
	private void CloudToggleChanged(EToggleState state)
	{
		base.GetSprite(10).SetUIActive(state == EToggleState.ETT_Checked);
		Platform.Instance.IsFakeCloudGame = (state == EToggleState.ETT_Checked);
		GameSettingsManager.Instance.Clear();
	}

	// Token: 0x0600C824 RID: 51236 RVA: 0x002DA1D9 File Offset: 0x002D83D9
	private void SkipPlotToggle(EToggleState state)
	{
		base.GetSprite(12).SetUIActive(state == EToggleState.ETT_Checked);
	}

	// Token: 0x0600C825 RID: 51237 RVA: 0x002DA1EC File Offset: 0x002D83EC
	private void OnClickUseCopySourceAccountToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			LoginModel.Instance.IsCopyAccount = true;
			UUIItem item = base.GetItem(19);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
			return;
		}
		else
		{
			LoginModel.Instance.IsCopyAccount = false;
			UUIItem item2 = base.GetItem(19);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600C826 RID: 51238 RVA: 0x002DA23C File Offset: 0x002D843C
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

	// Token: 0x0600C827 RID: 51239 RVA: 0x002DA2D8 File Offset: 0x002D84D8
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

	// Token: 0x0600C828 RID: 51240 RVA: 0x002DA338 File Offset: 0x002D8538
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

	// Token: 0x0600C829 RID: 51241 RVA: 0x002DA480 File Offset: 0x002D8680
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

	// Token: 0x0600C82A RID: 51242 RVA: 0x002DA528 File Offset: 0x002D8728
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

	// Token: 0x0600C82B RID: 51243 RVA: 0x002DA5C0 File Offset: 0x002D87C0
	private string GetNewAccount()
	{
		return PublicUtil.Instance.GetLocalHost() + "[" + TimeUtil.Instance.DateFormat(DateTime.Now) + "]";
	}

	// Token: 0x0600C82C RID: 51244 RVA: 0x002DA5EC File Offset: 0x002D87EC
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
			if (str.Count((char c) => c == ':') >= 2)
			{
				return new LoginDebugView.IpPortInfo
				{
					Ip = "[" + str + "]"
				};
			}
			int num2 = str.IndexOf(':');
			if (num2 >= 0)
			{
				return new LoginDebugView.IpPortInfo
				{
					Ip = str.Substring(0, num2),
					Port = str.Substring(num2 + 1)
				};
			}
			return new LoginDebugView.IpPortInfo
			{
				Ip = str
			};
		}
	}

	// Token: 0x0600C82D RID: 51245 RVA: 0x002DA700 File Offset: 0x002D8900
	private static bool IsIpAddress(string host)
	{
		return host.StartsWith("[") || Regex.IsMatch(host, "^(\\d{1,3}\\.){3}\\d{1,3}$");
	}

	// Token: 0x0600C82E RID: 51246 RVA: 0x002DA71C File Offset: 0x002D891C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private static UniTask<string> ResolveDomainToIp(string domain)
	{
		LoginDebugView.<ResolveDomainToIp>d__37 <ResolveDomainToIp>d__;
		<ResolveDomainToIp>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<ResolveDomainToIp>d__.domain = domain;
		<ResolveDomainToIp>d__.<>1__state = -1;
		<ResolveDomainToIp>d__.<>t__builder.Start<LoginDebugView.<ResolveDomainToIp>d__37>(ref <ResolveDomainToIp>d__);
		return <ResolveDomainToIp>d__.<>t__builder.Task;
	}

	// Token: 0x0600C82F RID: 51247 RVA: 0x002DA760 File Offset: 0x002D8960
	private UniTask ResolveDomainThenApply(string domain, Action onDone)
	{
		LoginDebugView.<ResolveDomainThenApply>d__38 <ResolveDomainThenApply>d__;
		<ResolveDomainThenApply>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ResolveDomainThenApply>d__.<>4__this = this;
		<ResolveDomainThenApply>d__.domain = domain;
		<ResolveDomainThenApply>d__.onDone = onDone;
		<ResolveDomainThenApply>d__.<>1__state = -1;
		<ResolveDomainThenApply>d__.<>t__builder.Start<LoginDebugView.<ResolveDomainThenApply>d__38>(ref <ResolveDomainThenApply>d__);
		return <ResolveDomainThenApply>d__.<>t__builder.Task;
	}

	// Token: 0x0600C830 RID: 51248 RVA: 0x002DA7B3 File Offset: 0x002D89B3
	private void ApplyCustomServer(string ip, [Nullable(2)] string port)
	{
		LoginModel.Instance.SetServerName("手动输入IP地址服务器");
		this.SetServerIp(ip, 2);
		LoginModel.Instance.TrySetCustomServerPort(port, 2);
	}

	// Token: 0x0600C831 RID: 51249 RVA: 0x002DA7D8 File Offset: 0x002D89D8
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

	// Token: 0x0600C832 RID: 51250 RVA: 0x002DAB64 File Offset: 0x002D8D64
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
				string[] array = (from m in Regex.Matches(privateServers.serverUrl, "://.*?/")
				select m.Value).ToArray<string>();
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

	// Token: 0x0600C833 RID: 51251 RVA: 0x002DAC40 File Offset: 0x002D8E40
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

	// Token: 0x0600C834 RID: 51252 RVA: 0x002DAD1E File Offset: 0x002D8F1E
	private void HttpCallBack(bool success, int code, string data)
	{
		this.HttpCallBackInternal(success, new int?(code), data, true);
	}

	// Token: 0x0600C835 RID: 51253 RVA: 0x002DAD30 File Offset: 0x002D8F30
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

	// Token: 0x0600C836 RID: 51254 RVA: 0x002DAD94 File Offset: 0x002D8F94
	private void SetServerIp(string serverIp, int reason)
	{
		LoginModel.Instance.SetServerIp(serverIp, reason);
		LocalStorage.SetGlobal<string>(ELocalStorageGlobalKey.LoginDebugServerIp, serverIp);
	}

	// Token: 0x0600C837 RID: 51255 RVA: 0x002DADAC File Offset: 0x002D8FAC
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

	// Token: 0x0600C838 RID: 51256 RVA: 0x002DADDF File Offset: 0x002D8FDF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.LoginRequestResult, new Action<bool>(this.CreateCharacterResult));
	}

	// Token: 0x0600C839 RID: 51257 RVA: 0x002DADFA File Offset: 0x002D8FFA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LoginRequestResult, new Action<bool>(this.CreateCharacterResult));
	}

	// Token: 0x0600C83A RID: 51258 RVA: 0x002DAE15 File Offset: 0x002D9015
	private void CreateCharacterResult(bool result)
	{
		if (!result)
		{
			return;
		}
		BlackScreenController.Instance.AddBlackScreen("None", "LoginFinish", "Black", "Default");
	}

	// Token: 0x04005C5D RID: 23645
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x04005C5E RID: 23646
	private int GmAccountIndex = -1;

	// Token: 0x04005C5F RID: 23647
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<FUIDropdownOptionData> OrigiMapData;

	// Token: 0x04005C60 RID: 23648
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<FUIDropdownOptionData> ToShowMapData;

	// Token: 0x04005C61 RID: 23649
	[Nullable(2)]
	private FPingCallExDelegate IcmpPingCallBack;

	// Token: 0x02007FE1 RID: 32737
	[NullableContext(0)]
	private class ELoginChildCom
	{
		// Token: 0x04029BEE RID: 170990
		public const int QuitBtn = 0;

		// Token: 0x04029BEF RID: 170991
		public const int LoginBtn = 1;

		// Token: 0x04029BF0 RID: 170992
		public const int AccountTextInput = 2;

		// Token: 0x04029BF1 RID: 170993
		public const int ServerComboBox = 3;

		// Token: 0x04029BF2 RID: 170994
		public const int SingleMapComboBox = 4;

		// Token: 0x04029BF3 RID: 170995
		public const int QuickLoginUseNewBtn = 5;

		// Token: 0x04029BF4 RID: 170996
		public const int QuickLoginUseCurBtn = 6;

		// Token: 0x04029BF5 RID: 170997
		public const int SexToggle = 7;

		// Token: 0x04029BF6 RID: 170998
		public const int SexSprite = 8;

		// Token: 0x04029BF7 RID: 170999
		public const int CloudToggle = 9;

		// Token: 0x04029BF8 RID: 171000
		public const int CloudSprite = 10;

		// Token: 0x04029BF9 RID: 171001
		public const int SkipPlotToggle = 11;

		// Token: 0x04029BFA RID: 171002
		public const int SkipPlotSprite = 12;

		// Token: 0x04029BFB RID: 171003
		public const int SearchMapInput = 13;

		// Token: 0x04029BFC RID: 171004
		public const int TargetIPInput = 14;

		// Token: 0x04029BFD RID: 171005
		public const int GmAccountDropDown = 15;

		// Token: 0x04029BFE RID: 171006
		public const int RecentlyAccountDropDown = 16;

		// Token: 0x04029BFF RID: 171007
		public const int SourceAccountTextInput = 17;

		// Token: 0x04029C00 RID: 171008
		public const int UseCopySourceAccountToggle = 18;

		// Token: 0x04029C01 RID: 171009
		public const int SourceAccountToggleCheckItem = 19;

		// Token: 0x04029C02 RID: 171010
		public const int ServerIpInput = 20;
	}

	// Token: 0x02007FE2 RID: 32738
	[Nullable(0)]
	private class IpPortInfo
	{
		// Token: 0x1700A066 RID: 41062
		// (get) Token: 0x06049E26 RID: 302630 RVA: 0x0132814A File Offset: 0x0132634A
		// (set) Token: 0x06049E27 RID: 302631 RVA: 0x01328152 File Offset: 0x01326352
		public string Ip { get; set; } = "";

		// Token: 0x1700A067 RID: 41063
		// (get) Token: 0x06049E28 RID: 302632 RVA: 0x0132815B File Offset: 0x0132635B
		// (set) Token: 0x06049E29 RID: 302633 RVA: 0x01328163 File Offset: 0x01326363
		[Nullable(2)]
		public string Port { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
