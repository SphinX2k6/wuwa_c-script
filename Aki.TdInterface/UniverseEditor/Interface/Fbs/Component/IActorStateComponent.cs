using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005367 RID: 21351
	public struct IActorStateComponent : IFlatbufferObject
	{
		// Token: 0x170096BF RID: 38591
		// (get) Token: 0x060213FD RID: 136189 RVA: 0x00496B9C File Offset: 0x00494D9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060213FE RID: 136190 RVA: 0x00496BA9 File Offset: 0x00494DA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060213FF RID: 136191 RVA: 0x00496BB0 File Offset: 0x00494DB0
		public static IActorStateComponent GetRootAsIActorStateComponent(ByteBuffer _bb)
		{
			return IActorStateComponent.GetRootAsIActorStateComponent(_bb, default(IActorStateComponent));
		}

		// Token: 0x06021400 RID: 136192 RVA: 0x00496BCC File Offset: 0x00494DCC
		public static IActorStateComponent GetRootAsIActorStateComponent(ByteBuffer _bb, IActorStateComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021401 RID: 136193 RVA: 0x00496BE9 File Offset: 0x00494DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021402 RID: 136194 RVA: 0x00496BF8 File Offset: 0x00494DF8
		public IActorStateComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096C0 RID: 38592
		// (get) Token: 0x06021403 RID: 136195 RVA: 0x00496C08 File Offset: 0x00494E08
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170096C1 RID: 38593
		// (get) Token: 0x06021404 RID: 136196 RVA: 0x00496C48 File Offset: 0x00494E48
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

		// Token: 0x06021405 RID: 136197 RVA: 0x00496C7F File Offset: 0x00494E7F
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021406 RID: 136198 RVA: 0x00496C8E File Offset: 0x00494E8E
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170096C2 RID: 38594
		// (get) Token: 0x06021407 RID: 136199 RVA: 0x00496C9C File Offset: 0x00494E9C
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

		// Token: 0x06021408 RID: 136200 RVA: 0x00496CD8 File Offset: 0x00494ED8
		public static Offset<IActorStateComponent> CreateIActorStateComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset InitStateOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorStateComponent.AddInitState(builder, InitStateOffset);
			IActorStateComponent.AddNullMask(builder, NullMask);
			IActorStateComponent.AddDisabled(builder, Disabled);
			return IActorStateComponent.EndIActorStateComponent(builder);
		}

		// Token: 0x06021409 RID: 136201 RVA: 0x00496CFC File Offset: 0x00494EFC
		public static void StartIActorStateComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602140A RID: 136202 RVA: 0x00496D05 File Offset: 0x00494F05
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602140B RID: 136203 RVA: 0x00496D10 File Offset: 0x00494F10
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(1, initStateOffset.Value, 0);
		}

		// Token: 0x0602140C RID: 136204 RVA: 0x00496D20 File Offset: 0x00494F20
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602140D RID: 136205 RVA: 0x00496D2B File Offset: 0x00494F2B
		public static Offset<IActorStateComponent> EndIActorStateComponent(FlatBufferBuilder builder)
		{
			return new Offset<IActorStateComponent>(builder.EndTable());
		}

		// Token: 0x0602140E RID: 136206 RVA: 0x00496D38 File Offset: 0x00494F38
		public IActorStateComponentT UnPack()
		{
			IActorStateComponentT actorStateComponentT = new IActorStateComponentT();
			this.UnPackTo(actorStateComponentT);
			return actorStateComponentT;
		}

		// Token: 0x0602140F RID: 136207 RVA: 0x00496D53 File Offset: 0x00494F53
		public void UnPackTo(IActorStateComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InitState = this.InitState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021410 RID: 136208 RVA: 0x00496D7C File Offset: 0x00494F7C
		public static Offset<IActorStateComponent> Pack(FlatBufferBuilder builder, IActorStateComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorStateComponent>);
			}
			StringOffset initStateOffset = (_o.InitState == null) ? default(StringOffset) : builder.CreateString(_o.InitState);
			return IActorStateComponent.CreateIActorStateComponent(builder, _o.Disabled, initStateOffset, _o.NullMask);
		}

		// Token: 0x0400E76D RID: 59245
		private Table __p;
	}
}
