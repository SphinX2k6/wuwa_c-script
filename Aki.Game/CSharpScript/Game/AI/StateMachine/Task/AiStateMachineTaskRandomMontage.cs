using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x020064A3 RID: 25763
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskRandomMontage : AiStateMachineTask, IAiTaskMontage
	{
		// Token: 0x17007727 RID: 30503
		// (get) Token: 0x0603E9C0 RID: 256448 RVA: 0x0123E3EB File Offset: 0x0123C5EB
		// (set) Token: 0x0603E9C1 RID: 256449 RVA: 0x0123E3F3 File Offset: 0x0123C5F3
		public bool Playing { get; set; }

		// Token: 0x17007728 RID: 30504
		// (get) Token: 0x0603E9C2 RID: 256450 RVA: 0x0123E3FC File Offset: 0x0123C5FC
		// (set) Token: 0x0603E9C3 RID: 256451 RVA: 0x0123E404 File Offset: 0x0123C604
		public float RemainedTrigger { get; set; } = -1f;

		// Token: 0x0603E9C4 RID: 256452 RVA: 0x0123E40D File Offset: 0x0123C60D
		public AiStateMachineTaskRandomMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x17007729 RID: 30505
		// (get) Token: 0x0603E9C5 RID: 256453 RVA: 0x0123E422 File Offset: 0x0123C622
		public bool HasResource
		{
			get
			{
				return this.MontageHandle != null;
			}
		}

		// Token: 0x0603E9C6 RID: 256454 RVA: 0x0123E430 File Offset: 0x0123C630
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			this.MontageNames = task.TaskRandomMontage.MontageNames.ToArray();
			this.HideOnLoading = task.TaskRandomMontage.HideOnLoading;
			this.BlendInTime = task.TaskRandomMontage.BlendInTime * 0.001f;
			this.RandomByClient = task.TaskRandomMontage.RandomByClient;
			return true;
		}

		// Token: 0x0603E9C7 RID: 256455 RVA: 0x0123E490 File Offset: 0x0123C690
		public override void OnEnter(long? contextId = null)
		{
			if (this.Node.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
			{
				this.Node.TaskFinished = true;
				return;
			}
			this.Node.SkillComponent.StopGroup1Skill("AiStateMachineTaskRandomMontage.OnEnter");
			this.Node.TaskFinished = false;
			this.Loading = true;
			this.Playing = false;
			this.MontageIndex = (this.RandomByClient ? new int?(Random.Shared.Next(this.MontageNames.Length)) : this.Node.Owner.GetBlackboard(CombatStateMachineDefine.Fsm.EFsmSyncKey.RandomMontageIndex));
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
			Entity entity = this.Node.Entity;
			string message = "随机Montage";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MontageIndex", this.MontageIndex);
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.MontageIndex != null)
			{
				int? montageIndex = this.MontageIndex;
				int num = 0;
				if (!(montageIndex.GetValueOrDefault() < num & montageIndex != null))
				{
					montageIndex = this.MontageIndex;
					num = this.MontageNames.Length;
					if (!(montageIndex.GetValueOrDefault() >= num & montageIndex != null))
					{
						goto IL_16C;
					}
				}
			}
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
			Entity entity2 = this.Node.Entity;
			string message2 = "播放随机Montage失败，MontageIndex非法";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("MontageIndex", this.MontageIndex);
			instance2.Error(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.MontageIndex = new int?(0);
			IL_16C:
			CharacterMontageComponent montageComponent = this.Node.MontageComponent;
			if (this.MontageHandle == null)
			{
				if (this.HideOnLoading && this.DisableHandle == null)
				{
					this.DisableHandle = new int?(this.Node.ActorComponent.DisableActor("状态机加载动作"));
				}
				for (int i = 0; i < this.MontageNames.Length; i++)
				{
					int num2 = (this.MontageIndex.Value + i) % this.MontageNames.Length;
					string montageName = this.MontageNames[num2];
					this.MontageHandle = montageComponent.CreateTaskWithName(montageName, new Action(this.OnLoadCompleted), new Action<bool>(this.OnMontageEnd), this.BlendInTime);
					if (this.MontageHandle != null)
					{
						montageComponent.SetMontageTaskRemainCb(this.MontageHandle.Value, new Action<float>(this.OnMontageRemain));
						break;
					}
				}
			}
			if (this.MontageHandle != null)
			{
				this.Playing = true;
				montageComponent.PlayMontageTaskWhenReady(this.MontageHandle.Value, (float)((double)this.Node.ElapseTime * TimeUtil.Instance.Millisecond), new long?(contextId.Value), this.RemainedTrigger);
				return;
			}
			this.Node.TaskFinished = true;
		}

		// Token: 0x0603E9C8 RID: 256456 RVA: 0x0123E754 File Offset: 0x0123C954
		public override void OnExit(long? contextId = null)
		{
			if (this.HideOnLoading && this.Loading && this.DisableHandle != null)
			{
				this.Node.ActorComponent.EnableActor(this.DisableHandle.Value);
				this.DisableHandle = null;
			}
			this.Node.MontageComponent.EndMontageTask(this.MontageHandle.GetValueOrDefault());
			this.MontageHandle = null;
			this.Node.TaskFinished = false;
			this.Playing = false;
		}

		// Token: 0x0603E9C9 RID: 256457 RVA: 0x0123E7E0 File Offset: 0x0123C9E0
		protected override void OnTick(float deltaSeconds, long? contextId = null)
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value);
			}
		}

		// Token: 0x0603E9CA RID: 256458 RVA: 0x0123E80B File Offset: 0x0123CA0B
		protected override void OnClear()
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
			}
			this.MontageHandle = null;
		}

		// Token: 0x0603E9CB RID: 256459 RVA: 0x0123E844 File Offset: 0x0123CA44
		private void OnLoadCompleted()
		{
			this.Loading = false;
			if (!this.Node.Activated)
			{
				return;
			}
			if (this.HideOnLoading && this.DisableHandle != null)
			{
				this.Node.ActorComponent.EnableActor(this.DisableHandle.Value);
				this.DisableHandle = null;
			}
			this.Node.MoveComponent.SetForceSpeed(Vector.ZeroVectorProxy);
		}

		// Token: 0x0603E9CC RID: 256460 RVA: 0x0123E8B8 File Offset: 0x0123CAB8
		private void OnMontageEnd(bool isInterrupted)
		{
			this.Node.TaskFinished = true;
		}

		// Token: 0x0603E9CD RID: 256461 RVA: 0x0123E8C8 File Offset: 0x0123CAC8
		private unsafe void OnMontageRemain(float remainTime)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.StateMachine;
			ELogAuthor author = ELogAuthor.PZ;
			string message = "Random Montage Task OnMontageRemain";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("montage", this.GetNameByCurrentHandle());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("remain time", remainTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("remained trigger", this.RemainedTrigger);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EventSystem.Instance.EmitWithTarget<float>(this, EEventName.OnMontageRemain, remainTime);
		}

		// Token: 0x0603E9CE RID: 256462 RVA: 0x0123E966 File Offset: 0x0123CB66
		public double GetTimeRemaining()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0603E9CF RID: 256463 RVA: 0x0123E998 File Offset: 0x0123CB98
		public double GetTimeElapsing()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeElapsing(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0603E9D0 RID: 256464 RVA: 0x0123E9CA File Offset: 0x0123CBCA
		public double GetTimeLength()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeLength(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x0603E9D1 RID: 256465 RVA: 0x0123E9FC File Offset: 0x0123CBFC
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0603E9D2 RID: 256466 RVA: 0x0123EA05 File Offset: 0x0123CC05
		[NullableContext(2)]
		private string GetNameByHandle(int handle)
		{
			return this.Node.MontageComponent.GetMontageTaskNameByHandle(handle);
		}

		// Token: 0x0603E9D3 RID: 256467 RVA: 0x0123EA18 File Offset: 0x0123CC18
		[NullableContext(2)]
		public string GetNameByCurrentHandle()
		{
			if (this.MontageHandle != null)
			{
				return this.GetNameByHandle(this.MontageHandle.Value);
			}
			return null;
		}

		// Token: 0x040216EA RID: 136938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] MontageNames;

		// Token: 0x040216EB RID: 136939
		private bool HideOnLoading;

		// Token: 0x040216EC RID: 136940
		private float BlendInTime;

		// Token: 0x040216ED RID: 136941
		private int? DisableHandle;

		// Token: 0x040216EE RID: 136942
		private int? MontageHandle;

		// Token: 0x040216EF RID: 136943
		public int? MontageIndex;

		// Token: 0x040216F0 RID: 136944
		private bool Loading;

		// Token: 0x040216F3 RID: 136947
		public bool RandomByClient;
	}
}
