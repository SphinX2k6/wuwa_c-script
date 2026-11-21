using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E50 RID: 24144
	public struct IRenderFogBarrier : IFlatbufferObject
	{
		// Token: 0x1700B202 RID: 45570
		// (get) Token: 0x0602859E RID: 165278 RVA: 0x00584488 File Offset: 0x00582688
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602859F RID: 165279 RVA: 0x00584495 File Offset: 0x00582695
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060285A0 RID: 165280 RVA: 0x0058449C File Offset: 0x0058269C
		public static IRenderFogBarrier GetRootAsIRenderFogBarrier(ByteBuffer _bb)
		{
			return IRenderFogBarrier.GetRootAsIRenderFogBarrier(_bb, default(IRenderFogBarrier));
		}

		// Token: 0x060285A1 RID: 165281 RVA: 0x005844B8 File Offset: 0x005826B8
		public static IRenderFogBarrier GetRootAsIRenderFogBarrier(ByteBuffer _bb, IRenderFogBarrier obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060285A2 RID: 165282 RVA: 0x005844D5 File Offset: 0x005826D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060285A3 RID: 165283 RVA: 0x005844E4 File Offset: 0x005826E4
		public IRenderFogBarrier __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B203 RID: 45571
		// (get) Token: 0x060285A4 RID: 165284 RVA: 0x005844F4 File Offset: 0x005826F4
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

		// Token: 0x1700B204 RID: 45572
		// (get) Token: 0x060285A5 RID: 165285 RVA: 0x00584530 File Offset: 0x00582730
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

		// Token: 0x060285A6 RID: 165286 RVA: 0x0058456C File Offset: 0x0058276C
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060285A7 RID: 165287 RVA: 0x005845B0 File Offset: 0x005827B0
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x060285A8 RID: 165288 RVA: 0x005845CC File Offset: 0x005827CC
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x060285A9 RID: 165289 RVA: 0x005845E8 File Offset: 0x005827E8
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x060285AA RID: 165290 RVA: 0x00584604 File Offset: 0x00582804
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x060285AB RID: 165291 RVA: 0x00584620 File Offset: 0x00582820
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700B205 RID: 45573
		// (get) Token: 0x060285AC RID: 165292 RVA: 0x0058463C File Offset: 0x0058283C
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

		// Token: 0x1700B206 RID: 45574
		// (get) Token: 0x060285AD RID: 165293 RVA: 0x0058469C File Offset: 0x0058289C
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

		// Token: 0x1700B207 RID: 45575
		// (get) Token: 0x060285AE RID: 165294 RVA: 0x005846FC File Offset: 0x005828FC
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

		// Token: 0x060285AF RID: 165295 RVA: 0x0058475A File Offset: 0x0058295A
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

		// Token: 0x060285B0 RID: 165296 RVA: 0x00584796 File Offset: 0x00582996
		public static void StartIRenderFogBarrier(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060285B1 RID: 165297 RVA: 0x0058479F File Offset: 0x0058299F
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060285B2 RID: 165298 RVA: 0x005847AA File Offset: 0x005829AA
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(1, (byte)centerTargetType, 0);
		}

		// Token: 0x060285B3 RID: 165299 RVA: 0x005847B5 File Offset: 0x005829B5
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(2, centerTargetOffset, 0);
		}

		// Token: 0x060285B4 RID: 165300 RVA: 0x005847C0 File Offset: 0x005829C0
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(3, centerOffset.Value, 0);
		}

		// Token: 0x060285B5 RID: 165301 RVA: 0x005847D0 File Offset: 0x005829D0
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(4, sizeOffset.Value, 0);
		}

		// Token: 0x060285B6 RID: 165302 RVA: 0x005847E0 File Offset: 0x005829E0
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(5, rotatorOffset.Value, 0);
		}

		// Token: 0x060285B7 RID: 165303 RVA: 0x005847F0 File Offset: 0x005829F0
		public static Offset<IRenderFogBarrier> EndIRenderFogBarrier(FlatBufferBuilder builder)
		{
			return new Offset<IRenderFogBarrier>(builder.EndTable());
		}

		// Token: 0x060285B8 RID: 165304 RVA: 0x00584800 File Offset: 0x00582A00
		public IRenderFogBarrierT UnPack()
		{
			IRenderFogBarrierT renderFogBarrierT = new IRenderFogBarrierT();
			this.UnPackTo(renderFogBarrierT);
			return renderFogBarrierT;
		}

		// Token: 0x060285B9 RID: 165305 RVA: 0x0058481C File Offset: 0x00582A1C
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

		// Token: 0x060285BA RID: 165306 RVA: 0x00584A2C File Offset: 0x00582C2C
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

		// Token: 0x0400FA54 RID: 64084
		private Table __p;
	}
}
