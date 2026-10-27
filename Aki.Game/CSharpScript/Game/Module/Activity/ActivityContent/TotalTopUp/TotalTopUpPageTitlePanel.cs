using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FBE RID: 24510
	public class TotalTopUpPageTitlePanel : UiPanelBase
	{
		// Token: 0x0603E212 RID: 254482 RVA: 0x00F01444 File Offset: 0x00EFF644
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickHelp))
			};
		}

		// Token: 0x0603E213 RID: 254483 RVA: 0x00F014D8 File Offset: 0x00EFF6D8
		public void RefreshTime(long time)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((double)time);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, "TotalTopUp_1001", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? string.Empty));
		}

		// Token: 0x0603E214 RID: 254484 RVA: 0x00F0151E File Offset: 0x00EFF71E
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(516);
		}

		// Token: 0x0200C296 RID: 49814
		private class ENode
		{
			// Token: 0x0403AC88 RID: 240776
			public const int TextTitle = 0;

			// Token: 0x0403AC89 RID: 240777
			public const int TextTime = 1;

			// Token: 0x0403AC8A RID: 240778
			public const int TextDescription = 2;

			// Token: 0x0403AC8B RID: 240779
			public const int BtnHelp = 3;
		}
	}
}
