using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02005895 RID: 22677
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InstanceDungeonBottomTipItem : GridProxyAbstract<InstanceDungeonBottomTipItemData>
	{
		// Token: 0x06039B48 RID: 236360 RVA: 0x00DB68BC File Offset: 0x00DB4ABC
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

		// Token: 0x06039B49 RID: 236361 RVA: 0x00DB6904 File Offset: 0x00DB4B04
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

		// Token: 0x0200BAEF RID: 47855
		private enum EComponent
		{
			// Token: 0x040387BD RID: 231357
			DescText
		}
	}
}
