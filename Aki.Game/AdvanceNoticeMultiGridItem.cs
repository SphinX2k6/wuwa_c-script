using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010D0 RID: 4304
public class AdvanceNoticeMultiGridItem : UiPanelBase
{
	// Token: 0x0600701C RID: 28700 RVA: 0x0016D0E3 File Offset: 0x0016B2E3
	public AdvanceNoticeMultiGridItem(int advertisingPageInfoId)
	{
		this.AdvertisingPageInfoId = advertisingPageInfoId;
	}

	// Token: 0x0600701D RID: 28701 RVA: 0x0016D100 File Offset: 0x0016B300
	protected override void OnRegisterComponent()
	{
		int gridCount = this.GetGridCount();
		for (int i = 0; i < gridCount; i++)
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
		}
	}

	// Token: 0x0600701E RID: 28702 RVA: 0x0016D13C File Offset: 0x0016B33C
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeMultiGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeMultiGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600701F RID: 28703 RVA: 0x0016D180 File Offset: 0x0016B380
	public int GetGridCount()
	{
		return AdvanceNoticeConfig.Instance.GetAdvertisingPageInfoById(this.AdvertisingPageInfoId).GetTabIdArrayArray().Length;
	}

	// Token: 0x06007020 RID: 28704 RVA: 0x0016D1A7 File Offset: 0x0016B3A7
	public void PlayAnim()
	{
		UUIInturnAnimController animControllerComponent = this.AnimControllerComponent;
		if (animControllerComponent == null)
		{
			return;
		}
		animControllerComponent.Play("", -1, false);
	}

	// Token: 0x0400340D RID: 13325
	[Nullable(1)]
	private readonly List<AdvanceNoticeGridItem> GridItemList = new List<AdvanceNoticeGridItem>();

	// Token: 0x0400340E RID: 13326
	[Nullable(2)]
	protected UUIInturnAnimController AnimControllerComponent;

	// Token: 0x0400340F RID: 13327
	public readonly int AdvertisingPageInfoId;
}
