using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC7 RID: 3271
	public struct FogBlock : IFlatbufferObject
	{
		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x060075E5 RID: 30181 RVA: 0x00240EB1 File Offset: 0x0023F0B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x00240EBE File Offset: 0x0023F0BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x00240EC8 File Offset: 0x0023F0C8
		public static FogBlock GetRootAsFogBlock(ByteBuffer _bb)
		{
			return FogBlock.GetRootAsFogBlock(_bb, default(FogBlock));
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00240EE4 File Offset: 0x0023F0E4
		public static FogBlock GetRootAsFogBlock(ByteBuffer _bb, FogBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00240F01 File Offset: 0x0023F101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00240F10 File Offset: 0x0023F110
		public FogBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x060075EB RID: 30187 RVA: 0x00240F20 File Offset: 0x0023F120
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00240F57 File Offset: 0x0023F157
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00240F66 File Offset: 0x0023F166
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x060075EE RID: 30190 RVA: 0x00240F80 File Offset: 0x0023F180
		public string Block
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00240FB7 File Offset: 0x0023F1B7
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00240FC6 File Offset: 0x0023F1C6
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x060075F1 RID: 30193 RVA: 0x00240FE0 File Offset: 0x0023F1E0
		public int MapId
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

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x060075F2 RID: 30194 RVA: 0x0024101C File Offset: 0x0023F21C
		public int R
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

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x0024105C File Offset: 0x0023F25C
		public int G
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x060075F4 RID: 30196 RVA: 0x0024109C File Offset: 0x0023F29C
		public int B
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060075F5 RID: 30197 RVA: 0x002410DC File Offset: 0x0023F2DC
		public int Alpha
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D37 RID: 19767
		private Table __p;
	}
}
