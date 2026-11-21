using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x0200649B RID: 25755
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskBeHitMontage : AiStateMachineTask, IAiTaskMontage
	{
		// Token: 0x17007721 RID: 30497
		// (get) Token: 0x0603E96F RID: 256367 RVA: 0x0123BC50 File Offset: 0x01239E50
		// (set) Token: 0x0603E970 RID: 256368 RVA: 0x0123BC58 File Offset: 0x01239E58
		public bool Playing { get; set; }

		// Token: 0x17007722 RID: 30498
		// (get) Token: 0x0603E971 RID: 256369 RVA: 0x0123BC61 File Offset: 0x01239E61
		// (set) Token: 0x0603E972 RID: 256370 RVA: 0x0123BC69 File Offset: 0x01239E69
		public float RemainedTrigger { get; set; } = -1f;

		// Token: 0x0603E973 RID: 256371 RVA: 0x0123BC72 File Offset: 0x01239E72
		public AiStateMachineTaskBeHitMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x17007723 RID: 30499
		// (get) Token: 0x0603E974 RID: 256372 RVA: 0x0123BCA8 File Offset: 0x01239EA8
		public bool HasResource
		{
			get
			{
				return this.MontageHandle != null;
			}
		}

		// Token: 0x0603E975 RID: 256373 RVA: 0x0123BCB8 File Offset: 0x01239EB8
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

		// Token: 0x0603E976 RID: 256374 RVA: 0x0123BD4C File Offset: 0x01239F4C
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

		// Token: 0x0603E977 RID: 256375 RVA: 0x0123BE18 File Offset: 0x0123A018
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

		// Token: 0x0603E978 RID: 256376 RVA: 0x0123C100 File Offset: 0x0123A300
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

		// Token: 0x0603E979 RID: 256377 RVA: 0x0123C154 File Offset: 0x0123A354
		protected override void OnTick(float deltaSeconds, long? contextId = null)
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value);
			}
		}

		// Token: 0x0603E97A RID: 256378 RVA: 0x0123C17F File Offset: 0x0123A37F
		protected override void OnClear()
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
			}
			this.MontageHandle = null;
		}

		// Token: 0x0603E97B RID: 256379 RVA: 0x0123C1B5 File Offset: 0x0123A3B5
		private void OnMontageEnd(bool isInterrupted)
		{
			this.Node.TaskFinished = true;
		}

		// Token: 0x0603E97C RID: 256380 RVA: 0x0123C1C3 File Offset: 0x0123A3C3
		public double GetTimeRemaining()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0603E97D RID: 256381 RVA: 0x0123C1F5 File Offset: 0x0123A3F5
		public double GetTimeElapsing()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeElapsing(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0603E97E RID: 256382 RVA: 0x0123C227 File Offset: 0x0123A427
		public double GetTimeLength()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeLength(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0603E97F RID: 256383 RVA: 0x0123C259 File Offset: 0x0123A459
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0603E980 RID: 256384 RVA: 0x0123C262 File Offset: 0x0123A462
		[NullableContext(2)]
		private string GetNameByHandle(int handle)
		{
			return this.Node.MontageComponent.GetMontageTaskNameByHandle(handle);
		}

		// Token: 0x0603E981 RID: 256385 RVA: 0x0123C275 File Offset: 0x0123A475
		[NullableContext(2)]
		public string GetNameByCurrentHandle()
		{
			if (this.MontageHandle != null)
			{
				return this.GetNameByHandle(this.MontageHandle.Value);
			}
			return null;
		}

		// Token: 0x040216AC RID: 136876
		private float BlendInTime;

		// Token: 0x040216AD RID: 136877
		private int? MontageHandle;

		// Token: 0x040216AF RID: 136879
		private string DefaultMontageName = "";

		// Token: 0x040216B0 RID: 136880
		private readonly Dictionary<EHitAnim, string> MontageMap = new Dictionary<EHitAnim, string>();

		// Token: 0x040216B1 RID: 136881
		[Nullable(2)]
		private string MontageName = "";
	}
}
