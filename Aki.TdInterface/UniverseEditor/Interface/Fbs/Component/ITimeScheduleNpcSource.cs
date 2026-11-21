using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B5 RID: 24757
	public struct ITimeScheduleNpcSource : IFlatbufferObject
	{
		// Token: 0x1700B80D RID: 47117
		// (get) Token: 0x06029E3A RID: 171578 RVA: 0x005B7DD2 File Offset: 0x005B5FD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029E3B RID: 171579 RVA: 0x005B7DDF File Offset: 0x005B5FDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029E3C RID: 171580 RVA: 0x005B7DE8 File Offset: 0x005B5FE8
		public static ITimeScheduleNpcSource GetRootAsITimeScheduleNpcSource(ByteBuffer _bb)
		{
			return ITimeScheduleNpcSource.GetRootAsITimeScheduleNpcSource(_bb, default(ITimeScheduleNpcSource));
		}

		// Token: 0x06029E3D RID: 171581 RVA: 0x005B7E04 File Offset: 0x005B6004
		public static ITimeScheduleNpcSource GetRootAsITimeScheduleNpcSource(ByteBuffer _bb, ITimeScheduleNpcSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029E3E RID: 171582 RVA: 0x005B7E21 File Offset: 0x005B6021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029E3F RID: 171583 RVA: 0x005B7E30 File Offset: 0x005B6030
		public ITimeScheduleNpcSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B80E RID: 47118
		// (get) Token: 0x06029E40 RID: 171584 RVA: 0x005B7E40 File Offset: 0x005B6040
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

		// Token: 0x06029E41 RID: 171585 RVA: 0x005B7E7C File Offset: 0x005B607C
		public static Offset<ITimeScheduleNpcSource> CreateITimeScheduleNpcSource(FlatBufferBuilder builder, ETimeScheduleNpcSourceType Type = ETimeScheduleNpcSourceType.EntityTemplate)
		{
			builder.StartTable(1);
			ITimeScheduleNpcSource.AddType(builder, Type);
			return ITimeScheduleNpcSource.EndITimeScheduleNpcSource(builder);
		}

		// Token: 0x06029E42 RID: 171586 RVA: 0x005B7E92 File Offset: 0x005B6092
		public static void StartITimeScheduleNpcSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029E43 RID: 171587 RVA: 0x005B7E9B File Offset: 0x005B609B
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleNpcSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029E44 RID: 171588 RVA: 0x005B7EA6 File Offset: 0x005B60A6
		public static Offset<ITimeScheduleNpcSource> EndITimeScheduleNpcSource(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleNpcSource>(builder.EndTable());
		}

		// Token: 0x06029E45 RID: 171589 RVA: 0x005B7EB4 File Offset: 0x005B60B4
		public ITimeScheduleNpcSourceT UnPack()
		{
			ITimeScheduleNpcSourceT timeScheduleNpcSourceT = new ITimeScheduleNpcSourceT();
			this.UnPackTo(timeScheduleNpcSourceT);
			return timeScheduleNpcSourceT;
		}

		// Token: 0x06029E46 RID: 171590 RVA: 0x005B7ECF File Offset: 0x005B60CF
		public void UnPackTo(ITimeScheduleNpcSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029E47 RID: 171591 RVA: 0x005B7EE0 File Offset: 0x005B60E0
		public static Offset<ITimeScheduleNpcSource> Pack(FlatBufferBuilder builder, ITimeScheduleNpcSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleNpcSource>);
			}
			return ITimeScheduleNpcSource.CreateITimeScheduleNpcSource(builder, _o.Type);
		}

		// Token: 0x0400FE63 RID: 65123
		private Table __p;
	}
}
