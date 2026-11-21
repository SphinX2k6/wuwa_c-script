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
	// Token: 0x020046FD RID: 18173
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSettleRightPanel : UiPanelBase
	{
		// Token: 0x0602DAA9 RID: 187049 RVA: 0x00CC4841 File Offset: 0x00CC2A41
		public EKurotatoSettlePageState GetCurrentPageState()
		{
			return this.PageState;
		}

		// Token: 0x0602DAAA RID: 187050 RVA: 0x00CC484C File Offset: 0x00CC2A4C
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

		// Token: 0x0602DAAB RID: 187051 RVA: 0x00CC4AD0 File Offset: 0x00CC2CD0
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoSettleRightPanel.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAAC RID: 187052 RVA: 0x00CC4B14 File Offset: 0x00CC2D14
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

		// Token: 0x0602DAAD RID: 187053 RVA: 0x00CC4BA0 File Offset: 0x00CC2DA0
		private UniTask CreateCompletionTimeItemAsync()
		{
			KurotatoSettleRightPanel.<CreateCompletionTimeItemAsync>d__15 <CreateCompletionTimeItemAsync>d__;
			<CreateCompletionTimeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCompletionTimeItemAsync>d__.<>4__this = this;
			<CreateCompletionTimeItemAsync>d__.<>1__state = -1;
			<CreateCompletionTimeItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateCompletionTimeItemAsync>d__15>(ref <CreateCompletionTimeItemAsync>d__);
			return <CreateCompletionTimeItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAAE RID: 187054 RVA: 0x00CC4BE4 File Offset: 0x00CC2DE4
		private UniTask CreateTotalKillsItemAsync()
		{
			KurotatoSettleRightPanel.<CreateTotalKillsItemAsync>d__16 <CreateTotalKillsItemAsync>d__;
			<CreateTotalKillsItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTotalKillsItemAsync>d__.<>4__this = this;
			<CreateTotalKillsItemAsync>d__.<>1__state = -1;
			<CreateTotalKillsItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateTotalKillsItemAsync>d__16>(ref <CreateTotalKillsItemAsync>d__);
			return <CreateTotalKillsItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAAF RID: 187055 RVA: 0x00CC4C28 File Offset: 0x00CC2E28
		private UniTask CreateEndlessCompletionTimeItemAsync()
		{
			KurotatoSettleRightPanel.<CreateEndlessCompletionTimeItemAsync>d__17 <CreateEndlessCompletionTimeItemAsync>d__;
			<CreateEndlessCompletionTimeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateEndlessCompletionTimeItemAsync>d__.<>4__this = this;
			<CreateEndlessCompletionTimeItemAsync>d__.<>1__state = -1;
			<CreateEndlessCompletionTimeItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateEndlessCompletionTimeItemAsync>d__17>(ref <CreateEndlessCompletionTimeItemAsync>d__);
			return <CreateEndlessCompletionTimeItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAB0 RID: 187056 RVA: 0x00CC4C6C File Offset: 0x00CC2E6C
		private UniTask CreateEndlessTotalKillsItemAsync()
		{
			KurotatoSettleRightPanel.<CreateEndlessTotalKillsItemAsync>d__18 <CreateEndlessTotalKillsItemAsync>d__;
			<CreateEndlessTotalKillsItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateEndlessTotalKillsItemAsync>d__.<>4__this = this;
			<CreateEndlessTotalKillsItemAsync>d__.<>1__state = -1;
			<CreateEndlessTotalKillsItemAsync>d__.<>t__builder.Start<KurotatoSettleRightPanel.<CreateEndlessTotalKillsItemAsync>d__18>(ref <CreateEndlessTotalKillsItemAsync>d__);
			return <CreateEndlessTotalKillsItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAB1 RID: 187057 RVA: 0x00CC4CAF File Offset: 0x00CC2EAF
		private void CreateItemMultiTemplateScrollView()
		{
			this.ItemMultiTemplateScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(14));
			this.RefreshScroll();
		}

		// Token: 0x0602DAB2 RID: 187058 RVA: 0x00CC4CCC File Offset: 0x00CC2ECC
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

		// Token: 0x0602DAB3 RID: 187059 RVA: 0x00CC4D44 File Offset: 0x00CC2F44
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

		// Token: 0x0602DAB4 RID: 187060 RVA: 0x00CC4E50 File Offset: 0x00CC3050
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

		// Token: 0x0602DAB5 RID: 187061 RVA: 0x00CC4E8C File Offset: 0x00CC308C
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

		// Token: 0x0602DAB6 RID: 187062 RVA: 0x00CC4FC8 File Offset: 0x00CC31C8
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

		// Token: 0x0602DAB7 RID: 187063 RVA: 0x00CC512C File Offset: 0x00CC332C
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

		// Token: 0x0602DAB8 RID: 187064 RVA: 0x00CC5314 File Offset: 0x00CC3514
		private void OnClickWeaponItem(List<KurotatoCardTip> cardData, int clickIndex)
		{
			KurotatoPopupItemDetailOpenParam param = new KurotatoPopupItemDetailOpenParam
			{
				Index = clickIndex,
				CardData = cardData
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, param, null);
		}

		// Token: 0x0602DAB9 RID: 187065 RVA: 0x00CC5348 File Offset: 0x00CC3548
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

		// Token: 0x0602DABA RID: 187066 RVA: 0x00CC5578 File Offset: 0x00CC3778
		private void OnClickItemItem(List<KurotatoCardTip> cardData, int clickIndex)
		{
			KurotatoPopupItemDetailOpenParam param = new KurotatoPopupItemDetailOpenParam
			{
				Index = clickIndex,
				CardData = cardData
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, param, null);
		}

		// Token: 0x0602DABB RID: 187067 RVA: 0x00CC55AA File Offset: 0x00CC37AA
		protected override void OnStart()
		{
			if (this.IsEndless)
			{
				this.RefreshEndlessMode();
				return;
			}
			this.RefreshNormalMode();
		}

		// Token: 0x0602DABC RID: 187068 RVA: 0x00CC55C1 File Offset: 0x00CC37C1
		public void SetPageState(EKurotatoSettlePageState state)
		{
			this.PageState = state;
			this.RefreshScroll();
		}

		// Token: 0x0602DABD RID: 187069 RVA: 0x00CC55D0 File Offset: 0x00CC37D0
		public void RefreshNormalMode()
		{
			this.RefreshModeInfo();
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			this.CompletionTimeItem.Refresh("Survivor_Wave", ((settlementData != null) ? settlementData.PassWaveCount : 0).ToString());
			this.TotalKillsItem.Refresh("Kurotato_Settle_TotalKills", ((settlementData != null) ? settlementData.CumulativeKills : 0).ToString());
			this.RefreshScroll();
		}

		// Token: 0x0602DABE RID: 187070 RVA: 0x00CC563C File Offset: 0x00CC383C
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

		// Token: 0x0602DABF RID: 187071 RVA: 0x00CC574C File Offset: 0x00CC394C
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

		// Token: 0x0602DAC0 RID: 187072 RVA: 0x00CC5874 File Offset: 0x00CC3A74
		private void RefreshScroll()
		{
			this.InitScrollViewData();
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.ItemMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x040186D1 RID: 100049
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

		// Token: 0x040186D2 RID: 100050
		private bool IsSuccess;

		// Token: 0x040186D3 RID: 100051
		private bool IsEndless;

		// Token: 0x040186D4 RID: 100052
		private EKurotatoSettlePageState PageState = EKurotatoSettlePageState.Info;

		// Token: 0x040186D5 RID: 100053
		private readonly KurotatoSettleTipInfoItem CompletionTimeItem = new KurotatoSettleTipInfoItem();

		// Token: 0x040186D6 RID: 100054
		private readonly KurotatoSettleTipInfoItem TotalKillsItem = new KurotatoSettleTipInfoItem();

		// Token: 0x040186D7 RID: 100055
		private readonly KurotatoSettleTipInfoItem EndlessCompletionTimeItem = new KurotatoSettleTipInfoItem();

		// Token: 0x040186D8 RID: 100056
		private readonly KurotatoSettleTipInfoItem EndlessTotalKillsItem = new KurotatoSettleTipInfoItem();

		// Token: 0x040186D9 RID: 100057
		[Nullable(2)]
		private MultiTemplateScrollView ItemMultiTemplateScrollView;

		// Token: 0x040186DA RID: 100058
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0200A306 RID: 41734
		[NullableContext(0)]
		private class EComps
		{
			// Token: 0x040328EB RID: 207083
			public const int PanelSuccess = 0;

			// Token: 0x040328EC RID: 207084
			public const int PanelFailure = 1;

			// Token: 0x040328ED RID: 207085
			public const int TextureEndless = 2;

			// Token: 0x040328EE RID: 207086
			public const int TextureScore = 3;

			// Token: 0x040328EF RID: 207087
			public const int TextureBg = 4;

			// Token: 0x040328F0 RID: 207088
			public const int TextMode = 5;

			// Token: 0x040328F1 RID: 207089
			public const int PanelNormal = 6;

			// Token: 0x040328F2 RID: 207090
			public const int PanelCompletionTime = 7;

			// Token: 0x040328F3 RID: 207091
			public const int PanelTotalKills = 8;

			// Token: 0x040328F4 RID: 207092
			public const int PanelUnlockInfo = 9;

			// Token: 0x040328F5 RID: 207093
			public const int PanelEndless = 10;

			// Token: 0x040328F6 RID: 207094
			public const int PanelEndlessCompletionTime = 11;

			// Token: 0x040328F7 RID: 207095
			public const int PanelEndlessTotalKills = 12;

			// Token: 0x040328F8 RID: 207096
			public const int ArtTextNum = 13;

			// Token: 0x040328F9 RID: 207097
			public const int ScrollItem = 14;

			// Token: 0x040328FA RID: 207098
			public const int PanelTitle = 15;

			// Token: 0x040328FB RID: 207099
			public const int PanelItem = 16;

			// Token: 0x040328FC RID: 207100
			public const int PanelRole = 17;
		}
	}
}
