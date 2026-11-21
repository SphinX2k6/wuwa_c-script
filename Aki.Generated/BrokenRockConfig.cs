using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C30 RID: 3120
	public struct BrokenRockConfig : IFlatbufferObject
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06005586 RID: 21894 RVA: 0x00208F99 File Offset: 0x00207199
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00208FA6 File Offset: 0x002071A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x00208FB0 File Offset: 0x002071B0
		public static BrokenRockConfig GetRootAsBrokenRockConfig(ByteBuffer _bb)
		{
			return BrokenRockConfig.GetRootAsBrokenRockConfig(_bb, default(BrokenRockConfig));
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00208FCC File Offset: 0x002071CC
		public static BrokenRockConfig GetRootAsBrokenRockConfig(ByteBuffer _bb, BrokenRockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00208FE9 File Offset: 0x002071E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00208FF8 File Offset: 0x002071F8
		public BrokenRockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600558C RID: 21900 RVA: 0x00209008 File Offset: 0x00207208
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x00209044 File Offset: 0x00207244
		public string EntityUid
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

		// Token: 0x0600558E RID: 21902 RVA: 0x0020907B File Offset: 0x0020727B
		public Span<byte> GetEntityUidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x0020908A File Offset: 0x0020728A
		public byte[] GetEntityUidArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x002090A4 File Offset: 0x002072A4
		public int Rings(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x002090E4 File Offset: 0x002072E4
		public int RingsLength
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

		// Token: 0x06005592 RID: 21906 RVA: 0x0020910F File Offset: 0x0020730F
		public Span<int> GetRingsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x0020911E File Offset: 0x0020731E
		public int[] GetRingsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x00209138 File Offset: 0x00207338
		public int ScoreMax
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06005595 RID: 21909 RVA: 0x00209178 File Offset: 0x00207378
		public int ScoreUp
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06005596 RID: 21910 RVA: 0x002091B8 File Offset: 0x002073B8
		public int ScoreDown
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 20;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06005597 RID: 21911 RVA: 0x002091F8 File Offset: 0x002073F8
		public int GlobalTime
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

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06005598 RID: 21912 RVA: 0x00209238 File Offset: 0x00207438
		public int NormalSkill
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x00209278 File Offset: 0x00207478
		public int FinishSkill
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

		// Token: 0x0600559A RID: 21914 RVA: 0x002092B5 File Offset: 0x002074B5
		[NullableContext(1)]
		public int[] Rings()
		{
			return this.GetRingsArray();
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x002092BD File Offset: 0x002074BD
		[NullableContext(1)]
		public IEnumerable<int> RingsIter()
		{
			BrokenRockConfig.<RingsIter>d__32 <RingsIter>d__ = new BrokenRockConfig.<RingsIter>d__32(-2);
			<RingsIter>d__.<>3__<>4__this = this;
			return <RingsIter>d__;
		}

		// Token: 0x0400512B RID: 20779
		private Table __p;
	}
}
