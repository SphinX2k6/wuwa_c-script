using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005067 RID: 20583
	public struct IClock : IFlatbufferObject
	{
		// Token: 0x1700934E RID: 37710
		// (get) Token: 0x060202DD RID: 131805 RVA: 0x00476306 File Offset: 0x00474506
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060202DE RID: 131806 RVA: 0x00476313 File Offset: 0x00474513
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060202DF RID: 131807 RVA: 0x0047631C File Offset: 0x0047451C
		public static IClock GetRootAsIClock(ByteBuffer _bb)
		{
			return IClock.GetRootAsIClock(_bb, default(IClock));
		}

		// Token: 0x060202E0 RID: 131808 RVA: 0x00476338 File Offset: 0x00474538
		public static IClock GetRootAsIClock(ByteBuffer _bb, IClock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060202E1 RID: 131809 RVA: 0x00476355 File Offset: 0x00474555
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060202E2 RID: 131810 RVA: 0x00476364 File Offset: 0x00474564
		public IClock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700934F RID: 37711
		// (get) Token: 0x060202E3 RID: 131811 RVA: 0x00476374 File Offset: 0x00474574
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009350 RID: 37712
		// (get) Token: 0x060202E4 RID: 131812 RVA: 0x004763B0 File Offset: 0x004745B0
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009351 RID: 37713
		// (get) Token: 0x060202E5 RID: 131813 RVA: 0x004763EC File Offset: 0x004745EC
		public int Start
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

		// Token: 0x17009352 RID: 37714
		// (get) Token: 0x060202E6 RID: 131814 RVA: 0x00476428 File Offset: 0x00474628
		public int End
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

		// Token: 0x060202E7 RID: 131815 RVA: 0x00476465 File Offset: 0x00474665
		public static Offset<IClock> CreateIClock(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, int Start = 0, int End = 0)
		{
			builder.StartTable(4);
			IClock.AddEnd(builder, End);
			IClock.AddStart(builder, Start);
			IClock.AddCompare(builder, Compare);
			IClock.AddType(builder, Type);
			return IClock.EndIClock(builder);
		}

		// Token: 0x060202E8 RID: 131816 RVA: 0x00476491 File Offset: 0x00474691
		public static void StartIClock(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060202E9 RID: 131817 RVA: 0x0047649A File Offset: 0x0047469A
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060202EA RID: 131818 RVA: 0x004764A5 File Offset: 0x004746A5
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060202EB RID: 131819 RVA: 0x004764B0 File Offset: 0x004746B0
		public static void AddStart(FlatBufferBuilder builder, int start)
		{
			builder.AddInt(2, start, 0);
		}

		// Token: 0x060202EC RID: 131820 RVA: 0x004764BB File Offset: 0x004746BB
		public static void AddEnd(FlatBufferBuilder builder, int end)
		{
			builder.AddInt(3, end, 0);
		}

		// Token: 0x060202ED RID: 131821 RVA: 0x004764C6 File Offset: 0x004746C6
		public static Offset<IClock> EndIClock(FlatBufferBuilder builder)
		{
			return new Offset<IClock>(builder.EndTable());
		}

		// Token: 0x060202EE RID: 131822 RVA: 0x004764D4 File Offset: 0x004746D4
		public IClockT UnPack()
		{
			IClockT clockT = new IClockT();
			this.UnPackTo(clockT);
			return clockT;
		}

		// Token: 0x060202EF RID: 131823 RVA: 0x004764EF File Offset: 0x004746EF
		public void UnPackTo(IClockT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Start = this.Start;
			_o.End = this.End;
		}

		// Token: 0x060202F0 RID: 131824 RVA: 0x00476524 File Offset: 0x00474724
		public static Offset<IClock> Pack(FlatBufferBuilder builder, IClockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClock>);
			}
			return IClock.CreateIClock(builder, _o.Type, _o.Compare, _o.Start, _o.End);
		}

		// Token: 0x0400DF4E RID: 57166
		private Table __p;
	}
}
