using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9E RID: 3742
	public struct KurotatoWeapon : IFlatbufferObject
	{
		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06009240 RID: 37440 RVA: 0x002920CA File Offset: 0x002902CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x002920D7 File Offset: 0x002902D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x002920E0 File Offset: 0x002902E0
		public static KurotatoWeapon GetRootAsKurotatoWeapon(ByteBuffer _bb)
		{
			return KurotatoWeapon.GetRootAsKurotatoWeapon(_bb, default(KurotatoWeapon));
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x002920FC File Offset: 0x002902FC
		public static KurotatoWeapon GetRootAsKurotatoWeapon(ByteBuffer _bb, KurotatoWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00292119 File Offset: 0x00290319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00292128 File Offset: 0x00290328
		public KurotatoWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x00292138 File Offset: 0x00290338
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

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06009247 RID: 37447 RVA: 0x00292174 File Offset: 0x00290374
		public int BasicProperty
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

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06009248 RID: 37448 RVA: 0x002921B0 File Offset: 0x002903B0
		public int GroupId
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

		// Token: 0x06009249 RID: 37449 RVA: 0x002921EC File Offset: 0x002903EC
		public int ShowProperty(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x0600924A RID: 37450 RVA: 0x0029222C File Offset: 0x0029042C
		public int ShowPropertyLength
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

		// Token: 0x0600924B RID: 37451 RVA: 0x00292258 File Offset: 0x00290458
		public Span<int> GetShowPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x00292268 File Offset: 0x00290468
		public int[] GetShowPropertyArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600924D RID: 37453 RVA: 0x00292280 File Offset: 0x00290480
		public int Effect(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600924E RID: 37454 RVA: 0x002922C0 File Offset: 0x002904C0
		public int EffectLength
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

		// Token: 0x0600924F RID: 37455 RVA: 0x002922EC File Offset: 0x002904EC
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x002922FC File Offset: 0x002904FC
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06009251 RID: 37457 RVA: 0x00292314 File Offset: 0x00290514
		public int SimpleCombatSubtypeId
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

		// Token: 0x06009252 RID: 37458 RVA: 0x00292354 File Offset: 0x00290554
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06009253 RID: 37459 RVA: 0x00292394 File Offset: 0x00290594
		public int InitBuffsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x002923C0 File Offset: 0x002905C0
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x002923D0 File Offset: 0x002905D0
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06009256 RID: 37462 RVA: 0x002923E8 File Offset: 0x002905E8
		public string Name
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

		// Token: 0x06009257 RID: 37463 RVA: 0x00292420 File Offset: 0x00290620
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x00292430 File Offset: 0x00290630
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06009259 RID: 37465 RVA: 0x00292448 File Offset: 0x00290648
		public int SortId
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

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x0600925A RID: 37466 RVA: 0x00292488 File Offset: 0x00290688
		public string Desc
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

		// Token: 0x0600925B RID: 37467 RVA: 0x002924C0 File Offset: 0x002906C0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600925C RID: 37468 RVA: 0x002924D0 File Offset: 0x002906D0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600925D RID: 37469 RVA: 0x002924E8 File Offset: 0x002906E8
		public string DescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x0600925E RID: 37470 RVA: 0x00292524 File Offset: 0x00290724
		public int DescParamsLength
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

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x0600925F RID: 37471 RVA: 0x00292550 File Offset: 0x00290750
		public string BgDesc
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x00292588 File Offset: 0x00290788
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x00292598 File Offset: 0x00290798
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06009262 RID: 37474 RVA: 0x002925B0 File Offset: 0x002907B0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x002925E8 File Offset: 0x002907E8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x002925F8 File Offset: 0x002907F8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06009265 RID: 37477 RVA: 0x00292610 File Offset: 0x00290810
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06009266 RID: 37478 RVA: 0x00292650 File Offset: 0x00290850
		public int ShopBasicCost
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06009267 RID: 37479 RVA: 0x00292690 File Offset: 0x00290890
		public float ShopSellMutiply
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0.6f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x002926D4 File Offset: 0x002908D4
		public DicIntFloat? InheritScale(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06009269 RID: 37481 RVA: 0x00292738 File Offset: 0x00290938
		public int InheritScaleLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x00292764 File Offset: 0x00290964
		public DicIntInt? InheritSource(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x0600926B RID: 37483 RVA: 0x002927C8 File Offset: 0x002909C8
		public int InheritSourceLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x0600926C RID: 37484 RVA: 0x002927F4 File Offset: 0x002909F4
		public float AttackSpeedBasic
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x0600926D RID: 37485 RVA: 0x00292838 File Offset: 0x00290A38
		public int Attr136Basic
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x0600926E RID: 37486 RVA: 0x00292878 File Offset: 0x00290A78
		public int Attr140Basic
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x0600926F RID: 37487 RVA: 0x002928B8 File Offset: 0x00290AB8
		public int Attr139Basic
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06009270 RID: 37488 RVA: 0x002928F8 File Offset: 0x00290AF8
		public int Attr151Basic
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x00292938 File Offset: 0x00290B38
		public string AttackDes
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x00292970 File Offset: 0x00290B70
		public Span<byte> GetAttackDesBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x00292980 File Offset: 0x00290B80
		public byte[] GetAttackDesArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x00292998 File Offset: 0x00290B98
		public string AttackDesParam(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06009275 RID: 37493 RVA: 0x002929D4 File Offset: 0x00290BD4
		public int AttackDesParamLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x00292A00 File Offset: 0x00290C00
		[NullableContext(1)]
		public string[] AttackDesParam()
		{
			return this.AttackDesParamIter().ToArray<string>();
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x00292A0D File Offset: 0x00290C0D
		[NullableContext(1)]
		public IEnumerable<string> AttackDesParamIter()
		{
			KurotatoWeapon.<AttackDesParamIter>d__82 <AttackDesParamIter>d__ = new KurotatoWeapon.<AttackDesParamIter>d__82(-2);
			<AttackDesParamIter>d__.<>3__<>4__this = this;
			return <AttackDesParamIter>d__;
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x00292A22 File Offset: 0x00290C22
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x00292A2F File Offset: 0x00290C2F
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			KurotatoWeapon.<DescParamsIter>d__84 <DescParamsIter>d__ = new KurotatoWeapon.<DescParamsIter>d__84(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x00292A44 File Offset: 0x00290C44
		[NullableContext(1)]
		public int[] Effect()
		{
			return this.GetEffectArray();
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x00292A4C File Offset: 0x00290C4C
		[NullableContext(1)]
		public IEnumerable<int> EffectIter()
		{
			KurotatoWeapon.<EffectIter>d__86 <EffectIter>d__ = new KurotatoWeapon.<EffectIter>d__86(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x00292A64 File Offset: 0x00290C64
		[NullableContext(1)]
		public Dictionary<int, float> InheritScale()
		{
			return this.InheritScaleIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x0600927D RID: 37501 RVA: 0x00292ABA File Offset: 0x00290CBA
		[NullableContext(1)]
		public IEnumerable<DicIntFloat> InheritScaleIter()
		{
			KurotatoWeapon.<InheritScaleIter>d__88 <InheritScaleIter>d__ = new KurotatoWeapon.<InheritScaleIter>d__88(-2);
			<InheritScaleIter>d__.<>3__<>4__this = this;
			return <InheritScaleIter>d__;
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x00292AD0 File Offset: 0x00290CD0
		[NullableContext(1)]
		public Dictionary<int, int> InheritSource()
		{
			return this.InheritSourceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x00292B26 File Offset: 0x00290D26
		[NullableContext(1)]
		public IEnumerable<DicIntInt> InheritSourceIter()
		{
			KurotatoWeapon.<InheritSourceIter>d__90 <InheritSourceIter>d__ = new KurotatoWeapon.<InheritSourceIter>d__90(-2);
			<InheritSourceIter>d__.<>3__<>4__this = this;
			return <InheritSourceIter>d__;
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x00292B3B File Offset: 0x00290D3B
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x00292B43 File Offset: 0x00290D43
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			KurotatoWeapon.<InitBuffsIter>d__92 <InitBuffsIter>d__ = new KurotatoWeapon.<InitBuffsIter>d__92(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x00292B58 File Offset: 0x00290D58
		[NullableContext(1)]
		public int[] ShowProperty()
		{
			return this.GetShowPropertyArray();
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00292B60 File Offset: 0x00290D60
		[NullableContext(1)]
		public IEnumerable<int> ShowPropertyIter()
		{
			KurotatoWeapon.<ShowPropertyIter>d__94 <ShowPropertyIter>d__ = new KurotatoWeapon.<ShowPropertyIter>d__94(-2);
			<ShowPropertyIter>d__.<>3__<>4__this = this;
			return <ShowPropertyIter>d__;
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x00292B78 File Offset: 0x00290D78
		public float? GetInheritScale(int key)
		{
			this.EnsureInheritScaleCacheIfNeeded();
			float value;
			if (!this.InheritScaleCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x00292BAC File Offset: 0x00290DAC
		public int? GetInheritSource(int key)
		{
			this.EnsureInheritSourceCacheIfNeeded();
			int value;
			if (!this.InheritSourceCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x00292BE0 File Offset: 0x00290DE0
		private void EnsureInheritScaleCacheIfNeeded()
		{
			if (this.InheritScaleCache != null)
			{
				return;
			}
			this.InheritScaleCache = this.InheritScaleIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x00292C48 File Offset: 0x00290E48
		private void EnsureInheritSourceCacheIfNeeded()
		{
			if (this.InheritSourceCache != null)
			{
				return;
			}
			this.InheritSourceCache = this.InheritSourceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00292CAE File Offset: 0x00290EAE
		[NullableContext(1)]
		public FrozenDictionary<int, float> GetInheritScaleFrozenDict()
		{
			this.EnsureInheritScaleCacheIfNeeded();
			return this.InheritScaleCache;
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x00292CBC File Offset: 0x00290EBC
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetInheritSourceFrozenDict()
		{
			this.EnsureInheritSourceCacheIfNeeded();
			return this.InheritSourceCache;
		}

		// Token: 0x04005432 RID: 21554
		private Table __p;

		// Token: 0x04005433 RID: 21555
		[Nullable(2)]
		private FrozenDictionary<int, float> InheritScaleCache;

		// Token: 0x04005434 RID: 21556
		[Nullable(2)]
		private FrozenDictionary<int, int> InheritSourceCache;
	}
}
