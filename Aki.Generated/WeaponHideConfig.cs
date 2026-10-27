using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001195 RID: 4501
	public struct WeaponHideConfig : IFlatbufferObject
	{
		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x0600E7DD RID: 59357 RVA: 0x00342835 File Offset: 0x00340A35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x00342842 File Offset: 0x00340A42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7DF RID: 59359 RVA: 0x0034284C File Offset: 0x00340A4C
		public static WeaponHideConfig GetRootAsWeaponHideConfig(ByteBuffer _bb)
		{
			return WeaponHideConfig.GetRootAsWeaponHideConfig(_bb, default(WeaponHideConfig));
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x00342868 File Offset: 0x00340A68
		public static WeaponHideConfig GetRootAsWeaponHideConfig(ByteBuffer _bb, WeaponHideConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x00342885 File Offset: 0x00340A85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x00342894 File Offset: 0x00340A94
		public WeaponHideConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x003428A4 File Offset: 0x00340AA4
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

		// Token: 0x0600E7E4 RID: 59364 RVA: 0x003428E0 File Offset: 0x00340AE0
		public string HideWeaponTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x0600E7E5 RID: 59365 RVA: 0x0034291C File Offset: 0x00340B1C
		public int HideWeaponTagsLength
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

		// Token: 0x0600E7E6 RID: 59366 RVA: 0x00342947 File Offset: 0x00340B47
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HideWeaponTagsIter()或GetHideWeaponTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] HideWeaponTags()
		{
			return this.HideWeaponTagsIter().ToArray<string>();
		}

		// Token: 0x0600E7E7 RID: 59367 RVA: 0x00342954 File Offset: 0x00340B54
		[NullableContext(1)]
		public readonly IEnumerable<string> HideWeaponTagsIter()
		{
			WeaponHideConfig.<HideWeaponTagsIter>d__14 <HideWeaponTagsIter>d__ = new WeaponHideConfig.<HideWeaponTagsIter>d__14(-2);
			<HideWeaponTagsIter>d__.<>3__<>4__this = this;
			return <HideWeaponTagsIter>d__;
		}

		// Token: 0x040052E0 RID: 21216
		private Table __p;
	}
}
