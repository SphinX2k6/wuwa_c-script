using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BD3 RID: 19411
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalRewardButtonItem : UiPanelBase
	{
		// Token: 0x0603071B RID: 198427 RVA: 0x00D8022C File Offset: 0x00D7E42C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603071C RID: 198428 RVA: 0x00D802D8 File Offset: 0x00D7E4D8
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalRewardButtonItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalRewardButtonItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603071D RID: 198429 RVA: 0x00D8031B File Offset: 0x00D7E51B
		protected override void OnStart()
		{
			if (this.NeedRemainTime)
			{
				this.RefreshTimeStr();
				this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTick), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			}
		}

		// Token: 0x0603071E RID: 198430 RVA: 0x00D8035A File Offset: 0x00D7E55A
		protected override void OnBeforeDestroy()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
		}

		// Token: 0x0603071F RID: 198431 RVA: 0x00D80375 File Offset: 0x00D7E575
		public void SetNeedRemainTime(bool need)
		{
			this.NeedRemainTime = need;
		}

		// Token: 0x06030720 RID: 198432 RVA: 0x00D8037E File Offset: 0x00D7E57E
		public void SetOnClick(Action callback)
		{
			this.OnClick = callback;
		}

		// Token: 0x06030721 RID: 198433 RVA: 0x00D80387 File Offset: 0x00D7E587
		public void BindRedDot(ERedDotName redDotName, int uId = 0)
		{
			this.Button.BindRedDot(redDotName, uId);
		}

		// Token: 0x06030722 RID: 198434 RVA: 0x00D80396 File Offset: 0x00D7E596
		public void UnBindRedDot()
		{
			this.Button.UnBindRedDot();
		}

		// Token: 0x06030723 RID: 198435 RVA: 0x00D803A3 File Offset: 0x00D7E5A3
		public void SetRedDotVisible(bool visible)
		{
			this.Button.SetRedDotVisible(visible);
		}

		// Token: 0x06030724 RID: 198436 RVA: 0x00D803B1 File Offset: 0x00D7E5B1
		public void SetProgressText(string text)
		{
			base.GetText(2).SetText(text, true);
		}

		// Token: 0x06030725 RID: 198437 RVA: 0x00D803C1 File Offset: 0x00D7E5C1
		public void SetTitle(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x06030726 RID: 198438 RVA: 0x00D803DC File Offset: 0x00D7E5DC
		private void RefreshTimeStr()
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Xkjsx_Rewards_Timeless", null);
			string rewardRemainTimeStr = CiacconaGalModel.Instance.ActivityData.RewardRemainTimeStr;
			string newText = localTextNew + " " + rewardRemainTimeStr;
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x06030727 RID: 198439 RVA: 0x00D80424 File Offset: 0x00D7E624
		private void OnTick(float _)
		{
			this.RefreshTimeStr();
			CiacconaGalActivityData activityData = CiacconaGalModel.Instance.ActivityData;
			bool? flag = (activityData != null) ? new bool?(activityData.IsInRewardTime) : null;
			if (flag == null || !flag.Value)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
				this.SetActive(false);
			}
		}

		// Token: 0x06030728 RID: 198440 RVA: 0x00D8048C File Offset: 0x00D7E68C
		private void OnClickInternal()
		{
			this.OnClick();
		}

		// Token: 0x04019A8F RID: 105103
		[Nullable(2)]
		private ButtonSpriteItem Button;

		// Token: 0x04019A90 RID: 105104
		private bool NeedRemainTime;

		// Token: 0x04019A91 RID: 105105
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04019A92 RID: 105106
		private Action OnClick = delegate()
		{
		};

		// Token: 0x0200A7E2 RID: 42978
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033DB1 RID: 212401
			public const int ItemBtn = 0;

			// Token: 0x04033DB2 RID: 212402
			public const int TextName = 1;

			// Token: 0x04033DB3 RID: 212403
			public const int TextNum = 2;

			// Token: 0x04033DB4 RID: 212404
			public const int TextTime = 3;
		}
	}
}
