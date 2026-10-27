using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024A0 RID: 9376
[NullableContext(1)]
[Nullable(0)]
public class VisionDetailUnderComponent : UiPanelBase
{
	// Token: 0x06012D30 RID: 77104 RVA: 0x004A58CC File Offset: 0x004A3ACC
	public VisionDetailUnderComponent(UUIItem actor)
	{
		base.CreateThenShowByActor(actor.GetOwner(), null);
	}

	// Token: 0x06012D31 RID: 77105 RVA: 0x004A58E4 File Offset: 0x004A3AE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06012D32 RID: 77106 RVA: 0x004A5940 File Offset: 0x004A3B40
	protected override void OnStart()
	{
		this.RightButtonItem = new ButtonItem(base.GetItem(0));
		this.RightButtonItem.SetFunction(new Action<int>(this.OnRightButton));
		this.LeftButtonItem = new ButtonItem(base.GetItem(1));
		this.LeftButtonItem.SetFunction(new Action<int>(this.OnLeftButton));
		this.EquipRoleAttribute = new EquipRoleAttribute(base.GetItem(2));
	}

	// Token: 0x06012D33 RID: 77107 RVA: 0x004A59B1 File Offset: 0x004A3BB1
	public void RefreshRightButtonText(string textId)
	{
		this.RightButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x06012D34 RID: 77108 RVA: 0x004A59C4 File Offset: 0x004A3BC4
	public void RefreshLeftButtonText(string textId)
	{
		this.LeftButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x06012D35 RID: 77109 RVA: 0x004A59D7 File Offset: 0x004A3BD7
	private void OnRightButton(int _)
	{
		Action onClickRightButton = this.OnClickRightButton;
		if (onClickRightButton == null)
		{
			return;
		}
		onClickRightButton();
	}

	// Token: 0x06012D36 RID: 77110 RVA: 0x004A59E9 File Offset: 0x004A3BE9
	private void OnLeftButton(int _)
	{
		Action onClickLeftButton = this.OnClickLeftButton;
		if (onClickLeftButton == null)
		{
			return;
		}
		onClickLeftButton();
	}

	// Token: 0x06012D37 RID: 77111 RVA: 0x004A59FB File Offset: 0x004A3BFB
	public void SetRightButtonClick(Action call)
	{
		this.OnClickRightButton = call;
	}

	// Token: 0x06012D38 RID: 77112 RVA: 0x004A5A04 File Offset: 0x004A3C04
	public void SetLeftButtonClick(Action call)
	{
		this.OnClickLeftButton = call;
	}

	// Token: 0x06012D39 RID: 77113 RVA: 0x004A5A0D File Offset: 0x004A3C0D
	public void RefreshViewByCompareState(bool ifCompare)
	{
		this.LeftButtonItem.SetActive(!ifCompare);
		this.RightButtonItem.SetActive(!ifCompare);
	}

	// Token: 0x06012D3A RID: 77114 RVA: 0x004A5A2D File Offset: 0x004A3C2D
	public void Update(PhantomBattleData data)
	{
		this.EquipRoleAttribute.SetActive(PhantomBattleController.Instance.CheckIsEquip(data.GetUniqueId()));
		this.EquipRoleAttribute.Update(data);
	}

	// Token: 0x04008DCA RID: 36298
	[Nullable(2)]
	private EquipRoleAttribute EquipRoleAttribute;

	// Token: 0x04008DCB RID: 36299
	[Nullable(2)]
	private ButtonItem RightButtonItem;

	// Token: 0x04008DCC RID: 36300
	[Nullable(2)]
	private ButtonItem LeftButtonItem;

	// Token: 0x04008DCD RID: 36301
	[Nullable(2)]
	private Action OnClickRightButton;

	// Token: 0x04008DCE RID: 36302
	[Nullable(2)]
	private Action OnClickLeftButton;

	// Token: 0x02008A22 RID: 35362
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CDAF RID: 183727
		RightButton,
		// Token: 0x0402CDB0 RID: 183728
		LeftButton,
		// Token: 0x0402CDB1 RID: 183729
		AttributePanel
	}
}
