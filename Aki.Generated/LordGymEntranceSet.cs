using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE1 RID: 3553
	public struct LordGymEntranceSet : IFlatbufferObject
	{
		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06009028 RID: 36904 RVA: 0x0027C69D File Offset: 0x0027A89D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0027C6AA File Offset: 0x0027A8AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x0027C6B4 File Offset: 0x0027A8B4
		public static LordGymEntranceSet GetRootAsLordGymEntranceSet(ByteBuffer _bb)
		{
			return LordGymEntranceSet.GetRootAsLordGymEntranceSet(_bb, default(LordGymEntranceSet));
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0027C6D0 File Offset: 0x0027A8D0
		public static LordGymEntranceSet GetRootAsLordGymEntranceSet(ByteBuffer _bb, LordGymEntranceSet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0027C6ED File Offset: 0x0027A8ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x0027C6FC File Offset: 0x0027A8FC
		public LordGymEntranceSet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x0600902E RID: 36910 RVA: 0x0027C70C File Offset: 0x0027A90C
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

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x0600902F RID: 36911 RVA: 0x0027C748 File Offset: 0x0027A948
		public int PreviewRewardId
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

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06009030 RID: 36912 RVA: 0x0027C784 File Offset: 0x0027A984
		public int MarkId
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

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06009031 RID: 36913 RVA: 0x0027C7C0 File Offset: 0x0027A9C0
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x0027C800 File Offset: 0x0027AA00
		public int LordEntranceList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06009033 RID: 36915 RVA: 0x0027C840 File Offset: 0x0027AA40
		public int LordEntranceListLength
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

		// Token: 0x06009034 RID: 36916 RVA: 0x0027C86C File Offset: 0x0027AA6C
		public Span<int> GetLordEntranceListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009035 RID: 36917 RVA: 0x0027C87C File Offset: 0x0027AA7C
		public int[] GetLordEntranceListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06009036 RID: 36918 RVA: 0x0027C894 File Offset: 0x0027AA94
		public int MapNoteUnlockCondition
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

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06009037 RID: 36919 RVA: 0x0027C8D4 File Offset: 0x0027AAD4
		public string Title
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x0027C90C File Offset: 0x0027AB0C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0027C91C File Offset: 0x0027AB1C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x0600903A RID: 36922 RVA: 0x0027C934 File Offset: 0x0027AB34
		public string Description
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

		// Token: 0x0600903B RID: 36923 RVA: 0x0027C96C File Offset: 0x0027AB6C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x0027C97C File Offset: 0x0027AB7C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x0600903D RID: 36925 RVA: 0x0027C994 File Offset: 0x0027AB94
		public int HelpId
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

		// Token: 0x0600903E RID: 36926 RVA: 0x0027C9D4 File Offset: 0x0027ABD4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LordEntranceListIter()或GetLordEntranceListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LordEntranceList()
		{
			LordGymEntranceSet lordGymEntranceSet = this;
			return lordGymEntranceSet.GetLordEntranceListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x0027C9F8 File Offset: 0x0027ABF8
		[NullableContext(1)]
		public readonly IEnumerable<int> LordEntranceListIter()
		{
			LordGymEntranceSet.<LordEntranceListIter>d__34 <LordEntranceListIter>d__ = new LordGymEntranceSet.<LordEntranceListIter>d__34(-2);
			<LordEntranceListIter>d__.<>3__<>4__this = this;
			return <LordEntranceListIter>d__;
		}

		// Token: 0x04004E7D RID: 20093
		private Table __p;
	}
}
