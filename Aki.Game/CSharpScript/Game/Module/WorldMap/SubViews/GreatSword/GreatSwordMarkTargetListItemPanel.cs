using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.GreatSword
{
	// Token: 0x0200374D RID: 14157
	public class GreatSwordMarkTargetListItemPanel : UiPanelBase
	{
		// Token: 0x06024D1D RID: 150813 RVA: 0x00A67E08 File Offset: 0x00A66008
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024D1E RID: 150814 RVA: 0x00A67E71 File Offset: 0x00A66071
		[NullableContext(1)]
		public void SetDescTxt(string txt)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), txt, Array.Empty<object>());
		}

		// Token: 0x06024D1F RID: 150815 RVA: 0x00A67E8C File Offset: 0x00A6608C
		public void SetState(bool completed)
		{
			string resourceId;
			if (!completed)
			{
				resourceId = "T_MapDifficultyEmpty";
			}
			else
			{
				resourceId = "T_MapDifficultyTick";
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
		}

		// Token: 0x020094A2 RID: 38050
		public static class EComponents
		{
			// Token: 0x0402E70A RID: 190218
			public const int TxtDesc = 0;

			// Token: 0x0402E70B RID: 190219
			public const int TexState = 1;
		}
	}
}
