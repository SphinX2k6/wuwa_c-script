using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200467A RID: 18042
	[NullableContext(1)]
	[Nullable(0)]
	internal class InputCallback<[Nullable(2)] T>
	{
		// Token: 0x0602E8FE RID: 190718 RVA: 0x00AC74D4 File Offset: 0x00AC56D4
		public InputCallback(string name)
		{
			this.InputIdentification = new InputIdentification(name);
		}

		// Token: 0x0602E8FF RID: 190719 RVA: 0x00AC750C File Offset: 0x00AC570C
		public void Call(T value)
		{
			this.IsCalling = true;
			foreach (TInputHandle<T> tinputHandle in this.CallbackList)
			{
				tinputHandle(this.InputIdentification.Name, value, this.InputIdentification);
			}
			this.TryAddAllPendingCallback();
			this.TryRemoveAllPendingCallback();
			this.IsCalling = false;
		}

		// Token: 0x0602E900 RID: 190720 RVA: 0x00AC7588 File Offset: 0x00AC5788
		public void Add(TInputHandle<T> callback)
		{
			if (this.IsCalling)
			{
				this.PendingAddCallbackList.Add(callback);
				return;
			}
			this.CallbackList.Add(callback);
		}

		// Token: 0x0602E901 RID: 190721 RVA: 0x00AC75AC File Offset: 0x00AC57AC
		private void TryAddAllPendingCallback()
		{
			if (this.PendingAddCallbackList.Count <= 0)
			{
				return;
			}
			foreach (TInputHandle<T> item in this.PendingAddCallbackList)
			{
				this.CallbackList.Add(item);
			}
			this.PendingAddCallbackList.Clear();
		}

		// Token: 0x0602E902 RID: 190722 RVA: 0x00AC7620 File Offset: 0x00AC5820
		public void Remove(TInputHandle<T> callback)
		{
			if (this.IsCalling)
			{
				this.PendingRemoveCallbackList.Add(callback);
				return;
			}
			int num = this.CallbackList.IndexOf(callback);
			if (num < 0)
			{
				return;
			}
			this.CallbackList.RemoveAt(num);
		}

		// Token: 0x0602E903 RID: 190723 RVA: 0x00AC7660 File Offset: 0x00AC5860
		private void TryRemoveAllPendingCallback()
		{
			if (this.PendingRemoveCallbackList.Count <= 0)
			{
				return;
			}
			foreach (TInputHandle<T> item in this.PendingRemoveCallbackList)
			{
				int num = this.CallbackList.IndexOf(item);
				if (num >= 0)
				{
					this.CallbackList.RemoveAt(num);
				}
			}
			this.PendingRemoveCallbackList.Clear();
		}

		// Token: 0x0602E904 RID: 190724 RVA: 0x00AC76E4 File Offset: 0x00AC58E4
		public void Clear()
		{
			this.InputIdentification = null;
			this.CallbackList.Clear();
		}

		// Token: 0x0602E905 RID: 190725 RVA: 0x00AC76F8 File Offset: 0x00AC58F8
		public int Length()
		{
			return this.CallbackList.Count;
		}

		// Token: 0x04019525 RID: 103717
		[Nullable(2)]
		private InputIdentification InputIdentification;

		// Token: 0x04019526 RID: 103718
		private readonly List<TInputHandle<T>> CallbackList = new List<TInputHandle<T>>();

		// Token: 0x04019527 RID: 103719
		private readonly List<TInputHandle<T>> PendingAddCallbackList = new List<TInputHandle<T>>();

		// Token: 0x04019528 RID: 103720
		private readonly List<TInputHandle<T>> PendingRemoveCallbackList = new List<TInputHandle<T>>();

		// Token: 0x04019529 RID: 103721
		private bool IsCalling;
	}
}
