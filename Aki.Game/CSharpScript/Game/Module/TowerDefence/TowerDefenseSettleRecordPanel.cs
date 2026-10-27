using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B65 RID: 19301
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSettleRecordPanel : UiPanelBase
	{
		// Token: 0x06031F91 RID: 204689 RVA: 0x00B9930C File Offset: 0x00B9750C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F92 RID: 204690 RVA: 0x00B99396 File Offset: 0x00B97596
		public void SetTitleById(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x06031F93 RID: 204691 RVA: 0x00B993AF File Offset: 0x00B975AF
		public void SetTitleOnly(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
			base.GetText(1).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06031F94 RID: 204692 RVA: 0x00B993E2 File Offset: 0x00B975E2
		public void SetRecord(string record, bool isNewRecord)
		{
			base.GetText(1).SetText(record, true);
			base.GetItem(2).SetUIActive(isNewRecord);
		}

		// Token: 0x06031F95 RID: 204693 RVA: 0x00B993FF File Offset: 0x00B975FF
		public void SetRecordRolling(int record, bool isNewRecord)
		{
			base.GetText(1).SetText(record.ToString(), true);
			base.GetItem(2).SetUIActive(isNewRecord);
		}

		// Token: 0x0200ACFB RID: 44283
		[NullableContext(0)]
		private class ERecordComponent
		{
			// Token: 0x040348F3 RID: 215283
			public const int TitleTxt = 0;

			// Token: 0x040348F4 RID: 215284
			public const int NumTxt = 1;

			// Token: 0x040348F5 RID: 215285
			public const int NewRecordItem = 2;
		}
	}
}
