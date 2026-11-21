using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001201 RID: 4609
	public struct SolarSchoolRoleTalk : IFlatbufferObject
	{
		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x00346175 File Offset: 0x00344375
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3BF RID: 58303 RVA: 0x00346182 File Offset: 0x00344382
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3C0 RID: 58304 RVA: 0x0034618C File Offset: 0x0034438C
		public static SolarSchoolRoleTalk GetRootAsSolarSchoolRoleTalk(ByteBuffer _bb)
		{
			return SolarSchoolRoleTalk.GetRootAsSolarSchoolRoleTalk(_bb, default(SolarSchoolRoleTalk));
		}

		// Token: 0x0600E3C1 RID: 58305 RVA: 0x003461A8 File Offset: 0x003443A8
		public static SolarSchoolRoleTalk GetRootAsSolarSchoolRoleTalk(ByteBuffer _bb, SolarSchoolRoleTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3C2 RID: 58306 RVA: 0x003461C5 File Offset: 0x003443C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x003461D4 File Offset: 0x003443D4
		public SolarSchoolRoleTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0600E3C4 RID: 58308 RVA: 0x003461E4 File Offset: 0x003443E4
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

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0600E3C5 RID: 58309 RVA: 0x00346220 File Offset: 0x00344420
		public int ActivityId
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

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x0034625C File Offset: 0x0034445C
		public int RoleId
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

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x0600E3C7 RID: 58311 RVA: 0x00346298 File Offset: 0x00344498
		public int TalkType
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

		// Token: 0x0600E3C8 RID: 58312 RVA: 0x003462D8 File Offset: 0x003444D8
		public int LocationIdList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0600E3C9 RID: 58313 RVA: 0x00346318 File Offset: 0x00344518
		public int LocationIdListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E3CA RID: 58314 RVA: 0x00346344 File Offset: 0x00344544
		public Span<int> GetLocationIdListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E3CB RID: 58315 RVA: 0x00346354 File Offset: 0x00344554
		public int[] GetLocationIdListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x0034636C File Offset: 0x0034456C
		public int StartDayIndex
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

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0600E3CD RID: 58317 RVA: 0x003463AC File Offset: 0x003445AC
		public int EndDayIndex
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

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0600E3CE RID: 58318 RVA: 0x003463EC File Offset: 0x003445EC
		public int RoleSpineId
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

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0600E3CF RID: 58319 RVA: 0x0034642C File Offset: 0x0034462C
		public string TextKey
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

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x00346464 File Offset: 0x00344664
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E3D1 RID: 58321 RVA: 0x00346474 File Offset: 0x00344674
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600E3D2 RID: 58322 RVA: 0x0034648C File Offset: 0x0034468C
		public string AudioId
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

		// Token: 0x0600E3D3 RID: 58323 RVA: 0x003464C4 File Offset: 0x003446C4
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E3D4 RID: 58324 RVA: 0x003464D4 File Offset: 0x003446D4
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0600E3D5 RID: 58325 RVA: 0x003464EC File Offset: 0x003446EC
		public int AnimationId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E3D6 RID: 58326 RVA: 0x00346529 File Offset: 0x00344729
		[NullableContext(1)]
		public int[] LocationIdList()
		{
			return this.GetLocationIdListArray();
		}

		// Token: 0x0600E3D7 RID: 58327 RVA: 0x00346531 File Offset: 0x00344731
		[NullableContext(1)]
		public IEnumerable<int> LocationIdListIter()
		{
			SolarSchoolRoleTalk.<LocationIdListIter>d__38 <LocationIdListIter>d__ = new SolarSchoolRoleTalk.<LocationIdListIter>d__38(-2);
			<LocationIdListIter>d__.<>3__<>4__this = this;
			return <LocationIdListIter>d__;
		}

		// Token: 0x0400583F RID: 22591
		private Table __p;
	}
}
