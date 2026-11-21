using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001200 RID: 4608
	public struct SolarSchoolRoleSpine : IFlatbufferObject
	{
		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0600E3AF RID: 58287 RVA: 0x00345F93 File Offset: 0x00344193
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x00345FA0 File Offset: 0x003441A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x00345FA8 File Offset: 0x003441A8
		public static SolarSchoolRoleSpine GetRootAsSolarSchoolRoleSpine(ByteBuffer _bb)
		{
			return SolarSchoolRoleSpine.GetRootAsSolarSchoolRoleSpine(_bb, default(SolarSchoolRoleSpine));
		}

		// Token: 0x0600E3B2 RID: 58290 RVA: 0x00345FC4 File Offset: 0x003441C4
		public static SolarSchoolRoleSpine GetRootAsSolarSchoolRoleSpine(ByteBuffer _bb, SolarSchoolRoleSpine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3B3 RID: 58291 RVA: 0x00345FE1 File Offset: 0x003441E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3B4 RID: 58292 RVA: 0x00345FF0 File Offset: 0x003441F0
		public SolarSchoolRoleSpine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0600E3B5 RID: 58293 RVA: 0x00346000 File Offset: 0x00344200
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

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x0034603C File Offset: 0x0034423C
		public int RoleId
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

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0600E3B7 RID: 58295 RVA: 0x00346078 File Offset: 0x00344278
		public string TextKey
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

		// Token: 0x0600E3B8 RID: 58296 RVA: 0x003460AF File Offset: 0x003442AF
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x003460BE File Offset: 0x003442BE
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x0600E3BA RID: 58298 RVA: 0x003460D8 File Offset: 0x003442D8
		public string AudioId
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

		// Token: 0x0600E3BB RID: 58299 RVA: 0x00346110 File Offset: 0x00344310
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x00346120 File Offset: 0x00344320
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0600E3BD RID: 58301 RVA: 0x00346138 File Offset: 0x00344338
		public int AnimationId
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

		// Token: 0x0400583E RID: 22590
		private Table __p;
	}
}
