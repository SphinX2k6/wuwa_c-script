using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001168 RID: 4456
	public struct RougePopularEntrie : IFlatbufferObject
	{
		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600D41E RID: 54302 RVA: 0x0032224D File Offset: 0x0032044D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D41F RID: 54303 RVA: 0x0032225A File Offset: 0x0032045A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D420 RID: 54304 RVA: 0x00322264 File Offset: 0x00320464
		public static RougePopularEntrie GetRootAsRougePopularEntrie(ByteBuffer _bb)
		{
			return RougePopularEntrie.GetRootAsRougePopularEntrie(_bb, default(RougePopularEntrie));
		}

		// Token: 0x0600D421 RID: 54305 RVA: 0x00322280 File Offset: 0x00320480
		public static RougePopularEntrie GetRootAsRougePopularEntrie(ByteBuffer _bb, RougePopularEntrie obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D422 RID: 54306 RVA: 0x0032229D File Offset: 0x0032049D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D423 RID: 54307 RVA: 0x003222AC File Offset: 0x003204AC
		public RougePopularEntrie __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600D424 RID: 54308 RVA: 0x003222BC File Offset: 0x003204BC
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

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600D425 RID: 54309 RVA: 0x003222F8 File Offset: 0x003204F8
		public int Category
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

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600D426 RID: 54310 RVA: 0x00322334 File Offset: 0x00320534
		public int Rate
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

		// Token: 0x0600D427 RID: 54311 RVA: 0x00322370 File Offset: 0x00320570
		public int Insts(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x003223B0 File Offset: 0x003205B0
		public int InstsLength
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

		// Token: 0x0600D429 RID: 54313 RVA: 0x003223DC File Offset: 0x003205DC
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D42A RID: 54314 RVA: 0x003223EC File Offset: 0x003205EC
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600D42B RID: 54315 RVA: 0x00322404 File Offset: 0x00320604
		public string Icon
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

		// Token: 0x0600D42C RID: 54316 RVA: 0x0032243C File Offset: 0x0032063C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D42D RID: 54317 RVA: 0x0032244C File Offset: 0x0032064C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600D42E RID: 54318 RVA: 0x00322464 File Offset: 0x00320664
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

		// Token: 0x0600D42F RID: 54319 RVA: 0x0032249C File Offset: 0x0032069C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x003224AC File Offset: 0x003206AC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600D431 RID: 54321 RVA: 0x003224C4 File Offset: 0x003206C4
		public string Describe
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

		// Token: 0x0600D432 RID: 54322 RVA: 0x003224FC File Offset: 0x003206FC
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x0032250C File Offset: 0x0032070C
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x00322524 File Offset: 0x00320724
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600D435 RID: 54325 RVA: 0x00322560 File Offset: 0x00320760
		public int DescriptionParamLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D436 RID: 54326 RVA: 0x0032258C File Offset: 0x0032078C
		[NullableContext(1)]
		public string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x0600D437 RID: 54327 RVA: 0x00322599 File Offset: 0x00320799
		[NullableContext(1)]
		public IEnumerable<string> DescriptionParamIter()
		{
			RougePopularEntrie.<DescriptionParamIter>d__35 <DescriptionParamIter>d__ = new RougePopularEntrie.<DescriptionParamIter>d__35(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x003225AE File Offset: 0x003207AE
		[NullableContext(1)]
		public int[] Insts()
		{
			return this.GetInstsArray();
		}

		// Token: 0x0600D439 RID: 54329 RVA: 0x003225B6 File Offset: 0x003207B6
		[NullableContext(1)]
		public IEnumerable<int> InstsIter()
		{
			RougePopularEntrie.<InstsIter>d__37 <InstsIter>d__ = new RougePopularEntrie.<InstsIter>d__37(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x04005771 RID: 22385
		private Table __p;
	}
}
