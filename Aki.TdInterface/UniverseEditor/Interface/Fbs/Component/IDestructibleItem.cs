using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EC RID: 21996
	public struct IDestructibleItem : IFlatbufferObject
	{
		// Token: 0x17009D84 RID: 40324
		// (get) Token: 0x06023049 RID: 143433 RVA: 0x004D18AB File Offset: 0x004CFAAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602304A RID: 143434 RVA: 0x004D18B8 File Offset: 0x004CFAB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602304B RID: 143435 RVA: 0x004D18C0 File Offset: 0x004CFAC0
		public static IDestructibleItem GetRootAsIDestructibleItem(ByteBuffer _bb)
		{
			return IDestructibleItem.GetRootAsIDestructibleItem(_bb, default(IDestructibleItem));
		}

		// Token: 0x0602304C RID: 143436 RVA: 0x004D18DC File Offset: 0x004CFADC
		public static IDestructibleItem GetRootAsIDestructibleItem(ByteBuffer _bb, IDestructibleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602304D RID: 143437 RVA: 0x004D18F9 File Offset: 0x004CFAF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602304E RID: 143438 RVA: 0x004D1908 File Offset: 0x004CFB08
		public IDestructibleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D85 RID: 40325
		// (get) Token: 0x0602304F RID: 143439 RVA: 0x004D1918 File Offset: 0x004CFB18
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D86 RID: 40326
		// (get) Token: 0x06023050 RID: 143440 RVA: 0x004D1958 File Offset: 0x004CFB58
		public THitBulletType HitBulletType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return THitBulletType.NONE;
				}
				return (THitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023051 RID: 143441 RVA: 0x004D1994 File Offset: 0x004CFB94
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023052 RID: 143442 RVA: 0x004D19D8 File Offset: 0x004CFBD8
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06023053 RID: 143443 RVA: 0x004D19F4 File Offset: 0x004CFBF4
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06023054 RID: 143444 RVA: 0x004D1A10 File Offset: 0x004CFC10
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06023055 RID: 143445 RVA: 0x004D1A2C File Offset: 0x004CFC2C
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06023056 RID: 143446 RVA: 0x004D1A48 File Offset: 0x004CFC48
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06023057 RID: 143447 RVA: 0x004D1A64 File Offset: 0x004CFC64
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x17009D87 RID: 40327
		// (get) Token: 0x06023058 RID: 143448 RVA: 0x004D1A80 File Offset: 0x004CFC80
		public IHitTimeScaleRatio? AttackerHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D88 RID: 40328
		// (get) Token: 0x06023059 RID: 143449 RVA: 0x004D1AE0 File Offset: 0x004CFCE0
		public IHitTimeScaleRatio? VictimHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602305A RID: 143450 RVA: 0x004D1B40 File Offset: 0x004CFD40
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D89 RID: 40329
		// (get) Token: 0x0602305B RID: 143451 RVA: 0x004D1BA4 File Offset: 0x004CFDA4
		public int AimPartsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009D8A RID: 40330
		// (get) Token: 0x0602305C RID: 143452 RVA: 0x004D1BD0 File Offset: 0x004CFDD0
		public int DurabilityId
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

		// Token: 0x17009D8B RID: 40331
		// (get) Token: 0x0602305D RID: 143453 RVA: 0x004D1C10 File Offset: 0x004CFE10
		public int Durability
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

		// Token: 0x17009D8C RID: 40332
		// (get) Token: 0x0602305E RID: 143454 RVA: 0x004D1C50 File Offset: 0x004CFE50
		public IDurabilityWorn? DurabilityWorn
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IDurabilityWorn?(default(IDurabilityWorn).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D8D RID: 40333
		// (get) Token: 0x0602305F RID: 143455 RVA: 0x004D1CB0 File Offset: 0x004CFEB0
		public IDurabilityStateConfig? DurabilityStateConfig
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IDurabilityStateConfig?(default(IDurabilityStateConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D8E RID: 40334
		// (get) Token: 0x06023060 RID: 143456 RVA: 0x004D1D10 File Offset: 0x004CFF10
		public IVectorInfo? HitPoint
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023061 RID: 143457 RVA: 0x004D1D70 File Offset: 0x004CFF70
		public IActionInfo? DestructionActions(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D8F RID: 40335
		// (get) Token: 0x06023062 RID: 143458 RVA: 0x004D1DD4 File Offset: 0x004CFFD4
		public int DestructionActionsLength
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

		// Token: 0x17009D90 RID: 40336
		// (get) Token: 0x06023063 RID: 143459 RVA: 0x004D1E00 File Offset: 0x004D0000
		public ISkillDamage? SkillDamage
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new ISkillDamage?(default(ISkillDamage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D91 RID: 40337
		// (get) Token: 0x06023064 RID: 143460 RVA: 0x004D1E60 File Offset: 0x004D0060
		public IElementDamage? ElementDamage
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new IElementDamage?(default(IElementDamage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D92 RID: 40338
		// (get) Token: 0x06023065 RID: 143461 RVA: 0x004D1EC0 File Offset: 0x004D00C0
		public IWeaponDamage? WeaponDamage
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IWeaponDamage?(default(IWeaponDamage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023066 RID: 143462 RVA: 0x004D1F20 File Offset: 0x004D0120
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009D93 RID: 40339
		// (get) Token: 0x06023067 RID: 143463 RVA: 0x004D1F60 File Offset: 0x004D0160
		public int MatchRoleOptionTypeLength
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

		// Token: 0x06023068 RID: 143464 RVA: 0x004D1F8C File Offset: 0x004D018C
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(34, 1);
		}

		// Token: 0x06023069 RID: 143465 RVA: 0x004D1F9C File Offset: 0x004D019C
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602306A RID: 143466 RVA: 0x004D2008 File Offset: 0x004D0208
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009D94 RID: 40340
		// (get) Token: 0x0602306B RID: 143467 RVA: 0x004D2050 File Offset: 0x004D0250
		public int MatchRoleOptionLength
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

		// Token: 0x17009D95 RID: 40341
		// (get) Token: 0x0602306C RID: 143468 RVA: 0x004D207C File Offset: 0x004D027C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602306D RID: 143469 RVA: 0x004D20BC File Offset: 0x004D02BC
		public static Offset<IDestructibleItem> CreateIDestructibleItem(FlatBufferBuilder builder, bool Disabled = false, THitBulletType HitBullet_type = THitBulletType.NONE, int HitBulletOffset = 0, Offset<IHitTimeScaleRatio> AttackerHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), Offset<IHitTimeScaleRatio> VictimHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), VectorOffset AimPartsOffset = default(VectorOffset), int DurabilityId = 0, int Durability = 0, Offset<IDurabilityWorn> DurabilityWornOffset = default(Offset<IDurabilityWorn>), Offset<IDurabilityStateConfig> DurabilityStateConfigOffset = default(Offset<IDurabilityStateConfig>), Offset<IVectorInfo> HitPointOffset = default(Offset<IVectorInfo>), VectorOffset DestructionActionsOffset = default(VectorOffset), Offset<ISkillDamage> SkillDamageOffset = default(Offset<ISkillDamage>), Offset<IElementDamage> ElementDamageOffset = default(Offset<IElementDamage>), Offset<IWeaponDamage> WeaponDamageOffset = default(Offset<IWeaponDamage>), VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(18);
			IDestructibleItem.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IDestructibleItem.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IDestructibleItem.AddWeaponDamage(builder, WeaponDamageOffset);
			IDestructibleItem.AddElementDamage(builder, ElementDamageOffset);
			IDestructibleItem.AddSkillDamage(builder, SkillDamageOffset);
			IDestructibleItem.AddDestructionActions(builder, DestructionActionsOffset);
			IDestructibleItem.AddHitPoint(builder, HitPointOffset);
			IDestructibleItem.AddDurabilityStateConfig(builder, DurabilityStateConfigOffset);
			IDestructibleItem.AddDurabilityWorn(builder, DurabilityWornOffset);
			IDestructibleItem.AddDurability(builder, Durability);
			IDestructibleItem.AddDurabilityId(builder, DurabilityId);
			IDestructibleItem.AddAimParts(builder, AimPartsOffset);
			IDestructibleItem.AddVictimHitTimeScaleRatio(builder, VictimHitTimeScaleRatioOffset);
			IDestructibleItem.AddAttackerHitTimeScaleRatio(builder, AttackerHitTimeScaleRatioOffset);
			IDestructibleItem.AddHitBullet(builder, HitBulletOffset);
			IDestructibleItem.AddNullMask(builder, NullMask);
			IDestructibleItem.AddHitBulletType(builder, HitBullet_type);
			IDestructibleItem.AddDisabled(builder, Disabled);
			return IDestructibleItem.EndIDestructibleItem(builder);
		}

		// Token: 0x0602306E RID: 143470 RVA: 0x004D2164 File Offset: 0x004D0364
		public static void StartIDestructibleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(18);
		}

		// Token: 0x0602306F RID: 143471 RVA: 0x004D216E File Offset: 0x004D036E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023070 RID: 143472 RVA: 0x004D2179 File Offset: 0x004D0379
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x06023071 RID: 143473 RVA: 0x004D2184 File Offset: 0x004D0384
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x06023072 RID: 143474 RVA: 0x004D218F File Offset: 0x004D038F
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06023073 RID: 143475 RVA: 0x004D219F File Offset: 0x004D039F
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06023074 RID: 143476 RVA: 0x004D21AF File Offset: 0x004D03AF
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x06023075 RID: 143477 RVA: 0x004D21C0 File Offset: 0x004D03C0
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023076 RID: 143478 RVA: 0x004D2200 File Offset: 0x004D0400
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023077 RID: 143479 RVA: 0x004D221A File Offset: 0x004D041A
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023078 RID: 143480 RVA: 0x004D2238 File Offset: 0x004D0438
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023079 RID: 143481 RVA: 0x004D2251 File Offset: 0x004D0451
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602307A RID: 143482 RVA: 0x004D225C File Offset: 0x004D045C
		public static void AddDurabilityId(FlatBufferBuilder builder, int durabilityId)
		{
			builder.AddInt(6, durabilityId, 0);
		}

		// Token: 0x0602307B RID: 143483 RVA: 0x004D2267 File Offset: 0x004D0467
		public static void AddDurability(FlatBufferBuilder builder, int durability)
		{
			builder.AddInt(7, durability, 0);
		}

		// Token: 0x0602307C RID: 143484 RVA: 0x004D2272 File Offset: 0x004D0472
		public static void AddDurabilityWorn(FlatBufferBuilder builder, Offset<IDurabilityWorn> durabilityWornOffset)
		{
			builder.AddOffset(8, durabilityWornOffset.Value, 0);
		}

		// Token: 0x0602307D RID: 143485 RVA: 0x004D2282 File Offset: 0x004D0482
		public static void AddDurabilityStateConfig(FlatBufferBuilder builder, Offset<IDurabilityStateConfig> durabilityStateConfigOffset)
		{
			builder.AddOffset(9, durabilityStateConfigOffset.Value, 0);
		}

		// Token: 0x0602307E RID: 143486 RVA: 0x004D2293 File Offset: 0x004D0493
		public static void AddHitPoint(FlatBufferBuilder builder, Offset<IVectorInfo> hitPointOffset)
		{
			builder.AddOffset(10, hitPointOffset.Value, 0);
		}

		// Token: 0x0602307F RID: 143487 RVA: 0x004D22A4 File Offset: 0x004D04A4
		public static void AddDestructionActions(FlatBufferBuilder builder, VectorOffset destructionActionsOffset)
		{
			builder.AddOffset(11, destructionActionsOffset.Value, 0);
		}

		// Token: 0x06023080 RID: 143488 RVA: 0x004D22B8 File Offset: 0x004D04B8
		public static VectorOffset CreateDestructionActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023081 RID: 143489 RVA: 0x004D22F8 File Offset: 0x004D04F8
		public static VectorOffset CreateDestructionActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023082 RID: 143490 RVA: 0x004D2312 File Offset: 0x004D0512
		public static VectorOffset CreateDestructionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023083 RID: 143491 RVA: 0x004D2330 File Offset: 0x004D0530
		public static VectorOffset CreateDestructionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023084 RID: 143492 RVA: 0x004D2349 File Offset: 0x004D0549
		public static void StartDestructionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023085 RID: 143493 RVA: 0x004D2354 File Offset: 0x004D0554
		public static void AddSkillDamage(FlatBufferBuilder builder, Offset<ISkillDamage> skillDamageOffset)
		{
			builder.AddOffset(12, skillDamageOffset.Value, 0);
		}

		// Token: 0x06023086 RID: 143494 RVA: 0x004D2365 File Offset: 0x004D0565
		public static void AddElementDamage(FlatBufferBuilder builder, Offset<IElementDamage> elementDamageOffset)
		{
			builder.AddOffset(13, elementDamageOffset.Value, 0);
		}

		// Token: 0x06023087 RID: 143495 RVA: 0x004D2376 File Offset: 0x004D0576
		public static void AddWeaponDamage(FlatBufferBuilder builder, Offset<IWeaponDamage> weaponDamageOffset)
		{
			builder.AddOffset(14, weaponDamageOffset.Value, 0);
		}

		// Token: 0x06023088 RID: 143496 RVA: 0x004D2387 File Offset: 0x004D0587
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(15, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06023089 RID: 143497 RVA: 0x004D2398 File Offset: 0x004D0598
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602308A RID: 143498 RVA: 0x004D23CF File Offset: 0x004D05CF
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602308B RID: 143499 RVA: 0x004D23E9 File Offset: 0x004D05E9
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602308C RID: 143500 RVA: 0x004D2407 File Offset: 0x004D0607
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602308D RID: 143501 RVA: 0x004D2420 File Offset: 0x004D0620
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602308E RID: 143502 RVA: 0x004D242B File Offset: 0x004D062B
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(16, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0602308F RID: 143503 RVA: 0x004D243C File Offset: 0x004D063C
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023090 RID: 143504 RVA: 0x004D2473 File Offset: 0x004D0673
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023091 RID: 143505 RVA: 0x004D248D File Offset: 0x004D068D
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023092 RID: 143506 RVA: 0x004D24AB File Offset: 0x004D06AB
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023093 RID: 143507 RVA: 0x004D24C4 File Offset: 0x004D06C4
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023094 RID: 143508 RVA: 0x004D24CF File Offset: 0x004D06CF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(17, nullMask, 0);
		}

		// Token: 0x06023095 RID: 143509 RVA: 0x004D24DB File Offset: 0x004D06DB
		public static Offset<IDestructibleItem> EndIDestructibleItem(FlatBufferBuilder builder)
		{
			return new Offset<IDestructibleItem>(builder.EndTable());
		}

		// Token: 0x06023096 RID: 143510 RVA: 0x004D24E8 File Offset: 0x004D06E8
		public IDestructibleItemT UnPack()
		{
			IDestructibleItemT destructibleItemT = new IDestructibleItemT();
			this.UnPackTo(destructibleItemT);
			return destructibleItemT;
		}

		// Token: 0x06023097 RID: 143511 RVA: 0x004D2504 File Offset: 0x004D0704
		public void UnPackTo(IDestructibleItemT _o)
		{
			_o.Disabled = this.Disabled;
			_o.HitBullet = new THitBulletTypeUnion();
			_o.HitBullet.Type = this.HitBulletType;
			switch (this.HitBulletType)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeAllCharacterAttack>() != null) ? this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeCrystalAttack>() != null) ? this.HitBullet<IHitBulletTypeCrystalAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeFixedBulletId>() != null) ? this.HitBullet<IHitBulletTypeFixedBulletId>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeOnlyDropAttack>() != null) ? this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value.UnPack() : null);
				break;
			}
			_o.AttackerHitTimeScaleRatio = ((this.AttackerHitTimeScaleRatio != null) ? this.AttackerHitTimeScaleRatio.Value.UnPack() : null);
			_o.VictimHitTimeScaleRatio = ((this.VictimHitTimeScaleRatio != null) ? this.VictimHitTimeScaleRatio.Value.UnPack() : null);
			_o.AimParts = new List<IAimPartT>();
			for (int i = 0; i < this.AimPartsLength; i++)
			{
				_o.AimParts.Add((this.AimParts(i) != null) ? this.AimParts(i).Value.UnPack() : null);
			}
			_o.DurabilityId = this.DurabilityId;
			_o.Durability = this.Durability;
			_o.DurabilityWorn = ((this.DurabilityWorn != null) ? this.DurabilityWorn.Value.UnPack() : null);
			_o.DurabilityStateConfig = ((this.DurabilityStateConfig != null) ? this.DurabilityStateConfig.Value.UnPack() : null);
			_o.HitPoint = ((this.HitPoint != null) ? this.HitPoint.Value.UnPack() : null);
			_o.DestructionActions = new List<IActionInfoT>();
			for (int j = 0; j < this.DestructionActionsLength; j++)
			{
				_o.DestructionActions.Add((this.DestructionActions(j) != null) ? this.DestructionActions(j).Value.UnPack() : null);
			}
			_o.SkillDamage = ((this.SkillDamage != null) ? this.SkillDamage.Value.UnPack() : null);
			_o.ElementDamage = ((this.ElementDamage != null) ? this.ElementDamage.Value.UnPack() : null);
			_o.WeaponDamage = ((this.WeaponDamage != null) ? this.WeaponDamage.Value.UnPack() : null);
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int k = 0; k < this.MatchRoleOptionLength; k++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(k);
				switch (this.MatchRoleOptionType(k))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(k) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(k).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(k) != null) ? this.MatchRoleOption<IMatchPhantomRole>(k).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(k) != null) ? this.MatchRoleOption<IMatchPlayerRole>(k).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023098 RID: 143512 RVA: 0x004D2A40 File Offset: 0x004D0C40
		public static Offset<IDestructibleItem> Pack(FlatBufferBuilder builder, IDestructibleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestructibleItem>);
			}
			THitBulletType hitBullet_type = (_o.HitBullet == null) ? THitBulletType.NONE : _o.HitBullet.Type;
			int hitBulletOffset = (_o.HitBullet == null) ? 0 : THitBulletTypeUnion.Pack(builder, _o.HitBullet);
			Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset = (_o.AttackerHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.AttackerHitTimeScaleRatio);
			Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset = (_o.VictimHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.VictimHitTimeScaleRatio);
			VectorOffset aimPartsOffset = default(VectorOffset);
			if (_o.AimParts != null)
			{
				Offset<IAimPart>[] array = new Offset<IAimPart>[_o.AimParts.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAimPart.Pack(builder, _o.AimParts[i]);
				}
				aimPartsOffset = IDestructibleItem.CreateAimPartsVector(builder, array);
			}
			Offset<IDurabilityWorn> durabilityWornOffset = (_o.DurabilityWorn == null) ? default(Offset<IDurabilityWorn>) : IDurabilityWorn.Pack(builder, _o.DurabilityWorn);
			Offset<IDurabilityStateConfig> durabilityStateConfigOffset = (_o.DurabilityStateConfig == null) ? default(Offset<IDurabilityStateConfig>) : IDurabilityStateConfig.Pack(builder, _o.DurabilityStateConfig);
			Offset<IVectorInfo> hitPointOffset = (_o.HitPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.HitPoint);
			VectorOffset destructionActionsOffset = default(VectorOffset);
			if (_o.DestructionActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.DestructionActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.DestructionActions[j]);
				}
				destructionActionsOffset = IDestructibleItem.CreateDestructionActionsVector(builder, array2);
			}
			Offset<ISkillDamage> skillDamageOffset = (_o.SkillDamage == null) ? default(Offset<ISkillDamage>) : ISkillDamage.Pack(builder, _o.SkillDamage);
			Offset<IElementDamage> elementDamageOffset = (_o.ElementDamage == null) ? default(Offset<IElementDamage>) : IElementDamage.Pack(builder, _o.ElementDamage);
			Offset<IWeaponDamage> weaponDamageOffset = (_o.WeaponDamage == null) ? default(Offset<IWeaponDamage>) : IWeaponDamage.Pack(builder, _o.WeaponDamage);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array3 = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.MatchRoleOption[k].Type;
				}
				matchRoleOption_typeOffset = IDestructibleItem.CreateMatchRoleOptionTypeVector(builder, array3);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array4 = new int[_o.MatchRoleOption.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[l]);
				}
				matchRoleOptionOffset = IDestructibleItem.CreateMatchRoleOptionVector(builder, array4);
			}
			return IDestructibleItem.CreateIDestructibleItem(builder, _o.Disabled, hitBullet_type, hitBulletOffset, attackerHitTimeScaleRatioOffset, victimHitTimeScaleRatioOffset, aimPartsOffset, _o.DurabilityId, _o.Durability, durabilityWornOffset, durabilityStateConfigOffset, hitPointOffset, destructionActionsOffset, skillDamageOffset, elementDamageOffset, weaponDamageOffset, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.NullMask);
		}

		// Token: 0x0400EC8C RID: 60556
		private Table __p;
	}
}
