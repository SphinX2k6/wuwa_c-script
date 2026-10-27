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
	// Token: 0x02004AC3 RID: 19139
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterView : UiViewBase
	{
		// Token: 0x0603194D RID: 203085 RVA: 0x00B7F2D3 File Offset: 0x00B7D4D3
		public TrapDefenseMonsterView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603194E RID: 203086 RVA: 0x00B7F2F4 File Offset: 0x00B7D4F4
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

		// Token: 0x0603194F RID: 203087 RVA: 0x00B7F468 File Offset: 0x00B7D668
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMonsterView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMonsterView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031950 RID: 203088 RVA: 0x00B7F4AB File Offset: 0x00B7D6AB
		protected override void OnStart()
		{
			this.InitTab();
		}

		// Token: 0x06031951 RID: 203089 RVA: 0x00B7F4B4 File Offset: 0x00B7D6B4
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

		// Token: 0x06031952 RID: 203090 RVA: 0x00B7F544 File Offset: 0x00B7D744
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

		// Token: 0x06031953 RID: 203091 RVA: 0x00B7F5AB File Offset: 0x00B7D7AB
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06031954 RID: 203092 RVA: 0x00B7F5AD File Offset: 0x00B7D7AD
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06031955 RID: 203093 RVA: 0x00B7F5AF File Offset: 0x00B7D7AF
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06031956 RID: 203094 RVA: 0x00B7F5B1 File Offset: 0x00B7D7B1
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.OnViewClose();
		}

		// Token: 0x06031957 RID: 203095 RVA: 0x00B7F5BE File Offset: 0x00B7D7BE
		protected override void OnAfterDestroy()
		{
		}

		// Token: 0x06031958 RID: 203096 RVA: 0x00B7F5C0 File Offset: 0x00B7D7C0
		public void OnBtnHelp()
		{
			int helpIdMonster = TrapDefenseConfig.Instance.GetHelpIdMonster();
			HelpController.Instance.OpenHelpById(helpIdMonster);
		}

		// Token: 0x06031959 RID: 203097 RVA: 0x00B7F5E3 File Offset: 0x00B7D7E3
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603195A RID: 203098 RVA: 0x00B7F5EC File Offset: 0x00B7D7EC
		public ShipTowerTeamTabItem CreateTabItem([Nullable(2)] UUIItem item, int? index)
		{
			return new ShipTowerTeamTabItem();
		}

		// Token: 0x0603195B RID: 203099 RVA: 0x00B7F5F4 File Offset: 0x00B7D7F4
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

		// Token: 0x0603195C RID: 203100 RVA: 0x00B7F628 File Offset: 0x00B7D828
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

		// Token: 0x0603195D RID: 203101 RVA: 0x00B7F698 File Offset: 0x00B7D898
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

		// Token: 0x0603195E RID: 203102 RVA: 0x00B7F710 File Offset: 0x00B7D910
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

		// Token: 0x0603195F RID: 203103 RVA: 0x00B7F778 File Offset: 0x00B7D978
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

		// Token: 0x06031960 RID: 203104 RVA: 0x00B7F8AC File Offset: 0x00B7DAAC
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

		// Token: 0x06031961 RID: 203105 RVA: 0x00B7F8E9 File Offset: 0x00B7DAE9
		public void SetEmptyInfoVisible(bool visible)
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06031962 RID: 203106 RVA: 0x00B7F8FD File Offset: 0x00B7DAFD
		public TrapDefenseMonsterTypeItem CreateItemMonsterType()
		{
			return new TrapDefenseMonsterTypeItem
			{
				OnSelectMonsterCallBack = new Action<TrapDefenseMonsterData>(this.OnSelectMonsterTypeMonster)
			};
		}

		// Token: 0x06031963 RID: 203107 RVA: 0x00B7F916 File Offset: 0x00B7DB16
		public TrapDefenseMonsterWaveItem CreateItemMonsterWave(TrapDefenseMonsterWaveData data, UUIItem uiItem, int index)
		{
			return new TrapDefenseMonsterWaveItem
			{
				OnSelectMonsterCallBack = new Action<TrapDefenseMonsterData, TrapDefenseMonsterWaveData>(this.OnSelectMonsterWaveMonster)
			};
		}

		// Token: 0x06031964 RID: 203108 RVA: 0x00B7F92F File Offset: 0x00B7DB2F
		public void OnSelectMonsterTypeMonster(TrapDefenseMonsterData data)
		{
			this.PanelMonsterDesc.UpdateData(data);
		}

		// Token: 0x06031965 RID: 203109 RVA: 0x00B7F93D File Offset: 0x00B7DB3D
		public void OnSelectMonsterWaveMonster(TrapDefenseMonsterData data, TrapDefenseMonsterWaveData waveData)
		{
			this.SetWaveSelectMonsterData(waveData, data);
			this.UpdateWaveSelectState();
		}

		// Token: 0x06031966 RID: 203110 RVA: 0x00B7F94D File Offset: 0x00B7DB4D
		public void SetWaveSelectMonsterData(TrapDefenseMonsterWaveData waveData, TrapDefenseMonsterData data)
		{
			this.ViewModel.SetWaveSelectMonsterData(waveData, data);
			this.PanelMonsterDesc.UpdateData(data);
		}

		// Token: 0x06031967 RID: 203111 RVA: 0x00B7F968 File Offset: 0x00B7DB68
		public void UpdateWaveSelectState()
		{
			TrapDefenseMonsterWaveItem[] scrollItemItems = this.ScrollMonsterWaveDynamic.GetScrollItemItems();
			for (int i = 0; i < scrollItemItems.Length; i++)
			{
				scrollItemItems[i].UpdateSelectState();
			}
		}

		// Token: 0x0401A7D8 RID: 108504
		private bool FirstInitWave = true;

		// Token: 0x0401A7D9 RID: 108505
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401A7DA RID: 108506
		public TabComponent<ShipTowerTeamTabItem> TabComponent;

		// Token: 0x0401A7DB RID: 108507
		public List<ITrapDefenseTab<ETrapDefenseMonsterTabType>> TabDataList;

		// Token: 0x0401A7DC RID: 108508
		public GenericScrollViewNew<TrapDefenseMonsterTypeItem, TrapDefenseMonsterTypeData> ScrollMonsterType;

		// Token: 0x0401A7DD RID: 108509
		public DynamicScrollView<TrapDefenseMonsterWaveItem, TrapDefenseMonsterWaveDynamicItem, TrapDefenseMonsterWaveData> ScrollMonsterWaveDynamic;

		// Token: 0x0401A7DE RID: 108510
		public TrapDefenseMonsterDescPanel PanelMonsterDesc;

		// Token: 0x0401A7DF RID: 108511
		public TrapDefenseMonsterViewModel ViewModel = TrapDefenseModel.Instance.ViewModelMonster;

		// Token: 0x0200AC2C RID: 44076
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034511 RID: 214289
			public const int ItemCaption = 0;

			// Token: 0x04034512 RID: 214290
			public const int ItemTabComponent = 1;

			// Token: 0x04034513 RID: 214291
			public const int ItemRootMonsterType = 2;

			// Token: 0x04034514 RID: 214292
			public const int ScrollMonsterType = 3;

			// Token: 0x04034515 RID: 214293
			public const int ItemMonsterType = 4;

			// Token: 0x04034516 RID: 214294
			public const int ItemRootMonsterWave = 5;

			// Token: 0x04034517 RID: 214295
			public const int ScrollMonsterWave = 6;

			// Token: 0x04034518 RID: 214296
			public const int ItemMonsterWave = 7;

			// Token: 0x04034519 RID: 214297
			public const int ItemEmptyInfo = 8;

			// Token: 0x0403451A RID: 214298
			public const int ItemMonsterDesc = 9;
		}
	}
}
