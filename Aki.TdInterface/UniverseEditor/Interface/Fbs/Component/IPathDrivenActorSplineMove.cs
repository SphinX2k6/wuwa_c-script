using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CED RID: 23789
	public struct IPathDrivenActorSplineMove : IFlatbufferObject
	{
		// Token: 0x1700AEC3 RID: 44739
		// (get) Token: 0x060277E0 RID: 161760 RVA: 0x00567782 File Offset: 0x00565982
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060277E1 RID: 161761 RVA: 0x0056778F File Offset: 0x0056598F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060277E2 RID: 161762 RVA: 0x00567798 File Offset: 0x00565998
		public static IPathDrivenActorSplineMove GetRootAsIPathDrivenActorSplineMove(ByteBuffer _bb)
		{
			return IPathDrivenActorSplineMove.GetRootAsIPathDrivenActorSplineMove(_bb, default(IPathDrivenActorSplineMove));
		}

		// Token: 0x060277E3 RID: 161763 RVA: 0x005677B4 File Offset: 0x005659B4
		public static IPathDrivenActorSplineMove GetRootAsIPathDrivenActorSplineMove(ByteBuffer _bb, IPathDrivenActorSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060277E4 RID: 161764 RVA: 0x005677D1 File Offset: 0x005659D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060277E5 RID: 161765 RVA: 0x005677E0 File Offset: 0x005659E0
		public IPathDrivenActorSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEC4 RID: 44740
		// (get) Token: 0x060277E6 RID: 161766 RVA: 0x005677F0 File Offset: 0x005659F0
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

		// Token: 0x060277E7 RID: 161767 RVA: 0x0056782C File Offset: 0x00565A2C
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AEC5 RID: 44741
		// (get) Token: 0x060277E8 RID: 161768 RVA: 0x0056786C File Offset: 0x00565A6C
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

		// Token: 0x060277E9 RID: 161769 RVA: 0x00567897 File Offset: 0x00565A97
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060277EA RID: 161770 RVA: 0x005678A6 File Offset: 0x00565AA6
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700AEC6 RID: 44742
		// (get) Token: 0x060277EB RID: 161771 RVA: 0x005678B4 File Offset: 0x00565AB4
		public bool IsRandomSpline
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AEC7 RID: 44743
		// (get) Token: 0x060277EC RID: 161772 RVA: 0x005678F4 File Offset: 0x00565AF4
		public bool IsChainedSpline
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AEC8 RID: 44744
		// (get) Token: 0x060277ED RID: 161773 RVA: 0x00567934 File Offset: 0x00565B34
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AEC9 RID: 44745
		// (get) Token: 0x060277EE RID: 161774 RVA: 0x00567974 File Offset: 0x00565B74
		public bool IsFollowSplineDir
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AECA RID: 44746
		// (get) Token: 0x060277EF RID: 161775 RVA: 0x005679B4 File Offset: 0x00565BB4
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

		// Token: 0x060277F0 RID: 161776 RVA: 0x005679F4 File Offset: 0x00565BF4
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

		// Token: 0x060277F1 RID: 161777 RVA: 0x00567A43 File Offset: 0x00565C43
		public static void StartIPathDrivenActorSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060277F2 RID: 161778 RVA: 0x00567A4C File Offset: 0x00565C4C
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060277F3 RID: 161779 RVA: 0x00567A57 File Offset: 0x00565C57
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(1, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x060277F4 RID: 161780 RVA: 0x00567A68 File Offset: 0x00565C68
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060277F5 RID: 161781 RVA: 0x00567A9F File Offset: 0x00565C9F
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060277F6 RID: 161782 RVA: 0x00567AB9 File Offset: 0x00565CB9
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060277F7 RID: 161783 RVA: 0x00567AD7 File Offset: 0x00565CD7
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060277F8 RID: 161784 RVA: 0x00567AF0 File Offset: 0x00565CF0
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060277F9 RID: 161785 RVA: 0x00567AFB File Offset: 0x00565CFB
		public static void AddIsRandomSpline(FlatBufferBuilder builder, bool isRandomSpline)
		{
			builder.AddBool(2, isRandomSpline, false);
		}

		// Token: 0x060277FA RID: 161786 RVA: 0x00567B06 File Offset: 0x00565D06
		public static void AddIsChainedSpline(FlatBufferBuilder builder, bool isChainedSpline)
		{
			builder.AddBool(3, isChainedSpline, false);
		}

		// Token: 0x060277FB RID: 161787 RVA: 0x00567B11 File Offset: 0x00565D11
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(4, isLoop, false);
		}

		// Token: 0x060277FC RID: 161788 RVA: 0x00567B1C File Offset: 0x00565D1C
		public static void AddIsFollowSplineDir(FlatBufferBuilder builder, bool isFollowSplineDir)
		{
			builder.AddBool(5, isFollowSplineDir, false);
		}

		// Token: 0x060277FD RID: 161789 RVA: 0x00567B27 File Offset: 0x00565D27
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060277FE RID: 161790 RVA: 0x00567B32 File Offset: 0x00565D32
		public static Offset<IPathDrivenActorSplineMove> EndIPathDrivenActorSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorSplineMove>(builder.EndTable());
		}

		// Token: 0x060277FF RID: 161791 RVA: 0x00567B40 File Offset: 0x00565D40
		public IPathDrivenActorSplineMoveT UnPack()
		{
			IPathDrivenActorSplineMoveT pathDrivenActorSplineMoveT = new IPathDrivenActorSplineMoveT();
			this.UnPackTo(pathDrivenActorSplineMoveT);
			return pathDrivenActorSplineMoveT;
		}

		// Token: 0x06027800 RID: 161792 RVA: 0x00567B5C File Offset: 0x00565D5C
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

		// Token: 0x06027801 RID: 161793 RVA: 0x00567BE0 File Offset: 0x00565DE0
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

		// Token: 0x0400F822 RID: 63522
		private Table __p;
	}
}
