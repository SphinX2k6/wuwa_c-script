using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6C RID: 28268
	public struct IFlowActionContext : IFlatbufferObject
	{
		// Token: 0x1700CF2B RID: 53035
		// (get) Token: 0x06030D5B RID: 200027 RVA: 0x006A0377 File Offset: 0x0069E577
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D5C RID: 200028 RVA: 0x006A0384 File Offset: 0x0069E584
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D5D RID: 200029 RVA: 0x006A038C File Offset: 0x0069E58C
		public static IFlowActionContext GetRootAsIFlowActionContext(ByteBuffer _bb)
		{
			return IFlowActionContext.GetRootAsIFlowActionContext(_bb, default(IFlowActionContext));
		}

		// Token: 0x06030D5E RID: 200030 RVA: 0x006A03A8 File Offset: 0x0069E5A8
		public static IFlowActionContext GetRootAsIFlowActionContext(ByteBuffer _bb, IFlowActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D5F RID: 200031 RVA: 0x006A03C5 File Offset: 0x0069E5C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D60 RID: 200032 RVA: 0x006A03D4 File Offset: 0x0069E5D4
		public IFlowActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF2C RID: 53036
		// (get) Token: 0x06030D61 RID: 200033 RVA: 0x006A03E4 File Offset: 0x0069E5E4
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

		// Token: 0x06030D62 RID: 200034 RVA: 0x006A041B File Offset: 0x0069E61B
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030D63 RID: 200035 RVA: 0x006A042A File Offset: 0x0069E62A
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06030D64 RID: 200036 RVA: 0x006A0438 File Offset: 0x0069E638
		public static Offset<IFlowActionContext> CreateIFlowActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IFlowActionContext.AddType(builder, TypeOffset);
			return IFlowActionContext.EndIFlowActionContext(builder);
		}

		// Token: 0x06030D65 RID: 200037 RVA: 0x006A044E File Offset: 0x0069E64E
		public static void StartIFlowActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030D66 RID: 200038 RVA: 0x006A0457 File Offset: 0x0069E657
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06030D67 RID: 200039 RVA: 0x006A0467 File Offset: 0x0069E667
		public static Offset<IFlowActionContext> EndIFlowActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IFlowActionContext>(builder.EndTable());
		}

		// Token: 0x06030D68 RID: 200040 RVA: 0x006A0474 File Offset: 0x0069E674
		public IFlowActionContextT UnPack()
		{
			IFlowActionContextT flowActionContextT = new IFlowActionContextT();
			this.UnPackTo(flowActionContextT);
			return flowActionContextT;
		}

		// Token: 0x06030D69 RID: 200041 RVA: 0x006A048F File Offset: 0x0069E68F
		public void UnPackTo(IFlowActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030D6A RID: 200042 RVA: 0x006A04A0 File Offset: 0x0069E6A0
		public static Offset<IFlowActionContext> Pack(FlatBufferBuilder builder, IFlowActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IFlowActionContext.CreateIFlowActionContext(builder, typeOffset);
		}

		// Token: 0x04011D39 RID: 73017
		private Table __p;
	}
}
