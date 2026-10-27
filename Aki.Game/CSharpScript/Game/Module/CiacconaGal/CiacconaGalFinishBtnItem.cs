using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD9 RID: 23513
	public class CiacconaGalFinishBtnItem : UiPanelBase
	{
		// Token: 0x0603B713 RID: 243475 RVA: 0x00E2CA9C File Offset: 0x00E2AC9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggleTextureTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B714 RID: 243476 RVA: 0x00E2CB64 File Offset: 0x00E2AD64
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalFinishBtnItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalFinishBtnItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B715 RID: 243477 RVA: 0x00E2CBA7 File Offset: 0x00E2ADA7
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603B716 RID: 243478 RVA: 0x00E2CBBC File Offset: 0x00E2ADBC
		protected override void OnAfterShow()
		{
			this.CanClick = false;
			float interval = CiacconaGalUtils.GetAvgChoiceProtectingTime() * (float)TimeUtil.Instance.InverseMillisecond;
			this.ProtectionTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.CanClick = true;
			}, interval, null, null, true, 1f);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B717 RID: 243479 RVA: 0x00E2CC27 File Offset: 0x00E2AE27
		protected override void OnBeforeDestroy()
		{
			if (this.ProtectionTimerHandle != null && TimerSystem.Instance.Has(this.ProtectionTimerHandle))
			{
				TimerSystem.Instance.Remove(this.ProtectionTimerHandle);
				this.ProtectionTimerHandle = null;
			}
		}

		// Token: 0x0603B718 RID: 243480 RVA: 0x00E2CC5B File Offset: 0x00E2AE5B
		[NullableContext(1)]
		public void SetLocalText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x0603B719 RID: 243481 RVA: 0x00E2CC74 File Offset: 0x00E2AE74
		private void OnClickInternal(EToggleState toggleState)
		{
			if (!this.CanClick)
			{
				return;
			}
			int curHandlingStepId = CiacconaGalController.Instance.GalPlayer.CurHandlingStepId;
			int subEndingId = CiacconaGalModel.Instance.GetStepDataById(curHandlingStepId).SubEndingId;
			CiacconaGalModel.Instance.GetSubEndingDataById(subEndingId).ClientSetFinished(true);
			CiacconaGalController.Instance.ExitAvg().Forget();
		}

		// Token: 0x0401EF8F RID: 126863
		private bool CanClick;

		// Token: 0x0401EF90 RID: 126864
		[Nullable(2)]
		private TimerHandle ProtectionTimerHandle;

		// Token: 0x0401EF91 RID: 126865
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200BDB8 RID: 48568
		private class EBtnItemComponentDefine
		{
			// Token: 0x04039368 RID: 234344
			public const int TogSelf = 0;

			// Token: 0x04039369 RID: 234345
			public const int Text = 1;

			// Token: 0x0403936A RID: 234346
			public const int TextureIconLock = 2;
		}
	}
}
