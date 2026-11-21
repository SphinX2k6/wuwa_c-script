using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A6B RID: 14955
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterView : UiViewBase
	{
		// Token: 0x060266DD RID: 157405 RVA: 0x00AC3287 File Offset: 0x00AC1487
		public TrapDefenseMonsterView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060266DE RID: 157406 RVA: 0x00AC32A8 File Offset: 0x00AC14A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060266DF RID: 157407 RVA: 0x00AC341C File Offset: 0x00AC161C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMonsterView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMonsterView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060266E0 RID: 157408 RVA: 0x00AC345F File Offset: 0x00AC165F
		protected override void OnStart()
		{
			this.InitTab();
		}

		// Token: 0x060266E1 RID: 157409 RVA: 0x00AC3468 File Offset: 0x00AC1668
		public void InitTab()
		{
			foreach (KeyValuePair<int, ShipTowerTeamTabItem> keyValuePair in this.TabComponent.GetTabItemMap())
			{
				int num;
				ShipTowerTeamTabItem shipTowerTeamTabItem;
				keyValuePair.Deconstruct(out num, out shipTowerTeamTabItem);
				int index = num;
				ShipTowerTeamTabItem shipTowerTeamTabItem2 = shipTowerTeamTabItem;
				shipTowerTeamTabItem2.UpdateName(this.TabDataList[index].TabNameKey);
				shipTowerTeamTabItem2.UpdateRedDotVisible(false);
			}
			this.TabComponent.SelectToggleByIndex(this.GetJumpTabIndex(), true, true);
		}

		// Token: 0x060266E2 RID: 157410 RVA: 0x00AC34F8 File Offset: 0x00AC16F8
		public int GetJumpTabIndex()
		{
			ETrapDefenseMonsterTabType? jumpTabType = this.ViewModel.JumpTabType;
			if (jumpTabType != null)
			{
				ETrapDefenseMonsterTabType? jumpTabType3 = jumpTabType;
				ETrapDefenseMonsterTabType etrapDefenseMonsterTabType = ETrapDefenseMonsterTabType.MonsterType;
				if (!(jumpTabType3.GetValueOrDefault() == etrapDefenseMonsterTabType & jumpTabType3 != null))
				{
					return this.TabDataList.FindIndex(delegate(ITrapDefenseTab<ETrapDefenseMonsterTabType> tab)
					{
						ETrapDefenseMonsterTabType tabType = tab.TabType;
						ETrapDefenseMonsterTabType? jumpTabType2 = jumpTabType;
						return tabType == jumpTabType2.GetValueOrDefault() & jumpTabType2 != null;
					});
				}
			}
			return 0;
		}

		// Token: 0x060266E3 RID: 157411 RVA: 0x00AC355F File Offset: 0x00AC175F
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x060266E4 RID: 157412 RVA: 0x00AC3561 File Offset: 0x00AC1761
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x060266E5 RID: 157413 RVA: 0x00AC3563 File Offset: 0x00AC1763
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060266E6 RID: 157414 RVA: 0x00AC3565 File Offset: 0x00AC1765
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.OnViewClose();
		}

		// Token: 0x060266E7 RID: 157415 RVA: 0x00AC3572 File Offset: 0x00AC1772
		protected override void OnAfterDestroy()
		{
		}

		// Token: 0x060266E8 RID: 157416 RVA: 0x00AC3574 File Offset: 0x00AC1774
		public void OnBtnHelp()
		{
			int helpIdMonster = TrapDefenseConfig.Instance.GetHelpIdMonster();
			HelpController.Instance.OpenHelpById(helpIdMonster);
		}

		// Token: 0x060266E9 RID: 157417 RVA: 0x00AC3597 File Offset: 0x00AC1797
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060266EA RID: 157418 RVA: 0x00AC35A0 File Offset: 0x00AC17A0
		public ShipTowerTeamTabItem CreateTabItem([Nullable(2)] UUIItem item, int? index)
		{
			return new ShipTowerTeamTabItem();
		}

		// Token: 0x060266EB RID: 157419 RVA: 0x00AC35A8 File Offset: 0x00AC17A8
		public void OnClickTabItem(int index)
		{
			ETrapDefenseMonsterTabType tabType = this.TabDataList[index].TabType;
			if (tabType == ETrapDefenseMonsterTabType.MonsterType)
			{
				this.ShowMonsterType();
				return;
			}
			if (tabType != ETrapDefenseMonsterTabType.MonsterWave)
			{
				return;
			}
			this.ShowMonsterWaveDynamic();
		}

		// Token: 0x060266EC RID: 157420 RVA: 0x00AC35DC File Offset: 0x00AC17DC
		public void SetTabItemContentShow(int childType)
		{
			foreach (int num in new List<int>
			{
				2,
				5
			})
			{
				UUIItem item = base.GetItem(num);
				if (item != null)
				{
					item.SetUIActive(childType == num);
				}
			}
		}

		// Token: 0x060266ED RID: 157421 RVA: 0x00AC364C File Offset: 0x00AC184C
		public void ShowMonsterType()
		{
			this.SetTabItemContentShow(2);
			int lastSelectIndex = this.ScrollMonsterType.GetSelectedIndex();
			List<TrapDefenseMonsterTypeData> monsterTypeDataList = this.ViewModel.GetMonsterTypeDataList(true);
			this.ScrollMonsterType.RefreshByData(monsterTypeDataList, delegate
			{
				this.ScrollMonsterType.SelectGridProxy(Math.Max(lastSelectIndex, 0), false);
			}, true);
			bool flag = monsterTypeDataList.Count > 0;
			this.SetEmptyInfoVisible(!flag);
			this.PanelMonsterDesc.SetActive(flag);
		}

		// Token: 0x060266EE RID: 157422 RVA: 0x00AC36C4 File Offset: 0x00AC18C4
		public void ShowMonsterWaveDynamic()
		{
			this.ViewModel.GetMonsterTypeDataList(false);
			this.SetTabItemContentShow(5);
			List<TrapDefenseMonsterWaveData> monsterWaveDataList = this.ViewModel.GetMonsterWaveDataList();
			this.ScrollMonsterWaveDynamic.RefreshByData(monsterWaveDataList.ToArray(), true, false);
			this.ScrollToCheckDynamic(monsterWaveDataList);
			bool flag = monsterWaveDataList.Count > 0;
			this.SetEmptyInfoVisible(!flag);
			this.PanelMonsterDesc.SetActive(flag);
		}

		// Token: 0x060266EF RID: 157423 RVA: 0x00AC372C File Offset: 0x00AC192C
		public void ScrollToCheckDynamic(List<TrapDefenseMonsterWaveData> dataList)
		{
			if (this.FirstInitWave)
			{
				this.FirstInitWave = false;
				TrapDefenseMonsterWaveData curWave = dataList.Find((TrapDefenseMonsterWaveData wave) => wave.IsInTheCurrentWave());
				if (curWave != null)
				{
					int index = dataList.FindIndex((TrapDefenseMonsterWaveData wave) => wave == curWave);
					this.LateScrollToDynamic(index);
					this.SetWaveSelectMonsterData(curWave, curWave.GetMonsterDataList()[0]);
					return;
				}
			}
			if (this.ViewModel.IsSameLevel(null) && this.ViewModel.Model.BattleData.GetBatch() > dataList.Count)
			{
				int index2 = dataList.Count - 1;
				this.LateScrollToDynamic(index2);
				this.SetWaveSelectMonsterData(dataList[index2], dataList[index2].GetMonsterDataList()[0]);
			}
			if (this.ViewModel.WaveSelectMonsterData != null)
			{
				this.PanelMonsterDesc.UpdateData(this.ViewModel.WaveSelectMonsterData);
				return;
			}
			this.SetWaveSelectMonsterData(dataList[0], dataList[0].GetMonsterDataList()[0]);
		}

		// Token: 0x060266F0 RID: 157424 RVA: 0x00AC3860 File Offset: 0x00AC1A60
		public void LateScrollToDynamic(int index)
		{
			DynamicScrollView<TrapDefenseMonsterWaveItem, TrapDefenseMonsterWaveDynamicItem, TrapDefenseMonsterWaveData> scrollMonsterWaveDynamic = this.ScrollMonsterWaveDynamic;
			if (scrollMonsterWaveDynamic == null)
			{
				return;
			}
			scrollMonsterWaveDynamic.BindLateUpdate(delegate(float _)
			{
				DynamicScrollView<TrapDefenseMonsterWaveItem, TrapDefenseMonsterWaveDynamicItem, TrapDefenseMonsterWaveData> scrollMonsterWaveDynamic2 = this.ScrollMonsterWaveDynamic;
				if (scrollMonsterWaveDynamic2 != null)
				{
					scrollMonsterWaveDynamic2.ScrollToItemIndex(index, true, false);
				}
				DynamicScrollView<TrapDefenseMonsterWaveItem, TrapDefenseMonsterWaveDynamicItem, TrapDefenseMonsterWaveData> scrollMonsterWaveDynamic3 = this.ScrollMonsterWaveDynamic;
				if (scrollMonsterWaveDynamic3 == null)
				{
					return;
				}
				scrollMonsterWaveDynamic3.UnBindLateUpdate();
			});
		}

		// Token: 0x060266F1 RID: 157425 RVA: 0x00AC389D File Offset: 0x00AC1A9D
		public void SetEmptyInfoVisible(bool visible)
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x060266F2 RID: 157426 RVA: 0x00AC38B1 File Offset: 0x00AC1AB1
		public TrapDefenseMonsterTypeItem CreateItemMonsterType()
		{
			return new TrapDefenseMonsterTypeItem
			{
				OnSelectMonsterCallBack = new Action<TrapDefenseMonsterData>(this.OnSelectMonsterTypeMonster)
			};
		}

		// Token: 0x060266F3 RID: 157427 RVA: 0x00AC38CA File Offset: 0x00AC1ACA
		public TrapDefenseMonsterWaveItem CreateItemMonsterWave(TrapDefenseMonsterWaveData data, UUIItem uiItem, int index)
		{
			return new TrapDefenseMonsterWaveItem
			{
				OnSelectMonsterCallBack = new Action<TrapDefenseMonsterData, TrapDefenseMonsterWaveData>(this.OnSelectMonsterWaveMonster)
			};
		}

		// Token: 0x060266F4 RID: 157428 RVA: 0x00AC38E3 File Offset: 0x00AC1AE3
		public void OnSelectMonsterTypeMonster(TrapDefenseMonsterData data)
		{
			this.PanelMonsterDesc.UpdateData(data);
		}

		// Token: 0x060266F5 RID: 157429 RVA: 0x00AC38F1 File Offset: 0x00AC1AF1
		public void OnSelectMonsterWaveMonster(TrapDefenseMonsterData data, TrapDefenseMonsterWaveData waveData)
		{
			this.SetWaveSelectMonsterData(waveData, data);
			this.UpdateWaveSelectState();
		}

		// Token: 0x060266F6 RID: 157430 RVA: 0x00AC3901 File Offset: 0x00AC1B01
		public void SetWaveSelectMonsterData(TrapDefenseMonsterWaveData waveData, TrapDefenseMonsterData data)
		{
			this.ViewModel.SetWaveSelectMonsterData(waveData, data);
			this.PanelMonsterDesc.UpdateData(data);
		}

		// Token: 0x060266F7 RID: 157431 RVA: 0x00AC391C File Offset: 0x00AC1B1C
		public void UpdateWaveSelectState()
		{
			TrapDefenseMonsterWaveItem[] scrollItemItems = this.ScrollMonsterWaveDynamic.GetScrollItemItems();
			for (int i = 0; i < scrollItemItems.Length; i++)
			{
				scrollItemItems[i].UpdateSelectState();
			}
		}

		// Token: 0x0401512A RID: 86314
		private bool FirstInitWave = true;

		// Token: 0x0401512B RID: 86315
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401512C RID: 86316
		public TabComponent<ShipTowerTeamTabItem> TabComponent;

		// Token: 0x0401512D RID: 86317
		public List<ITrapDefenseTab<ETrapDefenseMonsterTabType>> TabDataList;

		// Token: 0x0401512E RID: 86318
		public GenericScrollViewNew<TrapDefenseMonsterTypeItem, TrapDefenseMonsterTypeData> ScrollMonsterType;

		// Token: 0x0401512F RID: 86319
		public DynamicScrollView<TrapDefenseMonsterWaveItem, TrapDefenseMonsterWaveDynamicItem, TrapDefenseMonsterWaveData> ScrollMonsterWaveDynamic;

		// Token: 0x04015130 RID: 86320
		public TrapDefenseMonsterDescPanel PanelMonsterDesc;

		// Token: 0x04015131 RID: 86321
		public TrapDefenseMonsterViewModel ViewModel = TrapDefenseModel.Instance.ViewModelMonster;

		// Token: 0x0200964C RID: 38476
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EEC2 RID: 192194
			public const int ItemCaption = 0;

			// Token: 0x0402EEC3 RID: 192195
			public const int ItemTabComponent = 1;

			// Token: 0x0402EEC4 RID: 192196
			public const int ItemRootMonsterType = 2;

			// Token: 0x0402EEC5 RID: 192197
			public const int ScrollMonsterType = 3;

			// Token: 0x0402EEC6 RID: 192198
			public const int ItemMonsterType = 4;

			// Token: 0x0402EEC7 RID: 192199
			public const int ItemRootMonsterWave = 5;

			// Token: 0x0402EEC8 RID: 192200
			public const int ScrollMonsterWave = 6;

			// Token: 0x0402EEC9 RID: 192201
			public const int ItemMonsterWave = 7;

			// Token: 0x0402EECA RID: 192202
			public const int ItemEmptyInfo = 8;

			// Token: 0x0402EECB RID: 192203
			public const int ItemMonsterDesc = 9;
		}
	}
}
