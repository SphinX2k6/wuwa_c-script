using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.TabView.VisionSubView;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D0F RID: 7439
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerVisionHeadItem : RoleVisionCommonItem
{
	// Token: 0x17001B79 RID: 7033
	// (get) Token: 0x060126A9 RID: 75433 RVA: 0x00571402 File Offset: 0x0056F602
	// (set) Token: 0x060126AA RID: 75434 RVA: 0x0057140A File Offset: 0x0056F60A
	public int Slot { get; private set; } = -1;

	// Token: 0x060126AB RID: 75435 RVA: 0x00571413 File Offset: 0x0056F613
	public void SetSlot(int slot)
	{
		this.Slot = slot;
	}

	// Token: 0x060126AC RID: 75436 RVA: 0x0057141C File Offset: 0x0056F61C
	[NullableContext(1)]
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x060126AD RID: 75437 RVA: 0x00571425 File Offset: 0x0056F625
	public void SetKeepChecked(bool keepChecked)
	{
		this.KeepChecked = keepChecked;
	}

	// Token: 0x060126AE RID: 75438 RVA: 0x0057142E File Offset: 0x0056F62E
	public void SetChecked(bool isChecked)
	{
		if (this.GetSelectToggle() == null)
		{
			return;
		}
		base.SetToggleState(isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false);
	}

	// Token: 0x060126AF RID: 75439 RVA: 0x00571448 File Offset: 0x0056F648
	[NullableContext(1)]
	public RoleTowerVisionHeadItem(UUIItem mountItem, string resourceId, EPhantomItemIndex index, [Nullable(2)] RoleDataBase roleData) : base(mountItem, index, roleData, false, false, ERoleViewSource.Normal)
	{
		this.MountItem = mountItem;
		this.ResourceId = resourceId;
	}

	// Token: 0x060126B0 RID: 75440 RVA: 0x0057146C File Offset: 0x0056F66C
	public UniTask InitByResource()
	{
		RoleTowerVisionHeadItem.<InitByResource>d__14 <InitByResource>d__;
		<InitByResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitByResource>d__.<>4__this = this;
		<InitByResource>d__.<>1__state = -1;
		<InitByResource>d__.<>t__builder.Start<RoleTowerVisionHeadItem.<InitByResource>d__14>(ref <InitByResource>d__);
		return <InitByResource>d__.<>t__builder.Task;
	}

	// Token: 0x060126B1 RID: 75441 RVA: 0x005714B0 File Offset: 0x0056F6B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060126B2 RID: 75442 RVA: 0x00571680 File Offset: 0x0056F880
	private void OnClickToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			if (this.KeepChecked)
			{
				UUIExtendToggle selectToggle = this.GetSelectToggle();
				if (selectToggle == null)
				{
					return;
				}
				selectToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			return;
		}
		if (!this.KeepChecked)
		{
			UUIExtendToggle selectToggle2 = this.GetSelectToggle();
			if (selectToggle2 != null)
			{
				selectToggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		Action<int> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this.Slot);
	}

	// Token: 0x060126B3 RID: 75443 RVA: 0x005716E1 File Offset: 0x0056F8E1
	protected override UUITexture GetVisionTextureComponent()
	{
		return base.GetTexture(2);
	}

	// Token: 0x060126B4 RID: 75444 RVA: 0x005716EA File Offset: 0x0056F8EA
	protected override UUISprite GetVisionQualitySprite()
	{
		return base.GetSprite(3);
	}

	// Token: 0x060126B5 RID: 75445 RVA: 0x005716F3 File Offset: 0x0056F8F3
	protected override UUIItem GetVisionCostItem()
	{
		return base.GetItem(4);
	}

	// Token: 0x060126B6 RID: 75446 RVA: 0x005716FC File Offset: 0x0056F8FC
	protected override UUIText GetVisionCostText()
	{
		return base.GetText(5);
	}

	// Token: 0x060126B7 RID: 75447 RVA: 0x00571705 File Offset: 0x0056F905
	public override UUIDraggableComponent GetDragComponent()
	{
		return base.GetDraggable(1);
	}

	// Token: 0x060126B8 RID: 75448 RVA: 0x0057170E File Offset: 0x0056F90E
	protected override UUIExtendToggle GetSelectToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x060126B9 RID: 75449 RVA: 0x00571717 File Offset: 0x0056F917
	protected override UUIItem GetPlusItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x060126BA RID: 75450 RVA: 0x00571720 File Offset: 0x0056F920
	protected override void OnUpdateItem(PhantomDataBase data)
	{
		bool flag = data != null;
		base.SetUiActive(true);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(data.GetCost().ToString(), true);
			}
		}
		UUISprite sprite = base.GetSprite(3);
		if (sprite != null)
		{
			string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(flag ? data.GetQuality() : 0);
			this.SetSpriteByPath(phantomQualityBgSprite, sprite, false, null, null);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (flag)
		{
			UUIItem item3 = base.GetItem(14);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			UUIText text2 = base.GetText(15);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetPhantomLevel());
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		else
		{
			UUIItem item4 = base.GetItem(14);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
		}
		UUIItem item5 = base.GetItem(10);
		if (item5 != null)
		{
			item5.SetUIActive(false);
		}
		UUIItem item6 = base.GetItem(13);
		if (item6 != null)
		{
			item6.SetUIActive(false);
		}
		UUIItem item7 = base.GetItem(12);
		if (item7 != null)
		{
			item7.SetUIActive(false);
		}
		UUIItem item8 = base.GetItem(8);
		if (item8 != null)
		{
			item8.SetUIActive(false);
		}
		UUIItem item9 = base.GetItem(7);
		if (item9 != null)
		{
			item9.SetUIActive(false);
		}
		UUIItem item10 = base.GetItem(11);
		if (item10 != null)
		{
			item10.SetUIActive(false);
		}
		UUIItem item11 = base.GetItem(16);
		if (item11 != null)
		{
			item11.SetUIActive(false);
		}
		UUIItem item12 = base.GetItem(17);
		if (item12 == null)
		{
			return;
		}
		item12.SetUIActive(false);
	}

	// Token: 0x0400A06D RID: 41069
	[Nullable(1)]
	private readonly string ResourceId;

	// Token: 0x0400A06E RID: 41070
	[Nullable(1)]
	private readonly UUIItem MountItem;

	// Token: 0x0400A06F RID: 41071
	private Action<int> ClickCallback;

	// Token: 0x0400A071 RID: 41073
	private bool KeepChecked;

	// Token: 0x02008049 RID: 32841
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029821 RID: 170017
		ToggleItem,
		// Token: 0x04029822 RID: 170018
		CircleItem,
		// Token: 0x04029823 RID: 170019
		CircleItemTexture,
		// Token: 0x04029824 RID: 170020
		QualitySprite,
		// Token: 0x04029825 RID: 170021
		CostItem,
		// Token: 0x04029826 RID: 170022
		CostNumText,
		// Token: 0x04029827 RID: 170023
		PlusItem,
		// Token: 0x04029828 RID: 170024
		SuitElementItem,
		// Token: 0x04029829 RID: 170025
		RedItem,
		// Token: 0x0402982A RID: 170026
		CircleTextureBlackBg,
		// Token: 0x0402982B RID: 170027
		AddIconItem,
		// Token: 0x0402982C RID: 170028
		AniLight,
		// Token: 0x0402982D RID: 170029
		RemoveItem,
		// Token: 0x0402982E RID: 170030
		AddIconItem2,
		// Token: 0x0402982F RID: 170031
		LevelItem,
		// Token: 0x04029830 RID: 170032
		LevelText,
		// Token: 0x04029831 RID: 170033
		ItemOccupyPanel,
		// Token: 0x04029832 RID: 170034
		ItemWarningIcon
	}
}
