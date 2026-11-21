using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E2 RID: 4834
	public struct WuWuWeekTask : IFlatbufferObject
	{
		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x0600F704 RID: 63236 RVA: 0x003712D5 File Offset: 0x0036F4D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F705 RID: 63237 RVA: 0x003712E2 File Offset: 0x0036F4E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F706 RID: 63238 RVA: 0x003712EC File Offset: 0x0036F4EC
		public static WuWuWeekTask GetRootAsWuWuWeekTask(ByteBuffer _bb)
		{
			return WuWuWeekTask.GetRootAsWuWuWeekTask(_bb, default(WuWuWeekTask));
		}

		// Token: 0x0600F707 RID: 63239 RVA: 0x00371308 File Offset: 0x0036F508
		public static WuWuWeekTask GetRootAsWuWuWeekTask(ByteBuffer _bb, WuWuWeekTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F708 RID: 63240 RVA: 0x00371325 File Offset: 0x0036F525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F709 RID: 63241 RVA: 0x00371334 File Offset: 0x0036F534
		public WuWuWeekTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x0600F70A RID: 63242 RVA: 0x00371344 File Offset: 0x0036F544
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

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x0600F70B RID: 63243 RVA: 0x00371380 File Offset: 0x0036F580
		public int WrapId
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

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x0600F70C RID: 63244 RVA: 0x003713BC File Offset: 0x0036F5BC
		public int ActivityId
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

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x0600F70D RID: 63245 RVA: 0x003713F8 File Offset: 0x0036F5F8
		public int ConditionGroup
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

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x0600F70E RID: 63246 RVA: 0x00371438 File Offset: 0x0036F638
		public int ProgressType
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

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x0600F70F RID: 63247 RVA: 0x00371478 File Offset: 0x0036F678
		public int ProgressCondition
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

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x0600F710 RID: 63248 RVA: 0x003714B8 File Offset: 0x0036F6B8
		public int DropId
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

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x0600F711 RID: 63249 RVA: 0x003714F8 File Offset: 0x0036F6F8
		public string Title
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

		// Token: 0x0600F712 RID: 63250 RVA: 0x00371530 File Offset: 0x0036F730
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F713 RID: 63251 RVA: 0x00371540 File Offset: 0x0036F740
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400593C RID: 22844
		private Table __p;
	}
}
