using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBB RID: 3771
	public struct LoadingTipsText : IFlatbufferObject
	{
		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x0600954C RID: 38220 RVA: 0x002987A8 File Offset: 0x002969A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x002987B5 File Offset: 0x002969B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x002987BC File Offset: 0x002969BC
		public static LoadingTipsText GetRootAsLoadingTipsText(ByteBuffer _bb)
		{
			return LoadingTipsText.GetRootAsLoadingTipsText(_bb, default(LoadingTipsText));
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x002987D8 File Offset: 0x002969D8
		public static LoadingTipsText GetRootAsLoadingTipsText(ByteBuffer _bb, LoadingTipsText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x002987F5 File Offset: 0x002969F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x00298804 File Offset: 0x00296A04
		public LoadingTipsText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06009552 RID: 38226 RVA: 0x00298814 File Offset: 0x00296A14
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

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06009553 RID: 38227 RVA: 0x00298850 File Offset: 0x00296A50
		public int LevelAreaId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06009554 RID: 38228 RVA: 0x0029888C File Offset: 0x00296A8C
		public int ImageId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x002988C8 File Offset: 0x00296AC8
		public int Weight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06009556 RID: 38230 RVA: 0x00298908 File Offset: 0x00296B08
		public string Title
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x00298940 File Offset: 0x00296B40
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x00298950 File Offset: 0x00296B50
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06009559 RID: 38233 RVA: 0x00298968 File Offset: 0x00296B68
		public string TipsText
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x002989A0 File Offset: 0x00296BA0
		public Span<byte> GetTipsTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x002989B0 File Offset: 0x00296BB0
		public byte[] GetTipsTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005456 RID: 21590
		private Table __p;
	}
}
