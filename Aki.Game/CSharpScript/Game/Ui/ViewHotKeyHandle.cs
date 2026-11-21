using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035E7 RID: 13799
	[NullableContext(2)]
	[Nullable(0)]
	public class ViewHotKeyHandle
	{
		// Token: 0x0602323E RID: 143934 RVA: 0x009FC8E8 File Offset: 0x009FAAE8
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

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x0602323F RID: 143935 RVA: 0x009FC9E3 File Offset: 0x009FABE3
		public virtual EUiViewName? ViewName
		{
			get
			{
				return this.DefaultViewName;
			}
		}

		// Token: 0x06023240 RID: 143936 RVA: 0x009FC9EB File Offset: 0x009FABEB
		public void Destroy()
		{
			this.UnBind();
			this.RemovePressTriggerTimer();
			this.OpenViewCallback = null;
			this.CloseViewCallback = null;
			this.IsAllowOpenViewByShortcutKey = null;
			this.IsAllowCloseViewByShortcutKey = null;
		}

		// Token: 0x06023241 RID: 143937 RVA: 0x009FCA15 File Offset: 0x009FAC15
		public virtual void Bind()
		{
			InputDistributeController.Instance.BindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06023242 RID: 143938 RVA: 0x009FCA33 File Offset: 0x009FAC33
		protected virtual void UnBind()
		{
			InputDistributeController.Instance.UnBindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x06023243 RID: 143939 RVA: 0x009FCA51 File Offset: 0x009FAC51
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

		// Token: 0x06023244 RID: 143940 RVA: 0x009FCA88 File Offset: 0x009FAC88
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

		// Token: 0x06023245 RID: 143941 RVA: 0x009FCAC9 File Offset: 0x009FACC9
		[NullableContext(1)]
		public void BindOpenViewCallback(Action callback)
		{
			this.OpenViewCallback = callback;
		}

		// Token: 0x06023246 RID: 143942 RVA: 0x009FCAD2 File Offset: 0x009FACD2
		[NullableContext(1)]
		public void BindCloseViewCallback(Action callback)
		{
			this.CloseViewCallback = callback;
		}

		// Token: 0x06023247 RID: 143943 RVA: 0x009FCADC File Offset: 0x009FACDC
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

		// Token: 0x06023248 RID: 143944 RVA: 0x009FCB50 File Offset: 0x009FAD50
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

		// Token: 0x06023249 RID: 143945 RVA: 0x009FCBA8 File Offset: 0x009FADA8
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

		// Token: 0x0602324A RID: 143946 RVA: 0x009FCBF7 File Offset: 0x009FADF7
		private void OnPressTriggerTimeFinished(float delta)
		{
			this.RemovePressTriggerTimer();
			this.TryOpenView();
		}

		// Token: 0x0602324B RID: 143947 RVA: 0x009FCC06 File Offset: 0x009FAE06
		private void RemovePressTriggerTimer()
		{
			if (this.PressTriggerTimer != null && TimerSystem.Instance.Has(this.PressTriggerTimer))
			{
				TimerSystem.Instance.Remove(this.PressTriggerTimer);
			}
			this.PressTriggerTimer = null;
		}

		// Token: 0x0602324C RID: 143948 RVA: 0x009FCC3C File Offset: 0x009FAE3C
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

		// Token: 0x0602324D RID: 143949 RVA: 0x009FCCCC File Offset: 0x009FAECC
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

		// Token: 0x0602324E RID: 143950 RVA: 0x009FCD40 File Offset: 0x009FAF40
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

		// Token: 0x0602324F RID: 143951 RVA: 0x009FCDA0 File Offset: 0x009FAFA0
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

		// Token: 0x06023250 RID: 143952 RVA: 0x009FCE14 File Offset: 0x009FB014
		private bool IsAllowOpenView()
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			HashSet<EUiViewName> hashSet = (instance != null) ? instance.GetNotAllowFightInputViewNameSet() : null;
			return hashSet == null || hashSet.Count == 0 || hashSet.Contains(this.ViewName.Value);
		}

		// Token: 0x06023251 RID: 143953 RVA: 0x009FCE5C File Offset: 0x009FB05C
		protected virtual bool CheckHasInputLimit()
		{
			return LevelEventLockInputState.Instance.InputLimitView.Contains(this.ViewName.Value);
		}

		// Token: 0x06023252 RID: 143954 RVA: 0x009FCE86 File Offset: 0x009FB086
		protected virtual bool SpecialConditionCheck()
		{
			return true;
		}

		// Token: 0x06023253 RID: 143955 RVA: 0x009FCE8C File Offset: 0x009FB08C
		protected virtual void OnOpenViewImplement()
		{
			UiManager.Instance.OpenView(this.ViewName.Value, (this.ViewParam.Length != 0) ? this.ViewParam : null, null);
		}

		// Token: 0x04013D54 RID: 81236
		public int? ConfigId;

		// Token: 0x04013D55 RID: 81237
		public string ActionName;

		// Token: 0x04013D56 RID: 81238
		public readonly EOpenAndCloseViewInputControllerType InputControllerType;

		// Token: 0x04013D57 RID: 81239
		protected readonly EUiViewName? DefaultViewName;

		// Token: 0x04013D58 RID: 81240
		[Nullable(1)]
		public string[] ViewParam = Array.Empty<string>();

		// Token: 0x04013D59 RID: 81241
		public bool IsPressTrigger = true;

		// Token: 0x04013D5A RID: 81242
		public int PressStartTime;

		// Token: 0x04013D5B RID: 81243
		public int PressTriggerTime;

		// Token: 0x04013D5C RID: 81244
		public bool IsReleaseTrigger;

		// Token: 0x04013D5D RID: 81245
		public int ReleaseInvalidTime;

		// Token: 0x04013D5E RID: 81246
		public bool IsPressClose;

		// Token: 0x04013D5F RID: 81247
		public bool IsReleaseClose;

		// Token: 0x04013D60 RID: 81248
		private Action OpenViewCallback;

		// Token: 0x04013D61 RID: 81249
		private Action CloseViewCallback;

		// Token: 0x04013D62 RID: 81250
		private Func<bool> IsAllowOpenViewByShortcutKey;

		// Token: 0x04013D63 RID: 81251
		private Func<bool> IsAllowCloseViewByShortcutKey;

		// Token: 0x04013D64 RID: 81252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Func<string, InputDistributeDefine.EActionType, bool> IsLockShortcutKey;

		// Token: 0x04013D65 RID: 81253
		private TimerHandle PressTriggerTimer;

		// Token: 0x04013D66 RID: 81254
		private double PressTimeStamp;
	}
}
