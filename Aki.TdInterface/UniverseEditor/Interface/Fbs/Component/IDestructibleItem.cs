using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005087 RID: 20615
	public struct IDestructibleItem : IFlatbufferObject
	{
		// Token: 0x17009597 RID: 38295
		// (get) Token: 0x060210F5 RID: 135413 RVA: 0x00497967 File Offset: 0x00495B67
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060210F6 RID: 135414 RVA: 0x00497974 File Offset: 0x00495B74
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060210F7 RID: 135415 RVA: 0x0049797C File Offset: 0x00495B7C
		public static IDestructibleItem GetRootAsIDestructibleItem(ByteBuffer _bb)
		{
			return IDestructibleItem.GetRootAsIDestructibleItem(_bb, default(IDestructibleItem));
		}

		// Token: 0x060210F8 RID: 135416 RVA: 0x00497998 File Offset: 0x00495B98
		public static IDestructibleItem GetRootAsIDestructibleItem(ByteBuffer _bb, IDestructibleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060210F9 RID: 135417 RVA: 0x004979B5 File Offset: 0x00495BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060210FA RID: 135418 RVA: 0x004979C4 File Offset: 0x00495BC4
		public IDestructibleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009598 RID: 38296
		// (get) Token: 0x060210FB RID: 135419 RVA: 0x004979D4 File Offset: 0x00495BD4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009599 RID: 38297
		// (get) Token: 0x060210FC RID: 135420 RVA: 0x00497A14 File Offset: 0x00495C14
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

		// Token: 0x060210FD RID: 135421 RVA: 0x00497A50 File Offset: 0x00495C50
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060210FE RID: 135422 RVA: 0x00497A94 File Offset: 0x00495C94
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x060210FF RID: 135423 RVA: 0x00497AB0 File Offset: 0x00495CB0
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06021100 RID: 135424 RVA: 0x00497ACC File Offset: 0x00495CCC
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06021101 RID: 135425 RVA: 0x00497AE8 File Offset: 0x00495CE8
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06021102 RID: 135426 RVA: 0x00497B04 File Offset: 0x00495D04
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06021103 RID: 135427 RVA: 0x00497B20 File Offset: 0x00495D20
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700959A RID: 38298
		// (get) Token: 0x06021104 RID: 135428 RVA: 0x00497B3C File Offset: 0x00495D3C
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

		// Token: 0x1700959B RID: 38299
		// (get) Token: 0x06021105 RID: 135429 RVA: 0x00497B9C File Offset: 0x00495D9C
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

		// Token: 0x06021106 RID: 135430 RVA: 0x00497BFC File Offset: 0x00495DFC
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700959C RID: 38300
		// (get) Token: 0x06021107 RID: 135431 RVA: 0x00497C60 File Offset: 0x00495E60
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

		// Token: 0x1700959D RID: 38301
		// (get) Token: 0x06021108 RID: 135432 RVA: 0x00497C8C File Offset: 0x00495E8C
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

		// Token: 0x1700959E RID: 38302
		// (get) Token: 0x06021109 RID: 135433 RVA: 0x00497CCC File Offset: 0x00495ECC
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

		// Token: 0x1700959F RID: 38303
		// (get) Token: 0x0602110A RID: 135434 RVA: 0x00497D0C File Offset: 0x00495F0C
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

		// Token: 0x170095A0 RID: 38304
		// (get) Token: 0x0602110B RID: 135435 RVA: 0x00497D6C File Offset: 0x00495F6C
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

		// Token: 0x170095A1 RID: 38305
		// (get) Token: 0x0602110C RID: 135436 RVA: 0x00497DCC File Offset: 0x00495FCC
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

		// Token: 0x0602110D RID: 135437 RVA: 0x00497E2C File Offset: 0x0049602C
		public IActionInfo? DestructionActions(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170095A2 RID: 38306
		// (get) Token: 0x0602110E RID: 135438 RVA: 0x00497E90 File Offset: 0x00496090
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

		// Token: 0x170095A3 RID: 38307
		// (get) Token: 0x0602110F RID: 135439 RVA: 0x00497EBC File Offset: 0x004960BC
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

		// Token: 0x170095A4 RID: 38308
		// (get) Token: 0x06021110 RID: 135440 RVA: 0x00497F1C File Offset: 0x0049611C
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

		// Token: 0x170095A5 RID: 38309
		// (get) Token: 0x06021111 RID: 135441 RVA: 0x00497F7C File Offset: 0x0049617C
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

		// Token: 0x06021112 RID: 135442 RVA: 0x00497FDC File Offset: 0x004961DC
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170095A6 RID: 38310
		// (get) Token: 0x06021113 RID: 135443 RVA: 0x0049801C File Offset: 0x0049621C
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

		// Token: 0x06021114 RID: 135444 RVA: 0x00498048 File Offset: 0x00496248
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(34, 1);
		}

		// Token: 0x06021115 RID: 135445 RVA: 0x00498058 File Offset: 0x00496258
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

		// Token: 0x06021116 RID: 135446 RVA: 0x004980C4 File Offset: 0x004962C4
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170095A7 RID: 38311
		// (get) Token: 0x06021117 RID: 135447 RVA: 0x0049810C File Offset: 0x0049630C
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

		// Token: 0x170095A8 RID: 38312
		// (get) Token: 0x06021118 RID: 135448 RVA: 0x00498138 File Offset: 0x00496338
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

		// Token: 0x06021119 RID: 135449 RVA: 0x00498178 File Offset: 0x00496378
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

		// Token: 0x0602111A RID: 135450 RVA: 0x00498220 File Offset: 0x00496420
		public static void StartIDestructibleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(18);
		}

		// Token: 0x0602111B RID: 135451 RVA: 0x0049822A File Offset: 0x0049642A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602111C RID: 135452 RVA: 0x00498235 File Offset: 0x00496435
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x0602111D RID: 135453 RVA: 0x00498240 File Offset: 0x00496440
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x0602111E RID: 135454 RVA: 0x0049824B File Offset: 0x0049644B
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x0602111F RID: 135455 RVA: 0x0049825B File Offset: 0x0049645B
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06021120 RID: 135456 RVA: 0x0049826B File Offset: 0x0049646B
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x06021121 RID: 135457 RVA: 0x0049827C File Offset: 0x0049647C
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021122 RID: 135458 RVA: 0x004982BC File Offset: 0x004964BC
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021123 RID: 135459 RVA: 0x004982D6 File Offset: 0x004964D6
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021124 RID: 135460 RVA: 0x004982F4 File Offset: 0x004964F4
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021125 RID: 135461 RVA: 0x0049830D File Offset: 0x0049650D
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021126 RID: 135462 RVA: 0x00498318 File Offset: 0x00496518
		public static void AddDurabilityId(FlatBufferBuilder builder, int durabilityId)
		{
			builder.AddInt(6, durabilityId, 0);
		}

		// Token: 0x06021127 RID: 135463 RVA: 0x00498323 File Offset: 0x00496523
		public static void AddDurability(FlatBufferBuilder builder, int durability)
		{
			builder.AddInt(7, durability, 0);
		}

		// Token: 0x06021128 RID: 135464 RVA: 0x0049832E File Offset: 0x0049652E
		public static void AddDurabilityWorn(FlatBufferBuilder builder, Offset<IDurabilityWorn> durabilityWornOffset)
		{
			builder.AddOffset(8, durabilityWornOffset.Value, 0);
		}

		// Token: 0x06021129 RID: 135465 RVA: 0x0049833E File Offset: 0x0049653E
		public static void AddDurabilityStateConfig(FlatBufferBuilder builder, Offset<IDurabilityStateConfig> durabilityStateConfigOffset)
		{
			builder.AddOffset(9, durabilityStateConfigOffset.Value, 0);
		}

		// Token: 0x0602112A RID: 135466 RVA: 0x0049834F File Offset: 0x0049654F
		public static void AddHitPoint(FlatBufferBuilder builder, Offset<IVectorInfo> hitPointOffset)
		{
			builder.AddOffset(10, hitPointOffset.Value, 0);
		}

		// Token: 0x0602112B RID: 135467 RVA: 0x00498360 File Offset: 0x00496560
		public static void AddDestructionActions(FlatBufferBuilder builder, VectorOffset destructionActionsOffset)
		{
			builder.AddOffset(11, destructionActionsOffset.Value, 0);
		}

		// Token: 0x0602112C RID: 135468 RVA: 0x00498374 File Offset: 0x00496574
		public static VectorOffset CreateDestructionActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602112D RID: 135469 RVA: 0x004983B4 File Offset: 0x004965B4
		public static VectorOffset CreateDestructionActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602112E RID: 135470 RVA: 0x004983CE File Offset: 0x004965CE
		public static VectorOffset CreateDestructionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602112F RID: 135471 RVA: 0x004983EC File Offset: 0x004965EC
		public static VectorOffset CreateDestructionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021130 RID: 135472 RVA: 0x00498405 File Offset: 0x00496605
		public static void StartDestructionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021131 RID: 135473 RVA: 0x00498410 File Offset: 0x00496610
		public static void AddSkillDamage(FlatBufferBuilder builder, Offset<ISkillDamage> skillDamageOffset)
		{
			builder.AddOffset(12, skillDamageOffset.Value, 0);
		}

		// Token: 0x06021132 RID: 135474 RVA: 0x00498421 File Offset: 0x00496621
		public static void AddElementDamage(FlatBufferBuilder builder, Offset<IElementDamage> elementDamageOffset)
		{
			builder.AddOffset(13, elementDamageOffset.Value, 0);
		}

		// Token: 0x06021133 RID: 135475 RVA: 0x00498432 File Offset: 0x00496632
		public static void AddWeaponDamage(FlatBufferBuilder builder, Offset<IWeaponDamage> weaponDamageOffset)
		{
			builder.AddOffset(14, weaponDamageOffset.Value, 0);
		}

		// Token: 0x06021134 RID: 135476 RVA: 0x00498443 File Offset: 0x00496643
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(15, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06021135 RID: 135477 RVA: 0x00498454 File Offset: 0x00496654
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021136 RID: 135478 RVA: 0x0049848B File Offset: 0x0049668B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06021137 RID: 135479 RVA: 0x004984A5 File Offset: 0x004966A5
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06021138 RID: 135480 RVA: 0x004984C3 File Offset: 0x004966C3
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021139 RID: 135481 RVA: 0x004984DC File Offset: 0x004966DC
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602113A RID: 135482 RVA: 0x004984E7 File Offset: 0x004966E7
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(16, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0602113B RID: 135483 RVA: 0x004984F8 File Offset: 0x004966F8
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602113C RID: 135484 RVA: 0x0049852F File Offset: 0x0049672F
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602113D RID: 135485 RVA: 0x00498549 File Offset: 0x00496749
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602113E RID: 135486 RVA: 0x00498567 File Offset: 0x00496767
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602113F RID: 135487 RVA: 0x00498580 File Offset: 0x00496780
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021140 RID: 135488 RVA: 0x0049858B File Offset: 0x0049678B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(17, nullMask, 0);
		}

		// Token: 0x06021141 RID: 135489 RVA: 0x00498597 File Offset: 0x00496797
		public static Offset<IDestructibleItem> EndIDestructibleItem(FlatBufferBuilder builder)
		{
			return new Offset<IDestructibleItem>(builder.EndTable());
		}

		// Token: 0x06021142 RID: 135490 RVA: 0x004985A4 File Offset: 0x004967A4
		public IDestructibleItemT UnPack()
		{
			IDestructibleItemT destructibleItemT = new IDestructibleItemT();
			this.UnPackTo(destructibleItemT);
			return destructibleItemT;
		}

		// Token: 0x06021143 RID: 135491 RVA: 0x004985C0 File Offset: 0x004967C0
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
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(k);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(k) != null) ? this.MatchRoleOption<IMatchPlayerRole>(k).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(k) != null) ? this.MatchRoleOption<IMatchPhantomRole>(k).Value.UnPack() : null);
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021144 RID: 135492 RVA: 0x00498AB4 File Offset: 0x00496CB4
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

		// Token: 0x0400E08F RID: 57487
		private Table __p;
	}
}
