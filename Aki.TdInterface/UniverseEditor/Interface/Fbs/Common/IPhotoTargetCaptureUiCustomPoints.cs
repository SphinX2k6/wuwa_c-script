using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006470 RID: 25712
	public struct IPhotoTargetCaptureUiCustomPoints : IFlatbufferObject
	{
		// Token: 0x1700BDBF RID: 48575
		// (get) Token: 0x0602BB08 RID: 178952 RVA: 0x005F2098 File Offset: 0x005F0298
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB09 RID: 178953 RVA: 0x005F20A5 File Offset: 0x005F02A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB0A RID: 178954 RVA: 0x005F20AC File Offset: 0x005F02AC
		public static IPhotoTargetCaptureUiCustomPoints GetRootAsIPhotoTargetCaptureUiCustomPoints(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiCustomPoints.GetRootAsIPhotoTargetCaptureUiCustomPoints(_bb, default(IPhotoTargetCaptureUiCustomPoints));
		}

		// Token: 0x0602BB0B RID: 178955 RVA: 0x005F20C8 File Offset: 0x005F02C8
		public static IPhotoTargetCaptureUiCustomPoints GetRootAsIPhotoTargetCaptureUiCustomPoints(ByteBuffer _bb, IPhotoTargetCaptureUiCustomPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB0C RID: 178956 RVA: 0x005F20E5 File Offset: 0x005F02E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB0D RID: 178957 RVA: 0x005F20F4 File Offset: 0x005F02F4
		public IPhotoTargetCaptureUiCustomPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDC0 RID: 48576
		// (get) Token: 0x0602BB0E RID: 178958 RVA: 0x005F2104 File Offset: 0x005F0304
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

		// Token: 0x0602BB0F RID: 178959 RVA: 0x005F2140 File Offset: 0x005F0340
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BDC1 RID: 48577
		// (get) Token: 0x0602BB10 RID: 178960 RVA: 0x005F21A0 File Offset: 0x005F03A0
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

		// Token: 0x0602BB11 RID: 178961 RVA: 0x005F21CB File Offset: 0x005F03CB
		public static Offset<IPhotoTargetCaptureUiCustomPoints> CreateIPhotoTargetCaptureUiCustomPoints(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPhotoTargetCaptureUiCustomPoints.AddPoints(builder, PointsOffset);
			IPhotoTargetCaptureUiCustomPoints.AddType(builder, Type);
			return IPhotoTargetCaptureUiCustomPoints.EndIPhotoTargetCaptureUiCustomPoints(builder);
		}

		// Token: 0x0602BB12 RID: 178962 RVA: 0x005F21E8 File Offset: 0x005F03E8
		public static void StartIPhotoTargetCaptureUiCustomPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BB13 RID: 178963 RVA: 0x005F21F1 File Offset: 0x005F03F1
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB14 RID: 178964 RVA: 0x005F21FC File Offset: 0x005F03FC
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x0602BB15 RID: 178965 RVA: 0x005F220C File Offset: 0x005F040C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BB16 RID: 178966 RVA: 0x005F224C File Offset: 0x005F044C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BB17 RID: 178967 RVA: 0x005F2266 File Offset: 0x005F0466
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BB18 RID: 178968 RVA: 0x005F2284 File Offset: 0x005F0484
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BB19 RID: 178969 RVA: 0x005F229D File Offset: 0x005F049D
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BB1A RID: 178970 RVA: 0x005F22A8 File Offset: 0x005F04A8
		public static Offset<IPhotoTargetCaptureUiCustomPoints> EndIPhotoTargetCaptureUiCustomPoints(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiCustomPoints>(builder.EndTable());
		}

		// Token: 0x0602BB1B RID: 178971 RVA: 0x005F22B8 File Offset: 0x005F04B8
		public IPhotoTargetCaptureUiCustomPointsT UnPack()
		{
			IPhotoTargetCaptureUiCustomPointsT photoTargetCaptureUiCustomPointsT = new IPhotoTargetCaptureUiCustomPointsT();
			this.UnPackTo(photoTargetCaptureUiCustomPointsT);
			return photoTargetCaptureUiCustomPointsT;
		}

		// Token: 0x0602BB1C RID: 178972 RVA: 0x005F22D4 File Offset: 0x005F04D4
		public void UnPackTo(IPhotoTargetCaptureUiCustomPointsT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602BB1D RID: 178973 RVA: 0x005F2340 File Offset: 0x005F0540
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

		// Token: 0x04010591 RID: 66961
		private Table __p;
	}
}
