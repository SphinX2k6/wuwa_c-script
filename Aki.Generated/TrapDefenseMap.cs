using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001165 RID: 4453
	public struct TrapDefenseMap : IFlatbufferObject
	{
		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x0600E3D5 RID: 58325 RVA: 0x0033938D File Offset: 0x0033758D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3D6 RID: 58326 RVA: 0x0033939A File Offset: 0x0033759A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3D7 RID: 58327 RVA: 0x003393A4 File Offset: 0x003375A4
		public static TrapDefenseMap GetRootAsTrapDefenseMap(ByteBuffer _bb)
		{
			return TrapDefenseMap.GetRootAsTrapDefenseMap(_bb, default(TrapDefenseMap));
		}

		// Token: 0x0600E3D8 RID: 58328 RVA: 0x003393C0 File Offset: 0x003375C0
		public static TrapDefenseMap GetRootAsTrapDefenseMap(ByteBuffer _bb, TrapDefenseMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3D9 RID: 58329 RVA: 0x003393DD File Offset: 0x003375DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3DA RID: 58330 RVA: 0x003393EC File Offset: 0x003375EC
		public TrapDefenseMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0600E3DB RID: 58331 RVA: 0x003393FC File Offset: 0x003375FC
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

		// Token: 0x0600E3DC RID: 58332 RVA: 0x00339438 File Offset: 0x00337638
		public float CenterOffset(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0600E3DD RID: 58333 RVA: 0x0033947C File Offset: 0x0033767C
		public int CenterOffsetLength
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

		// Token: 0x0600E3DE RID: 58334 RVA: 0x003394A7 File Offset: 0x003376A7
		public Span<float> GetCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x0600E3DF RID: 58335 RVA: 0x003394B6 File Offset: 0x003376B6
		public float[] GetCenterOffsetArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x0600E3E0 RID: 58336 RVA: 0x003394D0 File Offset: 0x003376D0
		public float UiOffset(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x00339514 File Offset: 0x00337714
		public int UiOffsetLength
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

		// Token: 0x0600E3E2 RID: 58338 RVA: 0x0033953F File Offset: 0x0033773F
		public Span<float> GetUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600E3E3 RID: 58339 RVA: 0x0033954E File Offset: 0x0033774E
		public float[] GetUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600E3E4 RID: 58340 RVA: 0x00339568 File Offset: 0x00337768
		public float BigMapUiOffset(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x003395AC File Offset: 0x003377AC
		public int BigMapUiOffsetLength
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

		// Token: 0x0600E3E6 RID: 58342 RVA: 0x003395D8 File Offset: 0x003377D8
		public Span<float> GetBigMapUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x0600E3E7 RID: 58343 RVA: 0x003395E8 File Offset: 0x003377E8
		public float[] GetBigMapUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0600E3E8 RID: 58344 RVA: 0x00339600 File Offset: 0x00337800
		public float MiniMapScale
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0600E3E9 RID: 58345 RVA: 0x00339644 File Offset: 0x00337844
		public float MapScale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0600E3EA RID: 58346 RVA: 0x00339688 File Offset: 0x00337888
		public string MiniMapResourcePath
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

		// Token: 0x0600E3EB RID: 58347 RVA: 0x003396C0 File Offset: 0x003378C0
		public Span<byte> GetMiniMapResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E3EC RID: 58348 RVA: 0x003396D0 File Offset: 0x003378D0
		public byte[] GetMiniMapResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0600E3ED RID: 58349 RVA: 0x003396E8 File Offset: 0x003378E8
		public string MiniMapLightResourcePath
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

		// Token: 0x0600E3EE RID: 58350 RVA: 0x00339720 File Offset: 0x00337920
		public Span<byte> GetMiniMapLightResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E3EF RID: 58351 RVA: 0x00339730 File Offset: 0x00337930
		public byte[] GetMiniMapLightResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0600E3F0 RID: 58352 RVA: 0x00339748 File Offset: 0x00337948
		public string MapResourcePath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E3F1 RID: 58353 RVA: 0x00339780 File Offset: 0x00337980
		public Span<byte> GetMapResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E3F2 RID: 58354 RVA: 0x00339790 File Offset: 0x00337990
		public byte[] GetMapResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E3F3 RID: 58355 RVA: 0x003397A8 File Offset: 0x003379A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BigMapUiOffsetIter()或GetBigMapUiOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] BigMapUiOffset()
		{
			TrapDefenseMap trapDefenseMap = this;
			return trapDefenseMap.GetBigMapUiOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x003397CC File Offset: 0x003379CC
		[NullableContext(1)]
		public readonly IEnumerable<float> BigMapUiOffsetIter()
		{
			TrapDefenseMap.<BigMapUiOffsetIter>d__42 <BigMapUiOffsetIter>d__ = new TrapDefenseMap.<BigMapUiOffsetIter>d__42(-2);
			<BigMapUiOffsetIter>d__.<>3__<>4__this = this;
			return <BigMapUiOffsetIter>d__;
		}

		// Token: 0x0600E3F5 RID: 58357 RVA: 0x003397E4 File Offset: 0x003379E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CenterOffsetIter()或GetCenterOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CenterOffset()
		{
			TrapDefenseMap trapDefenseMap = this;
			return trapDefenseMap.GetCenterOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600E3F6 RID: 58358 RVA: 0x00339808 File Offset: 0x00337A08
		[NullableContext(1)]
		public readonly IEnumerable<float> CenterOffsetIter()
		{
			TrapDefenseMap.<CenterOffsetIter>d__44 <CenterOffsetIter>d__ = new TrapDefenseMap.<CenterOffsetIter>d__44(-2);
			<CenterOffsetIter>d__.<>3__<>4__this = this;
			return <CenterOffsetIter>d__;
		}

		// Token: 0x0600E3F7 RID: 58359 RVA: 0x00339820 File Offset: 0x00337A20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiOffsetIter()或GetUiOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] UiOffset()
		{
			TrapDefenseMap trapDefenseMap = this;
			return trapDefenseMap.GetUiOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600E3F8 RID: 58360 RVA: 0x00339844 File Offset: 0x00337A44
		[NullableContext(1)]
		public readonly IEnumerable<float> UiOffsetIter()
		{
			TrapDefenseMap.<UiOffsetIter>d__46 <UiOffsetIter>d__ = new TrapDefenseMap.<UiOffsetIter>d__46(-2);
			<UiOffsetIter>d__.<>3__<>4__this = this;
			return <UiOffsetIter>d__;
		}

		// Token: 0x040052AB RID: 21163
		private Table __p;
	}
}
