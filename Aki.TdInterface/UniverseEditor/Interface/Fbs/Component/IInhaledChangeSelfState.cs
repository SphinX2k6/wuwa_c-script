using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598D RID: 22925
	public struct IInhaledChangeSelfState : IFlatbufferObject
	{
		// Token: 0x1700A67E RID: 42622
		// (get) Token: 0x060255EF RID: 153071 RVA: 0x00520E20 File Offset: 0x0051F020
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060255F0 RID: 153072 RVA: 0x00520E2D File Offset: 0x0051F02D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060255F1 RID: 153073 RVA: 0x00520E34 File Offset: 0x0051F034
		public static IInhaledChangeSelfState GetRootAsIInhaledChangeSelfState(ByteBuffer _bb)
		{
			return IInhaledChangeSelfState.GetRootAsIInhaledChangeSelfState(_bb, default(IInhaledChangeSelfState));
		}

		// Token: 0x060255F2 RID: 153074 RVA: 0x00520E50 File Offset: 0x0051F050
		public static IInhaledChangeSelfState GetRootAsIInhaledChangeSelfState(ByteBuffer _bb, IInhaledChangeSelfState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060255F3 RID: 153075 RVA: 0x00520E6D File Offset: 0x0051F06D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060255F4 RID: 153076 RVA: 0x00520E7C File Offset: 0x0051F07C
		public IInhaledChangeSelfState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A67F RID: 42623
		// (get) Token: 0x060255F5 RID: 153077 RVA: 0x00520E8C File Offset: 0x0051F08C
		public EInhaledPerResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return (EInhaledPerResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A680 RID: 42624
		// (get) Token: 0x060255F6 RID: 153078 RVA: 0x00520EC8 File Offset: 0x0051F0C8
		public string ChangeSelfState
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

		// Token: 0x060255F7 RID: 153079 RVA: 0x00520EFF File Offset: 0x0051F0FF
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060255F8 RID: 153080 RVA: 0x00520F0E File Offset: 0x0051F10E
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060255F9 RID: 153081 RVA: 0x00520F1C File Offset: 0x0051F11C
		public static Offset<IInhaledChangeSelfState> CreateIInhaledChangeSelfState(FlatBufferBuilder builder, EInhaledPerResultType Type = EInhaledPerResultType.DestroySelf, StringOffset ChangeSelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInhaledChangeSelfState.AddChangeSelfState(builder, ChangeSelfStateOffset);
			IInhaledChangeSelfState.AddType(builder, Type);
			return IInhaledChangeSelfState.EndIInhaledChangeSelfState(builder);
		}

		// Token: 0x060255FA RID: 153082 RVA: 0x00520F39 File Offset: 0x0051F139
		public static void StartIInhaledChangeSelfState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060255FB RID: 153083 RVA: 0x00520F42 File Offset: 0x0051F142
		public static void AddType(FlatBufferBuilder builder, EInhaledPerResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060255FC RID: 153084 RVA: 0x00520F4D File Offset: 0x0051F14D
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(1, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x060255FD RID: 153085 RVA: 0x00520F5D File Offset: 0x0051F15D
		public static Offset<IInhaledChangeSelfState> EndIInhaledChangeSelfState(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledChangeSelfState>(builder.EndTable());
		}

		// Token: 0x060255FE RID: 153086 RVA: 0x00520F6C File Offset: 0x0051F16C
		public IInhaledChangeSelfStateT UnPack()
		{
			IInhaledChangeSelfStateT inhaledChangeSelfStateT = new IInhaledChangeSelfStateT();
			this.UnPackTo(inhaledChangeSelfStateT);
			return inhaledChangeSelfStateT;
		}

		// Token: 0x060255FF RID: 153087 RVA: 0x00520F87 File Offset: 0x0051F187
		public void UnPackTo(IInhaledChangeSelfStateT _o)
		{
			_o.Type = this.Type;
			_o.ChangeSelfState = this.ChangeSelfState;
		}

		// Token: 0x06025600 RID: 153088 RVA: 0x00520FA4 File Offset: 0x0051F1A4
		public static Offset<IInhaledChangeSelfState> Pack(FlatBufferBuilder builder, IInhaledChangeSelfStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledChangeSelfState>);
			}
			StringOffset changeSelfStateOffset = (_o.ChangeSelfState == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfState);
			return IInhaledChangeSelfState.CreateIInhaledChangeSelfState(builder, _o.Type, changeSelfStateOffset);
		}

		// Token: 0x0400F27F RID: 62079
		private Table __p;
	}
}
