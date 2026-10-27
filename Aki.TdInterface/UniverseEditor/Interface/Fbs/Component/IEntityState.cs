using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B0 RID: 20912
	public struct IEntityState : IFlatbufferObject
	{
		// Token: 0x170098D6 RID: 39126
		// (get) Token: 0x06021D9D RID: 138653 RVA: 0x004B20CB File Offset: 0x004B02CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D9E RID: 138654 RVA: 0x004B20D8 File Offset: 0x004B02D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D9F RID: 138655 RVA: 0x004B20E0 File Offset: 0x004B02E0
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb)
		{
			return IEntityState.GetRootAsIEntityState(_bb, default(IEntityState));
		}

		// Token: 0x06021DA0 RID: 138656 RVA: 0x004B20FC File Offset: 0x004B02FC
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb, IEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021DA1 RID: 138657 RVA: 0x004B2119 File Offset: 0x004B0319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021DA2 RID: 138658 RVA: 0x004B2128 File Offset: 0x004B0328
		public IEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098D7 RID: 39127
		// (get) Token: 0x06021DA3 RID: 138659 RVA: 0x004B2138 File Offset: 0x004B0338
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

		// Token: 0x06021DA4 RID: 138660 RVA: 0x004B216F File Offset: 0x004B036F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021DA5 RID: 138661 RVA: 0x004B217E File Offset: 0x004B037E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170098D8 RID: 39128
		// (get) Token: 0x06021DA6 RID: 138662 RVA: 0x004B218C File Offset: 0x004B038C
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

		// Token: 0x06021DA7 RID: 138663 RVA: 0x004B21C3 File Offset: 0x004B03C3
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021DA8 RID: 138664 RVA: 0x004B21D2 File Offset: 0x004B03D2
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06021DA9 RID: 138665 RVA: 0x004B21E0 File Offset: 0x004B03E0
		public static Offset<IEntityState> CreateIEntityState(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityState.AddState(builder, StateOffset);
			IEntityState.AddType(builder, TypeOffset);
			return IEntityState.EndIEntityState(builder);
		}

		// Token: 0x06021DAA RID: 138666 RVA: 0x004B21FD File Offset: 0x004B03FD
		public static void StartIEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021DAB RID: 138667 RVA: 0x004B2206 File Offset: 0x004B0406
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06021DAC RID: 138668 RVA: 0x004B2216 File Offset: 0x004B0416
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06021DAD RID: 138669 RVA: 0x004B2226 File Offset: 0x004B0426
		public static Offset<IEntityState> EndIEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityState>(builder.EndTable());
		}

		// Token: 0x06021DAE RID: 138670 RVA: 0x004B2234 File Offset: 0x004B0434
		public IEntityStateT UnPack()
		{
			IEntityStateT entityStateT = new IEntityStateT();
			this.UnPackTo(entityStateT);
			return entityStateT;
		}

		// Token: 0x06021DAF RID: 138671 RVA: 0x004B224F File Offset: 0x004B044F
		public void UnPackTo(IEntityStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06021DB0 RID: 138672 RVA: 0x004B226C File Offset: 0x004B046C
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

		// Token: 0x0400E296 RID: 58006
		private Table __p;
	}
}
