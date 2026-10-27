using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200645C RID: 25692
	public struct ICommonBtActionContext : IFlatbufferObject
	{
		// Token: 0x1700BF35 RID: 48949
		// (get) Token: 0x0602C758 RID: 182104 RVA: 0x00618F9E File Offset: 0x0061719E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C759 RID: 182105 RVA: 0x00618FAB File Offset: 0x006171AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C75A RID: 182106 RVA: 0x00618FB4 File Offset: 0x006171B4
		public static ICommonBtActionContext GetRootAsICommonBtActionContext(ByteBuffer _bb)
		{
			return ICommonBtActionContext.GetRootAsICommonBtActionContext(_bb, default(ICommonBtActionContext));
		}

		// Token: 0x0602C75B RID: 182107 RVA: 0x00618FD0 File Offset: 0x006171D0
		public static ICommonBtActionContext GetRootAsICommonBtActionContext(ByteBuffer _bb, ICommonBtActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C75C RID: 182108 RVA: 0x00618FED File Offset: 0x006171ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C75D RID: 182109 RVA: 0x00618FFC File Offset: 0x006171FC
		public ICommonBtActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF36 RID: 48950
		// (get) Token: 0x0602C75E RID: 182110 RVA: 0x0061900C File Offset: 0x0061720C
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

		// Token: 0x0602C75F RID: 182111 RVA: 0x00619043 File Offset: 0x00617243
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602C760 RID: 182112 RVA: 0x00619052 File Offset: 0x00617252
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602C761 RID: 182113 RVA: 0x00619060 File Offset: 0x00617260
		public static Offset<ICommonBtActionContext> CreateICommonBtActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ICommonBtActionContext.AddType(builder, TypeOffset);
			return ICommonBtActionContext.EndICommonBtActionContext(builder);
		}

		// Token: 0x0602C762 RID: 182114 RVA: 0x00619076 File Offset: 0x00617276
		public static void StartICommonBtActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C763 RID: 182115 RVA: 0x0061907F File Offset: 0x0061727F
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602C764 RID: 182116 RVA: 0x0061908F File Offset: 0x0061728F
		public static Offset<ICommonBtActionContext> EndICommonBtActionContext(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtActionContext>(builder.EndTable());
		}

		// Token: 0x0602C765 RID: 182117 RVA: 0x0061909C File Offset: 0x0061729C
		public ICommonBtActionContextT UnPack()
		{
			ICommonBtActionContextT commonBtActionContextT = new ICommonBtActionContextT();
			this.UnPackTo(commonBtActionContextT);
			return commonBtActionContextT;
		}

		// Token: 0x0602C766 RID: 182118 RVA: 0x006190B7 File Offset: 0x006172B7
		public void UnPackTo(ICommonBtActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C767 RID: 182119 RVA: 0x006190C8 File Offset: 0x006172C8
		public static Offset<ICommonBtActionContext> Pack(FlatBufferBuilder builder, ICommonBtActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return ICommonBtActionContext.CreateICommonBtActionContext(builder, typeOffset);
		}

		// Token: 0x04010A5A RID: 68186
		private Table __p;
	}
}
