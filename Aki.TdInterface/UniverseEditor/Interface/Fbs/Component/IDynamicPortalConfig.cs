using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005652 RID: 22098
	public struct IDynamicPortalConfig : IFlatbufferObject
	{
		// Token: 0x17009ECA RID: 40650
		// (get) Token: 0x06023509 RID: 144649 RVA: 0x004DBDEE File Offset: 0x004D9FEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602350A RID: 144650 RVA: 0x004DBDFB File Offset: 0x004D9FFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602350B RID: 144651 RVA: 0x004DBE04 File Offset: 0x004DA004
		public static IDynamicPortalConfig GetRootAsIDynamicPortalConfig(ByteBuffer _bb)
		{
			return IDynamicPortalConfig.GetRootAsIDynamicPortalConfig(_bb, default(IDynamicPortalConfig));
		}

		// Token: 0x0602350C RID: 144652 RVA: 0x004DBE20 File Offset: 0x004DA020
		public static IDynamicPortalConfig GetRootAsIDynamicPortalConfig(ByteBuffer _bb, IDynamicPortalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602350D RID: 144653 RVA: 0x004DBE3D File Offset: 0x004DA03D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602350E RID: 144654 RVA: 0x004DBE4C File Offset: 0x004DA04C
		public IDynamicPortalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009ECB RID: 40651
		// (get) Token: 0x0602350F RID: 144655 RVA: 0x004DBE5C File Offset: 0x004DA05C
		public EPortalModel PortalModel
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPortalModel.A;
				}
				return (EPortalModel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009ECC RID: 40652
		// (get) Token: 0x06023510 RID: 144656 RVA: 0x004DBE98 File Offset: 0x004DA098
		public string TemplateId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023511 RID: 144657 RVA: 0x004DBECF File Offset: 0x004DA0CF
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023512 RID: 144658 RVA: 0x004DBEDE File Offset: 0x004DA0DE
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023513 RID: 144659 RVA: 0x004DBEEC File Offset: 0x004DA0EC
		public static Offset<IDynamicPortalConfig> CreateIDynamicPortalConfig(FlatBufferBuilder builder, EPortalModel PortalModel = EPortalModel.A, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDynamicPortalConfig.AddTemplateId(builder, TemplateIdOffset);
			IDynamicPortalConfig.AddPortalModel(builder, PortalModel);
			return IDynamicPortalConfig.EndIDynamicPortalConfig(builder);
		}

		// Token: 0x06023514 RID: 144660 RVA: 0x004DBF09 File Offset: 0x004DA109
		public static void StartIDynamicPortalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023515 RID: 144661 RVA: 0x004DBF12 File Offset: 0x004DA112
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(0, (byte)portalModel, 0);
		}

		// Token: 0x06023516 RID: 144662 RVA: 0x004DBF1D File Offset: 0x004DA11D
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x06023517 RID: 144663 RVA: 0x004DBF2D File Offset: 0x004DA12D
		public static Offset<IDynamicPortalConfig> EndIDynamicPortalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalConfig>(builder.EndTable());
		}

		// Token: 0x06023518 RID: 144664 RVA: 0x004DBF3C File Offset: 0x004DA13C
		public IDynamicPortalConfigT UnPack()
		{
			IDynamicPortalConfigT dynamicPortalConfigT = new IDynamicPortalConfigT();
			this.UnPackTo(dynamicPortalConfigT);
			return dynamicPortalConfigT;
		}

		// Token: 0x06023519 RID: 144665 RVA: 0x004DBF57 File Offset: 0x004DA157
		public void UnPackTo(IDynamicPortalConfigT _o)
		{
			_o.PortalModel = this.PortalModel;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0602351A RID: 144666 RVA: 0x004DBF74 File Offset: 0x004DA174
		public static Offset<IDynamicPortalConfig> Pack(FlatBufferBuilder builder, IDynamicPortalConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortalConfig>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDynamicPortalConfig.CreateIDynamicPortalConfig(builder, _o.PortalModel, templateIdOffset);
		}

		// Token: 0x0400ED44 RID: 60740
		private Table __p;
	}
}
