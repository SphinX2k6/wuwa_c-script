using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045B5 RID: 17845
	public class MapRogueFloatTipsItem : UiPanelBase
	{
		// Token: 0x0602CF18 RID: 184088 RVA: 0x00C91A09 File Offset: 0x00C8FC09
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602CF19 RID: 184089 RVA: 0x00C91A42 File Offset: 0x00C8FC42
		protected override void OnStart()
		{
			base.GetItem(1).SetAnchorOffsetY(-80f);
		}

		// Token: 0x0602CF1A RID: 184090 RVA: 0x00C91A55 File Offset: 0x00C8FC55
		[NullableContext(1)]
		public void SetText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0401814B RID: 98635
		private const int TIPS_OFFSET_Y = -80;
	}
}
