using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019D0 RID: 6608
public class VisionNewRecommendVisionItem : UiPanelBase
{
	// Token: 0x060104C7 RID: 66759 RVA: 0x004C2824 File Offset: 0x004C0A24
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
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060104C8 RID: 66760 RVA: 0x004C29F4 File Offset: 0x004C0BF4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendVisionItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendVisionItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060104C9 RID: 66761 RVA: 0x004C2A38 File Offset: 0x004C0C38
	[NullableContext(1)]
	public void SetData(VisionNewRecommendVisionItemData data)
	{
		base.TrySetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(data.VisionMonsterId)[0].IconMiddle, base.GetTexture(2), null, null);
		base.GetText(5).SetText(data.Cost.ToString(), true);
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterGroupId);
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x060104CA RID: 66762 RVA: 0x004C2AB4 File Offset: 0x004C0CB4
	public void SetToggleState(EToggleState state, bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, fireEvent, false, false);
	}

	// Token: 0x060104CB RID: 66763 RVA: 0x004C2AC6 File Offset: 0x004C0CC6
	private void OnToggleClick(EToggleState _)
	{
		Action onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback();
	}

	// Token: 0x04009050 RID: 36944
	[Nullable(2)]
	public Action OnSelectedCallback;

	// Token: 0x04009051 RID: 36945
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007C04 RID: 31748
	private enum EComponent
	{
		// Token: 0x04028299 RID: 164505
		ToggleItem,
		// Token: 0x0402829A RID: 164506
		CircleItem,
		// Token: 0x0402829B RID: 164507
		CircleItemTexture,
		// Token: 0x0402829C RID: 164508
		QualitySprite,
		// Token: 0x0402829D RID: 164509
		CostItem,
		// Token: 0x0402829E RID: 164510
		CostNumText,
		// Token: 0x0402829F RID: 164511
		PlusItem,
		// Token: 0x040282A0 RID: 164512
		SuitElementItem,
		// Token: 0x040282A1 RID: 164513
		RedItem,
		// Token: 0x040282A2 RID: 164514
		CircleTextureBlackBg,
		// Token: 0x040282A3 RID: 164515
		AddIconItem,
		// Token: 0x040282A4 RID: 164516
		AniLight,
		// Token: 0x040282A5 RID: 164517
		RemoveItem,
		// Token: 0x040282A6 RID: 164518
		AddIconItem2,
		// Token: 0x040282A7 RID: 164519
		LevelItem,
		// Token: 0x040282A8 RID: 164520
		LevelText,
		// Token: 0x040282A9 RID: 164521
		ItemOccupyPanel,
		// Token: 0x040282AA RID: 164522
		ItemWarningIcon
	}
}
