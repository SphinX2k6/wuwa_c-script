using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE5 RID: 3813
	public struct PhantomFetter : IFlatbufferObject
	{
		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x0600A864 RID: 43108 RVA: 0x002B2BE4 File Offset: 0x002B0DE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x002B2BF1 File Offset: 0x002B0DF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x002B2BF8 File Offset: 0x002B0DF8
		public static PhantomFetter GetRootAsPhantomFetter(ByteBuffer _bb)
		{
			return PhantomFetter.GetRootAsPhantomFetter(_bb, default(PhantomFetter));
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x002B2C14 File Offset: 0x002B0E14
		public static PhantomFetter GetRootAsPhantomFetter(ByteBuffer _bb, PhantomFetter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x002B2C31 File Offset: 0x002B0E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x002B2C40 File Offset: 0x002B0E40
		public PhantomFetter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x0600A86A RID: 43114 RVA: 0x002B2C50 File Offset: 0x002B0E50
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

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x0600A86B RID: 43115 RVA: 0x002B2C8C File Offset: 0x002B0E8C
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

		// Token: 0x0600A86C RID: 43116 RVA: 0x002B2CC3 File Offset: 0x002B0EC3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x002B2CD2 File Offset: 0x002B0ED2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x002B2CEC File Offset: 0x002B0EEC
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x0600A86F RID: 43119 RVA: 0x002B2D38 File Offset: 0x002B0F38
		public int BuffIdsLength
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

		// Token: 0x0600A870 RID: 43120 RVA: 0x002B2D63 File Offset: 0x002B0F63
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600A871 RID: 43121 RVA: 0x002B2D77 File Offset: 0x002B0F77
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600A872 RID: 43122 RVA: 0x002B2DB4 File Offset: 0x002B0FB4
		public ConfigPropValue? AddProp(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x0600A873 RID: 43123 RVA: 0x002B2E18 File Offset: 0x002B1018
		public int AddPropLength
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

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x0600A874 RID: 43124 RVA: 0x002B2E44 File Offset: 0x002B1044
		public string EffectDescription
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

		// Token: 0x0600A875 RID: 43125 RVA: 0x002B2E7C File Offset: 0x002B107C
		public Span<byte> GetEffectDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A876 RID: 43126 RVA: 0x002B2E8C File Offset: 0x002B108C
		public byte[] GetEffectDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x0600A877 RID: 43127 RVA: 0x002B2EA4 File Offset: 0x002B10A4
		public string FetterIcon
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

		// Token: 0x0600A878 RID: 43128 RVA: 0x002B2EDC File Offset: 0x002B10DC
		public Span<byte> GetFetterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A879 RID: 43129 RVA: 0x002B2EEC File Offset: 0x002B10EC
		public byte[] GetFetterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x0600A87A RID: 43130 RVA: 0x002B2F04 File Offset: 0x002B1104
		public string SimplyEffectDesc
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

		// Token: 0x0600A87B RID: 43131 RVA: 0x002B2F3C File Offset: 0x002B113C
		public Span<byte> GetSimplyEffectDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x002B2F4C File Offset: 0x002B114C
		public byte[] GetSimplyEffectDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x002B2F64 File Offset: 0x002B1164
		public string EffectDescriptionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x0600A87E RID: 43134 RVA: 0x002B2FA0 File Offset: 0x002B11A0
		public int EffectDescriptionParamLength
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

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x0600A87F RID: 43135 RVA: 0x002B2FCC File Offset: 0x002B11CC
		public string EffectDefineDescription
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

		// Token: 0x0600A880 RID: 43136 RVA: 0x002B3004 File Offset: 0x002B1204
		public Span<byte> GetEffectDefineDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x002B3014 File Offset: 0x002B1214
		public byte[] GetEffectDefineDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x0600A882 RID: 43138 RVA: 0x002B302C File Offset: 0x002B122C
		public int Priority
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

		// Token: 0x0600A883 RID: 43139 RVA: 0x002B3069 File Offset: 0x002B1269
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddPropIter()或GetAddPropBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] AddProp()
		{
			return this.AddPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600A884 RID: 43140 RVA: 0x002B3076 File Offset: 0x002B1276
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> AddPropIter()
		{
			PhantomFetter.<AddPropIter>d__44 <AddPropIter>d__ = new PhantomFetter.<AddPropIter>d__44(-2);
			<AddPropIter>d__.<>3__<>4__this = this;
			return <AddPropIter>d__;
		}

		// Token: 0x0600A885 RID: 43141 RVA: 0x002B308C File Offset: 0x002B128C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			PhantomFetter phantomFetter = this;
			return phantomFetter.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600A886 RID: 43142 RVA: 0x002B30B0 File Offset: 0x002B12B0
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			PhantomFetter.<BuffIdsIter>d__46 <BuffIdsIter>d__ = new PhantomFetter.<BuffIdsIter>d__46(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x002B30C5 File Offset: 0x002B12C5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectDescriptionParamIter()或GetEffectDescriptionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EffectDescriptionParam()
		{
			return this.EffectDescriptionParamIter().ToArray<string>();
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x002B30D2 File Offset: 0x002B12D2
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectDescriptionParamIter()
		{
			PhantomFetter.<EffectDescriptionParamIter>d__48 <EffectDescriptionParamIter>d__ = new PhantomFetter.<EffectDescriptionParamIter>d__48(-2);
			<EffectDescriptionParamIter>d__.<>3__<>4__this = this;
			return <EffectDescriptionParamIter>d__;
		}

		// Token: 0x04004FA6 RID: 20390
		private Table __p;
	}
}
