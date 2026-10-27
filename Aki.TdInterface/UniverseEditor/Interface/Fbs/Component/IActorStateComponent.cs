using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E56 RID: 20054
	public struct IActorStateComponent : IFlatbufferObject
	{
		// Token: 0x17008F86 RID: 36742
		// (get) Token: 0x0601F7B2 RID: 128946 RVA: 0x00462B84 File Offset: 0x00460D84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F7B3 RID: 128947 RVA: 0x00462B91 File Offset: 0x00460D91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F7B4 RID: 128948 RVA: 0x00462B98 File Offset: 0x00460D98
		public static IActorStateComponent GetRootAsIActorStateComponent(ByteBuffer _bb)
		{
			return IActorStateComponent.GetRootAsIActorStateComponent(_bb, default(IActorStateComponent));
		}

		// Token: 0x0601F7B5 RID: 128949 RVA: 0x00462BB4 File Offset: 0x00460DB4
		public static IActorStateComponent GetRootAsIActorStateComponent(ByteBuffer _bb, IActorStateComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7B6 RID: 128950 RVA: 0x00462BD1 File Offset: 0x00460DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7B7 RID: 128951 RVA: 0x00462BE0 File Offset: 0x00460DE0
		public IActorStateComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F87 RID: 36743
		// (get) Token: 0x0601F7B8 RID: 128952 RVA: 0x00462BF0 File Offset: 0x00460DF0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008F88 RID: 36744
		// (get) Token: 0x0601F7B9 RID: 128953 RVA: 0x00462C30 File Offset: 0x00460E30
		public string InitState
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

		// Token: 0x0601F7BA RID: 128954 RVA: 0x00462C67 File Offset: 0x00460E67
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601F7BB RID: 128955 RVA: 0x00462C76 File Offset: 0x00460E76
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008F89 RID: 36745
		// (get) Token: 0x0601F7BC RID: 128956 RVA: 0x00462C84 File Offset: 0x00460E84
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F7BD RID: 128957 RVA: 0x00462CC0 File Offset: 0x00460EC0
		public static Offset<IActorStateComponent> CreateIActorStateComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset InitStateOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorStateComponent.AddInitState(builder, InitStateOffset);
			IActorStateComponent.AddNullMask(builder, NullMask);
			IActorStateComponent.AddDisabled(builder, Disabled);
			return IActorStateComponent.EndIActorStateComponent(builder);
		}

		// Token: 0x0601F7BE RID: 128958 RVA: 0x00462CE4 File Offset: 0x00460EE4
		public static void StartIActorStateComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F7BF RID: 128959 RVA: 0x00462CED File Offset: 0x00460EED
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601F7C0 RID: 128960 RVA: 0x00462CF8 File Offset: 0x00460EF8
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(1, initStateOffset.Value, 0);
		}

		// Token: 0x0601F7C1 RID: 128961 RVA: 0x00462D08 File Offset: 0x00460F08
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601F7C2 RID: 128962 RVA: 0x00462D13 File Offset: 0x00460F13
		public static Offset<IActorStateComponent> EndIActorStateComponent(FlatBufferBuilder builder)
		{
			return new Offset<IActorStateComponent>(builder.EndTable());
		}

		// Token: 0x0601F7C3 RID: 128963 RVA: 0x00462D20 File Offset: 0x00460F20
		public IActorStateComponentT UnPack()
		{
			IActorStateComponentT actorStateComponentT = new IActorStateComponentT();
			this.UnPackTo(actorStateComponentT);
			return actorStateComponentT;
		}

		// Token: 0x0601F7C4 RID: 128964 RVA: 0x00462D3B File Offset: 0x00460F3B
		public void UnPackTo(IActorStateComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InitState = this.InitState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F7C5 RID: 128965 RVA: 0x00462D64 File Offset: 0x00460F64
		public static Offset<IActorStateComponent> Pack(FlatBufferBuilder builder, IActorStateComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorStateComponent>);
			}
			StringOffset initStateOffset = (_o.InitState == null) ? default(StringOffset) : builder.CreateString(_o.InitState);
			return IActorStateComponent.CreateIActorStateComponent(builder, _o.Disabled, initStateOffset, _o.NullMask);
		}

		// Token: 0x0400DBF3 RID: 56307
		private Table __p;
	}
}
