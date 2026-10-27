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
	// Token: 0x020052B7 RID: 21175
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDialog : IStaticVariableResetter
	{
		// Token: 0x060362A3 RID: 221859 RVA: 0x00CD0838 File Offset: 0x00CCEA38
		public PhantomArenaBattleDialog()
		{
			this.InitSpeakerId();
			this.InitLogic();
		}

		// Token: 0x060362A4 RID: 221860 RVA: 0x00CD0862 File Offset: 0x00CCEA62
		static PhantomArenaBattleDialog()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaBattleDialog.CreateStaticDefaultValue), new Action(PhantomArenaBattleDialog.ResetStaticDefaultValue));
		}

		// Token: 0x060362A5 RID: 221861 RVA: 0x00CD0881 File Offset: 0x00CCEA81
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

		// Token: 0x060362A6 RID: 221862 RVA: 0x00CD08B5 File Offset: 0x00CCEAB5
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaBattleDialog.typeMap = null;
		}

		// Token: 0x060362A7 RID: 221863 RVA: 0x00CD08C0 File Offset: 0x00CCEAC0
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

		// Token: 0x060362A8 RID: 221864 RVA: 0x00CD0927 File Offset: 0x00CCEB27
		protected void InitSpeakerId()
		{
			this.OwnSpeakId = PhantomArenaConfig.Instance.GetPhantomArenaOwnSpeakerId();
			this.OpponentSpeakId = PhantomArenaConfig.Instance.GetPhantomArenaOpponentSpeakerId();
		}

		// Token: 0x060362A9 RID: 221865 RVA: 0x00CD0949 File Offset: 0x00CCEB49
		public void SetOpponentDialogItem(PhantomArenaDialogItem dialogItem)
		{
			this.OpponentDialogItem = dialogItem;
		}

		// Token: 0x060362AA RID: 221866 RVA: 0x00CD0952 File Offset: 0x00CCEB52
		public void SetOwnDialogItem(PhantomArenaDialogItem dialogItem)
		{
			this.OwnDialogItem = dialogItem;
		}

		// Token: 0x060362AB RID: 221867 RVA: 0x00CD095C File Offset: 0x00CCEB5C
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

		// Token: 0x060362AC RID: 221868 RVA: 0x00CD0B94 File Offset: 0x00CCED94
		public void Clear()
		{
			this.Logic.Clear();
		}

		// Token: 0x060362AD RID: 221869 RVA: 0x00CD0BA4 File Offset: 0x00CCEDA4
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

		// Token: 0x060362AE RID: 221870 RVA: 0x00CD0CA8 File Offset: 0x00CCEEA8
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

		// Token: 0x060362AF RID: 221871 RVA: 0x00CD0D1C File Offset: 0x00CCEF1C
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

		// Token: 0x060362B0 RID: 221872 RVA: 0x00CD0DDC File Offset: 0x00CCEFDC
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

		// Token: 0x0401CA80 RID: 117376
		private static Dictionary<EBvbPlayDialogType, int> typeMap;

		// Token: 0x0401CA81 RID: 117377
		protected PhantomArenaDialogItem OpponentDialogItem;

		// Token: 0x0401CA82 RID: 117378
		protected PhantomArenaDialogItem OwnDialogItem;

		// Token: 0x0401CA83 RID: 117379
		protected CommonFlowTextLogic<object> Logic = new CommonFlowTextLogic<object>();

		// Token: 0x0401CA84 RID: 117380
		protected List<ITalkItem> TalkData = new List<ITalkItem>();

		// Token: 0x0401CA85 RID: 117381
		protected int TalkIndex;

		// Token: 0x0401CA86 RID: 117382
		protected int OwnSpeakId;

		// Token: 0x0401CA87 RID: 117383
		protected int OpponentSpeakId;
	}
}
