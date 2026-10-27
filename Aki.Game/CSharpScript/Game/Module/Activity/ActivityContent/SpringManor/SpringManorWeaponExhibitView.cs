using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006054 RID: 24660
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorWeaponExhibitView : UiViewBase
	{
		// Token: 0x0603E656 RID: 255574 RVA: 0x00F11F68 File Offset: 0x00F10168
		public SpringManorWeaponExhibitView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E657 RID: 255575 RVA: 0x00F11FBC File Offset: 0x00F101BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickBtnRemove))
			};
		}

		// Token: 0x0603E658 RID: 255576 RVA: 0x00F12104 File Offset: 0x00F10304
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorWeaponExhibitView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorWeaponExhibitView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E659 RID: 255577 RVA: 0x00F12147 File Offset: 0x00F10347
		protected override void OnBeforeShow()
		{
			this.RefreshWeaponList();
		}

		// Token: 0x0603E65A RID: 255578 RVA: 0x00F1214F File Offset: 0x00F1034F
		protected override void OnBeforeDestroy()
		{
			UiCameraAnimationManager.Instance.EnablePlayerActor();
			FilterSortEntrance<int> filterSortComponent = this.FilterSortComponent;
			if (filterSortComponent != null)
			{
				filterSortComponent.ClearData(EFilterSortGroupId.SpringManorWeaponExhibit);
			}
			this.ResetAllExhibitActiveState();
		}

		// Token: 0x0603E65B RID: 255579 RVA: 0x00F12174 File Offset: 0x00F10374
		private void SelectFirstWeaponSlot()
		{
			if (this.WeaponTogList.Count > 0)
			{
				int num = this.WeaponSlotAssignments.FindIndex((int itemId) => itemId == 0);
				if (num < 0 || num >= this.WeaponTogList.Count)
				{
					num = 0;
				}
				this.OnWeaponToggleSelected(num);
			}
			else
			{
				this.SelectedToggleIndex = -1;
			}
			this.RefreshOperationButtonState();
		}

		// Token: 0x0603E65C RID: 255580 RVA: 0x00F121E4 File Offset: 0x00F103E4
		private UniTask CreateWeaponTogsAsync()
		{
			SpringManorWeaponExhibitView.<CreateWeaponTogsAsync>d__17 <CreateWeaponTogsAsync>d__;
			<CreateWeaponTogsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeaponTogsAsync>d__.<>4__this = this;
			<CreateWeaponTogsAsync>d__.<>1__state = -1;
			<CreateWeaponTogsAsync>d__.<>t__builder.Start<SpringManorWeaponExhibitView.<CreateWeaponTogsAsync>d__17>(ref <CreateWeaponTogsAsync>d__);
			return <CreateWeaponTogsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E65D RID: 255581 RVA: 0x00F12228 File Offset: 0x00F10428
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<SpringManorWeaponSlotToggle> CreateToggleAsync(int componentId)
		{
			SpringManorWeaponExhibitView.<CreateToggleAsync>d__18 <CreateToggleAsync>d__;
			<CreateToggleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SpringManorWeaponSlotToggle>.Create();
			<CreateToggleAsync>d__.<>4__this = this;
			<CreateToggleAsync>d__.componentId = componentId;
			<CreateToggleAsync>d__.<>1__state = -1;
			<CreateToggleAsync>d__.<>t__builder.Start<SpringManorWeaponExhibitView.<CreateToggleAsync>d__18>(ref <CreateToggleAsync>d__);
			return <CreateToggleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E65E RID: 255582 RVA: 0x00F12274 File Offset: 0x00F10474
		private void InitWeaponScrollView()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(6);
			UUIItem item = base.GetItem(7);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (loopScrollViewComponent == null || auibaseActor == null)
			{
				return;
			}
			this.WeaponScrollView = new LoopScrollView<SpringManorWeaponExhibitGrid, SpringManorWeaponExhibitItem>(loopScrollViewComponent, auibaseActor, new Func<SpringManorWeaponExhibitGrid>(this.CreateWeaponGrid), false);
		}

		// Token: 0x0603E65F RID: 255583 RVA: 0x00F122C4 File Offset: 0x00F104C4
		private void InitFilterSortEntrance()
		{
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			this.FilterSortComponent = new FilterSortEntrance<int>(item, new TUpdateDataListFunction<int>(this.OnFilterSortRefresh));
		}

		// Token: 0x0603E660 RID: 255584 RVA: 0x00F122F6 File Offset: 0x00F104F6
		private SpringManorWeaponExhibitGrid CreateWeaponGrid()
		{
			SpringManorWeaponExhibitGrid springManorWeaponExhibitGrid = new SpringManorWeaponExhibitGrid();
			springManorWeaponExhibitGrid.BindOnWeaponSelected(new Action<int, int>(this.OnWeaponGridSelected));
			return springManorWeaponExhibitGrid;
		}

		// Token: 0x0603E661 RID: 255585 RVA: 0x00F12310 File Offset: 0x00F10510
		private UniTask InitCaptionAsync()
		{
			SpringManorWeaponExhibitView.<InitCaptionAsync>d__22 <InitCaptionAsync>d__;
			<InitCaptionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionAsync>d__.<>4__this = this;
			<InitCaptionAsync>d__.<>1__state = -1;
			<InitCaptionAsync>d__.<>t__builder.Start<SpringManorWeaponExhibitView.<InitCaptionAsync>d__22>(ref <InitCaptionAsync>d__);
			return <InitCaptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E662 RID: 255586 RVA: 0x00F12354 File Offset: 0x00F10554
		private List<int> CreateWeaponItemViewDataList(List<WeaponItemData> sourceList)
		{
			List<int> list = new List<int>();
			this.WeaponItemLookup.Clear();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (WeaponItemData weaponItemData in sourceList)
			{
				int configId = weaponItemData.GetConfigId();
				if (!hashSet.Contains(configId) && weaponItemData.GetQuality() >= 4)
				{
					hashSet.Add(configId);
					SpringManorWeaponExhibitItem value = new SpringManorWeaponExhibitItem
					{
						ConfigId = configId,
						IsSelected = false
					};
					this.WeaponItemLookup.Add(configId, value);
					list.Add(configId);
				}
			}
			return list;
		}

		// Token: 0x0603E663 RID: 255587 RVA: 0x00F12404 File Offset: 0x00F10604
		private void RefreshWeaponList()
		{
			List<WeaponItemData> weaponItemDataList = InventoryModel.Instance.GetWeaponItemDataList();
			List<int> dataList = this.CreateWeaponItemViewDataList(weaponItemDataList);
			this.FilterSortComponent.UpdateData(EFilterSortGroupId.SpringManorWeaponExhibit, dataList, Array.Empty<object>());
		}

		// Token: 0x0603E664 RID: 255588 RVA: 0x00F12438 File Offset: 0x00F10638
		private List<SpringManorWeaponExhibitItem> SortPlacedWeaponFirst(List<SpringManorWeaponExhibitItem> dataList)
		{
			Dictionary<int, int> assignedOrder = new Dictionary<int, int>();
			for (int i = 0; i < this.WeaponSlotAssignments.Count; i++)
			{
				int num = this.WeaponSlotAssignments[i];
				if (num != 0)
				{
					assignedOrder.Add(num, i);
				}
			}
			if (assignedOrder.Count == 0)
			{
				return dataList;
			}
			List<SpringManorWeaponExhibitItem> list = new List<SpringManorWeaponExhibitItem>();
			List<SpringManorWeaponExhibitItem> list2 = new List<SpringManorWeaponExhibitItem>();
			foreach (SpringManorWeaponExhibitItem springManorWeaponExhibitItem in dataList)
			{
				if (assignedOrder.ContainsKey(springManorWeaponExhibitItem.ConfigId))
				{
					list.Add(springManorWeaponExhibitItem);
				}
				else
				{
					list2.Add(springManorWeaponExhibitItem);
				}
			}
			list.Sort(delegate(SpringManorWeaponExhibitItem a, SpringManorWeaponExhibitItem b)
			{
				int num2 = assignedOrder[a.ConfigId];
				int num3 = assignedOrder[b.ConfigId];
				return num2 - num3;
			});
			List<SpringManorWeaponExhibitItem> list3 = new List<SpringManorWeaponExhibitItem>(list);
			list3.AddRange(list2);
			return list3;
		}

		// Token: 0x0603E665 RID: 255589 RVA: 0x00F12528 File Offset: 0x00F10728
		private void ApplyWeaponList(List<SpringManorWeaponExhibitItem> dataList)
		{
			this.WeaponViewDataList = this.SortPlacedWeaponFirst(dataList);
			bool flag = this.WeaponViewDataList.Count > 0;
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			this.RefreshWeaponGridDataSource();
		}

		// Token: 0x0603E666 RID: 255590 RVA: 0x00F12570 File Offset: 0x00F10770
		private void OnFilterSortRefresh(List<int> list, bool isOutSideChange, EFilterSortType operationType)
		{
			List<int> list2 = list ?? new List<int>();
			List<SpringManorWeaponExhibitItem> list3 = new List<SpringManorWeaponExhibitItem>();
			foreach (int key in list2)
			{
				list3.Add(this.WeaponItemLookup[key]);
			}
			this.ApplyWeaponList(list3);
		}

		// Token: 0x0603E667 RID: 255591 RVA: 0x00F125E0 File Offset: 0x00F107E0
		private void RefreshToggleSelectState(int selectIndex)
		{
			if (this.WeaponTogList.Count == 0)
			{
				this.SelectedToggleIndex = -1;
				return;
			}
			int num = selectIndex;
			if (num < 0 || num >= this.WeaponTogList.Count)
			{
				num = 0;
			}
			this.SelectedToggleIndex = num;
			for (int i = 0; i < this.WeaponTogList.Count; i++)
			{
				this.WeaponTogList[i].SetSelected(i == num);
			}
		}

		// Token: 0x0603E668 RID: 255592 RVA: 0x00F1264A File Offset: 0x00F1084A
		private void OnWeaponGridSelected(int configId, int gridIndex)
		{
			this.SelectedConfigId = new int?(configId);
			this.WeaponScrollView.DeselectCurrentGridProxy(false);
			this.WeaponScrollView.SelectGridProxy(gridIndex, false);
			this.OnClickBtnPut();
		}

		// Token: 0x0603E669 RID: 255593 RVA: 0x00F12678 File Offset: 0x00F10878
		private void RefreshOperationButtonState()
		{
			bool flag = this.SelectedToggleIndex >= 0 && this.SelectedToggleIndex < this.WeaponTogList.Count;
			if (!flag)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(13);
			if (button == null)
			{
				return;
			}
			bool selfInteractive;
			if (flag)
			{
				int? selectedConfigId = this.SelectedConfigId;
				int num = this.WeaponSlotAssignments[this.SelectedToggleIndex];
				selfInteractive = (selectedConfigId.GetValueOrDefault() == num & selectedConfigId != null);
			}
			else
			{
				selfInteractive = false;
			}
			button.SetSelfInteractive(selfInteractive);
		}

		// Token: 0x0603E66A RID: 255594 RVA: 0x00F126EC File Offset: 0x00F108EC
		private void ScrollWeaponListToItemId(int itemId)
		{
			int num = this.WeaponViewDataList.FindIndex((SpringManorWeaponExhibitItem weaponData) => weaponData.ConfigId == itemId);
			if (num < 0)
			{
				return;
			}
			this.SelectedConfigId = new int?(this.WeaponViewDataList[num].ConfigId);
			this.WeaponScrollView.ScrollToGridIndex(num, false);
			this.WeaponScrollView.SelectGridProxy(num, false);
			this.OnWeaponGridSelected(this.SelectedConfigId.Value, num);
		}

		// Token: 0x0603E66B RID: 255595 RVA: 0x00F1276C File Offset: 0x00F1096C
		private void RefreshWeaponGridDataSource()
		{
			this.UpdateWeaponSelectState();
			this.WeaponScrollView.RefreshByData(this.WeaponViewDataList, false, null, true);
			bool flag = this.WeaponViewDataList.Count > 0;
			if (this.SelectedConfigId == null)
			{
				this.WeaponScrollView.DeselectCurrentGridProxy(false);
				return;
			}
			if (flag)
			{
				int num = this.WeaponSlotAssignments[this.SelectedToggleIndex];
				if (num != 0)
				{
					this.ScrollWeaponListToItemId(num);
					return;
				}
				this.ScrollWeaponListToItemId(this.SelectedConfigId.Value);
			}
		}

		// Token: 0x0603E66C RID: 255596 RVA: 0x00F127F0 File Offset: 0x00F109F0
		private void UpdateWeaponSelectState()
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int num in this.WeaponSlotAssignments)
			{
				if (num != 0)
				{
					hashSet.Add(num);
				}
			}
			foreach (SpringManorWeaponExhibitItem springManorWeaponExhibitItem in this.WeaponViewDataList)
			{
				bool isSelected = hashSet.Contains(springManorWeaponExhibitItem.ConfigId);
				springManorWeaponExhibitItem.IsSelected = isSelected;
			}
		}

		// Token: 0x0603E66D RID: 255597 RVA: 0x00F128A4 File Offset: 0x00F10AA4
		[NullableContext(2)]
		private SceneItemExhibitComponent GetExhibitComponent(int pbDataId)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (entityByPbDataId == null)
			{
				return null;
			}
			SceneItemExhibitComponent component = entityByPbDataId.Entity.GetComponent<SceneItemExhibitComponent>();
			if (component == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 1);
				defaultInterpolatedStringHandler.AppendLiteral("刷新场景物品展示模型失败，PbDataId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(pbDataId);
				defaultInterpolatedStringHandler.AppendLiteral("，Entity没有ActorComponent");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return component;
		}

		// Token: 0x0603E66E RID: 255598 RVA: 0x00F1291C File Offset: 0x00F10B1C
		private bool RefreshSceneItemExhibit(int pbDataId, int weaponGuid)
		{
			SceneItemExhibitComponent exhibitComponent = this.GetExhibitComponent(pbDataId);
			if (exhibitComponent == null)
			{
				return false;
			}
			if (weaponGuid == 0)
			{
				exhibitComponent.HideSkeletalMeshComponent();
			}
			else
			{
				exhibitComponent.RefreshSkeletalMeshComponent(weaponGuid, false);
			}
			return true;
		}

		// Token: 0x0603E66F RID: 255599 RVA: 0x00F1294C File Offset: 0x00F10B4C
		private void ResetExhibitToOrigin()
		{
			if (this.ExhibitPbDataIdList == null)
			{
				return;
			}
			for (int i = 0; i < this.ExhibitPbDataIdList.Count; i++)
			{
				int pbDataId = this.ExhibitPbDataIdList[i];
				int weaponGuid = this.OriginWeaponIdList[i];
				this.RefreshSceneItemExhibit(pbDataId, weaponGuid);
			}
		}

		// Token: 0x0603E670 RID: 255600 RVA: 0x00F1299C File Offset: 0x00F10B9C
		private void UpdateExhibitActiveState(int? previousIndex, int currentIndex)
		{
			if (this.ExhibitPbDataIdList == null)
			{
				return;
			}
			if (previousIndex != null)
			{
				int? num = previousIndex;
				int num2 = 0;
				if (num.GetValueOrDefault() >= num2 & num != null)
				{
					num = previousIndex;
					num2 = this.ExhibitPbDataIdList.Count;
					if (num.GetValueOrDefault() < num2 & num != null)
					{
						int pbDataId = this.ExhibitPbDataIdList[previousIndex.Value];
						SceneItemExhibitComponent exhibitComponent = this.GetExhibitComponent(pbDataId);
						if (exhibitComponent != null)
						{
							exhibitComponent.SetExhibitShowEffect(false);
						}
					}
				}
			}
			if (currentIndex >= 0 && currentIndex < this.ExhibitPbDataIdList.Count)
			{
				int pbDataId2 = this.ExhibitPbDataIdList[currentIndex];
				SceneItemExhibitComponent exhibitComponent2 = this.GetExhibitComponent(pbDataId2);
				if (exhibitComponent2 == null)
				{
					return;
				}
				exhibitComponent2.SetExhibitShowEffect(true);
			}
		}

		// Token: 0x0603E671 RID: 255601 RVA: 0x00F12A50 File Offset: 0x00F10C50
		private void ResetAllExhibitActiveState()
		{
			if (this.ExhibitPbDataIdList == null)
			{
				return;
			}
			foreach (int pbDataId in this.ExhibitPbDataIdList)
			{
				SceneItemExhibitComponent exhibitComponent = this.GetExhibitComponent(pbDataId);
				if (exhibitComponent != null)
				{
					exhibitComponent.SetExhibitShowEffect(false);
				}
			}
		}

		// Token: 0x0603E672 RID: 255602 RVA: 0x00F12AB8 File Offset: 0x00F10CB8
		private bool IsWeaponAssignmentsModified()
		{
			if (this.ExhibitPbDataIdList == null)
			{
				return false;
			}
			for (int i = 0; i < this.ExhibitPbDataIdList.Count; i++)
			{
				int num = this.OriginWeaponIdList[i];
				if (this.WeaponSlotAssignments[i] != num)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E673 RID: 255603 RVA: 0x00F12B04 File Offset: 0x00F10D04
		private void OnClickBtnPut()
		{
			if (this.SelectedToggleIndex < 0)
			{
				return;
			}
			if (this.SelectedConfigId == null)
			{
				return;
			}
			if (this.SelectedToggleIndex >= this.WeaponTogList.Count)
			{
				return;
			}
			int weaponItemId = this.SelectedConfigId.Value;
			int num = this.WeaponSlotAssignments.FindIndex((int itemId) => itemId == weaponItemId);
			if (num >= 0 && num != this.SelectedToggleIndex)
			{
				List<int> exhibitPbDataIdList = this.ExhibitPbDataIdList;
				int? num2 = (exhibitPbDataIdList != null) ? new int?(exhibitPbDataIdList[num]) : null;
				this.WeaponSlotAssignments[num] = 0;
				SpringManorWeaponSlotToggle springManorWeaponSlotToggle = this.WeaponTogList[num];
				if (springManorWeaponSlotToggle != null)
				{
					springManorWeaponSlotToggle.SetWeaponItemId(0);
				}
				if (num2 != null)
				{
					this.RefreshSceneItemExhibit(num2.Value, 0);
				}
			}
			this.WeaponSlotAssignments[this.SelectedToggleIndex] = weaponItemId;
			SpringManorWeaponSlotToggle springManorWeaponSlotToggle2 = this.WeaponTogList[this.SelectedToggleIndex];
			if (springManorWeaponSlotToggle2 != null)
			{
				springManorWeaponSlotToggle2.SetWeaponItemId(weaponItemId);
			}
			this.UpdateWeaponSelectState();
			this.WeaponScrollView.RefreshAllGridProxies();
			List<int> exhibitPbDataIdList2 = this.ExhibitPbDataIdList;
			int? num3 = (exhibitPbDataIdList2 != null) ? new int?(exhibitPbDataIdList2[this.SelectedToggleIndex]) : null;
			if (num3 != null)
			{
				this.RefreshSceneItemExhibit(num3.Value, this.SelectedConfigId.Value);
			}
			this.RefreshOperationButtonState();
		}

		// Token: 0x0603E674 RID: 255604 RVA: 0x00F12C74 File Offset: 0x00F10E74
		private void OnClickBtnRemove()
		{
			if (this.SelectedToggleIndex < 0 || this.SelectedToggleIndex >= this.WeaponTogList.Count)
			{
				return;
			}
			if (this.WeaponSlotAssignments[this.SelectedToggleIndex] == 0)
			{
				return;
			}
			this.WeaponSlotAssignments[this.SelectedToggleIndex] = 0;
			SpringManorWeaponSlotToggle springManorWeaponSlotToggle = this.WeaponTogList[this.SelectedToggleIndex];
			if (springManorWeaponSlotToggle != null)
			{
				springManorWeaponSlotToggle.SetWeaponItemId(0);
			}
			List<int> exhibitPbDataIdList = this.ExhibitPbDataIdList;
			int? num = (exhibitPbDataIdList != null) ? new int?(exhibitPbDataIdList[this.SelectedToggleIndex]) : null;
			if (num != null)
			{
				this.RefreshSceneItemExhibit(num.Value, 0);
			}
			this.UpdateWeaponSelectState();
			this.WeaponScrollView.RefreshAllGridProxies();
			this.RefreshOperationButtonState();
		}

		// Token: 0x0603E675 RID: 255605 RVA: 0x00F12D38 File Offset: 0x00F10F38
		private List<EntityItemBundleInfo> BuildWeaponBundleInfos()
		{
			List<EntityItemBundleInfo> list = new List<EntityItemBundleInfo>();
			if (this.ExhibitPbDataIdList == null)
			{
				return list;
			}
			for (int i = 0; i < this.ExhibitPbDataIdList.Count; i++)
			{
				int pbDataId = this.ExhibitPbDataIdList[i];
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (entityByPbDataId != null)
				{
					int num = this.WeaponSlotAssignments[i];
					if (num != this.OriginWeaponIdList[i])
					{
						EntityItemBundleInfo entityItemBundleInfo = EntityItemBundleInfo.Create();
						entityItemBundleInfo.EntityId = MathUtils.Instance.NumberToLong(entityByPbDataId.CreatureDataId);
						entityItemBundleInfo.ItemId = num;
						list.Add(entityItemBundleInfo);
					}
				}
			}
			return list;
		}

		// Token: 0x0603E676 RID: 255606 RVA: 0x00F12DD8 File Offset: 0x00F10FD8
		private void OnClickCloseBtn()
		{
			if (!this.IsWeaponAssignmentsModified())
			{
				base.CloseMe(null);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SpringManorWeaponExhibitConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				this.ResetExhibitToOrigin();
				base.CloseMe(null);
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				List<EntityItemBundleInfo> bundleInfos = this.BuildWeaponBundleInfos();
				SpringManorController.Instance.RequestExhibitionSave(bundleInfos);
				base.CloseMe(null);
			});
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603E677 RID: 255607 RVA: 0x00F12E44 File Offset: 0x00F11044
		private void SwitchWeaponSlot(int targetIndex)
		{
			this.RefreshToggleSelectState(targetIndex);
			int num = this.WeaponSlotAssignments[targetIndex];
			if (num != 0)
			{
				this.ScrollWeaponListToItemId(num);
			}
			else
			{
				LoopScrollView<SpringManorWeaponExhibitGrid, SpringManorWeaponExhibitItem> weaponScrollView = this.WeaponScrollView;
				if (weaponScrollView != null)
				{
					weaponScrollView.DeselectCurrentGridProxy(false);
				}
				this.SelectedConfigId = null;
			}
			this.RefreshOperationButtonState();
		}

		// Token: 0x0603E678 RID: 255608 RVA: 0x00F12E98 File Offset: 0x00F11098
		private void OnWeaponToggleSelected(int index)
		{
			int selectedToggleIndex = this.SelectedToggleIndex;
			if (selectedToggleIndex == index)
			{
				this.RefreshToggleSelectState(index);
				return;
			}
			this.SwitchWeaponSlot(index);
			this.UpdateExhibitActiveState(new int?(selectedToggleIndex), index);
		}

		// Token: 0x040209A5 RID: 133541
		private const int MIN_DISPLAY_WEAPON_QUALITY = 4;

		// Token: 0x040209A6 RID: 133542
		private List<SpringManorWeaponSlotToggle> WeaponTogList = new List<SpringManorWeaponSlotToggle>();

		// Token: 0x040209A7 RID: 133543
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SpringManorWeaponExhibitGrid, SpringManorWeaponExhibitItem> WeaponScrollView;

		// Token: 0x040209A8 RID: 133544
		private List<SpringManorWeaponExhibitItem> WeaponViewDataList = new List<SpringManorWeaponExhibitItem>();

		// Token: 0x040209A9 RID: 133545
		private readonly Dictionary<int, SpringManorWeaponExhibitItem> WeaponItemLookup = new Dictionary<int, SpringManorWeaponExhibitItem>();

		// Token: 0x040209AA RID: 133546
		[Nullable(2)]
		private FilterSortEntrance<int> FilterSortComponent;

		// Token: 0x040209AB RID: 133547
		private List<int> WeaponSlotAssignments = new List<int>();

		// Token: 0x040209AC RID: 133548
		private int SelectedToggleIndex = -1;

		// Token: 0x040209AD RID: 133549
		private int? SelectedConfigId;

		// Token: 0x040209AE RID: 133550
		[Nullable(2)]
		private List<int> ExhibitPbDataIdList;

		// Token: 0x040209AF RID: 133551
		private List<int> OriginWeaponIdList = new List<int>();
	}
}
