using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051B5 RID: 20917
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipQuickSelectLevelGirdItemTitleData : MultiTemplateGridDataBase<RhythmShipQuickSelectLevelData, RhythmShipQuickSelectLevelGirdItemTitle>
	{
		// Token: 0x060342CF RID: 213711 RVA: 0x00E995C2 File Offset: 0x00E977C2
		public RhythmShipQuickSelectLevelGirdItemTitleData(RhythmShipQuickSelectLevelData data)
		{
			base.Data = data;
		}

		// Token: 0x060342D0 RID: 213712 RVA: 0x00E995D1 File Offset: 0x00E977D1
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x060342D1 RID: 213713 RVA: 0x00E995D4 File Offset: 0x00E977D4
		public override RhythmShipQuickSelectLevelGirdItemTitle CreateProxy()
		{
			return new RhythmShipQuickSelectLevelGirdItemTitle();
		}

		// Token: 0x0200AE29 RID: 44585
		[NullableContext(2)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class RhythmShipQuickSelectLevelGirdItemLevel : SyncGridProxyAbstract<RhythmShipQuickSelectLevelData>
		{
			// Token: 0x06046E84 RID: 290436 RVA: 0x0156C111 File Offset: 0x0156A311
			protected override void OnRegisterComponent()
			{
				this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
				{
					new ValueTuple<int, Type>(0, typeof(UUIItem))
				};
			}

			// Token: 0x06046E85 RID: 290437 RVA: 0x0156C134 File Offset: 0x0156A334
			protected override void OnStart()
			{
				this.RhythmShipQuickSelectLevelGirdItemLevelPanel = new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevelPanel();
				this.RhythmShipQuickSelectLevelGirdItemLevelPanel.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
				this.RhythmShipQuickSelectLevelGirdItemLevelPanel.OnClickButtonCallBack = this.OnClickButtonCallBack;
			}

			// Token: 0x06046E86 RID: 290438 RVA: 0x0156C16A File Offset: 0x0156A36A
			[NullableContext(1)]
			public override void Refresh(RhythmShipQuickSelectLevelData data)
			{
				RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevelPanel rhythmShipQuickSelectLevelGirdItemLevelPanel = this.RhythmShipQuickSelectLevelGirdItemLevelPanel;
				if (rhythmShipQuickSelectLevelGirdItemLevelPanel == null)
				{
					return;
				}
				rhythmShipQuickSelectLevelGirdItemLevelPanel.RefreshPanelByLevelId(data.LevelConfig);
			}

			// Token: 0x04035CFB RID: 220411
			public Action<int> OnClickButtonCallBack;

			// Token: 0x04035CFC RID: 220412
			private RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevelPanel RhythmShipQuickSelectLevelGirdItemLevelPanel;
		}

		// Token: 0x0200AE2A RID: 44586
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public class RhythmShipQuickSelectLevelGirdItemLevelData : MultiTemplateGridDataBase<RhythmShipQuickSelectLevelData, RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevel>
		{
			// Token: 0x06046E88 RID: 290440 RVA: 0x0156C18A File Offset: 0x0156A38A
			public RhythmShipQuickSelectLevelGirdItemLevelData(RhythmShipQuickSelectLevelData data)
			{
				base.Data = data;
			}

			// Token: 0x06046E89 RID: 290441 RVA: 0x0156C199 File Offset: 0x0156A399
			public override int GetTemplateIndex()
			{
				return 1;
			}

			// Token: 0x06046E8A RID: 290442 RVA: 0x0156C19C File Offset: 0x0156A39C
			public override RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevel CreateProxy()
			{
				return new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevel
				{
					OnClickButtonCallBack = this.OnClickButtonCallBack
				};
			}

			// Token: 0x04035CFD RID: 220413
			[Nullable(2)]
			public Action<int> OnClickButtonCallBack;
		}

		// Token: 0x0200AE2B RID: 44587
		[NullableContext(0)]
		public class RhythmShipQuickSelectLevelGirdItemLevelPanel : UiPanelBase
		{
			// Token: 0x06046E8B RID: 290443 RVA: 0x0156C1B0 File Offset: 0x0156A3B0
			protected override void OnRegisterComponent()
			{
				this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
				{
					new ValueTuple<int, Type>(0, typeof(UUITexture)),
					new ValueTuple<int, Type>(1, typeof(UUIArtText)),
					new ValueTuple<int, Type>(2, typeof(UUIItem)),
					new ValueTuple<int, Type>(3, typeof(UUIItem)),
					new ValueTuple<int, Type>(4, typeof(UUIItem)),
					new ValueTuple<int, Type>(5, typeof(UUIText)),
					new ValueTuple<int, Type>(6, typeof(UUIText)),
					new ValueTuple<int, Type>(7, typeof(UUIText)),
					new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
					new ValueTuple<int, Type>(9, typeof(UUIItem))
				};
				this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
				{
					new ValueTuple<int, Delegate>(8, new Action(this.OnClickButton))
				};
			}

			// Token: 0x06046E8C RID: 290444 RVA: 0x0156C2C8 File Offset: 0x0156A4C8
			protected override void OnStart()
			{
				RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem rhythmShipQuickSelectStarItem = new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem();
				rhythmShipQuickSelectStarItem.CreateThenShowByActor(base.GetItem(2).GetOwner(), null);
				RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem rhythmShipQuickSelectStarItem2 = new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem();
				rhythmShipQuickSelectStarItem2.CreateThenShowByActor(base.GetItem(3).GetOwner(), null);
				RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem rhythmShipQuickSelectStarItem3 = new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem();
				rhythmShipQuickSelectStarItem3.CreateThenShowByActor(base.GetItem(4).GetOwner(), null);
				this.StarItemList.AddRange(new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem[]
				{
					rhythmShipQuickSelectStarItem,
					rhythmShipQuickSelectStarItem2,
					rhythmShipQuickSelectStarItem3
				});
			}

			// Token: 0x06046E8D RID: 290445 RVA: 0x0156C340 File Offset: 0x0156A540
			public void RefreshPanelByLevelId(int levelId)
			{
				this.LevelId = levelId;
				RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(levelId);
				if (rhythmShipLevelById == null)
				{
					return;
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), rhythmShipLevelById.Value.Name, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), rhythmShipLevelById.Value.DesName, Array.Empty<object>());
				base.SetTextureByPath(rhythmShipLevelById.Value.IconTexture, base.GetTexture(0), null, null);
				base.GetText(7).SetText(rhythmShipLevelById.Value.TimeText, true);
				base.GetArtText(1).SetText("0" + rhythmShipLevelById.Value.SortNumber.ToString());
				if (RhythmShipModel.Instance.ActivityData == null)
				{
					return;
				}
				List<int> list;
				RhythmShipModel.Instance.LevelSubLevelInfoMap.TryGetValue(this.LevelId, out list);
				list = (list ?? new List<int>());
				Dictionary<int, RhythmSubLevelPb> subLevelInfoMapByLevelId = RhythmShipModel.Instance.GetSubLevelInfoMapByLevelId(levelId);
				for (int i = 0; i < this.StarItemList.Count; i++)
				{
					RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem rhythmShipQuickSelectStarItem = this.StarItemList[i];
					bool flag = i < list.Count;
					rhythmShipQuickSelectStarItem.SetUiActive(flag);
					if (flag)
					{
						RhythmSubLevelPb rhythmSubLevelPb = null;
						if (subLevelInfoMapByLevelId != null)
						{
							subLevelInfoMapByLevelId.TryGetValue(list[i], out rhythmSubLevelPb);
						}
						bool light = rhythmSubLevelPb != null && rhythmSubLevelPb.Cleared;
						rhythmShipQuickSelectStarItem.SetLight(light);
					}
				}
				bool levelIsUnlock = RhythmShipModel.Instance.GetLevelIsUnlock(this.LevelId);
				base.GetItem(9).SetUIActive(!levelIsUnlock);
			}

			// Token: 0x06046E8E RID: 290446 RVA: 0x0156C4FA File Offset: 0x0156A6FA
			private void OnClickButton()
			{
				Action<int> onClickButtonCallBack = this.OnClickButtonCallBack;
				if (onClickButtonCallBack == null)
				{
					return;
				}
				onClickButtonCallBack(this.LevelId);
			}

			// Token: 0x04035CFE RID: 220414
			[Nullable(2)]
			public Action<int> OnClickButtonCallBack;

			// Token: 0x04035CFF RID: 220415
			private int LevelId;

			// Token: 0x04035D00 RID: 220416
			[Nullable(1)]
			private readonly List<RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem> StarItemList = new List<RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem>();
		}

		// Token: 0x0200AE2C RID: 44588
		[NullableContext(0)]
		private class RhythmShipQuickSelectStarItem : UiPanelBase
		{
			// Token: 0x06046E90 RID: 290448 RVA: 0x0156C525 File Offset: 0x0156A725
			protected override void OnRegisterComponent()
			{
				this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
				{
					new ValueTuple<int, Type>(1, typeof(UUIItem))
				};
			}

			// Token: 0x06046E91 RID: 290449 RVA: 0x0156C548 File Offset: 0x0156A748
			public void SetLight(bool value)
			{
				base.GetItem(1).SetUIActive(value);
			}
		}
	}
}
