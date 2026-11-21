using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D61 RID: 23905
	public struct IPointGroup : IFlatbufferObject
	{
		// Token: 0x1700AFF3 RID: 45043
		// (get) Token: 0x06027CA9 RID: 162985 RVA: 0x00571899 File Offset: 0x0056FA99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027CAA RID: 162986 RVA: 0x005718A6 File Offset: 0x0056FAA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027CAB RID: 162987 RVA: 0x005718B0 File Offset: 0x0056FAB0
		public static IPointGroup GetRootAsIPointGroup(ByteBuffer _bb)
		{
			return IPointGroup.GetRootAsIPointGroup(_bb, default(IPointGroup));
		}

		// Token: 0x06027CAC RID: 162988 RVA: 0x005718CC File Offset: 0x0056FACC
		public static IPointGroup GetRootAsIPointGroup(ByteBuffer _bb, IPointGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027CAD RID: 162989 RVA: 0x005718E9 File Offset: 0x0056FAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027CAE RID: 162990 RVA: 0x005718F8 File Offset: 0x0056FAF8
		public IPointGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFF4 RID: 45044
		// (get) Token: 0x06027CAF RID: 162991 RVA: 0x00571908 File Offset: 0x0056FB08
		public IPointGroupByLayer? GroupConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPointGroupByLayer?(default(IPointGroupByLayer).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027CB0 RID: 162992 RVA: 0x00571968 File Offset: 0x0056FB68
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFF5 RID: 45045
		// (get) Token: 0x06027CB1 RID: 162993 RVA: 0x005719C8 File Offset: 0x0056FBC8
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

		// Token: 0x06027CB2 RID: 162994 RVA: 0x005719F3 File Offset: 0x0056FBF3
		public static Offset<IPointGroup> CreateIPointGroup(FlatBufferBuilder builder, Offset<IPointGroupByLayer> GroupConfigOffset = default(Offset<IPointGroupByLayer>), VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPointGroup.AddPoints(builder, PointsOffset);
			IPointGroup.AddGroupConfig(builder, GroupConfigOffset);
			return IPointGroup.EndIPointGroup(builder);
		}

		// Token: 0x06027CB3 RID: 162995 RVA: 0x00571A10 File Offset: 0x0056FC10
		public static void StartIPointGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027CB4 RID: 162996 RVA: 0x00571A19 File Offset: 0x0056FC19
		public static void AddGroupConfig(FlatBufferBuilder builder, Offset<IPointGroupByLayer> groupConfigOffset)
		{
			builder.AddOffset(0, groupConfigOffset.Value, 0);
		}

		// Token: 0x06027CB5 RID: 162997 RVA: 0x00571A29 File Offset: 0x0056FC29
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x06027CB6 RID: 162998 RVA: 0x00571A3C File Offset: 0x0056FC3C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027CB7 RID: 162999 RVA: 0x00571A7C File Offset: 0x0056FC7C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CB8 RID: 163000 RVA: 0x00571A96 File Offset: 0x0056FC96
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CB9 RID: 163001 RVA: 0x00571AB4 File Offset: 0x0056FCB4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027CBA RID: 163002 RVA: 0x00571ACD File Offset: 0x0056FCCD
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027CBB RID: 163003 RVA: 0x00571AD8 File Offset: 0x0056FCD8
		public static Offset<IPointGroup> EndIPointGroup(FlatBufferBuilder builder)
		{
			return new Offset<IPointGroup>(builder.EndTable());
		}

		// Token: 0x06027CBC RID: 163004 RVA: 0x00571AE8 File Offset: 0x0056FCE8
		public IPointGroupT UnPack()
		{
			IPointGroupT pointGroupT = new IPointGroupT();
			this.UnPackTo(pointGroupT);
			return pointGroupT;
		}

		// Token: 0x06027CBD RID: 163005 RVA: 0x00571B04 File Offset: 0x0056FD04
		public void UnPackTo(IPointGroupT _o)
		{
			_o.GroupConfig = ((this.GroupConfig != null) ? this.GroupConfig.Value.UnPack() : null);
			_o.Points = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06027CBE RID: 163006 RVA: 0x00571B94 File Offset: 0x0056FD94
		public static Offset<IPointGroup> Pack(FlatBufferBuilder builder, IPointGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointGroup>);
			}
			Offset<IPointGroupByLayer> groupConfigOffset = (_o.GroupConfig == null) ? default(Offset<IPointGroupByLayer>) : IPointGroupByLayer.Pack(builder, _o.GroupConfig);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IPointGroup.CreatePointsVector(builder, array);
			}
			return IPointGroup.CreateIPointGroup(builder, groupConfigOffset, pointsOffset);
		}

		// Token: 0x0400F8E5 RID: 63717
		private Table __p;
	}
}
