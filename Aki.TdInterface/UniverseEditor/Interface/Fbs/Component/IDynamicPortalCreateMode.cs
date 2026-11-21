using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005655 RID: 22101
	public struct IDynamicPortalCreateMode : IFlatbufferObject
	{
		// Token: 0x17009ECF RID: 40655
		// (get) Token: 0x06023521 RID: 144673 RVA: 0x004DC021 File Offset: 0x004DA221
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023522 RID: 144674 RVA: 0x004DC02E File Offset: 0x004DA22E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023523 RID: 144675 RVA: 0x004DC038 File Offset: 0x004DA238
		public static IDynamicPortalCreateMode GetRootAsIDynamicPortalCreateMode(ByteBuffer _bb)
		{
			return IDynamicPortalCreateMode.GetRootAsIDynamicPortalCreateMode(_bb, default(IDynamicPortalCreateMode));
		}

		// Token: 0x06023524 RID: 144676 RVA: 0x004DC054 File Offset: 0x004DA254
		public static IDynamicPortalCreateMode GetRootAsIDynamicPortalCreateMode(ByteBuffer _bb, IDynamicPortalCreateMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023525 RID: 144677 RVA: 0x004DC071 File Offset: 0x004DA271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023526 RID: 144678 RVA: 0x004DC080 File Offset: 0x004DA280
		public IDynamicPortalCreateMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009ED0 RID: 40656
		// (get) Token: 0x06023527 RID: 144679 RVA: 0x004DC090 File Offset: 0x004DA290
		public EDynamicPortalCreateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicPortalCreateType.Bullet;
				}
				return (EDynamicPortalCreateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009ED1 RID: 40657
		// (get) Token: 0x06023528 RID: 144680 RVA: 0x004DC0CC File Offset: 0x004DA2CC
		public IDynamicPortalConfig? PortalA
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicPortalConfig?(default(IDynamicPortalConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009ED2 RID: 40658
		// (get) Token: 0x06023529 RID: 144681 RVA: 0x004DC12C File Offset: 0x004DA32C
		public IDynamicPortalConfig? PortalB
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicPortalConfig?(default(IDynamicPortalConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009ED3 RID: 40659
		// (get) Token: 0x0602352A RID: 144682 RVA: 0x004DC18C File Offset: 0x004DA38C
		public EPortalModel InitOpenPortal
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EPortalModel.A;
				}
				return (EPortalModel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009ED4 RID: 40660
		// (get) Token: 0x0602352B RID: 144683 RVA: 0x004DC1CC File Offset: 0x004DA3CC
		public IPortalRenderConfig? RenderConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IPortalRenderConfig?(default(IPortalRenderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009ED5 RID: 40661
		// (get) Token: 0x0602352C RID: 144684 RVA: 0x004DC22C File Offset: 0x004DA42C
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

		// Token: 0x0602352D RID: 144685 RVA: 0x004DC269 File Offset: 0x004DA469
		public static Offset<IDynamicPortalCreateMode> CreateIDynamicPortalCreateMode(FlatBufferBuilder builder, EDynamicPortalCreateType Type = EDynamicPortalCreateType.Bullet, Offset<IDynamicPortalConfig> PortalAOffset = default(Offset<IDynamicPortalConfig>), Offset<IDynamicPortalConfig> PortalBOffset = default(Offset<IDynamicPortalConfig>), EPortalModel InitOpenPortal = EPortalModel.A, Offset<IPortalRenderConfig> RenderConfigOffset = default(Offset<IPortalRenderConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IDynamicPortalCreateMode.AddRenderConfig(builder, RenderConfigOffset);
			IDynamicPortalCreateMode.AddPortalB(builder, PortalBOffset);
			IDynamicPortalCreateMode.AddPortalA(builder, PortalAOffset);
			IDynamicPortalCreateMode.AddNullMask(builder, NullMask);
			IDynamicPortalCreateMode.AddInitOpenPortal(builder, InitOpenPortal);
			IDynamicPortalCreateMode.AddType(builder, Type);
			return IDynamicPortalCreateMode.EndIDynamicPortalCreateMode(builder);
		}

		// Token: 0x0602352E RID: 144686 RVA: 0x004DC2A5 File Offset: 0x004DA4A5
		public static void StartIDynamicPortalCreateMode(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602352F RID: 144687 RVA: 0x004DC2AE File Offset: 0x004DA4AE
		public static void AddType(FlatBufferBuilder builder, EDynamicPortalCreateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023530 RID: 144688 RVA: 0x004DC2B9 File Offset: 0x004DA4B9
		public static void AddPortalA(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalAOffset)
		{
			builder.AddOffset(1, portalAOffset.Value, 0);
		}

		// Token: 0x06023531 RID: 144689 RVA: 0x004DC2C9 File Offset: 0x004DA4C9
		public static void AddPortalB(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalBOffset)
		{
			builder.AddOffset(2, portalBOffset.Value, 0);
		}

		// Token: 0x06023532 RID: 144690 RVA: 0x004DC2D9 File Offset: 0x004DA4D9
		public static void AddInitOpenPortal(FlatBufferBuilder builder, EPortalModel initOpenPortal)
		{
			builder.AddByte(3, (byte)initOpenPortal, 0);
		}

		// Token: 0x06023533 RID: 144691 RVA: 0x004DC2E4 File Offset: 0x004DA4E4
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(4, renderConfigOffset.Value, 0);
		}

		// Token: 0x06023534 RID: 144692 RVA: 0x004DC2F4 File Offset: 0x004DA4F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023535 RID: 144693 RVA: 0x004DC2FF File Offset: 0x004DA4FF
		public static Offset<IDynamicPortalCreateMode> EndIDynamicPortalCreateMode(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalCreateMode>(builder.EndTable());
		}

		// Token: 0x06023536 RID: 144694 RVA: 0x004DC30C File Offset: 0x004DA50C
		public IDynamicPortalCreateModeT UnPack()
		{
			IDynamicPortalCreateModeT dynamicPortalCreateModeT = new IDynamicPortalCreateModeT();
			this.UnPackTo(dynamicPortalCreateModeT);
			return dynamicPortalCreateModeT;
		}

		// Token: 0x06023537 RID: 144695 RVA: 0x004DC328 File Offset: 0x004DA528
		public void UnPackTo(IDynamicPortalCreateModeT _o)
		{
			_o.Type = this.Type;
			_o.PortalA = ((this.PortalA != null) ? this.PortalA.Value.UnPack() : null);
			_o.PortalB = ((this.PortalB != null) ? this.PortalB.Value.UnPack() : null);
			_o.InitOpenPortal = this.InitOpenPortal;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023538 RID: 144696 RVA: 0x004DC3E8 File Offset: 0x004DA5E8
		public static Offset<IDynamicPortalCreateMode> Pack(FlatBufferBuilder builder, IDynamicPortalCreateModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortalCreateMode>);
			}
			Offset<IDynamicPortalConfig> portalAOffset = (_o.PortalA == null) ? default(Offset<IDynamicPortalConfig>) : IDynamicPortalConfig.Pack(builder, _o.PortalA);
			Offset<IDynamicPortalConfig> portalBOffset = (_o.PortalB == null) ? default(Offset<IDynamicPortalConfig>) : IDynamicPortalConfig.Pack(builder, _o.PortalB);
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			return IDynamicPortalCreateMode.CreateIDynamicPortalCreateMode(builder, _o.Type, portalAOffset, portalBOffset, _o.InitOpenPortal, renderConfigOffset, _o.NullMask);
		}

		// Token: 0x0400ED47 RID: 60743
		private Table __p;
	}
}
