using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006443 RID: 25667
	public struct IInitNpcPerformState : IFlatbufferObject
	{
		// Token: 0x1700BD7C RID: 48508
		// (get) Token: 0x0602B9BC RID: 178620 RVA: 0x005EFB76 File Offset: 0x005EDD76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B9BD RID: 178621 RVA: 0x005EFB83 File Offset: 0x005EDD83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B9BE RID: 178622 RVA: 0x005EFB8C File Offset: 0x005EDD8C
		public static IInitNpcPerformState GetRootAsIInitNpcPerformState(ByteBuffer _bb)
		{
			return IInitNpcPerformState.GetRootAsIInitNpcPerformState(_bb, default(IInitNpcPerformState));
		}

		// Token: 0x0602B9BF RID: 178623 RVA: 0x005EFBA8 File Offset: 0x005EDDA8
		public static IInitNpcPerformState GetRootAsIInitNpcPerformState(ByteBuffer _bb, IInitNpcPerformState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B9C0 RID: 178624 RVA: 0x005EFBC5 File Offset: 0x005EDDC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B9C1 RID: 178625 RVA: 0x005EFBD4 File Offset: 0x005EDDD4
		public IInitNpcPerformState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD7D RID: 48509
		// (get) Token: 0x0602B9C2 RID: 178626 RVA: 0x005EFBE4 File Offset: 0x005EDDE4
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

		// Token: 0x0602B9C3 RID: 178627 RVA: 0x005EFC1B File Offset: 0x005EDE1B
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602B9C4 RID: 178628 RVA: 0x005EFC2A File Offset: 0x005EDE2A
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BD7E RID: 48510
		// (get) Token: 0x0602B9C5 RID: 178629 RVA: 0x005EFC38 File Offset: 0x005EDE38
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

		// Token: 0x0602B9C6 RID: 178630 RVA: 0x005EFC6F File Offset: 0x005EDE6F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B9C7 RID: 178631 RVA: 0x005EFC7E File Offset: 0x005EDE7E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602B9C8 RID: 178632 RVA: 0x005EFC8C File Offset: 0x005EDE8C
		public static Offset<IInitNpcPerformState> CreateIInitNpcPerformState(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInitNpcPerformState.AddState(builder, StateOffset);
			IInitNpcPerformState.AddType(builder, TypeOffset);
			return IInitNpcPerformState.EndIInitNpcPerformState(builder);
		}

		// Token: 0x0602B9C9 RID: 178633 RVA: 0x005EFCA9 File Offset: 0x005EDEA9
		public static void StartIInitNpcPerformState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B9CA RID: 178634 RVA: 0x005EFCB2 File Offset: 0x005EDEB2
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602B9CB RID: 178635 RVA: 0x005EFCC2 File Offset: 0x005EDEC2
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602B9CC RID: 178636 RVA: 0x005EFCD2 File Offset: 0x005EDED2
		public static Offset<IInitNpcPerformState> EndIInitNpcPerformState(FlatBufferBuilder builder)
		{
			return new Offset<IInitNpcPerformState>(builder.EndTable());
		}

		// Token: 0x0602B9CD RID: 178637 RVA: 0x005EFCE0 File Offset: 0x005EDEE0
		public IInitNpcPerformStateT UnPack()
		{
			IInitNpcPerformStateT initNpcPerformStateT = new IInitNpcPerformStateT();
			this.UnPackTo(initNpcPerformStateT);
			return initNpcPerformStateT;
		}

		// Token: 0x0602B9CE RID: 178638 RVA: 0x005EFCFB File Offset: 0x005EDEFB
		public void UnPackTo(IInitNpcPerformStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x0602B9CF RID: 178639 RVA: 0x005EFD18 File Offset: 0x005EDF18
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

		// Token: 0x04010553 RID: 66899
		private Table __p;
	}
}
