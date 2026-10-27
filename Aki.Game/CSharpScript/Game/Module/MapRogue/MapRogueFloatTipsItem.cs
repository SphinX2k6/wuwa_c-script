using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055DF RID: 21983
	public class MapRogueFloatTipsItem : UiPanelBase
	{
		// Token: 0x0603801A RID: 229402 RVA: 0x00D43CC1 File Offset: 0x00D41EC1
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603801B RID: 229403 RVA: 0x00D43CFA File Offset: 0x00D41EFA
		protected override void OnStart()
		{
			base.GetItem(1).SetAnchorOffsetY(-80f);
		}

		// Token: 0x0603801C RID: 229404 RVA: 0x00D43D0D File Offset: 0x00D41F0D
		[NullableContext(1)]
		public void SetText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0401D6C0 RID: 120512
		private const int TIPS_OFFSET_Y = -80;
	}
}
