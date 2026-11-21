using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019CB RID: 6603
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendLeftPanelView : UiPanelBase
{
	// Token: 0x06010492 RID: 66706 RVA: 0x004C168C File Offset: 0x004BF88C
	public VisionNewRecommendLeftPanelView(VisionNewRecommendProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06010493 RID: 66707 RVA: 0x004C169C File Offset: 0x004BF89C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x06010494 RID: 66708 RVA: 0x004C1764 File Offset: 0x004BF964
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendLeftPanelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendLeftPanelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010495 RID: 66709 RVA: 0x004C17A7 File Offset: 0x004BF9A7
	protected override void OnStart()
	{
		this.RefreshRoleInfo();
		this.SelectDefaultFetterItem();
	}

	// Token: 0x06010496 RID: 66710 RVA: 0x004C17B8 File Offset: 0x004BF9B8
	private UniTask InitAllLayouts()
	{
		VisionNewRecommendLeftPanelView.<InitAllLayouts>d__8 <InitAllLayouts>d__;
		<InitAllLayouts>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAllLayouts>d__.<>4__this = this;
		<InitAllLayouts>d__.<>1__state = -1;
		<InitAllLayouts>d__.<>t__builder.Start<VisionNewRecommendLeftPanelView.<InitAllLayouts>d__8>(ref <InitAllLayouts>d__);
		return <InitAllLayouts>d__.<>t__builder.Task;
	}

	// Token: 0x06010497 RID: 66711 RVA: 0x004C17FB File Offset: 0x004BF9FB
	private VisionNewRecommendBranchFetterItem InitSystemRecommendItem()
	{
		VisionNewRecommendBranchFetterItem visionNewRecommendBranchFetterItem = new VisionNewRecommendBranchFetterItem();
		visionNewRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnSystemRecommendItemSelected);
		visionNewRecommendBranchFetterItem.SetRoldId(this.Proxy.CurrentSelectRoleId);
		return visionNewRecommendBranchFetterItem;
	}

	// Token: 0x06010498 RID: 66712 RVA: 0x004C1825 File Offset: 0x004BFA25
	private VisionNewRecommendBranchFetterItem InitUsageRecommendItem()
	{
		VisionNewRecommendBranchFetterItem visionNewRecommendBranchFetterItem = new VisionNewRecommendBranchFetterItem();
		visionNewRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnUsageRecommendItemSelected);
		visionNewRecommendBranchFetterItem.SetRoldId(this.Proxy.CurrentSelectRoleId);
		return visionNewRecommendBranchFetterItem;
	}

	// Token: 0x06010499 RID: 66713 RVA: 0x004C1850 File Offset: 0x004BFA50
	private void OnSystemRecommendItemSelected(int index)
	{
		GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout = this.SystemRecommendLayout;
		int? num = (systemRecommendLayout != null) ? new int?(systemRecommendLayout.GetSelectedGridIndex()) : null;
		if (index == num.GetValueOrDefault() & num != null)
		{
			return;
		}
		List<VisionFetterRecommendInfo> systemRecommendInfoList = this.Proxy.GetSystemRecommendInfoList();
		VisionFetterRecommendInfo visionFetterRecommendInfo = (systemRecommendInfoList != null && index >= 0 && index < systemRecommendInfoList.Count) ? systemRecommendInfoList[index] : null;
		if (visionFetterRecommendInfo == null)
		{
			return;
		}
		GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout = this.UsageRecommendLayout;
		if (usageRecommendLayout != null)
		{
			usageRecommendLayout.DeselectCurrentGridProxy();
		}
		GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout2 = this.SystemRecommendLayout;
		if (systemRecommendLayout2 != null)
		{
			systemRecommendLayout2.SelectGridProxy(index, false);
		}
		this.Proxy.CurrentSelectFetterRecommendInfo = visionFetterRecommendInfo;
		Action<Action> refreshSelectedRecommendDetail = this.Proxy.RefreshSelectedRecommendDetail;
		if (refreshSelectedRecommendDetail != null)
		{
			refreshSelectedRecommendDetail(null);
		}
		UiBehaviorLevelSequence mainViewSequence = this.Proxy.MainViewSequence;
		if (mainViewSequence == null)
		{
			return;
		}
		mainViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x0601049A RID: 66714 RVA: 0x004C192C File Offset: 0x004BFB2C
	private void OnUsageRecommendItemSelected(int index)
	{
		GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout = this.UsageRecommendLayout;
		int? num = (usageRecommendLayout != null) ? new int?(usageRecommendLayout.GetSelectedGridIndex()) : null;
		if (index == num.GetValueOrDefault() & num != null)
		{
			return;
		}
		List<VisionFetterRecommendInfo> usageRecommendInfoList = this.Proxy.GetUsageRecommendInfoList();
		VisionFetterRecommendInfo visionFetterRecommendInfo = (usageRecommendInfoList != null && index >= 0 && index < usageRecommendInfoList.Count) ? usageRecommendInfoList[index] : null;
		if (visionFetterRecommendInfo == null)
		{
			return;
		}
		GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout = this.SystemRecommendLayout;
		if (systemRecommendLayout != null)
		{
			systemRecommendLayout.DeselectCurrentGridProxy();
		}
		GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout2 = this.UsageRecommendLayout;
		if (usageRecommendLayout2 != null)
		{
			usageRecommendLayout2.SelectGridProxy(index, false);
		}
		this.Proxy.CurrentSelectFetterRecommendInfo = visionFetterRecommendInfo;
		Action<Action> refreshSelectedRecommendDetail = this.Proxy.RefreshSelectedRecommendDetail;
		if (refreshSelectedRecommendDetail != null)
		{
			refreshSelectedRecommendDetail(null);
		}
		UiBehaviorLevelSequence mainViewSequence = this.Proxy.MainViewSequence;
		if (mainViewSequence == null)
		{
			return;
		}
		mainViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x0601049B RID: 66715 RVA: 0x004C1A08 File Offset: 0x004BFC08
	public void SelectDefaultFetterItem()
	{
		if (this.Proxy.IsFromRoleDev)
		{
			this.Proxy.IsFromRoleDevFirstSelect = true;
			int num = this.Proxy.GetSelectedPlanIdCallBack(this.Proxy.CurrentSelectRoleId);
			GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout = this.UsageRecommendLayout;
			if (((usageRecommendLayout != null) ? usageRecommendLayout.GetLayoutItemByKey(num) : null) == null)
			{
				GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout = this.SystemRecommendLayout;
				if (((systemRecommendLayout != null) ? systemRecommendLayout.GetLayoutItemByKey(num) : null) != null)
				{
					GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout2 = this.SystemRecommendLayout;
					if (systemRecommendLayout2 == null)
					{
						return;
					}
					systemRecommendLayout2.SelectGridProxyByKey(num, true);
				}
				return;
			}
			GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout2 = this.UsageRecommendLayout;
			if (usageRecommendLayout2 == null)
			{
				return;
			}
			usageRecommendLayout2.SelectGridProxyByKey(num, true);
			return;
		}
		else
		{
			List<VisionFetterRecommendInfo> usageRecommendInfoList = this.Proxy.GetUsageRecommendInfoList();
			if (usageRecommendInfoList != null && usageRecommendInfoList.Count > 0)
			{
				GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout3 = this.UsageRecommendLayout;
				if (usageRecommendLayout3 == null)
				{
					return;
				}
				usageRecommendLayout3.SelectGridProxy(0, true);
				return;
			}
			else
			{
				GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout3 = this.SystemRecommendLayout;
				if (systemRecommendLayout3 == null)
				{
					return;
				}
				systemRecommendLayout3.SelectGridProxy(0, true);
				return;
			}
		}
	}

	// Token: 0x0601049C RID: 66716 RVA: 0x004C1AEE File Offset: 0x004BFCEE
	public void RefreshRoleInfo()
	{
		this.RefreshRoleIcon();
		this.RefreshRoleName();
	}

	// Token: 0x0601049D RID: 66717 RVA: 0x004C1AFC File Offset: 0x004BFCFC
	private RoleSkin? GetRoleSkinConfig()
	{
		RoleSkinModel instance = RoleSkinModel.Instance;
		RoleSkinData roleSkinData = (instance != null) ? instance.GetRoleSkinDataByRoleId(this.Proxy.CurrentSelectRoleId) : null;
		if (roleSkinData != null)
		{
			return new RoleSkin?(roleSkinData.GetRoleSkinConfig());
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.Proxy.CurrentSelectRoleId);
		if (roleConfig == null)
		{
			return null;
		}
		return SkinConfig.Instance.GetRoleSkinConfig(roleConfig.Value.SkinId);
	}

	// Token: 0x0601049E RID: 66718 RVA: 0x004C1B78 File Offset: 0x004BFD78
	private void RefreshRoleIcon()
	{
		RoleSkin? roleSkinConfig = this.GetRoleSkinConfig();
		if (roleSkinConfig != null)
		{
			RoleSkin valueOrDefault = roleSkinConfig.GetValueOrDefault();
			string tag = "RoleIcon1";
			string roleSkinConfigParam = ComponentConfig.Instance.GetRoleSkinConfigParam(tag);
			string path;
			if (roleSkinConfigParam != null && roleSkinConfigParam != "" && valueOrDefault.TryGetMember(roleSkinConfigParam, out path))
			{
				base.SetTextureByPath(path, base.GetTexture(0), null, null);
			}
			return;
		}
	}

	// Token: 0x0601049F RID: 66719 RVA: 0x004C1BE8 File Offset: 0x004BFDE8
	private void RefreshRoleName()
	{
		RoleSkin? roleSkinConfig = this.GetRoleSkinConfig();
		if (roleSkinConfig == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(RoleConfig.Instance.GetRoleName(roleSkinConfig.Value.Name), true);
	}

	// Token: 0x04009033 RID: 36915
	private readonly VisionNewRecommendProxy Proxy;

	// Token: 0x04009034 RID: 36916
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> SystemRecommendLayout;

	// Token: 0x04009035 RID: 36917
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> UsageRecommendLayout;

	// Token: 0x02007BFB RID: 31739
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402826A RID: 164458
		RoleIcon,
		// Token: 0x0402826B RID: 164459
		RoleName,
		// Token: 0x0402826C RID: 164460
		UsageRecommendLayout,
		// Token: 0x0402826D RID: 164461
		UsageRecommendItem,
		// Token: 0x0402826E RID: 164462
		SystemRecommendLayout,
		// Token: 0x0402826F RID: 164463
		SystemRecommendItem,
		// Token: 0x04028270 RID: 164464
		PnlUsageRecommend,
		// Token: 0x04028271 RID: 164465
		PnlSystemRecommend
	}
}
