using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD5 RID: 24533
	public struct IStaticPortal : IFlatbufferObject
	{
		// Token: 0x1700B5D3 RID: 46547
		// (get) Token: 0x06029506 RID: 169222 RVA: 0x005A3E17 File Offset: 0x005A2017
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029507 RID: 169223 RVA: 0x005A3E24 File Offset: 0x005A2024
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029508 RID: 169224 RVA: 0x005A3E2C File Offset: 0x005A202C
		public static IStaticPortal GetRootAsIStaticPortal(ByteBuffer _bb)
		{
			return IStaticPortal.GetRootAsIStaticPortal(_bb, default(IStaticPortal));
		}

		// Token: 0x06029509 RID: 169225 RVA: 0x005A3E48 File Offset: 0x005A2048
		public static IStaticPortal GetRootAsIStaticPortal(ByteBuffer _bb, IStaticPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602950A RID: 169226 RVA: 0x005A3E65 File Offset: 0x005A2065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602950B RID: 169227 RVA: 0x005A3E74 File Offset: 0x005A2074
		public IStaticPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5D4 RID: 46548
		// (get) Token: 0x0602950C RID: 169228 RVA: 0x005A3E84 File Offset: 0x005A2084
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

		// Token: 0x1700B5D5 RID: 46549
		// (get) Token: 0x0602950D RID: 169229 RVA: 0x005A3EC0 File Offset: 0x005A20C0
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

		// Token: 0x1700B5D6 RID: 46550
		// (get) Token: 0x0602950E RID: 169230 RVA: 0x005A3EFC File Offset: 0x005A20FC
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

		// Token: 0x1700B5D7 RID: 46551
		// (get) Token: 0x0602950F RID: 169231 RVA: 0x005A3F5C File Offset: 0x005A215C
		public int LinkPortalEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5D8 RID: 46552
		// (get) Token: 0x06029510 RID: 169232 RVA: 0x005A3F9C File Offset: 0x005A219C
		public bool IsStreamSource
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B5D9 RID: 46553
		// (get) Token: 0x06029511 RID: 169233 RVA: 0x005A3FDC File Offset: 0x005A21DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029512 RID: 169234 RVA: 0x005A4019 File Offset: 0x005A2219
		public static Offset<IStaticPortal> CreateIStaticPortal(FlatBufferBuilder builder, EPortalType Type = EPortalType.Static, EPortalModel PortalModel = EPortalModel.A, Offset<IPortalRenderConfig> RenderConfigOffset = default(Offset<IPortalRenderConfig>), int LinkPortalEntityId = 0, bool IsStreamSource = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IStaticPortal.AddLinkPortalEntityId(builder, LinkPortalEntityId);
			IStaticPortal.AddRenderConfig(builder, RenderConfigOffset);
			IStaticPortal.AddNullMask(builder, NullMask);
			IStaticPortal.AddIsStreamSource(builder, IsStreamSource);
			IStaticPortal.AddPortalModel(builder, PortalModel);
			IStaticPortal.AddType(builder, Type);
			return IStaticPortal.EndIStaticPortal(builder);
		}

		// Token: 0x06029513 RID: 169235 RVA: 0x005A4055 File Offset: 0x005A2255
		public static void StartIStaticPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029514 RID: 169236 RVA: 0x005A405E File Offset: 0x005A225E
		public static void AddType(FlatBufferBuilder builder, EPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029515 RID: 169237 RVA: 0x005A4069 File Offset: 0x005A2269
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x06029516 RID: 169238 RVA: 0x005A4074 File Offset: 0x005A2274
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(2, renderConfigOffset.Value, 0);
		}

		// Token: 0x06029517 RID: 169239 RVA: 0x005A4084 File Offset: 0x005A2284
		public static void AddLinkPortalEntityId(FlatBufferBuilder builder, int linkPortalEntityId)
		{
			builder.AddInt(3, linkPortalEntityId, 0);
		}

		// Token: 0x06029518 RID: 169240 RVA: 0x005A408F File Offset: 0x005A228F
		public static void AddIsStreamSource(FlatBufferBuilder builder, bool isStreamSource)
		{
			builder.AddBool(4, isStreamSource, false);
		}

		// Token: 0x06029519 RID: 169241 RVA: 0x005A409A File Offset: 0x005A229A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602951A RID: 169242 RVA: 0x005A40A5 File Offset: 0x005A22A5
		public static Offset<IStaticPortal> EndIStaticPortal(FlatBufferBuilder builder)
		{
			return new Offset<IStaticPortal>(builder.EndTable());
		}

		// Token: 0x0602951B RID: 169243 RVA: 0x005A40B4 File Offset: 0x005A22B4
		public IStaticPortalT UnPack()
		{
			IStaticPortalT staticPortalT = new IStaticPortalT();
			this.UnPackTo(staticPortalT);
			return staticPortalT;
		}

		// Token: 0x0602951C RID: 169244 RVA: 0x005A40D0 File Offset: 0x005A22D0
		public void UnPackTo(IStaticPortalT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
			_o.LinkPortalEntityId = this.LinkPortalEntityId;
			_o.IsStreamSource = this.IsStreamSource;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602951D RID: 169245 RVA: 0x005A4148 File Offset: 0x005A2348
		public static Offset<IStaticPortal> Pack(FlatBufferBuilder builder, IStaticPortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStaticPortal>);
			}
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			return IStaticPortal.CreateIStaticPortal(builder, _o.Type, _o.PortalModel, renderConfigOffset, _o.LinkPortalEntityId, _o.IsStreamSource, _o.NullMask);
		}

		// Token: 0x0400FCE6 RID: 64742
		private Table __p;
	}
}
