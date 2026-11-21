using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200430E RID: 17166
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResTrialView : UiViewBase
	{
		// Token: 0x0602B63B RID: 177723 RVA: 0x00C3240B File Offset: 0x00C3060B
		public RogueResTrialView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B63C RID: 177724 RVA: 0x00C32414 File Offset: 0x00C30614
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
			};
		}

		// Token: 0x0602B63D RID: 177725 RVA: 0x00C32491 File Offset: 0x00C30691
		protected override void OnStart()
		{
			this.CurSeason = (int)this.OpenParam;
			this.ScrollView = new GenericScrollViewNew<RogueResTrialTabItem, ERogueResTrialType>(base.GetScrollViewWithScrollbar(1), new Func<RogueResTrialTabItem>(this.InitTab), null, false, null);
		}

		// Token: 0x0602B63E RID: 177726 RVA: 0x00C324C5 File Offset: 0x00C306C5
		protected override void OnBeforeShow()
		{
			this.RefreshTab();
		}

		// Token: 0x0602B63F RID: 177727 RVA: 0x00C324CD File Offset: 0x00C306CD
		protected override void OnBeforeDestroy()
		{
			this.ScrollView = null;
		}

		// Token: 0x0602B640 RID: 177728 RVA: 0x00C324D6 File Offset: 0x00C306D6
		private RogueResTrialTabItem InitTab()
		{
			return new RogueResTrialTabItem
			{
				SeasonId = this.CurSeason
			};
		}

		// Token: 0x0602B641 RID: 177729 RVA: 0x00C324E9 File Offset: 0x00C306E9
		private void OnClickBtn()
		{
			HelpController.Instance.OpenHelpById(261);
		}

		// Token: 0x0602B642 RID: 177730 RVA: 0x00C324FC File Offset: 0x00C306FC
		public void RefreshTab()
		{
			List<ERogueResTrialType> data = new List<ERogueResTrialType>
			{
				ERogueResTrialType.Dynamic,
				ERogueResTrialType.Static
			};
			GenericScrollViewNew<RogueResTrialTabItem, ERogueResTrialType> scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(data, null, false);
		}

		// Token: 0x0401770A RID: 96010
		private int CurSeason;

		// Token: 0x0401770B RID: 96011
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RogueResTrialTabItem, ERogueResTrialType> ScrollView;

		// Token: 0x0401770C RID: 96012
		private const int BTN_HELPID = 261;
	}
}
