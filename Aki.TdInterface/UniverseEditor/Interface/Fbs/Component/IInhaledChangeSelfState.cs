using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005407 RID: 21511
	public struct IInhaledChangeSelfState : IFlatbufferObject
	{
		// Token: 0x17009E44 RID: 40516
		// (get) Token: 0x06023537 RID: 144695 RVA: 0x004E3DF4 File Offset: 0x004E1FF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023538 RID: 144696 RVA: 0x004E3E01 File Offset: 0x004E2001
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023539 RID: 144697 RVA: 0x004E3E08 File Offset: 0x004E2008
		public static IInhaledChangeSelfState GetRootAsIInhaledChangeSelfState(ByteBuffer _bb)
		{
			return IInhaledChangeSelfState.GetRootAsIInhaledChangeSelfState(_bb, default(IInhaledChangeSelfState));
		}

		// Token: 0x0602353A RID: 144698 RVA: 0x004E3E24 File Offset: 0x004E2024
		public static IInhaledChangeSelfState GetRootAsIInhaledChangeSelfState(ByteBuffer _bb, IInhaledChangeSelfState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602353B RID: 144699 RVA: 0x004E3E41 File Offset: 0x004E2041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602353C RID: 144700 RVA: 0x004E3E50 File Offset: 0x004E2050
		public IInhaledChangeSelfState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E45 RID: 40517
		// (get) Token: 0x0602353D RID: 144701 RVA: 0x004E3E60 File Offset: 0x004E2060
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

		// Token: 0x17009E46 RID: 40518
		// (get) Token: 0x0602353E RID: 144702 RVA: 0x004E3E9C File Offset: 0x004E209C
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

		// Token: 0x0602353F RID: 144703 RVA: 0x004E3ED3 File Offset: 0x004E20D3
		public Span<byte> GetChangeSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023540 RID: 144704 RVA: 0x004E3EE2 File Offset: 0x004E20E2
		public byte[] GetChangeSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023541 RID: 144705 RVA: 0x004E3EF0 File Offset: 0x004E20F0
		public static Offset<IInhaledChangeSelfState> CreateIInhaledChangeSelfState(FlatBufferBuilder builder, EInhaledPerResultType Type = EInhaledPerResultType.DestroySelf, StringOffset ChangeSelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInhaledChangeSelfState.AddChangeSelfState(builder, ChangeSelfStateOffset);
			IInhaledChangeSelfState.AddType(builder, Type);
			return IInhaledChangeSelfState.EndIInhaledChangeSelfState(builder);
		}

		// Token: 0x06023542 RID: 144706 RVA: 0x004E3F0D File Offset: 0x004E210D
		public static void StartIInhaledChangeSelfState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023543 RID: 144707 RVA: 0x004E3F16 File Offset: 0x004E2116
		public static void AddType(FlatBufferBuilder builder, EInhaledPerResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023544 RID: 144708 RVA: 0x004E3F21 File Offset: 0x004E2121
		public static void AddChangeSelfState(FlatBufferBuilder builder, StringOffset changeSelfStateOffset)
		{
			builder.AddOffset(1, changeSelfStateOffset.Value, 0);
		}

		// Token: 0x06023545 RID: 144709 RVA: 0x004E3F31 File Offset: 0x004E2131
		public static Offset<IInhaledChangeSelfState> EndIInhaledChangeSelfState(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledChangeSelfState>(builder.EndTable());
		}

		// Token: 0x06023546 RID: 144710 RVA: 0x004E3F40 File Offset: 0x004E2140
		public IInhaledChangeSelfStateT UnPack()
		{
			IInhaledChangeSelfStateT inhaledChangeSelfStateT = new IInhaledChangeSelfStateT();
			this.UnPackTo(inhaledChangeSelfStateT);
			return inhaledChangeSelfStateT;
		}

		// Token: 0x06023547 RID: 144711 RVA: 0x004E3F5B File Offset: 0x004E215B
		public void UnPackTo(IInhaledChangeSelfStateT _o)
		{
			_o.Type = this.Type;
			_o.ChangeSelfState = this.ChangeSelfState;
		}

		// Token: 0x06023548 RID: 144712 RVA: 0x004E3F78 File Offset: 0x004E2178
		public static Offset<IInhaledChangeSelfState> Pack(FlatBufferBuilder builder, IInhaledChangeSelfStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledChangeSelfState>);
			}
			StringOffset changeSelfStateOffset = (_o.ChangeSelfState == null) ? default(StringOffset) : builder.CreateString(_o.ChangeSelfState);
			return IInhaledChangeSelfState.CreateIInhaledChangeSelfState(builder, _o.Type, changeSelfStateOffset);
		}

		// Token: 0x0400E64E RID: 58958
		private Table __p;
	}
}
