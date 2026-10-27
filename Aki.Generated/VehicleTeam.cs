using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118C RID: 4492
	public struct VehicleTeam : IFlatbufferObject
	{
		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x0600E705 RID: 59141 RVA: 0x003406F4 File Offset: 0x0033E8F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x00340701 File Offset: 0x0033E901
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E707 RID: 59143 RVA: 0x00340708 File Offset: 0x0033E908
		public static VehicleTeam GetRootAsVehicleTeam(ByteBuffer _bb)
		{
			return VehicleTeam.GetRootAsVehicleTeam(_bb, default(VehicleTeam));
		}

		// Token: 0x0600E708 RID: 59144 RVA: 0x00340724 File Offset: 0x0033E924
		public static VehicleTeam GetRootAsVehicleTeam(ByteBuffer _bb, VehicleTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E709 RID: 59145 RVA: 0x00340741 File Offset: 0x0033E941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E70A RID: 59146 RVA: 0x00340750 File Offset: 0x0033E950
		public VehicleTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x0600E70B RID: 59147 RVA: 0x00340760 File Offset: 0x0033E960
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

		// Token: 0x0600E70C RID: 59148 RVA: 0x0034079C File Offset: 0x0033E99C
		public int TemplateList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x0600E70D RID: 59149 RVA: 0x003407DC File Offset: 0x0033E9DC
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

		// Token: 0x0600E70E RID: 59150 RVA: 0x00340807 File Offset: 0x0033EA07
		public Span<int> GetTemplateListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E70F RID: 59151 RVA: 0x00340816 File Offset: 0x0033EA16
		public int[] GetTemplateListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600E710 RID: 59152 RVA: 0x00340830 File Offset: 0x0033EA30
		public Vector? PositionList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new Vector?(default(Vector).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x0600E711 RID: 59153 RVA: 0x00340890 File Offset: 0x0033EA90
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

		// Token: 0x0600E712 RID: 59154 RVA: 0x003408BB File Offset: 0x0033EABB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PositionListIter()或GetPositionListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Vector[] PositionList()
		{
			return this.PositionListIter().ToArray<Vector>();
		}

		// Token: 0x0600E713 RID: 59155 RVA: 0x003408C8 File Offset: 0x0033EAC8
		[NullableContext(1)]
		public readonly IEnumerable<Vector> PositionListIter()
		{
			VehicleTeam.<PositionListIter>d__19 <PositionListIter>d__ = new VehicleTeam.<PositionListIter>d__19(-2);
			<PositionListIter>d__.<>3__<>4__this = this;
			return <PositionListIter>d__;
		}

		// Token: 0x0600E714 RID: 59156 RVA: 0x003408E0 File Offset: 0x0033EAE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TemplateListIter()或GetTemplateListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TemplateList()
		{
			VehicleTeam vehicleTeam = this;
			return vehicleTeam.GetTemplateListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E715 RID: 59157 RVA: 0x00340904 File Offset: 0x0033EB04
		[NullableContext(1)]
		public readonly IEnumerable<int> TemplateListIter()
		{
			VehicleTeam.<TemplateListIter>d__21 <TemplateListIter>d__ = new VehicleTeam.<TemplateListIter>d__21(-2);
			<TemplateListIter>d__.<>3__<>4__this = this;
			return <TemplateListIter>d__;
		}

		// Token: 0x040052D6 RID: 21206
		private Table __p;
	}
}
