using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA8 RID: 23208
	public struct ITimeScheduleNpcSource : IFlatbufferObject
	{
		// Token: 0x1700AED3 RID: 44755
		// (get) Token: 0x060278B8 RID: 161976 RVA: 0x00570B92 File Offset: 0x0056ED92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060278B9 RID: 161977 RVA: 0x00570B9F File Offset: 0x0056ED9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060278BA RID: 161978 RVA: 0x00570BA8 File Offset: 0x0056EDA8
		public static ITimeScheduleNpcSource GetRootAsITimeScheduleNpcSource(ByteBuffer _bb)
		{
			return ITimeScheduleNpcSource.GetRootAsITimeScheduleNpcSource(_bb, default(ITimeScheduleNpcSource));
		}

		// Token: 0x060278BB RID: 161979 RVA: 0x00570BC4 File Offset: 0x0056EDC4
		public static ITimeScheduleNpcSource GetRootAsITimeScheduleNpcSource(ByteBuffer _bb, ITimeScheduleNpcSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278BC RID: 161980 RVA: 0x00570BE1 File Offset: 0x0056EDE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278BD RID: 161981 RVA: 0x00570BF0 File Offset: 0x0056EDF0
		public ITimeScheduleNpcSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AED4 RID: 44756
		// (get) Token: 0x060278BE RID: 161982 RVA: 0x00570C00 File Offset: 0x0056EE00
		public ETimeScheduleNpcSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleNpcSourceType.EntityTemplate;
				}
				return (ETimeScheduleNpcSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060278BF RID: 161983 RVA: 0x00570C3C File Offset: 0x0056EE3C
		public static Offset<ITimeScheduleNpcSource> CreateITimeScheduleNpcSource(FlatBufferBuilder builder, ETimeScheduleNpcSourceType Type = ETimeScheduleNpcSourceType.EntityTemplate)
		{
			builder.StartTable(1);
			ITimeScheduleNpcSource.AddType(builder, Type);
			return ITimeScheduleNpcSource.EndITimeScheduleNpcSource(builder);
		}

		// Token: 0x060278C0 RID: 161984 RVA: 0x00570C52 File Offset: 0x0056EE52
		public static void StartITimeScheduleNpcSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060278C1 RID: 161985 RVA: 0x00570C5B File Offset: 0x0056EE5B
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleNpcSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060278C2 RID: 161986 RVA: 0x00570C66 File Offset: 0x0056EE66
		public static Offset<ITimeScheduleNpcSource> EndITimeScheduleNpcSource(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleNpcSource>(builder.EndTable());
		}

		// Token: 0x060278C3 RID: 161987 RVA: 0x00570C74 File Offset: 0x0056EE74
		public ITimeScheduleNpcSourceT UnPack()
		{
			ITimeScheduleNpcSourceT timeScheduleNpcSourceT = new ITimeScheduleNpcSourceT();
			this.UnPackTo(timeScheduleNpcSourceT);
			return timeScheduleNpcSourceT;
		}

		// Token: 0x060278C4 RID: 161988 RVA: 0x00570C8F File Offset: 0x0056EE8F
		public void UnPackTo(ITimeScheduleNpcSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060278C5 RID: 161989 RVA: 0x00570CA0 File Offset: 0x0056EEA0
		public static Offset<ITimeScheduleNpcSource> Pack(FlatBufferBuilder builder, ITimeScheduleNpcSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleNpcSource>);
			}
			return ITimeScheduleNpcSource.CreateITimeScheduleNpcSource(builder, _o.Type);
		}

		// Token: 0x0400F16B RID: 61803
		private Table __p;
	}
}
