using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AC9 RID: 19145
	public struct ICheckMoonBuildingState : IFlatbufferObject
	{
		// Token: 0x17008ACC RID: 35532
		// (get) Token: 0x0601E0F6 RID: 123126 RVA: 0x00437B3A File Offset: 0x00435D3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E0F7 RID: 123127 RVA: 0x00437B47 File Offset: 0x00435D47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E0F8 RID: 123128 RVA: 0x00437B50 File Offset: 0x00435D50
		public static ICheckMoonBuildingState GetRootAsICheckMoonBuildingState(ByteBuffer _bb)
		{
			return ICheckMoonBuildingState.GetRootAsICheckMoonBuildingState(_bb, default(ICheckMoonBuildingState));
		}

		// Token: 0x0601E0F9 RID: 123129 RVA: 0x00437B6C File Offset: 0x00435D6C
		public static ICheckMoonBuildingState GetRootAsICheckMoonBuildingState(ByteBuffer _bb, ICheckMoonBuildingState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E0FA RID: 123130 RVA: 0x00437B89 File Offset: 0x00435D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E0FB RID: 123131 RVA: 0x00437B98 File Offset: 0x00435D98
		public ICheckMoonBuildingState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008ACD RID: 35533
		// (get) Token: 0x0601E0FC RID: 123132 RVA: 0x00437BA8 File Offset: 0x00435DA8
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

		// Token: 0x17008ACE RID: 35534
		// (get) Token: 0x0601E0FD RID: 123133 RVA: 0x00437BE4 File Offset: 0x00435DE4
		public int BuildingId
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

		// Token: 0x17008ACF RID: 35535
		// (get) Token: 0x0601E0FE RID: 123134 RVA: 0x00437C20 File Offset: 0x00435E20
		public bool IsBuilt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E0FF RID: 123135 RVA: 0x00437C5F File Offset: 0x00435E5F
		public static Offset<ICheckMoonBuildingState> CreateICheckMoonBuildingState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int BuildingId = 0, bool IsBuilt = false)
		{
			builder.StartTable(3);
			ICheckMoonBuildingState.AddBuildingId(builder, BuildingId);
			ICheckMoonBuildingState.AddIsBuilt(builder, IsBuilt);
			ICheckMoonBuildingState.AddType(builder, Type);
			return ICheckMoonBuildingState.EndICheckMoonBuildingState(builder);
		}

		// Token: 0x0601E100 RID: 123136 RVA: 0x00437C83 File Offset: 0x00435E83
		public static void StartICheckMoonBuildingState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E101 RID: 123137 RVA: 0x00437C8C File Offset: 0x00435E8C
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E102 RID: 123138 RVA: 0x00437C97 File Offset: 0x00435E97
		public static void AddBuildingId(FlatBufferBuilder builder, int buildingId)
		{
			builder.AddInt(1, buildingId, 0);
		}

		// Token: 0x0601E103 RID: 123139 RVA: 0x00437CA2 File Offset: 0x00435EA2
		public static void AddIsBuilt(FlatBufferBuilder builder, bool isBuilt)
		{
			builder.AddBool(2, isBuilt, false);
		}

		// Token: 0x0601E104 RID: 123140 RVA: 0x00437CAD File Offset: 0x00435EAD
		public static Offset<ICheckMoonBuildingState> EndICheckMoonBuildingState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckMoonBuildingState>(builder.EndTable());
		}

		// Token: 0x0601E105 RID: 123141 RVA: 0x00437CBC File Offset: 0x00435EBC
		public ICheckMoonBuildingStateT UnPack()
		{
			ICheckMoonBuildingStateT checkMoonBuildingStateT = new ICheckMoonBuildingStateT();
			this.UnPackTo(checkMoonBuildingStateT);
			return checkMoonBuildingStateT;
		}

		// Token: 0x0601E106 RID: 123142 RVA: 0x00437CD7 File Offset: 0x00435ED7
		public void UnPackTo(ICheckMoonBuildingStateT _o)
		{
			_o.Type = this.Type;
			_o.BuildingId = this.BuildingId;
			_o.IsBuilt = this.IsBuilt;
		}

		// Token: 0x0601E107 RID: 123143 RVA: 0x00437D00 File Offset: 0x00435F00
		public static Offset<ICheckMoonBuildingState> Pack(FlatBufferBuilder builder, ICheckMoonBuildingStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckMoonBuildingState>);
			}
			return ICheckMoonBuildingState.CreateICheckMoonBuildingState(builder, _o.Type, _o.BuildingId, _o.IsBuilt);
		}

		// Token: 0x0400D350 RID: 54096
		private Table __p;
	}
}
