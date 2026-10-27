using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102A RID: 4138
	public struct RogueWeeklyBuffDesc : IFlatbufferObject
	{
		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600C5AB RID: 50603 RVA: 0x002F3975 File Offset: 0x002F1B75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C5AC RID: 50604 RVA: 0x002F3982 File Offset: 0x002F1B82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x002F398C File Offset: 0x002F1B8C
		public static RogueWeeklyBuffDesc GetRootAsRogueWeeklyBuffDesc(ByteBuffer _bb)
		{
			return RogueWeeklyBuffDesc.GetRootAsRogueWeeklyBuffDesc(_bb, default(RogueWeeklyBuffDesc));
		}

		// Token: 0x0600C5AE RID: 50606 RVA: 0x002F39A8 File Offset: 0x002F1BA8
		public static RogueWeeklyBuffDesc GetRootAsRogueWeeklyBuffDesc(ByteBuffer _bb, RogueWeeklyBuffDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x002F39C5 File Offset: 0x002F1BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C5B0 RID: 50608 RVA: 0x002F39D4 File Offset: 0x002F1BD4
		public RogueWeeklyBuffDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600C5B1 RID: 50609 RVA: 0x002F39E4 File Offset: 0x002F1BE4
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

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0600C5B2 RID: 50610 RVA: 0x002F3A20 File Offset: 0x002F1C20
		public string BuffDsec
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

		// Token: 0x0600C5B3 RID: 50611 RVA: 0x002F3A57 File Offset: 0x002F1C57
		public Span<byte> GetBuffDsecBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C5B4 RID: 50612 RVA: 0x002F3A66 File Offset: 0x002F1C66
		public byte[] GetBuffDsecArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C5B5 RID: 50613 RVA: 0x002F3A80 File Offset: 0x002F1C80
		public string BuffDsecParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0600C5B6 RID: 50614 RVA: 0x002F3ABC File Offset: 0x002F1CBC
		public int BuffDsecParamLength
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

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x002F3AE7 File Offset: 0x002F1CE7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffDsecParamIter()或GetBuffDsecParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffDsecParam()
		{
			return this.BuffDsecParamIter().ToArray<string>();
		}

		// Token: 0x0600C5B8 RID: 50616 RVA: 0x002F3AF4 File Offset: 0x002F1CF4
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffDsecParamIter()
		{
			RogueWeeklyBuffDesc.<BuffDsecParamIter>d__18 <BuffDsecParamIter>d__ = new RogueWeeklyBuffDesc.<BuffDsecParamIter>d__18(-2);
			<BuffDsecParamIter>d__.<>3__<>4__this = this;
			return <BuffDsecParamIter>d__;
		}

		// Token: 0x0400511D RID: 20765
		private Table __p;
	}
}
