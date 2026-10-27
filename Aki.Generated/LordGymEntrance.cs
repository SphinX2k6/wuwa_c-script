using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE0 RID: 3552
	public struct LordGymEntrance : IFlatbufferObject
	{
		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06008FF0 RID: 36848 RVA: 0x0027BF0D File Offset: 0x0027A10D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x0027BF1A File Offset: 0x0027A11A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x0027BF24 File Offset: 0x0027A124
		public static LordGymEntrance GetRootAsLordGymEntrance(ByteBuffer _bb)
		{
			return LordGymEntrance.GetRootAsLordGymEntrance(_bb, default(LordGymEntrance));
		}

		// Token: 0x06008FF3 RID: 36851 RVA: 0x0027BF40 File Offset: 0x0027A140
		public static LordGymEntrance GetRootAsLordGymEntrance(ByteBuffer _bb, LordGymEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x0027BF5D File Offset: 0x0027A15D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x0027BF6C File Offset: 0x0027A16C
		public LordGymEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06008FF6 RID: 36854 RVA: 0x0027BF7C File Offset: 0x0027A17C
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

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06008FF7 RID: 36855 RVA: 0x0027BFB8 File Offset: 0x0027A1B8
		public int MarkId
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

		// Token: 0x06008FF8 RID: 36856 RVA: 0x0027BFF4 File Offset: 0x0027A1F4
		public int LordGymList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x0027C034 File Offset: 0x0027A234
		public int LordGymListLength
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

		// Token: 0x06008FFA RID: 36858 RVA: 0x0027C05F File Offset: 0x0027A25F
		public Span<int> GetLordGymListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x0027C06E File Offset: 0x0027A26E
		public int[] GetLordGymListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06008FFC RID: 36860 RVA: 0x0027C088 File Offset: 0x0027A288
		public string EntranceTitle
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

		// Token: 0x06008FFD RID: 36861 RVA: 0x0027C0C0 File Offset: 0x0027A2C0
		public Span<byte> GetEntranceTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x0027C0D0 File Offset: 0x0027A2D0
		public byte[] GetEntranceTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06008FFF RID: 36863 RVA: 0x0027C0E8 File Offset: 0x0027A2E8
		public string EntranceDescription
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

		// Token: 0x06009000 RID: 36864 RVA: 0x0027C120 File Offset: 0x0027A320
		public Span<byte> GetEntranceDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009001 RID: 36865 RVA: 0x0027C130 File Offset: 0x0027A330
		public byte[] GetEntranceDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06009002 RID: 36866 RVA: 0x0027C148 File Offset: 0x0027A348
		public int MeshId
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

		// Token: 0x06009003 RID: 36867 RVA: 0x0027C188 File Offset: 0x0027A388
		public float Zoom(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06009004 RID: 36868 RVA: 0x0027C1CC File Offset: 0x0027A3CC
		public int ZoomLength
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

		// Token: 0x06009005 RID: 36869 RVA: 0x0027C1F8 File Offset: 0x0027A3F8
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x0027C208 File Offset: 0x0027A408
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x0027C220 File Offset: 0x0027A420
		public float Location(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06009008 RID: 36872 RVA: 0x0027C264 File Offset: 0x0027A464
		public int LocationLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x0027C290 File Offset: 0x0027A490
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x0027C2A0 File Offset: 0x0027A4A0
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0027C2B8 File Offset: 0x0027A4B8
		public float Rotator(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x0600900C RID: 36876 RVA: 0x0027C2FC File Offset: 0x0027A4FC
		public int RotatorLength
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

		// Token: 0x0600900D RID: 36877 RVA: 0x0027C328 File Offset: 0x0027A528
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x0027C338 File Offset: 0x0027A538
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x0600900F RID: 36879 RVA: 0x0027C350 File Offset: 0x0027A550
		public string LordChangeMaterialController
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0027C388 File Offset: 0x0027A588
		public Span<byte> GetLordChangeMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0027C398 File Offset: 0x0027A598
		public byte[] GetLordChangeMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06009012 RID: 36882 RVA: 0x0027C3B0 File Offset: 0x0027A5B0
		public string LordStartMaterialController
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

		// Token: 0x06009013 RID: 36883 RVA: 0x0027C3E8 File Offset: 0x0027A5E8
		public Span<byte> GetLordStartMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x0027C3F8 File Offset: 0x0027A5F8
		public byte[] GetLordStartMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06009015 RID: 36885 RVA: 0x0027C410 File Offset: 0x0027A610
		public string LordIdleMaterialController
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

		// Token: 0x06009016 RID: 36886 RVA: 0x0027C448 File Offset: 0x0027A648
		public Span<byte> GetLordIdleMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x0027C458 File Offset: 0x0027A658
		public byte[] GetLordIdleMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06009018 RID: 36888 RVA: 0x0027C470 File Offset: 0x0027A670
		public bool IsGroup
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06009019 RID: 36889 RVA: 0x0027C4B0 File Offset: 0x0027A6B0
		public string LordUISceneEffect
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

		// Token: 0x0600901A RID: 36890 RVA: 0x0027C4E8 File Offset: 0x0027A6E8
		public Span<byte> GetLordUISceneEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x0027C4F8 File Offset: 0x0027A6F8
		public byte[] GetLordUISceneEffectArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x0600901C RID: 36892 RVA: 0x0027C510 File Offset: 0x0027A710
		public string StandAnim
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x0027C548 File Offset: 0x0027A748
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x0027C558 File Offset: 0x0027A758
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x0600901F RID: 36895 RVA: 0x0027C570 File Offset: 0x0027A770
		public bool IsDebug
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x0027C5B0 File Offset: 0x0027A7B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LocationIter()或GetLocationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Location()
		{
			LordGymEntrance lordGymEntrance = this;
			return lordGymEntrance.GetLocationArray() ?? Array.Empty<float>();
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x0027C5D4 File Offset: 0x0027A7D4
		[NullableContext(1)]
		public readonly IEnumerable<float> LocationIter()
		{
			LordGymEntrance.<LocationIter>d__67 <LocationIter>d__ = new LordGymEntrance.<LocationIter>d__67(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0027C5EC File Offset: 0x0027A7EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LordGymListIter()或GetLordGymListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LordGymList()
		{
			LordGymEntrance lordGymEntrance = this;
			return lordGymEntrance.GetLordGymListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x0027C610 File Offset: 0x0027A810
		[NullableContext(1)]
		public readonly IEnumerable<int> LordGymListIter()
		{
			LordGymEntrance.<LordGymListIter>d__69 <LordGymListIter>d__ = new LordGymEntrance.<LordGymListIter>d__69(-2);
			<LordGymListIter>d__.<>3__<>4__this = this;
			return <LordGymListIter>d__;
		}

		// Token: 0x06009024 RID: 36900 RVA: 0x0027C628 File Offset: 0x0027A828
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotatorIter()或GetRotatorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Rotator()
		{
			LordGymEntrance lordGymEntrance = this;
			return lordGymEntrance.GetRotatorArray() ?? Array.Empty<float>();
		}

		// Token: 0x06009025 RID: 36901 RVA: 0x0027C64C File Offset: 0x0027A84C
		[NullableContext(1)]
		public readonly IEnumerable<float> RotatorIter()
		{
			LordGymEntrance.<RotatorIter>d__71 <RotatorIter>d__ = new LordGymEntrance.<RotatorIter>d__71(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x0027C664 File Offset: 0x0027A864
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ZoomIter()或GetZoomBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Zoom()
		{
			LordGymEntrance lordGymEntrance = this;
			return lordGymEntrance.GetZoomArray() ?? Array.Empty<float>();
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0027C688 File Offset: 0x0027A888
		[NullableContext(1)]
		public readonly IEnumerable<float> ZoomIter()
		{
			LordGymEntrance.<ZoomIter>d__73 <ZoomIter>d__ = new LordGymEntrance.<ZoomIter>d__73(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x04004E7C RID: 20092
		private Table __p;
	}
}
