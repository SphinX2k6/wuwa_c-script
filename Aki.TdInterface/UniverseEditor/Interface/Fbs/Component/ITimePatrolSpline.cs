using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A88 RID: 23176
	public struct ITimePatrolSpline : IFlatbufferObject
	{
		// Token: 0x1700AE8B RID: 44683
		// (get) Token: 0x06027793 RID: 161683 RVA: 0x0056E5E5 File Offset: 0x0056C7E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027794 RID: 161684 RVA: 0x0056E5F2 File Offset: 0x0056C7F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027795 RID: 161685 RVA: 0x0056E5FC File Offset: 0x0056C7FC
		public static ITimePatrolSpline GetRootAsITimePatrolSpline(ByteBuffer _bb)
		{
			return ITimePatrolSpline.GetRootAsITimePatrolSpline(_bb, default(ITimePatrolSpline));
		}

		// Token: 0x06027796 RID: 161686 RVA: 0x0056E618 File Offset: 0x0056C818
		public static ITimePatrolSpline GetRootAsITimePatrolSpline(ByteBuffer _bb, ITimePatrolSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027797 RID: 161687 RVA: 0x0056E635 File Offset: 0x0056C835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027798 RID: 161688 RVA: 0x0056E644 File Offset: 0x0056C844
		public ITimePatrolSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE8C RID: 44684
		// (get) Token: 0x06027799 RID: 161689 RVA: 0x0056E654 File Offset: 0x0056C854
		public ESplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineType.Common;
				}
				return (ESplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602779A RID: 161690 RVA: 0x0056E690 File Offset: 0x0056C890
		public ITimePatrolSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITimePatrolSplinePoint?(default(ITimePatrolSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE8D RID: 44685
		// (get) Token: 0x0602779B RID: 161691 RVA: 0x0056E6F0 File Offset: 0x0056C8F0
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

		// Token: 0x0602779C RID: 161692 RVA: 0x0056E71B File Offset: 0x0056C91B
		public static Offset<ITimePatrolSpline> CreateITimePatrolSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITimePatrolSpline.AddPoints(builder, PointsOffset);
			ITimePatrolSpline.AddType(builder, Type);
			return ITimePatrolSpline.EndITimePatrolSpline(builder);
		}

		// Token: 0x0602779D RID: 161693 RVA: 0x0056E738 File Offset: 0x0056C938
		public static void StartITimePatrolSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602779E RID: 161694 RVA: 0x0056E741 File Offset: 0x0056C941
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602779F RID: 161695 RVA: 0x0056E74C File Offset: 0x0056C94C
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x060277A0 RID: 161696 RVA: 0x0056E75C File Offset: 0x0056C95C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ITimePatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060277A1 RID: 161697 RVA: 0x0056E79C File Offset: 0x0056C99C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ITimePatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITimePatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060277A2 RID: 161698 RVA: 0x0056E7B6 File Offset: 0x0056C9B6
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITimePatrolSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITimePatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060277A3 RID: 161699 RVA: 0x0056E7D4 File Offset: 0x0056C9D4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITimePatrolSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060277A4 RID: 161700 RVA: 0x0056E7ED File Offset: 0x0056C9ED
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060277A5 RID: 161701 RVA: 0x0056E7F8 File Offset: 0x0056C9F8
		public static Offset<ITimePatrolSpline> EndITimePatrolSpline(FlatBufferBuilder builder)
		{
			return new Offset<ITimePatrolSpline>(builder.EndTable());
		}

		// Token: 0x060277A6 RID: 161702 RVA: 0x0056E808 File Offset: 0x0056CA08
		public ITimePatrolSplineT UnPack()
		{
			ITimePatrolSplineT timePatrolSplineT = new ITimePatrolSplineT();
			this.UnPackTo(timePatrolSplineT);
			return timePatrolSplineT;
		}

		// Token: 0x060277A7 RID: 161703 RVA: 0x0056E824 File Offset: 0x0056CA24
		public void UnPackTo(ITimePatrolSplineT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<ITimePatrolSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060277A8 RID: 161704 RVA: 0x0056E890 File Offset: 0x0056CA90
		public static Offset<ITimePatrolSpline> Pack(FlatBufferBuilder builder, ITimePatrolSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimePatrolSpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ITimePatrolSplinePoint>[] array = new Offset<ITimePatrolSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITimePatrolSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = ITimePatrolSpline.CreatePointsVector(builder, array);
			}
			return ITimePatrolSpline.CreateITimePatrolSpline(builder, _o.Type, pointsOffset);
		}

		// Token: 0x0400F13D RID: 61757
		private Table __p;
	}
}
