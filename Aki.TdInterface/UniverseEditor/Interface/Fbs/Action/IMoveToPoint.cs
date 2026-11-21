using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A6 RID: 29350
	public struct IMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700D71D RID: 55069
		// (get) Token: 0x0603325A RID: 209498 RVA: 0x006E6B30 File Offset: 0x006E4D30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603325B RID: 209499 RVA: 0x006E6B3D File Offset: 0x006E4D3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603325C RID: 209500 RVA: 0x006E6B44 File Offset: 0x006E4D44
		public static IMoveToPoint GetRootAsIMoveToPoint(ByteBuffer _bb)
		{
			return IMoveToPoint.GetRootAsIMoveToPoint(_bb, default(IMoveToPoint));
		}

		// Token: 0x0603325D RID: 209501 RVA: 0x006E6B60 File Offset: 0x006E4D60
		public static IMoveToPoint GetRootAsIMoveToPoint(ByteBuffer _bb, IMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603325E RID: 209502 RVA: 0x006E6B7D File Offset: 0x006E4D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603325F RID: 209503 RVA: 0x006E6B8C File Offset: 0x006E4D8C
		public IMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D71E RID: 55070
		// (get) Token: 0x06033260 RID: 209504 RVA: 0x006E6B9C File Offset: 0x006E4D9C
		public EMoveSceneItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveSceneItemType.MoveToPoint;
				}
				return (EMoveSceneItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D71F RID: 55071
		// (get) Token: 0x06033261 RID: 209505 RVA: 0x006E6BD8 File Offset: 0x006E4DD8
		public IVectorInfo? Point
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D720 RID: 55072
		// (get) Token: 0x06033262 RID: 209506 RVA: 0x006E6C38 File Offset: 0x006E4E38
		public float Time
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D721 RID: 55073
		// (get) Token: 0x06033263 RID: 209507 RVA: 0x006E6C78 File Offset: 0x006E4E78
		public TMoveToPointType MoveMotionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TMoveToPointType.NONE;
				}
				return (TMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033264 RID: 209508 RVA: 0x006E6CB8 File Offset: 0x006E4EB8
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033265 RID: 209509 RVA: 0x006E6D00 File Offset: 0x006E4F00
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x06033266 RID: 209510 RVA: 0x006E6D1C File Offset: 0x006E4F1C
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x06033267 RID: 209511 RVA: 0x006E6D37 File Offset: 0x006E4F37
		public static Offset<IMoveToPoint> CreateIMoveToPoint(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint, Offset<IVectorInfo> PointOffset = default(Offset<IVectorInfo>), float Time = 0f, TMoveToPointType MoveMotion_type = TMoveToPointType.NONE, int MoveMotionOffset = 0)
		{
			builder.StartTable(5);
			IMoveToPoint.AddMoveMotion(builder, MoveMotionOffset);
			IMoveToPoint.AddTime(builder, Time);
			IMoveToPoint.AddPoint(builder, PointOffset);
			IMoveToPoint.AddMoveMotionType(builder, MoveMotion_type);
			IMoveToPoint.AddType(builder, Type);
			return IMoveToPoint.EndIMoveToPoint(builder);
		}

		// Token: 0x06033268 RID: 209512 RVA: 0x006E6D6B File Offset: 0x006E4F6B
		public static void StartIMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033269 RID: 209513 RVA: 0x006E6D74 File Offset: 0x006E4F74
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603326A RID: 209514 RVA: 0x006E6D7F File Offset: 0x006E4F7F
		public static void AddPoint(FlatBufferBuilder builder, Offset<IVectorInfo> pointOffset)
		{
			builder.AddOffset(1, pointOffset.Value, 0);
		}

		// Token: 0x0603326B RID: 209515 RVA: 0x006E6D8F File Offset: 0x006E4F8F
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(2, time, 0.0);
		}

		// Token: 0x0603326C RID: 209516 RVA: 0x006E6DA2 File Offset: 0x006E4FA2
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(3, (byte)moveMotionType, 0);
		}

		// Token: 0x0603326D RID: 209517 RVA: 0x006E6DAD File Offset: 0x006E4FAD
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(4, moveMotionOffset, 0);
		}

		// Token: 0x0603326E RID: 209518 RVA: 0x006E6DB8 File Offset: 0x006E4FB8
		public static Offset<IMoveToPoint> EndIMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0603326F RID: 209519 RVA: 0x006E6DC8 File Offset: 0x006E4FC8
		public IMoveToPointT UnPack()
		{
			IMoveToPointT moveToPointT = new IMoveToPointT();
			this.UnPackTo(moveToPointT);
			return moveToPointT;
		}

		// Token: 0x06033270 RID: 209520 RVA: 0x006E6DE4 File Offset: 0x006E4FE4
		public void UnPackTo(IMoveToPointT _o)
		{
			_o.Type = this.Type;
			_o.Point = ((this.Point != null) ? this.Point.Value.UnPack() : null);
			_o.Time = this.Time;
			_o.MoveMotion = new TMoveToPointTypeUnion();
			_o.MoveMotion.Type = this.MoveMotionType;
			TMoveToPointType moveMotionType = this.MoveMotionType;
			if (moveMotionType == TMoveToPointType.IUniformMotion)
			{
				_o.MoveMotion.Value = ((this.MoveMotion<IUniformMotion>() != null) ? this.MoveMotion<IUniformMotion>().Value.UnPack() : null);
				return;
			}
			if (moveMotionType != TMoveToPointType.IVariableMotion)
			{
				return;
			}
			_o.MoveMotion.Value = ((this.MoveMotion<IVariableMotion>() != null) ? this.MoveMotion<IVariableMotion>().Value.UnPack() : null);
		}

		// Token: 0x06033271 RID: 209521 RVA: 0x006E6ED4 File Offset: 0x006E50D4
		public static Offset<IMoveToPoint> Pack(FlatBufferBuilder builder, IMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveToPoint>);
			}
			Offset<IVectorInfo> pointOffset = (_o.Point == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Point);
			TMoveToPointType moveMotion_type = (_o.MoveMotion == null) ? TMoveToPointType.NONE : _o.MoveMotion.Type;
			int moveMotionOffset = (_o.MoveMotion == null) ? 0 : TMoveToPointTypeUnion.Pack(builder, _o.MoveMotion);
			return IMoveToPoint.CreateIMoveToPoint(builder, _o.Type, pointOffset, _o.Time, moveMotion_type, moveMotionOffset);
		}

		// Token: 0x04012334 RID: 74548
		private Table __p;
	}
}
