using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001079 RID: 4217
	public struct RoverRogueEventChoice : IFlatbufferObject
	{
		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600CDAA RID: 52650 RVA: 0x00305C50 File Offset: 0x00303E50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDAB RID: 52651 RVA: 0x00305C5D File Offset: 0x00303E5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDAC RID: 52652 RVA: 0x00305C64 File Offset: 0x00303E64
		public static RoverRogueEventChoice GetRootAsRoverRogueEventChoice(ByteBuffer _bb)
		{
			return RoverRogueEventChoice.GetRootAsRoverRogueEventChoice(_bb, default(RoverRogueEventChoice));
		}

		// Token: 0x0600CDAD RID: 52653 RVA: 0x00305C80 File Offset: 0x00303E80
		public static RoverRogueEventChoice GetRootAsRoverRogueEventChoice(ByteBuffer _bb, RoverRogueEventChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDAE RID: 52654 RVA: 0x00305C9D File Offset: 0x00303E9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDAF RID: 52655 RVA: 0x00305CAC File Offset: 0x00303EAC
		public RoverRogueEventChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600CDB0 RID: 52656 RVA: 0x00305CBC File Offset: 0x00303EBC
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

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600CDB1 RID: 52657 RVA: 0x00305CF8 File Offset: 0x00303EF8
		public string Desc
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

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x00305D2F File Offset: 0x00303F2F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CDB3 RID: 52659 RVA: 0x00305D3E File Offset: 0x00303F3E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x00305D58 File Offset: 0x00303F58
		public string Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600CDB5 RID: 52661 RVA: 0x00305D94 File Offset: 0x00303F94
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

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600CDB6 RID: 52662 RVA: 0x00305DC0 File Offset: 0x00303FC0
		public string BriefDesc
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

		// Token: 0x0600CDB7 RID: 52663 RVA: 0x00305DF8 File Offset: 0x00303FF8
		public Span<byte> GetBriefDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x00305E08 File Offset: 0x00304008
		public byte[] GetBriefDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x00305E20 File Offset: 0x00304020
		public string BriefDescParams(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600CDBA RID: 52666 RVA: 0x00305E5C File Offset: 0x0030405C
		public int BriefDescParamsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x00305E88 File Offset: 0x00304088
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BriefDescParamsIter()或GetBriefDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BriefDescParams()
		{
			return this.BriefDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600CDBC RID: 52668 RVA: 0x00305E95 File Offset: 0x00304095
		[NullableContext(1)]
		public readonly IEnumerable<string> BriefDescParamsIter()
		{
			RoverRogueEventChoice.<BriefDescParamsIter>d__25 <BriefDescParamsIter>d__ = new RoverRogueEventChoice.<BriefDescParamsIter>d__25(-2);
			<BriefDescParamsIter>d__.<>3__<>4__this = this;
			return <BriefDescParamsIter>d__;
		}

		// Token: 0x0600CDBD RID: 52669 RVA: 0x00305EAA File Offset: 0x003040AA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600CDBE RID: 52670 RVA: 0x00305EB7 File Offset: 0x003040B7
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamsIter()
		{
			RoverRogueEventChoice.<ParamsIter>d__27 <ParamsIter>d__ = new RoverRogueEventChoice.<ParamsIter>d__27(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005183 RID: 20867
		private Table __p;
	}
}
