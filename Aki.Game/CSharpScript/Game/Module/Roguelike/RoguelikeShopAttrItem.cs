using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DF1 RID: 15857
	public class RoguelikeShopAttrItem : UiPanelBase
	{
		// Token: 0x060287FC RID: 165884 RVA: 0x00B5B8EC File Offset: 0x00B59AEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060287FD RID: 165885 RVA: 0x00B5B958 File Offset: 0x00B59B58
		[NullableContext(1)]
		public void Update(AffixEntry data)
		{
			RogueAffix? rogueAffixConfig = RoguelikeConfig.Instance.GetRogueAffixConfig(data.Id.Value);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueAffixConfig.Value.AffixDesc, Array.Empty<object>());
			base.GetItem(1).SetUIActive(data.IsUnlock.Value);
		}

		// Token: 0x02009A05 RID: 39429
		private class ERoguelikeShopAttrItemDefine
		{
			// Token: 0x0403003B RID: 196667
			public const int TxtAttrDesc = 0;

			// Token: 0x0403003C RID: 196668
			public const int UnlockItem = 1;
		}
	}
}
