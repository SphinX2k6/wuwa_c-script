using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005130 RID: 20784
	public struct IHour : IFlatbufferObject
	{
		// Token: 0x170094F2 RID: 38130
		// (get) Token: 0x06020AF1 RID: 133873 RVA: 0x004876C8 File Offset: 0x004858C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020AF2 RID: 133874 RVA: 0x004876D5 File Offset: 0x004858D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020AF3 RID: 133875 RVA: 0x004876DC File Offset: 0x004858DC
		public static IHour GetRootAsIHour(ByteBuffer _bb)
		{
			return IHour.GetRootAsIHour(_bb, default(IHour));
		}

		// Token: 0x06020AF4 RID: 133876 RVA: 0x004876F8 File Offset: 0x004858F8
		public static IHour GetRootAsIHour(ByteBuffer _bb, IHour obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020AF5 RID: 133877 RVA: 0x00487715 File Offset: 0x00485915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020AF6 RID: 133878 RVA: 0x00487724 File Offset: 0x00485924
		public IHour __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094F3 RID: 38131
		// (get) Token: 0x06020AF7 RID: 133879 RVA: 0x00487734 File Offset: 0x00485934
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

		// Token: 0x170094F4 RID: 38132
		// (get) Token: 0x06020AF8 RID: 133880 RVA: 0x00487770 File Offset: 0x00485970
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

		// Token: 0x06020AF9 RID: 133881 RVA: 0x004877AC File Offset: 0x004859AC
		public static Offset<IHour> CreateIHour(FlatBufferBuilder builder, int Hour = 0, int Min = 0)
		{
			builder.StartTable(2);
			IHour.AddMin(builder, Min);
			IHour.AddHour(builder, Hour);
			return IHour.EndIHour(builder);
		}

		// Token: 0x06020AFA RID: 133882 RVA: 0x004877C9 File Offset: 0x004859C9
		public static void StartIHour(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020AFB RID: 133883 RVA: 0x004877D2 File Offset: 0x004859D2
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(0, hour, 0);
		}

		// Token: 0x06020AFC RID: 133884 RVA: 0x004877DD File Offset: 0x004859DD
		public static void AddMin(FlatBufferBuilder builder, int min)
		{
			builder.AddInt(1, min, 0);
		}

		// Token: 0x06020AFD RID: 133885 RVA: 0x004877E8 File Offset: 0x004859E8
		public static Offset<IHour> EndIHour(FlatBufferBuilder builder)
		{
			return new Offset<IHour>(builder.EndTable());
		}

		// Token: 0x06020AFE RID: 133886 RVA: 0x004877F8 File Offset: 0x004859F8
		public IHourT UnPack()
		{
			IHourT hourT = new IHourT();
			this.UnPackTo(hourT);
			return hourT;
		}

		// Token: 0x06020AFF RID: 133887 RVA: 0x00487813 File Offset: 0x00485A13
		public void UnPackTo(IHourT _o)
		{
			_o.Hour = this.Hour;
			_o.Min = this.Min;
		}

		// Token: 0x06020B00 RID: 133888 RVA: 0x00487830 File Offset: 0x00485A30
		public static Offset<IHour> Pack(FlatBufferBuilder builder, IHourT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHour>);
			}
			return IHour.CreateIHour(builder, _o.Hour, _o.Min);
		}

		// Token: 0x0400E101 RID: 57601
		private Table __p;
	}
}
