using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEE RID: 3310
	public struct GamePlayScanComposite : IFlatbufferObject
	{
		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06007964 RID: 31076 RVA: 0x00248C55 File Offset: 0x00246E55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x00248C62 File Offset: 0x00246E62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x00248C6C File Offset: 0x00246E6C
		public static GamePlayScanComposite GetRootAsGamePlayScanComposite(ByteBuffer _bb)
		{
			return GamePlayScanComposite.GetRootAsGamePlayScanComposite(_bb, default(GamePlayScanComposite));
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x00248C88 File Offset: 0x00246E88
		public static GamePlayScanComposite GetRootAsGamePlayScanComposite(ByteBuffer _bb, GamePlayScanComposite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x00248CA5 File Offset: 0x00246EA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x00248CB4 File Offset: 0x00246EB4
		public GamePlayScanComposite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x0600796A RID: 31082 RVA: 0x00248CC4 File Offset: 0x00246EC4
		public int UId
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

		// Token: 0x0600796B RID: 31083 RVA: 0x00248D00 File Offset: 0x00246F00
		public int ScanInfos(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x0600796C RID: 31084 RVA: 0x00248D40 File Offset: 0x00246F40
		public int ScanInfosLength
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

		// Token: 0x0600796D RID: 31085 RVA: 0x00248D6B File Offset: 0x00246F6B
		public Span<int> GetScanInfosBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x00248D7A File Offset: 0x00246F7A
		public int[] GetScanInfosArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x00248D94 File Offset: 0x00246F94
		public string ItemMaterialDataPath
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

		// Token: 0x06007970 RID: 31088 RVA: 0x00248DCB File Offset: 0x00246FCB
		public Span<byte> GetItemMaterialDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x00248DDA File Offset: 0x00246FDA
		public byte[] GetItemMaterialDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x00248DF4 File Offset: 0x00246FF4
		public string NearVoiceEffectPath
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

		// Token: 0x06007973 RID: 31091 RVA: 0x00248E2C File Offset: 0x0024702C
		public Span<byte> GetNearVoiceEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x00248E3C File Offset: 0x0024703C
		public byte[] GetNearVoiceEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06007975 RID: 31093 RVA: 0x00248E54 File Offset: 0x00247054
		public string FarVoiceEffectPath
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

		// Token: 0x06007976 RID: 31094 RVA: 0x00248E8C File Offset: 0x0024708C
		public Span<byte> GetFarVoiceEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x00248E9C File Offset: 0x0024709C
		public byte[] GetFarVoiceEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06007978 RID: 31096 RVA: 0x00248EB4 File Offset: 0x002470B4
		public string ScanConcealEffectPath
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

		// Token: 0x06007979 RID: 31097 RVA: 0x00248EEC File Offset: 0x002470EC
		public Span<byte> GetScanConcealEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x00248EFC File Offset: 0x002470FC
		public byte[] GetScanConcealEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600797B RID: 31099 RVA: 0x00248F14 File Offset: 0x00247114
		public float InteractionEffectInterval
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 8f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x0600797C RID: 31100 RVA: 0x00248F58 File Offset: 0x00247158
		public bool ShowDistance
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x0600797D RID: 31101 RVA: 0x00248F98 File Offset: 0x00247198
		public bool ShowInteractionEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x0600797E RID: 31102 RVA: 0x00248FD8 File Offset: 0x002471D8
		public bool ClampToEllipse
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x00249018 File Offset: 0x00247218
		public string ScanAudioEvent
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

		// Token: 0x06007980 RID: 31104 RVA: 0x00249050 File Offset: 0x00247250
		public Span<byte> GetScanAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x00249060 File Offset: 0x00247260
		public byte[] GetScanAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06007982 RID: 31106 RVA: 0x00249078 File Offset: 0x00247278
		public bool TriggerRoleAudio
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x002490B8 File Offset: 0x002472B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ScanInfosIter()或GetScanInfosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ScanInfos()
		{
			GamePlayScanComposite gamePlayScanComposite = this;
			return gamePlayScanComposite.GetScanInfosArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x002490DC File Offset: 0x002472DC
		[NullableContext(1)]
		public readonly IEnumerable<int> ScanInfosIter()
		{
			GamePlayScanComposite.<ScanInfosIter>d__46 <ScanInfosIter>d__ = new GamePlayScanComposite.<ScanInfosIter>d__46(-2);
			<ScanInfosIter>d__.<>3__<>4__this = this;
			return <ScanInfosIter>d__;
		}

		// Token: 0x04004D5F RID: 19807
		private Table __p;
	}
}
