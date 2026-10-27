using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD2 RID: 3282
	public struct FunctionCondition : IFlatbufferObject
	{
		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600770D RID: 30477 RVA: 0x00243A14 File Offset: 0x00241C14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00243A21 File Offset: 0x00241C21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x00243A28 File Offset: 0x00241C28
		public static FunctionCondition GetRootAsFunctionCondition(ByteBuffer _bb)
		{
			return FunctionCondition.GetRootAsFunctionCondition(_bb, default(FunctionCondition));
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00243A44 File Offset: 0x00241C44
		public static FunctionCondition GetRootAsFunctionCondition(ByteBuffer _bb, FunctionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00243A61 File Offset: 0x00241C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00243A70 File Offset: 0x00241C70
		public FunctionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06007713 RID: 30483 RVA: 0x00243A80 File Offset: 0x00241C80
		public int FunctionId
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

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00243ABC File Offset: 0x00241CBC
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

		// Token: 0x06007715 RID: 30485 RVA: 0x00243AF3 File Offset: 0x00241CF3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00243B02 File Offset: 0x00241D02
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06007717 RID: 30487 RVA: 0x00243B1C File Offset: 0x00241D1C
		public bool IsOn
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06007718 RID: 30488 RVA: 0x00243B5C File Offset: 0x00241D5C
		public int OpenConditionId
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

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06007719 RID: 30489 RVA: 0x00243B9C File Offset: 0x00241D9C
		public int ShowUIType
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

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x0600771A RID: 30490 RVA: 0x00243BDC File Offset: 0x00241DDC
		public int Delay
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 101;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x0600771B RID: 30491 RVA: 0x00243C1C File Offset: 0x00241E1C
		public string Title
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

		// Token: 0x0600771C RID: 30492 RVA: 0x00243C54 File Offset: 0x00241E54
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00243C64 File Offset: 0x00241E64
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x00243C7C File Offset: 0x00241E7C
		public string Desc
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

		// Token: 0x0600771F RID: 30495 RVA: 0x00243CB4 File Offset: 0x00241EB4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00243CC4 File Offset: 0x00241EC4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06007721 RID: 30497 RVA: 0x00243CDC File Offset: 0x00241EDC
		public string Icon
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

		// Token: 0x06007722 RID: 30498 RVA: 0x00243D14 File Offset: 0x00241F14
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x00243D24 File Offset: 0x00241F24
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x00243D3C File Offset: 0x00241F3C
		public string IconSprite
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

		// Token: 0x06007725 RID: 30501 RVA: 0x00243D74 File Offset: 0x00241F74
		public Span<byte> GetIconSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00243D84 File Offset: 0x00241F84
		public byte[] GetIconSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D42 RID: 19778
		private Table __p;
	}
}
