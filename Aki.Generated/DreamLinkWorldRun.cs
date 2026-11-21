using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE0 RID: 3296
	public struct DreamLinkWorldRun : IFlatbufferObject
	{
		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x0023574A File Offset: 0x0023394A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00235757 File Offset: 0x00233957
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x00235760 File Offset: 0x00233960
		public static DreamLinkWorldRun GetRootAsDreamLinkWorldRun(ByteBuffer _bb)
		{
			return DreamLinkWorldRun.GetRootAsDreamLinkWorldRun(_bb, default(DreamLinkWorldRun));
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x0023577C File Offset: 0x0023397C
		public static DreamLinkWorldRun GetRootAsDreamLinkWorldRun(ByteBuffer _bb, DreamLinkWorldRun obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00235799 File Offset: 0x00233999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x002357A8 File Offset: 0x002339A8
		public DreamLinkWorldRun __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x002357B8 File Offset: 0x002339B8
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

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x0600695C RID: 26972 RVA: 0x002357F4 File Offset: 0x002339F4
		public int ActivityId
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

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600695D RID: 26973 RVA: 0x00235830 File Offset: 0x00233A30
		public int MarkId
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

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600695E RID: 26974 RVA: 0x0023586C File Offset: 0x00233A6C
		public int MarkRange
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

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x002358AC File Offset: 0x00233AAC
		public int ConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06006960 RID: 26976 RVA: 0x002358EC File Offset: 0x00233AEC
		public string Title
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

		// Token: 0x06006961 RID: 26977 RVA: 0x00235924 File Offset: 0x00233B24
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x00235934 File Offset: 0x00233B34
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06006963 RID: 26979 RVA: 0x0023594C File Offset: 0x00233B4C
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400520F RID: 21007
		private Table __p;
	}
}
