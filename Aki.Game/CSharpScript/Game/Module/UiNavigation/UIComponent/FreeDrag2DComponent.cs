using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x0200397D RID: 14717
	[NullableContext(2)]
	[Nullable(0)]
	public class FreeDrag2DComponent : HotKeyComponent
	{
		// Token: 0x06025E0A RID: 155146 RVA: 0x00AA2EC6 File Offset: 0x00AA10C6
		public FreeDrag2DComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025E0B RID: 155147 RVA: 0x00AA2ED8 File Offset: 0x00AA10D8
		public void SetDataCallback(Func<bool> onStarted, Func<FreeDrag2DInput, bool> onUpdated, Action onEnded, Action onCanceled)
		{
			if (this.IsCleared || base.IsDestroyOrDestroying)
			{
				return;
			}
			if (this.StartedCallback == onStarted && this.UpdatedCallback == onUpdated && this.EndedCallback == onEnded && this.CanceledCallback == onCanceled)
			{
				return;
			}
			this.CancelInteraction();
			if (this.IsCleared || base.IsDestroyOrDestroying)
			{
				return;
			}
			this.StartedCallback = onStarted;
			this.UpdatedCallback = onUpdated;
			this.EndedCallback = onEnded;
			this.CanceledCallback = onCanceled;
			this.ResetAxisState();
			this.RefreshListenerActive();
		}

		// Token: 0x06025E0C RID: 155148 RVA: 0x00AA2F70 File Offset: 0x00AA1170
		public void SetInputEnabled(bool enabled)
		{
			if (this.IsCleared || base.IsDestroyOrDestroying)
			{
				return;
			}
			if (this.InputEnabled == enabled)
			{
				return;
			}
			this.InputEnabled = enabled;
			this.CancelInteraction();
			this.ResetAxisState();
			this.RefreshListenerActive();
		}

		// Token: 0x06025E0D RID: 155149 RVA: 0x00AA2FA8 File Offset: 0x00AA11A8
		protected override void OnAddEventListener()
		{
			if (this.IsInputRegistered || this.IsCleared)
			{
				return;
			}
			this.IsInputRegistered = true;
			this.ResetAxisState();
			InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnAxisInput));
			InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnAxisInput));
			EventSystem.Instance.Add<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			this.RefreshListenerActive();
		}

		// Token: 0x06025E0E RID: 155150 RVA: 0x00AA302C File Offset: 0x00AA122C
		protected override void OnRemoveEventListener()
		{
			if (!this.IsInputRegistered)
			{
				return;
			}
			this.IsInputRegistered = false;
			InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnAxisInput));
			InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnAxisInput));
			EventSystem.Instance.Remove<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			this.CancelInteraction();
			this.RefreshListenerActive();
		}

		// Token: 0x06025E0F RID: 155151 RVA: 0x00AA30A7 File Offset: 0x00AA12A7
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.RefreshListenerActive();
		}

		// Token: 0x06025E10 RID: 155152 RVA: 0x00AA30AF File Offset: 0x00AA12AF
		protected override void OnRefreshByControllerChange()
		{
			this.CancelInteraction();
			this.ResetAxisState();
			this.RefreshListenerActive();
		}

		// Token: 0x06025E11 RID: 155153 RVA: 0x00AA30C3 File Offset: 0x00AA12C3
		protected override void OnHotKeyActiveChanged(bool isActive)
		{
			this.CancelInteraction();
			this.ResetAxisState();
		}

		// Token: 0x06025E12 RID: 155154 RVA: 0x00AA30D1 File Offset: 0x00AA12D1
		[NullableContext(1)]
		protected override void OnFinishInputAxis(string axisName)
		{
			this.CancelInteraction();
		}

		// Token: 0x06025E13 RID: 155155 RVA: 0x00AA30D9 File Offset: 0x00AA12D9
		protected override void OnBeforeHide()
		{
			this.CancelInteraction();
		}

		// Token: 0x06025E14 RID: 155156 RVA: 0x00AA30E1 File Offset: 0x00AA12E1
		protected override void OnBeforeDestroy()
		{
			this.ClearInput();
		}

		// Token: 0x06025E15 RID: 155157 RVA: 0x00AA30E9 File Offset: 0x00AA12E9
		protected override void OnClear()
		{
			this.ClearInput();
		}

		// Token: 0x06025E16 RID: 155158 RVA: 0x00AA30F1 File Offset: 0x00AA12F1
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}

		// Token: 0x06025E17 RID: 155159 RVA: 0x00AA30F4 File Offset: 0x00AA12F4
		private void RefreshListenerActive()
		{
			if (this.IsCleared || base.IsDestroyOrDestroying)
			{
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IsInputRegistered && this.InputEnabled && this.UpdatedCallback != null, false);
		}

		// Token: 0x06025E18 RID: 155160 RVA: 0x00AA312C File Offset: 0x00AA132C
		private void ResetAxisState()
		{
			this.HorizontalValue = InputDistributeModel.Instance.GetAxisValue("UiMoveRight");
			this.VerticalValue = InputDistributeModel.Instance.GetAxisValue("UiMoveForward");
			this.WaitForCenter = (this.InputWasBlocked || this.HorizontalValue != 0f || this.VerticalValue != 0f);
		}

		// Token: 0x06025E19 RID: 155161 RVA: 0x00AA3191 File Offset: 0x00AA1391
		[NullableContext(1)]
		private void OnAxisInput(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!this.IsInputRegistered)
			{
				return;
			}
			if (!this.CanReceiveAxisInput())
			{
				this.CancelBlockedInput();
				return;
			}
			base.InputAxis(axisName, value);
		}

		// Token: 0x06025E1A RID: 155162 RVA: 0x00AA31B4 File Offset: 0x00AA13B4
		private bool CanReceiveAxisInput()
		{
			if (InputDistributeModel.Instance.HasActionLimitSet())
			{
				return InputDistributeModel.Instance.IsActionInLimitSet("UiMoveRight") && InputDistributeModel.Instance.IsActionInLimitSet("UiMoveForward");
			}
			return InputDistributeController.Instance.IsAxisRespondable("UiMoveRight") && InputDistributeController.Instance.IsAxisRespondable("UiMoveForward");
		}

		// Token: 0x06025E1B RID: 155163 RVA: 0x00AA3212 File Offset: 0x00AA1412
		[NullableContext(1)]
		private void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> tags)
		{
			if (!this.CanReceiveAxisInput())
			{
				this.CancelBlockedInput();
			}
		}

		// Token: 0x06025E1C RID: 155164 RVA: 0x00AA3222 File Offset: 0x00AA1422
		private void CancelBlockedInput()
		{
			this.InputWasBlocked = true;
			this.HorizontalSeenAfterBlock = false;
			this.VerticalSeenAfterBlock = false;
			this.CancelInteraction();
		}

		// Token: 0x06025E1D RID: 155165 RVA: 0x00AA3240 File Offset: 0x00AA1440
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			bool flag = axisName == "UiMoveRight";
			if (!flag && axisName != "UiMoveForward")
			{
				return;
			}
			if (!this.CanReceiveAxisInput())
			{
				this.CancelBlockedInput();
				return;
			}
			if (!this.IsInputRegistered || !this.InputEnabled || this.UpdatedCallback == null || base.IsDestroyOrDestroying || !float.IsFinite(value))
			{
				this.CancelInteraction();
				return;
			}
			value = Math.Clamp(value, -1f, 1f);
			if (flag)
			{
				this.HorizontalValue = value;
			}
			else
			{
				this.VerticalValue = value;
			}
			bool flag2 = this.HorizontalValue == 0f && this.VerticalValue == 0f;
			if (this.WaitForCenter)
			{
				if (this.InputWasBlocked)
				{
					this.HorizontalSeenAfterBlock = (this.HorizontalSeenAfterBlock || flag);
					this.VerticalSeenAfterBlock |= !flag;
					flag2 = (flag2 && this.HorizontalSeenAfterBlock && this.VerticalSeenAfterBlock);
				}
				this.WaitForCenter = !flag2;
				if (flag2)
				{
					this.InputWasBlocked = false;
				}
				return;
			}
			if (flag2)
			{
				this.FinishInteraction(this.EndedCallback);
				return;
			}
			int frame = Time.Instance.Frame;
			float deltaTimeSeconds = Time.Instance.DeltaTimeSeconds;
			if (this.LastInputFrame == frame || !float.IsFinite(deltaTimeSeconds) || deltaTimeSeconds <= 0f)
			{
				return;
			}
			this.LastInputFrame = frame;
			float val = MathF.Sqrt(this.HorizontalValue * this.HorizontalValue + this.VerticalValue * this.VerticalValue);
			float num = Math.Max(1f, val);
			FreeDrag2DInput input = new FreeDrag2DInput
			{
				Value = new FVector2D(this.HorizontalValue / num, this.VerticalValue / num),
				DeltaSeconds = deltaTimeSeconds
			};
			this.DispatchInput(input);
		}

		// Token: 0x06025E1E RID: 155166 RVA: 0x00AA33F8 File Offset: 0x00AA15F8
		private unsafe void DispatchInput(FreeDrag2DInput input)
		{
			string item = "StartedCallback";
			try
			{
				if (!this.IsInteracting)
				{
					this.IsInteracting = true;
					if (this.StartedCallback != null && !this.StartedCallback())
					{
						this.CancelInteraction();
						return;
					}
				}
				if (!this.IsInteracting || !this.InputEnabled || !this.IsInputRegistered || this.UpdatedCallback == null || this.IsCleared || base.IsDestroyOrDestroying)
				{
					this.CancelInteraction();
				}
				else
				{
					item = "UpdatedCallback";
					if (!this.UpdatedCallback(input))
					{
						this.CancelInteraction();
					}
				}
			}
			catch (Exception item2)
			{
				this.InputEnabled = false;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigationHotKey;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[DispatchInput] 二维拖拽业务回调异常，禁用当前输入";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HotKeyMapId", this.HotKeyMapIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Callback", item);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Exception", item2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.CancelInteraction();
			}
		}

		// Token: 0x06025E1F RID: 155167 RVA: 0x00AA352C File Offset: 0x00AA172C
		private unsafe void FinishInteraction(Action callback)
		{
			if (!this.IsInteracting)
			{
				return;
			}
			this.IsInteracting = false;
			try
			{
				if (callback != null)
				{
					callback();
				}
			}
			catch (Exception item)
			{
				this.InputEnabled = false;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigationHotKey;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[FinishInteraction] 二维拖拽结束回调异常，禁用当前输入";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HotKeyMapId", this.HotKeyMapIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Exception", item);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06025E20 RID: 155168 RVA: 0x00AA35D0 File Offset: 0x00AA17D0
		private void CancelInteraction()
		{
			this.WaitForCenter = true;
			this.FinishInteraction(this.CanceledCallback);
		}

		// Token: 0x06025E21 RID: 155169 RVA: 0x00AA35E8 File Offset: 0x00AA17E8
		private void ClearInput()
		{
			if (this.IsCleared)
			{
				return;
			}
			this.IsCleared = true;
			this.InputEnabled = false;
			this.OnRemoveEventListener();
			this.CancelInteraction();
			this.StartedCallback = null;
			this.UpdatedCallback = null;
			this.EndedCallback = null;
			this.CanceledCallback = null;
			this.HorizontalValue = 0f;
			this.VerticalValue = 0f;
			this.LastInputFrame = -1;
			this.InputWasBlocked = false;
			this.HorizontalSeenAfterBlock = false;
			this.VerticalSeenAfterBlock = false;
		}

		// Token: 0x04014D5E RID: 85342
		private Func<bool> StartedCallback;

		// Token: 0x04014D5F RID: 85343
		private Func<FreeDrag2DInput, bool> UpdatedCallback;

		// Token: 0x04014D60 RID: 85344
		private Action EndedCallback;

		// Token: 0x04014D61 RID: 85345
		private Action CanceledCallback;

		// Token: 0x04014D62 RID: 85346
		private bool InputEnabled;

		// Token: 0x04014D63 RID: 85347
		private bool IsInputRegistered;

		// Token: 0x04014D64 RID: 85348
		private bool IsCleared;

		// Token: 0x04014D65 RID: 85349
		private bool IsInteracting;

		// Token: 0x04014D66 RID: 85350
		private bool WaitForCenter;

		// Token: 0x04014D67 RID: 85351
		private bool InputWasBlocked;

		// Token: 0x04014D68 RID: 85352
		private bool HorizontalSeenAfterBlock;

		// Token: 0x04014D69 RID: 85353
		private bool VerticalSeenAfterBlock;

		// Token: 0x04014D6A RID: 85354
		private float HorizontalValue;

		// Token: 0x04014D6B RID: 85355
		private float VerticalValue;

		// Token: 0x04014D6C RID: 85356
		private int LastInputFrame = -1;
	}
}
