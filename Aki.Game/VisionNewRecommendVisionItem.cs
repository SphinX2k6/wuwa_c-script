using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024E9 RID: 9449
public class VisionNewRecommendVisionItem : UiPanelBase
{
	// Token: 0x06013008 RID: 77832 RVA: 0x004B4B78 File Offset: 0x004B2D78
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

	// Token: 0x06013009 RID: 77833 RVA: 0x004B4D48 File Offset: 0x004B2F48
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendVisionItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendVisionItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601300A RID: 77834 RVA: 0x004B4D8C File Offset: 0x004B2F8C
	[NullableContext(1)]
	public void SetData(VisionNewRecommendVisionItemData data)
	{
		base.TrySetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(data.VisionMonsterId)[0].IconMiddle, base.GetTexture(2), null, null);
		base.GetText(5).SetText(data.Cost.ToString(), true);
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterGroupId);
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
	}

	// Token: 0x0601300B RID: 77835 RVA: 0x004B4E08 File Offset: 0x004B3008
	public void SetToggleState(EToggleState state, bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, fireEvent, false, false);
	}

	// Token: 0x0601300C RID: 77836 RVA: 0x004B4E1A File Offset: 0x004B301A
	private void OnToggleClick(EToggleState _)
	{
		Action onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback();
	}

	// Token: 0x04008F06 RID: 36614
	[Nullable(2)]
	public Action OnSelectedCallback;

	// Token: 0x04008F07 RID: 36615
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A7C RID: 35452
	private enum EComponent
	{
		// Token: 0x0402CF81 RID: 184193
		ToggleItem,
		// Token: 0x0402CF82 RID: 184194
		CircleItem,
		// Token: 0x0402CF83 RID: 184195
		CircleItemTexture,
		// Token: 0x0402CF84 RID: 184196
		QualitySprite,
		// Token: 0x0402CF85 RID: 184197
		CostItem,
		// Token: 0x0402CF86 RID: 184198
		CostNumText,
		// Token: 0x0402CF87 RID: 184199
		PlusItem,
		// Token: 0x0402CF88 RID: 184200
		SuitElementItem,
		// Token: 0x0402CF89 RID: 184201
		RedItem,
		// Token: 0x0402CF8A RID: 184202
		CircleTextureBlackBg,
		// Token: 0x0402CF8B RID: 184203
		AddIconItem,
		// Token: 0x0402CF8C RID: 184204
		AniLight,
		// Token: 0x0402CF8D RID: 184205
		RemoveItem,
		// Token: 0x0402CF8E RID: 184206
		AddIconItem2,
		// Token: 0x0402CF8F RID: 184207
		LevelItem,
		// Token: 0x0402CF90 RID: 184208
		LevelText,
		// Token: 0x0402CF91 RID: 184209
		ItemOccupyPanel,
		// Token: 0x0402CF92 RID: 184210
		ItemWarningIcon
	}
}
