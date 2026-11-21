using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFE RID: 3326
	public struct EdgeRunnerReward : IFlatbufferObject
	{
		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x0023EA37 File Offset: 0x0023CC37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x0023EA44 File Offset: 0x0023CC44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x0023EA4C File Offset: 0x0023CC4C
		public static EdgeRunnerReward GetRootAsEdgeRunnerReward(ByteBuffer _bb)
		{
			return EdgeRunnerReward.GetRootAsEdgeRunnerReward(_bb, default(EdgeRunnerReward));
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x0023EA68 File Offset: 0x0023CC68
		public static EdgeRunnerReward GetRootAsEdgeRunnerReward(ByteBuffer _bb, EdgeRunnerReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x0023EA85 File Offset: 0x0023CC85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x0023EA94 File Offset: 0x0023CC94
		public EdgeRunnerReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06006D3B RID: 27963 RVA: 0x0023EAA4 File Offset: 0x0023CCA4
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

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06006D3C RID: 27964 RVA: 0x0023EAE0 File Offset: 0x0023CCE0
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

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06006D3D RID: 27965 RVA: 0x0023EB1C File Offset: 0x0023CD1C
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

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06006D3E RID: 27966 RVA: 0x0023EB58 File Offset: 0x0023CD58
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

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06006D3F RID: 27967 RVA: 0x0023EB98 File Offset: 0x0023CD98
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

		// Token: 0x06006D40 RID: 27968 RVA: 0x0023EBD0 File Offset: 0x0023CDD0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x0023EBE0 File Offset: 0x0023CDE0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06006D42 RID: 27970 RVA: 0x0023EBF8 File Offset: 0x0023CDF8
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06006D43 RID: 27971 RVA: 0x0023EC38 File Offset: 0x0023CE38
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06006D44 RID: 27972 RVA: 0x0023EC78 File Offset: 0x0023CE78
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

		// Token: 0x06006D45 RID: 27973 RVA: 0x0023ECB8 File Offset: 0x0023CEB8
		public string SkipParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06006D46 RID: 27974 RVA: 0x0023ECF4 File Offset: 0x0023CEF4
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

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06006D47 RID: 27975 RVA: 0x0023ED20 File Offset: 0x0023CF20
		public int SkipCondition
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06006D48 RID: 27976 RVA: 0x0023ED60 File Offset: 0x0023CF60
		public string HintText
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x0023ED98 File Offset: 0x0023CF98
		public Span<byte> GetHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x0023EDA8 File Offset: 0x0023CFA8
		public byte[] GetHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x0023EDC0 File Offset: 0x0023CFC0
		[NullableContext(1)]
		public string[] SkipParam()
		{
			return this.SkipParamIter().ToArray<string>();
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x0023EDCD File Offset: 0x0023CFCD
		[NullableContext(1)]
		public IEnumerable<string> SkipParamIter()
		{
			EdgeRunnerReward.<SkipParamIter>d__36 <SkipParamIter>d__ = new EdgeRunnerReward.<SkipParamIter>d__36(-2);
			<SkipParamIter>d__.<>3__<>4__this = this;
			return <SkipParamIter>d__;
		}

		// Token: 0x0400523E RID: 21054
		private Table __p;
	}
}
