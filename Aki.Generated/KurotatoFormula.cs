using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9E RID: 3486
	public struct KurotatoFormula : IFlatbufferObject
	{
		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06008977 RID: 35191 RVA: 0x0026DA19 File Offset: 0x0026BC19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x0026DA26 File Offset: 0x0026BC26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x0026DA30 File Offset: 0x0026BC30
		public static KurotatoFormula GetRootAsKurotatoFormula(ByteBuffer _bb)
		{
			return KurotatoFormula.GetRootAsKurotatoFormula(_bb, default(KurotatoFormula));
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x0026DA4C File Offset: 0x0026BC4C
		public static KurotatoFormula GetRootAsKurotatoFormula(ByteBuffer _bb, KurotatoFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x0026DA69 File Offset: 0x0026BC69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x0026DA78 File Offset: 0x0026BC78
		public KurotatoFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600897D RID: 35197 RVA: 0x0026DA88 File Offset: 0x0026BC88
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

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x0600897E RID: 35198 RVA: 0x0026DAC4 File Offset: 0x0026BCC4
		public int Type
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

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x0600897F RID: 35199 RVA: 0x0026DB00 File Offset: 0x0026BD00
		public int LimitType
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

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06008980 RID: 35200 RVA: 0x0026DB3C File Offset: 0x0026BD3C
		public int UpperLimit
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

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06008981 RID: 35201 RVA: 0x0026DB7C File Offset: 0x0026BD7C
		public int LowerLimit
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

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06008982 RID: 35202 RVA: 0x0026DBBC File Offset: 0x0026BDBC
		public int Precision
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

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x0026DBFC File Offset: 0x0026BDFC
		public string Prop1
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

		// Token: 0x06008984 RID: 35204 RVA: 0x0026DC34 File Offset: 0x0026BE34
		public Span<byte> GetProp1Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x0026DC44 File Offset: 0x0026BE44
		public byte[] GetProp1Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06008986 RID: 35206 RVA: 0x0026DC5C File Offset: 0x0026BE5C
		public string Prop2
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

		// Token: 0x06008987 RID: 35207 RVA: 0x0026DC94 File Offset: 0x0026BE94
		public Span<byte> GetProp2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0026DCA4 File Offset: 0x0026BEA4
		public byte[] GetProp2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06008989 RID: 35209 RVA: 0x0026DCBC File Offset: 0x0026BEBC
		public string Prop3
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

		// Token: 0x0600898A RID: 35210 RVA: 0x0026DCF4 File Offset: 0x0026BEF4
		public Span<byte> GetProp3Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x0026DD04 File Offset: 0x0026BF04
		public byte[] GetProp3Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x0600898C RID: 35212 RVA: 0x0026DD1C File Offset: 0x0026BF1C
		public int ParamInt1
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

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x0600898D RID: 35213 RVA: 0x0026DD5C File Offset: 0x0026BF5C
		public int ParamInt2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x0600898E RID: 35214 RVA: 0x0026DD9C File Offset: 0x0026BF9C
		public int ParamInt3
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x0600898F RID: 35215 RVA: 0x0026DDDC File Offset: 0x0026BFDC
		public int ParamInt4
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x0026DE1C File Offset: 0x0026C01C
		public int ParamInt5
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

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06008991 RID: 35217 RVA: 0x0026DE5C File Offset: 0x0026C05C
		public int ParamInt6
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06008992 RID: 35218 RVA: 0x0026DE9C File Offset: 0x0026C09C
		public int ParamInt7
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

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06008993 RID: 35219 RVA: 0x0026DEDC File Offset: 0x0026C0DC
		public int ParamInt8
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06008994 RID: 35220 RVA: 0x0026DF1C File Offset: 0x0026C11C
		public int ParamInt9
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E2E RID: 20014
		private Table __p;
	}
}
