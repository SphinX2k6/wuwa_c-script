using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045CF RID: 17871
	[NullableContext(2)]
	[Nullable(0)]
	public class EffectLifeTimeController
	{
		// Token: 0x170075A2 RID: 30114
		// (get) Token: 0x0602E10B RID: 188683 RVA: 0x00A9E91B File Offset: 0x00A9CB1B
		public float LifeTime
		{
			get
			{
				return this.LifeTimeStamp;
			}
		}

		// Token: 0x170075A3 RID: 30115
		// (get) Token: 0x0602E10C RID: 188684 RVA: 0x00A9E923 File Offset: 0x00A9CB23
		public float PassTime
		{
			get
			{
				return this.PassTimeInternal;
			}
		}

		// Token: 0x170075A4 RID: 30116
		// (get) Token: 0x0602E10D RID: 188685 RVA: 0x00A9E92B File Offset: 0x00A9CB2B
		public float TotalPassTime
		{
			get
			{
				return this.TotalPassTimeInternal;
			}
		}

		// Token: 0x170075A5 RID: 30117
		// (get) Token: 0x0602E10E RID: 188686 RVA: 0x00A9E933 File Offset: 0x00A9CB33
		public EControllerState State
		{
			get
			{
				return this.StateInternal;
			}
		}

		// Token: 0x170075A6 RID: 30118
		// (get) Token: 0x0602E10F RID: 188687 RVA: 0x00A9E93B File Offset: 0x00A9CB3B
		public bool IsFinish
		{
			get
			{
				return this.StateInternal == EControllerState.Finished;
			}
		}

		// Token: 0x170075A7 RID: 30119
		// (get) Token: 0x0602E110 RID: 188688 RVA: 0x00A9E946 File Offset: 0x00A9CB46
		public EEffectLifeTimeType Type
		{
			get
			{
				return this.TypeInternal;
			}
		}

		// Token: 0x0602E111 RID: 188689 RVA: 0x00A9E94E File Offset: 0x00A9CB4E
		public void SetPassTimeManual(float target, float? speed = null)
		{
			this.ManualTarget = target;
			if (speed != null)
			{
				this.ManualSpeed = speed.Value;
			}
		}

		// Token: 0x0602E112 RID: 188690 RVA: 0x00A9E970 File Offset: 0x00A9CB70
		public EffectLifeTimeController(float startTime, float loopTime, float endTime, EEffectLifeTimeType type, Action finishCallback = null, Func<bool> readyToFinish = null, float defaultManualTime = 0f, float defaultManualSpeed = 1f)
		{
			this.StateInternal = EControllerState.Constructor;
			if (type == EEffectLifeTimeType.Manual)
			{
				this.DefaultPassTime = defaultManualTime;
			}
			this.PassTimeInternal = 0f;
			this.TotalPassTimeInternal = 0f;
			this.TypeInternal = type;
			this.ReadyToFinish = readyToFinish;
			this.FinishCallback = finishCallback;
			this.ManualTarget = defaultManualTime;
			this.ManualSpeed = defaultManualSpeed;
			this.ReInit(startTime, loopTime, endTime);
		}

		// Token: 0x0602E113 RID: 188691 RVA: 0x00A9E9E9 File Offset: 0x00A9CBE9
		public void Reset()
		{
			this.PassTimeInternal = this.DefaultPassTime;
			this.TotalPassTimeInternal = 0f;
		}

		// Token: 0x0602E114 RID: 188692 RVA: 0x00A9EA02 File Offset: 0x00A9CC02
		public void JumpToEnd()
		{
			this.PassTimeInternal = this.LifeTimeStamp;
			this.TotalPassTimeInternal = this.LifeTimeStamp;
		}

		// Token: 0x0602E115 RID: 188693 RVA: 0x00A9EA1C File Offset: 0x00A9CC1C
		public void ReInit(float startTime, float loopTime, float endTime)
		{
			this.StartTimeInternal = startTime;
			this.LoopTimeInternal = loopTime;
			this.EndTimeInternal = endTime;
			this.LoopTimeStamp = startTime + loopTime;
			this.LifeTimeStamp = startTime + loopTime + endTime;
			this.CalcLoopBehavior();
		}

		// Token: 0x0602E116 RID: 188694 RVA: 0x00A9EA4D File Offset: 0x00A9CC4D
		public void SetType(EEffectLifeTimeType type)
		{
			this.TypeInternal = type;
			this.CalcLoopBehavior();
		}

		// Token: 0x0602E117 RID: 188695 RVA: 0x00A9EA5C File Offset: 0x00A9CC5C
		public bool LifeTimeCheck(float deltaSecond)
		{
			return false;
		}

		// Token: 0x0602E118 RID: 188696 RVA: 0x00A9EA60 File Offset: 0x00A9CC60
		public void CalcLoopBehavior()
		{
			this.WillLoop = (this.TypeInternal == EEffectLifeTimeType.AlwaysLoop || (this.TypeInternal == EEffectLifeTimeType.Auto && this.LoopTimeInternal > 0f));
			this.WillEverPlay = (this.WillLoop || (this.TypeInternal == EEffectLifeTimeType.Auto && this.LifeTimeStamp <= 0f) || this.TypeInternal == EEffectLifeTimeType.Manual);
		}

		// Token: 0x0602E119 RID: 188697 RVA: 0x00A9EAC6 File Offset: 0x00A9CCC6
		public void SetStateBuild()
		{
			this.StateInternal = EControllerState.Build;
		}

		// Token: 0x0602E11A RID: 188698 RVA: 0x00A9EACF File Offset: 0x00A9CCCF
		public void SetStateInit()
		{
			this.StateInternal = EControllerState.Init;
		}

		// Token: 0x0602E11B RID: 188699 RVA: 0x00A9EAD8 File Offset: 0x00A9CCD8
		public void Play()
		{
			if (this.StateInternal < EControllerState.Constructor)
			{
				return;
			}
			this.StateInternal = EControllerState.Playing;
			this.PassTimeInternal = this.DefaultPassTime;
			this.TotalPassTimeInternal = 0f;
		}

		// Token: 0x0602E11C RID: 188700 RVA: 0x00A9EB04 File Offset: 0x00A9CD04
		public void Update(float deltaSecond)
		{
			this.TotalPassTimeInternal += deltaSecond;
			if (this.TypeInternal != EEffectLifeTimeType.Manual)
			{
				this.SeekTo(this.PassTimeInternal + deltaSecond, true);
				return;
			}
			if (this.StateInternal == EControllerState.Stopping)
			{
				this.PrepareFinish();
				return;
			}
			float num = Math.Min(deltaSecond * this.ManualSpeed, Math.Abs(this.ManualTarget - this.PassTimeInternal));
			this.SeekTo(this.PassTimeInternal + num * (float)Math.Sign(this.ManualTarget - this.PassTimeInternal), false);
		}

		// Token: 0x0602E11D RID: 188701 RVA: 0x00A9EB8C File Offset: 0x00A9CD8C
		public void SeekTo(float time, bool triggerFinish = false)
		{
			this.PassTimeInternal = time;
			if (this.StateInternal == EControllerState.Playing && this.PassTimeInternal >= this.LoopTimeStamp && this.WillLoop)
			{
				this.MakeLoop();
			}
			if (triggerFinish && (!this.WillEverPlay || this.StateInternal >= EControllerState.Stopping) && this.PassTimeInternal >= this.LifeTimeStamp)
			{
				this.PrepareFinish();
			}
		}

		// Token: 0x0602E11E RID: 188702 RVA: 0x00A9EBF8 File Offset: 0x00A9CDF8
		private void MakeLoop()
		{
			if (this.LoopTimeInternal <= 0.01f)
			{
				this.PassTimeInternal = this.StartTimeInternal;
				return;
			}
			if (this.PassTimeInternal >= this.LoopTimeStamp + this.LoopTimeInternal)
			{
				float num = (this.PassTimeInternal - this.StartTimeInternal) % this.LoopTimeInternal;
				this.PassTimeInternal = this.StartTimeInternal + num;
				return;
			}
			this.PassTimeInternal -= this.LoopTimeInternal;
		}

		// Token: 0x0602E11F RID: 188703 RVA: 0x00A9EC6B File Offset: 0x00A9CE6B
		public void Stop(bool immediately = false)
		{
			if (this.StateInternal >= EControllerState.Stopping)
			{
				return;
			}
			this.StateInternal = EControllerState.Stopping;
			if (immediately)
			{
				this.PassTimeInternal = this.LoopTimeStamp;
			}
		}

		// Token: 0x0602E120 RID: 188704 RVA: 0x00A9EC8D File Offset: 0x00A9CE8D
		protected void PrepareFinish()
		{
			if (this.ReadyToFinish != null && !this.ReadyToFinish())
			{
				return;
			}
			this.StateInternal = EControllerState.Finished;
			Action finishCallback = this.FinishCallback;
			if (finishCallback == null)
			{
				return;
			}
			finishCallback();
		}

		// Token: 0x0602E121 RID: 188705 RVA: 0x00A9ECBC File Offset: 0x00A9CEBC
		public void SetStateFinish()
		{
			this.StateInternal = EControllerState.Finished;
		}

		// Token: 0x04018AEC RID: 101100
		protected EEffectLifeTimeType TypeInternal;

		// Token: 0x04018AED RID: 101101
		protected float DefaultPassTime;

		// Token: 0x04018AEE RID: 101102
		protected float PassTimeInternal;

		// Token: 0x04018AEF RID: 101103
		protected float TotalPassTimeInternal;

		// Token: 0x04018AF0 RID: 101104
		protected float StartTimeInternal = -1f;

		// Token: 0x04018AF1 RID: 101105
		protected float LoopTimeInternal;

		// Token: 0x04018AF2 RID: 101106
		protected float EndTimeInternal;

		// Token: 0x04018AF3 RID: 101107
		protected float LoopTimeStamp;

		// Token: 0x04018AF4 RID: 101108
		protected float LifeTimeStamp;

		// Token: 0x04018AF5 RID: 101109
		protected EControllerState StateInternal;

		// Token: 0x04018AF6 RID: 101110
		protected Func<bool> ReadyToFinish;

		// Token: 0x04018AF7 RID: 101111
		protected Action FinishCallback;

		// Token: 0x04018AF8 RID: 101112
		protected float ManualTarget;

		// Token: 0x04018AF9 RID: 101113
		protected float ManualSpeed;

		// Token: 0x04018AFA RID: 101114
		public bool WillLoop;

		// Token: 0x04018AFB RID: 101115
		public bool WillEverPlay;
	}
}
