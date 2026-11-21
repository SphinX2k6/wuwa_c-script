using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D8 RID: 26584
	public struct IAdjustTodTime : IFlatbufferObject
	{
		// Token: 0x1700C33F RID: 49983
		// (get) Token: 0x0602D609 RID: 185865 RVA: 0x00636C16 File Offset: 0x00634E16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D60A RID: 185866 RVA: 0x00636C23 File Offset: 0x00634E23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D60B RID: 185867 RVA: 0x00636C2C File Offset: 0x00634E2C
		public static IAdjustTodTime GetRootAsIAdjustTodTime(ByteBuffer _bb)
		{
			return IAdjustTodTime.GetRootAsIAdjustTodTime(_bb, default(IAdjustTodTime));
		}

		// Token: 0x0602D60C RID: 185868 RVA: 0x00636C48 File Offset: 0x00634E48
		public static IAdjustTodTime GetRootAsIAdjustTodTime(ByteBuffer _bb, IAdjustTodTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D60D RID: 185869 RVA: 0x00636C65 File Offset: 0x00634E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D60E RID: 185870 RVA: 0x00636C74 File Offset: 0x00634E74
		public IAdjustTodTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C340 RID: 49984
		// (get) Token: 0x0602D60F RID: 185871 RVA: 0x00636C84 File Offset: 0x00634E84
		public int Hour
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

		// Token: 0x1700C341 RID: 49985
		// (get) Token: 0x0602D610 RID: 185872 RVA: 0x00636CC0 File Offset: 0x00634EC0
		public int Min
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

		// Token: 0x1700C342 RID: 49986
		// (get) Token: 0x0602D611 RID: 185873 RVA: 0x00636CFC File Offset: 0x00634EFC
		public bool ShowUi
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D612 RID: 185874 RVA: 0x00636D3B File Offset: 0x00634F3B
		public static Offset<IAdjustTodTime> CreateIAdjustTodTime(FlatBufferBuilder builder, int Hour = 0, int Min = 0, bool ShowUi = false)
		{
			builder.StartTable(3);
			IAdjustTodTime.AddMin(builder, Min);
			IAdjustTodTime.AddHour(builder, Hour);
			IAdjustTodTime.AddShowUi(builder, ShowUi);
			return IAdjustTodTime.EndIAdjustTodTime(builder);
		}

		// Token: 0x0602D613 RID: 185875 RVA: 0x00636D5F File Offset: 0x00634F5F
		public static void StartIAdjustTodTime(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D614 RID: 185876 RVA: 0x00636D68 File Offset: 0x00634F68
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x0602D615 RID: 185877 RVA: 0x00636D73 File Offset: 0x00634F73
		public static void AddMin(FlatBufferBuilder builder, int min)
		{
			builder.AddInt(1, min, 0);
		}

		// Token: 0x0602D616 RID: 185878 RVA: 0x00636D7E File Offset: 0x00634F7E
		public static void AddShowUi(FlatBufferBuilder builder, bool showUi)
		{
			builder.AddBool(2, showUi, false);
		}

		// Token: 0x0602D617 RID: 185879 RVA: 0x00636D89 File Offset: 0x00634F89
		public static Offset<IAdjustTodTime> EndIAdjustTodTime(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustTodTime>(builder.EndTable());
		}

		// Token: 0x0602D618 RID: 185880 RVA: 0x00636D98 File Offset: 0x00634F98
		public IAdjustTodTimeT UnPack()
		{
			IAdjustTodTimeT adjustTodTimeT = new IAdjustTodTimeT();
			this.UnPackTo(adjustTodTimeT);
			return adjustTodTimeT;
		}

		// Token: 0x0602D619 RID: 185881 RVA: 0x00636DB3 File Offset: 0x00634FB3
		public void UnPackTo(IAdjustTodTimeT _o)
		{
			_o.Hour = this.Hour;
			_o.Min = this.Min;
			_o.ShowUi = this.ShowUi;
		}

		// Token: 0x0602D61A RID: 185882 RVA: 0x00636DDC File Offset: 0x00634FDC
		public static Offset<IAdjustTodTime> Pack(FlatBufferBuilder builder, IAdjustTodTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustTodTime>);
			}
			return IAdjustTodTime.CreateIAdjustTodTime(builder, _o.Hour, _o.Min, _o.ShowUi);
		}

		// Token: 0x04011460 RID: 70752
		private Table __p;
	}
}
