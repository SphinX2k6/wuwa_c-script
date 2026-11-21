using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034F7 RID: 13559
	[NullableContext(2)]
	[Nullable(0)]
	public class EffectLifeTimeController
	{
		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x060227F6 RID: 141302 RVA: 0x009CABE3 File Offset: 0x009C8DE3
		public float LifeTime
		{
			get
			{
				return this.LifeTimeStamp;
			}
		}

		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x060227F7 RID: 141303 RVA: 0x009CABEB File Offset: 0x009C8DEB
		public float PassTime
		{
			get
			{
				return this.PassTimeInternal;
			}
		}

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x060227F8 RID: 141304 RVA: 0x009CABF3 File Offset: 0x009C8DF3
		public float TotalPassTime
		{
			get
			{
				return this.TotalPassTimeInternal;
			}
		}

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x060227F9 RID: 141305 RVA: 0x009CABFB File Offset: 0x009C8DFB
		public EControllerState State
		{
			get
			{
				return this.StateInternal;
			}
		}

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x060227FA RID: 141306 RVA: 0x009CAC03 File Offset: 0x009C8E03
		public bool IsFinish
		{
			get
			{
				return this.StateInternal == EControllerState.Finished;
			}
		}

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x060227FB RID: 141307 RVA: 0x009CAC0E File Offset: 0x009C8E0E
		public EEffectLifeTimeType Type
		{
			get
			{
				return this.TypeInternal;
			}
		}

		// Token: 0x060227FC RID: 141308 RVA: 0x009CAC16 File Offset: 0x009C8E16
		public void SetPassTimeManual(float target, float? speed = null)
		{
			this.ManualTarget = target;
			if (speed != null)
			{
				this.ManualSpeed = speed.Value;
			}
		}

		// Token: 0x060227FD RID: 141309 RVA: 0x009CAC38 File Offset: 0x009C8E38
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

		// Token: 0x060227FE RID: 141310 RVA: 0x009CACB1 File Offset: 0x009C8EB1
		public void Reset()
		{
			this.PassTimeInternal = this.DefaultPassTime;
			this.TotalPassTimeInternal = 0f;
		}

		// Token: 0x060227FF RID: 141311 RVA: 0x009CACCA File Offset: 0x009C8ECA
		public void JumpToEnd()
		{
			this.PassTimeInternal = this.LifeTimeStamp;
			this.TotalPassTimeInternal = this.LifeTimeStamp;
		}

		// Token: 0x06022800 RID: 141312 RVA: 0x009CACE4 File Offset: 0x009C8EE4
		public void ReInit(float startTime, float loopTime, float endTime)
		{
			this.StartTimeInternal = startTime;
			this.LoopTimeInternal = loopTime;
			this.EndTimeInternal = endTime;
			this.LoopTimeStamp = startTime + loopTime;
			this.LifeTimeStamp = startTime + loopTime + endTime;
			this.CalcLoopBehavior();
		}

		// Token: 0x06022801 RID: 141313 RVA: 0x009CAD15 File Offset: 0x009C8F15
		public void SetType(EEffectLifeTimeType type)
		{
			this.TypeInternal = type;
			this.CalcLoopBehavior();
		}

		// Token: 0x06022802 RID: 141314 RVA: 0x009CAD24 File Offset: 0x009C8F24
		public bool LifeTimeCheck(float deltaSecond)
		{
			return false;
		}

		// Token: 0x06022803 RID: 141315 RVA: 0x009CAD28 File Offset: 0x009C8F28
		public void CalcLoopBehavior()
		{
			this.WillLoop = (this.TypeInternal == EEffectLifeTimeType.AlwaysLoop || (this.TypeInternal == EEffectLifeTimeType.Auto && this.LoopTimeInternal > 0f));
			this.WillEverPlay = (this.WillLoop || (this.TypeInternal == EEffectLifeTimeType.Auto && this.LifeTimeStamp <= 0f) || this.TypeInternal == EEffectLifeTimeType.Manual);
		}

		// Token: 0x06022804 RID: 141316 RVA: 0x009CAD8E File Offset: 0x009C8F8E
		public void SetStateBuild()
		{
			this.StateInternal = EControllerState.Build;
		}

		// Token: 0x06022805 RID: 141317 RVA: 0x009CAD97 File Offset: 0x009C8F97
		public void SetStateInit()
		{
			this.StateInternal = EControllerState.Init;
		}

		// Token: 0x06022806 RID: 141318 RVA: 0x009CADA0 File Offset: 0x009C8FA0
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

		// Token: 0x06022807 RID: 141319 RVA: 0x009CADCC File Offset: 0x009C8FCC
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

		// Token: 0x06022808 RID: 141320 RVA: 0x009CAE54 File Offset: 0x009C9054
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

		// Token: 0x06022809 RID: 141321 RVA: 0x009CAEC0 File Offset: 0x009C90C0
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

		// Token: 0x0602280A RID: 141322 RVA: 0x009CAF33 File Offset: 0x009C9133
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

		// Token: 0x0602280B RID: 141323 RVA: 0x009CAF55 File Offset: 0x009C9155
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

		// Token: 0x0602280C RID: 141324 RVA: 0x009CAF84 File Offset: 0x009C9184
		public void SetStateFinish()
		{
			this.StateInternal = EControllerState.Finished;
		}

		// Token: 0x04013127 RID: 78119
		protected EEffectLifeTimeType TypeInternal;

		// Token: 0x04013128 RID: 78120
		protected float DefaultPassTime;

		// Token: 0x04013129 RID: 78121
		protected float PassTimeInternal;

		// Token: 0x0401312A RID: 78122
		protected float TotalPassTimeInternal;

		// Token: 0x0401312B RID: 78123
		protected float StartTimeInternal = -1f;

		// Token: 0x0401312C RID: 78124
		protected float LoopTimeInternal;

		// Token: 0x0401312D RID: 78125
		protected float EndTimeInternal;

		// Token: 0x0401312E RID: 78126
		protected float LoopTimeStamp;

		// Token: 0x0401312F RID: 78127
		protected float LifeTimeStamp;

		// Token: 0x04013130 RID: 78128
		protected EControllerState StateInternal;

		// Token: 0x04013131 RID: 78129
		protected Func<bool> ReadyToFinish;

		// Token: 0x04013132 RID: 78130
		protected Action FinishCallback;

		// Token: 0x04013133 RID: 78131
		protected float ManualTarget;

		// Token: 0x04013134 RID: 78132
		protected float ManualSpeed;

		// Token: 0x04013135 RID: 78133
		public bool WillLoop;

		// Token: 0x04013136 RID: 78134
		public bool WillEverPlay;
	}
}
