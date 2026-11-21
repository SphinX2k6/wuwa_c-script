using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001317 RID: 4887
	public struct SkillDescribeStruct : IFlatbufferObject
	{
		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x0600F8E6 RID: 63718 RVA: 0x00375119 File Offset: 0x00373319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F8E7 RID: 63719 RVA: 0x00375126 File Offset: 0x00373326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F8E8 RID: 63720 RVA: 0x00375130 File Offset: 0x00373330
		public static SkillDescribeStruct GetRootAsSkillDescribeStruct(ByteBuffer _bb)
		{
			return SkillDescribeStruct.GetRootAsSkillDescribeStruct(_bb, default(SkillDescribeStruct));
		}

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x0037514C File Offset: 0x0037334C
		public static SkillDescribeStruct GetRootAsSkillDescribeStruct(ByteBuffer _bb, SkillDescribeStruct obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x00375169 File Offset: 0x00373369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x00375178 File Offset: 0x00373378
		public SkillDescribeStruct __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x0600F8EC RID: 63724 RVA: 0x00375188 File Offset: 0x00373388
		public string Title
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F8ED RID: 63725 RVA: 0x003751BF File Offset: 0x003733BF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F8EE RID: 63726 RVA: 0x003751CE File Offset: 0x003733CE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x0600F8EF RID: 63727 RVA: 0x003751E8 File Offset: 0x003733E8
		public string Content
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

		// Token: 0x0600F8F0 RID: 63728 RVA: 0x0037521F File Offset: 0x0037341F
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F8F1 RID: 63729 RVA: 0x0037522E File Offset: 0x0037342E
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400599D RID: 22941
		private Table __p;
	}
}
