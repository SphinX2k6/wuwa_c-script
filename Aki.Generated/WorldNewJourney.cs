using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A6 RID: 4518
	public struct WorldNewJourney : IFlatbufferObject
	{
		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600E935 RID: 59701 RVA: 0x00345969 File Offset: 0x00343B69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E936 RID: 59702 RVA: 0x00345976 File Offset: 0x00343B76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E937 RID: 59703 RVA: 0x00345980 File Offset: 0x00343B80
		public static WorldNewJourney GetRootAsWorldNewJourney(ByteBuffer _bb)
		{
			return WorldNewJourney.GetRootAsWorldNewJourney(_bb, default(WorldNewJourney));
		}

		// Token: 0x0600E938 RID: 59704 RVA: 0x0034599C File Offset: 0x00343B9C
		public static WorldNewJourney GetRootAsWorldNewJourney(ByteBuffer _bb, WorldNewJourney obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E939 RID: 59705 RVA: 0x003459B9 File Offset: 0x00343BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E93A RID: 59706 RVA: 0x003459C8 File Offset: 0x00343BC8
		public WorldNewJourney __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600E93B RID: 59707 RVA: 0x003459D8 File Offset: 0x00343BD8
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

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0600E93C RID: 59708 RVA: 0x00345A14 File Offset: 0x00343C14
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0600E93D RID: 59709 RVA: 0x00345A54 File Offset: 0x00343C54
		public int SourceType
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

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x0600E93E RID: 59710 RVA: 0x00345A90 File Offset: 0x00343C90
		public int SourceId
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

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0600E93F RID: 59711 RVA: 0x00345AD0 File Offset: 0x00343CD0
		public string SourceTitle
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

		// Token: 0x0600E940 RID: 59712 RVA: 0x00345B08 File Offset: 0x00343D08
		public Span<byte> GetSourceTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E941 RID: 59713 RVA: 0x00345B18 File Offset: 0x00343D18
		public byte[] GetSourceTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0600E942 RID: 59714 RVA: 0x00345B30 File Offset: 0x00343D30
		public string SourceDesc
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

		// Token: 0x0600E943 RID: 59715 RVA: 0x00345B68 File Offset: 0x00343D68
		public Span<byte> GetSourceDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E944 RID: 59716 RVA: 0x00345B78 File Offset: 0x00343D78
		public byte[] GetSourceDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x0600E945 RID: 59717 RVA: 0x00345B90 File Offset: 0x00343D90
		public int ConditionId
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

		// Token: 0x0600E946 RID: 59718 RVA: 0x00345BD0 File Offset: 0x00343DD0
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0600E947 RID: 59719 RVA: 0x00345C34 File Offset: 0x00343E34
		public int JumpToLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E948 RID: 59720 RVA: 0x00345C60 File Offset: 0x00343E60
		[NullableContext(1)]
		[Obsolete("已废弃，请使用JumpToFrozenDict()缓存字典，遍历请使用JumpToIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600E949 RID: 59721 RVA: 0x00345CB6 File Offset: 0x00343EB6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> JumpToIter()
		{
			WorldNewJourney.<JumpToIter>d__30 <JumpToIter>d__ = new WorldNewJourney.<JumpToIter>d__30(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x0600E94A RID: 59722 RVA: 0x00345CCC File Offset: 0x00343ECC
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

		// Token: 0x0600E94B RID: 59723 RVA: 0x00345CF4 File Offset: 0x00343EF4
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600E94C RID: 59724 RVA: 0x00345D5A File Offset: 0x00343F5A
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

		// Token: 0x040052F2 RID: 21234
		private Table __p;

		// Token: 0x040052F3 RID: 21235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
