using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200124A RID: 4682
	public struct TakeWeedsDifficulty : IFlatbufferObject
	{
		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600EA08 RID: 59912 RVA: 0x00354515 File Offset: 0x00352715
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA09 RID: 59913 RVA: 0x00354522 File Offset: 0x00352722
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA0A RID: 59914 RVA: 0x0035452C File Offset: 0x0035272C
		public static TakeWeedsDifficulty GetRootAsTakeWeedsDifficulty(ByteBuffer _bb)
		{
			return TakeWeedsDifficulty.GetRootAsTakeWeedsDifficulty(_bb, default(TakeWeedsDifficulty));
		}

		// Token: 0x0600EA0B RID: 59915 RVA: 0x00354548 File Offset: 0x00352748
		public static TakeWeedsDifficulty GetRootAsTakeWeedsDifficulty(ByteBuffer _bb, TakeWeedsDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA0C RID: 59916 RVA: 0x00354565 File Offset: 0x00352765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA0D RID: 59917 RVA: 0x00354574 File Offset: 0x00352774
		public TakeWeedsDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0600EA0E RID: 59918 RVA: 0x00354584 File Offset: 0x00352784
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

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0600EA0F RID: 59919 RVA: 0x003545C0 File Offset: 0x003527C0
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

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0600EA10 RID: 59920 RVA: 0x003545FC File Offset: 0x003527FC
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

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0600EA11 RID: 59921 RVA: 0x00354638 File Offset: 0x00352838
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0600EA12 RID: 59922 RVA: 0x00354678 File Offset: 0x00352878
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EA13 RID: 59923 RVA: 0x003546B0 File Offset: 0x003528B0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EA14 RID: 59924 RVA: 0x003546C0 File Offset: 0x003528C0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005894 RID: 22676
		private Table __p;
	}
}
