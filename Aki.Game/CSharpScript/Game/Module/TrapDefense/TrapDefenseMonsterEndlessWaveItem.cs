using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC0 RID: 19136
	public class TrapDefenseMonsterEndlessWaveItem : UiPanelBase
	{
		// Token: 0x06031931 RID: 203057 RVA: 0x00B7EE88 File Offset: 0x00B7D088
		[NullableContext(1)]
		public UniTask Init(UUIItem item)
		{
			TrapDefenseMonsterEndlessWaveItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseMonsterEndlessWaveItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06031932 RID: 203058 RVA: 0x00B7EED4 File Offset: 0x00B7D0D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031933 RID: 203059 RVA: 0x00B7EF1C File Offset: 0x00B7D11C
		[NullableContext(1)]
		public void UpdateDescKey(string descKey)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(descKey);
		}

		// Token: 0x0200AC27 RID: 44071
		private class EChildType
		{
			// Token: 0x040344FE RID: 214270
			public const int TextContent = 0;
		}
	}
}
