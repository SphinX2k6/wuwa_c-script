using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.View.CountDown
{
	// Token: 0x020059C0 RID: 22976
	public class SimpleLogicTreeCountDownView : UiViewBase
	{
		// Token: 0x0603A3DF RID: 238559 RVA: 0x00DD787C File Offset: 0x00DD5A7C
		[NullableContext(1)]
		public SimpleLogicTreeCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A3E0 RID: 238560 RVA: 0x00DD7888 File Offset: 0x00DD5A88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A3E1 RID: 238561 RVA: 0x00DD78F4 File Offset: 0x00DD5AF4
		protected override void OnStart()
		{
			SimpleLogicTreeCountDownViewParam simpleLogicTreeCountDownViewParam = this.OpenParam as SimpleLogicTreeCountDownViewParam;
			if (simpleLogicTreeCountDownViewParam != null)
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetText(simpleLogicTreeCountDownViewParam.Title, true);
				}
			}
			EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
		}

		// Token: 0x0603A3E2 RID: 238562 RVA: 0x00DD7945 File Offset: 0x00DD5B45
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.OnCountDownChanged));
		}

		// Token: 0x0603A3E3 RID: 238563 RVA: 0x00DD7964 File Offset: 0x00DD5B64
		private void HandleCountDownEnd()
		{
			GeneralLogicTreeModel.Instance.CountDownViewClosing = true;
			UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool success)
			{
				if (success)
				{
					GeneralLogicTreeModel.Instance.CountDownViewClosing = false;
				}
			});
		}

		// Token: 0x0603A3E4 RID: 238564 RVA: 0x00DD79B0 File Offset: 0x00DD5BB0
		private void OnCountDownChanged(double remainTime, double timerEndTime)
		{
			UUIText text = base.GetText(0);
			if (remainTime <= 0.0)
			{
				this.HandleCountDownEnd();
				return;
			}
			string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5(remainTime);
			if (text != null)
			{
				text.SetText(remainTimeDataFormat, true);
			}
		}

		// Token: 0x0200BC27 RID: 48167
		public static class ESimpleLogicTreeCountDownView
		{
			// Token: 0x04038C89 RID: 232585
			public const int TxtCountDown = 0;

			// Token: 0x04038C8A RID: 232586
			public const int TxtTitle = 1;
		}
	}
}
