using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200019B RID: 411
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayStation5Sdk : PlatformSdkNew
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x000464A0 File Offset: 0x000446A0
		protected override bool OnInit()
		{
			AuthCodeData authCode = this.GetAuthCode(EPlayStaionScope.Login);
			if (authCode == null)
			{
				return false;
			}
			string userId = this.GetUserId();
			this.UniversalDataSystemManager = new UniversalDataSystemManager();
			this.UniversalDataSystemManager.Initialize(userId);
			this.UniversalDataSystemManager.Start();
			this.PlayStationTrophy = new PlayStationTrophy();
			this.PlayStationTrophy.Init(this.UniversalDataSystemManager, this).Forget();
			this.AuthCodeData = authCode;
			string cacheMapElement = UKuroStaticPS5Library.GetCacheMapElement("AgreeState");
			if (cacheMapElement != null && cacheMapElement == "1")
			{
				this.CacheAgreeState = true;
			}
			PlatformReportLaunchGame eventData = new PlatformReportLaunchGame();
			this.ReportToThirdParty(eventData);
			return true;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0004653C File Offset: 0x0004473C
		protected override void InitPlatformSdkReportData()
		{
			string productId = PlatformSdkConfig.Instance.GetProductId();
			string platformPkg = PlatformSdkConfig.Instance.GetPlatformPkg();
			string channelId = PlatformSdkConfig.Instance.GetChannelId();
			string channel_name = "PlayStation";
			string channel_op = "";
			string runningOnlyCode = this.GetRunningOnlyCode();
			string appVersion = UKuroLauncherLibrary.GetAppVersion();
			string sdkVersion = PlatformSdkConfig.Instance.GetSdkVersion();
			string playStationToken = this.GetPlayStationToken();
			string language = this.GetLanguage();
			string initTime = this.InitTime.ToString();
			string gameId = this.GetGameId();
			string thirdUnionId = this.ThirdUnionId;
			PlatformSdkReportBaseData.InitSdkBaseValue(productId, platformPkg, channelId, channel_name, channel_op, language, runningOnlyCode, appVersion, sdkVersion, playStationToken, initTime, gameId, thirdUnionId);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000465D8 File Offset: 0x000447D8
		protected unsafe override void OnInitDataReport()
		{
			bool flag = UThinkingAnalytics.HasInstanceInitialized(this.PlatStationReportIndex);
			bool flag2 = UKuroAnalytics.HasInstanceInitialized(this.PlatStationReportIndex);
			if (flag && flag2)
			{
				this.ReportCacheReportData();
				return;
			}
			if (!flag)
			{
				string dataReportUrl = PlatformSdkConfig.Instance.GetDataReportUrl();
				string dataReportId = PlatformSdkConfig.Instance.GetDataReportId();
				string accountId = PlatformSdkReportBaseData.GetPuid().ToString();
				FCreateInstanceParam fcreateInstanceParam = new FCreateInstanceParam(this.PlatStationReportIndex, dataReportUrl, dataReportId, UThinkingAnalytics.GetMachineID(), accountId, "SdkData", "", 1000, TAMode.NORMAL, ESaveMode.None_Save, 0f, true, false, false, true, 1f, 1000, 10000f, true, 10f, true, false);
				LauncherLog instance = LauncherLog.Instance;
				string message = "[PlatformSdkNew][PlayStation5Sdk] InitThinkingDataReport";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("url", dataReportUrl);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("appId", dataReportId);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				UThinkingAnalytics.CreateSimpleInstance(fcreateInstanceParam);
			}
			if (!flag2)
			{
				string kuroDataReportUrl = PlatformSdkConfig.Instance.GetKuroDataReportUrl();
				string dataReportId2 = PlatformSdkConfig.Instance.GetDataReportId();
				string accountId2 = PlatformSdkReportBaseData.GetPuid().ToString();
				FKACreateInstanceParam fkacreateInstanceParam = new FKACreateInstanceParam(this.PlatStationReportIndex, kuroDataReportUrl, dataReportId2, UKuroAnalytics.GetMachineID(), accountId2, "SdkData", "", 1000, KAMode.NORMAL, EKASaveMode.None_Save, 0f, true, false, false, true, 1f, 1000, 10000f, true, 10f, true, false);
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "[PlatformSdkNew][PlayStation5Sdk] InitKuroDataReport";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("url", kuroDataReportUrl);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("appId", dataReportId2);
				instance2.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				UKuroAnalytics.CreateSimpleInstance(fkacreateInstanceParam);
			}
			this.ReportCacheReportData();
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000467B0 File Offset: 0x000449B0
		private void ReportCacheReportData()
		{
			if (this.CacheReportArray.Count > 0)
			{
				for (int i = 0; i < this.CacheReportArray.Count; i++)
				{
					PlatformSdkReportBaseData eventData = this.CacheReportArray[i];
					this.ReportToThirdPartyInternal(eventData);
				}
				this.CacheReportArray.Clear();
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00046800 File Offset: 0x00044A00
		private string GetPlayStationToken()
		{
			string idToken = this.GetIdToken(EPlayStaionScope.DeviceId);
			if (idToken == null)
			{
				return "";
			}
			IIdTokenData idTokenData = this.TryDecodeJtwToken(idToken);
			if (idTokenData == null)
			{
				return "";
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew][PlayStation5Sdk] DeviceId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DeviceId", this.DeviceId);
			instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return idTokenData.duid;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00046860 File Offset: 0x00044A60
		[return: Nullable(2)]
		private IIdTokenData TryDecodeJtwToken(string token)
		{
			string[] array = token.Split('.', StringSplitOptions.None);
			string text = (array.Length > 1) ? array[1] : null;
			if (text == null)
			{
				return null;
			}
			string text2 = UKuroStaticLibrary.Base64Decode(text);
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew][PlayStation5Sdk] TryDecodeJtwToken";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("decodedPayload", text2);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return LauncherJson.Parse<IIdTokenData>(text2, null);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000468BA File Offset: 0x00044ABA
		private void AddTickCallBack(Func<int> callback)
		{
			this.TickUpdateId++;
			this.OnTickCallBackMap[this.TickUpdateId] = callback;
			this.StartTicker();
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000468E4 File Offset: 0x00044AE4
		private void StartTicker()
		{
			if (this.Ticker == null && this.TickInnerState)
			{
				this.Ticker = new UKuroTickManager(this.WorldContext, null, EObjectFlags.RF_NoFlags);
				this.TickDelegate = delegate(float delta)
				{
					this.OnTick(delta);
				};
				this.Ticker.AddTick(ETickingGroup.TG_PrePhysics, DelegateUtils.ToManualReleaseDelegate<FTickHandler>(this.TickDelegate), 0);
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00046940 File Offset: 0x00044B40
		private void OnTick(float delta)
		{
			if (this.OnTickCallBackMap.Count == 0)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, Func<int>> keyValuePair in this.OnTickCallBackMap)
			{
				if (keyValuePair.Value() == -1)
				{
					list.Add(keyValuePair.Key);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				this.OnTickCallBackMap.Remove(list[i]);
			}
			if (this.OnTickCallBackMap.Count == 0)
			{
				this.RemoveTicker();
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000469F4 File Offset: 0x00044BF4
		private void RemoveTicker()
		{
			if (this.Ticker != null && this.TickInnerState)
			{
				this.Ticker.ClearTick();
				this.Ticker = null;
			}
			if (this.TickDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.TickDelegate);
				this.TickDelegate = null;
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00046A34 File Offset: 0x00044C34
		protected override void InitWebComponent()
		{
			string userId = this.GetUserId();
			UKuroStaticPS5Library.InitWebApi(ref userId);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00046A50 File Offset: 0x00044C50
		protected override bool OnUnInit()
		{
			UniversalDataSystemManager universalDataSystemManager = this.UniversalDataSystemManager;
			if (universalDataSystemManager != null)
			{
				universalDataSystemManager.Stop();
			}
			return true;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00046A64 File Offset: 0x00044C64
		public override void ConnectToServer(TSDKConnectCallback callback)
		{
			PlayStation5Sdk.<>c__DisplayClass41_0 CS$<>8__locals1 = new PlayStation5Sdk.<>c__DisplayClass41_0();
			CS$<>8__locals1.callback = callback;
			string platformPkg = PlatformSdkConfig.Instance.GetPlatformPkg();
			PlatformSdkServer.Instance.Connect("&pkg=" + platformPkg, new TSDKConnectCallback(CS$<>8__locals1.<ConnectToServer>g__FinalCallBack|0));
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00046AAC File Offset: 0x00044CAC
		[NullableContext(2)]
		private unsafe AuthCodeData GetAuthCode(EPlayStaionScope scope)
		{
			string platformClientId = PlatformSdkConfig.Instance.GetPlatformClientId();
			string text = (scope == EPlayStaionScope.Login) ? "psn:s2s openid id_token:psn.basic_claims" : "psn:s2s openid id_token:psn.basic_claims id_token:duid";
			string text2 = "";
			int num = 0;
			int authCode = UKuroStaticPS5Library.GetAuthCode(ref platformClientId, ref text, ref text2, ref num);
			if (authCode != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "[PlatformSdkNew][PlayStation5Sdk] GetAuthCode failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", authCode);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[PlatformSdkNew][PlayStation5Sdk] GetAuthCode";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("result", authCode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("authCode", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("issuerId", num);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			PlatformReportGetPsnAuth eventData = new PlatformReportGetPsnAuth();
			this.ReportToThirdParty(eventData);
			return new AuthCodeData(text2, num);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00046BA4 File Offset: 0x00044DA4
		[NullableContext(2)]
		public unsafe string GetIdToken(EPlayStaionScope scope)
		{
			string platformClientId = PlatformSdkConfig.Instance.GetPlatformClientId();
			string platformClientSecret = PlatformSdkConfig.Instance.GetPlatformClientSecret();
			string text = (scope == EPlayStaionScope.Login) ? "psn:s2s openid id_token:psn.basic_claims" : "psn:s2s openid id_token:psn.basic_claims id_token:duid";
			string text2 = "";
			int idToken = UKuroStaticPS5Library.GetIdToken(ref platformClientId, ref platformClientSecret, ref text, ref text2);
			if (idToken != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "[PlatformSdkNew][PlayStation5Sdk] GetIdToken failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", idToken);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[PlatformSdkNew][PlayStation5Sdk] GetIdToken";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("result", idToken);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("idToken", text2);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			PlatformReportPsnAccessId eventData = new PlatformReportPsnAccessId();
			this.ReportToThirdParty(eventData);
			return text2;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00046C81 File Offset: 0x00044E81
		public override bool NeedPrivacyProtocol()
		{
			return true;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00046C84 File Offset: 0x00044E84
		public override string GetDeviceId()
		{
			PlatformReportGetDid eventData = new PlatformReportGetDid();
			this.ReportToThirdParty(eventData);
			if (this.DeviceId == "")
			{
				string playStationToken = this.GetPlayStationToken();
				this.DeviceId = playStationToken;
				PlatformReportFirstGetDid platformReportFirstGetDid = new PlatformReportFirstGetDid();
				string projectId = PlatformSdkConfig.Instance.GetProjectId();
				string channelId = PlatformSdkConfig.Instance.GetChannelId();
				string deviceId = this.DeviceId;
				PlatformReportFirstGetDid platformReportFirstGetDid2 = platformReportFirstGetDid;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted(projectId);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted(channelId);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted(deviceId);
				platformReportFirstGetDid2.first_check_id = defaultInterpolatedStringHandler.ToStringAndClear();
				this.ReportToThirdParty(platformReportFirstGetDid);
			}
			if (this.DeviceId == "")
			{
				LauncherLog.Instance.Debug("[PlatformSdkNew][PlayStation5Sdk] GetDeviceId failed, empty DeviceId", default(ReadOnlySpan<ValueTuple<string, object>>));
				return "";
			}
			PlatformReportGetDidSuccess eventData2 = new PlatformReportGetDidSuccess();
			this.ReportToThirdParty(eventData2);
			return this.DeviceId;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00046D7C File Offset: 0x00044F7C
		public override void Login(TSDKLoginCallback callback)
		{
			AuthCodeData authCode = this.GetAuthCode(EPlayStaionScope.Login);
			if (authCode == null)
			{
				LauncherLog.Instance.Error("[PlatformSdkNew][PlayStation5Sdk] Login failed, empty authCode", default(ReadOnlySpan<ValueTuple<string, object>>));
				callback(PlatformSdkServerMsg.PsnAuthFail.ToEnumString(), false, false, null);
				return;
			}
			string platformPkg = PlatformSdkConfig.Instance.GetPlatformPkg();
			string clientId = PlatformSdkConfig.Instance.GetClientId();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 4);
			defaultInterpolatedStringHandler.AppendLiteral("&psnCode=");
			defaultInterpolatedStringHandler.AppendFormatted(authCode.AuthCode);
			defaultInterpolatedStringHandler.AppendLiteral("&psnEnvIssuerId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(authCode.IssuerId);
			defaultInterpolatedStringHandler.AppendLiteral("&pkg=");
			defaultInterpolatedStringHandler.AppendFormatted(platformPkg);
			defaultInterpolatedStringHandler.AppendLiteral("&client_id=");
			defaultInterpolatedStringHandler.AppendFormatted(clientId);
			defaultInterpolatedStringHandler.AppendLiteral("&redirect_uri=1&response_type=code");
			string param = defaultInterpolatedStringHandler.ToStringAndClear();
			PlatformSdkServer.Instance.Login(param, callback);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00046E58 File Offset: 0x00045058
		public override void BindAccountThenLogin(TSDKLoginCallback callback, string mailAddress = "", string mailCode = "")
		{
			AuthCodeData authCode = this.GetAuthCode(EPlayStaionScope.Login);
			if (authCode == null)
			{
				LauncherLog.Instance.Error("[PlatformSdkNew][PlayStation5Sdk] BindAccountThenLogin failed, empty authCode", default(ReadOnlySpan<ValueTuple<string, object>>));
				callback(PlatformSdkServerMsg.PsnAuthFail.ToEnumString(), false, false, null);
				return;
			}
			string platformPkg = PlatformSdkConfig.Instance.GetPlatformPkg();
			string clientId = PlatformSdkConfig.Instance.GetClientId();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 4);
			defaultInterpolatedStringHandler.AppendLiteral("&psnCode=");
			defaultInterpolatedStringHandler.AppendFormatted(authCode.AuthCode);
			defaultInterpolatedStringHandler.AppendLiteral("&psnEnvIssuerId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(authCode.IssuerId);
			defaultInterpolatedStringHandler.AppendLiteral("&pkg=");
			defaultInterpolatedStringHandler.AppendFormatted(platformPkg);
			defaultInterpolatedStringHandler.AppendLiteral("&client_id=");
			defaultInterpolatedStringHandler.AppendFormatted(clientId);
			defaultInterpolatedStringHandler.AppendLiteral("&redirect_uri=1&response_type=code");
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (mailAddress != "" && mailCode != "")
			{
				text = string.Concat(new string[]
				{
					text,
					"&email=",
					mailAddress,
					"&emailCode=",
					mailCode
				});
			}
			PlatformSdkServer.Instance.BindAccountThenLogin(text, callback);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00046F78 File Offset: 0x00045178
		public override void SetServerCommonParam()
		{
			string productId = PlatformSdkConfig.Instance.GetProductId();
			string projectId = PlatformSdkConfig.Instance.GetProjectId();
			string platform = PlatformSdkConfig.Instance.GetPlatform();
			string sdkVersion = PlatformSdkConfig.Instance.GetSdkVersion();
			string channelId = PlatformSdkConfig.Instance.GetChannelId();
			PlatformSdkServer instance = PlatformSdkServer.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 6);
			defaultInterpolatedStringHandler.AppendLiteral("productId=");
			defaultInterpolatedStringHandler.AppendFormatted(productId);
			defaultInterpolatedStringHandler.AppendLiteral("&projectId=");
			defaultInterpolatedStringHandler.AppendFormatted(projectId);
			defaultInterpolatedStringHandler.AppendLiteral("&deviceNum=");
			defaultInterpolatedStringHandler.AppendFormatted(this.GetDeviceId());
			defaultInterpolatedStringHandler.AppendLiteral("&platform=");
			defaultInterpolatedStringHandler.AppendFormatted(platform);
			defaultInterpolatedStringHandler.AppendLiteral("&sdkVersion=");
			defaultInterpolatedStringHandler.AppendFormatted(sdkVersion);
			defaultInterpolatedStringHandler.AppendLiteral("&channelId=");
			defaultInterpolatedStringHandler.AppendFormatted(channelId);
			instance.InitCommonParam(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00047056 File Offset: 0x00045256
		public override string GetUserId()
		{
			return UKuroStaticPS5Library.GetUserId();
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00047060 File Offset: 0x00045260
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<string> GetSelfAccountId()
		{
			PlayStation5Sdk.<GetSelfAccountId>d__50 <GetSelfAccountId>d__;
			<GetSelfAccountId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<GetSelfAccountId>d__.<>4__this = this;
			<GetSelfAccountId>d__.<>1__state = -1;
			<GetSelfAccountId>d__.<>t__builder.Start<PlayStation5Sdk.<GetSelfAccountId>d__50>(ref <GetSelfAccountId>d__);
			return <GetSelfAccountId>d__.<>t__builder.Task;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000470A4 File Offset: 0x000452A4
		public override bool GetPrivacyAgreeState()
		{
			if (this.CacheAgreeState)
			{
				return true;
			}
			Dictionary<string, Dictionary<string, bool>> global = LauncherStorageLib.Instance.GetGlobal<Dictionary<string, Dictionary<string, bool>>>(ELauncherStorageGlobalKey.UserProtocolAgreeState, null);
			if (global == null)
			{
				return false;
			}
			LauncherStorageLib.Instance.SetGlobal<Dictionary<string, Dictionary<string, bool>>>(ELauncherStorageGlobalKey.UserProtocolAgreeState, global);
			string language = this.GetLanguage();
			Dictionary<string, bool> dictionary;
			if (!global.TryGetValue(this.GetUserId(), out dictionary))
			{
				return false;
			}
			bool flag;
			if (!dictionary.TryGetValue(language, out flag))
			{
				return false;
			}
			if (flag)
			{
				UKuroStaticPS5Library.AddCacheMapElement("AgreeState", "1");
			}
			return flag;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00047114 File Offset: 0x00045314
		public override void SavePrivacyAgreeState(bool state)
		{
			PlatformReportAgreementClick eventData = new PlatformReportAgreementClick();
			this.ReportToThirdParty(eventData);
			Dictionary<string, Dictionary<string, bool>> dictionary = LauncherStorageLib.Instance.GetGlobal<Dictionary<string, Dictionary<string, bool>>>(ELauncherStorageGlobalKey.UserProtocolAgreeState, null);
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, Dictionary<string, bool>>();
			}
			string language = this.GetLanguage();
			Dictionary<string, bool> dictionary2;
			if (!dictionary.TryGetValue(this.GetUserId(), out dictionary2))
			{
				dictionary[this.GetUserId()] = new Dictionary<string, bool>();
			}
			dictionary[this.GetUserId()][language] = state;
			LauncherStorageLib.Instance.SetGlobal<Dictionary<string, Dictionary<string, bool>>>(ELauncherStorageGlobalKey.UserProtocolAgreeState, dictionary);
			UKuroStaticPS5Library.AddCacheMapElement("AgreeState", "1");
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0004719C File Offset: 0x0004539C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public override UniTask<Dictionary<string, string>> GetSdkOnlineId(List<string> userIdList)
		{
			PlayStation5Sdk.<GetSdkOnlineId>d__53 <GetSdkOnlineId>d__;
			<GetSdkOnlineId>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, string>>.Create();
			<GetSdkOnlineId>d__.<>4__this = this;
			<GetSdkOnlineId>d__.userIdList = userIdList;
			<GetSdkOnlineId>d__.<>1__state = -1;
			<GetSdkOnlineId>d__.<>t__builder.Start<PlayStation5Sdk.<GetSdkOnlineId>d__53>(ref <GetSdkOnlineId>d__);
			return <GetSdkOnlineId>d__.<>t__builder.Task;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000471E8 File Offset: 0x000453E8
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override UniTask<Dictionary<string, bool>> GetSdkBlockingUser()
		{
			PlayStation5Sdk.<GetSdkBlockingUser>d__54 <GetSdkBlockingUser>d__;
			<GetSdkBlockingUser>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, bool>>.Create();
			<GetSdkBlockingUser>d__.<>4__this = this;
			<GetSdkBlockingUser>d__.<>1__state = -1;
			<GetSdkBlockingUser>d__.<>t__builder.Start<PlayStation5Sdk.<GetSdkBlockingUser>d__54>(ref <GetSdkBlockingUser>d__);
			return <GetSdkBlockingUser>d__.<>t__builder.Task;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0004722C File Offset: 0x0004542C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public override UniTask<Dictionary<string, string>> GetSdkAccountId(List<string> userIdList)
		{
			PlayStation5Sdk.<GetSdkAccountId>d__55 <GetSdkAccountId>d__;
			<GetSdkAccountId>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, string>>.Create();
			<GetSdkAccountId>d__.<>4__this = this;
			<GetSdkAccountId>d__.userIdList = userIdList;
			<GetSdkAccountId>d__.<>1__state = -1;
			<GetSdkAccountId>d__.<>t__builder.Start<PlayStation5Sdk.<GetSdkAccountId>d__55>(ref <GetSdkAccountId>d__);
			return <GetSdkAccountId>d__.<>t__builder.Task;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00047278 File Offset: 0x00045478
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public override UniTask<string> GetSdkUserIdByAccountId(string accountId)
		{
			PlayStation5Sdk.<GetSdkUserIdByAccountId>d__56 <GetSdkUserIdByAccountId>d__;
			<GetSdkUserIdByAccountId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<GetSdkUserIdByAccountId>d__.<>1__state = -1;
			<GetSdkUserIdByAccountId>d__.<>t__builder.Start<PlayStation5Sdk.<GetSdkUserIdByAccountId>d__56>(ref <GetSdkUserIdByAccountId>d__);
			return <GetSdkUserIdByAccountId>d__.<>t__builder.Task;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000472B3 File Offset: 0x000454B3
		public override void ShowPlayStationStoreIcon(int positionType)
		{
			UKuroStaticPS5Library.ShowPsStoreIcon(positionType);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000472BC File Offset: 0x000454BC
		public override void HidePlayStationStoreIcon()
		{
			UKuroStaticPS5Library.HidePsStoreIcon();
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000472C4 File Offset: 0x000454C4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<IPlayStationOnlineData> GetPlayStationOnlineId(string userId)
		{
			PlayStation5Sdk.<GetPlayStationOnlineId>d__59 <GetPlayStationOnlineId>d__;
			<GetPlayStationOnlineId>d__.<>t__builder = AsyncUniTaskMethodBuilder<IPlayStationOnlineData>.Create();
			<GetPlayStationOnlineId>d__.userId = userId;
			<GetPlayStationOnlineId>d__.<>1__state = -1;
			<GetPlayStationOnlineId>d__.<>t__builder.Start<PlayStation5Sdk.<GetPlayStationOnlineId>d__59>(ref <GetPlayStationOnlineId>d__);
			return <GetPlayStationOnlineId>d__.<>t__builder.Task;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00047308 File Offset: 0x00045508
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<IPlayStationAccountData> GetPlayStationAccountId(string userId)
		{
			PlayStation5Sdk.<GetPlayStationAccountId>d__60 <GetPlayStationAccountId>d__;
			<GetPlayStationAccountId>d__.<>t__builder = AsyncUniTaskMethodBuilder<IPlayStationAccountData>.Create();
			<GetPlayStationAccountId>d__.userId = userId;
			<GetPlayStationAccountId>d__.<>1__state = -1;
			<GetPlayStationAccountId>d__.<>t__builder.Start<PlayStation5Sdk.<GetPlayStationAccountId>d__60>(ref <GetPlayStationAccountId>d__);
			return <GetPlayStationAccountId>d__.<>t__builder.Task;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0004734C File Offset: 0x0004554C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override UniTask<List<ISdkTrophyInfo>> GetSdkTrophyInfo(int offset = 0, int length = 0)
		{
			PlayStation5Sdk.<GetSdkTrophyInfo>d__61 <GetSdkTrophyInfo>d__;
			<GetSdkTrophyInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<ISdkTrophyInfo>>.Create();
			<GetSdkTrophyInfo>d__.<>4__this = this;
			<GetSdkTrophyInfo>d__.offset = offset;
			<GetSdkTrophyInfo>d__.length = length;
			<GetSdkTrophyInfo>d__.<>1__state = -1;
			<GetSdkTrophyInfo>d__.<>t__builder.Start<PlayStation5Sdk.<GetSdkTrophyInfo>d__61>(ref <GetSdkTrophyInfo>d__);
			return <GetSdkTrophyInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000473A0 File Offset: 0x000455A0
		[NullableContext(0)]
		public override UniTask<bool> UnlockSdkTrophy(int trophyId)
		{
			PlayStation5Sdk.<UnlockSdkTrophy>d__62 <UnlockSdkTrophy>d__;
			<UnlockSdkTrophy>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UnlockSdkTrophy>d__.<>4__this = this;
			<UnlockSdkTrophy>d__.trophyId = trophyId;
			<UnlockSdkTrophy>d__.<>1__state = -1;
			<UnlockSdkTrophy>d__.<>t__builder.Start<PlayStation5Sdk.<UnlockSdkTrophy>d__62>(ref <UnlockSdkTrophy>d__);
			return <UnlockSdkTrophy>d__.<>t__builder.Task;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000473EC File Offset: 0x000455EC
		[NullableContext(0)]
		public override UniTask<bool> UpdateSdkTrophyProgress(int trophyId, int progress)
		{
			PlayStation5Sdk.<UpdateSdkTrophyProgress>d__63 <UpdateSdkTrophyProgress>d__;
			<UpdateSdkTrophyProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateSdkTrophyProgress>d__.<>4__this = this;
			<UpdateSdkTrophyProgress>d__.trophyId = trophyId;
			<UpdateSdkTrophyProgress>d__.progress = progress;
			<UpdateSdkTrophyProgress>d__.<>1__state = -1;
			<UpdateSdkTrophyProgress>d__.<>t__builder.Start<PlayStation5Sdk.<UpdateSdkTrophyProgress>d__63>(ref <UpdateSdkTrophyProgress>d__);
			return <UpdateSdkTrophyProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0004743F File Offset: 0x0004563F
		public override bool NeedShowThirdPartyId()
		{
			return true;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00047442 File Offset: 0x00045642
		public override bool SupportSwitchFriendSearchByThirdPartyId()
		{
			return true;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00047445 File Offset: 0x00045645
		public override bool SupportSwitchFriendShowType()
		{
			return true;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00047448 File Offset: 0x00045648
		public override bool GetSdkFriendOnlyState()
		{
			return LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, false);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00047456 File Offset: 0x00045656
		public override void SaveSdkFriendOnlyState(bool state)
		{
			LauncherStorageLib.Instance.SetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, state);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00047465 File Offset: 0x00045665
		public override string GetProductId()
		{
			return PlatformSdkConfig.Instance.GetProductId();
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00047474 File Offset: 0x00045674
		public override void OpenWebView(string url, [Nullable(2)] Action endCallBack = null)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "OpenWebView";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", url);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			UKuroStaticPS5Library.OpenWebBrowser(ref url);
			this.AddTickCallBack(delegate
			{
				if (!this.PollWebViewClose())
				{
					return 0;
				}
				base.<OpenWebView>g__CallBack|0();
				return -1;
			});
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x000474D1 File Offset: 0x000456D1
		public override void CloseWebView()
		{
			UKuroStaticPS5Library.CloseWebBrowser();
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000474D9 File Offset: 0x000456D9
		public override bool NeedCheckPlayOnly()
		{
			return true;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000474DC File Offset: 0x000456DC
		public override bool NeedShowShopIcon()
		{
			return true;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x000474DF File Offset: 0x000456DF
		public override void StartActivity(string activityId)
		{
			UniversalDataSystemManager universalDataSystemManager = this.UniversalDataSystemManager;
			if (universalDataSystemManager == null)
			{
				return;
			}
			universalDataSystemManager.StartActivity(activityId);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000474F2 File Offset: 0x000456F2
		public override void EndActivity(string activityId)
		{
			UniversalDataSystemManager universalDataSystemManager = this.UniversalDataSystemManager;
			if (universalDataSystemManager == null)
			{
				return;
			}
			universalDataSystemManager.EndActivity(activityId, EPsActivityEndActivityOutcome.Completed);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00047506 File Offset: 0x00045706
		public override void ChangeActivityAvailability([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> availableActivities, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> unavailableActivities)
		{
			UniversalDataSystemManager universalDataSystemManager = this.UniversalDataSystemManager;
			if (universalDataSystemManager == null)
			{
				return;
			}
			universalDataSystemManager.ChangeActivityAvailability(availableActivities, unavailableActivities);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0004751A File Offset: 0x0004571A
		public override bool PollWebViewClose()
		{
			return UKuroStaticPS5Library.PollWebBrowser();
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00047524 File Offset: 0x00045724
		[return: Nullable(new byte[]
		{
			0,
			2,
			1
		})]
		private UniTask<TArray<FProductData>> GetPsnStoreProducts()
		{
			PlayStation5Sdk.<GetPsnStoreProducts>d__82 <GetPsnStoreProducts>d__;
			<GetPsnStoreProducts>d__.<>t__builder = AsyncUniTaskMethodBuilder<TArray<FProductData>>.Create();
			<GetPsnStoreProducts>d__.<>4__this = this;
			<GetPsnStoreProducts>d__.<>1__state = -1;
			<GetPsnStoreProducts>d__.<>t__builder.Start<PlayStation5Sdk.<GetPsnStoreProducts>d__82>(ref <GetPsnStoreProducts>d__);
			return <GetPsnStoreProducts>d__.<>t__builder.Task;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00047568 File Offset: 0x00045768
		private void GetPsnStoreProductsWithParams(int offset, int limit, TArray<FProductData> result, Action<TArray<FProductData>> callBack)
		{
			TArray<FProductData> storeProductsWithParams = UKuroStaticPS5Library.GetStoreProductsWithParams(this.LabelId, offset, limit);
			for (int i = 0; i < storeProductsWithParams.Num(); i++)
			{
				result.Add(storeProductsWithParams.Get(i));
			}
			if (storeProductsWithParams.Num() == 0 || storeProductsWithParams.Num() < limit)
			{
				callBack(result);
				return;
			}
			this.GetPsnStoreProductsWithParams(offset + limit, limit, result, callBack);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000475C8 File Offset: 0x000457C8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public override UniTask<IQueryProductResult> QueryProductInfo(List<string> productIds)
		{
			PlayStation5Sdk.<QueryProductInfo>d__84 <QueryProductInfo>d__;
			<QueryProductInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQueryProductResult>.Create();
			<QueryProductInfo>d__.<>4__this = this;
			<QueryProductInfo>d__.productIds = productIds;
			<QueryProductInfo>d__.<>1__state = -1;
			<QueryProductInfo>d__.<>t__builder.Start<PlayStation5Sdk.<QueryProductInfo>d__84>(ref <QueryProductInfo>d__);
			return <QueryProductInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00047614 File Offset: 0x00045814
		public override bool OpenCheckoutDialog(string productLabel, string productId, string channelGoodsId)
		{
			PlatformReportOpenPsnCheckOut platformReportOpenPsnCheckOut = new PlatformReportOpenPsnCheckOut();
			platformReportOpenPsnCheckOut.product_id = channelGoodsId;
			platformReportOpenPsnCheckOut.goodsId = productId;
			platformReportOpenPsnCheckOut.psnenvlssuer = this.AuthCodeData.IssuerId.ToString();
			this.CurrentPayChannelGoodsId = channelGoodsId;
			this.CurrentPayProductId = productId;
			this.ReportToThirdParty(platformReportOpenPsnCheckOut);
			int num = UKuroStaticPS5Library.OpenCheckoutDialog(ref productLabel);
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew][PlayStation5Sdk] OpenCheckoutDialog";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ret", num);
			instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return num == 0;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00047694 File Offset: 0x00045894
		public override ESdkDialogResult PollCheckoutDialogResult()
		{
			int num = UKuroStaticPS5Library.PollCheckoutDialogResult();
			if (num == -1)
			{
				return ESdkDialogResult.Waiting;
			}
			if (num != 2)
			{
				this.ReportPsnCheckoutClose();
				return ESdkDialogResult.No;
			}
			this.ReportPsnCheckoutClose();
			return ESdkDialogResult.Yes;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x000476C4 File Offset: 0x000458C4
		private void ReportPsnCheckoutClose()
		{
			this.ReportToThirdParty(new PlatformReportClosePsnCheckOut
			{
				product_id = this.CurrentPayChannelGoodsId,
				goodsId = this.CurrentPayProductId,
				psnenvlssuer = this.AuthCodeData.IssuerId.ToString()
			});
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0004770C File Offset: 0x0004590C
		public override void RequestCheckoutProduct(ISdkRequestCheckoutProductParam param, TSdkCheckoutProductCallback callback, ECheckoutReason reason)
		{
			string productId = PlatformSdkConfig.Instance.GetProductId();
			string version = PlatformSdkConfig.Instance.GetVersion();
			string sdkVersion = PlatformSdkConfig.Instance.GetSdkVersion();
			TMap<string, string> payHeader = PlatformSdkServer.Instance.GeneratePayHeader(productId, version, sdkVersion);
			string channelId = PlatformSdkConfig.Instance.GetChannelId();
			string platformPkg = PlatformSdkConfig.Instance.GetPlatformPkg();
			int issuerId = this.AuthCodeData.IssuerId;
			PlatformSdkServer.Instance.RequestCheckoutProduct(reason, issuerId, callback, payHeader, new object[]
			{
				"productId",
				productId,
				"channelId",
				channelId,
				"dn",
				this.GetDeviceId(),
				"pkg",
				platformPkg,
				"vn",
				version,
				"svn",
				sdkVersion,
				"plat",
				4,
				"access_token",
				param.AccessToken,
				"psnEnvIssuerId",
				this.AuthCodeData.IssuerId,
				"serverId",
				param.ServerId,
				"serverName",
				param.ServerName,
				"roleId",
				param.RoleId,
				"roleName",
				param.RoleName
			});
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00047864 File Offset: 0x00045A64
		public override bool NeedConfirmSdkProductInfo()
		{
			return true;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00047867 File Offset: 0x00045A67
		public override bool NeedShowSdkProductInfoBeforePay()
		{
			return true;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0004786C File Offset: 0x00045A6C
		public override void GetMessageBoxCurrentState(Action<ESdkMessageBoxState> callBack)
		{
			PlayStation5Sdk.<>c__DisplayClass91_0 CS$<>8__locals1 = new PlayStation5Sdk.<>c__DisplayClass91_0();
			CS$<>8__locals1.callBack = callBack;
			FPlayStationGetDialogStatusCallBack fplayStationGetDialogStatusCallBack = DelegateUtils.ToManualReleaseDelegate<FPlayStationGetDialogStatusCallBack>(new Action<int>(CS$<>8__locals1.<GetMessageBoxCurrentState>g__OnGetMessage|0));
			UKuroStaticPS5Library.GetMessageDialogStateAsync(fplayStationGetDialogStatusCallBack);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000478A0 File Offset: 0x00045AA0
		[NullableContext(0)]
		public override UniTask<bool> OpenMessageBox([Nullable(1)] string accountId, ESdkMessageBoxMode dialogMode, ESdkMessageBoxType msgType)
		{
			PlayStation5Sdk.<OpenMessageBox>d__92 <OpenMessageBox>d__;
			<OpenMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenMessageBox>d__.<>4__this = this;
			<OpenMessageBox>d__.accountId = accountId;
			<OpenMessageBox>d__.dialogMode = dialogMode;
			<OpenMessageBox>d__.msgType = msgType;
			<OpenMessageBox>d__.<>1__state = -1;
			<OpenMessageBox>d__.<>t__builder.Start<PlayStation5Sdk.<OpenMessageBox>d__92>(ref <OpenMessageBox>d__);
			return <OpenMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x000478FC File Offset: 0x00045AFC
		public override void GetCommunicationRestricted([Nullable(2)] string accountId, Action<ESdkCommunicationRestricted> callBack)
		{
			PlayStation5Sdk.<>c__DisplayClass93_0 CS$<>8__locals1 = new PlayStation5Sdk.<>c__DisplayClass93_0();
			CS$<>8__locals1.callBack = callBack;
			if (accountId == null)
			{
				CS$<>8__locals1.callBack(ESdkCommunicationRestricted.No);
				return;
			}
			FPlayStationGetCommunicationStatusCallBack fplayStationGetCommunicationStatusCallBack = DelegateUtils.ToManualReleaseDelegate<FPlayStationGetCommunicationStatusCallBack>(new Action<int, int>(CS$<>8__locals1.<GetCommunicationRestricted>g__OnCommunicationResponse|0));
			UKuroStaticPS5Library.GetCommunicationRestrictionStatusAsync(ref accountId, fplayStationGetCommunicationStatusCallBack);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00047944 File Offset: 0x00045B44
		[NullableContext(0)]
		public override UniTask<ESdkCommunicationRestricted> GetCommunicationRestrictedAsync([Nullable(2)] string accountId)
		{
			PlayStation5Sdk.<GetCommunicationRestrictedAsync>d__94 <GetCommunicationRestrictedAsync>d__;
			<GetCommunicationRestrictedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
			<GetCommunicationRestrictedAsync>d__.<>4__this = this;
			<GetCommunicationRestrictedAsync>d__.accountId = accountId;
			<GetCommunicationRestrictedAsync>d__.<>1__state = -1;
			<GetCommunicationRestrictedAsync>d__.<>t__builder.Start<PlayStation5Sdk.<GetCommunicationRestrictedAsync>d__94>(ref <GetCommunicationRestrictedAsync>d__);
			return <GetCommunicationRestrictedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0004798F File Offset: 0x00045B8F
		public override bool GetIfShowDefaultPrice()
		{
			return false;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00047994 File Offset: 0x00045B94
		public override int CheckUserPremium()
		{
			string userId = this.GetUserId();
			return UKuroStaticPS5Library.CheckUserPremium(ref userId);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000479B0 File Offset: 0x00045BB0
		public override void NotifyPlayStationPremium(bool isPlayStationOnly)
		{
			string userId = this.GetUserId();
			UKuroStaticPS5Library.NotifyPremiumFeature(ref userId, isPlayStationOnly);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000479CC File Offset: 0x00045BCC
		public override void TerminateMessageBox()
		{
			UKuroStaticPS5Library.TerminateMessageDialog();
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000479D4 File Offset: 0x00045BD4
		public override string CreatePlayerSession(int joinAbleUserType, int playerId)
		{
			string text = playerId.ToString();
			return UKuroStaticPS5Library.CreatePlayerSession(joinAbleUserType, ref text);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x000479F1 File Offset: 0x00045BF1
		public override void SetPlayerSessionJoinAbleUserType(int joinAbleUserType)
		{
			UKuroStaticPS5Library.SetPlayerSessionJoinableUserType(joinAbleUserType);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000479F9 File Offset: 0x00045BF9
		public override void LeavePlayerSession()
		{
			UKuroStaticPS5Library.LeavePlayerSession();
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00047A00 File Offset: 0x00045C00
		public override void JoinPlayerSession(string playerSession)
		{
			UKuroStaticPS5Library.JoinPlayerSession(ref playerSession);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00047A09 File Offset: 0x00045C09
		public override string CheckJoinSession()
		{
			return UKuroStaticPS5Library.CheckJoinSession();
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00047A10 File Offset: 0x00045C10
		public override string GetPlayerIdByPlayerSessionId(string playerSession)
		{
			return UKuroStaticPS5Library.GetPlayerIdByPlayerSessionId(ref playerSession);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00047A1C File Offset: 0x00045C1C
		public override bool IsPlatformNetworkReachable()
		{
			string userId = this.GetUserId();
			int num = 0;
			if (UKuroStaticPS5Library.SceNpGetNpReachabilityState(ref userId, ref num) != 0)
			{
				LauncherLog.Instance.Error("[PlatformSdkNew][PlayStation5Sdk] SceNpGetNpReachabilityState failed", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return num == 2;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00047A5C File Offset: 0x00045C5C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override UniTask<Dictionary<string, ESdkRelation>> GetTargetRelation(List<string> accountIdList)
		{
			PlayStation5Sdk.<GetTargetRelation>d__106 <GetTargetRelation>d__;
			<GetTargetRelation>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, ESdkRelation>>.Create();
			<GetTargetRelation>d__.<>4__this = this;
			<GetTargetRelation>d__.accountIdList = accountIdList;
			<GetTargetRelation>d__.<>1__state = -1;
			<GetTargetRelation>d__.<>t__builder.Start<PlayStation5Sdk.<GetTargetRelation>d__106>(ref <GetTargetRelation>d__);
			return <GetTargetRelation>d__.<>t__builder.Task;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00047AA7 File Offset: 0x00045CA7
		public override bool GetIfNeedQueryProductInfoForce()
		{
			return false;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00047AAC File Offset: 0x00045CAC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public override UniTask<RequestEmailCodeResponse> RequestEmailCode(string emailAddress)
		{
			PlayStation5Sdk.<RequestEmailCode>d__108 <RequestEmailCode>d__;
			<RequestEmailCode>d__.<>t__builder = AsyncUniTaskMethodBuilder<RequestEmailCodeResponse>.Create();
			<RequestEmailCode>d__.emailAddress = emailAddress;
			<RequestEmailCode>d__.<>1__state = -1;
			<RequestEmailCode>d__.<>t__builder.Start<PlayStation5Sdk.<RequestEmailCode>d__108>(ref <RequestEmailCode>d__);
			return <RequestEmailCode>d__.<>t__builder.Task;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00047AEF File Offset: 0x00045CEF
		public override bool SupportExternalWebBrowser()
		{
			return false;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00047AF4 File Offset: 0x00045CF4
		public override void OpenUserCenter(string sdkUid, [Nullable(2)] Action endCallBack = null)
		{
			PlatformReportClickAccountCenter eventData = new PlatformReportClickAccountCenter();
			this.ReportToThirdParty(eventData);
			string userCenterUrl = PlatformSdkServer.Instance.GetUserCenterUrl();
			string clientId = PlatformSdkConfig.Instance.GetClientId();
			string productId = PlatformSdkConfig.Instance.GetProductId();
			string projectId = PlatformSdkConfig.Instance.GetProjectId();
			string channelId = PlatformSdkConfig.Instance.GetChannelId();
			string language = this.GetLanguage();
			string platformPkg = PlatformSdkConfig.Instance.GetPlatformPkg();
			string currentAccessToken = this.CurrentAccessToken;
			string deviceId = this.GetDeviceId();
			string sdkVersion = PlatformSdkConfig.Instance.GetSdkVersion();
			string runningOnlyCode = this.GetRunningOnlyCode();
			string gameName = this.GetGameName();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(186, 13);
			defaultInterpolatedStringHandler.AppendFormatted(userCenterUrl);
			defaultInterpolatedStringHandler.AppendLiteral("?__e__=1&accessToken=");
			defaultInterpolatedStringHandler.AppendFormatted(currentAccessToken);
			defaultInterpolatedStringHandler.AppendLiteral("&response_type=code&redirect_uri=1&language=");
			defaultInterpolatedStringHandler.AppendFormatted(language);
			defaultInterpolatedStringHandler.AppendLiteral("&isSDK=1&pkg=");
			defaultInterpolatedStringHandler.AppendFormatted(platformPkg);
			defaultInterpolatedStringHandler.AppendLiteral("&userID=");
			defaultInterpolatedStringHandler.AppendFormatted(sdkUid);
			defaultInterpolatedStringHandler.AppendLiteral("&client_id=");
			defaultInterpolatedStringHandler.AppendFormatted(clientId);
			defaultInterpolatedStringHandler.AppendLiteral("&deviceNum=");
			defaultInterpolatedStringHandler.AppendFormatted(deviceId);
			defaultInterpolatedStringHandler.AppendLiteral("&gameName=");
			defaultInterpolatedStringHandler.AppendFormatted(gameName);
			defaultInterpolatedStringHandler.AppendLiteral("&channelId=");
			defaultInterpolatedStringHandler.AppendFormatted(channelId);
			defaultInterpolatedStringHandler.AppendLiteral("&productId=");
			defaultInterpolatedStringHandler.AppendFormatted(productId);
			defaultInterpolatedStringHandler.AppendLiteral("&accountType=0&projectId=");
			defaultInterpolatedStringHandler.AppendFormatted(projectId);
			defaultInterpolatedStringHandler.AppendLiteral("&sdkVersion=");
			defaultInterpolatedStringHandler.AppendFormatted(sdkVersion);
			defaultInterpolatedStringHandler.AppendLiteral("&loginId=");
			defaultInterpolatedStringHandler.AppendFormatted(runningOnlyCode);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			LauncherLog instance = LauncherLog.Instance;
			string message = "打开用户中心开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", text);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OpenWebView(text, delegate
			{
				LauncherLog.Instance.Info("打开用户中心结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action endCallBack2 = endCallBack;
				if (endCallBack2 == null)
				{
					return;
				}
				endCallBack2();
			});
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00047CE8 File Offset: 0x00045EE8
		public override void OpenCustomerService()
		{
			PlatformReportClickCustomerService eventData = new PlatformReportClickCustomerService();
			this.ReportToThirdParty(eventData);
			if (PlatformSdkServer.Instance.IsCustomerServiceEnable.GetValueOrDefault())
			{
				string customServiceUrl = PlatformSdkConfig.Instance.GetCustomServiceUrl();
				string channelId = PlatformSdkConfig.Instance.GetChannelId();
				string language = this.GetLanguage();
				string currentAccessToken = this.CurrentAccessToken;
				string gameId = this.GetGameId();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 5);
				defaultInterpolatedStringHandler.AppendFormatted(customServiceUrl);
				defaultInterpolatedStringHandler.AppendLiteral("?channel_id=");
				defaultInterpolatedStringHandler.AppendFormatted(channelId);
				defaultInterpolatedStringHandler.AppendLiteral("&language=");
				defaultInterpolatedStringHandler.AppendFormatted(language);
				defaultInterpolatedStringHandler.AppendLiteral("&game_id=");
				defaultInterpolatedStringHandler.AppendFormatted(gameId);
				defaultInterpolatedStringHandler.AppendLiteral("&token=");
				defaultInterpolatedStringHandler.AppendFormatted(currentAccessToken);
				defaultInterpolatedStringHandler.AppendLiteral("&islogin=1&source=psn");
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				LauncherLog instance = LauncherLog.Instance;
				string message = "打开客服";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", text);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.OpenWebView(text, null);
				return;
			}
			LauncherLog.Instance.Info("关闭了客服", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00047E0C File Offset: 0x0004600C
		public unsafe override void ReportToServer(EReportRoleDataType type, ReportRoleData data)
		{
			string param = LauncherJson.Stringify<ReportRoleData>(data, null);
			string roleId = data.roleId;
			string roleName = data.roleName;
			string serverId = data.serverId;
			string serverName = data.serverName;
			PlatformSdkReportBaseData.InitSdkRoleValue(roleId, roleName, serverId, serverName);
			PlatformSdkServer.Instance.RequestReportData(this.CurrentAccessToken, param, delegate(int code, string msg, long timestamp)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "ReportToServer";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("code", code);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("msg", msg);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("timestamp", timestamp);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			});
			if (type == EReportRoleDataType.Create)
			{
				PlatformReportCreateRole eventData = new PlatformReportCreateRole();
				this.ReportToThirdParty(eventData);
				return;
			}
			if (type == EReportRoleDataType.LevelUp)
			{
				PlatformReportUpgradeRole eventData2 = new PlatformReportUpgradeRole();
				this.ReportToThirdParty(eventData2);
				return;
			}
			if (type == EReportRoleDataType.Select)
			{
				this.ReportToThirdParty(new PlatformReportLoginRole
				{
					level = data.roleLevel
				});
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00047EBB File Offset: 0x000460BB
		public override void ReportToThirdParty(PlatformSdkReportBaseData eventData)
		{
			if (!this.DataReportInitState)
			{
				this.CacheReportArray.Add(eventData);
				return;
			}
			this.ReportToThirdPartyInternal(eventData);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00047EDC File Offset: 0x000460DC
		private unsafe void ReportToThirdPartyInternal(PlatformSdkReportBaseData eventData)
		{
			if (PlatformSdkServer.Instance.IsReportEnable.GetValueOrDefault())
			{
				string reportEventName = eventData.GetReportEventName();
				string reportData = eventData.GetReportData();
				LauncherLog instance = LauncherLog.Instance;
				string message = "ReportToThirdParty";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventName", reportEventName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("data", reportData);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				FThinkingAnalyticsForCSharp.Track(reportEventName, reportData, this.PlatStationReportIndex);
				FKuroAnalyticsForCSharp.Track(reportEventName, reportData, this.PlatStationReportIndex);
				return;
			}
			LauncherLog.Instance.Debug("关闭了数数上报", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00047F90 File Offset: 0x00046190
		public override void NotifyCurrentLanguage(string language)
		{
			PlatformReportGetGameLanguage eventData = new PlatformReportGetGameLanguage();
			this.ReportToThirdParty(eventData);
			PlatformSdkReportBaseData.ChangeLanguage(language);
			PlatformSdkServer.Instance.SetLanguage(language);
			this.CurrentGameLanguage = language;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00047FC2 File Offset: 0x000461C2
		private string GetLanguage()
		{
			if (this.CurrentGameLanguage == "")
			{
				return LauncherLanguageLib.Instance.PackageLanguage;
			}
			return this.CurrentGameLanguage;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00047FE8 File Offset: 0x000461E8
		public override bool BlockServerArea()
		{
			if (KuroApplication.GetAppReleaseType() == "Development")
			{
				return false;
			}
			LauncherLog.Instance.Info("开启了锁区，注意服务器列表配置（将CDN服务器region字段修改成当前国家码可显示）", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00048021 File Offset: 0x00046221
		public override string GetChannelId()
		{
			return PlatformSdkConfig.Instance.GetChannelId();
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0004802D File Offset: 0x0004622D
		public override string GetPackageId()
		{
			return PlatformSdkConfig.Instance.GetProductId();
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0004803C File Offset: 0x0004623C
		public override string GetSdkCountry()
		{
			string userId = this.GetUserId();
			string countryCodeByUserId = UKuroStaticPS5Library.GetCountryCodeByUserId(ref userId);
			LauncherLog instance = LauncherLog.Instance;
			string message = "GetSdkCountry";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("countryCode", countryCodeByUserId);
			instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return countryCodeByUserId;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0004807C File Offset: 0x0004627C
		public override void Tick(double delta)
		{
			this.OnTick((float)delta);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00048086 File Offset: 0x00046286
		public override bool NeedLimitUserInfoWhenSocialLimit()
		{
			return true;
		}

		// Token: 0x040006F5 RID: 1781
		private const int SDKMAXBLOCKUSER = 2000;

		// Token: 0x040006F6 RID: 1782
		private const string CACHEAGREEKEY = "AgreeState";

		// Token: 0x040006F7 RID: 1783
		private const string AGREEVALUE = "1";

		// Token: 0x040006F8 RID: 1784
		private const int EXIT_WAIT_TIME = 1;

		// Token: 0x040006F9 RID: 1785
		private const int MAX_PENDING_LOG = 1000;

		// Token: 0x040006FA RID: 1786
		private const int SEND_HTTP_TIMEOUT = 10000;

		// Token: 0x040006FB RID: 1787
		private const int CALIBRATE_INTERVAL = 10;

		// Token: 0x040006FC RID: 1788
		private const bool CALIBRATE_STOP_TIMER = true;

		// Token: 0x040006FD RID: 1789
		[Nullable(2)]
		private UniversalDataSystemManager UniversalDataSystemManager;

		// Token: 0x040006FE RID: 1790
		[Nullable(2)]
		private PlayStationTrophy PlayStationTrophy;

		// Token: 0x040006FF RID: 1791
		[Nullable(2)]
		private AuthCodeData AuthCodeData;

		// Token: 0x04000700 RID: 1792
		private bool CacheAgreeState;

		// Token: 0x04000701 RID: 1793
		private Dictionary<string, bool> CacheBlockMap = new Dictionary<string, bool>();

		// Token: 0x04000702 RID: 1794
		private long LastGetBlockTime;

		// Token: 0x04000703 RID: 1795
		private readonly Dictionary<string, ESdkRelation> CacheBlockRelationMap = new Dictionary<string, ESdkRelation>();

		// Token: 0x04000704 RID: 1796
		private readonly Dictionary<string, UniTaskCompletionSource<Dictionary<string, ESdkRelation>>> GetBlockRelationMissionPromiseMap = new Dictionary<string, UniTaskCompletionSource<Dictionary<string, ESdkRelation>>>();

		// Token: 0x04000705 RID: 1797
		private string SelfAccountId = "";

		// Token: 0x04000706 RID: 1798
		[Nullable(2)]
		private UKuroTickManager Ticker;

		// Token: 0x04000707 RID: 1799
		[Nullable(2)]
		private Action<float> TickDelegate;

		// Token: 0x04000708 RID: 1800
		private readonly Dictionary<int, Func<int>> OnTickCallBackMap = new Dictionary<int, Func<int>>();

		// Token: 0x04000709 RID: 1801
		private int TickUpdateId;

		// Token: 0x0400070A RID: 1802
		private ESdkMessageBoxState CacheMessageBoxState;

		// Token: 0x0400070B RID: 1803
		private string DeviceId = "";

		// Token: 0x0400070C RID: 1804
		private readonly int PlatStationReportIndex = 50;

		// Token: 0x0400070D RID: 1805
		private string CurrentGameLanguage = "";

		// Token: 0x0400070E RID: 1806
		private List<PlatformSdkReportBaseData> CacheReportArray = new List<PlatformSdkReportBaseData>();

		// Token: 0x0400070F RID: 1807
		private bool FirstTimeGetBlockState;

		// Token: 0x04000710 RID: 1808
		private string CurrentPayChannelGoodsId = "";

		// Token: 0x04000711 RID: 1809
		private string CurrentPayProductId = "";

		// Token: 0x04000712 RID: 1810
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FProductData> PsnProducts;

		// Token: 0x04000713 RID: 1811
		private long LastGetStoreProductsTime;

		// Token: 0x04000714 RID: 1812
		private readonly int GetProductCount = 20;

		// Token: 0x04000715 RID: 1813
		private readonly int LabelId;
	}
}
