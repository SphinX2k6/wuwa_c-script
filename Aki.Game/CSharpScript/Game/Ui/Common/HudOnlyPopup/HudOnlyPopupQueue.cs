using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui.Common.HudOnlyPopup
{
	// Token: 0x0200361E RID: 13854
	[NullableContext(1)]
	[Nullable(0)]
	public class HudOnlyPopupQueue
	{
		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x06023FA1 RID: 147361 RVA: 0x00A32019 File Offset: 0x00A30219
		public bool IsEmpty
		{
			get
			{
				return this.Tasks.Count == 0;
			}
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x06023FA2 RID: 147362 RVA: 0x00A32029 File Offset: 0x00A30229
		public int Length
		{
			get
			{
				return this.Tasks.Count;
			}
		}

		// Token: 0x06023FA3 RID: 147363 RVA: 0x00A32038 File Offset: 0x00A30238
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

		// Token: 0x06023FA4 RID: 147364 RVA: 0x00A320CA File Offset: 0x00A302CA
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

		// Token: 0x06023FA5 RID: 147365 RVA: 0x00A320F4 File Offset: 0x00A302F4
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

		// Token: 0x06023FA6 RID: 147366 RVA: 0x00A3213F File Offset: 0x00A3033F
		public void Clear()
		{
			this.Tasks.Clear();
		}

		// Token: 0x06023FA7 RID: 147367 RVA: 0x00A3214C File Offset: 0x00A3034C
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

		// Token: 0x0401412A RID: 82218
		private readonly List<HudOnlyPopupTask> Tasks = new List<HudOnlyPopupTask>();
	}
}
