using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4D RID: 3661
	public struct MotorFightRole : IFlatbufferObject
	{
		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x00290A1C File Offset: 0x0028EC1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009928 RID: 39208 RVA: 0x00290A29 File Offset: 0x0028EC29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009929 RID: 39209 RVA: 0x00290A30 File Offset: 0x0028EC30
		public static MotorFightRole GetRootAsMotorFightRole(ByteBuffer _bb)
		{
			return MotorFightRole.GetRootAsMotorFightRole(_bb, default(MotorFightRole));
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x00290A4C File Offset: 0x0028EC4C
		public static MotorFightRole GetRootAsMotorFightRole(ByteBuffer _bb, MotorFightRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x00290A69 File Offset: 0x0028EC69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x00290A78 File Offset: 0x0028EC78
		public MotorFightRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x0600992D RID: 39213 RVA: 0x00290A88 File Offset: 0x0028EC88
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

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x0600992E RID: 39214 RVA: 0x00290AC4 File Offset: 0x0028ECC4
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

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x0600992F RID: 39215 RVA: 0x00290B00 File Offset: 0x0028ED00
		public int Type
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

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06009930 RID: 39216 RVA: 0x00290B3C File Offset: 0x0028ED3C
		public int UnlockCondition
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

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06009931 RID: 39217 RVA: 0x00290B7C File Offset: 0x0028ED7C
		public int TrialRole
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

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06009932 RID: 39218 RVA: 0x00290BBC File Offset: 0x0028EDBC
		public int Effect
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

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06009933 RID: 39219 RVA: 0x00290BFC File Offset: 0x0028EDFC
		public string BuffName
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

		// Token: 0x06009934 RID: 39220 RVA: 0x00290C34 File Offset: 0x0028EE34
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009935 RID: 39221 RVA: 0x00290C44 File Offset: 0x0028EE44
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06009936 RID: 39222 RVA: 0x00290C5C File Offset: 0x0028EE5C
		public string BuffDesc
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

		// Token: 0x06009937 RID: 39223 RVA: 0x00290C94 File Offset: 0x0028EE94
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x00290CA4 File Offset: 0x0028EEA4
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x00290CBC File Offset: 0x0028EEBC
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x0600993A RID: 39226 RVA: 0x00290CF8 File Offset: 0x0028EEF8
		public int BuffDescParamLength
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

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600993B RID: 39227 RVA: 0x00290D24 File Offset: 0x0028EF24
		public string GenreDesc
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

		// Token: 0x0600993C RID: 39228 RVA: 0x00290D5C File Offset: 0x0028EF5C
		public Span<byte> GetGenreDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600993D RID: 39229 RVA: 0x00290D6C File Offset: 0x0028EF6C
		public byte[] GetGenreDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600993E RID: 39230 RVA: 0x00290D84 File Offset: 0x0028EF84
		public string RolePicture
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

		// Token: 0x0600993F RID: 39231 RVA: 0x00290DBC File Offset: 0x0028EFBC
		public Span<byte> GetRolePictureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009940 RID: 39232 RVA: 0x00290DCC File Offset: 0x0028EFCC
		public byte[] GetRolePictureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06009941 RID: 39233 RVA: 0x00290DE4 File Offset: 0x0028EFE4
		public string RankRolePicture
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

		// Token: 0x06009942 RID: 39234 RVA: 0x00290E1C File Offset: 0x0028F01C
		public Span<byte> GetRankRolePictureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009943 RID: 39235 RVA: 0x00290E2C File Offset: 0x0028F02C
		public byte[] GetRankRolePictureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06009944 RID: 39236 RVA: 0x00290E44 File Offset: 0x0028F044
		public string MotorStandAnimPath
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

		// Token: 0x06009945 RID: 39237 RVA: 0x00290E7C File Offset: 0x0028F07C
		public Span<byte> GetMotorStandAnimPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009946 RID: 39238 RVA: 0x00290E8C File Offset: 0x0028F08C
		public byte[] GetMotorStandAnimPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x00290EA4 File Offset: 0x0028F0A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffDescParamIter()或GetBuffDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x06009948 RID: 39240 RVA: 0x00290EB1 File Offset: 0x0028F0B1
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffDescParamIter()
		{
			MotorFightRole.<BuffDescParamIter>d__48 <BuffDescParamIter>d__ = new MotorFightRole.<BuffDescParamIter>d__48(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x04004EF6 RID: 20214
		private Table __p;
	}
}
