using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005021 RID: 20513
	public struct IContinuesVariableSpeedMovementSpline : IFlatbufferObject
	{
		// Token: 0x170094C7 RID: 38087
		// (get) Token: 0x06020D6B RID: 134507 RVA: 0x00490C8C File Offset: 0x0048EE8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D6C RID: 134508 RVA: 0x00490C99 File Offset: 0x0048EE99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D6D RID: 134509 RVA: 0x00490CA0 File Offset: 0x0048EEA0
		public static IContinuesVariableSpeedMovementSpline GetRootAsIContinuesVariableSpeedMovementSpline(ByteBuffer _bb)
		{
			return IContinuesVariableSpeedMovementSpline.GetRootAsIContinuesVariableSpeedMovementSpline(_bb, default(IContinuesVariableSpeedMovementSpline));
		}

		// Token: 0x06020D6E RID: 134510 RVA: 0x00490CBC File Offset: 0x0048EEBC
		public static IContinuesVariableSpeedMovementSpline GetRootAsIContinuesVariableSpeedMovementSpline(ByteBuffer _bb, IContinuesVariableSpeedMovementSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D6F RID: 134511 RVA: 0x00490CD9 File Offset: 0x0048EED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D70 RID: 134512 RVA: 0x00490CE8 File Offset: 0x0048EEE8
		public IContinuesVariableSpeedMovementSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094C8 RID: 38088
		// (get) Token: 0x06020D71 RID: 134513 RVA: 0x00490CF8 File Offset: 0x0048EEF8
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

		// Token: 0x170094C9 RID: 38089
		// (get) Token: 0x06020D72 RID: 134514 RVA: 0x00490D34 File Offset: 0x0048EF34
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

		// Token: 0x170094CA RID: 38090
		// (get) Token: 0x06020D73 RID: 134515 RVA: 0x00490D70 File Offset: 0x0048EF70
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

		// Token: 0x170094CB RID: 38091
		// (get) Token: 0x06020D74 RID: 134516 RVA: 0x00490DD0 File Offset: 0x0048EFD0
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

		// Token: 0x06020D75 RID: 134517 RVA: 0x00490E10 File Offset: 0x0048F010
		public IContinuesVariableSpeedSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IContinuesVariableSpeedSplinePoint?(default(IContinuesVariableSpeedSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094CC RID: 38092
		// (get) Token: 0x06020D76 RID: 134518 RVA: 0x00490E74 File Offset: 0x0048F074
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

		// Token: 0x170094CD RID: 38093
		// (get) Token: 0x06020D77 RID: 134519 RVA: 0x00490EA0 File Offset: 0x0048F0A0
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

		// Token: 0x06020D78 RID: 134520 RVA: 0x00490EDD File Offset: 0x0048F0DD
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

		// Token: 0x06020D79 RID: 134521 RVA: 0x00490F19 File Offset: 0x0048F119
		public static void StartIContinuesVariableSpeedMovementSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06020D7A RID: 134522 RVA: 0x00490F22 File Offset: 0x0048F122
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D7B RID: 134523 RVA: 0x00490F2D File Offset: 0x0048F12D
		public static void AddTransitionSpeed(FlatBufferBuilder builder, int transitionSpeed)
		{
			builder.AddInt(1, transitionSpeed, 0);
		}

		// Token: 0x06020D7C RID: 134524 RVA: 0x00490F38 File Offset: 0x0048F138
		public static void AddEntireTimePathConfig(FlatBufferBuilder builder, Offset<ITimePathConfig> entireTimePathConfigOffset)
		{
			builder.AddOffset(2, entireTimePathConfigOffset.Value, 0);
		}

		// Token: 0x06020D7D RID: 134525 RVA: 0x00490F48 File Offset: 0x0048F148
		public static void AddCircleMode(FlatBufferBuilder builder, EMoveCircleMode circleMode)
		{
			builder.AddByte(3, (byte)circleMode, 0);
		}

		// Token: 0x06020D7E RID: 134526 RVA: 0x00490F53 File Offset: 0x0048F153
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(4, pointsOffset.Value, 0);
		}

		// Token: 0x06020D7F RID: 134527 RVA: 0x00490F64 File Offset: 0x0048F164
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IContinuesVariableSpeedSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020D80 RID: 134528 RVA: 0x00490FA4 File Offset: 0x0048F1A4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IContinuesVariableSpeedSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IContinuesVariableSpeedSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D81 RID: 134529 RVA: 0x00490FBE File Offset: 0x0048F1BE
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IContinuesVariableSpeedSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IContinuesVariableSpeedSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020D82 RID: 134530 RVA: 0x00490FDC File Offset: 0x0048F1DC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IContinuesVariableSpeedSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020D83 RID: 134531 RVA: 0x00490FF5 File Offset: 0x0048F1F5
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020D84 RID: 134532 RVA: 0x00491000 File Offset: 0x0048F200
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06020D85 RID: 134533 RVA: 0x0049100B File Offset: 0x0048F20B
		public static Offset<IContinuesVariableSpeedMovementSpline> EndIContinuesVariableSpeedMovementSpline(FlatBufferBuilder builder)
		{
			return new Offset<IContinuesVariableSpeedMovementSpline>(builder.EndTable());
		}

		// Token: 0x06020D86 RID: 134534 RVA: 0x00491018 File Offset: 0x0048F218
		public IContinuesVariableSpeedMovementSplineT UnPack()
		{
			IContinuesVariableSpeedMovementSplineT continuesVariableSpeedMovementSplineT = new IContinuesVariableSpeedMovementSplineT();
			this.UnPackTo(continuesVariableSpeedMovementSplineT);
			return continuesVariableSpeedMovementSplineT;
		}

		// Token: 0x06020D87 RID: 134535 RVA: 0x00491034 File Offset: 0x0048F234
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

		// Token: 0x06020D88 RID: 134536 RVA: 0x004910F4 File Offset: 0x0048F2F4
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

		// Token: 0x0400DFFE RID: 57342
		private Table __p;
	}
}
