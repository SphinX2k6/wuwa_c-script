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
	// Token: 0x02003A68 RID: 14952
	public class TrapDefenseMonsterEndlessWaveItem : UiPanelBase
	{
		// Token: 0x060266C1 RID: 157377 RVA: 0x00AC2E3C File Offset: 0x00AC103C
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

		// Token: 0x060266C2 RID: 157378 RVA: 0x00AC2E88 File Offset: 0x00AC1088
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

		// Token: 0x060266C3 RID: 157379 RVA: 0x00AC2ED0 File Offset: 0x00AC10D0
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

		// Token: 0x02009647 RID: 38471
		private class EChildType
		{
			// Token: 0x0402EEAF RID: 192175
			public const int TextContent = 0;
		}
	}
}
