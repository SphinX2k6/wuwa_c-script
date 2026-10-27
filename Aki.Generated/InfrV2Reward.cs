using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6C RID: 3436
	public struct InfrV2Reward : IFlatbufferObject
	{
		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x0600840C RID: 33804 RVA: 0x002605BC File Offset: 0x0025E7BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x002605C9 File Offset: 0x0025E7C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x002605D0 File Offset: 0x0025E7D0
		public static InfrV2Reward GetRootAsInfrV2Reward(ByteBuffer _bb)
		{
			return InfrV2Reward.GetRootAsInfrV2Reward(_bb, default(InfrV2Reward));
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x002605EC File Offset: 0x0025E7EC
		public static InfrV2Reward GetRootAsInfrV2Reward(ByteBuffer _bb, InfrV2Reward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x00260609 File Offset: 0x0025E809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x00260618 File Offset: 0x0025E818
		public InfrV2Reward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06008412 RID: 33810 RVA: 0x00260628 File Offset: 0x0025E828
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

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06008413 RID: 33811 RVA: 0x00260664 File Offset: 0x0025E864
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

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06008414 RID: 33812 RVA: 0x002606A0 File Offset: 0x0025E8A0
		public int TabId
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

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06008415 RID: 33813 RVA: 0x002606DC File Offset: 0x0025E8DC
		public int Sort
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

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06008416 RID: 33814 RVA: 0x0026071C File Offset: 0x0025E91C
		public string Desc
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

		// Token: 0x06008417 RID: 33815 RVA: 0x00260754 File Offset: 0x0025E954
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x00260764 File Offset: 0x0025E964
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06008419 RID: 33817 RVA: 0x0026077C File Offset: 0x0025E97C
		public int ConditionGroup
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

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x0600841A RID: 33818 RVA: 0x002607BC File Offset: 0x0025E9BC
		public int DropId
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

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x0600841B RID: 33819 RVA: 0x002607FC File Offset: 0x0025E9FC
		public int SkipType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x0026083C File Offset: 0x0025EA3C
		public string SkipParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600841D RID: 33821 RVA: 0x00260878 File Offset: 0x0025EA78
		public int SkipParamLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x002608A4 File Offset: 0x0025EAA4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkipParamIter()或GetSkipParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkipParam()
		{
			return this.SkipParamIter().ToArray<string>();
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x002608B1 File Offset: 0x0025EAB1
		[NullableContext(1)]
		public readonly IEnumerable<string> SkipParamIter()
		{
			InfrV2Reward.<SkipParamIter>d__30 <SkipParamIter>d__ = new InfrV2Reward.<SkipParamIter>d__30(-2);
			<SkipParamIter>d__.<>3__<>4__this = this;
			return <SkipParamIter>d__;
		}

		// Token: 0x04004DEF RID: 19951
		private Table __p;
	}
}
