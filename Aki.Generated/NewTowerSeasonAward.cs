using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E93 RID: 3731
	public struct NewTowerSeasonAward : IFlatbufferObject
	{
		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x06009FFD RID: 40957 RVA: 0x0029FB4D File Offset: 0x0029DD4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x0029FB5A File Offset: 0x0029DD5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x0029FB64 File Offset: 0x0029DD64
		public static NewTowerSeasonAward GetRootAsNewTowerSeasonAward(ByteBuffer _bb)
		{
			return NewTowerSeasonAward.GetRootAsNewTowerSeasonAward(_bb, default(NewTowerSeasonAward));
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x0029FB80 File Offset: 0x0029DD80
		public static NewTowerSeasonAward GetRootAsNewTowerSeasonAward(ByteBuffer _bb, NewTowerSeasonAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x0029FB9D File Offset: 0x0029DD9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x0029FBAC File Offset: 0x0029DDAC
		public NewTowerSeasonAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x0029FBBC File Offset: 0x0029DDBC
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

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x0600A004 RID: 40964 RVA: 0x0029FBF8 File Offset: 0x0029DDF8
		public int SeasonId
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

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x0600A005 RID: 40965 RVA: 0x0029FC34 File Offset: 0x0029DE34
		public int CycleId
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

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x0600A006 RID: 40966 RVA: 0x0029FC70 File Offset: 0x0029DE70
		public int Index
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

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x0600A007 RID: 40967 RVA: 0x0029FCB0 File Offset: 0x0029DEB0
		public int DropId
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

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x0600A008 RID: 40968 RVA: 0x0029FCF0 File Offset: 0x0029DEF0
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

		// Token: 0x0600A009 RID: 40969 RVA: 0x0029FD28 File Offset: 0x0029DF28
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x0029FD38 File Offset: 0x0029DF38
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x0600A00B RID: 40971 RVA: 0x0029FD50 File Offset: 0x0029DF50
		public string Desc
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

		// Token: 0x0600A00C RID: 40972 RVA: 0x0029FD88 File Offset: 0x0029DF88
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x0029FD98 File Offset: 0x0029DF98
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600A00E RID: 40974 RVA: 0x0029FDB0 File Offset: 0x0029DFB0
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

		// Token: 0x0600A00F RID: 40975 RVA: 0x0029FDE8 File Offset: 0x0029DFE8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x0029FDF8 File Offset: 0x0029DFF8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600A011 RID: 40977 RVA: 0x0029FE10 File Offset: 0x0029E010
		public string ShineIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x0029FE48 File Offset: 0x0029E048
		public Span<byte> GetShineIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x0029FE58 File Offset: 0x0029E058
		public byte[] GetShineIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F46 RID: 20294
		private Table __p;
	}
}
