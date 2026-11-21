using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060AF RID: 24751
	public struct ITimeScheduleGenerateParams : IFlatbufferObject
	{
		// Token: 0x1700B808 RID: 47112
		// (get) Token: 0x06029E1C RID: 171548 RVA: 0x005B7B5D File Offset: 0x005B5D5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029E1D RID: 171549 RVA: 0x005B7B6A File Offset: 0x005B5D6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029E1E RID: 171550 RVA: 0x005B7B74 File Offset: 0x005B5D74
		public static ITimeScheduleGenerateParams GetRootAsITimeScheduleGenerateParams(ByteBuffer _bb)
		{
			return ITimeScheduleGenerateParams.GetRootAsITimeScheduleGenerateParams(_bb, default(ITimeScheduleGenerateParams));
		}

		// Token: 0x06029E1F RID: 171551 RVA: 0x005B7B90 File Offset: 0x005B5D90
		public static ITimeScheduleGenerateParams GetRootAsITimeScheduleGenerateParams(ByteBuffer _bb, ITimeScheduleGenerateParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029E20 RID: 171552 RVA: 0x005B7BAD File Offset: 0x005B5DAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029E21 RID: 171553 RVA: 0x005B7BBC File Offset: 0x005B5DBC
		public ITimeScheduleGenerateParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B809 RID: 47113
		// (get) Token: 0x06029E22 RID: 171554 RVA: 0x005B7BCC File Offset: 0x005B5DCC
		public ETimeScheduleGenerateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleGenerateType.FixedIntervalRefresh;
				}
				return (ETimeScheduleGenerateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029E23 RID: 171555 RVA: 0x005B7C08 File Offset: 0x005B5E08
		public static Offset<ITimeScheduleGenerateParams> CreateITimeScheduleGenerateParams(FlatBufferBuilder builder, ETimeScheduleGenerateType Type = ETimeScheduleGenerateType.FixedIntervalRefresh)
		{
			builder.StartTable(1);
			ITimeScheduleGenerateParams.AddType(builder, Type);
			return ITimeScheduleGenerateParams.EndITimeScheduleGenerateParams(builder);
		}

		// Token: 0x06029E24 RID: 171556 RVA: 0x005B7C1E File Offset: 0x005B5E1E
		public static void StartITimeScheduleGenerateParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029E25 RID: 171557 RVA: 0x005B7C27 File Offset: 0x005B5E27
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029E26 RID: 171558 RVA: 0x005B7C32 File Offset: 0x005B5E32
		public static Offset<ITimeScheduleGenerateParams> EndITimeScheduleGenerateParams(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleGenerateParams>(builder.EndTable());
		}

		// Token: 0x06029E27 RID: 171559 RVA: 0x005B7C40 File Offset: 0x005B5E40
		public ITimeScheduleGenerateParamsT UnPack()
		{
			ITimeScheduleGenerateParamsT timeScheduleGenerateParamsT = new ITimeScheduleGenerateParamsT();
			this.UnPackTo(timeScheduleGenerateParamsT);
			return timeScheduleGenerateParamsT;
		}

		// Token: 0x06029E28 RID: 171560 RVA: 0x005B7C5B File Offset: 0x005B5E5B
		public void UnPackTo(ITimeScheduleGenerateParamsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029E29 RID: 171561 RVA: 0x005B7C6C File Offset: 0x005B5E6C
		public static Offset<ITimeScheduleGenerateParams> Pack(FlatBufferBuilder builder, ITimeScheduleGenerateParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleGenerateParams>);
			}
			return ITimeScheduleGenerateParams.CreateITimeScheduleGenerateParams(builder, _o.Type);
		}

		// Token: 0x0400FE5B RID: 65115
		private Table __p;
	}
}
