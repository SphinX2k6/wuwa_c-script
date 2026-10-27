using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B74 RID: 19316
	public struct ICheckVillageInfrTreeBuildState : IFlatbufferObject
	{
		// Token: 0x17008C2D RID: 35885
		// (get) Token: 0x0601E701 RID: 124673 RVA: 0x004433B2 File Offset: 0x004415B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E702 RID: 124674 RVA: 0x004433BF File Offset: 0x004415BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E703 RID: 124675 RVA: 0x004433C8 File Offset: 0x004415C8
		public static ICheckVillageInfrTreeBuildState GetRootAsICheckVillageInfrTreeBuildState(ByteBuffer _bb)
		{
			return ICheckVillageInfrTreeBuildState.GetRootAsICheckVillageInfrTreeBuildState(_bb, default(ICheckVillageInfrTreeBuildState));
		}

		// Token: 0x0601E704 RID: 124676 RVA: 0x004433E4 File Offset: 0x004415E4
		public static ICheckVillageInfrTreeBuildState GetRootAsICheckVillageInfrTreeBuildState(ByteBuffer _bb, ICheckVillageInfrTreeBuildState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E705 RID: 124677 RVA: 0x00443401 File Offset: 0x00441601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E706 RID: 124678 RVA: 0x00443410 File Offset: 0x00441610
		public ICheckVillageInfrTreeBuildState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C2E RID: 35886
		// (get) Token: 0x0601E707 RID: 124679 RVA: 0x00443420 File Offset: 0x00441620
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

		// Token: 0x17008C2F RID: 35887
		// (get) Token: 0x0601E708 RID: 124680 RVA: 0x0044345C File Offset: 0x0044165C
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

		// Token: 0x17008C30 RID: 35888
		// (get) Token: 0x0601E709 RID: 124681 RVA: 0x00443498 File Offset: 0x00441698
		public bool IsBuilt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E70A RID: 124682 RVA: 0x004434D7 File Offset: 0x004416D7
		public static Offset<ICheckVillageInfrTreeBuildState> CreateICheckVillageInfrTreeBuildState(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int Id = 0, bool IsBuilt = false)
		{
			builder.StartTable(3);
			ICheckVillageInfrTreeBuildState.AddId(builder, Id);
			ICheckVillageInfrTreeBuildState.AddIsBuilt(builder, IsBuilt);
			ICheckVillageInfrTreeBuildState.AddType(builder, Type);
			return ICheckVillageInfrTreeBuildState.EndICheckVillageInfrTreeBuildState(builder);
		}

		// Token: 0x0601E70B RID: 124683 RVA: 0x004434FB File Offset: 0x004416FB
		public static void StartICheckVillageInfrTreeBuildState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E70C RID: 124684 RVA: 0x00443504 File Offset: 0x00441704
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E70D RID: 124685 RVA: 0x0044350F File Offset: 0x0044170F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601E70E RID: 124686 RVA: 0x0044351A File Offset: 0x0044171A
		public static void AddIsBuilt(FlatBufferBuilder builder, bool isBuilt)
		{
			builder.AddBool(2, isBuilt, false);
		}

		// Token: 0x0601E70F RID: 124687 RVA: 0x00443525 File Offset: 0x00441725
		public static Offset<ICheckVillageInfrTreeBuildState> EndICheckVillageInfrTreeBuildState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVillageInfrTreeBuildState>(builder.EndTable());
		}

		// Token: 0x0601E710 RID: 124688 RVA: 0x00443534 File Offset: 0x00441734
		public ICheckVillageInfrTreeBuildStateT UnPack()
		{
			ICheckVillageInfrTreeBuildStateT checkVillageInfrTreeBuildStateT = new ICheckVillageInfrTreeBuildStateT();
			this.UnPackTo(checkVillageInfrTreeBuildStateT);
			return checkVillageInfrTreeBuildStateT;
		}

		// Token: 0x0601E711 RID: 124689 RVA: 0x0044354F File Offset: 0x0044174F
		public void UnPackTo(ICheckVillageInfrTreeBuildStateT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.IsBuilt = this.IsBuilt;
		}

		// Token: 0x0601E712 RID: 124690 RVA: 0x00443578 File Offset: 0x00441778
		public static Offset<ICheckVillageInfrTreeBuildState> Pack(FlatBufferBuilder builder, ICheckVillageInfrTreeBuildStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVillageInfrTreeBuildState>);
			}
			return ICheckVillageInfrTreeBuildState.CreateICheckVillageInfrTreeBuildState(builder, _o.Type, _o.Id, _o.IsBuilt);
		}

		// Token: 0x0400D43F RID: 54335
		private Table __p;
	}
}
