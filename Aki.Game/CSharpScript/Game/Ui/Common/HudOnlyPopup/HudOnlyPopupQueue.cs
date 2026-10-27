using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui.Common.HudOnlyPopup
{
	// Token: 0x020046EE RID: 18158
	[NullableContext(1)]
	[Nullable(0)]
	public class HudOnlyPopupQueue
	{
		// Token: 0x17007689 RID: 30345
		// (get) Token: 0x0602F7D8 RID: 194520 RVA: 0x00B021DD File Offset: 0x00B003DD
		public bool IsEmpty
		{
			get
			{
				return this.Tasks.Count == 0;
			}
		}

		// Token: 0x1700768A RID: 30346
		// (get) Token: 0x0602F7D9 RID: 194521 RVA: 0x00B021ED File Offset: 0x00B003ED
		public int Length
		{
			get
			{
				return this.Tasks.Count;
			}
		}

		// Token: 0x0602F7DA RID: 194522 RVA: 0x00B021FC File Offset: 0x00B003FC
		public unsafe void Push(HudOnlyPopupTask task)
		{
			if (task.DedupKey != null && this.HasKey(task.DedupKey))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCommon;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[HudOnlyPopup] 重复任务跳过";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", task.ViewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DedupKey", task.DedupKey);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.Tasks.Add(task);
		}

		// Token: 0x0602F7DB RID: 194523 RVA: 0x00B0228E File Offset: 0x00B0048E
		[NullableContext(2)]
		public HudOnlyPopupTask Shift()
		{
			if (this.Tasks.Count == 0)
			{
				return null;
			}
			HudOnlyPopupTask result = this.Tasks[0];
			this.Tasks.RemoveAt(0);
			return result;
		}

		// Token: 0x0602F7DC RID: 194524 RVA: 0x00B022B8 File Offset: 0x00B004B8
		public bool RemoveByKey(string dedupKey)
		{
			for (int i = 0; i < this.Tasks.Count; i++)
			{
				if (this.Tasks[i].DedupKey == dedupKey)
				{
					this.Tasks.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602F7DD RID: 194525 RVA: 0x00B02303 File Offset: 0x00B00503
		public void Clear()
		{
			this.Tasks.Clear();
		}

		// Token: 0x0602F7DE RID: 194526 RVA: 0x00B02310 File Offset: 0x00B00510
		private bool HasKey(string dedupKey)
		{
			using (List<HudOnlyPopupTask>.Enumerator enumerator = this.Tasks.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.DedupKey == dedupKey)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04019A7B RID: 105083
		private readonly List<HudOnlyPopupTask> Tasks = new List<HudOnlyPopupTask>();
	}
}
