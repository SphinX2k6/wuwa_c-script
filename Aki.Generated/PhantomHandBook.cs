using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD0 RID: 4048
	public struct PhantomHandBook : IFlatbufferObject
	{
		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x0600AEF9 RID: 44793 RVA: 0x002D0BD5 File Offset: 0x002CEDD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEFA RID: 44794 RVA: 0x002D0BE2 File Offset: 0x002CEDE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEFB RID: 44795 RVA: 0x002D0BEC File Offset: 0x002CEDEC
		public static PhantomHandBook GetRootAsPhantomHandBook(ByteBuffer _bb)
		{
			return PhantomHandBook.GetRootAsPhantomHandBook(_bb, default(PhantomHandBook));
		}

		// Token: 0x0600AEFC RID: 44796 RVA: 0x002D0C08 File Offset: 0x002CEE08
		public static PhantomHandBook GetRootAsPhantomHandBook(ByteBuffer _bb, PhantomHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x002D0C25 File Offset: 0x002CEE25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x002D0C34 File Offset: 0x002CEE34
		public PhantomHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x002D0C44 File Offset: 0x002CEE44
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

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x0600AF00 RID: 44800 RVA: 0x002D0C80 File Offset: 0x002CEE80
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

		// Token: 0x0600AF01 RID: 44801 RVA: 0x002D0CB7 File Offset: 0x002CEEB7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x002D0CC6 File Offset: 0x002CEEC6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x0600AF03 RID: 44803 RVA: 0x002D0CE0 File Offset: 0x002CEEE0
		public string TypeDescrtption
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

		// Token: 0x0600AF04 RID: 44804 RVA: 0x002D0D17 File Offset: 0x002CEF17
		public Span<byte> GetTypeDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x002D0D26 File Offset: 0x002CEF26
		public byte[] GetTypeDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x0600AF06 RID: 44806 RVA: 0x002D0D40 File Offset: 0x002CEF40
		public string Intensity
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

		// Token: 0x0600AF07 RID: 44807 RVA: 0x002D0D78 File Offset: 0x002CEF78
		public Span<byte> GetIntensityBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AF08 RID: 44808 RVA: 0x002D0D88 File Offset: 0x002CEF88
		public byte[] GetIntensityArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600AF09 RID: 44809 RVA: 0x002D0DA0 File Offset: 0x002CEFA0
		public string Place
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

		// Token: 0x0600AF0A RID: 44810 RVA: 0x002D0DD8 File Offset: 0x002CEFD8
		public Span<byte> GetPlaceBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x002D0DE8 File Offset: 0x002CEFE8
		public byte[] GetPlaceArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x0600AF0C RID: 44812 RVA: 0x002D0E00 File Offset: 0x002CF000
		public string Title1
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

		// Token: 0x0600AF0D RID: 44813 RVA: 0x002D0E38 File Offset: 0x002CF038
		public Span<byte> GetTitle1Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AF0E RID: 44814 RVA: 0x002D0E48 File Offset: 0x002CF048
		public byte[] GetTitle1Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x0600AF0F RID: 44815 RVA: 0x002D0E60 File Offset: 0x002CF060
		public string Descrtption1
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

		// Token: 0x0600AF10 RID: 44816 RVA: 0x002D0E98 File Offset: 0x002CF098
		public Span<byte> GetDescrtption1Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AF11 RID: 44817 RVA: 0x002D0EA8 File Offset: 0x002CF0A8
		public byte[] GetDescrtption1Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x002D0EC0 File Offset: 0x002CF0C0
		public string Title2
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

		// Token: 0x0600AF13 RID: 44819 RVA: 0x002D0EF8 File Offset: 0x002CF0F8
		public Span<byte> GetTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AF14 RID: 44820 RVA: 0x002D0F08 File Offset: 0x002CF108
		public byte[] GetTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x002D0F20 File Offset: 0x002CF120
		public string Descrtption2
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

		// Token: 0x0600AF16 RID: 44822 RVA: 0x002D0F58 File Offset: 0x002CF158
		public Span<byte> GetDescrtption2Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AF17 RID: 44823 RVA: 0x002D0F68 File Offset: 0x002CF168
		public byte[] GetDescrtption2Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AF18 RID: 44824 RVA: 0x002D0F80 File Offset: 0x002CF180
		public float Scale(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x0600AF19 RID: 44825 RVA: 0x002D0FC4 File Offset: 0x002CF1C4
		public int ScaleLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x002D0FF0 File Offset: 0x002CF1F0
		public Span<float> GetScaleBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x002D1000 File Offset: 0x002CF200
		public float[] GetScaleArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x0600AF1C RID: 44828 RVA: 0x002D1018 File Offset: 0x002CF218
		public float Position(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x002D105C File Offset: 0x002CF25C
		public int PositionLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x002D1088 File Offset: 0x002CF288
		public Span<float> GetPositionBytes()
		{
			return this.__p.__vector_as_span<float>(24, 4);
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x002D1098 File Offset: 0x002CF298
		public float[] GetPositionArray()
		{
			return this.__p.__vector_as_array<float>(24) ?? Array.Empty<float>();
		}

		// Token: 0x0600AF20 RID: 44832 RVA: 0x002D10B0 File Offset: 0x002CF2B0
		public float Rotator(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x0600AF21 RID: 44833 RVA: 0x002D10F4 File Offset: 0x002CF2F4
		public int RotatorLength
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

		// Token: 0x0600AF22 RID: 44834 RVA: 0x002D1120 File Offset: 0x002CF320
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(26, 4);
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x002D1130 File Offset: 0x002CF330
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(26) ?? Array.Empty<float>();
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x002D1148 File Offset: 0x002CF348
		[NullableContext(1)]
		public float[] Position()
		{
			return this.GetPositionArray();
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x002D1150 File Offset: 0x002CF350
		[NullableContext(1)]
		public IEnumerable<float> PositionIter()
		{
			PhantomHandBook.<PositionIter>d__58 <PositionIter>d__ = new PhantomHandBook.<PositionIter>d__58(-2);
			<PositionIter>d__.<>3__<>4__this = this;
			return <PositionIter>d__;
		}

		// Token: 0x0600AF26 RID: 44838 RVA: 0x002D1165 File Offset: 0x002CF365
		[NullableContext(1)]
		public float[] Rotator()
		{
			return this.GetRotatorArray();
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x002D116D File Offset: 0x002CF36D
		[NullableContext(1)]
		public IEnumerable<float> RotatorIter()
		{
			PhantomHandBook.<RotatorIter>d__60 <RotatorIter>d__ = new PhantomHandBook.<RotatorIter>d__60(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x002D1182 File Offset: 0x002CF382
		[NullableContext(1)]
		public float[] Scale()
		{
			return this.GetScaleArray();
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x002D118A File Offset: 0x002CF38A
		[NullableContext(1)]
		public IEnumerable<float> ScaleIter()
		{
			PhantomHandBook.<ScaleIter>d__62 <ScaleIter>d__ = new PhantomHandBook.<ScaleIter>d__62(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x04005592 RID: 21906
		private Table __p;
	}
}
