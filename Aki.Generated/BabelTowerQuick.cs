using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B23 RID: 2851
	public struct BabelTowerQuick : IFlatbufferObject
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06004B43 RID: 19267 RVA: 0x001DE098 File Offset: 0x001DC298
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x001DE0A5 File Offset: 0x001DC2A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x001DE0AC File Offset: 0x001DC2AC
		public static BabelTowerQuick GetRootAsBabelTowerQuick(ByteBuffer _bb)
		{
			return BabelTowerQuick.GetRootAsBabelTowerQuick(_bb, default(BabelTowerQuick));
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x001DE0C8 File Offset: 0x001DC2C8
		public static BabelTowerQuick GetRootAsBabelTowerQuick(ByteBuffer _bb, BabelTowerQuick obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x001DE0E5 File Offset: 0x001DC2E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x001DE0F4 File Offset: 0x001DC2F4
		public BabelTowerQuick __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x001DE104 File Offset: 0x001DC304
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x001DE140 File Offset: 0x001DC340
		public int InstId
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x001DE17C File Offset: 0x001DC37C
		public int ActivityId
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

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x001DE1B8 File Offset: 0x001DC3B8
		public string Des
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

		// Token: 0x06004B4D RID: 19277 RVA: 0x001DE1F0 File Offset: 0x001DC3F0
		public Span<byte> GetDesBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x001DE200 File Offset: 0x001DC400
		public byte[] GetDesArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06004B4F RID: 19279 RVA: 0x001DE218 File Offset: 0x001DC418
		public string DifficultyTextKey
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

		// Token: 0x06004B50 RID: 19280 RVA: 0x001DE250 File Offset: 0x001DC450
		public Span<byte> GetDifficultyTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x001DE260 File Offset: 0x001DC460
		public byte[] GetDifficultyTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06004B52 RID: 19282 RVA: 0x001DE278 File Offset: 0x001DC478
		public int QuickSelect
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

		// Token: 0x06004B53 RID: 19283 RVA: 0x001DE2B8 File Offset: 0x001DC4B8
		public int BuffGroup(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06004B54 RID: 19284 RVA: 0x001DE2F8 File Offset: 0x001DC4F8
		public int BuffGroupLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x001DE324 File Offset: 0x001DC524
		public Span<int> GetBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x001DE334 File Offset: 0x001DC534
		public int[] GetBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x001DE34C File Offset: 0x001DC54C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffGroupIter()或GetBuffGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffGroup()
		{
			BabelTowerQuick babelTowerQuick = this;
			return babelTowerQuick.GetBuffGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x001DE370 File Offset: 0x001DC570
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffGroupIter()
		{
			BabelTowerQuick.<BuffGroupIter>d__30 <BuffGroupIter>d__ = new BabelTowerQuick.<BuffGroupIter>d__30(-2);
			<BuffGroupIter>d__.<>3__<>4__this = this;
			return <BuffGroupIter>d__;
		}

		// Token: 0x04004B15 RID: 19221
		private Table __p;
	}
}
