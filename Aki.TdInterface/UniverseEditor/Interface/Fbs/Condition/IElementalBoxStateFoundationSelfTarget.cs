using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050EB RID: 20715
	public struct IElementalBoxStateFoundationSelfTarget : IFlatbufferObject
	{
		// Token: 0x17009474 RID: 38004
		// (get) Token: 0x060208C1 RID: 133313 RVA: 0x00483EB0 File Offset: 0x004820B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060208C2 RID: 133314 RVA: 0x00483EBD File Offset: 0x004820BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060208C3 RID: 133315 RVA: 0x00483EC4 File Offset: 0x004820C4
		public static IElementalBoxStateFoundationSelfTarget GetRootAsIElementalBoxStateFoundationSelfTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateFoundationSelfTarget.GetRootAsIElementalBoxStateFoundationSelfTarget(_bb, default(IElementalBoxStateFoundationSelfTarget));
		}

		// Token: 0x060208C4 RID: 133316 RVA: 0x00483EE0 File Offset: 0x004820E0
		public static IElementalBoxStateFoundationSelfTarget GetRootAsIElementalBoxStateFoundationSelfTarget(ByteBuffer _bb, IElementalBoxStateFoundationSelfTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060208C5 RID: 133317 RVA: 0x00483EFD File Offset: 0x004820FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060208C6 RID: 133318 RVA: 0x00483F0C File Offset: 0x0048210C
		public IElementalBoxStateFoundationSelfTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009475 RID: 38005
		// (get) Token: 0x060208C7 RID: 133319 RVA: 0x00483F1C File Offset: 0x0048211C
		public EElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxStateTargetType.Player;
				}
				return (EElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009476 RID: 38006
		// (get) Token: 0x060208C8 RID: 133320 RVA: 0x00483F58 File Offset: 0x00482158
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

		// Token: 0x060208C9 RID: 133321 RVA: 0x00483F8F File Offset: 0x0048218F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060208CA RID: 133322 RVA: 0x00483F9E File Offset: 0x0048219E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060208CB RID: 133323 RVA: 0x00483FAC File Offset: 0x004821AC
		public static Offset<IElementalBoxStateFoundationSelfTarget> CreateIElementalBoxStateFoundationSelfTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IElementalBoxStateFoundationSelfTarget.AddState(builder, StateOffset);
			IElementalBoxStateFoundationSelfTarget.AddType(builder, Type);
			return IElementalBoxStateFoundationSelfTarget.EndIElementalBoxStateFoundationSelfTarget(builder);
		}

		// Token: 0x060208CC RID: 133324 RVA: 0x00483FC9 File Offset: 0x004821C9
		public static void StartIElementalBoxStateFoundationSelfTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060208CD RID: 133325 RVA: 0x00483FD2 File Offset: 0x004821D2
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060208CE RID: 133326 RVA: 0x00483FDD File Offset: 0x004821DD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060208CF RID: 133327 RVA: 0x00483FED File Offset: 0x004821ED
		public static Offset<IElementalBoxStateFoundationSelfTarget> EndIElementalBoxStateFoundationSelfTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateFoundationSelfTarget>(builder.EndTable());
		}

		// Token: 0x060208D0 RID: 133328 RVA: 0x00483FFC File Offset: 0x004821FC
		public IElementalBoxStateFoundationSelfTargetT UnPack()
		{
			IElementalBoxStateFoundationSelfTargetT elementalBoxStateFoundationSelfTargetT = new IElementalBoxStateFoundationSelfTargetT();
			this.UnPackTo(elementalBoxStateFoundationSelfTargetT);
			return elementalBoxStateFoundationSelfTargetT;
		}

		// Token: 0x060208D1 RID: 133329 RVA: 0x00484017 File Offset: 0x00482217
		public void UnPackTo(IElementalBoxStateFoundationSelfTargetT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x060208D2 RID: 133330 RVA: 0x00484034 File Offset: 0x00482234
		public static Offset<IElementalBoxStateFoundationSelfTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateFoundationSelfTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateFoundationSelfTarget>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IElementalBoxStateFoundationSelfTarget.CreateIElementalBoxStateFoundationSelfTarget(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400E0A2 RID: 57506
		private Table __p;
	}
}
