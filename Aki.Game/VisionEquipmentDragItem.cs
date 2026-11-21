using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001989 RID: 6537
[NullableContext(2)]
[Nullable(0)]
public class VisionEquipmentDragItem : UiPanelBase
{
	// Token: 0x060101FF RID: 66047 RVA: 0x004B36E5 File Offset: 0x004B18E5
	[NullableContext(1)]
	public VisionEquipmentDragItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06010200 RID: 66048 RVA: 0x004B36F4 File Offset: 0x004B18F4
	public UniTask Init()
	{
		VisionEquipmentDragItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionEquipmentDragItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06010201 RID: 66049 RVA: 0x004B3738 File Offset: 0x004B1938
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06010202 RID: 66050 RVA: 0x004B37A8 File Offset: 0x004B19A8
	protected override UniTask OnBeforeStartAsync()
	{
		VisionEquipmentDragItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionEquipmentDragItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010203 RID: 66051 RVA: 0x004B37EB File Offset: 0x004B19EB
	protected override void OnStart()
	{
	}

	// Token: 0x06010204 RID: 66052 RVA: 0x004B37ED File Offset: 0x004B19ED
	public UUIDraggableComponent GetDragComponent()
	{
		return base.GetDraggable(2);
	}

	// Token: 0x06010205 RID: 66053 RVA: 0x004B37F8 File Offset: 0x004B19F8
	[NullableContext(1)]
	public void UpdateItem(PhantomDataBase data)
	{
		int quality = data.GetQuality();
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(quality);
		PhantomFetterGroup fetterGroupConfig = data.GetFetterGroupConfig();
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupConfig));
		this.SetSpriteByPath(phantomQualityBgSprite, base.GetSprite(0), false, null, null);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.GetConfigId(true));
		base.SetTextureByPath(itemConfigData.IconMiddle, base.GetTexture(1), null, null);
	}

	// Token: 0x04008F19 RID: 36633
	private readonly UUIItem SourceItem;

	// Token: 0x04008F1A RID: 36634
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007BAE RID: 31662
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040280D6 RID: 164054
		BgSprite,
		// Token: 0x040280D7 RID: 164055
		Texture,
		// Token: 0x040280D8 RID: 164056
		DragComponent,
		// Token: 0x040280D9 RID: 164057
		SuitElementItem
	}
}
