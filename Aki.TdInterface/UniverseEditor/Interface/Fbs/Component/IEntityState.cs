using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005715 RID: 22293
	public struct IEntityState : IFlatbufferObject
	{
		// Token: 0x1700A0C5 RID: 41157
		// (get) Token: 0x06023CF5 RID: 146677 RVA: 0x004EC133 File Offset: 0x004EA333
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023CF6 RID: 146678 RVA: 0x004EC140 File Offset: 0x004EA340
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023CF7 RID: 146679 RVA: 0x004EC148 File Offset: 0x004EA348
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb)
		{
			return IEntityState.GetRootAsIEntityState(_bb, default(IEntityState));
		}

		// Token: 0x06023CF8 RID: 146680 RVA: 0x004EC164 File Offset: 0x004EA364
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb, IEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023CF9 RID: 146681 RVA: 0x004EC181 File Offset: 0x004EA381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023CFA RID: 146682 RVA: 0x004EC190 File Offset: 0x004EA390
		public IEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0C6 RID: 41158
		// (get) Token: 0x06023CFB RID: 146683 RVA: 0x004EC1A0 File Offset: 0x004EA3A0
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

		// Token: 0x06023CFC RID: 146684 RVA: 0x004EC1D7 File Offset: 0x004EA3D7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023CFD RID: 146685 RVA: 0x004EC1E6 File Offset: 0x004EA3E6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A0C7 RID: 41159
		// (get) Token: 0x06023CFE RID: 146686 RVA: 0x004EC1F4 File Offset: 0x004EA3F4
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

		// Token: 0x06023CFF RID: 146687 RVA: 0x004EC22B File Offset: 0x004EA42B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023D00 RID: 146688 RVA: 0x004EC23A File Offset: 0x004EA43A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023D01 RID: 146689 RVA: 0x004EC248 File Offset: 0x004EA448
		public static Offset<IEntityState> CreateIEntityState(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityState.AddState(builder, StateOffset);
			IEntityState.AddType(builder, TypeOffset);
			return IEntityState.EndIEntityState(builder);
		}

		// Token: 0x06023D02 RID: 146690 RVA: 0x004EC265 File Offset: 0x004EA465
		public static void StartIEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023D03 RID: 146691 RVA: 0x004EC26E File Offset: 0x004EA46E
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06023D04 RID: 146692 RVA: 0x004EC27E File Offset: 0x004EA47E
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06023D05 RID: 146693 RVA: 0x004EC28E File Offset: 0x004EA48E
		public static Offset<IEntityState> EndIEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityState>(builder.EndTable());
		}

		// Token: 0x06023D06 RID: 146694 RVA: 0x004EC29C File Offset: 0x004EA49C
		public IEntityStateT UnPack()
		{
			IEntityStateT entityStateT = new IEntityStateT();
			this.UnPackTo(entityStateT);
			return entityStateT;
		}

		// Token: 0x06023D07 RID: 146695 RVA: 0x004EC2B7 File Offset: 0x004EA4B7
		public void UnPackTo(IEntityStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06023D08 RID: 146696 RVA: 0x004EC2D4 File Offset: 0x004EA4D4
		public static Offset<IEntityState> Pack(FlatBufferBuilder builder, IEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityState>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IEntityState.CreateIEntityState(builder, typeOffset, stateOffset);
		}

		// Token: 0x0400EE94 RID: 61076
		private Table __p;
	}
}
