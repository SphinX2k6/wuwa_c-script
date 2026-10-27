using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024E4 RID: 9444
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendLeftPanelView : UiPanelBase
{
	// Token: 0x06012FD3 RID: 77779 RVA: 0x004B3ACC File Offset: 0x004B1CCC
	public VisionNewRecommendLeftPanelView(VisionNewRecommendProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06012FD4 RID: 77780 RVA: 0x004B3ADC File Offset: 0x004B1CDC
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

	// Token: 0x06012FD5 RID: 77781 RVA: 0x004B3BA4 File Offset: 0x004B1DA4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendLeftPanelView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendLeftPanelView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012FD6 RID: 77782 RVA: 0x004B3BE7 File Offset: 0x004B1DE7
	protected override void OnStart()
	{
		this.RefreshRoleInfo();
		this.SelectDefaultFetterItem();
	}

	// Token: 0x06012FD7 RID: 77783 RVA: 0x004B3BF8 File Offset: 0x004B1DF8
	private UniTask InitAllLayouts()
	{
		VisionNewRecommendLeftPanelView.<InitAllLayouts>d__8 <InitAllLayouts>d__;
		<InitAllLayouts>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAllLayouts>d__.<>4__this = this;
		<InitAllLayouts>d__.<>1__state = -1;
		<InitAllLayouts>d__.<>t__builder.Start<VisionNewRecommendLeftPanelView.<InitAllLayouts>d__8>(ref <InitAllLayouts>d__);
		return <InitAllLayouts>d__.<>t__builder.Task;
	}

	// Token: 0x06012FD8 RID: 77784 RVA: 0x004B3C3B File Offset: 0x004B1E3B
	private VisionNewRecommendBranchFetterItem InitSystemRecommendItem()
	{
		VisionNewRecommendBranchFetterItem visionNewRecommendBranchFetterItem = new VisionNewRecommendBranchFetterItem();
		visionNewRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnSystemRecommendItemSelected);
		visionNewRecommendBranchFetterItem.SetRoldId(this.Proxy.CurrentSelectRoleId);
		return visionNewRecommendBranchFetterItem;
	}

	// Token: 0x06012FD9 RID: 77785 RVA: 0x004B3C65 File Offset: 0x004B1E65
	private VisionNewRecommendBranchFetterItem InitUsageRecommendItem()
	{
		VisionNewRecommendBranchFetterItem visionNewRecommendBranchFetterItem = new VisionNewRecommendBranchFetterItem();
		visionNewRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnUsageRecommendItemSelected);
		visionNewRecommendBranchFetterItem.SetRoldId(this.Proxy.CurrentSelectRoleId);
		return visionNewRecommendBranchFetterItem;
	}

	// Token: 0x06012FDA RID: 77786 RVA: 0x004B3C90 File Offset: 0x004B1E90
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

	// Token: 0x06012FDB RID: 77787 RVA: 0x004B3D6C File Offset: 0x004B1F6C
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

	// Token: 0x06012FDC RID: 77788 RVA: 0x004B3E48 File Offset: 0x004B2048
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

	// Token: 0x06012FDD RID: 77789 RVA: 0x004B3F2E File Offset: 0x004B212E
	public void RefreshRoleInfo()
	{
		this.RefreshRoleIcon();
		this.RefreshRoleName();
	}

	// Token: 0x06012FDE RID: 77790 RVA: 0x004B3F3C File Offset: 0x004B213C
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

	// Token: 0x06012FDF RID: 77791 RVA: 0x004B3FB8 File Offset: 0x004B21B8
	private void RefreshRoleIcon()
	{
		RoleSkin? roleSkinConfig = this.GetRoleSkinConfig();
		if (roleSkinConfig == null)
		{
			return;
		}
		string tag = "RoleIcon1";
		string roleSkinConfigParam = ComponentConfig.Instance.GetRoleSkinConfigParam(tag);
		if (roleSkinConfigParam != null && roleSkinConfigParam != "")
		{
			PropertyInfo property = roleSkinConfig.Value.GetType().GetProperty(roleSkinConfigParam);
			if (property != null)
			{
				string text = property.GetValue(roleSkinConfig.Value) as string;
				if (text != null)
				{
					base.SetTextureByPath(text, base.GetTexture(0), null, null);
				}
			}
		}
	}

	// Token: 0x06012FE0 RID: 77792 RVA: 0x004B4050 File Offset: 0x004B2250
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

	// Token: 0x04008EE9 RID: 36585
	private readonly VisionNewRecommendProxy Proxy;

	// Token: 0x04008EEA RID: 36586
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> SystemRecommendLayout;

	// Token: 0x04008EEB RID: 36587
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionNewRecommendBranchFetterItem, VisionFetterRecommendInfo> UsageRecommendLayout;

	// Token: 0x02008A73 RID: 35443
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CF51 RID: 184145
		RoleIcon,
		// Token: 0x0402CF52 RID: 184146
		RoleName,
		// Token: 0x0402CF53 RID: 184147
		UsageRecommendLayout,
		// Token: 0x0402CF54 RID: 184148
		UsageRecommendItem,
		// Token: 0x0402CF55 RID: 184149
		SystemRecommendLayout,
		// Token: 0x0402CF56 RID: 184150
		SystemRecommendItem,
		// Token: 0x0402CF57 RID: 184151
		PnlUsageRecommend,
		// Token: 0x0402CF58 RID: 184152
		PnlSystemRecommend
	}
}
