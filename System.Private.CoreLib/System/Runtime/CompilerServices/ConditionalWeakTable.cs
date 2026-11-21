using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200067F RID: 1663
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class ConditionalWeakTable<TKey, [Nullable(2), DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class where TValue : class
	{
		// Token: 0x06007397 RID: 29591 RVA: 0x001134D2 File Offset: 0x001116D2
		public ConditionalWeakTable()
		{
			this._lock = new object();
			this._container = new ConditionalWeakTable<TKey, TValue>.Container(this);
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x001134F3 File Offset: 0x001116F3
		public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			return this._container.TryGetValueWorker(key, out value);
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x00113514 File Offset: 0x00111714
		public void Add(TKey key, TValue value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			object @lock = this._lock;
			lock (@lock)
			{
				object obj;
				if (this._container.FindEntry(key, out obj) != -1)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AddingDuplicate);
				}
				this.CreateEntry(key, value);
			}
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x00113580 File Offset: 0x00111780
		public bool TryAdd(TKey key, TValue value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			object @lock = this._lock;
			bool result;
			lock (@lock)
			{
				object obj;
				if (this._container.FindEntry(key, out obj) != -1)
				{
					result = false;
				}
				else
				{
					this.CreateEntry(key, value);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x001135EC File Offset: 0x001117EC
		public void AddOrUpdate(TKey key, TValue value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			object @lock = this._lock;
			lock (@lock)
			{
				object obj;
				int num = this._container.FindEntry(key, out obj);
				if (num != -1)
				{
					this._container.UpdateValue(num, value);
				}
				else
				{
					this.CreateEntry(key, value);
				}
			}
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x00113664 File Offset: 0x00111864
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			object @lock = this._lock;
			bool result;
			lock (@lock)
			{
				result = this._container.Remove(key);
			}
			return result;
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x001136BC File Offset: 0x001118BC
		public void Clear()
		{
			object @lock = this._lock;
			lock (@lock)
			{
				if (this._activeEnumeratorRefCount > 0)
				{
					this._container.RemoveAllKeys();
				}
				else
				{
					this._container = new ConditionalWeakTable<TKey, TValue>.Container(this);
				}
			}
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x0011371C File Offset: 0x0011191C
		public TValue GetValue(TKey key, [Nullable(new byte[]
		{
			1,
			0,
			0
		})] ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			ArgumentNullException.ThrowIfNull(createValueCallback, "createValueCallback");
			TValue result;
			if (!this.TryGetValue(key, out result))
			{
				return this.GetValueLocked(key, createValueCallback);
			}
			return result;
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x0011374C File Offset: 0x0011194C
		private TValue GetValueLocked(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			TValue tvalue = createValueCallback(key);
			object @lock = this._lock;
			TValue result;
			lock (@lock)
			{
				TValue tvalue2;
				if (this._container.TryGetValueWorker(key, out tvalue2))
				{
					result = tvalue2;
				}
				else
				{
					this.CreateEntry(key, tvalue);
					result = tvalue;
				}
			}
			return result;
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x001137B4 File Offset: 0x001119B4
		public TValue GetOrCreateValue(TKey key)
		{
			return this.GetValue(key, (TKey _) => Activator.CreateInstance<TValue>());
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x001137DC File Offset: 0x001119DC
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			object @lock = this._lock;
			IEnumerator<KeyValuePair<TKey, TValue>> enumerator;
			lock (@lock)
			{
				ConditionalWeakTable<TKey, TValue>.Container container = this._container;
				IEnumerator<KeyValuePair<TKey, TValue>> enumerator2;
				if (container != null && container.FirstFreeEntry != 0)
				{
					enumerator = new ConditionalWeakTable<TKey, TValue>.Enumerator(this);
					enumerator2 = enumerator;
				}
				else
				{
					enumerator = GenericEmptyEnumerator<KeyValuePair<TKey, TValue>>.Instance;
					enumerator2 = enumerator;
				}
				enumerator = enumerator2;
			}
			return enumerator;
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x00113840 File Offset: 0x00111A40
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x00113848 File Offset: 0x00111A48
		private void CreateEntry(TKey key, TValue value)
		{
			ConditionalWeakTable<TKey, TValue>.Container container = this._container;
			if (!container.HasCapacity)
			{
				container = (this._container = container.Resize());
			}
			container.CreateEntryNoResize(key, value);
		}

		// Token: 0x0400148C RID: 5260
		private readonly object _lock;

		// Token: 0x0400148D RID: 5261
		private volatile ConditionalWeakTable<TKey, TValue>.Container _container;

		// Token: 0x0400148E RID: 5262
		private int _activeEnumeratorRefCount;

		// Token: 0x02000680 RID: 1664
		// (Invoke) Token: 0x060073A5 RID: 29605
		[NullableContext(0)]
		public delegate TValue CreateValueCallback(TKey key);

		// Token: 0x02000681 RID: 1665
		private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
		{
			// Token: 0x060073A8 RID: 29608 RVA: 0x0011387E File Offset: 0x00111A7E
			public Enumerator(ConditionalWeakTable<TKey, TValue> table)
			{
				this._table = table;
				table._activeEnumeratorRefCount++;
				this._maxIndexInclusive = table._container.FirstFreeEntry - 1;
				this._currentIndex = -1;
			}

			// Token: 0x060073A9 RID: 29609 RVA: 0x001138B8 File Offset: 0x00111AB8
			~Enumerator()
			{
				this.Dispose();
			}

			// Token: 0x060073AA RID: 29610 RVA: 0x001138E4 File Offset: 0x00111AE4
			public void Dispose()
			{
				ConditionalWeakTable<TKey, TValue> conditionalWeakTable = Interlocked.Exchange<ConditionalWeakTable<TKey, TValue>>(ref this._table, null);
				if (conditionalWeakTable != null)
				{
					this._current = default(KeyValuePair<TKey, TValue>);
					object @lock = conditionalWeakTable._lock;
					lock (@lock)
					{
						conditionalWeakTable._activeEnumeratorRefCount--;
					}
					GC.SuppressFinalize(this);
				}
			}

			// Token: 0x060073AB RID: 29611 RVA: 0x00113950 File Offset: 0x00111B50
			public bool MoveNext()
			{
				ConditionalWeakTable<TKey, TValue> table = this._table;
				if (table != null)
				{
					object @lock = table._lock;
					lock (@lock)
					{
						ConditionalWeakTable<TKey, TValue>.Container container = table._container;
						if (container != null)
						{
							while (this._currentIndex < this._maxIndexInclusive)
							{
								this._currentIndex++;
								TKey key;
								TValue value;
								if (container.TryGetEntry(this._currentIndex, out key, out value))
								{
									this._current = new KeyValuePair<TKey, TValue>(key, value);
									return true;
								}
							}
						}
					}
					return false;
				}
				return false;
			}

			// Token: 0x17000E2F RID: 3631
			// (get) Token: 0x060073AC RID: 29612 RVA: 0x001139E8 File Offset: 0x00111BE8
			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					if (this._currentIndex < 0)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current;
				}
			}

			// Token: 0x17000E30 RID: 3632
			// (get) Token: 0x060073AD RID: 29613 RVA: 0x001139FE File Offset: 0x00111BFE
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060073AE RID: 29614 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public void Reset()
			{
			}

			// Token: 0x0400148F RID: 5263
			private ConditionalWeakTable<TKey, TValue> _table;

			// Token: 0x04001490 RID: 5264
			private readonly int _maxIndexInclusive;

			// Token: 0x04001491 RID: 5265
			private int _currentIndex;

			// Token: 0x04001492 RID: 5266
			private KeyValuePair<TKey, TValue> _current;
		}

		// Token: 0x02000682 RID: 1666
		private struct Entry
		{
			// Token: 0x04001493 RID: 5267
			public DependentHandle depHnd;

			// Token: 0x04001494 RID: 5268
			public int HashCode;

			// Token: 0x04001495 RID: 5269
			public int Next;
		}

		// Token: 0x02000683 RID: 1667
		private sealed class Container
		{
			// Token: 0x060073AF RID: 29615 RVA: 0x00113A0C File Offset: 0x00111C0C
			internal Container(ConditionalWeakTable<TKey, TValue> parent)
			{
				this._buckets = new int[8];
				for (int i = 0; i < this._buckets.Length; i++)
				{
					this._buckets[i] = -1;
				}
				this._entries = new ConditionalWeakTable<TKey, TValue>.Entry[8];
				this._parent = parent;
			}

			// Token: 0x060073B0 RID: 29616 RVA: 0x00113A5A File Offset: 0x00111C5A
			private Container(ConditionalWeakTable<TKey, TValue> parent, int[] buckets, ConditionalWeakTable<TKey, TValue>.Entry[] entries, int firstFreeEntry)
			{
				this._parent = parent;
				this._buckets = buckets;
				this._entries = entries;
				this._firstFreeEntry = firstFreeEntry;
			}

			// Token: 0x17000E31 RID: 3633
			// (get) Token: 0x060073B1 RID: 29617 RVA: 0x00113A7F File Offset: 0x00111C7F
			internal bool HasCapacity
			{
				get
				{
					return this._firstFreeEntry < this._entries.Length;
				}
			}

			// Token: 0x17000E32 RID: 3634
			// (get) Token: 0x060073B2 RID: 29618 RVA: 0x00113A91 File Offset: 0x00111C91
			internal int FirstFreeEntry
			{
				get
				{
					return this._firstFreeEntry;
				}
			}

			// Token: 0x060073B3 RID: 29619 RVA: 0x00113A9C File Offset: 0x00111C9C
			internal void CreateEntryNoResize(TKey key, TValue value)
			{
				this.VerifyIntegrity();
				this._invalid = true;
				int num = RuntimeHelpers.GetHashCode(key) & int.MaxValue;
				int firstFreeEntry = this._firstFreeEntry;
				this._firstFreeEntry = firstFreeEntry + 1;
				int num2 = firstFreeEntry;
				this._entries[num2].HashCode = num;
				this._entries[num2].depHnd = new DependentHandle(key, value);
				int num3 = num & this._buckets.Length - 1;
				this._entries[num2].Next = this._buckets[num3];
				Volatile.Write(ref this._buckets[num3], num2);
				this._invalid = false;
			}

			// Token: 0x060073B4 RID: 29620 RVA: 0x00113B50 File Offset: 0x00111D50
			internal bool TryGetValueWorker(TKey key, [MaybeNullWhen(false)] out TValue value)
			{
				object o;
				int num = this.FindEntry(key, out o);
				value = Unsafe.As<TValue>(o);
				return num != -1;
			}

			// Token: 0x060073B5 RID: 29621 RVA: 0x00113B78 File Offset: 0x00111D78
			internal int FindEntry(TKey key, out object value)
			{
				int num = RuntimeHelpers.TryGetHashCode(key);
				if (num == 0)
				{
					value = null;
					return -1;
				}
				num &= int.MaxValue;
				int num2 = num & this._buckets.Length - 1;
				for (int num3 = Volatile.Read(ref this._buckets[num2]); num3 != -1; num3 = this._entries[num3].Next)
				{
					if (this._entries[num3].HashCode == num && this._entries[num3].depHnd.UnsafeGetTargetAndDependent(out value) == key)
					{
						GC.KeepAlive(this);
						return num3;
					}
				}
				GC.KeepAlive(this);
				value = null;
				return -1;
			}

			// Token: 0x060073B6 RID: 29622 RVA: 0x00113C20 File Offset: 0x00111E20
			internal bool TryGetEntry(int index, [NotNullWhen(true)] out TKey key, [MaybeNullWhen(false)] out TValue value)
			{
				if (index < this._entries.Length)
				{
					object o;
					object obj = this._entries[index].depHnd.UnsafeGetTargetAndDependent(out o);
					GC.KeepAlive(this);
					if (obj != null)
					{
						key = Unsafe.As<TKey>(obj);
						value = Unsafe.As<TValue>(o);
						return true;
					}
				}
				key = default(TKey);
				value = default(TValue);
				return false;
			}

			// Token: 0x060073B7 RID: 29623 RVA: 0x00113C84 File Offset: 0x00111E84
			internal void RemoveAllKeys()
			{
				for (int i = 0; i < this._firstFreeEntry; i++)
				{
					this.RemoveIndex(i);
				}
			}

			// Token: 0x060073B8 RID: 29624 RVA: 0x00113CAC File Offset: 0x00111EAC
			internal bool Remove(TKey key)
			{
				this.VerifyIntegrity();
				object obj;
				int num = this.FindEntry(key, out obj);
				if (num != -1)
				{
					this.RemoveIndex(num);
					return true;
				}
				return false;
			}

			// Token: 0x060073B9 RID: 29625 RVA: 0x00113CD7 File Offset: 0x00111ED7
			private void RemoveIndex(int entryIndex)
			{
				ConditionalWeakTable<TKey, TValue>.Entry[] entries = this._entries;
				Volatile.Write(ref entries[entryIndex].HashCode, -1);
				entries[entryIndex].depHnd.UnsafeSetTargetToNull();
			}

			// Token: 0x060073BA RID: 29626 RVA: 0x00113CFB File Offset: 0x00111EFB
			internal void UpdateValue(int entryIndex, TValue newValue)
			{
				this.VerifyIntegrity();
				this._invalid = true;
				this._entries[entryIndex].depHnd.UnsafeSetDependent(newValue);
				this._invalid = false;
			}

			// Token: 0x060073BB RID: 29627 RVA: 0x00113D30 File Offset: 0x00111F30
			internal ConditionalWeakTable<TKey, TValue>.Container Resize()
			{
				bool flag = false;
				int newSize = this._buckets.Length;
				if (this._parent == null || this._parent._activeEnumeratorRefCount == 0)
				{
					for (int i = 0; i < this._entries.Length; i++)
					{
						ref ConditionalWeakTable<TKey, TValue>.Entry ptr = ref this._entries[i];
						if (ptr.HashCode == -1)
						{
							flag = true;
							break;
						}
						if (ptr.depHnd.IsAllocated && ptr.depHnd.UnsafeGetTarget() == null)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					newSize = this._buckets.Length * 2;
				}
				return this.Resize(newSize);
			}

			// Token: 0x060073BC RID: 29628 RVA: 0x00113DC0 File Offset: 0x00111FC0
			internal ConditionalWeakTable<TKey, TValue>.Container Resize(int newSize)
			{
				int[] array = new int[newSize];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = -1;
				}
				ConditionalWeakTable<TKey, TValue>.Entry[] array2 = new ConditionalWeakTable<TKey, TValue>.Entry[newSize];
				int j = 0;
				bool flag = this._parent != null && this._parent._activeEnumeratorRefCount > 0;
				if (flag)
				{
					while (j < this._entries.Length)
					{
						ref ConditionalWeakTable<TKey, TValue>.Entry ptr = ref this._entries[j];
						ConditionalWeakTable<TKey, TValue>.Entry[] array3 = array2;
						int num = j;
						int hashCode = ptr.HashCode;
						array3[num].HashCode = hashCode;
						array3[num].depHnd = ptr.depHnd;
						int num2 = hashCode & array.Length - 1;
						array3[num].Next = array[num2];
						array[num2] = j;
						j++;
					}
				}
				else
				{
					for (int k = 0; k < this._entries.Length; k++)
					{
						ref ConditionalWeakTable<TKey, TValue>.Entry ptr2 = ref this._entries[k];
						int hashCode2 = ptr2.HashCode;
						DependentHandle depHnd = ptr2.depHnd;
						if (hashCode2 != -1 && depHnd.IsAllocated)
						{
							if (depHnd.UnsafeGetTarget() != null)
							{
								ConditionalWeakTable<TKey, TValue>.Entry[] array4 = array2;
								int num3 = j;
								array4[num3].HashCode = hashCode2;
								array4[num3].depHnd = depHnd;
								int num4 = hashCode2 & array.Length - 1;
								array4[num3].Next = array[num4];
								array[num4] = j;
								j++;
							}
							else
							{
								Volatile.Write(ref ptr2.HashCode, -1);
							}
						}
					}
				}
				ConditionalWeakTable<TKey, TValue>.Container container = new ConditionalWeakTable<TKey, TValue>.Container(this._parent, array, array2, j);
				if (flag)
				{
					GC.SuppressFinalize(this);
				}
				this._oldKeepAlive = container;
				GC.KeepAlive(this);
				return container;
			}

			// Token: 0x060073BD RID: 29629 RVA: 0x00113F34 File Offset: 0x00112134
			private void VerifyIntegrity()
			{
				if (this._invalid)
				{
					throw new InvalidOperationException(SR.InvalidOperation_CollectionCorrupted);
				}
			}

			// Token: 0x060073BE RID: 29630 RVA: 0x00113F4C File Offset: 0x0011214C
			protected override void Finalize()
			{
				try
				{
					if (!this._invalid && this._parent != null)
					{
						if (!this._finalized)
						{
							this._finalized = true;
							object @lock = this._parent._lock;
							lock (@lock)
							{
								if (this._parent._container == this)
								{
									this._parent._container = null;
								}
							}
							GC.ReRegisterForFinalize(this);
						}
						else
						{
							ConditionalWeakTable<TKey, TValue>.Entry[] entries = this._entries;
							this._invalid = true;
							this._entries = null;
							this._buckets = null;
							if (entries != null)
							{
								for (int i = 0; i < entries.Length; i++)
								{
									if (this._oldKeepAlive == null || entries[i].HashCode == -1)
									{
										entries[i].depHnd.Dispose();
									}
								}
							}
						}
					}
				}
				finally
				{
					base.Finalize();
				}
			}

			// Token: 0x04001496 RID: 5270
			private readonly ConditionalWeakTable<TKey, TValue> _parent;

			// Token: 0x04001497 RID: 5271
			private int[] _buckets;

			// Token: 0x04001498 RID: 5272
			private ConditionalWeakTable<TKey, TValue>.Entry[] _entries;

			// Token: 0x04001499 RID: 5273
			private int _firstFreeEntry;

			// Token: 0x0400149A RID: 5274
			private bool _invalid;

			// Token: 0x0400149B RID: 5275
			private bool _finalized;

			// Token: 0x0400149C RID: 5276
			private volatile object _oldKeepAlive;
		}
	}
}
