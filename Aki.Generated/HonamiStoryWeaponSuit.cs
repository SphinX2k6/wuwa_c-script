using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D53 RID: 3411
	public struct HonamiStoryWeaponSuit : IFlatbufferObject
	{
		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x060081E9 RID: 33257 RVA: 0x0025BCBC File Offset: 0x00259EBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060081EA RID: 33258 RVA: 0x0025BCC9 File Offset: 0x00259EC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x0025BCD0 File Offset: 0x00259ED0
		public static HonamiStoryWeaponSuit GetRootAsHonamiStoryWeaponSuit(ByteBuffer _bb)
		{
			return HonamiStoryWeaponSuit.GetRootAsHonamiStoryWeaponSuit(_bb, default(HonamiStoryWeaponSuit));
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x0025BCEC File Offset: 0x00259EEC
		public static HonamiStoryWeaponSuit GetRootAsHonamiStoryWeaponSuit(ByteBuffer _bb, HonamiStoryWeaponSuit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x0025BD09 File Offset: 0x00259F09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x0025BD18 File Offset: 0x00259F18
		public HonamiStoryWeaponSuit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x060081EF RID: 33263 RVA: 0x0025BD28 File Offset: 0x00259F28
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

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x060081F0 RID: 33264 RVA: 0x0025BD64 File Offset: 0x00259F64
		public int WeaponPluginType
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

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x060081F1 RID: 33265 RVA: 0x0025BDA0 File Offset: 0x00259FA0
		public int NeedNum
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

		// Token: 0x060081F2 RID: 33266 RVA: 0x0025BDDC File Offset: 0x00259FDC
		public int BuffTempId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x060081F3 RID: 33267 RVA: 0x0025BE1C File Offset: 0x0025A01C
		public int BuffTempIdLength
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

		// Token: 0x060081F4 RID: 33268 RVA: 0x0025BE48 File Offset: 0x0025A048
		public Span<int> GetBuffTempIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x0025BE58 File Offset: 0x0025A058
		public int[] GetBuffTempIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x060081F6 RID: 33270 RVA: 0x0025BE70 File Offset: 0x0025A070
		public int EnhanceLevel
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

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x060081F7 RID: 33271 RVA: 0x0025BEB0 File Offset: 0x0025A0B0
		public string Name
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

		// Token: 0x060081F8 RID: 33272 RVA: 0x0025BEE8 File Offset: 0x0025A0E8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x0025BEF8 File Offset: 0x0025A0F8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x060081FA RID: 33274 RVA: 0x0025BF10 File Offset: 0x0025A110
		public string Desc
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

		// Token: 0x060081FB RID: 33275 RVA: 0x0025BF48 File Offset: 0x0025A148
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x0025BF58 File Offset: 0x0025A158
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x0025BF70 File Offset: 0x0025A170
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x060081FE RID: 33278 RVA: 0x0025BFAC File Offset: 0x0025A1AC
		public int DescArgsLength
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

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x060081FF RID: 33279 RVA: 0x0025BFD8 File Offset: 0x0025A1D8
		public string DescSimple
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

		// Token: 0x06008200 RID: 33280 RVA: 0x0025C010 File Offset: 0x0025A210
		public Span<byte> GetDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x0025C020 File Offset: 0x0025A220
		public byte[] GetDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x0025C038 File Offset: 0x0025A238
		public string DescSimpleArgs(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06008203 RID: 33283 RVA: 0x0025C074 File Offset: 0x0025A274
		public int DescSimpleArgsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x0025C0A0 File Offset: 0x0025A2A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffTempIdIter()或GetBuffTempIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffTempId()
		{
			HonamiStoryWeaponSuit honamiStoryWeaponSuit = this;
			return honamiStoryWeaponSuit.GetBuffTempIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x0025C0C4 File Offset: 0x0025A2C4
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffTempIdIter()
		{
			HonamiStoryWeaponSuit.<BuffTempIdIter>d__40 <BuffTempIdIter>d__ = new HonamiStoryWeaponSuit.<BuffTempIdIter>d__40(-2);
			<BuffTempIdIter>d__.<>3__<>4__this = this;
			return <BuffTempIdIter>d__;
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x0025C0D9 File Offset: 0x0025A2D9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x0025C0E6 File Offset: 0x0025A2E6
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			HonamiStoryWeaponSuit.<DescArgsIter>d__42 <DescArgsIter>d__ = new HonamiStoryWeaponSuit.<DescArgsIter>d__42(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x0025C0FB File Offset: 0x0025A2FB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescSimpleArgsIter()或GetDescSimpleArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescSimpleArgs()
		{
			return this.DescSimpleArgsIter().ToArray<string>();
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x0025C108 File Offset: 0x0025A308
		[NullableContext(1)]
		public readonly IEnumerable<string> DescSimpleArgsIter()
		{
			HonamiStoryWeaponSuit.<DescSimpleArgsIter>d__44 <DescSimpleArgsIter>d__ = new HonamiStoryWeaponSuit.<DescSimpleArgsIter>d__44(-2);
			<DescSimpleArgsIter>d__.<>3__<>4__this = this;
			return <DescSimpleArgsIter>d__;
		}

		// Token: 0x04004DD2 RID: 19922
		private Table __p;
	}
}
