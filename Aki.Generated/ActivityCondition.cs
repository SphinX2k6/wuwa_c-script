using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B99 RID: 2969
	public struct ActivityCondition : IFlatbufferObject
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x001EB26C File Offset: 0x001E946C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x001EB279 File Offset: 0x001E9479
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x001EB280 File Offset: 0x001E9480
		public static ActivityCondition GetRootAsActivityCondition(ByteBuffer _bb)
		{
			return ActivityCondition.GetRootAsActivityCondition(_bb, default(ActivityCondition));
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x001EB29C File Offset: 0x001E949C
		public static ActivityCondition GetRootAsActivityCondition(ByteBuffer _bb, ActivityCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x001EB2B9 File Offset: 0x001E94B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x001EB2C8 File Offset: 0x001E94C8
		public ActivityCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x001EB2D8 File Offset: 0x001E94D8
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x001EB314 File Offset: 0x001E9514
		public int Type
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

		// Token: 0x06004854 RID: 18516 RVA: 0x001EB350 File Offset: 0x001E9550
		public DicStringString? Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x001EB3B0 File Offset: 0x001E95B0
		public int ParamsLength
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06004856 RID: 18518 RVA: 0x001EB3DC File Offset: 0x001E95DC
		public string Description
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

		// Token: 0x06004857 RID: 18519 RVA: 0x001EB414 File Offset: 0x001E9614
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x001EB424 File Offset: 0x001E9624
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x001EB43C File Offset: 0x001E963C
		[NullableContext(1)]
		public Dictionary<string, string> Params()
		{
			return this.ParamsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x001EB492 File Offset: 0x001E9692
		[NullableContext(1)]
		public IEnumerable<DicStringString> ParamsIter()
		{
			ActivityCondition.<ParamsIter>d__20 <ParamsIter>d__ = new ActivityCondition.<ParamsIter>d__20(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x001EB4A8 File Offset: 0x001E96A8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParams(string key)
		{
			this.EnsureParamsCacheIfNeeded();
			string result;
			if (!this.ParamsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x001EB4D0 File Offset: 0x001E96D0
		private void EnsureParamsCacheIfNeeded()
		{
			if (this.ParamsCache != null)
			{
				return;
			}
			this.ParamsCache = this.ParamsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x001EB536 File Offset: 0x001E9736
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParamsFrozenDict()
		{
			this.EnsureParamsCacheIfNeeded();
			return this.ParamsCache;
		}

		// Token: 0x04005074 RID: 20596
		private Table __p;

		// Token: 0x04005075 RID: 20597
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ParamsCache;
	}
}
