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
	// Token: 0x02005BF3 RID: 23539
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalRewardButtonItem : UiPanelBase
	{
		// Token: 0x0603B7D0 RID: 243664 RVA: 0x00E2FF1C File Offset: 0x00E2E11C
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

		// Token: 0x0603B7D1 RID: 243665 RVA: 0x00E2FFC8 File Offset: 0x00E2E1C8
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalRewardButtonItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalRewardButtonItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7D2 RID: 243666 RVA: 0x00E3000B File Offset: 0x00E2E20B
		protected override void OnStart()
		{
			if (this.NeedRemainTime)
			{
				this.RefreshTimeStr();
				this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTick), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			}
		}

		// Token: 0x0603B7D3 RID: 243667 RVA: 0x00E3004A File Offset: 0x00E2E24A
		protected override void OnBeforeDestroy()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
		}

		// Token: 0x0603B7D4 RID: 243668 RVA: 0x00E30065 File Offset: 0x00E2E265
		public void SetNeedRemainTime(bool need)
		{
			this.NeedRemainTime = need;
		}

		// Token: 0x0603B7D5 RID: 243669 RVA: 0x00E3006E File Offset: 0x00E2E26E
		public void SetOnClick(Action callback)
		{
			this.OnClick = callback;
		}

		// Token: 0x0603B7D6 RID: 243670 RVA: 0x00E30077 File Offset: 0x00E2E277
		public void BindRedDot(ERedDotName redDotName, int uId = 0)
		{
			this.Button.BindRedDot(redDotName, uId);
		}

		// Token: 0x0603B7D7 RID: 243671 RVA: 0x00E30086 File Offset: 0x00E2E286
		public void UnBindRedDot()
		{
			this.Button.UnBindRedDot();
		}

		// Token: 0x0603B7D8 RID: 243672 RVA: 0x00E30093 File Offset: 0x00E2E293
		public void SetRedDotVisible(bool visible)
		{
			this.Button.SetRedDotVisible(visible);
		}

		// Token: 0x0603B7D9 RID: 243673 RVA: 0x00E300A1 File Offset: 0x00E2E2A1
		public void SetProgressText(string text)
		{
			base.GetText(2).SetText(text, true);
		}

		// Token: 0x0603B7DA RID: 243674 RVA: 0x00E300B1 File Offset: 0x00E2E2B1
		public void SetTitle(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x0603B7DB RID: 243675 RVA: 0x00E300CC File Offset: 0x00E2E2CC
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

		// Token: 0x0603B7DC RID: 243676 RVA: 0x00E30114 File Offset: 0x00E2E314
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

		// Token: 0x0603B7DD RID: 243677 RVA: 0x00E3017C File Offset: 0x00E2E37C
		private void OnClickInternal()
		{
			this.OnClick();
		}

		// Token: 0x0401EFDE RID: 126942
		[Nullable(2)]
		private ButtonSpriteItem Button;

		// Token: 0x0401EFDF RID: 126943
		private bool NeedRemainTime;

		// Token: 0x0401EFE0 RID: 126944
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401EFE1 RID: 126945
		private Action OnClick = delegate()
		{
		};

		// Token: 0x0200BDDA RID: 48602
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393EE RID: 234478
			public const int ItemBtn = 0;

			// Token: 0x040393EF RID: 234479
			public const int TextName = 1;

			// Token: 0x040393F0 RID: 234480
			public const int TextNum = 2;

			// Token: 0x040393F1 RID: 234481
			public const int TextTime = 3;
		}
	}
}
