using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD6 RID: 2774
	public struct AdventureTaskV2 : IFlatbufferObject
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x001CEC95 File Offset: 0x001CCE95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x001CECA2 File Offset: 0x001CCEA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x001CECAC File Offset: 0x001CCEAC
		public static AdventureTaskV2 GetRootAsAdventureTaskV2(ByteBuffer _bb)
		{
			return AdventureTaskV2.GetRootAsAdventureTaskV2(_bb, default(AdventureTaskV2));
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x001CECC8 File Offset: 0x001CCEC8
		public static AdventureTaskV2 GetRootAsAdventureTaskV2(ByteBuffer _bb, AdventureTaskV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x001CECE5 File Offset: 0x001CCEE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x001CECF4 File Offset: 0x001CCEF4
		public AdventureTaskV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x001CED04 File Offset: 0x001CCF04
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x001CED40 File Offset: 0x001CCF40
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x001CED7C File Offset: 0x001CCF7C
		public string TaskText
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

		// Token: 0x060044A3 RID: 17571 RVA: 0x001CEDB3 File Offset: 0x001CCFB3
		public Span<byte> GetTaskTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x001CEDC2 File Offset: 0x001CCFC2
		public byte[] GetTaskTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x001CEDDC File Offset: 0x001CCFDC
		public int ChapterId
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x001CEE1C File Offset: 0x001CD01C
		public int DropId
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

		// Token: 0x060044A7 RID: 17575 RVA: 0x001CEE5C File Offset: 0x001CD05C
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x001CEEC0 File Offset: 0x001CD0C0
		public int JumpToLength
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x001CEEEC File Offset: 0x001CD0EC
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x001CEF2C File Offset: 0x001CD12C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用JumpToFrozenDict()缓存字典，遍历请使用JumpToIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x001CEF82 File Offset: 0x001CD182
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> JumpToIter()
		{
			AdventureTaskV2.<JumpToIter>d__26 <JumpToIter>d__ = new AdventureTaskV2.<JumpToIter>d__26(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x001CEF98 File Offset: 0x001CD198
		[NullableContext(2)]
		public string GetJumpTo(int key)
		{
			this.EnsureJumpToCacheIfNeeded();
			string result;
			if (!this.JumpToCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x001CEFC0 File Offset: 0x001CD1C0
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x001CF026 File Offset: 0x001CD226
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetJumpToFrozenDict(int key)
		{
			this.EnsureJumpToCacheIfNeeded();
			return this.JumpToCache;
		}

		// Token: 0x04004AB4 RID: 19124
		private Table __p;

		// Token: 0x04004AB5 RID: 19125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
