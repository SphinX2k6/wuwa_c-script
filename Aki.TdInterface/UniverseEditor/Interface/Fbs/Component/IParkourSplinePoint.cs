using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5A RID: 23642
	public struct IParkourSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700ADB5 RID: 44469
		// (get) Token: 0x06027357 RID: 160599 RVA: 0x0055EE86 File Offset: 0x0055D086
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027358 RID: 160600 RVA: 0x0055EE93 File Offset: 0x0055D093
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027359 RID: 160601 RVA: 0x0055EE9C File Offset: 0x0055D09C
		public static IParkourSplinePoint GetRootAsIParkourSplinePoint(ByteBuffer _bb)
		{
			return IParkourSplinePoint.GetRootAsIParkourSplinePoint(_bb, default(IParkourSplinePoint));
		}

		// Token: 0x0602735A RID: 160602 RVA: 0x0055EEB8 File Offset: 0x0055D0B8
		public static IParkourSplinePoint GetRootAsIParkourSplinePoint(ByteBuffer _bb, IParkourSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602735B RID: 160603 RVA: 0x0055EED5 File Offset: 0x0055D0D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602735C RID: 160604 RVA: 0x0055EEE4 File Offset: 0x0055D0E4
		public IParkourSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADB6 RID: 44470
		// (get) Token: 0x0602735D RID: 160605 RVA: 0x0055EEF4 File Offset: 0x0055D0F4
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

		// Token: 0x1700ADB7 RID: 44471
		// (get) Token: 0x0602735E RID: 160606 RVA: 0x0055EF54 File Offset: 0x0055D154
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

		// Token: 0x1700ADB8 RID: 44472
		// (get) Token: 0x0602735F RID: 160607 RVA: 0x0055EFB4 File Offset: 0x0055D1B4
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

		// Token: 0x1700ADB9 RID: 44473
		// (get) Token: 0x06027360 RID: 160608 RVA: 0x0055F014 File Offset: 0x0055D214
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

		// Token: 0x1700ADBA RID: 44474
		// (get) Token: 0x06027361 RID: 160609 RVA: 0x0055F054 File Offset: 0x0055D254
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

		// Token: 0x1700ADBB RID: 44475
		// (get) Token: 0x06027362 RID: 160610 RVA: 0x0055F0B4 File Offset: 0x0055D2B4
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

		// Token: 0x1700ADBC RID: 44476
		// (get) Token: 0x06027363 RID: 160611 RVA: 0x0055F0F4 File Offset: 0x0055D2F4
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

		// Token: 0x1700ADBD RID: 44477
		// (get) Token: 0x06027364 RID: 160612 RVA: 0x0055F138 File Offset: 0x0055D338
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

		// Token: 0x1700ADBE RID: 44478
		// (get) Token: 0x06027365 RID: 160613 RVA: 0x0055F178 File Offset: 0x0055D378
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

		// Token: 0x1700ADBF RID: 44479
		// (get) Token: 0x06027366 RID: 160614 RVA: 0x0055F1D8 File Offset: 0x0055D3D8
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

		// Token: 0x06027367 RID: 160615 RVA: 0x0055F210 File Offset: 0x0055D410
		public Span<byte> GetPlayerTagBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06027368 RID: 160616 RVA: 0x0055F220 File Offset: 0x0055D420
		public byte[] GetPlayerTagArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700ADC0 RID: 44480
		// (get) Token: 0x06027369 RID: 160617 RVA: 0x0055F230 File Offset: 0x0055D430
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

		// Token: 0x0602736A RID: 160618 RVA: 0x0055F270 File Offset: 0x0055D470
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

		// Token: 0x0602736B RID: 160619 RVA: 0x0055F2E0 File Offset: 0x0055D4E0
		public static void StartIParkourSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602736C RID: 160620 RVA: 0x0055F2EA File Offset: 0x0055D4EA
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0602736D RID: 160621 RVA: 0x0055F2FA File Offset: 0x0055D4FA
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x0602736E RID: 160622 RVA: 0x0055F30A File Offset: 0x0055D50A
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x0602736F RID: 160623 RVA: 0x0055F31A File Offset: 0x0055D51A
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06027370 RID: 160624 RVA: 0x0055F325 File Offset: 0x0055D525
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06027371 RID: 160625 RVA: 0x0055F335 File Offset: 0x0055D535
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(5, radius, 0);
		}

		// Token: 0x06027372 RID: 160626 RVA: 0x0055F340 File Offset: 0x0055D540
		public static void AddModifiedTime(FlatBufferBuilder builder, float modifiedTime)
		{
			builder.AddFloat(6, modifiedTime, 0.0);
		}

		// Token: 0x06027373 RID: 160627 RVA: 0x0055F353 File Offset: 0x0055D553
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(7, buffId, 0L);
		}

		// Token: 0x06027374 RID: 160628 RVA: 0x0055F35F File Offset: 0x0055D55F
		public static void AddPointGroup(FlatBufferBuilder builder, Offset<IPointGroup> pointGroupOffset)
		{
			builder.AddOffset(8, pointGroupOffset.Value, 0);
		}

		// Token: 0x06027375 RID: 160629 RVA: 0x0055F36F File Offset: 0x0055D56F
		public static void AddPlayerTag(FlatBufferBuilder builder, StringOffset playerTagOffset)
		{
			builder.AddOffset(9, playerTagOffset.Value, 0);
		}

		// Token: 0x06027376 RID: 160630 RVA: 0x0055F380 File Offset: 0x0055D580
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06027377 RID: 160631 RVA: 0x0055F38C File Offset: 0x0055D58C
		public static Offset<IParkourSplinePoint> EndIParkourSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IParkourSplinePoint>(builder.EndTable());
		}

		// Token: 0x06027378 RID: 160632 RVA: 0x0055F39C File Offset: 0x0055D59C
		public IParkourSplinePointT UnPack()
		{
			IParkourSplinePointT parkourSplinePointT = new IParkourSplinePointT();
			this.UnPackTo(parkourSplinePointT);
			return parkourSplinePointT;
		}

		// Token: 0x06027379 RID: 160633 RVA: 0x0055F3B8 File Offset: 0x0055D5B8
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

		// Token: 0x0602737A RID: 160634 RVA: 0x0055F4F8 File Offset: 0x0055D6F8
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

		// Token: 0x0400F74F RID: 63311
		private Table __p;
	}
}
