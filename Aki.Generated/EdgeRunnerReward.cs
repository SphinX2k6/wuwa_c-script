using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1B RID: 3099
	public struct EdgeRunnerReward : IFlatbufferObject
	{
		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x0021F659 File Offset: 0x0021D859
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x0021F666 File Offset: 0x0021D866
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x0021F670 File Offset: 0x0021D870
		public static EdgeRunnerReward GetRootAsEdgeRunnerReward(ByteBuffer _bb)
		{
			return EdgeRunnerReward.GetRootAsEdgeRunnerReward(_bb, default(EdgeRunnerReward));
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x0021F68C File Offset: 0x0021D88C
		public static EdgeRunnerReward GetRootAsEdgeRunnerReward(ByteBuffer _bb, EdgeRunnerReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x0021F6A9 File Offset: 0x0021D8A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x0021F6B8 File Offset: 0x0021D8B8
		public EdgeRunnerReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x0021F6C8 File Offset: 0x0021D8C8
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

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x0021F704 File Offset: 0x0021D904
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

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x0021F740 File Offset: 0x0021D940
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

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x0021F77C File Offset: 0x0021D97C
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

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x0600674C RID: 26444 RVA: 0x0021F7BC File Offset: 0x0021D9BC
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

		// Token: 0x0600674D RID: 26445 RVA: 0x0021F7F4 File Offset: 0x0021D9F4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x0021F804 File Offset: 0x0021DA04
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x0021F81C File Offset: 0x0021DA1C
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

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x0021F85C File Offset: 0x0021DA5C
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

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x0021F89C File Offset: 0x0021DA9C
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

		// Token: 0x06006752 RID: 26450 RVA: 0x0021F8DC File Offset: 0x0021DADC
		public string SkipParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06006753 RID: 26451 RVA: 0x0021F918 File Offset: 0x0021DB18
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

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x0021F944 File Offset: 0x0021DB44
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

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06006755 RID: 26453 RVA: 0x0021F984 File Offset: 0x0021DB84
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

		// Token: 0x06006756 RID: 26454 RVA: 0x0021F9BC File Offset: 0x0021DBBC
		public Span<byte> GetHintTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x0021F9CC File Offset: 0x0021DBCC
		public byte[] GetHintTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x0021F9E4 File Offset: 0x0021DBE4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkipParamIter()或GetSkipParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkipParam()
		{
			return this.SkipParamIter().ToArray<string>();
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x0021F9F1 File Offset: 0x0021DBF1
		[NullableContext(1)]
		public readonly IEnumerable<string> SkipParamIter()
		{
			EdgeRunnerReward.<SkipParamIter>d__36 <SkipParamIter>d__ = new EdgeRunnerReward.<SkipParamIter>d__36(-2);
			<SkipParamIter>d__.<>3__<>4__this = this;
			return <SkipParamIter>d__;
		}

		// Token: 0x04004C5B RID: 19547
		private Table __p;
	}
}
