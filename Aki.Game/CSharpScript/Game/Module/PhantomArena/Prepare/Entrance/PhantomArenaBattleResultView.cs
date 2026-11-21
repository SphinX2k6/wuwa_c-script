using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200412A RID: 16682
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleResultView : UiViewBase
	{
		// Token: 0x0602A2D6 RID: 172758 RVA: 0x00BE82F2 File Offset: 0x00BE64F2
		public PhantomArenaBattleResultView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A2D7 RID: 172759 RVA: 0x00BE82FC File Offset: 0x00BE64FC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIText)),
				new ValueTuple<int, Type>(16, typeof(UUISprite)),
				new ValueTuple<int, Type>(17, typeof(UUISprite)),
				new ValueTuple<int, Type>(18, typeof(UUIText)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickClose))
			};
		}

		// Token: 0x0602A2D8 RID: 172760 RVA: 0x00BE8514 File Offset: 0x00BE6714
		protected override void OnStart()
		{
			BattleResultViewOpenParam battleResultViewOpenParam = this.OpenParam as BattleResultViewOpenParam;
			this.Result = battleResultViewOpenParam.Result;
			if (this.Result.Reward == null)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.WDX, "结算页数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.CallbackOnClose = battleResultViewOpenParam.CallbackOnClose;
			this.ExpTweenComponent = new ExpTweenComponent(base.GetSprite(16), base.GetSprite(10), base.GetSprite(17), null, null);
		}

		// Token: 0x0602A2D9 RID: 172761 RVA: 0x00BE8596 File Offset: 0x00BE6796
		protected override void OnBeforeShow()
		{
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshAll();
		}

		// Token: 0x0602A2DA RID: 172762 RVA: 0x00BE85B4 File Offset: 0x00BE67B4
		protected override void OnAfterShow()
		{
			PhantomBattleBoardSettleNotify result = this.Result;
			string sequenceName = (result != null && result.IsWin) ? "Success" : "Fail";
			this.UiViewSequence.AddSequenceFinishEvent(sequenceName, new Action<string>(this.OnSequenceShowFinish), false);
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
			this.UiViewSequence.PlaySequence(sequenceName, false, null);
		}

		// Token: 0x0602A2DB RID: 172763 RVA: 0x00BE8630 File Offset: 0x00BE6830
		protected override void OnBeforeDestroy()
		{
			if (this.ExpTweenComponent != null)
			{
				this.ExpTweenComponent.Destroy();
			}
			this.RootActor.OnSequencePlayEvent.Unbind();
			PhantomBattleBoardSettleNotify result = this.Result;
			string sequenceName = (result != null && result.IsWin) ? "Success" : "Fail";
			this.UiViewSequence.RemoveSequenceFinishEvent(sequenceName, new Action<string>(this.OnSequenceShowFinish));
		}

		// Token: 0x0602A2DC RID: 172764 RVA: 0x00BE8699 File Offset: 0x00BE6899
		private void RefreshAll()
		{
			this.RefreshViewTitle();
			this.RefreshLevelTitle();
			this.RefreshPointsSkill();
		}

		// Token: 0x0602A2DD RID: 172765 RVA: 0x00BE86B0 File Offset: 0x00BE68B0
		private void RefreshViewTitle()
		{
			PhantomBattleBoardSettleNotify result = this.Result;
			string textStringId = (result != null && result.IsWin) ? "GenericPromptTypes_3_GeneralText" : "GenericPromptTypes_4_GeneralText";
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
			bool flag = this.Result.IsWin && this.Result.SettleType != PhantomBattleBoardSettleType.CommonSettle && this.Result.SettleType != PhantomBattleBoardSettleType.Skip;
			UUIText text = base.GetText(20);
			if (text != null)
			{
				text.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			PhantomBattleBoardSettleType settleType = this.Result.SettleType;
			string text2 = null;
			if (settleType == PhantomBattleBoardSettleType.CommonSettle)
			{
				text2 = "PhantomBattle_1145";
			}
			else if (settleType == PhantomBattleBoardSettleType.RoundSettle)
			{
				text2 = "PhantomBattle_1146";
			}
			else if (settleType == PhantomBattleBoardSettleType.LimitSettle)
			{
				text2 = "PhantomBattle_1147";
			}
			if (text2 != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(20), text2, Array.Empty<object>());
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "声骸bvb结算类型不存在对应的结算文本";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("settleType", (int)settleType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602A2DE RID: 172766 RVA: 0x00BE87B8 File Offset: 0x00BE69B8
		private void RefreshLevelTitle()
		{
			int beforeLv = this.Result.Reward.BeforeLv;
			int afterLv = this.Result.Reward.AfterLv;
			base.GetText(4).SetText(beforeLv.ToString(), true);
			base.GetText(5).SetText(afterLv.ToString(), true);
			base.GetItem(3).SetUIActive(beforeLv != afterLv);
			base.GetText(2).SetText(beforeLv.ToString(), true);
			int addExp = this.Result.Reward.AddExp;
			int totalExp = this.Result.Reward.TotalExp;
			string newText = StringUtils.Format("EXP+{0}", new string[]
			{
				addExp.ToString()
			});
			base.GetText(8).SetText(newText, true);
			base.GetText(8).SetUIActive(addExp > 0);
			PhantomBattleMasterLevel? masterLevelConfig = PhantomArenaModel.Instance.GetMasterLevelConfig(beforeLv, this.Result.ActId);
			int num = Math.Max(totalExp - addExp, 0) - masterLevelConfig.Value.ExpNeed;
			int expNext = masterLevelConfig.Value.ExpNext;
			base.GetSprite(16).SetFillAmount((float)num / (float)expNext);
			base.GetSprite(10).SetFillAmount(0f);
			base.GetSprite(17).SetFillAmount(0f);
			int masterTitleIdByLevel = PhantomArenaModel.Instance.GetMasterTitleIdByLevel(beforeLv, this.Result.ActId);
			string name = PhantomArenaConfig.Instance.GetPhantomBattleMasterTitleById(masterTitleIdByLevel).Name;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), name, Array.Empty<object>());
			int masterExpNextNeed = PhantomArenaModel.Instance.GetMasterExpNextNeed(this.Result.ActId);
			string newText2 = StringUtils.Format("{0}/{1}", new string[]
			{
				totalExp.ToString(),
				masterExpNextNeed.ToString()
			});
			base.GetText(9).SetText(newText2, true);
		}

		// Token: 0x0602A2DF RID: 172767 RVA: 0x00BE89A8 File Offset: 0x00BE6BA8
		private void RefreshPointsSkill()
		{
			int beforeLv = this.Result.Reward.BeforeLv;
			int afterLv = this.Result.Reward.AfterLv;
			int pointsItemId = PhantomArenaModel.Instance.GetPointsItemId(this.Result.ActId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(pointsItemId, 0);
			int num = 0;
			foreach (PhantomBattleReward phantomBattleReward in this.Result.Reward.Reward)
			{
				if (phantomBattleReward.ItemId == pointsItemId)
				{
					num = phantomBattleReward.Count;
				}
			}
			int num2 = commonItemCount - num;
			string newText = (num >= 0) ? ("+" + num.ToString()) : num.ToString();
			base.GetText(14).SetText(num2.ToString(), true);
			base.GetText(18).SetText(newText, true);
			base.GetText(15).SetText(commonItemCount.ToString(), true);
			base.GetItem(13).SetUIActive(num != 0);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(12), "Text_ResultLevelSkillDesc_Text", new <>z__ReadOnlySingleElementList<object>(afterLv));
			base.GetItem(11).SetUIActive(beforeLv != afterLv);
		}

		// Token: 0x0602A2E0 RID: 172768 RVA: 0x00BE8B04 File Offset: 0x00BE6D04
		private void PlayExpTween()
		{
			if (this.Result.Reward.AddExp <= 0)
			{
				return;
			}
			int beforeLv = this.Result.Reward.BeforeLv;
			int afterLv = this.Result.Reward.AfterLv;
			PhantomBattleMasterLevel? masterLevelConfig = PhantomArenaModel.Instance.GetMasterLevelConfig(afterLv, this.Result.ActId);
			float num = (float)(this.Result.Reward.TotalExp - masterLevelConfig.Value.ExpNeed) / (float)masterLevelConfig.Value.ExpNext;
			int num2 = afterLv - beforeLv + 1;
			if (num2 > 2)
			{
				num2 = 2;
			}
			if (num >= 1f)
			{
				num2 = 1;
			}
			this.ExpTweenComponent.PlayExpTween(num2, num, 0f, LTweenEase.InOutSine);
		}

		// Token: 0x0602A2E1 RID: 172769 RVA: 0x00BE8BC2 File Offset: 0x00BE6DC2
		private void OnSequenceShowFinish(string _)
		{
			this.PlayExpTween();
			this.PlayUnlockSequence();
			this.PlayTitleSequence();
		}

		// Token: 0x0602A2E2 RID: 172770 RVA: 0x00BE8BD8 File Offset: 0x00BE6DD8
		private void PlayUnlockSequence()
		{
			int beforeLv = this.Result.Reward.BeforeLv;
			int afterLv = this.Result.Reward.AfterLv;
			if (beforeLv == afterLv)
			{
				return;
			}
			this.UiViewSequence.PlaySequence("Unlock", false, null);
		}

		// Token: 0x0602A2E3 RID: 172771 RVA: 0x00BE8C24 File Offset: 0x00BE6E24
		private void PlayTitleSequence()
		{
			int beforeLv = this.Result.Reward.BeforeLv;
			int afterLv = this.Result.Reward.AfterLv;
			int masterTitleIdByLevel = PhantomArenaModel.Instance.GetMasterTitleIdByLevel(beforeLv, this.Result.ActId);
			int masterTitleIdByLevel2 = PhantomArenaModel.Instance.GetMasterTitleIdByLevel(afterLv, this.Result.ActId);
			if (masterTitleIdByLevel == masterTitleIdByLevel2)
			{
				return;
			}
			this.UiViewSequence.PlaySequence("NameChange", false, null);
		}

		// Token: 0x0602A2E4 RID: 172772 RVA: 0x00BE8CA0 File Offset: 0x00BE6EA0
		private void OnEventSequence(string sequenceName, string eventName)
		{
			int afterLv = this.Result.Reward.AfterLv;
			if (sequenceName == "Unlock".ToString() && eventName == "LevelChange")
			{
				base.GetText(2).SetText(afterLv.ToString(), true);
				return;
			}
			if (sequenceName == "NameChange".ToString() && eventName == "NameChange")
			{
				int masterTitleIdByLevel = PhantomArenaModel.Instance.GetMasterTitleIdByLevel(afterLv, this.Result.ActId);
				string name = PhantomArenaConfig.Instance.GetPhantomBattleMasterTitleById(masterTitleIdByLevel).Name;
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), name, Array.Empty<object>());
			}
		}

		// Token: 0x0602A2E5 RID: 172773 RVA: 0x00BE8D53 File Offset: 0x00BE6F53
		private void OnClickClose()
		{
			base.CloseMe(this.CallbackOnClose);
		}

		// Token: 0x04016F80 RID: 94080
		[Nullable(2)]
		private ExpTweenComponent ExpTweenComponent;

		// Token: 0x04016F81 RID: 94081
		[Nullable(2)]
		private PhantomBattleBoardSettleNotify Result;

		// Token: 0x04016F82 RID: 94082
		[Nullable(2)]
		private Action<bool> CallbackOnClose;

		// Token: 0x02009CF4 RID: 40180
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030C9E RID: 199838
			public const int TextViewTitle = 0;

			// Token: 0x04030C9F RID: 199839
			public const int BtnClose = 1;

			// Token: 0x04030CA0 RID: 199840
			public const int TextLevel = 2;

			// Token: 0x04030CA1 RID: 199841
			public const int PanelLevelUp = 3;

			// Token: 0x04030CA2 RID: 199842
			public const int TextLevelBofore = 4;

			// Token: 0x04030CA3 RID: 199843
			public const int TextLevelAfter = 5;

			// Token: 0x04030CA4 RID: 199844
			public const int PanelPlayerTitle = 6;

			// Token: 0x04030CA5 RID: 199845
			public const int TextPlayerTitle = 7;

			// Token: 0x04030CA6 RID: 199846
			public const int TextExpUp = 8;

			// Token: 0x04030CA7 RID: 199847
			public const int TextExpAll = 9;

			// Token: 0x04030CA8 RID: 199848
			public const int SpriteNextExp = 10;

			// Token: 0x04030CA9 RID: 199849
			public const int PanelUnlock = 11;

			// Token: 0x04030CAA RID: 199850
			public const int TextUnlock = 12;

			// Token: 0x04030CAB RID: 199851
			public const int PanelPoints = 13;

			// Token: 0x04030CAC RID: 199852
			public const int TextPointsOld = 14;

			// Token: 0x04030CAD RID: 199853
			public const int TextPointsNew = 15;

			// Token: 0x04030CAE RID: 199854
			public const int SpriteCurrExp = 16;

			// Token: 0x04030CAF RID: 199855
			public const int SpriteAddExp = 17;

			// Token: 0x04030CB0 RID: 199856
			public const int TextPointsAdd = 18;

			// Token: 0x04030CB1 RID: 199857
			public const int ItemScorePanel = 19;

			// Token: 0x04030CB2 RID: 199858
			public const int TextWinReason = 20;
		}
	}
}
