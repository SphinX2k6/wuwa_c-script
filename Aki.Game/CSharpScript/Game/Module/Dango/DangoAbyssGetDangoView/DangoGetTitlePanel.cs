using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango.DangoAbyssGetDangoView
{
	// Token: 0x02005AEA RID: 23274
	internal class DangoGetTitlePanel : UiPanelBase
	{
		// Token: 0x0603AEC4 RID: 241348 RVA: 0x00E0C458 File Offset: 0x00E0A658
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite))
			};
		}

		// Token: 0x0603AEC5 RID: 241349 RVA: 0x00E0C4B4 File Offset: 0x00E0A6B4
		[NullableContext(1)]
		public void RefreshView(DangoAbyssDefine.IDangoUnlockData data)
		{
			base.GetText(0).SetText(data.UnlockTitle, true);
			base.GetText(1).SetText(data.UnlockSubTitle, true);
			this.SetSpriteByPath(data.UnlockWutheringWaveTitleSpritePath, base.GetSprite(2), true, null, null);
		}
	}
}
