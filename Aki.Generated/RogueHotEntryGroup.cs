using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE2 RID: 4066
	public struct RogueHotEntryGroup : IFlatbufferObject
	{
		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x002E5665 File Offset: 0x002E3865
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x002E5672 File Offset: 0x002E3872
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x002E567C File Offset: 0x002E387C
		public static RogueHotEntryGroup GetRootAsRogueHotEntryGroup(ByteBuffer _bb)
		{
			return RogueHotEntryGroup.GetRootAsRogueHotEntryGroup(_bb, default(RogueHotEntryGroup));
		}

		// Token: 0x0600BF4A RID: 48970 RVA: 0x002E5698 File Offset: 0x002E3898
		public static RogueHotEntryGroup GetRootAsRogueHotEntryGroup(ByteBuffer _bb, RogueHotEntryGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x002E56B5 File Offset: 0x002E38B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x002E56C4 File Offset: 0x002E38C4
		public RogueHotEntryGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600BF4D RID: 48973 RVA: 0x002E56D4 File Offset: 0x002E38D4
		public int GroupId
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

		// Token: 0x0600BF4E RID: 48974 RVA: 0x002E5710 File Offset: 0x002E3910
		public int Group1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x0600BF4F RID: 48975 RVA: 0x002E5750 File Offset: 0x002E3950
		public int Group1Length
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x002E577B File Offset: 0x002E397B
		public Span<int> GetGroup1Bytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x002E578A File Offset: 0x002E398A
		public int[] GetGroup1Array()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BF52 RID: 48978 RVA: 0x002E57A4 File Offset: 0x002E39A4
		public int Group2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x0600BF53 RID: 48979 RVA: 0x002E57E4 File Offset: 0x002E39E4
		public int Group2Length
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

		// Token: 0x0600BF54 RID: 48980 RVA: 0x002E580F File Offset: 0x002E3A0F
		public Span<int> GetGroup2Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x002E581E File Offset: 0x002E3A1E
		public int[] GetGroup2Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BF56 RID: 48982 RVA: 0x002E5838 File Offset: 0x002E3A38
		public int Group3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x0600BF57 RID: 48983 RVA: 0x002E5878 File Offset: 0x002E3A78
		public int Group3Length
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BF58 RID: 48984 RVA: 0x002E58A4 File Offset: 0x002E3AA4
		public Span<int> GetGroup3Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BF59 RID: 48985 RVA: 0x002E58B4 File Offset: 0x002E3AB4
		public int[] GetGroup3Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0600BF5A RID: 48986 RVA: 0x002E58CC File Offset: 0x002E3ACC
		public int Rate
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

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600BF5B RID: 48987 RVA: 0x002E590C File Offset: 0x002E3B0C
		public string RateColor
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

		// Token: 0x0600BF5C RID: 48988 RVA: 0x002E5944 File Offset: 0x002E3B44
		public Span<byte> GetRateColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x002E5954 File Offset: 0x002E3B54
		public byte[] GetRateColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0600BF5E RID: 48990 RVA: 0x002E596C File Offset: 0x002E3B6C
		public string SettleIcon
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

		// Token: 0x0600BF5F RID: 48991 RVA: 0x002E59A4 File Offset: 0x002E3BA4
		public Span<byte> GetSettleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BF60 RID: 48992 RVA: 0x002E59B4 File Offset: 0x002E3BB4
		public byte[] GetSettleIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0600BF61 RID: 48993 RVA: 0x002E59CC File Offset: 0x002E3BCC
		public string SettleTextColor
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

		// Token: 0x0600BF62 RID: 48994 RVA: 0x002E5A04 File Offset: 0x002E3C04
		public Span<byte> GetSettleTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BF63 RID: 48995 RVA: 0x002E5A14 File Offset: 0x002E3C14
		public byte[] GetSettleTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0600BF64 RID: 48996 RVA: 0x002E5A2C File Offset: 0x002E3C2C
		public int SettleAudioState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BF65 RID: 48997 RVA: 0x002E5A6C File Offset: 0x002E3C6C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Group1Iter()或GetGroup1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Group1()
		{
			RogueHotEntryGroup rogueHotEntryGroup = this;
			return rogueHotEntryGroup.GetGroup1Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600BF66 RID: 48998 RVA: 0x002E5A90 File Offset: 0x002E3C90
		[NullableContext(1)]
		public readonly IEnumerable<int> Group1Iter()
		{
			RogueHotEntryGroup.<Group1Iter>d__42 <Group1Iter>d__ = new RogueHotEntryGroup.<Group1Iter>d__42(-2);
			<Group1Iter>d__.<>3__<>4__this = this;
			return <Group1Iter>d__;
		}

		// Token: 0x0600BF67 RID: 48999 RVA: 0x002E5AA8 File Offset: 0x002E3CA8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Group2Iter()或GetGroup2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Group2()
		{
			RogueHotEntryGroup rogueHotEntryGroup = this;
			return rogueHotEntryGroup.GetGroup2Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x002E5ACC File Offset: 0x002E3CCC
		[NullableContext(1)]
		public readonly IEnumerable<int> Group2Iter()
		{
			RogueHotEntryGroup.<Group2Iter>d__44 <Group2Iter>d__ = new RogueHotEntryGroup.<Group2Iter>d__44(-2);
			<Group2Iter>d__.<>3__<>4__this = this;
			return <Group2Iter>d__;
		}

		// Token: 0x0600BF69 RID: 49001 RVA: 0x002E5AE4 File Offset: 0x002E3CE4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用Group3Iter()或GetGroup3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Group3()
		{
			RogueHotEntryGroup rogueHotEntryGroup = this;
			return rogueHotEntryGroup.GetGroup3Array() ?? Array.Empty<int>();
		}

		// Token: 0x0600BF6A RID: 49002 RVA: 0x002E5B08 File Offset: 0x002E3D08
		[NullableContext(1)]
		public readonly IEnumerable<int> Group3Iter()
		{
			RogueHotEntryGroup.<Group3Iter>d__46 <Group3Iter>d__ = new RogueHotEntryGroup.<Group3Iter>d__46(-2);
			<Group3Iter>d__.<>3__<>4__this = this;
			return <Group3Iter>d__;
		}

		// Token: 0x040050BF RID: 20671
		private Table __p;
	}
}
