using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Letter;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.WriteLetter
{
	// Token: 0x020069B4 RID: 27060
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class WriteLetterController : ControllerBase
	{
		// Token: 0x0604352C RID: 275756 RVA: 0x01072A5E File Offset: 0x01070C5E
		protected override bool OnInit()
		{
			this.OnRegisterNetEvent();
			return true;
		}

		// Token: 0x0604352D RID: 275757 RVA: 0x01072A67 File Offset: 0x01070C67
		protected override bool OnClear()
		{
			this.OnUnRegisterNetEvent();
			return true;
		}

		// Token: 0x0604352E RID: 275758 RVA: 0x01072A70 File Offset: 0x01070C70
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MiniWriteLetterLoginNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMiniWriteLetterLoginNotify));
		}

		// Token: 0x0604352F RID: 275759 RVA: 0x01072A8E File Offset: 0x01070C8E
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MiniWriteLetterLoginNotify);
		}

		// Token: 0x06043530 RID: 275760 RVA: 0x01072AA0 File Offset: 0x01070CA0
		public void OpenWriteLetter(IWriteLetter gameplayConfig)
		{
			WriteLetter? config = ConfigWriteLetterById.GetConfig(gameplayConfig.Id, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[WriteLetterController] 写信配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WriteLetterId", gameplayConfig.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			string text = config.Value.Flow(0);
			string text2 = config.Value.Flow(1);
			string text3 = config.Value.Flow(2);
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "[WriteLetterController] 写信配置Flow为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("WriteLetterId", gameplayConfig.Id);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			WriteLetterViewOpenParam writeLetterViewOpenParam = this.ParseWriteLetterFlowInfo(text, text2, text3);
			if (writeLetterViewOpenParam == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Event;
				ELogAuthor author3 = ELogAuthor.YZH;
				string message3 = "[WriteLetterController] 写信Flow解析失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("WriteLetterId", gameplayConfig.Id);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			WriteLetterViewOpenParam param = new WriteLetterViewOpenParam
			{
				FlowListName = writeLetterViewOpenParam.FlowListName,
				FlowId = writeLetterViewOpenParam.FlowId,
				StateId = writeLetterViewOpenParam.StateId,
				LetterStyle = this.ParseWriteLetterStyle(config.Value.Style),
				GameplayId = gameplayConfig.Id.ToString(),
				LetterId = new int?(gameplayConfig.Id)
			};
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.WriteLetterView);
			UiManager.Instance.OpenView(EUiViewName.WriteLetterView, param, null);
		}

		// Token: 0x06043531 RID: 275761 RVA: 0x01072C40 File Offset: 0x01070E40
		public bool OpenLetterBackupDisplayByConfig(int letterId, bool inPlot = false)
		{
			WriteLetter? config = ConfigWriteLetterById.GetConfig(letterId, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[WriteLetterController] 写信配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WriteLetterId", letterId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string text = config.Value.Flow(0);
			string text2 = config.Value.Flow(1);
			string text3 = config.Value.Flow(2);
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.YZH;
				string message2 = "[WriteLetterController] 写信配置Flow为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("WriteLetterId", letterId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			WriteLetterViewOpenParam writeLetterViewOpenParam = this.ParseWriteLetterFlowInfo(text, text2, text3);
			if (writeLetterViewOpenParam == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Event;
				ELogAuthor author3 = ELogAuthor.YZH;
				string message3 = "[WriteLetterController] 写信Flow解析失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("WriteLetterId", letterId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			List<ITalkItem> items = this.CollectDisplayTalkItems(writeLetterViewOpenParam.FlowListName, writeLetterViewOpenParam.FlowId, writeLetterViewOpenParam.StateId);
			LetterBackupDisplayViewOpenParam param = new LetterBackupDisplayViewOpenParam
			{
				LetterId = letterId,
				Items = items,
				LetterStyle = new ELetterStyle?(this.ParseWriteLetterStyle(config.Value.Style))
			};
			if (inPlot)
			{
				UiManager.Instance.OpenViewByPlot(EUiViewName.LetterBackupDisplayView, param, null);
			}
			else
			{
				UiManager.Instance.OpenView(EUiViewName.LetterBackupDisplayView, param, null);
			}
			return true;
		}

		// Token: 0x06043532 RID: 275762 RVA: 0x01072DC0 File Offset: 0x01070FC0
		public ELetterStyle GetLetterStyleByLetterId(int letterId)
		{
			WriteLetter? config = ConfigWriteLetterById.GetConfig(letterId, true);
			if (config == null)
			{
				return ELetterStyle.A;
			}
			return this.ParseWriteLetterStyle(config.Value.Style);
		}

		// Token: 0x06043533 RID: 275763 RVA: 0x01072DF8 File Offset: 0x01070FF8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkItem> CollectDisplayTalkItemsByLetterId(int letterId)
		{
			WriteLetter? config = ConfigWriteLetterById.GetConfig(letterId, true);
			if (config == null)
			{
				return null;
			}
			string text = config.Value.Flow(0);
			string text2 = config.Value.Flow(1);
			string text3 = config.Value.Flow(2);
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
			{
				return null;
			}
			WriteLetterViewOpenParam writeLetterViewOpenParam = this.ParseWriteLetterFlowInfo(text, text2, text3);
			if (writeLetterViewOpenParam == null)
			{
				return null;
			}
			return this.CollectDisplayTalkItems(writeLetterViewOpenParam.FlowListName, writeLetterViewOpenParam.FlowId, writeLetterViewOpenParam.StateId);
		}

		// Token: 0x06043534 RID: 275764 RVA: 0x01072E94 File Offset: 0x01071094
		private List<ITalkItem> CollectDisplayTalkItems(string flowListName, int flowId, int stateId)
		{
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flowListName, flowId, stateId);
			if (flowStateActions == null)
			{
				return new List<ITalkItem>();
			}
			List<ITalkItem> list = new List<ITalkItem>();
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					ShowTalk showTalk = actionInfo.Params as ShowTalk;
					if (showTalk != null)
					{
						foreach (ITalkItem talkItem in (showTalk.TalkItems ?? new List<ITalkItem>()))
						{
							List<ITalkOption> options = talkItem.Options;
							if (((options != null) ? options.Count : 0) <= 0)
							{
								ITalkItemDialog talkItemDialog = talkItem as ITalkItemDialog;
								bool flag;
								if (talkItemDialog == null)
								{
									flag = false;
								}
								else
								{
									ITalkItemStyle style = talkItemDialog.Style;
									ETalkItemStyle? etalkItemStyle = (style != null) ? new ETalkItemStyle?(style.Type) : null;
									ETalkItemStyle etalkItemStyle2 = ETalkItemStyle.InnerVoice;
									flag = (etalkItemStyle.GetValueOrDefault() == etalkItemStyle2 & etalkItemStyle != null);
								}
								if (!flag)
								{
									list.Add(talkItem);
								}
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06043535 RID: 275765 RVA: 0x01072FCC File Offset: 0x010711CC
		public void RequestWriteLetterComplete(string gameplayId)
		{
			UiGamePlayRequest uiGamePlayRequest = UiGamePlayRequest.Create();
			uiGamePlayRequest.GamePlayKey = gameplayId;
			uiGamePlayRequest.Type = UiGamePlayType.WriteLetter;
			Net.Instance.Call(ERequestMessageId.UiGamePlayRequest, uiGamePlayRequest, null, 0);
		}

		// Token: 0x06043536 RID: 275766 RVA: 0x01073000 File Offset: 0x01071200
		public void RecordWriteLetterContent(int letterId, ITalkItem talkItem)
		{
			WriteLetterModel instance = WriteLetterModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RecordLetterContent(letterId, talkItem);
		}

		// Token: 0x06043537 RID: 275767 RVA: 0x01073020 File Offset: 0x01071220
		public unsafe void RequestWriteLetterSaveContent(int letterId)
		{
			WriteLetterModel instance = WriteLetterModel.Instance;
			if (instance == null || !instance.HasLetterContent(letterId))
			{
				return;
			}
			MiniLetterContentPb letterContentPb = instance.GetLetterContentPb(letterId);
			if (letterContentPb == null)
			{
				return;
			}
			MiniWriteLetterSaveContentRequest miniWriteLetterSaveContentRequest = MiniWriteLetterSaveContentRequest.Create();
			miniWriteLetterSaveContentRequest.LetterContent.Add(letterContentPb);
			Net.Instance.Call(ERequestMessageId.MiniWriteLetterSaveContentRequest, miniWriteLetterSaveContentRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MiniWriteLetterSaveContentResponse miniWriteLetterSaveContentResponse = (MiniWriteLetterSaveContentResponse)msg;
				if (miniWriteLetterSaveContentResponse == null || miniWriteLetterSaveContentResponse.ErrorId == Aki.Protocol.ErrorCode.Success)
				{
					return;
				}
				global::Log instance2 = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[WriteLetterController] 保存信件内容失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LetterId", letterId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ErrorId", miniWriteLetterSaveContentResponse.ErrorId);
				instance2.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}, 0);
		}

		// Token: 0x06043538 RID: 275768 RVA: 0x01073094 File Offset: 0x01071294
		[NullableContext(2)]
		private void OnMiniWriteLetterLoginNotify(IMessage msg, Net.CallbackStatus status)
		{
			MiniWriteLetterLoginNotify miniWriteLetterLoginNotify = (MiniWriteLetterLoginNotify)msg;
			if (miniWriteLetterLoginNotify == null)
			{
				return;
			}
			WriteLetterModel instance = WriteLetterModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SetLetterContentsFromProto(miniWriteLetterLoginNotify.LetterContent);
		}

		// Token: 0x06043539 RID: 275769 RVA: 0x010730C4 File Offset: 0x010712C4
		private ELetterStyle ParseWriteLetterStyle(string style)
		{
			string a = style.Trim();
			if (a == "Rover")
			{
				return ELetterStyle.A;
			}
			if (a == "Yangyang")
			{
				return ELetterStyle.B;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[WriteLetterController] 未识别的Style，回退A";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Style", style);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return ELetterStyle.A;
		}

		// Token: 0x0604353A RID: 275770 RVA: 0x01073120 File Offset: 0x01071320
		[return: Nullable(2)]
		private WriteLetterViewOpenParam ParseWriteLetterFlowInfo(string flowListNameRaw, string flowIdRaw, string stateIdRaw)
		{
			string text = flowListNameRaw.Trim();
			int flowId;
			int stateId;
			if (string.IsNullOrEmpty(text) || !int.TryParse(flowIdRaw, out flowId) || !int.TryParse(stateIdRaw, out stateId))
			{
				return null;
			}
			return new WriteLetterViewOpenParam
			{
				FlowListName = text,
				FlowId = flowId,
				StateId = stateId,
				LetterStyle = ELetterStyle.A
			};
		}

		// Token: 0x17009859 RID: 39001
		// (get) Token: 0x0604353B RID: 275771 RVA: 0x01073173 File Offset: 0x01071373
		public static WriteLetterController Instance
		{
			get
			{
				return WriteLetterController._Instance;
			}
		}

		// Token: 0x0604353C RID: 275772 RVA: 0x0107317A File Offset: 0x0107137A
		public static WriteLetterController GetOrCreateInstance()
		{
			if (WriteLetterController._Instance == null)
			{
				WriteLetterController.CreateInstance();
			}
			return WriteLetterController._Instance;
		}

		// Token: 0x0604353D RID: 275773 RVA: 0x0107318E File Offset: 0x0107138E
		public static bool CreateInstance()
		{
			if (WriteLetterController._Instance != null)
			{
				return true;
			}
			WriteLetterController._Instance = new WriteLetterController();
			return true;
		}

		// Token: 0x0604353E RID: 275774 RVA: 0x010731A4 File Offset: 0x010713A4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604353F RID: 275775 RVA: 0x010731A6 File Offset: 0x010713A6
		public static void ResetStaticDefaultValue()
		{
			WriteLetterController._Instance = null;
		}

		// Token: 0x06043540 RID: 275776 RVA: 0x010731AE File Offset: 0x010713AE
		static WriteLetterController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WriteLetterController.CreateStaticDefaultValue), new Action(WriteLetterController.ResetStaticDefaultValue));
		}

		// Token: 0x040231FD RID: 143869
		[Nullable(2)]
		private static WriteLetterController _Instance;
	}
}
