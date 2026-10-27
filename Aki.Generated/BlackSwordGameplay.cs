using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3A RID: 2874
	public struct BlackSwordGameplay : IFlatbufferObject
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06004DC3 RID: 19907 RVA: 0x001E4B2D File Offset: 0x001E2D2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x001E4B3A File Offset: 0x001E2D3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x001E4B44 File Offset: 0x001E2D44
		public static BlackSwordGameplay GetRootAsBlackSwordGameplay(ByteBuffer _bb)
		{
			return BlackSwordGameplay.GetRootAsBlackSwordGameplay(_bb, default(BlackSwordGameplay));
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x001E4B60 File Offset: 0x001E2D60
		public static BlackSwordGameplay GetRootAsBlackSwordGameplay(ByteBuffer _bb, BlackSwordGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x001E4B7D File Offset: 0x001E2D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x001E4B8C File Offset: 0x001E2D8C
		public BlackSwordGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06004DC9 RID: 19913 RVA: 0x001E4B9C File Offset: 0x001E2D9C
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

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x001E4BD8 File Offset: 0x001E2DD8
		public int UIConfigId
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06004DCB RID: 19915 RVA: 0x001E4C14 File Offset: 0x001E2E14
		public string TitleText
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

		// Token: 0x06004DCC RID: 19916 RVA: 0x001E4C4B File Offset: 0x001E2E4B
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x001E4C5A File Offset: 0x001E2E5A
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x001E4C74 File Offset: 0x001E2E74
		public string GoalText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x001E4CAC File Offset: 0x001E2EAC
		public Span<byte> GetGoalTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x001E4CBC File Offset: 0x001E2EBC
		public byte[] GetGoalTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x001E4CD4 File Offset: 0x001E2ED4
		public string MapGoalText
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

		// Token: 0x06004DD2 RID: 19922 RVA: 0x001E4D0C File Offset: 0x001E2F0C
		public Span<byte> GetMapGoalTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x001E4D1C File Offset: 0x001E2F1C
		public byte[] GetMapGoalTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x001E4D34 File Offset: 0x001E2F34
		public string RuleText
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

		// Token: 0x06004DD5 RID: 19925 RVA: 0x001E4D6C File Offset: 0x001E2F6C
		public Span<byte> GetRuleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x001E4D7C File Offset: 0x001E2F7C
		public byte[] GetRuleTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B35 RID: 19253
		private Table __p;
	}
}
