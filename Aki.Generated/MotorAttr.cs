using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F13 RID: 3859
	public struct MotorAttr : IFlatbufferObject
	{
		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06009CBB RID: 40123 RVA: 0x002A892D File Offset: 0x002A6B2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x002A893A File Offset: 0x002A6B3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x002A8944 File Offset: 0x002A6B44
		public static MotorAttr GetRootAsMotorAttr(ByteBuffer _bb)
		{
			return MotorAttr.GetRootAsMotorAttr(_bb, default(MotorAttr));
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x002A8960 File Offset: 0x002A6B60
		public static MotorAttr GetRootAsMotorAttr(ByteBuffer _bb, MotorAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x002A897D File Offset: 0x002A6B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x002A898C File Offset: 0x002A6B8C
		public MotorAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06009CC1 RID: 40129 RVA: 0x002A899C File Offset: 0x002A6B9C
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

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06009CC2 RID: 40130 RVA: 0x002A89D8 File Offset: 0x002A6BD8
		public string PropertyId
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

		// Token: 0x06009CC3 RID: 40131 RVA: 0x002A8A0F File Offset: 0x002A6C0F
		public Span<byte> GetPropertyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x002A8A1E File Offset: 0x002A6C1E
		public byte[] GetPropertyIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06009CC5 RID: 40133 RVA: 0x002A8A38 File Offset: 0x002A6C38
		public string Icon
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

		// Token: 0x06009CC6 RID: 40134 RVA: 0x002A8A6F File Offset: 0x002A6C6F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x002A8A7E File Offset: 0x002A6C7E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06009CC8 RID: 40136 RVA: 0x002A8A98 File Offset: 0x002A6C98
		public string Name
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

		// Token: 0x06009CC9 RID: 40137 RVA: 0x002A8AD0 File Offset: 0x002A6CD0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x002A8AE0 File Offset: 0x002A6CE0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06009CCB RID: 40139 RVA: 0x002A8AF8 File Offset: 0x002A6CF8
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

		// Token: 0x06009CCC RID: 40140 RVA: 0x002A8B30 File Offset: 0x002A6D30
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x002A8B40 File Offset: 0x002A6D40
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06009CCE RID: 40142 RVA: 0x002A8B58 File Offset: 0x002A6D58
		public int ShowMain
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

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06009CCF RID: 40143 RVA: 0x002A8B98 File Offset: 0x002A6D98
		public int ShowMainOrder
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

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06009CD0 RID: 40144 RVA: 0x002A8BD8 File Offset: 0x002A6DD8
		public int ShowProperty
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06009CD1 RID: 40145 RVA: 0x002A8C18 File Offset: 0x002A6E18
		public int ShowDetailOrder
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x002A8C58 File Offset: 0x002A6E58
		public int SpecialLevelShow
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06009CD3 RID: 40147 RVA: 0x002A8C98 File Offset: 0x002A6E98
		public string Suffix
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x002A8CD0 File Offset: 0x002A6ED0
		public Span<byte> GetSuffixBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009CD5 RID: 40149 RVA: 0x002A8CE0 File Offset: 0x002A6EE0
		public byte[] GetSuffixArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06009CD6 RID: 40150 RVA: 0x002A8CF8 File Offset: 0x002A6EF8
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06009CD7 RID: 40151 RVA: 0x002A8D38 File Offset: 0x002A6F38
		public bool IsNumber
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040054B8 RID: 21688
		private Table __p;
	}
}
