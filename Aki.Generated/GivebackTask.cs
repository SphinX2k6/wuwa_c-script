using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D03 RID: 3331
	public struct GivebackTask : IFlatbufferObject
	{
		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06007AF5 RID: 31477 RVA: 0x0024C4E5 File Offset: 0x0024A6E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x0024C4F2 File Offset: 0x0024A6F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x0024C4FC File Offset: 0x0024A6FC
		public static GivebackTask GetRootAsGivebackTask(ByteBuffer _bb)
		{
			return GivebackTask.GetRootAsGivebackTask(_bb, default(GivebackTask));
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x0024C518 File Offset: 0x0024A718
		public static GivebackTask GetRootAsGivebackTask(ByteBuffer _bb, GivebackTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x0024C535 File Offset: 0x0024A735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x0024C544 File Offset: 0x0024A744
		public GivebackTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06007AFB RID: 31483 RVA: 0x0024C554 File Offset: 0x0024A754
		public int TaskId
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

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06007AFC RID: 31484 RVA: 0x0024C590 File Offset: 0x0024A790
		public string TaskName
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

		// Token: 0x06007AFD RID: 31485 RVA: 0x0024C5C7 File Offset: 0x0024A7C7
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x0024C5D6 File Offset: 0x0024A7D6
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06007AFF RID: 31487 RVA: 0x0024C5F0 File Offset: 0x0024A7F0
		public string TaskDes
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

		// Token: 0x06007B00 RID: 31488 RVA: 0x0024C627 File Offset: 0x0024A827
		public Span<byte> GetTaskDesBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x0024C636 File Offset: 0x0024A836
		public byte[] GetTaskDesArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06007B02 RID: 31490 RVA: 0x0024C650 File Offset: 0x0024A850
		public int SortId
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

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06007B03 RID: 31491 RVA: 0x0024C690 File Offset: 0x0024A890
		public int HelpBtn
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

		// Token: 0x06007B04 RID: 31492 RVA: 0x0024C6D0 File Offset: 0x0024A8D0
		public int Param(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06007B05 RID: 31493 RVA: 0x0024C710 File Offset: 0x0024A910
		public int ParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x0024C73C File Offset: 0x0024A93C
		public Span<int> GetParamBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x0024C74C File Offset: 0x0024A94C
		public int[] GetParamArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x0024C764 File Offset: 0x0024A964
		public int MaxScore
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

		// Token: 0x06007B09 RID: 31497 RVA: 0x0024C7A4 File Offset: 0x0024A9A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamIter()或GetParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Param()
		{
			GivebackTask givebackTask = this;
			return givebackTask.GetParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x0024C7C8 File Offset: 0x0024A9C8
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamIter()
		{
			GivebackTask.<ParamIter>d__30 <ParamIter>d__ = new GivebackTask.<ParamIter>d__30(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x04004D79 RID: 19833
		private Table __p;
	}
}
