using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001137 RID: 4407
	public struct TowerConfig : IFlatbufferObject
	{
		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0600DF78 RID: 57208 RVA: 0x0032F360 File Offset: 0x0032D560
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF79 RID: 57209 RVA: 0x0032F36D File Offset: 0x0032D56D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF7A RID: 57210 RVA: 0x0032F374 File Offset: 0x0032D574
		public static TowerConfig GetRootAsTowerConfig(ByteBuffer _bb)
		{
			return TowerConfig.GetRootAsTowerConfig(_bb, default(TowerConfig));
		}

		// Token: 0x0600DF7B RID: 57211 RVA: 0x0032F390 File Offset: 0x0032D590
		public static TowerConfig GetRootAsTowerConfig(ByteBuffer _bb, TowerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF7C RID: 57212 RVA: 0x0032F3AD File Offset: 0x0032D5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF7D RID: 57213 RVA: 0x0032F3BC File Offset: 0x0032D5BC
		public TowerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0600DF7E RID: 57214 RVA: 0x0032F3CC File Offset: 0x0032D5CC
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

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0600DF7F RID: 57215 RVA: 0x0032F408 File Offset: 0x0032D608
		public int Season
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

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0600DF80 RID: 57216 RVA: 0x0032F444 File Offset: 0x0032D644
		public int Difficulty
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

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0600DF81 RID: 57217 RVA: 0x0032F480 File Offset: 0x0032D680
		public int AreaNum
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

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0600DF82 RID: 57218 RVA: 0x0032F4C0 File Offset: 0x0032D6C0
		public int Floor
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

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0600DF83 RID: 57219 RVA: 0x0032F500 File Offset: 0x0032D700
		public int InstanceId
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

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0600DF84 RID: 57220 RVA: 0x0032F540 File Offset: 0x0032D740
		public string AreaName
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

		// Token: 0x0600DF85 RID: 57221 RVA: 0x0032F578 File Offset: 0x0032D778
		public Span<byte> GetAreaNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DF86 RID: 57222 RVA: 0x0032F588 File Offset: 0x0032D788
		public byte[] GetAreaNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0600DF87 RID: 57223 RVA: 0x0032F5A0 File Offset: 0x0032D7A0
		public int Cost
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

		// Token: 0x0600DF88 RID: 57224 RVA: 0x0032F5E0 File Offset: 0x0032D7E0
		public int RecommendElement(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0600DF89 RID: 57225 RVA: 0x0032F620 File Offset: 0x0032D820
		public int RecommendElementLength
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

		// Token: 0x0600DF8A RID: 57226 RVA: 0x0032F64C File Offset: 0x0032D84C
		public Span<int> GetRecommendElementBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DF8B RID: 57227 RVA: 0x0032F65C File Offset: 0x0032D85C
		public int[] GetRecommendElementArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DF8C RID: 57228 RVA: 0x0032F674 File Offset: 0x0032D874
		public int ShowMonsters(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0600DF8D RID: 57229 RVA: 0x0032F6B4 File Offset: 0x0032D8B4
		public int ShowMonstersLength
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

		// Token: 0x0600DF8E RID: 57230 RVA: 0x0032F6E0 File Offset: 0x0032D8E0
		public Span<int> GetShowMonstersBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DF8F RID: 57231 RVA: 0x0032F6F0 File Offset: 0x0032D8F0
		public int[] GetShowMonstersArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DF90 RID: 57232 RVA: 0x0032F708 File Offset: 0x0032D908
		public IntPair? ShowMonstersAndLevel(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0600DF91 RID: 57233 RVA: 0x0032F76C File Offset: 0x0032D96C
		public int ShowMonstersAndLevelLength
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

		// Token: 0x0600DF92 RID: 57234 RVA: 0x0032F798 File Offset: 0x0032D998
		public long ShowBuffs(int j)
		{
			int num = this.__p.__offset(26);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0600DF93 RID: 57235 RVA: 0x0032F7E4 File Offset: 0x0032D9E4
		public int ShowBuffsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DF94 RID: 57236 RVA: 0x0032F810 File Offset: 0x0032DA10
		public Span<long> GetShowBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(26, 8));
		}

		// Token: 0x0600DF95 RID: 57237 RVA: 0x0032F825 File Offset: 0x0032DA25
		public long[] GetShowBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(26) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600DF96 RID: 57238 RVA: 0x0032F864 File Offset: 0x0032DA64
		public long RoleBuff(int j)
		{
			int num = this.__p.__offset(28);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x0600DF97 RID: 57239 RVA: 0x0032F8B0 File Offset: 0x0032DAB0
		public int RoleBuffLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DF98 RID: 57240 RVA: 0x0032F8DC File Offset: 0x0032DADC
		public Span<long> GetRoleBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(28, 8));
		}

		// Token: 0x0600DF99 RID: 57241 RVA: 0x0032F8F1 File Offset: 0x0032DAF1
		public long[] GetRoleBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(28) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600DF9A RID: 57242 RVA: 0x0032F930 File Offset: 0x0032DB30
		public long MonsterBuff(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x0600DF9B RID: 57243 RVA: 0x0032F97C File Offset: 0x0032DB7C
		public int MonsterBuffLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DF9C RID: 57244 RVA: 0x0032F9A8 File Offset: 0x0032DBA8
		public Span<long> GetMonsterBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x0600DF9D RID: 57245 RVA: 0x0032F9BD File Offset: 0x0032DBBD
		public long[] GetMonsterBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600DF9E RID: 57246 RVA: 0x0032F9FC File Offset: 0x0032DBFC
		public int Target(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x0600DF9F RID: 57247 RVA: 0x0032FA3C File Offset: 0x0032DC3C
		public int TargetLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DFA0 RID: 57248 RVA: 0x0032FA68 File Offset: 0x0032DC68
		public Span<int> GetTargetBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600DFA1 RID: 57249 RVA: 0x0032FA78 File Offset: 0x0032DC78
		public int[] GetTargetArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600DFA2 RID: 57250 RVA: 0x0032FA90 File Offset: 0x0032DC90
		public int TargetConfig(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0600DFA3 RID: 57251 RVA: 0x0032FAD0 File Offset: 0x0032DCD0
		public int TargetConfigLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DFA4 RID: 57252 RVA: 0x0032FAFC File Offset: 0x0032DCFC
		public Span<int> GetTargetConfigBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600DFA5 RID: 57253 RVA: 0x0032FB0C File Offset: 0x0032DD0C
		public int[] GetTargetConfigArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0600DFA6 RID: 57254 RVA: 0x0032FB24 File Offset: 0x0032DD24
		public string BgPath
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFA7 RID: 57255 RVA: 0x0032FB5C File Offset: 0x0032DD5C
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600DFA8 RID: 57256 RVA: 0x0032FB6C File Offset: 0x0032DD6C
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x0600DFA9 RID: 57257 RVA: 0x0032FB84 File Offset: 0x0032DD84
		public string ItemBgPath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFAA RID: 57258 RVA: 0x0032FBBC File Offset: 0x0032DDBC
		public Span<byte> GetItemBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600DFAB RID: 57259 RVA: 0x0032FBCC File Offset: 0x0032DDCC
		public byte[] GetItemBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DFAC RID: 57260 RVA: 0x0032FBE4 File Offset: 0x0032DDE4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterBuffIter()或GetMonsterBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] MonsterBuff()
		{
			TowerConfig towerConfig = this;
			return towerConfig.GetMonsterBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600DFAD RID: 57261 RVA: 0x0032FC08 File Offset: 0x0032DE08
		[NullableContext(1)]
		public readonly IEnumerable<long> MonsterBuffIter()
		{
			TowerConfig.<MonsterBuffIter>d__73 <MonsterBuffIter>d__ = new TowerConfig.<MonsterBuffIter>d__73(-2);
			<MonsterBuffIter>d__.<>3__<>4__this = this;
			return <MonsterBuffIter>d__;
		}

		// Token: 0x0600DFAE RID: 57262 RVA: 0x0032FC20 File Offset: 0x0032DE20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendElementIter()或GetRecommendElementBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendElement()
		{
			TowerConfig towerConfig = this;
			return towerConfig.GetRecommendElementArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DFAF RID: 57263 RVA: 0x0032FC44 File Offset: 0x0032DE44
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendElementIter()
		{
			TowerConfig.<RecommendElementIter>d__75 <RecommendElementIter>d__ = new TowerConfig.<RecommendElementIter>d__75(-2);
			<RecommendElementIter>d__.<>3__<>4__this = this;
			return <RecommendElementIter>d__;
		}

		// Token: 0x0600DFB0 RID: 57264 RVA: 0x0032FC5C File Offset: 0x0032DE5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleBuffIter()或GetRoleBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] RoleBuff()
		{
			TowerConfig towerConfig = this;
			return towerConfig.GetRoleBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600DFB1 RID: 57265 RVA: 0x0032FC80 File Offset: 0x0032DE80
		[NullableContext(1)]
		public readonly IEnumerable<long> RoleBuffIter()
		{
			TowerConfig.<RoleBuffIter>d__77 <RoleBuffIter>d__ = new TowerConfig.<RoleBuffIter>d__77(-2);
			<RoleBuffIter>d__.<>3__<>4__this = this;
			return <RoleBuffIter>d__;
		}

		// Token: 0x0600DFB2 RID: 57266 RVA: 0x0032FC98 File Offset: 0x0032DE98
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowBuffsIter()或GetShowBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] ShowBuffs()
		{
			TowerConfig towerConfig = this;
			return towerConfig.GetShowBuffsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600DFB3 RID: 57267 RVA: 0x0032FCBC File Offset: 0x0032DEBC
		[NullableContext(1)]
		public readonly IEnumerable<long> ShowBuffsIter()
		{
			TowerConfig.<ShowBuffsIter>d__79 <ShowBuffsIter>d__ = new TowerConfig.<ShowBuffsIter>d__79(-2);
			<ShowBuffsIter>d__.<>3__<>4__this = this;
			return <ShowBuffsIter>d__;
		}

		// Token: 0x0600DFB4 RID: 57268 RVA: 0x0032FCD4 File Offset: 0x0032DED4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowMonstersIter()或GetShowMonstersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowMonsters()
		{
			TowerConfig towerConfig = this;
			return towerConfig.GetShowMonstersArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DFB5 RID: 57269 RVA: 0x0032FCF8 File Offset: 0x0032DEF8
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowMonstersIter()
		{
			TowerConfig.<ShowMonstersIter>d__81 <ShowMonstersIter>d__ = new TowerConfig.<ShowMonstersIter>d__81(-2);
			<ShowMonstersIter>d__.<>3__<>4__this = this;
			return <ShowMonstersIter>d__;
		}

		// Token: 0x0600DFB6 RID: 57270 RVA: 0x0032FD0D File Offset: 0x0032DF0D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowMonstersAndLevelIter()或GetShowMonstersAndLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] ShowMonstersAndLevel()
		{
			return this.ShowMonstersAndLevelIter().ToArray<IntPair>();
		}

		// Token: 0x0600DFB7 RID: 57271 RVA: 0x0032FD1A File Offset: 0x0032DF1A
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> ShowMonstersAndLevelIter()
		{
			TowerConfig.<ShowMonstersAndLevelIter>d__83 <ShowMonstersAndLevelIter>d__ = new TowerConfig.<ShowMonstersAndLevelIter>d__83(-2);
			<ShowMonstersAndLevelIter>d__.<>3__<>4__this = this;
			return <ShowMonstersAndLevelIter>d__;
		}

		// Token: 0x0600DFB8 RID: 57272 RVA: 0x0032FD30 File Offset: 0x0032DF30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetIter()或GetTargetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Target()
		{
			TowerConfig towerConfig = this;
			return towerConfig.GetTargetArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DFB9 RID: 57273 RVA: 0x0032FD54 File Offset: 0x0032DF54
		[NullableContext(1)]
		public readonly IEnumerable<int> TargetIter()
		{
			TowerConfig.<TargetIter>d__85 <TargetIter>d__ = new TowerConfig.<TargetIter>d__85(-2);
			<TargetIter>d__.<>3__<>4__this = this;
			return <TargetIter>d__;
		}

		// Token: 0x0600DFBA RID: 57274 RVA: 0x0032FD6C File Offset: 0x0032DF6C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetConfigIter()或GetTargetConfigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TargetConfig()
		{
			TowerConfig towerConfig = this;
			return towerConfig.GetTargetConfigArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DFBB RID: 57275 RVA: 0x0032FD90 File Offset: 0x0032DF90
		[NullableContext(1)]
		public readonly IEnumerable<int> TargetConfigIter()
		{
			TowerConfig.<TargetConfigIter>d__87 <TargetConfigIter>d__ = new TowerConfig.<TargetConfigIter>d__87(-2);
			<TargetConfigIter>d__.<>3__<>4__this = this;
			return <TargetConfigIter>d__;
		}

		// Token: 0x04005278 RID: 21112
		private Table __p;
	}
}
