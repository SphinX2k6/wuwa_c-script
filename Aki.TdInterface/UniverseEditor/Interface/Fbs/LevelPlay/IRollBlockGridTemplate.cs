using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200457E RID: 17790
	public struct IRollBlockGridTemplate : IFlatbufferObject
	{
		// Token: 0x17007E6A RID: 32362
		// (get) Token: 0x0601ADE9 RID: 110057 RVA: 0x003D5E2A File Offset: 0x003D402A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ADEA RID: 110058 RVA: 0x003D5E37 File Offset: 0x003D4037
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ADEB RID: 110059 RVA: 0x003D5E40 File Offset: 0x003D4040
		public static IRollBlockGridTemplate GetRootAsIRollBlockGridTemplate(ByteBuffer _bb)
		{
			return IRollBlockGridTemplate.GetRootAsIRollBlockGridTemplate(_bb, default(IRollBlockGridTemplate));
		}

		// Token: 0x0601ADEC RID: 110060 RVA: 0x003D5E5C File Offset: 0x003D405C
		public static IRollBlockGridTemplate GetRootAsIRollBlockGridTemplate(ByteBuffer _bb, IRollBlockGridTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ADED RID: 110061 RVA: 0x003D5E79 File Offset: 0x003D4079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ADEE RID: 110062 RVA: 0x003D5E88 File Offset: 0x003D4088
		public IRollBlockGridTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E6B RID: 32363
		// (get) Token: 0x0601ADEF RID: 110063 RVA: 0x003D5E98 File Offset: 0x003D4098
		public ERollBlockGridType GridType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockGridType.Empty;
				}
				return (ERollBlockGridType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E6C RID: 32364
		// (get) Token: 0x0601ADF0 RID: 110064 RVA: 0x003D5ED4 File Offset: 0x003D40D4
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

		// Token: 0x0601ADF1 RID: 110065 RVA: 0x003D5F0B File Offset: 0x003D410B
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ADF2 RID: 110066 RVA: 0x003D5F1A File Offset: 0x003D411A
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601ADF3 RID: 110067 RVA: 0x003D5F28 File Offset: 0x003D4128
		public static Offset<IRollBlockGridTemplate> CreateIRollBlockGridTemplate(FlatBufferBuilder builder, ERollBlockGridType GridType = ERollBlockGridType.Empty, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRollBlockGridTemplate.AddTemplateId(builder, TemplateIdOffset);
			IRollBlockGridTemplate.AddGridType(builder, GridType);
			return IRollBlockGridTemplate.EndIRollBlockGridTemplate(builder);
		}

		// Token: 0x0601ADF4 RID: 110068 RVA: 0x003D5F45 File Offset: 0x003D4145
		public static void StartIRollBlockGridTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ADF5 RID: 110069 RVA: 0x003D5F4E File Offset: 0x003D414E
		public static void AddGridType(FlatBufferBuilder builder, ERollBlockGridType gridType)
		{
			builder.AddByte(0, (byte)gridType, 0);
		}

		// Token: 0x0601ADF6 RID: 110070 RVA: 0x003D5F59 File Offset: 0x003D4159
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0601ADF7 RID: 110071 RVA: 0x003D5F69 File Offset: 0x003D4169
		public static Offset<IRollBlockGridTemplate> EndIRollBlockGridTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridTemplate>(builder.EndTable());
		}

		// Token: 0x0601ADF8 RID: 110072 RVA: 0x003D5F78 File Offset: 0x003D4178
		public IRollBlockGridTemplateT UnPack()
		{
			IRollBlockGridTemplateT rollBlockGridTemplateT = new IRollBlockGridTemplateT();
			this.UnPackTo(rollBlockGridTemplateT);
			return rollBlockGridTemplateT;
		}

		// Token: 0x0601ADF9 RID: 110073 RVA: 0x003D5F93 File Offset: 0x003D4193
		public void UnPackTo(IRollBlockGridTemplateT _o)
		{
			_o.GridType = this.GridType;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0601ADFA RID: 110074 RVA: 0x003D5FB0 File Offset: 0x003D41B0
		public static Offset<IRollBlockGridTemplate> Pack(FlatBufferBuilder builder, IRollBlockGridTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridTemplate>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IRollBlockGridTemplate.CreateIRollBlockGridTemplate(builder, _o.GridType, templateIdOffset);
		}

		// Token: 0x0400C633 RID: 50739
		private Table __p;
	}
}
