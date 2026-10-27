using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF2 RID: 20210
	public struct IBaseSplinePointType : IFlatbufferObject
	{
		// Token: 0x17009154 RID: 37204
		// (get) Token: 0x0601FE80 RID: 130688 RVA: 0x00470CD0 File Offset: 0x0046EED0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE81 RID: 130689 RVA: 0x00470CDD File Offset: 0x0046EEDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE82 RID: 130690 RVA: 0x00470CE4 File Offset: 0x0046EEE4
		public static IBaseSplinePointType GetRootAsIBaseSplinePointType(ByteBuffer _bb)
		{
			return IBaseSplinePointType.GetRootAsIBaseSplinePointType(_bb, default(IBaseSplinePointType));
		}

		// Token: 0x0601FE83 RID: 130691 RVA: 0x00470D00 File Offset: 0x0046EF00
		public static IBaseSplinePointType GetRootAsIBaseSplinePointType(ByteBuffer _bb, IBaseSplinePointType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE84 RID: 130692 RVA: 0x00470D1D File Offset: 0x0046EF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE85 RID: 130693 RVA: 0x00470D2C File Offset: 0x0046EF2C
		public IBaseSplinePointType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009155 RID: 37205
		// (get) Token: 0x0601FE86 RID: 130694 RVA: 0x00470D3C File Offset: 0x0046EF3C
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

		// Token: 0x17009156 RID: 37206
		// (get) Token: 0x0601FE87 RID: 130695 RVA: 0x00470D9C File Offset: 0x0046EF9C
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

		// Token: 0x17009157 RID: 37207
		// (get) Token: 0x0601FE88 RID: 130696 RVA: 0x00470DFC File Offset: 0x0046EFFC
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

		// Token: 0x17009158 RID: 37208
		// (get) Token: 0x0601FE89 RID: 130697 RVA: 0x00470E5C File Offset: 0x0046F05C
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

		// Token: 0x17009159 RID: 37209
		// (get) Token: 0x0601FE8A RID: 130698 RVA: 0x00470E9C File Offset: 0x0046F09C
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

		// Token: 0x0601FE8B RID: 130699 RVA: 0x00470EFA File Offset: 0x0046F0FA
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

		// Token: 0x0601FE8C RID: 130700 RVA: 0x00470F2E File Offset: 0x0046F12E
		public static void StartIBaseSplinePointType(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601FE8D RID: 130701 RVA: 0x00470F37 File Offset: 0x0046F137
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0601FE8E RID: 130702 RVA: 0x00470F47 File Offset: 0x0046F147
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x0601FE8F RID: 130703 RVA: 0x00470F57 File Offset: 0x0046F157
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x0601FE90 RID: 130704 RVA: 0x00470F67 File Offset: 0x0046F167
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x0601FE91 RID: 130705 RVA: 0x00470F72 File Offset: 0x0046F172
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x0601FE92 RID: 130706 RVA: 0x00470F82 File Offset: 0x0046F182
		public static Offset<IBaseSplinePointType> EndIBaseSplinePointType(FlatBufferBuilder builder)
		{
			return new Offset<IBaseSplinePointType>(builder.EndTable());
		}

		// Token: 0x0601FE93 RID: 130707 RVA: 0x00470F90 File Offset: 0x0046F190
		public IBaseSplinePointTypeT UnPack()
		{
			IBaseSplinePointTypeT baseSplinePointTypeT = new IBaseSplinePointTypeT();
			this.UnPackTo(baseSplinePointTypeT);
			return baseSplinePointTypeT;
		}

		// Token: 0x0601FE94 RID: 130708 RVA: 0x00470FAC File Offset: 0x0046F1AC
		public void UnPackTo(IBaseSplinePointTypeT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
		}

		// Token: 0x0601FE95 RID: 130709 RVA: 0x00471084 File Offset: 0x0046F284
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

		// Token: 0x0400DD1E RID: 56606
		private Table __p;
	}
}
