using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF1 RID: 3825
	public struct MobileBattleUiSet : IFlatbufferObject
	{
		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06009A52 RID: 39506 RVA: 0x002A3890 File Offset: 0x002A1A90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x002A389D File Offset: 0x002A1A9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x002A38A4 File Offset: 0x002A1AA4
		public static MobileBattleUiSet GetRootAsMobileBattleUiSet(ByteBuffer _bb)
		{
			return MobileBattleUiSet.GetRootAsMobileBattleUiSet(_bb, default(MobileBattleUiSet));
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x002A38C0 File Offset: 0x002A1AC0
		public static MobileBattleUiSet GetRootAsMobileBattleUiSet(ByteBuffer _bb, MobileBattleUiSet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x002A38DD File Offset: 0x002A1ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x002A38EC File Offset: 0x002A1AEC
		public MobileBattleUiSet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06009A58 RID: 39512 RVA: 0x002A38FC File Offset: 0x002A1AFC
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

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x002A3938 File Offset: 0x002A1B38
		public int PanelIndex
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

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06009A5A RID: 39514 RVA: 0x002A3974 File Offset: 0x002A1B74
		public int ItemIndex
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

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06009A5B RID: 39515 RVA: 0x002A39B0 File Offset: 0x002A1BB0
		public string Name
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

		// Token: 0x06009A5C RID: 39516 RVA: 0x002A39E8 File Offset: 0x002A1BE8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x002A39F8 File Offset: 0x002A1BF8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06009A5E RID: 39518 RVA: 0x002A3A10 File Offset: 0x002A1C10
		public float SourceSize
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06009A5F RID: 39519 RVA: 0x002A3A54 File Offset: 0x002A1C54
		public float SourceAlpha
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06009A60 RID: 39520 RVA: 0x002A3A98 File Offset: 0x002A1C98
		public float SourceOffsetX
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06009A61 RID: 39521 RVA: 0x002A3ADC File Offset: 0x002A1CDC
		public float SourceOffsetY
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06009A62 RID: 39522 RVA: 0x002A3B20 File Offset: 0x002A1D20
		public bool IsCheckOverlap
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06009A63 RID: 39523 RVA: 0x002A3B60 File Offset: 0x002A1D60
		public bool CanEdit
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06009A64 RID: 39524 RVA: 0x002A3BA0 File Offset: 0x002A1DA0
		public bool IsDefaultSelected
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06009A65 RID: 39525 RVA: 0x002A3BE0 File Offset: 0x002A1DE0
		public int SourceHierarchyIndex
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

		// Token: 0x04005496 RID: 21654
		private Table __p;
	}
}
