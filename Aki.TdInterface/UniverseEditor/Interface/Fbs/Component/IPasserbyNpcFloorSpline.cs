using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7B RID: 23675
	public struct IPasserbyNpcFloorSpline : IFlatbufferObject
	{
		// Token: 0x1700ADF5 RID: 44533
		// (get) Token: 0x06027461 RID: 160865 RVA: 0x00560F78 File Offset: 0x0055F178
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027462 RID: 160866 RVA: 0x00560F85 File Offset: 0x0055F185
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027463 RID: 160867 RVA: 0x00560F8C File Offset: 0x0055F18C
		public static IPasserbyNpcFloorSpline GetRootAsIPasserbyNpcFloorSpline(ByteBuffer _bb)
		{
			return IPasserbyNpcFloorSpline.GetRootAsIPasserbyNpcFloorSpline(_bb, default(IPasserbyNpcFloorSpline));
		}

		// Token: 0x06027464 RID: 160868 RVA: 0x00560FA8 File Offset: 0x0055F1A8
		public static IPasserbyNpcFloorSpline GetRootAsIPasserbyNpcFloorSpline(ByteBuffer _bb, IPasserbyNpcFloorSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027465 RID: 160869 RVA: 0x00560FC5 File Offset: 0x0055F1C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027466 RID: 160870 RVA: 0x00560FD4 File Offset: 0x0055F1D4
		public IPasserbyNpcFloorSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADF6 RID: 44534
		// (get) Token: 0x06027467 RID: 160871 RVA: 0x00560FE4 File Offset: 0x0055F1E4
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ADF7 RID: 44535
		// (get) Token: 0x06027468 RID: 160872 RVA: 0x00561020 File Offset: 0x0055F220
		public int Floor
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

		// Token: 0x1700ADF8 RID: 44536
		// (get) Token: 0x06027469 RID: 160873 RVA: 0x0056105C File Offset: 0x0055F25C
		public IPasserbyNpcMoveState? MoveState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcMoveState?(default(IPasserbyNpcMoveState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602746A RID: 160874 RVA: 0x005610B9 File Offset: 0x0055F2B9
		public static Offset<IPasserbyNpcFloorSpline> CreateIPasserbyNpcFloorSpline(FlatBufferBuilder builder, int SplineEntityId = 0, int Floor = 0, Offset<IPasserbyNpcMoveState> MoveStateOffset = default(Offset<IPasserbyNpcMoveState>))
		{
			builder.StartTable(3);
			IPasserbyNpcFloorSpline.AddMoveState(builder, MoveStateOffset);
			IPasserbyNpcFloorSpline.AddFloor(builder, Floor);
			IPasserbyNpcFloorSpline.AddSplineEntityId(builder, SplineEntityId);
			return IPasserbyNpcFloorSpline.EndIPasserbyNpcFloorSpline(builder);
		}

		// Token: 0x0602746B RID: 160875 RVA: 0x005610DD File Offset: 0x0055F2DD
		public static void StartIPasserbyNpcFloorSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602746C RID: 160876 RVA: 0x005610E6 File Offset: 0x0055F2E6
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(0, splineEntityId, 0);
		}

		// Token: 0x0602746D RID: 160877 RVA: 0x005610F1 File Offset: 0x0055F2F1
		public static void AddFloor(FlatBufferBuilder builder, int floor)
		{
			builder.AddInt(1, floor, 0);
		}

		// Token: 0x0602746E RID: 160878 RVA: 0x005610FC File Offset: 0x0055F2FC
		public static void AddMoveState(FlatBufferBuilder builder, Offset<IPasserbyNpcMoveState> moveStateOffset)
		{
			builder.AddOffset(2, moveStateOffset.Value, 0);
		}

		// Token: 0x0602746F RID: 160879 RVA: 0x0056110C File Offset: 0x0055F30C
		public static Offset<IPasserbyNpcFloorSpline> EndIPasserbyNpcFloorSpline(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcFloorSpline>(builder.EndTable());
		}

		// Token: 0x06027470 RID: 160880 RVA: 0x0056111C File Offset: 0x0055F31C
		public IPasserbyNpcFloorSplineT UnPack()
		{
			IPasserbyNpcFloorSplineT passerbyNpcFloorSplineT = new IPasserbyNpcFloorSplineT();
			this.UnPackTo(passerbyNpcFloorSplineT);
			return passerbyNpcFloorSplineT;
		}

		// Token: 0x06027471 RID: 160881 RVA: 0x00561138 File Offset: 0x0055F338
		public void UnPackTo(IPasserbyNpcFloorSplineT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.Floor = this.Floor;
			_o.MoveState = ((this.MoveState != null) ? this.MoveState.Value.UnPack() : null);
		}

		// Token: 0x06027472 RID: 160882 RVA: 0x0056118C File Offset: 0x0055F38C
		public static Offset<IPasserbyNpcFloorSpline> Pack(FlatBufferBuilder builder, IPasserbyNpcFloorSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcFloorSpline>);
			}
			Offset<IPasserbyNpcMoveState> moveStateOffset = (_o.MoveState == null) ? default(Offset<IPasserbyNpcMoveState>) : IPasserbyNpcMoveState.Pack(builder, _o.MoveState);
			return IPasserbyNpcFloorSpline.CreateIPasserbyNpcFloorSpline(builder, _o.SplineEntityId, _o.Floor, moveStateOffset);
		}

		// Token: 0x0400F782 RID: 63362
		private Table __p;
	}
}
