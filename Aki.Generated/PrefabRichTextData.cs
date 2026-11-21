using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001037 RID: 4151
	public struct PrefabRichTextData : IFlatbufferObject
	{
		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x002E650D File Offset: 0x002E470D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8BC RID: 47292 RVA: 0x002E651A File Offset: 0x002E471A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8BD RID: 47293 RVA: 0x002E6524 File Offset: 0x002E4724
		public static PrefabRichTextData GetRootAsPrefabRichTextData(ByteBuffer _bb)
		{
			return PrefabRichTextData.GetRootAsPrefabRichTextData(_bb, default(PrefabRichTextData));
		}

		// Token: 0x0600B8BE RID: 47294 RVA: 0x002E6540 File Offset: 0x002E4740
		public static PrefabRichTextData GetRootAsPrefabRichTextData(ByteBuffer _bb, PrefabRichTextData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8BF RID: 47295 RVA: 0x002E655D File Offset: 0x002E475D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x002E656C File Offset: 0x002E476C
		public PrefabRichTextData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0600B8C1 RID: 47297 RVA: 0x002E657C File Offset: 0x002E477C
		public string Id
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

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x002E65B3 File Offset: 0x002E47B3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x002E65C2 File Offset: 0x002E47C2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x002E65DC File Offset: 0x002E47DC
		public bool IsIncludeRichText
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0600B8C5 RID: 47301 RVA: 0x002E661C File Offset: 0x002E481C
		public bool IsIncludeGameText
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005604 RID: 22020
		private Table __p;
	}
}
