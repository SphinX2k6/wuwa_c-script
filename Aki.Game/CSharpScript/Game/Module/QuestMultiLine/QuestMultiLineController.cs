using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02004F9D RID: 20381
	[Controller(0)]
	public class QuestMultiLineController : ControllerBase
	{
		// Token: 0x0603430A RID: 213770 RVA: 0x00C408C0 File Offset: 0x00C3EAC0
		protected override bool OnInit()
		{
			this.RegisterListeners();
			return true;
		}

		// Token: 0x0603430B RID: 213771 RVA: 0x00C408C9 File Offset: 0x00C3EAC9
		protected override bool OnClear()
		{
			this.UnregisterListeners();
			return true;
		}

		// Token: 0x0603430C RID: 213772 RVA: 0x00C408D2 File Offset: 0x00C3EAD2
		public void OpenViewWithTestData()
		{
			this.OpenQuestMultiLineView(0, true, false);
		}

		// Token: 0x0603430D RID: 213773 RVA: 0x00C408E0 File Offset: 0x00C3EAE0
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

		// Token: 0x0603430E RID: 213774 RVA: 0x00C4092C File Offset: 0x00C3EB2C
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

		// Token: 0x0603430F RID: 213775 RVA: 0x00C40980 File Offset: 0x00C3EB80
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

		// Token: 0x06034310 RID: 213776 RVA: 0x00C409D3 File Offset: 0x00C3EBD3
		private void RegisterListeners()
		{
			EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
			Net.Instance.Register(ENotifyMessageId.QuestBranchUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnQuestTimePointUpdateNotify));
		}

		// Token: 0x06034311 RID: 213777 RVA: 0x00C40A0A File Offset: 0x00C3EC0A
		private void UnregisterListeners()
		{
			EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.OnEnterGameSuccess));
			Net.Instance.UnRegister(ENotifyMessageId.QuestBranchUpdateNotify);
		}

		// Token: 0x06034312 RID: 213778 RVA: 0x00C40A38 File Offset: 0x00C3EC38
		[NullableContext(2)]
		private void OnQuestTimePointUpdateNotify(IMessage __msg, Net.CallbackStatus status)
		{
			QuestBranchUpdateNotify questBranchUpdateNotify = (QuestBranchUpdateNotify)__msg;
			if (questBranchUpdateNotify.QuestBranchInfo != null)
			{
				QuestMultiLineModel.Instance.AddData(questBranchUpdateNotify.QuestBranchInfo);
			}
		}

		// Token: 0x06034313 RID: 213779 RVA: 0x00C40A64 File Offset: 0x00C3EC64
		private void OnEnterGameSuccess()
		{
			this.RequestQuestBranchData();
		}

		// Token: 0x06034314 RID: 213780 RVA: 0x00C40A70 File Offset: 0x00C3EC70
		public UniTask RequestQuestBranchData()
		{
			QuestMultiLineController.<RequestQuestBranchData>d__10 <RequestQuestBranchData>d__;
			<RequestQuestBranchData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestQuestBranchData>d__.<>1__state = -1;
			<RequestQuestBranchData>d__.<>t__builder.Start<QuestMultiLineController.<RequestQuestBranchData>d__10>(ref <RequestQuestBranchData>d__);
			return <RequestQuestBranchData>d__.<>t__builder.Task;
		}

		// Token: 0x17007F6E RID: 32622
		// (get) Token: 0x06034315 RID: 213781 RVA: 0x00C40AAB File Offset: 0x00C3ECAB
		[Nullable(1)]
		public static QuestMultiLineController Instance
		{
			[NullableContext(1)]
			get
			{
				return QuestMultiLineController._Instance;
			}
		}

		// Token: 0x06034316 RID: 213782 RVA: 0x00C40AB2 File Offset: 0x00C3ECB2
		[NullableContext(1)]
		public static QuestMultiLineController GetOrCreateInstance()
		{
			if (QuestMultiLineController._Instance == null)
			{
				QuestMultiLineController.CreateInstance();
			}
			return QuestMultiLineController._Instance;
		}

		// Token: 0x06034317 RID: 213783 RVA: 0x00C40AC6 File Offset: 0x00C3ECC6
		public static bool CreateInstance()
		{
			if (QuestMultiLineController._Instance != null)
			{
				return true;
			}
			QuestMultiLineController._Instance = new QuestMultiLineController();
			return true;
		}

		// Token: 0x06034318 RID: 213784 RVA: 0x00C40ADC File Offset: 0x00C3ECDC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034319 RID: 213785 RVA: 0x00C40ADE File Offset: 0x00C3ECDE
		public static void ResetStaticDefaultValue()
		{
			QuestMultiLineController._Instance = null;
		}

		// Token: 0x0603431A RID: 213786 RVA: 0x00C40AE6 File Offset: 0x00C3ECE6
		static QuestMultiLineController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuestMultiLineController.CreateStaticDefaultValue), new Action(QuestMultiLineController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BBE5 RID: 113637
		[Nullable(2)]
		private static QuestMultiLineController _Instance;
	}
}
