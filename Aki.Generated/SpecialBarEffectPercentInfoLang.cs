using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E4 RID: 4580
	public struct SpecialBarEffectPercentInfoLang : IFlatbufferObject
	{
		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x0600EB9B RID: 60315 RVA: 0x0034A980 File Offset: 0x00348B80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB9C RID: 60316 RVA: 0x0034A98D File Offset: 0x00348B8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x0034A994 File Offset: 0x00348B94
		public static SpecialBarEffectPercentInfoLang GetRootAsSpecialBarEffectPercentInfoLang(ByteBuffer _bb)
		{
			return SpecialBarEffectPercentInfoLang.GetRootAsSpecialBarEffectPercentInfoLang(_bb, default(SpecialBarEffectPercentInfoLang));
		}

		// Token: 0x0600EB9E RID: 60318 RVA: 0x0034A9B0 File Offset: 0x00348BB0
		public static SpecialBarEffectPercentInfoLang GetRootAsSpecialBarEffectPercentInfoLang(ByteBuffer _bb, SpecialBarEffectPercentInfoLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB9F RID: 60319 RVA: 0x0034A9CD File Offset: 0x00348BCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x0034A9DC File Offset: 0x00348BDC
		public SpecialBarEffectPercentInfoLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x0600EBA1 RID: 60321 RVA: 0x0034A9EC File Offset: 0x00348BEC
		public int MinPercent
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

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x0600EBA2 RID: 60322 RVA: 0x0034AA28 File Offset: 0x00348C28
		public int MaxPercent
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

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x0600EBA3 RID: 60323 RVA: 0x0034AA64 File Offset: 0x00348C64
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x0600EBA4 RID: 60324 RVA: 0x0034AAA4 File Offset: 0x00348CA4
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x0600EBA5 RID: 60325 RVA: 0x0034AAE8 File Offset: 0x00348CE8
		public int FloatParameterName
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

		// Token: 0x0400535D RID: 21341
		private Table __p;
	}
}
