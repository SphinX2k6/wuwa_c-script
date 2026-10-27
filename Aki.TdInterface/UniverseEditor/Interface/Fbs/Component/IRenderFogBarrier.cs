using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005846 RID: 22598
	public struct IRenderFogBarrier : IFlatbufferObject
	{
		// Token: 0x1700A8D7 RID: 43223
		// (get) Token: 0x06026057 RID: 155735 RVA: 0x0053DC24 File Offset: 0x0053BE24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026058 RID: 155736 RVA: 0x0053DC31 File Offset: 0x0053BE31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026059 RID: 155737 RVA: 0x0053DC38 File Offset: 0x0053BE38
		public static IRenderFogBarrier GetRootAsIRenderFogBarrier(ByteBuffer _bb)
		{
			return IRenderFogBarrier.GetRootAsIRenderFogBarrier(_bb, default(IRenderFogBarrier));
		}

		// Token: 0x0602605A RID: 155738 RVA: 0x0053DC54 File Offset: 0x0053BE54
		public static IRenderFogBarrier GetRootAsIRenderFogBarrier(ByteBuffer _bb, IRenderFogBarrier obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602605B RID: 155739 RVA: 0x0053DC71 File Offset: 0x0053BE71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602605C RID: 155740 RVA: 0x0053DC80 File Offset: 0x0053BE80
		public IRenderFogBarrier __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8D8 RID: 43224
		// (get) Token: 0x0602605D RID: 155741 RVA: 0x0053DC90 File Offset: 0x0053BE90
		public ERenderSpecifiedRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return (ERenderSpecifiedRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A8D9 RID: 43225
		// (get) Token: 0x0602605E RID: 155742 RVA: 0x0053DCCC File Offset: 0x0053BECC
		public TTargetEntity CenterTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602605F RID: 155743 RVA: 0x0053DD08 File Offset: 0x0053BF08
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026060 RID: 155744 RVA: 0x0053DD4C File Offset: 0x0053BF4C
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x06026061 RID: 155745 RVA: 0x0053DD68 File Offset: 0x0053BF68
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x06026062 RID: 155746 RVA: 0x0053DD84 File Offset: 0x0053BF84
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x06026063 RID: 155747 RVA: 0x0053DDA0 File Offset: 0x0053BFA0
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x06026064 RID: 155748 RVA: 0x0053DDBC File Offset: 0x0053BFBC
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700A8DA RID: 43226
		// (get) Token: 0x06026065 RID: 155749 RVA: 0x0053DDD8 File Offset: 0x0053BFD8
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A8DB RID: 43227
		// (get) Token: 0x06026066 RID: 155750 RVA: 0x0053DE38 File Offset: 0x0053C038
		public IVectorInfo? Size
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

		// Token: 0x1700A8DC RID: 43228
		// (get) Token: 0x06026067 RID: 155751 RVA: 0x0053DE98 File Offset: 0x0053C098
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026068 RID: 155752 RVA: 0x0053DEF6 File Offset: 0x0053C0F6
		public static Offset<IRenderFogBarrier> CreateIRenderFogBarrier(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge, TTargetEntity CenterTarget_type = TTargetEntity.NONE, int CenterTargetOffset = 0, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(6);
			IRenderFogBarrier.AddRotator(builder, RotatorOffset);
			IRenderFogBarrier.AddSize(builder, SizeOffset);
			IRenderFogBarrier.AddCenter(builder, CenterOffset);
			IRenderFogBarrier.AddCenterTarget(builder, CenterTargetOffset);
			IRenderFogBarrier.AddCenterTargetType(builder, CenterTarget_type);
			IRenderFogBarrier.AddType(builder, Type);
			return IRenderFogBarrier.EndIRenderFogBarrier(builder);
		}

		// Token: 0x06026069 RID: 155753 RVA: 0x0053DF32 File Offset: 0x0053C132
		public static void StartIRenderFogBarrier(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602606A RID: 155754 RVA: 0x0053DF3B File Offset: 0x0053C13B
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602606B RID: 155755 RVA: 0x0053DF46 File Offset: 0x0053C146
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(1, (byte)centerTargetType, 0);
		}

		// Token: 0x0602606C RID: 155756 RVA: 0x0053DF51 File Offset: 0x0053C151
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(2, centerTargetOffset, 0);
		}

		// Token: 0x0602606D RID: 155757 RVA: 0x0053DF5C File Offset: 0x0053C15C
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(3, centerOffset.Value, 0);
		}

		// Token: 0x0602606E RID: 155758 RVA: 0x0053DF6C File Offset: 0x0053C16C
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(4, sizeOffset.Value, 0);
		}

		// Token: 0x0602606F RID: 155759 RVA: 0x0053DF7C File Offset: 0x0053C17C
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(5, rotatorOffset.Value, 0);
		}

		// Token: 0x06026070 RID: 155760 RVA: 0x0053DF8C File Offset: 0x0053C18C
		public static Offset<IRenderFogBarrier> EndIRenderFogBarrier(FlatBufferBuilder builder)
		{
			return new Offset<IRenderFogBarrier>(builder.EndTable());
		}

		// Token: 0x06026071 RID: 155761 RVA: 0x0053DF9C File Offset: 0x0053C19C
		public IRenderFogBarrierT UnPack()
		{
			IRenderFogBarrierT renderFogBarrierT = new IRenderFogBarrierT();
			this.UnPackTo(renderFogBarrierT);
			return renderFogBarrierT;
		}

		// Token: 0x06026072 RID: 155762 RVA: 0x0053DFB8 File Offset: 0x0053C1B8
		public void UnPackTo(IRenderFogBarrierT _o)
		{
			_o.Type = this.Type;
			_o.CenterTarget = new TTargetEntityUnion();
			_o.CenterTarget.Type = this.CenterTargetType;
			switch (this.CenterTargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IPlayerEntity>() != null) ? this.CenterTarget<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ISelfEntity>() != null) ? this.CenterTarget<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITargetEntity>() != null) ? this.CenterTarget<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITriggeredEntity>() != null) ? this.CenterTarget<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IVehicleEntity>() != null) ? this.CenterTarget<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x06026073 RID: 155763 RVA: 0x0053E1C8 File Offset: 0x0053C3C8
		public static Offset<IRenderFogBarrier> Pack(FlatBufferBuilder builder, IRenderFogBarrierT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderFogBarrier>);
			}
			TTargetEntity centerTarget_type = (_o.CenterTarget == null) ? TTargetEntity.NONE : _o.CenterTarget.Type;
			int centerTargetOffset = (_o.CenterTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CenterTarget);
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IRenderFogBarrier.CreateIRenderFogBarrier(builder, _o.Type, centerTarget_type, centerTargetOffset, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400ED65 RID: 60773
		private Table __p;
	}
}
