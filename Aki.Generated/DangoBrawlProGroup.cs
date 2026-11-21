using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAE RID: 3246
	public struct DangoBrawlProGroup : IFlatbufferObject
	{
		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060064CA RID: 25802 RVA: 0x0022BB58 File Offset: 0x00229D58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x0022BB65 File Offset: 0x00229D65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x0022BB6C File Offset: 0x00229D6C
		public static DangoBrawlProGroup GetRootAsDangoBrawlProGroup(ByteBuffer _bb)
		{
			return DangoBrawlProGroup.GetRootAsDangoBrawlProGroup(_bb, default(DangoBrawlProGroup));
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x0022BB88 File Offset: 0x00229D88
		public static DangoBrawlProGroup GetRootAsDangoBrawlProGroup(ByteBuffer _bb, DangoBrawlProGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x0022BBA5 File Offset: 0x00229DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x0022BBB4 File Offset: 0x00229DB4
		public DangoBrawlProGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060064D0 RID: 25808 RVA: 0x0022BBC4 File Offset: 0x00229DC4
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

		// Token: 0x060064D1 RID: 25809 RVA: 0x0022BC00 File Offset: 0x00229E00
		public ProAddEntry? InitAttr(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ProAddEntry?(default(ProAddEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060064D2 RID: 25810 RVA: 0x0022BC60 File Offset: 0x00229E60
		public int InitAttrLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x0022BC8B File Offset: 0x00229E8B
		[NullableContext(1)]
		public ProAddEntry[] InitAttr()
		{
			return this.InitAttrIter().ToArray<ProAddEntry>();
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x0022BC98 File Offset: 0x00229E98
		[NullableContext(1)]
		public IEnumerable<ProAddEntry> InitAttrIter()
		{
			DangoBrawlProGroup.<InitAttrIter>d__14 <InitAttrIter>d__ = new DangoBrawlProGroup.<InitAttrIter>d__14(-2);
			<InitAttrIter>d__.<>3__<>4__this = this;
			return <InitAttrIter>d__;
		}

		// Token: 0x040051D8 RID: 20952
		private Table __p;
	}
}
