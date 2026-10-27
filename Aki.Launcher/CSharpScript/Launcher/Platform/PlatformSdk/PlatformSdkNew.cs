using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000140 RID: 320
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkNew
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x00043EAC File Offset: 0x000420AC
		public virtual bool Initialize(UObject worldContext)
		{
			this.WorldContext = worldContext;
			this.InitTime = (long)this.GetInitTime();
			if (this.IsInitialized)
			{
				LauncherLog.Instance.Error("[PlatformSdkNew]平台SDK重复初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			this.InitPlatformSdkReportData();
			this.SetServerCommonParam();
			this.InitWebComponent();
			if (!this.OnInit())
			{
				LauncherLog.Instance.Error("[PlatformSdkNew]平台SDK初始化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.IsInitialized = true;
			return true;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00043F2C File Offset: 0x0004212C
		public virtual bool UnInitialize()
		{
			if (!this.IsInitialized)
			{
				LauncherLog.Instance.Error("[PlatformSdkNew]平台SDK注销失败, 未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!this.OnUnInit())
			{
				LauncherLog.Instance.Error("[PlatformSdkNew]平台SDK注销失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.IsInitialized = false;
			return true;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00043F85 File Offset: 0x00042185
		protected virtual bool OnInit()
		{
			return true;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00043F88 File Offset: 0x00042188
		protected virtual bool OnUnInit()
		{
			return true;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00043F8B File Offset: 0x0004218B
		public virtual void ConnectToServer(TSDKConnectCallback callback)
		{
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00043F8D File Offset: 0x0004218D
		public virtual bool NeedPrivacyProtocol()
		{
			return false;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00043F90 File Offset: 0x00042190
		public virtual bool GetPrivacyAgreeState()
		{
			return false;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00043F93 File Offset: 0x00042193
		public virtual void SavePrivacyAgreeState(bool state)
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00043F95 File Offset: 0x00042195
		public virtual string GetDeviceId()
		{
			return "DefaultDeviceId";
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00043F9C File Offset: 0x0004219C
		public virtual string GetProductId()
		{
			return "DefaultProductId";
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00043FA3 File Offset: 0x000421A3
		public virtual void SetServerCommonParam()
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00043FA5 File Offset: 0x000421A5
		public virtual void Login(TSDKLoginCallback callback)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00043FA7 File Offset: 0x000421A7
		public virtual void BindAccountThenLogin(TSDKLoginCallback callback, string mailAddress = "", string mailCode = "")
		{
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00043FA9 File Offset: 0x000421A9
		public virtual string GetUserId()
		{
			return "NotImplement";
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00043FB0 File Offset: 0x000421B0
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public virtual UniTask<Dictionary<string, string>> GetSdkOnlineId(List<string> userIdList)
		{
			PlatformSdkNew.<GetSdkOnlineId>d__25 <GetSdkOnlineId>d__;
			<GetSdkOnlineId>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, string>>.Create();
			<GetSdkOnlineId>d__.<>1__state = -1;
			<GetSdkOnlineId>d__.<>t__builder.Start<PlatformSdkNew.<GetSdkOnlineId>d__25>(ref <GetSdkOnlineId>d__);
			return <GetSdkOnlineId>d__.<>t__builder.Task;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00043FEC File Offset: 0x000421EC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public virtual UniTask<Dictionary<string, bool>> GetSdkBlockingUser()
		{
			PlatformSdkNew.<GetSdkBlockingUser>d__26 <GetSdkBlockingUser>d__;
			<GetSdkBlockingUser>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, bool>>.Create();
			<GetSdkBlockingUser>d__.<>1__state = -1;
			<GetSdkBlockingUser>d__.<>t__builder.Start<PlatformSdkNew.<GetSdkBlockingUser>d__26>(ref <GetSdkBlockingUser>d__);
			return <GetSdkBlockingUser>d__.<>t__builder.Task;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00044028 File Offset: 0x00042228
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public virtual UniTask<Dictionary<string, ESdkRelation>> GetTargetRelation(List<string> accountIdList)
		{
			PlatformSdkNew.<GetTargetRelation>d__27 <GetTargetRelation>d__;
			<GetTargetRelation>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, ESdkRelation>>.Create();
			<GetTargetRelation>d__.<>1__state = -1;
			<GetTargetRelation>d__.<>t__builder.Start<PlatformSdkNew.<GetTargetRelation>d__27>(ref <GetTargetRelation>d__);
			return <GetTargetRelation>d__.<>t__builder.Task;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00044064 File Offset: 0x00042264
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public virtual UniTask<Dictionary<string, string>> GetSdkAccountId(List<string> userIdList)
		{
			PlatformSdkNew.<GetSdkAccountId>d__28 <GetSdkAccountId>d__;
			<GetSdkAccountId>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<string, string>>.Create();
			<GetSdkAccountId>d__.<>1__state = -1;
			<GetSdkAccountId>d__.<>t__builder.Start<PlatformSdkNew.<GetSdkAccountId>d__28>(ref <GetSdkAccountId>d__);
			return <GetSdkAccountId>d__.<>t__builder.Task;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000440A0 File Offset: 0x000422A0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public virtual UniTask<string> GetSdkUserIdByAccountId(string accountId)
		{
			PlatformSdkNew.<GetSdkUserIdByAccountId>d__29 <GetSdkUserIdByAccountId>d__;
			<GetSdkUserIdByAccountId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<GetSdkUserIdByAccountId>d__.<>1__state = -1;
			<GetSdkUserIdByAccountId>d__.<>t__builder.Start<PlatformSdkNew.<GetSdkUserIdByAccountId>d__29>(ref <GetSdkUserIdByAccountId>d__);
			return <GetSdkUserIdByAccountId>d__.<>t__builder.Task;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000440DB File Offset: 0x000422DB
		public virtual bool NeedShowShopIcon()
		{
			return false;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000440DE File Offset: 0x000422DE
		public virtual void ShowPlayStationStoreIcon(int positionType)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000440E0 File Offset: 0x000422E0
		public virtual void HidePlayStationStoreIcon()
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000440E2 File Offset: 0x000422E2
		public virtual bool NeedShowThirdPartyId()
		{
			return false;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000440E5 File Offset: 0x000422E5
		public virtual bool SupportSwitchFriendSearchByThirdPartyId()
		{
			return false;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000440E8 File Offset: 0x000422E8
		public virtual bool SupportSwitchFriendShowType()
		{
			return false;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000440EC File Offset: 0x000422EC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public virtual UniTask<List<ISdkTrophyInfo>> GetSdkTrophyInfo(int offset = 0, int length = 0)
		{
			PlatformSdkNew.<GetSdkTrophyInfo>d__36 <GetSdkTrophyInfo>d__;
			<GetSdkTrophyInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<ISdkTrophyInfo>>.Create();
			<GetSdkTrophyInfo>d__.<>1__state = -1;
			<GetSdkTrophyInfo>d__.<>t__builder.Start<PlatformSdkNew.<GetSdkTrophyInfo>d__36>(ref <GetSdkTrophyInfo>d__);
			return <GetSdkTrophyInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00044128 File Offset: 0x00042328
		[NullableContext(0)]
		public virtual UniTask<bool> UnlockSdkTrophy(int trophyId)
		{
			PlatformSdkNew.<UnlockSdkTrophy>d__37 <UnlockSdkTrophy>d__;
			<UnlockSdkTrophy>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UnlockSdkTrophy>d__.<>1__state = -1;
			<UnlockSdkTrophy>d__.<>t__builder.Start<PlatformSdkNew.<UnlockSdkTrophy>d__37>(ref <UnlockSdkTrophy>d__);
			return <UnlockSdkTrophy>d__.<>t__builder.Task;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00044164 File Offset: 0x00042364
		[NullableContext(0)]
		public virtual UniTask<bool> UpdateSdkTrophyProgress(int trophyId, int progress)
		{
			PlatformSdkNew.<UpdateSdkTrophyProgress>d__38 <UpdateSdkTrophyProgress>d__;
			<UpdateSdkTrophyProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateSdkTrophyProgress>d__.<>1__state = -1;
			<UpdateSdkTrophyProgress>d__.<>t__builder.Start<PlatformSdkNew.<UpdateSdkTrophyProgress>d__38>(ref <UpdateSdkTrophyProgress>d__);
			return <UpdateSdkTrophyProgress>d__.<>t__builder.Task;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0004419F File Offset: 0x0004239F
		public virtual bool GetSdkFriendOnlyState()
		{
			return false;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000441A2 File Offset: 0x000423A2
		public virtual void SaveSdkFriendOnlyState(bool state)
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000441A4 File Offset: 0x000423A4
		public virtual void OpenWebView(string url, [Nullable(2)] Action endCallBack = null)
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000441A6 File Offset: 0x000423A6
		public virtual void CloseWebView()
		{
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000441A8 File Offset: 0x000423A8
		public virtual bool PollWebViewClose()
		{
			return true;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000441AB File Offset: 0x000423AB
		protected virtual void InitWebComponent()
		{
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000441B0 File Offset: 0x000423B0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public virtual UniTask<IQueryProductResult> QueryProductInfo(List<string> productIds)
		{
			PlatformSdkNew.<QueryProductInfo>d__45 <QueryProductInfo>d__;
			<QueryProductInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQueryProductResult>.Create();
			<QueryProductInfo>d__.<>1__state = -1;
			<QueryProductInfo>d__.<>t__builder.Start<PlatformSdkNew.<QueryProductInfo>d__45>(ref <QueryProductInfo>d__);
			return <QueryProductInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000441EB File Offset: 0x000423EB
		public virtual bool OpenCheckoutDialog(string productLabel, string productId, string channelGoodsId)
		{
			return false;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000441EE File Offset: 0x000423EE
		public virtual bool NeedCheckPlayOnly()
		{
			return false;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000441F1 File Offset: 0x000423F1
		public virtual bool PlayOnly()
		{
			return this.NeedCheckPlayOnly() && this.PlayOnlyState;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00044203 File Offset: 0x00042403
		public virtual void SetPlayOnly(bool state)
		{
			this.PlayOnlyState = state;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0004420C File Offset: 0x0004240C
		public virtual ESdkDialogResult PollCheckoutDialogResult()
		{
			return ESdkDialogResult.No;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0004420F File Offset: 0x0004240F
		public virtual void RequestCheckoutProduct(ISdkRequestCheckoutProductParam param, TSdkCheckoutProductCallback callback, ECheckoutReason reason)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00044211 File Offset: 0x00042411
		public virtual void StartActivity(string activityId)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00044213 File Offset: 0x00042413
		public virtual void EndActivity(string activityId)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00044215 File Offset: 0x00042415
		public virtual void ChangeActivityAvailability([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> availableActivities, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> unavailableActivities)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00044217 File Offset: 0x00042417
		public virtual bool NeedConfirmSdkProductInfo()
		{
			return false;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0004421A File Offset: 0x0004241A
		public virtual bool NeedShowSdkProductInfoBeforePay()
		{
			return false;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00044220 File Offset: 0x00042420
		[NullableContext(0)]
		public virtual UniTask<bool> OpenMessageBox([Nullable(1)] string accountId, ESdkMessageBoxMode dialogMode, ESdkMessageBoxType msgType)
		{
			PlatformSdkNew.<OpenMessageBox>d__57 <OpenMessageBox>d__;
			<OpenMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenMessageBox>d__.<>1__state = -1;
			<OpenMessageBox>d__.<>t__builder.Start<PlatformSdkNew.<OpenMessageBox>d__57>(ref <OpenMessageBox>d__);
			return <OpenMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0004425B File Offset: 0x0004245B
		public virtual void GetMessageBoxCurrentState(Action<ESdkMessageBoxState> callBack)
		{
			callBack(ESdkMessageBoxState.None);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00044264 File Offset: 0x00042464
		public virtual void TerminateMessageBox()
		{
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00044266 File Offset: 0x00042466
		public virtual void GetCommunicationRestricted([Nullable(2)] string accountId, Action<ESdkCommunicationRestricted> callBack)
		{
			callBack(ESdkCommunicationRestricted.No);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00044270 File Offset: 0x00042470
		[NullableContext(0)]
		public virtual UniTask<ESdkCommunicationRestricted> GetCommunicationRestrictedAsync([Nullable(2)] string accountId)
		{
			PlatformSdkNew.<GetCommunicationRestrictedAsync>d__61 <GetCommunicationRestrictedAsync>d__;
			<GetCommunicationRestrictedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
			<GetCommunicationRestrictedAsync>d__.<>1__state = -1;
			<GetCommunicationRestrictedAsync>d__.<>t__builder.Start<PlatformSdkNew.<GetCommunicationRestrictedAsync>d__61>(ref <GetCommunicationRestrictedAsync>d__);
			return <GetCommunicationRestrictedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000442AB File Offset: 0x000424AB
		public virtual bool GetIfShowDefaultPrice()
		{
			return true;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000442AE File Offset: 0x000424AE
		public virtual int CheckUserPremium()
		{
			return 0;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000442B1 File Offset: 0x000424B1
		public virtual bool GetIfNeedQueryProductInfoForce()
		{
			return false;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000442B4 File Offset: 0x000424B4
		public virtual void NotifyPlayStationPremium(bool isPlayStationOnly)
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000442B6 File Offset: 0x000424B6
		public virtual string CreatePlayerSession(int joinAbleUserType, int playerId)
		{
			return "-1";
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000442BD File Offset: 0x000424BD
		public virtual void SetPlayerSessionJoinAbleUserType(int joinAbleUserType)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000442BF File Offset: 0x000424BF
		public virtual void LeavePlayerSession()
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000442C1 File Offset: 0x000424C1
		public virtual void JoinPlayerSession(string playerSession)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000442C3 File Offset: 0x000424C3
		public virtual string CheckJoinSession()
		{
			return "-1";
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000442CA File Offset: 0x000424CA
		public virtual string GetPlayerIdByPlayerSessionId(string playerSession)
		{
			return "-1";
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000442D1 File Offset: 0x000424D1
		public virtual bool IsPlatformNetworkReachable()
		{
			return true;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000442D4 File Offset: 0x000424D4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public virtual UniTask<RequestEmailCodeResponse> RequestEmailCode(string emailAddress)
		{
			PlatformSdkNew.<RequestEmailCode>d__73 <RequestEmailCode>d__;
			<RequestEmailCode>d__.<>t__builder = AsyncUniTaskMethodBuilder<RequestEmailCodeResponse>.Create();
			<RequestEmailCode>d__.<>1__state = -1;
			<RequestEmailCode>d__.<>t__builder.Start<PlatformSdkNew.<RequestEmailCode>d__73>(ref <RequestEmailCode>d__);
			return <RequestEmailCode>d__.<>t__builder.Task;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0004430F File Offset: 0x0004250F
		public virtual bool SupportExternalWebBrowser()
		{
			return true;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00044312 File Offset: 0x00042512
		public virtual void OpenExternalUrl(string url)
		{
			if (this.SupportExternalWebBrowser())
			{
				UKismetSystemLibrary.LaunchURL(url);
				return;
			}
			this.OpenWebView(url, null);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0004432B File Offset: 0x0004252B
		public virtual void OpenUserCenter(string sdkUid, [Nullable(2)] Action endCallBack = null)
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0004432D File Offset: 0x0004252D
		public virtual void RefreshAccessToken(string token)
		{
			this.CurrentAccessToken = token;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00044338 File Offset: 0x00042538
		private int GetInitTime()
		{
			int result = 0;
			if (UKuroVariableFunctionLibrary.GetIntValue("Sdk_InitTime", ref result))
			{
				return result;
			}
			int num = (int)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			UKuroVariableFunctionLibrary.SetIntValue("Sdk_InitTime", num);
			return num;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00044374 File Offset: 0x00042574
		public virtual string GetRunningOnlyCode()
		{
			if (this.RunningInitCode != "")
			{
				return this.RunningInitCode;
			}
			string empty = string.Empty;
			if (UKuroVariableFunctionLibrary.GetStringValue("Sdk_LoginCode", ref empty))
			{
				this.RunningInitCode = (empty ?? "");
			}
			else
			{
				long value = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
				long value2 = new Random().NextInt64(0L, 10000000000L);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<long>(value);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<long>(value2);
				string runningInitCode = defaultInterpolatedStringHandler.ToStringAndClear();
				this.RunningInitCode = runningInitCode;
				UKuroVariableFunctionLibrary.SetStringValue("Sdk_LoginCode", this.RunningInitCode);
			}
			return this.RunningInitCode;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00044430 File Offset: 0x00042630
		public virtual void OpenCustomerService()
		{
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00044432 File Offset: 0x00042632
		public virtual void ReportToServer(EReportRoleDataType type, ReportRoleData data)
		{
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00044434 File Offset: 0x00042634
		public virtual void ReportToThirdParty(PlatformSdkReportBaseData eventData)
		{
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00044436 File Offset: 0x00042636
		public virtual void NotifyCurrentLanguage(string language)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00044438 File Offset: 0x00042638
		public virtual bool BlockServerArea()
		{
			return false;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0004443B File Offset: 0x0004263B
		public virtual string GetSdkCountry()
		{
			return "";
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00044442 File Offset: 0x00042642
		protected virtual string GetGameName()
		{
			return "wutheringwaves";
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00044449 File Offset: 0x00042649
		public virtual string GetGameId()
		{
			if (PlatformSdkConfig.Instance.IsGlobal)
			{
				return "G153";
			}
			return "G152";
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00044462 File Offset: 0x00042662
		public virtual string GetChannelId()
		{
			return "";
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00044469 File Offset: 0x00042669
		public virtual string GetPackageId()
		{
			return "";
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00044470 File Offset: 0x00042670
		public virtual void OpenNotice()
		{
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00044472 File Offset: 0x00042672
		public virtual void Tick(double delta)
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00044474 File Offset: 0x00042674
		public virtual void SetTickInnerState(bool state)
		{
			this.TickInnerState = state;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0004447D File Offset: 0x0004267D
		public virtual void BindOnWebViewCloseCallBack(Action callback)
		{
			this.OnWebViewCloseCallBack = callback;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00044486 File Offset: 0x00042686
		public virtual bool NeedLimitUserInfoWhenSocialLimit()
		{
			return false;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00044489 File Offset: 0x00042689
		public virtual void SetThirdUnionId(string unionId)
		{
			this.ThirdUnionId = unionId;
			this.InitPlatformSdkReportData();
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00044498 File Offset: 0x00042698
		protected virtual void InitPlatformSdkReportData()
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0004449A File Offset: 0x0004269A
		public virtual void InitDataReport()
		{
			this.DataReportInitState = true;
			this.OnInitDataReport();
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000444A9 File Offset: 0x000426A9
		protected virtual void OnInitDataReport()
		{
		}

		// Token: 0x040005EB RID: 1515
		private const string LOGINCODE = "Sdk_LoginCode";

		// Token: 0x040005EC RID: 1516
		private bool IsInitialized;

		// Token: 0x040005ED RID: 1517
		private bool PlayOnlyState;

		// Token: 0x040005EE RID: 1518
		[Nullable(2)]
		protected UObject WorldContext;

		// Token: 0x040005EF RID: 1519
		private string RunningInitCode = "";

		// Token: 0x040005F0 RID: 1520
		protected long InitTime;

		// Token: 0x040005F1 RID: 1521
		protected string CurrentAccessToken = "";

		// Token: 0x040005F2 RID: 1522
		protected bool TickInnerState = true;

		// Token: 0x040005F3 RID: 1523
		[Nullable(2)]
		protected Action OnWebViewCloseCallBack;

		// Token: 0x040005F4 RID: 1524
		protected string ThirdUnionId = "";

		// Token: 0x040005F5 RID: 1525
		protected bool DataReportInitState;
	}
}
