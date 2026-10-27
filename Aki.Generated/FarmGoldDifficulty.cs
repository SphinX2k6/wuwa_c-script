using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5B RID: 3163
	public struct FarmGoldDifficulty : IFlatbufferObject
	{
		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x0022AF8D File Offset: 0x0022918D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x0022AF9A File Offset: 0x0022919A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x0022AFA4 File Offset: 0x002291A4
		public static FarmGoldDifficulty GetRootAsFarmGoldDifficulty(ByteBuffer _bb)
		{
			return FarmGoldDifficulty.GetRootAsFarmGoldDifficulty(_bb, default(FarmGoldDifficulty));
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x0022AFC0 File Offset: 0x002291C0
		public static FarmGoldDifficulty GetRootAsFarmGoldDifficulty(ByteBuffer _bb, FarmGoldDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x0022AFDD File Offset: 0x002291DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x0022AFEC File Offset: 0x002291EC
		public FarmGoldDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x0022AFFC File Offset: 0x002291FC
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

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06006C9E RID: 27806 RVA: 0x0022B038 File Offset: 0x00229238
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

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x0022B074 File Offset: 0x00229274
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

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06006CA0 RID: 27808 RVA: 0x0022B0B0 File Offset: 0x002292B0
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

		// Token: 0x06006CA1 RID: 27809 RVA: 0x0022B0E8 File Offset: 0x002292E8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x0022B0F8 File Offset: 0x002292F8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CA6 RID: 19622
		private Table __p;
	}
}
