using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE1 RID: 3809
	public struct PhantomCollectTaskDesc : IFlatbufferObject
	{
		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x0600A837 RID: 43063 RVA: 0x002B25FA File Offset: 0x002B07FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x002B2607 File Offset: 0x002B0807
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x002B2610 File Offset: 0x002B0810
		public static PhantomCollectTaskDesc GetRootAsPhantomCollectTaskDesc(ByteBuffer _bb)
		{
			return PhantomCollectTaskDesc.GetRootAsPhantomCollectTaskDesc(_bb, default(PhantomCollectTaskDesc));
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x002B262C File Offset: 0x002B082C
		public static PhantomCollectTaskDesc GetRootAsPhantomCollectTaskDesc(ByteBuffer _bb, PhantomCollectTaskDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x002B2649 File Offset: 0x002B0849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x002B2658 File Offset: 0x002B0858
		public PhantomCollectTaskDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x0600A83D RID: 43069 RVA: 0x002B2668 File Offset: 0x002B0868
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

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x0600A83E RID: 43070 RVA: 0x002B26A4 File Offset: 0x002B08A4
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

		// Token: 0x0600A83F RID: 43071 RVA: 0x002B26DB File Offset: 0x002B08DB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x002B26EA File Offset: 0x002B08EA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x002B2704 File Offset: 0x002B0904
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

		// Token: 0x0600A842 RID: 43074 RVA: 0x002B273B File Offset: 0x002B093B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x002B274A File Offset: 0x002B094A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x002B2764 File Offset: 0x002B0964
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x002B27C8 File Offset: 0x002B09C8
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

		// Token: 0x0600A846 RID: 43078 RVA: 0x002B27F4 File Offset: 0x002B09F4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用JumpToFrozenDict()缓存字典，遍历请使用JumpToIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x002B284A File Offset: 0x002B0A4A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> JumpToIter()
		{
			PhantomCollectTaskDesc.<JumpToIter>d__22 <JumpToIter>d__ = new PhantomCollectTaskDesc.<JumpToIter>d__22(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x0600A848 RID: 43080 RVA: 0x002B2860 File Offset: 0x002B0A60
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

		// Token: 0x0600A849 RID: 43081 RVA: 0x002B2888 File Offset: 0x002B0A88
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600A84A RID: 43082 RVA: 0x002B28EE File Offset: 0x002B0AEE
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

		// Token: 0x04004FA1 RID: 20385
		private Table __p;

		// Token: 0x04004FA2 RID: 20386
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
