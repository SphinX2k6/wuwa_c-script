using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E06 RID: 24070
	public struct IInitNpcPerformState : IFlatbufferObject
	{
		// Token: 0x1700B416 RID: 46102
		// (get) Token: 0x06029332 RID: 168754 RVA: 0x005A6E46 File Offset: 0x005A5046
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029333 RID: 168755 RVA: 0x005A6E53 File Offset: 0x005A5053
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029334 RID: 168756 RVA: 0x005A6E5C File Offset: 0x005A505C
		public static IInitNpcPerformState GetRootAsIInitNpcPerformState(ByteBuffer _bb)
		{
			return IInitNpcPerformState.GetRootAsIInitNpcPerformState(_bb, default(IInitNpcPerformState));
		}

		// Token: 0x06029335 RID: 168757 RVA: 0x005A6E78 File Offset: 0x005A5078
		public static IInitNpcPerformState GetRootAsIInitNpcPerformState(ByteBuffer _bb, IInitNpcPerformState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029336 RID: 168758 RVA: 0x005A6E95 File Offset: 0x005A5095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029337 RID: 168759 RVA: 0x005A6EA4 File Offset: 0x005A50A4
		public IInitNpcPerformState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B417 RID: 46103
		// (get) Token: 0x06029338 RID: 168760 RVA: 0x005A6EB4 File Offset: 0x005A50B4
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

		// Token: 0x06029339 RID: 168761 RVA: 0x005A6EEB File Offset: 0x005A50EB
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602933A RID: 168762 RVA: 0x005A6EFA File Offset: 0x005A50FA
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B418 RID: 46104
		// (get) Token: 0x0602933B RID: 168763 RVA: 0x005A6F08 File Offset: 0x005A5108
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602933C RID: 168764 RVA: 0x005A6F3F File Offset: 0x005A513F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602933D RID: 168765 RVA: 0x005A6F4E File Offset: 0x005A514E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602933E RID: 168766 RVA: 0x005A6F5C File Offset: 0x005A515C
		public static Offset<IInitNpcPerformState> CreateIInitNpcPerformState(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInitNpcPerformState.AddState(builder, StateOffset);
			IInitNpcPerformState.AddType(builder, TypeOffset);
			return IInitNpcPerformState.EndIInitNpcPerformState(builder);
		}

		// Token: 0x0602933F RID: 168767 RVA: 0x005A6F79 File Offset: 0x005A5179
		public static void StartIInitNpcPerformState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029340 RID: 168768 RVA: 0x005A6F82 File Offset: 0x005A5182
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06029341 RID: 168769 RVA: 0x005A6F92 File Offset: 0x005A5192
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06029342 RID: 168770 RVA: 0x005A6FA2 File Offset: 0x005A51A2
		public static Offset<IInitNpcPerformState> EndIInitNpcPerformState(FlatBufferBuilder builder)
		{
			return new Offset<IInitNpcPerformState>(builder.EndTable());
		}

		// Token: 0x06029343 RID: 168771 RVA: 0x005A6FB0 File Offset: 0x005A51B0
		public IInitNpcPerformStateT UnPack()
		{
			IInitNpcPerformStateT initNpcPerformStateT = new IInitNpcPerformStateT();
			this.UnPackTo(initNpcPerformStateT);
			return initNpcPerformStateT;
		}

		// Token: 0x06029344 RID: 168772 RVA: 0x005A6FCB File Offset: 0x005A51CB
		public void UnPackTo(IInitNpcPerformStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06029345 RID: 168773 RVA: 0x005A6FE8 File Offset: 0x005A51E8
		public static Offset<IInitNpcPerformState> Pack(FlatBufferBuilder builder, IInitNpcPerformStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitNpcPerformState>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IInitNpcPerformState.CreateIInitNpcPerformState(builder, typeOffset, stateOffset);
		}

		// Token: 0x0400F7F8 RID: 63480
		private Table __p;
	}
}
