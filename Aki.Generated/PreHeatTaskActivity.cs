using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F57 RID: 3927
	public struct PreHeatTaskActivity : IFlatbufferObject
	{
		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x0600B2F8 RID: 45816 RVA: 0x002CA865 File Offset: 0x002C8A65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x002CA872 File Offset: 0x002C8A72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2FA RID: 45818 RVA: 0x002CA87C File Offset: 0x002C8A7C
		public static PreHeatTaskActivity GetRootAsPreHeatTaskActivity(ByteBuffer _bb)
		{
			return PreHeatTaskActivity.GetRootAsPreHeatTaskActivity(_bb, default(PreHeatTaskActivity));
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x002CA898 File Offset: 0x002C8A98
		public static PreHeatTaskActivity GetRootAsPreHeatTaskActivity(ByteBuffer _bb, PreHeatTaskActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2FC RID: 45820 RVA: 0x002CA8B5 File Offset: 0x002C8AB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2FD RID: 45821 RVA: 0x002CA8C4 File Offset: 0x002C8AC4
		public PreHeatTaskActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x002CA8D4 File Offset: 0x002C8AD4
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

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x0600B2FF RID: 45823 RVA: 0x002CA910 File Offset: 0x002C8B10
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

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x002CA94C File Offset: 0x002C8B4C
		public int QuestId
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

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x0600B301 RID: 45825 RVA: 0x002CA988 File Offset: 0x002C8B88
		public int OpenDay
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

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x002CA9C8 File Offset: 0x002C8BC8
		public string ItemIconPath
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

		// Token: 0x0600B303 RID: 45827 RVA: 0x002CAA00 File Offset: 0x002C8C00
		public Span<byte> GetItemIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x002CAA10 File Offset: 0x002C8C10
		public byte[] GetItemIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0600B305 RID: 45829 RVA: 0x002CAA28 File Offset: 0x002C8C28
		public string ShadowItemIconPath
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

		// Token: 0x0600B306 RID: 45830 RVA: 0x002CAA60 File Offset: 0x002C8C60
		public Span<byte> GetShadowItemIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B307 RID: 45831 RVA: 0x002CAA70 File Offset: 0x002C8C70
		public byte[] GetShadowItemIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0600B308 RID: 45832 RVA: 0x002CAA88 File Offset: 0x002C8C88
		public string IconPath
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

		// Token: 0x0600B309 RID: 45833 RVA: 0x002CAAC0 File Offset: 0x002C8CC0
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x002CAAD0 File Offset: 0x002C8CD0
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x0600B30B RID: 45835 RVA: 0x002CAAE8 File Offset: 0x002C8CE8
		public string ShadowIconPath
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

		// Token: 0x0600B30C RID: 45836 RVA: 0x002CAB20 File Offset: 0x002C8D20
		public Span<byte> GetShadowIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x002CAB30 File Offset: 0x002C8D30
		public byte[] GetShadowIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x002CAB48 File Offset: 0x002C8D48
		public string Title
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

		// Token: 0x0600B30F RID: 45839 RVA: 0x002CAB80 File Offset: 0x002C8D80
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x002CAB90 File Offset: 0x002C8D90
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x0600B311 RID: 45841 RVA: 0x002CABA8 File Offset: 0x002C8DA8
		public string Desc
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

		// Token: 0x0600B312 RID: 45842 RVA: 0x002CABE0 File Offset: 0x002C8DE0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x002CABF0 File Offset: 0x002C8DF0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0600B314 RID: 45844 RVA: 0x002CAC08 File Offset: 0x002C8E08
		public string BgPath
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

		// Token: 0x0600B315 RID: 45845 RVA: 0x002CAC40 File Offset: 0x002C8E40
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x002CAC50 File Offset: 0x002C8E50
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0600B317 RID: 45847 RVA: 0x002CAC68 File Offset: 0x002C8E68
		public string ParsingMatPath
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

		// Token: 0x0600B318 RID: 45848 RVA: 0x002CACA0 File Offset: 0x002C8EA0
		public Span<byte> GetParsingMatPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x002CACB0 File Offset: 0x002C8EB0
		public byte[] GetParsingMatPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04005024 RID: 20516
		private Table __p;
	}
}
