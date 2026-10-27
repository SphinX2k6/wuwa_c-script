using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B19 RID: 2841
	public struct AxisRevert : IFlatbufferObject
	{
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06004A5A RID: 19034 RVA: 0x001DBF22 File Offset: 0x001DA122
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x001DBF2F File Offset: 0x001DA12F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x001DBF38 File Offset: 0x001DA138
		public static AxisRevert GetRootAsAxisRevert(ByteBuffer _bb)
		{
			return AxisRevert.GetRootAsAxisRevert(_bb, default(AxisRevert));
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x001DBF54 File Offset: 0x001DA154
		public static AxisRevert GetRootAsAxisRevert(ByteBuffer _bb, AxisRevert obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x001DBF71 File Offset: 0x001DA171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x001DBF80 File Offset: 0x001DA180
		public AxisRevert __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06004A60 RID: 19040 RVA: 0x001DBF90 File Offset: 0x001DA190
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

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x001DBFCC File Offset: 0x001DA1CC
		public int RevertType
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

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06004A62 RID: 19042 RVA: 0x001DC008 File Offset: 0x001DA208
		public string AxisName
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

		// Token: 0x06004A63 RID: 19043 RVA: 0x001DC03F File Offset: 0x001DA23F
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x001DC04E File Offset: 0x001DA24E
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x001DC068 File Offset: 0x001DA268
		public DicStringInt? RevertInfo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06004A66 RID: 19046 RVA: 0x001DC0CC File Offset: 0x001DA2CC
		public int RevertInfoLength
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

		// Token: 0x06004A67 RID: 19047 RVA: 0x001DC0F8 File Offset: 0x001DA2F8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RevertInfoFrozenDict()缓存字典，遍历请使用RevertInfoIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> RevertInfo()
		{
			return this.RevertInfoIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x001DC14E File Offset: 0x001DA34E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringInt> RevertInfoIter()
		{
			AxisRevert.<RevertInfoIter>d__20 <RevertInfoIter>d__ = new AxisRevert.<RevertInfoIter>d__20(-2);
			<RevertInfoIter>d__.<>3__<>4__this = this;
			return <RevertInfoIter>d__;
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x001DC164 File Offset: 0x001DA364
		[NullableContext(1)]
		public int? GetRevertInfo(string key)
		{
			this.EnsureRevertInfoCacheIfNeeded();
			int value;
			if (!this.RevertInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x001DC198 File Offset: 0x001DA398
		private void EnsureRevertInfoCacheIfNeeded()
		{
			if (this.RevertInfoCache != null)
			{
				return;
			}
			this.RevertInfoCache = this.RevertInfoIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x001DC1FE File Offset: 0x001DA3FE
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetRevertInfoFrozenDict(string key)
		{
			this.EnsureRevertInfoCacheIfNeeded();
			return this.RevertInfoCache;
		}

		// Token: 0x04004B07 RID: 19207
		private Table __p;

		// Token: 0x04004B08 RID: 19208
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> RevertInfoCache;
	}
}
