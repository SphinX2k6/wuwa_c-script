using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDB RID: 3035
	public struct DangoMonopolyProperty : IFlatbufferObject
	{
		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600608F RID: 24719 RVA: 0x0020FD95 File Offset: 0x0020DF95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x0020FDA2 File Offset: 0x0020DFA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x0020FDAC File Offset: 0x0020DFAC
		public static DangoMonopolyProperty GetRootAsDangoMonopolyProperty(ByteBuffer _bb)
		{
			return DangoMonopolyProperty.GetRootAsDangoMonopolyProperty(_bb, default(DangoMonopolyProperty));
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x0020FDC8 File Offset: 0x0020DFC8
		public static DangoMonopolyProperty GetRootAsDangoMonopolyProperty(ByteBuffer _bb, DangoMonopolyProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x0020FDE5 File Offset: 0x0020DFE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0020FDF4 File Offset: 0x0020DFF4
		public DangoMonopolyProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06006095 RID: 24725 RVA: 0x0020FE04 File Offset: 0x0020E004
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

		// Token: 0x06006096 RID: 24726 RVA: 0x0020FE40 File Offset: 0x0020E040
		public int PropertyInfo(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06006097 RID: 24727 RVA: 0x0020FE80 File Offset: 0x0020E080
		public int PropertyInfoLength
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

		// Token: 0x06006098 RID: 24728 RVA: 0x0020FEAB File Offset: 0x0020E0AB
		public Span<int> GetPropertyInfoBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x0020FEBA File Offset: 0x0020E0BA
		public int[] GetPropertyInfoArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x0020FED4 File Offset: 0x0020E0D4
		public string Title
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

		// Token: 0x0600609B RID: 24731 RVA: 0x0020FF0B File Offset: 0x0020E10B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x0020FF1A File Offset: 0x0020E11A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600609D RID: 24733 RVA: 0x0020FF34 File Offset: 0x0020E134
		public string Desc
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

		// Token: 0x0600609E RID: 24734 RVA: 0x0020FF6C File Offset: 0x0020E16C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x0020FF7C File Offset: 0x0020E17C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x0020FF94 File Offset: 0x0020E194
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropertyInfoIter()或GetPropertyInfoBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PropertyInfo()
		{
			DangoMonopolyProperty dangoMonopolyProperty = this;
			return dangoMonopolyProperty.GetPropertyInfoArray() ?? Array.Empty<int>();
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x0020FFB8 File Offset: 0x0020E1B8
		[NullableContext(1)]
		public readonly IEnumerable<int> PropertyInfoIter()
		{
			DangoMonopolyProperty.<PropertyInfoIter>d__24 <PropertyInfoIter>d__ = new DangoMonopolyProperty.<PropertyInfoIter>d__24(-2);
			<PropertyInfoIter>d__.<>3__<>4__this = this;
			return <PropertyInfoIter>d__;
		}

		// Token: 0x04004C08 RID: 19464
		private Table __p;
	}
}
