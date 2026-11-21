using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAC RID: 2988
	public struct AdventureRole : IFlatbufferObject
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x001EDBD9 File Offset: 0x001EBDD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x001EDBE6 File Offset: 0x001EBDE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x001EDBF0 File Offset: 0x001EBDF0
		public static AdventureRole GetRootAsAdventureRole(ByteBuffer _bb)
		{
			return AdventureRole.GetRootAsAdventureRole(_bb, default(AdventureRole));
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x001EDC0C File Offset: 0x001EBE0C
		public static AdventureRole GetRootAsAdventureRole(ByteBuffer _bb, AdventureRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x001EDC29 File Offset: 0x001EBE29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x001EDC38 File Offset: 0x001EBE38
		public AdventureRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06004995 RID: 18837 RVA: 0x001EDC48 File Offset: 0x001EBE48
		public int RoleId
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06004996 RID: 18838 RVA: 0x001EDC84 File Offset: 0x001EBE84
		public string DesText
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

		// Token: 0x06004997 RID: 18839 RVA: 0x001EDCBB File Offset: 0x001EBEBB
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x001EDCCA File Offset: 0x001EBECA
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x001EDCE4 File Offset: 0x001EBEE4
		public string HeadCard
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

		// Token: 0x0600499A RID: 18842 RVA: 0x001EDD1B File Offset: 0x001EBF1B
		public Span<byte> GetHeadCardBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x001EDD2A File Offset: 0x001EBF2A
		public byte[] GetHeadCardArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600499C RID: 18844 RVA: 0x001EDD44 File Offset: 0x001EBF44
		public int TrialRoleId
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

		// Token: 0x04005089 RID: 20617
		private Table __p;
	}
}
