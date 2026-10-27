using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEB RID: 3307
	public struct GamePlayInformationGroup : IFlatbufferObject
	{
		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06007939 RID: 31033 RVA: 0x002486F1 File Offset: 0x002468F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x002486FE File Offset: 0x002468FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x00248708 File Offset: 0x00246908
		public static GamePlayInformationGroup GetRootAsGamePlayInformationGroup(ByteBuffer _bb)
		{
			return GamePlayInformationGroup.GetRootAsGamePlayInformationGroup(_bb, default(GamePlayInformationGroup));
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x00248724 File Offset: 0x00246924
		public static GamePlayInformationGroup GetRootAsGamePlayInformationGroup(ByteBuffer _bb, GamePlayInformationGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x00248741 File Offset: 0x00246941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x00248750 File Offset: 0x00246950
		public GamePlayInformationGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x0600793F RID: 31039 RVA: 0x00248760 File Offset: 0x00246960
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

		// Token: 0x06007940 RID: 31040 RVA: 0x0024879C File Offset: 0x0024699C
		public int InfoGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x002487DC File Offset: 0x002469DC
		public int InfoGroupLength
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

		// Token: 0x06007942 RID: 31042 RVA: 0x00248807 File Offset: 0x00246A07
		public Span<int> GetInfoGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x00248816 File Offset: 0x00246A16
		public int[] GetInfoGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06007944 RID: 31044 RVA: 0x00248830 File Offset: 0x00246A30
		public string IconString
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

		// Token: 0x06007945 RID: 31045 RVA: 0x00248867 File Offset: 0x00246A67
		public Span<byte> GetIconStringBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x00248876 File Offset: 0x00246A76
		public byte[] GetIconStringArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00248890 File Offset: 0x00246A90
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InfoGroupIter()或GetInfoGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InfoGroup()
		{
			GamePlayInformationGroup gamePlayInformationGroup = this;
			return gamePlayInformationGroup.GetInfoGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x002488B4 File Offset: 0x00246AB4
		[NullableContext(1)]
		public readonly IEnumerable<int> InfoGroupIter()
		{
			GamePlayInformationGroup.<InfoGroupIter>d__20 <InfoGroupIter>d__ = new GamePlayInformationGroup.<InfoGroupIter>d__20(-2);
			<InfoGroupIter>d__.<>3__<>4__this = this;
			return <InfoGroupIter>d__;
		}

		// Token: 0x04004D5C RID: 19804
		private Table __p;
	}
}
