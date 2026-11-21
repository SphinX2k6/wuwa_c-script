using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001151 RID: 4433
	public struct RoleTowerParam : IFlatbufferObject
	{
		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600D273 RID: 53875 RVA: 0x0031EA6D File Offset: 0x0031CC6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D274 RID: 53876 RVA: 0x0031EA7A File Offset: 0x0031CC7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D275 RID: 53877 RVA: 0x0031EA84 File Offset: 0x0031CC84
		public static RoleTowerParam GetRootAsRoleTowerParam(ByteBuffer _bb)
		{
			return RoleTowerParam.GetRootAsRoleTowerParam(_bb, default(RoleTowerParam));
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x0031EAA0 File Offset: 0x0031CCA0
		public static RoleTowerParam GetRootAsRoleTowerParam(ByteBuffer _bb, RoleTowerParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x0031EABD File Offset: 0x0031CCBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x0031EACC File Offset: 0x0031CCCC
		public RoleTowerParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600D279 RID: 53881 RVA: 0x0031EADC File Offset: 0x0031CCDC
		public int ActivityId
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

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600D27A RID: 53882 RVA: 0x0031EB18 File Offset: 0x0031CD18
		public int InitTeamLevel
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

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600D27B RID: 53883 RVA: 0x0031EB54 File Offset: 0x0031CD54
		public int InitPhantomLevel
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

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600D27C RID: 53884 RVA: 0x0031EB90 File Offset: 0x0031CD90
		public int InitPhantomExp
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

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600D27D RID: 53885 RVA: 0x0031EBD0 File Offset: 0x0031CDD0
		public int MaxRankDisplay
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

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600D27E RID: 53886 RVA: 0x0031EC10 File Offset: 0x0031CE10
		public string EchoLvHelpTitle
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

		// Token: 0x0600D27F RID: 53887 RVA: 0x0031EC48 File Offset: 0x0031CE48
		public Span<byte> GetEchoLvHelpTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x0031EC58 File Offset: 0x0031CE58
		public byte[] GetEchoLvHelpTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600D281 RID: 53889 RVA: 0x0031EC70 File Offset: 0x0031CE70
		public string EchoLvHelpDesc
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

		// Token: 0x0600D282 RID: 53890 RVA: 0x0031ECA8 File Offset: 0x0031CEA8
		public Span<byte> GetEchoLvHelpDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x0031ECB8 File Offset: 0x0031CEB8
		public byte[] GetEchoLvHelpDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005758 RID: 22360
		private Table __p;
	}
}
