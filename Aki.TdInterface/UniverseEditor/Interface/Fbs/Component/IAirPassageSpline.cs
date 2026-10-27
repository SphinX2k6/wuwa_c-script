using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E89 RID: 20105
	public struct IAirPassageSpline : IFlatbufferObject
	{
		// Token: 0x17009012 RID: 36882
		// (get) Token: 0x0601F9D2 RID: 129490 RVA: 0x00467316 File Offset: 0x00465516
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F9D3 RID: 129491 RVA: 0x00467323 File Offset: 0x00465523
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F9D4 RID: 129492 RVA: 0x0046732C File Offset: 0x0046552C
		public static IAirPassageSpline GetRootAsIAirPassageSpline(ByteBuffer _bb)
		{
			return IAirPassageSpline.GetRootAsIAirPassageSpline(_bb, default(IAirPassageSpline));
		}

		// Token: 0x0601F9D5 RID: 129493 RVA: 0x00467348 File Offset: 0x00465548
		public static IAirPassageSpline GetRootAsIAirPassageSpline(ByteBuffer _bb, IAirPassageSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F9D6 RID: 129494 RVA: 0x00467365 File Offset: 0x00465565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F9D7 RID: 129495 RVA: 0x00467374 File Offset: 0x00465574
		public IAirPassageSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009013 RID: 36883
		// (get) Token: 0x0601F9D8 RID: 129496 RVA: 0x00467384 File Offset: 0x00465584
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

		// Token: 0x17009014 RID: 36884
		// (get) Token: 0x0601F9D9 RID: 129497 RVA: 0x004673C0 File Offset: 0x004655C0
		public string MiddleLineEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F9DA RID: 129498 RVA: 0x004673F7 File Offset: 0x004655F7
		public Span<byte> GetMiddleLineEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601F9DB RID: 129499 RVA: 0x00467406 File Offset: 0x00465606
		public byte[] GetMiddleLineEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009015 RID: 36885
		// (get) Token: 0x0601F9DC RID: 129500 RVA: 0x00467414 File Offset: 0x00465614
		public string TailCircleEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F9DD RID: 129501 RVA: 0x0046744B File Offset: 0x0046564B
		public Span<byte> GetTailCircleEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601F9DE RID: 129502 RVA: 0x0046745A File Offset: 0x0046565A
		public byte[] GetTailCircleEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009016 RID: 36886
		// (get) Token: 0x0601F9DF RID: 129503 RVA: 0x00467468 File Offset: 0x00465668
		public string MiddleCircleEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F9E0 RID: 129504 RVA: 0x004674A0 File Offset: 0x004656A0
		public Span<byte> GetMiddleCircleEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601F9E1 RID: 129505 RVA: 0x004674B0 File Offset: 0x004656B0
		public byte[] GetMiddleCircleEffectArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009017 RID: 36887
		// (get) Token: 0x0601F9E2 RID: 129506 RVA: 0x004674C0 File Offset: 0x004656C0
		public string MiddleCircleOverlyingEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F9E3 RID: 129507 RVA: 0x004674F8 File Offset: 0x004656F8
		public Span<byte> GetMiddleCircleOverlyingEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601F9E4 RID: 129508 RVA: 0x00467508 File Offset: 0x00465708
		public byte[] GetMiddleCircleOverlyingEffectArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009018 RID: 36888
		// (get) Token: 0x0601F9E5 RID: 129509 RVA: 0x00467518 File Offset: 0x00465718
		public float MiddleCircleSpace
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009019 RID: 36889
		// (get) Token: 0x0601F9E6 RID: 129510 RVA: 0x0046755C File Offset: 0x0046575C
		public float MiddleCircleRadius
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700901A RID: 36890
		// (get) Token: 0x0601F9E7 RID: 129511 RVA: 0x004675A0 File Offset: 0x004657A0
		public float MovableRadius
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700901B RID: 36891
		// (get) Token: 0x0601F9E8 RID: 129512 RVA: 0x004675E4 File Offset: 0x004657E4
		public float Resistance
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700901C RID: 36892
		// (get) Token: 0x0601F9E9 RID: 129513 RVA: 0x00467628 File Offset: 0x00465828
		public float SpeedLimit
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700901D RID: 36893
		// (get) Token: 0x0601F9EA RID: 129514 RVA: 0x0046766C File Offset: 0x0046586C
		public float SprintSpeedLimit
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F9EB RID: 129515 RVA: 0x004676B0 File Offset: 0x004658B0
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700901E RID: 36894
		// (get) Token: 0x0601F9EC RID: 129516 RVA: 0x00467714 File Offset: 0x00465914
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601F9ED RID: 129517 RVA: 0x00467740 File Offset: 0x00465940
		public static Offset<IAirPassageSpline> CreateIAirPassageSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, StringOffset MiddleLineEffectOffset = default(StringOffset), StringOffset TailCircleEffectOffset = default(StringOffset), StringOffset MiddleCircleEffectOffset = default(StringOffset), StringOffset MiddleCircleOverlyingEffectOffset = default(StringOffset), float MiddleCircleSpace = 0f, float MiddleCircleRadius = 0f, float MovableRadius = 0f, float Resistance = 0f, float SpeedLimit = 0f, float SprintSpeedLimit = 0f, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(12);
			IAirPassageSpline.AddPoints(builder, PointsOffset);
			IAirPassageSpline.AddSprintSpeedLimit(builder, SprintSpeedLimit);
			IAirPassageSpline.AddSpeedLimit(builder, SpeedLimit);
			IAirPassageSpline.AddResistance(builder, Resistance);
			IAirPassageSpline.AddMovableRadius(builder, MovableRadius);
			IAirPassageSpline.AddMiddleCircleRadius(builder, MiddleCircleRadius);
			IAirPassageSpline.AddMiddleCircleSpace(builder, MiddleCircleSpace);
			IAirPassageSpline.AddMiddleCircleOverlyingEffect(builder, MiddleCircleOverlyingEffectOffset);
			IAirPassageSpline.AddMiddleCircleEffect(builder, MiddleCircleEffectOffset);
			IAirPassageSpline.AddTailCircleEffect(builder, TailCircleEffectOffset);
			IAirPassageSpline.AddMiddleLineEffect(builder, MiddleLineEffectOffset);
			IAirPassageSpline.AddType(builder, Type);
			return IAirPassageSpline.EndIAirPassageSpline(builder);
		}

		// Token: 0x0601F9EE RID: 129518 RVA: 0x004677B8 File Offset: 0x004659B8
		public static void StartIAirPassageSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0601F9EF RID: 129519 RVA: 0x004677C2 File Offset: 0x004659C2
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F9F0 RID: 129520 RVA: 0x004677CD File Offset: 0x004659CD
		public static void AddMiddleLineEffect(FlatBufferBuilder builder, StringOffset middleLineEffectOffset)
		{
			builder.AddOffset(1, middleLineEffectOffset.Value, 0);
		}

		// Token: 0x0601F9F1 RID: 129521 RVA: 0x004677DD File Offset: 0x004659DD
		public static void AddTailCircleEffect(FlatBufferBuilder builder, StringOffset tailCircleEffectOffset)
		{
			builder.AddOffset(2, tailCircleEffectOffset.Value, 0);
		}

		// Token: 0x0601F9F2 RID: 129522 RVA: 0x004677ED File Offset: 0x004659ED
		public static void AddMiddleCircleEffect(FlatBufferBuilder builder, StringOffset middleCircleEffectOffset)
		{
			builder.AddOffset(3, middleCircleEffectOffset.Value, 0);
		}

		// Token: 0x0601F9F3 RID: 129523 RVA: 0x004677FD File Offset: 0x004659FD
		public static void AddMiddleCircleOverlyingEffect(FlatBufferBuilder builder, StringOffset middleCircleOverlyingEffectOffset)
		{
			builder.AddOffset(4, middleCircleOverlyingEffectOffset.Value, 0);
		}

		// Token: 0x0601F9F4 RID: 129524 RVA: 0x0046780D File Offset: 0x00465A0D
		public static void AddMiddleCircleSpace(FlatBufferBuilder builder, float middleCircleSpace)
		{
			builder.AddFloat(5, middleCircleSpace, 0.0);
		}

		// Token: 0x0601F9F5 RID: 129525 RVA: 0x00467820 File Offset: 0x00465A20
		public static void AddMiddleCircleRadius(FlatBufferBuilder builder, float middleCircleRadius)
		{
			builder.AddFloat(6, middleCircleRadius, 0.0);
		}

		// Token: 0x0601F9F6 RID: 129526 RVA: 0x00467833 File Offset: 0x00465A33
		public static void AddMovableRadius(FlatBufferBuilder builder, float movableRadius)
		{
			builder.AddFloat(7, movableRadius, 0.0);
		}

		// Token: 0x0601F9F7 RID: 129527 RVA: 0x00467846 File Offset: 0x00465A46
		public static void AddResistance(FlatBufferBuilder builder, float resistance)
		{
			builder.AddFloat(8, resistance, 0.0);
		}

		// Token: 0x0601F9F8 RID: 129528 RVA: 0x00467859 File Offset: 0x00465A59
		public static void AddSpeedLimit(FlatBufferBuilder builder, float speedLimit)
		{
			builder.AddFloat(9, speedLimit, 0.0);
		}

		// Token: 0x0601F9F9 RID: 129529 RVA: 0x0046786D File Offset: 0x00465A6D
		public static void AddSprintSpeedLimit(FlatBufferBuilder builder, float sprintSpeedLimit)
		{
			builder.AddFloat(10, sprintSpeedLimit, 0.0);
		}

		// Token: 0x0601F9FA RID: 129530 RVA: 0x00467881 File Offset: 0x00465A81
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(11, pointsOffset.Value, 0);
		}

		// Token: 0x0601F9FB RID: 129531 RVA: 0x00467894 File Offset: 0x00465A94
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F9FC RID: 129532 RVA: 0x004678D4 File Offset: 0x00465AD4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F9FD RID: 129533 RVA: 0x004678EE File Offset: 0x00465AEE
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F9FE RID: 129534 RVA: 0x0046790C File Offset: 0x00465B0C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F9FF RID: 129535 RVA: 0x00467925 File Offset: 0x00465B25
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FA00 RID: 129536 RVA: 0x00467930 File Offset: 0x00465B30
		public static Offset<IAirPassageSpline> EndIAirPassageSpline(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageSpline>(builder.EndTable());
		}

		// Token: 0x0601FA01 RID: 129537 RVA: 0x00467940 File Offset: 0x00465B40
		public IAirPassageSplineT UnPack()
		{
			IAirPassageSplineT airPassageSplineT = new IAirPassageSplineT();
			this.UnPackTo(airPassageSplineT);
			return airPassageSplineT;
		}

		// Token: 0x0601FA02 RID: 129538 RVA: 0x0046795C File Offset: 0x00465B5C
		public void UnPackTo(IAirPassageSplineT _o)
		{
			_o.Type = this.Type;
			_o.MiddleLineEffect = this.MiddleLineEffect;
			_o.TailCircleEffect = this.TailCircleEffect;
			_o.MiddleCircleEffect = this.MiddleCircleEffect;
			_o.MiddleCircleOverlyingEffect = this.MiddleCircleOverlyingEffect;
			_o.MiddleCircleSpace = this.MiddleCircleSpace;
			_o.MiddleCircleRadius = this.MiddleCircleRadius;
			_o.MovableRadius = this.MovableRadius;
			_o.Resistance = this.Resistance;
			_o.SpeedLimit = this.SpeedLimit;
			_o.SprintSpeedLimit = this.SprintSpeedLimit;
			_o.Points = new List<ICommonSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601FA03 RID: 129539 RVA: 0x00467A40 File Offset: 0x00465C40
		public static Offset<IAirPassageSpline> Pack(FlatBufferBuilder builder, IAirPassageSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirPassageSpline>);
			}
			StringOffset middleLineEffectOffset = (_o.MiddleLineEffect == null) ? default(StringOffset) : builder.CreateString(_o.MiddleLineEffect);
			StringOffset tailCircleEffectOffset = (_o.TailCircleEffect == null) ? default(StringOffset) : builder.CreateString(_o.TailCircleEffect);
			StringOffset middleCircleEffectOffset = (_o.MiddleCircleEffect == null) ? default(StringOffset) : builder.CreateString(_o.MiddleCircleEffect);
			StringOffset middleCircleOverlyingEffectOffset = (_o.MiddleCircleOverlyingEffect == null) ? default(StringOffset) : builder.CreateString(_o.MiddleCircleOverlyingEffect);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ICommonSplinePoint>[] array = new Offset<ICommonSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommonSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IAirPassageSpline.CreatePointsVector(builder, array);
			}
			return IAirPassageSpline.CreateIAirPassageSpline(builder, _o.Type, middleLineEffectOffset, tailCircleEffectOffset, middleCircleEffectOffset, middleCircleOverlyingEffectOffset, _o.MiddleCircleSpace, _o.MiddleCircleRadius, _o.MovableRadius, _o.Resistance, _o.SpeedLimit, _o.SprintSpeedLimit, pointsOffset);
		}

		// Token: 0x0400DC4D RID: 56397
		private Table __p;
	}
}
