using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2C RID: 3884
	public struct MotorFightLevelType : IFlatbufferObject
	{
		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x002AD3AA File Offset: 0x002AB5AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x002AD3B7 File Offset: 0x002AB5B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x002AD3C0 File Offset: 0x002AB5C0
		public static MotorFightLevelType GetRootAsMotorFightLevelType(ByteBuffer _bb)
		{
			return MotorFightLevelType.GetRootAsMotorFightLevelType(_bb, default(MotorFightLevelType));
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x002AD3DC File Offset: 0x002AB5DC
		public static MotorFightLevelType GetRootAsMotorFightLevelType(ByteBuffer _bb, MotorFightLevelType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x002AD3F9 File Offset: 0x002AB5F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x002AD408 File Offset: 0x002AB608
		public MotorFightLevelType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06009ECD RID: 40653 RVA: 0x002AD418 File Offset: 0x002AB618
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

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06009ECE RID: 40654 RVA: 0x002AD454 File Offset: 0x002AB654
		public string Hold
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

		// Token: 0x06009ECF RID: 40655 RVA: 0x002AD48B File Offset: 0x002AB68B
		public Span<byte> GetHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x002AD49A File Offset: 0x002AB69A
		public byte[] GetHoldArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x002AD4B4 File Offset: 0x002AB6B4
		public string Mask
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

		// Token: 0x06009ED2 RID: 40658 RVA: 0x002AD4EB File Offset: 0x002AB6EB
		public Span<byte> GetMaskBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009ED3 RID: 40659 RVA: 0x002AD4FA File Offset: 0x002AB6FA
		public byte[] GetMaskArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06009ED4 RID: 40660 RVA: 0x002AD514 File Offset: 0x002AB714
		public string Light
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

		// Token: 0x06009ED5 RID: 40661 RVA: 0x002AD54C File Offset: 0x002AB74C
		public Span<byte> GetLightBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009ED6 RID: 40662 RVA: 0x002AD55C File Offset: 0x002AB75C
		public byte[] GetLightArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06009ED7 RID: 40663 RVA: 0x002AD574 File Offset: 0x002AB774
		public string Bg
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

		// Token: 0x06009ED8 RID: 40664 RVA: 0x002AD5AC File Offset: 0x002AB7AC
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009ED9 RID: 40665 RVA: 0x002AD5BC File Offset: 0x002AB7BC
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06009EDA RID: 40666 RVA: 0x002AD5D4 File Offset: 0x002AB7D4
		public string Title
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

		// Token: 0x06009EDB RID: 40667 RVA: 0x002AD60C File Offset: 0x002AB80C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x002AD61C File Offset: 0x002AB81C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06009EDD RID: 40669 RVA: 0x002AD634 File Offset: 0x002AB834
		public string SelectLevelState
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

		// Token: 0x06009EDE RID: 40670 RVA: 0x002AD66C File Offset: 0x002AB86C
		public Span<byte> GetSelectLevelStateBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x002AD67C File Offset: 0x002AB87C
		public byte[] GetSelectLevelStateArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06009EE0 RID: 40672 RVA: 0x002AD694 File Offset: 0x002AB894
		public string SelectLevelStateBg
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

		// Token: 0x06009EE1 RID: 40673 RVA: 0x002AD6CC File Offset: 0x002AB8CC
		public Span<byte> GetSelectLevelStateBgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x002AD6DC File Offset: 0x002AB8DC
		public byte[] GetSelectLevelStateBgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040054D4 RID: 21716
		private Table __p;
	}
}
