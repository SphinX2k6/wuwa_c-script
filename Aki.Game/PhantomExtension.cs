using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BCB RID: 7115
[NullableContext(1)]
[Nullable(0)]
public class PhantomExtension : ISlotExtension
{
	// Token: 0x0600D42F RID: 54319 RVA: 0x0030D244 File Offset: 0x0030B444
	public UniTask OnAttach(ISlotMountPoint mount, int position)
	{
		PhantomExtension.<OnAttach>d__2 <OnAttach>d__;
		<OnAttach>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAttach>d__.<>4__this = this;
		<OnAttach>d__.mount = mount;
		<OnAttach>d__.position = position;
		<OnAttach>d__.<>1__state = -1;
		<OnAttach>d__.<>t__builder.Start<PhantomExtension.<OnAttach>d__2>(ref <OnAttach>d__);
		return <OnAttach>d__.<>t__builder.Task;
	}

	// Token: 0x0600D430 RID: 54320 RVA: 0x0030D297 File Offset: 0x0030B497
	public void OnDetach()
	{
		if (this.PhantomComponent == null)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.TowerDefensePhantomChanged, new Action(this.OnPhantomChanged));
		this.PhantomComponent = null;
		this.Mount = null;
	}

	// Token: 0x0600D431 RID: 54321 RVA: 0x0030D2CC File Offset: 0x0030B4CC
	public void OnRefresh(IRoleSlotDisplayData data)
	{
		if (this.PhantomComponent == null || this.Mount == null)
		{
			return;
		}
		int? slotPlayerId = (data.PlayerId > 0) ? new int?(data.PlayerId) : null;
		int num = this.Mount.GetProvider().ResolveSafePlayerId(slotPlayerId);
		int configId = data.ConfigId;
		this.PhantomComponent.PlayerId = num;
		this.PhantomComponent.RoleCfgId = configId;
		string text = TowerDefenseController.Instance.BuildTeamPhantomIconData(num, configId);
		this.PhantomComponent.SetIcon(text, TowerDefenseController.Instance.CheckIsSelf(num));
		int num2 = this.Mount.GetProvider().ResolveSafePlayerId(null);
		this.PhantomComponent.SetRedDotActive(num2 == num && text == null);
	}

	// Token: 0x0600D432 RID: 54322 RVA: 0x0030D394 File Offset: 0x0030B594
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public UUIItem[] QueryGuideItem(string[] configParams)
	{
		if (this.PhantomComponent == null || this.Mount == null)
		{
			return null;
		}
		if (configParams.Length == 0 || !configParams[0].Contains("FirstSelf"))
		{
			return null;
		}
		if (configParams.Length < 2)
		{
			return null;
		}
		UUIItem[] guideUiItemAndUiItemForShowEx = this.PhantomComponent.GetGuideUiItemAndUiItemForShowEx(configParams);
		if (guideUiItemAndUiItemForShowEx == null)
		{
			return null;
		}
		if (configParams[1] == "G")
		{
			UUIItem chooseButtonRoot = this.Mount.GetChooseButtonRoot();
			if (chooseButtonRoot != null)
			{
				guideUiItemAndUiItemForShowEx[1] = chooseButtonRoot;
			}
		}
		return guideUiItemAndUiItemForShowEx;
	}

	// Token: 0x0600D433 RID: 54323 RVA: 0x0030D408 File Offset: 0x0030B608
	private void OnPhantomChanged()
	{
		if (this.PhantomComponent == null || this.Mount == null)
		{
			return;
		}
		int playerId = this.PhantomComponent.PlayerId;
		int roleCfgId = this.PhantomComponent.RoleCfgId;
		string text = TowerDefenseController.Instance.BuildTeamPhantomIconData(playerId, roleCfgId);
		this.PhantomComponent.SetIcon(text, TowerDefenseController.Instance.CheckIsSelf(playerId));
		int num = this.Mount.GetProvider().ResolveSafePlayerId(null);
		this.PhantomComponent.SetRedDotActive(num == playerId && text == null);
	}

	// Token: 0x040060FC RID: 24828
	[Nullable(2)]
	private ISlotMountPoint Mount;

	// Token: 0x040060FD RID: 24829
	[Nullable(2)]
	private PhantomPanel PhantomComponent;
}
