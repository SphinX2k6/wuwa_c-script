using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Module.Activity.ActivityContent.Tetris;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.ExploreLevel;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057AE RID: 22446
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ItemRewardController : UiControllerBase
	{
		// Token: 0x0603907E RID: 233598 RVA: 0x00D8DE20 File Offset: 0x00D8C020
		protected override bool OnInit()
		{
			this.SoarStrengthItemId = ConfigCommonParamById.GetIntConfig("FlyStrengthItemId").Value;
			return true;
		}

		// Token: 0x0603907F RID: 233599 RVA: 0x00D8DE46 File Offset: 0x00D8C046
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.ItemObtainNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMsgItemObtainNotify));
		}

		// Token: 0x06039080 RID: 233600 RVA: 0x00D8DE64 File Offset: 0x00D8C064
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ItemObtainNotify);
		}

		// Token: 0x06039081 RID: 233601 RVA: 0x00D8DE78 File Offset: 0x00D8C078
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnItemRewardNotify, new Action<ItemRewardNotify>(this.OnItemRewardNotify));
			EventSystem.Instance.Add(EEventName.OnExploreRewardShowEnd, new Action(this.OnExploreLevelRewardViewShowEnd));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06039082 RID: 233602 RVA: 0x00D8DEDC File Offset: 0x00D8C0DC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnItemRewardNotify, new Action<ItemRewardNotify>(this.OnItemRewardNotify));
			EventSystem.Instance.Remove(EEventName.OnExploreRewardShowEnd, new Action(this.OnExploreLevelRewardViewShowEnd));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06039083 RID: 233603 RVA: 0x00D8DF40 File Offset: 0x00D8C140
		private void OnWorldDone()
		{
			List<RewardData<ICommonRewardInfo>> cacheCommonRewardDataList = ItemRewardModel.Instance.CacheCommonRewardDataList;
			if (cacheCommonRewardDataList.Count > 0)
			{
				this.Open<ICommonRewardInfo>(cacheCommonRewardDataList[0], null);
			}
		}

		// Token: 0x06039084 RID: 233604 RVA: 0x00D8DF70 File Offset: 0x00D8C170
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

		// Token: 0x06039085 RID: 233605 RVA: 0x00D8DFFC File Offset: 0x00D8C1FC
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
							if (repeatedField.Any((RewardItemInfo info) => info.ItemId == 1))
							{
								return;
							}
						}
					}
				}
			}
			if (rewardItemDataList.Any((RewardItemData d) => d.ConfigId == 1 && d.GetDropItemType() == EDropItemType.Activity))
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < rewardItemDataList.Count; i++)
			{
				RewardItemData rewardItemData = rewardItemDataList[i];
				if (rewardItemData.ConfigId == 1 && rewardItemData.GetDropItemType() == EDropItemType.Normal)
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
			RewardItemData rewardItemData2 = rewardItemDataList[num];
			int count = rewardItemData2.Count;
			int num2 = count / 2;
			int num3 = count - num2;
			if (num3 <= 0 || num2 <= 0)
			{
				return;
			}
			rewardItemData2.Count = num2;
			rewardItemDataList.Add(new RewardItemData(1, num3, new int?(rewardItemData2.UniqueId), EDropItemType.Activity));
		}

		// Token: 0x06039086 RID: 233606 RVA: 0x00D8E170 File Offset: 0x00D8C370
		private unsafe void OnItemRewardNotify(ItemRewardNotify notify)
		{
			MapField<int, RewardItemInfoList> rewardItems = notify.RewardItems;
			ICollection<int> keys = rewardItems.Keys;
			if (rewardItems == null || keys == null)
			{
				return;
			}
			int reason = notify.Reason;
			RewardViewFromSource? rewardViewFromSource = this.GetRewardViewReasonArray().Contains(reason) ? ItemRewardConfig.Instance.GetRewardViewFromSourceConfig(reason) : null;
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
			if (ItemRewardDefine.FillRoleDevelopStateTagReasonIdList.Contains(reason))
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
			if (ItemRewardDefine.BlockReasonIdList.Contains(reason))
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

		// Token: 0x06039087 RID: 233607 RVA: 0x00D8E6F8 File Offset: 0x00D8C8F8
		[NullableContext(2)]
		private void OnMsgItemObtainNotify(IMessage msg, Net.CallbackStatus _)
		{
			ItemObtainNotify notify = (ItemObtainNotify)msg;
			this.OnItemObtainNotify(notify, null);
		}

		// Token: 0x06039088 RID: 233608 RVA: 0x00D8E714 File Offset: 0x00D8C914
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

		// Token: 0x06039089 RID: 233609 RVA: 0x00D8EA40 File Offset: 0x00D8CC40
		public void DispatchPackagedReward(int reasonId, List<RewardItemData> rewardItemDataList, List<RewardItemPackage> characterItemList, List<RewardItemData> obtainSkinItemDataList, List<RewardItemData> obtainFlySkinItemDataList, List<RewardItemData> obtainMotorItemDataList, List<RewardItemData> obtainOrnamentItemDataList, int soarStrengthItemCount, [Nullable(2)] Action<bool?> callback = null, [Nullable(2)] ItemObtainNotify originNotify = null)
		{
			if (ItemRewardDefine.BlockObtainReasonIdList.Contains(reasonId))
			{
				return;
			}
			if (rewardItemDataList.Any((RewardItemData item) => item.ConfigId == 50021))
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
			RewardViewFromSource? rewardViewFromSource = this.GetRewardViewReasonArray().Contains(reasonId) ? ItemRewardConfig.Instance.GetRewardViewFromSourceConfig(reasonId) : null;
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
					using (List<RewardItemPackage>.Enumerator enumerator = characterItemList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							RewardItemPackage itemPackage = enumerator.Current;
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

		// Token: 0x0603908A RID: 233610 RVA: 0x00D8EDEC File Offset: 0x00D8CFEC
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

		// Token: 0x0603908B RID: 233611 RVA: 0x00D8EE0C File Offset: 0x00D8D00C
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

		// Token: 0x0603908C RID: 233612 RVA: 0x00D8EE40 File Offset: 0x00D8D040
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

		// Token: 0x0603908D RID: 233613 RVA: 0x00D8EE90 File Offset: 0x00D8D090
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

		// Token: 0x0603908E RID: 233614 RVA: 0x00D8EEC4 File Offset: 0x00D8D0C4
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

		// Token: 0x0603908F RID: 233615 RVA: 0x00D8EF7C File Offset: 0x00D8D17C
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

		// Token: 0x06039090 RID: 233616 RVA: 0x00D8EFCE File Offset: 0x00D8D1CE
		private void OnExploreLevelRewardViewShowEnd()
		{
			this.ExploreRewardQueue.Pop();
			this.OpenExploreLevelRewardViewFromQueue();
		}

		// Token: 0x06039091 RID: 233617 RVA: 0x00D8EFE4 File Offset: 0x00D8D1E4
		private void OpenExploreLevelRewardViewFromQueue()
		{
			if (this.ExploreRewardQueue.Empty)
			{
				return;
			}
			ValueTuple<RewardItemData[], int> front = this.ExploreRewardQueue.Front;
			RewardItemData[] item = front.Item1;
			int item2 = front.Item2;
			RewardData<IExploreLevelRewardInfo> exploreLevelRewardData = ItemRewardModel.Instance.GetExploreLevelRewardData(EUiViewName.ExploreLevelRewardView, item2, item2 + 1, item.ToList<RewardItemData>());
			this.Open<IExploreLevelRewardInfo>(exploreLevelRewardData, null);
		}

		// Token: 0x06039092 RID: 233618 RVA: 0x00D8F03C File Offset: 0x00D8D23C
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

		// Token: 0x06039093 RID: 233619 RVA: 0x00D8F068 File Offset: 0x00D8D268
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

		// Token: 0x06039094 RID: 233620 RVA: 0x00D8F0AC File Offset: 0x00D8D2AC
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

		// Token: 0x06039095 RID: 233621 RVA: 0x00D8F0D8 File Offset: 0x00D8D2D8
		public bool OpenBattlePassExtraRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<IBattlePassExtraRewardInfo> rewardData = BattlePassController.Instance.BuildExtraRewardData(rewardItemDataList);
			this.Open<IBattlePassExtraRewardInfo>(rewardData, rewardData.GetRewardInfo().FinishCallback);
			return true;
		}

		// Token: 0x06039096 RID: 233622 RVA: 0x00D8F104 File Offset: 0x00D8D304
		public bool OpenRegressBpRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<IBattlePassExtraRewardInfo> rewardData = ActivityRegressController.Instance.BuildExtraRewardData(rewardItemDataList);
			this.Open<IBattlePassExtraRewardInfo>(rewardData, rewardData.GetRewardInfo().FinishCallback);
			return true;
		}

		// Token: 0x06039097 RID: 233623 RVA: 0x00D8F130 File Offset: 0x00D8D330
		public bool OpenEncircleRewardView(List<RewardItemData> rewardItemDataList)
		{
			RewardData<IEncircleRewardInfo> rewardData = ActivityEncircleController.Instance.BuildRewardData(rewardItemDataList);
			this.Open<IEncircleRewardInfo>(rewardData, null);
			return true;
		}

		// Token: 0x06039098 RID: 233624 RVA: 0x00D8F154 File Offset: 0x00D8D354
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
				MotorcycleDiyController.Instance.OpenTargetViewByReward(obtainMotorItemDataList.ToList<RewardItemData>(), jumpDiyType);
			} : null;
			RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(configId, EUiViewName.CommonRewardView, rewardItemDataList, null, leftBtnTextId, rightBtnTextId, new Action(ItemRewardController.<OpenMotorItemRewardView>g__quitCallback|29_0), rightAction, false, false);
			if (rewardData == null)
			{
				return false;
			}
			this.Open<ICommonRewardInfo>(rewardData, null);
			return true;
		}

		// Token: 0x06039099 RID: 233625 RVA: 0x00D8F27C File Offset: 0x00D8D47C
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

		// Token: 0x0603909A RID: 233626 RVA: 0x00D8F2E4 File Offset: 0x00D8D4E4
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

		// Token: 0x0603909B RID: 233627 RVA: 0x00D8F368 File Offset: 0x00D8D568
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

		// Token: 0x0603909C RID: 233628 RVA: 0x00D8F401 File Offset: 0x00D8D601
		public void SetItemList(List<RewardItemData> rewardItemList)
		{
			ItemRewardModel.Instance.SetItemList(rewardItemList);
		}

		// Token: 0x0603909D RID: 233629 RVA: 0x00D8F40E File Offset: 0x00D8D60E
		public void AddItemList(List<RewardItemData> rewardItemList)
		{
			ItemRewardModel.Instance.AddItemList(rewardItemList);
		}

		// Token: 0x0603909E RID: 233630 RVA: 0x00D8F41B File Offset: 0x00D8D61B
		public void SetProgressQueue(List<IRewardProgress> progressQueue)
		{
			ItemRewardModel.Instance.SetProgressQueue(progressQueue);
		}

		// Token: 0x0603909F RID: 233631 RVA: 0x00D8F428 File Offset: 0x00D8D628
		public void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList)
		{
			ItemRewardModel.Instance.SetExploreBarDataList(exploreBarDataList);
		}

		// Token: 0x060390A0 RID: 233632 RVA: 0x00D8F435 File Offset: 0x00D8D635
		public void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo)
		{
			ItemRewardModel.Instance.SetExploreRecordInfo(exploreRecordInfo);
		}

		// Token: 0x060390A1 RID: 233633 RVA: 0x00D8F442 File Offset: 0x00D8D642
		public void SetButtonList(List<IRewardExploreConfirmButton> exploreButtonInfo)
		{
			ItemRewardModel.Instance.SetButtonList(exploreButtonInfo);
		}

		// Token: 0x060390A2 RID: 233634 RVA: 0x00D8F44F File Offset: 0x00D8D64F
		public void SetExploreFriendDataList(List<IRewardExploreFriendData> exploreFriendDataList)
		{
			ItemRewardModel.Instance.SetExploreFriendDataList(exploreFriendDataList);
		}

		// Token: 0x060390A3 RID: 233635 RVA: 0x00D8F45C File Offset: 0x00D8D65C
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

		// Token: 0x060390A4 RID: 233636 RVA: 0x00D8F5CC File Offset: 0x00D8D7CC
		private string BuildTeamIndexIcon(int onlineIndex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("FormationOnline");
			defaultInterpolatedStringHandler.AppendFormatted<int>(onlineIndex);
			defaultInterpolatedStringHandler.AppendLiteral("PIcon");
			string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
			return UiResourceConfig.Instance.GetResourcePath(resourceId);
		}

		// Token: 0x060390A5 RID: 233637 RVA: 0x00D8F618 File Offset: 0x00D8D818
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

		// Token: 0x060390A6 RID: 233638 RVA: 0x00D8F684 File Offset: 0x00D8D884
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

		// Token: 0x060390A7 RID: 233639 RVA: 0x00D8F6D4 File Offset: 0x00D8D8D4
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

		// Token: 0x170088D9 RID: 35033
		// (get) Token: 0x060390A8 RID: 233640 RVA: 0x00D8F90E File Offset: 0x00D8DB0E
		public static ItemRewardController Instance
		{
			get
			{
				return ItemRewardController._Instance;
			}
		}

		// Token: 0x060390A9 RID: 233641 RVA: 0x00D8F915 File Offset: 0x00D8DB15
		public static ItemRewardController GetOrCreateInstance()
		{
			if (ItemRewardController._Instance == null)
			{
				ItemRewardController.CreateInstance();
			}
			return ItemRewardController._Instance;
		}

		// Token: 0x060390AA RID: 233642 RVA: 0x00D8F929 File Offset: 0x00D8DB29
		public static bool CreateInstance()
		{
			if (ItemRewardController._Instance != null)
			{
				return true;
			}
			ItemRewardController._Instance = new ItemRewardController();
			return true;
		}

		// Token: 0x060390AB RID: 233643 RVA: 0x00D8F93F File Offset: 0x00D8DB3F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060390AC RID: 233644 RVA: 0x00D8F941 File Offset: 0x00D8DB41
		public static void ResetStaticDefaultValue()
		{
			ItemRewardController._Instance = null;
		}

		// Token: 0x060390AD RID: 233645 RVA: 0x00D8F949 File Offset: 0x00D8DB49
		static ItemRewardController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardController.CreateStaticDefaultValue), new Action(ItemRewardController.ResetStaticDefaultValue));
		}

		// Token: 0x060390AF RID: 233647 RVA: 0x00D8F97C File Offset: 0x00D8DB7C
		[CompilerGenerated]
		internal static void <OpenMotorItemRewardView>g__quitCallback|29_0()
		{
			if (MotorcycleDiyModel.Instance.IsEquipFrameLockedByPlayer())
			{
				MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
			}
		}

		// Token: 0x0401DDFC RID: 122364
		[Nullable(2)]
		protected int[] RewardViewReasonArray;

		// Token: 0x0401DDFD RID: 122365
		private int SoarStrengthItemId;

		// Token: 0x0401DDFE RID: 122366
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly Queue<ValueTuple<RewardItemData[], int>> ExploreRewardQueue = new Queue<ValueTuple<RewardItemData[], int>>(4);

		// Token: 0x0401DDFF RID: 122367
		[Nullable(2)]
		private static ItemRewardController _Instance;
	}
}
