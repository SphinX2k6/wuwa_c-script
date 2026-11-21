using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x0200029B RID: 667
	internal readonly struct VectorDebugView<T> where T : struct
	{
		// Token: 0x060032B0 RID: 12976 RVA: 0x000A29FD File Offset: 0x000A0BFD
		public VectorDebugView(Vector<T> value)
		{
			this._value = value;
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x000A2A06 File Offset: 0x000A0C06
		public byte[] ByteView
		{
			get
			{
				byte[] array = new byte[Vector<byte>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(ref array[0], this._value);
				return array;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000A2A24 File Offset: 0x000A0C24
		public double[] DoubleView
		{
			get
			{
				double[] array = new double[Vector<double>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<double, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x000A2A47 File Offset: 0x000A0C47
		public short[] Int16View
		{
			get
			{
				short[] array = new short[Vector<short>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<short, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000A2A6A File Offset: 0x000A0C6A
		public int[] Int32View
		{
			get
			{
				int[] array = new int[Vector<int>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<int, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x000A2A8D File Offset: 0x000A0C8D
		public long[] Int64View
		{
			get
			{
				long[] array = new long[Vector<long>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<long, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000A2AB0 File Offset: 0x000A0CB0
		public IntPtr[] NIntView
		{
			get
			{
				IntPtr[] array = new IntPtr[Vector<IntPtr>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<IntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060032B7 RID: 12983 RVA: 0x000A2AD3 File Offset: 0x000A0CD3
		public UIntPtr[] NUIntView
		{
			get
			{
				UIntPtr[] array = new UIntPtr[Vector<UIntPtr>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<UIntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000A2AF6 File Offset: 0x000A0CF6
		public sbyte[] SByteView
		{
			get
			{
				sbyte[] array = new sbyte[Vector<sbyte>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<sbyte, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x000A2B19 File Offset: 0x000A0D19
		public float[] SingleView
		{
			get
			{
				float[] array = new float[Vector<float>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<float, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000A2B3C File Offset: 0x000A0D3C
		public ushort[] UInt16View
		{
			get
			{
				ushort[] array = new ushort[Vector<ushort>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<ushort, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x000A2B5F File Offset: 0x000A0D5F
		public uint[] UInt32View
		{
			get
			{
				uint[] array = new uint[Vector<uint>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<uint, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x000A2B82 File Offset: 0x000A0D82
		public ulong[] UInt64View
		{
			get
			{
				ulong[] array = new ulong[Vector<ulong>.Count];
				Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<ulong, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x040008F4 RID: 2292
		private readonly Vector<T> _value;
	}
}
