using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD6 RID: 3030
	public struct AnimalHandBook : IFlatbufferObject
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x001F5581 File Offset: 0x001F3781
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x001F558E File Offset: 0x001F378E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x001F5598 File Offset: 0x001F3798
		public static AnimalHandBook GetRootAsAnimalHandBook(ByteBuffer _bb)
		{
			return AnimalHandBook.GetRootAsAnimalHandBook(_bb, default(AnimalHandBook));
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x001F55B4 File Offset: 0x001F37B4
		public static AnimalHandBook GetRootAsAnimalHandBook(ByteBuffer _bb, AnimalHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x001F55D1 File Offset: 0x001F37D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x001F55E0 File Offset: 0x001F37E0
		public AnimalHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06004D07 RID: 19719 RVA: 0x001F55F0 File Offset: 0x001F37F0
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

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x001F562C File Offset: 0x001F382C
		public int MeshId
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x001F5668 File Offset: 0x001F3868
		public string Name
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

		// Token: 0x06004D0A RID: 19722 RVA: 0x001F569F File Offset: 0x001F389F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x001F56AE File Offset: 0x001F38AE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x001F56C8 File Offset: 0x001F38C8
		public float Scale(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06004D0D RID: 19725 RVA: 0x001F570C File Offset: 0x001F390C
		public int ScaleLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x001F5738 File Offset: 0x001F3938
		public Span<float> GetScaleBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x001F5748 File Offset: 0x001F3948
		public float[] GetScaleArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x001F5760 File Offset: 0x001F3960
		public float Position(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x001F57A4 File Offset: 0x001F39A4
		public int PositionLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x001F57D0 File Offset: 0x001F39D0
		public Span<float> GetPositionBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x001F57E0 File Offset: 0x001F39E0
		public float[] GetPositionArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x001F57F8 File Offset: 0x001F39F8
		public float Rotator(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06004D15 RID: 19733 RVA: 0x001F583C File Offset: 0x001F3A3C
		public int RotatorLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x001F5868 File Offset: 0x001F3A68
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x001F5878 File Offset: 0x001F3A78
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x001F5890 File Offset: 0x001F3A90
		public string StandAnim
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

		// Token: 0x06004D19 RID: 19737 RVA: 0x001F58C8 File Offset: 0x001F3AC8
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x001F58D8 File Offset: 0x001F3AD8
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x001F58F0 File Offset: 0x001F3AF0
		public string Icon
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

		// Token: 0x06004D1C RID: 19740 RVA: 0x001F5928 File Offset: 0x001F3B28
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x001F5938 File Offset: 0x001F3B38
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06004D1E RID: 19742 RVA: 0x001F5950 File Offset: 0x001F3B50
		public string TypeDescrtption
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

		// Token: 0x06004D1F RID: 19743 RVA: 0x001F5988 File Offset: 0x001F3B88
		public Span<byte> GetTypeDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x001F5998 File Offset: 0x001F3B98
		public byte[] GetTypeDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x001F59B0 File Offset: 0x001F3BB0
		public string Place
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

		// Token: 0x06004D22 RID: 19746 RVA: 0x001F59E8 File Offset: 0x001F3BE8
		public Span<byte> GetPlaceBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001F59F8 File Offset: 0x001F3BF8
		public byte[] GetPlaceArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06004D24 RID: 19748 RVA: 0x001F5A10 File Offset: 0x001F3C10
		public string Descrtption
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

		// Token: 0x06004D25 RID: 19749 RVA: 0x001F5A48 File Offset: 0x001F3C48
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x001F5A58 File Offset: 0x001F3C58
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x001F5A70 File Offset: 0x001F3C70
		public int DropItemId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06004D28 RID: 19752 RVA: 0x001F5AB0 File Offset: 0x001F3CB0
		public int DropItemIdLength
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

		// Token: 0x06004D29 RID: 19753 RVA: 0x001F5ADC File Offset: 0x001F3CDC
		public Span<int> GetDropItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x001F5AEC File Offset: 0x001F3CEC
		public int[] GetDropItemIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x001F5B04 File Offset: 0x001F3D04
		[NullableContext(1)]
		public int[] DropItemId()
		{
			return this.GetDropItemIdArray();
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x001F5B0C File Offset: 0x001F3D0C
		[NullableContext(1)]
		public IEnumerable<int> DropItemIdIter()
		{
			AnimalHandBook.<DropItemIdIter>d__57 <DropItemIdIter>d__ = new AnimalHandBook.<DropItemIdIter>d__57(-2);
			<DropItemIdIter>d__.<>3__<>4__this = this;
			return <DropItemIdIter>d__;
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x001F5B21 File Offset: 0x001F3D21
		[NullableContext(1)]
		public float[] Position()
		{
			return this.GetPositionArray();
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x001F5B29 File Offset: 0x001F3D29
		[NullableContext(1)]
		public IEnumerable<float> PositionIter()
		{
			AnimalHandBook.<PositionIter>d__59 <PositionIter>d__ = new AnimalHandBook.<PositionIter>d__59(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x001F5B3E File Offset: 0x001F3D3E
		[NullableContext(1)]
		public float[] Rotator()
		{
			return this.GetRotatorArray();
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x001F5B46 File Offset: 0x001F3D46
		[NullableContext(1)]
		public IEnumerable<float> RotatorIter()
		{
			AnimalHandBook.<RotatorIter>d__61 <RotatorIter>d__ = new AnimalHandBook.<RotatorIter>d__61(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x001F5B5B File Offset: 0x001F3D5B
		[NullableContext(1)]
		public float[] Scale()
		{
			return this.GetScaleArray();
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x001F5B63 File Offset: 0x001F3D63
		[NullableContext(1)]
		public IEnumerable<float> ScaleIter()
		{
			AnimalHandBook.<ScaleIter>d__63 <ScaleIter>d__ = new AnimalHandBook.<ScaleIter>d__63(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x040050B7 RID: 20663
		private Table __p;
	}
}
