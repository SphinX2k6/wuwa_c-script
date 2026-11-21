using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DED RID: 15853
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeSettleView : UiViewBase
	{
		// Token: 0x060287D6 RID: 165846 RVA: 0x00B59FC7 File Offset: 0x00B581C7
		[NullableContext(1)]
		public RoguelikeSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060287D7 RID: 165847 RVA: 0x00B59FE4 File Offset: 0x00B581E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 24;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnBtnBackClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060287D8 RID: 165848 RVA: 0x00B5A374 File Offset: 0x00B58574
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeSettleView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeSettleView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060287D9 RID: 165849 RVA: 0x00B5A3B7 File Offset: 0x00B585B7
		protected override void OnAfterShow()
		{
			if (this.FirstShowFlag)
			{
				this.FirstShowFlag = false;
				this.SkillPointRewardItem.StartAnim();
				this.OutSideRewardItem.StartAnim();
			}
		}

		// Token: 0x060287DA RID: 165850 RVA: 0x00B5A3E0 File Offset: 0x00B585E0
		protected override void OnStart()
		{
			this.InitBaseInfo();
			EventSystem.Instance.Add<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.OnArchiveSaved));
		}

		// Token: 0x060287DB RID: 165851 RVA: 0x00B5A404 File Offset: 0x00B58604
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.OnArchiveSaved));
			this.RecordItemList.ForEach(delegate(RoguelikeSettleRecordItem item)
			{
				item.Destroy(null);
			});
			this.RecordItemList = new List<RoguelikeSettleRecordItem>();
		}

		// Token: 0x060287DC RID: 165852 RVA: 0x00B5A464 File Offset: 0x00B58664
		private void InitBaseInfo()
		{
			RoguelikeResultInfo roguelikeResultInfo = (RoguelikeResultInfo)this.OpenParam;
			RoleDataBase roguelikeRoleData = RoguelikeModel.Instance.GetRoguelikeRoleData(roguelikeResultInfo.RoleEntry.ConfigId);
			RoleInfo roleConfig = roguelikeRoleData.GetRoleConfig();
			RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(roguelikeResultInfo.PhantomEntry.ConfigId);
			string timeString = TimeUtil.Instance.GetTimeString((double)roguelikeResultInfo.TotalCostTime);
			base.GetText(21).SetText(timeString, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), roleConfig.Name, Array.Empty<object>());
			string formationRoleCard = roleConfig.FormationRoleCard;
			int roleSkinId = roguelikeRoleData.GetRoleSkinId();
			if (roleSkinId != -1)
			{
				formationRoleCard = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId).Value.FormationRoleCard;
			}
			base.SetTextureByPath(formationRoleCard, base.GetTexture(1), null, null);
			if (roguePhantomConfig != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roguePhantomConfig.Value.PokemonName, Array.Empty<object>());
				base.SetTextureByPath(roguePhantomConfig.Value.PokemonSettleIcon, base.GetTexture(3), null, null);
			}
			else
			{
				base.GetText(4).SetUIActive(false);
				base.GetTexture(3).SetUIActive(false);
			}
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(roguelikeResultInfo.InstId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), config.Value.MapName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), (config.Value.DifficultyDescLength > 0) ? config.Value.DifficultyDesc(0) : "", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "RoguelikeSettlePlayerName", new <>z__ReadOnlySingleElementList<object>(FunctionModel.Instance.GetPlayerName()));
			string newText = TimeUtil.Instance.DateFormatString(roguelikeResultInfo.Time);
			base.GetText(9).SetText(newText, true);
			int num = (int)Math.Floor((double)roguelikeResultInfo.CurLayer / (double)roguelikeResultInfo.MaxLayer * 100.0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "RoguelikeSettleProgress", new <>z__ReadOnlySingleElementList<object>(num));
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			UUIItem item = base.GetItem(0);
			UUITexture texture = base.GetTexture(19);
			if (num >= paramConfigBySeasonId.Value.RoguelikeSettleS)
			{
				item.SetUIActive(true);
				base.SetTextureByPath(paramConfigBySeasonId.Value.RoguelikeSettleBgS, texture, null, null);
			}
			else if (num >= paramConfigBySeasonId.Value.RoguelikeSettleA)
			{
				item.SetUIActive(false);
				base.SetTextureByPath(paramConfigBySeasonId.Value.RoguelikeSettleBgNormal, texture, null, null);
			}
			else if (num >= paramConfigBySeasonId.Value.RoguelikeSettleB)
			{
				item.SetUIActive(false);
				base.SetTextureByPath(paramConfigBySeasonId.Value.RoguelikeSettleBgNormal, texture, null, null);
			}
			else
			{
				item.SetUIActive(false);
				base.SetTextureByPath(paramConfigBySeasonId.Value.RoguelikeSettleBgNormal, texture, null, null);
			}
			UUITexture texture2 = base.GetTexture(5);
			int selectHotEntryGroupId = roguelikeResultInfo.SelectHotEntryGroupId;
			RogueHotEntryGroup? rogueHotEntryGroupConfig = RoguelikeConfig.Instance.GetRogueHotEntryGroupConfig(selectHotEntryGroupId);
			if (rogueHotEntryGroupConfig != null)
			{
				base.SetTextureByPath(rogueHotEntryGroupConfig.Value.SettleIcon, texture2, null, null);
				base.GetText(6).SetColor(FColor.FromHex(rogueHotEntryGroupConfig.Value.SettleTextColor));
				base.GetText(22).SetColor(FColor.FromHex(rogueHotEntryGroupConfig.Value.SettleTextColor));
				base.GetText(14).SetText(((float)rogueHotEntryGroupConfig.Value.Rate / 100f).ToString() + "%", true);
				int settleAudioState = rogueHotEntryGroupConfig.Value.SettleAudioState;
				if (settleAudioState == 1)
				{
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_s", true);
				}
				else if (settleAudioState == 2)
				{
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_a", true);
				}
				else if (settleAudioState == 3)
				{
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_b", true);
				}
				else if (settleAudioState == 4)
				{
					AudioSystem.Instance.SetState("ui_rogue_settle", "settle_c", true);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(22), "RogueEnd_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				roguelikeResultInfo.CurLayer,
				roguelikeResultInfo.MaxLayer
			}));
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(12), base.GetItem(11));
			UUIItem uuiitem2 = LguiUtil.Instance.CopyItem(base.GetItem(12), base.GetItem(11));
			int count = 0;
			int count2 = 0;
			int num2 = 0;
			RogueParam? paramConfigBySeasonId2 = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			foreach (int num3 in roguelikeResultInfo.Rewards.Keys)
			{
				if (num3 == paramConfigBySeasonId2.Value.SkillPoint)
				{
					count = roguelikeResultInfo.Rewards[num3];
				}
				else if (num3 == paramConfigBySeasonId2.Value.TokenItem)
				{
					count2 = roguelikeResultInfo.Rewards[num3];
				}
				else if (num3 == paramConfigBySeasonId2.Value.InsideCurrency)
				{
					num2 = roguelikeResultInfo.Rewards[num3];
				}
			}
			RoguelikeSettleRecordItem roguelikeSettleRecordItem = new RoguelikeSettleRecordItem(ERoguelikeSettleItemType.KillCount, roguelikeResultInfo.KillEnemyCount);
			roguelikeSettleRecordItem.CreateThenShowByActorAsync(base.GetItem(12).GetOwner(), null, false);
			RoguelikeSettleRecordItem roguelikeSettleRecordItem2 = new RoguelikeSettleRecordItem(ERoguelikeSettleItemType.TokenCount, roguelikeResultInfo.GetGainCount);
			roguelikeSettleRecordItem2.CreateThenShowByActorAsync(uuiitem.GetOwner(), null, false);
			RoguelikeSettleRecordItem roguelikeSettleRecordItem3 = new RoguelikeSettleRecordItem(ERoguelikeSettleItemType.MoneyCount, num2);
			roguelikeSettleRecordItem3.CreateThenShowByActorAsync(uuiitem2.GetOwner(), null, false);
			this.RecordItemList = new List<RoguelikeSettleRecordItem>
			{
				roguelikeSettleRecordItem,
				roguelikeSettleRecordItem2,
				roguelikeSettleRecordItem3
			};
			this.SkillPointRewardItem.Refresh(paramConfigBySeasonId2.Value.SkillPoint, count, roguelikeResultInfo.Rate);
			this.OutSideRewardItem.Refresh(paramConfigBySeasonId2.Value.TokenItem, count2, roguelikeResultInfo.Rate);
			RogueArchiveState rogueArchiveState = roguelikeResultInfo.RogueArchiveState;
			bool flag = rogueArchiveState > RogueArchiveState.CantSave;
			ButtonItem btnAchieveItem = this.BtnAchieveItem;
			if (btnAchieveItem != null)
			{
				btnAchieveItem.SetUiActive(flag);
			}
			if (flag)
			{
				if (rogueArchiveState == RogueArchiveState.Saved)
				{
					ButtonItem btnAchieveItem2 = this.BtnAchieveItem;
					if (btnAchieveItem2 != null)
					{
						btnAchieveItem2.SetLocalTextNew("Rogue_NormalResult_Saved", Array.Empty<object>());
					}
					ButtonItem btnAchieveItem3 = this.BtnAchieveItem;
					if (btnAchieveItem3 == null)
					{
						return;
					}
					btnAchieveItem3.SetEnableClick(false);
					return;
				}
				else
				{
					ButtonItem btnAchieveItem4 = this.BtnAchieveItem;
					if (btnAchieveItem4 != null)
					{
						btnAchieveItem4.SetLocalTextNew("Rogue_NormalResult_CanSave", Array.Empty<object>());
					}
					ButtonItem btnAchieveItem5 = this.BtnAchieveItem;
					if (btnAchieveItem5 == null)
					{
						return;
					}
					btnAchieveItem5.SetEnableClick(true);
				}
			}
		}

		// Token: 0x060287DD RID: 165853 RVA: 0x00B5ABAC File Offset: 0x00B58DAC
		private void OnBtnAchieveClick(int _)
		{
			RoguelikeResultInfo roguelikeResultInfo = (RoguelikeResultInfo)this.OpenParam;
			if (roguelikeResultInfo.RogueArchiveState == RogueArchiveState.CanSave)
			{
				this.OpenAchieveViewAsync(roguelikeResultInfo.RogueArchiveInfo);
			}
		}

		// Token: 0x060287DE RID: 165854 RVA: 0x00B5ABDA File Offset: 0x00B58DDA
		private void OnArchiveSaved(int slotId)
		{
			((RoguelikeResultInfo)this.OpenParam).RogueArchiveState = RogueArchiveState.Saved;
			ButtonItem btnAchieveItem = this.BtnAchieveItem;
			if (btnAchieveItem != null)
			{
				btnAchieveItem.SetLocalTextNew("Rogue_NormalResult_Saved", Array.Empty<object>());
			}
			ButtonItem btnAchieveItem2 = this.BtnAchieveItem;
			if (btnAchieveItem2 == null)
			{
				return;
			}
			btnAchieveItem2.SetEnableClick(false);
		}

		// Token: 0x060287DF RID: 165855 RVA: 0x00B5AC1C File Offset: 0x00B58E1C
		private void OnBtnBackClick()
		{
			RoguelikeResultInfo settleData = (RoguelikeResultInfo)this.OpenParam;
			RogueArchiveState rogueArchiveState = settleData.RogueArchiveState;
			Action<bool> <>9__3;
			Action<bool> exit = delegate(bool fireEvent)
			{
				if (RoguelikeModel.Instance.CheckInRoguelike())
				{
					UniTask<bool> task = InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
					Action<bool> continuationFunction;
					if ((continuationFunction = <>9__3) == null)
					{
						continuationFunction = (<>9__3 = delegate(bool _)
						{
							if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
							{
								this.CloseMe(null);
							}
						});
					}
					task.ContinueWith(continuationFunction);
					return;
				}
				this.CloseMe(null);
			};
			Action value = delegate()
			{
				RoguelikeController.Instance.RoguelikeAchieveGiveUpRequest(exit);
			};
			Action value2 = delegate()
			{
				this.OpenAchieveViewAsync(settleData.RogueArchiveInfo);
			};
			if (rogueArchiveState == RogueArchiveState.CanSave)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoguelikeGiveUpArchiveConfirm);
				confirmBoxDataNew.FunctionMap[1] = value;
				confirmBoxDataNew.FunctionMap[2] = value2;
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			exit(true);
		}

		// Token: 0x060287E0 RID: 165856 RVA: 0x00B5ACD0 File Offset: 0x00B58ED0
		private void OpenAchieveViewAsync(RogueArchiveInfo achieveData)
		{
			RoguelikeSettleView.<>c__DisplayClass16_0 CS$<>8__locals1 = new RoguelikeSettleView.<>c__DisplayClass16_0();
			CS$<>8__locals1.achieveData = achieveData;
			new UiAsyncTask("RoguelikeSettleView.OpenRoguelikeAchieveView", delegate()
			{
				RoguelikeSettleView.<>c__DisplayClass16_0.<<OpenAchieveViewAsync>b__0>d <<OpenAchieveViewAsync>b__0>d;
				<<OpenAchieveViewAsync>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OpenAchieveViewAsync>b__0>d.<>4__this = CS$<>8__locals1;
				<<OpenAchieveViewAsync>b__0>d.<>1__state = -1;
				<<OpenAchieveViewAsync>b__0>d.<>t__builder.Start<RoguelikeSettleView.<>c__DisplayClass16_0.<<OpenAchieveViewAsync>b__0>d>(ref <<OpenAchieveViewAsync>b__0>d);
				return <<OpenAchieveViewAsync>b__0>d.<>t__builder.Task;
			}, null).Run().Forget();
		}

		// Token: 0x04015FA8 RID: 90024
		[Nullable(1)]
		public List<RoguelikeSettleRecordItem> RecordItemList = new List<RoguelikeSettleRecordItem>();

		// Token: 0x04015FA9 RID: 90025
		public RoguelikeSettleCurrencyItem SkillPointRewardItem;

		// Token: 0x04015FAA RID: 90026
		public RoguelikeSettleCurrencyItem OutSideRewardItem;

		// Token: 0x04015FAB RID: 90027
		private ButtonItem BtnAchieveItem;

		// Token: 0x04015FAC RID: 90028
		private bool FirstShowFlag = true;

		// Token: 0x020099F9 RID: 39417
		[NullableContext(0)]
		public static class ERoguelikeSettleViewDefine
		{
			// Token: 0x0402FFF7 RID: 196599
			public const int QualityPanel = 0;

			// Token: 0x0402FFF8 RID: 196600
			public const int RoleSprite = 1;

			// Token: 0x0402FFF9 RID: 196601
			public const int TxtRoleName = 2;

			// Token: 0x0402FFFA RID: 196602
			public const int PhantomSprite = 3;

			// Token: 0x0402FFFB RID: 196603
			public const int TxtPhantomName = 4;

			// Token: 0x0402FFFC RID: 196604
			public const int ResultTex = 5;

			// Token: 0x0402FFFD RID: 196605
			public const int ResultTxt = 6;

			// Token: 0x0402FFFE RID: 196606
			public const int TxtTitle = 7;

			// Token: 0x0402FFFF RID: 196607
			public const int TxtDifficulty = 8;

			// Token: 0x04030000 RID: 196608
			public const int TxtTime = 9;

			// Token: 0x04030001 RID: 196609
			public const int TxtPlayer = 10;

			// Token: 0x04030002 RID: 196610
			public const int RecordPanel = 11;

			// Token: 0x04030003 RID: 196611
			public const int RecordItem = 12;

			// Token: 0x04030004 RID: 196612
			public const int TxtProgress = 13;

			// Token: 0x04030005 RID: 196613
			public const int TxtRate = 14;

			// Token: 0x04030006 RID: 196614
			public const int RewardPanel = 15;

			// Token: 0x04030007 RID: 196615
			public const int RewardItem = 16;

			// Token: 0x04030008 RID: 196616
			public const int BtnBack = 17;

			// Token: 0x04030009 RID: 196617
			public const int RewardItem2 = 18;

			// Token: 0x0403000A RID: 196618
			public const int TextureQualityBg = 19;

			// Token: 0x0403000B RID: 196619
			public const int TxtPassTitle = 20;

			// Token: 0x0403000C RID: 196620
			public const int TxtPassTime = 21;

			// Token: 0x0403000D RID: 196621
			public const int TxtLevelProgress = 22;

			// Token: 0x0403000E RID: 196622
			public const int BtnAchieve = 23;
		}
	}
}
