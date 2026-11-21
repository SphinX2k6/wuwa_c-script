using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x0200054B RID: 1355
	internal readonly struct Vector512DebugView<T>
	{
		// Token: 0x06004EC6 RID: 20166 RVA: 0x00100ED1 File Offset: 0x000FF0D1
		public Vector512DebugView(Vector512<T> value)
		{
			this._value = value;
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06004EC7 RID: 20167 RVA: 0x00100EDA File Offset: 0x000FF0DA
		public byte[] ByteView
		{
			get
			{
				byte[] array = new byte[Vector512<byte>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(ref array[0], this._value);
				return array;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x00100EF8 File Offset: 0x000FF0F8
		public double[] DoubleView
		{
			get
			{
				double[] array = new double[Vector512<double>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<double, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06004EC9 RID: 20169 RVA: 0x00100F1B File Offset: 0x000FF11B
		public short[] Int16View
		{
			get
			{
				short[] array = new short[Vector512<short>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<short, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06004ECA RID: 20170 RVA: 0x00100F3E File Offset: 0x000FF13E
		public int[] Int32View
		{
			get
			{
				int[] array = new int[Vector512<int>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<int, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06004ECB RID: 20171 RVA: 0x00100F61 File Offset: 0x000FF161
		public long[] Int64View
		{
			get
			{
				long[] array = new long[Vector512<long>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<long, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06004ECC RID: 20172 RVA: 0x00100F84 File Offset: 0x000FF184
		public IntPtr[] NIntView
		{
			get
			{
				IntPtr[] array = new IntPtr[Vector512<IntPtr>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<IntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x00100FA7 File Offset: 0x000FF1A7
		public UIntPtr[] NUIntView
		{
			get
			{
				UIntPtr[] array = new UIntPtr[Vector512<UIntPtr>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<UIntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x00100FCA File Offset: 0x000FF1CA
		public sbyte[] SByteView
		{
			get
			{
				sbyte[] array = new sbyte[Vector512<sbyte>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<sbyte, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06004ECF RID: 20175 RVA: 0x00100FED File Offset: 0x000FF1ED
		public float[] SingleView
		{
			get
			{
				float[] array = new float[Vector512<float>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<float, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x00101010 File Offset: 0x000FF210
		public ushort[] UInt16View
		{
			get
			{
				ushort[] array = new ushort[Vector512<ushort>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<ushort, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06004ED1 RID: 20177 RVA: 0x00101033 File Offset: 0x000FF233
		public uint[] UInt32View
		{
			get
			{
				uint[] array = new uint[Vector512<uint>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<uint, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x00101056 File Offset: 0x000FF256
		public ulong[] UInt64View
		{
			get
			{
				ulong[] array = new ulong[Vector512<ulong>.Count];
				Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<ulong, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x040011C8 RID: 4552
		private readonly Vector512<T> _value;
	}
}
