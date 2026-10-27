using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x0200731C RID: 29468
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskMontage : AiStateMachineTask, IAiTaskMontage
	{
		// Token: 0x17009F86 RID: 40838
		// (get) Token: 0x0604854A RID: 296266 RVA: 0x0129A3D6 File Offset: 0x012985D6
		// (set) Token: 0x0604854B RID: 296267 RVA: 0x0129A3DE File Offset: 0x012985DE
		public bool Playing { get; set; }

		// Token: 0x17009F87 RID: 40839
		// (get) Token: 0x0604854C RID: 296268 RVA: 0x0129A3E7 File Offset: 0x012985E7
		// (set) Token: 0x0604854D RID: 296269 RVA: 0x0129A3EF File Offset: 0x012985EF
		public float RemainedTrigger { get; set; } = -1f;

		// Token: 0x0604854E RID: 296270 RVA: 0x0129A3F8 File Offset: 0x012985F8
		public AiStateMachineTaskMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x17009F88 RID: 40840
		// (get) Token: 0x0604854F RID: 296271 RVA: 0x0129A435 File Offset: 0x01298635
		public bool HasResource
		{
			get
			{
				return this.MontageHandle != null || this.Node.TaskFinished;
			}
		}

		// Token: 0x06048550 RID: 296272 RVA: 0x0129A454 File Offset: 0x01298654
		protected unsafe override bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			AiStateMachineBase node = this.Node;
			if (((node != null) ? node.MontageComponent : null) == null)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
				AiStateMachineBase node2 = this.Node;
				Entity entity = (node2 != null) ? node2.Entity : null;
				string message = "注册蒙太奇到ForcePushMontageSet失败，Node或Node的蒙太奇组件不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MontageName", this.MontageName);
				instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (task.TaskMontage != null)
			{
				this.MontageName = task.TaskMontage.MontageName;
				this.HideOnLoading = task.TaskMontage.HideOnLoading;
				this.BlendInTime = task.TaskMontage.BlendInTime * 0.001f;
				this.ForcePush2Server = task.TaskMontage.ForcePush2Server;
				this.ConfigReplaceTagId = task.TaskMontage.ConfigReplaceTagId;
				this.ConfigReplaceTagName = task.TaskMontage.ConfigReplaceTagName;
				this.ForcePushRegistered = false;
			}
			if (!string.IsNullOrEmpty(this.ConfigReplaceTagName) && this.ConfigReplaceTagName != "None")
			{
				this.ReplaceConfig = this.Node.FindStateRepPerfConfig(this.ConfigReplaceTagName);
				IStateRepPerfBase replaceConfig = this.ReplaceConfig;
				if (replaceConfig != null && replaceConfig.Type == EStateRepPerfType.MontagePath)
				{
					IStateRepPerfMontagePath stateRepPerfMontagePath = this.ReplaceConfig as IStateRepPerfMontagePath;
					if (!string.IsNullOrEmpty((stateRepPerfMontagePath != null) ? stateRepPerfMontagePath.MontagePath : null))
					{
						string baseFilename = UBlueprintPathsLibrary.GetBaseFilename(stateRepPerfMontagePath.MontagePath, true);
						if (!string.IsNullOrEmpty(baseFilename))
						{
							string montageName = this.MontageName;
							this.MontageName = baseFilename;
							CombatLog instance2 = CombatLog.Instance;
							CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
							AiStateMachineBase node3 = this.Node;
							Entity entity2 = (node3 != null) ? node3.Entity : null;
							string message2 = "MontageTask蒙太奇替换成功";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原MontageName", montageName);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("新MontageName", baseFilename);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Path", stateRepPerfMontagePath.MontagePath);
							instance2.Info(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						}
					}
				}
				else if (this.ReplaceConfig != null)
				{
					CombatLog instance3 = CombatLog.Instance;
					CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.StateMachineNew;
					AiStateMachineBase node4 = this.Node;
					Entity entity3 = (node4 != null) ? node4.Entity : null;
					string message3 = "MontageTask替换配置错误，替换配置不生效";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("节点", this.Node.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ConfigReplaceTagName", this.ConfigReplaceTagName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("配置覆盖Type", this.ReplaceConfig.Type);
					instance3.Error(flag3, entity3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
			}
			string montagePathByName = this.Node.MontageComponent.GetMontagePathByName(this.MontageName, true, false);
			if (!string.IsNullOrEmpty(montagePathByName))
			{
				this.MontageHash = UGASBPLibrary.FnvHash(montagePathByName);
			}
			else
			{
				this.MontageHash = -1;
				CombatLog instance4 = CombatLog.Instance;
				CombatLog.EDebugModule flag4 = CombatLog.EDebugModule.StateMachineNew;
				AiStateMachineBase node5 = this.Node;
				Entity entity4 = (node5 != null) ? node5.Entity : null;
				string message4 = "MontageTask获取蒙太奇HashID失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MontageName", this.MontageName);
				instance4.Warn(flag4, entity4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return true;
		}

		// Token: 0x06048551 RID: 296273 RVA: 0x0129A774 File Offset: 0x01298974
		public unsafe override void OnEnter(long? contextId = null)
		{
			if (this.ForcePush2Server && !this.ForcePushRegistered)
			{
				this.Node.MontageComponent.AddForcePushMontage(this.MontageName);
				this.ForcePushRegistered = true;
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
				AiStateMachineBase node = this.Node;
				Entity entity = (node != null) ? node.Entity : null;
				string message = "注册蒙太奇到ForcePushMontageSet";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MontageName", this.MontageName);
				instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			AiStateMachineBase node2 = this.Node;
			if (((node2 != null) ? node2.TagComponent : null) == null)
			{
				return;
			}
			if (this.Node.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				this.Node.TaskFinished = true;
				return;
			}
			CharacterSkillComponent skillComponent = this.Node.SkillComponent;
			if (skillComponent != null)
			{
				skillComponent.StopGroup1Skill("AiStateMachineTaskMontage.OnEnter");
			}
			this.Node.TaskFinished = false;
			this.Loading = true;
			this.Playing = false;
			this.PredictEndDuration = -1f;
			if (this.MontageHash != -1)
			{
				AiStateMachineGroup owner = this.Node.Owner;
				if (owner.HasValidMontagePredictEndParams() && owner.GetMontagePredictEndHash() == this.MontageHash)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
					AiStateMachineBase node3 = this.Node;
					Entity entity2 = (node3 != null) ? node3.Entity : null;
					string message2 = "MontageTask OnEnter清除残留的先行结束参数";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("montage", this.MontageName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MontageHash", this.MontageHash);
					instance2.Info(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					owner.ClearMontagePredictEndParams();
				}
			}
			if (this.Node.MontageComponent == null)
			{
				return;
			}
			CharacterMontageComponent montageComponent = this.Node.MontageComponent;
			if (this.MontageHandle == null)
			{
				if (this.HideOnLoading && this.DisableHandle == null)
				{
					this.DisableHandle = new int?(this.Node.ActorComponent.DisableActor("状态机加载动作"));
				}
				this.MontageHandle = montageComponent.CreateTaskWithName(this.MontageName, new Action(this.OnLoadCompleted), new Action<bool>(this.OnMontageEnd), this.BlendInTime);
				if (this.MontageHandle != null)
				{
					montageComponent.SetMontageTaskRemainCb(this.MontageHandle.Value, new Action<float>(this.OnMontageRemain));
				}
			}
			if (this.MontageHandle != null)
			{
				this.Playing = true;
				float num = (float)((double)this.Node.ElapseTime * TimeUtil.Instance.Millisecond);
				float montageTimeLength = montageComponent.GetMontageTimeLength(this.MontageHandle.Value);
				if (montageTimeLength > 0f && num > montageTimeLength)
				{
					num %= montageTimeLength;
				}
				montageComponent.PlayMontageTaskWhenReady(this.MontageHandle.Value, num, new long?(contextId.Value), this.RemainedTrigger);
				return;
			}
			this.Node.TaskFinished = true;
		}

		// Token: 0x06048552 RID: 296274 RVA: 0x0129AA58 File Offset: 0x01298C58
		public unsafe override void OnExit(long? contextId = null)
		{
			if (this.Node != null)
			{
				if (this.Node.ActorComponent != null && this.HideOnLoading && this.Loading && this.DisableHandle != null)
				{
					this.Node.ActorComponent.EnableActor(this.DisableHandle.Value);
					this.DisableHandle = null;
				}
				if (this.MontageHash != -1)
				{
					AiStateMachineGroup owner = this.Node.Owner;
					if (owner.HasValidMontagePredictEndParams() && owner.GetMontagePredictEndHash() == this.MontageHash)
					{
						CombatLog instance = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
						AiStateMachineBase node = this.Node;
						Entity entity = (node != null) ? node.Entity : null;
						string message = "MontageTask OnExit清除残留的先行结束参数";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("montage", this.MontageName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MontageHash", this.MontageHash);
						instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						owner.ClearMontagePredictEndParams();
					}
				}
				if (this.Node.MontageComponent != null && this.MontageHandle != null)
				{
					this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
				}
			}
			this.MontageHandle = null;
			this.Node.TaskFinished = false;
			this.Playing = false;
		}

		// Token: 0x06048553 RID: 296275 RVA: 0x0129ABC0 File Offset: 0x01298DC0
		protected override void OnTick(float deltaSeconds, long? contextId = null)
		{
			if (this.Node != null && this.Node.MontageComponent != null && this.MontageHandle != null)
			{
				this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value);
			}
			this.CheckPredictEnd(deltaSeconds);
		}

		// Token: 0x06048554 RID: 296276 RVA: 0x0129AC14 File Offset: 0x01298E14
		protected override void OnClear()
		{
			if (this.Node != null && this.Node.MontageComponent != null && this.MontageHandle != null)
			{
				this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
			}
			this.MontageHandle = null;
		}

		// Token: 0x06048555 RID: 296277 RVA: 0x0129AC6C File Offset: 0x01298E6C
		private void OnLoadCompleted()
		{
			this.Loading = false;
			if (this.Node == null || !this.Node.Activated)
			{
				return;
			}
			if (this.Node.ActorComponent != null && this.HideOnLoading && this.DisableHandle != null)
			{
				this.Node.ActorComponent.EnableActor(this.DisableHandle.Value);
				this.DisableHandle = null;
			}
			CharacterMoveComponent moveComponent = this.Node.MoveComponent;
			if (moveComponent == null)
			{
				return;
			}
			moveComponent.SetForceSpeed(Vector.ZeroVectorProxy);
		}

		// Token: 0x06048556 RID: 296278 RVA: 0x0129ACFA File Offset: 0x01298EFA
		private void OnMontageEnd(bool isInterrupted)
		{
			this.Node.TaskFinished = true;
			this.MontageHandle = null;
		}

		// Token: 0x06048557 RID: 296279 RVA: 0x0129AD14 File Offset: 0x01298F14
		private unsafe void OnMontageRemain(float remainTime)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
			AiStateMachineBase node = this.Node;
			Entity entity = (node != null) ? node.Entity : null;
			string message = "Montage Task OnMontageRemain";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("montage", this.GetNameByCurrentHandle() ?? "");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("remain time", remainTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("remained trigger", this.RemainedTrigger);
			instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EventSystem.Instance.EmitWithTarget<float>(this, EEventName.OnMontageRemain, remainTime);
		}

		// Token: 0x06048558 RID: 296280 RVA: 0x0129ADCC File Offset: 0x01298FCC
		public double GetTimeRemaining()
		{
			if (this.Node == null || this.Node.MontageComponent == null)
			{
				return -1.0;
			}
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x06048559 RID: 296281 RVA: 0x0129AE28 File Offset: 0x01299028
		public double GetTimeElapsing()
		{
			if (this.Node == null || this.Node.MontageComponent == null)
			{
				return -1.0;
			}
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeElapsing(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0604855A RID: 296282 RVA: 0x0129AE84 File Offset: 0x01299084
		public double GetTimeLength()
		{
			if (this.Node == null || this.Node.MontageComponent == null)
			{
				return -1.0;
			}
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeLength(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0604855B RID: 296283 RVA: 0x0129AEE0 File Offset: 0x012990E0
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0604855C RID: 296284 RVA: 0x0129AEE9 File Offset: 0x012990E9
		[NullableContext(2)]
		private string GetNameByHandle(int handle)
		{
			if (this.Node == null || this.Node.MontageComponent == null)
			{
				return null;
			}
			return this.Node.MontageComponent.GetMontageTaskNameByHandle(handle);
		}

		// Token: 0x0604855D RID: 296285 RVA: 0x0129AF13 File Offset: 0x01299113
		[NullableContext(2)]
		public string GetNameByCurrentHandle()
		{
			if (this.MontageHandle != null)
			{
				return this.GetNameByHandle(this.MontageHandle.Value);
			}
			return null;
		}

		// Token: 0x0604855E RID: 296286 RVA: 0x0129AF38 File Offset: 0x01299138
		private unsafe void CheckPredictEnd(float deltaSeconds)
		{
			if (!this.Playing || this.Loading)
			{
				return;
			}
			if (this.PredictEndDuration == -1f && this.MontageHash != -1)
			{
				AiStateMachineGroup owner = this.Node.Owner;
				if (owner.HasValidMontagePredictEndParams() && owner.GetMontagePredictEndHash() == this.MontageHash)
				{
					this.PredictEndDuration = owner.GetMontagePredictEndDuration();
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
					AiStateMachineBase node = this.Node;
					Entity entity = (node != null) ? node.Entity : null;
					string message = "MontageTask先行结束时间应用";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("montage", this.MontageName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MontageHash", this.MontageHash);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("duration", this.PredictEndDuration);
					instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					owner.ClearMontagePredictEndParams();
				}
			}
			if (this.PredictEndDuration > 0f && this.Node.ElapseTime >= this.PredictEndDuration)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
				AiStateMachineBase node2 = this.Node;
				Entity entity2 = (node2 != null) ? node2.Entity : null;
				string message2 = "MontageTask先行结束时间到，结束蒙太奇";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("montage", this.MontageName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("MontageHash", this.MontageHash);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("elapsed", this.Node.ElapseTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("duration", this.PredictEndDuration);
				instance2.Info(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				if (this.HideOnLoading && this.Loading && this.DisableHandle != null)
				{
					if (this.Node != null && this.Node.ActorComponent != null)
					{
						this.Node.ActorComponent.EnableActor(this.DisableHandle.Value);
					}
					this.DisableHandle = null;
				}
				if (this.Node != null && this.Node.MontageComponent != null && this.MontageHandle != null)
				{
					this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
				}
				this.OnMontageEnd(true);
			}
		}

		// Token: 0x040263D7 RID: 156631
		private string MontageName = "";

		// Token: 0x040263D8 RID: 156632
		private bool HideOnLoading;

		// Token: 0x040263D9 RID: 156633
		private float BlendInTime;

		// Token: 0x040263DA RID: 156634
		private bool ForcePush2Server;

		// Token: 0x040263DB RID: 156635
		public int ConfigReplaceTagId;

		// Token: 0x040263DC RID: 156636
		public string ConfigReplaceTagName = "";

		// Token: 0x040263DD RID: 156637
		[Nullable(2)]
		private IStateRepPerfBase ReplaceConfig;

		// Token: 0x040263DE RID: 156638
		private bool ForcePushRegistered;

		// Token: 0x040263DF RID: 156639
		private int? DisableHandle;

		// Token: 0x040263E0 RID: 156640
		private int? MontageHandle;

		// Token: 0x040263E1 RID: 156641
		private bool Loading;

		// Token: 0x040263E4 RID: 156644
		private int MontageHash = -1;

		// Token: 0x040263E5 RID: 156645
		private float PredictEndDuration = -1f;
	}
}
