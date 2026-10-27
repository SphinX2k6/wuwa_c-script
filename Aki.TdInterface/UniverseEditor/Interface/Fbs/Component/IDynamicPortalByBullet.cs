using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050EA RID: 20714
	public struct IDynamicPortalByBullet : IFlatbufferObject
	{
		// Token: 0x170096CC RID: 38604
		// (get) Token: 0x06021587 RID: 136583 RVA: 0x004A1673 File Offset: 0x0049F873
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021588 RID: 136584 RVA: 0x004A1680 File Offset: 0x0049F880
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021589 RID: 136585 RVA: 0x004A1688 File Offset: 0x0049F888
		public static IDynamicPortalByBullet GetRootAsIDynamicPortalByBullet(ByteBuffer _bb)
		{
			return IDynamicPortalByBullet.GetRootAsIDynamicPortalByBullet(_bb, default(IDynamicPortalByBullet));
		}

		// Token: 0x0602158A RID: 136586 RVA: 0x004A16A4 File Offset: 0x0049F8A4
		public static IDynamicPortalByBullet GetRootAsIDynamicPortalByBullet(ByteBuffer _bb, IDynamicPortalByBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602158B RID: 136587 RVA: 0x004A16C1 File Offset: 0x0049F8C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602158C RID: 136588 RVA: 0x004A16D0 File Offset: 0x0049F8D0
		public IDynamicPortalByBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096CD RID: 38605
		// (get) Token: 0x0602158D RID: 136589 RVA: 0x004A16E0 File Offset: 0x0049F8E0
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

		// Token: 0x170096CE RID: 38606
		// (get) Token: 0x0602158E RID: 136590 RVA: 0x004A171C File Offset: 0x0049F91C
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

		// Token: 0x170096CF RID: 38607
		// (get) Token: 0x0602158F RID: 136591 RVA: 0x004A177C File Offset: 0x0049F97C
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

		// Token: 0x170096D0 RID: 38608
		// (get) Token: 0x06021590 RID: 136592 RVA: 0x004A17DC File Offset: 0x0049F9DC
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

		// Token: 0x170096D1 RID: 38609
		// (get) Token: 0x06021591 RID: 136593 RVA: 0x004A181C File Offset: 0x0049FA1C
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

		// Token: 0x170096D2 RID: 38610
		// (get) Token: 0x06021592 RID: 136594 RVA: 0x004A187C File Offset: 0x0049FA7C
		public IDynamicBulletConfig? TypeA
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicBulletConfig?(default(IDynamicBulletConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170096D3 RID: 38611
		// (get) Token: 0x06021593 RID: 136595 RVA: 0x004A18DC File Offset: 0x0049FADC
		public IDynamicBulletConfig? TypeB
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicBulletConfig?(default(IDynamicBulletConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170096D4 RID: 38612
		// (get) Token: 0x06021594 RID: 136596 RVA: 0x004A193C File Offset: 0x0049FB3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021595 RID: 136597 RVA: 0x004A197C File Offset: 0x0049FB7C
		public static Offset<IDynamicPortalByBullet> CreateIDynamicPortalByBullet(FlatBufferBuilder builder, EDynamicPortalCreateType Type = EDynamicPortalCreateType.Bullet, Offset<IDynamicPortalConfig> PortalAOffset = default(Offset<IDynamicPortalConfig>), Offset<IDynamicPortalConfig> PortalBOffset = default(Offset<IDynamicPortalConfig>), EPortalModel InitOpenPortal = EPortalModel.A, Offset<IPortalRenderConfig> RenderConfigOffset = default(Offset<IPortalRenderConfig>), Offset<IDynamicBulletConfig> TypeAOffset = default(Offset<IDynamicBulletConfig>), Offset<IDynamicBulletConfig> TypeBOffset = default(Offset<IDynamicBulletConfig>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IDynamicPortalByBullet.AddTypeB(builder, TypeBOffset);
			IDynamicPortalByBullet.AddTypeA(builder, TypeAOffset);
			IDynamicPortalByBullet.AddRenderConfig(builder, RenderConfigOffset);
			IDynamicPortalByBullet.AddPortalB(builder, PortalBOffset);
			IDynamicPortalByBullet.AddPortalA(builder, PortalAOffset);
			IDynamicPortalByBullet.AddNullMask(builder, NullMask);
			IDynamicPortalByBullet.AddInitOpenPortal(builder, InitOpenPortal);
			IDynamicPortalByBullet.AddType(builder, Type);
			return IDynamicPortalByBullet.EndIDynamicPortalByBullet(builder);
		}

		// Token: 0x06021596 RID: 136598 RVA: 0x004A19D3 File Offset: 0x0049FBD3
		public static void StartIDynamicPortalByBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06021597 RID: 136599 RVA: 0x004A19DC File Offset: 0x0049FBDC
		public static void AddType(FlatBufferBuilder builder, EDynamicPortalCreateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021598 RID: 136600 RVA: 0x004A19E7 File Offset: 0x0049FBE7
		public static void AddPortalA(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalAOffset)
		{
			builder.AddOffset(1, portalAOffset.Value, 0);
		}

		// Token: 0x06021599 RID: 136601 RVA: 0x004A19F7 File Offset: 0x0049FBF7
		public static void AddPortalB(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalBOffset)
		{
			builder.AddOffset(2, portalBOffset.Value, 0);
		}

		// Token: 0x0602159A RID: 136602 RVA: 0x004A1A07 File Offset: 0x0049FC07
		public static void AddInitOpenPortal(FlatBufferBuilder builder, EPortalModel initOpenPortal)
		{
			builder.AddByte(3, (byte)initOpenPortal, 0);
		}

		// Token: 0x0602159B RID: 136603 RVA: 0x004A1A12 File Offset: 0x0049FC12
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(4, renderConfigOffset.Value, 0);
		}

		// Token: 0x0602159C RID: 136604 RVA: 0x004A1A22 File Offset: 0x0049FC22
		public static void AddTypeA(FlatBufferBuilder builder, Offset<IDynamicBulletConfig> typeAOffset)
		{
			builder.AddOffset(5, typeAOffset.Value, 0);
		}

		// Token: 0x0602159D RID: 136605 RVA: 0x004A1A32 File Offset: 0x0049FC32
		public static void AddTypeB(FlatBufferBuilder builder, Offset<IDynamicBulletConfig> typeBOffset)
		{
			builder.AddOffset(6, typeBOffset.Value, 0);
		}

		// Token: 0x0602159E RID: 136606 RVA: 0x004A1A42 File Offset: 0x0049FC42
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602159F RID: 136607 RVA: 0x004A1A4D File Offset: 0x0049FC4D
		public static Offset<IDynamicPortalByBullet> EndIDynamicPortalByBullet(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalByBullet>(builder.EndTable());
		}

		// Token: 0x060215A0 RID: 136608 RVA: 0x004A1A5C File Offset: 0x0049FC5C
		public IDynamicPortalByBulletT UnPack()
		{
			IDynamicPortalByBulletT dynamicPortalByBulletT = new IDynamicPortalByBulletT();
			this.UnPackTo(dynamicPortalByBulletT);
			return dynamicPortalByBulletT;
		}

		// Token: 0x060215A1 RID: 136609 RVA: 0x004A1A78 File Offset: 0x0049FC78
		public void UnPackTo(IDynamicPortalByBulletT _o)
		{
			_o.Type = this.Type;
			_o.PortalA = ((this.PortalA != null) ? this.PortalA.Value.UnPack() : null);
			_o.PortalB = ((this.PortalB != null) ? this.PortalB.Value.UnPack() : null);
			_o.InitOpenPortal = this.InitOpenPortal;
			_o.RenderConfig = ((this.RenderConfig != null) ? this.RenderConfig.Value.UnPack() : null);
			_o.TypeA = ((this.TypeA != null) ? this.TypeA.Value.UnPack() : null);
			_o.TypeB = ((this.TypeB != null) ? this.TypeB.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060215A2 RID: 136610 RVA: 0x004A1B9C File Offset: 0x0049FD9C
		public static Offset<IDynamicPortalByBullet> Pack(FlatBufferBuilder builder, IDynamicPortalByBulletT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortalByBullet>);
			}
			Offset<IDynamicPortalConfig> portalAOffset = (_o.PortalA == null) ? default(Offset<IDynamicPortalConfig>) : IDynamicPortalConfig.Pack(builder, _o.PortalA);
			Offset<IDynamicPortalConfig> portalBOffset = (_o.PortalB == null) ? default(Offset<IDynamicPortalConfig>) : IDynamicPortalConfig.Pack(builder, _o.PortalB);
			Offset<IPortalRenderConfig> renderConfigOffset = (_o.RenderConfig == null) ? default(Offset<IPortalRenderConfig>) : IPortalRenderConfig.Pack(builder, _o.RenderConfig);
			Offset<IDynamicBulletConfig> typeAOffset = (_o.TypeA == null) ? default(Offset<IDynamicBulletConfig>) : IDynamicBulletConfig.Pack(builder, _o.TypeA);
			Offset<IDynamicBulletConfig> typeBOffset = (_o.TypeB == null) ? default(Offset<IDynamicBulletConfig>) : IDynamicBulletConfig.Pack(builder, _o.TypeB);
			return IDynamicPortalByBullet.CreateIDynamicPortalByBullet(builder, _o.Type, portalAOffset, portalBOffset, _o.InitOpenPortal, renderConfigOffset, typeAOffset, typeBOffset, _o.NullMask);
		}

		// Token: 0x0400E13E RID: 57662
		private Table __p;
	}
}
