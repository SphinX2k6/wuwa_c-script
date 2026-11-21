using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x02006401 RID: 25601
	[NullableContext(1)]
	[Nullable(0)]
	public class TsPureUiKeyHandle
	{
		// Token: 0x0603E163 RID: 254307 RVA: 0x0120339D File Offset: 0x0120159D
		public void Initialize(TsCharacterController playerController)
		{
			this.PlayerController = playerController;
		}

		// Token: 0x0603E164 RID: 254308 RVA: 0x012033A8 File Offset: 0x012015A8
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

		// Token: 0x0603E165 RID: 254309 RVA: 0x012033FC File Offset: 0x012015FC
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
			UKuroInputDelegateLibrary.RegisterKeyBinding(new FInputChord
			{
				Key = new FKey
				{
					KeyName = TsPureUiKeyHandle.LEFT_BARACKET_NAME
				}
			}, EInputEvent.IE_Released, this.PlayerController, this.OnSetUiRootActiveDelegate);
			if (this.OnSetUiRootDeactivateDelegate == null)
			{
				this.OnSetUiRootDeactivateDelegate = DelegateUtils.ToManualReleaseDelegate<FKeyBindingDelegate>(new Action<FKey>(this.OnSetUiRootDeactivate));
			}
			UKuroInputDelegateLibrary.RegisterKeyBinding(new FInputChord
			{
				Key = new FKey
				{
					KeyName = TsPureUiKeyHandle.RIGHT_BARACKET_NAME
				}
			}, EInputEvent.IE_Released, this.PlayerController, this.OnSetUiRootDeactivateDelegate);
		}

		// Token: 0x0603E166 RID: 254310 RVA: 0x012034C8 File Offset: 0x012016C8
		private void OnSetUiRootActive(FKey key)
		{
			if (SundryModel.Instance.CanOpenGmView)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 】 键显示所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiLayer.Instance.ForceShowUi();
			}
		}

		// Token: 0x0603E167 RID: 254311 RVA: 0x01203508 File Offset: 0x01201708
		private void OnSetUiRootDeactivate(FKey key)
		{
			if (SundryModel.Instance.CanOpenGmView)
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 【 键隐藏所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiLayer.Instance.ForceHideUi();
			}
		}

		// Token: 0x04020F33 RID: 134963
		private static readonly FName LEFT_BARACKET_NAME = new FName("LeftBracket");

		// Token: 0x04020F34 RID: 134964
		private static readonly FName RIGHT_BARACKET_NAME = new FName("RightBracket");

		// Token: 0x04020F35 RID: 134965
		[Nullable(2)]
		private TsCharacterController PlayerController;

		// Token: 0x04020F36 RID: 134966
		[Nullable(2)]
		private FKeyBindingDelegate OnSetUiRootActiveDelegate;

		// Token: 0x04020F37 RID: 134967
		[Nullable(2)]
		private FKeyBindingDelegate OnSetUiRootDeactivateDelegate;
	}
}
