using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D4 RID: 4564
	public struct SolarSchoolAttr : IFlatbufferObject
	{
		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600DF37 RID: 57143 RVA: 0x0033BC45 File Offset: 0x00339E45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF38 RID: 57144 RVA: 0x0033BC52 File Offset: 0x00339E52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF39 RID: 57145 RVA: 0x0033BC5C File Offset: 0x00339E5C
		public static SolarSchoolAttr GetRootAsSolarSchoolAttr(ByteBuffer _bb)
		{
			return SolarSchoolAttr.GetRootAsSolarSchoolAttr(_bb, default(SolarSchoolAttr));
		}

		// Token: 0x0600DF3A RID: 57146 RVA: 0x0033BC78 File Offset: 0x00339E78
		public static SolarSchoolAttr GetRootAsSolarSchoolAttr(ByteBuffer _bb, SolarSchoolAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF3B RID: 57147 RVA: 0x0033BC95 File Offset: 0x00339E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF3C RID: 57148 RVA: 0x0033BCA4 File Offset: 0x00339EA4
		public SolarSchoolAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600DF3D RID: 57149 RVA: 0x0033BCB4 File Offset: 0x00339EB4
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

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600DF3E RID: 57150 RVA: 0x0033BCF0 File Offset: 0x00339EF0
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

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600DF3F RID: 57151 RVA: 0x0033BD2C File Offset: 0x00339F2C
		public int AttrType
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

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600DF40 RID: 57152 RVA: 0x0033BD68 File Offset: 0x00339F68
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

		// Token: 0x0600DF41 RID: 57153 RVA: 0x0033BDA0 File Offset: 0x00339FA0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DF42 RID: 57154 RVA: 0x0033BDB0 File Offset: 0x00339FB0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600DF43 RID: 57155 RVA: 0x0033BDC8 File Offset: 0x00339FC8
		public string IconSmall
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

		// Token: 0x0600DF44 RID: 57156 RVA: 0x0033BE00 File Offset: 0x0033A000
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DF45 RID: 57157 RVA: 0x0033BE10 File Offset: 0x0033A010
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600DF46 RID: 57158 RVA: 0x0033BE28 File Offset: 0x0033A028
		public string YellowIconSmall
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

		// Token: 0x0600DF47 RID: 57159 RVA: 0x0033BE60 File Offset: 0x0033A060
		public Span<byte> GetYellowIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DF48 RID: 57160 RVA: 0x0033BE70 File Offset: 0x0033A070
		public byte[] GetYellowIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600DF49 RID: 57161 RVA: 0x0033BE88 File Offset: 0x0033A088
		public string IconReach
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

		// Token: 0x0600DF4A RID: 57162 RVA: 0x0033BEC0 File Offset: 0x0033A0C0
		public Span<byte> GetIconReachBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DF4B RID: 57163 RVA: 0x0033BED0 File Offset: 0x0033A0D0
		public byte[] GetIconReachArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x0033BEE8 File Offset: 0x0033A0E8
		public string IconNotReach
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

		// Token: 0x0600DF4D RID: 57165 RVA: 0x0033BF20 File Offset: 0x0033A120
		public Span<byte> GetIconNotReachBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DF4E RID: 57166 RVA: 0x0033BF30 File Offset: 0x0033A130
		public byte[] GetIconNotReachArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DF4F RID: 57167 RVA: 0x0033BF48 File Offset: 0x0033A148
		public int Ranks(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x0033BF88 File Offset: 0x0033A188
		public int RanksLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DF51 RID: 57169 RVA: 0x0033BFB4 File Offset: 0x0033A1B4
		public Span<int> GetRanksBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DF52 RID: 57170 RVA: 0x0033BFC4 File Offset: 0x0033A1C4
		public int[] GetRanksArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DF53 RID: 57171 RVA: 0x0033BFDC File Offset: 0x0033A1DC
		public string RankIcon(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x0033C018 File Offset: 0x0033A218
		public int RankIconLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600DF55 RID: 57173 RVA: 0x0033C044 File Offset: 0x0033A244
		public int InitValue
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

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600DF56 RID: 57174 RVA: 0x0033C084 File Offset: 0x0033A284
		public int MinValue
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600DF57 RID: 57175 RVA: 0x0033C0C4 File Offset: 0x0033A2C4
		public int MaxValue
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600DF58 RID: 57176 RVA: 0x0033C104 File Offset: 0x0033A304
		public int DailyMax
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 9999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DF59 RID: 57177 RVA: 0x0033C145 File Offset: 0x0033A345
		[NullableContext(1)]
		public string[] RankIcon()
		{
			return this.RankIconIter().ToArray<string>();
		}

		// Token: 0x0600DF5A RID: 57178 RVA: 0x0033C152 File Offset: 0x0033A352
		[NullableContext(1)]
		public IEnumerable<string> RankIconIter()
		{
			SolarSchoolAttr.<RankIconIter>d__51 <RankIconIter>d__ = new SolarSchoolAttr.<RankIconIter>d__51(-2);
			<RankIconIter>d__.<>3__<>4__this = this;
			return <RankIconIter>d__;
		}

		// Token: 0x0600DF5B RID: 57179 RVA: 0x0033C167 File Offset: 0x0033A367
		[NullableContext(1)]
		public int[] Ranks()
		{
			return this.GetRanksArray();
		}

		// Token: 0x0600DF5C RID: 57180 RVA: 0x0033C16F File Offset: 0x0033A36F
		[NullableContext(1)]
		public IEnumerable<int> RanksIter()
		{
			SolarSchoolAttr.<RanksIter>d__53 <RanksIter>d__ = new SolarSchoolAttr.<RanksIter>d__53(-2);
			<RanksIter>d__.<>3__<>4__this = this;
			return <RanksIter>d__;
		}

		// Token: 0x0400580B RID: 22539
		private Table __p;
	}
}
