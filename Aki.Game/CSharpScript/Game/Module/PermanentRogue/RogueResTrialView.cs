using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200533E RID: 21310
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResTrialView : UiViewBase
	{
		// Token: 0x0603673F RID: 223039 RVA: 0x00CE4A3B File Offset: 0x00CE2C3B
		public RogueResTrialView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036740 RID: 223040 RVA: 0x00CE4A44 File Offset: 0x00CE2C44
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

		// Token: 0x06036741 RID: 223041 RVA: 0x00CE4AC1 File Offset: 0x00CE2CC1
		protected override void OnStart()
		{
			this.CurSeason = (int)this.OpenParam;
			this.ScrollView = new GenericScrollViewNew<RogueResTrialTabItem, ERogueResTrialType>(base.GetScrollViewWithScrollbar(1), new Func<RogueResTrialTabItem>(this.InitTab), null, false, null);
		}

		// Token: 0x06036742 RID: 223042 RVA: 0x00CE4AF5 File Offset: 0x00CE2CF5
		protected override void OnBeforeShow()
		{
			this.RefreshTab();
		}

		// Token: 0x06036743 RID: 223043 RVA: 0x00CE4AFD File Offset: 0x00CE2CFD
		protected override void OnBeforeDestroy()
		{
			this.ScrollView = null;
		}

		// Token: 0x06036744 RID: 223044 RVA: 0x00CE4B06 File Offset: 0x00CE2D06
		private RogueResTrialTabItem InitTab()
		{
			return new RogueResTrialTabItem
			{
				SeasonId = this.CurSeason
			};
		}

		// Token: 0x06036745 RID: 223045 RVA: 0x00CE4B19 File Offset: 0x00CE2D19
		private void OnClickBtn()
		{
			HelpController.Instance.OpenHelpById(261);
		}

		// Token: 0x06036746 RID: 223046 RVA: 0x00CE4B2C File Offset: 0x00CE2D2C
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

		// Token: 0x0401CCD4 RID: 117972
		private int CurSeason;

		// Token: 0x0401CCD5 RID: 117973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RogueResTrialTabItem, ERogueResTrialType> ScrollView;

		// Token: 0x0401CCD6 RID: 117974
		private const int BTN_HELPID = 261;
	}
}
