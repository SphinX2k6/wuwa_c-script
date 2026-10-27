using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DFF RID: 19967
	public class RogueInfoViewTokenDetailGridBottom : MediumItemGridComponent
	{
		// Token: 0x06033852 RID: 211026 RVA: 0x00C09F11 File Offset: 0x00C08111
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogue";
		}

		// Token: 0x06033853 RID: 211027 RVA: 0x00C09F18 File Offset: 0x00C08118
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033854 RID: 211028 RVA: 0x00C09F81 File Offset: 0x00C08181
		protected override void OnActivate()
		{
			this.CommonElementItem = new CommonElementItem();
			this.CommonElementItem.CreateThenShowByActorAsync(base.GetItem(0).GetOwner());
		}

		// Token: 0x06033855 RID: 211029 RVA: 0x00C09FA8 File Offset: 0x00C081A8
		[NullableContext(2)]
		protected override void OnRefresh(object param = null)
		{
			RogueGainEntry rogueGainEntry = param as RogueGainEntry;
			if (rogueGainEntry == null)
			{
				return;
			}
			List<ElementInfo> sortElementInfoArrayByCount = rogueGainEntry.GetSortElementInfoArrayByCount(false);
			if (sortElementInfoArrayByCount.Count <= 0)
			{
				return;
			}
			this.CommonElementItem.Update(sortElementInfoArrayByCount[0].ElementId);
			this.CommonElementItem.RefreshPanel();
			base.GetText(1).SetText(sortElementInfoArrayByCount[0].Count.ToString(), true);
		}

		// Token: 0x0401B55B RID: 111963
		[Nullable(2)]
		private CommonElementItem CommonElementItem;

		// Token: 0x0200AF8C RID: 44940
		private class ERogueInfoViewTokenDetailGridBottomDefine
		{
			// Token: 0x040354C9 RID: 218313
			public const int ElementItem = 0;

			// Token: 0x040354CA RID: 218314
			public const int ElementNumText = 1;
		}
	}
}
