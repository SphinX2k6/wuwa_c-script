using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049BC RID: 18876
	public struct IRollBlockBlockTemplate : IFlatbufferObject
	{
		// Token: 0x17008423 RID: 33827
		// (get) Token: 0x0601C32C RID: 115500 RVA: 0x003FB30C File Offset: 0x003F950C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C32D RID: 115501 RVA: 0x003FB319 File Offset: 0x003F9519
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C32E RID: 115502 RVA: 0x003FB320 File Offset: 0x003F9520
		public static IRollBlockBlockTemplate GetRootAsIRollBlockBlockTemplate(ByteBuffer _bb)
		{
			return IRollBlockBlockTemplate.GetRootAsIRollBlockBlockTemplate(_bb, default(IRollBlockBlockTemplate));
		}

		// Token: 0x0601C32F RID: 115503 RVA: 0x003FB33C File Offset: 0x003F953C
		public static IRollBlockBlockTemplate GetRootAsIRollBlockBlockTemplate(ByteBuffer _bb, IRollBlockBlockTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C330 RID: 115504 RVA: 0x003FB359 File Offset: 0x003F9559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C331 RID: 115505 RVA: 0x003FB368 File Offset: 0x003F9568
		public IRollBlockBlockTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008424 RID: 33828
		// (get) Token: 0x0601C332 RID: 115506 RVA: 0x003FB378 File Offset: 0x003F9578
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

		// Token: 0x17008425 RID: 33829
		// (get) Token: 0x0601C333 RID: 115507 RVA: 0x003FB3B4 File Offset: 0x003F95B4
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

		// Token: 0x0601C334 RID: 115508 RVA: 0x003FB3EB File Offset: 0x003F95EB
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C335 RID: 115509 RVA: 0x003FB3FA File Offset: 0x003F95FA
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008426 RID: 33830
		// (get) Token: 0x0601C336 RID: 115510 RVA: 0x003FB408 File Offset: 0x003F9608
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

		// Token: 0x0601C337 RID: 115511 RVA: 0x003FB43F File Offset: 0x003F963F
		public Span<byte> GetPhantomTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601C338 RID: 115512 RVA: 0x003FB44E File Offset: 0x003F964E
		public byte[] GetPhantomTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008427 RID: 33831
		// (get) Token: 0x0601C339 RID: 115513 RVA: 0x003FB45C File Offset: 0x003F965C
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

		// Token: 0x0601C33A RID: 115514 RVA: 0x003FB4BA File Offset: 0x003F96BA
		public static Offset<IRollBlockBlockTemplate> CreateIRollBlockBlockTemplate(FlatBufferBuilder builder, ERollBlockBlockType BlockType = ERollBlockBlockType.Block1, StringOffset TemplateIdOffset = default(StringOffset), StringOffset PhantomTemplateIdOffset = default(StringOffset), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IRollBlockBlockTemplate.AddSize(builder, SizeOffset);
			IRollBlockBlockTemplate.AddPhantomTemplateId(builder, PhantomTemplateIdOffset);
			IRollBlockBlockTemplate.AddTemplateId(builder, TemplateIdOffset);
			IRollBlockBlockTemplate.AddBlockType(builder, BlockType);
			return IRollBlockBlockTemplate.EndIRollBlockBlockTemplate(builder);
		}

		// Token: 0x0601C33B RID: 115515 RVA: 0x003FB4E6 File Offset: 0x003F96E6
		public static void StartIRollBlockBlockTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C33C RID: 115516 RVA: 0x003FB4EF File Offset: 0x003F96EF
		public static void AddBlockType(FlatBufferBuilder builder, ERollBlockBlockType blockType)
		{
			builder.AddByte(0, (byte)blockType, 0);
		}

		// Token: 0x0601C33D RID: 115517 RVA: 0x003FB4FA File Offset: 0x003F96FA
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0601C33E RID: 115518 RVA: 0x003FB50A File Offset: 0x003F970A
		public static void AddPhantomTemplateId(FlatBufferBuilder builder, StringOffset phantomTemplateIdOffset)
		{
			builder.AddOffset(2, phantomTemplateIdOffset.Value, 0);
		}

		// Token: 0x0601C33F RID: 115519 RVA: 0x003FB51A File Offset: 0x003F971A
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(3, sizeOffset.Value, 0);
		}

		// Token: 0x0601C340 RID: 115520 RVA: 0x003FB52A File Offset: 0x003F972A
		public static Offset<IRollBlockBlockTemplate> EndIRollBlockBlockTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockBlockTemplate>(builder.EndTable());
		}

		// Token: 0x0601C341 RID: 115521 RVA: 0x003FB538 File Offset: 0x003F9738
		public IRollBlockBlockTemplateT UnPack()
		{
			IRollBlockBlockTemplateT rollBlockBlockTemplateT = new IRollBlockBlockTemplateT();
			this.UnPackTo(rollBlockBlockTemplateT);
			return rollBlockBlockTemplateT;
		}

		// Token: 0x0601C342 RID: 115522 RVA: 0x003FB554 File Offset: 0x003F9754
		public void UnPackTo(IRollBlockBlockTemplateT _o)
		{
			_o.BlockType = this.BlockType;
			_o.TemplateId = this.TemplateId;
			_o.PhantomTemplateId = this.PhantomTemplateId;
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
		}

		// Token: 0x0601C343 RID: 115523 RVA: 0x003FB5B4 File Offset: 0x003F97B4
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

		// Token: 0x0400D010 RID: 53264
		private Table __p;
	}
}
