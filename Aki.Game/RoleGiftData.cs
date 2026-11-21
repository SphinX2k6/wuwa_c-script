using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200096D RID: 2413
[NullableContext(1)]
[Nullable(0)]
public class RoleGiftData : ActivityBaseData
{
	// Token: 0x060069EF RID: 27119 RVA: 0x00210571 File Offset: 0x0020E771
	protected override void OnInit(ActivityData data)
	{
		this.InitConfig();
	}

	// Token: 0x060069F0 RID: 27120 RVA: 0x0021057C File Offset: 0x0020E77C
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

	// Token: 0x060069F1 RID: 27121 RVA: 0x00210628 File Offset: 0x0020E828
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

	// Token: 0x060069F2 RID: 27122 RVA: 0x002108C0 File Offset: 0x0020EAC0
	private static int RoleIdToTrialId(int roleId)
	{
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(roleId);
		if (gachaTextureInfo == null)
		{
			return 0;
		}
		return gachaTextureInfo.GetValueOrDefault().TrialId;
	}

	// Token: 0x060069F3 RID: 27123 RVA: 0x002108F3 File Offset: 0x0020EAF3
	public int GetDropId()
	{
		return this.DropIdInternal;
	}

	// Token: 0x060069F4 RID: 27124 RVA: 0x002108FB File Offset: 0x0020EAFB
	public int GetRoleId()
	{
		return this.RoleIdInternal;
	}

	// Token: 0x060069F5 RID: 27125 RVA: 0x00210903 File Offset: 0x0020EB03
	public int GetRoleTrialId()
	{
		return this.RoleTrialIdInternal;
	}

	// Token: 0x060069F6 RID: 27126 RVA: 0x0021090B File Offset: 0x0020EB0B
	public int GetRoleGiftConfigId()
	{
		return this.RoleGiftConfigIdInternal;
	}

	// Token: 0x060069F7 RID: 27127 RVA: 0x00210913 File Offset: 0x0020EB13
	public void SetHadGetReward(bool hadGet)
	{
		this.RewardHadGet = hadGet;
	}

	// Token: 0x060069F8 RID: 27128 RVA: 0x0021091C File Offset: 0x0020EB1C
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

	// Token: 0x060069F9 RID: 27129 RVA: 0x00210972 File Offset: 0x0020EB72
	public bool GetRewardHadGet()
	{
		return this.RewardHadGet;
	}

	// Token: 0x060069FA RID: 27130 RVA: 0x0021097C File Offset: 0x0020EB7C
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

	// Token: 0x060069FB RID: 27131 RVA: 0x00210A39 File Offset: 0x0020EC39
	public bool NeedSplash()
	{
		return this.CanReceiveReward();
	}

	// Token: 0x060069FC RID: 27132 RVA: 0x00210A41 File Offset: 0x0020EC41
	public override bool GetExDataRedPointShowState()
	{
		return !this.RewardHadGet && base.IsUnLock();
	}

	// Token: 0x060069FD RID: 27133 RVA: 0x00210A53 File Offset: 0x0020EC53
	protected override bool GetExDataFinishShowState()
	{
		return this.RewardHadGet;
	}

	// Token: 0x040042F5 RID: 17141
	private bool RewardHadGet;

	// Token: 0x040042F6 RID: 17142
	private bool ConfigInitialized;

	// Token: 0x040042F7 RID: 17143
	private int DropIdInternal;

	// Token: 0x040042F8 RID: 17144
	private int RoleIdInternal;

	// Token: 0x040042F9 RID: 17145
	private int RoleTrialIdInternal;

	// Token: 0x040042FA RID: 17146
	private int RoleGiftConfigIdInternal;
}
