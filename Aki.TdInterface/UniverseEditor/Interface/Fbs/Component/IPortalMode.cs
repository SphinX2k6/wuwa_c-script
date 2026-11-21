using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D73 RID: 23923
	public struct IPortalMode : IFlatbufferObject
	{
		// Token: 0x1700B010 RID: 45072
		// (get) Token: 0x06027D39 RID: 163129 RVA: 0x00572ADC File Offset: 0x00570CDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D3A RID: 163130 RVA: 0x00572AE9 File Offset: 0x00570CE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D3B RID: 163131 RVA: 0x00572AF0 File Offset: 0x00570CF0
		public static IPortalMode GetRootAsIPortalMode(ByteBuffer _bb)
		{
			return IPortalMode.GetRootAsIPortalMode(_bb, default(IPortalMode));
		}

		// Token: 0x06027D3C RID: 163132 RVA: 0x00572B0C File Offset: 0x00570D0C
		public static IPortalMode GetRootAsIPortalMode(ByteBuffer _bb, IPortalMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D3D RID: 163133 RVA: 0x00572B29 File Offset: 0x00570D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D3E RID: 163134 RVA: 0x00572B38 File Offset: 0x00570D38
		public IPortalMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B011 RID: 45073
		// (get) Token: 0x06027D3F RID: 163135 RVA: 0x00572B48 File Offset: 0x00570D48
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

		// Token: 0x1700B012 RID: 45074
		// (get) Token: 0x06027D40 RID: 163136 RVA: 0x00572B84 File Offset: 0x00570D84
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

		// Token: 0x1700B013 RID: 45075
		// (get) Token: 0x06027D41 RID: 163137 RVA: 0x00572BC0 File Offset: 0x00570DC0
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

		// Token: 0x06027D42 RID: 163138 RVA: 0x00572C1D File Offset: 0x00570E1D
		public static Offset<IPortalMode> CreateIPortalMode(FlatBufferBuilder builder, EPortalType Type = EPortalType.Static, EPortalModel PortalModel = EPortalModel.A, Offset<IPortalRenderConfig> RenderConfigOffset = default(Offset<IPortalRenderConfig>))
		{
			builder.StartTable(3);
			IPortalMode.AddRenderConfig(builder, RenderConfigOffset);
			IPortalMode.AddPortalModel(builder, PortalModel);
			IPortalMode.AddType(builder, Type);
			return IPortalMode.EndIPortalMode(builder);
		}

		// Token: 0x06027D43 RID: 163139 RVA: 0x00572C41 File Offset: 0x00570E41
		public static void StartIPortalMode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027D44 RID: 163140 RVA: 0x00572C4A File Offset: 0x00570E4A
		public static void AddType(FlatBufferBuilder builder, EPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027D45 RID: 163141 RVA: 0x00572C55 File Offset: 0x00570E55
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x06027D46 RID: 163142 RVA: 0x00572C60 File Offset: 0x00570E60
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(2, renderConfigOffset.Value, 0);
		}

		// Token: 0x06027D47 RID: 163143 RVA: 0x00572C70 File Offset: 0x00570E70
		public static Offset<IPortalMode> EndIPortalMode(FlatBufferBuilder builder)
		{
			return new Offset<IPortalMode>(builder.EndTable());
		}

		// Token: 0x06027D48 RID: 163144 RVA: 0x00572C80 File Offset: 0x00570E80
		public IPortalModeT UnPack()
		{
			IPortalModeT portalModeT = new IPortalModeT();
			this.UnPackTo(portalModeT);
			return portalModeT;
		}

		// Token: 0x06027D49 RID: 163145 RVA: 0x00572C9C File Offset: 0x00570E9C
		public void UnPackTo(IPortalModeT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
		}

		// Token: 0x06027D4A RID: 163146 RVA: 0x00572CF0 File Offset: 0x00570EF0
		public static Offset<IPortalMode> Pack(FlatBufferBuilder builder, IPortalModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPortalMode>);
			}
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			return IPortalMode.CreateIPortalMode(builder, _o.Type, _o.PortalModel, renderConfigOffset);
		}

		// Token: 0x0400F8FB RID: 63739
		private Table __p;
	}
}
