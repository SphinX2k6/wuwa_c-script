using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563A RID: 22074
	public struct IDynamicBulletConfig : IFlatbufferObject
	{
		// Token: 0x17009E85 RID: 40581
		// (get) Token: 0x060233FB RID: 144379 RVA: 0x004D99B5 File Offset: 0x004D7BB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060233FC RID: 144380 RVA: 0x004D99C2 File Offset: 0x004D7BC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060233FD RID: 144381 RVA: 0x004D99CC File Offset: 0x004D7BCC
		public static IDynamicBulletConfig GetRootAsIDynamicBulletConfig(ByteBuffer _bb)
		{
			return IDynamicBulletConfig.GetRootAsIDynamicBulletConfig(_bb, default(IDynamicBulletConfig));
		}

		// Token: 0x060233FE RID: 144382 RVA: 0x004D99E8 File Offset: 0x004D7BE8
		public static IDynamicBulletConfig GetRootAsIDynamicBulletConfig(ByteBuffer _bb, IDynamicBulletConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060233FF RID: 144383 RVA: 0x004D9A05 File Offset: 0x004D7C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023400 RID: 144384 RVA: 0x004D9A14 File Offset: 0x004D7C14
		public IDynamicBulletConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E86 RID: 40582
		// (get) Token: 0x06023401 RID: 144385 RVA: 0x004D9A24 File Offset: 0x004D7C24
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

		// Token: 0x17009E87 RID: 40583
		// (get) Token: 0x06023402 RID: 144386 RVA: 0x004D9A60 File Offset: 0x004D7C60
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

		// Token: 0x17009E88 RID: 40584
		// (get) Token: 0x06023403 RID: 144387 RVA: 0x004D9A9C File Offset: 0x004D7C9C
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

		// Token: 0x06023404 RID: 144388 RVA: 0x004D9AD3 File Offset: 0x004D7CD3
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06023405 RID: 144389 RVA: 0x004D9AE2 File Offset: 0x004D7CE2
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06023406 RID: 144390 RVA: 0x004D9AF0 File Offset: 0x004D7CF0
		public static Offset<IDynamicBulletConfig> CreateIDynamicBulletConfig(FlatBufferBuilder builder, int BulletId = 0, EPortalModel PortalModel = EPortalModel.A, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IDynamicBulletConfig.AddTemplateId(builder, TemplateIdOffset);
			IDynamicBulletConfig.AddBulletId(builder, BulletId);
			IDynamicBulletConfig.AddPortalModel(builder, PortalModel);
			return IDynamicBulletConfig.EndIDynamicBulletConfig(builder);
		}

		// Token: 0x06023407 RID: 144391 RVA: 0x004D9B14 File Offset: 0x004D7D14
		public static void StartIDynamicBulletConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023408 RID: 144392 RVA: 0x004D9B1D File Offset: 0x004D7D1D
		public static void AddBulletId(FlatBufferBuilder builder, int bulletId)
		{
			builder.AddInt(0, bulletId, 0);
		}

		// Token: 0x06023409 RID: 144393 RVA: 0x004D9B28 File Offset: 0x004D7D28
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x0602340A RID: 144394 RVA: 0x004D9B33 File Offset: 0x004D7D33
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(2, templateIdOffset.Value, 0);
		}

		// Token: 0x0602340B RID: 144395 RVA: 0x004D9B43 File Offset: 0x004D7D43
		public static Offset<IDynamicBulletConfig> EndIDynamicBulletConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicBulletConfig>(builder.EndTable());
		}

		// Token: 0x0602340C RID: 144396 RVA: 0x004D9B50 File Offset: 0x004D7D50
		public IDynamicBulletConfigT UnPack()
		{
			IDynamicBulletConfigT dynamicBulletConfigT = new IDynamicBulletConfigT();
			this.UnPackTo(dynamicBulletConfigT);
			return dynamicBulletConfigT;
		}

		// Token: 0x0602340D RID: 144397 RVA: 0x004D9B6B File Offset: 0x004D7D6B
		public void UnPackTo(IDynamicBulletConfigT _o)
		{
			_o.BulletId = this.BulletId;
			_o.PortalModel = this.PortalModel;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0602340E RID: 144398 RVA: 0x004D9B94 File Offset: 0x004D7D94
		public static Offset<IDynamicBulletConfig> Pack(FlatBufferBuilder builder, IDynamicBulletConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicBulletConfig>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDynamicBulletConfig.CreateIDynamicBulletConfig(builder, _o.BulletId, _o.PortalModel, templateIdOffset);
		}

		// Token: 0x0400ED19 RID: 60697
		private Table __p;
	}
}
