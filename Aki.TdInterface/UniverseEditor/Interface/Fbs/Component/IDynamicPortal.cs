using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E7 RID: 20711
	public struct IDynamicPortal : IFlatbufferObject
	{
		// Token: 0x170096C5 RID: 38597
		// (get) Token: 0x0602156D RID: 136557 RVA: 0x004A135C File Offset: 0x0049F55C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602156E RID: 136558 RVA: 0x004A1369 File Offset: 0x0049F569
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602156F RID: 136559 RVA: 0x004A1370 File Offset: 0x0049F570
		public static IDynamicPortal GetRootAsIDynamicPortal(ByteBuffer _bb)
		{
			return IDynamicPortal.GetRootAsIDynamicPortal(_bb, default(IDynamicPortal));
		}

		// Token: 0x06021570 RID: 136560 RVA: 0x004A138C File Offset: 0x0049F58C
		public static IDynamicPortal GetRootAsIDynamicPortal(ByteBuffer _bb, IDynamicPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021571 RID: 136561 RVA: 0x004A13A9 File Offset: 0x0049F5A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021572 RID: 136562 RVA: 0x004A13B8 File Offset: 0x0049F5B8
		public IDynamicPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096C6 RID: 38598
		// (get) Token: 0x06021573 RID: 136563 RVA: 0x004A13C8 File Offset: 0x0049F5C8
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

		// Token: 0x170096C7 RID: 38599
		// (get) Token: 0x06021574 RID: 136564 RVA: 0x004A1404 File Offset: 0x0049F604
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

		// Token: 0x170096C8 RID: 38600
		// (get) Token: 0x06021575 RID: 136565 RVA: 0x004A1440 File Offset: 0x0049F640
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

		// Token: 0x06021576 RID: 136566 RVA: 0x004A149D File Offset: 0x0049F69D
		public static Offset<IDynamicPortal> CreateIDynamicPortal(FlatBufferBuilder builder, EPortalType Type = EPortalType.Static, EPortalModel PortalModel = EPortalModel.A, Offset<IPortalRenderConfig> RenderConfigOffset = default(Offset<IPortalRenderConfig>))
		{
			builder.StartTable(3);
			IDynamicPortal.AddRenderConfig(builder, RenderConfigOffset);
			IDynamicPortal.AddPortalModel(builder, PortalModel);
			IDynamicPortal.AddType(builder, Type);
			return IDynamicPortal.EndIDynamicPortal(builder);
		}

		// Token: 0x06021577 RID: 136567 RVA: 0x004A14C1 File Offset: 0x0049F6C1
		public static void StartIDynamicPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021578 RID: 136568 RVA: 0x004A14CA File Offset: 0x0049F6CA
		public static void AddType(FlatBufferBuilder builder, EPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021579 RID: 136569 RVA: 0x004A14D5 File Offset: 0x0049F6D5
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x0602157A RID: 136570 RVA: 0x004A14E0 File Offset: 0x0049F6E0
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(2, renderConfigOffset.Value, 0);
		}

		// Token: 0x0602157B RID: 136571 RVA: 0x004A14F0 File Offset: 0x0049F6F0
		public static Offset<IDynamicPortal> EndIDynamicPortal(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortal>(builder.EndTable());
		}

		// Token: 0x0602157C RID: 136572 RVA: 0x004A1500 File Offset: 0x0049F700
		public IDynamicPortalT UnPack()
		{
			IDynamicPortalT dynamicPortalT = new IDynamicPortalT();
			this.UnPackTo(dynamicPortalT);
			return dynamicPortalT;
		}

		// Token: 0x0602157D RID: 136573 RVA: 0x004A151C File Offset: 0x0049F71C
		public void UnPackTo(IDynamicPortalT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
		}

		// Token: 0x0602157E RID: 136574 RVA: 0x004A1570 File Offset: 0x0049F770
		public static Offset<IDynamicPortal> Pack(FlatBufferBuilder builder, IDynamicPortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortal>);
			}
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			return IDynamicPortal.CreateIDynamicPortal(builder, _o.Type, _o.PortalModel, renderConfigOffset);
		}

		// Token: 0x0400E13A RID: 57658
		private Table __p;
	}
}
