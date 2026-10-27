using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD3 RID: 2771
	public struct AdventureTask : IFlatbufferObject
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06004456 RID: 17494 RVA: 0x001CE255 File Offset: 0x001CC455
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x001CE262 File Offset: 0x001CC462
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x001CE26C File Offset: 0x001CC46C
		public static AdventureTask GetRootAsAdventureTask(ByteBuffer _bb)
		{
			return AdventureTask.GetRootAsAdventureTask(_bb, default(AdventureTask));
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x001CE288 File Offset: 0x001CC488
		public static AdventureTask GetRootAsAdventureTask(ByteBuffer _bb, AdventureTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x001CE2A5 File Offset: 0x001CC4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x001CE2B4 File Offset: 0x001CC4B4
		public AdventureTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x001CE2C4 File Offset: 0x001CC4C4
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x001CE300 File Offset: 0x001CC500
		public int ChapterId
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x001CE33C File Offset: 0x001CC53C
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

		// Token: 0x0600445F RID: 17503 RVA: 0x001CE373 File Offset: 0x001CC573
		public Span<byte> GetTaskTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x001CE382 File Offset: 0x001CC582
		public byte[] GetTaskTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x001CE39C File Offset: 0x001CC59C
		public int RecordId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x001CE3DC File Offset: 0x001CC5DC
		public int RecordIdLength
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

		// Token: 0x06004463 RID: 17507 RVA: 0x001CE408 File Offset: 0x001CC608
		public Span<int> GetRecordIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x001CE418 File Offset: 0x001CC618
		public int[] GetRecordIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x001CE430 File Offset: 0x001CC630
		public int NeedProgress
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x001CE470 File Offset: 0x001CC670
		public int DropIds
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

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x001CE4B0 File Offset: 0x001CC6B0
		public int PathId
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

		// Token: 0x06004468 RID: 17512 RVA: 0x001CE4F0 File Offset: 0x001CC6F0
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x001CE554 File Offset: 0x001CC754
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

		// Token: 0x0600446A RID: 17514 RVA: 0x001CE580 File Offset: 0x001CC780
		[NullableContext(1)]
		[Obsolete("已废弃，请使用JumpToFrozenDict()缓存字典，遍历请使用JumpToIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x001CE5D6 File Offset: 0x001CC7D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> JumpToIter()
		{
			AdventureTask.<JumpToIter>d__31 <JumpToIter>d__ = new AdventureTask.<JumpToIter>d__31(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x001CE5EC File Offset: 0x001CC7EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecordIdIter()或GetRecordIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecordId()
		{
			AdventureTask adventureTask = this;
			return adventureTask.GetRecordIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x001CE610 File Offset: 0x001CC810
		[NullableContext(1)]
		public readonly IEnumerable<int> RecordIdIter()
		{
			AdventureTask.<RecordIdIter>d__33 <RecordIdIter>d__ = new AdventureTask.<RecordIdIter>d__33(-2);
			<RecordIdIter>d__.<>3__<>4__this = this;
			return <RecordIdIter>d__;
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x001CE628 File Offset: 0x001CC828
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

		// Token: 0x0600446F RID: 17519 RVA: 0x001CE650 File Offset: 0x001CC850
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x001CE6B6 File Offset: 0x001CC8B6
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

		// Token: 0x04004AB0 RID: 19120
		private Table __p;

		// Token: 0x04004AB1 RID: 19121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
