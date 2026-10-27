using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RecallQuest.Views
{
	// Token: 0x02004F19 RID: 20249
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RecallFunctionAttachGrid : AutoAttachItem<List<int>>
	{
		// Token: 0x06033EB6 RID: 212662 RVA: 0x00C2B1DA File Offset: 0x00C293DA
		[NullableContext(2)]
		public RecallFunctionAttachGrid(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x06033EB7 RID: 212663 RVA: 0x00C2B1E4 File Offset: 0x00C293E4
		protected override void OnRefreshItem(List<int> data)
		{
			if (data == null)
			{
				return;
			}
			GenericLayout<RecallFunctionItem, int> recallLayout = this.RecallLayout;
			if (recallLayout != null)
			{
				recallLayout.RefreshByDataAsync(data, this.NeedAnim, null);
			}
			this.NeedAnim = false;
		}

		// Token: 0x06033EB8 RID: 212664 RVA: 0x00C2B220 File Offset: 0x00C29420
		public override void OnSelect()
		{
			EventSystem.Instance.Emit<int>(EEventName.FunctionGridSelected, base.GetCurrentShowItemIndex());
		}

		// Token: 0x06033EB9 RID: 212665 RVA: 0x00C2B238 File Offset: 0x00C29438
		protected override void OnUnSelect()
		{
		}

		// Token: 0x06033EBA RID: 212666 RVA: 0x00C2B23A File Offset: 0x00C2943A
		protected override void OnMoveItem()
		{
		}

		// Token: 0x06033EBB RID: 212667 RVA: 0x00C2B23C File Offset: 0x00C2943C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033EBC RID: 212668 RVA: 0x00C2B2A8 File Offset: 0x00C294A8
		protected override void OnStart()
		{
			this.RecallLayout = new GenericLayout<RecallFunctionItem, int>(base.GetGridLayout(0), () => new RecallFunctionItem(), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033EBD RID: 212669 RVA: 0x00C2B2F9 File Offset: 0x00C294F9
		public void SetNeedAnim(bool value)
		{
			this.NeedAnim = value;
		}

		// Token: 0x0401B974 RID: 113012
		public GenericLayout<RecallFunctionItem, int> RecallLayout;

		// Token: 0x0401B975 RID: 113013
		private bool NeedAnim;

		// Token: 0x0200B05F RID: 45151
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x0403586A RID: 219242
			public const int LayoutItem = 0;

			// Token: 0x0403586B RID: 219243
			public const int GridItem = 1;
		}
	}
}
