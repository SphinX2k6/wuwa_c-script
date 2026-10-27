using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E28 RID: 20008
	public class RoguelikeShopAttrItem : UiPanelBase
	{
		// Token: 0x06033991 RID: 211345 RVA: 0x00C123B8 File Offset: 0x00C105B8
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

		// Token: 0x06033992 RID: 211346 RVA: 0x00C12424 File Offset: 0x00C10624
		[NullableContext(1)]
		public void Update(AffixEntry data)
		{
			RogueAffix? rogueAffixConfig = RoguelikeConfig.Instance.GetRogueAffixConfig(data.Id.Value);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueAffixConfig.Value.AffixDesc, Array.Empty<object>());
			base.GetItem(1).SetUIActive(data.IsUnlock.Value);
		}

		// Token: 0x0200AFD3 RID: 45011
		private class ERoguelikeShopAttrItemDefine
		{
			// Token: 0x0403560B RID: 218635
			public const int TxtAttrDesc = 0;

			// Token: 0x0403560C RID: 218636
			public const int UnlockItem = 1;
		}
	}
}
