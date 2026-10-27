using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.GreatSword
{
	// Token: 0x0200481C RID: 18460
	public class GreatSwordMarkTargetListItemPanel : UiPanelBase
	{
		// Token: 0x0603054D RID: 197965 RVA: 0x00B37D48 File Offset: 0x00B35F48
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

		// Token: 0x0603054E RID: 197966 RVA: 0x00B37DB1 File Offset: 0x00B35FB1
		[NullableContext(1)]
		public void SetDescTxt(string txt)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), txt, Array.Empty<object>());
		}

		// Token: 0x0603054F RID: 197967 RVA: 0x00B37DCC File Offset: 0x00B35FCC
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

		// Token: 0x0200AAF3 RID: 43763
		public static class EComponents
		{
			// Token: 0x04033F8A RID: 212874
			public const int TxtDesc = 0;

			// Token: 0x04033F8B RID: 212875
			public const int TexState = 1;
		}
	}
}
