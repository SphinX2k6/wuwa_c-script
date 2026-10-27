using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E5 RID: 4325
	public struct SpringFestival : IFlatbufferObject
	{
		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600D850 RID: 55376 RVA: 0x0031ED59 File Offset: 0x0031CF59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D851 RID: 55377 RVA: 0x0031ED66 File Offset: 0x0031CF66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D852 RID: 55378 RVA: 0x0031ED70 File Offset: 0x0031CF70
		public static SpringFestival GetRootAsSpringFestival(ByteBuffer _bb)
		{
			return SpringFestival.GetRootAsSpringFestival(_bb, default(SpringFestival));
		}

		// Token: 0x0600D853 RID: 55379 RVA: 0x0031ED8C File Offset: 0x0031CF8C
		public static SpringFestival GetRootAsSpringFestival(ByteBuffer _bb, SpringFestival obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D854 RID: 55380 RVA: 0x0031EDA9 File Offset: 0x0031CFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D855 RID: 55381 RVA: 0x0031EDB8 File Offset: 0x0031CFB8
		public SpringFestival __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x0600D856 RID: 55382 RVA: 0x0031EDC8 File Offset: 0x0031CFC8
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

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x0600D857 RID: 55383 RVA: 0x0031EE04 File Offset: 0x0031D004
		public int InstanceId
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

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x0600D858 RID: 55384 RVA: 0x0031EE40 File Offset: 0x0031D040
		public int ScoreItemId
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

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0600D859 RID: 55385 RVA: 0x0031EE7C File Offset: 0x0031D07C
		public int ShopId
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

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0600D85A RID: 55386 RVA: 0x0031EEBC File Offset: 0x0031D0BC
		public int ShopNpcEntityId
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

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0600D85B RID: 55387 RVA: 0x0031EEFC File Offset: 0x0031D0FC
		public int SpareShopNpcEntityId
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

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600D85C RID: 55388 RVA: 0x0031EF3C File Offset: 0x0031D13C
		public string ShopNpcName
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

		// Token: 0x0600D85D RID: 55389 RVA: 0x0031EF74 File Offset: 0x0031D174
		public Span<byte> GetShopNpcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D85E RID: 55390 RVA: 0x0031EF84 File Offset: 0x0031D184
		public byte[] GetShopNpcNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0600D85F RID: 55391 RVA: 0x0031EF9C File Offset: 0x0031D19C
		public string ShopNpcSpeak
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

		// Token: 0x0600D860 RID: 55392 RVA: 0x0031EFD4 File Offset: 0x0031D1D4
		public Span<byte> GetShopNpcSpeakBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D861 RID: 55393 RVA: 0x0031EFE4 File Offset: 0x0031D1E4
		public byte[] GetShopNpcSpeakArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0600D862 RID: 55394 RVA: 0x0031EFFC File Offset: 0x0031D1FC
		public string ShopNpcStartMontage
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

		// Token: 0x0600D863 RID: 55395 RVA: 0x0031F034 File Offset: 0x0031D234
		public Span<byte> GetShopNpcStartMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x0031F044 File Offset: 0x0031D244
		public byte[] GetShopNpcStartMontageArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0600D865 RID: 55397 RVA: 0x0031F05C File Offset: 0x0031D25C
		public int VisionSkinItemId
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

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600D866 RID: 55398 RVA: 0x0031F09C File Offset: 0x0031D29C
		public string TrackRewardIconPath
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

		// Token: 0x0600D867 RID: 55399 RVA: 0x0031F0D4 File Offset: 0x0031D2D4
		public Span<byte> GetTrackRewardIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D868 RID: 55400 RVA: 0x0031F0E4 File Offset: 0x0031D2E4
		public byte[] GetTrackRewardIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D869 RID: 55401 RVA: 0x0031F0FC File Offset: 0x0031D2FC
		public int EntityWhiteList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600D86A RID: 55402 RVA: 0x0031F13C File Offset: 0x0031D33C
		public int EntityWhiteListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x0031F168 File Offset: 0x0031D368
		public Span<int> GetEntityWhiteListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x0031F178 File Offset: 0x0031D378
		public int[] GetEntityWhiteListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x0031F190 File Offset: 0x0031D390
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EntityWhiteListIter()或GetEntityWhiteListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EntityWhiteList()
		{
			SpringFestival springFestival = this;
			return springFestival.GetEntityWhiteListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D86E RID: 55406 RVA: 0x0031F1B4 File Offset: 0x0031D3B4
		[NullableContext(1)]
		public readonly IEnumerable<int> EntityWhiteListIter()
		{
			SpringFestival.<EntityWhiteListIter>d__44 <EntityWhiteListIter>d__ = new SpringFestival.<EntityWhiteListIter>d__44(-2);
			<EntityWhiteListIter>d__.<>3__<>4__this = this;
			return <EntityWhiteListIter>d__;
		}

		// Token: 0x04005218 RID: 21016
		private Table __p;
	}
}
