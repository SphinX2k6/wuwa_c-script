using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004554 RID: 17748
	public struct IRollBlockBlockTemplate : IFlatbufferObject
	{
		// Token: 0x17007DE2 RID: 32226
		// (get) Token: 0x0601AB57 RID: 109399 RVA: 0x003CF070 File Offset: 0x003CD270
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB58 RID: 109400 RVA: 0x003CF07D File Offset: 0x003CD27D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB59 RID: 109401 RVA: 0x003CF084 File Offset: 0x003CD284
		public static IRollBlockBlockTemplate GetRootAsIRollBlockBlockTemplate(ByteBuffer _bb)
		{
			return IRollBlockBlockTemplate.GetRootAsIRollBlockBlockTemplate(_bb, default(IRollBlockBlockTemplate));
		}

		// Token: 0x0601AB5A RID: 109402 RVA: 0x003CF0A0 File Offset: 0x003CD2A0
		public static IRollBlockBlockTemplate GetRootAsIRollBlockBlockTemplate(ByteBuffer _bb, IRollBlockBlockTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB5B RID: 109403 RVA: 0x003CF0BD File Offset: 0x003CD2BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB5C RID: 109404 RVA: 0x003CF0CC File Offset: 0x003CD2CC
		public IRollBlockBlockTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DE3 RID: 32227
		// (get) Token: 0x0601AB5D RID: 109405 RVA: 0x003CF0DC File Offset: 0x003CD2DC
		public ERollBlockBlockType BlockType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockBlockType.Block1;
				}
				return (ERollBlockBlockType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007DE4 RID: 32228
		// (get) Token: 0x0601AB5E RID: 109406 RVA: 0x003CF118 File Offset: 0x003CD318
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

		// Token: 0x0601AB5F RID: 109407 RVA: 0x003CF14F File Offset: 0x003CD34F
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601AB60 RID: 109408 RVA: 0x003CF15E File Offset: 0x003CD35E
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007DE5 RID: 32229
		// (get) Token: 0x0601AB61 RID: 109409 RVA: 0x003CF16C File Offset: 0x003CD36C
		public string PhantomTemplateId
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

		// Token: 0x0601AB62 RID: 109410 RVA: 0x003CF1A3 File Offset: 0x003CD3A3
		public Span<byte> GetPhantomTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601AB63 RID: 109411 RVA: 0x003CF1B2 File Offset: 0x003CD3B2
		public byte[] GetPhantomTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007DE6 RID: 32230
		// (get) Token: 0x0601AB64 RID: 109412 RVA: 0x003CF1C0 File Offset: 0x003CD3C0
		public IVectorInfo? Size
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601AB65 RID: 109413 RVA: 0x003CF21E File Offset: 0x003CD41E
		public static Offset<IRollBlockBlockTemplate> CreateIRollBlockBlockTemplate(FlatBufferBuilder builder, ERollBlockBlockType BlockType = ERollBlockBlockType.Block1, StringOffset TemplateIdOffset = default(StringOffset), StringOffset PhantomTemplateIdOffset = default(StringOffset), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IRollBlockBlockTemplate.AddSize(builder, SizeOffset);
			IRollBlockBlockTemplate.AddPhantomTemplateId(builder, PhantomTemplateIdOffset);
			IRollBlockBlockTemplate.AddTemplateId(builder, TemplateIdOffset);
			IRollBlockBlockTemplate.AddBlockType(builder, BlockType);
			return IRollBlockBlockTemplate.EndIRollBlockBlockTemplate(builder);
		}

		// Token: 0x0601AB66 RID: 109414 RVA: 0x003CF24A File Offset: 0x003CD44A
		public static void StartIRollBlockBlockTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601AB67 RID: 109415 RVA: 0x003CF253 File Offset: 0x003CD453
		public static void AddBlockType(FlatBufferBuilder builder, ERollBlockBlockType blockType)
		{
			builder.AddByte(0, (byte)blockType, 0);
		}

		// Token: 0x0601AB68 RID: 109416 RVA: 0x003CF25E File Offset: 0x003CD45E
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0601AB69 RID: 109417 RVA: 0x003CF26E File Offset: 0x003CD46E
		public static void AddPhantomTemplateId(FlatBufferBuilder builder, StringOffset phantomTemplateIdOffset)
		{
			builder.AddOffset(2, phantomTemplateIdOffset.Value, 0);
		}

		// Token: 0x0601AB6A RID: 109418 RVA: 0x003CF27E File Offset: 0x003CD47E
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(3, sizeOffset.Value, 0);
		}

		// Token: 0x0601AB6B RID: 109419 RVA: 0x003CF28E File Offset: 0x003CD48E
		public static Offset<IRollBlockBlockTemplate> EndIRollBlockBlockTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockBlockTemplate>(builder.EndTable());
		}

		// Token: 0x0601AB6C RID: 109420 RVA: 0x003CF29C File Offset: 0x003CD49C
		public IRollBlockBlockTemplateT UnPack()
		{
			IRollBlockBlockTemplateT rollBlockBlockTemplateT = new IRollBlockBlockTemplateT();
			this.UnPackTo(rollBlockBlockTemplateT);
			return rollBlockBlockTemplateT;
		}

		// Token: 0x0601AB6D RID: 109421 RVA: 0x003CF2B8 File Offset: 0x003CD4B8
		public void UnPackTo(IRollBlockBlockTemplateT _o)
		{
			_o.BlockType = this.BlockType;
			_o.TemplateId = this.TemplateId;
			_o.PhantomTemplateId = this.PhantomTemplateId;
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
		}

		// Token: 0x0601AB6E RID: 109422 RVA: 0x003CF318 File Offset: 0x003CD518
		public static Offset<IRollBlockBlockTemplate> Pack(FlatBufferBuilder builder, IRollBlockBlockTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockBlockTemplate>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			StringOffset phantomTemplateIdOffset = (_o.PhantomTemplateId == null) ? default(StringOffset) : builder.CreateString(_o.PhantomTemplateId);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			return IRollBlockBlockTemplate.CreateIRollBlockBlockTemplate(builder, _o.BlockType, templateIdOffset, phantomTemplateIdOffset, sizeOffset);
		}

		// Token: 0x0400C5E1 RID: 50657
		private Table __p;
	}
}
