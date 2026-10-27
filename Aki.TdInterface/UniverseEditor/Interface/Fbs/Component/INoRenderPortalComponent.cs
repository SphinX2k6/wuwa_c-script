using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560E RID: 22030
	public struct INoRenderPortalComponent : IFlatbufferObject
	{
		// Token: 0x1700A305 RID: 41733
		// (get) Token: 0x060248F7 RID: 149751 RVA: 0x0050B8C2 File Offset: 0x00509AC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060248F8 RID: 149752 RVA: 0x0050B8CF File Offset: 0x00509ACF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060248F9 RID: 149753 RVA: 0x0050B8D8 File Offset: 0x00509AD8
		public static INoRenderPortalComponent GetRootAsINoRenderPortalComponent(ByteBuffer _bb)
		{
			return INoRenderPortalComponent.GetRootAsINoRenderPortalComponent(_bb, default(INoRenderPortalComponent));
		}

		// Token: 0x060248FA RID: 149754 RVA: 0x0050B8F4 File Offset: 0x00509AF4
		public static INoRenderPortalComponent GetRootAsINoRenderPortalComponent(ByteBuffer _bb, INoRenderPortalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060248FB RID: 149755 RVA: 0x0050B911 File Offset: 0x00509B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060248FC RID: 149756 RVA: 0x0050B920 File Offset: 0x00509B20
		public INoRenderPortalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A306 RID: 41734
		// (get) Token: 0x060248FD RID: 149757 RVA: 0x0050B930 File Offset: 0x00509B30
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A307 RID: 41735
		// (get) Token: 0x060248FE RID: 149758 RVA: 0x0050B970 File Offset: 0x00509B70
		public IStaticNoRenderPortal? Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IStaticNoRenderPortal?(default(IStaticNoRenderPortal).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A308 RID: 41736
		// (get) Token: 0x060248FF RID: 149759 RVA: 0x0050B9D0 File Offset: 0x00509BD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024900 RID: 149760 RVA: 0x0050BA0C File Offset: 0x00509C0C
		public static Offset<INoRenderPortalComponent> CreateINoRenderPortalComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IStaticNoRenderPortal> ConfigOffset = default(Offset<IStaticNoRenderPortal>), byte NullMask = 0)
		{
			builder.StartTable(3);
			INoRenderPortalComponent.AddConfig(builder, ConfigOffset);
			INoRenderPortalComponent.AddNullMask(builder, NullMask);
			INoRenderPortalComponent.AddDisabled(builder, Disabled);
			return INoRenderPortalComponent.EndINoRenderPortalComponent(builder);
		}

		// Token: 0x06024901 RID: 149761 RVA: 0x0050BA30 File Offset: 0x00509C30
		public static void StartINoRenderPortalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024902 RID: 149762 RVA: 0x0050BA39 File Offset: 0x00509C39
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024903 RID: 149763 RVA: 0x0050BA44 File Offset: 0x00509C44
		public static void AddConfig(FlatBufferBuilder builder, Offset<IStaticNoRenderPortal> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06024904 RID: 149764 RVA: 0x0050BA54 File Offset: 0x00509C54
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024905 RID: 149765 RVA: 0x0050BA5F File Offset: 0x00509C5F
		public static Offset<INoRenderPortalComponent> EndINoRenderPortalComponent(FlatBufferBuilder builder)
		{
			return new Offset<INoRenderPortalComponent>(builder.EndTable());
		}

		// Token: 0x06024906 RID: 149766 RVA: 0x0050BA6C File Offset: 0x00509C6C
		public INoRenderPortalComponentT UnPack()
		{
			INoRenderPortalComponentT noRenderPortalComponentT = new INoRenderPortalComponentT();
			this.UnPackTo(noRenderPortalComponentT);
			return noRenderPortalComponentT;
		}

		// Token: 0x06024907 RID: 149767 RVA: 0x0050BA88 File Offset: 0x00509C88
		public void UnPackTo(INoRenderPortalComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024908 RID: 149768 RVA: 0x0050BADC File Offset: 0x00509CDC
		public static Offset<INoRenderPortalComponent> Pack(FlatBufferBuilder builder, INoRenderPortalComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoRenderPortalComponent>);
			}
			Offset<IStaticNoRenderPortal> configOffset = (_o.Config == null) ? default(Offset<IStaticNoRenderPortal>) : IStaticNoRenderPortal.Pack(builder, _o.Config);
			return INoRenderPortalComponent.CreateINoRenderPortalComponent(builder, _o.Disabled, configOffset, _o.NullMask);
		}

		// Token: 0x0400E98E RID: 59790
		private Table __p;
	}
}
