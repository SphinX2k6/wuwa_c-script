using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x02007318 RID: 29464
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskBeHitMontage : AiStateMachineTask, IAiTaskMontage
	{
		// Token: 0x17009F83 RID: 40835
		// (get) Token: 0x06048522 RID: 296226 RVA: 0x012991D0 File Offset: 0x012973D0
		// (set) Token: 0x06048523 RID: 296227 RVA: 0x012991D8 File Offset: 0x012973D8
		public bool Playing { get; set; }

		// Token: 0x17009F84 RID: 40836
		// (get) Token: 0x06048524 RID: 296228 RVA: 0x012991E1 File Offset: 0x012973E1
		// (set) Token: 0x06048525 RID: 296229 RVA: 0x012991E9 File Offset: 0x012973E9
		public float RemainedTrigger { get; set; } = -1f;

		// Token: 0x06048526 RID: 296230 RVA: 0x012991F2 File Offset: 0x012973F2
		public AiStateMachineTaskBeHitMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x17009F85 RID: 40837
		// (get) Token: 0x06048527 RID: 296231 RVA: 0x01299228 File Offset: 0x01297428
		public bool HasResource
		{
			get
			{
				return this.MontageHandle != null;
			}
		}

		// Token: 0x06048528 RID: 296232 RVA: 0x01299238 File Offset: 0x01297438
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			this.DefaultMontageName = task.TaskBeHitMontage.DefaultMontageName;
			foreach (ValueTuple<int, string> valueTuple in task.TaskBeHitMontage.MontageMap)
			{
				this.MontageMap[(EHitAnim)valueTuple.Item1] = valueTuple.Item2;
			}
			this.BlendInTime = task.TaskBeHitMontage.BlendInTime * 0.001f;
			return true;
		}

		// Token: 0x06048529 RID: 296233 RVA: 0x012992CC File Offset: 0x012974CC
		private void ActivateHitStateByHitAnim(EHitAnim beHitAnim)
		{
			if (this.Node.UnifiedStateComponent.PositionState == ECharPositionState.Air)
			{
				this.Node.UnifiedStateComponent.SetMoveState(ECharMoveState.KnockUp);
				return;
			}
			switch (beHitAnim)
			{
			case EHitAnim.轻左:
			case EHitAnim.轻右:
			case EHitAnim.轻前:
			case EHitAnim.轻后:
				this.Node.UnifiedStateComponent.SetMoveState(ECharMoveState.SoftKnock);
				return;
			case EHitAnim.重左:
			case EHitAnim.重右:
			case EHitAnim.压制:
			case EHitAnim.重前:
			case EHitAnim.重后:
				this.Node.UnifiedStateComponent.SetMoveState(ECharMoveState.HeavyKnock);
				return;
			case EHitAnim.击飞:
			case EHitAnim.击倒:
				this.Node.UnifiedStateComponent.SetMoveState(ECharMoveState.KnockUp);
				return;
			case EHitAnim.被弹反:
				this.Node.UnifiedStateComponent.SetMoveState(ECharMoveState.Parry);
				return;
			case EHitAnim.被破弱:
				this.Node.UnifiedStateComponent.SetMoveState(ECharMoveState.BreakWeakness);
				return;
			default:
				return;
			}
		}

		// Token: 0x0604852A RID: 296234 RVA: 0x01299398 File Offset: 0x01297598
		public unsafe override void OnEnter(long? contextId = null)
		{
			if (this.Node.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				this.Node.TaskFinished = true;
				return;
			}
			EHitAnim beHitAnim = this.Node.HitComponent.BeHitAnim;
			this.ActivateHitStateByHitAnim(beHitAnim);
			this.MontageName = this.MontageMap.GetValueOrDefault(beHitAnim);
			if (string.IsNullOrEmpty(this.MontageName))
			{
				this.MontageName = this.DefaultMontageName;
			}
			if (string.IsNullOrEmpty(this.MontageName))
			{
				CreatureDataComponent component = this.Node.Entity.GetComponent<CreatureDataComponent>();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Resource;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "受击动画播放失败，MontageName为空";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "actorName";
				CharacterActorComponent actorComponent = this.Node.ActorComponent;
				ptr = new ValueTuple<string, object>(item, (actorComponent != null) ? actorComponent.Actor.GetName() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pbDataId", component.GetPbDataId());
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "nodeName";
				AiStateMachineBase node = this.Node;
				ptr2 = new ValueTuple<string, object>(item2, (node != null) ? node.Name : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			this.Node.SkillComponent.StopGroup1Skill("AiStateMachineTaskBeHitMontage.OnEnter");
			this.Node.TaskFinished = false;
			this.Playing = false;
			CharacterMontageComponent montageComponent = this.Node.MontageComponent;
			if (this.MontageHandle == null)
			{
				this.MontageHandle = montageComponent.CreateTaskWithName(this.MontageName, null, new Action<bool>(this.OnMontageEnd), this.BlendInTime);
				if (this.MontageHandle == null && this.MontageName != this.DefaultMontageName)
				{
					if (string.IsNullOrEmpty(this.DefaultMontageName))
					{
						CombatLog instance2 = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachine;
						Entity entity = this.Node.Entity;
						string message2 = "播放空白蒙太奇路径";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("MontageName", this.MontageName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("DefaultMontageName", this.DefaultMontageName);
						instance2.Error(flag, entity, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
					this.MontageName = this.DefaultMontageName;
					this.MontageHandle = montageComponent.CreateTaskWithName(this.MontageName, null, new Action<bool>(this.OnMontageEnd), this.BlendInTime);
				}
			}
			if (this.MontageHandle != null)
			{
				CharacterHitComponent hitComponent = this.Node.HitComponent;
				if (hitComponent != null)
				{
					hitComponent.ConfirmExecutedBeHitState();
				}
				this.Playing = true;
				montageComponent.PlayMontageTaskWhenReady(this.MontageHandle.Value, (float)((double)this.Node.ElapseTime * TimeUtil.Instance.Millisecond), new long?(contextId.GetValueOrDefault()), -1f);
				return;
			}
			this.Node.TaskFinished = true;
		}

		// Token: 0x0604852B RID: 296235 RVA: 0x01299680 File Offset: 0x01297880
		public override void OnExit(long? contextId = null)
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
			}
			this.MontageHandle = null;
			this.Node.TaskFinished = false;
			this.Playing = false;
		}

		// Token: 0x0604852C RID: 296236 RVA: 0x012996D4 File Offset: 0x012978D4
		protected override void OnTick(float deltaSeconds, long? contextId = null)
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value);
			}
		}

		// Token: 0x0604852D RID: 296237 RVA: 0x012996FF File Offset: 0x012978FF
		protected override void OnClear()
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
			}
			this.MontageHandle = null;
		}

		// Token: 0x0604852E RID: 296238 RVA: 0x01299735 File Offset: 0x01297935
		private void OnMontageEnd(bool isInterrupted)
		{
			this.Node.TaskFinished = true;
		}

		// Token: 0x0604852F RID: 296239 RVA: 0x01299743 File Offset: 0x01297943
		public double GetTimeRemaining()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x06048530 RID: 296240 RVA: 0x01299775 File Offset: 0x01297975
		public double GetTimeElapsing()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeElapsing(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x06048531 RID: 296241 RVA: 0x012997A7 File Offset: 0x012979A7
		public double GetTimeLength()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeLength(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x06048532 RID: 296242 RVA: 0x012997D9 File Offset: 0x012979D9
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x06048533 RID: 296243 RVA: 0x012997E2 File Offset: 0x012979E2
		[NullableContext(2)]
		private string GetNameByHandle(int handle)
		{
			return this.Node.MontageComponent.GetMontageTaskNameByHandle(handle);
		}

		// Token: 0x06048534 RID: 296244 RVA: 0x012997F5 File Offset: 0x012979F5
		[NullableContext(2)]
		public string GetNameByCurrentHandle()
		{
			if (this.MontageHandle != null)
			{
				return this.GetNameByHandle(this.MontageHandle.Value);
			}
			return null;
		}

		// Token: 0x040263BF RID: 156607
		private float BlendInTime;

		// Token: 0x040263C0 RID: 156608
		private int? MontageHandle;

		// Token: 0x040263C2 RID: 156610
		private string DefaultMontageName = "";

		// Token: 0x040263C3 RID: 156611
		private readonly Dictionary<EHitAnim, string> MontageMap = new Dictionary<EHitAnim, string>();

		// Token: 0x040263C4 RID: 156612
		[Nullable(2)]
		private string MontageName = "";
	}
}
