using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006237 RID: 25143
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RhythmShipQuickSelectLevelGirdItemTitleData : MultiTemplateGridDataBase<RhythmShipQuickSelectLevelData, RhythmShipQuickSelectLevelGirdItemTitle>
	{
		// Token: 0x0603F60E RID: 259598 RVA: 0x00F52666 File Offset: 0x00F50866
		public RhythmShipQuickSelectLevelGirdItemTitleData(RhythmShipQuickSelectLevelData data)
		{
			base.Data = data;
		}

		// Token: 0x0603F60F RID: 259599 RVA: 0x00F52675 File Offset: 0x00F50875
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603F610 RID: 259600 RVA: 0x00F52678 File Offset: 0x00F50878
		public override RhythmShipQuickSelectLevelGirdItemTitle CreateProxy()
		{
			return new RhythmShipQuickSelectLevelGirdItemTitle();
		}

		// Token: 0x0200C442 RID: 50242
		[NullableContext(2)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class RhythmShipQuickSelectLevelGirdItemLevel : SyncGridProxyAbstract<RhythmShipQuickSelectLevelData>
		{
			// Token: 0x0605099C RID: 330140 RVA: 0x015B4425 File Offset: 0x015B2625
			protected override void OnRegisterComponent()
			{
				this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
				{
					new ValueTuple<int, Type>(0, typeof(UUIItem))
				};
			}

			// Token: 0x0605099D RID: 330141 RVA: 0x015B4448 File Offset: 0x015B2648
			protected override void OnStart()
			{
				this.RhythmShipQuickSelectLevelGirdItemLevelPanel = new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevelPanel();
				this.RhythmShipQuickSelectLevelGirdItemLevelPanel.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
				this.RhythmShipQuickSelectLevelGirdItemLevelPanel.OnClickButtonCallBack = this.OnClickButtonCallBack;
			}

			// Token: 0x0605099E RID: 330142 RVA: 0x015B447E File Offset: 0x015B267E
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

			// Token: 0x0403B399 RID: 242585
			public Action<int> OnClickButtonCallBack;

			// Token: 0x0403B39A RID: 242586
			private RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevelPanel RhythmShipQuickSelectLevelGirdItemLevelPanel;
		}

		// Token: 0x0200C443 RID: 50243
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public class RhythmShipQuickSelectLevelGirdItemLevelData : MultiTemplateGridDataBase<RhythmShipQuickSelectLevelData, RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevel>
		{
			// Token: 0x060509A0 RID: 330144 RVA: 0x015B449E File Offset: 0x015B269E
			public RhythmShipQuickSelectLevelGirdItemLevelData(RhythmShipQuickSelectLevelData data)
			{
				base.Data = data;
			}

			// Token: 0x060509A1 RID: 330145 RVA: 0x015B44AD File Offset: 0x015B26AD
			public override int GetTemplateIndex()
			{
				return 1;
			}

			// Token: 0x060509A2 RID: 330146 RVA: 0x015B44B0 File Offset: 0x015B26B0
			public override RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevel CreateProxy()
			{
				return new RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectLevelGirdItemLevel
				{
					OnClickButtonCallBack = this.OnClickButtonCallBack
				};
			}

			// Token: 0x0403B39B RID: 242587
			[Nullable(2)]
			public Action<int> OnClickButtonCallBack;
		}

		// Token: 0x0200C444 RID: 50244
		[NullableContext(0)]
		public class RhythmShipQuickSelectLevelGirdItemLevelPanel : UiPanelBase
		{
			// Token: 0x060509A3 RID: 330147 RVA: 0x015B44C4 File Offset: 0x015B26C4
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

			// Token: 0x060509A4 RID: 330148 RVA: 0x015B45DC File Offset: 0x015B27DC
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

			// Token: 0x060509A5 RID: 330149 RVA: 0x015B4654 File Offset: 0x015B2854
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

			// Token: 0x060509A6 RID: 330150 RVA: 0x015B480E File Offset: 0x015B2A0E
			private void OnClickButton()
			{
				Action<int> onClickButtonCallBack = this.OnClickButtonCallBack;
				if (onClickButtonCallBack == null)
				{
					return;
				}
				onClickButtonCallBack(this.LevelId);
			}

			// Token: 0x0403B39C RID: 242588
			[Nullable(2)]
			public Action<int> OnClickButtonCallBack;

			// Token: 0x0403B39D RID: 242589
			private int LevelId;

			// Token: 0x0403B39E RID: 242590
			[Nullable(1)]
			private readonly List<RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem> StarItemList = new List<RhythmShipQuickSelectLevelGirdItemTitleData.RhythmShipQuickSelectStarItem>();
		}

		// Token: 0x0200C445 RID: 50245
		[NullableContext(0)]
		private class RhythmShipQuickSelectStarItem : UiPanelBase
		{
			// Token: 0x060509A8 RID: 330152 RVA: 0x015B4839 File Offset: 0x015B2A39
			protected override void OnRegisterComponent()
			{
				this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
				{
					new ValueTuple<int, Type>(1, typeof(UUIItem))
				};
			}

			// Token: 0x060509A9 RID: 330153 RVA: 0x015B485C File Offset: 0x015B2A5C
			public void SetLight(bool value)
			{
				base.GetItem(1).SetUIActive(value);
			}
		}
	}
}
