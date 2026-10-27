using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C8 RID: 22984
	public struct IStaticPortal : IFlatbufferObject
	{
		// Token: 0x1700AC9B RID: 44187
		// (get) Token: 0x06026F8E RID: 159630 RVA: 0x0055CE51 File Offset: 0x0055B051
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026F8F RID: 159631 RVA: 0x0055CE5E File Offset: 0x0055B05E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026F90 RID: 159632 RVA: 0x0055CE68 File Offset: 0x0055B068
		public static IStaticPortal GetRootAsIStaticPortal(ByteBuffer _bb)
		{
			return IStaticPortal.GetRootAsIStaticPortal(_bb, default(IStaticPortal));
		}

		// Token: 0x06026F91 RID: 159633 RVA: 0x0055CE84 File Offset: 0x0055B084
		public static IStaticPortal GetRootAsIStaticPortal(ByteBuffer _bb, IStaticPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026F92 RID: 159634 RVA: 0x0055CEA1 File Offset: 0x0055B0A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026F93 RID: 159635 RVA: 0x0055CEB0 File Offset: 0x0055B0B0
		public IStaticPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC9C RID: 44188
		// (get) Token: 0x06026F94 RID: 159636 RVA: 0x0055CEC0 File Offset: 0x0055B0C0
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

		// Token: 0x1700AC9D RID: 44189
		// (get) Token: 0x06026F95 RID: 159637 RVA: 0x0055CEFC File Offset: 0x0055B0FC
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

		// Token: 0x1700AC9E RID: 44190
		// (get) Token: 0x06026F96 RID: 159638 RVA: 0x0055CF38 File Offset: 0x0055B138
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

		// Token: 0x1700AC9F RID: 44191
		// (get) Token: 0x06026F97 RID: 159639 RVA: 0x0055CF98 File Offset: 0x0055B198
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

		// Token: 0x1700ACA0 RID: 44192
		// (get) Token: 0x06026F98 RID: 159640 RVA: 0x0055CFD8 File Offset: 0x0055B1D8
		public bool IsStreamSource
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ACA1 RID: 44193
		// (get) Token: 0x06026F99 RID: 159641 RVA: 0x0055D018 File Offset: 0x0055B218
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

		// Token: 0x06026F9A RID: 159642 RVA: 0x0055D055 File Offset: 0x0055B255
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

		// Token: 0x06026F9B RID: 159643 RVA: 0x0055D091 File Offset: 0x0055B291
		public static void StartIStaticPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026F9C RID: 159644 RVA: 0x0055D09A File Offset: 0x0055B29A
		public static void AddType(FlatBufferBuilder builder, EPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026F9D RID: 159645 RVA: 0x0055D0A5 File Offset: 0x0055B2A5
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x06026F9E RID: 159646 RVA: 0x0055D0B0 File Offset: 0x0055B2B0
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(2, renderConfigOffset.Value, 0);
		}

		// Token: 0x06026F9F RID: 159647 RVA: 0x0055D0C0 File Offset: 0x0055B2C0
		public static void AddLinkPortalEntityId(FlatBufferBuilder builder, int linkPortalEntityId)
		{
			builder.AddInt(3, linkPortalEntityId, 0);
		}

		// Token: 0x06026FA0 RID: 159648 RVA: 0x0055D0CB File Offset: 0x0055B2CB
		public static void AddIsStreamSource(FlatBufferBuilder builder, bool isStreamSource)
		{
			builder.AddBool(4, isStreamSource, false);
		}

		// Token: 0x06026FA1 RID: 159649 RVA: 0x0055D0D6 File Offset: 0x0055B2D6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026FA2 RID: 159650 RVA: 0x0055D0E1 File Offset: 0x0055B2E1
		public static Offset<IStaticPortal> EndIStaticPortal(FlatBufferBuilder builder)
		{
			return new Offset<IStaticPortal>(builder.EndTable());
		}

		// Token: 0x06026FA3 RID: 159651 RVA: 0x0055D0F0 File Offset: 0x0055B2F0
		public IStaticPortalT UnPack()
		{
			IStaticPortalT staticPortalT = new IStaticPortalT();
			this.UnPackTo(staticPortalT);
			return staticPortalT;
		}

		// Token: 0x06026FA4 RID: 159652 RVA: 0x0055D10C File Offset: 0x0055B30C
		public void UnPackTo(IStaticPortalT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
			_o.LinkPortalEntityId = this.LinkPortalEntityId;
			_o.IsStreamSource = this.IsStreamSource;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026FA5 RID: 159653 RVA: 0x0055D184 File Offset: 0x0055B384
		public static Offset<IStaticPortal> Pack(FlatBufferBuilder builder, IStaticPortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStaticPortal>);
			}
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			return IStaticPortal.CreateIStaticPortal(builder, _o.Type, _o.PortalModel, renderConfigOffset, _o.LinkPortalEntityId, _o.IsStreamSource, _o.NullMask);
		}

		// Token: 0x0400EFEF RID: 61423
		private Table __p;
	}
}
