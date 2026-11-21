using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011EF RID: 4591
	public struct SolarSchoolItemEffect : IFlatbufferObject
	{
		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600E1FA RID: 57850 RVA: 0x00342170 File Offset: 0x00340370
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E1FB RID: 57851 RVA: 0x0034217D File Offset: 0x0034037D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E1FC RID: 57852 RVA: 0x00342184 File Offset: 0x00340384
		public static SolarSchoolItemEffect GetRootAsSolarSchoolItemEffect(ByteBuffer _bb)
		{
			return SolarSchoolItemEffect.GetRootAsSolarSchoolItemEffect(_bb, default(SolarSchoolItemEffect));
		}

		// Token: 0x0600E1FD RID: 57853 RVA: 0x003421A0 File Offset: 0x003403A0
		public static SolarSchoolItemEffect GetRootAsSolarSchoolItemEffect(ByteBuffer _bb, SolarSchoolItemEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E1FE RID: 57854 RVA: 0x003421BD File Offset: 0x003403BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E1FF RID: 57855 RVA: 0x003421CC File Offset: 0x003403CC
		public SolarSchoolItemEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600E200 RID: 57856 RVA: 0x003421DC File Offset: 0x003403DC
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

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0600E201 RID: 57857 RVA: 0x00342218 File Offset: 0x00340418
		public int EffectType
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

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600E202 RID: 57858 RVA: 0x00342254 File Offset: 0x00340454
		public int Value1
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

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600E203 RID: 57859 RVA: 0x00342290 File Offset: 0x00340490
		public int Value2
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

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600E204 RID: 57860 RVA: 0x003422D0 File Offset: 0x003404D0
		public int Value3
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

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600E205 RID: 57861 RVA: 0x00342310 File Offset: 0x00340510
		public int Value4
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

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600E206 RID: 57862 RVA: 0x00342350 File Offset: 0x00340550
		public int Value5
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

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600E207 RID: 57863 RVA: 0x00342390 File Offset: 0x00340590
		public int Popularity
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

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600E208 RID: 57864 RVA: 0x003423D0 File Offset: 0x003405D0
		public int Fatigue
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

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600E209 RID: 57865 RVA: 0x00342410 File Offset: 0x00340610
		public int Buff
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

		// Token: 0x0600E20A RID: 57866 RVA: 0x00342450 File Offset: 0x00340650
		public DicIntInt? FavorList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600E20B RID: 57867 RVA: 0x003424B4 File Offset: 0x003406B4
		public int FavorListLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E20C RID: 57868 RVA: 0x003424E0 File Offset: 0x003406E0
		[NullableContext(1)]
		public Dictionary<int, int> FavorList()
		{
			return this.FavorListIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E20D RID: 57869 RVA: 0x00342536 File Offset: 0x00340736
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FavorListIter()
		{
			SolarSchoolItemEffect.<FavorListIter>d__32 <FavorListIter>d__ = new SolarSchoolItemEffect.<FavorListIter>d__32(-2);
			<FavorListIter>d__.<>3__<>4__this = this;
			return <FavorListIter>d__;
		}

		// Token: 0x0600E20E RID: 57870 RVA: 0x0034254C File Offset: 0x0034074C
		public int? GetFavorList(int key)
		{
			this.EnsureFavorListCacheIfNeeded();
			int value;
			if (!this.FavorListCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E20F RID: 57871 RVA: 0x00342580 File Offset: 0x00340780
		private void EnsureFavorListCacheIfNeeded()
		{
			if (this.FavorListCache != null)
			{
				return;
			}
			this.FavorListCache = this.FavorListIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E210 RID: 57872 RVA: 0x003425E6 File Offset: 0x003407E6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFavorListFrozenDict()
		{
			this.EnsureFavorListCacheIfNeeded();
			return this.FavorListCache;
		}

		// Token: 0x0400582C RID: 22572
		private Table __p;

		// Token: 0x0400582D RID: 22573
		[Nullable(2)]
		private FrozenDictionary<int, int> FavorListCache;
	}
}
