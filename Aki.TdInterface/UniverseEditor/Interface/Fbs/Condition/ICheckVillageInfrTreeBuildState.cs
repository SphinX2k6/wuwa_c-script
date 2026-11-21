using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200505B RID: 20571
	public struct ICheckVillageInfrTreeBuildState : IFlatbufferObject
	{
		// Token: 0x1700933D RID: 37693
		// (get) Token: 0x0602028F RID: 131727 RVA: 0x00475BFE File Offset: 0x00473DFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020290 RID: 131728 RVA: 0x00475C0B File Offset: 0x00473E0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020291 RID: 131729 RVA: 0x00475C14 File Offset: 0x00473E14
		public static ICheckVillageInfrTreeBuildState GetRootAsICheckVillageInfrTreeBuildState(ByteBuffer _bb)
		{
			return ICheckVillageInfrTreeBuildState.GetRootAsICheckVillageInfrTreeBuildState(_bb, default(ICheckVillageInfrTreeBuildState));
		}

		// Token: 0x06020292 RID: 131730 RVA: 0x00475C30 File Offset: 0x00473E30
		public static ICheckVillageInfrTreeBuildState GetRootAsICheckVillageInfrTreeBuildState(ByteBuffer _bb, ICheckVillageInfrTreeBuildState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020293 RID: 131731 RVA: 0x00475C4D File Offset: 0x00473E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020294 RID: 131732 RVA: 0x00475C5C File Offset: 0x00473E5C
		public ICheckVillageInfrTreeBuildState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700933E RID: 37694
		// (get) Token: 0x06020295 RID: 131733 RVA: 0x00475C6C File Offset: 0x00473E6C
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

		// Token: 0x1700933F RID: 37695
		// (get) Token: 0x06020296 RID: 131734 RVA: 0x00475CA8 File Offset: 0x00473EA8
		public int Id
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

		// Token: 0x17009340 RID: 37696
		// (get) Token: 0x06020297 RID: 131735 RVA: 0x00475CE4 File Offset: 0x00473EE4
		public bool IsBuilt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020298 RID: 131736 RVA: 0x00475D23 File Offset: 0x00473F23
		public static Offset<ICheckVillageInfrTreeBuildState> CreateICheckVillageInfrTreeBuildState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int Id = 0, bool IsBuilt = false)
		{
			builder.StartTable(3);
			ICheckVillageInfrTreeBuildState.AddId(builder, Id);
			ICheckVillageInfrTreeBuildState.AddIsBuilt(builder, IsBuilt);
			ICheckVillageInfrTreeBuildState.AddType(builder, Type);
			return ICheckVillageInfrTreeBuildState.EndICheckVillageInfrTreeBuildState(builder);
		}

		// Token: 0x06020299 RID: 131737 RVA: 0x00475D47 File Offset: 0x00473F47
		public static void StartICheckVillageInfrTreeBuildState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602029A RID: 131738 RVA: 0x00475D50 File Offset: 0x00473F50
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602029B RID: 131739 RVA: 0x00475D5B File Offset: 0x00473F5B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602029C RID: 131740 RVA: 0x00475D66 File Offset: 0x00473F66
		public static void AddIsBuilt(FlatBufferBuilder builder, bool isBuilt)
		{
			builder.AddBool(2, isBuilt, false);
		}

		// Token: 0x0602029D RID: 131741 RVA: 0x00475D71 File Offset: 0x00473F71
		public static Offset<ICheckVillageInfrTreeBuildState> EndICheckVillageInfrTreeBuildState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVillageInfrTreeBuildState>(builder.EndTable());
		}

		// Token: 0x0602029E RID: 131742 RVA: 0x00475D80 File Offset: 0x00473F80
		public ICheckVillageInfrTreeBuildStateT UnPack()
		{
			ICheckVillageInfrTreeBuildStateT checkVillageInfrTreeBuildStateT = new ICheckVillageInfrTreeBuildStateT();
			this.UnPackTo(checkVillageInfrTreeBuildStateT);
			return checkVillageInfrTreeBuildStateT;
		}

		// Token: 0x0602029F RID: 131743 RVA: 0x00475D9B File Offset: 0x00473F9B
		public void UnPackTo(ICheckVillageInfrTreeBuildStateT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.IsBuilt = this.IsBuilt;
		}

		// Token: 0x060202A0 RID: 131744 RVA: 0x00475DC4 File Offset: 0x00473FC4
		public static Offset<ICheckVillageInfrTreeBuildState> Pack(FlatBufferBuilder builder, ICheckVillageInfrTreeBuildStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVillageInfrTreeBuildState>);
			}
			return ICheckVillageInfrTreeBuildState.CreateICheckVillageInfrTreeBuildState(builder, _o.Type, _o.Id, _o.IsBuilt);
		}

		// Token: 0x0400DF3F RID: 57151
		private Table __p;
	}
}
