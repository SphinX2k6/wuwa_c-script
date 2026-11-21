using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC6 RID: 4038
	public struct PhantomCollectTaskDesc : IFlatbufferObject
	{
		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x0600AE58 RID: 44632 RVA: 0x002CF662 File Offset: 0x002CD862
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x002CF66F File Offset: 0x002CD86F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x002CF678 File Offset: 0x002CD878
		public static PhantomCollectTaskDesc GetRootAsPhantomCollectTaskDesc(ByteBuffer _bb)
		{
			return PhantomCollectTaskDesc.GetRootAsPhantomCollectTaskDesc(_bb, default(PhantomCollectTaskDesc));
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x002CF694 File Offset: 0x002CD894
		public static PhantomCollectTaskDesc GetRootAsPhantomCollectTaskDesc(ByteBuffer _bb, PhantomCollectTaskDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x002CF6B1 File Offset: 0x002CD8B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x002CF6C0 File Offset: 0x002CD8C0
		public PhantomCollectTaskDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x0600AE5E RID: 44638 RVA: 0x002CF6D0 File Offset: 0x002CD8D0
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

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x002CF70C File Offset: 0x002CD90C
		public string Title
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

		// Token: 0x0600AE60 RID: 44640 RVA: 0x002CF743 File Offset: 0x002CD943
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AE61 RID: 44641 RVA: 0x002CF752 File Offset: 0x002CD952
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x0600AE62 RID: 44642 RVA: 0x002CF76C File Offset: 0x002CD96C
		public string Desc
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

		// Token: 0x0600AE63 RID: 44643 RVA: 0x002CF7A3 File Offset: 0x002CD9A3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x002CF7B2 File Offset: 0x002CD9B2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AE65 RID: 44645 RVA: 0x002CF7CC File Offset: 0x002CD9CC
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x0600AE66 RID: 44646 RVA: 0x002CF830 File Offset: 0x002CDA30
		public int JumpToLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AE67 RID: 44647 RVA: 0x002CF85C File Offset: 0x002CDA5C
		[NullableContext(1)]
		public Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600AE68 RID: 44648 RVA: 0x002CF8B2 File Offset: 0x002CDAB2
		[NullableContext(1)]
		public IEnumerable<DicIntString> JumpToIter()
		{
			PhantomCollectTaskDesc.<JumpToIter>d__22 <JumpToIter>d__ = new PhantomCollectTaskDesc.<JumpToIter>d__22(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x0600AE69 RID: 44649 RVA: 0x002CF8C8 File Offset: 0x002CDAC8
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

		// Token: 0x0600AE6A RID: 44650 RVA: 0x002CF8F0 File Offset: 0x002CDAF0
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600AE6B RID: 44651 RVA: 0x002CF956 File Offset: 0x002CDB56
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetJumpToFrozenDict()
		{
			this.EnsureJumpToCacheIfNeeded();
			return this.JumpToCache;
		}

		// Token: 0x04005586 RID: 21894
		private Table __p;

		// Token: 0x04005587 RID: 21895
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
