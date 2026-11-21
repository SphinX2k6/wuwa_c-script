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
	// Token: 0x02004BB9 RID: 19385
	public class CiacconaGalFinishBtnItem : UiPanelBase
	{
		// Token: 0x0603065E RID: 198238 RVA: 0x00D7CDA4 File Offset: 0x00D7AFA4
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

		// Token: 0x0603065F RID: 198239 RVA: 0x00D7CE6C File Offset: 0x00D7B06C
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalFinishBtnItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalFinishBtnItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030660 RID: 198240 RVA: 0x00D7CEAF File Offset: 0x00D7B0AF
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06030661 RID: 198241 RVA: 0x00D7CEC4 File Offset: 0x00D7B0C4
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

		// Token: 0x06030662 RID: 198242 RVA: 0x00D7CF2F File Offset: 0x00D7B12F
		protected override void OnBeforeDestroy()
		{
			if (this.ProtectionTimerHandle != null && TimerSystem.Instance.Has(this.ProtectionTimerHandle))
			{
				TimerSystem.Instance.Remove(this.ProtectionTimerHandle);
				this.ProtectionTimerHandle = null;
			}
		}

		// Token: 0x06030663 RID: 198243 RVA: 0x00D7CF63 File Offset: 0x00D7B163
		[NullableContext(1)]
		public void SetLocalText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x06030664 RID: 198244 RVA: 0x00D7CF7C File Offset: 0x00D7B17C
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

		// Token: 0x04019A40 RID: 105024
		private bool CanClick;

		// Token: 0x04019A41 RID: 105025
		[Nullable(2)]
		private TimerHandle ProtectionTimerHandle;

		// Token: 0x04019A42 RID: 105026
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200A7C1 RID: 42945
		private class EBtnItemComponentDefine
		{
			// Token: 0x04033D2D RID: 212269
			public const int TogSelf = 0;

			// Token: 0x04033D2E RID: 212270
			public const int Text = 1;

			// Token: 0x04033D2F RID: 212271
			public const int TextureIconLock = 2;
		}
	}
}
