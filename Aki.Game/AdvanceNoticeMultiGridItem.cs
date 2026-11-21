using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000584 RID: 1412
public class AdvanceNoticeMultiGridItem : UiPanelBase
{
	// Token: 0x060043B2 RID: 17330 RVA: 0x00175A9F File Offset: 0x00173C9F
	public AdvanceNoticeMultiGridItem(int advertisingPageInfoId)
	{
		this.AdvertisingPageInfoId = advertisingPageInfoId;
	}

	// Token: 0x060043B3 RID: 17331 RVA: 0x00175ABC File Offset: 0x00173CBC
	protected override void OnRegisterComponent()
	{
		int gridCount = this.GetGridCount();
		for (int i = 0; i < gridCount; i++)
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
		}
	}

	// Token: 0x060043B4 RID: 17332 RVA: 0x00175AF8 File Offset: 0x00173CF8
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeMultiGridItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeMultiGridItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060043B5 RID: 17333 RVA: 0x00175B3C File Offset: 0x00173D3C
	public int GetGridCount()
	{
		return AdvanceNoticeConfig.Instance.GetAdvertisingPageInfoById(this.AdvertisingPageInfoId).GetTabIdArrayArray().Length;
	}

	// Token: 0x060043B6 RID: 17334 RVA: 0x00175B63 File Offset: 0x00173D63
	public void PlayAnim()
	{
		UUIInturnAnimController animControllerComponent = this.AnimControllerComponent;
		if (animControllerComponent == null)
		{
			return;
		}
		animControllerComponent.Play("", -1, false);
	}

	// Token: 0x040034A6 RID: 13478
	[Nullable(1)]
	private readonly List<AdvanceNoticeGridItem> GridItemList = new List<AdvanceNoticeGridItem>();

	// Token: 0x040034A7 RID: 13479
	[Nullable(2)]
	protected UUIInturnAnimController AnimControllerComponent;

	// Token: 0x040034A8 RID: 13480
	public readonly int AdvertisingPageInfoId;
}
