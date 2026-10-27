using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024A2 RID: 9378
[NullableContext(2)]
[Nullable(0)]
public class VisionEquipmentDragItem : UiPanelBase
{
	// Token: 0x06012D3E RID: 77118 RVA: 0x004A5C0B File Offset: 0x004A3E0B
	[NullableContext(1)]
	public VisionEquipmentDragItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06012D3F RID: 77119 RVA: 0x004A5C1C File Offset: 0x004A3E1C
	public UniTask Init()
	{
		VisionEquipmentDragItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionEquipmentDragItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06012D40 RID: 77120 RVA: 0x004A5C60 File Offset: 0x004A3E60
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

	// Token: 0x06012D41 RID: 77121 RVA: 0x004A5CD0 File Offset: 0x004A3ED0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionEquipmentDragItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionEquipmentDragItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012D42 RID: 77122 RVA: 0x004A5D13 File Offset: 0x004A3F13
	protected override void OnStart()
	{
	}

	// Token: 0x06012D43 RID: 77123 RVA: 0x004A5D15 File Offset: 0x004A3F15
	public UUIDraggableComponent GetDragComponent()
	{
		return base.GetDraggable(2);
	}

	// Token: 0x06012D44 RID: 77124 RVA: 0x004A5D20 File Offset: 0x004A3F20
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

	// Token: 0x04008DCF RID: 36303
	private readonly UUIItem SourceItem;

	// Token: 0x04008DD0 RID: 36304
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A24 RID: 35364
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CDB6 RID: 183734
		BgSprite,
		// Token: 0x0402CDB7 RID: 183735
		Texture,
		// Token: 0x0402CDB8 RID: 183736
		DragComponent,
		// Token: 0x0402CDB9 RID: 183737
		SuitElementItem
	}
}
