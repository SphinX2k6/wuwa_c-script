using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025BD RID: 9661
public class FightPhotoSettingPanel : FightPhotoTabPanelBase
{
	// Token: 0x06013970 RID: 80240 RVA: 0x004E6054 File Offset: 0x004E4254
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

	// Token: 0x06013971 RID: 80241 RVA: 0x004E60C4 File Offset: 0x004E42C4
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoSettingPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoSettingPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013972 RID: 80242 RVA: 0x004E6108 File Offset: 0x004E4308
	private UniTask InitializeFightPhotoSetup()
	{
		FightPhotoSettingPanel.<InitializeFightPhotoSetup>d__4 <InitializeFightPhotoSetup>d__;
		<InitializeFightPhotoSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFightPhotoSetup>d__.<>4__this = this;
		<InitializeFightPhotoSetup>d__.<>1__state = -1;
		<InitializeFightPhotoSetup>d__.<>t__builder.Start<FightPhotoSettingPanel.<InitializeFightPhotoSetup>d__4>(ref <InitializeFightPhotoSetup>d__);
		return <InitializeFightPhotoSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06013973 RID: 80243 RVA: 0x004E614C File Offset: 0x004E434C
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

	// Token: 0x06013974 RID: 80244 RVA: 0x004E61C4 File Offset: 0x004E43C4
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		foreach (FightPhotoSetupBase fightPhotoSetupBase in this.SetupItemMap.Values)
		{
			fightPhotoSetupBase.Destroy(null);
		}
		this.SetupItemMap.Clear();
	}

	// Token: 0x040093D6 RID: 37846
	[Nullable(1)]
	private readonly Dictionary<int, FightPhotoSetupBase> SetupItemMap = new Dictionary<int, FightPhotoSetupBase>();

	// Token: 0x02008BCB RID: 35787
	private enum EComponents
	{
		// Token: 0x0402D5FD RID: 185853
		Content,
		// Token: 0x0402D5FE RID: 185854
		ItemDropDown,
		// Token: 0x0402D5FF RID: 185855
		ItemSlider,
		// Token: 0x0402D600 RID: 185856
		ItemScroll
	}
}
