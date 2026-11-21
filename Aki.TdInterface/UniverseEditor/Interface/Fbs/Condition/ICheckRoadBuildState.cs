using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FF2 RID: 20466
	public struct ICheckRoadBuildState : IFlatbufferObject
	{
		// Token: 0x1700926B RID: 37483
		// (get) Token: 0x0601FEED RID: 130797 RVA: 0x0046EFAC File Offset: 0x0046D1AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FEEE RID: 130798 RVA: 0x0046EFB9 File Offset: 0x0046D1B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FEEF RID: 130799 RVA: 0x0046EFC0 File Offset: 0x0046D1C0
		public static ICheckRoadBuildState GetRootAsICheckRoadBuildState(ByteBuffer _bb)
		{
			return ICheckRoadBuildState.GetRootAsICheckRoadBuildState(_bb, default(ICheckRoadBuildState));
		}

		// Token: 0x0601FEF0 RID: 130800 RVA: 0x0046EFDC File Offset: 0x0046D1DC
		public static ICheckRoadBuildState GetRootAsICheckRoadBuildState(ByteBuffer _bb, ICheckRoadBuildState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FEF1 RID: 130801 RVA: 0x0046EFF9 File Offset: 0x0046D1F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FEF2 RID: 130802 RVA: 0x0046F008 File Offset: 0x0046D208
		public ICheckRoadBuildState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700926C RID: 37484
		// (get) Token: 0x0601FEF3 RID: 130803 RVA: 0x0046F018 File Offset: 0x0046D218
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

		// Token: 0x1700926D RID: 37485
		// (get) Token: 0x0601FEF4 RID: 130804 RVA: 0x0046F054 File Offset: 0x0046D254
		public int RoadId
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

		// Token: 0x1700926E RID: 37486
		// (get) Token: 0x0601FEF5 RID: 130805 RVA: 0x0046F090 File Offset: 0x0046D290
		public bool IsBuilt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FEF6 RID: 130806 RVA: 0x0046F0CF File Offset: 0x0046D2CF
		public static Offset<ICheckRoadBuildState> CreateICheckRoadBuildState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int RoadId = 0, bool IsBuilt = false)
		{
			builder.StartTable(3);
			ICheckRoadBuildState.AddRoadId(builder, RoadId);
			ICheckRoadBuildState.AddIsBuilt(builder, IsBuilt);
			ICheckRoadBuildState.AddType(builder, Type);
			return ICheckRoadBuildState.EndICheckRoadBuildState(builder);
		}

		// Token: 0x0601FEF7 RID: 130807 RVA: 0x0046F0F3 File Offset: 0x0046D2F3
		public static void StartICheckRoadBuildState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FEF8 RID: 130808 RVA: 0x0046F0FC File Offset: 0x0046D2FC
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FEF9 RID: 130809 RVA: 0x0046F107 File Offset: 0x0046D307
		public static void AddRoadId(FlatBufferBuilder builder, int roadId)
		{
			builder.AddInt(1, roadId, 0);
		}

		// Token: 0x0601FEFA RID: 130810 RVA: 0x0046F112 File Offset: 0x0046D312
		public static void AddIsBuilt(FlatBufferBuilder builder, bool isBuilt)
		{
			builder.AddBool(2, isBuilt, false);
		}

		// Token: 0x0601FEFB RID: 130811 RVA: 0x0046F11D File Offset: 0x0046D31D
		public static Offset<ICheckRoadBuildState> EndICheckRoadBuildState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRoadBuildState>(builder.EndTable());
		}

		// Token: 0x0601FEFC RID: 130812 RVA: 0x0046F12C File Offset: 0x0046D32C
		public ICheckRoadBuildStateT UnPack()
		{
			ICheckRoadBuildStateT checkRoadBuildStateT = new ICheckRoadBuildStateT();
			this.UnPackTo(checkRoadBuildStateT);
			return checkRoadBuildStateT;
		}

		// Token: 0x0601FEFD RID: 130813 RVA: 0x0046F147 File Offset: 0x0046D347
		public void UnPackTo(ICheckRoadBuildStateT _o)
		{
			_o.Type = this.Type;
			_o.RoadId = this.RoadId;
			_o.IsBuilt = this.IsBuilt;
		}

		// Token: 0x0601FEFE RID: 130814 RVA: 0x0046F170 File Offset: 0x0046D370
		public static Offset<ICheckRoadBuildState> Pack(FlatBufferBuilder builder, ICheckRoadBuildStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRoadBuildState>);
			}
			return ICheckRoadBuildState.CreateICheckRoadBuildState(builder, _o.Type, _o.RoadId, _o.IsBuilt);
		}

		// Token: 0x0400DEA5 RID: 56997
		private Table __p;
	}
}
