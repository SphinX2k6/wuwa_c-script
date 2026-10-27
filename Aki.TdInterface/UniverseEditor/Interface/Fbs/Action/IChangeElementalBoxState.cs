using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D2 RID: 25298
	public struct IChangeElementalBoxState : IFlatbufferObject
	{
		// Token: 0x1700BCD8 RID: 48344
		// (get) Token: 0x0602BBA3 RID: 179107 RVA: 0x00604596 File Offset: 0x00602796
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BBA4 RID: 179108 RVA: 0x006045A3 File Offset: 0x006027A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BBA5 RID: 179109 RVA: 0x006045AC File Offset: 0x006027AC
		public static IChangeElementalBoxState GetRootAsIChangeElementalBoxState(ByteBuffer _bb)
		{
			return IChangeElementalBoxState.GetRootAsIChangeElementalBoxState(_bb, default(IChangeElementalBoxState));
		}

		// Token: 0x0602BBA6 RID: 179110 RVA: 0x006045C8 File Offset: 0x006027C8
		public static IChangeElementalBoxState GetRootAsIChangeElementalBoxState(ByteBuffer _bb, IChangeElementalBoxState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BBA7 RID: 179111 RVA: 0x006045E5 File Offset: 0x006027E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BBA8 RID: 179112 RVA: 0x006045F4 File Offset: 0x006027F4
		public IChangeElementalBoxState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCD9 RID: 48345
		// (get) Token: 0x0602BBA9 RID: 179113 RVA: 0x00604604 File Offset: 0x00602804
		public TChangeElementalBoxStateTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TChangeElementalBoxStateTarget.NONE;
				}
				return (TChangeElementalBoxStateTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BBAA RID: 179114 RVA: 0x00604640 File Offset: 0x00602840
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BBAB RID: 179115 RVA: 0x00604684 File Offset: 0x00602884
		public IChangeElementalBoxStatePlayerTarget TargetAsIChangeElementalBoxStatePlayerTarget()
		{
			return this.Target<IChangeElementalBoxStatePlayerTarget>().Value;
		}

		// Token: 0x0602BBAC RID: 179116 RVA: 0x006046A0 File Offset: 0x006028A0
		public IChangeElementalBoxStateTargetBoxId TargetAsIChangeElementalBoxStateTargetBoxId()
		{
			return this.Target<IChangeElementalBoxStateTargetBoxId>().Value;
		}

		// Token: 0x1700BCDA RID: 48346
		// (get) Token: 0x0602BBAD RID: 179117 RVA: 0x006046BC File Offset: 0x006028BC
		public string State
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BBAE RID: 179118 RVA: 0x006046F3 File Offset: 0x006028F3
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602BBAF RID: 179119 RVA: 0x00604702 File Offset: 0x00602902
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602BBB0 RID: 179120 RVA: 0x00604710 File Offset: 0x00602910
		public static Offset<IChangeElementalBoxState> CreateIChangeElementalBoxState(FlatBufferBuilder builder, TChangeElementalBoxStateTarget Target_type = TChangeElementalBoxStateTarget.NONE, int TargetOffset = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChangeElementalBoxState.AddState(builder, StateOffset);
			IChangeElementalBoxState.AddTarget(builder, TargetOffset);
			IChangeElementalBoxState.AddTargetType(builder, Target_type);
			return IChangeElementalBoxState.EndIChangeElementalBoxState(builder);
		}

		// Token: 0x0602BBB1 RID: 179121 RVA: 0x00604734 File Offset: 0x00602934
		public static void StartIChangeElementalBoxState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BBB2 RID: 179122 RVA: 0x0060473D File Offset: 0x0060293D
		public static void AddTargetType(FlatBufferBuilder builder, TChangeElementalBoxStateTarget targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x0602BBB3 RID: 179123 RVA: 0x00604748 File Offset: 0x00602948
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x0602BBB4 RID: 179124 RVA: 0x00604753 File Offset: 0x00602953
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x0602BBB5 RID: 179125 RVA: 0x00604763 File Offset: 0x00602963
		public static Offset<IChangeElementalBoxState> EndIChangeElementalBoxState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxState>(builder.EndTable());
		}

		// Token: 0x0602BBB6 RID: 179126 RVA: 0x00604770 File Offset: 0x00602970
		public IChangeElementalBoxStateT UnPack()
		{
			IChangeElementalBoxStateT changeElementalBoxStateT = new IChangeElementalBoxStateT();
			this.UnPackTo(changeElementalBoxStateT);
			return changeElementalBoxStateT;
		}

		// Token: 0x0602BBB7 RID: 179127 RVA: 0x0060478C File Offset: 0x0060298C
		public void UnPackTo(IChangeElementalBoxStateT _o)
		{
			_o.Target = new TChangeElementalBoxStateTargetUnion();
			_o.Target.Type = this.TargetType;
			TChangeElementalBoxStateTarget targetType = this.TargetType;
			if (targetType != TChangeElementalBoxStateTarget.IChangeElementalBoxStatePlayerTarget)
			{
				if (targetType == TChangeElementalBoxStateTarget.IChangeElementalBoxStateTargetBoxId)
				{
					_o.Target.Value = ((this.Target<IChangeElementalBoxStateTargetBoxId>() != null) ? this.Target<IChangeElementalBoxStateTargetBoxId>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<IChangeElementalBoxStatePlayerTarget>() != null) ? this.Target<IChangeElementalBoxStatePlayerTarget>().Value.UnPack() : null);
			}
			_o.State = this.State;
		}

		// Token: 0x0602BBB8 RID: 179128 RVA: 0x00604840 File Offset: 0x00602A40
		public static Offset<IChangeElementalBoxState> Pack(FlatBufferBuilder builder, IChangeElementalBoxStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeElementalBoxState>);
			}
			TChangeElementalBoxStateTarget target_type = (_o.Target == null) ? TChangeElementalBoxStateTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TChangeElementalBoxStateTargetUnion.Pack(builder, _o.Target);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeElementalBoxState.CreateIChangeElementalBoxState(builder, target_type, targetOffset, stateOffset);
		}

		// Token: 0x0401087A RID: 67706
		private Table __p;
	}
}
