using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006009 RID: 24585
	public class LockBtnPanel : UiPanelBase
	{
		// Token: 0x0603E43F RID: 255039 RVA: 0x00F08808 File Offset: 0x00F06A08
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603E440 RID: 255040 RVA: 0x00F08862 File Offset: 0x00F06A62
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Tetristext_14", Array.Empty<object>());
			base.GetItem(2).SetUIActive(false);
		}
	}
}
