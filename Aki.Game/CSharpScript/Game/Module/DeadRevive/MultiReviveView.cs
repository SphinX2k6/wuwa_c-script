using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AA7 RID: 19111
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiReviveView : UiTickViewBase
	{
		// Token: 0x0602FD19 RID: 195865 RVA: 0x00D57C52 File Offset: 0x00D55E52
		public MultiReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FD1A RID: 195866 RVA: 0x00D57C84 File Offset: 0x00D55E84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickQuitBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickAgainBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickReviveBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickReviveAtLocationBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FD1B RID: 195867 RVA: 0x00D57EE4 File Offset: 0x00D560E4
		protected override void OnAddEventListener()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				EventSystem.Instance.Add<int, EContinuingChallenge>(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
				EventSystem.Instance.Add<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			}
		}

		// Token: 0x0602FD1C RID: 195868 RVA: 0x00D57F38 File Offset: 0x00D56138
		protected override void OnRemoveEventListener()
		{
			if (EventSystem.Instance.Has(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept)))
			{
				EventSystem.Instance.Remove(EEventName.PlayerChallengeStateChange, new Action<int, EContinuingChallenge>(this.OnlineTeamPlayerAccept));
			}
			if (EventSystem.Instance.Has(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange)))
			{
				EventSystem.Instance.Remove(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			}
		}

		// Token: 0x0602FD1D RID: 195869 RVA: 0x00D57FB8 File Offset: 0x00D561B8
		protected override void OnBeforeShow()
		{
			bool flag = GameModeController.Instance.IsInInstance();
			base.GetButton(1).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(2).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(7).RootUIComp.Get().SetUIActive(!flag);
			if (flag)
			{
				this.UpdateOnlineTeamPlayer();
				this.UpdateOnlineText();
				return;
			}
			base.GetItem(3).SetUIActive(false);
			this.InitRevive();
		}

		// Token: 0x0602FD1E RID: 195870 RVA: 0x00D58044 File Offset: 0x00D56244
		protected override void OnBeforeDestroy()
		{
			this.ResetData();
		}

		// Token: 0x0602FD1F RID: 195871 RVA: 0x00D5804C File Offset: 0x00D5624C
		private void ResetData()
		{
			this.ReviveNumber = -1;
			this.AutoReviveTime = 0;
			this.AutoReviveText = null;
			this.ReviveAtLocationName = "";
			this.ReviveAtLocationCd = "";
			if (this.AutoReviveTimer != null)
			{
				this.AutoReviveTimer.Remove();
				this.AutoReviveTimer = null;
			}
			if (this.PlayerStateItemMap != null)
			{
				this.PlayerStateItemMap.Clear();
			}
		}

		// Token: 0x0602FD20 RID: 195872 RVA: 0x00D580B4 File Offset: 0x00D562B4
		private void InitRevive()
		{
			Revive? reviveConfig = DeadReviveModel.Instance.ReviveConfig;
			if (reviveConfig != null)
			{
				this.ReviveNumber = reviveConfig.Value.ReviveTimes;
			}
			if (this.AutoReviveTimer == null)
			{
				this.AutoReviveTime = 60;
				this.AutoReviveText = base.GetText(8);
				LguiUtil.Instance.SetLocalText(this.AutoReviveText, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveTime));
				this.AutoReviveTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					if (this.AutoReviveTime <= 0)
					{
						ConfirmBoxController.Instance.CloseConfirmBoxView();
						this.OnClickReviveBtn();
						if (this.AutoReviveTimer != null)
						{
							this.AutoReviveTimer.Remove();
							this.AutoReviveTimer = null;
						}
						return;
					}
					this.AutoReviveTime--;
					LguiUtil.Instance.SetLocalText(this.AutoReviveText, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveTime));
				}, 1000f, 1f, null, null, true);
			}
			int num = -1;
			Revive? reviveConfig2 = DeadReviveModel.Instance.ReviveConfig;
			if (reviveConfig2 != null)
			{
				num = reviveConfig2.Value.UseItemId;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(num, 0);
			if (itemCountByConfigId <= 0)
			{
				return;
			}
			base.GetButton(9).RootUIComp.Get().SetUIActive(true);
			UUITexture texture = base.GetTexture(10);
			UUIText text = base.GetText(11);
			BuffItemModel instance = BuffItemModel.Instance;
			base.SetItemIcon(texture, num, null, null);
			this.ReviveAtLocationName = ItemConfig.Instance.GetItemName(num);
			int buffItemTotalCdTime = BuffItemConfig.Instance.GetBuffItemTotalCdTime(num);
			if ((double)buffItemTotalCdTime < TimeUtil.Instance.Minute)
			{
				this.ReviveAtLocationCd = buffItemTotalCdTime.ToString() + TextConfig.Instance.GetTextById("Second");
			}
			else
			{
				this.ReviveAtLocationCd = Math.Floor((double)buffItemTotalCdTime / TimeUtil.Instance.Minute).ToString() + TextConfig.Instance.GetTextById("MinuteText");
				double num2 = (double)buffItemTotalCdTime % TimeUtil.Instance.Minute;
				if (num2 > 0.0)
				{
					this.ReviveAtLocationCd = this.ReviveAtLocationCd + num2.ToString() + TextConfig.Instance.GetTextById("Second");
				}
			}
			if (instance.GetBuffItemRemainCdTime(num) > 0.0)
			{
				LguiUtil.Instance.SetLocalText(text, "ReviveItemCd", Array.Empty<object>());
				(base.GetButton(9).GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(false);
				return;
			}
			text.SetText(itemCountByConfigId.ToString(), true);
		}

		// Token: 0x0602FD21 RID: 195873 RVA: 0x00D58300 File Offset: 0x00D56500
		private void OnClickReviveBtn()
		{
			if (this.ReviveNumber == 0)
			{
				ScrollingTipsController.Instance.ShowTipsById("CannotRevive", Array.Empty<object>());
				return;
			}
			this.RequestRevive(false);
		}

		// Token: 0x0602FD22 RID: 195874 RVA: 0x00D58328 File Offset: 0x00D56528
		private void OnClickReviveAtLocationBtn()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.UsingItemRevive);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				this.ReviveAtLocationName,
				this.ReviveAtLocationCd
			});
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.RequestRevive(true);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602FD23 RID: 195875 RVA: 0x00D58380 File Offset: 0x00D56580
		private void RequestRevive(bool useItem)
		{
			DeadReviveController.Instance.ReviveRequest(useItem, delegate(bool result)
			{
				if (result)
				{
					this.ResetData();
				}
			}, null);
		}

		// Token: 0x0602FD24 RID: 195876 RVA: 0x00D583B0 File Offset: 0x00D565B0
		private void UpdateOnlineTeamPlayer()
		{
			UUIText text = base.GetText(0);
			UUIItem item = base.GetItem(3);
			List<ScenePlayerData> allScenePlayers = CreatureModel.Instance.GetAllScenePlayers();
			bool flag = true;
			foreach (ScenePlayerData scenePlayerData in allScenePlayers)
			{
				if (SceneTeamModel.Instance.GetGroupLivingState(scenePlayerData.GetPlayerId(), ETeamGroupType.Battle) == ETeamLivingState.Alive)
				{
					flag = false;
					break;
				}
			}
			if (allScenePlayers.Count <= 1 || !flag)
			{
				text.SetUIActive(true);
				item.SetUIActive(false);
				return;
			}
			text.SetUIActive(false);
			item.SetUIActive(true);
			UUISprite sprite = base.GetSprite(4);
			UUISprite sprite2 = base.GetSprite(5);
			sprite.SetUIActive(false);
			sprite2.SetUIActive(false);
			int? id = PlayerInfoModel.Instance.GetId();
			foreach (ScenePlayerData scenePlayerData2 in allScenePlayers)
			{
				int playerId = scenePlayerData2.GetPlayerId();
				int num = playerId;
				int? num2 = id;
				if (!(num == num2.GetValueOrDefault() & num2 != null))
				{
					EContinuingChallenge? continuingChallengeConfirmState = OnlineModel.Instance.GetContinuingChallengeConfirmState(playerId);
					if (!sprite.bIsUIActive)
					{
						sprite.SetUIActive(true);
						this.SetTeamPlayerSprite(continuingChallengeConfirmState.Value, sprite);
						this.PlayerStateItemMap[playerId] = sprite;
					}
					else if (!sprite2.bIsUIActive)
					{
						sprite2.SetUIActive(true);
						this.SetTeamPlayerSprite(continuingChallengeConfirmState.Value, sprite2);
						this.PlayerStateItemMap[playerId] = sprite2;
					}
				}
			}
		}

		// Token: 0x0602FD25 RID: 195877 RVA: 0x00D58550 File Offset: 0x00D56750
		private void UpdateOnlineText()
		{
			if (CreatureModel.Instance.IsMyWorld())
			{
				LguiUtil.Instance.SetLocalText(base.GetText(6), "ChallengeAgain", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(6), "SuggestChallengeAgain", Array.Empty<object>());
		}

		// Token: 0x0602FD26 RID: 195878 RVA: 0x00D585A0 File Offset: 0x00D567A0
		private void SetTeamPlayerSprite(EContinuingChallenge state, UUISprite playerSprite)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(OnlineDefine.onlineContinuingChallengeIcon[state]);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				this.SetSpriteByPath(resourcePath, playerSprite, false, null, null);
			}
		}

		// Token: 0x0602FD27 RID: 195879 RVA: 0x00D585E0 File Offset: 0x00D567E0
		private void OnClickQuitBtn()
		{
			if (SceneTeamModel.Instance.IsAllDid())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.OnlineQuitInstance);
			Action value = delegate()
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			};
			confirmBoxDataNew.FunctionMap[2] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602FD28 RID: 195880 RVA: 0x00D5864C File Offset: 0x00D5684C
		private void OnClickAgainBtn()
		{
			if (!SceneTeamModel.Instance.IsAllDid())
			{
				ScrollingTipsController.Instance.ShowTipsById("NeedAllDeadToChallengeAgain", Array.Empty<object>());
				return;
			}
			if (!OnlineModel.Instance.AllowInitiate)
			{
				ScrollingTipsController.Instance.ShowTipsById("CannotInvite", Array.Empty<object>());
				return;
			}
			bool flag = CreatureModel.Instance.IsMyWorld();
			double nextInitiateLeftTime = OnlineModel.Instance.NextInitiateLeftTime;
			if (nextInitiateLeftTime > 0.0)
			{
				if (flag)
				{
					ScrollingTipsController.Instance.ShowTipsById("NextInviteTime", new object[]
					{
						TimeUtil.Instance.GetCoolDown(nextInitiateLeftTime)
					});
					return;
				}
				ScrollingTipsController.Instance.ShowTipsById("NextSuggestTime", new object[]
				{
					TimeUtil.Instance.GetCoolDown(nextInitiateLeftTime)
				});
				return;
			}
			else
			{
				if (OnlineModel.Instance.GetContinuingChallengeConfirmState(PlayerInfoModel.Instance.GetId().Value).GetValueOrDefault() == EContinuingChallenge.Pending)
				{
					OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Dead);
					return;
				}
				if (flag)
				{
					OnlineController.Instance.InviteRechallengeRequest();
					return;
				}
				OnlineController.Instance.ApplyRechallengeRequest(ApplyRechallengeReason.Dead);
				return;
			}
		}

		// Token: 0x0602FD29 RID: 195881 RVA: 0x00D58754 File Offset: 0x00D56954
		private void OnlineTeamPlayerAccept(int playerId, EContinuingChallenge state)
		{
			UUISprite uuisprite;
			this.PlayerStateItemMap.TryGetValue(playerId, out uuisprite);
			if (uuisprite == null)
			{
				return;
			}
			this.SetTeamPlayerSprite(state, uuisprite);
		}

		// Token: 0x0602FD2A RID: 195882 RVA: 0x00D5877C File Offset: 0x00D5697C
		private void OnTeamLivingStateChange(bool b, ETeamGroupType eTeamGroupType, ETeamLivingState arg3, ETeamLivingState arg4)
		{
			this.UpdateOnlineTeamPlayer();
		}

		// Token: 0x04019626 RID: 103974
		private const int TIME_SECOND = 1000;

		// Token: 0x04019627 RID: 103975
		private const int AUTO_REVIVE_TIME = 60;

		// Token: 0x04019628 RID: 103976
		private readonly Dictionary<int, UUISprite> PlayerStateItemMap = new Dictionary<int, UUISprite>();

		// Token: 0x04019629 RID: 103977
		private string ReviveAtLocationName = "";

		// Token: 0x0401962A RID: 103978
		private string ReviveAtLocationCd = "";

		// Token: 0x0401962B RID: 103979
		private int ReviveNumber = -1;

		// Token: 0x0401962C RID: 103980
		private int AutoReviveTime;

		// Token: 0x0401962D RID: 103981
		[Nullable(2)]
		private TimerHandle AutoReviveTimer;

		// Token: 0x0401962E RID: 103982
		[Nullable(2)]
		private UUIText AutoReviveText;

		// Token: 0x0200A720 RID: 42784
		[NullableContext(0)]
		private class EOnlineInstanceDungeonDeathPanel
		{
			// Token: 0x04033A47 RID: 211527
			public const int TextTips = 0;

			// Token: 0x04033A48 RID: 211528
			public const int QuitButton = 1;

			// Token: 0x04033A49 RID: 211529
			public const int AgainButton = 2;

			// Token: 0x04033A4A RID: 211530
			public const int TeamPlayerStateItem = 3;

			// Token: 0x04033A4B RID: 211531
			public const int TeamPlayer1Sprite = 4;

			// Token: 0x04033A4C RID: 211532
			public const int TeamPlayer2Sprite = 5;

			// Token: 0x04033A4D RID: 211533
			public const int TextAgain = 6;

			// Token: 0x04033A4E RID: 211534
			public const int ReviveBtn = 7;

			// Token: 0x04033A4F RID: 211535
			public const int AutoReviveText = 8;

			// Token: 0x04033A50 RID: 211536
			public const int ReviveAtLocationBtn = 9;

			// Token: 0x04033A51 RID: 211537
			public const int ReviveAtLocationTexture = 10;

			// Token: 0x04033A52 RID: 211538
			public const int ReviveAtLocationText = 11;
		}
	}
}
