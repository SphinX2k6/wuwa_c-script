using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F6A RID: 20330
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackMarkInstance
	{
		// Token: 0x0603413E RID: 213310 RVA: 0x00C370B8 File Offset: 0x00C352B8
		[NullableContext(1)]
		public void StartMark(int id, EntityHandle entityHandle, double uploadTime, double duration, string iconPath)
		{
			if (uploadTime > 0.0)
			{
				this.UploadTime = uploadTime;
				this.UploadEnableTimeScale = true;
			}
			else
			{
				this.UploadTime = 300.0;
				this.UploadEnableTimeScale = false;
			}
			this.Id = id;
			this.Owner = entityHandle;
			this.Duration = duration;
			this.IconPath = iconPath;
			this.CurrentProgress = 0.0;
			this.StartUpload();
		}

		// Token: 0x0603413F RID: 213311 RVA: 0x00C3712A File Offset: 0x00C3532A
		public void ClearMark()
		{
			this.FinishPerform();
		}

		// Token: 0x06034140 RID: 213312 RVA: 0x00C37134 File Offset: 0x00C35334
		public void UpdateMark()
		{
			if (this.CurrentState == EQuickHackMarkState.Finish)
			{
				return;
			}
			double num = MathUtils.Instance.RangeClamp(this.GetTimeStamp(), this.ProgressStartTime, this.ProgressEndTime, this.ProgressFrom, this.ProgressTo);
			this.CurrentProgress = num;
			if (num != this.ProgressTo)
			{
				Action<double> onProgressChange = this.OnProgressChange;
				if (onProgressChange == null)
				{
					return;
				}
				onProgressChange(num);
				return;
			}
			else
			{
				if (this.CurrentState != EQuickHackMarkState.Upload || this.Duration <= 0.0)
				{
					this.FinishPerform();
					return;
				}
				this.StartDuration();
				Action<double> onProgressChange2 = this.OnProgressChange;
				if (onProgressChange2 == null)
				{
					return;
				}
				onProgressChange2(num);
				return;
			}
		}

		// Token: 0x06034141 RID: 213313 RVA: 0x00C371CD File Offset: 0x00C353CD
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x06034142 RID: 213314 RVA: 0x00C371D5 File Offset: 0x00C353D5
		public EntityHandle GetOwner()
		{
			return this.Owner;
		}

		// Token: 0x06034143 RID: 213315 RVA: 0x00C371DD File Offset: 0x00C353DD
		public double GetCurrentProgress()
		{
			return this.CurrentProgress;
		}

		// Token: 0x06034144 RID: 213316 RVA: 0x00C371E5 File Offset: 0x00C353E5
		public EQuickHackMarkState GetCurrentState()
		{
			return this.CurrentState;
		}

		// Token: 0x06034145 RID: 213317 RVA: 0x00C371ED File Offset: 0x00C353ED
		public bool IsFinish()
		{
			return this.CurrentState == EQuickHackMarkState.Finish;
		}

		// Token: 0x06034146 RID: 213318 RVA: 0x00C371F8 File Offset: 0x00C353F8
		public string GetIconPath()
		{
			return this.IconPath;
		}

		// Token: 0x06034147 RID: 213319 RVA: 0x00C37200 File Offset: 0x00C35400
		[NullableContext(1)]
		public void RegisterOnProgressChange(Action<double> onProgressChange)
		{
			this.OnProgressChange = onProgressChange;
		}

		// Token: 0x06034148 RID: 213320 RVA: 0x00C37209 File Offset: 0x00C35409
		public void UnRegisterOnProgressChange()
		{
			this.OnProgressChange = null;
		}

		// Token: 0x06034149 RID: 213321 RVA: 0x00C37212 File Offset: 0x00C35412
		[NullableContext(1)]
		public void RegisterOnStateChange(Action<EQuickHackMarkState, EQuickHackMarkState> onStateChange)
		{
			this.OnStateChange = onStateChange;
		}

		// Token: 0x0603414A RID: 213322 RVA: 0x00C3721B File Offset: 0x00C3541B
		public void UnRegisterOnStateChange()
		{
			this.OnStateChange = null;
		}

		// Token: 0x0603414B RID: 213323 RVA: 0x00C37224 File Offset: 0x00C35424
		private void StartUpload()
		{
			EQuickHackMarkState currentState = this.CurrentState;
			this.CurrentState = EQuickHackMarkState.Upload;
			Action<EQuickHackMarkState, EQuickHackMarkState> onStateChange = this.OnStateChange;
			if (onStateChange != null)
			{
				onStateChange(currentState, this.CurrentState);
			}
			this.ProgressStartTime = this.GetTimeStamp();
			this.ProgressEndTime = this.ProgressStartTime + this.UploadTime;
			this.ProgressFrom = 0.0;
			this.ProgressTo = 1.0;
		}

		// Token: 0x0603414C RID: 213324 RVA: 0x00C37294 File Offset: 0x00C35494
		private void StartDuration()
		{
			EQuickHackMarkState currentState = this.CurrentState;
			this.CurrentState = EQuickHackMarkState.Duration;
			Action<EQuickHackMarkState, EQuickHackMarkState> onStateChange = this.OnStateChange;
			if (onStateChange != null)
			{
				onStateChange(currentState, this.CurrentState);
			}
			this.ProgressStartTime = this.GetTimeStamp();
			this.ProgressEndTime = this.ProgressStartTime + this.Duration;
			this.ProgressFrom = 1.0;
			this.ProgressTo = 0.0;
		}

		// Token: 0x0603414D RID: 213325 RVA: 0x00C37304 File Offset: 0x00C35504
		private void FinishPerform()
		{
			EQuickHackMarkState currentState = this.CurrentState;
			this.CurrentState = EQuickHackMarkState.Finish;
			this.Owner = null;
			Action<double> onProgressChange = this.OnProgressChange;
			if (onProgressChange != null)
			{
				onProgressChange(this.ProgressTo);
			}
			this.OnProgressChange = null;
			Action<EQuickHackMarkState, EQuickHackMarkState> onStateChange = this.OnStateChange;
			if (onStateChange != null)
			{
				onStateChange(currentState, this.CurrentState);
			}
			this.OnStateChange = null;
		}

		// Token: 0x0603414E RID: 213326 RVA: 0x00C37363 File Offset: 0x00C35563
		private double GetTimeStamp()
		{
			if (this.CurrentState != EQuickHackMarkState.Upload || this.UploadEnableTimeScale)
			{
				return Time.Instance.FlowTime;
			}
			return Time.Instance.PlayerTime;
		}

		// Token: 0x0401BAAB RID: 113323
		private const int DEFAULT_UPLOAD_TIME = 300;

		// Token: 0x0401BAAC RID: 113324
		private int Id;

		// Token: 0x0401BAAD RID: 113325
		private EntityHandle Owner;

		// Token: 0x0401BAAE RID: 113326
		private string IconPath;

		// Token: 0x0401BAAF RID: 113327
		private double UploadTime;

		// Token: 0x0401BAB0 RID: 113328
		private bool UploadEnableTimeScale;

		// Token: 0x0401BAB1 RID: 113329
		private double Duration;

		// Token: 0x0401BAB2 RID: 113330
		private EQuickHackMarkState CurrentState;

		// Token: 0x0401BAB3 RID: 113331
		private double ProgressStartTime;

		// Token: 0x0401BAB4 RID: 113332
		private double ProgressEndTime;

		// Token: 0x0401BAB5 RID: 113333
		private double ProgressFrom;

		// Token: 0x0401BAB6 RID: 113334
		private double ProgressTo;

		// Token: 0x0401BAB7 RID: 113335
		private double CurrentProgress;

		// Token: 0x0401BAB8 RID: 113336
		private Action<double> OnProgressChange;

		// Token: 0x0401BAB9 RID: 113337
		private Action<EQuickHackMarkState, EQuickHackMarkState> OnStateChange;
	}
}
