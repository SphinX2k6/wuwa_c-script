using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BD4 RID: 19412
	public class CiacconaTitleInspirationItem : UiPanelBase
	{
		// Token: 0x0603072A RID: 198442 RVA: 0x00D804C6 File Offset: 0x00D7E6C6
		[NullableContext(1)]
		public CiacconaTitleInspirationItem(CiacconaGalActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x0603072B RID: 198443 RVA: 0x00D804D8 File Offset: 0x00D7E6D8
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

		// Token: 0x0603072C RID: 198444 RVA: 0x00D805E4 File Offset: 0x00D7E7E4
		protected override void OnStart()
		{
			this.Refresh();
			this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.Tick), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			EventSystem.Instance.Add(EEventName.OnCiacconaInspirationDataUpdate, new Action(this.OnCiacconaInspirationDataUpdate));
		}

		// Token: 0x0603072D RID: 198445 RVA: 0x00D80642 File Offset: 0x00D7E842
		protected override void OnBeforeDestroy()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
			EventSystem.Instance.Remove(EEventName.OnCiacconaInspirationDataUpdate, new Action(this.OnCiacconaInspirationDataUpdate));
		}

		// Token: 0x0603072E RID: 198446 RVA: 0x00D80680 File Offset: 0x00D7E880
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

		// Token: 0x0603072F RID: 198447 RVA: 0x00D80751 File Offset: 0x00D7E951
		private void Tick(float _)
		{
			this.Refresh();
		}

		// Token: 0x06030730 RID: 198448 RVA: 0x00D80759 File Offset: 0x00D7E959
		private void OnCiacconaInspirationDataUpdate()
		{
			this.Refresh();
		}

		// Token: 0x06030731 RID: 198449 RVA: 0x00D80761 File Offset: 0x00D7E961
		private void OnClick()
		{
			HelpController.Instance.OpenHelpById(250);
		}

		// Token: 0x04019A93 RID: 105107
		[Nullable(1)]
		private CiacconaGalActivityData ActivityData;

		// Token: 0x04019A94 RID: 105108
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0200A7E5 RID: 42981
		private class EInspirationComponentDefine
		{
			// Token: 0x04033DBB RID: 212411
			public const int TextNum = 0;

			// Token: 0x04033DBC RID: 212412
			public const int TextTime = 1;

			// Token: 0x04033DBD RID: 212413
			public const int SpriteSplitLine = 2;

			// Token: 0x04033DBE RID: 212414
			public const int ItemTime = 3;

			// Token: 0x04033DBF RID: 212415
			public const int BtnSelf = 4;
		}
	}
}
