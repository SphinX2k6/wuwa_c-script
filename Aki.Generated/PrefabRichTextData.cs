using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F52 RID: 3922
	public struct PrefabRichTextData : IFlatbufferObject
	{
		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x0600B29A RID: 45722 RVA: 0x002C9CC1 File Offset: 0x002C7EC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x002C9CCE File Offset: 0x002C7ECE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x002C9CD8 File Offset: 0x002C7ED8
		public static PrefabRichTextData GetRootAsPrefabRichTextData(ByteBuffer _bb)
		{
			return PrefabRichTextData.GetRootAsPrefabRichTextData(_bb, default(PrefabRichTextData));
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x002C9CF4 File Offset: 0x002C7EF4
		public static PrefabRichTextData GetRootAsPrefabRichTextData(ByteBuffer _bb, PrefabRichTextData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x002C9D11 File Offset: 0x002C7F11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x002C9D20 File Offset: 0x002C7F20
		public PrefabRichTextData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x002C9D30 File Offset: 0x002C7F30
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

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x002C9D67 File Offset: 0x002C7F67
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x002C9D76 File Offset: 0x002C7F76
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x0600B2A3 RID: 45731 RVA: 0x002C9D90 File Offset: 0x002C7F90
		public bool IsIncludeRichText
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x0600B2A4 RID: 45732 RVA: 0x002C9DD0 File Offset: 0x002C7FD0
		public bool IsIncludeGameText
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400501F RID: 20511
		private Table __p;
	}
}
