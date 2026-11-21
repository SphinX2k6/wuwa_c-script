using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango.DangoAbyssGetDangoView
{
	// Token: 0x02004ACB RID: 19147
	internal class DangoGetTitlePanel : UiPanelBase
	{
		// Token: 0x0602FE36 RID: 196150 RVA: 0x00D5D130 File Offset: 0x00D5B330
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x0602FE37 RID: 196151 RVA: 0x00D5D18C File Offset: 0x00D5B38C
		[NullableContext(1)]
		public void RefreshView(DangoAbyssDefine.IDangoUnlockData data)
		{
			base.GetText(0).SetText(data.UnlockTitle, true);
			base.GetText(1).SetText(data.UnlockSubTitle, true);
			this.SetSpriteByPath(data.UnlockWutheringWaveTitleSpritePath, base.GetSprite(2), true, null, null);
		}
	}
}
