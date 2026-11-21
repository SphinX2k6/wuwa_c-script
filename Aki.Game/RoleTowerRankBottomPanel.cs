using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF3 RID: 7411
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerRankBottomPanel : UiPanelBase
{
	// Token: 0x06012589 RID: 75145 RVA: 0x0056A1CC File Offset: 0x005683CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickRewardPreview))
		};
	}

	// Token: 0x0601258A RID: 75146 RVA: 0x0056A28C File Offset: 0x0056848C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerRankBottomPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerRankBottomPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601258B RID: 75147 RVA: 0x0056A2CF File Offset: 0x005684CF
	public void Refresh(int levelId)
	{
		this.RefreshSelfRank(levelId);
		this.RefreshRewardPreview(levelId);
	}

	// Token: 0x0601258C RID: 75148 RVA: 0x0056A2E0 File Offset: 0x005684E0
	private void RefreshSelfRank(int levelId)
	{
		if (this.SelfRankItem == null)
		{
			return;
		}
		RoleTowerRankData selfRank = RoleTowerModel.Instance.GetSelfRank(levelId);
		this.SelfRankItem.CanGetServerReward = RoleTowerModel.Instance.GetRankCanGetServerReward(levelId);
		this.SelfRankItem.NewRecordTagFilter = delegate()
		{
			Func<int, bool> newRecordTagFilter = this.NewRecordTagFilter;
			return newRecordTagFilter == null || newRecordTagFilter(levelId);
		};
		this.SelfRankItem.Refresh(selfRank ?? new RoleTowerRankData(), false, 0);
	}

	// Token: 0x0601258D RID: 75149 RVA: 0x0056A364 File Offset: 0x00568564
	private void RefreshRewardPreview(int levelId)
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(RoleTowerModel.Instance.GetRankCanGetServerReward(levelId));
		}
		UUITexture texture = base.GetTexture(3);
		if (texture == null)
		{
			return;
		}
		RoleTowerLevel? roleTowerLevel;
		int num = (RoleTowerConfig.Instance.GetLevelById(levelId) != null) ? roleTowerLevel.GetValueOrDefault().RoleTowerRankRewardItemId : 0;
		ItemConfig itemConfig = (num > 0) ? InventoryConfig.Instance.GetItemConfigData(num) : null;
		texture.SetUIActive(itemConfig != null);
		if (itemConfig != null)
		{
			base.SetTextureByPath(itemConfig.IconMiddle ?? string.Empty, texture, null, null);
		}
	}

	// Token: 0x0601258E RID: 75150 RVA: 0x0056A404 File Offset: 0x00568604
	private void OnClickRewardPreview()
	{
		Action onClickRewardPreviewCallback = this.OnClickRewardPreviewCallback;
		if (onClickRewardPreviewCallback == null)
		{
			return;
		}
		onClickRewardPreviewCallback();
	}

	// Token: 0x04009FF6 RID: 40950
	private RoleTowerRankItem SelfRankItem;

	// Token: 0x04009FF7 RID: 40951
	public Action OnClickRewardPreviewCallback;

	// Token: 0x04009FF8 RID: 40952
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleTowerRankData> OnClickRecordDetailCallback;

	// Token: 0x04009FF9 RID: 40953
	public Func<int, bool> NewRecordTagFilter;

	// Token: 0x02008008 RID: 32776
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040296C7 RID: 169671
		public const int TexLeftDecoBg = 0;

		// Token: 0x040296C8 RID: 169672
		public const int SprIcon = 1;

		// Token: 0x040296C9 RID: 169673
		public const int BtnRankRewardPreview = 2;

		// Token: 0x040296CA RID: 169674
		public const int TexRewardIcon = 3;

		// Token: 0x040296CB RID: 169675
		public const int PnlRedDot = 4;

		// Token: 0x040296CC RID: 169676
		public const int UiItemSelfRankItem = 5;
	}
}
