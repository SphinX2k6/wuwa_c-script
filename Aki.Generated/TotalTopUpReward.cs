using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001130 RID: 4400
	public struct TotalTopUpReward : IFlatbufferObject
	{
		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0600DF0C RID: 57100 RVA: 0x0032E59D File Offset: 0x0032C79D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF0D RID: 57101 RVA: 0x0032E5AA File Offset: 0x0032C7AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF0E RID: 57102 RVA: 0x0032E5B4 File Offset: 0x0032C7B4
		public static TotalTopUpReward GetRootAsTotalTopUpReward(ByteBuffer _bb)
		{
			return TotalTopUpReward.GetRootAsTotalTopUpReward(_bb, default(TotalTopUpReward));
		}

		// Token: 0x0600DF0F RID: 57103 RVA: 0x0032E5D0 File Offset: 0x0032C7D0
		public static TotalTopUpReward GetRootAsTotalTopUpReward(ByteBuffer _bb, TotalTopUpReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF10 RID: 57104 RVA: 0x0032E5ED File Offset: 0x0032C7ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF11 RID: 57105 RVA: 0x0032E5FC File Offset: 0x0032C7FC
		public TotalTopUpReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x0032E60C File Offset: 0x0032C80C
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

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0600DF13 RID: 57107 RVA: 0x0032E648 File Offset: 0x0032C848
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

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0600DF14 RID: 57108 RVA: 0x0032E684 File Offset: 0x0032C884
		public int PreviewFunction
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

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0600DF15 RID: 57109 RVA: 0x0032E6C0 File Offset: 0x0032C8C0
		public bool ShowPreviewIcon
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x0032E700 File Offset: 0x0032C900
		public int ShowRewardCount
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

		// Token: 0x0600DF17 RID: 57111 RVA: 0x0032E740 File Offset: 0x0032C940
		public int PreviewButtonRegistry(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0600DF18 RID: 57112 RVA: 0x0032E780 File Offset: 0x0032C980
		public int PreviewButtonRegistryLength
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

		// Token: 0x0600DF19 RID: 57113 RVA: 0x0032E7AC File Offset: 0x0032C9AC
		public Span<int> GetPreviewButtonRegistryBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600DF1A RID: 57114 RVA: 0x0032E7BC File Offset: 0x0032C9BC
		public int[] GetPreviewButtonRegistryArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600DF1B RID: 57115 RVA: 0x0032E7D4 File Offset: 0x0032C9D4
		public int MotorPreviewId
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

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0600DF1C RID: 57116 RVA: 0x0032E814 File Offset: 0x0032CA14
		public string PreviewContentId
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

		// Token: 0x0600DF1D RID: 57117 RVA: 0x0032E84C File Offset: 0x0032CA4C
		public Span<byte> GetPreviewContentIdBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x0032E85C File Offset: 0x0032CA5C
		public byte[] GetPreviewContentIdArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0600DF1F RID: 57119 RVA: 0x0032E874 File Offset: 0x0032CA74
		public int ClaimFunction
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DF20 RID: 57120 RVA: 0x0032E8B4 File Offset: 0x0032CAB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreviewButtonRegistryIter()或GetPreviewButtonRegistryBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreviewButtonRegistry()
		{
			TotalTopUpReward totalTopUpReward = this;
			return totalTopUpReward.GetPreviewButtonRegistryArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DF21 RID: 57121 RVA: 0x0032E8D8 File Offset: 0x0032CAD8
		[NullableContext(1)]
		public readonly IEnumerable<int> PreviewButtonRegistryIter()
		{
			TotalTopUpReward.<PreviewButtonRegistryIter>d__32 <PreviewButtonRegistryIter>d__ = new TotalTopUpReward.<PreviewButtonRegistryIter>d__32(-2);
			<PreviewButtonRegistryIter>d__.<>3__<>4__this = this;
			return <PreviewButtonRegistryIter>d__;
		}

		// Token: 0x04005271 RID: 21105
		private Table __p;
	}
}
