using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000548 RID: 1352
	internal readonly struct Vector256DebugView<T>
	{
		// Token: 0x06004D30 RID: 19760 RVA: 0x000FDF5D File Offset: 0x000FC15D
		public Vector256DebugView(Vector256<T> value)
		{
			this._value = value;
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06004D31 RID: 19761 RVA: 0x000FDF66 File Offset: 0x000FC166
		public byte[] ByteView
		{
			get
			{
				byte[] array = new byte[Vector256<byte>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(ref array[0], this._value);
				return array;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06004D32 RID: 19762 RVA: 0x000FDF84 File Offset: 0x000FC184
		public double[] DoubleView
		{
			get
			{
				double[] array = new double[Vector256<double>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<double, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06004D33 RID: 19763 RVA: 0x000FDFA7 File Offset: 0x000FC1A7
		public short[] Int16View
		{
			get
			{
				short[] array = new short[Vector256<short>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<short, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x000FDFCA File Offset: 0x000FC1CA
		public int[] Int32View
		{
			get
			{
				int[] array = new int[Vector256<int>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<int, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06004D35 RID: 19765 RVA: 0x000FDFED File Offset: 0x000FC1ED
		public long[] Int64View
		{
			get
			{
				long[] array = new long[Vector256<long>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<long, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x000FE010 File Offset: 0x000FC210
		public IntPtr[] NIntView
		{
			get
			{
				IntPtr[] array = new IntPtr[Vector256<IntPtr>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<IntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x000FE033 File Offset: 0x000FC233
		public UIntPtr[] NUIntView
		{
			get
			{
				UIntPtr[] array = new UIntPtr[Vector256<UIntPtr>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<UIntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x000FE056 File Offset: 0x000FC256
		public sbyte[] SByteView
		{
			get
			{
				sbyte[] array = new sbyte[Vector256<sbyte>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<sbyte, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x000FE079 File Offset: 0x000FC279
		public float[] SingleView
		{
			get
			{
				float[] array = new float[Vector256<float>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<float, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x000FE09C File Offset: 0x000FC29C
		public ushort[] UInt16View
		{
			get
			{
				ushort[] array = new ushort[Vector256<ushort>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<ushort, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06004D3B RID: 19771 RVA: 0x000FE0BF File Offset: 0x000FC2BF
		public uint[] UInt32View
		{
			get
			{
				uint[] array = new uint[Vector256<uint>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<uint, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06004D3C RID: 19772 RVA: 0x000FE0E2 File Offset: 0x000FC2E2
		public ulong[] UInt64View
		{
			get
			{
				ulong[] array = new ulong[Vector256<ulong>.Count];
				Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<ulong, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x040011C5 RID: 4549
		private readonly Vector256<T> _value;
	}
}
