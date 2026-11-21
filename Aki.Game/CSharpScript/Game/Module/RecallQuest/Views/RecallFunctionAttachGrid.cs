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
	// Token: 0x02003EE2 RID: 16098
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RecallFunctionAttachGrid : AutoAttachItem<List<int>>
	{
		// Token: 0x06028D21 RID: 167201 RVA: 0x00B7484E File Offset: 0x00B72A4E
		[NullableContext(2)]
		public RecallFunctionAttachGrid(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x06028D22 RID: 167202 RVA: 0x00B74858 File Offset: 0x00B72A58
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

		// Token: 0x06028D23 RID: 167203 RVA: 0x00B74894 File Offset: 0x00B72A94
		public override void OnSelect()
		{
			EventSystem.Instance.Emit<int>(EEventName.FunctionGridSelected, base.GetCurrentShowItemIndex());
		}

		// Token: 0x06028D24 RID: 167204 RVA: 0x00B748AC File Offset: 0x00B72AAC
		protected override void OnUnSelect()
		{
		}

		// Token: 0x06028D25 RID: 167205 RVA: 0x00B748AE File Offset: 0x00B72AAE
		protected override void OnMoveItem()
		{
		}

		// Token: 0x06028D26 RID: 167206 RVA: 0x00B748B0 File Offset: 0x00B72AB0
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

		// Token: 0x06028D27 RID: 167207 RVA: 0x00B7491C File Offset: 0x00B72B1C
		protected override void OnStart()
		{
			this.RecallLayout = new GenericLayout<RecallFunctionItem, int>(base.GetGridLayout(0), () => new RecallFunctionItem(), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06028D28 RID: 167208 RVA: 0x00B7496D File Offset: 0x00B72B6D
		public void SetNeedAnim(bool value)
		{
			this.NeedAnim = value;
		}

		// Token: 0x04016347 RID: 90951
		public GenericLayout<RecallFunctionItem, int> RecallLayout;

		// Token: 0x04016348 RID: 90952
		private bool NeedAnim;

		// Token: 0x02009A8F RID: 39567
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04030295 RID: 197269
			public const int LayoutItem = 0;

			// Token: 0x04030296 RID: 197270
			public const int GridItem = 1;
		}
	}
}
