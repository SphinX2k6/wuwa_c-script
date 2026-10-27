using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200177D RID: 6013
public class VisionGridItem : GridProxyAbstract<int>
{
	// Token: 0x0600AECE RID: 44750 RVA: 0x00277FB1 File Offset: 0x002761B1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600AECF RID: 44751 RVA: 0x00277FD4 File Offset: 0x002761D4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionGridItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionGridItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AED0 RID: 44752 RVA: 0x00278018 File Offset: 0x00276218
	private UniTask CreateItemGrid()
	{
		VisionGridItem.<CreateItemGrid>d__4 <CreateItemGrid>d__;
		<CreateItemGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateItemGrid>d__.<>4__this = this;
		<CreateItemGrid>d__.<>1__state = -1;
		<CreateItemGrid>d__.<>t__builder.Start<VisionGridItem.<CreateItemGrid>d__4>(ref <CreateItemGrid>d__);
		return <CreateItemGrid>d__.<>t__builder.Task;
	}

	// Token: 0x0600AED1 RID: 44753 RVA: 0x0027805C File Offset: 0x0027625C
	private void RefreshPrivate(int itemId)
	{
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(itemId);
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(phantomItemById.Value.MonsterId);
		MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(calabashDevelopRewardByMonsterId.Value.MonsterInfoId);
		InventoryConfig instance = InventoryConfig.Instance;
		ItemConfig itemConfig = (instance != null) ? instance.GetItemConfigData(itemId) : null;
		string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(itemConfig.QualityId);
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = itemId,
			ItemConfigId = new int?(itemId),
			IconPath = monsterInfoConfig.Value.Icon,
			QualityIcon = phantomQualityBgSprite
		};
		this.ItemGrid.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x0600AED2 RID: 44754 RVA: 0x0027811A File Offset: 0x0027631A
	public override void Refresh(int itemId, bool isSelected, int gridIndex)
	{
		this.RefreshPrivate(itemId);
	}

	// Token: 0x0600AED3 RID: 44755 RVA: 0x00278123 File Offset: 0x00276323
	public void RefreshByData(int itemId)
	{
		this.RefreshPrivate(itemId);
	}

	// Token: 0x04004F5D RID: 20317
	[Nullable(2)]
	private MediumItemGrid ItemGrid;

	// Token: 0x02007D86 RID: 32134
	private class EComponentDefine
	{
		// Token: 0x040291AE RID: 168366
		public const int ItemGrid = 0;
	}
}
