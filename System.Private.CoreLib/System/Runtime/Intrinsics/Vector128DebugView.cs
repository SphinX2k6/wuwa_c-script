using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000545 RID: 1349
	internal readonly struct Vector128DebugView<T>
	{
		// Token: 0x06004B99 RID: 19353 RVA: 0x000FB0D1 File Offset: 0x000F92D1
		public Vector128DebugView(Vector128<T> value)
		{
			this._value = value;
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06004B9A RID: 19354 RVA: 0x000FB0DA File Offset: 0x000F92DA
		public byte[] ByteView
		{
			get
			{
				byte[] array = new byte[Vector128<byte>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(ref array[0], this._value);
				return array;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x000FB0F8 File Offset: 0x000F92F8
		public double[] DoubleView
		{
			get
			{
				double[] array = new double[Vector128<double>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<double, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06004B9C RID: 19356 RVA: 0x000FB11B File Offset: 0x000F931B
		public short[] Int16View
		{
			get
			{
				short[] array = new short[Vector128<short>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<short, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x000FB13E File Offset: 0x000F933E
		public int[] Int32View
		{
			get
			{
				int[] array = new int[Vector128<int>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<int, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06004B9E RID: 19358 RVA: 0x000FB161 File Offset: 0x000F9361
		public long[] Int64View
		{
			get
			{
				long[] array = new long[Vector128<long>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<long, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x000FB184 File Offset: 0x000F9384
		public IntPtr[] NIntView
		{
			get
			{
				IntPtr[] array = new IntPtr[Vector128<IntPtr>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<IntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06004BA0 RID: 19360 RVA: 0x000FB1A7 File Offset: 0x000F93A7
		public UIntPtr[] NUIntView
		{
			get
			{
				UIntPtr[] array = new UIntPtr[Vector128<UIntPtr>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<UIntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x000FB1CA File Offset: 0x000F93CA
		public sbyte[] SByteView
		{
			get
			{
				sbyte[] array = new sbyte[Vector128<sbyte>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<sbyte, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06004BA2 RID: 19362 RVA: 0x000FB1ED File Offset: 0x000F93ED
		public float[] SingleView
		{
			get
			{
				float[] array = new float[Vector128<float>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<float, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x000FB210 File Offset: 0x000F9410
		public ushort[] UInt16View
		{
			get
			{
				ushort[] array = new ushort[Vector128<ushort>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<ushort, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x000FB233 File Offset: 0x000F9433
		public uint[] UInt32View
		{
			get
			{
				uint[] array = new uint[Vector128<uint>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<uint, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x000FB256 File Offset: 0x000F9456
		public ulong[] UInt64View
		{
			get
			{
				ulong[] array = new ulong[Vector128<ulong>.Count];
				Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<ulong, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x040011C2 RID: 4546
		private readonly Vector128<T> _value;
	}
}
