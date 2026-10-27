using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CED RID: 23789
	public class BattleSkillLongPressItem : UiPanelBase
	{
		// Token: 0x0603C3D6 RID: 246742 RVA: 0x00E6BBA4 File Offset: 0x00E69DA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C3D7 RID: 246743 RVA: 0x00E6BBEC File Offset: 0x00E69DEC
		protected override void OnStart()
		{
			this.ProgressTex = base.GetTexture(0);
			UUITexture progressTex = this.ProgressTex;
			if (progressTex != null)
			{
				progressTex.SetFillAmount(0f);
			}
			this.SetComponentActive(this.TargetActive);
		}

		// Token: 0x0603C3D8 RID: 246744 RVA: 0x00E6BC1D File Offset: 0x00E69E1D
		protected override void OnBeforeShow()
		{
			this.BindEvents();
		}

		// Token: 0x0603C3D9 RID: 246745 RVA: 0x00E6BC25 File Offset: 0x00E69E25
		protected override void OnAfterHide()
		{
			this.UnbindEvents();
			this.ClearTimer();
		}

		// Token: 0x0603C3DA RID: 246746 RVA: 0x00E6BC33 File Offset: 0x00E69E33
		protected override void OnBeforeDestroy()
		{
			this.UnbindEvents();
			this.ClearTimer();
		}

		// Token: 0x0603C3DB RID: 246747 RVA: 0x00E6BC44 File Offset: 0x00E69E44
		private void BindEvents()
		{
			if (this.IsBindEvent)
			{
				return;
			}
			this.IsBindEvent = true;
			EventSystem.Instance.Add(EEventName.SkillLongPressStart, new Action<EInputAction>(this.OnSkillLongPressStart));
			EventSystem.Instance.Add(EEventName.SkillLongPressEnd, new Action<EInputAction>(this.OnSkillLongPressEnd));
		}

		// Token: 0x0603C3DC RID: 246748 RVA: 0x00E6BC9C File Offset: 0x00E69E9C
		private void UnbindEvents()
		{
			if (!this.IsBindEvent)
			{
				return;
			}
			this.IsBindEvent = false;
			EventSystem.Instance.Remove(EEventName.SkillLongPressStart, new Action<EInputAction>(this.OnSkillLongPressStart));
			EventSystem.Instance.Remove(EEventName.SkillLongPressEnd, new Action<EInputAction>(this.OnSkillLongPressEnd));
		}

		// Token: 0x0603C3DD RID: 246749 RVA: 0x00E6BCF1 File Offset: 0x00E69EF1
		private void ClearTimer()
		{
			if (this.Timer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}

		// Token: 0x0603C3DE RID: 246750 RVA: 0x00E6BD14 File Offset: 0x00E69F14
		public void SetComponentActive(bool visibility)
		{
			if (this.TargetActive == visibility && !this.IsFirstShow)
			{
				return;
			}
			this.TargetActive = visibility;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.IsFirstShow = false;
			this.SetActive(visibility);
			UUITexture progressTex = this.ProgressTex;
			if (progressTex == null)
			{
				return;
			}
			progressTex.SetFillAmount(0f);
		}

		// Token: 0x0603C3DF RID: 246751 RVA: 0x00E6BD66 File Offset: 0x00E69F66
		public void SetAction(in EInputAction action)
		{
			this.Action = new EInputAction?(action);
		}

		// Token: 0x0603C3E0 RID: 246752 RVA: 0x00E6BD79 File Offset: 0x00E69F79
		public void SetDuration(float duration)
		{
			this.Duration = duration * (float)TimeUtil.Instance.InverseMillisecond;
		}

		// Token: 0x0603C3E1 RID: 246753 RVA: 0x00E6BD90 File Offset: 0x00E69F90
		private void OnSkillLongPressStart(EInputAction action)
		{
			if (this.Action != action)
			{
				return;
			}
			if (this.Duration <= 0f)
			{
				return;
			}
			this.StartProgress();
		}

		// Token: 0x0603C3E2 RID: 246754 RVA: 0x00E6BDD8 File Offset: 0x00E69FD8
		private void OnSkillLongPressEnd(EInputAction action)
		{
			if (this.Action != action)
			{
				return;
			}
			this.StopProgress();
			UUITexture progressTex = this.ProgressTex;
			if (progressTex == null)
			{
				return;
			}
			progressTex.SetFillAmount(0f);
		}

		// Token: 0x0603C3E3 RID: 246755 RVA: 0x00E6BE28 File Offset: 0x00E6A028
		public void StartProgress()
		{
			this.ClearTimer();
			this.StartTime = (float)Time.Instance.WorldTime;
			int num = 20;
			this.Timer = TimerSystem.Instance.Forever(delegate(float _)
			{
				float num2 = (float)Time.Instance.WorldTime - this.StartTime;
				float num3 = Math.Min(1f, num2 / this.Duration);
				UUITexture progressTex = this.ProgressTex;
				if (progressTex != null)
				{
					progressTex.SetFillAmount(num3);
				}
				if (num3 == 1f)
				{
					this.StopProgress();
				}
			}, (float)num, 1f, null, null, true);
		}

		// Token: 0x0603C3E4 RID: 246756 RVA: 0x00E6BE75 File Offset: 0x00E6A075
		private void StopProgress()
		{
			this.ClearTimer();
		}

		// Token: 0x0401F649 RID: 128585
		public bool TargetActive;

		// Token: 0x0401F64A RID: 128586
		[Nullable(2)]
		private UUITexture ProgressTex;

		// Token: 0x0401F64B RID: 128587
		private bool IsBindEvent;

		// Token: 0x0401F64C RID: 128588
		private EInputAction? Action;

		// Token: 0x0401F64D RID: 128589
		private float Duration;

		// Token: 0x0401F64E RID: 128590
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401F64F RID: 128591
		private float StartTime;

		// Token: 0x0401F650 RID: 128592
		private bool IsFirstShow = true;

		// Token: 0x0200BF49 RID: 48969
		private enum ESkillLongPressItem
		{
			// Token: 0x04039B23 RID: 236323
			ProgressTex
		}
	}
}
