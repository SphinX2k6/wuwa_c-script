using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5F RID: 3167
	public struct CircumBase : IFlatbufferObject
	{
		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06005B87 RID: 23431 RVA: 0x00216400 File Offset: 0x00214600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x0021640D File Offset: 0x0021460D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x00216414 File Offset: 0x00214614
		public static CircumBase GetRootAsCircumBase(ByteBuffer _bb)
		{
			return CircumBase.GetRootAsCircumBase(_bb, default(CircumBase));
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00216430 File Offset: 0x00214630
		public static CircumBase GetRootAsCircumBase(ByteBuffer _bb, CircumBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x0021644D File Offset: 0x0021464D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x0021645C File Offset: 0x0021465C
		public CircumBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06005B8D RID: 23437 RVA: 0x0021646C File Offset: 0x0021466C
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

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x002164A8 File Offset: 0x002146A8
		public int EntryType
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

		// Token: 0x06005B8F RID: 23439 RVA: 0x002164E4 File Offset: 0x002146E4
		public int ArgId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06005B90 RID: 23440 RVA: 0x00216524 File Offset: 0x00214724
		public int ArgIdLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x0021654F File Offset: 0x0021474F
		public Span<int> GetArgIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x0021655E File Offset: 0x0021475E
		public int[] GetArgIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06005B93 RID: 23443 RVA: 0x00216578 File Offset: 0x00214778
		public string Title
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

		// Token: 0x06005B94 RID: 23444 RVA: 0x002165B0 File Offset: 0x002147B0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x002165C0 File Offset: 0x002147C0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x002165D8 File Offset: 0x002147D8
		public int GachaId
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

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x00216618 File Offset: 0x00214818
		public string SubTitle
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

		// Token: 0x06005B98 RID: 23448 RVA: 0x00216650 File Offset: 0x00214850
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x00216660 File Offset: 0x00214860
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x00216678 File Offset: 0x00214878
		public string BgPathF
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

		// Token: 0x06005B9B RID: 23451 RVA: 0x002166B0 File Offset: 0x002148B0
		public Span<byte> GetBgPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x002166C0 File Offset: 0x002148C0
		public byte[] GetBgPathFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06005B9D RID: 23453 RVA: 0x002166D8 File Offset: 0x002148D8
		public string BgPath
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

		// Token: 0x06005B9E RID: 23454 RVA: 0x00216710 File Offset: 0x00214910
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x00216720 File Offset: 0x00214920
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x00216738 File Offset: 0x00214938
		public string Description
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

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00216770 File Offset: 0x00214970
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x00216780 File Offset: 0x00214980
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06005BA3 RID: 23459 RVA: 0x00216798 File Offset: 0x00214998
		public int RewardPreview
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x002167D8 File Offset: 0x002149D8
		public bool ShowCondition
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x00216818 File Offset: 0x00214A18
		[NullableContext(1)]
		public int[] ArgId()
		{
			return this.GetArgIdArray();
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00216820 File Offset: 0x00214A20
		[NullableContext(1)]
		public IEnumerable<int> ArgIdIter()
		{
			CircumBase.<ArgIdIter>d__44 <ArgIdIter>d__ = new CircumBase.<ArgIdIter>d__44(-2);
			<ArgIdIter>d__.<>3__<>4__this = this;
			return <ArgIdIter>d__;
		}

		// Token: 0x04005163 RID: 20835
		private Table __p;
	}
}
