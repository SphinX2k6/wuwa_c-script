using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005580 RID: 21888
	public struct IContinuesVariableSpeedMovementSpline : IFlatbufferObject
	{
		// Token: 0x17009CA8 RID: 40104
		// (get) Token: 0x06022C8B RID: 142475 RVA: 0x004CA6DC File Offset: 0x004C88DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C8C RID: 142476 RVA: 0x004CA6E9 File Offset: 0x004C88E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C8D RID: 142477 RVA: 0x004CA6F0 File Offset: 0x004C88F0
		public static IContinuesVariableSpeedMovementSpline GetRootAsIContinuesVariableSpeedMovementSpline(ByteBuffer _bb)
		{
			return IContinuesVariableSpeedMovementSpline.GetRootAsIContinuesVariableSpeedMovementSpline(_bb, default(IContinuesVariableSpeedMovementSpline));
		}

		// Token: 0x06022C8E RID: 142478 RVA: 0x004CA70C File Offset: 0x004C890C
		public static IContinuesVariableSpeedMovementSpline GetRootAsIContinuesVariableSpeedMovementSpline(ByteBuffer _bb, IContinuesVariableSpeedMovementSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C8F RID: 142479 RVA: 0x004CA729 File Offset: 0x004C8929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C90 RID: 142480 RVA: 0x004CA738 File Offset: 0x004C8938
		public IContinuesVariableSpeedMovementSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CA9 RID: 40105
		// (get) Token: 0x06022C91 RID: 142481 RVA: 0x004CA748 File Offset: 0x004C8948
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

		// Token: 0x17009CAA RID: 40106
		// (get) Token: 0x06022C92 RID: 142482 RVA: 0x004CA784 File Offset: 0x004C8984
		public int TransitionSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009CAB RID: 40107
		// (get) Token: 0x06022C93 RID: 142483 RVA: 0x004CA7C0 File Offset: 0x004C89C0
		public ITimePathConfig? EntireTimePathConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITimePathConfig?(default(ITimePathConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009CAC RID: 40108
		// (get) Token: 0x06022C94 RID: 142484 RVA: 0x004CA820 File Offset: 0x004C8A20
		public EMoveCircleMode CircleMode
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMoveCircleMode.CloseLoop;
				}
				return (EMoveCircleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022C95 RID: 142485 RVA: 0x004CA860 File Offset: 0x004C8A60
		public IContinuesVariableSpeedSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IContinuesVariableSpeedSplinePoint?(default(IContinuesVariableSpeedSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CAD RID: 40109
		// (get) Token: 0x06022C96 RID: 142486 RVA: 0x004CA8C4 File Offset: 0x004C8AC4
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009CAE RID: 40110
		// (get) Token: 0x06022C97 RID: 142487 RVA: 0x004CA8F0 File Offset: 0x004C8AF0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022C98 RID: 142488 RVA: 0x004CA92D File Offset: 0x004C8B2D
		public static Offset<IContinuesVariableSpeedMovementSpline> CreateIContinuesVariableSpeedMovementSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, int TransitionSpeed = 0, Offset<ITimePathConfig> EntireTimePathConfigOffset = default(Offset<ITimePathConfig>), EMoveCircleMode CircleMode = EMoveCircleMode.CloseLoop, VectorOffset PointsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IContinuesVariableSpeedMovementSpline.AddPoints(builder, PointsOffset);
			IContinuesVariableSpeedMovementSpline.AddEntireTimePathConfig(builder, EntireTimePathConfigOffset);
			IContinuesVariableSpeedMovementSpline.AddTransitionSpeed(builder, TransitionSpeed);
			IContinuesVariableSpeedMovementSpline.AddNullMask(builder, NullMask);
			IContinuesVariableSpeedMovementSpline.AddCircleMode(builder, CircleMode);
			IContinuesVariableSpeedMovementSpline.AddType(builder, Type);
			return IContinuesVariableSpeedMovementSpline.EndIContinuesVariableSpeedMovementSpline(builder);
		}

		// Token: 0x06022C99 RID: 142489 RVA: 0x004CA969 File Offset: 0x004C8B69
		public static void StartIContinuesVariableSpeedMovementSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06022C9A RID: 142490 RVA: 0x004CA972 File Offset: 0x004C8B72
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022C9B RID: 142491 RVA: 0x004CA97D File Offset: 0x004C8B7D
		public static void AddTransitionSpeed(FlatBufferBuilder builder, int transitionSpeed)
		{
			builder.AddInt(1, transitionSpeed, 0);
		}

		// Token: 0x06022C9C RID: 142492 RVA: 0x004CA988 File Offset: 0x004C8B88
		public static void AddEntireTimePathConfig(FlatBufferBuilder builder, Offset<ITimePathConfig> entireTimePathConfigOffset)
		{
			builder.AddOffset(2, entireTimePathConfigOffset.Value, 0);
		}

		// Token: 0x06022C9D RID: 142493 RVA: 0x004CA998 File Offset: 0x004C8B98
		public static void AddCircleMode(FlatBufferBuilder builder, EMoveCircleMode circleMode)
		{
			builder.AddByte(3, (byte)circleMode, 0);
		}

		// Token: 0x06022C9E RID: 142494 RVA: 0x004CA9A3 File Offset: 0x004C8BA3
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(4, pointsOffset.Value, 0);
		}

		// Token: 0x06022C9F RID: 142495 RVA: 0x004CA9B4 File Offset: 0x004C8BB4
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IContinuesVariableSpeedSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022CA0 RID: 142496 RVA: 0x004CA9F4 File Offset: 0x004C8BF4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IContinuesVariableSpeedSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IContinuesVariableSpeedSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CA1 RID: 142497 RVA: 0x004CAA0E File Offset: 0x004C8C0E
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IContinuesVariableSpeedSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IContinuesVariableSpeedSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022CA2 RID: 142498 RVA: 0x004CAA2C File Offset: 0x004C8C2C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IContinuesVariableSpeedSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022CA3 RID: 142499 RVA: 0x004CAA45 File Offset: 0x004C8C45
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022CA4 RID: 142500 RVA: 0x004CAA50 File Offset: 0x004C8C50
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06022CA5 RID: 142501 RVA: 0x004CAA5B File Offset: 0x004C8C5B
		public static Offset<IContinuesVariableSpeedMovementSpline> EndIContinuesVariableSpeedMovementSpline(FlatBufferBuilder builder)
		{
			return new Offset<IContinuesVariableSpeedMovementSpline>(builder.EndTable());
		}

		// Token: 0x06022CA6 RID: 142502 RVA: 0x004CAA68 File Offset: 0x004C8C68
		public IContinuesVariableSpeedMovementSplineT UnPack()
		{
			IContinuesVariableSpeedMovementSplineT continuesVariableSpeedMovementSplineT = new IContinuesVariableSpeedMovementSplineT();
			this.UnPackTo(continuesVariableSpeedMovementSplineT);
			return continuesVariableSpeedMovementSplineT;
		}

		// Token: 0x06022CA7 RID: 142503 RVA: 0x004CAA84 File Offset: 0x004C8C84
		public void UnPackTo(IContinuesVariableSpeedMovementSplineT _o)
		{
			_o.Type = this.Type;
			_o.TransitionSpeed = this.TransitionSpeed;
			_o.EntireTimePathConfig = ((this.EntireTimePathConfig != null) ? this.EntireTimePathConfig.Value.UnPack() : null);
			_o.CircleMode = this.CircleMode;
			_o.Points = new List<IContinuesVariableSpeedSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022CA8 RID: 142504 RVA: 0x004CAB44 File Offset: 0x004C8D44
		public static Offset<IContinuesVariableSpeedMovementSpline> Pack(FlatBufferBuilder builder, IContinuesVariableSpeedMovementSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IContinuesVariableSpeedMovementSpline>);
			}
			Offset<ITimePathConfig> entireTimePathConfigOffset = (_o.EntireTimePathConfig == null) ? default(Offset<ITimePathConfig>) : ITimePathConfig.Pack(builder, _o.EntireTimePathConfig);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IContinuesVariableSpeedSplinePoint>[] array = new Offset<IContinuesVariableSpeedSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IContinuesVariableSpeedSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IContinuesVariableSpeedMovementSpline.CreatePointsVector(builder, array);
			}
			return IContinuesVariableSpeedMovementSpline.CreateIContinuesVariableSpeedMovementSpline(builder, _o.Type, _o.TransitionSpeed, entireTimePathConfigOffset, _o.CircleMode, pointsOffset, _o.NullMask);
		}

		// Token: 0x0400EBF4 RID: 60404
		private Table __p;
	}
}
