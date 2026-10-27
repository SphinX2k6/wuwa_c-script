using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC9 RID: 3273
	public struct FoleySynthBoneConfig : IFlatbufferObject
	{
		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x0600761A RID: 30234 RVA: 0x002415B1 File Offset: 0x0023F7B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x002415BE File Offset: 0x0023F7BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x002415C8 File Offset: 0x0023F7C8
		public static FoleySynthBoneConfig GetRootAsFoleySynthBoneConfig(ByteBuffer _bb)
		{
			return FoleySynthBoneConfig.GetRootAsFoleySynthBoneConfig(_bb, default(FoleySynthBoneConfig));
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x002415E4 File Offset: 0x0023F7E4
		public static FoleySynthBoneConfig GetRootAsFoleySynthBoneConfig(ByteBuffer _bb, FoleySynthBoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00241601 File Offset: 0x0023F801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00241610 File Offset: 0x0023F810
		public FoleySynthBoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06007620 RID: 30240 RVA: 0x00241620 File Offset: 0x0023F820
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

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06007621 RID: 30241 RVA: 0x0024165C File Offset: 0x0023F85C
		public string Name
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

		// Token: 0x06007622 RID: 30242 RVA: 0x00241693 File Offset: 0x0023F893
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x002416A2 File Offset: 0x0023F8A2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06007624 RID: 30244 RVA: 0x002416BC File Offset: 0x0023F8BC
		public string BoneName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x002416F3 File Offset: 0x0023F8F3
		public Span<byte> GetBoneNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00241702 File Offset: 0x0023F902
		public byte[] GetBoneNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06007627 RID: 30247 RVA: 0x0024171C File Offset: 0x0023F91C
		public float Model1Ceil
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06007628 RID: 30248 RVA: 0x00241760 File Offset: 0x0023F960
		public string Model1CeilEventPath
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

		// Token: 0x06007629 RID: 30249 RVA: 0x00241798 File Offset: 0x0023F998
		public Span<byte> GetModel1CeilEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x002417A8 File Offset: 0x0023F9A8
		public byte[] GetModel1CeilEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x0600762B RID: 30251 RVA: 0x002417C0 File Offset: 0x0023F9C0
		public float Model1Floor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x0600762C RID: 30252 RVA: 0x00241804 File Offset: 0x0023FA04
		public string Model1FloorEventPath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x0024183C File Offset: 0x0023FA3C
		public Span<byte> GetModel1FloorEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x0024184C File Offset: 0x0023FA4C
		public byte[] GetModel1FloorEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x0600762F RID: 30255 RVA: 0x00241864 File Offset: 0x0023FA64
		public float Model1CeilInterpolation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x002418A8 File Offset: 0x0023FAA8
		public float Model1FloorInterpolation
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06007631 RID: 30257 RVA: 0x002418EC File Offset: 0x0023FAEC
		public string Model1RtpcPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00241924 File Offset: 0x0023FB24
		public Span<byte> GetModel1RtpcPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00241934 File Offset: 0x0023FB34
		public byte[] GetModel1RtpcPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06007634 RID: 30260 RVA: 0x0024194C File Offset: 0x0023FB4C
		public float Model2Ceil
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06007635 RID: 30261 RVA: 0x00241990 File Offset: 0x0023FB90
		public string Model2CeilEventPath
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x002419C8 File Offset: 0x0023FBC8
		public Span<byte> GetModel2CeilEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x002419D8 File Offset: 0x0023FBD8
		public byte[] GetModel2CeilEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x002419F0 File Offset: 0x0023FBF0
		public float Model2Floor
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06007639 RID: 30265 RVA: 0x00241A34 File Offset: 0x0023FC34
		public string Model2FloorPath
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00241A6C File Offset: 0x0023FC6C
		public Span<byte> GetModel2FloorPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00241A7C File Offset: 0x0023FC7C
		public byte[] GetModel2FloorPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x00241A94 File Offset: 0x0023FC94
		public float Model2FloorPrecent
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x0600763D RID: 30269 RVA: 0x00241AD8 File Offset: 0x0023FCD8
		public string Model2RptcVelocityMax
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00241B10 File Offset: 0x0023FD10
		public Span<byte> GetModel2RptcVelocityMaxBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00241B20 File Offset: 0x0023FD20
		public byte[] GetModel2RptcVelocityMaxArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06007640 RID: 30272 RVA: 0x00241B38 File Offset: 0x0023FD38
		public string Model2RptcAccelerationMax
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00241B70 File Offset: 0x0023FD70
		public Span<byte> GetModel2RptcAccelerationMaxBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00241B80 File Offset: 0x0023FD80
		public byte[] GetModel2RptcAccelerationMaxArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06007643 RID: 30275 RVA: 0x00241B98 File Offset: 0x0023FD98
		public string Model2RptcVelocityDuring
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00241BD0 File Offset: 0x0023FDD0
		public Span<byte> GetModel2RptcVelocityDuringBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00241BE0 File Offset: 0x0023FDE0
		public byte[] GetModel2RptcVelocityDuringArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06007646 RID: 30278 RVA: 0x00241BF8 File Offset: 0x0023FDF8
		public float Model2CeilInterpolation
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06007647 RID: 30279 RVA: 0x00241C3C File Offset: 0x0023FE3C
		public float Model2FloorInterpolation
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D39 RID: 19769
		private Table __p;
	}
}
