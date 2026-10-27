using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D09 RID: 3337
	public struct GolemCrack : IFlatbufferObject
	{
		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x0024D24B File Offset: 0x0024B44B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B64 RID: 31588 RVA: 0x0024D258 File Offset: 0x0024B458
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x0024D260 File Offset: 0x0024B460
		public static GolemCrack GetRootAsGolemCrack(ByteBuffer _bb)
		{
			return GolemCrack.GetRootAsGolemCrack(_bb, default(GolemCrack));
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x0024D27C File Offset: 0x0024B47C
		public static GolemCrack GetRootAsGolemCrack(ByteBuffer _bb, GolemCrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x0024D299 File Offset: 0x0024B499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x0024D2A8 File Offset: 0x0024B4A8
		public GolemCrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06007B69 RID: 31593 RVA: 0x0024D2B8 File Offset: 0x0024B4B8
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

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06007B6A RID: 31594 RVA: 0x0024D2F4 File Offset: 0x0024B4F4
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

		// Token: 0x06007B6B RID: 31595 RVA: 0x0024D330 File Offset: 0x0024B530
		public int ConfigIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06007B6C RID: 31596 RVA: 0x0024D370 File Offset: 0x0024B570
		public int ConfigIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x0024D39B File Offset: 0x0024B59B
		public Span<int> GetConfigIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007B6E RID: 31598 RVA: 0x0024D3AA File Offset: 0x0024B5AA
		public int[] GetConfigIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x0024D3C4 File Offset: 0x0024B5C4
		public int Group
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06007B70 RID: 31600 RVA: 0x0024D404 File Offset: 0x0024B604
		public int UnlockId
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

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x0024D444 File Offset: 0x0024B644
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06007B72 RID: 31602 RVA: 0x0024D484 File Offset: 0x0024B684
		public int DropId
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

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x0024D4C4 File Offset: 0x0024B6C4
		public string Title
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x0024D4FC File Offset: 0x0024B6FC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x0024D50C File Offset: 0x0024B70C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06007B76 RID: 31606 RVA: 0x0024D524 File Offset: 0x0024B724
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x0024D55C File Offset: 0x0024B75C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x0024D56C File Offset: 0x0024B76C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x0024D584 File Offset: 0x0024B784
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConfigIdsIter()或GetConfigIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConfigIds()
		{
			GolemCrack golemCrack = this;
			return golemCrack.GetConfigIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x0024D5A8 File Offset: 0x0024B7A8
		[NullableContext(1)]
		public readonly IEnumerable<int> ConfigIdsIter()
		{
			GolemCrack.<ConfigIdsIter>d__34 <ConfigIdsIter>d__ = new GolemCrack.<ConfigIdsIter>d__34(-2);
			<ConfigIdsIter>d__.<>3__<>4__this = this;
			return <ConfigIdsIter>d__;
		}

		// Token: 0x04004D7F RID: 19839
		private Table __p;
	}
}
