using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061A2 RID: 24994
	public class RoverlikeTalentTreeLevelDescItem : UiPanelBase
	{
		// Token: 0x0603F203 RID: 258563 RVA: 0x00F3F3E4 File Offset: 0x00F3D5E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F204 RID: 258564 RVA: 0x00F3F44D File Offset: 0x00F3D64D
		[NullableContext(1)]
		public void SetContent(int level, string descTextId, IReadOnlyList<string> descParams)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), descTextId, descParams.ToArray<string>());
		}

		// Token: 0x0603F205 RID: 258565 RVA: 0x00F3F467 File Offset: 0x00F3D667
		[NullableContext(1)]
		public void SetTitle(string titleTextId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), titleTextId, Array.Empty<object>());
		}

		// Token: 0x0200C3EC RID: 50156
		private class ELevelDescDefine
		{
			// Token: 0x0403B1F0 RID: 242160
			public const int TxtDetail = 0;

			// Token: 0x0403B1F1 RID: 242161
			public const int TxtTitle = 1;
		}
	}
}
