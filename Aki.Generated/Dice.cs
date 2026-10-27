using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEE RID: 3054
	public struct Dice : IFlatbufferObject
	{
		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x002129BC File Offset: 0x00210BBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x002129C9 File Offset: 0x00210BC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x002129D0 File Offset: 0x00210BD0
		public static Dice GetRootAsDice(ByteBuffer _bb)
		{
			return Dice.GetRootAsDice(_bb, default(Dice));
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x002129EC File Offset: 0x00210BEC
		public static Dice GetRootAsDice(ByteBuffer _bb, Dice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x00212A09 File Offset: 0x00210C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x00212A18 File Offset: 0x00210C18
		public Dice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x00212A28 File Offset: 0x00210C28
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

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060061E0 RID: 25056 RVA: 0x00212A64 File Offset: 0x00210C64
		public string Icon
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

		// Token: 0x060061E1 RID: 25057 RVA: 0x00212A9B File Offset: 0x00210C9B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x00212AAA File Offset: 0x00210CAA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x00212AC4 File Offset: 0x00210CC4
		public int Num
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

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060061E4 RID: 25060 RVA: 0x00212B00 File Offset: 0x00210D00
		public string DicePointOneIcon
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

		// Token: 0x060061E5 RID: 25061 RVA: 0x00212B38 File Offset: 0x00210D38
		public Span<byte> GetDicePointOneIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x00212B48 File Offset: 0x00210D48
		public byte[] GetDicePointOneIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x00212B60 File Offset: 0x00210D60
		public string DicePointTwoIcon
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

		// Token: 0x060061E8 RID: 25064 RVA: 0x00212B98 File Offset: 0x00210D98
		public Span<byte> GetDicePointTwoIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x00212BA8 File Offset: 0x00210DA8
		public byte[] GetDicePointTwoIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060061EA RID: 25066 RVA: 0x00212BC0 File Offset: 0x00210DC0
		public string DicePointThreeIcon
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

		// Token: 0x060061EB RID: 25067 RVA: 0x00212BF8 File Offset: 0x00210DF8
		public Span<byte> GetDicePointThreeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x00212C08 File Offset: 0x00210E08
		public byte[] GetDicePointThreeIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060061ED RID: 25069 RVA: 0x00212C20 File Offset: 0x00210E20
		public string DicePointFourIcon
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

		// Token: 0x060061EE RID: 25070 RVA: 0x00212C58 File Offset: 0x00210E58
		public Span<byte> GetDicePointFourIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x00212C68 File Offset: 0x00210E68
		public byte[] GetDicePointFourIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060061F0 RID: 25072 RVA: 0x00212C80 File Offset: 0x00210E80
		public string DicePointFiveIcon
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

		// Token: 0x060061F1 RID: 25073 RVA: 0x00212CB8 File Offset: 0x00210EB8
		public Span<byte> GetDicePointFiveIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x00212CC8 File Offset: 0x00210EC8
		public byte[] GetDicePointFiveIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060061F3 RID: 25075 RVA: 0x00212CE0 File Offset: 0x00210EE0
		public string DicePointSixIcon
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

		// Token: 0x060061F4 RID: 25076 RVA: 0x00212D18 File Offset: 0x00210F18
		public Span<byte> GetDicePointSixIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x00212D28 File Offset: 0x00210F28
		public byte[] GetDicePointSixIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060061F6 RID: 25078 RVA: 0x00212D40 File Offset: 0x00210F40
		public string DiceBackgroundIcon
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

		// Token: 0x060061F7 RID: 25079 RVA: 0x00212D78 File Offset: 0x00210F78
		public Span<byte> GetDiceBackgroundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060061F8 RID: 25080 RVA: 0x00212D88 File Offset: 0x00210F88
		public byte[] GetDiceBackgroundIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060061F9 RID: 25081 RVA: 0x00212DA0 File Offset: 0x00210FA0
		public string RollDiceBackgroundIcon
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

		// Token: 0x060061FA RID: 25082 RVA: 0x00212DD8 File Offset: 0x00210FD8
		public Span<byte> GetRollDiceBackgroundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x00212DE8 File Offset: 0x00210FE8
		public byte[] GetRollDiceBackgroundIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060061FC RID: 25084 RVA: 0x00212E00 File Offset: 0x00211000
		public string DiceColor
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

		// Token: 0x060061FD RID: 25085 RVA: 0x00212E38 File Offset: 0x00211038
		public Span<byte> GetDiceColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x00212E48 File Offset: 0x00211048
		public byte[] GetDiceColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x00212E60 File Offset: 0x00211060
		public string DiceNumColor
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

		// Token: 0x06006200 RID: 25088 RVA: 0x00212E98 File Offset: 0x00211098
		public Span<byte> GetDiceNumColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x00212EA8 File Offset: 0x002110A8
		public byte[] GetDiceNumColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06006202 RID: 25090 RVA: 0x00212EC0 File Offset: 0x002110C0
		public string DiceHighLightColor
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x00212EF8 File Offset: 0x002110F8
		public Span<byte> GetDiceHighLightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x00212F08 File Offset: 0x00211108
		public byte[] GetDiceHighLightColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06006205 RID: 25093 RVA: 0x00212F20 File Offset: 0x00211120
		public int FacesNum
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

		// Token: 0x04004C1B RID: 19483
		private Table __p;
	}
}
