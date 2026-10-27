using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B97 RID: 27543
	public struct INewMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700CCB6 RID: 52406
		// (get) Token: 0x060305EF RID: 198127 RVA: 0x006920AB File Offset: 0x006902AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060305F0 RID: 198128 RVA: 0x006920B8 File Offset: 0x006902B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060305F1 RID: 198129 RVA: 0x006920C0 File Offset: 0x006902C0
		public static INewMoveWithSpline GetRootAsINewMoveWithSpline(ByteBuffer _bb)
		{
			return INewMoveWithSpline.GetRootAsINewMoveWithSpline(_bb, default(INewMoveWithSpline));
		}

		// Token: 0x060305F2 RID: 198130 RVA: 0x006920DC File Offset: 0x006902DC
		public static INewMoveWithSpline GetRootAsINewMoveWithSpline(ByteBuffer _bb, INewMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060305F3 RID: 198131 RVA: 0x006920F9 File Offset: 0x006902F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060305F4 RID: 198132 RVA: 0x00692108 File Offset: 0x00690308
		public INewMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCB7 RID: 52407
		// (get) Token: 0x060305F5 RID: 198133 RVA: 0x00692118 File Offset: 0x00690318
		public TNewSplineMoveTarget MoveTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TNewSplineMoveTarget.NONE;
				}
				return (TNewSplineMoveTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060305F6 RID: 198134 RVA: 0x00692154 File Offset: 0x00690354
		public TTable? MoveTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060305F7 RID: 198135 RVA: 0x00692198 File Offset: 0x00690398
		public INpcNewSplineMoveTarget MoveTargetAsINpcNewSplineMoveTarget()
		{
			return this.MoveTarget<INpcNewSplineMoveTarget>().Value;
		}

		// Token: 0x060305F8 RID: 198136 RVA: 0x006921B4 File Offset: 0x006903B4
		public IPlayerNewSplineMoveTarget MoveTargetAsIPlayerNewSplineMoveTarget()
		{
			return this.MoveTarget<IPlayerNewSplineMoveTarget>().Value;
		}

		// Token: 0x060305F9 RID: 198137 RVA: 0x006921D0 File Offset: 0x006903D0
		public ISceneItemNewSplineMoveTarget MoveTargetAsISceneItemNewSplineMoveTarget()
		{
			return this.MoveTarget<ISceneItemNewSplineMoveTarget>().Value;
		}

		// Token: 0x060305FA RID: 198138 RVA: 0x006921EC File Offset: 0x006903EC
		public IVehicleNewSplineMoveTarget MoveTargetAsIVehicleNewSplineMoveTarget()
		{
			return this.MoveTarget<IVehicleNewSplineMoveTarget>().Value;
		}

		// Token: 0x1700CCB8 RID: 52408
		// (get) Token: 0x060305FB RID: 198139 RVA: 0x00692208 File Offset: 0x00690408
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCB9 RID: 52409
		// (get) Token: 0x060305FC RID: 198140 RVA: 0x00692244 File Offset: 0x00690444
		public int StartPointIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCBA RID: 52410
		// (get) Token: 0x060305FD RID: 198141 RVA: 0x00692284 File Offset: 0x00690484
		public int EndPointIndex
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

		// Token: 0x1700CCBB RID: 52411
		// (get) Token: 0x060305FE RID: 198142 RVA: 0x006922C4 File Offset: 0x006904C4
		public bool IsStartFromCurrentPos
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCBC RID: 52412
		// (get) Token: 0x060305FF RID: 198143 RVA: 0x00692304 File Offset: 0x00690504
		public bool IsFollowStrictly
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCBD RID: 52413
		// (get) Token: 0x06030600 RID: 198144 RVA: 0x00692344 File Offset: 0x00690544
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030601 RID: 198145 RVA: 0x00692384 File Offset: 0x00690584
		public static Offset<INewMoveWithSpline> CreateINewMoveWithSpline(FlatBufferBuilder builder, TNewSplineMoveTarget MoveTarget_type = TNewSplineMoveTarget.NONE, int MoveTargetOffset = 0, int SplineEntityId = 0, int StartPointIndex = 0, int EndPointIndex = 0, bool IsStartFromCurrentPos = false, bool IsFollowStrictly = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			INewMoveWithSpline.AddEndPointIndex(builder, EndPointIndex);
			INewMoveWithSpline.AddStartPointIndex(builder, StartPointIndex);
			INewMoveWithSpline.AddSplineEntityId(builder, SplineEntityId);
			INewMoveWithSpline.AddMoveTarget(builder, MoveTargetOffset);
			INewMoveWithSpline.AddNullMask(builder, NullMask);
			INewMoveWithSpline.AddIsFollowStrictly(builder, IsFollowStrictly);
			INewMoveWithSpline.AddIsStartFromCurrentPos(builder, IsStartFromCurrentPos);
			INewMoveWithSpline.AddMoveTargetType(builder, MoveTarget_type);
			return INewMoveWithSpline.EndINewMoveWithSpline(builder);
		}

		// Token: 0x06030602 RID: 198146 RVA: 0x006923DB File Offset: 0x006905DB
		public static void StartINewMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06030603 RID: 198147 RVA: 0x006923E4 File Offset: 0x006905E4
		public static void AddMoveTargetType(FlatBufferBuilder builder, TNewSplineMoveTarget moveTargetType)
		{
			builder.AddByte(0, (byte)moveTargetType, 0);
		}

		// Token: 0x06030604 RID: 198148 RVA: 0x006923EF File Offset: 0x006905EF
		public static void AddMoveTarget(FlatBufferBuilder builder, int moveTargetOffset)
		{
			builder.AddOffset(1, moveTargetOffset, 0);
		}

		// Token: 0x06030605 RID: 198149 RVA: 0x006923FA File Offset: 0x006905FA
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06030606 RID: 198150 RVA: 0x00692405 File Offset: 0x00690605
		public static void AddStartPointIndex(FlatBufferBuilder builder, int startPointIndex)
		{
			builder.AddInt(3, startPointIndex, 0);
		}

		// Token: 0x06030607 RID: 198151 RVA: 0x00692410 File Offset: 0x00690610
		public static void AddEndPointIndex(FlatBufferBuilder builder, int endPointIndex)
		{
			builder.AddInt(4, endPointIndex, 0);
		}

		// Token: 0x06030608 RID: 198152 RVA: 0x0069241B File Offset: 0x0069061B
		public static void AddIsStartFromCurrentPos(FlatBufferBuilder builder, bool isStartFromCurrentPos)
		{
			builder.AddBool(5, isStartFromCurrentPos, false);
		}

		// Token: 0x06030609 RID: 198153 RVA: 0x00692426 File Offset: 0x00690626
		public static void AddIsFollowStrictly(FlatBufferBuilder builder, bool isFollowStrictly)
		{
			builder.AddBool(6, isFollowStrictly, false);
		}

		// Token: 0x0603060A RID: 198154 RVA: 0x00692431 File Offset: 0x00690631
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0603060B RID: 198155 RVA: 0x0069243C File Offset: 0x0069063C
		public static Offset<INewMoveWithSpline> EndINewMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<INewMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x0603060C RID: 198156 RVA: 0x0069244C File Offset: 0x0069064C
		public INewMoveWithSplineT UnPack()
		{
			INewMoveWithSplineT newMoveWithSplineT = new INewMoveWithSplineT();
			this.UnPackTo(newMoveWithSplineT);
			return newMoveWithSplineT;
		}

		// Token: 0x0603060D RID: 198157 RVA: 0x00692468 File Offset: 0x00690668
		public void UnPackTo(INewMoveWithSplineT _o)
		{
			_o.MoveTarget = new TNewSplineMoveTargetUnion();
			_o.MoveTarget.Type = this.MoveTargetType;
			switch (this.MoveTargetType)
			{
			case TNewSplineMoveTarget.INpcNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<INpcNewSplineMoveTarget>() != null) ? this.MoveTarget<INpcNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			case TNewSplineMoveTarget.IPlayerNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<IPlayerNewSplineMoveTarget>() != null) ? this.MoveTarget<IPlayerNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			case TNewSplineMoveTarget.ISceneItemNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<ISceneItemNewSplineMoveTarget>() != null) ? this.MoveTarget<ISceneItemNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			case TNewSplineMoveTarget.IVehicleNewSplineMoveTarget:
				_o.MoveTarget.Value = ((this.MoveTarget<IVehicleNewSplineMoveTarget>() != null) ? this.MoveTarget<IVehicleNewSplineMoveTarget>().Value.UnPack() : null);
				break;
			}
			_o.SplineEntityId = this.SplineEntityId;
			_o.StartPointIndex = this.StartPointIndex;
			_o.EndPointIndex = this.EndPointIndex;
			_o.IsStartFromCurrentPos = this.IsStartFromCurrentPos;
			_o.IsFollowStrictly = this.IsFollowStrictly;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603060E RID: 198158 RVA: 0x006925E0 File Offset: 0x006907E0
		public static Offset<INewMoveWithSpline> Pack(FlatBufferBuilder builder, INewMoveWithSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewMoveWithSpline>);
			}
			TNewSplineMoveTarget moveTarget_type = (_o.MoveTarget == null) ? TNewSplineMoveTarget.NONE : _o.MoveTarget.Type;
			int moveTargetOffset = (_o.MoveTarget == null) ? 0 : TNewSplineMoveTargetUnion.Pack(builder, _o.MoveTarget);
			return INewMoveWithSpline.CreateINewMoveWithSpline(builder, moveTarget_type, moveTargetOffset, _o.SplineEntityId, _o.StartPointIndex, _o.EndPointIndex, _o.IsStartFromCurrentPos, _o.IsFollowStrictly, _o.NullMask);
		}

		// Token: 0x04011458 RID: 70744
		private Table __p;
	}
}
