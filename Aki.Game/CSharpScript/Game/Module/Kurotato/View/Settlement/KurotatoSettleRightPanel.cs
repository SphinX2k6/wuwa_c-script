using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005726 RID: 22310
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSettleRightPanel : UiPanelBase
	{
		// Token: 0x06038B99 RID: 232345 RVA: 0x00D76195 File Offset: 0x00D74395
		public EKurotatoSettlePageState GetCurrentPageState()
		{
			return this.PageState;
		}

		// Token: 0x06038B9A RID: 232346 RVA: 0x00D761A0 File Offset: 0x00D743A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038B9B RID: 232347 RVA: 0x00D76424 File Offset: 0x00D74624
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoSettleRightPanel.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B9C RID: 232348 RVA: 0x00D76468 File Offset: 0x00D74668
		private void SetupOpenParam()
		{
			this.PageState = (EKurotatoSettlePageState)this.OpenParam;
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			if (settlementData != null)
			{
				this.IsSuccess = settlementData.IsPass;
				int curLevelId = KurotatoModel.Instance.GetCurLevelId();
				KurotatoLevel? kurotatoLevel;
				this.IsEndless = (((KurotatoConfig.Instance.GetLevelConfig(curLevelId) != null) ? new int?(kurotatoLevel.GetValueOrDefault().Difficulty) : null).GetValueOrDefault() == 3);
			}
		}

		// Token: 0x06038B9D RID: 232349 RVA: 0x00D764F4 File Offset: 0x00D746F4
		private UniTask CreateCompletionTimeItemAsync()
		{
			KurotatoSettleRightPanel.<CreateCompletionTimeItemAsync>d__15 <CreateCompletionTimeItemAsync>d__;
			<CreateCompletionTimeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCompletionTimeItemAsync>d__.<>4__this = this;
			<CreateCompletionTimeItemAsync>d__.<>1__state = -1;
			<CreateCompletionTimeItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateCompletionTimeItemAsync>d__15>(ref <CreateCompletionTimeItemAsync>d__);
			return <CreateCompletionTimeItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B9E RID: 232350 RVA: 0x00D76538 File Offset: 0x00D74738
		private UniTask CreateTotalKillsItemAsync()
		{
			KurotatoSettleRightPanel.<CreateTotalKillsItemAsync>d__16 <CreateTotalKillsItemAsync>d__;
			<CreateTotalKillsItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTotalKillsItemAsync>d__.<>4__this = this;
			<CreateTotalKillsItemAsync>d__.<>1__state = -1;
			<CreateTotalKillsItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateTotalKillsItemAsync>d__16>(ref <CreateTotalKillsItemAsync>d__);
			return <CreateTotalKillsItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B9F RID: 232351 RVA: 0x00D7657C File Offset: 0x00D7477C
		private UniTask CreateEndlessCompletionTimeItemAsync()
		{
			KurotatoSettleRightPanel.<CreateEndlessCompletionTimeItemAsync>d__17 <CreateEndlessCompletionTimeItemAsync>d__;
			<CreateEndlessCompletionTimeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateEndlessCompletionTimeItemAsync>d__.<>4__this = this;
			<CreateEndlessCompletionTimeItemAsync>d__.<>1__state = -1;
			<CreateEndlessCompletionTimeItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateEndlessCompletionTimeItemAsync>d__17>(ref <CreateEndlessCompletionTimeItemAsync>d__);
			return <CreateEndlessCompletionTimeItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BA0 RID: 232352 RVA: 0x00D765C0 File Offset: 0x00D747C0
		private UniTask CreateEndlessTotalKillsItemAsync()
		{
			KurotatoSettleRightPanel.<CreateEndlessTotalKillsItemAsync>d__18 <CreateEndlessTotalKillsItemAsync>d__;
			<CreateEndlessTotalKillsItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateEndlessTotalKillsItemAsync>d__.<>4__this = this;
			<CreateEndlessTotalKillsItemAsync>d__.<>1__state = -1;
			<CreateEndlessTotalKillsItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateEndlessTotalKillsItemAsync>d__18>(ref <CreateEndlessTotalKillsItemAsync>d__);
			return <CreateEndlessTotalKillsItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BA1 RID: 232353 RVA: 0x00D76603 File Offset: 0x00D74803
		private void CreateItemMultiTemplateScrollView()
		{
			this.ItemMultiTemplateScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(14));
			this.RefreshScroll();
		}

		// Token: 0x06038BA2 RID: 232354 RVA: 0x00D76620 File Offset: 0x00D74820
		private void InitScrollViewData()
		{
			this.ScrollDataList.Clear();
			if (this.PageState == EKurotatoSettlePageState.Info)
			{
				this.ScrollDataList.AddRange(this.GetCurrentWeaponScrollData());
				this.ScrollDataList.AddRange(this.GetCurrentItemScrollData());
				return;
			}
			this.ScrollDataList.AddRange(this.GetRoleScrollData());
			this.ScrollDataList.AddRange(this.GetUnlockWeaponScrollData());
			this.ScrollDataList.AddRange(this.GetUnlockItemScrollData());
		}

		// Token: 0x06038BA3 RID: 232355 RVA: 0x00D76698 File Offset: 0x00D74898
		private List<IMultiTemplateGridData> GetRoleScrollData()
		{
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			List<int> unlockRoles = ((settlementData != null) ? settlementData.UnlockRoles : null) ?? new List<int>();
			if (unlockRoles.Count == 0)
			{
				return new List<IMultiTemplateGridData>();
			}
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			list.Add(new GridTitleItemData
			{
				Data = new GridTitleItemDataInner
				{
					Title = "Kurotato_FinishprefabTilte_Unlock",
					Num = ""
				}
			});
			Action<RoleItem, bool> <>9__0;
			foreach (int data in unlockRoles)
			{
				RoleItemData roleItemData = new RoleItemData();
				roleItemData.Data = data;
				RoleItemData roleItemData2 = roleItemData;
				Action<RoleItem, bool> onClickCb;
				if ((onClickCb = <>9__0) == null)
				{
					onClickCb = (<>9__0 = delegate(RoleItem item, bool selected)
					{
						this.OnClickRoleItem(item.Data, unlockRoles);
					});
				}
				roleItemData2.OnClickCb = onClickCb;
				list.Add(roleItemData);
			}
			return list;
		}

		// Token: 0x06038BA4 RID: 232356 RVA: 0x00D767A4 File Offset: 0x00D749A4
		private void OnClickRoleItem(int roleId, List<int> unlockRoles)
		{
			int index = unlockRoles.IndexOf(roleId);
			KurotatoPopupUnlockRoleOpenParam param = new KurotatoPopupUnlockRoleOpenParam
			{
				RoleIds = unlockRoles,
				Index = index
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupUnlockRoleView, param, null);
		}

		// Token: 0x06038BA5 RID: 232357 RVA: 0x00D767E0 File Offset: 0x00D749E0
		private List<IMultiTemplateGridData> GetUnlockWeaponScrollData()
		{
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			List<int> unlockWeapons = ((settlementData != null) ? settlementData.UnlockWeapons : null) ?? new List<int>();
			if (unlockWeapons.Count == 0)
			{
				return new List<IMultiTemplateGridData>();
			}
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			list.Add(new GridTitleItemData
			{
				Data = new GridTitleItemDataInner
				{
					Title = "Kurotato_FinishprefabTilte_Getweapon",
					Num = unlockWeapons.Count.ToString()
				}
			});
			for (int i = 0; i < unlockWeapons.Count; i++)
			{
				int id = unlockWeapons[i];
				int index = i;
				list.Add(new GridItemData
				{
					Data = new GridItemCellData
					{
						Item = new KurotatoSmallItemGridData
						{
							Type = EKurotatoCardType.Weapon,
							Id = id,
							IncId = 0,
							Count = 1
						},
						OnClick = delegate
						{
							List<KurotatoCardTip> list2 = new List<KurotatoCardTip>();
							foreach (int selectId in unlockWeapons)
							{
								list2.Add(new KurotatoCardTip
								{
									CardType = EKurotatoCardType.Weapon,
									SelectId = selectId,
									IsConfigId = new bool?(true)
								});
							}
							this.OnClickWeaponItem(list2, index);
						}
					}
				});
			}
			return list;
		}

		// Token: 0x06038BA6 RID: 232358 RVA: 0x00D7691C File Offset: 0x00D74B1C
		private List<IMultiTemplateGridData> GetUnlockItemScrollData()
		{
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			KurotatoConfig kurotatoConfig = KurotatoConfig.Instance;
			List<int> unlockItems = new List<int>(((settlementData != null) ? settlementData.UnlockItems : null) ?? new List<int>());
			unlockItems.Sort(delegate(int a, int b)
			{
				KurotatoItem? itemConfigByItemId = kurotatoConfig.GetItemConfigByItemId(a);
				int num = (itemConfigByItemId != null) ? itemConfigByItemId.GetValueOrDefault().Quality : 0;
				itemConfigByItemId = kurotatoConfig.GetItemConfigByItemId(b);
				int num2 = (itemConfigByItemId != null) ? itemConfigByItemId.GetValueOrDefault().Quality : 0;
				if (num != num2)
				{
					return num2 - num;
				}
				return a - b;
			});
			if (unlockItems.Count == 0)
			{
				return new List<IMultiTemplateGridData>();
			}
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			list.Add(new GridTitleItemData
			{
				Data = new GridTitleItemDataInner
				{
					Title = "Kurotato_FinishprefabTilte_Getitem",
					Num = unlockItems.Count.ToString()
				}
			});
			for (int i = 0; i < unlockItems.Count; i++)
			{
				int id = unlockItems[i];
				int index = i;
				list.Add(new GridItemData
				{
					Data = new GridItemCellData
					{
						Item = new KurotatoSmallItemGridData
						{
							Type = EKurotatoCardType.Item,
							Id = id,
							IncId = 0,
							Count = 1
						},
						OnClick = delegate
						{
							List<KurotatoCardTip> list2 = new List<KurotatoCardTip>();
							foreach (int selectId in unlockItems)
							{
								list2.Add(new KurotatoCardTip
								{
									CardType = EKurotatoCardType.Item,
									SelectId = selectId,
									IsConfigId = new bool?(true)
								});
							}
							this.OnClickItemItem(list2, index);
						}
					}
				});
			}
			return list;
		}

		// Token: 0x06038BA7 RID: 232359 RVA: 0x00D76A80 File Offset: 0x00D74C80
		private List<IMultiTemplateGridData> GetCurrentWeaponScrollData()
		{
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			List<KurotatoWeaponData> weaponData = ((settlementData != null) ? settlementData.WeaponPanelData : null) ?? new List<KurotatoWeaponData>();
			KurotatoActivityConfig? kurotatoActivityConfig;
			int num = (KurotatoModel.Instance.GetActivityConfig() != null) ? kurotatoActivityConfig.GetValueOrDefault().WeaponCount : weaponData.Count;
			GridTitleItemData gridTitleItemData = new GridTitleItemData();
			MultiTemplateGridDataBase<GridTitleItemDataInner, GridTitleItem> multiTemplateGridDataBase = gridTitleItemData;
			GridTitleItemDataInner gridTitleItemDataInner = new GridTitleItemDataInner();
			gridTitleItemDataInner.Title = "Kurotato_FinishprefabTilte_weapon";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(weaponData.Count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			gridTitleItemDataInner.Num = defaultInterpolatedStringHandler.ToStringAndClear();
			multiTemplateGridDataBase.Data = gridTitleItemDataInner;
			list.Add(gridTitleItemData);
			for (int i = 0; i < weaponData.Count; i++)
			{
				KurotatoWeaponData kurotatoWeaponData = weaponData[i];
				int index = i;
				list.Add(new GridItemData
				{
					Data = new GridItemCellData
					{
						Item = new KurotatoSmallItemGridData
						{
							Type = EKurotatoCardType.Weapon,
							Id = kurotatoWeaponData.WeaponId,
							IncId = kurotatoWeaponData.IncId,
							Count = 1
						},
						OnClick = delegate
						{
							List<KurotatoCardTip> list2 = new List<KurotatoCardTip>();
							foreach (KurotatoWeaponData kurotatoWeaponData2 in weaponData)
							{
								list2.Add(new KurotatoCardTip
								{
									CardType = EKurotatoCardType.Weapon,
									SelectId = kurotatoWeaponData2.IncId
								});
							}
							this.OnClickWeaponItem(list2, index);
						}
					}
				});
			}
			for (int j = weaponData.Count; j < num; j++)
			{
				list.Add(new GridItemData
				{
					Data = new GridItemCellData
					{
						Item = new KurotatoSmallItemGridData
						{
							Type = EKurotatoCardType.None,
							Id = 0,
							IncId = 0,
							Count = 0
						}
					}
				});
			}
			return list;
		}

		// Token: 0x06038BA8 RID: 232360 RVA: 0x00D76C68 File Offset: 0x00D74E68
		private void OnClickWeaponItem(List<KurotatoCardTip> cardData, int clickIndex)
		{
			KurotatoPopupItemDetailOpenParam param = new KurotatoPopupItemDetailOpenParam
			{
				Index = clickIndex,
				CardData = cardData
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, param, null);
		}

		// Token: 0x06038BA9 RID: 232361 RVA: 0x00D76C9C File Offset: 0x00D74E9C
		private List<IMultiTemplateGridData> GetCurrentItemScrollData()
		{
			KurotatoConfig kurotatoConfig = KurotatoConfig.Instance;
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			List<KurotatoItemData> itemData = new List<KurotatoItemData>();
			foreach (KurotatoItemData kurotatoItemData in (((settlementData != null) ? settlementData.ItemPanelData : null) ?? new List<KurotatoItemData>()))
			{
				KurotatoItem? kurotatoItem;
				if (kurotatoConfig.GetItemConfigByItemId(kurotatoItemData.ItemId) != null && kurotatoItem.GetValueOrDefault().Type == 2)
				{
					itemData.Add(kurotatoItemData);
				}
			}
			itemData.Sort(delegate(KurotatoItemData a, KurotatoItemData b)
			{
				KurotatoItem? itemConfigByItemId = kurotatoConfig.GetItemConfigByItemId(a.ItemId);
				int num2 = (itemConfigByItemId != null) ? itemConfigByItemId.GetValueOrDefault().Quality : 0;
				itemConfigByItemId = kurotatoConfig.GetItemConfigByItemId(b.ItemId);
				int num3 = (itemConfigByItemId != null) ? itemConfigByItemId.GetValueOrDefault().Quality : 0;
				if (num2 != num3)
				{
					return num3 - num2;
				}
				return a.ItemId - b.ItemId;
			});
			if (itemData.Count == 0)
			{
				return new List<IMultiTemplateGridData>();
			}
			GridTitleItemData gridTitleItemData = new GridTitleItemData();
			int num = 0;
			foreach (KurotatoItemData kurotatoItemData2 in itemData)
			{
				num += kurotatoItemData2.Count;
			}
			gridTitleItemData.Data = new GridTitleItemDataInner
			{
				Title = "Kurotato_FinishprefabTilte_item",
				Num = num.ToString()
			};
			list.Add(gridTitleItemData);
			for (int i = 0; i < itemData.Count; i++)
			{
				KurotatoItemData kurotatoItemData3 = itemData[i];
				int index = i;
				list.Add(new GridItemData
				{
					Data = new GridItemCellData
					{
						Item = new KurotatoSmallItemGridData
						{
							Type = EKurotatoCardType.Item,
							Id = kurotatoItemData3.ItemId,
							IncId = 0,
							Count = kurotatoItemData3.Count,
							IsShowCount = new bool?(true)
						},
						OnClick = delegate
						{
							List<KurotatoCardTip> list2 = new List<KurotatoCardTip>();
							foreach (KurotatoItemData kurotatoItemData4 in itemData)
							{
								list2.Add(new KurotatoCardTip
								{
									CardType = EKurotatoCardType.Item,
									SelectId = kurotatoItemData4.ItemId,
									IsConfigId = new bool?(true)
								});
							}
							this.OnClickItemItem(list2, index);
						}
					}
				});
			}
			return list;
		}

		// Token: 0x06038BAA RID: 232362 RVA: 0x00D76ECC File Offset: 0x00D750CC
		private void OnClickItemItem(List<KurotatoCardTip> cardData, int clickIndex)
		{
			KurotatoPopupItemDetailOpenParam param = new KurotatoPopupItemDetailOpenParam
			{
				Index = clickIndex,
				CardData = cardData
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, param, null);
		}

		// Token: 0x06038BAB RID: 232363 RVA: 0x00D76EFE File Offset: 0x00D750FE
		protected override void OnStart()
		{
			if (this.IsEndless)
			{
				this.RefreshEndlessMode();
				return;
			}
			this.RefreshNormalMode();
		}

		// Token: 0x06038BAC RID: 232364 RVA: 0x00D76F15 File Offset: 0x00D75115
		public void SetPageState(EKurotatoSettlePageState state)
		{
			this.PageState = state;
			this.RefreshScroll();
		}

		// Token: 0x06038BAD RID: 232365 RVA: 0x00D76F24 File Offset: 0x00D75124
		public void RefreshNormalMode()
		{
			this.RefreshModeInfo();
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			this.CompletionTimeItem.Refresh("Survivor_Wave", ((settlementData != null) ? settlementData.PassWaveCount : 0).ToString());
			this.TotalKillsItem.Refresh("Kurotato_Settle_TotalKills", ((settlementData != null) ? settlementData.CumulativeKills : 0).ToString());
			this.RefreshScroll();
		}

		// Token: 0x06038BAE RID: 232366 RVA: 0x00D76F90 File Offset: 0x00D75190
		public void RefreshEndlessMode()
		{
			this.RefreshModeInfo();
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			this.EndlessCompletionTimeItem.Refresh("Survivor_Wave", ((settlementData != null) ? settlementData.PassWaveCount : 0).ToString());
			this.EndlessTotalKillsItem.Refresh("Kurotato_Settle_TotalKills", ((settlementData != null) ? settlementData.CumulativeKills : 0).ToString());
			base.GetArtText(13).SetText(((settlementData != null) ? settlementData.PassWaveCount : 0).ToString());
			int num = (settlementData != null) ? settlementData.PassWaveCount : 0;
			foreach (KurotatoWaveLevel kurotatoWaveLevel in KurotatoConfig.Instance.GetWaveLevelConfigList())
			{
				if (kurotatoWaveLevel.WaveRange(0) <= num && num <= kurotatoWaveLevel.WaveRange(1))
				{
					base.SetTextureByPath(kurotatoWaveLevel.Icon, base.GetTexture(3), null, null);
					break;
				}
			}
			this.RefreshScroll();
		}

		// Token: 0x06038BAF RID: 232367 RVA: 0x00D770A0 File Offset: 0x00D752A0
		private void RefreshModeInfo()
		{
			int curLevelId = KurotatoModel.Instance.GetCurLevelId();
			KurotatoLevel? levelConfig = KurotatoConfig.Instance.GetLevelConfig(curLevelId);
			EKurotatoLevelDifficulty key = (EKurotatoLevelDifficulty)((levelConfig != null) ? levelConfig.GetValueOrDefault().Difficulty : 0);
			base.GetText(5).ShowTextNew(((levelConfig != null) ? levelConfig.GetValueOrDefault().Name : null) ?? "");
			string hexStr = KurotatoSettleRightPanel.DifficultyColorMap.GetValueOrDefault(key) ?? "#6a6a6a";
			base.GetTexture(4).SetColor(FColor.FromHex(hexStr));
			base.GetItem(0).SetUIActive(this.IsSuccess || this.IsEndless);
			base.GetItem(1).SetUIActive(!this.IsSuccess && !this.IsEndless);
			base.GetTexture(2).SetUIActive(!this.IsEndless);
			base.GetTexture(3).SetUIActive(this.IsEndless);
			base.GetItem(6).SetUIActive(!this.IsEndless);
			base.GetItem(10).SetUIActive(this.IsEndless);
		}

		// Token: 0x06038BB0 RID: 232368 RVA: 0x00D771C8 File Offset: 0x00D753C8
		private void RefreshScroll()
		{
			this.InitScrollViewData();
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.ItemMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x0401DC3B RID: 121915
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyDictionary<EKurotatoLevelDifficulty, string> DifficultyColorMap = new Dictionary<EKurotatoLevelDifficulty, string>
		{
			{
				EKurotatoLevelDifficulty.TeachEasy,
				"#6a6a6a"
			},
			{
				EKurotatoLevelDifficulty.TeachDifficulty,
				"#6639d1"
			},
			{
				EKurotatoLevelDifficulty.Interest,
				"#4153db"
			},
			{
				EKurotatoLevelDifficulty.Endless,
				"#b12846"
			}
		};

		// Token: 0x0401DC3C RID: 121916
		private bool IsSuccess;

		// Token: 0x0401DC3D RID: 121917
		private bool IsEndless;

		// Token: 0x0401DC3E RID: 121918
		private EKurotatoSettlePageState PageState = EKurotatoSettlePageState.Info;

		// Token: 0x0401DC3F RID: 121919
		private readonly KurotatoSettleTipInfoItem CompletionTimeItem = new KurotatoSettleTipInfoItem();

		// Token: 0x0401DC40 RID: 121920
		private readonly KurotatoSettleTipInfoItem TotalKillsItem = new KurotatoSettleTipInfoItem();

		// Token: 0x0401DC41 RID: 121921
		private readonly KurotatoSettleTipInfoItem EndlessCompletionTimeItem = new KurotatoSettleTipInfoItem();

		// Token: 0x0401DC42 RID: 121922
		private readonly KurotatoSettleTipInfoItem EndlessTotalKillsItem = new KurotatoSettleTipInfoItem();

		// Token: 0x0401DC43 RID: 121923
		[Nullable(2)]
		private MultiTemplateScrollView ItemMultiTemplateScrollView;

		// Token: 0x0401DC44 RID: 121924
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0200B8E5 RID: 47333
		[NullableContext(0)]
		private class EComps
		{
			// Token: 0x04037EDB RID: 229083
			public const int PanelSuccess = 0;

			// Token: 0x04037EDC RID: 229084
			public const int PanelFailure = 1;

			// Token: 0x04037EDD RID: 229085
			public const int TextureEndless = 2;

			// Token: 0x04037EDE RID: 229086
			public const int TextureScore = 3;

			// Token: 0x04037EDF RID: 229087
			public const int TextureBg = 4;

			// Token: 0x04037EE0 RID: 229088
			public const int TextMode = 5;

			// Token: 0x04037EE1 RID: 229089
			public const int PanelNormal = 6;

			// Token: 0x04037EE2 RID: 229090
			public const int PanelCompletionTime = 7;

			// Token: 0x04037EE3 RID: 229091
			public const int PanelTotalKills = 8;

			// Token: 0x04037EE4 RID: 229092
			public const int PanelUnlockInfo = 9;

			// Token: 0x04037EE5 RID: 229093
			public const int PanelEndless = 10;

			// Token: 0x04037EE6 RID: 229094
			public const int PanelEndlessCompletionTime = 11;

			// Token: 0x04037EE7 RID: 229095
			public const int PanelEndlessTotalKills = 12;

			// Token: 0x04037EE8 RID: 229096
			public const int ArtTextNum = 13;

			// Token: 0x04037EE9 RID: 229097
			public const int ScrollItem = 14;

			// Token: 0x04037EEA RID: 229098
			public const int PanelTitle = 15;

			// Token: 0x04037EEB RID: 229099
			public const int PanelItem = 16;

			// Token: 0x04037EEC RID: 229100
			public const int PanelRole = 17;
		}
	}
}
