using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D5 RID: 20693
	public struct IDynamicBulletConfig : IFlatbufferObject
	{
		// Token: 0x17009698 RID: 38552
		// (get) Token: 0x060214A7 RID: 136359 RVA: 0x0049FA29 File Offset: 0x0049DC29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060214A8 RID: 136360 RVA: 0x0049FA36 File Offset: 0x0049DC36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060214A9 RID: 136361 RVA: 0x0049FA40 File Offset: 0x0049DC40
		public static IDynamicBulletConfig GetRootAsIDynamicBulletConfig(ByteBuffer _bb)
		{
			return IDynamicBulletConfig.GetRootAsIDynamicBulletConfig(_bb, default(IDynamicBulletConfig));
		}

		// Token: 0x060214AA RID: 136362 RVA: 0x0049FA5C File Offset: 0x0049DC5C
		public static IDynamicBulletConfig GetRootAsIDynamicBulletConfig(ByteBuffer _bb, IDynamicBulletConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060214AB RID: 136363 RVA: 0x0049FA79 File Offset: 0x0049DC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060214AC RID: 136364 RVA: 0x0049FA88 File Offset: 0x0049DC88
		public IDynamicBulletConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009699 RID: 38553
		// (get) Token: 0x060214AD RID: 136365 RVA: 0x0049FA98 File Offset: 0x0049DC98
		public int BulletId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700969A RID: 38554
		// (get) Token: 0x060214AE RID: 136366 RVA: 0x0049FAD4 File Offset: 0x0049DCD4
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

		// Token: 0x1700969B RID: 38555
		// (get) Token: 0x060214AF RID: 136367 RVA: 0x0049FB10 File Offset: 0x0049DD10
		public string TemplateId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060214B0 RID: 136368 RVA: 0x0049FB47 File Offset: 0x0049DD47
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060214B1 RID: 136369 RVA: 0x0049FB56 File Offset: 0x0049DD56
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060214B2 RID: 136370 RVA: 0x0049FB64 File Offset: 0x0049DD64
		public static Offset<IDynamicBulletConfig> CreateIDynamicBulletConfig(FlatBufferBuilder builder, int BulletId = 0, EPortalModel PortalModel = EPortalModel.A, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IDynamicBulletConfig.AddTemplateId(builder, TemplateIdOffset);
			IDynamicBulletConfig.AddBulletId(builder, BulletId);
			IDynamicBulletConfig.AddPortalModel(builder, PortalModel);
			return IDynamicBulletConfig.EndIDynamicBulletConfig(builder);
		}

		// Token: 0x060214B3 RID: 136371 RVA: 0x0049FB88 File Offset: 0x0049DD88
		public static void StartIDynamicBulletConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060214B4 RID: 136372 RVA: 0x0049FB91 File Offset: 0x0049DD91
		public static void AddBulletId(FlatBufferBuilder builder, int bulletId)
		{
			builder.AddInt(0, bulletId, 0);
		}

		// Token: 0x060214B5 RID: 136373 RVA: 0x0049FB9C File Offset: 0x0049DD9C
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x060214B6 RID: 136374 RVA: 0x0049FBA7 File Offset: 0x0049DDA7
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(2, templateIdOffset.Value, 0);
		}

		// Token: 0x060214B7 RID: 136375 RVA: 0x0049FBB7 File Offset: 0x0049DDB7
		public static Offset<IDynamicBulletConfig> EndIDynamicBulletConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicBulletConfig>(builder.EndTable());
		}

		// Token: 0x060214B8 RID: 136376 RVA: 0x0049FBC4 File Offset: 0x0049DDC4
		public IDynamicBulletConfigT UnPack()
		{
			IDynamicBulletConfigT dynamicBulletConfigT = new IDynamicBulletConfigT();
			this.UnPackTo(dynamicBulletConfigT);
			return dynamicBulletConfigT;
		}

		// Token: 0x060214B9 RID: 136377 RVA: 0x0049FBDF File Offset: 0x0049DDDF
		public void UnPackTo(IDynamicBulletConfigT _o)
		{
			_o.BulletId = this.BulletId;
			_o.PortalModel = this.PortalModel;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x060214BA RID: 136378 RVA: 0x0049FC08 File Offset: 0x0049DE08
		public static Offset<IDynamicBulletConfig> Pack(FlatBufferBuilder builder, IDynamicBulletConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicBulletConfig>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDynamicBulletConfig.CreateIDynamicBulletConfig(builder, _o.BulletId, _o.PortalModel, templateIdOffset);
		}

		// Token: 0x0400E11C RID: 57628
		private Table __p;
	}
}
