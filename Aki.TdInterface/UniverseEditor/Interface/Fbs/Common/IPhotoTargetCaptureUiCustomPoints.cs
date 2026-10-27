using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E33 RID: 24115
	public struct IPhotoTargetCaptureUiCustomPoints : IFlatbufferObject
	{
		// Token: 0x1700B459 RID: 46169
		// (get) Token: 0x0602947E RID: 169086 RVA: 0x005A9368 File Offset: 0x005A7568
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602947F RID: 169087 RVA: 0x005A9375 File Offset: 0x005A7575
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029480 RID: 169088 RVA: 0x005A937C File Offset: 0x005A757C
		public static IPhotoTargetCaptureUiCustomPoints GetRootAsIPhotoTargetCaptureUiCustomPoints(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiCustomPoints.GetRootAsIPhotoTargetCaptureUiCustomPoints(_bb, default(IPhotoTargetCaptureUiCustomPoints));
		}

		// Token: 0x06029481 RID: 169089 RVA: 0x005A9398 File Offset: 0x005A7598
		public static IPhotoTargetCaptureUiCustomPoints GetRootAsIPhotoTargetCaptureUiCustomPoints(ByteBuffer _bb, IPhotoTargetCaptureUiCustomPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029482 RID: 169090 RVA: 0x005A93B5 File Offset: 0x005A75B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029483 RID: 169091 RVA: 0x005A93C4 File Offset: 0x005A75C4
		public IPhotoTargetCaptureUiCustomPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B45A RID: 46170
		// (get) Token: 0x06029484 RID: 169092 RVA: 0x005A93D4 File Offset: 0x005A75D4
		public EPhotoTargetCaptureUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotoTargetCaptureUiType.RequiredPointsCenter;
				}
				return (EPhotoTargetCaptureUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029485 RID: 169093 RVA: 0x005A9410 File Offset: 0x005A7610
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B45B RID: 46171
		// (get) Token: 0x06029486 RID: 169094 RVA: 0x005A9470 File Offset: 0x005A7670
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

		// Token: 0x06029487 RID: 169095 RVA: 0x005A949B File Offset: 0x005A769B
		public static Offset<IPhotoTargetCaptureUiCustomPoints> CreateIPhotoTargetCaptureUiCustomPoints(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPhotoTargetCaptureUiCustomPoints.AddPoints(builder, PointsOffset);
			IPhotoTargetCaptureUiCustomPoints.AddType(builder, Type);
			return IPhotoTargetCaptureUiCustomPoints.EndIPhotoTargetCaptureUiCustomPoints(builder);
		}

		// Token: 0x06029488 RID: 169096 RVA: 0x005A94B8 File Offset: 0x005A76B8
		public static void StartIPhotoTargetCaptureUiCustomPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029489 RID: 169097 RVA: 0x005A94C1 File Offset: 0x005A76C1
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602948A RID: 169098 RVA: 0x005A94CC File Offset: 0x005A76CC
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x0602948B RID: 169099 RVA: 0x005A94DC File Offset: 0x005A76DC
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602948C RID: 169100 RVA: 0x005A951C File Offset: 0x005A771C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602948D RID: 169101 RVA: 0x005A9536 File Offset: 0x005A7736
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602948E RID: 169102 RVA: 0x005A9554 File Offset: 0x005A7754
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602948F RID: 169103 RVA: 0x005A956D File Offset: 0x005A776D
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029490 RID: 169104 RVA: 0x005A9578 File Offset: 0x005A7778
		public static Offset<IPhotoTargetCaptureUiCustomPoints> EndIPhotoTargetCaptureUiCustomPoints(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiCustomPoints>(builder.EndTable());
		}

		// Token: 0x06029491 RID: 169105 RVA: 0x005A9588 File Offset: 0x005A7788
		public IPhotoTargetCaptureUiCustomPointsT UnPack()
		{
			IPhotoTargetCaptureUiCustomPointsT photoTargetCaptureUiCustomPointsT = new IPhotoTargetCaptureUiCustomPointsT();
			this.UnPackTo(photoTargetCaptureUiCustomPointsT);
			return photoTargetCaptureUiCustomPointsT;
		}

		// Token: 0x06029492 RID: 169106 RVA: 0x005A95A4 File Offset: 0x005A77A4
		public void UnPackTo(IPhotoTargetCaptureUiCustomPointsT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029493 RID: 169107 RVA: 0x005A9610 File Offset: 0x005A7810
		public static Offset<IPhotoTargetCaptureUiCustomPoints> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiCustomPointsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiCustomPoints>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IPhotoTargetCaptureUiCustomPoints.CreatePointsVector(builder, array);
			}
			return IPhotoTargetCaptureUiCustomPoints.CreateIPhotoTargetCaptureUiCustomPoints(builder, _o.Type, pointsOffset);
		}

		// Token: 0x0400F836 RID: 63542
		private Table __p;
	}
}
