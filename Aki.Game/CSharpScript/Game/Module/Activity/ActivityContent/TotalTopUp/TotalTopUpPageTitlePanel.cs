using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FA5 RID: 20389
	public class TotalTopUpPageTitlePanel : UiPanelBase
	{
		// Token: 0x060331AC RID: 209324 RVA: 0x00E53100 File Offset: 0x00E51300
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

		// Token: 0x060331AD RID: 209325 RVA: 0x00E53194 File Offset: 0x00E51394
		public void RefreshTime(long time)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((double)time);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, "TotalTopUp_1001", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? string.Empty));
		}

		// Token: 0x060331AE RID: 209326 RVA: 0x00E531DA File Offset: 0x00E513DA
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(516);
		}

		// Token: 0x0200ACA1 RID: 44193
		private class ENode
		{
			// Token: 0x04035664 RID: 218724
			public const int TextTitle = 0;

			// Token: 0x04035665 RID: 218725
			public const int TextTime = 1;

			// Token: 0x04035666 RID: 218726
			public const int TextDescription = 2;

			// Token: 0x04035667 RID: 218727
			public const int BtnHelp = 3;
		}
	}
}
