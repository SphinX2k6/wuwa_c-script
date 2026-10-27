using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F0 RID: 20720
	public struct IDynamicPortalCreateMode : IFlatbufferObject
	{
		// Token: 0x170096E2 RID: 38626
		// (get) Token: 0x060215CD RID: 136653 RVA: 0x004A2095 File Offset: 0x004A0295
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060215CE RID: 136654 RVA: 0x004A20A2 File Offset: 0x004A02A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060215CF RID: 136655 RVA: 0x004A20AC File Offset: 0x004A02AC
		public static IDynamicPortalCreateMode GetRootAsIDynamicPortalCreateMode(ByteBuffer _bb)
		{
			return IDynamicPortalCreateMode.GetRootAsIDynamicPortalCreateMode(_bb, default(IDynamicPortalCreateMode));
		}

		// Token: 0x060215D0 RID: 136656 RVA: 0x004A20C8 File Offset: 0x004A02C8
		public static IDynamicPortalCreateMode GetRootAsIDynamicPortalCreateMode(ByteBuffer _bb, IDynamicPortalCreateMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060215D1 RID: 136657 RVA: 0x004A20E5 File Offset: 0x004A02E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060215D2 RID: 136658 RVA: 0x004A20F4 File Offset: 0x004A02F4
		public IDynamicPortalCreateMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096E3 RID: 38627
		// (get) Token: 0x060215D3 RID: 136659 RVA: 0x004A2104 File Offset: 0x004A0304
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

		// Token: 0x170096E4 RID: 38628
		// (get) Token: 0x060215D4 RID: 136660 RVA: 0x004A2140 File Offset: 0x004A0340
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

		// Token: 0x170096E5 RID: 38629
		// (get) Token: 0x060215D5 RID: 136661 RVA: 0x004A21A0 File Offset: 0x004A03A0
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

		// Token: 0x170096E6 RID: 38630
		// (get) Token: 0x060215D6 RID: 136662 RVA: 0x004A2200 File Offset: 0x004A0400
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

		// Token: 0x170096E7 RID: 38631
		// (get) Token: 0x060215D7 RID: 136663 RVA: 0x004A2240 File Offset: 0x004A0440
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

		// Token: 0x170096E8 RID: 38632
		// (get) Token: 0x060215D8 RID: 136664 RVA: 0x004A22A0 File Offset: 0x004A04A0
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

		// Token: 0x060215D9 RID: 136665 RVA: 0x004A22DD File Offset: 0x004A04DD
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

		// Token: 0x060215DA RID: 136666 RVA: 0x004A2319 File Offset: 0x004A0519
		public static void StartIDynamicPortalCreateMode(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060215DB RID: 136667 RVA: 0x004A2322 File Offset: 0x004A0522
		public static void AddType(FlatBufferBuilder builder, EDynamicPortalCreateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060215DC RID: 136668 RVA: 0x004A232D File Offset: 0x004A052D
		public static void AddPortalA(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalAOffset)
		{
			builder.AddOffset(1, portalAOffset.Value, 0);
		}

		// Token: 0x060215DD RID: 136669 RVA: 0x004A233D File Offset: 0x004A053D
		public static void AddPortalB(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalBOffset)
		{
			builder.AddOffset(2, portalBOffset.Value, 0);
		}

		// Token: 0x060215DE RID: 136670 RVA: 0x004A234D File Offset: 0x004A054D
		public static void AddInitOpenPortal(FlatBufferBuilder builder, EPortalModel initOpenPortal)
		{
			builder.AddByte(3, (byte)initOpenPortal, 0);
		}

		// Token: 0x060215DF RID: 136671 RVA: 0x004A2358 File Offset: 0x004A0558
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(4, renderConfigOffset.Value, 0);
		}

		// Token: 0x060215E0 RID: 136672 RVA: 0x004A2368 File Offset: 0x004A0568
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060215E1 RID: 136673 RVA: 0x004A2373 File Offset: 0x004A0573
		public static Offset<IDynamicPortalCreateMode> EndIDynamicPortalCreateMode(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalCreateMode>(builder.EndTable());
		}

		// Token: 0x060215E2 RID: 136674 RVA: 0x004A2380 File Offset: 0x004A0580
		public IDynamicPortalCreateModeT UnPack()
		{
			IDynamicPortalCreateModeT dynamicPortalCreateModeT = new IDynamicPortalCreateModeT();
			this.UnPackTo(dynamicPortalCreateModeT);
			return dynamicPortalCreateModeT;
		}

		// Token: 0x060215E3 RID: 136675 RVA: 0x004A239C File Offset: 0x004A059C
		public void UnPackTo(IDynamicPortalCreateModeT _o)
		{
			_o.Type = this.Type;
			_o.PortalA = ((this.PortalA != null) ? this.PortalA.Value.UnPack() : null);
			_o.PortalB = ((this.PortalB != null) ? this.PortalB.Value.UnPack() : null);
			_o.InitOpenPortal = this.InitOpenPortal;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060215E4 RID: 136676 RVA: 0x004A245C File Offset: 0x004A065C
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

		// Token: 0x0400E14A RID: 57674
		private Table __p;
	}
}
