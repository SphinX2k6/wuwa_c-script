using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200486D RID: 18541
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InstanceDungeonBottomTipItem : GridProxyAbstract<InstanceDungeonBottomTipItemData>
	{
		// Token: 0x0602EA6B RID: 191083 RVA: 0x00D057D4 File Offset: 0x00D039D4
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

		// Token: 0x0602EA6C RID: 191084 RVA: 0x00D0581C File Offset: 0x00D03A1C
		[NullableContext(1)]
		public override void Refresh(InstanceDungeonBottomTipItemData data, bool isSelected, int gridIndex)
		{
			string textId = data.TextId;
			string[] textArgs = data.TextArgs;
			if (textArgs != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, textArgs);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0200A508 RID: 42248
		private enum EComponent
		{
			// Token: 0x040331BE RID: 209342
			DescText
		}
	}
}
