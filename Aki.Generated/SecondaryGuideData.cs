using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118E RID: 4494
	public struct SecondaryGuideData : IFlatbufferObject
	{
		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600D7CA RID: 55242 RVA: 0x0032A26A File Offset: 0x0032846A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7CB RID: 55243 RVA: 0x0032A277 File Offset: 0x00328477
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7CC RID: 55244 RVA: 0x0032A280 File Offset: 0x00328480
		public static SecondaryGuideData GetRootAsSecondaryGuideData(ByteBuffer _bb)
		{
			return SecondaryGuideData.GetRootAsSecondaryGuideData(_bb, default(SecondaryGuideData));
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x0032A29C File Offset: 0x0032849C
		public static SecondaryGuideData GetRootAsSecondaryGuideData(ByteBuffer _bb, SecondaryGuideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x0032A2B9 File Offset: 0x003284B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x0032A2C8 File Offset: 0x003284C8
		public SecondaryGuideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600D7D0 RID: 55248 RVA: 0x0032A2D8 File Offset: 0x003284D8
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

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600D7D1 RID: 55249 RVA: 0x0032A314 File Offset: 0x00328514
		public int SortNumber
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

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600D7D2 RID: 55250 RVA: 0x0032A350 File Offset: 0x00328550
		public int ConditionGroupId
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

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600D7D3 RID: 55251 RVA: 0x0032A38C File Offset: 0x0032858C
		public string Text
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

		// Token: 0x0600D7D4 RID: 55252 RVA: 0x0032A3C4 File Offset: 0x003285C4
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D7D5 RID: 55253 RVA: 0x0032A3D4 File Offset: 0x003285D4
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600D7D6 RID: 55254 RVA: 0x0032A3EC File Offset: 0x003285EC
		public string SubText
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

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x0032A424 File Offset: 0x00328624
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x0032A434 File Offset: 0x00328634
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600D7D9 RID: 55257 RVA: 0x0032A44C File Offset: 0x0032864C
		public string Icon
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

		// Token: 0x0600D7DA RID: 55258 RVA: 0x0032A484 File Offset: 0x00328684
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D7DB RID: 55259 RVA: 0x0032A494 File Offset: 0x00328694
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x0032A4AC File Offset: 0x003286AC
		public int HelpGroupId
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

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600D7DD RID: 55261 RVA: 0x0032A4EC File Offset: 0x003286EC
		public bool ShowDropDown
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600D7DE RID: 55262 RVA: 0x0032A52C File Offset: 0x0032872C
		public int DropDownTypeId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600D7DF RID: 55263 RVA: 0x0032A56C File Offset: 0x0032876C
		public int TimeOutDay
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

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600D7E0 RID: 55264 RVA: 0x0032A5AC File Offset: 0x003287AC
		public bool Shield
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400579F RID: 22431
		private Table __p;
	}
}
