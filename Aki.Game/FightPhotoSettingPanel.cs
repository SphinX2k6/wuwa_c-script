using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AA8 RID: 6824
public class FightPhotoSettingPanel : FightPhotoTabPanelBase
{
	// Token: 0x06010E50 RID: 69200 RVA: 0x004F4C54 File Offset: 0x004F2E54
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06010E51 RID: 69201 RVA: 0x004F4CC4 File Offset: 0x004F2EC4
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoSettingPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoSettingPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010E52 RID: 69202 RVA: 0x004F4D08 File Offset: 0x004F2F08
	private UniTask InitializeFightPhotoSetup()
	{
		FightPhotoSettingPanel.<InitializeFightPhotoSetup>d__4 <InitializeFightPhotoSetup>d__;
		<InitializeFightPhotoSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFightPhotoSetup>d__.<>4__this = this;
		<InitializeFightPhotoSetup>d__.<>1__state = -1;
		<InitializeFightPhotoSetup>d__.<>t__builder.Start<FightPhotoSettingPanel.<InitializeFightPhotoSetup>d__4>(ref <InitializeFightPhotoSetup>d__);
		return <InitializeFightPhotoSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06010E53 RID: 69203 RVA: 0x004F4D4C File Offset: 0x004F2F4C
	[NullableContext(1)]
	private UniTask NewSetupItem(int configId, int uiType, UUIItem contentItem, UUIItem itemDropDown, UUIItem itemSlider, UUIItem itemScroll)
	{
		FightPhotoSettingPanel.<NewSetupItem>d__5 <NewSetupItem>d__;
		<NewSetupItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewSetupItem>d__.<>4__this = this;
		<NewSetupItem>d__.configId = configId;
		<NewSetupItem>d__.uiType = uiType;
		<NewSetupItem>d__.contentItem = contentItem;
		<NewSetupItem>d__.itemDropDown = itemDropDown;
		<NewSetupItem>d__.itemSlider = itemSlider;
		<NewSetupItem>d__.itemScroll = itemScroll;
		<NewSetupItem>d__.<>1__state = -1;
		<NewSetupItem>d__.<>t__builder.Start<FightPhotoSettingPanel.<NewSetupItem>d__5>(ref <NewSetupItem>d__);
		return <NewSetupItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010E54 RID: 69204 RVA: 0x004F4DC4 File Offset: 0x004F2FC4
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		foreach (FightPhotoSetupBase fightPhotoSetupBase in this.SetupItemMap.Values)
		{
			fightPhotoSetupBase.Destroy(null);
		}
		this.SetupItemMap.Clear();
	}

	// Token: 0x0400952C RID: 38188
	[Nullable(1)]
	private readonly Dictionary<int, FightPhotoSetupBase> SetupItemMap = new Dictionary<int, FightPhotoSetupBase>();

	// Token: 0x02007D53 RID: 32083
	private enum EComponents
	{
		// Token: 0x04028912 RID: 166162
		Content,
		// Token: 0x04028913 RID: 166163
		ItemDropDown,
		// Token: 0x04028914 RID: 166164
		ItemSlider,
		// Token: 0x04028915 RID: 166165
		ItemScroll
	}
}
