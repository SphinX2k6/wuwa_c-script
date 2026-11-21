using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF2 RID: 16114
	public struct ITimeDisplayParams : IFlatbufferObject
	{
		// Token: 0x17006D15 RID: 27925
		// (get) Token: 0x06015D98 RID: 89496 RVA: 0x003247F4 File Offset: 0x003229F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015D99 RID: 89497 RVA: 0x00324801 File Offset: 0x00322A01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015D9A RID: 89498 RVA: 0x00324808 File Offset: 0x00322A08
		public static ITimeDisplayParams GetRootAsITimeDisplayParams(ByteBuffer _bb)
		{
			return ITimeDisplayParams.GetRootAsITimeDisplayParams(_bb, default(ITimeDisplayParams));
		}

		// Token: 0x06015D9B RID: 89499 RVA: 0x00324824 File Offset: 0x00322A24
		public static ITimeDisplayParams GetRootAsITimeDisplayParams(ByteBuffer _bb, ITimeDisplayParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015D9C RID: 89500 RVA: 0x00324841 File Offset: 0x00322A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015D9D RID: 89501 RVA: 0x00324850 File Offset: 0x00322A50
		public ITimeDisplayParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D16 RID: 27926
		// (get) Token: 0x06015D9E RID: 89502 RVA: 0x00324860 File Offset: 0x00322A60
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

		// Token: 0x06015D9F RID: 89503 RVA: 0x0032489C File Offset: 0x00322A9C
		public static Offset<ITimeDisplayParams> CreateITimeDisplayParams(FlatBufferBuilder builder, ETimeDisplayDataSource Type = ETimeDisplayDataSource.Constant)
		{
			builder.StartTable(1);
			ITimeDisplayParams.AddType(builder, Type);
			return ITimeDisplayParams.EndITimeDisplayParams(builder);
		}

		// Token: 0x06015DA0 RID: 89504 RVA: 0x003248B2 File Offset: 0x00322AB2
		public static void StartITimeDisplayParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015DA1 RID: 89505 RVA: 0x003248BB File Offset: 0x00322ABB
		public static void AddType(FlatBufferBuilder builder, ETimeDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015DA2 RID: 89506 RVA: 0x003248C6 File Offset: 0x00322AC6
		public static Offset<ITimeDisplayParams> EndITimeDisplayParams(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayParams>(builder.EndTable());
		}

		// Token: 0x06015DA3 RID: 89507 RVA: 0x003248D4 File Offset: 0x00322AD4
		public ITimeDisplayParamsT UnPack()
		{
			ITimeDisplayParamsT timeDisplayParamsT = new ITimeDisplayParamsT();
			this.UnPackTo(timeDisplayParamsT);
			return timeDisplayParamsT;
		}

		// Token: 0x06015DA4 RID: 89508 RVA: 0x003248EF File Offset: 0x00322AEF
		public void UnPackTo(ITimeDisplayParamsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015DA5 RID: 89509 RVA: 0x00324900 File Offset: 0x00322B00
		public static Offset<ITimeDisplayParams> Pack(FlatBufferBuilder builder, ITimeDisplayParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeDisplayParams>);
			}
			return ITimeDisplayParams.CreateITimeDisplayParams(builder, _o.Type);
		}

		// Token: 0x0400B920 RID: 47392
		private Table __p;
	}
}
