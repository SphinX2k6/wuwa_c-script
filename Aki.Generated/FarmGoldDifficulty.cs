using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3F RID: 3391
	public struct FarmGoldDifficulty : IFlatbufferObject
	{
		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x060072A2 RID: 29346 RVA: 0x0024A2DE File Offset: 0x002484DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x0024A2EB File Offset: 0x002484EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x0024A2F4 File Offset: 0x002484F4
		public static FarmGoldDifficulty GetRootAsFarmGoldDifficulty(ByteBuffer _bb)
		{
			return FarmGoldDifficulty.GetRootAsFarmGoldDifficulty(_bb, default(FarmGoldDifficulty));
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x0024A310 File Offset: 0x00248510
		public static FarmGoldDifficulty GetRootAsFarmGoldDifficulty(ByteBuffer _bb, FarmGoldDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x0024A32D File Offset: 0x0024852D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x0024A33C File Offset: 0x0024853C
		public FarmGoldDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x060072A8 RID: 29352 RVA: 0x0024A34C File Offset: 0x0024854C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x060072A9 RID: 29353 RVA: 0x0024A388 File Offset: 0x00248588
		public int Magnification
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x060072AA RID: 29354 RVA: 0x0024A3C4 File Offset: 0x002485C4
		public int RecommendedLevel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x0024A400 File Offset: 0x00248600
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x0024A438 File Offset: 0x00248638
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x0024A448 File Offset: 0x00248648
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400528A RID: 21130
		private Table __p;
	}
}
