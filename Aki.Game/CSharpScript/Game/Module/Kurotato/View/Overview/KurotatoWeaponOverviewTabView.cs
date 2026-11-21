using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004724 RID: 18212
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoWeaponOverviewTabView : UiTabViewBase
	{
		// Token: 0x0602DBFD RID: 187389 RVA: 0x00CCC434 File Offset: 0x00CCA634
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DBFE RID: 187390 RVA: 0x00CCC524 File Offset: 0x00CCA724
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoWeaponOverviewTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoWeaponOverviewTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBFF RID: 187391 RVA: 0x00CCC568 File Offset: 0x00CCA768
		private UniTask CreateWeaponTipAsync()
		{
			KurotatoWeaponOverviewTabView.<CreateWeaponTipAsync>d__10 <CreateWeaponTipAsync>d__;
			<CreateWeaponTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateWeaponTipAsync>d__.<>4__this = this;
			<CreateWeaponTipAsync>d__.<>1__state = -1;
			<CreateWeaponTipAsync>d__.<>t__builder.Start<KurotatoWeaponOverviewTabView.<CreateWeaponTipAsync>d__10>(ref <CreateWeaponTipAsync>d__);
			return <CreateWeaponTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC00 RID: 187392 RVA: 0x00CCC5AC File Offset: 0x00CCA7AC
		private void CreateItemMultiTemplateScrollViewAsync()
		{
			this.ItemMultiTemplateScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(0));
			KurotatoInstInfo saveInstInfo = this.ExtraParams as KurotatoInstInfo;
			this.InitScrollViewData(saveInstInfo);
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.ItemMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x0602DC01 RID: 187393 RVA: 0x00CCC600 File Offset: 0x00CCA800
		protected override void OnShowUiTabViewFromToggle()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			if (tabBehavior != null)
			{
				tabBehavior.PlaySequence("Switch");
			}
			if (this.ItemMultiTemplateScrollView == null)
			{
				return;
			}
			KurotatoInstInfo saveInstInfo = this.ExtraParams as KurotatoInstInfo;
			WeaponGridItem selectedItem = this.SelectedItem;
			if (selectedItem != null)
			{
				selectedItem.SetSelected(false, false);
			}
			this.SelectedId = 0;
			this.SelectedItem = null;
			this.InitScrollViewData(saveInstInfo);
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.ItemMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
			this.RefreshItemTip();
			this.RefreshSelectItem();
		}

		// Token: 0x0602DC02 RID: 187394 RVA: 0x00CCC68C File Offset: 0x00CCA88C
		[NullableContext(2)]
		private void InitScrollViewData(KurotatoInstInfo saveInstInfo)
		{
			KurotatoConfig kurotatoConfig = KurotatoConfig.Instance;
			KurotatoModel instance = KurotatoModel.Instance;
			this.ScrollDataList.Clear();
			bool flag = false;
			Dictionary<int, int> itemQuality = new Dictionary<int, int>();
			List<IKurotatoItemData> list;
			if (saveInstInfo != null)
			{
				KurotatoItemPanelPbData itemPanelPbData = saveInstInfo.ItemPanelPbData;
				RepeatedField<KurotatoItemPbData> repeatedField = ((itemPanelPbData != null) ? itemPanelPbData.ItemPbDatas : null) ?? new RepeatedField<KurotatoItemPbData>();
				list = new List<IKurotatoItemData>();
				using (IEnumerator<KurotatoItemPbData> enumerator = repeatedField.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KurotatoItemPbData kurotatoItemPbData = enumerator.Current;
						KurotatoItem? itemConfigByItemId = kurotatoConfig.GetItemConfigByItemId(kurotatoItemPbData.ItemId);
						if (itemConfigByItemId != null && itemConfigByItemId.GetValueOrDefault().Type == 2)
						{
							list.Add(new KurotatoItemData
							{
								ItemId = kurotatoItemPbData.ItemId,
								Count = kurotatoItemPbData.Count
							});
						}
					}
					goto IL_150;
				}
			}
			list = new List<IKurotatoItemData>();
			foreach (IKurotatoItemData kurotatoItemData in instance.GetHoldItemData())
			{
				KurotatoItem? itemConfigByItemId = kurotatoConfig.GetItemConfigByItemId(kurotatoItemData.ItemId);
				if (itemConfigByItemId != null && itemConfigByItemId.GetValueOrDefault().Type == 2)
				{
					list.Add(kurotatoItemData);
				}
			}
			IL_150:
			List<IKurotatoWeaponData> list2;
			if (saveInstInfo != null)
			{
				KurotatoWeaponPanelPbData weaponPanelPbData = saveInstInfo.WeaponPanelPbData;
				RepeatedField<KurotatoWeaponPbData> repeatedField2 = ((weaponPanelPbData != null) ? weaponPanelPbData.WeaponPbDatas : null) ?? new RepeatedField<KurotatoWeaponPbData>();
				list2 = new List<IKurotatoWeaponData>();
				using (IEnumerator<KurotatoWeaponPbData> enumerator3 = repeatedField2.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						KurotatoWeaponPbData kurotatoWeaponPbData = enumerator3.Current;
						list2.Add(new KurotatoWeaponData
						{
							WeaponId = kurotatoWeaponPbData.WeaponId,
							IncId = kurotatoWeaponPbData.IncId,
							SellPrice = kurotatoWeaponPbData.SellPrice,
							PreWaveDealtDamage = kurotatoWeaponPbData.PreWaveDealtDamage
						});
					}
					goto IL_1EE;
				}
			}
			list2 = new List<IKurotatoWeaponData>(instance.GetHoldWeaponData());
			IL_1EE:
			list.Sort(delegate(IKurotatoItemData a, IKurotatoItemData b)
			{
				if (!itemQuality.ContainsKey(a.ItemId))
				{
					itemQuality[a.ItemId] = kurotatoConfig.GetItemConfigByItemId(a.ItemId).Value.Quality;
				}
				if (!itemQuality.ContainsKey(b.ItemId))
				{
					itemQuality[b.ItemId] = kurotatoConfig.GetItemConfigByItemId(b.ItemId).Value.Quality;
				}
				int valueOrDefault = itemQuality.GetValueOrDefault(a.ItemId, 0);
				return itemQuality.GetValueOrDefault(b.ItemId, 0) - valueOrDefault;
			});
			KurotatoActivityConfig? kurotatoActivityConfig;
			int num = (instance.GetActivityConfig() != null) ? kurotatoActivityConfig.GetValueOrDefault().WeaponCount : list2.Count;
			GridTitleItemData gridTitleItemData = new GridTitleItemData();
			MultiTemplateGridDataBase<GridTitleItemDataInner, GridTitleItem> multiTemplateGridDataBase = gridTitleItemData;
			GridTitleItemDataInner gridTitleItemDataInner = new GridTitleItemDataInner();
			gridTitleItemDataInner.Title = "Kurotato_prefabTilte_weapon";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(list2.Count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			gridTitleItemDataInner.Num = defaultInterpolatedStringHandler.ToStringAndClear();
			multiTemplateGridDataBase.Data = gridTitleItemDataInner;
			this.ScrollDataList.Add(gridTitleItemData);
			foreach (IKurotatoWeaponData kurotatoWeaponData in list2)
			{
				if (!flag)
				{
					flag = true;
					this.SelectedId = kurotatoWeaponData.IncId;
					this.SelectedType = EKurotatoCardType.Weapon;
					this.SelectedPreWaveDealtDamage = new int?(kurotatoWeaponData.PreWaveDealtDamage);
				}
				OverviewGridItemData overviewGridItemData = new OverviewGridItemData();
				overviewGridItemData.Data = new KurotatoMediumItemGridData
				{
					Type = EKurotatoCardType.Weapon,
					Id = kurotatoWeaponData.WeaponId,
					IncId = kurotatoWeaponData.IncId,
					Count = 1,
					PreWaveDealtDamage = new int?(kurotatoWeaponData.PreWaveDealtDamage)
				};
				overviewGridItemData.OnClickCb = new Action<WeaponGridItem, bool>(this.OnClickGridItem);
				overviewGridItemData.IsSelectedCb = new Func<IKurotatoMediumItemGridData, bool>(this.IsGridDataSelected);
				this.ScrollDataList.Add(overviewGridItemData);
			}
			for (int i = list2.Count; i < num; i++)
			{
				OverviewGridItemData overviewGridItemData2 = new OverviewGridItemData();
				overviewGridItemData2.Data = new KurotatoMediumItemGridData
				{
					Type = EKurotatoCardType.None,
					Id = 0,
					IncId = 0,
					Count = 0
				};
				overviewGridItemData2.OnClickCb = new Action<WeaponGridItem, bool>(this.OnClickGridItem);
				overviewGridItemData2.IsSelectedCb = new Func<IKurotatoMediumItemGridData, bool>(this.IsGridDataSelected);
				this.ScrollDataList.Add(overviewGridItemData2);
			}
			GridTitleItemData gridTitleItemData2 = new GridTitleItemData();
			int num2 = 0;
			foreach (IKurotatoItemData kurotatoItemData2 in list)
			{
				num2 += kurotatoItemData2.Count;
			}
			gridTitleItemData2.Data = new GridTitleItemDataInner
			{
				Title = "Kurotato_prefabTilte_item",
				Num = num2.ToString()
			};
			this.ScrollDataList.Add(gridTitleItemData2);
			foreach (IKurotatoItemData kurotatoItemData3 in list)
			{
				if (!flag)
				{
					flag = true;
					this.SelectedId = kurotatoItemData3.ItemId;
					this.SelectedType = EKurotatoCardType.Item;
				}
				OverviewGridItemData overviewGridItemData3 = new OverviewGridItemData();
				overviewGridItemData3.Data = new KurotatoMediumItemGridData
				{
					Type = EKurotatoCardType.Item,
					Id = kurotatoItemData3.ItemId,
					IncId = 0,
					Count = kurotatoItemData3.Count
				};
				overviewGridItemData3.OnClickCb = new Action<WeaponGridItem, bool>(this.OnClickGridItem);
				overviewGridItemData3.IsSelectedCb = new Func<IKurotatoMediumItemGridData, bool>(this.IsGridDataSelected);
				this.ScrollDataList.Add(overviewGridItemData3);
			}
			if (list.Count <= 0)
			{
				this.ScrollDataList.Add(new OverviewEmptyGridData());
			}
		}

		// Token: 0x0602DC03 RID: 187395 RVA: 0x00CCCC14 File Offset: 0x00CCAE14
		protected override void OnStart()
		{
			this.RefreshItemTip();
			this.RefreshSelectItem();
		}

		// Token: 0x0602DC04 RID: 187396 RVA: 0x00CCCC24 File Offset: 0x00CCAE24
		private void RefreshSelectItem()
		{
			this.SelectedItem = null;
			bool flag = false;
			for (int i = 0; i < this.ScrollDataList.Count; i++)
			{
				OverviewGridItemData overviewGridItemData = this.ScrollDataList[i] as OverviewGridItemData;
				if (overviewGridItemData != null)
				{
					flag = true;
					if (this.IsGridDataSelected(overviewGridItemData.Data))
					{
						MultiTemplateScrollView itemMultiTemplateScrollView = this.ItemMultiTemplateScrollView;
						this.SelectedItem = (((itemMultiTemplateScrollView != null) ? itemMultiTemplateScrollView.GetProxyByGridIndex(i) : null) as WeaponGridItem);
						break;
					}
				}
			}
			UUIItem uuiitem = base.GetMultiTemplateScrollViewComponent(0).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
			base.GetItem(3).SetUIActive(!flag);
		}

		// Token: 0x0602DC05 RID: 187397 RVA: 0x00CCCCC8 File Offset: 0x00CCAEC8
		private void RefreshItemTip()
		{
			if (this.SelectedId <= 0)
			{
				this.ItemTip.SetUiActive(false);
				return;
			}
			this.ItemTip.SetUiActive(true);
			if (this.ItemTip.IsOutside && this.SelectedType == EKurotatoCardType.Weapon)
			{
				using (List<IMultiTemplateGridData>.Enumerator enumerator = this.ScrollDataList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IMultiTemplateGridData multiTemplateGridData = enumerator.Current;
						OverviewGridItemData overviewGridItemData = multiTemplateGridData as OverviewGridItemData;
						if (overviewGridItemData != null && overviewGridItemData.Data.IncId == this.SelectedId)
						{
							this.SelectedPreWaveDealtDamage = overviewGridItemData.Data.PreWaveDealtDamage;
							this.ItemTip.Refresh(this.SelectedType, overviewGridItemData.Data.Id, true, false, this.SelectedPreWaveDealtDamage);
							break;
						}
					}
					return;
				}
			}
			this.ItemTip.Refresh(this.SelectedType, this.SelectedId, true, false, this.SelectedPreWaveDealtDamage);
		}

		// Token: 0x0602DC06 RID: 187398 RVA: 0x00CCCDC4 File Offset: 0x00CCAFC4
		private bool IsGridDataSelected(IKurotatoMediumItemGridData data)
		{
			if (this.SelectedType != data.Type)
			{
				return false;
			}
			if (data.Type == EKurotatoCardType.Weapon)
			{
				return this.SelectedId == data.IncId;
			}
			return this.SelectedId == data.Id;
		}

		// Token: 0x0602DC07 RID: 187399 RVA: 0x00CCCDFC File Offset: 0x00CCAFFC
		private void OnClickGridItem(WeaponGridItem item, bool selected)
		{
			if (!selected)
			{
				return;
			}
			IKurotatoMediumItemGridData data = item.Data;
			if (data.Type == EKurotatoCardType.None)
			{
				return;
			}
			for (int i = 0; i < this.ScrollDataList.Count; i++)
			{
				MultiTemplateScrollView itemMultiTemplateScrollView = this.ItemMultiTemplateScrollView;
				WeaponGridItem weaponGridItem = ((itemMultiTemplateScrollView != null) ? itemMultiTemplateScrollView.GetProxyByGridIndex(i) : null) as WeaponGridItem;
				if (weaponGridItem != null && this.IsGridDataSelected(weaponGridItem.Data))
				{
					weaponGridItem.SetSelected(false, false);
					break;
				}
			}
			this.SelectedType = data.Type;
			if (data.Type == EKurotatoCardType.Weapon)
			{
				this.SelectedId = data.IncId;
				this.SelectedPreWaveDealtDamage = data.PreWaveDealtDamage;
			}
			else
			{
				this.SelectedId = data.Id;
				this.SelectedPreWaveDealtDamage = null;
			}
			this.SelectedItem = item;
			item.SetSelected(true, false);
			this.RefreshItemTip();
		}

		// Token: 0x04018748 RID: 100168
		private EKurotatoCardType SelectedType;

		// Token: 0x04018749 RID: 100169
		private int SelectedId;

		// Token: 0x0401874A RID: 100170
		private int? SelectedPreWaveDealtDamage;

		// Token: 0x0401874B RID: 100171
		[Nullable(2)]
		private WeaponGridItem SelectedItem;

		// Token: 0x0401874C RID: 100172
		private readonly KurotatoItemInfoTipPanel ItemTip = new KurotatoItemInfoTipPanel();

		// Token: 0x0401874D RID: 100173
		[Nullable(2)]
		private MultiTemplateScrollView ItemMultiTemplateScrollView;

		// Token: 0x0401874E RID: 100174
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0200A362 RID: 41826
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032A8F RID: 207503
			MultiTemplateScrollViewInfo,
			// Token: 0x04032A90 RID: 207504
			PanelTitle,
			// Token: 0x04032A91 RID: 207505
			PanelItem,
			// Token: 0x04032A92 RID: 207506
			PanelEmpty,
			// Token: 0x04032A93 RID: 207507
			ItemBase,
			// Token: 0x04032A94 RID: 207508
			TipItem
		}
	}
}
