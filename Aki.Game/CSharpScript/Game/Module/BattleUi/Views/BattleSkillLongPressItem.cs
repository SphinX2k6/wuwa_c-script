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
	// Token: 0x02004CCF RID: 19663
	public class BattleSkillLongPressItem : UiPanelBase
	{
		// Token: 0x0603132C RID: 201516 RVA: 0x00DBC158 File Offset: 0x00DBA358
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

		// Token: 0x0603132D RID: 201517 RVA: 0x00DBC1A0 File Offset: 0x00DBA3A0
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

		// Token: 0x0603132E RID: 201518 RVA: 0x00DBC1D1 File Offset: 0x00DBA3D1
		protected override void OnBeforeShow()
		{
			this.BindEvents();
		}

		// Token: 0x0603132F RID: 201519 RVA: 0x00DBC1D9 File Offset: 0x00DBA3D9
		protected override void OnAfterHide()
		{
			this.UnbindEvents();
			this.ClearTimer();
		}

		// Token: 0x06031330 RID: 201520 RVA: 0x00DBC1E7 File Offset: 0x00DBA3E7
		protected override void OnBeforeDestroy()
		{
			this.UnbindEvents();
			this.ClearTimer();
		}

		// Token: 0x06031331 RID: 201521 RVA: 0x00DBC1F8 File Offset: 0x00DBA3F8
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

		// Token: 0x06031332 RID: 201522 RVA: 0x00DBC250 File Offset: 0x00DBA450
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

		// Token: 0x06031333 RID: 201523 RVA: 0x00DBC2A5 File Offset: 0x00DBA4A5
		private void ClearTimer()
		{
			if (this.Timer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}

		// Token: 0x06031334 RID: 201524 RVA: 0x00DBC2C8 File Offset: 0x00DBA4C8
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

		// Token: 0x06031335 RID: 201525 RVA: 0x00DBC31A File Offset: 0x00DBA51A
		public void SetAction(in EInputAction action)
		{
			this.Action = new EInputAction?(action);
		}

		// Token: 0x06031336 RID: 201526 RVA: 0x00DBC32D File Offset: 0x00DBA52D
		public void SetDuration(float duration)
		{
			this.Duration = duration * (float)TimeUtil.Instance.InverseMillisecond;
		}

		// Token: 0x06031337 RID: 201527 RVA: 0x00DBC344 File Offset: 0x00DBA544
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

		// Token: 0x06031338 RID: 201528 RVA: 0x00DBC38C File Offset: 0x00DBA58C
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

		// Token: 0x06031339 RID: 201529 RVA: 0x00DBC3DC File Offset: 0x00DBA5DC
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

		// Token: 0x0603133A RID: 201530 RVA: 0x00DBC429 File Offset: 0x00DBA629
		private void StopProgress()
		{
			this.ClearTimer();
		}

		// Token: 0x0401A102 RID: 106754
		public bool TargetActive;

		// Token: 0x0401A103 RID: 106755
		[Nullable(2)]
		private UUITexture ProgressTex;

		// Token: 0x0401A104 RID: 106756
		private bool IsBindEvent;

		// Token: 0x0401A105 RID: 106757
		private EInputAction? Action;

		// Token: 0x0401A106 RID: 106758
		private float Duration;

		// Token: 0x0401A107 RID: 106759
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401A108 RID: 106760
		private float StartTime;

		// Token: 0x0401A109 RID: 106761
		private bool IsFirstShow = true;

		// Token: 0x0200A94F RID: 43343
		private enum ESkillLongPressItem
		{
			// Token: 0x040344E5 RID: 214245
			ProgressTex
		}
	}
}
