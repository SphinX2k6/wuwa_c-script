using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005843 RID: 22595
	public struct IRenderFlowerBridge : IFlatbufferObject
	{
		// Token: 0x1700A8CE RID: 43214
		// (get) Token: 0x06026030 RID: 155696 RVA: 0x0053D638 File Offset: 0x0053B838
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026031 RID: 155697 RVA: 0x0053D645 File Offset: 0x0053B845
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026032 RID: 155698 RVA: 0x0053D64C File Offset: 0x0053B84C
		public static IRenderFlowerBridge GetRootAsIRenderFlowerBridge(ByteBuffer _bb)
		{
			return IRenderFlowerBridge.GetRootAsIRenderFlowerBridge(_bb, default(IRenderFlowerBridge));
		}

		// Token: 0x06026033 RID: 155699 RVA: 0x0053D668 File Offset: 0x0053B868
		public static IRenderFlowerBridge GetRootAsIRenderFlowerBridge(ByteBuffer _bb, IRenderFlowerBridge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026034 RID: 155700 RVA: 0x0053D685 File Offset: 0x0053B885
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026035 RID: 155701 RVA: 0x0053D694 File Offset: 0x0053B894
		public IRenderFlowerBridge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8CF RID: 43215
		// (get) Token: 0x06026036 RID: 155702 RVA: 0x0053D6A4 File Offset: 0x0053B8A4
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

		// Token: 0x1700A8D0 RID: 43216
		// (get) Token: 0x06026037 RID: 155703 RVA: 0x0053D6E0 File Offset: 0x0053B8E0
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

		// Token: 0x1700A8D1 RID: 43217
		// (get) Token: 0x06026038 RID: 155704 RVA: 0x0053D71C File Offset: 0x0053B91C
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

		// Token: 0x06026039 RID: 155705 RVA: 0x0053D758 File Offset: 0x0053B958
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602603A RID: 155706 RVA: 0x0053D7A0 File Offset: 0x0053B9A0
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0602603B RID: 155707 RVA: 0x0053D7BC File Offset: 0x0053B9BC
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x0602603C RID: 155708 RVA: 0x0053D7D8 File Offset: 0x0053B9D8
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x0602603D RID: 155709 RVA: 0x0053D7F4 File Offset: 0x0053B9F4
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x0602603E RID: 155710 RVA: 0x0053D810 File Offset: 0x0053BA10
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700A8D2 RID: 43218
		// (get) Token: 0x0602603F RID: 155711 RVA: 0x0053D82C File Offset: 0x0053BA2C
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

		// Token: 0x06026040 RID: 155712 RVA: 0x0053D864 File Offset: 0x0053BA64
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06026041 RID: 155713 RVA: 0x0053D874 File Offset: 0x0053BA74
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06026042 RID: 155714 RVA: 0x0053D883 File Offset: 0x0053BA83
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

		// Token: 0x06026043 RID: 155715 RVA: 0x0053D8B7 File Offset: 0x0053BAB7
		public static void StartIRenderFlowerBridge(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026044 RID: 155716 RVA: 0x0053D8C0 File Offset: 0x0053BAC0
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026045 RID: 155717 RVA: 0x0053D8CB File Offset: 0x0053BACB
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06026046 RID: 155718 RVA: 0x0053D8D6 File Offset: 0x0053BAD6
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(2, (byte)centerTargetType, 0);
		}

		// Token: 0x06026047 RID: 155719 RVA: 0x0053D8E1 File Offset: 0x0053BAE1
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(3, centerTargetOffset, 0);
		}

		// Token: 0x06026048 RID: 155720 RVA: 0x0053D8EC File Offset: 0x0053BAEC
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(4, akEventOffset.Value, 0);
		}

		// Token: 0x06026049 RID: 155721 RVA: 0x0053D8FC File Offset: 0x0053BAFC
		public static Offset<IRenderFlowerBridge> EndIRenderFlowerBridge(FlatBufferBuilder builder)
		{
			return new Offset<IRenderFlowerBridge>(builder.EndTable());
		}

		// Token: 0x0602604A RID: 155722 RVA: 0x0053D90C File Offset: 0x0053BB0C
		public IRenderFlowerBridgeT UnPack()
		{
			IRenderFlowerBridgeT renderFlowerBridgeT = new IRenderFlowerBridgeT();
			this.UnPackTo(renderFlowerBridgeT);
			return renderFlowerBridgeT;
		}

		// Token: 0x0602604B RID: 155723 RVA: 0x0053D928 File Offset: 0x0053BB28
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

		// Token: 0x0602604C RID: 155724 RVA: 0x0053DABC File Offset: 0x0053BCBC
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

		// Token: 0x0400ED60 RID: 60768
		private Table __p;
	}
}
