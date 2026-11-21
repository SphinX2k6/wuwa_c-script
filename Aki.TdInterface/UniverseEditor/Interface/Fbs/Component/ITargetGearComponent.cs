using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006032 RID: 24626
	public struct ITargetGearComponent : IFlatbufferObject
	{
		// Token: 0x1700B6AF RID: 46767
		// (get) Token: 0x06029891 RID: 170129 RVA: 0x005AB203 File Offset: 0x005A9403
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029892 RID: 170130 RVA: 0x005AB210 File Offset: 0x005A9410
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029893 RID: 170131 RVA: 0x005AB218 File Offset: 0x005A9418
		public static ITargetGearComponent GetRootAsITargetGearComponent(ByteBuffer _bb)
		{
			return ITargetGearComponent.GetRootAsITargetGearComponent(_bb, default(ITargetGearComponent));
		}

		// Token: 0x06029894 RID: 170132 RVA: 0x005AB234 File Offset: 0x005A9434
		public static ITargetGearComponent GetRootAsITargetGearComponent(ByteBuffer _bb, ITargetGearComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029895 RID: 170133 RVA: 0x005AB251 File Offset: 0x005A9451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029896 RID: 170134 RVA: 0x005AB260 File Offset: 0x005A9460
		public ITargetGearComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6B0 RID: 46768
		// (get) Token: 0x06029897 RID: 170135 RVA: 0x005AB270 File Offset: 0x005A9470
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6B1 RID: 46769
		// (get) Token: 0x06029898 RID: 170136 RVA: 0x005AB2B0 File Offset: 0x005A94B0
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

		// Token: 0x06029899 RID: 170137 RVA: 0x005AB2EC File Offset: 0x005A94EC
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602989A RID: 170138 RVA: 0x005AB330 File Offset: 0x005A9530
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x0602989B RID: 170139 RVA: 0x005AB34C File Offset: 0x005A954C
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x0602989C RID: 170140 RVA: 0x005AB368 File Offset: 0x005A9568
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x0602989D RID: 170141 RVA: 0x005AB384 File Offset: 0x005A9584
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x0602989E RID: 170142 RVA: 0x005AB3A0 File Offset: 0x005A95A0
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x0602989F RID: 170143 RVA: 0x005AB3BC File Offset: 0x005A95BC
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700B6B2 RID: 46770
		// (get) Token: 0x060298A0 RID: 170144 RVA: 0x005AB3D8 File Offset: 0x005A95D8
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

		// Token: 0x1700B6B3 RID: 46771
		// (get) Token: 0x060298A1 RID: 170145 RVA: 0x005AB438 File Offset: 0x005A9638
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

		// Token: 0x060298A2 RID: 170146 RVA: 0x005AB498 File Offset: 0x005A9698
		public IAimPart? AimParts(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IAimPart?(default(IAimPart).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B6B4 RID: 46772
		// (get) Token: 0x060298A3 RID: 170147 RVA: 0x005AB4FC File Offset: 0x005A96FC
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

		// Token: 0x1700B6B5 RID: 46773
		// (get) Token: 0x060298A4 RID: 170148 RVA: 0x005AB528 File Offset: 0x005A9728
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

		// Token: 0x060298A5 RID: 170149 RVA: 0x005AB560 File Offset: 0x005A9760
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060298A6 RID: 170150 RVA: 0x005AB570 File Offset: 0x005A9770
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700B6B6 RID: 46774
		// (get) Token: 0x060298A7 RID: 170151 RVA: 0x005AB580 File Offset: 0x005A9780
		public bool IsCycle
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6B7 RID: 46775
		// (get) Token: 0x060298A8 RID: 170152 RVA: 0x005AB5C0 File Offset: 0x005A97C0
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

		// Token: 0x060298A9 RID: 170153 RVA: 0x005AB600 File Offset: 0x005A9800
		public string CycleStates(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B6B8 RID: 46776
		// (get) Token: 0x060298AA RID: 170154 RVA: 0x005AB63C File Offset: 0x005A983C
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

		// Token: 0x1700B6B9 RID: 46777
		// (get) Token: 0x060298AB RID: 170155 RVA: 0x005AB668 File Offset: 0x005A9868
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

		// Token: 0x060298AC RID: 170156 RVA: 0x005AB6A8 File Offset: 0x005A98A8
		public TTable? HitLogicType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060298AD RID: 170157 RVA: 0x005AB6F0 File Offset: 0x005A98F0
		public IHitLogicActionByHitType HitLogicTypeAsIHitLogicActionByHitType()
		{
			return this.HitLogicType<IHitLogicActionByHitType>().Value;
		}

		// Token: 0x060298AE RID: 170158 RVA: 0x005AB70C File Offset: 0x005A990C
		public IHitLogicChangeByPartHit HitLogicTypeAsIHitLogicChangeByPartHit()
		{
			return this.HitLogicType<IHitLogicChangeByPartHit>().Value;
		}

		// Token: 0x060298AF RID: 170159 RVA: 0x005AB728 File Offset: 0x005A9928
		public IHitLogicChangeCountDownState HitLogicTypeAsIHitLogicChangeCountDownState()
		{
			return this.HitLogicType<IHitLogicChangeCountDownState>().Value;
		}

		// Token: 0x060298B0 RID: 170160 RVA: 0x005AB744 File Offset: 0x005A9944
		public IHitLogicChangeLockState HitLogicTypeAsIHitLogicChangeLockState()
		{
			return this.HitLogicType<IHitLogicChangeLockState>().Value;
		}

		// Token: 0x060298B1 RID: 170161 RVA: 0x005AB760 File Offset: 0x005A9960
		public IHitLogicChangeNextAndLockTargetState HitLogicTypeAsIHitLogicChangeNextAndLockTargetState()
		{
			return this.HitLogicType<IHitLogicChangeNextAndLockTargetState>().Value;
		}

		// Token: 0x060298B2 RID: 170162 RVA: 0x005AB77C File Offset: 0x005A997C
		public IHitLogicChangeNextState HitLogicTypeAsIHitLogicChangeNextState()
		{
			return this.HitLogicType<IHitLogicChangeNextState>().Value;
		}

		// Token: 0x060298B3 RID: 170163 RVA: 0x005AB798 File Offset: 0x005A9998
		public IHitLogicChangeTargetState HitLogicTypeAsIHitLogicChangeTargetState()
		{
			return this.HitLogicType<IHitLogicChangeTargetState>().Value;
		}

		// Token: 0x1700B6BA RID: 46778
		// (get) Token: 0x060298B4 RID: 170164 RVA: 0x005AB7B4 File Offset: 0x005A99B4
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

		// Token: 0x1700B6BB RID: 46779
		// (get) Token: 0x060298B5 RID: 170165 RVA: 0x005AB814 File Offset: 0x005A9A14
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

		// Token: 0x1700B6BC RID: 46780
		// (get) Token: 0x060298B6 RID: 170166 RVA: 0x005AB858 File Offset: 0x005A9A58
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

		// Token: 0x060298B7 RID: 170167 RVA: 0x005AB898 File Offset: 0x005A9A98
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

		// Token: 0x060298B8 RID: 170168 RVA: 0x005AB928 File Offset: 0x005A9B28
		public static void StartITargetGearComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x060298B9 RID: 170169 RVA: 0x005AB932 File Offset: 0x005A9B32
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060298BA RID: 170170 RVA: 0x005AB93D File Offset: 0x005A9B3D
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(1, (byte)hitBulletType, 0);
		}

		// Token: 0x060298BB RID: 170171 RVA: 0x005AB948 File Offset: 0x005A9B48
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(2, hitBulletOffset, 0);
		}

		// Token: 0x060298BC RID: 170172 RVA: 0x005AB953 File Offset: 0x005A9B53
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060298BD RID: 170173 RVA: 0x005AB963 File Offset: 0x005A9B63
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(4, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060298BE RID: 170174 RVA: 0x005AB973 File Offset: 0x005A9B73
		public static void AddAimParts(FlatBufferBuilder builder, VectorOffset aimPartsOffset)
		{
			builder.AddOffset(5, aimPartsOffset.Value, 0);
		}

		// Token: 0x060298BF RID: 170175 RVA: 0x005AB984 File Offset: 0x005A9B84
		public static VectorOffset CreateAimPartsVector(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060298C0 RID: 170176 RVA: 0x005AB9C4 File Offset: 0x005A9BC4
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, Offset<IAimPart>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x060298C1 RID: 170177 RVA: 0x005AB9DE File Offset: 0x005A9BDE
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAimPart>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAimPart>>(data);
			return builder.EndVector();
		}

		// Token: 0x060298C2 RID: 170178 RVA: 0x005AB9FC File Offset: 0x005A9BFC
		public static VectorOffset CreateAimPartsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAimPart>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060298C3 RID: 170179 RVA: 0x005ABA15 File Offset: 0x005A9C15
		public static void StartAimPartsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060298C4 RID: 170180 RVA: 0x005ABA20 File Offset: 0x005A9C20
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(6, typeOffset.Value, 0);
		}

		// Token: 0x060298C5 RID: 170181 RVA: 0x005ABA30 File Offset: 0x005A9C30
		public static void AddIsCycle(FlatBufferBuilder builder, bool isCycle)
		{
			builder.AddBool(7, isCycle, false);
		}

		// Token: 0x060298C6 RID: 170182 RVA: 0x005ABA3B File Offset: 0x005A9C3B
		public static void AddCycleInterval(FlatBufferBuilder builder, int cycleInterval)
		{
			builder.AddInt(8, cycleInterval, 0);
		}

		// Token: 0x060298C7 RID: 170183 RVA: 0x005ABA46 File Offset: 0x005A9C46
		public static void AddCycleStates(FlatBufferBuilder builder, VectorOffset cycleStatesOffset)
		{
			builder.AddOffset(9, cycleStatesOffset.Value, 0);
		}

		// Token: 0x060298C8 RID: 170184 RVA: 0x005ABA58 File Offset: 0x005A9C58
		public static VectorOffset CreateCycleStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060298C9 RID: 170185 RVA: 0x005ABA98 File Offset: 0x005A9C98
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060298CA RID: 170186 RVA: 0x005ABAB2 File Offset: 0x005A9CB2
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060298CB RID: 170187 RVA: 0x005ABAD0 File Offset: 0x005A9CD0
		public static VectorOffset CreateCycleStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060298CC RID: 170188 RVA: 0x005ABAE9 File Offset: 0x005A9CE9
		public static void StartCycleStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060298CD RID: 170189 RVA: 0x005ABAF4 File Offset: 0x005A9CF4
		public static void AddHitLogicTypeType(FlatBufferBuilder builder, THitLogicType hitLogicTypeType)
		{
			builder.AddByte(10, (byte)hitLogicTypeType, 0);
		}

		// Token: 0x060298CE RID: 170190 RVA: 0x005ABB00 File Offset: 0x005A9D00
		public static void AddHitLogicType(FlatBufferBuilder builder, int hitLogicTypeOffset)
		{
			builder.AddOffset(11, hitLogicTypeOffset, 0);
		}

		// Token: 0x060298CF RID: 170191 RVA: 0x005ABB0C File Offset: 0x005A9D0C
		public static void AddPatrol(FlatBufferBuilder builder, Offset<ISplineMove> patrolOffset)
		{
			builder.AddOffset(12, patrolOffset.Value, 0);
		}

		// Token: 0x060298D0 RID: 170192 RVA: 0x005ABB1D File Offset: 0x005A9D1D
		public static void AddHitCd(FlatBufferBuilder builder, float hitCd)
		{
			builder.AddFloat(13, hitCd, 0.0);
		}

		// Token: 0x060298D1 RID: 170193 RVA: 0x005ABB31 File Offset: 0x005A9D31
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x060298D2 RID: 170194 RVA: 0x005ABB3D File Offset: 0x005A9D3D
		public static Offset<ITargetGearComponent> EndITargetGearComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearComponent>(builder.EndTable());
		}

		// Token: 0x060298D3 RID: 170195 RVA: 0x005ABB4C File Offset: 0x005A9D4C
		public ITargetGearComponentT UnPack()
		{
			ITargetGearComponentT targetGearComponentT = new ITargetGearComponentT();
			this.UnPackTo(targetGearComponentT);
			return targetGearComponentT;
		}

		// Token: 0x060298D4 RID: 170196 RVA: 0x005ABB68 File Offset: 0x005A9D68
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

		// Token: 0x060298D5 RID: 170197 RVA: 0x005AC068 File Offset: 0x005AA268
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

		// Token: 0x0400FD73 RID: 64883
		private Table __p;
	}
}
