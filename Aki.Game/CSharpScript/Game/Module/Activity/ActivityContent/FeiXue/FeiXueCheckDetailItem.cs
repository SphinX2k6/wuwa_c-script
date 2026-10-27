using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x0200663D RID: 26173
	public class FeiXueCheckDetailItem : UiPanelBase
	{
		// Token: 0x060419A7 RID: 268711 RVA: 0x00FE9193 File Offset: 0x00FE7393
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x060419A8 RID: 268712 RVA: 0x00FE91B6 File Offset: 0x00FE73B6
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "FeiXueWarmup_1031", Array.Empty<object>());
		}
	}
}
