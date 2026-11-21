using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7E RID: 3454
	public struct FlagStronghold : IFlatbufferObject
	{
		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x00255974 File Offset: 0x00253B74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00255981 File Offset: 0x00253B81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00255988 File Offset: 0x00253B88
		public static FlagStronghold GetRootAsFlagStronghold(ByteBuffer _bb)
		{
			return FlagStronghold.GetRootAsFlagStronghold(_bb, default(FlagStronghold));
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x002559A4 File Offset: 0x00253BA4
		public static FlagStronghold GetRootAsFlagStronghold(ByteBuffer _bb, FlagStronghold obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x002559C1 File Offset: 0x00253BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x002559D0 File Offset: 0x00253BD0
		public FlagStronghold __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x002559E0 File Offset: 0x00253BE0
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

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x060077B5 RID: 30645 RVA: 0x00255A1C File Offset: 0x00253C1C
		public int MarkId
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

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x060077B6 RID: 30646 RVA: 0x00255A58 File Offset: 0x00253C58
		public int ChallengeLevelId
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

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x060077B7 RID: 30647 RVA: 0x00255A94 File Offset: 0x00253C94
		public int AreaId
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

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x060077B8 RID: 30648 RVA: 0x00255AD4 File Offset: 0x00253CD4
		public int Type
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

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x060077B9 RID: 30649 RVA: 0x00255B14 File Offset: 0x00253D14
		public int DropId
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

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060077BA RID: 30650 RVA: 0x00255B54 File Offset: 0x00253D54
		public int EntityConfigId
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

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x060077BB RID: 30651 RVA: 0x00255B94 File Offset: 0x00253D94
		public string Name
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

		// Token: 0x060077BC RID: 30652 RVA: 0x00255BCC File Offset: 0x00253DCC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00255BDC File Offset: 0x00253DDC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x00255BF4 File Offset: 0x00253DF4
		public int MonsterLevel
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

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x060077BF RID: 30655 RVA: 0x00255C34 File Offset: 0x00253E34
		public string MonsterIconPath
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

		// Token: 0x060077C0 RID: 30656 RVA: 0x00255C6C File Offset: 0x00253E6C
		public Span<byte> GetMonsterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00255C7C File Offset: 0x00253E7C
		public byte[] GetMonsterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x060077C2 RID: 30658 RVA: 0x00255C94 File Offset: 0x00253E94
		public string MonsterDesc
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

		// Token: 0x060077C3 RID: 30659 RVA: 0x00255CCC File Offset: 0x00253ECC
		public Span<byte> GetMonsterDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x00255CDC File Offset: 0x00253EDC
		public byte[] GetMonsterDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x00255CF4 File Offset: 0x00253EF4
		public int UiRelativePos(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x060077C6 RID: 30662 RVA: 0x00255D34 File Offset: 0x00253F34
		public int UiRelativePosLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00255D60 File Offset: 0x00253F60
		public Span<int> GetUiRelativePosBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00255D70 File Offset: 0x00253F70
		public int[] GetUiRelativePosArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x060077C9 RID: 30665 RVA: 0x00255D88 File Offset: 0x00253F88
		public int Index
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

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x060077CA RID: 30666 RVA: 0x00255DC8 File Offset: 0x00253FC8
		public int RecommendLevel
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

		// Token: 0x060077CB RID: 30667 RVA: 0x00255E05 File Offset: 0x00254005
		[NullableContext(1)]
		public int[] UiRelativePos()
		{
			return this.GetUiRelativePosArray();
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x00255E0D File Offset: 0x0025400D
		[NullableContext(1)]
		public IEnumerable<int> UiRelativePosIter()
		{
			FlagStronghold.<UiRelativePosIter>d__46 <UiRelativePosIter>d__ = new FlagStronghold.<UiRelativePosIter>d__46(-2);
			<UiRelativePosIter>d__.<>3__<>4__this = this;
			return <UiRelativePosIter>d__;
		}

		// Token: 0x040052D5 RID: 21205
		private Table __p;
	}
}
