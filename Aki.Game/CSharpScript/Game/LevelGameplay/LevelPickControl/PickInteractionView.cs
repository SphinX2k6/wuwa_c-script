using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02005C4F RID: 23631
	public class PickInteractionView : UiViewBase
	{
		// Token: 0x0603A095 RID: 237717 RVA: 0x010543A3 File Offset: 0x010525A3
		[NullableContext(1)]
		public PickInteractionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A096 RID: 237718 RVA: 0x010543AC File Offset: 0x010525AC
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

		// Token: 0x0603A097 RID: 237719 RVA: 0x010544BC File Offset: 0x010526BC
		protected override void OnStart()
		{
			LevelPickInteractController.Instance.OnClosingView = new Action(this.OnClosingView);
			LevelPickInteractController.Instance.OnViewPiecePostMoveEventStart = new Action(this.OnViewPiecePostMoveEventStart);
			LevelPickInteractController.Instance.OnViewPiecePostMoveEventEnd = new Action(this.OnViewPiecePostMoveEventEnd);
			this.IsDoingPostMoveEvent = false;
		}

		// Token: 0x0603A098 RID: 237720 RVA: 0x01054514 File Offset: 0x01052714
		private void OnClosingView()
		{
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0603A099 RID: 237721 RVA: 0x0105456F File Offset: 0x0105276F
		private void OnViewPiecePostMoveEventStart()
		{
			this.IsDoingPostMoveEvent = true;
		}

		// Token: 0x0603A09A RID: 237722 RVA: 0x01054578 File Offset: 0x01052778
		private void OnViewPiecePostMoveEventEnd()
		{
			this.IsDoingPostMoveEvent = false;
		}

		// Token: 0x0603A09B RID: 237723 RVA: 0x01054581 File Offset: 0x01052781
		private void OnClickResetBtn()
		{
			LevelPickInteractController.Instance.ResetPickInteractGame();
		}

		// Token: 0x0603A09C RID: 237724 RVA: 0x0105458D File Offset: 0x0105278D
		private void OnClickBackBtn()
		{
			this.OnClosingView();
			LevelPickInteractController.Instance.ExitPickInteractModel(false);
		}

		// Token: 0x0603A09D RID: 237725 RVA: 0x010545A0 File Offset: 0x010527A0
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

		// Token: 0x0401EAF8 RID: 125688
		private bool IsDoingPostMoveEvent;

		// Token: 0x0200B7AD RID: 47021
		public enum EPickInteractionViewComponent
		{
			// Token: 0x04038BE3 RID: 232419
			ResetBtn,
			// Token: 0x04038BE4 RID: 232420
			CloseBtn,
			// Token: 0x04038BE5 RID: 232421
			HelpInfoBtn
		}
	}
}
