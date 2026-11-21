using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001257 RID: 4695
	public struct TermExplanationViewStyle : IFlatbufferObject
	{
		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0600EB19 RID: 60185 RVA: 0x00356986 File Offset: 0x00354B86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x00356993 File Offset: 0x00354B93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x0035699C File Offset: 0x00354B9C
		public static TermExplanationViewStyle GetRootAsTermExplanationViewStyle(ByteBuffer _bb)
		{
			return TermExplanationViewStyle.GetRootAsTermExplanationViewStyle(_bb, default(TermExplanationViewStyle));
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x003569B8 File Offset: 0x00354BB8
		public static TermExplanationViewStyle GetRootAsTermExplanationViewStyle(ByteBuffer _bb, TermExplanationViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB1D RID: 60189 RVA: 0x003569D5 File Offset: 0x00354BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB1E RID: 60190 RVA: 0x003569E4 File Offset: 0x00354BE4
		public TermExplanationViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x0600EB1F RID: 60191 RVA: 0x003569F4 File Offset: 0x00354BF4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0600EB20 RID: 60192 RVA: 0x00356A30 File Offset: 0x00354C30
		public string SideView
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

		// Token: 0x0600EB21 RID: 60193 RVA: 0x00356A67 File Offset: 0x00354C67
		public Span<byte> GetSideViewBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EB22 RID: 60194 RVA: 0x00356A76 File Offset: 0x00354C76
		public byte[] GetSideViewArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x0600EB23 RID: 60195 RVA: 0x00356A90 File Offset: 0x00354C90
		public string CenterView
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

		// Token: 0x0600EB24 RID: 60196 RVA: 0x00356AC7 File Offset: 0x00354CC7
		public Span<byte> GetCenterViewBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EB25 RID: 60197 RVA: 0x00356AD6 File Offset: 0x00354CD6
		public byte[] GetCenterViewArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040058A1 RID: 22689
		private Table __p;
	}
}
