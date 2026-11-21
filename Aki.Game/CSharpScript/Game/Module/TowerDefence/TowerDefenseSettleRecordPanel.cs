using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B0D RID: 15117
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSettleRecordPanel : UiPanelBase
	{
		// Token: 0x06026D20 RID: 159008 RVA: 0x00ADD548 File Offset: 0x00ADB748
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

		// Token: 0x06026D21 RID: 159009 RVA: 0x00ADD5D2 File Offset: 0x00ADB7D2
		public void SetTitleById(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x06026D22 RID: 159010 RVA: 0x00ADD5EB File Offset: 0x00ADB7EB
		public void SetTitleOnly(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
			base.GetText(1).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06026D23 RID: 159011 RVA: 0x00ADD61E File Offset: 0x00ADB81E
		public void SetRecord(string record, bool isNewRecord)
		{
			base.GetText(1).SetText(record, true);
			base.GetItem(2).SetUIActive(isNewRecord);
		}

		// Token: 0x06026D24 RID: 159012 RVA: 0x00ADD63B File Offset: 0x00ADB83B
		public void SetRecordRolling(int record, bool isNewRecord)
		{
			base.GetText(1).SetText(record.ToString(), true);
			base.GetItem(2).SetUIActive(isNewRecord);
		}

		// Token: 0x0200971A RID: 38682
		[NullableContext(0)]
		private class ERecordComponent
		{
			// Token: 0x0402F29C RID: 193180
			public const int TitleTxt = 0;

			// Token: 0x0402F29D RID: 193181
			public const int NumTxt = 1;

			// Token: 0x0402F29E RID: 193182
			public const int NewRecordItem = 2;
		}
	}
}
