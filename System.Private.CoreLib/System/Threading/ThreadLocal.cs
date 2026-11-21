using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x0200041F RID: 1055
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<>))]
	[DebuggerDisplay("IsValueCreated = {IsValueCreated}, Value = {ValueForDebugDisplay}, Count = {ValuesCountForDebugDisplay}")]
	public class ThreadLocal<[Nullable(2)] T> : IDisposable
	{
		// Token: 0x060041B5 RID: 16821 RVA: 0x000DB1C2 File Offset: 0x000D93C2
		public ThreadLocal()
		{
			this.Initialize(null, false);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000DB1DE File Offset: 0x000D93DE
		public ThreadLocal(bool trackAllValues)
		{
			this.Initialize(null, trackAllValues);
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x000DB1FA File Offset: 0x000D93FA
		public ThreadLocal(Func<T> valueFactory)
		{
			ArgumentNullException.ThrowIfNull(valueFactory, "valueFactory");
			this.Initialize(valueFactory, false);
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000DB221 File Offset: 0x000D9421
		public ThreadLocal(Func<T> valueFactory, bool trackAllValues)
		{
			ArgumentNullException.ThrowIfNull(valueFactory, "valueFactory");
			this.Initialize(valueFactory, trackAllValues);
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000DB248 File Offset: 0x000D9448
		private void Initialize(Func<T> valueFactory, bool trackAllValues)
		{
			this._valueFactory = valueFactory;
			this._trackAllValues = trackAllValues;
			this._idComplement = ~ThreadLocal<T>.s_idManager.GetId(trackAllValues);
			this._initialized = true;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x000DB274 File Offset: 0x000D9474
		~ThreadLocal()
		{
			this.Dispose(false);
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x000DB2A4 File Offset: 0x000D94A4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x000DB2B4 File Offset: 0x000D94B4
		protected virtual void Dispose(bool disposing)
		{
			int num;
			using (ThreadLocal<T>.s_idManagerLock.EnterScope())
			{
				num = ~this._idComplement;
				this._idComplement = 0;
				if (num < 0 || !this._initialized)
				{
					return;
				}
				this._initialized = false;
				for (ThreadLocal<T>.LinkedSlot next = this._linkedSlot._next; next != null; next = next._next)
				{
					ThreadLocal<T>.LinkedSlotVolatile[] slotArray = next._slotArray;
					if (slotArray != null)
					{
						next._slotArray = null;
						slotArray[num].Value._value = default(T);
						slotArray[num].Value = null;
					}
				}
			}
			this._linkedSlot = null;
			ThreadLocal<T>.s_idManager.ReturnId(num, this._trackAllValues);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x000DB384 File Offset: 0x000D9584
		[NullableContext(2)]
		public override string ToString()
		{
			T value = this.Value;
			return value.ToString();
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x000DB3A8 File Offset: 0x000D95A8
		// (set) Token: 0x060041BF RID: 16831 RVA: 0x000DB3FC File Offset: 0x000D95FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			[return: MaybeNull]
			get
			{
				ThreadLocal<T>.LinkedSlotVolatile[] array = ThreadLocal<T>.ts_slotArray;
				int num = ~this._idComplement;
				ThreadLocal<T>.LinkedSlot value;
				if (array != null && num >= 0 && num < array.Length && (value = array[num].Value) != null && this._initialized)
				{
					return value._value;
				}
				return this.GetValueSlow();
			}
			set
			{
				ThreadLocal<T>.LinkedSlotVolatile[] array = ThreadLocal<T>.ts_slotArray;
				int num = ~this._idComplement;
				ThreadLocal<T>.LinkedSlot value2;
				if (array != null && num >= 0 && num < array.Length && (value2 = array[num].Value) != null && this._initialized)
				{
					value2._value = value;
					return;
				}
				this.SetValueSlow(value, array);
			}
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x000DB450 File Offset: 0x000D9650
		private T GetValueSlow()
		{
			ObjectDisposedException.ThrowIf(~this._idComplement < 0, this);
			Debugger.NotifyOfCrossThreadDependency();
			T t;
			if (this._valueFactory == null)
			{
				t = default(T);
			}
			else
			{
				t = this._valueFactory();
				if (this.IsValueCreated)
				{
					throw new InvalidOperationException(SR.ThreadLocal_Value_RecursiveCallsToValue);
				}
			}
			this.Value = t;
			return t;
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x000DB4AC File Offset: 0x000D96AC
		private void SetValueSlow(T value, ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
		{
			int num = ~this._idComplement;
			ObjectDisposedException.ThrowIf(num < 0, this);
			if (slotArray == null)
			{
				slotArray = new ThreadLocal<T>.LinkedSlotVolatile[ThreadLocal<T>.GetNewTableSize(num + 1)];
				ThreadLocal<T>.ts_finalizationHelper = new ThreadLocal<T>.FinalizationHelper(slotArray);
				ThreadLocal<T>.ts_slotArray = slotArray;
			}
			if (num >= slotArray.Length)
			{
				ThreadLocal<T>.GrowTable(ref slotArray, num + 1);
				ThreadLocal<T>.ts_finalizationHelper.SlotArray = slotArray;
				ThreadLocal<T>.ts_slotArray = slotArray;
			}
			if (slotArray[num].Value == null)
			{
				this.CreateLinkedSlot(slotArray, num, value);
				return;
			}
			ThreadLocal<T>.LinkedSlot value2 = slotArray[num].Value;
			ObjectDisposedException.ThrowIf(!this._initialized, this);
			value2._value = value;
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x000DB550 File Offset: 0x000D9750
		private void CreateLinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray, int id, T value)
		{
			ThreadLocal<T>.LinkedSlot linkedSlot = new ThreadLocal<T>.LinkedSlot(slotArray);
			using (ThreadLocal<T>.s_idManagerLock.EnterScope())
			{
				ObjectDisposedException.ThrowIf(!this._initialized, this);
				ThreadLocal<T>.LinkedSlot next = this._linkedSlot._next;
				linkedSlot._next = next;
				linkedSlot._previous = this._linkedSlot;
				linkedSlot._value = value;
				if (next != null)
				{
					next._previous = linkedSlot;
				}
				this._linkedSlot._next = linkedSlot;
				slotArray[id].Value = linkedSlot;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x000DB5F0 File Offset: 0x000D97F0
		public IList<T> Values
		{
			get
			{
				if (!this._trackAllValues)
				{
					throw new InvalidOperationException(SR.ThreadLocal_ValuesNotAvailable);
				}
				List<T> valuesAsList = this.GetValuesAsList();
				ObjectDisposedException.ThrowIf(valuesAsList == null, this);
				return valuesAsList;
			}
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x000DB618 File Offset: 0x000D9818
		private List<T> GetValuesAsList()
		{
			ThreadLocal<T>.LinkedSlot linkedSlot = this._linkedSlot;
			if (~this._idComplement == -1 || linkedSlot == null)
			{
				return null;
			}
			List<T> list = new List<T>();
			for (linkedSlot = linkedSlot._next; linkedSlot != null; linkedSlot = linkedSlot._next)
			{
				list.Add(linkedSlot._value);
			}
			return list;
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x000DB668 File Offset: 0x000D9868
		private int ValuesCountForDebugDisplay
		{
			get
			{
				int num = 0;
				ThreadLocal<T>.LinkedSlot linkedSlot = this._linkedSlot;
				for (ThreadLocal<T>.LinkedSlot linkedSlot2 = (linkedSlot != null) ? linkedSlot._next : null; linkedSlot2 != null; linkedSlot2 = linkedSlot2._next)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x000DB6A0 File Offset: 0x000D98A0
		public bool IsValueCreated
		{
			get
			{
				int num = ~this._idComplement;
				ObjectDisposedException.ThrowIf(num < 0, this);
				ThreadLocal<T>.LinkedSlotVolatile[] array = ThreadLocal<T>.ts_slotArray;
				return array != null && num < array.Length && array[num].Value != null;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x000DB6E4 File Offset: 0x000D98E4
		[Nullable(2)]
		internal T ValueForDebugDisplay
		{
			get
			{
				ThreadLocal<T>.LinkedSlotVolatile[] array = ThreadLocal<T>.ts_slotArray;
				int num = ~this._idComplement;
				ThreadLocal<T>.LinkedSlot value;
				if (array == null || num >= array.Length || (value = array[num].Value) == null || !this._initialized)
				{
					return default(T);
				}
				return value._value;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x000DB734 File Offset: 0x000D9934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal List<T> ValuesForDebugDisplay
		{
			get
			{
				return this.GetValuesAsList();
			}
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x000DB73C File Offset: 0x000D993C
		private static void GrowTable(ref ThreadLocal<T>.LinkedSlotVolatile[] table, int minLength)
		{
			ThreadLocal<T>.LinkedSlotVolatile[] array = new ThreadLocal<T>.LinkedSlotVolatile[ThreadLocal<T>.GetNewTableSize(minLength)];
			using (ThreadLocal<T>.s_idManagerLock.EnterScope())
			{
				for (int i = 0; i < table.Length; i++)
				{
					ThreadLocal<T>.LinkedSlot value = table[i].Value;
					if (value != null && value._slotArray != null)
					{
						value._slotArray = array;
						array[i] = table[i];
					}
				}
			}
			table = array;
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x000DB7C4 File Offset: 0x000D99C4
		private static int GetNewTableSize(int minSize)
		{
			if ((ulong)minSize > 2147483591UL)
			{
				return int.MaxValue;
			}
			uint num = BitOperations.RoundUpToPowerOf2((uint)minSize);
			if ((ulong)num > 2147483591UL)
			{
				num = 2147483591U;
			}
			return (int)num;
		}

		// Token: 0x04000E00 RID: 3584
		private Func<T> _valueFactory;

		// Token: 0x04000E01 RID: 3585
		[ThreadStatic]
		private static ThreadLocal<T>.LinkedSlotVolatile[] ts_slotArray;

		// Token: 0x04000E02 RID: 3586
		[ThreadStatic]
		private static ThreadLocal<T>.FinalizationHelper ts_finalizationHelper;

		// Token: 0x04000E03 RID: 3587
		private int _idComplement;

		// Token: 0x04000E04 RID: 3588
		private volatile bool _initialized;

		// Token: 0x04000E05 RID: 3589
		private static readonly ThreadLocal<T>.IdManager s_idManager = new ThreadLocal<T>.IdManager();

		// Token: 0x04000E06 RID: 3590
		private static readonly Lock s_idManagerLock = new Lock();

		// Token: 0x04000E07 RID: 3591
		private ThreadLocal<T>.LinkedSlot _linkedSlot = new ThreadLocal<T>.LinkedSlot(null);

		// Token: 0x04000E08 RID: 3592
		private bool _trackAllValues;

		// Token: 0x02000420 RID: 1056
		private struct LinkedSlotVolatile
		{
			// Token: 0x04000E09 RID: 3593
			internal volatile ThreadLocal<T>.LinkedSlot Value;
		}

		// Token: 0x02000421 RID: 1057
		private sealed class LinkedSlot
		{
			// Token: 0x060041CC RID: 16844 RVA: 0x000DB80F File Offset: 0x000D9A0F
			internal LinkedSlot(ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
			{
				this._slotArray = slotArray;
			}

			// Token: 0x04000E0A RID: 3594
			internal volatile ThreadLocal<T>.LinkedSlot _next;

			// Token: 0x04000E0B RID: 3595
			internal volatile ThreadLocal<T>.LinkedSlot _previous;

			// Token: 0x04000E0C RID: 3596
			internal volatile ThreadLocal<T>.LinkedSlotVolatile[] _slotArray;

			// Token: 0x04000E0D RID: 3597
			internal T _value;
		}

		// Token: 0x02000422 RID: 1058
		private sealed class IdManager
		{
			// Token: 0x060041CD RID: 16845 RVA: 0x000DB820 File Offset: 0x000D9A20
			internal int GetId(bool trackAllValues)
			{
				int result;
				using (this._freeIdsLock.EnterScope())
				{
					int count = this._freeIds.Count;
					int num;
					if (count > 0)
					{
						num = this._freeIds[count - 1];
					}
					else
					{
						num = this._nextIdToTry;
					}
					this._freeIds.EnsureCapacity(this._usedIdToTracksAllValuesMap.Count + 1);
					this._usedIdToTracksAllValuesMap.Add(num, trackAllValues);
					if (count > 0)
					{
						this._freeIds.RemoveAt(count - 1);
					}
					else
					{
						this._nextIdToTry = num + 1;
					}
					if (!trackAllValues)
					{
						this._idsThatDoNotTrackAllValues++;
					}
					result = num;
				}
				return result;
			}

			// Token: 0x060041CE RID: 16846 RVA: 0x000DB8D8 File Offset: 0x000D9AD8
			internal bool IdTracksAllValues(int id)
			{
				bool result;
				using (this._freeIdsLock.EnterScope())
				{
					bool flag;
					result = (this._usedIdToTracksAllValuesMap.TryGetValue(id, out flag) && flag);
				}
				return result;
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x060041CF RID: 16847 RVA: 0x000DB920 File Offset: 0x000D9B20
			internal int IdsThatDoNotTrackValuesCount
			{
				get
				{
					return this._idsThatDoNotTrackAllValues;
				}
			}

			// Token: 0x060041D0 RID: 16848 RVA: 0x000DB92C File Offset: 0x000D9B2C
			internal void ReturnId(int id, bool idTracksAllValues)
			{
				using (this._freeIdsLock.EnterScope())
				{
					if (!idTracksAllValues)
					{
						this._idsThatDoNotTrackAllValues--;
					}
					this._usedIdToTracksAllValuesMap.Remove(id);
					this._freeIds.Add(id);
				}
			}

			// Token: 0x04000E0E RID: 3598
			private int _nextIdToTry;

			// Token: 0x04000E0F RID: 3599
			private volatile int _idsThatDoNotTrackAllValues;

			// Token: 0x04000E10 RID: 3600
			private readonly Dictionary<int, bool> _usedIdToTracksAllValuesMap = new Dictionary<int, bool>();

			// Token: 0x04000E11 RID: 3601
			private readonly List<int> _freeIds = new List<int>();

			// Token: 0x04000E12 RID: 3602
			private readonly Lock _freeIdsLock = new Lock();
		}

		// Token: 0x02000423 RID: 1059
		private sealed class FinalizationHelper
		{
			// Token: 0x060041D2 RID: 16850 RVA: 0x000DB9B9 File Offset: 0x000D9BB9
			internal FinalizationHelper(ThreadLocal<T>.LinkedSlotVolatile[] slotArray)
			{
				this.SlotArray = slotArray;
			}

			// Token: 0x060041D3 RID: 16851 RVA: 0x000DB9C8 File Offset: 0x000D9BC8
			protected override void Finalize()
			{
				try
				{
					ThreadLocal<T>.LinkedSlotVolatile[] slotArray = this.SlotArray;
					int num = ThreadLocal<T>.s_idManager.IdsThatDoNotTrackValuesCount;
					for (int i = 0; i < slotArray.Length; i++)
					{
						ThreadLocal<T>.LinkedSlot value = slotArray[i].Value;
						if (value != null)
						{
							if (num == 0 || ThreadLocal<T>.s_idManager.IdTracksAllValues(i))
							{
								value._slotArray = null;
							}
							else
							{
								using (ThreadLocal<T>.s_idManagerLock.EnterScope())
								{
									if (slotArray[i].Value != null)
									{
										num--;
									}
									if (value._next != null)
									{
										value._next._previous = value._previous;
									}
									value._previous._next = value._next;
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

			// Token: 0x04000E13 RID: 3603
			internal ThreadLocal<T>.LinkedSlotVolatile[] SlotArray;
		}
	}
}
