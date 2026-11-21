using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C91 RID: 3217
	public struct DaemonHackConfigCsv : IFlatbufferObject
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06006095 RID: 24725 RVA: 0x002226E8 File Offset: 0x002208E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x002226F5 File Offset: 0x002208F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x002226FC File Offset: 0x002208FC
		public static DaemonHackConfigCsv GetRootAsDaemonHackConfigCsv(ByteBuffer _bb)
		{
			return DaemonHackConfigCsv.GetRootAsDaemonHackConfigCsv(_bb, default(DaemonHackConfigCsv));
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x00222718 File Offset: 0x00220918
		public static DaemonHackConfigCsv GetRootAsDaemonHackConfigCsv(ByteBuffer _bb, DaemonHackConfigCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x00222735 File Offset: 0x00220935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x00222744 File Offset: 0x00220944
		public DaemonHackConfigCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x0600609B RID: 24731 RVA: 0x00222754 File Offset: 0x00220954
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

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600609C RID: 24732 RVA: 0x00222790 File Offset: 0x00220990
		public string CodeMap
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

		// Token: 0x0600609D RID: 24733 RVA: 0x002227C7 File Offset: 0x002209C7
		public Span<byte> GetCodeMapBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x002227D6 File Offset: 0x002209D6
		public byte[] GetCodeMapArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600609F RID: 24735 RVA: 0x002227F0 File Offset: 0x002209F0
		public string CodeMatrix
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

		// Token: 0x060060A0 RID: 24736 RVA: 0x00222827 File Offset: 0x00220A27
		public Span<byte> GetCodeMatrixBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x00222836 File Offset: 0x00220A36
		public byte[] GetCodeMatrixArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x00222850 File Offset: 0x00220A50
		public int CodeBufferSize
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

		// Token: 0x060060A3 RID: 24739 RVA: 0x00222890 File Offset: 0x00220A90
		public string TargetCodes(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060060A4 RID: 24740 RVA: 0x002228CC File Offset: 0x00220ACC
		public int TargetCodesLength
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

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060060A5 RID: 24741 RVA: 0x002228F8 File Offset: 0x00220AF8
		public int CountDown
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

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060060A6 RID: 24742 RVA: 0x00222938 File Offset: 0x00220B38
		public int FailThreshold
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

		// Token: 0x060060A7 RID: 24743 RVA: 0x00222975 File Offset: 0x00220B75
		[NullableContext(1)]
		public string[] TargetCodes()
		{
			return this.TargetCodesIter().ToArray<string>();
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x00222982 File Offset: 0x00220B82
		[NullableContext(1)]
		public IEnumerable<string> TargetCodesIter()
		{
			DaemonHackConfigCsv.<TargetCodesIter>d__28 <TargetCodesIter>d__ = new DaemonHackConfigCsv.<TargetCodesIter>d__28(-2);
			<TargetCodesIter>d__.<>3__<>4__this = this;
			return <TargetCodesIter>d__;
		}

		// Token: 0x040051B4 RID: 20916
		private Table __p;
	}
}
