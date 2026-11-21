using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055BB RID: 21947
	public class FeiXueCheckDetailItem : UiPanelBase
	{
		// Token: 0x0603666C RID: 222828 RVA: 0x00F3024B File Offset: 0x00F2E44B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0603666D RID: 222829 RVA: 0x00F3026E File Offset: 0x00F2E46E
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "FeiXueWarmup_1031", Array.Empty<object>());
		}
	}
}
