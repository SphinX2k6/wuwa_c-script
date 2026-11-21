using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAE RID: 23726
	public struct IPasserbyNpcRideLiftLeaveOnArrivalMove : IFlatbufferObject
	{
		// Token: 0x1700AE4B RID: 44619
		// (get) Token: 0x060275DD RID: 161245 RVA: 0x005638F6 File Offset: 0x00561AF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060275DE RID: 161246 RVA: 0x00563903 File Offset: 0x00561B03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060275DF RID: 161247 RVA: 0x0056390C File Offset: 0x00561B0C
		public static IPasserbyNpcRideLiftLeaveOnArrivalMove GetRootAsIPasserbyNpcRideLiftLeaveOnArrivalMove(ByteBuffer _bb)
		{
			return IPasserbyNpcRideLiftLeaveOnArrivalMove.GetRootAsIPasserbyNpcRideLiftLeaveOnArrivalMove(_bb, default(IPasserbyNpcRideLiftLeaveOnArrivalMove));
		}

		// Token: 0x060275E0 RID: 161248 RVA: 0x00563928 File Offset: 0x00561B28
		public static IPasserbyNpcRideLiftLeaveOnArrivalMove GetRootAsIPasserbyNpcRideLiftLeaveOnArrivalMove(ByteBuffer _bb, IPasserbyNpcRideLiftLeaveOnArrivalMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060275E1 RID: 161249 RVA: 0x00563945 File Offset: 0x00561B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060275E2 RID: 161250 RVA: 0x00563954 File Offset: 0x00561B54
		public IPasserbyNpcRideLiftLeaveOnArrivalMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE4C RID: 44620
		// (get) Token: 0x060275E3 RID: 161251 RVA: 0x00563964 File Offset: 0x00561B64
		public EPasserbyNpcLiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
				}
				return (EPasserbyNpcLiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE4D RID: 44621
		// (get) Token: 0x060275E4 RID: 161252 RVA: 0x005639A0 File Offset: 0x00561BA0
		public int LiftEntityId
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

		// Token: 0x1700AE4E RID: 44622
		// (get) Token: 0x060275E5 RID: 161253 RVA: 0x005639DC File Offset: 0x00561BDC
		public IPasserbyNpcLiftStopExitTiming? ExitTiming
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcLiftStopExitTiming?(default(IPasserbyNpcLiftStopExitTiming).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060275E6 RID: 161254 RVA: 0x00563A3C File Offset: 0x00561C3C
		public IPasserbyNpcFloorSpline? FloorSplines(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IPasserbyNpcFloorSpline?(default(IPasserbyNpcFloorSpline).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE4F RID: 44623
		// (get) Token: 0x060275E7 RID: 161255 RVA: 0x00563AA0 File Offset: 0x00561CA0
		public int FloorSplinesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060275E8 RID: 161256 RVA: 0x00563ACC File Offset: 0x00561CCC
		public static Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove> CreateIPasserbyNpcRideLiftLeaveOnArrivalMove(FlatBufferBuilder builder, EPasserbyNpcLiftMoveType Type = EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival, int LiftEntityId = 0, Offset<IPasserbyNpcLiftStopExitTiming> ExitTimingOffset = default(Offset<IPasserbyNpcLiftStopExitTiming>), VectorOffset FloorSplinesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IPasserbyNpcRideLiftLeaveOnArrivalMove.AddFloorSplines(builder, FloorSplinesOffset);
			IPasserbyNpcRideLiftLeaveOnArrivalMove.AddExitTiming(builder, ExitTimingOffset);
			IPasserbyNpcRideLiftLeaveOnArrivalMove.AddLiftEntityId(builder, LiftEntityId);
			IPasserbyNpcRideLiftLeaveOnArrivalMove.AddType(builder, Type);
			return IPasserbyNpcRideLiftLeaveOnArrivalMove.EndIPasserbyNpcRideLiftLeaveOnArrivalMove(builder);
		}

		// Token: 0x060275E9 RID: 161257 RVA: 0x00563AF8 File Offset: 0x00561CF8
		public static void StartIPasserbyNpcRideLiftLeaveOnArrivalMove(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060275EA RID: 161258 RVA: 0x00563B01 File Offset: 0x00561D01
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcLiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060275EB RID: 161259 RVA: 0x00563B0C File Offset: 0x00561D0C
		public static void AddLiftEntityId(FlatBufferBuilder builder, int liftEntityId)
		{
			builder.AddInt(1, liftEntityId, 0);
		}

		// Token: 0x060275EC RID: 161260 RVA: 0x00563B17 File Offset: 0x00561D17
		public static void AddExitTiming(FlatBufferBuilder builder, Offset<IPasserbyNpcLiftStopExitTiming> exitTimingOffset)
		{
			builder.AddOffset(2, exitTimingOffset.Value, 0);
		}

		// Token: 0x060275ED RID: 161261 RVA: 0x00563B27 File Offset: 0x00561D27
		public static void AddFloorSplines(FlatBufferBuilder builder, VectorOffset floorSplinesOffset)
		{
			builder.AddOffset(3, floorSplinesOffset.Value, 0);
		}

		// Token: 0x060275EE RID: 161262 RVA: 0x00563B38 File Offset: 0x00561D38
		public static VectorOffset CreateFloorSplinesVector(FlatBufferBuilder builder, Offset<IPasserbyNpcFloorSpline>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060275EF RID: 161263 RVA: 0x00563B78 File Offset: 0x00561D78
		public static VectorOffset CreateFloorSplinesVectorBlock(FlatBufferBuilder builder, Offset<IPasserbyNpcFloorSpline>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPasserbyNpcFloorSpline>>(data);
			return builder.EndVector();
		}

		// Token: 0x060275F0 RID: 161264 RVA: 0x00563B92 File Offset: 0x00561D92
		public static VectorOffset CreateFloorSplinesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPasserbyNpcFloorSpline>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPasserbyNpcFloorSpline>>(data);
			return builder.EndVector();
		}

		// Token: 0x060275F1 RID: 161265 RVA: 0x00563BB0 File Offset: 0x00561DB0
		public static VectorOffset CreateFloorSplinesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPasserbyNpcFloorSpline>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060275F2 RID: 161266 RVA: 0x00563BC9 File Offset: 0x00561DC9
		public static void StartFloorSplinesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060275F3 RID: 161267 RVA: 0x00563BD4 File Offset: 0x00561DD4
		public static Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove> EndIPasserbyNpcRideLiftLeaveOnArrivalMove(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove>(builder.EndTable());
		}

		// Token: 0x060275F4 RID: 161268 RVA: 0x00563BE4 File Offset: 0x00561DE4
		public IPasserbyNpcRideLiftLeaveOnArrivalMoveT UnPack()
		{
			IPasserbyNpcRideLiftLeaveOnArrivalMoveT passerbyNpcRideLiftLeaveOnArrivalMoveT = new IPasserbyNpcRideLiftLeaveOnArrivalMoveT();
			this.UnPackTo(passerbyNpcRideLiftLeaveOnArrivalMoveT);
			return passerbyNpcRideLiftLeaveOnArrivalMoveT;
		}

		// Token: 0x060275F5 RID: 161269 RVA: 0x00563C00 File Offset: 0x00561E00
		public void UnPackTo(IPasserbyNpcRideLiftLeaveOnArrivalMoveT _o)
		{
			_o.Type = this.Type;
			_o.LiftEntityId = this.LiftEntityId;
			_o.ExitTiming = ((this.ExitTiming != null) ? this.ExitTiming.Value.UnPack() : null);
			_o.FloorSplines = new List<IPasserbyNpcFloorSplineT>();
			for (int i = 0; i < this.FloorSplinesLength; i++)
			{
				_o.FloorSplines.Add((this.FloorSplines(i) != null) ? this.FloorSplines(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060275F6 RID: 161270 RVA: 0x00563CA8 File Offset: 0x00561EA8
		public static Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove> Pack(FlatBufferBuilder builder, IPasserbyNpcRideLiftLeaveOnArrivalMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove>);
			}
			Offset<IPasserbyNpcLiftStopExitTiming> exitTimingOffset = (_o.ExitTiming == null) ? default(Offset<IPasserbyNpcLiftStopExitTiming>) : IPasserbyNpcLiftStopExitTiming.Pack(builder, _o.ExitTiming);
			VectorOffset floorSplinesOffset = default(VectorOffset);
			if (_o.FloorSplines != null)
			{
				Offset<IPasserbyNpcFloorSpline>[] array = new Offset<IPasserbyNpcFloorSpline>[_o.FloorSplines.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPasserbyNpcFloorSpline.Pack(builder, _o.FloorSplines[i]);
				}
				floorSplinesOffset = IPasserbyNpcRideLiftLeaveOnArrivalMove.CreateFloorSplinesVector(builder, array);
			}
			return IPasserbyNpcRideLiftLeaveOnArrivalMove.CreateIPasserbyNpcRideLiftLeaveOnArrivalMove(builder, _o.Type, _o.LiftEntityId, exitTimingOffset, floorSplinesOffset);
		}

		// Token: 0x0400F7C4 RID: 63428
		private Table __p;
	}
}
