using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B6 RID: 18102
	[NullableContext(2)]
	[Nullable(0)]
	public class ViewHotKeyHandle
	{
		// Token: 0x0602EAF2 RID: 191218 RVA: 0x00ACE014 File Offset: 0x00ACC214
		[NullableContext(1)]
		public ViewHotKeyHandle(IOpenAndCloseViewHotKey parameters)
		{
			this.ConfigId = new int?(parameters.ConfigId);
			this.ActionName = parameters.ActionName;
			this.InputControllerType = parameters.InputControllerType;
			this.DefaultViewName = new EUiViewName?(parameters.ViewName);
			this.ViewParam = parameters.ViewParam;
			this.IsPressTrigger = parameters.IsPressTrigger;
			this.PressStartTime = parameters.PressStartTime;
			this.PressTriggerTime = parameters.PressTriggerTime;
			this.IsReleaseTrigger = parameters.IsReleaseTrigger;
			this.ReleaseInvalidTime = parameters.ReleaseInvalidTime;
			this.IsPressClose = parameters.IsPressClose;
			this.IsReleaseClose = parameters.IsReleaseClose;
			this.OpenViewCallback = parameters.OpenViewCallback;
			this.CloseViewCallback = parameters.CloseViewCallback;
			this.IsAllowOpenViewByShortcutKey = parameters.IsAllowOpenViewByShortcutKey;
			this.IsAllowCloseViewByShortcutKey = parameters.IsAllowCloseViewByShortcutKey;
			this.IsLockShortcutKey = parameters.IsLockShortcutKey;
		}

		// Token: 0x17007661 RID: 30305
		// (get) Token: 0x0602EAF3 RID: 191219 RVA: 0x00ACE10F File Offset: 0x00ACC30F
		public virtual EUiViewName? ViewName
		{
			get
			{
				return this.DefaultViewName;
			}
		}

		// Token: 0x0602EAF4 RID: 191220 RVA: 0x00ACE117 File Offset: 0x00ACC317
		public void Destroy()
		{
			this.UnBind();
			this.RemovePressTriggerTimer();
			this.OpenViewCallback = null;
			this.CloseViewCallback = null;
			this.IsAllowOpenViewByShortcutKey = null;
			this.IsAllowCloseViewByShortcutKey = null;
		}

		// Token: 0x0602EAF5 RID: 191221 RVA: 0x00ACE141 File Offset: 0x00ACC341
		public virtual void Bind()
		{
			InputDistributeController.Instance.BindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0602EAF6 RID: 191222 RVA: 0x00ACE15F File Offset: 0x00ACC35F
		protected virtual void UnBind()
		{
			InputDistributeController.Instance.UnBindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0602EAF7 RID: 191223 RVA: 0x00ACE17D File Offset: 0x00ACC37D
		[NullableContext(1)]
		protected void OnInputAction(string name, InputDistributeDefine.EActionType value, InputIdentification inputIdentification)
		{
			if (!this.CheckInputControllerType())
			{
				return;
			}
			Func<string, InputDistributeDefine.EActionType, bool> isLockShortcutKey = this.IsLockShortcutKey;
			if (isLockShortcutKey != null && isLockShortcutKey(name, value))
			{
				return;
			}
			if (value == InputDistributeDefine.EActionType.Press)
			{
				this.Press();
				return;
			}
			if (value == InputDistributeDefine.EActionType.Release)
			{
				this.Release();
			}
		}

		// Token: 0x0602EAF8 RID: 191224 RVA: 0x00ACE1B4 File Offset: 0x00ACC3B4
		private bool CheckInputControllerType()
		{
			switch (this.InputControllerType)
			{
			case EOpenAndCloseViewInputControllerType.Common:
				return true;
			case EOpenAndCloseViewInputControllerType.Keyboard:
				return Info.Instance.IsInKeyBoard();
			case EOpenAndCloseViewInputControllerType.Gamepad:
				return Info.Instance.IsInGamepad();
			default:
				return false;
			}
		}

		// Token: 0x0602EAF9 RID: 191225 RVA: 0x00ACE1F5 File Offset: 0x00ACC3F5
		[NullableContext(1)]
		public void BindOpenViewCallback(Action callback)
		{
			this.OpenViewCallback = callback;
		}

		// Token: 0x0602EAFA RID: 191226 RVA: 0x00ACE1FE File Offset: 0x00ACC3FE
		[NullableContext(1)]
		public void BindCloseViewCallback(Action callback)
		{
			this.CloseViewCallback = callback;
		}

		// Token: 0x0602EAFB RID: 191227 RVA: 0x00ACE208 File Offset: 0x00ACC408
		public void Press()
		{
			if (this.ViewName == null)
			{
				return;
			}
			EUiViewName? viewName = this.ViewName;
			if (StringUtils.IsBlank((viewName != null) ? viewName.GetValueOrDefault() : null))
			{
				return;
			}
			this.PressTimeStamp = Time.Instance.WorldTime;
			if (this.IsPressTrigger)
			{
				this.TryPressOpenView();
			}
			if (this.IsPressClose)
			{
				this.TryCloseView();
			}
		}

		// Token: 0x0602EAFC RID: 191228 RVA: 0x00ACE27C File Offset: 0x00ACC47C
		public void Release()
		{
			this.RemovePressTriggerTimer();
			if (this.IsReleaseTrigger)
			{
				double worldTime = Time.Instance.WorldTime;
				if (this.ReleaseInvalidTime <= 0 || worldTime - this.PressTimeStamp <= (double)this.ReleaseInvalidTime)
				{
					this.TryOpenView();
				}
			}
			if (this.IsReleaseClose)
			{
				this.TryCloseView();
			}
		}

		// Token: 0x0602EAFD RID: 191229 RVA: 0x00ACE2D4 File Offset: 0x00ACC4D4
		private bool TryPressOpenView()
		{
			if (this.PressTriggerTime <= 0)
			{
				return this.TryOpenView();
			}
			this.RemovePressTriggerTimer();
			this.PressTriggerTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnPressTriggerTimeFinished), (float)this.PressTriggerTime, null, null, true, 1f);
			return false;
		}

		// Token: 0x0602EAFE RID: 191230 RVA: 0x00ACE323 File Offset: 0x00ACC523
		private void OnPressTriggerTimeFinished(float delta)
		{
			this.RemovePressTriggerTimer();
			this.TryOpenView();
		}

		// Token: 0x0602EAFF RID: 191231 RVA: 0x00ACE332 File Offset: 0x00ACC532
		private void RemovePressTriggerTimer()
		{
			if (this.PressTriggerTimer != null && TimerSystem.Instance.Has(this.PressTriggerTimer))
			{
				TimerSystem.Instance.Remove(this.PressTriggerTimer);
			}
			this.PressTriggerTimer = null;
		}

		// Token: 0x0602EB00 RID: 191232 RVA: 0x00ACE368 File Offset: 0x00ACC568
		private bool TryOpenView()
		{
			if (UiManager.Instance.IsViewOpen(this.ViewName.Value))
			{
				return false;
			}
			if (LoadingModel.Instance.IsLoading)
			{
				return false;
			}
			if (this.CheckHasInputLimit())
			{
				return false;
			}
			if (this.IsAllowOpenViewByShortcutKey != null && !this.IsAllowOpenViewByShortcutKey())
			{
				return false;
			}
			if (!this.SpecialConditionCheck())
			{
				Log.Instance.Info(ELogModule.InputManager, ELogAuthor.YZY, "特殊情况，不处理分发，在别的模块处理", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			if (!this.IsAllowOpenView())
			{
				return false;
			}
			this.OpenView();
			return true;
		}

		// Token: 0x0602EB01 RID: 191233 RVA: 0x00ACE3F8 File Offset: 0x00ACC5F8
		private bool TryCloseView()
		{
			if (!UiManager.Instance.IsViewOpen(this.ViewName.Value))
			{
				return false;
			}
			if (!UiManager.Instance.IsViewShow(this.ViewName.Value))
			{
				return false;
			}
			if (LoadingModel.Instance.IsLoading)
			{
				return false;
			}
			if (this.IsAllowCloseViewByShortcutKey != null && !this.IsAllowCloseViewByShortcutKey())
			{
				return false;
			}
			this.CloseView();
			return true;
		}

		// Token: 0x0602EB02 RID: 191234 RVA: 0x00ACE46C File Offset: 0x00ACC66C
		private void OpenView()
		{
			if (this.ViewName == null)
			{
				return;
			}
			EUiViewName? viewName = this.ViewName;
			if (StringUtils.IsBlank((viewName != null) ? viewName.GetValueOrDefault() : null))
			{
				return;
			}
			if (this.OpenViewCallback != null)
			{
				this.OpenViewCallback();
				return;
			}
			this.OnOpenViewImplement();
		}

		// Token: 0x0602EB03 RID: 191235 RVA: 0x00ACE4CC File Offset: 0x00ACC6CC
		private void CloseView()
		{
			if (this.ViewName == null)
			{
				return;
			}
			EUiViewName? viewName = this.ViewName;
			if (StringUtils.IsBlank((viewName != null) ? viewName.GetValueOrDefault() : null))
			{
				return;
			}
			if (this.CloseViewCallback != null)
			{
				this.CloseViewCallback();
				return;
			}
			UiManager.Instance.CloseView(this.ViewName.Value, null);
		}

		// Token: 0x0602EB04 RID: 191236 RVA: 0x00ACE540 File Offset: 0x00ACC740
		private bool IsAllowOpenView()
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			HashSet<EUiViewName> hashSet = (instance != null) ? instance.GetNotAllowFightInputViewNameSet() : null;
			return hashSet == null || hashSet.Count == 0 || hashSet.Contains(this.ViewName.Value);
		}

		// Token: 0x0602EB05 RID: 191237 RVA: 0x00ACE588 File Offset: 0x00ACC788
		protected virtual bool CheckHasInputLimit()
		{
			return LevelEventLockInputState.Instance.InputLimitView.Contains(this.ViewName.Value);
		}

		// Token: 0x0602EB06 RID: 191238 RVA: 0x00ACE5B2 File Offset: 0x00ACC7B2
		protected virtual bool SpecialConditionCheck()
		{
			return true;
		}

		// Token: 0x0602EB07 RID: 191239 RVA: 0x00ACE5B8 File Offset: 0x00ACC7B8
		protected virtual void OnOpenViewImplement()
		{
			UiManager.Instance.OpenView(this.ViewName.Value, (this.ViewParam.Length != 0) ? this.ViewParam : null, null);
		}

		// Token: 0x040196AF RID: 104111
		public int? ConfigId;

		// Token: 0x040196B0 RID: 104112
		public string ActionName;

		// Token: 0x040196B1 RID: 104113
		public readonly EOpenAndCloseViewInputControllerType InputControllerType;

		// Token: 0x040196B2 RID: 104114
		protected readonly EUiViewName? DefaultViewName;

		// Token: 0x040196B3 RID: 104115
		[Nullable(1)]
		public string[] ViewParam = Array.Empty<string>();

		// Token: 0x040196B4 RID: 104116
		public bool IsPressTrigger = true;

		// Token: 0x040196B5 RID: 104117
		public int PressStartTime;

		// Token: 0x040196B6 RID: 104118
		public int PressTriggerTime;

		// Token: 0x040196B7 RID: 104119
		public bool IsReleaseTrigger;

		// Token: 0x040196B8 RID: 104120
		public int ReleaseInvalidTime;

		// Token: 0x040196B9 RID: 104121
		public bool IsPressClose;

		// Token: 0x040196BA RID: 104122
		public bool IsReleaseClose;

		// Token: 0x040196BB RID: 104123
		private Action OpenViewCallback;

		// Token: 0x040196BC RID: 104124
		private Action CloseViewCallback;

		// Token: 0x040196BD RID: 104125
		private Func<bool> IsAllowOpenViewByShortcutKey;

		// Token: 0x040196BE RID: 104126
		private Func<bool> IsAllowCloseViewByShortcutKey;

		// Token: 0x040196BF RID: 104127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Func<string, InputDistributeDefine.EActionType, bool> IsLockShortcutKey;

		// Token: 0x040196C0 RID: 104128
		private TimerHandle PressTriggerTimer;

		// Token: 0x040196C1 RID: 104129
		private double PressTimeStamp;
	}
}
