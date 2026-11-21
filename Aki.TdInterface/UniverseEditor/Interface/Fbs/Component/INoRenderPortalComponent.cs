using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAC RID: 23468
	public struct INoRenderPortalComponent : IFlatbufferObject
	{
		// Token: 0x1700AB8D RID: 43917
		// (get) Token: 0x06026B07 RID: 158471 RVA: 0x0054BEDA File Offset: 0x0054A0DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B08 RID: 158472 RVA: 0x0054BEE7 File Offset: 0x0054A0E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B09 RID: 158473 RVA: 0x0054BEF0 File Offset: 0x0054A0F0
		public static INoRenderPortalComponent GetRootAsINoRenderPortalComponent(ByteBuffer _bb)
		{
			return INoRenderPortalComponent.GetRootAsINoRenderPortalComponent(_bb, default(INoRenderPortalComponent));
		}

		// Token: 0x06026B0A RID: 158474 RVA: 0x0054BF0C File Offset: 0x0054A10C
		public static INoRenderPortalComponent GetRootAsINoRenderPortalComponent(ByteBuffer _bb, INoRenderPortalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B0B RID: 158475 RVA: 0x0054BF29 File Offset: 0x0054A129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B0C RID: 158476 RVA: 0x0054BF38 File Offset: 0x0054A138
		public INoRenderPortalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB8E RID: 43918
		// (get) Token: 0x06026B0D RID: 158477 RVA: 0x0054BF48 File Offset: 0x0054A148
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB8F RID: 43919
		// (get) Token: 0x06026B0E RID: 158478 RVA: 0x0054BF88 File Offset: 0x0054A188
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

		// Token: 0x1700AB90 RID: 43920
		// (get) Token: 0x06026B0F RID: 158479 RVA: 0x0054BFE8 File Offset: 0x0054A1E8
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

		// Token: 0x06026B10 RID: 158480 RVA: 0x0054C024 File Offset: 0x0054A224
		public static Offset<INoRenderPortalComponent> CreateINoRenderPortalComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IStaticNoRenderPortal> ConfigOffset = default(Offset<IStaticNoRenderPortal>), byte NullMask = 0)
		{
			builder.StartTable(3);
			INoRenderPortalComponent.AddConfig(builder, ConfigOffset);
			INoRenderPortalComponent.AddNullMask(builder, NullMask);
			INoRenderPortalComponent.AddDisabled(builder, Disabled);
			return INoRenderPortalComponent.EndINoRenderPortalComponent(builder);
		}

		// Token: 0x06026B11 RID: 158481 RVA: 0x0054C048 File Offset: 0x0054A248
		public static void StartINoRenderPortalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026B12 RID: 158482 RVA: 0x0054C051 File Offset: 0x0054A251
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026B13 RID: 158483 RVA: 0x0054C05C File Offset: 0x0054A25C
		public static void AddConfig(FlatBufferBuilder builder, Offset<IStaticNoRenderPortal> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06026B14 RID: 158484 RVA: 0x0054C06C File Offset: 0x0054A26C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026B15 RID: 158485 RVA: 0x0054C077 File Offset: 0x0054A277
		public static Offset<INoRenderPortalComponent> EndINoRenderPortalComponent(FlatBufferBuilder builder)
		{
			return new Offset<INoRenderPortalComponent>(builder.EndTable());
		}

		// Token: 0x06026B16 RID: 158486 RVA: 0x0054C084 File Offset: 0x0054A284
		public INoRenderPortalComponentT UnPack()
		{
			INoRenderPortalComponentT noRenderPortalComponentT = new INoRenderPortalComponentT();
			this.UnPackTo(noRenderPortalComponentT);
			return noRenderPortalComponentT;
		}

		// Token: 0x06026B17 RID: 158487 RVA: 0x0054C0A0 File Offset: 0x0054A2A0
		public void UnPackTo(INoRenderPortalComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026B18 RID: 158488 RVA: 0x0054C0F4 File Offset: 0x0054A2F4
		public static Offset<INoRenderPortalComponent> Pack(FlatBufferBuilder builder, INoRenderPortalComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoRenderPortalComponent>);
			}
			Offset<IStaticNoRenderPortal> configOffset = (_o.Config == null) ? default(Offset<IStaticNoRenderPortal>) : IStaticNoRenderPortal.Pack(builder, _o.Config);
			return INoRenderPortalComponent.CreateINoRenderPortalComponent(builder, _o.Disabled, configOffset, _o.NullMask);
		}

		// Token: 0x0400F5F1 RID: 62961
		private Table __p;
	}
}
