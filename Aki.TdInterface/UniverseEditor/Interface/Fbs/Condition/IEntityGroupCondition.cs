using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005103 RID: 20739
	public struct IEntityGroupCondition : IFlatbufferObject
	{
		// Token: 0x170094A1 RID: 38049
		// (get) Token: 0x06020987 RID: 133511 RVA: 0x004851C8 File Offset: 0x004833C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020988 RID: 133512 RVA: 0x004851D5 File Offset: 0x004833D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020989 RID: 133513 RVA: 0x004851DC File Offset: 0x004833DC
		public static IEntityGroupCondition GetRootAsIEntityGroupCondition(ByteBuffer _bb)
		{
			return IEntityGroupCondition.GetRootAsIEntityGroupCondition(_bb, default(IEntityGroupCondition));
		}

		// Token: 0x0602098A RID: 133514 RVA: 0x004851F8 File Offset: 0x004833F8
		public static IEntityGroupCondition GetRootAsIEntityGroupCondition(ByteBuffer _bb, IEntityGroupCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602098B RID: 133515 RVA: 0x00485215 File Offset: 0x00483415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602098C RID: 133516 RVA: 0x00485224 File Offset: 0x00483424
		public IEntityGroupCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094A2 RID: 38050
		// (get) Token: 0x0602098D RID: 133517 RVA: 0x00485234 File Offset: 0x00483434
		public int Count
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094A3 RID: 38051
		// (get) Token: 0x0602098E RID: 133518 RVA: 0x00485270 File Offset: 0x00483470
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602098F RID: 133519 RVA: 0x004852AC File Offset: 0x004834AC
		public IEntityEventCondition? Conditions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityEventCondition?(default(IEntityEventCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094A4 RID: 38052
		// (get) Token: 0x06020990 RID: 133520 RVA: 0x0048530C File Offset: 0x0048350C
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170094A5 RID: 38053
		// (get) Token: 0x06020991 RID: 133521 RVA: 0x00485338 File Offset: 0x00483538
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020992 RID: 133522 RVA: 0x00485375 File Offset: 0x00483575
		public static Offset<IEntityGroupCondition> CreateIEntityGroupCondition(FlatBufferBuilder builder, int Count = 0, ECompare Compare = ECompare.Eq, VectorOffset ConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityGroupCondition.AddConditions(builder, ConditionsOffset);
			IEntityGroupCondition.AddCount(builder, Count);
			IEntityGroupCondition.AddNullMask(builder, NullMask);
			IEntityGroupCondition.AddCompare(builder, Compare);
			return IEntityGroupCondition.EndIEntityGroupCondition(builder);
		}

		// Token: 0x06020993 RID: 133523 RVA: 0x004853A1 File Offset: 0x004835A1
		public static void StartIEntityGroupCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020994 RID: 133524 RVA: 0x004853AA File Offset: 0x004835AA
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(0, count, 0);
		}

		// Token: 0x06020995 RID: 133525 RVA: 0x004853B5 File Offset: 0x004835B5
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020996 RID: 133526 RVA: 0x004853C0 File Offset: 0x004835C0
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x06020997 RID: 133527 RVA: 0x004853D0 File Offset: 0x004835D0
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityEventCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020998 RID: 133528 RVA: 0x00485410 File Offset: 0x00483610
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityEventCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityEventCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020999 RID: 133529 RVA: 0x0048542A File Offset: 0x0048362A
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityEventCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityEventCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602099A RID: 133530 RVA: 0x00485448 File Offset: 0x00483648
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityEventCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602099B RID: 133531 RVA: 0x00485461 File Offset: 0x00483661
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602099C RID: 133532 RVA: 0x0048546C File Offset: 0x0048366C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602099D RID: 133533 RVA: 0x00485477 File Offset: 0x00483677
		public static Offset<IEntityGroupCondition> EndIEntityGroupCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupCondition>(builder.EndTable());
		}

		// Token: 0x0602099E RID: 133534 RVA: 0x00485484 File Offset: 0x00483684
		public IEntityGroupConditionT UnPack()
		{
			IEntityGroupConditionT entityGroupConditionT = new IEntityGroupConditionT();
			this.UnPackTo(entityGroupConditionT);
			return entityGroupConditionT;
		}

		// Token: 0x0602099F RID: 133535 RVA: 0x004854A0 File Offset: 0x004836A0
		public void UnPackTo(IEntityGroupConditionT _o)
		{
			_o.Count = this.Count;
			_o.Compare = this.Compare;
			_o.Conditions = new List<IEntityEventConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060209A0 RID: 133536 RVA: 0x00485524 File Offset: 0x00483724
		public static Offset<IEntityGroupCondition> Pack(FlatBufferBuilder builder, IEntityGroupConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupCondition>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IEntityEventCondition>[] array = new Offset<IEntityEventCondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityEventCondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IEntityGroupCondition.CreateConditionsVector(builder, array);
			}
			return IEntityGroupCondition.CreateIEntityGroupCondition(builder, _o.Count, _o.Compare, conditionsOffset, _o.NullMask);
		}

		// Token: 0x0400E0C4 RID: 57540
		private Table __p;
	}
}
