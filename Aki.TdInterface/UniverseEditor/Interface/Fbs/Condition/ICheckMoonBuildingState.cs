using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F9B RID: 20379
	public struct ICheckMoonBuildingState : IFlatbufferObject
	{
		// Token: 0x170091BE RID: 37310
		// (get) Token: 0x0601FBF5 RID: 130037 RVA: 0x004695E8 File Offset: 0x004677E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FBF6 RID: 130038 RVA: 0x004695F5 File Offset: 0x004677F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FBF7 RID: 130039 RVA: 0x004695FC File Offset: 0x004677FC
		public static ICheckMoonBuildingState GetRootAsICheckMoonBuildingState(ByteBuffer _bb)
		{
			return ICheckMoonBuildingState.GetRootAsICheckMoonBuildingState(_bb, default(ICheckMoonBuildingState));
		}

		// Token: 0x0601FBF8 RID: 130040 RVA: 0x00469618 File Offset: 0x00467818
		public static ICheckMoonBuildingState GetRootAsICheckMoonBuildingState(ByteBuffer _bb, ICheckMoonBuildingState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FBF9 RID: 130041 RVA: 0x00469635 File Offset: 0x00467835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FBFA RID: 130042 RVA: 0x00469644 File Offset: 0x00467844
		public ICheckMoonBuildingState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091BF RID: 37311
		// (get) Token: 0x0601FBFB RID: 130043 RVA: 0x00469654 File Offset: 0x00467854
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

		// Token: 0x170091C0 RID: 37312
		// (get) Token: 0x0601FBFC RID: 130044 RVA: 0x00469690 File Offset: 0x00467890
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

		// Token: 0x170091C1 RID: 37313
		// (get) Token: 0x0601FBFD RID: 130045 RVA: 0x004696CC File Offset: 0x004678CC
		public bool IsBuilt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FBFE RID: 130046 RVA: 0x0046970B File Offset: 0x0046790B
		public static Offset<ICheckMoonBuildingState> CreateICheckMoonBuildingState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int BuildingId = 0, bool IsBuilt = false)
		{
			builder.StartTable(3);
			ICheckMoonBuildingState.AddBuildingId(builder, BuildingId);
			ICheckMoonBuildingState.AddIsBuilt(builder, IsBuilt);
			ICheckMoonBuildingState.AddType(builder, Type);
			return ICheckMoonBuildingState.EndICheckMoonBuildingState(builder);
		}

		// Token: 0x0601FBFF RID: 130047 RVA: 0x0046972F File Offset: 0x0046792F
		public static void StartICheckMoonBuildingState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FC00 RID: 130048 RVA: 0x00469738 File Offset: 0x00467938
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FC01 RID: 130049 RVA: 0x00469743 File Offset: 0x00467943
		public static void AddBuildingId(FlatBufferBuilder builder, int buildingId)
		{
			builder.AddInt(1, buildingId, 0);
		}

		// Token: 0x0601FC02 RID: 130050 RVA: 0x0046974E File Offset: 0x0046794E
		public static void AddIsBuilt(FlatBufferBuilder builder, bool isBuilt)
		{
			builder.AddBool(2, isBuilt, false);
		}

		// Token: 0x0601FC03 RID: 130051 RVA: 0x00469759 File Offset: 0x00467959
		public static Offset<ICheckMoonBuildingState> EndICheckMoonBuildingState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckMoonBuildingState>(builder.EndTable());
		}

		// Token: 0x0601FC04 RID: 130052 RVA: 0x00469768 File Offset: 0x00467968
		public ICheckMoonBuildingStateT UnPack()
		{
			ICheckMoonBuildingStateT checkMoonBuildingStateT = new ICheckMoonBuildingStateT();
			this.UnPackTo(checkMoonBuildingStateT);
			return checkMoonBuildingStateT;
		}

		// Token: 0x0601FC05 RID: 130053 RVA: 0x00469783 File Offset: 0x00467983
		public void UnPackTo(ICheckMoonBuildingStateT _o)
		{
			_o.Type = this.Type;
			_o.BuildingId = this.BuildingId;
			_o.IsBuilt = this.IsBuilt;
		}

		// Token: 0x0601FC06 RID: 130054 RVA: 0x004697AC File Offset: 0x004679AC
		public static Offset<ICheckMoonBuildingState> Pack(FlatBufferBuilder builder, ICheckMoonBuildingStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckMoonBuildingState>);
			}
			return ICheckMoonBuildingState.CreateICheckMoonBuildingState(builder, _o.Type, _o.BuildingId, _o.IsBuilt);
		}

		// Token: 0x0400DE38 RID: 56888
		private Table __p;
	}
}
