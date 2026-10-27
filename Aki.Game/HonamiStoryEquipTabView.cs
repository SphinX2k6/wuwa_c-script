using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EB9 RID: 7865
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryEquipTabView : UiTabViewBase
{
	// Token: 0x170012E2 RID: 4834
	// (get) Token: 0x0600F201 RID: 61953 RVA: 0x003A4399 File Offset: 0x003A2599
	public HonamiStoryInteractController DragController { get; } = new HonamiStoryInteractController();

	// Token: 0x0600F202 RID: 61954 RVA: 0x003A43A4 File Offset: 0x003A25A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F203 RID: 61955 RVA: 0x003A4450 File Offset: 0x003A2650
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryEquipTabView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryEquipTabView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F204 RID: 61956 RVA: 0x003A4493 File Offset: 0x003A2693
	protected override void OnBeforeShow()
	{
		this.DragController.OnBeforeShow();
	}

	// Token: 0x0600F205 RID: 61957 RVA: 0x003A44A0 File Offset: 0x003A26A0
	private UniTask InitPlayerBackpackPanel()
	{
		HonamiStoryEquipTabView.<InitPlayerBackpackPanel>d__9 <InitPlayerBackpackPanel>d__;
		<InitPlayerBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerBackpackPanel>d__.<>4__this = this;
		<InitPlayerBackpackPanel>d__.<>1__state = -1;
		<InitPlayerBackpackPanel>d__.<>t__builder.Start<HonamiStoryEquipTabView.<InitPlayerBackpackPanel>d__9>(ref <InitPlayerBackpackPanel>d__);
		return <InitPlayerBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F206 RID: 61958 RVA: 0x003A44E4 File Offset: 0x003A26E4
	private UniTask InitBackpackPanel()
	{
		HonamiStoryEquipTabView.<InitBackpackPanel>d__10 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryEquipTabView.<InitBackpackPanel>d__10>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F207 RID: 61959 RVA: 0x003A4528 File Offset: 0x003A2728
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "RolePanel" || a == "Equips" || a == "AddBtn" || a == "UpdateBtn")
		{
			HonamiStoryEquipBackpackPanel equipPanel = this.EquipPanel;
			if (equipPanel == null)
			{
				return null;
			}
			return equipPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			if (!(a == "BtnSell") && !(a == "ToggleSelect") && !(a == "BtnReset"))
			{
				return null;
			}
			HonamiStoryBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return null;
			}
			return backpackPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x04006FD4 RID: 28628
	private HonamiStoryEquipBackpackPanel EquipPanel;

	// Token: 0x04006FD5 RID: 28629
	public HonamiStoryBackpackPanel BackpackPanel;

	// Token: 0x0200849D RID: 33949
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B2AD RID: 176813
		EquipPanel,
		// Token: 0x0402B2AE RID: 176814
		BackpackPanel,
		// Token: 0x0402B2AF RID: 176815
		InteractPanel,
		// Token: 0x0402B2B0 RID: 176816
		AttachPanel
	}
}
