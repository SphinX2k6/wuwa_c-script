using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BB RID: 4283
	public struct RoadBookPhantomGain : IFlatbufferObject
	{
		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600C41F RID: 50207 RVA: 0x002FE9A4 File Offset: 0x002FCBA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C420 RID: 50208 RVA: 0x002FE9B1 File Offset: 0x002FCBB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x002FE9B8 File Offset: 0x002FCBB8
		public static RoadBookPhantomGain GetRootAsRoadBookPhantomGain(ByteBuffer _bb)
		{
			return RoadBookPhantomGain.GetRootAsRoadBookPhantomGain(_bb, default(RoadBookPhantomGain));
		}

		// Token: 0x0600C422 RID: 50210 RVA: 0x002FE9D4 File Offset: 0x002FCBD4
		public static RoadBookPhantomGain GetRootAsRoadBookPhantomGain(ByteBuffer _bb, RoadBookPhantomGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x002FE9F1 File Offset: 0x002FCBF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C424 RID: 50212 RVA: 0x002FEA00 File Offset: 0x002FCC00
		public RoadBookPhantomGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x0600C425 RID: 50213 RVA: 0x002FEA10 File Offset: 0x002FCC10
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

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600C426 RID: 50214 RVA: 0x002FEA4C File Offset: 0x002FCC4C
		public int MonsterInfoId
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

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0600C427 RID: 50215 RVA: 0x002FEA88 File Offset: 0x002FCC88
		public int ActivityId
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

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0600C428 RID: 50216 RVA: 0x002FEAC4 File Offset: 0x002FCCC4
		public int UnLockReward
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

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0600C429 RID: 50217 RVA: 0x002FEB04 File Offset: 0x002FCD04
		public int Sort
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

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x0600C42A RID: 50218 RVA: 0x002FEB44 File Offset: 0x002FCD44
		public string Name
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x002FEB7C File Offset: 0x002FCD7C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C42C RID: 50220 RVA: 0x002FEB8C File Offset: 0x002FCD8C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600C42D RID: 50221 RVA: 0x002FEBA4 File Offset: 0x002FCDA4
		public string TexPhantom
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

		// Token: 0x0600C42E RID: 50222 RVA: 0x002FEBDC File Offset: 0x002FCDDC
		public Span<byte> GetTexPhantomBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C42F RID: 50223 RVA: 0x002FEBEC File Offset: 0x002FCDEC
		public byte[] GetTexPhantomArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005697 RID: 22167
		private Table __p;
	}
}
