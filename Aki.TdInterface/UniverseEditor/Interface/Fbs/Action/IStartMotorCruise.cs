using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007986 RID: 31110
	public struct IStartMotorCruise : IFlatbufferObject
	{
		// Token: 0x1700E41E RID: 58398
		// (get) Token: 0x06036CBA RID: 224442 RVA: 0x00754506 File Offset: 0x00752706
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036CBB RID: 224443 RVA: 0x00754513 File Offset: 0x00752713
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036CBC RID: 224444 RVA: 0x0075451C File Offset: 0x0075271C
		public static IStartMotorCruise GetRootAsIStartMotorCruise(ByteBuffer _bb)
		{
			return IStartMotorCruise.GetRootAsIStartMotorCruise(_bb, default(IStartMotorCruise));
		}

		// Token: 0x06036CBD RID: 224445 RVA: 0x00754538 File Offset: 0x00752738
		public static IStartMotorCruise GetRootAsIStartMotorCruise(ByteBuffer _bb, IStartMotorCruise obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036CBE RID: 224446 RVA: 0x00754555 File Offset: 0x00752755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036CBF RID: 224447 RVA: 0x00754564 File Offset: 0x00752764
		public IStartMotorCruise __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E41F RID: 58399
		// (get) Token: 0x06036CC0 RID: 224448 RVA: 0x00754574 File Offset: 0x00752774
		public ISplineWayPoint? StartPoint
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E420 RID: 58400
		// (get) Token: 0x06036CC1 RID: 224449 RVA: 0x007545D4 File Offset: 0x007527D4
		public ISplineWayPoint? EndPoint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E421 RID: 58401
		// (get) Token: 0x06036CC2 RID: 224450 RVA: 0x00754634 File Offset: 0x00752834
		public bool AllowSkip
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036CC3 RID: 224451 RVA: 0x00754673 File Offset: 0x00752873
		public static Offset<IStartMotorCruise> CreateIStartMotorCruise(FlatBufferBuilder builder, Offset<ISplineWayPoint> StartPointOffset = default(Offset<ISplineWayPoint>), Offset<ISplineWayPoint> EndPointOffset = default(Offset<ISplineWayPoint>), bool AllowSkip = false)
		{
			builder.StartTable(3);
			IStartMotorCruise.AddEndPoint(builder, EndPointOffset);
			IStartMotorCruise.AddStartPoint(builder, StartPointOffset);
			IStartMotorCruise.AddAllowSkip(builder, AllowSkip);
			return IStartMotorCruise.EndIStartMotorCruise(builder);
		}

		// Token: 0x06036CC4 RID: 224452 RVA: 0x00754697 File Offset: 0x00752897
		public static void StartIStartMotorCruise(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036CC5 RID: 224453 RVA: 0x007546A0 File Offset: 0x007528A0
		public static void AddStartPoint(FlatBufferBuilder builder, Offset<ISplineWayPoint> startPointOffset)
		{
			builder.AddOffset(0, startPointOffset.Value, 0);
		}

		// Token: 0x06036CC6 RID: 224454 RVA: 0x007546B0 File Offset: 0x007528B0
		public static void AddEndPoint(FlatBufferBuilder builder, Offset<ISplineWayPoint> endPointOffset)
		{
			builder.AddOffset(1, endPointOffset.Value, 0);
		}

		// Token: 0x06036CC7 RID: 224455 RVA: 0x007546C0 File Offset: 0x007528C0
		public static void AddAllowSkip(FlatBufferBuilder builder, bool allowSkip)
		{
			builder.AddBool(2, allowSkip, false);
		}

		// Token: 0x06036CC8 RID: 224456 RVA: 0x007546CB File Offset: 0x007528CB
		public static Offset<IStartMotorCruise> EndIStartMotorCruise(FlatBufferBuilder builder)
		{
			return new Offset<IStartMotorCruise>(builder.EndTable());
		}

		// Token: 0x06036CC9 RID: 224457 RVA: 0x007546D8 File Offset: 0x007528D8
		public IStartMotorCruiseT UnPack()
		{
			IStartMotorCruiseT startMotorCruiseT = new IStartMotorCruiseT();
			this.UnPackTo(startMotorCruiseT);
			return startMotorCruiseT;
		}

		// Token: 0x06036CCA RID: 224458 RVA: 0x007546F4 File Offset: 0x007528F4
		public void UnPackTo(IStartMotorCruiseT _o)
		{
			_o.StartPoint = ((this.StartPoint != null) ? this.StartPoint.Value.UnPack() : null);
			_o.EndPoint = ((this.EndPoint != null) ? this.EndPoint.Value.UnPack() : null);
			_o.AllowSkip = this.AllowSkip;
		}

		// Token: 0x06036CCB RID: 224459 RVA: 0x0075476C File Offset: 0x0075296C
		public static Offset<IStartMotorCruise> Pack(FlatBufferBuilder builder, IStartMotorCruiseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartMotorCruise>);
			}
			Offset<ISplineWayPoint> startPointOffset = (_o.StartPoint == null) ? default(Offset<ISplineWayPoint>) : ISplineWayPoint.Pack(builder, _o.StartPoint);
			Offset<ISplineWayPoint> endPointOffset = (_o.EndPoint == null) ? default(Offset<ISplineWayPoint>) : ISplineWayPoint.Pack(builder, _o.EndPoint);
			return IStartMotorCruise.CreateIStartMotorCruise(builder, startPointOffset, endPointOffset, _o.AllowSkip);
		}

		// Token: 0x04012C7C RID: 76924
		private Table __p;
	}
}
