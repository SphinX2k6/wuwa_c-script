using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006943 RID: 26947
	public struct IChangeElementalBoxState : IFlatbufferObject
	{
		// Token: 0x1700C662 RID: 50786
		// (get) Token: 0x0602E30C RID: 189196 RVA: 0x0064F5A2 File Offset: 0x0064D7A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E30D RID: 189197 RVA: 0x0064F5AF File Offset: 0x0064D7AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E30E RID: 189198 RVA: 0x0064F5B8 File Offset: 0x0064D7B8
		public static IChangeElementalBoxState GetRootAsIChangeElementalBoxState(ByteBuffer _bb)
		{
			return IChangeElementalBoxState.GetRootAsIChangeElementalBoxState(_bb, default(IChangeElementalBoxState));
		}

		// Token: 0x0602E30F RID: 189199 RVA: 0x0064F5D4 File Offset: 0x0064D7D4
		public static IChangeElementalBoxState GetRootAsIChangeElementalBoxState(ByteBuffer _bb, IChangeElementalBoxState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E310 RID: 189200 RVA: 0x0064F5F1 File Offset: 0x0064D7F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E311 RID: 189201 RVA: 0x0064F600 File Offset: 0x0064D800
		public IChangeElementalBoxState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C663 RID: 50787
		// (get) Token: 0x0602E312 RID: 189202 RVA: 0x0064F610 File Offset: 0x0064D810
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

		// Token: 0x0602E313 RID: 189203 RVA: 0x0064F64C File Offset: 0x0064D84C
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E314 RID: 189204 RVA: 0x0064F690 File Offset: 0x0064D890
		public IChangeElementalBoxStatePlayerTarget TargetAsIChangeElementalBoxStatePlayerTarget()
		{
			return this.Target<IChangeElementalBoxStatePlayerTarget>().Value;
		}

		// Token: 0x0602E315 RID: 189205 RVA: 0x0064F6AC File Offset: 0x0064D8AC
		public IChangeElementalBoxStateTargetBoxId TargetAsIChangeElementalBoxStateTargetBoxId()
		{
			return this.Target<IChangeElementalBoxStateTargetBoxId>().Value;
		}

		// Token: 0x1700C664 RID: 50788
		// (get) Token: 0x0602E316 RID: 189206 RVA: 0x0064F6C8 File Offset: 0x0064D8C8
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

		// Token: 0x0602E317 RID: 189207 RVA: 0x0064F6FF File Offset: 0x0064D8FF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E318 RID: 189208 RVA: 0x0064F70E File Offset: 0x0064D90E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602E319 RID: 189209 RVA: 0x0064F71C File Offset: 0x0064D91C
		public static Offset<IChangeElementalBoxState> CreateIChangeElementalBoxState(FlatBufferBuilder builder, TChangeElementalBoxStateTarget Target_type = TChangeElementalBoxStateTarget.NONE, int TargetOffset = 0, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChangeElementalBoxState.AddState(builder, StateOffset);
			IChangeElementalBoxState.AddTarget(builder, TargetOffset);
			IChangeElementalBoxState.AddTargetType(builder, Target_type);
			return IChangeElementalBoxState.EndIChangeElementalBoxState(builder);
		}

		// Token: 0x0602E31A RID: 189210 RVA: 0x0064F740 File Offset: 0x0064D940
		public static void StartIChangeElementalBoxState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E31B RID: 189211 RVA: 0x0064F749 File Offset: 0x0064D949
		public static void AddTargetType(FlatBufferBuilder builder, TChangeElementalBoxStateTarget targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x0602E31C RID: 189212 RVA: 0x0064F754 File Offset: 0x0064D954
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x0602E31D RID: 189213 RVA: 0x0064F75F File Offset: 0x0064D95F
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(2, stateOffset.Value, 0);
		}

		// Token: 0x0602E31E RID: 189214 RVA: 0x0064F76F File Offset: 0x0064D96F
		public static Offset<IChangeElementalBoxState> EndIChangeElementalBoxState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeElementalBoxState>(builder.EndTable());
		}

		// Token: 0x0602E31F RID: 189215 RVA: 0x0064F77C File Offset: 0x0064D97C
		public IChangeElementalBoxStateT UnPack()
		{
			IChangeElementalBoxStateT changeElementalBoxStateT = new IChangeElementalBoxStateT();
			this.UnPackTo(changeElementalBoxStateT);
			return changeElementalBoxStateT;
		}

		// Token: 0x0602E320 RID: 189216 RVA: 0x0064F798 File Offset: 0x0064D998
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

		// Token: 0x0602E321 RID: 189217 RVA: 0x0064F84C File Offset: 0x0064DA4C
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

		// Token: 0x04011690 RID: 71312
		private Table __p;
	}
}
