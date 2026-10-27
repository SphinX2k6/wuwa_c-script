using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A25 RID: 23077
	public struct ITargetGearComponent : IFlatbufferObject
	{
		// Token: 0x1700AD77 RID: 44407
		// (get) Token: 0x06027319 RID: 160537 RVA: 0x0056423F File Offset: 0x0056243F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602731A RID: 160538 RVA: 0x0056424C File Offset: 0x0056244C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602731B RID: 160539 RVA: 0x00564254 File Offset: 0x00562454
		public static ITargetGearComponent GetRootAsITargetGearComponent(ByteBuffer _bb)
		{
			return ITargetGearComponent.GetRootAsITargetGearComponent(_bb, default(ITargetGearComponent));
		}

		// Token: 0x0602731C RID: 160540 RVA: 0x00564270 File Offset: 0x00562470
		public static ITargetGearComponent GetRootAsITargetGearComponent(ByteBuffer _bb, ITargetGearComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602731D RID: 160541 RVA: 0x0056428D File Offset: 0x0056248D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602731E RID: 160542 RVA: 0x0056429C File Offset: 0x0056249C
		public ITargetGearComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD78 RID: 44408
		// (get) Token: 0x0602731F RID: 160543 RVA: 0x005642AC File Offset: 0x005624AC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD79 RID: 44409
		// (get) Token: 0x06027320 RID: 160544 RVA: 0x005642EC File Offset: 0x005624EC
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

		// Token: 0x06027321 RID: 160545 RVA: 0x00564328 File Offset: 0x00562528
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027322 RID: 160546 RVA: 0x0056436C File Offset: 0x0056256C
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06027323 RID: 160547 RVA: 0x00564388 File Offset: 0x00562588
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06027324 RID: 160548 RVA: 0x005643A4 File Offset: 0x005625A4
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06027325 RID: 160549 RVA: 0x005643C0 File Offset: 0x005625C0
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06027326 RID: 160550 RVA: 0x005643DC File Offset: 0x005625DC
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06027327 RID: 160551 RVA: 0x005643F8 File Offset: 0x005625F8
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700AD7A RID: 44410
		// (get) Token: 0x06027328 RID: 160552 RVA: 0x00564414 File Offset: 0x00562614
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

		// Token: 0x1700AD7B RID: 44411
		// (get) Token: 0x06027329 RID: 160553 RVA: 0x00564474 File Offset: 0x00562674
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

		// Token: 0x0602732A RID: 160554 RVA: 0x005644D4 File Offset: 0x005626D4
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD7C RID: 44412
		// (get) Token: 0x0602732B RID: 160555 RVA: 0x00564538 File Offset: 0x00562738
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

		// Token: 0x1700AD7D RID: 44413
		// (get) Token: 0x0602732C RID: 160556 RVA: 0x00564564 File Offset: 0x00562764
		public string Type
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

		// Token: 0x0602732D RID: 160557 RVA: 0x0056459C File Offset: 0x0056279C
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0602732E RID: 160558 RVA: 0x005645AC File Offset: 0x005627AC
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700AD7E RID: 44414
		// (get) Token: 0x0602732F RID: 160559 RVA: 0x005645BC File Offset: 0x005627BC
		public bool IsCycle
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD7F RID: 44415
		// (get) Token: 0x06027330 RID: 160560 RVA: 0x005645FC File Offset: 0x005627FC
		public int CycleInterval
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

		// Token: 0x06027331 RID: 160561 RVA: 0x0056463C File Offset: 0x0056283C
		public string CycleStates(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AD80 RID: 44416
		// (get) Token: 0x06027332 RID: 160562 RVA: 0x00564678 File Offset: 0x00562878
		public int CycleStatesLength
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

		// Token: 0x1700AD81 RID: 44417
		// (get) Token: 0x06027333 RID: 160563 RVA: 0x005646A4 File Offset: 0x005628A4
		public THitLogicType HitLogicTypeType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return THitLogicType.NONE;
				}
				return (THitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027334 RID: 160564 RVA: 0x005646E4 File Offset: 0x005628E4
		public TTable? HitLogicType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027335 RID: 160565 RVA: 0x0056472C File Offset: 0x0056292C
		public IHitLogicActionByHitType HitLogicTypeAsIHitLogicActionByHitType()
		{
			return this.HitLogicType<IHitLogicActionByHitType>().Value;
		}

		// Token: 0x06027336 RID: 160566 RVA: 0x00564748 File Offset: 0x00562948
		public IHitLogicChangeByPartHit HitLogicTypeAsIHitLogicChangeByPartHit()
		{
			return this.HitLogicType<IHitLogicChangeByPartHit>().Value;
		}

		// Token: 0x06027337 RID: 160567 RVA: 0x00564764 File Offset: 0x00562964
		public IHitLogicChangeCountDownState HitLogicTypeAsIHitLogicChangeCountDownState()
		{
			return this.HitLogicType<IHitLogicChangeCountDownState>().Value;
		}

		// Token: 0x06027338 RID: 160568 RVA: 0x00564780 File Offset: 0x00562980
		public IHitLogicChangeLockState HitLogicTypeAsIHitLogicChangeLockState()
		{
			return this.HitLogicType<IHitLogicChangeLockState>().Value;
		}

		// Token: 0x06027339 RID: 160569 RVA: 0x0056479C File Offset: 0x0056299C
		public IHitLogicChangeNextAndLockTargetState HitLogicTypeAsIHitLogicChangeNextAndLockTargetState()
		{
			return this.HitLogicType<IHitLogicChangeNextAndLockTargetState>().Value;
		}

		// Token: 0x0602733A RID: 160570 RVA: 0x005647B8 File Offset: 0x005629B8
		public IHitLogicChangeNextState HitLogicTypeAsIHitLogicChangeNextState()
		{
			return this.HitLogicType<IHitLogicChangeNextState>().Value;
		}

		// Token: 0x0602733B RID: 160571 RVA: 0x005647D4 File Offset: 0x005629D4
		public IHitLogicChangeTargetState HitLogicTypeAsIHitLogicChangeTargetState()
		{
			return this.HitLogicType<IHitLogicChangeTargetState>().Value;
		}

		// Token: 0x1700AD82 RID: 44418
		// (get) Token: 0x0602733C RID: 160572 RVA: 0x005647F0 File Offset: 0x005629F0
		public ISplineMove? Patrol
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new ISplineMove?(default(ISplineMove).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD83 RID: 44419
		// (get) Token: 0x0602733D RID: 160573 RVA: 0x00564850 File Offset: 0x00562A50
		public float HitCd
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD84 RID: 44420
		// (get) Token: 0x0602733E RID: 160574 RVA: 0x00564894 File Offset: 0x00562A94
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602733F RID: 160575 RVA: 0x005648D4 File Offset: 0x00562AD4
		public static Offset<ITargetGearComponent> CreateITargetGearComponent(FlatBufferBuilder builder, bool Disabled = false, THitBulletType HitBullet_type = THitBulletType.NONE, int HitBulletOffset = 0, Offset<IHitTimeScaleRatio> AttackerHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), Offset<IHitTimeScaleRatio> VictimHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), VectorOffset AimPartsOffset = default(VectorOffset), StringOffset TypeOffset = default(StringOffset), bool IsCycle = false, int CycleInterval = 0, VectorOffset CycleStatesOffset = default(VectorOffset), THitLogicType HitLogicType_type = THitLogicType.NONE, int HitLogicTypeOffset = 0, Offset<ISplineMove> PatrolOffset = default(Offset<ISplineMove>), float HitCd = 0f, byte NullMask = 0)
		{
			builder.StartTable(15);
			ITargetGearComponent.AddHitCd(builder, HitCd);
			ITargetGearComponent.AddPatrol(builder, PatrolOffset);
			ITargetGearComponent.AddHitLogicType(builder, HitLogicTypeOffset);
			ITargetGearComponent.AddCycleStates(builder, CycleStatesOffset);
			ITargetGearComponent.AddCycleInterval(builder, CycleInterval);
			ITargetGearComponent.AddType(builder, TypeOffset);
			ITargetGearComponent.AddAimParts(builder, AimPartsOffset);
			ITargetGearComponent.AddVictimHitTimeScaleRatio(builder, VictimHitTimeScaleRatioOffset);
			ITargetGearComponent.AddAttackerHitTimeScaleRatio(builder, AttackerHitTimeScaleRatioOffset);
			ITargetGearComponent.AddHitBullet(builder, HitBulletOffset);
			ITargetGearComponent.AddNullMask(builder, NullMask);
			ITargetGearComponent.AddHitLogicTypeType(builder, HitLogicType_type);
			ITargetGearComponent.AddIsCycle(builder, IsCycle);
			ITargetGearComponent.AddHitBulletType(builder, HitBullet_type);
			ITargetGearComponent.AddDisabled(builder, Disabled);
			return ITargetGearComponent.EndITargetGearComponent(builder);
		}

		// Token: 0x06027340 RID: 160576 RVA: 0x00564964 File Offset: 0x00562B64
		public static void StartITargetGearComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x06027341 RID: 160577 RVA: 0x0056496E File Offset: 0x00562B6E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027342 RID: 160578 RVA: 0x00564979 File Offset: 0x00562B79
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x06027343 RID: 160579 RVA: 0x00564984 File Offset: 0x00562B84
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x06027344 RID: 160580 RVA: 0x0056498F File Offset: 0x00562B8F
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06027345 RID: 160581 RVA: 0x0056499F File Offset: 0x00562B9F
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06027346 RID: 160582 RVA: 0x005649AF File Offset: 0x00562BAF
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x06027347 RID: 160583 RVA: 0x005649C0 File Offset: 0x00562BC0
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027348 RID: 160584 RVA: 0x00564A00 File Offset: 0x00562C00
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027349 RID: 160585 RVA: 0x00564A1A File Offset: 0x00562C1A
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602734A RID: 160586 RVA: 0x00564A38 File Offset: 0x00562C38
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602734B RID: 160587 RVA: 0x00564A51 File Offset: 0x00562C51
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602734C RID: 160588 RVA: 0x00564A5C File Offset: 0x00562C5C
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(6, typeOffset.Value, 0);
		}

		// Token: 0x0602734D RID: 160589 RVA: 0x00564A6C File Offset: 0x00562C6C
		public static void AddIsCycle(FlatBufferBuilder builder, bool isCycle)
		{
			builder.AddBool(7, isCycle, false);
		}

		// Token: 0x0602734E RID: 160590 RVA: 0x00564A77 File Offset: 0x00562C77
		public static void AddCycleInterval(FlatBufferBuilder builder, int cycleInterval)
		{
			builder.AddInt(8, cycleInterval, 0);
		}

		// Token: 0x0602734F RID: 160591 RVA: 0x00564A82 File Offset: 0x00562C82
		public static void AddCycleStates(FlatBufferBuilder builder, VectorOffset cycleStatesOffset)
		{
			builder.AddOffset(9, cycleStatesOffset.Value, 0);
		}

		// Token: 0x06027350 RID: 160592 RVA: 0x00564A94 File Offset: 0x00562C94
		public static VectorOffset CreateCycleStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027351 RID: 160593 RVA: 0x00564AD4 File Offset: 0x00562CD4
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06027352 RID: 160594 RVA: 0x00564AEE File Offset: 0x00562CEE
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06027353 RID: 160595 RVA: 0x00564B0C File Offset: 0x00562D0C
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027354 RID: 160596 RVA: 0x00564B25 File Offset: 0x00562D25
		public static void StartCycleStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027355 RID: 160597 RVA: 0x00564B30 File Offset: 0x00562D30
		public static void AddHitLogicTypeType(FlatBufferBuilder builder, THitLogicType hitLogicTypeType)
		{
			builder.AddByte(10, (byte)hitLogicTypeType, 0);
		}

		// Token: 0x06027356 RID: 160598 RVA: 0x00564B3C File Offset: 0x00562D3C
		public static void AddHitLogicType(FlatBufferBuilder builder, int hitLogicTypeOffset)
		{
			builder.AddOffset(11, hitLogicTypeOffset, 0);
		}

		// Token: 0x06027357 RID: 160599 RVA: 0x00564B48 File Offset: 0x00562D48
		public static void AddPatrol(FlatBufferBuilder builder, Offset<ISplineMove> patrolOffset)
		{
			builder.AddOffset(12, patrolOffset.Value, 0);
		}

		// Token: 0x06027358 RID: 160600 RVA: 0x00564B59 File Offset: 0x00562D59
		public static void AddHitCd(FlatBufferBuilder builder, float hitCd)
		{
			builder.AddFloat(13, hitCd, 0.0);
		}

		// Token: 0x06027359 RID: 160601 RVA: 0x00564B6D File Offset: 0x00562D6D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x0602735A RID: 160602 RVA: 0x00564B79 File Offset: 0x00562D79
		public static Offset<ITargetGearComponent> EndITargetGearComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearComponent>(builder.EndTable());
		}

		// Token: 0x0602735B RID: 160603 RVA: 0x00564B88 File Offset: 0x00562D88
		public ITargetGearComponentT UnPack()
		{
			ITargetGearComponentT targetGearComponentT = new ITargetGearComponentT();
			this.UnPackTo(targetGearComponentT);
			return targetGearComponentT;
		}

		// Token: 0x0602735C RID: 160604 RVA: 0x00564BA4 File Offset: 0x00562DA4
		public void UnPackTo(ITargetGearComponentT _o)
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
			_o.Type = this.Type;
			_o.IsCycle = this.IsCycle;
			_o.CycleInterval = this.CycleInterval;
			_o.CycleStates = new List<string>();
			for (int j = 0; j < this.CycleStatesLength; j++)
			{
				_o.CycleStates.Add(this.CycleStates(j));
			}
			_o.HitLogicType = new THitLogicTypeUnion();
			_o.HitLogicType.Type = this.HitLogicTypeType;
			switch (this.HitLogicTypeType)
			{
			case THitLogicType.IHitLogicActionByHitType:
				_o.HitLogicType.Value = ((this.HitLogicType<IHitLogicActionByHitType>() != null) ? this.HitLogicType<IHitLogicActionByHitType>().Value.UnPack() : null);
				break;
			case THitLogicType.IHitLogicChangeByPartHit:
				_o.HitLogicType.Value = ((this.HitLogicType<IHitLogicChangeByPartHit>() != null) ? this.HitLogicType<IHitLogicChangeByPartHit>().Value.UnPack() : null);
				break;
			case THitLogicType.IHitLogicChangeCountDownState:
				_o.HitLogicType.Value = ((this.HitLogicType<IHitLogicChangeCountDownState>() != null) ? this.HitLogicType<IHitLogicChangeCountDownState>().Value.UnPack() : null);
				break;
			case THitLogicType.IHitLogicChangeLockState:
				_o.HitLogicType.Value = ((this.HitLogicType<IHitLogicChangeLockState>() != null) ? this.HitLogicType<IHitLogicChangeLockState>().Value.UnPack() : null);
				break;
			case THitLogicType.IHitLogicChangeNextAndLockTargetState:
				_o.HitLogicType.Value = ((this.HitLogicType<IHitLogicChangeNextAndLockTargetState>() != null) ? this.HitLogicType<IHitLogicChangeNextAndLockTargetState>().Value.UnPack() : null);
				break;
			case THitLogicType.IHitLogicChangeNextState:
				_o.HitLogicType.Value = ((this.HitLogicType<IHitLogicChangeNextState>() != null) ? this.HitLogicType<IHitLogicChangeNextState>().Value.UnPack() : null);
				break;
			case THitLogicType.IHitLogicChangeTargetState:
				_o.HitLogicType.Value = ((this.HitLogicType<IHitLogicChangeTargetState>() != null) ? this.HitLogicType<IHitLogicChangeTargetState>().Value.UnPack() : null);
				break;
			}
			_o.Patrol = ((this.Patrol != null) ? this.Patrol.Value.UnPack() : null);
			_o.HitCd = this.HitCd;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602735D RID: 160605 RVA: 0x005650A4 File Offset: 0x005632A4
		public static Offset<ITargetGearComponent> Pack(FlatBufferBuilder builder, ITargetGearComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearComponent>);
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
				aimPartsOffset = ITargetGearComponent.CreateAimPartsVector(builder, array);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			VectorOffset cycleStatesOffset = default(VectorOffset);
			if (_o.CycleStates != null)
			{
				StringOffset[] array2 = new StringOffset[_o.CycleStates.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.CycleStates[j]);
				}
				cycleStatesOffset = ITargetGearComponent.CreateCycleStatesVector(builder, array2);
			}
			THitLogicType hitLogicType_type = (_o.HitLogicType == null) ? THitLogicType.NONE : _o.HitLogicType.Type;
			int hitLogicTypeOffset = (_o.HitLogicType == null) ? 0 : THitLogicTypeUnion.Pack(builder, _o.HitLogicType);
			Offset<ISplineMove> patrolOffset = (_o.Patrol == null) ? default(Offset<ISplineMove>) : ISplineMove.Pack(builder, _o.Patrol);
			return ITargetGearComponent.CreateITargetGearComponent(builder, _o.Disabled, hitBullet_type, hitBulletOffset, attackerHitTimeScaleRatioOffset, victimHitTimeScaleRatioOffset, aimPartsOffset, typeOffset, _o.IsCycle, _o.CycleInterval, cycleStatesOffset, hitLogicType_type, hitLogicTypeOffset, patrolOffset, _o.HitCd, _o.NullMask);
		}

		// Token: 0x0400F07C RID: 61564
		private Table __p;
	}
}
