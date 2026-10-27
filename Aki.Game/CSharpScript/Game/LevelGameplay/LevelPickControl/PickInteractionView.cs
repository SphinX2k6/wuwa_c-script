using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02006AD7 RID: 27351
	public class PickInteractionView : UiViewBase
	{
		// Token: 0x06043F4C RID: 278348 RVA: 0x010AACF3 File Offset: 0x010A8EF3
		[NullableContext(1)]
		public PickInteractionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043F4D RID: 278349 RVA: 0x010AACFC File Offset: 0x010A8EFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickResetBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBackBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelpInfoBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06043F4E RID: 278350 RVA: 0x010AAE0C File Offset: 0x010A900C
		protected override void OnStart()
		{
			LevelPickInteractController.Instance.OnClosingView = new Action(this.OnClosingView);
			LevelPickInteractController.Instance.OnViewPiecePostMoveEventStart = new Action(this.OnViewPiecePostMoveEventStart);
			LevelPickInteractController.Instance.OnViewPiecePostMoveEventEnd = new Action(this.OnViewPiecePostMoveEventEnd);
			this.IsDoingPostMoveEvent = false;
		}

		// Token: 0x06043F4F RID: 278351 RVA: 0x010AAE64 File Offset: 0x010A9064
		private void OnClosingView()
		{
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06043F50 RID: 278352 RVA: 0x010AAEBF File Offset: 0x010A90BF
		private void OnViewPiecePostMoveEventStart()
		{
			this.IsDoingPostMoveEvent = true;
		}

		// Token: 0x06043F51 RID: 278353 RVA: 0x010AAEC8 File Offset: 0x010A90C8
		private void OnViewPiecePostMoveEventEnd()
		{
			this.IsDoingPostMoveEvent = false;
		}

		// Token: 0x06043F52 RID: 278354 RVA: 0x010AAED1 File Offset: 0x010A90D1
		private void OnClickResetBtn()
		{
			LevelPickInteractController.Instance.ResetPickInteractGame();
		}

		// Token: 0x06043F53 RID: 278355 RVA: 0x010AAEDD File Offset: 0x010A90DD
		private void OnClickBackBtn()
		{
			this.OnClosingView();
			LevelPickInteractController.Instance.ExitPickInteractModel(false);
		}

		// Token: 0x06043F54 RID: 278356 RVA: 0x010AAEF0 File Offset: 0x010A90F0
		private void OnClickHelpInfoBtn()
		{
			if (this.IsDoingPostMoveEvent)
			{
				return;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("PickInteractionViewTutorialId");
			if (intConfig != null)
			{
				HelpController.Instance.OpenHelpById(intConfig.Value);
			}
		}

		// Token: 0x04023858 RID: 145496
		private bool IsDoingPostMoveEvent;

		// Token: 0x0200CBBC RID: 52156
		public enum EPickInteractionViewComponent
		{
			// Token: 0x0403D7C0 RID: 251840
			ResetBtn,
			// Token: 0x0403D7C1 RID: 251841
			CloseBtn,
			// Token: 0x0403D7C2 RID: 251842
			HelpInfoBtn
		}
	}
}
