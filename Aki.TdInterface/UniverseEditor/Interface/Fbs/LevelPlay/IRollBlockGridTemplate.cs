using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049E6 RID: 18918
	public struct IRollBlockGridTemplate : IFlatbufferObject
	{
		// Token: 0x170084AB RID: 33963
		// (get) Token: 0x0601C5BE RID: 116158 RVA: 0x004020C6 File Offset: 0x004002C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C5BF RID: 116159 RVA: 0x004020D3 File Offset: 0x004002D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C5C0 RID: 116160 RVA: 0x004020DC File Offset: 0x004002DC
		public static IRollBlockGridTemplate GetRootAsIRollBlockGridTemplate(ByteBuffer _bb)
		{
			return IRollBlockGridTemplate.GetRootAsIRollBlockGridTemplate(_bb, default(IRollBlockGridTemplate));
		}

		// Token: 0x0601C5C1 RID: 116161 RVA: 0x004020F8 File Offset: 0x004002F8
		public static IRollBlockGridTemplate GetRootAsIRollBlockGridTemplate(ByteBuffer _bb, IRollBlockGridTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C5C2 RID: 116162 RVA: 0x00402115 File Offset: 0x00400315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C5C3 RID: 116163 RVA: 0x00402124 File Offset: 0x00400324
		public IRollBlockGridTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084AC RID: 33964
		// (get) Token: 0x0601C5C4 RID: 116164 RVA: 0x00402134 File Offset: 0x00400334
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

		// Token: 0x170084AD RID: 33965
		// (get) Token: 0x0601C5C5 RID: 116165 RVA: 0x00402170 File Offset: 0x00400370
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

		// Token: 0x0601C5C6 RID: 116166 RVA: 0x004021A7 File Offset: 0x004003A7
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C5C7 RID: 116167 RVA: 0x004021B6 File Offset: 0x004003B6
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601C5C8 RID: 116168 RVA: 0x004021C4 File Offset: 0x004003C4
		public static Offset<IRollBlockGridTemplate> CreateIRollBlockGridTemplate(FlatBufferBuilder builder, ERollBlockGridType GridType = ERollBlockGridType.Empty, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRollBlockGridTemplate.AddTemplateId(builder, TemplateIdOffset);
			IRollBlockGridTemplate.AddGridType(builder, GridType);
			return IRollBlockGridTemplate.EndIRollBlockGridTemplate(builder);
		}

		// Token: 0x0601C5C9 RID: 116169 RVA: 0x004021E1 File Offset: 0x004003E1
		public static void StartIRollBlockGridTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C5CA RID: 116170 RVA: 0x004021EA File Offset: 0x004003EA
		public static void AddGridType(FlatBufferBuilder builder, ERollBlockGridType gridType)
		{
			builder.AddByte(0, (byte)gridType, 0);
		}

		// Token: 0x0601C5CB RID: 116171 RVA: 0x004021F5 File Offset: 0x004003F5
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0601C5CC RID: 116172 RVA: 0x00402205 File Offset: 0x00400405
		public static Offset<IRollBlockGridTemplate> EndIRollBlockGridTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGridTemplate>(builder.EndTable());
		}

		// Token: 0x0601C5CD RID: 116173 RVA: 0x00402214 File Offset: 0x00400414
		public IRollBlockGridTemplateT UnPack()
		{
			IRollBlockGridTemplateT rollBlockGridTemplateT = new IRollBlockGridTemplateT();
			this.UnPackTo(rollBlockGridTemplateT);
			return rollBlockGridTemplateT;
		}

		// Token: 0x0601C5CE RID: 116174 RVA: 0x0040222F File Offset: 0x0040042F
		public void UnPackTo(IRollBlockGridTemplateT _o)
		{
			_o.GridType = this.GridType;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0601C5CF RID: 116175 RVA: 0x0040224C File Offset: 0x0040044C
		public static Offset<IRollBlockGridTemplate> Pack(FlatBufferBuilder builder, IRollBlockGridTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGridTemplate>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IRollBlockGridTemplate.CreateIRollBlockGridTemplate(builder, _o.GridType, templateIdOffset);
		}

		// Token: 0x0400D062 RID: 53346
		private Table __p;
	}
}
