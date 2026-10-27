using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x0200636B RID: 25451
	public class TagIconItem : UiPanelBase
	{
		// Token: 0x06040064 RID: 262244 RVA: 0x00F7D148 File Offset: 0x00F7B348
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040065 RID: 262245 RVA: 0x00F7D1B4 File Offset: 0x00F7B3B4
		[NullableContext(1)]
		public void RefreshPanel(string path, string color)
		{
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
			base.GetItem(0).SetColor(FColor.FromHex(color));
		}

		// Token: 0x0200C586 RID: 50566
		private enum ETagIconItem
		{
			// Token: 0x0403B9EC RID: 244204
			BgItem,
			// Token: 0x0403B9ED RID: 244205
			IconTexture
		}
	}
}
