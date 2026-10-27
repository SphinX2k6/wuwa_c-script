using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EC RID: 26604
	public struct IFlowActionContext : IFlatbufferObject
	{
		// Token: 0x1700C575 RID: 50549
		// (get) Token: 0x0602E515 RID: 189717 RVA: 0x00652C33 File Offset: 0x00650E33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E516 RID: 189718 RVA: 0x00652C40 File Offset: 0x00650E40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E517 RID: 189719 RVA: 0x00652C48 File Offset: 0x00650E48
		public static IFlowActionContext GetRootAsIFlowActionContext(ByteBuffer _bb)
		{
			return IFlowActionContext.GetRootAsIFlowActionContext(_bb, default(IFlowActionContext));
		}

		// Token: 0x0602E518 RID: 189720 RVA: 0x00652C64 File Offset: 0x00650E64
		public static IFlowActionContext GetRootAsIFlowActionContext(ByteBuffer _bb, IFlowActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E519 RID: 189721 RVA: 0x00652C81 File Offset: 0x00650E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E51A RID: 189722 RVA: 0x00652C90 File Offset: 0x00650E90
		public IFlowActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C576 RID: 50550
		// (get) Token: 0x0602E51B RID: 189723 RVA: 0x00652CA0 File Offset: 0x00650EA0
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E51C RID: 189724 RVA: 0x00652CD7 File Offset: 0x00650ED7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E51D RID: 189725 RVA: 0x00652CE6 File Offset: 0x00650EE6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602E51E RID: 189726 RVA: 0x00652CF4 File Offset: 0x00650EF4
		public static Offset<IFlowActionContext> CreateIFlowActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IFlowActionContext.AddType(builder, TypeOffset);
			return IFlowActionContext.EndIFlowActionContext(builder);
		}

		// Token: 0x0602E51F RID: 189727 RVA: 0x00652D0A File Offset: 0x00650F0A
		public static void StartIFlowActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E520 RID: 189728 RVA: 0x00652D13 File Offset: 0x00650F13
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602E521 RID: 189729 RVA: 0x00652D23 File Offset: 0x00650F23
		public static Offset<IFlowActionContext> EndIFlowActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IFlowActionContext>(builder.EndTable());
		}

		// Token: 0x0602E522 RID: 189730 RVA: 0x00652D30 File Offset: 0x00650F30
		public IFlowActionContextT UnPack()
		{
			IFlowActionContextT flowActionContextT = new IFlowActionContextT();
			this.UnPackTo(flowActionContextT);
			return flowActionContextT;
		}

		// Token: 0x0602E523 RID: 189731 RVA: 0x00652D4B File Offset: 0x00650F4B
		public void UnPackTo(IFlowActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E524 RID: 189732 RVA: 0x00652D5C File Offset: 0x00650F5C
		public static Offset<IFlowActionContext> Pack(FlatBufferBuilder builder, IFlowActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IFlowActionContext.CreateIFlowActionContext(builder, typeOffset);
		}

		// Token: 0x04010F07 RID: 69383
		private Table __p;
	}
}
