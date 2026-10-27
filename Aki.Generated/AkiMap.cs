using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF9 RID: 2809
	public struct AkiMap : IFlatbufferObject
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x001D520C File Offset: 0x001D340C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x001D5219 File Offset: 0x001D3419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x001D5220 File Offset: 0x001D3420
		public static AkiMap GetRootAsAkiMap(ByteBuffer _bb)
		{
			return AkiMap.GetRootAsAkiMap(_bb, default(AkiMap));
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x001D523C File Offset: 0x001D343C
		public static AkiMap GetRootAsAkiMap(ByteBuffer _bb, AkiMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x001D5259 File Offset: 0x001D3459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x001D5268 File Offset: 0x001D3468
		public AkiMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06004779 RID: 18297 RVA: 0x001D5278 File Offset: 0x001D3478
		public int MapId
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x001D52B4 File Offset: 0x001D34B4
		public string MapName
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

		// Token: 0x0600477B RID: 18299 RVA: 0x001D52EB File Offset: 0x001D34EB
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x001D52FA File Offset: 0x001D34FA
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x001D5314 File Offset: 0x001D3514
		public int FatherMap
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x001D5350 File Offset: 0x001D3550
		public int GroupMark
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x001D5390 File Offset: 0x001D3590
		public int Floor
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x001D53D0 File Offset: 0x001D35D0
		public string SwitchCondition
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

		// Token: 0x06004781 RID: 18305 RVA: 0x001D5408 File Offset: 0x001D3608
		public Span<byte> GetSwitchConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x001D5418 File Offset: 0x001D3618
		public byte[] GetSwitchConditionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x001D5430 File Offset: 0x001D3630
		public string MapPic3d
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

		// Token: 0x06004784 RID: 18308 RVA: 0x001D5468 File Offset: 0x001D3668
		public Span<byte> GetMapPic3dBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x001D5478 File Offset: 0x001D3678
		public byte[] GetMapPic3dArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x001D5490 File Offset: 0x001D3690
		public string MapPic2d
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

		// Token: 0x06004787 RID: 18311 RVA: 0x001D54C8 File Offset: 0x001D36C8
		public Span<byte> GetMapPic2dBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x001D54D8 File Offset: 0x001D36D8
		public byte[] GetMapPic2dArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x001D54F0 File Offset: 0x001D36F0
		public int BigMapDefaultScale
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x001D5530 File Offset: 0x001D3730
		public int BigMapMinScale
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600478B RID: 18315 RVA: 0x001D5570 File Offset: 0x001D3770
		public int BigMapMaxScale
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x001D55B0 File Offset: 0x001D37B0
		public int LittleMapDefaultScale
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600478D RID: 18317 RVA: 0x001D55F0 File Offset: 0x001D37F0
		public string LimitContent
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x001D5628 File Offset: 0x001D3828
		public Span<byte> GetLimitContentBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x001D5638 File Offset: 0x001D3838
		public byte[] GetLimitContentArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x001D5650 File Offset: 0x001D3850
		public bool IsGravityMap
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x001D5690 File Offset: 0x001D3890
		public bool IsNeedCustomizedThumbnail
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x001D56D0 File Offset: 0x001D38D0
		public int SafeAreaOffset(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06004793 RID: 18323 RVA: 0x001D5710 File Offset: 0x001D3910
		public int SafeAreaOffsetLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x001D573C File Offset: 0x001D393C
		public Span<int> GetSafeAreaOffsetBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x001D574C File Offset: 0x001D394C
		public int[] GetSafeAreaOffsetArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x001D5764 File Offset: 0x001D3964
		public int ShowMode
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

		// Token: 0x06004797 RID: 18327 RVA: 0x001D57A4 File Offset: 0x001D39A4
		public int FogFullUnlockDungeonList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x001D57E4 File Offset: 0x001D39E4
		public int FogFullUnlockDungeonListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x001D5810 File Offset: 0x001D3A10
		public Span<int> GetFogFullUnlockDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x001D5820 File Offset: 0x001D3A20
		public int[] GetFogFullUnlockDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x001D5838 File Offset: 0x001D3A38
		public int ExtraMapScale
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x001D5878 File Offset: 0x001D3A78
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FogFullUnlockDungeonListIter()或GetFogFullUnlockDungeonListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FogFullUnlockDungeonList()
		{
			AkiMap akiMap = this;
			return akiMap.GetFogFullUnlockDungeonListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x001D589C File Offset: 0x001D3A9C
		[NullableContext(1)]
		public readonly IEnumerable<int> FogFullUnlockDungeonListIter()
		{
			AkiMap.<FogFullUnlockDungeonListIter>d__63 <FogFullUnlockDungeonListIter>d__ = new AkiMap.<FogFullUnlockDungeonListIter>d__63(-2);
			<FogFullUnlockDungeonListIter>d__.<>3__<>4__this = this;
			return <FogFullUnlockDungeonListIter>d__;
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x001D58B4 File Offset: 0x001D3AB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SafeAreaOffsetIter()或GetSafeAreaOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SafeAreaOffset()
		{
			AkiMap akiMap = this;
			return akiMap.GetSafeAreaOffsetArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x001D58D8 File Offset: 0x001D3AD8
		[NullableContext(1)]
		public readonly IEnumerable<int> SafeAreaOffsetIter()
		{
			AkiMap.<SafeAreaOffsetIter>d__65 <SafeAreaOffsetIter>d__ = new AkiMap.<SafeAreaOffsetIter>d__65(-2);
			<SafeAreaOffsetIter>d__.<>3__<>4__this = this;
			return <SafeAreaOffsetIter>d__;
		}

		// Token: 0x04004ADA RID: 19162
		private Table __p;
	}
}
