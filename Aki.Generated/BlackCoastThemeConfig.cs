using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B35 RID: 2869
	public struct BlackCoastThemeConfig : IFlatbufferObject
	{
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06004D6F RID: 19823 RVA: 0x001E401D File Offset: 0x001E221D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x001E402A File Offset: 0x001E222A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x001E4034 File Offset: 0x001E2234
		public static BlackCoastThemeConfig GetRootAsBlackCoastThemeConfig(ByteBuffer _bb)
		{
			return BlackCoastThemeConfig.GetRootAsBlackCoastThemeConfig(_bb, default(BlackCoastThemeConfig));
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x001E4050 File Offset: 0x001E2250
		public static BlackCoastThemeConfig GetRootAsBlackCoastThemeConfig(ByteBuffer _bb, BlackCoastThemeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x001E406D File Offset: 0x001E226D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x001E407C File Offset: 0x001E227C
		public BlackCoastThemeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06004D75 RID: 19829 RVA: 0x001E408C File Offset: 0x001E228C
		public int ActivityId
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06004D76 RID: 19830 RVA: 0x001E40C8 File Offset: 0x001E22C8
		public int ItemId
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

		// Token: 0x06004D77 RID: 19831 RVA: 0x001E4104 File Offset: 0x001E2304
		public int WeaponPreviewId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06004D78 RID: 19832 RVA: 0x001E4144 File Offset: 0x001E2344
		public int WeaponPreviewIdLength
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

		// Token: 0x06004D79 RID: 19833 RVA: 0x001E416F File Offset: 0x001E236F
		public Span<int> GetWeaponPreviewIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x001E417E File Offset: 0x001E237E
		public int[] GetWeaponPreviewIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x001E4198 File Offset: 0x001E2398
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponPreviewIdIter()或GetWeaponPreviewIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponPreviewId()
		{
			BlackCoastThemeConfig blackCoastThemeConfig = this;
			return blackCoastThemeConfig.GetWeaponPreviewIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x001E41BC File Offset: 0x001E23BC
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponPreviewIdIter()
		{
			BlackCoastThemeConfig.<WeaponPreviewIdIter>d__18 <WeaponPreviewIdIter>d__ = new BlackCoastThemeConfig.<WeaponPreviewIdIter>d__18(-2);
			<WeaponPreviewIdIter>d__.<>3__<>4__this = this;
			return <WeaponPreviewIdIter>d__;
		}

		// Token: 0x04004B30 RID: 19248
		private Table __p;
	}
}
