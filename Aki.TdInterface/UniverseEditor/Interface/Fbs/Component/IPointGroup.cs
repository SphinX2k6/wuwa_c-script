using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575A RID: 22362
	public struct IPointGroup : IFlatbufferObject
	{
		// Token: 0x1700A6CF RID: 42703
		// (get) Token: 0x06025789 RID: 153481 RVA: 0x0052B70D File Offset: 0x0052990D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602578A RID: 153482 RVA: 0x0052B71A File Offset: 0x0052991A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602578B RID: 153483 RVA: 0x0052B724 File Offset: 0x00529924
		public static IPointGroup GetRootAsIPointGroup(ByteBuffer _bb)
		{
			return IPointGroup.GetRootAsIPointGroup(_bb, default(IPointGroup));
		}

		// Token: 0x0602578C RID: 153484 RVA: 0x0052B740 File Offset: 0x00529940
		public static IPointGroup GetRootAsIPointGroup(ByteBuffer _bb, IPointGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602578D RID: 153485 RVA: 0x0052B75D File Offset: 0x0052995D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602578E RID: 153486 RVA: 0x0052B76C File Offset: 0x0052996C
		public IPointGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6D0 RID: 42704
		// (get) Token: 0x0602578F RID: 153487 RVA: 0x0052B77C File Offset: 0x0052997C
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

		// Token: 0x06025790 RID: 153488 RVA: 0x0052B7DC File Offset: 0x005299DC
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A6D1 RID: 42705
		// (get) Token: 0x06025791 RID: 153489 RVA: 0x0052B83C File Offset: 0x00529A3C
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

		// Token: 0x06025792 RID: 153490 RVA: 0x0052B867 File Offset: 0x00529A67
		public static Offset<IPointGroup> CreateIPointGroup(FlatBufferBuilder builder, Offset<IPointGroupByLayer> GroupConfigOffset = default(Offset<IPointGroupByLayer>), VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPointGroup.AddPoints(builder, PointsOffset);
			IPointGroup.AddGroupConfig(builder, GroupConfigOffset);
			return IPointGroup.EndIPointGroup(builder);
		}

		// Token: 0x06025793 RID: 153491 RVA: 0x0052B884 File Offset: 0x00529A84
		public static void StartIPointGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025794 RID: 153492 RVA: 0x0052B88D File Offset: 0x00529A8D
		public static void AddGroupConfig(FlatBufferBuilder builder, Offset<IPointGroupByLayer> groupConfigOffset)
		{
			builder.AddOffset(0, groupConfigOffset.Value, 0);
		}

		// Token: 0x06025795 RID: 153493 RVA: 0x0052B89D File Offset: 0x00529A9D
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x06025796 RID: 153494 RVA: 0x0052B8B0 File Offset: 0x00529AB0
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025797 RID: 153495 RVA: 0x0052B8F0 File Offset: 0x00529AF0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025798 RID: 153496 RVA: 0x0052B90A File Offset: 0x00529B0A
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025799 RID: 153497 RVA: 0x0052B928 File Offset: 0x00529B28
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602579A RID: 153498 RVA: 0x0052B941 File Offset: 0x00529B41
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602579B RID: 153499 RVA: 0x0052B94C File Offset: 0x00529B4C
		public static Offset<IPointGroup> EndIPointGroup(FlatBufferBuilder builder)
		{
			return new Offset<IPointGroup>(builder.EndTable());
		}

		// Token: 0x0602579C RID: 153500 RVA: 0x0052B95C File Offset: 0x00529B5C
		public IPointGroupT UnPack()
		{
			IPointGroupT pointGroupT = new IPointGroupT();
			this.UnPackTo(pointGroupT);
			return pointGroupT;
		}

		// Token: 0x0602579D RID: 153501 RVA: 0x0052B978 File Offset: 0x00529B78
		public void UnPackTo(IPointGroupT _o)
		{
			_o.GroupConfig = ((this.GroupConfig != null) ? this.GroupConfig.Value.UnPack() : null);
			_o.Points = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602579E RID: 153502 RVA: 0x0052BA08 File Offset: 0x00529C08
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

		// Token: 0x0400EBFA RID: 60410
		private Table __p;
	}
}
