using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006341 RID: 25409
	public struct IAirCurrentData : IFlatbufferObject
	{
		// Token: 0x1700BBD0 RID: 48080
		// (get) Token: 0x0602B147 RID: 176455 RVA: 0x005DF246 File Offset: 0x005DD446
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B148 RID: 176456 RVA: 0x005DF253 File Offset: 0x005DD453
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B149 RID: 176457 RVA: 0x005DF25C File Offset: 0x005DD45C
		public static IAirCurrentData GetRootAsIAirCurrentData(ByteBuffer _bb)
		{
			return IAirCurrentData.GetRootAsIAirCurrentData(_bb, default(IAirCurrentData));
		}

		// Token: 0x0602B14A RID: 176458 RVA: 0x005DF278 File Offset: 0x005DD478
		public static IAirCurrentData GetRootAsIAirCurrentData(ByteBuffer _bb, IAirCurrentData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B14B RID: 176459 RVA: 0x005DF295 File Offset: 0x005DD495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B14C RID: 176460 RVA: 0x005DF2A4 File Offset: 0x005DD4A4
		public IAirCurrentData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBD1 RID: 48081
		// (get) Token: 0x0602B14D RID: 176461 RVA: 0x005DF2B4 File Offset: 0x005DD4B4
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

		// Token: 0x1700BBD2 RID: 48082
		// (get) Token: 0x0602B14E RID: 176462 RVA: 0x005DF2F0 File Offset: 0x005DD4F0
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

		// Token: 0x1700BBD3 RID: 48083
		// (get) Token: 0x0602B14F RID: 176463 RVA: 0x005DF330 File Offset: 0x005DD530
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

		// Token: 0x1700BBD4 RID: 48084
		// (get) Token: 0x0602B150 RID: 176464 RVA: 0x005DF370 File Offset: 0x005DD570
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

		// Token: 0x1700BBD5 RID: 48085
		// (get) Token: 0x0602B151 RID: 176465 RVA: 0x005DF3B4 File Offset: 0x005DD5B4
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

		// Token: 0x1700BBD6 RID: 48086
		// (get) Token: 0x0602B152 RID: 176466 RVA: 0x005DF3F4 File Offset: 0x005DD5F4
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

		// Token: 0x1700BBD7 RID: 48087
		// (get) Token: 0x0602B153 RID: 176467 RVA: 0x005DF438 File Offset: 0x005DD638
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

		// Token: 0x1700BBD8 RID: 48088
		// (get) Token: 0x0602B154 RID: 176468 RVA: 0x005DF498 File Offset: 0x005DD698
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

		// Token: 0x1700BBD9 RID: 48089
		// (get) Token: 0x0602B155 RID: 176469 RVA: 0x005DF4F8 File Offset: 0x005DD6F8
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

		// Token: 0x0602B156 RID: 176470 RVA: 0x005DF538 File Offset: 0x005DD738
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

		// Token: 0x0602B157 RID: 176471 RVA: 0x005DF598 File Offset: 0x005DD798
		public static void StartIAirCurrentData(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602B158 RID: 176472 RVA: 0x005DF5A2 File Offset: 0x005DD7A2
		public static void AddType(FlatBufferBuilder builder, EAreaFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B159 RID: 176473 RVA: 0x005DF5AD File Offset: 0x005DD7AD
		public static void AddExitEffectHeight(FlatBufferBuilder builder, float exitEffectHeight)
		{
			builder.AddFloat(1, exitEffectHeight, 0.0);
		}

		// Token: 0x0602B15A RID: 176474 RVA: 0x005DF5C0 File Offset: 0x005DD7C0
		public static void AddEffectiveHeight(FlatBufferBuilder builder, float effectiveHeight)
		{
			builder.AddFloat(2, effectiveHeight, 0.0);
		}

		// Token: 0x0602B15B RID: 176475 RVA: 0x005DF5D3 File Offset: 0x005DD7D3
		public static void AddFallTeleportHeight(FlatBufferBuilder builder, float fallTeleportHeight)
		{
			builder.AddFloat(3, fallTeleportHeight, 0.0);
		}

		// Token: 0x0602B15C RID: 176476 RVA: 0x005DF5E6 File Offset: 0x005DD7E6
		public static void AddFallTeleportTransitionConfigId(FlatBufferBuilder builder, int fallTeleportTransitionConfigId)
		{
			builder.AddInt(4, fallTeleportTransitionConfigId, 0);
		}

		// Token: 0x0602B15D RID: 176477 RVA: 0x005DF5F1 File Offset: 0x005DD7F1
		public static void AddTopTeleportHeight(FlatBufferBuilder builder, float topTeleportHeight)
		{
			builder.AddFloat(5, topTeleportHeight, 0.0);
		}

		// Token: 0x0602B15E RID: 176478 RVA: 0x005DF604 File Offset: 0x005DD804
		public static void AddMotor(FlatBufferBuilder builder, Offset<IMotorAirCurrentConfig> motorOffset)
		{
			builder.AddOffset(6, motorOffset.Value, 0);
		}

		// Token: 0x0602B15F RID: 176479 RVA: 0x005DF614 File Offset: 0x005DD814
		public static void AddCharacter(FlatBufferBuilder builder, Offset<ICharacterAirCurrentConfig> characterOffset)
		{
			builder.AddOffset(7, characterOffset.Value, 0);
		}

		// Token: 0x0602B160 RID: 176480 RVA: 0x005DF624 File Offset: 0x005DD824
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602B161 RID: 176481 RVA: 0x005DF62F File Offset: 0x005DD82F
		public static Offset<IAirCurrentData> EndIAirCurrentData(FlatBufferBuilder builder)
		{
			return new Offset<IAirCurrentData>(builder.EndTable());
		}

		// Token: 0x0602B162 RID: 176482 RVA: 0x005DF63C File Offset: 0x005DD83C
		public IAirCurrentDataT UnPack()
		{
			IAirCurrentDataT airCurrentDataT = new IAirCurrentDataT();
			this.UnPackTo(airCurrentDataT);
			return airCurrentDataT;
		}

		// Token: 0x0602B163 RID: 176483 RVA: 0x005DF658 File Offset: 0x005DD858
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

		// Token: 0x0602B164 RID: 176484 RVA: 0x005DF718 File Offset: 0x005DD918
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

		// Token: 0x040103FD RID: 66557
		private Table __p;
	}
}
