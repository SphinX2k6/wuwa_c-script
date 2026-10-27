using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x02007282 RID: 29314
	[NullableContext(1)]
	[Nullable(0)]
	public class TsPureUiKeyHandle
	{
		// Token: 0x06047DA3 RID: 294307 RVA: 0x0126299D File Offset: 0x01260B9D
		public void Initialize(TsCharacterController playerController)
		{
			this.PlayerController = playerController;
		}

		// Token: 0x06047DA4 RID: 294308 RVA: 0x012629A8 File Offset: 0x01260BA8
		public void Reset()
		{
			this.PlayerController = null;
			if (this.OnSetUiRootActiveDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FKey>(this.OnSetUiRootActive));
				this.OnSetUiRootActiveDelegate = null;
			}
			if (this.OnSetUiRootDeactivateDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FKey>(this.OnSetUiRootDeactivate));
				this.OnSetUiRootDeactivateDelegate = null;
			}
		}

		// Token: 0x06047DA5 RID: 294309 RVA: 0x012629FC File Offset: 0x01260BFC
		public void BindKey()
		{
			if (this.PlayerController == null)
			{
				Log.Instance.Error(ELogModule.Input, ELogAuthor.WLJ, "[TsPureUiKeyHandle::BindTouch]PlayerController为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.OnSetUiRootActiveDelegate == null)
			{
				this.OnSetUiRootActiveDelegate = DelegateUtils.ToManualReleaseDelegate<FKeyBindingDelegate>(new Action<FKey>(this.OnSetUiRootActive));
			}
			UKuroInputDelegateLibrary.RegisterKeyBinding(new FInputChord(new FKey(TsPureUiKeyHandle.LEFT_BARACKET_NAME), false, false, false, false), EInputEvent.IE_Released, this.PlayerController, this.OnSetUiRootActiveDelegate);
			if (this.OnSetUiRootDeactivateDelegate == null)
			{
				this.OnSetUiRootDeactivateDelegate = DelegateUtils.ToManualReleaseDelegate<FKeyBindingDelegate>(new Action<FKey>(this.OnSetUiRootDeactivate));
			}
			UKuroInputDelegateLibrary.RegisterKeyBinding(new FInputChord(new FKey(TsPureUiKeyHandle.RIGHT_BARACKET_NAME), false, false, false, false), EInputEvent.IE_Released, this.PlayerController, this.OnSetUiRootDeactivateDelegate);
		}

		// Token: 0x06047DA6 RID: 294310 RVA: 0x01262AB8 File Offset: 0x01260CB8
		private void OnSetUiRootActive(FKey key)
		{
			if (SundryModel.Instance.CanOpenGmView)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 】 键显示所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiLayer.Instance.ForceShowUi();
			}
		}

		// Token: 0x06047DA7 RID: 294311 RVA: 0x01262AF8 File Offset: 0x01260CF8
		private void OnSetUiRootDeactivate(FKey key)
		{
			if (SundryModel.Instance.CanOpenGmView)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 【 键隐藏所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiLayer.Instance.ForceHideUi();
			}
		}

		// Token: 0x04025C73 RID: 154739
		private static readonly FName LEFT_BARACKET_NAME = new FName("LeftBracket");

		// Token: 0x04025C74 RID: 154740
		private static readonly FName RIGHT_BARACKET_NAME = new FName("RightBracket");

		// Token: 0x04025C75 RID: 154741
		[Nullable(2)]
		private TsCharacterController PlayerController;

		// Token: 0x04025C76 RID: 154742
		[Nullable(2)]
		private FKeyBindingDelegate OnSetUiRootActiveDelegate;

		// Token: 0x04025C77 RID: 154743
		[Nullable(2)]
		private FKeyBindingDelegate OnSetUiRootDeactivateDelegate;
	}
}
