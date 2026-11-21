using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A07 RID: 18951
	public struct IRollBlockItemTemplate : IFlatbufferObject
	{
		// Token: 0x170084E2 RID: 34018
		// (get) Token: 0x0601C6B2 RID: 116402 RVA: 0x0040385A File Offset: 0x00401A5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C6B3 RID: 116403 RVA: 0x00403867 File Offset: 0x00401A67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C6B4 RID: 116404 RVA: 0x00403870 File Offset: 0x00401A70
		public static IRollBlockItemTemplate GetRootAsIRollBlockItemTemplate(ByteBuffer _bb)
		{
			return IRollBlockItemTemplate.GetRootAsIRollBlockItemTemplate(_bb, default(IRollBlockItemTemplate));
		}

		// Token: 0x0601C6B5 RID: 116405 RVA: 0x0040388C File Offset: 0x00401A8C
		public static IRollBlockItemTemplate GetRootAsIRollBlockItemTemplate(ByteBuffer _bb, IRollBlockItemTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C6B6 RID: 116406 RVA: 0x004038A9 File Offset: 0x00401AA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C6B7 RID: 116407 RVA: 0x004038B8 File Offset: 0x00401AB8
		public IRollBlockItemTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084E3 RID: 34019
		// (get) Token: 0x0601C6B8 RID: 116408 RVA: 0x004038C8 File Offset: 0x00401AC8
		public ERollBlockItemType ItemType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockItemType.BreakableObstacle;
				}
				return (ERollBlockItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170084E4 RID: 34020
		// (get) Token: 0x0601C6B9 RID: 116409 RVA: 0x00403904 File Offset: 0x00401B04
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

		// Token: 0x0601C6BA RID: 116410 RVA: 0x0040393B File Offset: 0x00401B3B
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C6BB RID: 116411 RVA: 0x0040394A File Offset: 0x00401B4A
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601C6BC RID: 116412 RVA: 0x00403958 File Offset: 0x00401B58
		public static Offset<IRollBlockItemTemplate> CreateIRollBlockItemTemplate(FlatBufferBuilder builder, ERollBlockItemType ItemType = ERollBlockItemType.BreakableObstacle, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRollBlockItemTemplate.AddTemplateId(builder, TemplateIdOffset);
			IRollBlockItemTemplate.AddItemType(builder, ItemType);
			return IRollBlockItemTemplate.EndIRollBlockItemTemplate(builder);
		}

		// Token: 0x0601C6BD RID: 116413 RVA: 0x00403975 File Offset: 0x00401B75
		public static void StartIRollBlockItemTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C6BE RID: 116414 RVA: 0x0040397E File Offset: 0x00401B7E
		public static void AddItemType(FlatBufferBuilder builder, ERollBlockItemType itemType)
		{
			builder.AddByte(0, (byte)itemType, 0);
		}

		// Token: 0x0601C6BF RID: 116415 RVA: 0x00403989 File Offset: 0x00401B89
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0601C6C0 RID: 116416 RVA: 0x00403999 File Offset: 0x00401B99
		public static Offset<IRollBlockItemTemplate> EndIRollBlockItemTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemTemplate>(builder.EndTable());
		}

		// Token: 0x0601C6C1 RID: 116417 RVA: 0x004039A8 File Offset: 0x00401BA8
		public IRollBlockItemTemplateT UnPack()
		{
			IRollBlockItemTemplateT rollBlockItemTemplateT = new IRollBlockItemTemplateT();
			this.UnPackTo(rollBlockItemTemplateT);
			return rollBlockItemTemplateT;
		}

		// Token: 0x0601C6C2 RID: 116418 RVA: 0x004039C3 File Offset: 0x00401BC3
		public void UnPackTo(IRollBlockItemTemplateT _o)
		{
			_o.ItemType = this.ItemType;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0601C6C3 RID: 116419 RVA: 0x004039E0 File Offset: 0x00401BE0
		public static Offset<IRollBlockItemTemplate> Pack(FlatBufferBuilder builder, IRollBlockItemTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemTemplate>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IRollBlockItemTemplate.CreateIRollBlockItemTemplate(builder, _o.ItemType, templateIdOffset);
		}

		// Token: 0x0400D090 RID: 53392
		private Table __p;
	}
}
