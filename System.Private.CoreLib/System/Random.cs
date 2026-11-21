using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000193 RID: 403
	[NullableContext(1)]
	[Nullable(0)]
	public class Random
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x000558D0 File Offset: 0x00053AD0
		public Random()
		{
			this._impl = ((base.GetType() == typeof(Random)) ? new Random.XoshiroImpl() : new Random.Net5CompatDerivedImpl(this));
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00055902 File Offset: 0x00053B02
		public Random(int Seed)
		{
			this._impl = ((base.GetType() == typeof(Random)) ? new Random.Net5CompatSeedImpl(Seed) : new Random.Net5CompatDerivedImpl(this, Seed));
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00055936 File Offset: 0x00053B36
		private protected Random(bool isThreadSafeRandom)
		{
			this._impl = null;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00055945 File Offset: 0x00053B45
		public static Random Shared { get; } = new Random.ThreadSafeRandom();

		// Token: 0x06001A20 RID: 6688 RVA: 0x0005594C File Offset: 0x00053B4C
		public virtual int Next()
		{
			return this._impl.Next();
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00055959 File Offset: 0x00053B59
		public virtual int Next(int maxValue)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(maxValue, "maxValue");
			return this._impl.Next(maxValue);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00055972 File Offset: 0x00053B72
		public virtual int Next(int minValue, int maxValue)
		{
			if (minValue > maxValue)
			{
				Random.ThrowMinMaxValueSwapped();
			}
			return this._impl.Next(minValue, maxValue);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0005598A File Offset: 0x00053B8A
		public virtual long NextInt64()
		{
			return this._impl.NextInt64();
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00055997 File Offset: 0x00053B97
		public virtual long NextInt64(long maxValue)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<long>(maxValue, "maxValue");
			return this._impl.NextInt64(maxValue);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000559B0 File Offset: 0x00053BB0
		public virtual long NextInt64(long minValue, long maxValue)
		{
			if (minValue > maxValue)
			{
				Random.ThrowMinMaxValueSwapped();
			}
			return this._impl.NextInt64(minValue, maxValue);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000559C8 File Offset: 0x00053BC8
		public virtual float NextSingle()
		{
			return this._impl.NextSingle();
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000559D5 File Offset: 0x00053BD5
		public virtual double NextDouble()
		{
			return this._impl.NextDouble();
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000559E2 File Offset: 0x00053BE2
		public virtual void NextBytes(byte[] buffer)
		{
			if (buffer == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.buffer);
			}
			this._impl.NextBytes(buffer);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000559FA File Offset: 0x00053BFA
		[NullableContext(0)]
		public virtual void NextBytes(Span<byte> buffer)
		{
			this._impl.NextBytes(buffer);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00055A08 File Offset: 0x00053C08
		[NullableContext(2)]
		public unsafe void GetItems<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> choices, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (choices.IsEmpty)
			{
				throw new ArgumentException(SR.Arg_EmptySpan, "choices");
			}
			Random.ImplBase impl = this._impl;
			if ((impl == null || impl.GetType() == typeof(Random.XoshiroImpl)) && BitOperations.IsPow2(choices.Length) && choices.Length <= 256)
			{
				Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)512], 512);
				while (!destination.IsEmpty)
				{
					if (destination.Length < buffer.Length)
					{
						buffer = buffer.Slice(0, destination.Length);
					}
					this.NextBytes(buffer);
					int num = choices.Length - 1;
					for (int i = 0; i < buffer.Length; i++)
					{
						*destination[i] = *choices[(int)(*buffer[i]) & num];
					}
					destination = destination.Slice(buffer.Length);
				}
				return;
			}
			for (int j = 0; j < destination.Length; j++)
			{
				*destination[j] = *choices[this.Next(choices.Length)];
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00055B47 File Offset: 0x00053D47
		public T[] GetItems<[Nullable(2)] T>(T[] choices, int length)
		{
			ArgumentNullException.ThrowIfNull(choices, "choices");
			return this.GetItems<T>(new ReadOnlySpan<T>(choices), length);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00055B64 File Offset: 0x00053D64
		public T[] GetItems<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> choices, int length)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			T[] array = new T[length];
			this.GetItems<T>(choices, array.AsSpan<T>());
			return array;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00055B91 File Offset: 0x00053D91
		public void Shuffle<[Nullable(2)] T>(T[] values)
		{
			ArgumentNullException.ThrowIfNull(values, "values");
			this.Shuffle<T>(new Span<T>(MemoryMarshal.GetArrayDataReference<T>(values), values.Length));
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00055BB4 File Offset: 0x00053DB4
		[NullableContext(2)]
		public unsafe void Shuffle<T>([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> values)
		{
			int length = values.Length;
			for (int i = 0; i < length - 1; i++)
			{
				int num = this.Next(i, length);
				if (num != i)
				{
					T t = *values[i];
					*values[i] = *values[num];
					*values[num] = t;
				}
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00055C1A File Offset: 0x00053E1A
		protected virtual double Sample()
		{
			return this._impl.Sample();
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00055C27 File Offset: 0x00053E27
		private static void ThrowMinMaxValueSwapped()
		{
			throw new ArgumentOutOfRangeException("minValue", SR.Format(SR.Argument_MinMaxValue, "minValue", "maxValue"));
		}

		// Token: 0x04000549 RID: 1353
		private readonly Random.ImplBase _impl;

		// Token: 0x02000194 RID: 404
		private sealed class ThreadSafeRandom : Random
		{
			// Token: 0x06001A32 RID: 6706 RVA: 0x00055C53 File Offset: 0x00053E53
			public ThreadSafeRandom() : base(true)
			{
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00055C5C File Offset: 0x00053E5C
			private static Random.XoshiroImpl LocalRandom
			{
				get
				{
					return Random.ThreadSafeRandom.t_random ?? Random.ThreadSafeRandom.Create();
				}
			}

			// Token: 0x06001A34 RID: 6708 RVA: 0x00055C6C File Offset: 0x00053E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static Random.XoshiroImpl Create()
			{
				return Random.ThreadSafeRandom.t_random = new Random.XoshiroImpl();
			}

			// Token: 0x06001A35 RID: 6709 RVA: 0x00055C79 File Offset: 0x00053E79
			public override int Next()
			{
				return Random.ThreadSafeRandom.LocalRandom.Next();
			}

			// Token: 0x06001A36 RID: 6710 RVA: 0x00055C85 File Offset: 0x00053E85
			public override int Next(int maxValue)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(maxValue, "maxValue");
				return Random.ThreadSafeRandom.LocalRandom.Next(maxValue);
			}

			// Token: 0x06001A37 RID: 6711 RVA: 0x00055C9D File Offset: 0x00053E9D
			public override int Next(int minValue, int maxValue)
			{
				if (minValue > maxValue)
				{
					Random.ThrowMinMaxValueSwapped();
				}
				return Random.ThreadSafeRandom.LocalRandom.Next(minValue, maxValue);
			}

			// Token: 0x06001A38 RID: 6712 RVA: 0x00055CB4 File Offset: 0x00053EB4
			public override long NextInt64()
			{
				return Random.ThreadSafeRandom.LocalRandom.NextInt64();
			}

			// Token: 0x06001A39 RID: 6713 RVA: 0x00055CC0 File Offset: 0x00053EC0
			public override long NextInt64(long maxValue)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<long>(maxValue, "maxValue");
				return Random.ThreadSafeRandom.LocalRandom.NextInt64(maxValue);
			}

			// Token: 0x06001A3A RID: 6714 RVA: 0x00055CD8 File Offset: 0x00053ED8
			public override long NextInt64(long minValue, long maxValue)
			{
				if (minValue > maxValue)
				{
					Random.ThrowMinMaxValueSwapped();
				}
				return Random.ThreadSafeRandom.LocalRandom.NextInt64(minValue, maxValue);
			}

			// Token: 0x06001A3B RID: 6715 RVA: 0x00055CEF File Offset: 0x00053EEF
			public override float NextSingle()
			{
				return Random.ThreadSafeRandom.LocalRandom.NextSingle();
			}

			// Token: 0x06001A3C RID: 6716 RVA: 0x00055CFB File Offset: 0x00053EFB
			public override double NextDouble()
			{
				return Random.ThreadSafeRandom.LocalRandom.NextDouble();
			}

			// Token: 0x06001A3D RID: 6717 RVA: 0x00055D07 File Offset: 0x00053F07
			public override void NextBytes(byte[] buffer)
			{
				if (buffer == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.buffer);
				}
				Random.ThreadSafeRandom.LocalRandom.NextBytes(buffer);
			}

			// Token: 0x06001A3E RID: 6718 RVA: 0x00055D1E File Offset: 0x00053F1E
			public override void NextBytes(Span<byte> buffer)
			{
				Random.ThreadSafeRandom.LocalRandom.NextBytes(buffer);
			}

			// Token: 0x06001A3F RID: 6719 RVA: 0x0001A563 File Offset: 0x00018763
			protected override double Sample()
			{
				throw new NotSupportedException();
			}

			// Token: 0x0400054B RID: 1355
			[ThreadStatic]
			private static Random.XoshiroImpl t_random;
		}

		// Token: 0x02000195 RID: 405
		internal abstract class ImplBase
		{
			// Token: 0x06001A40 RID: 6720
			public abstract double Sample();

			// Token: 0x06001A41 RID: 6721
			public abstract int Next();

			// Token: 0x06001A42 RID: 6722
			public abstract int Next(int maxValue);

			// Token: 0x06001A43 RID: 6723
			public abstract int Next(int minValue, int maxValue);

			// Token: 0x06001A44 RID: 6724
			public abstract long NextInt64();

			// Token: 0x06001A45 RID: 6725
			public abstract long NextInt64(long maxValue);

			// Token: 0x06001A46 RID: 6726
			public abstract long NextInt64(long minValue, long maxValue);

			// Token: 0x06001A47 RID: 6727
			public abstract float NextSingle();

			// Token: 0x06001A48 RID: 6728
			public abstract double NextDouble();

			// Token: 0x06001A49 RID: 6729
			public abstract void NextBytes(byte[] buffer);

			// Token: 0x06001A4A RID: 6730
			public abstract void NextBytes(Span<byte> buffer);

			// Token: 0x06001A4B RID: 6731 RVA: 0x00055D2C File Offset: 0x00053F2C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static uint NextUInt32(uint maxValue, Random.XoshiroImpl xoshiro)
			{
				ulong num = (ulong)maxValue * (ulong)xoshiro.NextUInt32();
				uint num2 = (uint)num;
				if (num2 < maxValue)
				{
					uint num3 = (0U - maxValue) % maxValue;
					while (num2 < num3)
					{
						num = (ulong)maxValue * (ulong)xoshiro.NextUInt32();
						num2 = (uint)num;
					}
				}
				return (uint)(num >> 32);
			}

			// Token: 0x06001A4C RID: 6732 RVA: 0x00055D6C File Offset: 0x00053F6C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static ulong NextUInt64(ulong maxValue, Random.XoshiroImpl xoshiro)
			{
				ulong num;
				ulong result = Math.BigMul(maxValue, xoshiro.NextUInt64(), out num);
				if (num < maxValue)
				{
					ulong num2 = (0UL - maxValue) % maxValue;
					while (num < num2)
					{
						result = Math.BigMul(maxValue, xoshiro.NextUInt64(), out num);
					}
				}
				return result;
			}
		}

		// Token: 0x02000196 RID: 406
		private sealed class Net5CompatSeedImpl : Random.ImplBase
		{
			// Token: 0x06001A4E RID: 6734 RVA: 0x00055DA9 File Offset: 0x00053FA9
			public Net5CompatSeedImpl(int seed)
			{
				this._prng.EnsureInitialized(seed);
			}

			// Token: 0x06001A4F RID: 6735 RVA: 0x00055DBD File Offset: 0x00053FBD
			public override double Sample()
			{
				return this._prng.Sample();
			}

			// Token: 0x06001A50 RID: 6736 RVA: 0x00055DCA File Offset: 0x00053FCA
			public override int Next()
			{
				return this._prng.InternalSample();
			}

			// Token: 0x06001A51 RID: 6737 RVA: 0x00055DD7 File Offset: 0x00053FD7
			public override int Next(int maxValue)
			{
				return (int)(this._prng.Sample() * (double)maxValue);
			}

			// Token: 0x06001A52 RID: 6738 RVA: 0x00055DE8 File Offset: 0x00053FE8
			public override int Next(int minValue, int maxValue)
			{
				long num = (long)maxValue - (long)minValue;
				if (num > 2147483647L)
				{
					return (int)((long)(this._prng.GetSampleForLargeRange() * (double)num) + (long)minValue);
				}
				return (int)(this._prng.Sample() * (double)num) + minValue;
			}

			// Token: 0x06001A53 RID: 6739 RVA: 0x00055E2C File Offset: 0x0005402C
			public override long NextInt64()
			{
				ulong num;
				do
				{
					num = this.NextUInt64() >> 1;
				}
				while (num == 9223372036854775807UL);
				return (long)num;
			}

			// Token: 0x06001A54 RID: 6740 RVA: 0x00055E4F File Offset: 0x0005404F
			public override long NextInt64(long maxValue)
			{
				return this.NextInt64(0L, maxValue);
			}

			// Token: 0x06001A55 RID: 6741 RVA: 0x00055E5C File Offset: 0x0005405C
			public override long NextInt64(long minValue, long maxValue)
			{
				ulong num = (ulong)(maxValue - minValue);
				if (num > 1UL)
				{
					int num2 = BitOperations.Log2Ceiling(num);
					ulong num3;
					do
					{
						num3 = this.NextUInt64() >> 64 - num2;
					}
					while (num3 >= num);
					return (long)(num3 + (ulong)minValue);
				}
				return minValue;
			}

			// Token: 0x06001A56 RID: 6742 RVA: 0x00055E91 File Offset: 0x00054091
			private ulong NextUInt64()
			{
				return (ulong)this.Next(4194304) | (ulong)this.Next(4194304) << 22 | (ulong)this.Next(1048576) << 44;
			}

			// Token: 0x06001A57 RID: 6743 RVA: 0x00055DBD File Offset: 0x00053FBD
			public override double NextDouble()
			{
				return this._prng.Sample();
			}

			// Token: 0x06001A58 RID: 6744 RVA: 0x00055EC0 File Offset: 0x000540C0
			public override float NextSingle()
			{
				float num;
				do
				{
					num = (float)this._prng.Sample();
				}
				while (num >= 1f);
				return num;
			}

			// Token: 0x06001A59 RID: 6745 RVA: 0x00055EE3 File Offset: 0x000540E3
			public override void NextBytes(byte[] buffer)
			{
				this._prng.NextBytes(buffer);
			}

			// Token: 0x06001A5A RID: 6746 RVA: 0x00055EF6 File Offset: 0x000540F6
			public override void NextBytes(Span<byte> buffer)
			{
				this._prng.NextBytes(buffer);
			}

			// Token: 0x0400054C RID: 1356
			private Random.CompatPrng _prng;
		}

		// Token: 0x02000197 RID: 407
		private sealed class Net5CompatDerivedImpl : Random.ImplBase
		{
			// Token: 0x06001A5B RID: 6747 RVA: 0x00055F04 File Offset: 0x00054104
			public Net5CompatDerivedImpl(Random parent) : this(parent, Random.Shared.Next())
			{
			}

			// Token: 0x06001A5C RID: 6748 RVA: 0x00055F17 File Offset: 0x00054117
			public Net5CompatDerivedImpl(Random parent, int seed)
			{
				this._parent = parent;
				this._seed = seed;
			}

			// Token: 0x06001A5D RID: 6749 RVA: 0x00055F2D File Offset: 0x0005412D
			public override double Sample()
			{
				this._prng.EnsureInitialized(this._seed);
				return this._prng.Sample();
			}

			// Token: 0x06001A5E RID: 6750 RVA: 0x00055F4B File Offset: 0x0005414B
			public override int Next()
			{
				this._prng.EnsureInitialized(this._seed);
				return this._prng.InternalSample();
			}

			// Token: 0x06001A5F RID: 6751 RVA: 0x00055F69 File Offset: 0x00054169
			public override int Next(int maxValue)
			{
				this._prng.EnsureInitialized(this._seed);
				return (int)(this._parent.Sample() * (double)maxValue);
			}

			// Token: 0x06001A60 RID: 6752 RVA: 0x00055F8C File Offset: 0x0005418C
			public override int Next(int minValue, int maxValue)
			{
				this._prng.EnsureInitialized(this._seed);
				long num = (long)maxValue - (long)minValue;
				if (num > 2147483647L)
				{
					return (int)((long)(this._prng.GetSampleForLargeRange() * (double)num) + (long)minValue);
				}
				return (int)(this._parent.Sample() * (double)num) + minValue;
			}

			// Token: 0x06001A61 RID: 6753 RVA: 0x00055FE0 File Offset: 0x000541E0
			public override long NextInt64()
			{
				this._prng.EnsureInitialized(this._seed);
				ulong num;
				do
				{
					num = this.NextUInt64() >> 1;
				}
				while (num == 9223372036854775807UL);
				return (long)num;
			}

			// Token: 0x06001A62 RID: 6754 RVA: 0x00055E4F File Offset: 0x0005404F
			public override long NextInt64(long maxValue)
			{
				return this.NextInt64(0L, maxValue);
			}

			// Token: 0x06001A63 RID: 6755 RVA: 0x00056014 File Offset: 0x00054214
			public override long NextInt64(long minValue, long maxValue)
			{
				ulong num = (ulong)(maxValue - minValue);
				if (num > 1UL)
				{
					this._prng.EnsureInitialized(this._seed);
					int num2 = BitOperations.Log2Ceiling(num);
					ulong num3;
					do
					{
						num3 = this.NextUInt64() >> 64 - num2;
					}
					while (num3 >= num);
					return (long)(num3 + (ulong)minValue);
				}
				return minValue;
			}

			// Token: 0x06001A64 RID: 6756 RVA: 0x0005605A File Offset: 0x0005425A
			private ulong NextUInt64()
			{
				return (ulong)this._parent.Next(4194304) | (ulong)this._parent.Next(4194304) << 22 | (ulong)this._parent.Next(1048576) << 44;
			}

			// Token: 0x06001A65 RID: 6757 RVA: 0x00056097 File Offset: 0x00054297
			public override double NextDouble()
			{
				this._prng.EnsureInitialized(this._seed);
				return this._parent.Sample();
			}

			// Token: 0x06001A66 RID: 6758 RVA: 0x000560B8 File Offset: 0x000542B8
			public override float NextSingle()
			{
				this._prng.EnsureInitialized(this._seed);
				float num;
				do
				{
					num = (float)this._parent.Sample();
				}
				while (num >= 1f);
				return num;
			}

			// Token: 0x06001A67 RID: 6759 RVA: 0x000560EC File Offset: 0x000542EC
			public override void NextBytes(byte[] buffer)
			{
				this._prng.EnsureInitialized(this._seed);
				this._prng.NextBytes(buffer);
			}

			// Token: 0x06001A68 RID: 6760 RVA: 0x00056110 File Offset: 0x00054310
			public unsafe override void NextBytes(Span<byte> buffer)
			{
				this._prng.EnsureInitialized(this._seed);
				for (int i = 0; i < buffer.Length; i++)
				{
					*buffer[i] = (byte)this._parent.Next();
				}
			}

			// Token: 0x0400054D RID: 1357
			private readonly Random _parent;

			// Token: 0x0400054E RID: 1358
			private readonly int _seed;

			// Token: 0x0400054F RID: 1359
			private Random.CompatPrng _prng;
		}

		// Token: 0x02000198 RID: 408
		private struct CompatPrng
		{
			// Token: 0x06001A69 RID: 6761 RVA: 0x00056155 File Offset: 0x00054355
			[MemberNotNull("_seedArray")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void EnsureInitialized(int seed)
			{
				if (this._seedArray == null)
				{
					this.Initialize(seed);
				}
			}

			// Token: 0x06001A6A RID: 6762 RVA: 0x00056168 File Offset: 0x00054368
			[MemberNotNull("_seedArray")]
			private void Initialize(int seed)
			{
				int[] array = new int[56];
				int num = (seed == int.MinValue) ? int.MaxValue : Math.Abs(seed);
				int num2 = 161803398 - num;
				array[55] = num2;
				int num3 = 1;
				int num4 = 0;
				for (int i = 1; i < 55; i++)
				{
					if ((num4 += 21) >= 55)
					{
						num4 -= 55;
					}
					array[num4] = num3;
					num3 = num2 - num3;
					if (num3 < 0)
					{
						num3 += int.MaxValue;
					}
					num2 = array[num4];
				}
				for (int j = 1; j < 5; j++)
				{
					for (int k = 1; k < 56; k++)
					{
						int num5 = k + 30;
						if (num5 >= 55)
						{
							num5 -= 55;
						}
						array[k] -= array[1 + num5];
						if (array[k] < 0)
						{
							array[k] += int.MaxValue;
						}
					}
				}
				this._seedArray = array;
				this._inext = 0;
				this._inextp = 21;
			}

			// Token: 0x06001A6B RID: 6763 RVA: 0x00056258 File Offset: 0x00054458
			internal double Sample()
			{
				return (double)this.InternalSample() * 4.656612875245797E-10;
			}

			// Token: 0x06001A6C RID: 6764 RVA: 0x0005626C File Offset: 0x0005446C
			internal unsafe void NextBytes(Span<byte> buffer)
			{
				for (int i = 0; i < buffer.Length; i++)
				{
					*buffer[i] = (byte)this.InternalSample();
				}
			}

			// Token: 0x06001A6D RID: 6765 RVA: 0x0005629C File Offset: 0x0005449C
			internal int InternalSample()
			{
				int num = this._inext;
				if (++num >= 56)
				{
					num = 1;
				}
				int num2 = this._inextp;
				if (++num2 >= 56)
				{
					num2 = 1;
				}
				int[] seedArray = this._seedArray;
				int num3 = seedArray[num] - seedArray[num2];
				if (num3 == 2147483647)
				{
					num3--;
				}
				if (num3 < 0)
				{
					num3 += int.MaxValue;
				}
				seedArray[num] = num3;
				this._inext = num;
				this._inextp = num2;
				return num3;
			}

			// Token: 0x06001A6E RID: 6766 RVA: 0x00056308 File Offset: 0x00054508
			internal double GetSampleForLargeRange()
			{
				int num = this.InternalSample();
				if (this.InternalSample() % 2 == 0)
				{
					num = -num;
				}
				return ((double)num + 2147483646.0) / 4294967293.0;
			}

			// Token: 0x04000550 RID: 1360
			private int[] _seedArray;

			// Token: 0x04000551 RID: 1361
			private int _inext;

			// Token: 0x04000552 RID: 1362
			private int _inextp;
		}

		// Token: 0x02000199 RID: 409
		internal sealed class XoshiroImpl : Random.ImplBase
		{
			// Token: 0x06001A6F RID: 6767 RVA: 0x00056340 File Offset: 0x00054540
			public unsafe XoshiroImpl()
			{
				ulong* ptr = stackalloc ulong[(UIntPtr)32];
				do
				{
					Interop.GetRandomBytes((byte*)ptr, 32);
					this._s0 = *ptr;
					this._s1 = ptr[1];
					this._s2 = ptr[2];
					this._s3 = ptr[3];
				}
				while ((this._s0 | this._s1 | this._s2 | this._s3) == 0UL);
			}

			// Token: 0x06001A70 RID: 6768 RVA: 0x000563AA File Offset: 0x000545AA
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal uint NextUInt32()
			{
				return (uint)(this.NextUInt64() >> 32);
			}

			// Token: 0x06001A71 RID: 6769 RVA: 0x000563B8 File Offset: 0x000545B8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal ulong NextUInt64()
			{
				ulong num = this._s0;
				ulong num2 = this._s1;
				ulong num3 = this._s2;
				ulong num4 = this._s3;
				ulong result = BitOperations.RotateLeft(num2 * 5UL, 7) * 9UL;
				ulong num5 = num2 << 17;
				num3 ^= num;
				num4 ^= num2;
				num2 ^= num3;
				num ^= num4;
				num3 ^= num5;
				num4 = BitOperations.RotateLeft(num4, 45);
				this._s0 = num;
				this._s1 = num2;
				this._s2 = num3;
				this._s3 = num4;
				return result;
			}

			// Token: 0x06001A72 RID: 6770 RVA: 0x00056430 File Offset: 0x00054630
			public override int Next()
			{
				ulong num;
				do
				{
					num = this.NextUInt64() >> 33;
				}
				while (num == 2147483647UL);
				return (int)num;
			}

			// Token: 0x06001A73 RID: 6771 RVA: 0x00056452 File Offset: 0x00054652
			public override int Next(int maxValue)
			{
				return (int)Random.ImplBase.NextUInt32((uint)maxValue, this);
			}

			// Token: 0x06001A74 RID: 6772 RVA: 0x0005645B File Offset: 0x0005465B
			public override int Next(int minValue, int maxValue)
			{
				return (int)(Random.ImplBase.NextUInt32((uint)(maxValue - minValue), this) + (uint)minValue);
			}

			// Token: 0x06001A75 RID: 6773 RVA: 0x00056468 File Offset: 0x00054668
			public override long NextInt64()
			{
				ulong num;
				do
				{
					num = this.NextUInt64() >> 1;
				}
				while (num == 9223372036854775807UL);
				return (long)num;
			}

			// Token: 0x06001A76 RID: 6774 RVA: 0x0005648B File Offset: 0x0005468B
			public override long NextInt64(long maxValue)
			{
				return (long)Random.ImplBase.NextUInt64((ulong)maxValue, this);
			}

			// Token: 0x06001A77 RID: 6775 RVA: 0x00056494 File Offset: 0x00054694
			public override long NextInt64(long minValue, long maxValue)
			{
				return (long)(Random.ImplBase.NextUInt64((ulong)(maxValue - minValue), this) + (ulong)minValue);
			}

			// Token: 0x06001A78 RID: 6776 RVA: 0x000564A1 File Offset: 0x000546A1
			public override void NextBytes(byte[] buffer)
			{
				this.NextBytes(buffer);
			}

			// Token: 0x06001A79 RID: 6777 RVA: 0x000564B0 File Offset: 0x000546B0
			public unsafe override void NextBytes(Span<byte> buffer)
			{
				ulong num = this._s0;
				ulong num2 = this._s1;
				ulong num3 = this._s2;
				ulong num4 = this._s3;
				while (buffer.Length >= 8)
				{
					Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(buffer), BitOperations.RotateLeft(num2 * 5UL, 7) * 9UL);
					ulong num5 = num2 << 17;
					num3 ^= num;
					num4 ^= num2;
					num2 ^= num3;
					num ^= num4;
					num3 ^= num5;
					num4 = BitOperations.RotateLeft(num4, 45);
					buffer = buffer.Slice(8);
				}
				if (!buffer.IsEmpty)
				{
					ulong num6 = BitOperations.RotateLeft(num2 * 5UL, 7) * 9UL;
					byte* ptr = (byte*)(&num6);
					for (int i = 0; i < buffer.Length; i++)
					{
						*buffer[i] = ptr[i];
					}
					ulong num7 = num2 << 17;
					num3 ^= num;
					num4 ^= num2;
					num2 ^= num3;
					num ^= num4;
					num3 ^= num7;
					num4 = BitOperations.RotateLeft(num4, 45);
				}
				this._s0 = num;
				this._s1 = num2;
				this._s2 = num3;
				this._s3 = num4;
			}

			// Token: 0x06001A7A RID: 6778 RVA: 0x000565B0 File Offset: 0x000547B0
			public override double NextDouble()
			{
				return (this.NextUInt64() >> 11) * 1.1102230246251565E-16;
			}

			// Token: 0x06001A7B RID: 6779 RVA: 0x000565C7 File Offset: 0x000547C7
			public override float NextSingle()
			{
				return (this.NextUInt64() >> 40) * 5.9604645E-08f;
			}

			// Token: 0x06001A7C RID: 6780 RVA: 0x0001A563 File Offset: 0x00018763
			public override double Sample()
			{
				throw new NotSupportedException();
			}

			// Token: 0x04000553 RID: 1363
			private ulong _s0;

			// Token: 0x04000554 RID: 1364
			private ulong _s1;

			// Token: 0x04000555 RID: 1365
			private ulong _s2;

			// Token: 0x04000556 RID: 1366
			private ulong _s3;
		}
	}
}
