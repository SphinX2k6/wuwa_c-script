using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001027 RID: 4135
	public struct RogueTowerBuff : IFlatbufferObject
	{
		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600C575 RID: 50549 RVA: 0x002F3265 File Offset: 0x002F1465
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C576 RID: 50550 RVA: 0x002F3272 File Offset: 0x002F1472
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C577 RID: 50551 RVA: 0x002F327C File Offset: 0x002F147C
		public static RogueTowerBuff GetRootAsRogueTowerBuff(ByteBuffer _bb)
		{
			return RogueTowerBuff.GetRootAsRogueTowerBuff(_bb, default(RogueTowerBuff));
		}

		// Token: 0x0600C578 RID: 50552 RVA: 0x002F3298 File Offset: 0x002F1498
		public static RogueTowerBuff GetRootAsRogueTowerBuff(ByteBuffer _bb, RogueTowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C579 RID: 50553 RVA: 0x002F32B5 File Offset: 0x002F14B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C57A RID: 50554 RVA: 0x002F32C4 File Offset: 0x002F14C4
		public RogueTowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600C57B RID: 50555 RVA: 0x002F32D4 File Offset: 0x002F14D4
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

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600C57C RID: 50556 RVA: 0x002F3310 File Offset: 0x002F1510
		public string Icon
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

		// Token: 0x0600C57D RID: 50557 RVA: 0x002F3347 File Offset: 0x002F1547
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C57E RID: 50558 RVA: 0x002F3356 File Offset: 0x002F1556
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600C57F RID: 50559 RVA: 0x002F3370 File Offset: 0x002F1570
		public string Name
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

		// Token: 0x0600C580 RID: 50560 RVA: 0x002F33A7 File Offset: 0x002F15A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C581 RID: 50561 RVA: 0x002F33B6 File Offset: 0x002F15B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600C582 RID: 50562 RVA: 0x002F33D0 File Offset: 0x002F15D0
		public string Describe
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

		// Token: 0x0600C583 RID: 50563 RVA: 0x002F3408 File Offset: 0x002F1608
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C584 RID: 50564 RVA: 0x002F3418 File Offset: 0x002F1618
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C585 RID: 50565 RVA: 0x002F3430 File Offset: 0x002F1630
		public string DescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600C586 RID: 50566 RVA: 0x002F346C File Offset: 0x002F166C
		public int DescParamLength
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

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600C587 RID: 50567 RVA: 0x002F3498 File Offset: 0x002F1698
		public string BriefDesc
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

		// Token: 0x0600C588 RID: 50568 RVA: 0x002F34D0 File Offset: 0x002F16D0
		public Span<byte> GetBriefDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C589 RID: 50569 RVA: 0x002F34E0 File Offset: 0x002F16E0
		public byte[] GetBriefDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C58A RID: 50570 RVA: 0x002F34F8 File Offset: 0x002F16F8
		public string BriefDescParam(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600C58B RID: 50571 RVA: 0x002F3534 File Offset: 0x002F1734
		public int BriefDescParamLength
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

		// Token: 0x0600C58C RID: 50572 RVA: 0x002F3560 File Offset: 0x002F1760
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BriefDescParamIter()或GetBriefDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BriefDescParam()
		{
			return this.BriefDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x002F356D File Offset: 0x002F176D
		[NullableContext(1)]
		public readonly IEnumerable<string> BriefDescParamIter()
		{
			RogueTowerBuff.<BriefDescParamIter>d__33 <BriefDescParamIter>d__ = new RogueTowerBuff.<BriefDescParamIter>d__33(-2);
			<BriefDescParamIter>d__.<>3__<>4__this = this;
			return <BriefDescParamIter>d__;
		}

		// Token: 0x0600C58E RID: 50574 RVA: 0x002F3582 File Offset: 0x002F1782
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamIter()或GetDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600C58F RID: 50575 RVA: 0x002F358F File Offset: 0x002F178F
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamIter()
		{
			RogueTowerBuff.<DescParamIter>d__35 <DescParamIter>d__ = new RogueTowerBuff.<DescParamIter>d__35(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x0400511A RID: 20762
		private Table __p;
	}
}
