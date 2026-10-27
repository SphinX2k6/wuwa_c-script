using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B29 RID: 19241
	public struct ICheckSpringFestivalAtmosphereLevel : IFlatbufferObject
	{
		// Token: 0x17008B96 RID: 35734
		// (get) Token: 0x0601E45A RID: 123994 RVA: 0x0043E338 File Offset: 0x0043C538
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E45B RID: 123995 RVA: 0x0043E345 File Offset: 0x0043C545
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E45C RID: 123996 RVA: 0x0043E34C File Offset: 0x0043C54C
		public static ICheckSpringFestivalAtmosphereLevel GetRootAsICheckSpringFestivalAtmosphereLevel(ByteBuffer _bb)
		{
			return ICheckSpringFestivalAtmosphereLevel.GetRootAsICheckSpringFestivalAtmosphereLevel(_bb, default(ICheckSpringFestivalAtmosphereLevel));
		}

		// Token: 0x0601E45D RID: 123997 RVA: 0x0043E368 File Offset: 0x0043C568
		public static ICheckSpringFestivalAtmosphereLevel GetRootAsICheckSpringFestivalAtmosphereLevel(ByteBuffer _bb, ICheckSpringFestivalAtmosphereLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E45E RID: 123998 RVA: 0x0043E385 File Offset: 0x0043C585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E45F RID: 123999 RVA: 0x0043E394 File Offset: 0x0043C594
		public ICheckSpringFestivalAtmosphereLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B97 RID: 35735
		// (get) Token: 0x0601E460 RID: 124000 RVA: 0x0043E3A4 File Offset: 0x0043C5A4
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

		// Token: 0x17008B98 RID: 35736
		// (get) Token: 0x0601E461 RID: 124001 RVA: 0x0043E3E0 File Offset: 0x0043C5E0
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

		// Token: 0x0601E462 RID: 124002 RVA: 0x0043E41C File Offset: 0x0043C61C
		public static Offset<ICheckSpringFestivalAtmosphereLevel> CreateICheckSpringFestivalAtmosphereLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int AtmosphereLevel = 0)
		{
			builder.StartTable(2);
			ICheckSpringFestivalAtmosphereLevel.AddAtmosphereLevel(builder, AtmosphereLevel);
			ICheckSpringFestivalAtmosphereLevel.AddType(builder, Type);
			return ICheckSpringFestivalAtmosphereLevel.EndICheckSpringFestivalAtmosphereLevel(builder);
		}

		// Token: 0x0601E463 RID: 124003 RVA: 0x0043E439 File Offset: 0x0043C639
		public static void StartICheckSpringFestivalAtmosphereLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E464 RID: 124004 RVA: 0x0043E442 File Offset: 0x0043C642
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E465 RID: 124005 RVA: 0x0043E44D File Offset: 0x0043C64D
		public static void AddAtmosphereLevel(FlatBufferBuilder builder, int atmosphereLevel)
		{
			builder.AddInt(1, atmosphereLevel, 0);
		}

		// Token: 0x0601E466 RID: 124006 RVA: 0x0043E458 File Offset: 0x0043C658
		public static Offset<ICheckSpringFestivalAtmosphereLevel> EndICheckSpringFestivalAtmosphereLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalAtmosphereLevel>(builder.EndTable());
		}

		// Token: 0x0601E467 RID: 124007 RVA: 0x0043E468 File Offset: 0x0043C668
		public ICheckSpringFestivalAtmosphereLevelT UnPack()
		{
			ICheckSpringFestivalAtmosphereLevelT checkSpringFestivalAtmosphereLevelT = new ICheckSpringFestivalAtmosphereLevelT();
			this.UnPackTo(checkSpringFestivalAtmosphereLevelT);
			return checkSpringFestivalAtmosphereLevelT;
		}

		// Token: 0x0601E468 RID: 124008 RVA: 0x0043E483 File Offset: 0x0043C683
		public void UnPackTo(ICheckSpringFestivalAtmosphereLevelT _o)
		{
			_o.Type = this.Type;
			_o.AtmosphereLevel = this.AtmosphereLevel;
		}

		// Token: 0x0601E469 RID: 124009 RVA: 0x0043E4A0 File Offset: 0x0043C6A0
		public static Offset<ICheckSpringFestivalAtmosphereLevel> Pack(FlatBufferBuilder builder, ICheckSpringFestivalAtmosphereLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalAtmosphereLevel>);
			}
			return ICheckSpringFestivalAtmosphereLevel.CreateICheckSpringFestivalAtmosphereLevel(builder, _o.Type, _o.AtmosphereLevel);
		}

		// Token: 0x0400D3CE RID: 54222
		private Table __p;
	}
}
