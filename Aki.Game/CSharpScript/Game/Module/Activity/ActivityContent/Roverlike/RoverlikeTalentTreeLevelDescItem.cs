using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005120 RID: 20768
	public class RoverlikeTalentTreeLevelDescItem : UiPanelBase
	{
		// Token: 0x06033EC3 RID: 212675 RVA: 0x00E862AC File Offset: 0x00E844AC
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

		// Token: 0x06033EC4 RID: 212676 RVA: 0x00E86315 File Offset: 0x00E84515
		[NullableContext(1)]
		public void SetContent(int level, string descTextId, IReadOnlyList<string> descParams)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), descTextId, descParams.ToArray<string>());
		}

		// Token: 0x06033EC5 RID: 212677 RVA: 0x00E8632F File Offset: 0x00E8452F
		[NullableContext(1)]
		public void SetTitle(string titleTextId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), titleTextId, Array.Empty<object>());
		}

		// Token: 0x0200ADD3 RID: 44499
		private class ELevelDescDefine
		{
			// Token: 0x04035B51 RID: 219985
			public const int TxtDetail = 0;

			// Token: 0x04035B52 RID: 219986
			public const int TxtTitle = 1;
		}
	}
}
