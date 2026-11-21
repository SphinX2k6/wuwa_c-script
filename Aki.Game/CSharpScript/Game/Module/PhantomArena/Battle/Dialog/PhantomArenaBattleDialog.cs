using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Dialog
{
	// Token: 0x02004287 RID: 17031
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDialog : IStaticVariableResetter
	{
		// Token: 0x0602B19E RID: 176542 RVA: 0x00C1DF60 File Offset: 0x00C1C160
		public PhantomArenaBattleDialog()
		{
			this.InitSpeakerId();
			this.InitLogic();
		}

		// Token: 0x0602B19F RID: 176543 RVA: 0x00C1DF8A File Offset: 0x00C1C18A
		static PhantomArenaBattleDialog()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaBattleDialog.CreateStaticDefaultValue), new Action(PhantomArenaBattleDialog.ResetStaticDefaultValue));
		}

		// Token: 0x0602B1A0 RID: 176544 RVA: 0x00C1DFA9 File Offset: 0x00C1C1A9
		public static void CreateStaticDefaultValue()
		{
			PhantomArenaBattleDialog.typeMap = new Dictionary<EBvbPlayDialogType, int>
			{
				{
					EBvbPlayDialogType.DungeonBegin,
					1
				},
				{
					EBvbPlayDialogType.PlayerBattleWin,
					2
				},
				{
					EBvbPlayDialogType.PlayerWin,
					3
				},
				{
					EBvbPlayDialogType.PlayerLose,
					4
				},
				{
					EBvbPlayDialogType.NewTurnBegin,
					5
				}
			};
		}

		// Token: 0x0602B1A1 RID: 176545 RVA: 0x00C1DFDD File Offset: 0x00C1C1DD
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaBattleDialog.typeMap = null;
		}

		// Token: 0x0602B1A2 RID: 176546 RVA: 0x00C1DFE8 File Offset: 0x00C1C1E8
		protected void InitLogic()
		{
			CommonFlowTextLogicData<object> data = new CommonFlowTextLogicData<object>
			{
				GetTextComp = new Func<ITalkItem, UUIText>(this.GetDialogText),
				TextAnimStartDelegate = new Action<ITalkItem, object>(this.TextAnimStartDelegate),
				TextAnimFinishDelegate = new Action<ITalkItem, object>(this.TextAnimFinishDelegate),
				ClearDelegate = new Action(this.ClearDelegate)
			};
			this.Logic.InitData(data);
		}

		// Token: 0x0602B1A3 RID: 176547 RVA: 0x00C1E04F File Offset: 0x00C1C24F
		protected void InitSpeakerId()
		{
			this.OwnSpeakId = PhantomArenaConfig.Instance.GetPhantomArenaOwnSpeakerId();
			this.OpponentSpeakId = PhantomArenaConfig.Instance.GetPhantomArenaOpponentSpeakerId();
		}

		// Token: 0x0602B1A4 RID: 176548 RVA: 0x00C1E071 File Offset: 0x00C1C271
		public void SetOpponentDialogItem(PhantomArenaDialogItem dialogItem)
		{
			this.OpponentDialogItem = dialogItem;
		}

		// Token: 0x0602B1A5 RID: 176549 RVA: 0x00C1E07A File Offset: 0x00C1C27A
		public void SetOwnDialogItem(PhantomArenaDialogItem dialogItem)
		{
			this.OwnDialogItem = dialogItem;
		}

		// Token: 0x0602B1A6 RID: 176550 RVA: 0x00C1E084 File Offset: 0x00C1C284
		public unsafe void NotifyDialogType(EBvbPlayDialogType dialogType)
		{
			this.TalkData = new List<ITalkItem>();
			this.TalkIndex = 0;
			int challengeId = PhantomArenaBattleModel.Instance.ChallengeId;
			int num;
			PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).DialogMap().TryGetValue(PhantomArenaBattleDialog.typeMap[dialogType], out num);
			if (num == 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "找不到对应的对话配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ChallengeId", challengeId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DialogType", dialogType);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			PhantomBattleDialog phantomBattleDialog = PhantomArenaConfig.Instance.GetPhantomBattleDialog(num);
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(phantomBattleDialog.PlotName, phantomBattleDialog.FlowId, phantomBattleDialog.StateId);
			if (flowStateActions == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.PhantomArena;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "找不到对应的剧本配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PlotName", phantomBattleDialog.PlotName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowId", phantomBattleDialog.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("StateId", phantomBattleDialog.StateId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					ShowTalk showTalk = actionInfo.Params as ShowTalk;
					if (showTalk != null)
					{
						foreach (ITalkItem item in showTalk.TalkItems)
						{
							this.TalkData.Add(item);
						}
					}
				}
			}
			this.Logic.PlayFlowText(this.TalkData[this.TalkIndex], null);
		}

		// Token: 0x0602B1A7 RID: 176551 RVA: 0x00C1E2BC File Offset: 0x00C1C4BC
		public void Clear()
		{
			this.Logic.Clear();
		}

		// Token: 0x0602B1A8 RID: 176552 RVA: 0x00C1E2CC File Offset: 0x00C1C4CC
		private unsafe UUIText GetDialogText(ITalkItem talkData)
		{
			int? whoId = talkData.WhoId;
			int num = this.OwnSpeakId;
			if (whoId.GetValueOrDefault() == num & whoId != null)
			{
				PhantomArenaDialogItem ownDialogItem = this.OwnDialogItem;
				if (ownDialogItem == null)
				{
					return null;
				}
				return ownDialogItem.GetDialog();
			}
			else
			{
				whoId = talkData.WhoId;
				num = this.OpponentSpeakId;
				if (!(whoId.GetValueOrDefault() == num & whoId != null))
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.PhantomArena;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "说话人配置错误";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("编辑器配置ID", talkData.WhoId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("己方说话人ID", this.OwnSpeakId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("对方说话人ID", this.OpponentSpeakId);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return null;
				}
				PhantomArenaDialogItem opponentDialogItem = this.OpponentDialogItem;
				if (opponentDialogItem == null)
				{
					return null;
				}
				return opponentDialogItem.GetDialog();
			}
		}

		// Token: 0x0602B1A9 RID: 176553 RVA: 0x00C1E3D0 File Offset: 0x00C1C5D0
		private void TextAnimStartDelegate(ITalkItem talkData, object _)
		{
			int? whoId = talkData.WhoId;
			int num = this.OwnSpeakId;
			if (!(whoId.GetValueOrDefault() == num & whoId != null))
			{
				whoId = talkData.WhoId;
				num = this.OpponentSpeakId;
				if (whoId.GetValueOrDefault() == num & whoId != null)
				{
					PhantomArenaDialogItem opponentDialogItem = this.OpponentDialogItem;
					if (opponentDialogItem == null)
					{
						return;
					}
					opponentDialogItem.SetDialogActive(true);
				}
				return;
			}
			PhantomArenaDialogItem ownDialogItem = this.OwnDialogItem;
			if (ownDialogItem == null)
			{
				return;
			}
			ownDialogItem.SetDialogActive(true);
		}

		// Token: 0x0602B1AA RID: 176554 RVA: 0x00C1E444 File Offset: 0x00C1C644
		private void TextAnimFinishDelegate(ITalkItem talkData, object _)
		{
			int? whoId = talkData.WhoId;
			int num = this.OwnSpeakId;
			if (whoId.GetValueOrDefault() == num & whoId != null)
			{
				PhantomArenaDialogItem ownDialogItem = this.OwnDialogItem;
				if (ownDialogItem != null)
				{
					ownDialogItem.SetDialogActive(false);
				}
			}
			else
			{
				whoId = talkData.WhoId;
				num = this.OpponentSpeakId;
				if (whoId.GetValueOrDefault() == num & whoId != null)
				{
					PhantomArenaDialogItem opponentDialogItem = this.OpponentDialogItem;
					if (opponentDialogItem != null)
					{
						opponentDialogItem.SetDialogActive(false);
					}
				}
			}
			this.TalkIndex++;
			if (this.TalkIndex >= this.TalkData.Count)
			{
				return;
			}
			this.Logic.PlayFlowText(this.TalkData[this.TalkIndex], this.TalkIndex);
		}

		// Token: 0x0602B1AB RID: 176555 RVA: 0x00C1E504 File Offset: 0x00C1C704
		private void ClearDelegate()
		{
			PhantomArenaDialogItem ownDialogItem = this.OwnDialogItem;
			if (ownDialogItem != null)
			{
				ownDialogItem.SetActive(false);
			}
			PhantomArenaDialogItem opponentDialogItem = this.OpponentDialogItem;
			if (opponentDialogItem == null)
			{
				return;
			}
			opponentDialogItem.SetActive(false);
		}

		// Token: 0x040174B5 RID: 95413
		private static Dictionary<EBvbPlayDialogType, int> typeMap;

		// Token: 0x040174B6 RID: 95414
		protected PhantomArenaDialogItem OpponentDialogItem;

		// Token: 0x040174B7 RID: 95415
		protected PhantomArenaDialogItem OwnDialogItem;

		// Token: 0x040174B8 RID: 95416
		protected CommonFlowTextLogic<object> Logic = new CommonFlowTextLogic<object>();

		// Token: 0x040174B9 RID: 95417
		protected List<ITalkItem> TalkData = new List<ITalkItem>();

		// Token: 0x040174BA RID: 95418
		protected int TalkIndex;

		// Token: 0x040174BB RID: 95419
		protected int OwnSpeakId;

		// Token: 0x040174BC RID: 95420
		protected int OpponentSpeakId;
	}
}
