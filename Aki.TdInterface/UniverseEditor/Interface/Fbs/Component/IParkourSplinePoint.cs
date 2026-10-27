using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B6 RID: 22198
	public struct IParkourSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700A521 RID: 42273
		// (get) Token: 0x06025102 RID: 151810 RVA: 0x0051DF3E File Offset: 0x0051C13E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025103 RID: 151811 RVA: 0x0051DF4B File Offset: 0x0051C14B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025104 RID: 151812 RVA: 0x0051DF54 File Offset: 0x0051C154
		public static IParkourSplinePoint GetRootAsIParkourSplinePoint(ByteBuffer _bb)
		{
			return IParkourSplinePoint.GetRootAsIParkourSplinePoint(_bb, default(IParkourSplinePoint));
		}

		// Token: 0x06025105 RID: 151813 RVA: 0x0051DF70 File Offset: 0x0051C170
		public static IParkourSplinePoint GetRootAsIParkourSplinePoint(ByteBuffer _bb, IParkourSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025106 RID: 151814 RVA: 0x0051DF8D File Offset: 0x0051C18D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025107 RID: 151815 RVA: 0x0051DF9C File Offset: 0x0051C19C
		public IParkourSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A522 RID: 42274
		// (get) Token: 0x06025108 RID: 151816 RVA: 0x0051DFAC File Offset: 0x0051C1AC
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A523 RID: 42275
		// (get) Token: 0x06025109 RID: 151817 RVA: 0x0051E00C File Offset: 0x0051C20C
		public IVectorInfo? ArriveTangent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A524 RID: 42276
		// (get) Token: 0x0602510A RID: 151818 RVA: 0x0051E06C File Offset: 0x0051C26C
		public IVectorInfo? LeaveTangent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A525 RID: 42277
		// (get) Token: 0x0602510B RID: 151819 RVA: 0x0051E0CC File Offset: 0x0051C2CC
		public ESplineLine LineType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ESplineLine.Linear;
				}
				return (ESplineLine)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A526 RID: 42278
		// (get) Token: 0x0602510C RID: 151820 RVA: 0x0051E10C File Offset: 0x0051C30C
		public IVectorInfo? Rotation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A527 RID: 42279
		// (get) Token: 0x0602510D RID: 151821 RVA: 0x0051E16C File Offset: 0x0051C36C
		public int Radius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A528 RID: 42280
		// (get) Token: 0x0602510E RID: 151822 RVA: 0x0051E1AC File Offset: 0x0051C3AC
		public float ModifiedTime
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

		// Token: 0x1700A529 RID: 42281
		// (get) Token: 0x0602510F RID: 151823 RVA: 0x0051E1F0 File Offset: 0x0051C3F0
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A52A RID: 42282
		// (get) Token: 0x06025110 RID: 151824 RVA: 0x0051E230 File Offset: 0x0051C430
		public IPointGroup? PointGroup
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IPointGroup?(default(IPointGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A52B RID: 42283
		// (get) Token: 0x06025111 RID: 151825 RVA: 0x0051E290 File Offset: 0x0051C490
		public string PlayerTag
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025112 RID: 151826 RVA: 0x0051E2C8 File Offset: 0x0051C4C8
		public Span<byte> GetPlayerTagBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06025113 RID: 151827 RVA: 0x0051E2D8 File Offset: 0x0051C4D8
		public byte[] GetPlayerTagArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700A52C RID: 42284
		// (get) Token: 0x06025114 RID: 151828 RVA: 0x0051E2E8 File Offset: 0x0051C4E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025115 RID: 151829 RVA: 0x0051E328 File Offset: 0x0051C528
		public static Offset<IParkourSplinePoint> CreateIParkourSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), int Radius = 0, float ModifiedTime = 0f, long BuffId = 0L, Offset<IPointGroup> PointGroupOffset = default(Offset<IPointGroup>), StringOffset PlayerTagOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			IParkourSplinePoint.AddBuffId(builder, BuffId);
			IParkourSplinePoint.AddPlayerTag(builder, PlayerTagOffset);
			IParkourSplinePoint.AddPointGroup(builder, PointGroupOffset);
			IParkourSplinePoint.AddModifiedTime(builder, ModifiedTime);
			IParkourSplinePoint.AddRadius(builder, Radius);
			IParkourSplinePoint.AddRotation(builder, RotationOffset);
			IParkourSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IParkourSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IParkourSplinePoint.AddPosition(builder, PositionOffset);
			IParkourSplinePoint.AddNullMask(builder, NullMask);
			IParkourSplinePoint.AddLineType(builder, LineType);
			return IParkourSplinePoint.EndIParkourSplinePoint(builder);
		}

		// Token: 0x06025116 RID: 151830 RVA: 0x0051E398 File Offset: 0x0051C598
		public static void StartIParkourSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06025117 RID: 151831 RVA: 0x0051E3A2 File Offset: 0x0051C5A2
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06025118 RID: 151832 RVA: 0x0051E3B2 File Offset: 0x0051C5B2
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06025119 RID: 151833 RVA: 0x0051E3C2 File Offset: 0x0051C5C2
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x0602511A RID: 151834 RVA: 0x0051E3D2 File Offset: 0x0051C5D2
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x0602511B RID: 151835 RVA: 0x0051E3DD File Offset: 0x0051C5DD
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x0602511C RID: 151836 RVA: 0x0051E3ED File Offset: 0x0051C5ED
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(5, radius, 0);
		}

		// Token: 0x0602511D RID: 151837 RVA: 0x0051E3F8 File Offset: 0x0051C5F8
		public static void AddModifiedTime(FlatBufferBuilder builder, float modifiedTime)
		{
			builder.AddFloat(6, modifiedTime, 0.0);
		}

		// Token: 0x0602511E RID: 151838 RVA: 0x0051E40B File Offset: 0x0051C60B
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(7, buffId, 0L);
		}

		// Token: 0x0602511F RID: 151839 RVA: 0x0051E417 File Offset: 0x0051C617
		public static void AddPointGroup(FlatBufferBuilder builder, Offset<IPointGroup> pointGroupOffset)
		{
			builder.AddOffset(8, pointGroupOffset.Value, 0);
		}

		// Token: 0x06025120 RID: 151840 RVA: 0x0051E427 File Offset: 0x0051C627
		public static void AddPlayerTag(FlatBufferBuilder builder, StringOffset playerTagOffset)
		{
			builder.AddOffset(9, playerTagOffset.Value, 0);
		}

		// Token: 0x06025121 RID: 151841 RVA: 0x0051E438 File Offset: 0x0051C638
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06025122 RID: 151842 RVA: 0x0051E444 File Offset: 0x0051C644
		public static Offset<IParkourSplinePoint> EndIParkourSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IParkourSplinePoint>(builder.EndTable());
		}

		// Token: 0x06025123 RID: 151843 RVA: 0x0051E454 File Offset: 0x0051C654
		public IParkourSplinePointT UnPack()
		{
			IParkourSplinePointT parkourSplinePointT = new IParkourSplinePointT();
			this.UnPackTo(parkourSplinePointT);
			return parkourSplinePointT;
		}

		// Token: 0x06025124 RID: 151844 RVA: 0x0051E470 File Offset: 0x0051C670
		public void UnPackTo(IParkourSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.ModifiedTime = this.ModifiedTime;
			_o.BuffId = this.BuffId;
			_o.PointGroup = ((this.PointGroup != null) ? this.PointGroup.Value.UnPack() : null);
			_o.PlayerTag = this.PlayerTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025125 RID: 151845 RVA: 0x0051E5B0 File Offset: 0x0051C7B0
		public static Offset<IParkourSplinePoint> Pack(FlatBufferBuilder builder, IParkourSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParkourSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			Offset<IPointGroup> pointGroupOffset = (_o.PointGroup == null) ? default(Offset<IPointGroup>) : IPointGroup.Pack(builder, _o.PointGroup);
			StringOffset playerTagOffset = (_o.PlayerTag == null) ? default(StringOffset) : builder.CreateString(_o.PlayerTag);
			return IParkourSplinePoint.CreateIParkourSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.Radius, _o.ModifiedTime, _o.BuffId, pointGroupOffset, playerTagOffset, _o.NullMask);
		}

		// Token: 0x0400EAE3 RID: 60131
		private Table __p;
	}
}
