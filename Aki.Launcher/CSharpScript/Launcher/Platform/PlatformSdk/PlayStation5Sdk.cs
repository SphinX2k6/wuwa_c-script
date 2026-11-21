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
	// Token: 0x0200019F RID: 415
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayStation5Sdk : PlatformSdkNew
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x000488C0 File Offset: 0x00046AC0
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

		// Token: 0x06000B2F RID: 2863 RVA: 0x0004895C File Offset: 0x00046B5C
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

		// Token: 0x06000B30 RID: 2864 RVA: 0x000489F8 File Offset: 0x00046BF8
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
				FCreateInstanceParam fcreateInstanceParam = new FCreateInstanceParam
				{
					Index = this.PlatStationReportIndex,
					ServerUrl = dataReportUrl,
					AppId = dataReportId,
					DistinctId = UThinkingAnalytics.GetMachineID(),
					AccountId = accountId,
					LogDisplayName = "SdkData",
					SaveDBPath = "",
					MaxNumInBatch = 1000,
					Mode = TAMode.NORMAL,
					SaveMode = ESaveMode.None_Save,
					FlushTimeInterval = 0f,
					bUseUtf8 = true,
					bLogInitEnable = false,
					bImmediateSave = false,
					bRuntimeInstance = true,
					ExitWaitTime = 1f,
					MaxPendingLog = 1000,
					SendHttpTimeout = 10000f,
					bExitFlush = true,
					CalibrateIntervalTime = 10f,
					bCalibratedStopTimer = true,
					bEnableCompressPlusOneLen = false
				};
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
				FKACreateInstanceParam fkacreateInstanceParam = new FKACreateInstanceParam
				{
					Index = this.PlatStationReportIndex,
					ServerUrl = kuroDataReportUrl,
					AppId = dataReportId2,
					DistinctId = UKuroAnalytics.GetMachineID(),
					AccountId = accountId2,
					LogDisplayName = "SdkData",
					SaveDBPath = "",
					MaxNumInBatch = 1000,
					Mode = KAMode.NORMAL,
					SaveMode = EKASaveMode.None_Save,
					FlushTimeInterval = 0f,
					bUseUtf8 = true,
					bLogInitEnable = false,
					bImmediateSave = false,
					bRuntimeInstance = true,
					ExitWaitTime = 1f,
					MaxPendingLog = 1000,
					SendHttpTimeout = 10000f,
					bExitFlush = true,
					CalibrateIntervalTime = 10f,
					bCalibratedStopTimer = true,
					bEnableCompressPlusOneLen = false
				};
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

		// Token: 0x06000B31 RID: 2865 RVA: 0x00048CD8 File Offset: 0x00046ED8
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

		// Token: 0x06000B32 RID: 2866 RVA: 0x00048D28 File Offset: 0x00046F28
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

		// Token: 0x06000B33 RID: 2867 RVA: 0x00048D88 File Offset: 0x00046F88
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

		// Token: 0x06000B34 RID: 2868 RVA: 0x00048DE2 File Offset: 0x00046FE2
		private void AddTickCallBack(Func<int> callback)
		{
			this.TickUpdateId++;
			this.OnTickCallBackMap[this.TickUpdateId] = callback;
			this.StartTicker();
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00048E0C File Offset: 0x0004700C
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

		// Token: 0x06000B36 RID: 2870 RVA: 0x00048E68 File Offset: 0x00047068
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

		// Token: 0x06000B37 RID: 2871 RVA: 0x00048F1C File Offset: 0x0004711C
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

		// Token: 0x06000B38 RID: 2872 RVA: 0x00048F5C File Offset: 0x0004715C
		protected override void InitWebComponent()
		{
			string userId = this.GetUserId();
			UKuroStaticPS5Library.InitWebApi(ref userId);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00048F78 File Offset: 0x00047178
		protected override bool OnUnInit()
		{
			UniversalDataSystemManager universalDataSystemManager = this.UniversalDataSystemManager;
			if (universalDataSystemManager != null)
			{
				universalDataSystemManager.Stop();
			}
			return true;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00048F8C File Offset: 0x0004718C
		public override void ConnectToServer(TSDKConnectCallback callback)
		{
			PlayStation5Sdk.<>c__DisplayClass41_0 CS$<>8__locals1 = new PlayStation5Sdk.<>c__DisplayClass41_0();
			CS$<>8__locals1.callback = callback;
			string platformPkg = PlatformSdkConfig.Instance.GetPlatformPkg();
			PlatformSdkServer.Instance.Connect("&pkg=" + platformPkg, new TSDKConnectCallback(CS$<>8__locals1.<ConnectToServer>g__FinalCallBack|0));
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00048FD4 File Offset: 0x000471D4
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

		// Token: 0x06000B3C RID: 2876 RVA: 0x000490CC File Offset: 0x000472CC
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

		// Token: 0x06000B3D RID: 2877 RVA: 0x000491A9 File Offset: 0x000473A9
		public override bool NeedPrivacyProtocol()
		{
			return true;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000491AC File Offset: 0x000473AC
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

		// Token: 0x06000B3F RID: 2879 RVA: 0x000492A4 File Offset: 0x000474A4
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

		// Token: 0x06000B40 RID: 2880 RVA: 0x00049380 File Offset: 0x00047580
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

		// Token: 0x06000B41 RID: 2881 RVA: 0x000494A0 File Offset: 0x000476A0
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

		// Token: 0x06000B42 RID: 2882 RVA: 0x0004957E File Offset: 0x0004777E
		public override string GetUserId()
		{
			return UKuroStaticPS5Library.GetUserId();
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00049588 File Offset: 0x00047788
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

		// Token: 0x06000B44 RID: 2884 RVA: 0x000495CC File Offset: 0x000477CC
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

		// Token: 0x06000B45 RID: 2885 RVA: 0x0004963C File Offset: 0x0004783C
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

		// Token: 0x06000B46 RID: 2886 RVA: 0x000496C4 File Offset: 0x000478C4
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

		// Token: 0x06000B47 RID: 2887 RVA: 0x00049710 File Offset: 0x00047910
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

		// Token: 0x06000B48 RID: 2888 RVA: 0x00049754 File Offset: 0x00047954
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

		// Token: 0x06000B49 RID: 2889 RVA: 0x000497A0 File Offset: 0x000479A0
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

		// Token: 0x06000B4A RID: 2890 RVA: 0x000497DB File Offset: 0x000479DB
		public override void ShowPlayStationStoreIcon(int positionType)
		{
			UKuroStaticPS5Library.ShowPsStoreIcon(positionType);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000497E4 File Offset: 0x000479E4
		public override void HidePlayStationStoreIcon()
		{
			UKuroStaticPS5Library.HidePsStoreIcon();
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000497EC File Offset: 0x000479EC
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

		// Token: 0x06000B4D RID: 2893 RVA: 0x00049830 File Offset: 0x00047A30
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

		// Token: 0x06000B4E RID: 2894 RVA: 0x00049874 File Offset: 0x00047A74
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

		// Token: 0x06000B4F RID: 2895 RVA: 0x000498C8 File Offset: 0x00047AC8
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

		// Token: 0x06000B50 RID: 2896 RVA: 0x00049914 File Offset: 0x00047B14
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

		// Token: 0x06000B51 RID: 2897 RVA: 0x00049967 File Offset: 0x00047B67
		public override bool NeedShowThirdPartyId()
		{
			return true;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0004996A File Offset: 0x00047B6A
		public override bool SupportSwitchFriendSearchByThirdPartyId()
		{
			return true;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0004996D File Offset: 0x00047B6D
		public override bool SupportSwitchFriendShowType()
		{
			return true;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00049970 File Offset: 0x00047B70
		public override bool GetSdkFriendOnlyState()
		{
			return LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, false);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0004997E File Offset: 0x00047B7E
		public override void SaveSdkFriendOnlyState(bool state)
		{
			LauncherStorageLib.Instance.SetGlobal<bool>(ELauncherStorageGlobalKey.PlayStationFriendOnly, state);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0004998D File Offset: 0x00047B8D
		public override string GetProductId()
		{
			return PlatformSdkConfig.Instance.GetProductId();
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0004999C File Offset: 0x00047B9C
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

		// Token: 0x06000B58 RID: 2904 RVA: 0x000499F9 File Offset: 0x00047BF9
		public override void CloseWebView()
		{
			UKuroStaticPS5Library.CloseWebBrowser();
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00049A01 File Offset: 0x00047C01
		public override bool NeedCheckPlayOnly()
		{
			return true;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00049A04 File Offset: 0x00047C04
		public override bool NeedShowShopIcon()
		{
			return true;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00049A07 File Offset: 0x00047C07
		public override void StartActivity(string activityId)
		{
			UniversalDataSystemManager universalDataSystemManager = this.UniversalDataSystemManager;
			if (universalDataSystemManager == null)
			{
				return;
			}
			universalDataSystemManager.StartActivity(activityId);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00049A1A File Offset: 0x00047C1A
		public override void EndActivity(string activityId)
		{
			UniversalDataSystemManager universalDataSystemManager = this.UniversalDataSystemManager;
			if (universalDataSystemManager == null)
			{
				return;
			}
			universalDataSystemManager.EndActivity(activityId, EPsActivityEndActivityOutcome.Completed);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00049A2E File Offset: 0x00047C2E
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

		// Token: 0x06000B5E RID: 2910 RVA: 0x00049A42 File Offset: 0x00047C42
		public override bool PollWebViewClose()
		{
			return UKuroStaticPS5Library.PollWebBrowser();
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00049A4C File Offset: 0x00047C4C
		[return: Nullable(new byte[]
		{
			0,
			2,
			1
		})]
		private UniTask<TArray<FProductData>> GetPsnStoreProducts()
		{
			PlayStation5Sdk.<GetPsnStoreProducts>d__83 <GetPsnStoreProducts>d__;
			<GetPsnStoreProducts>d__.<>t__builder = AsyncUniTaskMethodBuilder<TArray<FProductData>>.Create();
			<GetPsnStoreProducts>d__.<>4__this = this;
			<GetPsnStoreProducts>d__.<>1__state = -1;
			<GetPsnStoreProducts>d__.<>t__builder.Start<PlayStation5Sdk.<GetPsnStoreProducts>d__83>(ref <GetPsnStoreProducts>d__);
			return <GetPsnStoreProducts>d__.<>t__builder.Task;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00049A90 File Offset: 0x00047C90
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

		// Token: 0x06000B61 RID: 2913 RVA: 0x00049AF0 File Offset: 0x00047CF0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public override UniTask<IQueryProductResult> QueryProductInfo(List<string> productIds)
		{
			PlayStation5Sdk.<QueryProductInfo>d__85 <QueryProductInfo>d__;
			<QueryProductInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQueryProductResult>.Create();
			<QueryProductInfo>d__.<>4__this = this;
			<QueryProductInfo>d__.productIds = productIds;
			<QueryProductInfo>d__.<>1__state = -1;
			<QueryProductInfo>d__.<>t__builder.Start<PlayStation5Sdk.<QueryProductInfo>d__85>(ref <QueryProductInfo>d__);
			return <QueryProductInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00049B3C File Offset: 0x00047D3C
		private void ReportGetGoodsList(string goodsIdsStr, int length)
		{
			this.ReportToThirdParty(new PlatformReportGetGoodsList
			{
				goodsid = goodsIdsStr,
				goodsid_count = length
			});
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00049B64 File Offset: 0x00047D64
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			2,
			1
		})]
		private UniTask<ValueTuple<string, bool, List<IQueryGoodsResponseData>>> QueryStoreProductsInBatches(List<string> productIds)
		{
			PlayStation5Sdk.<QueryStoreProductsInBatches>d__87 <QueryStoreProductsInBatches>d__;
			<QueryStoreProductsInBatches>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<string, bool, List<IQueryGoodsResponseData>>>.Create();
			<QueryStoreProductsInBatches>d__.<>4__this = this;
			<QueryStoreProductsInBatches>d__.productIds = productIds;
			<QueryStoreProductsInBatches>d__.<>1__state = -1;
			<QueryStoreProductsInBatches>d__.<>t__builder.Start<PlayStation5Sdk.<QueryStoreProductsInBatches>d__87>(ref <QueryStoreProductsInBatches>d__);
			return <QueryStoreProductsInBatches>d__.<>t__builder.Task;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00049BB0 File Offset: 0x00047DB0
		private unsafe List<DisplayProductInfo> MergeProductInfo(TArray<FProductData> psnProducts, List<IQueryGoodsResponseData> serverData)
		{
			bool flag = false;
			List<DisplayProductInfo> list = new List<DisplayProductInfo>();
			for (int i = 0; i < psnProducts.Num(); i++)
			{
				FProductData fproductData = psnProducts.Get(i);
				string id = fproductData.id;
				IQueryGoodsResponseData queryGoodsResponseData = null;
				for (int j = 0; j < serverData.Count; j++)
				{
					if (serverData[j].channelGoodsId == id)
					{
						queryGoodsResponseData = serverData[j];
						break;
					}
				}
				if (queryGoodsResponseData == null)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "[PlatformSdkNew][PlayStation5Sdk] QueryProductInfo Error, PSN商品信息在SDK商品配置中找不到";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PSN商品信息 psnId", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PSN商品信息 displayName", fproductData.displayName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PSN商品信息 displayPrice", fproductData.displayPrice);
					instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					flag = true;
				}
				else
				{
					list.Add(new DisplayProductInfo
					{
						GoodId = queryGoodsResponseData.goodsId,
						Price = fproductData.displayPrice.ToString(),
						ChannelGoodId = id,
						GoodLabel = fproductData.label.ToString(),
						Desc = fproductData.description.ToString(),
						Name = fproductData.displayName.ToString()
					});
				}
			}
			if (flag)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "QueryProductInfo Error, PSN商品信息与SDK商品配置不一致";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SDK商品列表", serverData);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				for (int k = 0; k < psnProducts.Num(); k++)
				{
					FProductData fproductData2 = psnProducts.Get(k);
					LauncherLog instance3 = LauncherLog.Instance;
					string message3 = "[PlatformSdkNew][PlayStation5Sdk] PSN商品列表";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("index", k);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("id", fproductData2.id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("displayName", fproductData2.displayName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("displayPrice", fproductData2.displayPrice);
					instance3.Info(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				}
			}
			return list;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00049E04 File Offset: 0x00048004
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

		// Token: 0x06000B66 RID: 2918 RVA: 0x00049E84 File Offset: 0x00048084
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

		// Token: 0x06000B67 RID: 2919 RVA: 0x00049EB4 File Offset: 0x000480B4
		private void ReportPsnCheckoutClose()
		{
			this.ReportToThirdParty(new PlatformReportClosePsnCheckOut
			{
				product_id = this.CurrentPayChannelGoodsId,
				goodsId = this.CurrentPayProductId,
				psnenvlssuer = this.AuthCodeData.IssuerId.ToString()
			});
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00049EFC File Offset: 0x000480FC
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

		// Token: 0x06000B69 RID: 2921 RVA: 0x0004A054 File Offset: 0x00048254
		public override bool NeedConfirmSdkProductInfo()
		{
			return true;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0004A057 File Offset: 0x00048257
		public override bool NeedShowSdkProductInfoBeforePay()
		{
			return true;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0004A05C File Offset: 0x0004825C
		public override void GetMessageBoxCurrentState(Action<ESdkMessageBoxState> callBack)
		{
			PlayStation5Sdk.<>c__DisplayClass95_0 CS$<>8__locals1 = new PlayStation5Sdk.<>c__DisplayClass95_0();
			CS$<>8__locals1.callBack = callBack;
			FPlayStationGetDialogStatusCallBack fplayStationGetDialogStatusCallBack = DelegateUtils.ToManualReleaseDelegate<FPlayStationGetDialogStatusCallBack>(new Action<int>(CS$<>8__locals1.<GetMessageBoxCurrentState>g__OnGetMessage|0));
			UKuroStaticPS5Library.GetMessageDialogStateAsync(fplayStationGetDialogStatusCallBack);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0004A090 File Offset: 0x00048290
		[NullableContext(0)]
		public override UniTask<bool> OpenMessageBox([Nullable(1)] string accountId, ESdkMessageBoxMode dialogMode, ESdkMessageBoxType msgType)
		{
			PlayStation5Sdk.<OpenMessageBox>d__96 <OpenMessageBox>d__;
			<OpenMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenMessageBox>d__.<>4__this = this;
			<OpenMessageBox>d__.accountId = accountId;
			<OpenMessageBox>d__.dialogMode = dialogMode;
			<OpenMessageBox>d__.msgType = msgType;
			<OpenMessageBox>d__.<>1__state = -1;
			<OpenMessageBox>d__.<>t__builder.Start<PlayStation5Sdk.<OpenMessageBox>d__96>(ref <OpenMessageBox>d__);
			return <OpenMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0004A0EC File Offset: 0x000482EC
		public override void GetCommunicationRestricted([Nullable(2)] string accountId, Action<ESdkCommunicationRestricted> callBack)
		{
			PlayStation5Sdk.<>c__DisplayClass97_0 CS$<>8__locals1 = new PlayStation5Sdk.<>c__DisplayClass97_0();
			CS$<>8__locals1.callBack = callBack;
			if (accountId == null)
			{
				CS$<>8__locals1.callBack(ESdkCommunicationRestricted.No);
				return;
			}
			FPlayStationGetCommunicationStatusCallBack fplayStationGetCommunicationStatusCallBack = DelegateUtils.ToManualReleaseDelegate<FPlayStationGetCommunicationStatusCallBack>(new Action<int, int>(CS$<>8__locals1.<GetCommunicationRestricted>g__OnCommunicationResponse|0));
			UKuroStaticPS5Library.GetCommunicationRestrictionStatusAsync(ref accountId, fplayStationGetCommunicationStatusCallBack);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0004A134 File Offset: 0x00048334
		[NullableContext(0)]
		public override UniTask<ESdkCommunicationRestricted> GetCommunicationRestrictedAsync([Nullable(2)] string accountId)
		{
			PlayStation5Sdk.<GetCommunicationRestrictedAsync>d__98 <GetCommunicationRestrictedAsync>d__;
			<GetCommunicationRestrictedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
			<GetCommunicationRestrictedAsync>d__.<>4__this = this;
			<GetCommunicationRestrictedAsync>d__.accountId = accountId;
			<GetCommunicationRestrictedAsync>d__.<>1__state = -1;
			<GetCommunicationRestrictedAsync>d__.<>t__builder.Start<PlayStation5Sdk.<GetCommunicationRestrictedAsync>d__98>(ref <GetCommunicationRestrictedAsync>d__);
			return <GetCommunicationRestrictedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0004A17F File Offset: 0x0004837F
		public override bool GetIfShowDefaultPrice()
		{
			return false;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0004A184 File Offset: 0x00048384
		public override int CheckUserPremium()
		{
			string userId = this.GetUserId();
			return UKuroStaticPS5Library.CheckUserPremium(ref userId);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0004A1A0 File Offset: 0x000483A0
		public override void NotifyPlayStationPremium(bool isPlayStationOnly)
		{
			string userId = this.GetUserId();
			UKuroStaticPS5Library.NotifyPremiumFeature(ref userId, isPlayStationOnly);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0004A1BC File Offset: 0x000483BC
		public override void TerminateMessageBox()
		{
			UKuroStaticPS5Library.TerminateMessageDialog();
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0004A1C4 File Offset: 0x000483C4
		public override string CreatePlayerSession(int joinAbleUserType, int playerId)
		{
			string text = playerId.ToString();
			return UKuroStaticPS5Library.CreatePlayerSession(joinAbleUserType, ref text);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0004A1E1 File Offset: 0x000483E1
		public override void SetPlayerSessionJoinAbleUserType(int joinAbleUserType)
		{
			UKuroStaticPS5Library.SetPlayerSessionJoinableUserType(joinAbleUserType);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0004A1E9 File Offset: 0x000483E9
		public override void LeavePlayerSession()
		{
			UKuroStaticPS5Library.LeavePlayerSession();
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0004A1F0 File Offset: 0x000483F0
		public override void JoinPlayerSession(string playerSession)
		{
			UKuroStaticPS5Library.JoinPlayerSession(ref playerSession);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0004A1F9 File Offset: 0x000483F9
		public override string CheckJoinSession()
		{
			return UKuroStaticPS5Library.CheckJoinSession();
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0004A200 File Offset: 0x00048400
		public override string GetPlayerIdByPlayerSessionId(string playerSession)
		{
			return UKuroStaticPS5Library.GetPlayerIdByPlayerSessionId(ref playerSession);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0004A20C File Offset: 0x0004840C
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

		// Token: 0x06000B7A RID: 2938 RVA: 0x0004A24C File Offset: 0x0004844C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override UniTask<Dictionary<string, ESdkRelation>> GetTargetRelation(List<string> accountIdList)
		{
			PlayStation5Sdk.<GetTargetRelation>d__110 <GetTargetRelation>d__;
			<GetTargetRelation>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, ESdkRelation>>.Create();
			<GetTargetRelation>d__.<>4__this = this;
			<GetTargetRelation>d__.accountIdList = accountIdList;
			<GetTargetRelation>d__.<>1__state = -1;
			<GetTargetRelation>d__.<>t__builder.Start<PlayStation5Sdk.<GetTargetRelation>d__110>(ref <GetTargetRelation>d__);
			return <GetTargetRelation>d__.<>t__builder.Task;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0004A297 File Offset: 0x00048497
		public override bool GetIfNeedQueryProductInfoForce()
		{
			return false;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0004A29C File Offset: 0x0004849C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public override UniTask<RequestEmailCodeResponse> RequestEmailCode(string emailAddress)
		{
			PlayStation5Sdk.<RequestEmailCode>d__112 <RequestEmailCode>d__;
			<RequestEmailCode>d__.<>t__builder = AsyncUniTaskMethodBuilder<RequestEmailCodeResponse>.Create();
			<RequestEmailCode>d__.emailAddress = emailAddress;
			<RequestEmailCode>d__.<>1__state = -1;
			<RequestEmailCode>d__.<>t__builder.Start<PlayStation5Sdk.<RequestEmailCode>d__112>(ref <RequestEmailCode>d__);
			return <RequestEmailCode>d__.<>t__builder.Task;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0004A2DF File Offset: 0x000484DF
		public override bool SupportExternalWebBrowser()
		{
			return false;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0004A2E4 File Offset: 0x000484E4
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

		// Token: 0x06000B7F RID: 2943 RVA: 0x0004A4D8 File Offset: 0x000486D8
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

		// Token: 0x06000B80 RID: 2944 RVA: 0x0004A5FC File Offset: 0x000487FC
		public unsafe override void ReportToServer(EReportRoleDataType type, ReportRoleData data)
		{
			string param = LauncherJson.Stringify(data, null);
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

		// Token: 0x06000B81 RID: 2945 RVA: 0x0004A6AB File Offset: 0x000488AB
		public override void ReportToThirdParty(PlatformSdkReportBaseData eventData)
		{
			if (!this.DataReportInitState)
			{
				this.CacheReportArray.Add(eventData);
				return;
			}
			this.ReportToThirdPartyInternal(eventData);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0004A6CC File Offset: 0x000488CC
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

		// Token: 0x06000B83 RID: 2947 RVA: 0x0004A780 File Offset: 0x00048980
		public override void NotifyCurrentLanguage(string language)
		{
			PlatformReportGetGameLanguage eventData = new PlatformReportGetGameLanguage();
			this.ReportToThirdParty(eventData);
			PlatformSdkReportBaseData.ChangeLanguage(language);
			PlatformSdkServer.Instance.SetLanguage(language);
			this.CurrentGameLanguage = language;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0004A7B2 File Offset: 0x000489B2
		private string GetLanguage()
		{
			if (this.CurrentGameLanguage == "")
			{
				return LauncherLanguageLib.Instance.PackageLanguage;
			}
			return this.CurrentGameLanguage;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0004A7D8 File Offset: 0x000489D8
		public override bool BlockServerArea()
		{
			if (KuroApplication.GetAppReleaseType() == "Development")
			{
				return false;
			}
			LauncherLog.Instance.Info("开启了锁区，注意服务器列表配置（将CDN服务器region字段修改成当前国家码可显示）", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0004A811 File Offset: 0x00048A11
		public override string GetChannelId()
		{
			return PlatformSdkConfig.Instance.GetChannelId();
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0004A81D File Offset: 0x00048A1D
		public override string GetPackageId()
		{
			return PlatformSdkConfig.Instance.GetProductId();
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0004A82C File Offset: 0x00048A2C
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

		// Token: 0x06000B89 RID: 2953 RVA: 0x0004A86C File Offset: 0x00048A6C
		public override void Tick(double delta)
		{
			this.OnTick((float)delta);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0004A876 File Offset: 0x00048A76
		public override bool NeedLimitUserInfoWhenSocialLimit()
		{
			return true;
		}

		// Token: 0x04000730 RID: 1840
		private const int SDKMAXBLOCKUSER = 2000;

		// Token: 0x04000731 RID: 1841
		private const string CACHEAGREEKEY = "AgreeState";

		// Token: 0x04000732 RID: 1842
		private const string AGREEVALUE = "1";

		// Token: 0x04000733 RID: 1843
		private const int EXIT_WAIT_TIME = 1;

		// Token: 0x04000734 RID: 1844
		private const int MAX_PENDING_LOG = 1000;

		// Token: 0x04000735 RID: 1845
		private const int SEND_HTTP_TIMEOUT = 10000;

		// Token: 0x04000736 RID: 1846
		private const int CALIBRATE_INTERVAL = 10;

		// Token: 0x04000737 RID: 1847
		private const bool CALIBRATE_STOP_TIMER = true;

		// Token: 0x04000738 RID: 1848
		[Nullable(2)]
		private UniversalDataSystemManager UniversalDataSystemManager;

		// Token: 0x04000739 RID: 1849
		[Nullable(2)]
		private PlayStationTrophy PlayStationTrophy;

		// Token: 0x0400073A RID: 1850
		[Nullable(2)]
		private AuthCodeData AuthCodeData;

		// Token: 0x0400073B RID: 1851
		private bool CacheAgreeState;

		// Token: 0x0400073C RID: 1852
		private Dictionary<string, bool> CacheBlockMap = new Dictionary<string, bool>();

		// Token: 0x0400073D RID: 1853
		private long LastGetBlockTime;

		// Token: 0x0400073E RID: 1854
		private readonly Dictionary<string, ESdkRelation> CacheBlockRelationMap = new Dictionary<string, ESdkRelation>();

		// Token: 0x0400073F RID: 1855
		private readonly Dictionary<string, UniTaskCompletionSource<Dictionary<string, ESdkRelation>>> GetBlockRelationMissionPromiseMap = new Dictionary<string, UniTaskCompletionSource<Dictionary<string, ESdkRelation>>>();

		// Token: 0x04000740 RID: 1856
		private string SelfAccountId = "";

		// Token: 0x04000741 RID: 1857
		[Nullable(2)]
		private UKuroTickManager Ticker;

		// Token: 0x04000742 RID: 1858
		[Nullable(2)]
		private Action<float> TickDelegate;

		// Token: 0x04000743 RID: 1859
		private readonly Dictionary<int, Func<int>> OnTickCallBackMap = new Dictionary<int, Func<int>>();

		// Token: 0x04000744 RID: 1860
		private int TickUpdateId;

		// Token: 0x04000745 RID: 1861
		private ESdkMessageBoxState CacheMessageBoxState;

		// Token: 0x04000746 RID: 1862
		private string DeviceId = "";

		// Token: 0x04000747 RID: 1863
		private readonly int PlatStationReportIndex = 50;

		// Token: 0x04000748 RID: 1864
		private string CurrentGameLanguage = "";

		// Token: 0x04000749 RID: 1865
		private List<PlatformSdkReportBaseData> CacheReportArray = new List<PlatformSdkReportBaseData>();

		// Token: 0x0400074A RID: 1866
		private bool FirstTimeGetBlockState;

		// Token: 0x0400074B RID: 1867
		private string CurrentPayChannelGoodsId = "";

		// Token: 0x0400074C RID: 1868
		private string CurrentPayProductId = "";

		// Token: 0x0400074D RID: 1869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FProductData> PsnProducts;

		// Token: 0x0400074E RID: 1870
		private long LastGetStoreProductsTime;

		// Token: 0x0400074F RID: 1871
		private readonly int GetProductCount = 20;

		// Token: 0x04000750 RID: 1872
		private readonly int LabelId;

		// Token: 0x04000751 RID: 1873
		private const int QueryProductBatchSize = 50;
	}
}
