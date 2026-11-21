using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005424 RID: 21540
	public struct IBaseSplinePointType : IFlatbufferObject
	{
		// Token: 0x170098D6 RID: 39126
		// (get) Token: 0x06021BF0 RID: 138224 RVA: 0x004A7064 File Offset: 0x004A5264
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021BF1 RID: 138225 RVA: 0x004A7071 File Offset: 0x004A5271
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021BF2 RID: 138226 RVA: 0x004A7078 File Offset: 0x004A5278
		public static IBaseSplinePointType GetRootAsIBaseSplinePointType(ByteBuffer _bb)
		{
			return IBaseSplinePointType.GetRootAsIBaseSplinePointType(_bb, default(IBaseSplinePointType));
		}

		// Token: 0x06021BF3 RID: 138227 RVA: 0x004A7094 File Offset: 0x004A5294
		public static IBaseSplinePointType GetRootAsIBaseSplinePointType(ByteBuffer _bb, IBaseSplinePointType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021BF4 RID: 138228 RVA: 0x004A70B1 File Offset: 0x004A52B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021BF5 RID: 138229 RVA: 0x004A70C0 File Offset: 0x004A52C0
		public IBaseSplinePointType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098D7 RID: 39127
		// (get) Token: 0x06021BF6 RID: 138230 RVA: 0x004A70D0 File Offset: 0x004A52D0
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

		// Token: 0x170098D8 RID: 39128
		// (get) Token: 0x06021BF7 RID: 138231 RVA: 0x004A7130 File Offset: 0x004A5330
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

		// Token: 0x170098D9 RID: 39129
		// (get) Token: 0x06021BF8 RID: 138232 RVA: 0x004A7190 File Offset: 0x004A5390
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

		// Token: 0x170098DA RID: 39130
		// (get) Token: 0x06021BF9 RID: 138233 RVA: 0x004A71F0 File Offset: 0x004A53F0
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

		// Token: 0x170098DB RID: 39131
		// (get) Token: 0x06021BFA RID: 138234 RVA: 0x004A7230 File Offset: 0x004A5430
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

		// Token: 0x06021BFB RID: 138235 RVA: 0x004A728E File Offset: 0x004A548E
		public static Offset<IBaseSplinePointType> CreateIBaseSplinePointType(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(5);
			IBaseSplinePointType.AddRotation(builder, RotationOffset);
			IBaseSplinePointType.AddLeaveTangent(builder, LeaveTangentOffset);
			IBaseSplinePointType.AddArriveTangent(builder, ArriveTangentOffset);
			IBaseSplinePointType.AddPosition(builder, PositionOffset);
			IBaseSplinePointType.AddLineType(builder, LineType);
			return IBaseSplinePointType.EndIBaseSplinePointType(builder);
		}

		// Token: 0x06021BFC RID: 138236 RVA: 0x004A72C2 File Offset: 0x004A54C2
		public static void StartIBaseSplinePointType(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021BFD RID: 138237 RVA: 0x004A72CB File Offset: 0x004A54CB
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06021BFE RID: 138238 RVA: 0x004A72DB File Offset: 0x004A54DB
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06021BFF RID: 138239 RVA: 0x004A72EB File Offset: 0x004A54EB
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06021C00 RID: 138240 RVA: 0x004A72FB File Offset: 0x004A54FB
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06021C01 RID: 138241 RVA: 0x004A7306 File Offset: 0x004A5506
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06021C02 RID: 138242 RVA: 0x004A7316 File Offset: 0x004A5516
		public static Offset<IBaseSplinePointType> EndIBaseSplinePointType(FlatBufferBuilder builder)
		{
			return new Offset<IBaseSplinePointType>(builder.EndTable());
		}

		// Token: 0x06021C03 RID: 138243 RVA: 0x004A7324 File Offset: 0x004A5524
		public IBaseSplinePointTypeT UnPack()
		{
			IBaseSplinePointTypeT baseSplinePointTypeT = new IBaseSplinePointTypeT();
			this.UnPackTo(baseSplinePointTypeT);
			return baseSplinePointTypeT;
		}

		// Token: 0x06021C04 RID: 138244 RVA: 0x004A7340 File Offset: 0x004A5540
		public void UnPackTo(IBaseSplinePointTypeT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
		}

		// Token: 0x06021C05 RID: 138245 RVA: 0x004A7418 File Offset: 0x004A5618
		public static Offset<IBaseSplinePointType> Pack(FlatBufferBuilder builder, IBaseSplinePointTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseSplinePointType>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return IBaseSplinePointType.CreateIBaseSplinePointType(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset);
		}

		// Token: 0x0400E8CD RID: 59597
		private Table __p;
	}
}
