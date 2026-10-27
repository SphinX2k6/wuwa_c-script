using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FE RID: 22270
	public struct IPathDrivenActorSplineMove : IFlatbufferObject
	{
		// Token: 0x1700A5C0 RID: 42432
		// (get) Token: 0x06025379 RID: 152441 RVA: 0x00522D36 File Offset: 0x00520F36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602537A RID: 152442 RVA: 0x00522D43 File Offset: 0x00520F43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602537B RID: 152443 RVA: 0x00522D4C File Offset: 0x00520F4C
		public static IPathDrivenActorSplineMove GetRootAsIPathDrivenActorSplineMove(ByteBuffer _bb)
		{
			return IPathDrivenActorSplineMove.GetRootAsIPathDrivenActorSplineMove(_bb, default(IPathDrivenActorSplineMove));
		}

		// Token: 0x0602537C RID: 152444 RVA: 0x00522D68 File Offset: 0x00520F68
		public static IPathDrivenActorSplineMove GetRootAsIPathDrivenActorSplineMove(ByteBuffer _bb, IPathDrivenActorSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602537D RID: 152445 RVA: 0x00522D85 File Offset: 0x00520F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602537E RID: 152446 RVA: 0x00522D94 File Offset: 0x00520F94
		public IPathDrivenActorSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5C1 RID: 42433
		// (get) Token: 0x0602537F RID: 152447 RVA: 0x00522DA4 File Offset: 0x00520FA4
		public EPathDrivenActorMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathDrivenActorMoveType.Spline;
				}
				return (EPathDrivenActorMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025380 RID: 152448 RVA: 0x00522DE0 File Offset: 0x00520FE0
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A5C2 RID: 42434
		// (get) Token: 0x06025381 RID: 152449 RVA: 0x00522E20 File Offset: 0x00521020
		public int SplineEntityIdsLength
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

		// Token: 0x06025382 RID: 152450 RVA: 0x00522E4B File Offset: 0x0052104B
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06025383 RID: 152451 RVA: 0x00522E5A File Offset: 0x0052105A
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700A5C3 RID: 42435
		// (get) Token: 0x06025384 RID: 152452 RVA: 0x00522E68 File Offset: 0x00521068
		public bool IsRandomSpline
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5C4 RID: 42436
		// (get) Token: 0x06025385 RID: 152453 RVA: 0x00522EA8 File Offset: 0x005210A8
		public bool IsChainedSpline
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5C5 RID: 42437
		// (get) Token: 0x06025386 RID: 152454 RVA: 0x00522EE8 File Offset: 0x005210E8
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5C6 RID: 42438
		// (get) Token: 0x06025387 RID: 152455 RVA: 0x00522F28 File Offset: 0x00521128
		public bool IsFollowSplineDir
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5C7 RID: 42439
		// (get) Token: 0x06025388 RID: 152456 RVA: 0x00522F68 File Offset: 0x00521168
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

		// Token: 0x06025389 RID: 152457 RVA: 0x00522FA8 File Offset: 0x005211A8
		public static Offset<IPathDrivenActorSplineMove> CreateIPathDrivenActorSplineMove(FlatBufferBuilder builder, EPathDrivenActorMoveType Type = EPathDrivenActorMoveType.Spline, VectorOffset SplineEntityIdsOffset = default(VectorOffset), bool IsRandomSpline = false, bool IsChainedSpline = false, bool IsLoop = false, bool IsFollowSplineDir = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPathDrivenActorSplineMove.AddSplineEntityIds(builder, SplineEntityIdsOffset);
			IPathDrivenActorSplineMove.AddNullMask(builder, NullMask);
			IPathDrivenActorSplineMove.AddIsFollowSplineDir(builder, IsFollowSplineDir);
			IPathDrivenActorSplineMove.AddIsLoop(builder, IsLoop);
			IPathDrivenActorSplineMove.AddIsChainedSpline(builder, IsChainedSpline);
			IPathDrivenActorSplineMove.AddIsRandomSpline(builder, IsRandomSpline);
			IPathDrivenActorSplineMove.AddType(builder, Type);
			return IPathDrivenActorSplineMove.EndIPathDrivenActorSplineMove(builder);
		}

		// Token: 0x0602538A RID: 152458 RVA: 0x00522FF7 File Offset: 0x005211F7
		public static void StartIPathDrivenActorSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602538B RID: 152459 RVA: 0x00523000 File Offset: 0x00521200
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602538C RID: 152460 RVA: 0x0052300B File Offset: 0x0052120B
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(1, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x0602538D RID: 152461 RVA: 0x0052301C File Offset: 0x0052121C
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602538E RID: 152462 RVA: 0x00523053 File Offset: 0x00521253
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602538F RID: 152463 RVA: 0x0052306D File Offset: 0x0052126D
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025390 RID: 152464 RVA: 0x0052308B File Offset: 0x0052128B
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025391 RID: 152465 RVA: 0x005230A4 File Offset: 0x005212A4
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025392 RID: 152466 RVA: 0x005230AF File Offset: 0x005212AF
		public static void AddIsRandomSpline(FlatBufferBuilder builder, bool isRandomSpline)
		{
			builder.AddBool(2, isRandomSpline, false);
		}

		// Token: 0x06025393 RID: 152467 RVA: 0x005230BA File Offset: 0x005212BA
		public static void AddIsChainedSpline(FlatBufferBuilder builder, bool isChainedSpline)
		{
			builder.AddBool(3, isChainedSpline, false);
		}

		// Token: 0x06025394 RID: 152468 RVA: 0x005230C5 File Offset: 0x005212C5
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(4, isLoop, false);
		}

		// Token: 0x06025395 RID: 152469 RVA: 0x005230D0 File Offset: 0x005212D0
		public static void AddIsFollowSplineDir(FlatBufferBuilder builder, bool isFollowSplineDir)
		{
			builder.AddBool(5, isFollowSplineDir, false);
		}

		// Token: 0x06025396 RID: 152470 RVA: 0x005230DB File Offset: 0x005212DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025397 RID: 152471 RVA: 0x005230E6 File Offset: 0x005212E6
		public static Offset<IPathDrivenActorSplineMove> EndIPathDrivenActorSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorSplineMove>(builder.EndTable());
		}

		// Token: 0x06025398 RID: 152472 RVA: 0x005230F4 File Offset: 0x005212F4
		public IPathDrivenActorSplineMoveT UnPack()
		{
			IPathDrivenActorSplineMoveT pathDrivenActorSplineMoveT = new IPathDrivenActorSplineMoveT();
			this.UnPackTo(pathDrivenActorSplineMoveT);
			return pathDrivenActorSplineMoveT;
		}

		// Token: 0x06025399 RID: 152473 RVA: 0x00523110 File Offset: 0x00521310
		public void UnPackTo(IPathDrivenActorSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityIds = new List<int>();
			for (int i = 0; i < this.SplineEntityIdsLength; i++)
			{
				_o.SplineEntityIds.Add(this.SplineEntityIds(i));
			}
			_o.IsRandomSpline = this.IsRandomSpline;
			_o.IsChainedSpline = this.IsChainedSpline;
			_o.IsLoop = this.IsLoop;
			_o.IsFollowSplineDir = this.IsFollowSplineDir;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602539A RID: 152474 RVA: 0x00523194 File Offset: 0x00521394
		public static Offset<IPathDrivenActorSplineMove> Pack(FlatBufferBuilder builder, IPathDrivenActorSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorSplineMove>);
			}
			VectorOffset splineEntityIdsOffset = default(VectorOffset);
			if (_o.SplineEntityIds != null)
			{
				int[] data = _o.SplineEntityIds.ToArray();
				splineEntityIdsOffset = IPathDrivenActorSplineMove.CreateSplineEntityIdsVector(builder, data);
			}
			return IPathDrivenActorSplineMove.CreateIPathDrivenActorSplineMove(builder, _o.Type, splineEntityIdsOffset, _o.IsRandomSpline, _o.IsChainedSpline, _o.IsLoop, _o.IsFollowSplineDir, _o.NullMask);
		}

		// Token: 0x0400EB55 RID: 60245
		private Table __p;
	}
}
