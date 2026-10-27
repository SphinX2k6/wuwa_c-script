using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200459F RID: 17823
	public struct IRollBlockItemTemplate : IFlatbufferObject
	{
		// Token: 0x17007EA1 RID: 32417
		// (get) Token: 0x0601AEDD RID: 110301 RVA: 0x003D75BE File Offset: 0x003D57BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AEDE RID: 110302 RVA: 0x003D75CB File Offset: 0x003D57CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AEDF RID: 110303 RVA: 0x003D75D4 File Offset: 0x003D57D4
		public static IRollBlockItemTemplate GetRootAsIRollBlockItemTemplate(ByteBuffer _bb)
		{
			return IRollBlockItemTemplate.GetRootAsIRollBlockItemTemplate(_bb, default(IRollBlockItemTemplate));
		}

		// Token: 0x0601AEE0 RID: 110304 RVA: 0x003D75F0 File Offset: 0x003D57F0
		public static IRollBlockItemTemplate GetRootAsIRollBlockItemTemplate(ByteBuffer _bb, IRollBlockItemTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AEE1 RID: 110305 RVA: 0x003D760D File Offset: 0x003D580D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AEE2 RID: 110306 RVA: 0x003D761C File Offset: 0x003D581C
		public IRollBlockItemTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EA2 RID: 32418
		// (get) Token: 0x0601AEE3 RID: 110307 RVA: 0x003D762C File Offset: 0x003D582C
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

		// Token: 0x17007EA3 RID: 32419
		// (get) Token: 0x0601AEE4 RID: 110308 RVA: 0x003D7668 File Offset: 0x003D5868
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

		// Token: 0x0601AEE5 RID: 110309 RVA: 0x003D769F File Offset: 0x003D589F
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601AEE6 RID: 110310 RVA: 0x003D76AE File Offset: 0x003D58AE
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601AEE7 RID: 110311 RVA: 0x003D76BC File Offset: 0x003D58BC
		public static Offset<IRollBlockItemTemplate> CreateIRollBlockItemTemplate(FlatBufferBuilder builder, ERollBlockItemType ItemType = ERollBlockItemType.BreakableObstacle, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRollBlockItemTemplate.AddTemplateId(builder, TemplateIdOffset);
			IRollBlockItemTemplate.AddItemType(builder, ItemType);
			return IRollBlockItemTemplate.EndIRollBlockItemTemplate(builder);
		}

		// Token: 0x0601AEE8 RID: 110312 RVA: 0x003D76D9 File Offset: 0x003D58D9
		public static void StartIRollBlockItemTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AEE9 RID: 110313 RVA: 0x003D76E2 File Offset: 0x003D58E2
		public static void AddItemType(FlatBufferBuilder builder, ERollBlockItemType itemType)
		{
			builder.AddByte(0, (byte)itemType, 0);
		}

		// Token: 0x0601AEEA RID: 110314 RVA: 0x003D76ED File Offset: 0x003D58ED
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0601AEEB RID: 110315 RVA: 0x003D76FD File Offset: 0x003D58FD
		public static Offset<IRollBlockItemTemplate> EndIRollBlockItemTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemTemplate>(builder.EndTable());
		}

		// Token: 0x0601AEEC RID: 110316 RVA: 0x003D770C File Offset: 0x003D590C
		public IRollBlockItemTemplateT UnPack()
		{
			IRollBlockItemTemplateT rollBlockItemTemplateT = new IRollBlockItemTemplateT();
			this.UnPackTo(rollBlockItemTemplateT);
			return rollBlockItemTemplateT;
		}

		// Token: 0x0601AEED RID: 110317 RVA: 0x003D7727 File Offset: 0x003D5927
		public void UnPackTo(IRollBlockItemTemplateT _o)
		{
			_o.ItemType = this.ItemType;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0601AEEE RID: 110318 RVA: 0x003D7744 File Offset: 0x003D5944
		public static Offset<IRollBlockItemTemplate> Pack(FlatBufferBuilder builder, IRollBlockItemTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemTemplate>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IRollBlockItemTemplate.CreateIRollBlockItemTemplate(builder, _o.ItemType, templateIdOffset);
		}

		// Token: 0x0400C661 RID: 50785
		private Table __p;
	}
}
