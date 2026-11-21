using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109E RID: 4254
	public struct Reigns : IFlatbufferObject
	{
		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0600C1A5 RID: 49573 RVA: 0x002F945D File Offset: 0x002F765D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1A6 RID: 49574 RVA: 0x002F946A File Offset: 0x002F766A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1A7 RID: 49575 RVA: 0x002F9474 File Offset: 0x002F7674
		public static Reigns GetRootAsReigns(ByteBuffer _bb)
		{
			return Reigns.GetRootAsReigns(_bb, default(Reigns));
		}

		// Token: 0x0600C1A8 RID: 49576 RVA: 0x002F9490 File Offset: 0x002F7690
		public static Reigns GetRootAsReigns(ByteBuffer _bb, Reigns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x002F94AD File Offset: 0x002F76AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1AA RID: 49578 RVA: 0x002F94BC File Offset: 0x002F76BC
		public Reigns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0600C1AB RID: 49579 RVA: 0x002F94CC File Offset: 0x002F76CC
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

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600C1AC RID: 49580 RVA: 0x002F9508 File Offset: 0x002F7708
		public int NextReignsId
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

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600C1AD RID: 49581 RVA: 0x002F9544 File Offset: 0x002F7744
		public int PropertyDownReducePercent
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

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600C1AE RID: 49582 RVA: 0x002F9580 File Offset: 0x002F7780
		public string TargetText
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

		// Token: 0x0600C1AF RID: 49583 RVA: 0x002F95B8 File Offset: 0x002F77B8
		public Span<byte> GetTargetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C1B0 RID: 49584 RVA: 0x002F95C8 File Offset: 0x002F77C8
		public byte[] GetTargetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0600C1B1 RID: 49585 RVA: 0x002F95E0 File Offset: 0x002F77E0
		public string TitleText
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

		// Token: 0x0600C1B2 RID: 49586 RVA: 0x002F9618 File Offset: 0x002F7818
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C1B3 RID: 49587 RVA: 0x002F9628 File Offset: 0x002F7828
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C1B4 RID: 49588 RVA: 0x002F9640 File Offset: 0x002F7840
		public string FlowId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600C1B5 RID: 49589 RVA: 0x002F967C File Offset: 0x002F787C
		public int FlowIdLength
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

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600C1B6 RID: 49590 RVA: 0x002F96A8 File Offset: 0x002F78A8
		public string EndingList
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

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x002F96E0 File Offset: 0x002F78E0
		public Span<byte> GetEndingListBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C1B8 RID: 49592 RVA: 0x002F96F0 File Offset: 0x002F78F0
		public byte[] GetEndingListArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x0600C1B9 RID: 49593 RVA: 0x002F9708 File Offset: 0x002F7908
		public string BaseProperty
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

		// Token: 0x0600C1BA RID: 49594 RVA: 0x002F9740 File Offset: 0x002F7940
		public Span<byte> GetBasePropertyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x002F9750 File Offset: 0x002F7950
		public byte[] GetBasePropertyArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C1BC RID: 49596 RVA: 0x002F9768 File Offset: 0x002F7968
		[NullableContext(1)]
		public string[] FlowId()
		{
			return this.FlowIdIter().ToArray<string>();
		}

		// Token: 0x0600C1BD RID: 49597 RVA: 0x002F9775 File Offset: 0x002F7975
		[NullableContext(1)]
		public IEnumerable<string> FlowIdIter()
		{
			Reigns.<FlowIdIter>d__34 <FlowIdIter>d__ = new Reigns.<FlowIdIter>d__34(-2);
			<FlowIdIter>d__.<>3__<>4__this = this;
			return <FlowIdIter>d__;
		}

		// Token: 0x04005677 RID: 22135
		private Table __p;
	}
}
