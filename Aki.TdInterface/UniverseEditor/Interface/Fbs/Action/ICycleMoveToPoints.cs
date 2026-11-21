using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B90 RID: 27536
	public struct ICycleMoveToPoints : IFlatbufferObject
	{
		// Token: 0x1700CA10 RID: 51728
		// (get) Token: 0x0602F62F RID: 194095 RVA: 0x006772A5 File Offset: 0x006754A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F630 RID: 194096 RVA: 0x006772B2 File Offset: 0x006754B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F631 RID: 194097 RVA: 0x006772BC File Offset: 0x006754BC
		public static ICycleMoveToPoints GetRootAsICycleMoveToPoints(ByteBuffer _bb)
		{
			return ICycleMoveToPoints.GetRootAsICycleMoveToPoints(_bb, default(ICycleMoveToPoints));
		}

		// Token: 0x0602F632 RID: 194098 RVA: 0x006772D8 File Offset: 0x006754D8
		public static ICycleMoveToPoints GetRootAsICycleMoveToPoints(ByteBuffer _bb, ICycleMoveToPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F633 RID: 194099 RVA: 0x006772F5 File Offset: 0x006754F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F634 RID: 194100 RVA: 0x00677304 File Offset: 0x00675504
		public ICycleMoveToPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA11 RID: 51729
		// (get) Token: 0x0602F635 RID: 194101 RVA: 0x00677314 File Offset: 0x00675514
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

		// Token: 0x0602F636 RID: 194102 RVA: 0x00677350 File Offset: 0x00675550
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CA12 RID: 51730
		// (get) Token: 0x0602F637 RID: 194103 RVA: 0x006773B0 File Offset: 0x006755B0
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700CA13 RID: 51731
		// (get) Token: 0x0602F638 RID: 194104 RVA: 0x006773DC File Offset: 0x006755DC
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA14 RID: 51732
		// (get) Token: 0x0602F639 RID: 194105 RVA: 0x0067741C File Offset: 0x0067561C
		public float StopTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA15 RID: 51733
		// (get) Token: 0x0602F63A RID: 194106 RVA: 0x00677460 File Offset: 0x00675660
		public TMoveToPointType MoveMotionType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TMoveToPointType.NONE;
				}
				return (TMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F63B RID: 194107 RVA: 0x006774A0 File Offset: 0x006756A0
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F63C RID: 194108 RVA: 0x006774E8 File Offset: 0x006756E8
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x0602F63D RID: 194109 RVA: 0x00677504 File Offset: 0x00675704
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x1700CA16 RID: 51734
		// (get) Token: 0x0602F63E RID: 194110 RVA: 0x00677520 File Offset: 0x00675720
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F63F RID: 194111 RVA: 0x00677560 File Offset: 0x00675760
		public static Offset<ICycleMoveToPoints> CreateICycleMoveToPoints(FlatBufferBuilder builder, EMoveSceneItemType Type = EMoveSceneItemType.MoveToPoint, VectorOffset PointsOffset = default(VectorOffset), bool IsLoop = false, float StopTime = 0f, TMoveToPointType MoveMotion_type = TMoveToPointType.NONE, int MoveMotionOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			ICycleMoveToPoints.AddMoveMotion(builder, MoveMotionOffset);
			ICycleMoveToPoints.AddStopTime(builder, StopTime);
			ICycleMoveToPoints.AddPoints(builder, PointsOffset);
			ICycleMoveToPoints.AddNullMask(builder, NullMask);
			ICycleMoveToPoints.AddMoveMotionType(builder, MoveMotion_type);
			ICycleMoveToPoints.AddIsLoop(builder, IsLoop);
			ICycleMoveToPoints.AddType(builder, Type);
			return ICycleMoveToPoints.EndICycleMoveToPoints(builder);
		}

		// Token: 0x0602F640 RID: 194112 RVA: 0x006775AF File Offset: 0x006757AF
		public static void StartICycleMoveToPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602F641 RID: 194113 RVA: 0x006775B8 File Offset: 0x006757B8
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F642 RID: 194114 RVA: 0x006775C3 File Offset: 0x006757C3
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x0602F643 RID: 194115 RVA: 0x006775D4 File Offset: 0x006757D4
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F644 RID: 194116 RVA: 0x00677614 File Offset: 0x00675814
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F645 RID: 194117 RVA: 0x0067762E File Offset: 0x0067582E
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F646 RID: 194118 RVA: 0x0067764C File Offset: 0x0067584C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F647 RID: 194119 RVA: 0x00677665 File Offset: 0x00675865
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F648 RID: 194120 RVA: 0x00677670 File Offset: 0x00675870
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x0602F649 RID: 194121 RVA: 0x0067767B File Offset: 0x0067587B
		public static void AddStopTime(FlatBufferBuilder builder, float stopTime)
		{
			builder.AddFloat(3, stopTime, 0.0);
		}

		// Token: 0x0602F64A RID: 194122 RVA: 0x0067768E File Offset: 0x0067588E
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(4, (byte)moveMotionType, 0);
		}

		// Token: 0x0602F64B RID: 194123 RVA: 0x00677699 File Offset: 0x00675899
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(5, moveMotionOffset, 0);
		}

		// Token: 0x0602F64C RID: 194124 RVA: 0x006776A4 File Offset: 0x006758A4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602F64D RID: 194125 RVA: 0x006776AF File Offset: 0x006758AF
		public static Offset<ICycleMoveToPoints> EndICycleMoveToPoints(FlatBufferBuilder builder)
		{
			return new Offset<ICycleMoveToPoints>(builder.EndTable());
		}

		// Token: 0x0602F64E RID: 194126 RVA: 0x006776BC File Offset: 0x006758BC
		public ICycleMoveToPointsT UnPack()
		{
			ICycleMoveToPointsT cycleMoveToPointsT = new ICycleMoveToPointsT();
			this.UnPackTo(cycleMoveToPointsT);
			return cycleMoveToPointsT;
		}

		// Token: 0x0602F64F RID: 194127 RVA: 0x006776D8 File Offset: 0x006758D8
		public void UnPackTo(ICycleMoveToPointsT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
			_o.IsLoop = this.IsLoop;
			_o.StopTime = this.StopTime;
			_o.MoveMotion = new TMoveToPointTypeUnion();
			_o.MoveMotion.Type = this.MoveMotionType;
			TMoveToPointType moveMotionType = this.MoveMotionType;
			if (moveMotionType != TMoveToPointType.IUniformMotion)
			{
				if (moveMotionType == TMoveToPointType.IVariableMotion)
				{
					_o.MoveMotion.Value = ((this.MoveMotion<IVariableMotion>() != null) ? this.MoveMotion<IVariableMotion>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveMotion.Value = ((this.MoveMotion<IUniformMotion>() != null) ? this.MoveMotion<IUniformMotion>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F650 RID: 194128 RVA: 0x00677804 File Offset: 0x00675A04
		public static Offset<ICycleMoveToPoints> Pack(FlatBufferBuilder builder, ICycleMoveToPointsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICycleMoveToPoints>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.Points[i]);
				}
				pointsOffset = ICycleMoveToPoints.CreatePointsVector(builder, array);
			}
			TMoveToPointType moveMotion_type = (_o.MoveMotion == null) ? TMoveToPointType.NONE : _o.MoveMotion.Type;
			int moveMotionOffset = (_o.MoveMotion == null) ? 0 : TMoveToPointTypeUnion.Pack(builder, _o.MoveMotion);
			return ICycleMoveToPoints.CreateICycleMoveToPoints(builder, _o.Type, pointsOffset, _o.IsLoop, _o.StopTime, moveMotion_type, moveMotionOffset, _o.NullMask);
		}

		// Token: 0x04011985 RID: 72069
		private Table __p;
	}
}
