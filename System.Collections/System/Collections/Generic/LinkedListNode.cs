using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x02000014 RID: 20
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class LinkedListNode<[Nullable(2)] T>
	{
		// Token: 0x060000BB RID: 187 RVA: 0x000049B4 File Offset: 0x00002BB4
		public LinkedListNode(T value)
		{
			this.item = value;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000049C3 File Offset: 0x00002BC3
		internal LinkedListNode(LinkedList<T> list, T value)
		{
			this.list = list;
			this.item = value;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000049D9 File Offset: 0x00002BD9
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public LinkedList<T> List
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this.list;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000049E1 File Offset: 0x00002BE1
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public LinkedListNode<T> Next
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.next != null && this.next != this.list.head)
				{
					return this.next;
				}
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004A06 File Offset: 0x00002C06
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public LinkedListNode<T> Previous
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.prev != null && this != this.list.head)
				{
					return this.prev;
				}
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004A26 File Offset: 0x00002C26
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00004A2E File Offset: 0x00002C2E
		public T Value
		{
			get
			{
				return this.item;
			}
			set
			{
				this.item = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004A37 File Offset: 0x00002C37
		public ref T ValueRef
		{
			get
			{
				return ref this.item;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004A3F File Offset: 0x00002C3F
		internal void Invalidate()
		{
			this.list = null;
			this.next = null;
			this.prev = null;
		}

		// Token: 0x0400001D RID: 29
		internal LinkedList<T> list;

		// Token: 0x0400001E RID: 30
		internal LinkedListNode<T> next;

		// Token: 0x0400001F RID: 31
		internal LinkedListNode<T> prev;

		// Token: 0x04000020 RID: 32
		internal T item;
	}
}
