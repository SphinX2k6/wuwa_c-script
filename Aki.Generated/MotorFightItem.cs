using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E44 RID: 3652
	public struct MotorFightItem : IFlatbufferObject
	{
		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06009848 RID: 38984 RVA: 0x0028EAD9 File Offset: 0x0028CCD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x0028EAE6 File Offset: 0x0028CCE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x0028EAF0 File Offset: 0x0028CCF0
		public static MotorFightItem GetRootAsMotorFightItem(ByteBuffer _bb)
		{
			return MotorFightItem.GetRootAsMotorFightItem(_bb, default(MotorFightItem));
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x0028EB0C File Offset: 0x0028CD0C
		public static MotorFightItem GetRootAsMotorFightItem(ByteBuffer _bb, MotorFightItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x0028EB29 File Offset: 0x0028CD29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x0028EB38 File Offset: 0x0028CD38
		public MotorFightItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600984E RID: 38990 RVA: 0x0028EB48 File Offset: 0x0028CD48
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

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600984F RID: 38991 RVA: 0x0028EB84 File Offset: 0x0028CD84
		public int ActivityId
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

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06009850 RID: 38992 RVA: 0x0028EBC0 File Offset: 0x0028CDC0
		public int GetLimitNumber
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

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06009851 RID: 38993 RVA: 0x0028EBFC File Offset: 0x0028CDFC
		public int Type
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

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06009852 RID: 38994 RVA: 0x0028EC3C File Offset: 0x0028CE3C
		public int Quality
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

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06009853 RID: 38995 RVA: 0x0028EC7C File Offset: 0x0028CE7C
		public int UnlockCondition
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

		// Token: 0x06009854 RID: 38996 RVA: 0x0028ECBC File Offset: 0x0028CEBC
		public int Effects(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06009855 RID: 38997 RVA: 0x0028ECFC File Offset: 0x0028CEFC
		public int EffectsLength
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

		// Token: 0x06009856 RID: 38998 RVA: 0x0028ED28 File Offset: 0x0028CF28
		public Span<int> GetEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x0028ED38 File Offset: 0x0028CF38
		public int[] GetEffectsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06009858 RID: 39000 RVA: 0x0028ED50 File Offset: 0x0028CF50
		public string Name
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

		// Token: 0x06009859 RID: 39001 RVA: 0x0028ED88 File Offset: 0x0028CF88
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x0028ED98 File Offset: 0x0028CF98
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x0600985B RID: 39003 RVA: 0x0028EDB0 File Offset: 0x0028CFB0
		public string Desc
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

		// Token: 0x0600985C RID: 39004 RVA: 0x0028EDE8 File Offset: 0x0028CFE8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600985D RID: 39005 RVA: 0x0028EDF8 File Offset: 0x0028CFF8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600985E RID: 39006 RVA: 0x0028EE10 File Offset: 0x0028D010
		public string DescParam(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x0600985F RID: 39007 RVA: 0x0028EE4C File Offset: 0x0028D04C
		public int DescParamLength
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

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06009860 RID: 39008 RVA: 0x0028EE78 File Offset: 0x0028D078
		public string Icon
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

		// Token: 0x06009861 RID: 39009 RVA: 0x0028EEB0 File Offset: 0x0028D0B0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x0028EEC0 File Offset: 0x0028D0C0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06009863 RID: 39011 RVA: 0x0028EED8 File Offset: 0x0028D0D8
		public string IconBig
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

		// Token: 0x06009864 RID: 39012 RVA: 0x0028EF10 File Offset: 0x0028D110
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x0028EF20 File Offset: 0x0028D120
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06009866 RID: 39014 RVA: 0x0028EF38 File Offset: 0x0028D138
		public bool IsShowInHandBook
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x0028EF78 File Offset: 0x0028D178
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamIter()或GetDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x06009868 RID: 39016 RVA: 0x0028EF85 File Offset: 0x0028D185
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamIter()
		{
			MotorFightItem.<DescParamIter>d__47 <DescParamIter>d__ = new MotorFightItem.<DescParamIter>d__47(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x0028EF9C File Offset: 0x0028D19C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Effects()
		{
			MotorFightItem motorFightItem = this;
			return motorFightItem.GetEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600986A RID: 39018 RVA: 0x0028EFC0 File Offset: 0x0028D1C0
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectsIter()
		{
			MotorFightItem.<EffectsIter>d__49 <EffectsIter>d__ = new MotorFightItem.<EffectsIter>d__49(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x04004EEC RID: 20204
		private Table __p;
	}
}
