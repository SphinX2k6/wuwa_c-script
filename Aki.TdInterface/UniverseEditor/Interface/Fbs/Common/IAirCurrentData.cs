using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D0D RID: 23821
	public struct IAirCurrentData : IFlatbufferObject
	{
		// Token: 0x1700B274 RID: 45684
		// (get) Token: 0x06028AF3 RID: 166643 RVA: 0x005969D6 File Offset: 0x00594BD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028AF4 RID: 166644 RVA: 0x005969E3 File Offset: 0x00594BE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028AF5 RID: 166645 RVA: 0x005969EC File Offset: 0x00594BEC
		public static IAirCurrentData GetRootAsIAirCurrentData(ByteBuffer _bb)
		{
			return IAirCurrentData.GetRootAsIAirCurrentData(_bb, default(IAirCurrentData));
		}

		// Token: 0x06028AF6 RID: 166646 RVA: 0x00596A08 File Offset: 0x00594C08
		public static IAirCurrentData GetRootAsIAirCurrentData(ByteBuffer _bb, IAirCurrentData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028AF7 RID: 166647 RVA: 0x00596A25 File Offset: 0x00594C25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028AF8 RID: 166648 RVA: 0x00596A34 File Offset: 0x00594C34
		public IAirCurrentData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B275 RID: 45685
		// (get) Token: 0x06028AF9 RID: 166649 RVA: 0x00596A44 File Offset: 0x00594C44
		public EAreaFunctionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAreaFunctionType.AirCurrent;
				}
				return (EAreaFunctionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B276 RID: 45686
		// (get) Token: 0x06028AFA RID: 166650 RVA: 0x00596A80 File Offset: 0x00594C80
		public float ExitEffectHeight
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B277 RID: 45687
		// (get) Token: 0x06028AFB RID: 166651 RVA: 0x00596AC0 File Offset: 0x00594CC0
		public float EffectiveHeight
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B278 RID: 45688
		// (get) Token: 0x06028AFC RID: 166652 RVA: 0x00596B00 File Offset: 0x00594D00
		public float FallTeleportHeight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B279 RID: 45689
		// (get) Token: 0x06028AFD RID: 166653 RVA: 0x00596B44 File Offset: 0x00594D44
		public int FallTeleportTransitionConfigId
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

		// Token: 0x1700B27A RID: 45690
		// (get) Token: 0x06028AFE RID: 166654 RVA: 0x00596B84 File Offset: 0x00594D84
		public float TopTeleportHeight
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B27B RID: 45691
		// (get) Token: 0x06028AFF RID: 166655 RVA: 0x00596BC8 File Offset: 0x00594DC8
		public IMotorAirCurrentConfig? Motor
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IMotorAirCurrentConfig?(default(IMotorAirCurrentConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B27C RID: 45692
		// (get) Token: 0x06028B00 RID: 166656 RVA: 0x00596C28 File Offset: 0x00594E28
		public ICharacterAirCurrentConfig? Character
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ICharacterAirCurrentConfig?(default(ICharacterAirCurrentConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B27D RID: 45693
		// (get) Token: 0x06028B01 RID: 166657 RVA: 0x00596C88 File Offset: 0x00594E88
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028B02 RID: 166658 RVA: 0x00596CC8 File Offset: 0x00594EC8
		public static Offset<IAirCurrentData> CreateIAirCurrentData(FlatBufferBuilder builder, EAreaFunctionType Type = EAreaFunctionType.AirCurrent, float ExitEffectHeight = 0f, float EffectiveHeight = 0f, float FallTeleportHeight = 0f, int FallTeleportTransitionConfigId = 0, float TopTeleportHeight = 0f, Offset<IMotorAirCurrentConfig> MotorOffset = default(Offset<IMotorAirCurrentConfig>), Offset<ICharacterAirCurrentConfig> CharacterOffset = default(Offset<ICharacterAirCurrentConfig>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IAirCurrentData.AddCharacter(builder, CharacterOffset);
			IAirCurrentData.AddMotor(builder, MotorOffset);
			IAirCurrentData.AddTopTeleportHeight(builder, TopTeleportHeight);
			IAirCurrentData.AddFallTeleportTransitionConfigId(builder, FallTeleportTransitionConfigId);
			IAirCurrentData.AddFallTeleportHeight(builder, FallTeleportHeight);
			IAirCurrentData.AddEffectiveHeight(builder, EffectiveHeight);
			IAirCurrentData.AddExitEffectHeight(builder, ExitEffectHeight);
			IAirCurrentData.AddNullMask(builder, NullMask);
			IAirCurrentData.AddType(builder, Type);
			return IAirCurrentData.EndIAirCurrentData(builder);
		}

		// Token: 0x06028B03 RID: 166659 RVA: 0x00596D28 File Offset: 0x00594F28
		public static void StartIAirCurrentData(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06028B04 RID: 166660 RVA: 0x00596D32 File Offset: 0x00594F32
		public static void AddType(FlatBufferBuilder builder, EAreaFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028B05 RID: 166661 RVA: 0x00596D3D File Offset: 0x00594F3D
		public static void AddExitEffectHeight(FlatBufferBuilder builder, float exitEffectHeight)
		{
			builder.AddFloat(1, exitEffectHeight, 0.0);
		}

		// Token: 0x06028B06 RID: 166662 RVA: 0x00596D50 File Offset: 0x00594F50
		public static void AddEffectiveHeight(FlatBufferBuilder builder, float effectiveHeight)
		{
			builder.AddFloat(2, effectiveHeight, 0.0);
		}

		// Token: 0x06028B07 RID: 166663 RVA: 0x00596D63 File Offset: 0x00594F63
		public static void AddFallTeleportHeight(FlatBufferBuilder builder, float fallTeleportHeight)
		{
			builder.AddFloat(3, fallTeleportHeight, 0.0);
		}

		// Token: 0x06028B08 RID: 166664 RVA: 0x00596D76 File Offset: 0x00594F76
		public static void AddFallTeleportTransitionConfigId(FlatBufferBuilder builder, int fallTeleportTransitionConfigId)
		{
			builder.AddInt(4, fallTeleportTransitionConfigId, 0);
		}

		// Token: 0x06028B09 RID: 166665 RVA: 0x00596D81 File Offset: 0x00594F81
		public static void AddTopTeleportHeight(FlatBufferBuilder builder, float topTeleportHeight)
		{
			builder.AddFloat(5, topTeleportHeight, 0.0);
		}

		// Token: 0x06028B0A RID: 166666 RVA: 0x00596D94 File Offset: 0x00594F94
		public static void AddMotor(FlatBufferBuilder builder, Offset<IMotorAirCurrentConfig> motorOffset)
		{
			builder.AddOffset(6, motorOffset.Value, 0);
		}

		// Token: 0x06028B0B RID: 166667 RVA: 0x00596DA4 File Offset: 0x00594FA4
		public static void AddCharacter(FlatBufferBuilder builder, Offset<ICharacterAirCurrentConfig> characterOffset)
		{
			builder.AddOffset(7, characterOffset.Value, 0);
		}

		// Token: 0x06028B0C RID: 166668 RVA: 0x00596DB4 File Offset: 0x00594FB4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06028B0D RID: 166669 RVA: 0x00596DBF File Offset: 0x00594FBF
		public static Offset<IAirCurrentData> EndIAirCurrentData(FlatBufferBuilder builder)
		{
			return new Offset<IAirCurrentData>(builder.EndTable());
		}

		// Token: 0x06028B0E RID: 166670 RVA: 0x00596DCC File Offset: 0x00594FCC
		public IAirCurrentDataT UnPack()
		{
			IAirCurrentDataT airCurrentDataT = new IAirCurrentDataT();
			this.UnPackTo(airCurrentDataT);
			return airCurrentDataT;
		}

		// Token: 0x06028B0F RID: 166671 RVA: 0x00596DE8 File Offset: 0x00594FE8
		public void UnPackTo(IAirCurrentDataT _o)
		{
			_o.Type = this.Type;
			_o.ExitEffectHeight = this.ExitEffectHeight;
			_o.EffectiveHeight = this.EffectiveHeight;
			_o.FallTeleportHeight = this.FallTeleportHeight;
			_o.FallTeleportTransitionConfigId = this.FallTeleportTransitionConfigId;
			_o.TopTeleportHeight = this.TopTeleportHeight;
			_o.Motor = ((this.Motor != null) ? this.Motor.Value.UnPack() : null);
			_o.Character = ((this.Character != null) ? this.Character.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028B10 RID: 166672 RVA: 0x00596EA8 File Offset: 0x005950A8
		public static Offset<IAirCurrentData> Pack(FlatBufferBuilder builder, IAirCurrentDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirCurrentData>);
			}
			Offset<IMotorAirCurrentConfig> motorOffset = (_o.Motor == null) ? default(Offset<IMotorAirCurrentConfig>) : IMotorAirCurrentConfig.Pack(builder, _o.Motor);
			Offset<ICharacterAirCurrentConfig> characterOffset = (_o.Character == null) ? default(Offset<ICharacterAirCurrentConfig>) : ICharacterAirCurrentConfig.Pack(builder, _o.Character);
			return IAirCurrentData.CreateIAirCurrentData(builder, _o.Type, _o.ExitEffectHeight, _o.EffectiveHeight, _o.FallTeleportHeight, _o.FallTeleportTransitionConfigId, _o.TopTeleportHeight, motorOffset, characterOffset, _o.NullMask);
		}

		// Token: 0x0400F6AE RID: 63150
		private Table __p;
	}
}
