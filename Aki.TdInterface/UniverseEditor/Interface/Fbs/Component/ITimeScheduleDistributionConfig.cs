using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A96 RID: 23190
	public struct ITimeScheduleDistributionConfig : IFlatbufferObject
	{
		// Token: 0x1700AEB6 RID: 44726
		// (get) Token: 0x06027834 RID: 161844 RVA: 0x0056FC2C File Offset: 0x0056DE2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027835 RID: 161845 RVA: 0x0056FC39 File Offset: 0x0056DE39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027836 RID: 161846 RVA: 0x0056FC40 File Offset: 0x0056DE40
		public static ITimeScheduleDistributionConfig GetRootAsITimeScheduleDistributionConfig(ByteBuffer _bb)
		{
			return ITimeScheduleDistributionConfig.GetRootAsITimeScheduleDistributionConfig(_bb, default(ITimeScheduleDistributionConfig));
		}

		// Token: 0x06027837 RID: 161847 RVA: 0x0056FC5C File Offset: 0x0056DE5C
		public static ITimeScheduleDistributionConfig GetRootAsITimeScheduleDistributionConfig(ByteBuffer _bb, ITimeScheduleDistributionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027838 RID: 161848 RVA: 0x0056FC79 File Offset: 0x0056DE79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027839 RID: 161849 RVA: 0x0056FC88 File Offset: 0x0056DE88
		public ITimeScheduleDistributionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEB7 RID: 44727
		// (get) Token: 0x0602783A RID: 161850 RVA: 0x0056FC98 File Offset: 0x0056DE98
		public ETimeScheduleDistributionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleDistributionType.RandomSchedulePosition;
				}
				return (ETimeScheduleDistributionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602783B RID: 161851 RVA: 0x0056FCD4 File Offset: 0x0056DED4
		public static Offset<ITimeScheduleDistributionConfig> CreateITimeScheduleDistributionConfig(FlatBufferBuilder builder, ETimeScheduleDistributionType Type = ETimeScheduleDistributionType.RandomSchedulePosition)
		{
			builder.StartTable(1);
			ITimeScheduleDistributionConfig.AddType(builder, Type);
			return ITimeScheduleDistributionConfig.EndITimeScheduleDistributionConfig(builder);
		}

		// Token: 0x0602783C RID: 161852 RVA: 0x0056FCEA File Offset: 0x0056DEEA
		public static void StartITimeScheduleDistributionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602783D RID: 161853 RVA: 0x0056FCF3 File Offset: 0x0056DEF3
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleDistributionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602783E RID: 161854 RVA: 0x0056FCFE File Offset: 0x0056DEFE
		public static Offset<ITimeScheduleDistributionConfig> EndITimeScheduleDistributionConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleDistributionConfig>(builder.EndTable());
		}

		// Token: 0x0602783F RID: 161855 RVA: 0x0056FD0C File Offset: 0x0056DF0C
		public ITimeScheduleDistributionConfigT UnPack()
		{
			ITimeScheduleDistributionConfigT timeScheduleDistributionConfigT = new ITimeScheduleDistributionConfigT();
			this.UnPackTo(timeScheduleDistributionConfigT);
			return timeScheduleDistributionConfigT;
		}

		// Token: 0x06027840 RID: 161856 RVA: 0x0056FD27 File Offset: 0x0056DF27
		public void UnPackTo(ITimeScheduleDistributionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027841 RID: 161857 RVA: 0x0056FD38 File Offset: 0x0056DF38
		public static Offset<ITimeScheduleDistributionConfig> Pack(FlatBufferBuilder builder, ITimeScheduleDistributionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleDistributionConfig>);
			}
			return ITimeScheduleDistributionConfig.CreateITimeScheduleDistributionConfig(builder, _o.Type);
		}

		// Token: 0x0400F155 RID: 61781
		private Table __p;
	}
}
