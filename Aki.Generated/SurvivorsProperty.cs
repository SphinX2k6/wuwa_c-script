using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001101 RID: 4353
	public struct SurvivorsProperty : IFlatbufferObject
	{
		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600DAED RID: 56045 RVA: 0x00324E20 File Offset: 0x00323020
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DAEE RID: 56046 RVA: 0x00324E2D File Offset: 0x0032302D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DAEF RID: 56047 RVA: 0x00324E34 File Offset: 0x00323034
		public static SurvivorsProperty GetRootAsSurvivorsProperty(ByteBuffer _bb)
		{
			return SurvivorsProperty.GetRootAsSurvivorsProperty(_bb, default(SurvivorsProperty));
		}

		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00324E50 File Offset: 0x00323050
		public static SurvivorsProperty GetRootAsSurvivorsProperty(ByteBuffer _bb, SurvivorsProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DAF1 RID: 56049 RVA: 0x00324E6D File Offset: 0x0032306D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DAF2 RID: 56050 RVA: 0x00324E7C File Offset: 0x0032307C
		public SurvivorsProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600DAF3 RID: 56051 RVA: 0x00324E8C File Offset: 0x0032308C
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

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600DAF4 RID: 56052 RVA: 0x00324EC8 File Offset: 0x003230C8
		public string Key
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

		// Token: 0x0600DAF5 RID: 56053 RVA: 0x00324EFF File Offset: 0x003230FF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DAF6 RID: 56054 RVA: 0x00324F0E File Offset: 0x0032310E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600DAF7 RID: 56055 RVA: 0x00324F28 File Offset: 0x00323128
		public string Name
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

		// Token: 0x0600DAF8 RID: 56056 RVA: 0x00324F5F File Offset: 0x0032315F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x00324F6E File Offset: 0x0032316E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600DAFA RID: 56058 RVA: 0x00324F88 File Offset: 0x00323188
		public bool IsBasePermyriad
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600DAFB RID: 56059 RVA: 0x00324FC8 File Offset: 0x003231C8
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600DAFC RID: 56060 RVA: 0x00325008 File Offset: 0x00323208
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600DAFD RID: 56061 RVA: 0x00325048 File Offset: 0x00323248
		public int Priority
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

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600DAFE RID: 56062 RVA: 0x00325088 File Offset: 0x00323288
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DAFF RID: 56063 RVA: 0x003250C0 File Offset: 0x003232C0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DB00 RID: 56064 RVA: 0x003250D0 File Offset: 0x003232D0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005239 RID: 21049
		private Table __p;
	}
}
