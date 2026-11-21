using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBD RID: 3261
	public struct DangoMonopolyProperty : IFlatbufferObject
	{
		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06006668 RID: 26216 RVA: 0x0022F3F9 File Offset: 0x0022D5F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x0022F406 File Offset: 0x0022D606
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x0022F410 File Offset: 0x0022D610
		public static DangoMonopolyProperty GetRootAsDangoMonopolyProperty(ByteBuffer _bb)
		{
			return DangoMonopolyProperty.GetRootAsDangoMonopolyProperty(_bb, default(DangoMonopolyProperty));
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x0022F42C File Offset: 0x0022D62C
		public static DangoMonopolyProperty GetRootAsDangoMonopolyProperty(ByteBuffer _bb, DangoMonopolyProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x0022F449 File Offset: 0x0022D649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x0022F458 File Offset: 0x0022D658
		public DangoMonopolyProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600666E RID: 26222 RVA: 0x0022F468 File Offset: 0x0022D668
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

		// Token: 0x0600666F RID: 26223 RVA: 0x0022F4A4 File Offset: 0x0022D6A4
		public int PropertyInfo(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x0022F4E4 File Offset: 0x0022D6E4
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

		// Token: 0x06006671 RID: 26225 RVA: 0x0022F50F File Offset: 0x0022D70F
		public Span<int> GetPropertyInfoBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x0022F51E File Offset: 0x0022D71E
		public int[] GetPropertyInfoArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06006673 RID: 26227 RVA: 0x0022F538 File Offset: 0x0022D738
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

		// Token: 0x06006674 RID: 26228 RVA: 0x0022F56F File Offset: 0x0022D76F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x0022F57E File Offset: 0x0022D77E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x0022F598 File Offset: 0x0022D798
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

		// Token: 0x06006677 RID: 26231 RVA: 0x0022F5D0 File Offset: 0x0022D7D0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x0022F5E0 File Offset: 0x0022D7E0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x0022F5F8 File Offset: 0x0022D7F8
		[NullableContext(1)]
		public int[] PropertyInfo()
		{
			return this.GetPropertyInfoArray();
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x0022F600 File Offset: 0x0022D800
		[NullableContext(1)]
		public IEnumerable<int> PropertyInfoIter()
		{
			DangoMonopolyProperty.<PropertyInfoIter>d__24 <PropertyInfoIter>d__ = new DangoMonopolyProperty.<PropertyInfoIter>d__24(-2);
			<PropertyInfoIter>d__.<>3__<>4__this = this;
			return <PropertyInfoIter>d__;
		}

		// Token: 0x040051EA RID: 20970
		private Table __p;
	}
}
