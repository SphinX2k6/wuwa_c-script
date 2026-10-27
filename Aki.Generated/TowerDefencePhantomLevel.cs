using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113C RID: 4412
	public struct TowerDefencePhantomLevel : IFlatbufferObject
	{
		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0600E004 RID: 57348 RVA: 0x00330848 File Offset: 0x0032EA48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E005 RID: 57349 RVA: 0x00330855 File Offset: 0x0032EA55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E006 RID: 57350 RVA: 0x0033085C File Offset: 0x0032EA5C
		public static TowerDefencePhantomLevel GetRootAsTowerDefencePhantomLevel(ByteBuffer _bb)
		{
			return TowerDefencePhantomLevel.GetRootAsTowerDefencePhantomLevel(_bb, default(TowerDefencePhantomLevel));
		}

		// Token: 0x0600E007 RID: 57351 RVA: 0x00330878 File Offset: 0x0032EA78
		public static TowerDefencePhantomLevel GetRootAsTowerDefencePhantomLevel(ByteBuffer _bb, TowerDefencePhantomLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E008 RID: 57352 RVA: 0x00330895 File Offset: 0x0032EA95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E009 RID: 57353 RVA: 0x003308A4 File Offset: 0x0032EAA4
		public TowerDefencePhantomLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x0600E00A RID: 57354 RVA: 0x003308B4 File Offset: 0x0032EAB4
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

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0600E00B RID: 57355 RVA: 0x003308F0 File Offset: 0x0032EAF0
		public int GroupId
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

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0600E00C RID: 57356 RVA: 0x0033092C File Offset: 0x0032EB2C
		public int Level
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

		// Token: 0x0600E00D RID: 57357 RVA: 0x00330968 File Offset: 0x0032EB68
		public long SkillId(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0600E00E RID: 57358 RVA: 0x003309B4 File Offset: 0x0032EBB4
		public int SkillIdLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E00F RID: 57359 RVA: 0x003309E0 File Offset: 0x0032EBE0
		public Span<long> GetSkillIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x0600E010 RID: 57360 RVA: 0x003309F5 File Offset: 0x0032EBF5
		public long[] GetSkillIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0600E011 RID: 57361 RVA: 0x00330A34 File Offset: 0x0032EC34
		public string Title
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

		// Token: 0x0600E012 RID: 57362 RVA: 0x00330A6C File Offset: 0x0032EC6C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E013 RID: 57363 RVA: 0x00330A7C File Offset: 0x0032EC7C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x0600E014 RID: 57364 RVA: 0x00330A94 File Offset: 0x0032EC94
		public string Description
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

		// Token: 0x0600E015 RID: 57365 RVA: 0x00330ACC File Offset: 0x0032ECCC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x00330ADC File Offset: 0x0032ECDC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0600E017 RID: 57367 RVA: 0x00330AF4 File Offset: 0x0032ECF4
		public int ExpLevel
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

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0600E018 RID: 57368 RVA: 0x00330B34 File Offset: 0x0032ED34
		public string UnlockDescription
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

		// Token: 0x0600E019 RID: 57369 RVA: 0x00330B6C File Offset: 0x0032ED6C
		public Span<byte> GetUnlockDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E01A RID: 57370 RVA: 0x00330B7C File Offset: 0x0032ED7C
		public byte[] GetUnlockDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0600E01B RID: 57371 RVA: 0x00330B94 File Offset: 0x0032ED94
		public int PhantomSkill
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

		// Token: 0x0600E01C RID: 57372 RVA: 0x00330BD4 File Offset: 0x0032EDD4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIdIter()或GetSkillIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] SkillId()
		{
			TowerDefencePhantomLevel towerDefencePhantomLevel = this;
			return towerDefencePhantomLevel.GetSkillIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600E01D RID: 57373 RVA: 0x00330BF8 File Offset: 0x0032EDF8
		[NullableContext(1)]
		public readonly IEnumerable<long> SkillIdIter()
		{
			TowerDefencePhantomLevel.<SkillIdIter>d__36 <SkillIdIter>d__ = new TowerDefencePhantomLevel.<SkillIdIter>d__36(-2);
			<SkillIdIter>d__.<>3__<>4__this = this;
			return <SkillIdIter>d__;
		}

		// Token: 0x0400527D RID: 21117
		private Table __p;
	}
}
