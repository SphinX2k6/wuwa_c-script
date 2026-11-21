using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564C RID: 22092
	public struct IDynamicPortal : IFlatbufferObject
	{
		// Token: 0x17009EB2 RID: 40626
		// (get) Token: 0x060234C1 RID: 144577 RVA: 0x004DB2E8 File Offset: 0x004D94E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060234C2 RID: 144578 RVA: 0x004DB2F5 File Offset: 0x004D94F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060234C3 RID: 144579 RVA: 0x004DB2FC File Offset: 0x004D94FC
		public static IDynamicPortal GetRootAsIDynamicPortal(ByteBuffer _bb)
		{
			return IDynamicPortal.GetRootAsIDynamicPortal(_bb, default(IDynamicPortal));
		}

		// Token: 0x060234C4 RID: 144580 RVA: 0x004DB318 File Offset: 0x004D9518
		public static IDynamicPortal GetRootAsIDynamicPortal(ByteBuffer _bb, IDynamicPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060234C5 RID: 144581 RVA: 0x004DB335 File Offset: 0x004D9535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060234C6 RID: 144582 RVA: 0x004DB344 File Offset: 0x004D9544
		public IDynamicPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EB3 RID: 40627
		// (get) Token: 0x060234C7 RID: 144583 RVA: 0x004DB354 File Offset: 0x004D9554
		public EPortalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPortalType.Static;
				}
				return (EPortalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009EB4 RID: 40628
		// (get) Token: 0x060234C8 RID: 144584 RVA: 0x004DB390 File Offset: 0x004D9590
		public EPortalModel PortalModel
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPortalModel.A;
				}
				return (EPortalModel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009EB5 RID: 40629
		// (get) Token: 0x060234C9 RID: 144585 RVA: 0x004DB3CC File Offset: 0x004D95CC
		public IPortalRenderConfig? RenderConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPortalRenderConfig?(default(IPortalRenderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060234CA RID: 144586 RVA: 0x004DB429 File Offset: 0x004D9629
		public static Offset<IDynamicPortal> CreateIDynamicPortal(FlatBufferBuilder builder, EPortalType Type = EPortalType.Static, EPortalModel PortalModel = EPortalModel.A, Offset<IPortalRenderConfig> RenderConfigOffset = default(Offset<IPortalRenderConfig>))
		{
			builder.StartTable(3);
			IDynamicPortal.AddRenderConfig(builder, RenderConfigOffset);
			IDynamicPortal.AddPortalModel(builder, PortalModel);
			IDynamicPortal.AddType(builder, Type);
			return IDynamicPortal.EndIDynamicPortal(builder);
		}

		// Token: 0x060234CB RID: 144587 RVA: 0x004DB44D File Offset: 0x004D964D
		public static void StartIDynamicPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060234CC RID: 144588 RVA: 0x004DB456 File Offset: 0x004D9656
		public static void AddType(FlatBufferBuilder builder, EPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060234CD RID: 144589 RVA: 0x004DB461 File Offset: 0x004D9661
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x060234CE RID: 144590 RVA: 0x004DB46C File Offset: 0x004D966C
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(2, renderConfigOffset.Value, 0);
		}

		// Token: 0x060234CF RID: 144591 RVA: 0x004DB47C File Offset: 0x004D967C
		public static Offset<IDynamicPortal> EndIDynamicPortal(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortal>(builder.EndTable());
		}

		// Token: 0x060234D0 RID: 144592 RVA: 0x004DB48C File Offset: 0x004D968C
		public IDynamicPortalT UnPack()
		{
			IDynamicPortalT dynamicPortalT = new IDynamicPortalT();
			this.UnPackTo(dynamicPortalT);
			return dynamicPortalT;
		}

		// Token: 0x060234D1 RID: 144593 RVA: 0x004DB4A8 File Offset: 0x004D96A8
		public void UnPackTo(IDynamicPortalT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
		}

		// Token: 0x060234D2 RID: 144594 RVA: 0x004DB4FC File Offset: 0x004D96FC
		public static Offset<IDynamicPortal> Pack(FlatBufferBuilder builder, IDynamicPortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortal>);
			}
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			return IDynamicPortal.CreateIDynamicPortal(builder, _o.Type, _o.PortalModel, renderConfigOffset);
		}

		// Token: 0x0400ED37 RID: 60727
		private Table __p;
	}
}
