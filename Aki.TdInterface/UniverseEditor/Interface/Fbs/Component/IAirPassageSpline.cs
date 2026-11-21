using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539A RID: 21402
	public struct IAirPassageSpline : IFlatbufferObject
	{
		// Token: 0x1700974B RID: 38731
		// (get) Token: 0x0602161D RID: 136733 RVA: 0x0049B32E File Offset: 0x0049952E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602161E RID: 136734 RVA: 0x0049B33B File Offset: 0x0049953B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602161F RID: 136735 RVA: 0x0049B344 File Offset: 0x00499544
		public static IAirPassageSpline GetRootAsIAirPassageSpline(ByteBuffer _bb)
		{
			return IAirPassageSpline.GetRootAsIAirPassageSpline(_bb, default(IAirPassageSpline));
		}

		// Token: 0x06021620 RID: 136736 RVA: 0x0049B360 File Offset: 0x00499560
		public static IAirPassageSpline GetRootAsIAirPassageSpline(ByteBuffer _bb, IAirPassageSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021621 RID: 136737 RVA: 0x0049B37D File Offset: 0x0049957D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021622 RID: 136738 RVA: 0x0049B38C File Offset: 0x0049958C
		public IAirPassageSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700974C RID: 38732
		// (get) Token: 0x06021623 RID: 136739 RVA: 0x0049B39C File Offset: 0x0049959C
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

		// Token: 0x1700974D RID: 38733
		// (get) Token: 0x06021624 RID: 136740 RVA: 0x0049B3D8 File Offset: 0x004995D8
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

		// Token: 0x06021625 RID: 136741 RVA: 0x0049B40F File Offset: 0x0049960F
		public Span<byte> GetMiddleLineEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021626 RID: 136742 RVA: 0x0049B41E File Offset: 0x0049961E
		public byte[] GetMiddleLineEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700974E RID: 38734
		// (get) Token: 0x06021627 RID: 136743 RVA: 0x0049B42C File Offset: 0x0049962C
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

		// Token: 0x06021628 RID: 136744 RVA: 0x0049B463 File Offset: 0x00499663
		public Span<byte> GetTailCircleEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06021629 RID: 136745 RVA: 0x0049B472 File Offset: 0x00499672
		public byte[] GetTailCircleEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700974F RID: 38735
		// (get) Token: 0x0602162A RID: 136746 RVA: 0x0049B480 File Offset: 0x00499680
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

		// Token: 0x0602162B RID: 136747 RVA: 0x0049B4B8 File Offset: 0x004996B8
		public Span<byte> GetMiddleCircleEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602162C RID: 136748 RVA: 0x0049B4C8 File Offset: 0x004996C8
		public byte[] GetMiddleCircleEffectArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009750 RID: 38736
		// (get) Token: 0x0602162D RID: 136749 RVA: 0x0049B4D8 File Offset: 0x004996D8
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

		// Token: 0x0602162E RID: 136750 RVA: 0x0049B510 File Offset: 0x00499710
		public Span<byte> GetMiddleCircleOverlyingEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602162F RID: 136751 RVA: 0x0049B520 File Offset: 0x00499720
		public byte[] GetMiddleCircleOverlyingEffectArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009751 RID: 38737
		// (get) Token: 0x06021630 RID: 136752 RVA: 0x0049B530 File Offset: 0x00499730
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

		// Token: 0x17009752 RID: 38738
		// (get) Token: 0x06021631 RID: 136753 RVA: 0x0049B574 File Offset: 0x00499774
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

		// Token: 0x17009753 RID: 38739
		// (get) Token: 0x06021632 RID: 136754 RVA: 0x0049B5B8 File Offset: 0x004997B8
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

		// Token: 0x17009754 RID: 38740
		// (get) Token: 0x06021633 RID: 136755 RVA: 0x0049B5FC File Offset: 0x004997FC
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

		// Token: 0x17009755 RID: 38741
		// (get) Token: 0x06021634 RID: 136756 RVA: 0x0049B640 File Offset: 0x00499840
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

		// Token: 0x17009756 RID: 38742
		// (get) Token: 0x06021635 RID: 136757 RVA: 0x0049B684 File Offset: 0x00499884
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

		// Token: 0x06021636 RID: 136758 RVA: 0x0049B6C8 File Offset: 0x004998C8
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009757 RID: 38743
		// (get) Token: 0x06021637 RID: 136759 RVA: 0x0049B72C File Offset: 0x0049992C
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

		// Token: 0x06021638 RID: 136760 RVA: 0x0049B758 File Offset: 0x00499958
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

		// Token: 0x06021639 RID: 136761 RVA: 0x0049B7D0 File Offset: 0x004999D0
		public static void StartIAirPassageSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0602163A RID: 136762 RVA: 0x0049B7DA File Offset: 0x004999DA
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602163B RID: 136763 RVA: 0x0049B7E5 File Offset: 0x004999E5
		public static void AddMiddleLineEffect(FlatBufferBuilder builder, StringOffset middleLineEffectOffset)
		{
			builder.AddOffset(1, middleLineEffectOffset.Value, 0);
		}

		// Token: 0x0602163C RID: 136764 RVA: 0x0049B7F5 File Offset: 0x004999F5
		public static void AddTailCircleEffect(FlatBufferBuilder builder, StringOffset tailCircleEffectOffset)
		{
			builder.AddOffset(2, tailCircleEffectOffset.Value, 0);
		}

		// Token: 0x0602163D RID: 136765 RVA: 0x0049B805 File Offset: 0x00499A05
		public static void AddMiddleCircleEffect(FlatBufferBuilder builder, StringOffset middleCircleEffectOffset)
		{
			builder.AddOffset(3, middleCircleEffectOffset.Value, 0);
		}

		// Token: 0x0602163E RID: 136766 RVA: 0x0049B815 File Offset: 0x00499A15
		public static void AddMiddleCircleOverlyingEffect(FlatBufferBuilder builder, StringOffset middleCircleOverlyingEffectOffset)
		{
			builder.AddOffset(4, middleCircleOverlyingEffectOffset.Value, 0);
		}

		// Token: 0x0602163F RID: 136767 RVA: 0x0049B825 File Offset: 0x00499A25
		public static void AddMiddleCircleSpace(FlatBufferBuilder builder, float middleCircleSpace)
		{
			builder.AddFloat(5, middleCircleSpace, 0.0);
		}

		// Token: 0x06021640 RID: 136768 RVA: 0x0049B838 File Offset: 0x00499A38
		public static void AddMiddleCircleRadius(FlatBufferBuilder builder, float middleCircleRadius)
		{
			builder.AddFloat(6, middleCircleRadius, 0.0);
		}

		// Token: 0x06021641 RID: 136769 RVA: 0x0049B84B File Offset: 0x00499A4B
		public static void AddMovableRadius(FlatBufferBuilder builder, float movableRadius)
		{
			builder.AddFloat(7, movableRadius, 0.0);
		}

		// Token: 0x06021642 RID: 136770 RVA: 0x0049B85E File Offset: 0x00499A5E
		public static void AddResistance(FlatBufferBuilder builder, float resistance)
		{
			builder.AddFloat(8, resistance, 0.0);
		}

		// Token: 0x06021643 RID: 136771 RVA: 0x0049B871 File Offset: 0x00499A71
		public static void AddSpeedLimit(FlatBufferBuilder builder, float speedLimit)
		{
			builder.AddFloat(9, speedLimit, 0.0);
		}

		// Token: 0x06021644 RID: 136772 RVA: 0x0049B885 File Offset: 0x00499A85
		public static void AddSprintSpeedLimit(FlatBufferBuilder builder, float sprintSpeedLimit)
		{
			builder.AddFloat(10, sprintSpeedLimit, 0.0);
		}

		// Token: 0x06021645 RID: 136773 RVA: 0x0049B899 File Offset: 0x00499A99
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(11, pointsOffset.Value, 0);
		}

		// Token: 0x06021646 RID: 136774 RVA: 0x0049B8AC File Offset: 0x00499AAC
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021647 RID: 136775 RVA: 0x0049B8EC File Offset: 0x00499AEC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021648 RID: 136776 RVA: 0x0049B906 File Offset: 0x00499B06
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021649 RID: 136777 RVA: 0x0049B924 File Offset: 0x00499B24
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602164A RID: 136778 RVA: 0x0049B93D File Offset: 0x00499B3D
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602164B RID: 136779 RVA: 0x0049B948 File Offset: 0x00499B48
		public static Offset<IAirPassageSpline> EndIAirPassageSpline(FlatBufferBuilder builder)
		{
			return new Offset<IAirPassageSpline>(builder.EndTable());
		}

		// Token: 0x0602164C RID: 136780 RVA: 0x0049B958 File Offset: 0x00499B58
		public IAirPassageSplineT UnPack()
		{
			IAirPassageSplineT airPassageSplineT = new IAirPassageSplineT();
			this.UnPackTo(airPassageSplineT);
			return airPassageSplineT;
		}

		// Token: 0x0602164D RID: 136781 RVA: 0x0049B974 File Offset: 0x00499B74
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

		// Token: 0x0602164E RID: 136782 RVA: 0x0049BA58 File Offset: 0x00499C58
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

		// Token: 0x0400E7C7 RID: 59335
		private Table __p;
	}
}
