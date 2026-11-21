using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001987 RID: 6535
[NullableContext(1)]
[Nullable(0)]
public class VisionDetailUnderComponent : UiPanelBase
{
	// Token: 0x060101F1 RID: 66033 RVA: 0x004B33D4 File Offset: 0x004B15D4
	public VisionDetailUnderComponent(UUIItem actor)
	{
		base.CreateThenShowByActor(actor.GetOwner(), null);
	}

	// Token: 0x060101F2 RID: 66034 RVA: 0x004B33EC File Offset: 0x004B15EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060101F3 RID: 66035 RVA: 0x004B3448 File Offset: 0x004B1648
	protected override void OnStart()
	{
		this.RightButtonItem = new ButtonItem(base.GetItem(0));
		this.RightButtonItem.SetFunction(new Action<int>(this.OnRightButton));
		this.LeftButtonItem = new ButtonItem(base.GetItem(1));
		this.LeftButtonItem.SetFunction(new Action<int>(this.OnLeftButton));
		this.EquipRoleAttribute = new EquipRoleAttribute(base.GetItem(2));
	}

	// Token: 0x060101F4 RID: 66036 RVA: 0x004B34B9 File Offset: 0x004B16B9
	public void RefreshRightButtonText(string textId)
	{
		this.RightButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x060101F5 RID: 66037 RVA: 0x004B34CC File Offset: 0x004B16CC
	public void RefreshLeftButtonText(string textId)
	{
		this.LeftButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x060101F6 RID: 66038 RVA: 0x004B34DF File Offset: 0x004B16DF
	private void OnRightButton(int _)
	{
		Action onClickRightButton = this.OnClickRightButton;
		if (onClickRightButton == null)
		{
			return;
		}
		onClickRightButton();
	}

	// Token: 0x060101F7 RID: 66039 RVA: 0x004B34F1 File Offset: 0x004B16F1
	private void OnLeftButton(int _)
	{
		Action onClickLeftButton = this.OnClickLeftButton;
		if (onClickLeftButton == null)
		{
			return;
		}
		onClickLeftButton();
	}

	// Token: 0x060101F8 RID: 66040 RVA: 0x004B3503 File Offset: 0x004B1703
	public void SetRightButtonClick(Action call)
	{
		this.OnClickRightButton = call;
	}

	// Token: 0x060101F9 RID: 66041 RVA: 0x004B350C File Offset: 0x004B170C
	public void SetLeftButtonClick(Action call)
	{
		this.OnClickLeftButton = call;
	}

	// Token: 0x060101FA RID: 66042 RVA: 0x004B3515 File Offset: 0x004B1715
	public void RefreshViewByCompareState(bool ifCompare)
	{
		this.LeftButtonItem.SetActive(!ifCompare);
		this.RightButtonItem.SetActive(!ifCompare);
	}

	// Token: 0x060101FB RID: 66043 RVA: 0x004B3535 File Offset: 0x004B1735
	public void Update(PhantomBattleData data)
	{
		this.EquipRoleAttribute.SetActive(PhantomBattleController.Instance.CheckIsEquip(data.GetUniqueId()));
		this.EquipRoleAttribute.Update(data);
	}

	// Token: 0x04008F14 RID: 36628
	[Nullable(2)]
	private EquipRoleAttribute EquipRoleAttribute;

	// Token: 0x04008F15 RID: 36629
	[Nullable(2)]
	private ButtonItem RightButtonItem;

	// Token: 0x04008F16 RID: 36630
	[Nullable(2)]
	private ButtonItem LeftButtonItem;

	// Token: 0x04008F17 RID: 36631
	[Nullable(2)]
	private Action OnClickRightButton;

	// Token: 0x04008F18 RID: 36632
	[Nullable(2)]
	private Action OnClickLeftButton;

	// Token: 0x02007BAC RID: 31660
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040280CF RID: 164047
		RightButton,
		// Token: 0x040280D0 RID: 164048
		LeftButton,
		// Token: 0x040280D1 RID: 164049
		AttributePanel
	}
}
