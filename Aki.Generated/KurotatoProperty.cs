using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAE RID: 3502
	public struct KurotatoProperty : IFlatbufferObject
	{
		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06008B14 RID: 35604 RVA: 0x00271394 File Offset: 0x0026F594
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x002713A1 File Offset: 0x0026F5A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x002713A8 File Offset: 0x0026F5A8
		public static KurotatoProperty GetRootAsKurotatoProperty(ByteBuffer _bb)
		{
			return KurotatoProperty.GetRootAsKurotatoProperty(_bb, default(KurotatoProperty));
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x002713C4 File Offset: 0x0026F5C4
		public static KurotatoProperty GetRootAsKurotatoProperty(ByteBuffer _bb, KurotatoProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x002713E1 File Offset: 0x0026F5E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x002713F0 File Offset: 0x0026F5F0
		public KurotatoProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06008B1A RID: 35610 RVA: 0x00271400 File Offset: 0x0026F600
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

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06008B1B RID: 35611 RVA: 0x0027143C File Offset: 0x0026F63C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x00271473 File Offset: 0x0026F673
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x00271482 File Offset: 0x0026F682
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06008B1E RID: 35614 RVA: 0x0027149C File Offset: 0x0026F69C
		public string KSCBasePropertyVarName
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

		// Token: 0x06008B1F RID: 35615 RVA: 0x002714D3 File Offset: 0x0026F6D3
		public Span<byte> GetKSCBasePropertyVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x002714E2 File Offset: 0x0026F6E2
		public byte[] GetKSCBasePropertyVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x002714FC File Offset: 0x0026F6FC
		public string ShowName
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

		// Token: 0x06008B22 RID: 35618 RVA: 0x00271534 File Offset: 0x0026F734
		public Span<byte> GetShowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x00271544 File Offset: 0x0026F744
		public byte[] GetShowNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06008B24 RID: 35620 RVA: 0x0027155C File Offset: 0x0026F75C
		public string WeaponPropertyDesc
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

		// Token: 0x06008B25 RID: 35621 RVA: 0x00271594 File Offset: 0x0026F794
		public Span<byte> GetWeaponPropertyDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x002715A4 File Offset: 0x0026F7A4
		public byte[] GetWeaponPropertyDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x002715BC File Offset: 0x0026F7BC
		public string WeaponPropertyDescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06008B28 RID: 35624 RVA: 0x002715F8 File Offset: 0x0026F7F8
		public int WeaponPropertyDescParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06008B29 RID: 35625 RVA: 0x00271624 File Offset: 0x0026F824
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x00271664 File Offset: 0x0026F864
		public string Desc
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

		// Token: 0x06008B2B RID: 35627 RVA: 0x0027169C File Offset: 0x0026F89C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x002716AC File Offset: 0x0026F8AC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x002716C4 File Offset: 0x0026F8C4
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06008B2E RID: 35630 RVA: 0x00271700 File Offset: 0x0026F900
		public int DescParamsLength
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

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06008B2F RID: 35631 RVA: 0x0027172C File Offset: 0x0026F92C
		public int BasicValue
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

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06008B30 RID: 35632 RVA: 0x0027176C File Offset: 0x0026F96C
		public int Min
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return int.MinValue;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06008B31 RID: 35633 RVA: 0x002717B0 File Offset: 0x0026F9B0
		public int Max
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return int.MaxValue;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06008B32 RID: 35634 RVA: 0x002717F4 File Offset: 0x0026F9F4
		public string Icon
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

		// Token: 0x06008B33 RID: 35635 RVA: 0x0027182C File Offset: 0x0026FA2C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x0027183C File Offset: 0x0026FA3C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06008B35 RID: 35637 RVA: 0x00271854 File Offset: 0x0026FA54
		public int RoleType
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06008B36 RID: 35638 RVA: 0x00271894 File Offset: 0x0026FA94
		public int ShowType
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06008B37 RID: 35639 RVA: 0x002718D4 File Offset: 0x0026FAD4
		public int Precision
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06008B38 RID: 35640 RVA: 0x00271914 File Offset: 0x0026FB14
		public bool IsBlockFloat
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008B39 RID: 35641 RVA: 0x00271954 File Offset: 0x0026FB54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x06008B3A RID: 35642 RVA: 0x00271961 File Offset: 0x0026FB61
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			KurotatoProperty.<DescParamsIter>d__57 <DescParamsIter>d__ = new KurotatoProperty.<DescParamsIter>d__57(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x06008B3B RID: 35643 RVA: 0x00271976 File Offset: 0x0026FB76
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponPropertyDescParamIter()或GetWeaponPropertyDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] WeaponPropertyDescParam()
		{
			return this.WeaponPropertyDescParamIter().ToArray<string>();
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x00271983 File Offset: 0x0026FB83
		[NullableContext(1)]
		public readonly IEnumerable<string> WeaponPropertyDescParamIter()
		{
			KurotatoProperty.<WeaponPropertyDescParamIter>d__59 <WeaponPropertyDescParamIter>d__ = new KurotatoProperty.<WeaponPropertyDescParamIter>d__59(-2);
			<WeaponPropertyDescParamIter>d__.<>3__<>4__this = this;
			return <WeaponPropertyDescParamIter>d__;
		}

		// Token: 0x04004E40 RID: 20032
		private Table __p;
	}
}
