using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050ED RID: 20717
	public struct IDynamicPortalConfig : IFlatbufferObject
	{
		// Token: 0x170096DD RID: 38621
		// (get) Token: 0x060215B5 RID: 136629 RVA: 0x004A1E62 File Offset: 0x004A0062
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060215B6 RID: 136630 RVA: 0x004A1E6F File Offset: 0x004A006F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060215B7 RID: 136631 RVA: 0x004A1E78 File Offset: 0x004A0078
		public static IDynamicPortalConfig GetRootAsIDynamicPortalConfig(ByteBuffer _bb)
		{
			return IDynamicPortalConfig.GetRootAsIDynamicPortalConfig(_bb, default(IDynamicPortalConfig));
		}

		// Token: 0x060215B8 RID: 136632 RVA: 0x004A1E94 File Offset: 0x004A0094
		public static IDynamicPortalConfig GetRootAsIDynamicPortalConfig(ByteBuffer _bb, IDynamicPortalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060215B9 RID: 136633 RVA: 0x004A1EB1 File Offset: 0x004A00B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060215BA RID: 136634 RVA: 0x004A1EC0 File Offset: 0x004A00C0
		public IDynamicPortalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096DE RID: 38622
		// (get) Token: 0x060215BB RID: 136635 RVA: 0x004A1ED0 File Offset: 0x004A00D0
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

		// Token: 0x170096DF RID: 38623
		// (get) Token: 0x060215BC RID: 136636 RVA: 0x004A1F0C File Offset: 0x004A010C
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

		// Token: 0x060215BD RID: 136637 RVA: 0x004A1F43 File Offset: 0x004A0143
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060215BE RID: 136638 RVA: 0x004A1F52 File Offset: 0x004A0152
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060215BF RID: 136639 RVA: 0x004A1F60 File Offset: 0x004A0160
		public static Offset<IDynamicPortalConfig> CreateIDynamicPortalConfig(FlatBufferBuilder builder, EPortalModel PortalModel = EPortalModel.A, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDynamicPortalConfig.AddTemplateId(builder, TemplateIdOffset);
			IDynamicPortalConfig.AddPortalModel(builder, PortalModel);
			return IDynamicPortalConfig.EndIDynamicPortalConfig(builder);
		}

		// Token: 0x060215C0 RID: 136640 RVA: 0x004A1F7D File Offset: 0x004A017D
		public static void StartIDynamicPortalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060215C1 RID: 136641 RVA: 0x004A1F86 File Offset: 0x004A0186
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(0, (byte)portalModel, 0);
		}

		// Token: 0x060215C2 RID: 136642 RVA: 0x004A1F91 File Offset: 0x004A0191
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x060215C3 RID: 136643 RVA: 0x004A1FA1 File Offset: 0x004A01A1
		public static Offset<IDynamicPortalConfig> EndIDynamicPortalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicPortalConfig>(builder.EndTable());
		}

		// Token: 0x060215C4 RID: 136644 RVA: 0x004A1FB0 File Offset: 0x004A01B0
		public IDynamicPortalConfigT UnPack()
		{
			IDynamicPortalConfigT dynamicPortalConfigT = new IDynamicPortalConfigT();
			this.UnPackTo(dynamicPortalConfigT);
			return dynamicPortalConfigT;
		}

		// Token: 0x060215C5 RID: 136645 RVA: 0x004A1FCB File Offset: 0x004A01CB
		public void UnPackTo(IDynamicPortalConfigT _o)
		{
			_o.PortalModel = this.PortalModel;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x060215C6 RID: 136646 RVA: 0x004A1FE8 File Offset: 0x004A01E8
		public static Offset<IDynamicPortalConfig> Pack(FlatBufferBuilder builder, IDynamicPortalConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicPortalConfig>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDynamicPortalConfig.CreateIDynamicPortalConfig(builder, _o.PortalModel, templateIdOffset);
		}

		// Token: 0x0400E147 RID: 57671
		private Table __p;
	}
}
