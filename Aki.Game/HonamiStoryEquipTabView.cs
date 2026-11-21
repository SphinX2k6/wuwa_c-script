using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200137B RID: 4987
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryEquipTabView : UiTabViewBase
{
	// Token: 0x1700130C RID: 4876
	// (get) Token: 0x0600C620 RID: 50720 RVA: 0x003AFE99 File Offset: 0x003AE099
	public HonamiStoryInteractController DragController { get; } = new HonamiStoryInteractController();

	// Token: 0x0600C621 RID: 50721 RVA: 0x003AFEA4 File Offset: 0x003AE0A4
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

	// Token: 0x0600C622 RID: 50722 RVA: 0x003AFF50 File Offset: 0x003AE150
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryEquipTabView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryEquipTabView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C623 RID: 50723 RVA: 0x003AFF93 File Offset: 0x003AE193
	protected override void OnBeforeShow()
	{
		this.DragController.OnBeforeShow();
	}

	// Token: 0x0600C624 RID: 50724 RVA: 0x003AFFA0 File Offset: 0x003AE1A0
	private UniTask InitPlayerBackpackPanel()
	{
		HonamiStoryEquipTabView.<InitPlayerBackpackPanel>d__9 <InitPlayerBackpackPanel>d__;
		<InitPlayerBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPlayerBackpackPanel>d__.<>4__this = this;
		<InitPlayerBackpackPanel>d__.<>1__state = -1;
		<InitPlayerBackpackPanel>d__.<>t__builder.Start<HonamiStoryEquipTabView.<InitPlayerBackpackPanel>d__9>(ref <InitPlayerBackpackPanel>d__);
		return <InitPlayerBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C625 RID: 50725 RVA: 0x003AFFE4 File Offset: 0x003AE1E4
	private UniTask InitBackpackPanel()
	{
		HonamiStoryEquipTabView.<InitBackpackPanel>d__10 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryEquipTabView.<InitBackpackPanel>d__10>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C626 RID: 50726 RVA: 0x003B0028 File Offset: 0x003AE228
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

	// Token: 0x040070B5 RID: 28853
	private HonamiStoryEquipBackpackPanel EquipPanel;

	// Token: 0x040070B6 RID: 28854
	public HonamiStoryBackpackPanel BackpackPanel;

	// Token: 0x02007622 RID: 30242
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040265D1 RID: 157137
		EquipPanel,
		// Token: 0x040265D2 RID: 157138
		BackpackPanel,
		// Token: 0x040265D3 RID: 157139
		InteractPanel,
		// Token: 0x040265D4 RID: 157140
		AttachPanel
	}
}
