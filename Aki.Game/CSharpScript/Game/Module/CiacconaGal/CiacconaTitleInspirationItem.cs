using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BF4 RID: 23540
	public class CiacconaTitleInspirationItem : UiPanelBase
	{
		// Token: 0x0603B7DF RID: 243679 RVA: 0x00E301B6 File Offset: 0x00E2E3B6
		[NullableContext(1)]
		public CiacconaTitleInspirationItem(CiacconaGalActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x0603B7E0 RID: 243680 RVA: 0x00E301C8 File Offset: 0x00E2E3C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B7E1 RID: 243681 RVA: 0x00E302D4 File Offset: 0x00E2E4D4
		protected override void OnStart()
		{
			this.Refresh();
			this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.Tick), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			EventSystem.Instance.Add(EEventName.OnCiacconaInspirationDataUpdate, new Action(this.OnCiacconaInspirationDataUpdate));
		}

		// Token: 0x0603B7E2 RID: 243682 RVA: 0x00E30332 File Offset: 0x00E2E532
		protected override void OnBeforeDestroy()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
			EventSystem.Instance.Remove(EEventName.OnCiacconaInspirationDataUpdate, new Action(this.OnCiacconaInspirationDataUpdate));
		}

		// Token: 0x0603B7E3 RID: 243683 RVA: 0x00E30370 File Offset: 0x00E2E570
		private void Refresh()
		{
			int inspirationCount = this.ActivityData.InspirationCount;
			int maxInspirationCount = this.ActivityData.MaxInspirationCount;
			string value = (inspirationCount == 0) ? "#c25757" : "#ffffff";
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(inspirationCount);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(maxInspirationCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			string remainTimeToNextRefreshStr = this.ActivityData.RemainTimeToNextRefreshStr;
			if (!StringUtils.IsEmpty(remainTimeToNextRefreshStr))
			{
				base.GetText(1).SetText(remainTimeToNextRefreshStr, true);
			}
			base.GetSprite(2).SetUIActive(inspirationCount < maxInspirationCount);
			base.GetItem(3).SetUIActive(inspirationCount < maxInspirationCount);
		}

		// Token: 0x0603B7E4 RID: 243684 RVA: 0x00E30441 File Offset: 0x00E2E641
		private void Tick(float _)
		{
			this.Refresh();
		}

		// Token: 0x0603B7E5 RID: 243685 RVA: 0x00E30449 File Offset: 0x00E2E649
		private void OnCiacconaInspirationDataUpdate()
		{
			this.Refresh();
		}

		// Token: 0x0603B7E6 RID: 243686 RVA: 0x00E30451 File Offset: 0x00E2E651
		private void OnClick()
		{
			HelpController.Instance.OpenHelpById(250);
		}

		// Token: 0x0401EFE2 RID: 126946
		[Nullable(1)]
		private CiacconaGalActivityData ActivityData;

		// Token: 0x0401EFE3 RID: 126947
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0200BDDD RID: 48605
		private class EInspirationComponentDefine
		{
			// Token: 0x040393F8 RID: 234488
			public const int TextNum = 0;

			// Token: 0x040393F9 RID: 234489
			public const int TextTime = 1;

			// Token: 0x040393FA RID: 234490
			public const int SpriteSplitLine = 2;

			// Token: 0x040393FB RID: 234491
			public const int ItemTime = 3;

			// Token: 0x040393FC RID: 234492
			public const int BtnSelf = 4;
		}
	}
}
