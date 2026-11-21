using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001137 RID: 4407
	public struct RoleInfluence : IFlatbufferObject
	{
		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600CF02 RID: 52994 RVA: 0x00316765 File Offset: 0x00314965
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF03 RID: 52995 RVA: 0x00316772 File Offset: 0x00314972
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x0031677C File Offset: 0x0031497C
		public static RoleInfluence GetRootAsRoleInfluence(ByteBuffer _bb)
		{
			return RoleInfluence.GetRootAsRoleInfluence(_bb, default(RoleInfluence));
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x00316798 File Offset: 0x00314998
		public static RoleInfluence GetRootAsRoleInfluence(ByteBuffer _bb, RoleInfluence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF06 RID: 52998 RVA: 0x003167B5 File Offset: 0x003149B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x003167C4 File Offset: 0x003149C4
		public RoleInfluence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600CF08 RID: 53000 RVA: 0x003167D4 File Offset: 0x003149D4
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

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600CF09 RID: 53001 RVA: 0x00316810 File Offset: 0x00314A10
		public string Title
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

		// Token: 0x0600CF0A RID: 53002 RVA: 0x00316847 File Offset: 0x00314A47
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CF0B RID: 53003 RVA: 0x00316856 File Offset: 0x00314A56
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600CF0C RID: 53004 RVA: 0x00316870 File Offset: 0x00314A70
		public string BackGround
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

		// Token: 0x0600CF0D RID: 53005 RVA: 0x003168A7 File Offset: 0x00314AA7
		public Span<byte> GetBackGroundBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CF0E RID: 53006 RVA: 0x003168B6 File Offset: 0x00314AB6
		public byte[] GetBackGroundArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600CF0F RID: 53007 RVA: 0x003168D0 File Offset: 0x00314AD0
		public int InfluenceId
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

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600CF10 RID: 53008 RVA: 0x00316910 File Offset: 0x00314B10
		public int CountryId
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

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600CF11 RID: 53009 RVA: 0x00316950 File Offset: 0x00314B50
		public string FilterIcon
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

		// Token: 0x0600CF12 RID: 53010 RVA: 0x00316988 File Offset: 0x00314B88
		public Span<byte> GetFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CF13 RID: 53011 RVA: 0x00316998 File Offset: 0x00314B98
		public byte[] GetFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600CF14 RID: 53012 RVA: 0x003169B0 File Offset: 0x00314BB0
		public IntArray? Role
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IntArray?(default(IntArray).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04005735 RID: 22325
		private Table __p;
	}
}
