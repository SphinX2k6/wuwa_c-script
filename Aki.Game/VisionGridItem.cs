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

// Token: 0x02000C36 RID: 3126
public class VisionGridItem : GridProxyAbstract<int>
{
	// Token: 0x060082B5 RID: 33461 RVA: 0x00282475 File Offset: 0x00280675
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x060082B6 RID: 33462 RVA: 0x00282498 File Offset: 0x00280698
	protected override UniTask OnBeforeStartAsync()
	{
		VisionGridItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionGridItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060082B7 RID: 33463 RVA: 0x002824DC File Offset: 0x002806DC
	private UniTask CreateItemGrid()
	{
		VisionGridItem.<CreateItemGrid>d__4 <CreateItemGrid>d__;
		<CreateItemGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateItemGrid>d__.<>4__this = this;
		<CreateItemGrid>d__.<>1__state = -1;
		<CreateItemGrid>d__.<>t__builder.Start<VisionGridItem.<CreateItemGrid>d__4>(ref <CreateItemGrid>d__);
		return <CreateItemGrid>d__.<>t__builder.Task;
	}

	// Token: 0x060082B8 RID: 33464 RVA: 0x00282520 File Offset: 0x00280720
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

	// Token: 0x060082B9 RID: 33465 RVA: 0x002825DE File Offset: 0x002807DE
	public override void Refresh(int itemId, bool isSelected, int gridIndex)
	{
		this.RefreshPrivate(itemId);
	}

	// Token: 0x060082BA RID: 33466 RVA: 0x002825E7 File Offset: 0x002807E7
	public void RefreshByData(int itemId)
	{
		this.RefreshPrivate(itemId);
	}

	// Token: 0x04005007 RID: 20487
	[Nullable(2)]
	private MediumItemGrid ItemGrid;

	// Token: 0x02006F0C RID: 28428
	private class EComponentDefine
	{
		// Token: 0x040244D9 RID: 148697
		public const int ItemGrid = 0;
	}
}
