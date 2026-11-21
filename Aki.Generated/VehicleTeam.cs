using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C2 RID: 4802
	public struct VehicleTeam : IFlatbufferObject
	{
		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x0600F473 RID: 62579 RVA: 0x0036B4CC File Offset: 0x003696CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F474 RID: 62580 RVA: 0x0036B4D9 File Offset: 0x003696D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F475 RID: 62581 RVA: 0x0036B4E0 File Offset: 0x003696E0
		public static VehicleTeam GetRootAsVehicleTeam(ByteBuffer _bb)
		{
			return VehicleTeam.GetRootAsVehicleTeam(_bb, default(VehicleTeam));
		}

		// Token: 0x0600F476 RID: 62582 RVA: 0x0036B4FC File Offset: 0x003696FC
		public static VehicleTeam GetRootAsVehicleTeam(ByteBuffer _bb, VehicleTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F477 RID: 62583 RVA: 0x0036B519 File Offset: 0x00369719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F478 RID: 62584 RVA: 0x0036B528 File Offset: 0x00369728
		public VehicleTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x0600F479 RID: 62585 RVA: 0x0036B538 File Offset: 0x00369738
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

		// Token: 0x0600F47A RID: 62586 RVA: 0x0036B574 File Offset: 0x00369774
		public int TemplateList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x0600F47B RID: 62587 RVA: 0x0036B5B4 File Offset: 0x003697B4
		public int TemplateListLength
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

		// Token: 0x0600F47C RID: 62588 RVA: 0x0036B5DF File Offset: 0x003697DF
		public Span<int> GetTemplateListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600F47D RID: 62589 RVA: 0x0036B5EE File Offset: 0x003697EE
		public int[] GetTemplateListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600F47E RID: 62590 RVA: 0x0036B608 File Offset: 0x00369808
		public Vector? PositionList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new Vector?(default(Vector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x0600F47F RID: 62591 RVA: 0x0036B668 File Offset: 0x00369868
		public int PositionListLength
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

		// Token: 0x0600F480 RID: 62592 RVA: 0x0036B693 File Offset: 0x00369893
		[NullableContext(1)]
		public Vector[] PositionList()
		{
			return this.PositionListIter().ToArray<Vector>();
		}

		// Token: 0x0600F481 RID: 62593 RVA: 0x0036B6A0 File Offset: 0x003698A0
		[NullableContext(1)]
		public IEnumerable<Vector> PositionListIter()
		{
			VehicleTeam.<PositionListIter>d__19 <PositionListIter>d__ = new VehicleTeam.<PositionListIter>d__19(-2);
			<PositionListIter>d__.<>3__<>4__this = this;
			return <PositionListIter>d__;
		}

		// Token: 0x0600F482 RID: 62594 RVA: 0x0036B6B5 File Offset: 0x003698B5
		[NullableContext(1)]
		public int[] TemplateList()
		{
			return this.GetTemplateListArray();
		}

		// Token: 0x0600F483 RID: 62595 RVA: 0x0036B6BD File Offset: 0x003698BD
		[NullableContext(1)]
		public IEnumerable<int> TemplateListIter()
		{
			VehicleTeam.<TemplateListIter>d__21 <TemplateListIter>d__ = new VehicleTeam.<TemplateListIter>d__21(-2);
			<TemplateListIter>d__.<>3__<>4__this = this;
			return <TemplateListIter>d__;
		}

		// Token: 0x04005919 RID: 22809
		private Table __p;
	}
}
