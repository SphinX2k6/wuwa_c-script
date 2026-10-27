using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B09 RID: 2825
	public struct AreaTerminal : IFlatbufferObject
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x001D86D4 File Offset: 0x001D68D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x001D86E1 File Offset: 0x001D68E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x001D86E8 File Offset: 0x001D68E8
		public static AreaTerminal GetRootAsAreaTerminal(ByteBuffer _bb)
		{
			return AreaTerminal.GetRootAsAreaTerminal(_bb, default(AreaTerminal));
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x001D8704 File Offset: 0x001D6904
		public static AreaTerminal GetRootAsAreaTerminal(ByteBuffer _bb, AreaTerminal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x001D8721 File Offset: 0x001D6921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x001D8730 File Offset: 0x001D6930
		public AreaTerminal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060048EA RID: 18666 RVA: 0x001D8740 File Offset: 0x001D6940
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x001D877C File Offset: 0x001D697C
		public int Country
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x001D87B8 File Offset: 0x001D69B8
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

		// Token: 0x060048ED RID: 18669 RVA: 0x001D87EF File Offset: 0x001D69EF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x001D87FE File Offset: 0x001D69FE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x001D8818 File Offset: 0x001D6A18
		public string TagName
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

		// Token: 0x060048F0 RID: 18672 RVA: 0x001D8850 File Offset: 0x001D6A50
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x001D8860 File Offset: 0x001D6A60
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x001D8878 File Offset: 0x001D6A78
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

		// Token: 0x060048F3 RID: 18675 RVA: 0x001D88B0 File Offset: 0x001D6AB0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x001D88C0 File Offset: 0x001D6AC0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x001D88D8 File Offset: 0x001D6AD8
		public string Icon
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

		// Token: 0x060048F6 RID: 18678 RVA: 0x001D8910 File Offset: 0x001D6B10
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x001D8920 File Offset: 0x001D6B20
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x001D8938 File Offset: 0x001D6B38
		public string TexBgLock
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

		// Token: 0x060048F9 RID: 18681 RVA: 0x001D8970 File Offset: 0x001D6B70
		public Span<byte> GetTexBgLockBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x001D8980 File Offset: 0x001D6B80
		public byte[] GetTexBgLockArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x001D8998 File Offset: 0x001D6B98
		public string TexBg
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

		// Token: 0x060048FC RID: 18684 RVA: 0x001D89D0 File Offset: 0x001D6BD0
		public Span<byte> GetTexBgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x001D89E0 File Offset: 0x001D6BE0
		public byte[] GetTexBgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060048FE RID: 18686 RVA: 0x001D89F8 File Offset: 0x001D6BF8
		public int SortId
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x001D8A38 File Offset: 0x001D6C38
		public int GroupId
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

		// Token: 0x06004900 RID: 18688 RVA: 0x001D8A78 File Offset: 0x001D6C78
		public int Area(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x001D8AB8 File Offset: 0x001D6CB8
		public int AreaLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x001D8AE4 File Offset: 0x001D6CE4
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x001D8AF4 File Offset: 0x001D6CF4
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x001D8B0C File Offset: 0x001D6D0C
		public string AreaForbiddenTips
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x001D8B44 File Offset: 0x001D6D44
		public Span<byte> GetAreaForbiddenTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x001D8B54 File Offset: 0x001D6D54
		public byte[] GetAreaForbiddenTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x001D8B6C File Offset: 0x001D6D6C
		public int AreaMapGroup(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x001D8BAC File Offset: 0x001D6DAC
		public int AreaMapGroupLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x001D8BD8 File Offset: 0x001D6DD8
		public Span<int> GetAreaMapGroupBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x001D8BE8 File Offset: 0x001D6DE8
		public int[] GetAreaMapGroupArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x001D8C00 File Offset: 0x001D6E00
		public string UnlockButtonText
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x001D8C38 File Offset: 0x001D6E38
		public Span<byte> GetUnlockButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x001D8C48 File Offset: 0x001D6E48
		public byte[] GetUnlockButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x001D8C60 File Offset: 0x001D6E60
		public int GamePlayType
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x001D8CA0 File Offset: 0x001D6EA0
		public int GamePlayId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x001D8CE0 File Offset: 0x001D6EE0
		public int RewardPreview
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x001D8D20 File Offset: 0x001D6F20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaIter()或GetAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Area()
		{
			AreaTerminal areaTerminal = this;
			return areaTerminal.GetAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x001D8D44 File Offset: 0x001D6F44
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaIter()
		{
			AreaTerminal.<AreaIter>d__65 <AreaIter>d__ = new AreaTerminal.<AreaIter>d__65(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x001D8D5C File Offset: 0x001D6F5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaMapGroupIter()或GetAreaMapGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AreaMapGroup()
		{
			AreaTerminal areaTerminal = this;
			return areaTerminal.GetAreaMapGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x001D8D80 File Offset: 0x001D6F80
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaMapGroupIter()
		{
			AreaTerminal.<AreaMapGroupIter>d__67 <AreaMapGroupIter>d__ = new AreaTerminal.<AreaMapGroupIter>d__67(-2);
			<AreaMapGroupIter>d__.<>3__<>4__this = this;
			return <AreaMapGroupIter>d__;
		}

		// Token: 0x04004AEE RID: 19182
		private Table __p;
	}
}
