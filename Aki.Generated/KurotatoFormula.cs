using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E83 RID: 3715
	public struct KurotatoFormula : IFlatbufferObject
	{
		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06008F93 RID: 36755 RVA: 0x0028C595 File Offset: 0x0028A795
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F94 RID: 36756 RVA: 0x0028C5A2 File Offset: 0x0028A7A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x0028C5AC File Offset: 0x0028A7AC
		public static KurotatoFormula GetRootAsKurotatoFormula(ByteBuffer _bb)
		{
			return KurotatoFormula.GetRootAsKurotatoFormula(_bb, default(KurotatoFormula));
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x0028C5C8 File Offset: 0x0028A7C8
		public static KurotatoFormula GetRootAsKurotatoFormula(ByteBuffer _bb, KurotatoFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x0028C5E5 File Offset: 0x0028A7E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x0028C5F4 File Offset: 0x0028A7F4
		public KurotatoFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06008F99 RID: 36761 RVA: 0x0028C604 File Offset: 0x0028A804
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

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06008F9A RID: 36762 RVA: 0x0028C640 File Offset: 0x0028A840
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

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06008F9B RID: 36763 RVA: 0x0028C67C File Offset: 0x0028A87C
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

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06008F9C RID: 36764 RVA: 0x0028C6B8 File Offset: 0x0028A8B8
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

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06008F9D RID: 36765 RVA: 0x0028C6F8 File Offset: 0x0028A8F8
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

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06008F9E RID: 36766 RVA: 0x0028C738 File Offset: 0x0028A938
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

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x0028C778 File Offset: 0x0028A978
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

		// Token: 0x06008FA0 RID: 36768 RVA: 0x0028C7B0 File Offset: 0x0028A9B0
		public Span<byte> GetProp1Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x0028C7C0 File Offset: 0x0028A9C0
		public byte[] GetProp1Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06008FA2 RID: 36770 RVA: 0x0028C7D8 File Offset: 0x0028A9D8
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

		// Token: 0x06008FA3 RID: 36771 RVA: 0x0028C810 File Offset: 0x0028AA10
		public Span<byte> GetProp2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x0028C820 File Offset: 0x0028AA20
		public byte[] GetProp2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06008FA5 RID: 36773 RVA: 0x0028C838 File Offset: 0x0028AA38
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

		// Token: 0x06008FA6 RID: 36774 RVA: 0x0028C870 File Offset: 0x0028AA70
		public Span<byte> GetProp3Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x0028C880 File Offset: 0x0028AA80
		public byte[] GetProp3Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x0028C898 File Offset: 0x0028AA98
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

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06008FA9 RID: 36777 RVA: 0x0028C8D8 File Offset: 0x0028AAD8
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

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06008FAA RID: 36778 RVA: 0x0028C918 File Offset: 0x0028AB18
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

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06008FAB RID: 36779 RVA: 0x0028C958 File Offset: 0x0028AB58
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

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06008FAC RID: 36780 RVA: 0x0028C998 File Offset: 0x0028AB98
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

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06008FAD RID: 36781 RVA: 0x0028C9D8 File Offset: 0x0028ABD8
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

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06008FAE RID: 36782 RVA: 0x0028CA18 File Offset: 0x0028AC18
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

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06008FAF RID: 36783 RVA: 0x0028CA58 File Offset: 0x0028AC58
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

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x0028CA98 File Offset: 0x0028AC98
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

		// Token: 0x04005413 RID: 21523
		private Table __p;
	}
}
