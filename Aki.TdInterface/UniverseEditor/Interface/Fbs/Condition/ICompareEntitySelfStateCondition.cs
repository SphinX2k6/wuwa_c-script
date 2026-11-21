using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005082 RID: 20610
	public struct ICompareEntitySelfStateCondition : IFlatbufferObject
	{
		// Token: 0x17009386 RID: 37766
		// (get) Token: 0x060203BE RID: 132030 RVA: 0x00477AF0 File Offset: 0x00475CF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060203BF RID: 132031 RVA: 0x00477AFD File Offset: 0x00475CFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060203C0 RID: 132032 RVA: 0x00477B04 File Offset: 0x00475D04
		public static ICompareEntitySelfStateCondition GetRootAsICompareEntitySelfStateCondition(ByteBuffer _bb)
		{
			return ICompareEntitySelfStateCondition.GetRootAsICompareEntitySelfStateCondition(_bb, default(ICompareEntitySelfStateCondition));
		}

		// Token: 0x060203C1 RID: 132033 RVA: 0x00477B20 File Offset: 0x00475D20
		public static ICompareEntitySelfStateCondition GetRootAsICompareEntitySelfStateCondition(ByteBuffer _bb, ICompareEntitySelfStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060203C2 RID: 132034 RVA: 0x00477B3D File Offset: 0x00475D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060203C3 RID: 132035 RVA: 0x00477B4C File Offset: 0x00475D4C
		public ICompareEntitySelfStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009387 RID: 37767
		// (get) Token: 0x060203C4 RID: 132036 RVA: 0x00477B5C File Offset: 0x00475D5C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009388 RID: 37768
		// (get) Token: 0x060203C5 RID: 132037 RVA: 0x00477B98 File Offset: 0x00475D98
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

		// Token: 0x060203C6 RID: 132038 RVA: 0x00477BCF File Offset: 0x00475DCF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060203C7 RID: 132039 RVA: 0x00477BDE File Offset: 0x00475DDE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009389 RID: 37769
		// (get) Token: 0x060203C8 RID: 132040 RVA: 0x00477BEC File Offset: 0x00475DEC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060203C9 RID: 132041 RVA: 0x00477C28 File Offset: 0x00475E28
		public static Offset<ICompareEntitySelfStateCondition> CreateICompareEntitySelfStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset StateOffset = default(StringOffset), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICompareEntitySelfStateCondition.AddState(builder, StateOffset);
			ICompareEntitySelfStateCondition.AddCompare(builder, Compare);
			ICompareEntitySelfStateCondition.AddType(builder, Type);
			return ICompareEntitySelfStateCondition.EndICompareEntitySelfStateCondition(builder);
		}

		// Token: 0x060203CA RID: 132042 RVA: 0x00477C4C File Offset: 0x00475E4C
		public static void StartICompareEntitySelfStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060203CB RID: 132043 RVA: 0x00477C55 File Offset: 0x00475E55
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060203CC RID: 132044 RVA: 0x00477C60 File Offset: 0x00475E60
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060203CD RID: 132045 RVA: 0x00477C70 File Offset: 0x00475E70
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x060203CE RID: 132046 RVA: 0x00477C7B File Offset: 0x00475E7B
		public static Offset<ICompareEntitySelfStateCondition> EndICompareEntitySelfStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareEntitySelfStateCondition>(builder.EndTable());
		}

		// Token: 0x060203CF RID: 132047 RVA: 0x00477C88 File Offset: 0x00475E88
		public ICompareEntitySelfStateConditionT UnPack()
		{
			ICompareEntitySelfStateConditionT compareEntitySelfStateConditionT = new ICompareEntitySelfStateConditionT();
			this.UnPackTo(compareEntitySelfStateConditionT);
			return compareEntitySelfStateConditionT;
		}

		// Token: 0x060203D0 RID: 132048 RVA: 0x00477CA3 File Offset: 0x00475EA3
		public void UnPackTo(ICompareEntitySelfStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
			_o.Compare = this.Compare;
		}

		// Token: 0x060203D1 RID: 132049 RVA: 0x00477CCC File Offset: 0x00475ECC
		public static Offset<ICompareEntitySelfStateCondition> Pack(FlatBufferBuilder builder, ICompareEntitySelfStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareEntitySelfStateCondition>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ICompareEntitySelfStateCondition.CreateICompareEntitySelfStateCondition(builder, _o.Type, stateOffset, _o.Compare);
		}

		// Token: 0x0400DF75 RID: 57205
		private Table __p;
	}
}
