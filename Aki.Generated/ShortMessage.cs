using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AD RID: 4269
	public struct ShortMessage : IFlatbufferObject
	{
		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600D216 RID: 53782 RVA: 0x0030FA91 File Offset: 0x0030DC91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D217 RID: 53783 RVA: 0x0030FA9E File Offset: 0x0030DC9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D218 RID: 53784 RVA: 0x0030FAA8 File Offset: 0x0030DCA8
		public static ShortMessage GetRootAsShortMessage(ByteBuffer _bb)
		{
			return ShortMessage.GetRootAsShortMessage(_bb, default(ShortMessage));
		}

		// Token: 0x0600D219 RID: 53785 RVA: 0x0030FAC4 File Offset: 0x0030DCC4
		public static ShortMessage GetRootAsShortMessage(ByteBuffer _bb, ShortMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D21A RID: 53786 RVA: 0x0030FAE1 File Offset: 0x0030DCE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D21B RID: 53787 RVA: 0x0030FAF0 File Offset: 0x0030DCF0
		public ShortMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600D21C RID: 53788 RVA: 0x0030FB00 File Offset: 0x0030DD00
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

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600D21D RID: 53789 RVA: 0x0030FB3C File Offset: 0x0030DD3C
		public int WhichChat
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

		// Token: 0x0600D21E RID: 53790 RVA: 0x0030FB78 File Offset: 0x0030DD78
		public string FlowParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600D21F RID: 53791 RVA: 0x0030FBB4 File Offset: 0x0030DDB4
		public int FlowParamLength
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

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600D220 RID: 53792 RVA: 0x0030FBE0 File Offset: 0x0030DDE0
		public int TipType
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

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600D221 RID: 53793 RVA: 0x0030FC20 File Offset: 0x0030DE20
		public int ListenQuestId
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

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600D222 RID: 53794 RVA: 0x0030FC60 File Offset: 0x0030DE60
		public int FinallPopType
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

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600D223 RID: 53795 RVA: 0x0030FCA0 File Offset: 0x0030DEA0
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

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600D224 RID: 53796 RVA: 0x0030FCE0 File Offset: 0x0030DEE0
		public int QuestId
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

		// Token: 0x0600D225 RID: 53797 RVA: 0x0030FD1D File Offset: 0x0030DF1D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlowParamIter()或GetFlowParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FlowParam()
		{
			return this.FlowParamIter().ToArray<string>();
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x0030FD2A File Offset: 0x0030DF2A
		[NullableContext(1)]
		public readonly IEnumerable<string> FlowParamIter()
		{
			ShortMessage.<FlowParamIter>d__26 <FlowParamIter>d__ = new ShortMessage.<FlowParamIter>d__26(-2);
			<FlowParamIter>d__.<>3__<>4__this = this;
			return <FlowParamIter>d__;
		}

		// Token: 0x040051C0 RID: 20928
		private Table __p;
	}
}
