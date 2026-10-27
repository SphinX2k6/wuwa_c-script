using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C6 RID: 25286
	public struct IChangeActorState : IFlatbufferObject
	{
		// Token: 0x1700BCC2 RID: 48322
		// (get) Token: 0x0602BB39 RID: 179001 RVA: 0x00603B35 File Offset: 0x00601D35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB3A RID: 179002 RVA: 0x00603B42 File Offset: 0x00601D42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB3B RID: 179003 RVA: 0x00603B4C File Offset: 0x00601D4C
		public static IChangeActorState GetRootAsIChangeActorState(ByteBuffer _bb)
		{
			return IChangeActorState.GetRootAsIChangeActorState(_bb, default(IChangeActorState));
		}

		// Token: 0x0602BB3C RID: 179004 RVA: 0x00603B68 File Offset: 0x00601D68
		public static IChangeActorState GetRootAsIChangeActorState(ByteBuffer _bb, IChangeActorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB3D RID: 179005 RVA: 0x00603B85 File Offset: 0x00601D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB3E RID: 179006 RVA: 0x00603B94 File Offset: 0x00601D94
		public IChangeActorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCC3 RID: 48323
		// (get) Token: 0x0602BB3F RID: 179007 RVA: 0x00603BA4 File Offset: 0x00601DA4
		public string State
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

		// Token: 0x0602BB40 RID: 179008 RVA: 0x00603BDB File Offset: 0x00601DDB
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602BB41 RID: 179009 RVA: 0x00603BEA File Offset: 0x00601DEA
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602BB42 RID: 179010 RVA: 0x00603BF8 File Offset: 0x00601DF8
		public static Offset<IChangeActorState> CreateIChangeActorState(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IChangeActorState.AddState(builder, StateOffset);
			return IChangeActorState.EndIChangeActorState(builder);
		}

		// Token: 0x0602BB43 RID: 179011 RVA: 0x00603C0E File Offset: 0x00601E0E
		public static void StartIChangeActorState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BB44 RID: 179012 RVA: 0x00603C17 File Offset: 0x00601E17
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0602BB45 RID: 179013 RVA: 0x00603C27 File Offset: 0x00601E27
		public static Offset<IChangeActorState> EndIChangeActorState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorState>(builder.EndTable());
		}

		// Token: 0x0602BB46 RID: 179014 RVA: 0x00603C34 File Offset: 0x00601E34
		public IChangeActorStateT UnPack()
		{
			IChangeActorStateT changeActorStateT = new IChangeActorStateT();
			this.UnPackTo(changeActorStateT);
			return changeActorStateT;
		}

		// Token: 0x0602BB47 RID: 179015 RVA: 0x00603C4F File Offset: 0x00601E4F
		public void UnPackTo(IChangeActorStateT _o)
		{
			_o.State = this.State;
		}

		// Token: 0x0602BB48 RID: 179016 RVA: 0x00603C60 File Offset: 0x00601E60
		public static Offset<IChangeActorState> Pack(FlatBufferBuilder builder, IChangeActorStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeActorState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeActorState.CreateIChangeActorState(builder, stateOffset);
		}

		// Token: 0x0401086D RID: 67693
		private Table __p;
	}
}
