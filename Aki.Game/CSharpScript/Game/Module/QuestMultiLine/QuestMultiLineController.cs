using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02003F66 RID: 16230
	[Controller(0)]
	public class QuestMultiLineController : ControllerBase
	{
		// Token: 0x06029178 RID: 168312 RVA: 0x00B8A06C File Offset: 0x00B8826C
		protected override bool OnInit()
		{
			this.RegisterListeners();
			return true;
		}

		// Token: 0x06029179 RID: 168313 RVA: 0x00B8A075 File Offset: 0x00B88275
		protected override bool OnClear()
		{
			this.UnregisterListeners();
			return true;
		}

		// Token: 0x0602917A RID: 168314 RVA: 0x00B8A07E File Offset: 0x00B8827E
		public void OpenViewWithTestData()
		{
			this.OpenQuestMultiLineView(0, true, false);
		}

		// Token: 0x0602917B RID: 168315 RVA: 0x00B8A08C File Offset: 0x00B8828C
		public UniTask SendSelectBranchRequest(int branchPageId, int branchId)
		{
			QuestMultiLineController.<SendSelectBranchRequest>d__3 <SendSelectBranchRequest>d__;
			<SendSelectBranchRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SendSelectBranchRequest>d__.branchPageId = branchPageId;
			<SendSelectBranchRequest>d__.branchId = branchId;
			<SendSelectBranchRequest>d__.<>1__state = -1;
			<SendSelectBranchRequest>d__.<>t__builder.Start<QuestMultiLineController.<SendSelectBranchRequest>d__3>(ref <SendSelectBranchRequest>d__);
			return <SendSelectBranchRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602917C RID: 168316 RVA: 0x00B8A0D8 File Offset: 0x00B882D8
		public UniTask<int?> OpenQuestMultiLineView(int timePointId = 0, bool playTimePointComponentAnim = false, bool byPlot = false)
		{
			QuestMultiLineController.<OpenQuestMultiLineView>d__4 <OpenQuestMultiLineView>d__;
			<OpenQuestMultiLineView>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenQuestMultiLineView>d__.timePointId = timePointId;
			<OpenQuestMultiLineView>d__.playTimePointComponentAnim = playTimePointComponentAnim;
			<OpenQuestMultiLineView>d__.byPlot = byPlot;
			<OpenQuestMultiLineView>d__.<>1__state = -1;
			<OpenQuestMultiLineView>d__.<>t__builder.Start<QuestMultiLineController.<OpenQuestMultiLineView>d__4>(ref <OpenQuestMultiLineView>d__);
			return <OpenQuestMultiLineView>d__.<>t__builder.Task;
		}

		// Token: 0x0602917D RID: 168317 RVA: 0x00B8A12C File Offset: 0x00B8832C
		public UniTask<bool> OpenQuestMultiLineTipsViewAsync(int timePointId, bool byPlot = false, bool enableAnimation = false)
		{
			QuestMultiLineController.<OpenQuestMultiLineTipsViewAsync>d__5 <OpenQuestMultiLineTipsViewAsync>d__;
			<OpenQuestMultiLineTipsViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenQuestMultiLineTipsViewAsync>d__.timePointId = timePointId;
			<OpenQuestMultiLineTipsViewAsync>d__.byPlot = byPlot;
			<OpenQuestMultiLineTipsViewAsync>d__.enableAnimation = enableAnimation;
			<OpenQuestMultiLineTipsViewAsync>d__.<>1__state = -1;
			<OpenQuestMultiLineTipsViewAsync>d__.<>t__builder.Start<QuestMultiLineController.<OpenQuestMultiLineTipsViewAsync>d__5>(ref <OpenQuestMultiLineTipsViewAsync>d__);
			return <OpenQuestMultiLineTipsViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602917E RID: 168318 RVA: 0x00B8A17F File Offset: 0x00B8837F
		private void RegisterListeners()
		{
			EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
			Net.Instance.Register(ENotifyMessageId.QuestBranchUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestTimePointUpdateNotify));
		}

		// Token: 0x0602917F RID: 168319 RVA: 0x00B8A1B6 File Offset: 0x00B883B6
		private void UnregisterListeners()
		{
			EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
			Net.Instance.UnRegister(ENotifyMessageId.QuestBranchUpdateNotify);
		}

		// Token: 0x06029180 RID: 168320 RVA: 0x00B8A1E4 File Offset: 0x00B883E4
		[NullableContext(2)]
		private void OnQuestTimePointUpdateNotify(IMessage __msg, Net.CallbackStatus status)
		{
			QuestBranchUpdateNotify questBranchUpdateNotify = (QuestBranchUpdateNotify)__msg;
			if (questBranchUpdateNotify.QuestBranchInfo != null)
			{
				QuestMultiLineModel.Instance.AddData(questBranchUpdateNotify.QuestBranchInfo);
			}
		}

		// Token: 0x06029181 RID: 168321 RVA: 0x00B8A210 File Offset: 0x00B88410
		private void OnEnterGameSuccess()
		{
			this.RequestQuestBranchData();
		}

		// Token: 0x06029182 RID: 168322 RVA: 0x00B8A21C File Offset: 0x00B8841C
		public UniTask RequestQuestBranchData()
		{
			QuestMultiLineController.<RequestQuestBranchData>d__10 <RequestQuestBranchData>d__;
			<RequestQuestBranchData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestQuestBranchData>d__.<>1__state = -1;
			<RequestQuestBranchData>d__.<>t__builder.Start<QuestMultiLineController.<RequestQuestBranchData>d__10>(ref <RequestQuestBranchData>d__);
			return <RequestQuestBranchData>d__.<>t__builder.Task;
		}

		// Token: 0x1700531E RID: 21278
		// (get) Token: 0x06029183 RID: 168323 RVA: 0x00B8A257 File Offset: 0x00B88457
		[Nullable(1)]
		public static QuestMultiLineController Instance
		{
			[NullableContext(1)]
			get
			{
				return QuestMultiLineController._Instance;
			}
		}

		// Token: 0x06029184 RID: 168324 RVA: 0x00B8A25E File Offset: 0x00B8845E
		[NullableContext(1)]
		public static QuestMultiLineController GetOrCreateInstance()
		{
			if (QuestMultiLineController._Instance == null)
			{
				QuestMultiLineController.CreateInstance();
			}
			return QuestMultiLineController._Instance;
		}

		// Token: 0x06029185 RID: 168325 RVA: 0x00B8A272 File Offset: 0x00B88472
		public static bool CreateInstance()
		{
			if (QuestMultiLineController._Instance != null)
			{
				return true;
			}
			QuestMultiLineController._Instance = new QuestMultiLineController();
			return true;
		}

		// Token: 0x06029186 RID: 168326 RVA: 0x00B8A288 File Offset: 0x00B88488
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029187 RID: 168327 RVA: 0x00B8A28A File Offset: 0x00B8848A
		public static void ResetStaticDefaultValue()
		{
			QuestMultiLineController._Instance = null;
		}

		// Token: 0x06029188 RID: 168328 RVA: 0x00B8A292 File Offset: 0x00B88492
		static QuestMultiLineController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuestMultiLineController.CreateStaticDefaultValue), new Action(QuestMultiLineController.ResetStaticDefaultValue));
		}

		// Token: 0x040165BA RID: 91578
		[Nullable(2)]
		private static QuestMultiLineController _Instance;
	}
}
