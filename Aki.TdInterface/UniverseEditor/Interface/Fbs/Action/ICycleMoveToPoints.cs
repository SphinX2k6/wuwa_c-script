using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006522 RID: 25890
	public struct ICycleMoveToPoints : IFlatbufferObject
	{
		// Token: 0x1700C07E RID: 49278
		// (get) Token: 0x0602CE91 RID: 183953 RVA: 0x0062ADF9 File Offset: 0x00628FF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE92 RID: 183954 RVA: 0x0062AE06 File Offset: 0x00629006
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE93 RID: 183955 RVA: 0x0062AE10 File Offset: 0x00629010
		public static ICycleMoveToPoints GetRootAsICycleMoveToPoints(ByteBuffer _bb)
		{
			return ICycleMoveToPoints.GetRootAsICycleMoveToPoints(_bb, default(ICycleMoveToPoints));
		}

		// Token: 0x0602CE94 RID: 183956 RVA: 0x0062AE2C File Offset: 0x0062902C
		public static ICycleMoveToPoints GetRootAsICycleMoveToPoints(ByteBuffer _bb, ICycleMoveToPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE95 RID: 183957 RVA: 0x0062AE49 File Offset: 0x00629049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE96 RID: 183958 RVA: 0x0062AE58 File Offset: 0x00629058
		public ICycleMoveToPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C07F RID: 49279
		// (get) Token: 0x0602CE97 RID: 183959 RVA: 0x0062AE68 File Offset: 0x00629068
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

		// Token: 0x0602CE98 RID: 183960 RVA: 0x0062AEA4 File Offset: 0x006290A4
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C080 RID: 49280
		// (get) Token: 0x0602CE99 RID: 183961 RVA: 0x0062AF04 File Offset: 0x00629104
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

		// Token: 0x1700C081 RID: 49281
		// (get) Token: 0x0602CE9A RID: 183962 RVA: 0x0062AF30 File Offset: 0x00629130
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C082 RID: 49282
		// (get) Token: 0x0602CE9B RID: 183963 RVA: 0x0062AF70 File Offset: 0x00629170
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

		// Token: 0x1700C083 RID: 49283
		// (get) Token: 0x0602CE9C RID: 183964 RVA: 0x0062AFB4 File Offset: 0x006291B4
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

		// Token: 0x0602CE9D RID: 183965 RVA: 0x0062AFF4 File Offset: 0x006291F4
		public TTable? MoveMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CE9E RID: 183966 RVA: 0x0062B03C File Offset: 0x0062923C
		public IUniformMotion MoveMotionAsIUniformMotion()
		{
			return this.MoveMotion<IUniformMotion>().Value;
		}

		// Token: 0x0602CE9F RID: 183967 RVA: 0x0062B058 File Offset: 0x00629258
		public IVariableMotion MoveMotionAsIVariableMotion()
		{
			return this.MoveMotion<IVariableMotion>().Value;
		}

		// Token: 0x1700C084 RID: 49284
		// (get) Token: 0x0602CEA0 RID: 183968 RVA: 0x0062B074 File Offset: 0x00629274
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

		// Token: 0x0602CEA1 RID: 183969 RVA: 0x0062B0B4 File Offset: 0x006292B4
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

		// Token: 0x0602CEA2 RID: 183970 RVA: 0x0062B103 File Offset: 0x00629303
		public static void StartICycleMoveToPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602CEA3 RID: 183971 RVA: 0x0062B10C File Offset: 0x0062930C
		public static void AddType(FlatBufferBuilder builder, EMoveSceneItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CEA4 RID: 183972 RVA: 0x0062B117 File Offset: 0x00629317
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x0602CEA5 RID: 183973 RVA: 0x0062B128 File Offset: 0x00629328
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CEA6 RID: 183974 RVA: 0x0062B168 File Offset: 0x00629368
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEA7 RID: 183975 RVA: 0x0062B182 File Offset: 0x00629382
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CEA8 RID: 183976 RVA: 0x0062B1A0 File Offset: 0x006293A0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CEA9 RID: 183977 RVA: 0x0062B1B9 File Offset: 0x006293B9
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CEAA RID: 183978 RVA: 0x0062B1C4 File Offset: 0x006293C4
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x0602CEAB RID: 183979 RVA: 0x0062B1CF File Offset: 0x006293CF
		public static void AddStopTime(FlatBufferBuilder builder, float stopTime)
		{
			builder.AddFloat(3, stopTime, 0.0);
		}

		// Token: 0x0602CEAC RID: 183980 RVA: 0x0062B1E2 File Offset: 0x006293E2
		public static void AddMoveMotionType(FlatBufferBuilder builder, TMoveToPointType moveMotionType)
		{
			builder.AddByte(4, (byte)moveMotionType, 0);
		}

		// Token: 0x0602CEAD RID: 183981 RVA: 0x0062B1ED File Offset: 0x006293ED
		public static void AddMoveMotion(FlatBufferBuilder builder, int moveMotionOffset)
		{
			builder.AddOffset(5, moveMotionOffset, 0);
		}

		// Token: 0x0602CEAE RID: 183982 RVA: 0x0062B1F8 File Offset: 0x006293F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602CEAF RID: 183983 RVA: 0x0062B203 File Offset: 0x00629403
		public static Offset<ICycleMoveToPoints> EndICycleMoveToPoints(FlatBufferBuilder builder)
		{
			return new Offset<ICycleMoveToPoints>(builder.EndTable());
		}

		// Token: 0x0602CEB0 RID: 183984 RVA: 0x0062B210 File Offset: 0x00629410
		public ICycleMoveToPointsT UnPack()
		{
			ICycleMoveToPointsT cycleMoveToPointsT = new ICycleMoveToPointsT();
			this.UnPackTo(cycleMoveToPointsT);
			return cycleMoveToPointsT;
		}

		// Token: 0x0602CEB1 RID: 183985 RVA: 0x0062B22C File Offset: 0x0062942C
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

		// Token: 0x0602CEB2 RID: 183986 RVA: 0x0062B358 File Offset: 0x00629558
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

		// Token: 0x04010B6C RID: 68460
		private Table __p;
	}
}
