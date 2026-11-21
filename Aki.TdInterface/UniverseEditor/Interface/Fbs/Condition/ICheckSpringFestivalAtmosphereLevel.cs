using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005010 RID: 20496
	public struct ICheckSpringFestivalAtmosphereLevel : IFlatbufferObject
	{
		// Token: 0x170092A6 RID: 37542
		// (get) Token: 0x0601FFE5 RID: 131045 RVA: 0x00470AE4 File Offset: 0x0046ECE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FFE6 RID: 131046 RVA: 0x00470AF1 File Offset: 0x0046ECF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FFE7 RID: 131047 RVA: 0x00470AF8 File Offset: 0x0046ECF8
		public static ICheckSpringFestivalAtmosphereLevel GetRootAsICheckSpringFestivalAtmosphereLevel(ByteBuffer _bb)
		{
			return ICheckSpringFestivalAtmosphereLevel.GetRootAsICheckSpringFestivalAtmosphereLevel(_bb, default(ICheckSpringFestivalAtmosphereLevel));
		}

		// Token: 0x0601FFE8 RID: 131048 RVA: 0x00470B14 File Offset: 0x0046ED14
		public static ICheckSpringFestivalAtmosphereLevel GetRootAsICheckSpringFestivalAtmosphereLevel(ByteBuffer _bb, ICheckSpringFestivalAtmosphereLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FFE9 RID: 131049 RVA: 0x00470B31 File Offset: 0x0046ED31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FFEA RID: 131050 RVA: 0x00470B40 File Offset: 0x0046ED40
		public ICheckSpringFestivalAtmosphereLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092A7 RID: 37543
		// (get) Token: 0x0601FFEB RID: 131051 RVA: 0x00470B50 File Offset: 0x0046ED50
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092A8 RID: 37544
		// (get) Token: 0x0601FFEC RID: 131052 RVA: 0x00470B8C File Offset: 0x0046ED8C
		public int AtmosphereLevel
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

		// Token: 0x0601FFED RID: 131053 RVA: 0x00470BC8 File Offset: 0x0046EDC8
		public static Offset<ICheckSpringFestivalAtmosphereLevel> CreateICheckSpringFestivalAtmosphereLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int AtmosphereLevel = 0)
		{
			builder.StartTable(2);
			ICheckSpringFestivalAtmosphereLevel.AddAtmosphereLevel(builder, AtmosphereLevel);
			ICheckSpringFestivalAtmosphereLevel.AddType(builder, Type);
			return ICheckSpringFestivalAtmosphereLevel.EndICheckSpringFestivalAtmosphereLevel(builder);
		}

		// Token: 0x0601FFEE RID: 131054 RVA: 0x00470BE5 File Offset: 0x0046EDE5
		public static void StartICheckSpringFestivalAtmosphereLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FFEF RID: 131055 RVA: 0x00470BEE File Offset: 0x0046EDEE
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FFF0 RID: 131056 RVA: 0x00470BF9 File Offset: 0x0046EDF9
		public static void AddAtmosphereLevel(FlatBufferBuilder builder, int atmosphereLevel)
		{
			builder.AddInt(1, atmosphereLevel, 0);
		}

		// Token: 0x0601FFF1 RID: 131057 RVA: 0x00470C04 File Offset: 0x0046EE04
		public static Offset<ICheckSpringFestivalAtmosphereLevel> EndICheckSpringFestivalAtmosphereLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalAtmosphereLevel>(builder.EndTable());
		}

		// Token: 0x0601FFF2 RID: 131058 RVA: 0x00470C14 File Offset: 0x0046EE14
		public ICheckSpringFestivalAtmosphereLevelT UnPack()
		{
			ICheckSpringFestivalAtmosphereLevelT checkSpringFestivalAtmosphereLevelT = new ICheckSpringFestivalAtmosphereLevelT();
			this.UnPackTo(checkSpringFestivalAtmosphereLevelT);
			return checkSpringFestivalAtmosphereLevelT;
		}

		// Token: 0x0601FFF3 RID: 131059 RVA: 0x00470C2F File Offset: 0x0046EE2F
		public void UnPackTo(ICheckSpringFestivalAtmosphereLevelT _o)
		{
			_o.Type = this.Type;
			_o.AtmosphereLevel = this.AtmosphereLevel;
		}

		// Token: 0x0601FFF4 RID: 131060 RVA: 0x00470C4C File Offset: 0x0046EE4C
		public static Offset<ICheckSpringFestivalAtmosphereLevel> Pack(FlatBufferBuilder builder, ICheckSpringFestivalAtmosphereLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalAtmosphereLevel>);
			}
			return ICheckSpringFestivalAtmosphereLevel.CreateICheckSpringFestivalAtmosphereLevel(builder, _o.Type, _o.AtmosphereLevel);
		}

		// Token: 0x0400DECD RID: 57037
		private Table __p;
	}
}
