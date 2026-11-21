using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB6 RID: 3510
	public struct FunctionCondition : IFlatbufferObject
	{
		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06007D18 RID: 32024 RVA: 0x002625B0 File Offset: 0x002607B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x002625BD File Offset: 0x002607BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x002625C4 File Offset: 0x002607C4
		public static FunctionCondition GetRootAsFunctionCondition(ByteBuffer _bb)
		{
			return FunctionCondition.GetRootAsFunctionCondition(_bb, default(FunctionCondition));
		}

		// Token: 0x06007D1B RID: 32027 RVA: 0x002625E0 File Offset: 0x002607E0
		public static FunctionCondition GetRootAsFunctionCondition(ByteBuffer _bb, FunctionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x002625FD File Offset: 0x002607FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x0026260C File Offset: 0x0026080C
		public FunctionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06007D1E RID: 32030 RVA: 0x0026261C File Offset: 0x0026081C
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06007D1F RID: 32031 RVA: 0x00262658 File Offset: 0x00260858
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

		// Token: 0x06007D20 RID: 32032 RVA: 0x0026268F File Offset: 0x0026088F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x0026269E File Offset: 0x0026089E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x002626B8 File Offset: 0x002608B8
		public bool IsOn
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06007D23 RID: 32035 RVA: 0x002626F8 File Offset: 0x002608F8
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

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06007D24 RID: 32036 RVA: 0x00262738 File Offset: 0x00260938
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

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06007D25 RID: 32037 RVA: 0x00262778 File Offset: 0x00260978
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

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x002627B8 File Offset: 0x002609B8
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

		// Token: 0x06007D27 RID: 32039 RVA: 0x002627F0 File Offset: 0x002609F0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007D28 RID: 32040 RVA: 0x00262800 File Offset: 0x00260A00
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06007D29 RID: 32041 RVA: 0x00262818 File Offset: 0x00260A18
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

		// Token: 0x06007D2A RID: 32042 RVA: 0x00262850 File Offset: 0x00260A50
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x00262860 File Offset: 0x00260A60
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06007D2C RID: 32044 RVA: 0x00262878 File Offset: 0x00260A78
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

		// Token: 0x06007D2D RID: 32045 RVA: 0x002628B0 File Offset: 0x00260AB0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007D2E RID: 32046 RVA: 0x002628C0 File Offset: 0x00260AC0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06007D2F RID: 32047 RVA: 0x002628D8 File Offset: 0x00260AD8
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

		// Token: 0x06007D30 RID: 32048 RVA: 0x00262910 File Offset: 0x00260B10
		public Span<byte> GetIconSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x00262920 File Offset: 0x00260B20
		public byte[] GetIconSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005326 RID: 21286
		private Table __p;
	}
}
