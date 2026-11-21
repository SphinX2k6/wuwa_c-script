using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Encircle;
using Aki.Game.Module.Activity.ActivityContent.Tetris.View;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.ExploreLevel;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004785 RID: 18309
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ItemRewardController : UiControllerBase
	{
		// Token: 0x0602DF8E RID: 188302 RVA: 0x00CDCBDC File Offset: 0x00CDADDC
		protected override bool OnInit()
		{
			this.SoarStrengthItemId = ConfigCommonParamById.GetIntConfig("FlyStrengthItemId").Value;
			return true;
		}

		// Token: 0x0602DF8F RID: 188303 RVA: 0x00CDCC02 File Offset: 0x00CDAE02
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.ItemObtainNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMsgItemObtainNotify));
		}

		// Token: 0x0602DF90 RID: 188304 RVA: 0x00CDCC20 File Offset: 0x00CDAE20
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ItemObtainNotify);
		}

		// Token: 0x0602DF91 RID: 188305 RVA: 0x00CDCC34 File Offset: 0x00CDAE34
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnItemRewardNotify, new Action<ItemRewardNotify>(this.OnItemRewardNotify));
			EventSystem.Instance.Add(EEventName.OnExploreRewardShowEnd, new Action(this.OnExploreLevelRewardViewShowEnd));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0602DF92 RID: 188306 RVA: 0x00CDCC98 File Offset: 0x00CDAE98
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnItemRewardNotify, new Action<ItemRewardNotify>(this.OnItemRewardNotify));
			EventSystem.Instance.Remove(EEventName.OnExploreRewardShowEnd, new Action(this.OnExploreLevelRewardViewShowEnd));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0602DF93 RID: 188307 RVA: 0x00CDCCFC File Offset: 0x00CDAEFC
		private void OnWorldDone()
		{
			List<RewardData<ICommonRewardInfo>> cacheCommonRewardDataList = ItemRewardModel.Instance.CacheCommonRewardDataList;
			if (cacheCommonRewardDataList.Count > 0)
			{
				this.Open<ICommonRewardInfo>(cacheCommonRewardDataList[0], null);
			}
		}

		// Token: 0x0602DF94 RID: 188308 RVA: 0x00CDCD2C File Offset: 0x00CDAF2C
		public int[] GetRewardViewReasonArray()
		{
			if (this.RewardViewReasonArray != null)
			{
				return this.RewardViewReasonArray;
			}
			this.RewardViewReasonArray = new int[0];
			IEnumerable<RewardViewFromSource> allRewardViewFromSourceConfig = ItemRewardConfig.Instance.GetAllRewardViewFromSourceConfig();
			List<int> list = new List<int>();
			foreach (RewardViewFromSource rewardViewFromSource in allRewardViewFromSourceConfig)
			{
				list.Add(rewardViewFromSource.RewardSourceId);
			}
			this.RewardViewReasonArray = list.ToArray();
			return this.RewardViewReasonArray;
		}

		// Token: 0x0602DF95 RID: 188309 RVA: 0x00CDCDB8 File Offset: 0x00CDAFB8
		private void ApplyDailyActivityLivenessUnionExpSplitForDisplay(int reasonId, [Nullable(2)] ItemRewardNotify notify, List<RewardItemData> rewardItemDataList)
		{
			if (reasonId != 19600)
			{
				return;
			}
			DailyActivityModel.LivenessUnionExpBonusSplitRule livenessUnionExpBonusSplitRule;
			if (!DailyActivityModel.Instance.TryGetActiveLivenessUnionExpBonusSplitRule(out livenessUnionExpBonusSplitRule))
			{
				return;
			}
			MapField<int, RewardItemInfoList> mapField = (notify != null) ? notify.RewardItems : null;
			if (mapField != null)
			{
				foreach (KeyValuePair<int, RewardItemInfoList> keyValuePair in mapField)
				{
					if (keyValuePair.Key != 0)
					{
						RewardItemInfoList value = keyValuePair.Value;
						RepeatedField<RewardItemInfo> repeatedField = (value != null) ? value.ItemList : null;
						if (repeatedField != null && repeatedField.Count != 0)
						{
							bool flag = false;
							using (IEnumerator<RewardItemInfo> enumerator2 = repeatedField.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.ItemId == 1)
									{
										flag = true;
										break;
									}
								}
							}
							if (flag)
							{
								return;
							}
						}
					}
				}
			}
			bool flag2 = false;
			foreach (RewardItemData rewardItemData in rewardItemDataList)
			{
				if (rewardItemData.ConfigId == 1 && rewardItemData.GetDropItemType() == EDropItemType.Activity)
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < rewardItemDataList.Count; i++)
			{
				RewardItemData rewardItemData2 = rewardItemDataList[i];
				if (rewardItemData2.ConfigId == 1 && rewardItemData2.GetDropItemType() == EDropItemType.Normal)
				{
					if (num >= 0)
					{
						return;
					}
					num = i;
				}
			}
			if (num < 0)
			{
				return;
			}
			RewardItemData rewardItemData3 = rewardItemDataList[num];
			int count = rewardItemData3.Count;
			int num2 = count / 2;
			int num3 = count - num2;
			if (num3 <= 0 || num2 <= 0)
			{
				return;
			}
			rewardItemData3.Count = num2;
			rewardItemDataList.Add(new RewardItemData(1, num3, new int?(rewardItemData3.UniqueId), EDropItemType.Activity));
		}

		// Token: 0x0602DF96 RID: 188310 RVA: 0x00CDCF80 File Offset: 0x00CDB180
		private unsafe void OnItemRewardNotify(ItemRewardNotify notify)
		{
			MapField<int, RewardItemInfoList> rewardItems = notify.RewardItems;
			ICollection<int> keys = rewardItems.Keys;
			if (rewardItems == null || keys == null)
			{
				return;
			}
			int reason = notify.Reason;
			RewardViewFromSource? rewardViewFromSource = (Array.IndexOf<int>(this.GetRewardViewReasonArray(), reason) >= 0) ? ItemRewardConfig.Instance.GetRewardViewFromSourceConfig(reason) : null;
			if (rewardViewFromSource != null && rewardViewFromSource.Value.RewardNotifyNotTrick)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Reward;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "[ItemRewardController]当掉落协议通知时,配置上不触发后续处理";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rewardViewConfig", rewardViewFromSource.Value.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			List<RewardItemData> list = new List<RewardItemData>();
			List<RewardItemData> list2 = new List<RewardItemData>();
			List<RewardItemData> list3 = new List<RewardItemData>();
			int soarStrengthItemCount = 0;
			foreach (int key in keys)
			{
				RewardItemInfoList rewardItemInfoList = rewardItems[key];
				RepeatedField<RewardItemInfo> repeatedField = (rewardItemInfoList != null) ? rewardItemInfoList.ItemList : null;
				if (repeatedField != null && repeatedField.Count != 0)
				{
					int dropItemType = int.Parse(key.ToString());
					foreach (RewardItemInfo rewardItemInfo in repeatedField)
					{
						InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(rewardItemInfo.ItemId));
						RewardItemData item = new RewardItemData(rewardItemInfo.ItemId, rewardItemInfo.Count, new int?(rewardItemInfo.IncrId), (EDropItemType)dropItemType);
						if (rewardItemInfo.ItemId == this.SoarStrengthItemId)
						{
							soarStrengthItemCount += rewardItemInfo.Count;
						}
						if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleSkinItem)
						{
							list2.Add(item);
						}
						else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.FlySkinItem)
						{
							if (ConfigFlySkinConfigById.GetConfig(rewardItemInfo.ItemId, true).Value.IsSpecialViewAfterObtain)
							{
								list3.Add(item);
							}
							else
							{
								list.Add(item);
							}
						}
						else
						{
							list.Add(item);
						}
					}
				}
			}
			this.ApplyDailyActivityLivenessUnionExpSplitForDisplay(reason, notify, list);
			if (Array.IndexOf<int>(ItemRewardDefine.FillRoleDevelopStateTagReasonIdList, reason) >= 0)
			{
				ItemRewardRoleDevelopStateTagUtil.FillRewardRoleDevelopStateTagType(list);
			}
			ItemRewardModel instance2 = ItemRewardModel.Instance;
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[ItemRewardController]当掉落协议通知时";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("reasonId", reason);
			instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			int? currentReasonId = instance2.CurrentReasonId;
			int num = reason;
			if (!(currentReasonId.GetValueOrDefault() == num & currentReasonId != null))
			{
				instance2.ClearCurrentRewardData();
			}
			instance2.CurrentReasonId = new int?(reason);
			if (Array.IndexOf<int>(ItemRewardDefine.BlockReasonIdList, reason) >= 0)
			{
				return;
			}
			if (reason == 20200)
			{
				this.OpenExploreLevelRewardView(list.ToArray());
				return;
			}
			if (reason == 52401)
			{
				this.OpenEncircleRewardView(list);
				return;
			}
			if (reason == 19707)
			{
				RoguelikeModel.Instance.ShowRewardList = list;
				KuroSdkReport.Instance.OnRougeFinish();
				return;
			}
			if (reason == 15008)
			{
				List<IRewardExploreConfirmButton> list4 = new List<IRewardExploreConfirmButton>();
				RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
				rewardExploreConfirmButtonData.ButtonTextId = "ConfirmBox_45_ButtonText_1";
				rewardExploreConfirmButtonData.DescriptionTextId = null;
				rewardExploreConfirmButtonData.DescriptionArgs = null;
				rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
				rewardExploreConfirmButtonData.IsClickedCloseView = false;
				rewardExploreConfirmButtonData.OnClickedCallback = delegate(int index)
				{
					if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
					{
						UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
					}
				};
				RewardExploreConfirmButtonData item2 = rewardExploreConfirmButtonData;
				list4.Add(item2);
				string tip = null;
				if (notify.Magnification > 1)
				{
					DoubleDropFrom from = notify.From;
					if (from != DoubleDropFrom.DoubleActivity)
					{
						if (from == DoubleDropFrom.FromRegress)
						{
							int lastUnGetRewardLevelPlayId = ActivityRegressModel.Instance.LastUnGetRewardLevelPlayId;
							if (lastUnGetRewardLevelPlayId != 0)
							{
								ActivityRegressModel.Instance.LastUnGetRewardLevelPlayId = 0;
								ValueTuple<bool, int, int, string, string> levelPlayDoubleDropTuple = ActivityRegressModel.Instance.GetLevelPlayDoubleDropTuple(lastUnGetRewardLevelPlayId);
								bool item3 = levelPlayDoubleDropTuple.Item1;
								int item4 = levelPlayDoubleDropTuple.Item2;
								int item5 = levelPlayDoubleDropTuple.Item3;
								string item6 = levelPlayDoubleDropTuple.Item4;
								string item7 = levelPlayDoubleDropTuple.Item5;
								if (item3)
								{
									string multiText = TextConfig.Instance.GetMultiText(item7, Array.Empty<string>());
									string multiText2 = TextConfig.Instance.GetMultiText(item6, new string[]
									{
										item4.ToString(),
										item5.ToString()
									});
									tip = multiText + multiText2;
								}
							}
						}
					}
					else
					{
						ActivityDoubleRewardController instance4 = ActivityDoubleRewardController.Instance;
						num = 1;
						List<int> list5 = new List<int>(num);
						CollectionsMarshal.SetCount<int>(list5, num);
						Span<int> span = CollectionsMarshal.AsSpan<int>(list5);
						int index2 = 0;
						*span[index2] = 3;
						tip = instance4.GetDungeonUpActivityFullTip(list5, false);
					}
				}
				this.OpenExploreRewardView(3006, true, list, null, null, list4, null, null, null, tip, null, null, null, null, new bool?(true), null, null);
				return;
			}
			if (reason == 6003 && rewardViewFromSource != null)
			{
				this.OpenQuestRewardView(rewardViewFromSource.Value.RewardViewId, list, null);
				return;
			}
			if (rewardViewFromSource == null)
			{
				this.AddItemList(list);
				return;
			}
			if (list2.Count > 0)
			{
				SkinController.Instance.OpenObtainSkinView(list2.ToArray(), list.ToArray());
				return;
			}
			if (list3.Count > 0)
			{
				SkinController.Instance.OpenObtainFlySkinView(list3.ToArray(), list.ToArray());
				return;
			}
			int rewardViewId = rewardViewFromSource.Value.RewardViewId;
			if (soarStrengthItemCount > 0)
			{
				this.OpenCommonRewardView(rewardViewId, list, delegate
				{
					this.OpenSoarStrengthUpView(soarStrengthItemCount);
				});
				return;
			}
			this.OpenCommonRewardView(rewardViewId, list, null);
		}

		// Token: 0x0602DF97 RID: 188311 RVA: 0x00CDD508 File Offset: 0x00CDB708
		[NullableContext(2)]
		private void OnMsgItemObtainNotify(IMessage msg, Net.CallbackStatus _)
		{
			ItemObtainNotify notify = (ItemObtainNotify)msg;
			this.OnItemObtainNotify(notify, null);
		}

		// Token: 0x0602DF98 RID: 188312 RVA: 0x00CDD524 File Offset: 0x00CDB724
		public void OnItemObtainNotify(ItemObtainNotify notify, [Nullable(2)] Action<bool?> callback)
		{
			RepeatedField<RewardItemPackage> rewardItemPackages = notify.RewardItemPackages;
			if (rewardItemPackages.Count <= 0)
			{
				return;
			}
			if (this.TryShowConsoleExtraPayGiftPreview(notify.Reason, delegate
			{
				this.OnItemObtainNotify(notify, callback);
			}))
			{
				return;
			}
			List<RewardItemData> list = new List<RewardItemData>();
			List<RewardItemData> list2 = new List<RewardItemData>();
			List<RewardItemData> list3 = new List<RewardItemData>();
			List<RewardItemData> list4 = new List<RewardItemData>();
			List<RewardItemData> list5 = new List<RewardItemData>();
			List<RewardItemPackage> list6 = new List<RewardItemPackage>();
			int num = 0;
			foreach (RewardItemPackage rewardItemPackage in rewardItemPackages)
			{
				InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(rewardItemPackage.RewardItem.Id));
				if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
				{
					list6.Add(rewardItemPackage);
				}
				else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleSkinItem)
				{
					RewardItemData item = new RewardItemData(rewardItemPackage.RewardItem.Id, rewardItemPackage.RewardItem.Count, new int?(rewardItemPackage.RewardItem.IncrId), EDropItemType.Normal);
					list2.Add(item);
				}
				else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.FlySkinItem)
				{
					RewardItemData item2 = new RewardItemData(rewardItemPackage.RewardItem.Id, rewardItemPackage.RewardItem.Count, new int?(rewardItemPackage.RewardItem.IncrId), EDropItemType.Normal);
					if (ConfigFlySkinConfigById.GetConfig(rewardItemPackage.RewardItem.Id, true).Value.IsSpecialViewAfterObtain)
					{
						list3.Add(item2);
					}
					else
					{
						list.Add(item2);
					}
				}
				else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorFrameItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorStickerItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorDecorationItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorSkinItem)
				{
					RewardItemData item3 = new RewardItemData(rewardItemPackage.RewardItem.Id, rewardItemPackage.RewardItem.Count, new int?(rewardItemPackage.RewardItem.IncrId), EDropItemType.Normal);
					list4.Add(item3);
					list.Add(item3);
				}
				else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.OrnamentItem)
				{
					RewardItemData item4 = new RewardItemData(rewardItemPackage.RewardItem.Id, rewardItemPackage.RewardItem.Count, new int?(rewardItemPackage.RewardItem.IncrId), EDropItemType.Normal);
					list5.Add(item4);
					list.Add(item4);
				}
				else
				{
					RewardItemData item5 = new RewardItemData(rewardItemPackage.RewardItem.Id, rewardItemPackage.RewardItem.Count, new int?(rewardItemPackage.RewardItem.IncrId), EDropItemType.Normal);
					if (rewardItemPackage.RewardItem.Id == this.SoarStrengthItemId)
					{
						num += rewardItemPackage.RewardItem.Count;
					}
					list.Add(item5);
				}
			}
			int reason = notify.Reason;
			this.ApplyDailyActivityLivenessUnionExpSplitForDisplay(reason, null, list);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[ItemRewardController]当服务端通知奖励获得时";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reasonId", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DispatchPackagedReward(reason, list, list6, list2, list3, list4, list5, num, callback, notify);
		}

		// Token: 0x0602DF99 RID: 188313 RVA: 0x00CDD850 File Offset: 0x00CDBA50
		public void DispatchPackagedReward(int reasonId, List<RewardItemData> rewardItemDataList, List<RewardItemPackage> characterItemList, List<RewardItemData> obtainSkinItemDataList, List<RewardItemData> obtainFlySkinItemDataList, List<RewardItemData> obtainMotorItemDataList, List<RewardItemData> obtainOrnamentItemDataList, int soarStrengthItemCount, [Nullable(2)] Action<bool?> callback = null, [Nullable(2)] ItemObtainNotify originNotify = null)
		{
			if (Array.IndexOf<int>(ItemRewardDefine.BlockObtainReasonIdList, reasonId) >= 0)
			{
				return;
			}
			bool flag = false;
			using (List<RewardItemData>.Enumerator enumerator = rewardItemDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ConfigId == 50021)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				return;
			}
			ItemRewardModel instance = ItemRewardModel.Instance;
			int? currentReasonId = instance.CurrentReasonId;
			if (!(currentReasonId.GetValueOrDefault() == reasonId & currentReasonId != null))
			{
				instance.ClearCurrentRewardData();
			}
			instance.CurrentReasonId = new int?(reasonId);
			RewardViewFromSource? rewardViewFromSource = (Array.IndexOf<int>(this.GetRewardViewReasonArray(), reasonId) >= 0) ? ItemRewardConfig.Instance.GetRewardViewFromSourceConfig(reasonId) : null;
			if (rewardViewFromSource != null)
			{
				int rewardViewId = rewardViewFromSource.Value.RewardViewId;
				int rewardSourceId = rewardViewFromSource.Value.RewardSourceId;
				if (rewardSourceId == 13000 && !ItemExchangeController.Instance.NeedPop)
				{
					return;
				}
				if (rewardSourceId == 6003)
				{
					this.OpenQuestRewardView(rewardViewId, rewardItemDataList, delegate
					{
						Action<bool?> callback2 = callback;
						if (callback2 == null)
						{
							return;
						}
						callback2(null);
					});
					return;
				}
				if (rewardSourceId == 27002)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_AutoMaterial", Array.Empty<object>());
					return;
				}
				if (soarStrengthItemCount > 0)
				{
					this.OpenObtainItemNormalRewardView(reasonId, rewardViewId, rewardItemDataList, delegate
					{
						this.OpenSoarStrengthUpView(soarStrengthItemCount);
					});
					return;
				}
				if ((rewardSourceId == 18500 || rewardSourceId == 18504 || rewardSourceId == 18505) && BattlePassController.Instance.IsNeedExtraRewardView())
				{
					this.OpenBattlePassExtraRewardView(rewardItemDataList);
					return;
				}
				if (rewardSourceId == 48007 && !ActivityRegressModel.Instance.ActivityData.IsPayRewardUnlock() && ActivityRegressController.Instance.IsNeedExtraRewardView())
				{
					this.OpenRegressBpRewardView(rewardItemDataList);
					return;
				}
				if (reasonId == 53101)
				{
					this.OpenCommonRewardView(rewardViewId, rewardItemDataList, delegate
					{
						TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
						if (tetrisPlayView != null)
						{
							tetrisPlayView.TetrisRewardClose();
						}
					});
					return;
				}
				if (obtainMotorItemDataList.Count > 0 && reasonId == 8001)
				{
					this.OpenMotorItemRewardView(rewardViewId, rewardItemDataList, obtainMotorItemDataList);
					return;
				}
				if (characterItemList.Count == 0 && obtainSkinItemDataList.Count == 0 && obtainFlySkinItemDataList.Count == 0 && obtainOrnamentItemDataList.Count == 0)
				{
					this.OpenObtainItemNormalRewardView(reasonId, rewardViewId, rewardItemDataList, delegate
					{
						Action<bool?> callback2 = callback;
						if (callback2 == null)
						{
							return;
						}
						callback2(null);
					});
					return;
				}
				if (rewardItemDataList.Count == 0 && characterItemList.Count > 0)
				{
					using (List<RewardItemPackage>.Enumerator enumerator2 = characterItemList.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							RewardItemPackage itemPackage = enumerator2.Current;
							GachaController.Instance.CommonShowRoleResult(itemPackage, true, false);
						}
						return;
					}
				}
				if (obtainSkinItemDataList.Count > 0)
				{
					SkinController.Instance.OpenObtainSkinView(obtainSkinItemDataList.ToArray(), rewardItemDataList.ToArray());
					return;
				}
				if (obtainFlySkinItemDataList.Count > 0)
				{
					SkinController.Instance.OpenObtainFlySkinView(obtainFlySkinItemDataList.ToArray(), rewardItemDataList.ToArray());
					return;
				}
				if (obtainOrnamentItemDataList.Count > 0)
				{
					this.OpenOrnamentItemRewardView(rewardViewId, rewardItemDataList, obtainOrnamentItemDataList, delegate
					{
						Action<bool?> callback2 = callback;
						if (callback2 == null)
						{
							return;
						}
						callback2(null);
					});
					return;
				}
				this.OpenObtainItemNormalRewardView(reasonId, rewardViewId, rewardItemDataList, delegate
				{
					foreach (RewardItemPackage itemPackage2 in characterItemList)
					{
						GachaController.Instance.CommonShowRoleResult(itemPackage2, true, false);
					}
					Action<bool?> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(null);
				});
				return;
			}
			else if (reasonId > 50000)
			{
				int? intConfig = ConfigCommonParamById.GetIntConfig("DefaultConfigId");
				if (intConfig != null)
				{
					this.OpenObtainItemNormalRewardView(reasonId, intConfig.Value, rewardItemDataList, delegate
					{
						Action<bool?> callback2 = callback;
						if (callback2 == null)
						{
							return;
						}
						callback2(null);
					});
					return;
				}
			}
			else
			{
				this.AddItemList(rewardItemDataList);
				if (callback != null)
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.Reward;
					ELogAuthor author = ELogAuthor.ZJC;
					string message = "OnItemObtainNotify err";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", originNotify);
					instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}

		// Token: 0x0602DF9A RID: 188314 RVA: 0x00CDDC24 File Offset: 0x00CDBE24
		[NullableContext(2)]
		private void OpenObtainItemNormalRewardView(int reasonId, int configId, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, Action onCloseCallback = null)
		{
			if (reasonId == 8001)
			{
				this.OpenPayRewardView(configId, rewardItemDataList, onCloseCallback);
				return;
			}
			this.OpenCommonRewardView(configId, rewardItemDataList, onCloseCallback);
		}

		// Token: 0x0602DF9B RID: 188315 RVA: 0x00CDDC44 File Offset: 0x00CDBE44
		[NullableContext(2)]
		public void OpenCommonRewardView(int configId, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, Action onCloseCallback = null)
		{
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(configId, EUiViewName.CommonRewardView, rewardItemDataList, onCloseCallback, null, null, null, null, true, false);
			if (rewardData == null)
			{
				return;
			}
			this.Open<ICommonRewardInfo>(rewardData, null);
		}

		// Token: 0x0602DF9C RID: 188316 RVA: 0x00CDDC78 File Offset: 0x00CDBE78
		[NullableContext(2)]
		public void OpenPayRewardView(int configId, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, Action onCloseCallback = null)
		{
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.CreateCommonRewardDataFromConfig(configId, EUiViewName.PayRewardView, rewardItemDataList, onCloseCallback, null, null, null, null, true, false);
			if (rewardData == null)
			{
				return;
			}
			ItemRewardModel.Instance.CacheCommonRewardDataList.Add(rewardData);
			if (GameModeModel.Instance.WorldDone)
			{
				this.Open<ICommonRewardInfo>(rewardData, null);
			}
		}

		// Token: 0x0602DF9D RID: 188317 RVA: 0x00CDDCC8 File Offset: 0x00CDBEC8
		[NullableContext(2)]
		public void OpenQuestRewardView(int configId, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, Action onCloseCallback = null)
		{
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(configId, EUiViewName.QuestRewardView, rewardItemDataList, onCloseCallback, null, null, null, null, true, false);
			if (rewardData == null)
			{
				return;
			}
			this.Open<ICommonRewardInfo>(rewardData, null);
		}

		// Token: 0x0602DF9E RID: 188318 RVA: 0x00CDDCFC File Offset: 0x00CDBEFC
		private bool TryShowConsoleExtraPayGiftPreview(int reasonId, Action onConfirm)
		{
			ItemRewardController.<>c__DisplayClass19_0 CS$<>8__locals1 = new ItemRewardController.<>c__DisplayClass19_0();
			CS$<>8__locals1.onConfirm = onConfirm;
			PayShopModel instance = PayShopModel.Instance;
			if (instance == null)
			{
				return false;
			}
			PayGiftPreviewBuildResult payGiftPreviewBuildResult = instance.TryBuildConsoleExtraPayGiftPreview(reasonId);
			if (payGiftPreviewBuildResult == null)
			{
				return false;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("DefaultConfigId");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.YZY, "[ConsoleExtraPayGift] DefaultConfigId missing, fallback to normal flow", default(ReadOnlySpan<ValueTuple<string, object>>));
				instance.ClearPreviewPayGiftEntries();
				return false;
			}
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(intConfig.Value, EUiViewName.CommonRewardView, payGiftPreviewBuildResult.PreviewItems, new Action(CS$<>8__locals1.<TryShowConsoleExtraPayGiftPreview>g__previewOnClose|0), null, "PayGiftUseConfirm", null, null, true, true);
			if (rewardData == null)
			{
				instance.ClearPreviewPayGiftEntries();
				return false;
			}
			this.Open<ICommonRewardInfo>(rewardData, null);
			return true;
		}

		// Token: 0x0602DF9F RID: 188319 RVA: 0x00CDDDB4 File Offset: 0x00CDBFB4
		public void OpenExploreLevelRewardView([Nullable(new byte[]
		{
			2,
			1
		})] RewardItemData[] rewardItemDataList = null)
		{
			CountryExploreLevelData currentCountryExploreLevelData = ExploreLevelModel.Instance.GetCurrentCountryExploreLevelData();
			if (currentCountryExploreLevelData == null)
			{
				return;
			}
			int exploreLevel = currentCountryExploreLevelData.GetExploreLevel();
			this.ExploreRewardQueue.Push(new ValueTuple<RewardItemData[], int>(rewardItemDataList ?? Array.Empty<RewardItemData>(), exploreLevel));
			if (this.ExploreRewardQueue.Size == 1)
			{
				this.OpenExploreLevelRewardViewFromQueue();
			}
		}

		// Token: 0x0602DFA0 RID: 188320 RVA: 0x00CDDE06 File Offset: 0x00CDC006
		private void OnExploreLevelRewardViewShowEnd()
		{
			this.ExploreRewardQueue.Pop();
			this.OpenExploreLevelRewardViewFromQueue();
		}

		// Token: 0x0602DFA1 RID: 188321 RVA: 0x00CDDE1C File Offset: 0x00CDC01C
		private void OpenExploreLevelRewardViewFromQueue()
		{
			if (this.ExploreRewardQueue.Empty)
			{
				return;
			}
			ValueTuple<RewardItemData[], int> front = this.ExploreRewardQueue.Front;
			RewardItemData[] item = front.Item1;
			int item2 = front.Item2;
			RewardData<IExploreLevelRewardInfo> exploreLevelRewardData = ItemRewardModel.Instance.GetExploreLevelRewardData(EUiViewName.ExploreLevelRewardView, item2, item2 + 1, new List<RewardItemData>(item));
			this.Open<IExploreLevelRewardInfo>(exploreLevelRewardData, null);
		}

		// Token: 0x0602DFA2 RID: 188322 RVA: 0x00CDDE74 File Offset: 0x00CDC074
		public void OpenCompositeRewardView(int configId, bool isSuccess = true, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardProgress> progressQueue = null)
		{
			RewardData<ICompositeRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCompositeRewardDataFromConfig(configId, isSuccess, rewardItemDataList, progressQueue);
			if (rewardData == null)
			{
				return;
			}
			this.Open<ICompositeRewardInfo>(rewardData, null);
		}

		// Token: 0x0602DFA3 RID: 188323 RVA: 0x00CDDEA0 File Offset: 0x00CDC0A0
		[NullableContext(2)]
		public bool OpenExploreRewardView(int configId, bool isSuccess = true, [Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemDataList = null, IRewardExploreRecord exploreRecordInfo = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreBar> exploreBarDataList = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreConfirmButton> buttonInfoList = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreTargetReached> targetReached = null, IRewardExploreToggle stateToggle = null, Action onCloseCallback = null, string tip = null, Action<bool> finishCallback = null, bool? isShowOnlineChallengePlayer = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardExploreFriendData> exploreFriendDataList = null, ReachTargetData scoreReachedData = null, bool? isRewardMultiLine = null, AccumulatedScoreData accumulatedScoreData = null, string titleTextId = null)
		{
			RewardData<IExploreRewardInfo> rewardData = ItemRewardModel.Instance.RefreshExploreRewardDataFromConfig(configId, isSuccess, rewardItemDataList, exploreRecordInfo, exploreBarDataList, buttonInfoList, targetReached, stateToggle, onCloseCallback, tip, isShowOnlineChallengePlayer, exploreFriendDataList, scoreReachedData, isRewardMultiLine, accumulatedScoreData, titleTextId);
			if (rewardData == null)
			{
				return false;
			}
			this.Open<IExploreRewardInfo>(rewardData, finishCallback);
			return true;
		}

		// Token: 0x0602DFA4 RID: 188324 RVA: 0x00CDDEE4 File Offset: 0x00CDC0E4
		public bool OpenExploreRewardViewNew(IExploreRewardViewData data)
		{
			RewardData<IExploreRewardInfo> rewardData = ItemRewardModel.Instance.RefreshExploreRewardDataFromConfigNew(data);
			if (rewardData == null)
			{
				return false;
			}
			this.Open<IExploreRewardInfo>(rewardData, data.FinishCallback);
			return true;
		}

		// Token: 0x0602DFA5 RID: 188325 RVA: 0x00CDDF10 File Offset: 0x00CDC110
		public bool OpenBattlePassExtraRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<IBattlePassExtraRewardInfo> rewardData = BattlePassController.Instance.BuildExtraRewardData(rewardItemDataList);
			this.Open<IBattlePassExtraRewardInfo>(rewardData, rewardData.GetRewardInfo().FinishCallback);
			return true;
		}

		// Token: 0x0602DFA6 RID: 188326 RVA: 0x00CDDF3C File Offset: 0x00CDC13C
		public bool OpenRegressBpRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<IBattlePassExtraRewardInfo> rewardData = ActivityRegressController.Instance.BuildExtraRewardData(rewardItemDataList);
			this.Open<IBattlePassExtraRewardInfo>(rewardData, rewardData.GetRewardInfo().FinishCallback);
			return true;
		}

		// Token: 0x0602DFA7 RID: 188327 RVA: 0x00CDDF68 File Offset: 0x00CDC168
		public bool OpenEncircleRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<IEncircleRewardInfo> rewardData = ActivityEncircleController.Instance.BuildRewardData(rewardItemDataList);
			this.Open<IEncircleRewardInfo>(rewardData, null);
			return true;
		}

		// Token: 0x0602DFA8 RID: 188328 RVA: 0x00CDDF8C File Offset: 0x00CDC18C
		public bool OpenMotorItemRewardView(int configId, List<RewardItemData> rewardItemDataList, List<RewardItemData> obtainMotorItemDataList)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.MotorDevelop);
			bool flag2 = false;
			if (flag)
			{
				flag2 = MotorcycleDiyModel.Instance.IsEquipDefaultSkin();
			}
			bool flag3 = flag && flag2;
			string leftBtnTextId = flag ? "MotorBike_Shop_CloseButton" : null;
			string rightBtnTextId = flag3 ? "MotorBike_Shop_EquipButton" : null;
			int jumpDiyType = 0;
			if (UiManager.Instance.IsViewOpen(EUiViewName.MotorSkinBuyDetailView))
			{
				MotorSkinBuyDetailView motorSkinBuyDetailView = UiManager.Instance.GetViewByName(EUiViewName.MotorSkinBuyDetailView) as MotorSkinBuyDetailView;
				MotorSkinBuyDetailViewData motorSkinBuyDetailViewData = (motorSkinBuyDetailView != null) ? motorSkinBuyDetailView.GetViewData() : null;
				if (motorSkinBuyDetailViewData != null)
				{
					ShopMotorSkinData currentGoodsData = motorSkinBuyDetailViewData.GetCurrentGoodsData();
					MotorSkinData motorSkinData = (currentGoodsData != null) ? currentGoodsData.GetMotorSkinData() : null;
					MotorSkinShow? motorSkinShow = (motorSkinData != null) ? motorSkinData.GetMotorSkinShow() : null;
					if (motorSkinShow != null)
					{
						jumpDiyType = motorSkinShow.Value.JumpDiyRoot;
					}
				}
			}
			Action rightAction = flag3 ? delegate()
			{
				MotorcycleDiyController.Instance.OpenTargetViewByReward(new List<RewardItemData>(obtainMotorItemDataList), jumpDiyType);
			} : null;
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(configId, EUiViewName.CommonRewardView, rewardItemDataList, null, leftBtnTextId, rightBtnTextId, new Action(ItemRewardController.<OpenMotorItemRewardView>g__quitCallback|29_0), rightAction, false, false);
			if (rewardData == null)
			{
				return false;
			}
			this.Open<ICommonRewardInfo>(rewardData, null);
			return true;
		}

		// Token: 0x0602DFA9 RID: 188329 RVA: 0x00CDE0B4 File Offset: 0x00CDC2B4
		public bool OpenOrnamentItemRewardView(int configId, List<RewardItemData> rewardItemDataList, List<RewardItemData> obtainOrnamentItemDataList, [Nullable(2)] Action onCloseCallback = null)
		{
			ItemRewardController.<>c__DisplayClass30_0 CS$<>8__locals1 = new ItemRewardController.<>c__DisplayClass30_0();
			CS$<>8__locals1.onCloseCallback = onCloseCallback;
			CS$<>8__locals1.obtainOrnamentItemDataList = obtainOrnamentItemDataList;
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(configId, EUiViewName.CommonRewardView, rewardItemDataList, null, "MotorBike_Shop_CloseButton", "OrnamentShop_text_01", new Action(CS$<>8__locals1.<OpenOrnamentItemRewardView>g__quitCallback|0), new Action(CS$<>8__locals1.<OpenOrnamentItemRewardView>g__equipCallback|1), false, false);
			if (rewardData == null)
			{
				return false;
			}
			this.Open<ICommonRewardInfo>(rewardData, null);
			return true;
		}

		// Token: 0x0602DFAA RID: 188330 RVA: 0x00CDE11C File Offset: 0x00CDC31C
		public void Open<[Nullable(0)] T>(RewardData<T> rewardData, [Nullable(2)] Action<bool> finishCallback = null) where T : IRewardInfo
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.DrawMainView))
			{
				return;
			}
			T rewardInfo = rewardData.GetRewardInfo();
			if (UiManager.Instance.IsViewOpen(rewardInfo.ViewName))
			{
				EventSystem.Instance.Emit<IRewardDataInterface>(EEventName.OnRefreshRewardView, rewardData);
				return;
			}
			EUiViewName viewName = rewardInfo.ViewName;
			UiManager.Instance.OpenView(viewName, rewardData, delegate(bool success, int viewId)
			{
				Action<bool> finishCallback2 = finishCallback;
				if (finishCallback2 != null)
				{
					finishCallback2(success);
				}
				if (!success)
				{
					return;
				}
				UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
				if (uiViewBase == null)
				{
					return;
				}
				uiViewBase.AddChildViewById(viewId);
			});
		}

		// Token: 0x0602DFAB RID: 188331 RVA: 0x00CDE1A0 File Offset: 0x00CDC3A0
		public void Close([Nullable(new byte[]
		{
			2,
			1
		})] RewardData<IRewardInfo> rewardData = null)
		{
			if (rewardData != null)
			{
				EUiViewName viewName = rewardData.GetRewardInfo().ViewName;
				if (UiManager.Instance.IsViewShow(viewName))
				{
					UiManager.Instance.CloseView(viewName, null);
				}
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.CommonRewardView))
			{
				UiManager.Instance.CloseView(EUiViewName.CommonRewardView, null);
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.CompositeRewardView))
			{
				UiManager.Instance.CloseView(EUiViewName.CompositeRewardView, null);
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
			{
				UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
			}
		}

		// Token: 0x0602DFAC RID: 188332 RVA: 0x00CDE239 File Offset: 0x00CDC439
		public void SetItemList(List<RewardItemData> rewardItemList)
		{
			ItemRewardModel.Instance.SetItemList(rewardItemList);
		}

		// Token: 0x0602DFAD RID: 188333 RVA: 0x00CDE246 File Offset: 0x00CDC446
		public void AddItemList(List<RewardItemData> rewardItemList)
		{
			ItemRewardModel.Instance.AddItemList(rewardItemList);
		}

		// Token: 0x0602DFAE RID: 188334 RVA: 0x00CDE253 File Offset: 0x00CDC453
		public void SetProgressQueue(List<IRewardProgress> progressQueue)
		{
			ItemRewardModel.Instance.SetProgressQueue(progressQueue);
		}

		// Token: 0x0602DFAF RID: 188335 RVA: 0x00CDE260 File Offset: 0x00CDC460
		public void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList)
		{
			ItemRewardModel.Instance.SetExploreBarDataList(exploreBarDataList);
		}

		// Token: 0x0602DFB0 RID: 188336 RVA: 0x00CDE26D File Offset: 0x00CDC46D
		public void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo)
		{
			ItemRewardModel.Instance.SetExploreRecordInfo(exploreRecordInfo);
		}

		// Token: 0x0602DFB1 RID: 188337 RVA: 0x00CDE27A File Offset: 0x00CDC47A
		public void SetButtonList(List<IRewardExploreConfirmButton> exploreButtonInfo)
		{
			ItemRewardModel.Instance.SetButtonList(exploreButtonInfo);
		}

		// Token: 0x0602DFB2 RID: 188338 RVA: 0x00CDE287 File Offset: 0x00CDC487
		public void SetExploreFriendDataList(List<IRewardExploreFriendData> exploreFriendDataList)
		{
			ItemRewardModel.Instance.SetExploreFriendDataList(exploreFriendDataList);
		}

		// Token: 0x0602DFB3 RID: 188339 RVA: 0x00CDE294 File Offset: 0x00CDC494
		public List<IRewardExploreFriendData> BuildExploreFriendDataList()
		{
			List<IRewardExploreFriendData> list = new List<IRewardExploreFriendData>();
			FriendModel instance = FriendModel.Instance;
			OnlineModel instance2 = OnlineModel.Instance;
			foreach (OnlineTeamData onlineTeamData in instance2.GetTeamList())
			{
				if (!onlineTeamData.IsSelf)
				{
					int playerId = onlineTeamData.PlayerId;
					OnlineTeamData currentTeamListById = instance2.GetCurrentTeamListById(playerId);
					string playerIconPath = (currentTeamListById != null) ? PersonalModel.Instance.GetPlayerHeadData(onlineTeamData.HeadId, false).GetRoleHeadIconCircle() : "";
					string playerIndexPath = (currentTeamListById != null) ? this.BuildTeamIndexIcon(currentTeamListById.PlayerNumber) : "";
					RewardExploreFriendData rewardExploreFriendData = new RewardExploreFriendData();
					rewardExploreFriendData.PlayerId = playerId;
					rewardExploreFriendData.PlayerLevel = onlineTeamData.Level;
					rewardExploreFriendData.IsMyFriend = instance.IsMyFriend(playerId);
					rewardExploreFriendData.PlayerName = (((currentTeamListById != null) ? currentTeamListById.PlayerName : null) ?? "");
					rewardExploreFriendData.PlayerDesc = (((currentTeamListById != null) ? currentTeamListById.Signature : null) ?? "");
					rewardExploreFriendData.PlayerIconPath = playerIconPath;
					rewardExploreFriendData.PlayerIndexPath = playerIndexPath;
					rewardExploreFriendData.OnClickCallback = delegate(int pid)
					{
						FriendController.Instance.RequestFriendApplyAddSend(pid, FriendApplyWay.RecentlyTeam);
					};
					RewardExploreFriendData item = rewardExploreFriendData;
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0602DFB4 RID: 188340 RVA: 0x00CDE404 File Offset: 0x00CDC604
		private string BuildTeamIndexIcon(int onlineIndex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("FormationOnline");
			defaultInterpolatedStringHandler.AppendFormatted<int>(onlineIndex);
			defaultInterpolatedStringHandler.AppendLiteral("PIcon");
			string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
			return UiResourceConfig.Instance.GetResourcePath(resourceId);
		}

		// Token: 0x0602DFB5 RID: 188341 RVA: 0x00CDE450 File Offset: 0x00CDC650
		public List<int> BuildExploreFriendIdList()
		{
			List<int> list = new List<int>();
			foreach (OnlineTeamData onlineTeamData in OnlineModel.Instance.GetTeamList())
			{
				if (!onlineTeamData.IsSelf)
				{
					list.Add(onlineTeamData.PlayerId);
				}
			}
			return list;
		}

		// Token: 0x0602DFB6 RID: 188342 RVA: 0x00CDE4BC File Offset: 0x00CDC6BC
		[NullableContext(2)]
		public void PlayAudio(string audioId, PlayResult result = null)
		{
			if (StringUtils.IsEmpty(audioId))
			{
				return;
			}
			Audio? audioPath = AudioConfig.Instance.GetAudioPath(audioId);
			if (audioPath == null)
			{
				return;
			}
			AudioController.Instance.PostEventByUi(audioPath.Value.Path, result, null, null);
		}

		// Token: 0x0602DFB7 RID: 188343 RVA: 0x00CDE50C File Offset: 0x00CDC70C
		public unsafe void OpenSoarStrengthUpView(int strengthItemCount)
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("FlyStrengthItemId");
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(intConfig.Value);
			if (itemConfig == null || itemConfig.Value.ParametersLength == 0)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			if (num2 < itemConfig.Value.ParametersLength)
			{
				num = itemConfig.Value.Parameters(num2).Value.Value;
			}
			if (num == 0)
			{
				return;
			}
			PropRewardConf? config = ConfigPropRewardConfById.GetConfig(num, true);
			if (config == null)
			{
				return;
			}
			float num3 = 0f;
			for (int i = 0; i < config.Value.PropsLength; i++)
			{
				ConfigPropValue value = config.Value.Props(i).Value;
				if (value.Id == 10)
				{
					num3 = value.Value;
					break;
				}
			}
			if (num3 == 0f)
			{
				return;
			}
			num3 *= (float)strengthItemCount;
			int num4 = (int)FormationAttributeController.Instance.GetMax(EFormationAttributeId.SoarStrength);
			FormationProperty value2 = ConfigFormationPropertyById.GetConfig(10, true).Value;
			AttributeInfo attributeInfo = new AttributeInfo
			{
				Name = value2.Name,
				IconPath = value2.Icon,
				ShowArrow = new bool?(true),
				PreText = ((int)Math.Floor((double)((float)num4 - num3) / 100.0)).ToString(),
				CurText = ((int)Math.Floor((double)num4 / 100.0)).ToString()
			};
			LevelUpSuccessAttributeData levelUpSuccessAttributeData = new LevelUpSuccessAttributeData();
			levelUpSuccessAttributeData.Title = "Flying_EnergyUp";
			levelUpSuccessAttributeData.StrengthUpgradeData = new StrengthUpgradeData
			{
				AttributeId = EFormationAttributeId.SoarStrength,
				SingleStrengthValue = ConfigCommonParamById.GetIntConfig("FlySingleStrengthValue").Value,
				MaxSingleStrengthItemCount = ConfigCommonParamById.GetIntConfig("FlyMaxSingleStrengthItemCount").Value,
				MaxStrength = num4
			};
			int num5 = 1;
			List<IAttributeInfo> list = new List<IAttributeInfo>(num5);
			CollectionsMarshal.SetCount<IAttributeInfo>(list, num5);
			Span<IAttributeInfo> span = CollectionsMarshal.AsSpan<IAttributeInfo>(list);
			int index = 0;
			*span[index] = attributeInfo;
			levelUpSuccessAttributeData.AttributeInfo = list;
			LevelUpSuccessAttributeData data = levelUpSuccessAttributeData;
			RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(data, null);
		}

		// Token: 0x17005CA1 RID: 23713
		// (get) Token: 0x0602DFB8 RID: 188344 RVA: 0x00CDE746 File Offset: 0x00CDC946
		public static ItemRewardController Instance
		{
			get
			{
				return ItemRewardController._Instance;
			}
		}

		// Token: 0x0602DFB9 RID: 188345 RVA: 0x00CDE74D File Offset: 0x00CDC94D
		public static ItemRewardController GetOrCreateInstance()
		{
			if (ItemRewardController._Instance == null)
			{
				ItemRewardController.CreateInstance();
			}
			return ItemRewardController._Instance;
		}

		// Token: 0x0602DFBA RID: 188346 RVA: 0x00CDE761 File Offset: 0x00CDC961
		public static bool CreateInstance()
		{
			if (ItemRewardController._Instance != null)
			{
				return true;
			}
			ItemRewardController._Instance = new ItemRewardController();
			return true;
		}

		// Token: 0x0602DFBB RID: 188347 RVA: 0x00CDE777 File Offset: 0x00CDC977
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DFBC RID: 188348 RVA: 0x00CDE779 File Offset: 0x00CDC979
		public static void ResetStaticDefaultValue()
		{
			ItemRewardController._Instance = null;
		}

		// Token: 0x0602DFBD RID: 188349 RVA: 0x00CDE781 File Offset: 0x00CDC981
		static ItemRewardController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardController.CreateStaticDefaultValue), new Action(ItemRewardController.ResetStaticDefaultValue));
		}

		// Token: 0x0602DFBF RID: 188351 RVA: 0x00CDE7B4 File Offset: 0x00CDC9B4
		[CompilerGenerated]
		internal static void <OpenMotorItemRewardView>g__quitCallback|29_0()
		{
			if (MotorcycleDiyModel.Instance.IsEquipFrameLockedByPlayer())
			{
				MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
			}
		}

		// Token: 0x04018892 RID: 100498
		[Nullable(2)]
		protected int[] RewardViewReasonArray;

		// Token: 0x04018893 RID: 100499
		private int SoarStrengthItemId;

		// Token: 0x04018894 RID: 100500
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly Queue<ValueTuple<RewardItemData[], int>> ExploreRewardQueue = new Queue<ValueTuple<RewardItemData[], int>>(4);

		// Token: 0x04018895 RID: 100501
		[Nullable(2)]
		private static ItemRewardController _Instance;
	}
}
