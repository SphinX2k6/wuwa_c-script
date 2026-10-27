using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583E RID: 22590
	public struct IRenderBookPage : IFlatbufferObject
	{
		// Token: 0x1700A8C0 RID: 43200
		// (get) Token: 0x06025FFB RID: 155643 RVA: 0x0053CF20 File Offset: 0x0053B120
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025FFC RID: 155644 RVA: 0x0053CF2D File Offset: 0x0053B12D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025FFD RID: 155645 RVA: 0x0053CF34 File Offset: 0x0053B134
		public static IRenderBookPage GetRootAsIRenderBookPage(ByteBuffer _bb)
		{
			return IRenderBookPage.GetRootAsIRenderBookPage(_bb, default(IRenderBookPage));
		}

		// Token: 0x06025FFE RID: 155646 RVA: 0x0053CF50 File Offset: 0x0053B150
		public static IRenderBookPage GetRootAsIRenderBookPage(ByteBuffer _bb, IRenderBookPage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025FFF RID: 155647 RVA: 0x0053CF6D File Offset: 0x0053B16D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026000 RID: 155648 RVA: 0x0053CF7C File Offset: 0x0053B17C
		public IRenderBookPage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8C1 RID: 43201
		// (get) Token: 0x06026001 RID: 155649 RVA: 0x0053CF8C File Offset: 0x0053B18C
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

		// Token: 0x1700A8C2 RID: 43202
		// (get) Token: 0x06026002 RID: 155650 RVA: 0x0053CFC8 File Offset: 0x0053B1C8
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

		// Token: 0x1700A8C3 RID: 43203
		// (get) Token: 0x06026003 RID: 155651 RVA: 0x0053D004 File Offset: 0x0053B204
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

		// Token: 0x06026004 RID: 155652 RVA: 0x0053D040 File Offset: 0x0053B240
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026005 RID: 155653 RVA: 0x0053D088 File Offset: 0x0053B288
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x06026006 RID: 155654 RVA: 0x0053D0A4 File Offset: 0x0053B2A4
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x06026007 RID: 155655 RVA: 0x0053D0C0 File Offset: 0x0053B2C0
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x06026008 RID: 155656 RVA: 0x0053D0DC File Offset: 0x0053B2DC
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x06026009 RID: 155657 RVA: 0x0053D0F8 File Offset: 0x0053B2F8
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700A8C4 RID: 43204
		// (get) Token: 0x0602600A RID: 155658 RVA: 0x0053D114 File Offset: 0x0053B314
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

		// Token: 0x0602600B RID: 155659 RVA: 0x0053D14C File Offset: 0x0053B34C
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602600C RID: 155660 RVA: 0x0053D15C File Offset: 0x0053B35C
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602600D RID: 155661 RVA: 0x0053D16B File Offset: 0x0053B36B
		public static Offset<IRenderBookPage> CreateIRenderBookPage(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge, int Radius = 0, TTargetEntity CenterTarget_type = TTargetEntity.NONE, int CenterTargetOffset = 0, StringOffset AkEventOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IRenderBookPage.AddAkEvent(builder, AkEventOffset);
			IRenderBookPage.AddCenterTarget(builder, CenterTargetOffset);
			IRenderBookPage.AddRadius(builder, Radius);
			IRenderBookPage.AddCenterTargetType(builder, CenterTarget_type);
			IRenderBookPage.AddType(builder, Type);
			return IRenderBookPage.EndIRenderBookPage(builder);
		}

		// Token: 0x0602600E RID: 155662 RVA: 0x0053D19F File Offset: 0x0053B39F
		public static void StartIRenderBookPage(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602600F RID: 155663 RVA: 0x0053D1A8 File Offset: 0x0053B3A8
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026010 RID: 155664 RVA: 0x0053D1B3 File Offset: 0x0053B3B3
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06026011 RID: 155665 RVA: 0x0053D1BE File Offset: 0x0053B3BE
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(2, (byte)centerTargetType, 0);
		}

		// Token: 0x06026012 RID: 155666 RVA: 0x0053D1C9 File Offset: 0x0053B3C9
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(3, centerTargetOffset, 0);
		}

		// Token: 0x06026013 RID: 155667 RVA: 0x0053D1D4 File Offset: 0x0053B3D4
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(4, akEventOffset.Value, 0);
		}

		// Token: 0x06026014 RID: 155668 RVA: 0x0053D1E4 File Offset: 0x0053B3E4
		public static Offset<IRenderBookPage> EndIRenderBookPage(FlatBufferBuilder builder)
		{
			return new Offset<IRenderBookPage>(builder.EndTable());
		}

		// Token: 0x06026015 RID: 155669 RVA: 0x0053D1F4 File Offset: 0x0053B3F4
		public IRenderBookPageT UnPack()
		{
			IRenderBookPageT renderBookPageT = new IRenderBookPageT();
			this.UnPackTo(renderBookPageT);
			return renderBookPageT;
		}

		// Token: 0x06026016 RID: 155670 RVA: 0x0053D210 File Offset: 0x0053B410
		public void UnPackTo(IRenderBookPageT _o)
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

		// Token: 0x06026017 RID: 155671 RVA: 0x0053D3A4 File Offset: 0x0053B5A4
		public static Offset<IRenderBookPage> Pack(FlatBufferBuilder builder, IRenderBookPageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderBookPage>);
			}
			TTargetEntity centerTarget_type = (_o.CenterTarget == null) ? TTargetEntity.NONE : _o.CenterTarget.Type;
			int centerTargetOffset = (_o.CenterTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CenterTarget);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IRenderBookPage.CreateIRenderBookPage(builder, _o.Type, _o.Radius, centerTarget_type, centerTargetOffset, akEventOffset);
		}

		// Token: 0x0400ED58 RID: 60760
		private Table __p;
	}
}
