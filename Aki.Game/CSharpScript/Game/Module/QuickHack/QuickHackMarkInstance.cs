using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F33 RID: 16179
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackMarkInstance
	{
		// Token: 0x06028FAC RID: 167852 RVA: 0x00B80858 File Offset: 0x00B7EA58
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

		// Token: 0x06028FAD RID: 167853 RVA: 0x00B808CA File Offset: 0x00B7EACA
		public void ClearMark()
		{
			this.FinishPerform();
		}

		// Token: 0x06028FAE RID: 167854 RVA: 0x00B808D4 File Offset: 0x00B7EAD4
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

		// Token: 0x06028FAF RID: 167855 RVA: 0x00B8096D File Offset: 0x00B7EB6D
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x06028FB0 RID: 167856 RVA: 0x00B80975 File Offset: 0x00B7EB75
		public EntityHandle GetOwner()
		{
			return this.Owner;
		}

		// Token: 0x06028FB1 RID: 167857 RVA: 0x00B8097D File Offset: 0x00B7EB7D
		public double GetCurrentProgress()
		{
			return this.CurrentProgress;
		}

		// Token: 0x06028FB2 RID: 167858 RVA: 0x00B80985 File Offset: 0x00B7EB85
		public EQuickHackMarkState GetCurrentState()
		{
			return this.CurrentState;
		}

		// Token: 0x06028FB3 RID: 167859 RVA: 0x00B8098D File Offset: 0x00B7EB8D
		public bool IsFinish()
		{
			return this.CurrentState == EQuickHackMarkState.Finish;
		}

		// Token: 0x06028FB4 RID: 167860 RVA: 0x00B80998 File Offset: 0x00B7EB98
		public string GetIconPath()
		{
			return this.IconPath;
		}

		// Token: 0x06028FB5 RID: 167861 RVA: 0x00B809A0 File Offset: 0x00B7EBA0
		[NullableContext(1)]
		public void RegisterOnProgressChange(Action<double> onProgressChange)
		{
			this.OnProgressChange = onProgressChange;
		}

		// Token: 0x06028FB6 RID: 167862 RVA: 0x00B809A9 File Offset: 0x00B7EBA9
		public void UnRegisterOnProgressChange()
		{
			this.OnProgressChange = null;
		}

		// Token: 0x06028FB7 RID: 167863 RVA: 0x00B809B2 File Offset: 0x00B7EBB2
		[NullableContext(1)]
		public void RegisterOnStateChange(Action<EQuickHackMarkState, EQuickHackMarkState> onStateChange)
		{
			this.OnStateChange = onStateChange;
		}

		// Token: 0x06028FB8 RID: 167864 RVA: 0x00B809BB File Offset: 0x00B7EBBB
		public void UnRegisterOnStateChange()
		{
			this.OnStateChange = null;
		}

		// Token: 0x06028FB9 RID: 167865 RVA: 0x00B809C4 File Offset: 0x00B7EBC4
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

		// Token: 0x06028FBA RID: 167866 RVA: 0x00B80A34 File Offset: 0x00B7EC34
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

		// Token: 0x06028FBB RID: 167867 RVA: 0x00B80AA4 File Offset: 0x00B7ECA4
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

		// Token: 0x06028FBC RID: 167868 RVA: 0x00B80B03 File Offset: 0x00B7ED03
		private double GetTimeStamp()
		{
			if (this.CurrentState != EQuickHackMarkState.Upload || this.UploadEnableTimeScale)
			{
				return Time.Instance.FlowTime;
			}
			return Time.Instance.PlayerTime;
		}

		// Token: 0x04016480 RID: 91264
		private const int DEFAULT_UPLOAD_TIME = 300;

		// Token: 0x04016481 RID: 91265
		private int Id;

		// Token: 0x04016482 RID: 91266
		private EntityHandle Owner;

		// Token: 0x04016483 RID: 91267
		private string IconPath;

		// Token: 0x04016484 RID: 91268
		private double UploadTime;

		// Token: 0x04016485 RID: 91269
		private bool UploadEnableTimeScale;

		// Token: 0x04016486 RID: 91270
		private double Duration;

		// Token: 0x04016487 RID: 91271
		private EQuickHackMarkState CurrentState;

		// Token: 0x04016488 RID: 91272
		private double ProgressStartTime;

		// Token: 0x04016489 RID: 91273
		private double ProgressEndTime;

		// Token: 0x0401648A RID: 91274
		private double ProgressFrom;

		// Token: 0x0401648B RID: 91275
		private double ProgressTo;

		// Token: 0x0401648C RID: 91276
		private double CurrentProgress;

		// Token: 0x0401648D RID: 91277
		private Action<double> OnProgressChange;

		// Token: 0x0401648E RID: 91278
		private Action<EQuickHackMarkState, EQuickHackMarkState> OnStateChange;
	}
}
