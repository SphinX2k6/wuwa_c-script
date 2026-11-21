using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E4D RID: 24141
	public struct IRenderFlowerBridge : IFlatbufferObject
	{
		// Token: 0x1700B1F9 RID: 45561
		// (get) Token: 0x06028577 RID: 165239 RVA: 0x00583E9C File Offset: 0x0058209C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028578 RID: 165240 RVA: 0x00583EA9 File Offset: 0x005820A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028579 RID: 165241 RVA: 0x00583EB0 File Offset: 0x005820B0
		public static IRenderFlowerBridge GetRootAsIRenderFlowerBridge(ByteBuffer _bb)
		{
			return IRenderFlowerBridge.GetRootAsIRenderFlowerBridge(_bb, default(IRenderFlowerBridge));
		}

		// Token: 0x0602857A RID: 165242 RVA: 0x00583ECC File Offset: 0x005820CC
		public static IRenderFlowerBridge GetRootAsIRenderFlowerBridge(ByteBuffer _bb, IRenderFlowerBridge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602857B RID: 165243 RVA: 0x00583EE9 File Offset: 0x005820E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602857C RID: 165244 RVA: 0x00583EF8 File Offset: 0x005820F8
		public IRenderFlowerBridge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1FA RID: 45562
		// (get) Token: 0x0602857D RID: 165245 RVA: 0x00583F08 File Offset: 0x00582108
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

		// Token: 0x1700B1FB RID: 45563
		// (get) Token: 0x0602857E RID: 165246 RVA: 0x00583F44 File Offset: 0x00582144
		public int Radius
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

		// Token: 0x1700B1FC RID: 45564
		// (get) Token: 0x0602857F RID: 165247 RVA: 0x00583F80 File Offset: 0x00582180
		public TTargetEntity CenterTargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028580 RID: 165248 RVA: 0x00583FBC File Offset: 0x005821BC
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028581 RID: 165249 RVA: 0x00584004 File Offset: 0x00582204
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x06028582 RID: 165250 RVA: 0x00584020 File Offset: 0x00582220
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x06028583 RID: 165251 RVA: 0x0058403C File Offset: 0x0058223C
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x06028584 RID: 165252 RVA: 0x00584058 File Offset: 0x00582258
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x06028585 RID: 165253 RVA: 0x00584074 File Offset: 0x00582274
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700B1FD RID: 45565
		// (get) Token: 0x06028586 RID: 165254 RVA: 0x00584090 File Offset: 0x00582290
		public string AkEvent
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

		// Token: 0x06028587 RID: 165255 RVA: 0x005840C8 File Offset: 0x005822C8
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06028588 RID: 165256 RVA: 0x005840D8 File Offset: 0x005822D8
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06028589 RID: 165257 RVA: 0x005840E7 File Offset: 0x005822E7
		public static Offset<IRenderFlowerBridge> CreateIRenderFlowerBridge(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge, int Radius = 0, TTargetEntity CenterTarget_type = TTargetEntity.NONE, int CenterTargetOffset = 0, StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IRenderFlowerBridge.AddAkEvent(builder, AkEventOffset);
			IRenderFlowerBridge.AddCenterTarget(builder, CenterTargetOffset);
			IRenderFlowerBridge.AddRadius(builder, Radius);
			IRenderFlowerBridge.AddCenterTargetType(builder, CenterTarget_type);
			IRenderFlowerBridge.AddType(builder, Type);
			return IRenderFlowerBridge.EndIRenderFlowerBridge(builder);
		}

		// Token: 0x0602858A RID: 165258 RVA: 0x0058411B File Offset: 0x0058231B
		public static void StartIRenderFlowerBridge(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602858B RID: 165259 RVA: 0x00584124 File Offset: 0x00582324
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602858C RID: 165260 RVA: 0x0058412F File Offset: 0x0058232F
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x0602858D RID: 165261 RVA: 0x0058413A File Offset: 0x0058233A
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(2, (byte)centerTargetType, 0);
		}

		// Token: 0x0602858E RID: 165262 RVA: 0x00584145 File Offset: 0x00582345
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(3, centerTargetOffset, 0);
		}

		// Token: 0x0602858F RID: 165263 RVA: 0x00584150 File Offset: 0x00582350
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(4, akEventOffset.Value, 0);
		}

		// Token: 0x06028590 RID: 165264 RVA: 0x00584160 File Offset: 0x00582360
		public static Offset<IRenderFlowerBridge> EndIRenderFlowerBridge(FlatBufferBuilder builder)
		{
			return new Offset<IRenderFlowerBridge>(builder.EndTable());
		}

		// Token: 0x06028591 RID: 165265 RVA: 0x00584170 File Offset: 0x00582370
		public IRenderFlowerBridgeT UnPack()
		{
			IRenderFlowerBridgeT renderFlowerBridgeT = new IRenderFlowerBridgeT();
			this.UnPackTo(renderFlowerBridgeT);
			return renderFlowerBridgeT;
		}

		// Token: 0x06028592 RID: 165266 RVA: 0x0058418C File Offset: 0x0058238C
		public void UnPackTo(IRenderFlowerBridgeT _o)
		{
			_o.Type = this.Type;
			_o.Radius = this.Radius;
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
			_o.AkEvent = this.AkEvent;
		}

		// Token: 0x06028593 RID: 165267 RVA: 0x00584320 File Offset: 0x00582520
		public static Offset<IRenderFlowerBridge> Pack(FlatBufferBuilder builder, IRenderFlowerBridgeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderFlowerBridge>);
			}
			TTargetEntity centerTarget_type = (_o.CenterTarget == null) ? TTargetEntity.NONE : _o.CenterTarget.Type;
			int centerTargetOffset = (_o.CenterTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CenterTarget);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IRenderFlowerBridge.CreateIRenderFlowerBridge(builder, _o.Type, _o.Radius, centerTarget_type, centerTargetOffset, akEventOffset);
		}

		// Token: 0x0400FA4F RID: 64079
		private Table __p;
	}
}
