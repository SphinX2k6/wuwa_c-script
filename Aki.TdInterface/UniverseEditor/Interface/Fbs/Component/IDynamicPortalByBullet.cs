using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564F RID: 22095
	public struct IDynamicPortalByBullet : IFlatbufferObject
	{
		// Token: 0x17009EB9 RID: 40633
		// (get) Token: 0x060234DB RID: 144603 RVA: 0x004DB5FF File Offset: 0x004D97FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060234DC RID: 144604 RVA: 0x004DB60C File Offset: 0x004D980C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060234DD RID: 144605 RVA: 0x004DB614 File Offset: 0x004D9814
		public static IDynamicPortalByBullet GetRootAsIDynamicPortalByBullet(ByteBuffer _bb)
		{
			return IDynamicPortalByBullet.GetRootAsIDynamicPortalByBullet(_bb, default(IDynamicPortalByBullet));
		}

		// Token: 0x060234DE RID: 144606 RVA: 0x004DB630 File Offset: 0x004D9830
		public static IDynamicPortalByBullet GetRootAsIDynamicPortalByBullet(ByteBuffer _bb, IDynamicPortalByBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060234DF RID: 144607 RVA: 0x004DB64D File Offset: 0x004D984D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060234E0 RID: 144608 RVA: 0x004DB65C File Offset: 0x004D985C
		public IDynamicPortalByBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EBA RID: 40634
		// (get) Token: 0x060234E1 RID: 144609 RVA: 0x004DB66C File Offset: 0x004D986C
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

		// Token: 0x17009EBB RID: 40635
		// (get) Token: 0x060234E2 RID: 144610 RVA: 0x004DB6A8 File Offset: 0x004D98A8
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

		// Token: 0x17009EBC RID: 40636
		// (get) Token: 0x060234E3 RID: 144611 RVA: 0x004DB708 File Offset: 0x004D9908
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

		// Token: 0x17009EBD RID: 40637
		// (get) Token: 0x060234E4 RID: 144612 RVA: 0x004DB768 File Offset: 0x004D9968
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

		// Token: 0x17009EBE RID: 40638
		// (get) Token: 0x060234E5 RID: 144613 RVA: 0x004DB7A8 File Offset: 0x004D99A8
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

		// Token: 0x17009EBF RID: 40639
		// (get) Token: 0x060234E6 RID: 144614 RVA: 0x004DB808 File Offset: 0x004D9A08
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

		// Token: 0x17009EC0 RID: 40640
		// (get) Token: 0x060234E7 RID: 144615 RVA: 0x004DB868 File Offset: 0x004D9A68
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

		// Token: 0x17009EC1 RID: 40641
		// (get) Token: 0x060234E8 RID: 144616 RVA: 0x004DB8C8 File Offset: 0x004D9AC8
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

		// Token: 0x060234E9 RID: 144617 RVA: 0x004DB908 File Offset: 0x004D9B08
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

		// Token: 0x060234EA RID: 144618 RVA: 0x004DB95F File Offset: 0x004D9B5F
		public static void StartIDynamicPortalByBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060234EB RID: 144619 RVA: 0x004DB968 File Offset: 0x004D9B68
		public static void AddType(FlatBufferBuilder builder, EDynamicPortalCreateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060234EC RID: 144620 RVA: 0x004DB973 File Offset: 0x004D9B73
		public static void AddPortalA(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalAOffset)
		{
			builder.AddOffset(1, portalAOffset.Value, 0);
		}

		// Token: 0x060234ED RID: 144621 RVA: 0x004DB983 File Offset: 0x004D9B83
		public static void AddPortalB(FlatBufferBuilder builder, Offset<IDynamicPortalConfig> portalBOffset)
		{
			builder.AddOffset(2, portalBOffset.Value, 0);
		}

		// Token: 0x060234EE RID: 144622 RVA: 0x004DB993 File Offset: 0x004D9B93
		public static void AddInitOpenPortal(FlatBufferBuilder builder, EPortalModel initOpenPortal)
		{
			builder.AddByte(3, (byte)initOpenPortal, 0);
		}

		// Token: 0x060234EF RID: 144623 RVA: 0x004DB99E File Offset: 0x004D9B9E
		public static void AddRenderConfig(FlatBufferBuilder builder, Offset<IPortalRenderConfig> renderConfigOffset)
		{
			builder.AddOffset(4, renderConfigOffset.Value, 0);
		}

		// Token: 0x060234F0 RID: 144624 RVA: 0x004DB9AE File Offset: 0x004D9BAE
		public static void AddTypeA(FlatBufferBuilder builder, Offset<IDynamicBulletConfig> typeAOffset)
		{
			builder.AddOffset(5, typeAOffset.Value, 0);
		}

		// Token: 0x060234F1 RID: 144625 RVA: 0x004DB9BE File Offset: 0x004D9BBE
		public static void AddTypeB(FlatBufferBuilder builder, Offset<IDynamicBulletConfig> typeBOffset)
		{
			builder.AddOffset(6, typeBOffset.Value, 0);
		}

		// Token: 0x060234F2 RID: 144626 RVA: 0x004DB9CE File Offset: 0x004D9BCE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060234F3 RID: 144627 RVA: 0x004DB9D9 File Offset: 0x004D9BD9
		public static Offset<IDynamicPortalByBullet> EndIDynamicPortalByBullet(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalByBullet>(builder.EndTable());
		}

		// Token: 0x060234F4 RID: 144628 RVA: 0x004DB9E8 File Offset: 0x004D9BE8
		public IDynamicPortalByBulletT UnPack()
		{
			IDynamicPortalByBulletT dynamicPortalByBulletT = new IDynamicPortalByBulletT();
			this.UnPackTo(dynamicPortalByBulletT);
			return dynamicPortalByBulletT;
		}

		// Token: 0x060234F5 RID: 144629 RVA: 0x004DBA04 File Offset: 0x004D9C04
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

		// Token: 0x060234F6 RID: 144630 RVA: 0x004DBB28 File Offset: 0x004D9D28
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

		// Token: 0x0400ED3B RID: 60731
		private Table __p;
	}
}
