using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006991 RID: 27025
	public struct IChangeSelfEntityState : IFlatbufferObject
	{
		// Token: 0x1700C6F7 RID: 50935
		// (get) Token: 0x0602E5B2 RID: 189874 RVA: 0x00653EBD File Offset: 0x006520BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E5B3 RID: 189875 RVA: 0x00653ECA File Offset: 0x006520CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E5B4 RID: 189876 RVA: 0x00653ED4 File Offset: 0x006520D4
		public static IChangeSelfEntityState GetRootAsIChangeSelfEntityState(ByteBuffer _bb)
		{
			return IChangeSelfEntityState.GetRootAsIChangeSelfEntityState(_bb, default(IChangeSelfEntityState));
		}

		// Token: 0x0602E5B5 RID: 189877 RVA: 0x00653EF0 File Offset: 0x006520F0
		public static IChangeSelfEntityState GetRootAsIChangeSelfEntityState(ByteBuffer _bb, IChangeSelfEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E5B6 RID: 189878 RVA: 0x00653F0D File Offset: 0x0065210D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5B7 RID: 189879 RVA: 0x00653F1C File Offset: 0x0065211C
		public IChangeSelfEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6F8 RID: 50936
		// (get) Token: 0x0602E5B8 RID: 189880 RVA: 0x00653F2C File Offset: 0x0065212C
		public string EntityState
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

		// Token: 0x0602E5B9 RID: 189881 RVA: 0x00653F63 File Offset: 0x00652163
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E5BA RID: 189882 RVA: 0x00653F72 File Offset: 0x00652172
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602E5BB RID: 189883 RVA: 0x00653F80 File Offset: 0x00652180
		public static Offset<IChangeSelfEntityState> CreateIChangeSelfEntityState(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IChangeSelfEntityState.AddEntityState(builder, EntityStateOffset);
			return IChangeSelfEntityState.EndIChangeSelfEntityState(builder);
		}

		// Token: 0x0602E5BC RID: 189884 RVA: 0x00653F96 File Offset: 0x00652196
		public static void StartIChangeSelfEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E5BD RID: 189885 RVA: 0x00653F9F File Offset: 0x0065219F
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602E5BE RID: 189886 RVA: 0x00653FAF File Offset: 0x006521AF
		public static Offset<IChangeSelfEntityState> EndIChangeSelfEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeSelfEntityState>(builder.EndTable());
		}

		// Token: 0x0602E5BF RID: 189887 RVA: 0x00653FBC File Offset: 0x006521BC
		public IChangeSelfEntityStateT UnPack()
		{
			IChangeSelfEntityStateT changeSelfEntityStateT = new IChangeSelfEntityStateT();
			this.UnPackTo(changeSelfEntityStateT);
			return changeSelfEntityStateT;
		}

		// Token: 0x0602E5C0 RID: 189888 RVA: 0x00653FD7 File Offset: 0x006521D7
		public void UnPackTo(IChangeSelfEntityStateT _o)
		{
			_o.EntityState = this.EntityState;
		}

		// Token: 0x0602E5C1 RID: 189889 RVA: 0x00653FE8 File Offset: 0x006521E8
		public static Offset<IChangeSelfEntityState> Pack(FlatBufferBuilder builder, IChangeSelfEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeSelfEntityState>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			return IChangeSelfEntityState.CreateIChangeSelfEntityState(builder, entityStateOffset);
		}

		// Token: 0x040116F9 RID: 71417
		private Table __p;
	}
}
