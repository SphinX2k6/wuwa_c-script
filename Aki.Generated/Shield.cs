using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A2 RID: 4514
	public struct Shield : IFlatbufferObject
	{
		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600D962 RID: 55650 RVA: 0x0032D9A1 File Offset: 0x0032BBA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D963 RID: 55651 RVA: 0x0032D9AE File Offset: 0x0032BBAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D964 RID: 55652 RVA: 0x0032D9B8 File Offset: 0x0032BBB8
		public static Shield GetRootAsShield(ByteBuffer _bb)
		{
			return Shield.GetRootAsShield(_bb, default(Shield));
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x0032D9D4 File Offset: 0x0032BBD4
		public static Shield GetRootAsShield(ByteBuffer _bb, Shield obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D966 RID: 55654 RVA: 0x0032D9F1 File Offset: 0x0032BBF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D967 RID: 55655 RVA: 0x0032DA00 File Offset: 0x0032BC00
		public Shield __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600D968 RID: 55656 RVA: 0x0032DA10 File Offset: 0x0032BC10
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

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600D969 RID: 55657 RVA: 0x0032DA4C File Offset: 0x0032BC4C
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600D96A RID: 55658 RVA: 0x0032DA88 File Offset: 0x0032BC88
		public int RefrenceAttribute
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

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600D96B RID: 55659 RVA: 0x0032DAC4 File Offset: 0x0032BCC4
		public int AttributeType
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

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600D96C RID: 55660 RVA: 0x0032DB04 File Offset: 0x0032BD04
		public int FormationPropValueType
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

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600D96D RID: 55661 RVA: 0x0032DB44 File Offset: 0x0032BD44
		public int RefrenceTarget
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

		// Token: 0x0600D96E RID: 55662 RVA: 0x0032DB84 File Offset: 0x0032BD84
		public float AttributeRate(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600D96F RID: 55663 RVA: 0x0032DBC8 File Offset: 0x0032BDC8
		public int AttributeRateLength
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

		// Token: 0x0600D970 RID: 55664 RVA: 0x0032DBF4 File Offset: 0x0032BDF4
		public Span<float> GetAttributeRateBytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x0032DC04 File Offset: 0x0032BE04
		public float[] GetAttributeRateArray()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x0032DC1C File Offset: 0x0032BE1C
		public float Value(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600D973 RID: 55667 RVA: 0x0032DC60 File Offset: 0x0032BE60
		public int ValueLength
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

		// Token: 0x0600D974 RID: 55668 RVA: 0x0032DC8C File Offset: 0x0032BE8C
		public Span<float> GetValueBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x0600D975 RID: 55669 RVA: 0x0032DC9C File Offset: 0x0032BE9C
		public float[] GetValueArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x0600D976 RID: 55670 RVA: 0x0032DCB4 File Offset: 0x0032BEB4
		[NullableContext(1)]
		public float[] AttributeRate()
		{
			return this.GetAttributeRateArray();
		}

		// Token: 0x0600D977 RID: 55671 RVA: 0x0032DCBC File Offset: 0x0032BEBC
		[NullableContext(1)]
		public IEnumerable<float> AttributeRateIter()
		{
			Shield.<AttributeRateIter>d__31 <AttributeRateIter>d__ = new Shield.<AttributeRateIter>d__31(-2);
			<AttributeRateIter>d__.<>3__<>4__this = this;
			return <AttributeRateIter>d__;
		}

		// Token: 0x0600D978 RID: 55672 RVA: 0x0032DCD1 File Offset: 0x0032BED1
		[NullableContext(1)]
		public float[] Value()
		{
			return this.GetValueArray();
		}

		// Token: 0x0600D979 RID: 55673 RVA: 0x0032DCD9 File Offset: 0x0032BED9
		[NullableContext(1)]
		public IEnumerable<float> ValueIter()
		{
			Shield.<ValueIter>d__33 <ValueIter>d__ = new Shield.<ValueIter>d__33(-2);
			<ValueIter>d__.<>3__<>4__this = this;
			return <ValueIter>d__;
		}

		// Token: 0x040057B5 RID: 22453
		private Table __p;
	}
}
