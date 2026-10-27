using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x02007320 RID: 29472
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskRandomMontage : AiStateMachineTask, IAiTaskMontage
	{
		// Token: 0x17009F89 RID: 40841
		// (get) Token: 0x06048573 RID: 296307 RVA: 0x0129B96B File Offset: 0x01299B6B
		// (set) Token: 0x06048574 RID: 296308 RVA: 0x0129B973 File Offset: 0x01299B73
		public bool Playing { get; set; }

		// Token: 0x17009F8A RID: 40842
		// (get) Token: 0x06048575 RID: 296309 RVA: 0x0129B97C File Offset: 0x01299B7C
		// (set) Token: 0x06048576 RID: 296310 RVA: 0x0129B984 File Offset: 0x01299B84
		public float RemainedTrigger { get; set; } = -1f;

		// Token: 0x06048577 RID: 296311 RVA: 0x0129B98D File Offset: 0x01299B8D
		public AiStateMachineTaskRandomMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x17009F8B RID: 40843
		// (get) Token: 0x06048578 RID: 296312 RVA: 0x0129B9A2 File Offset: 0x01299BA2
		public bool HasResource
		{
			get
			{
				return this.MontageHandle != null;
			}
		}

		// Token: 0x06048579 RID: 296313 RVA: 0x0129B9B0 File Offset: 0x01299BB0
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			this.MontageNames = task.TaskRandomMontage.MontageNames.ToArray();
			this.HideOnLoading = task.TaskRandomMontage.HideOnLoading;
			this.BlendInTime = task.TaskRandomMontage.BlendInTime * 0.001f;
			this.RandomByClient = task.TaskRandomMontage.RandomByClient;
			return true;
		}

		// Token: 0x0604857A RID: 296314 RVA: 0x0129BA10 File Offset: 0x01299C10
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

		// Token: 0x0604857B RID: 296315 RVA: 0x0129BCD4 File Offset: 0x01299ED4
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

		// Token: 0x0604857C RID: 296316 RVA: 0x0129BD60 File Offset: 0x01299F60
		protected override void OnTick(float deltaSeconds, long? contextId = null)
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value);
			}
		}

		// Token: 0x0604857D RID: 296317 RVA: 0x0129BD8B File Offset: 0x01299F8B
		protected override void OnClear()
		{
			if (this.MontageHandle != null)
			{
				this.Node.MontageComponent.EndMontageTask(this.MontageHandle.Value);
			}
			this.MontageHandle = null;
		}

		// Token: 0x0604857E RID: 296318 RVA: 0x0129BDC4 File Offset: 0x01299FC4
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

		// Token: 0x0604857F RID: 296319 RVA: 0x0129BE38 File Offset: 0x0129A038
		private void OnMontageEnd(bool isInterrupted)
		{
			this.Node.TaskFinished = true;
		}

		// Token: 0x06048580 RID: 296320 RVA: 0x0129BE48 File Offset: 0x0129A048
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

		// Token: 0x06048581 RID: 296321 RVA: 0x0129BEE6 File Offset: 0x0129A0E6
		public double GetTimeRemaining()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeRemaining(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x06048582 RID: 296322 RVA: 0x0129BF18 File Offset: 0x0129A118
		public double GetTimeElapsing()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeElapsing(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x06048583 RID: 296323 RVA: 0x0129BF4A File Offset: 0x0129A14A
		public double GetTimeLength()
		{
			return (double)((this.MontageHandle != null) ? this.Node.MontageComponent.GetMontageTimeLength(this.MontageHandle.Value) : -1f);
		}

		// Token: 0x06048584 RID: 296324 RVA: 0x0129BF7C File Offset: 0x0129A17C
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x06048585 RID: 296325 RVA: 0x0129BF85 File Offset: 0x0129A185
		[NullableContext(2)]
		private string GetNameByHandle(int handle)
		{
			return this.Node.MontageComponent.GetMontageTaskNameByHandle(handle);
		}

		// Token: 0x06048586 RID: 296326 RVA: 0x0129BF98 File Offset: 0x0129A198
		[NullableContext(2)]
		public string GetNameByCurrentHandle()
		{
			if (this.MontageHandle != null)
			{
				return this.GetNameByHandle(this.MontageHandle.Value);
			}
			return null;
		}

		// Token: 0x040263FD RID: 156669
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] MontageNames;

		// Token: 0x040263FE RID: 156670
		private bool HideOnLoading;

		// Token: 0x040263FF RID: 156671
		private float BlendInTime;

		// Token: 0x04026400 RID: 156672
		private int? DisableHandle;

		// Token: 0x04026401 RID: 156673
		private int? MontageHandle;

		// Token: 0x04026402 RID: 156674
		public int? MontageIndex;

		// Token: 0x04026403 RID: 156675
		private bool Loading;

		// Token: 0x04026406 RID: 156678
		public bool RandomByClient;
	}
}
