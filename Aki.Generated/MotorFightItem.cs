using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F29 RID: 3881
	public struct MotorFightItem : IFlatbufferObject
	{
		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06009E68 RID: 40552 RVA: 0x002AC701 File Offset: 0x002AA901
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x002AC70E File Offset: 0x002AA90E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x002AC718 File Offset: 0x002AA918
		public static MotorFightItem GetRootAsMotorFightItem(ByteBuffer _bb)
		{
			return MotorFightItem.GetRootAsMotorFightItem(_bb, default(MotorFightItem));
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x002AC734 File Offset: 0x002AA934
		public static MotorFightItem GetRootAsMotorFightItem(ByteBuffer _bb, MotorFightItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x002AC751 File Offset: 0x002AA951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E6D RID: 40557 RVA: 0x002AC760 File Offset: 0x002AA960
		public MotorFightItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06009E6E RID: 40558 RVA: 0x002AC770 File Offset: 0x002AA970
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

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x002AC7AC File Offset: 0x002AA9AC
		public int ActivityId
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

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06009E70 RID: 40560 RVA: 0x002AC7E8 File Offset: 0x002AA9E8
		public int GetLimitNumber
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

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06009E71 RID: 40561 RVA: 0x002AC824 File Offset: 0x002AAA24
		public int Type
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

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06009E72 RID: 40562 RVA: 0x002AC864 File Offset: 0x002AAA64
		public int Quality
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

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06009E73 RID: 40563 RVA: 0x002AC8A4 File Offset: 0x002AAAA4
		public int UnlockCondition
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

		// Token: 0x06009E74 RID: 40564 RVA: 0x002AC8E4 File Offset: 0x002AAAE4
		public int Effects(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06009E75 RID: 40565 RVA: 0x002AC924 File Offset: 0x002AAB24
		public int EffectsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x002AC950 File Offset: 0x002AAB50
		public Span<int> GetEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x002AC960 File Offset: 0x002AAB60
		public int[] GetEffectsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06009E78 RID: 40568 RVA: 0x002AC978 File Offset: 0x002AAB78
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

		// Token: 0x06009E79 RID: 40569 RVA: 0x002AC9B0 File Offset: 0x002AABB0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x002AC9C0 File Offset: 0x002AABC0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06009E7B RID: 40571 RVA: 0x002AC9D8 File Offset: 0x002AABD8
		public string Desc
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

		// Token: 0x06009E7C RID: 40572 RVA: 0x002ACA10 File Offset: 0x002AAC10
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x002ACA20 File Offset: 0x002AAC20
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x002ACA38 File Offset: 0x002AAC38
		public string DescParam(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06009E7F RID: 40575 RVA: 0x002ACA74 File Offset: 0x002AAC74
		public int DescParamLength
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

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06009E80 RID: 40576 RVA: 0x002ACAA0 File Offset: 0x002AACA0
		public string Icon
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

		// Token: 0x06009E81 RID: 40577 RVA: 0x002ACAD8 File Offset: 0x002AACD8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x002ACAE8 File Offset: 0x002AACE8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06009E83 RID: 40579 RVA: 0x002ACB00 File Offset: 0x002AAD00
		public string IconBig
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x002ACB38 File Offset: 0x002AAD38
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x002ACB48 File Offset: 0x002AAD48
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06009E86 RID: 40582 RVA: 0x002ACB60 File Offset: 0x002AAD60
		public bool IsShowInHandBook
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x002ACBA0 File Offset: 0x002AADA0
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x002ACBAD File Offset: 0x002AADAD
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			MotorFightItem.<DescParamIter>d__47 <DescParamIter>d__ = new MotorFightItem.<DescParamIter>d__47(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x002ACBC2 File Offset: 0x002AADC2
		[NullableContext(1)]
		public int[] Effects()
		{
			return this.GetEffectsArray();
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x002ACBCA File Offset: 0x002AADCA
		[NullableContext(1)]
		public IEnumerable<int> EffectsIter()
		{
			MotorFightItem.<EffectsIter>d__49 <EffectsIter>d__ = new MotorFightItem.<EffectsIter>d__49(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x040054D1 RID: 21713
		private Table __p;
	}
}
