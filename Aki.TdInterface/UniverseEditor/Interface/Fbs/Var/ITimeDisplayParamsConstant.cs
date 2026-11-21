using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF5 RID: 16117
	public struct ITimeDisplayParamsConstant : IFlatbufferObject
	{
		// Token: 0x17006D18 RID: 27928
		// (get) Token: 0x06015DAA RID: 89514 RVA: 0x00324969 File Offset: 0x00322B69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015DAB RID: 89515 RVA: 0x00324976 File Offset: 0x00322B76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015DAC RID: 89516 RVA: 0x00324980 File Offset: 0x00322B80
		public static ITimeDisplayParamsConstant GetRootAsITimeDisplayParamsConstant(ByteBuffer _bb)
		{
			return ITimeDisplayParamsConstant.GetRootAsITimeDisplayParamsConstant(_bb, default(ITimeDisplayParamsConstant));
		}

		// Token: 0x06015DAD RID: 89517 RVA: 0x0032499C File Offset: 0x00322B9C
		public static ITimeDisplayParamsConstant GetRootAsITimeDisplayParamsConstant(ByteBuffer _bb, ITimeDisplayParamsConstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015DAE RID: 89518 RVA: 0x003249B9 File Offset: 0x00322BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015DAF RID: 89519 RVA: 0x003249C8 File Offset: 0x00322BC8
		public ITimeDisplayParamsConstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D19 RID: 27929
		// (get) Token: 0x06015DB0 RID: 89520 RVA: 0x003249D8 File Offset: 0x00322BD8
		public ETimeDisplayDataSource Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeDisplayDataSource.Constant;
				}
				return (ETimeDisplayDataSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D1A RID: 27930
		// (get) Token: 0x06015DB1 RID: 89521 RVA: 0x00324A14 File Offset: 0x00322C14
		public int Value
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

		// Token: 0x06015DB2 RID: 89522 RVA: 0x00324A50 File Offset: 0x00322C50
		public static Offset<ITimeDisplayParamsConstant> CreateITimeDisplayParamsConstant(FlatBufferBuilder builder, ETimeDisplayDataSource Type = ETimeDisplayDataSource.Constant, int Value = 0)
		{
			builder.StartTable(2);
			ITimeDisplayParamsConstant.AddValue(builder, Value);
			ITimeDisplayParamsConstant.AddType(builder, Type);
			return ITimeDisplayParamsConstant.EndITimeDisplayParamsConstant(builder);
		}

		// Token: 0x06015DB3 RID: 89523 RVA: 0x00324A6D File Offset: 0x00322C6D
		public static void StartITimeDisplayParamsConstant(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015DB4 RID: 89524 RVA: 0x00324A76 File Offset: 0x00322C76
		public static void AddType(FlatBufferBuilder builder, ETimeDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015DB5 RID: 89525 RVA: 0x00324A81 File Offset: 0x00322C81
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x06015DB6 RID: 89526 RVA: 0x00324A8C File Offset: 0x00322C8C
		public static Offset<ITimeDisplayParamsConstant> EndITimeDisplayParamsConstant(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayParamsConstant>(builder.EndTable());
		}

		// Token: 0x06015DB7 RID: 89527 RVA: 0x00324A9C File Offset: 0x00322C9C
		public ITimeDisplayParamsConstantT UnPack()
		{
			ITimeDisplayParamsConstantT timeDisplayParamsConstantT = new ITimeDisplayParamsConstantT();
			this.UnPackTo(timeDisplayParamsConstantT);
			return timeDisplayParamsConstantT;
		}

		// Token: 0x06015DB8 RID: 89528 RVA: 0x00324AB7 File Offset: 0x00322CB7
		public void UnPackTo(ITimeDisplayParamsConstantT _o)
		{
			_o.Type = this.Type;
			_o.Value = this.Value;
		}

		// Token: 0x06015DB9 RID: 89529 RVA: 0x00324AD4 File Offset: 0x00322CD4
		public static Offset<ITimeDisplayParamsConstant> Pack(FlatBufferBuilder builder, ITimeDisplayParamsConstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeDisplayParamsConstant>);
			}
			return ITimeDisplayParamsConstant.CreateITimeDisplayParamsConstant(builder, _o.Type, _o.Value);
		}

		// Token: 0x0400B922 RID: 47394
		private Table __p;
	}
}
