using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x0200054E RID: 1358
	internal readonly struct Vector64DebugView<T>
	{
		// Token: 0x0600504B RID: 20555 RVA: 0x0010456A File Offset: 0x0010276A
		public Vector64DebugView(Vector64<T> value)
		{
			this._value = value;
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600504C RID: 20556 RVA: 0x00104573 File Offset: 0x00102773
		public byte[] ByteView
		{
			get
			{
				byte[] array = new byte[Vector64<byte>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(ref array[0], this._value);
				return array;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600504D RID: 20557 RVA: 0x00104591 File Offset: 0x00102791
		public double[] DoubleView
		{
			get
			{
				double[] array = new double[Vector64<double>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<double, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600504E RID: 20558 RVA: 0x001045B4 File Offset: 0x001027B4
		public short[] Int16View
		{
			get
			{
				short[] array = new short[Vector64<short>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<short, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600504F RID: 20559 RVA: 0x001045D7 File Offset: 0x001027D7
		public int[] Int32View
		{
			get
			{
				int[] array = new int[Vector64<int>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<int, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x001045FA File Offset: 0x001027FA
		public long[] Int64View
		{
			get
			{
				long[] array = new long[Vector64<long>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<long, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x0010461D File Offset: 0x0010281D
		public IntPtr[] NIntView
		{
			get
			{
				IntPtr[] array = new IntPtr[Vector64<IntPtr>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<IntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x00104640 File Offset: 0x00102840
		public UIntPtr[] NUIntView
		{
			get
			{
				UIntPtr[] array = new UIntPtr[Vector64<UIntPtr>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<UIntPtr, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x00104663 File Offset: 0x00102863
		public sbyte[] SByteView
		{
			get
			{
				sbyte[] array = new sbyte[Vector64<sbyte>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<sbyte, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x00104686 File Offset: 0x00102886
		public float[] SingleView
		{
			get
			{
				float[] array = new float[Vector64<float>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<float, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x001046A9 File Offset: 0x001028A9
		public ushort[] UInt16View
		{
			get
			{
				ushort[] array = new ushort[Vector64<ushort>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<ushort, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x001046CC File Offset: 0x001028CC
		public uint[] UInt32View
		{
			get
			{
				uint[] array = new uint[Vector64<uint>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<uint, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06005057 RID: 20567 RVA: 0x001046EF File Offset: 0x001028EF
		public ulong[] UInt64View
		{
			get
			{
				ulong[] array = new ulong[Vector64<ulong>.Count];
				Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<ulong, byte>(ref array[0]), this._value);
				return array;
			}
		}

		// Token: 0x040011CA RID: 4554
		private readonly Vector64<T> _value;
	}
}
