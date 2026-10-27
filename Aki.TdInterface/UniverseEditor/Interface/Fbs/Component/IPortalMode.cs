using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576C RID: 22380
	public struct IPortalMode : IFlatbufferObject
	{
		// Token: 0x1700A6EC RID: 42732
		// (get) Token: 0x06025819 RID: 153625 RVA: 0x0052C950 File Offset: 0x0052AB50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602581A RID: 153626 RVA: 0x0052C95D File Offset: 0x0052AB5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602581B RID: 153627 RVA: 0x0052C964 File Offset: 0x0052AB64
		public static IPortalMode GetRootAsIPortalMode(ByteBuffer _bb)
		{
			return IPortalMode.GetRootAsIPortalMode(_bb, default(IPortalMode));
		}

		// Token: 0x0602581C RID: 153628 RVA: 0x0052C980 File Offset: 0x0052AB80
		public static IPortalMode GetRootAsIPortalMode(ByteBuffer _bb, IPortalMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602581D RID: 153629 RVA: 0x0052C99D File Offset: 0x0052AB9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602581E RID: 153630 RVA: 0x0052C9AC File Offset: 0x0052ABAC
		public IPortalMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6ED RID: 42733
		// (get) Token: 0x0602581F RID: 153631 RVA: 0x0052C9BC File Offset: 0x0052ABBC
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

		// Token: 0x1700A6EE RID: 42734
		// (get) Token: 0x06025820 RID: 153632 RVA: 0x0052C9F8 File Offset: 0x0052ABF8
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

		// Token: 0x1700A6EF RID: 42735
		// (get) Token: 0x06025821 RID: 153633 RVA: 0x0052CA34 File Offset: 0x0052AC34
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

		// Token: 0x06025822 RID: 153634 RVA: 0x0052CA91 File Offset: 0x0052AC91
		public static Offset<IPortalMode> CreateIPortalMode(FlatBufferBuilder builder, EPortalType Type = EPortalType.Static, EPortalModel PortalModel = EPortalModel.A, Offset<IPortalRenderConfig> RenderConfigOffset = default(Offset<IPortalRenderConfig>))
		{
			builder.StartTable(3);
			IPortalMode.AddRenderConfig(builder, RenderConfigOffset);
			IPortalMode.AddPortalModel(builder, PortalModel);
			IPortalMode.AddType(builder, Type);
			return IPortalMode.EndIPortalMode(builder);
		}

		// Token: 0x06025823 RID: 153635 RVA: 0x0052CAB5 File Offset: 0x0052ACB5
		public static void StartIPortalMode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025824 RID: 153636 RVA: 0x0052CABE File Offset: 0x0052ACBE
		public static void AddType(FlatBufferBuilder builder, EPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025825 RID: 153637 RVA: 0x0052CAC9 File Offset: 0x0052ACC9
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x06025826 RID: 153638 RVA: 0x0052CAD4 File Offset: 0x0052ACD4
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(2, renderConfigOffset.Value, 0);
		}

		// Token: 0x06025827 RID: 153639 RVA: 0x0052CAE4 File Offset: 0x0052ACE4
		public static Offset<IPortalMode> EndIPortalMode(FlatBufferBuilder builder)
		{
			return new Offset<IPortalMode>(builder.EndTable());
		}

		// Token: 0x06025828 RID: 153640 RVA: 0x0052CAF4 File Offset: 0x0052ACF4
		public IPortalModeT UnPack()
		{
			IPortalModeT portalModeT = new IPortalModeT();
			this.UnPackTo(portalModeT);
			return portalModeT;
		}

		// Token: 0x06025829 RID: 153641 RVA: 0x0052CB10 File Offset: 0x0052AD10
		public void UnPackTo(IPortalModeT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
		}

		// Token: 0x0602582A RID: 153642 RVA: 0x0052CB64 File Offset: 0x0052AD64
		public static Offset<IPortalMode> Pack(FlatBufferBuilder builder, IPortalModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPortalMode>);
			}
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			return IPortalMode.CreateIPortalMode(builder, _o.Type, _o.PortalModel, renderConfigOffset);
		}

		// Token: 0x0400EC10 RID: 60432
		private Table __p;
	}
}
