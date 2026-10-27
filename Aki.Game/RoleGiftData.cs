using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014B9 RID: 5305
[NullableContext(1)]
[Nullable(0)]
public class RoleGiftData : ActivityBaseData
{
	// Token: 0x0600965A RID: 38490 RVA: 0x00207605 File Offset: 0x00205805
	protected override void OnInit(ActivityData data)
	{
		this.InitConfig();
	}

	// Token: 0x0600965B RID: 38491 RVA: 0x00207610 File Offset: 0x00205810
	private void InitConfig()
	{
		if (this.ConfigInitialized)
		{
			return;
		}
		this.ConfigInitialized = true;
		RoleGiftConfig? config = ConfigRoleGiftConfigByActivityId.GetConfig(base.Id, true);
		string message = "InitConfig";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleGiftConfig", (config != null) ? new int?(config.GetValueOrDefault().DropId) : null);
		RoleGiftUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (config != null)
		{
			RoleGiftConfig value = config.Value;
			this.DropIdInternal = value.DropId;
			this.ResolveRoleIdFromDrop(this.DropIdInternal);
			this.RoleGiftConfigIdInternal = value.Id;
		}
	}

	// Token: 0x0600965C RID: 38492 RVA: 0x002076BC File Offset: 0x002058BC
	private unsafe void ResolveRoleIdFromDrop(int dropId)
	{
		this.RoleIdInternal = 0;
		this.RoleTrialIdInternal = 0;
		if (dropId == 0)
		{
			string message = "ResolveRoleIdFromDrop";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", "empty_dropId");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dropId", dropId);
			RoleGiftUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		DropPackage? config = ConfigDropPackageById.GetConfig(dropId, true);
		if (config == null)
		{
			string message2 = "ResolveRoleIdFromDrop";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("reason", "no_drop_or_preview");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("dropId", dropId);
			RoleGiftUtil.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		DropPackage value = config.Value;
		int dropPreviewLength = value.DropPreviewLength;
		if (dropPreviewLength <= 0)
		{
			string message3 = "ResolveRoleIdFromDrop";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("reason", "no_drop_or_preview");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("dropId", dropId);
			RoleGiftUtil.Debug(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return;
		}
		for (int i = 0; i < dropPreviewLength; i++)
		{
			DicIntInt? dicIntInt = value.DropPreview(i);
			if (dicIntInt != null)
			{
				int key = dicIntInt.Value.Key;
				if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.RoleItem)
				{
					this.RoleIdInternal = key;
					this.RoleTrialIdInternal = RoleGiftData.RoleIdToTrialId(key);
					string message4 = "ResolveRoleIdFromDrop";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("reason", "resolved");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("dropId", dropId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("roleId", this.RoleIdInternal);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("roleTrialId", this.RoleTrialIdInternal);
					RoleGiftUtil.Debug(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 4));
					return;
				}
			}
		}
		string message5 = "ResolveRoleIdFromDrop";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("reason", "no_role_in_preview");
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("dropId", dropId);
		RoleGiftUtil.Debug(message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
	}

	// Token: 0x0600965D RID: 38493 RVA: 0x00207954 File Offset: 0x00205B54
	private static int RoleIdToTrialId(int roleId)
	{
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(roleId);
		if (gachaTextureInfo == null)
		{
			return 0;
		}
		return gachaTextureInfo.GetValueOrDefault().TrialId;
	}

	// Token: 0x0600965E RID: 38494 RVA: 0x00207987 File Offset: 0x00205B87
	public int GetDropId()
	{
		return this.DropIdInternal;
	}

	// Token: 0x0600965F RID: 38495 RVA: 0x0020798F File Offset: 0x00205B8F
	public int GetRoleId()
	{
		return this.RoleIdInternal;
	}

	// Token: 0x06009660 RID: 38496 RVA: 0x00207997 File Offset: 0x00205B97
	public int GetRoleTrialId()
	{
		return this.RoleTrialIdInternal;
	}

	// Token: 0x06009661 RID: 38497 RVA: 0x0020799F File Offset: 0x00205B9F
	public int GetRoleGiftConfigId()
	{
		return this.RoleGiftConfigIdInternal;
	}

	// Token: 0x06009662 RID: 38498 RVA: 0x002079A7 File Offset: 0x00205BA7
	public void SetHadGetReward(bool hadGet)
	{
		this.RewardHadGet = hadGet;
	}

	// Token: 0x06009663 RID: 38499 RVA: 0x002079B0 File Offset: 0x00205BB0
	protected override void PhraseEx(ActivityData data)
	{
		RoleGiftActivityData roleGiftActivityData = data.RoleGiftActivityData;
		if (roleGiftActivityData == null)
		{
			return;
		}
		this.InitConfig();
		this.RewardHadGet = roleGiftActivityData.RewardHadGet;
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06009664 RID: 38500 RVA: 0x00207A06 File Offset: 0x00205C06
	public bool GetRewardHadGet()
	{
		return this.RewardHadGet;
	}

	// Token: 0x06009665 RID: 38501 RVA: 0x00207A10 File Offset: 0x00205C10
	public unsafe bool CanReceiveReward()
	{
		bool flag = base.IsUnLock();
		bool flag2 = flag && !this.RewardHadGet;
		string message = "CanReceiveReward";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", base.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isUnLock", flag);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("rewardHadGet", this.RewardHadGet);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("canReceive", flag2);
		RoleGiftUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		return flag2;
	}

	// Token: 0x06009666 RID: 38502 RVA: 0x00207ACD File Offset: 0x00205CCD
	public bool NeedSplash()
	{
		return this.CanReceiveReward();
	}

	// Token: 0x06009667 RID: 38503 RVA: 0x00207AD5 File Offset: 0x00205CD5
	public override bool GetExDataRedPointShowState()
	{
		return !this.RewardHadGet && base.IsUnLock();
	}

	// Token: 0x06009668 RID: 38504 RVA: 0x00207AE7 File Offset: 0x00205CE7
	protected override bool GetExDataFinishShowState()
	{
		return this.RewardHadGet;
	}

	// Token: 0x0400425D RID: 16989
	private bool RewardHadGet;

	// Token: 0x0400425E RID: 16990
	private bool ConfigInitialized;

	// Token: 0x0400425F RID: 16991
	private int DropIdInternal;

	// Token: 0x04004260 RID: 16992
	private int RoleIdInternal;

	// Token: 0x04004261 RID: 16993
	private int RoleTrialIdInternal;

	// Token: 0x04004262 RID: 16994
	private int RoleGiftConfigIdInternal;
}
