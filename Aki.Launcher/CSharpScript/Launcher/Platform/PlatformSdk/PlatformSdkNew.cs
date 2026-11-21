using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000144 RID: 324
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkNew
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x000462C0 File Offset: 0x000444C0
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

		// Token: 0x06000A13 RID: 2579 RVA: 0x00046340 File Offset: 0x00044540
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

		// Token: 0x06000A14 RID: 2580 RVA: 0x00046399 File Offset: 0x00044599
		protected virtual bool OnInit()
		{
			return true;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0004639C File Offset: 0x0004459C
		protected virtual bool OnUnInit()
		{
			return true;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0004639F File Offset: 0x0004459F
		public virtual void ConnectToServer(TSDKConnectCallback callback)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000463A1 File Offset: 0x000445A1
		public virtual bool NeedPrivacyProtocol()
		{
			return false;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000463A4 File Offset: 0x000445A4
		public virtual bool GetPrivacyAgreeState()
		{
			return false;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000463A7 File Offset: 0x000445A7
		public virtual void SavePrivacyAgreeState(bool state)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000463A9 File Offset: 0x000445A9
		public virtual string GetDeviceId()
		{
			return "DefaultDeviceId";
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000463B0 File Offset: 0x000445B0
		public virtual string GetProductId()
		{
			return "DefaultProductId";
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000463B7 File Offset: 0x000445B7
		public virtual void SetServerCommonParam()
		{
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000463B9 File Offset: 0x000445B9
		public virtual void Login(TSDKLoginCallback callback)
		{
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000463BB File Offset: 0x000445BB
		public virtual void BindAccountThenLogin(TSDKLoginCallback callback, string mailAddress = "", string mailCode = "")
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x000463BD File Offset: 0x000445BD
		public virtual string GetUserId()
		{
			return "NotImplement";
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000463C4 File Offset: 0x000445C4
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

		// Token: 0x06000A21 RID: 2593 RVA: 0x00046400 File Offset: 0x00044600
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

		// Token: 0x06000A22 RID: 2594 RVA: 0x0004643C File Offset: 0x0004463C
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

		// Token: 0x06000A23 RID: 2595 RVA: 0x00046478 File Offset: 0x00044678
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

		// Token: 0x06000A24 RID: 2596 RVA: 0x000464B4 File Offset: 0x000446B4
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

		// Token: 0x06000A25 RID: 2597 RVA: 0x000464EF File Offset: 0x000446EF
		public virtual bool NeedShowShopIcon()
		{
			return false;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000464F2 File Offset: 0x000446F2
		public virtual void ShowPlayStationStoreIcon(int positionType)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000464F4 File Offset: 0x000446F4
		public virtual void HidePlayStationStoreIcon()
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000464F6 File Offset: 0x000446F6
		public virtual bool NeedShowThirdPartyId()
		{
			return false;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000464F9 File Offset: 0x000446F9
		public virtual bool SupportSwitchFriendSearchByThirdPartyId()
		{
			return false;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000464FC File Offset: 0x000446FC
		public virtual bool SupportSwitchFriendShowType()
		{
			return false;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00046500 File Offset: 0x00044700
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

		// Token: 0x06000A2C RID: 2604 RVA: 0x0004653C File Offset: 0x0004473C
		[NullableContext(0)]
		public virtual UniTask<bool> UnlockSdkTrophy(int trophyId)
		{
			PlatformSdkNew.<UnlockSdkTrophy>d__37 <UnlockSdkTrophy>d__;
			<UnlockSdkTrophy>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UnlockSdkTrophy>d__.<>1__state = -1;
			<UnlockSdkTrophy>d__.<>t__builder.Start<PlatformSdkNew.<UnlockSdkTrophy>d__37>(ref <UnlockSdkTrophy>d__);
			return <UnlockSdkTrophy>d__.<>t__builder.Task;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00046578 File Offset: 0x00044778
		[NullableContext(0)]
		public virtual UniTask<bool> UpdateSdkTrophyProgress(int trophyId, int progress)
		{
			PlatformSdkNew.<UpdateSdkTrophyProgress>d__38 <UpdateSdkTrophyProgress>d__;
			<UpdateSdkTrophyProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateSdkTrophyProgress>d__.<>1__state = -1;
			<UpdateSdkTrophyProgress>d__.<>t__builder.Start<PlatformSdkNew.<UpdateSdkTrophyProgress>d__38>(ref <UpdateSdkTrophyProgress>d__);
			return <UpdateSdkTrophyProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000465B3 File Offset: 0x000447B3
		public virtual bool GetSdkFriendOnlyState()
		{
			return false;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000465B6 File Offset: 0x000447B6
		public virtual void SaveSdkFriendOnlyState(bool state)
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000465B8 File Offset: 0x000447B8
		public virtual void OpenWebView(string url, [Nullable(2)] Action endCallBack = null)
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000465BA File Offset: 0x000447BA
		public virtual void CloseWebView()
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000465BC File Offset: 0x000447BC
		public virtual bool PollWebViewClose()
		{
			return true;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000465BF File Offset: 0x000447BF
		protected virtual void InitWebComponent()
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000465C4 File Offset: 0x000447C4
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

		// Token: 0x06000A35 RID: 2613 RVA: 0x000465FF File Offset: 0x000447FF
		public virtual bool OpenCheckoutDialog(string productLabel, string productId, string channelGoodsId)
		{
			return false;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00046602 File Offset: 0x00044802
		public virtual bool NeedCheckPlayOnly()
		{
			return false;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00046605 File Offset: 0x00044805
		public virtual bool PlayOnly()
		{
			return this.NeedCheckPlayOnly() && this.PlayOnlyState;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00046617 File Offset: 0x00044817
		public virtual void SetPlayOnly(bool state)
		{
			this.PlayOnlyState = state;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00046620 File Offset: 0x00044820
		public virtual ESdkDialogResult PollCheckoutDialogResult()
		{
			return ESdkDialogResult.No;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00046623 File Offset: 0x00044823
		public virtual void RequestCheckoutProduct(ISdkRequestCheckoutProductParam param, TSdkCheckoutProductCallback callback, ECheckoutReason reason)
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00046625 File Offset: 0x00044825
		public virtual void StartActivity(string activityId)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00046627 File Offset: 0x00044827
		public virtual void EndActivity(string activityId)
		{
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00046629 File Offset: 0x00044829
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

		// Token: 0x06000A3E RID: 2622 RVA: 0x0004662B File Offset: 0x0004482B
		public virtual bool NeedConfirmSdkProductInfo()
		{
			return false;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0004662E File Offset: 0x0004482E
		public virtual bool NeedShowSdkProductInfoBeforePay()
		{
			return false;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00046634 File Offset: 0x00044834
		[NullableContext(0)]
		public virtual UniTask<bool> OpenMessageBox([Nullable(1)] string accountId, ESdkMessageBoxMode dialogMode, ESdkMessageBoxType msgType)
		{
			PlatformSdkNew.<OpenMessageBox>d__57 <OpenMessageBox>d__;
			<OpenMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenMessageBox>d__.<>1__state = -1;
			<OpenMessageBox>d__.<>t__builder.Start<PlatformSdkNew.<OpenMessageBox>d__57>(ref <OpenMessageBox>d__);
			return <OpenMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0004666F File Offset: 0x0004486F
		public virtual void GetMessageBoxCurrentState(Action<ESdkMessageBoxState> callBack)
		{
			callBack(ESdkMessageBoxState.None);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00046678 File Offset: 0x00044878
		public virtual void TerminateMessageBox()
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0004667A File Offset: 0x0004487A
		public virtual void GetCommunicationRestricted([Nullable(2)] string accountId, Action<ESdkCommunicationRestricted> callBack)
		{
			callBack(ESdkCommunicationRestricted.No);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00046684 File Offset: 0x00044884
		[NullableContext(0)]
		public virtual UniTask<ESdkCommunicationRestricted> GetCommunicationRestrictedAsync([Nullable(2)] string accountId)
		{
			PlatformSdkNew.<GetCommunicationRestrictedAsync>d__61 <GetCommunicationRestrictedAsync>d__;
			<GetCommunicationRestrictedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESdkCommunicationRestricted>.Create();
			<GetCommunicationRestrictedAsync>d__.<>1__state = -1;
			<GetCommunicationRestrictedAsync>d__.<>t__builder.Start<PlatformSdkNew.<GetCommunicationRestrictedAsync>d__61>(ref <GetCommunicationRestrictedAsync>d__);
			return <GetCommunicationRestrictedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000466BF File Offset: 0x000448BF
		public virtual bool GetIfShowDefaultPrice()
		{
			return true;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000466C2 File Offset: 0x000448C2
		public virtual int CheckUserPremium()
		{
			return 0;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000466C5 File Offset: 0x000448C5
		public virtual bool GetIfNeedQueryProductInfoForce()
		{
			return false;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000466C8 File Offset: 0x000448C8
		public virtual void NotifyPlayStationPremium(bool isPlayStationOnly)
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000466CA File Offset: 0x000448CA
		public virtual string CreatePlayerSession(int joinAbleUserType, int playerId)
		{
			return "-1";
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000466D1 File Offset: 0x000448D1
		public virtual void SetPlayerSessionJoinAbleUserType(int joinAbleUserType)
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000466D3 File Offset: 0x000448D3
		public virtual void LeavePlayerSession()
		{
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000466D5 File Offset: 0x000448D5
		public virtual void JoinPlayerSession(string playerSession)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000466D7 File Offset: 0x000448D7
		public virtual string CheckJoinSession()
		{
			return "-1";
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000466DE File Offset: 0x000448DE
		public virtual string GetPlayerIdByPlayerSessionId(string playerSession)
		{
			return "-1";
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000466E5 File Offset: 0x000448E5
		public virtual bool IsPlatformNetworkReachable()
		{
			return true;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000466E8 File Offset: 0x000448E8
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

		// Token: 0x06000A51 RID: 2641 RVA: 0x00046723 File Offset: 0x00044923
		public virtual bool SupportExternalWebBrowser()
		{
			return true;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00046726 File Offset: 0x00044926
		public virtual void OpenExternalUrl(string url)
		{
			if (this.SupportExternalWebBrowser())
			{
				UKismetSystemLibrary.LaunchURL(url);
				return;
			}
			this.OpenWebView(url, null);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0004673F File Offset: 0x0004493F
		public virtual void OpenUserCenter(string sdkUid, [Nullable(2)] Action endCallBack = null)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00046741 File Offset: 0x00044941
		public virtual void RefreshAccessToken(string token)
		{
			this.CurrentAccessToken = token;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0004674C File Offset: 0x0004494C
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

		// Token: 0x06000A56 RID: 2646 RVA: 0x00046788 File Offset: 0x00044988
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

		// Token: 0x06000A57 RID: 2647 RVA: 0x00046844 File Offset: 0x00044A44
		public virtual void OpenCustomerService()
		{
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00046846 File Offset: 0x00044A46
		public virtual void ReportToServer(EReportRoleDataType type, ReportRoleData data)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00046848 File Offset: 0x00044A48
		public virtual void ReportToThirdParty(PlatformSdkReportBaseData eventData)
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0004684A File Offset: 0x00044A4A
		public virtual void NotifyCurrentLanguage(string language)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0004684C File Offset: 0x00044A4C
		public virtual bool BlockServerArea()
		{
			return false;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0004684F File Offset: 0x00044A4F
		public virtual string GetSdkCountry()
		{
			return "";
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00046856 File Offset: 0x00044A56
		protected virtual string GetGameName()
		{
			return "wutheringwaves";
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0004685D File Offset: 0x00044A5D
		public virtual string GetGameId()
		{
			if (PlatformSdkConfig.Instance.IsGlobal)
			{
				return "G153";
			}
			return "G152";
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00046876 File Offset: 0x00044A76
		public virtual string GetChannelId()
		{
			return "";
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0004687D File Offset: 0x00044A7D
		public virtual string GetPackageId()
		{
			return "";
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00046884 File Offset: 0x00044A84
		public virtual void OpenNotice()
		{
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00046886 File Offset: 0x00044A86
		public virtual void Tick(double delta)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00046888 File Offset: 0x00044A88
		public virtual void SetTickInnerState(bool state)
		{
			this.TickInnerState = state;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00046891 File Offset: 0x00044A91
		public virtual void BindOnWebViewCloseCallBack(Action callback)
		{
			this.OnWebViewCloseCallBack = callback;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0004689A File Offset: 0x00044A9A
		public virtual bool NeedLimitUserInfoWhenSocialLimit()
		{
			return false;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0004689D File Offset: 0x00044A9D
		public virtual void SetThirdUnionId(string unionId)
		{
			this.ThirdUnionId = unionId;
			this.InitPlatformSdkReportData();
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000468AC File Offset: 0x00044AAC
		protected virtual void InitPlatformSdkReportData()
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000468AE File Offset: 0x00044AAE
		public virtual void InitDataReport()
		{
			this.DataReportInitState = true;
			this.OnInitDataReport();
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000468BD File Offset: 0x00044ABD
		protected virtual void OnInitDataReport()
		{
		}

		// Token: 0x04000626 RID: 1574
		private const string LOGINCODE = "Sdk_LoginCode";

		// Token: 0x04000627 RID: 1575
		private bool IsInitialized;

		// Token: 0x04000628 RID: 1576
		private bool PlayOnlyState;

		// Token: 0x04000629 RID: 1577
		[Nullable(2)]
		protected UObject WorldContext;

		// Token: 0x0400062A RID: 1578
		private string RunningInitCode = "";

		// Token: 0x0400062B RID: 1579
		protected long InitTime;

		// Token: 0x0400062C RID: 1580
		protected string CurrentAccessToken = "";

		// Token: 0x0400062D RID: 1581
		protected bool TickInnerState = true;

		// Token: 0x0400062E RID: 1582
		[Nullable(2)]
		protected Action OnWebViewCloseCallBack;

		// Token: 0x0400062F RID: 1583
		protected string ThirdUnionId = "";

		// Token: 0x04000630 RID: 1584
		protected bool DataReportInitState;
	}
}
