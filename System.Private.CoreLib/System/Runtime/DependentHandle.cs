using System;
using System.Runtime.CompilerServices;

namespace System.Runtime
{
	// Token: 0x020004FB RID: 1275
	[NullableContext(2)]
	[Nullable(0)]
	public struct DependentHandle : IDisposable
	{
		// Token: 0x06004812 RID: 18450 RVA: 0x000F0436 File Offset: 0x000EE636
		public DependentHandle(object target, object dependent)
		{
			this._data = new Ephemeron[1];
			this._data[0].Key = target;
			this._data[0].Value = dependent;
			GC.register_ephemeron_array(this._data);
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x000F0473 File Offset: 0x000EE673
		public bool IsAllocated
		{
			get
			{
				return this._data != null;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x000F0481 File Offset: 0x000EE681
		// (set) Token: 0x06004815 RID: 18453 RVA: 0x000F048C File Offset: 0x000EE68C
		public object Target
		{
			get
			{
				return this.UnsafeGetTarget();
			}
			set
			{
				Ephemeron[] data = this._data;
				if (data == null || value != null)
				{
					ThrowHelper.ThrowInvalidOperationException();
					return;
				}
				data[0].Key = null;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06004816 RID: 18454 RVA: 0x000F04B9 File Offset: 0x000EE6B9
		// (set) Token: 0x06004817 RID: 18455 RVA: 0x000F04C1 File Offset: 0x000EE6C1
		public object Dependent
		{
			get
			{
				return this.UnsafeGetDependent();
			}
			set
			{
				this.UnsafeSetDependent(value);
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x000F04CC File Offset: 0x000EE6CC
		[TupleElementNames(new string[]
		{
			"Target",
			"Dependent"
		})]
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public ValueTuple<object, object> TargetAndDependent
		{
			[return: TupleElementNames(new string[]
			{
				"Target",
				"Dependent"
			})]
			[return: Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			get
			{
				object item;
				return new ValueTuple<object, object>(this.UnsafeGetTargetAndDependent(out item), item);
			}
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x000F04E8 File Offset: 0x000EE6E8
		internal object UnsafeGetTarget()
		{
			Ephemeron[] data = this._data;
			if (data == null)
			{
				ThrowHelper.ThrowInvalidOperationException();
				return null;
			}
			object key = data[0].Key;
			if (key == GC.EPHEMERON_TOMBSTONE)
			{
				return null;
			}
			return key;
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x000F0520 File Offset: 0x000EE720
		internal object UnsafeGetDependent()
		{
			Ephemeron[] data = this._data;
			if (data == null)
			{
				ThrowHelper.ThrowInvalidOperationException();
				return null;
			}
			Ephemeron ephemeron = data[0];
			if (ephemeron.Key == GC.EPHEMERON_TOMBSTONE || ephemeron.Key == null)
			{
				return null;
			}
			return ephemeron.Value;
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x000F0564 File Offset: 0x000EE764
		internal object UnsafeGetTargetAndDependent(out object dependent)
		{
			Ephemeron[] data = this._data;
			if (data == null)
			{
				ThrowHelper.ThrowInvalidOperationException();
				dependent = null;
				return null;
			}
			Ephemeron ephemeron = data[0];
			if (ephemeron.Key != GC.EPHEMERON_TOMBSTONE && ephemeron.Key != null)
			{
				dependent = ephemeron.Value;
				return ephemeron.Key;
			}
			dependent = null;
			return null;
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x000F05B8 File Offset: 0x000EE7B8
		internal void UnsafeSetTargetToNull()
		{
			Ephemeron[] data = this._data;
			if (data == null)
			{
				ThrowHelper.ThrowInvalidOperationException();
				return;
			}
			data[0].Key = null;
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x000F05E4 File Offset: 0x000EE7E4
		internal void UnsafeSetDependent(object dependent)
		{
			Ephemeron[] data = this._data;
			if (data == null)
			{
				ThrowHelper.ThrowInvalidOperationException();
				return;
			}
			data[0].Value = dependent;
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x000F060E File Offset: 0x000EE80E
		public void Dispose()
		{
			this._data = null;
		}

		// Token: 0x0400111E RID: 4382
		private Ephemeron[] _data;
	}
}
