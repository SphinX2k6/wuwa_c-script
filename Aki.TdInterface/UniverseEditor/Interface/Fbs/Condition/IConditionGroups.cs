using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BE9 RID: 19433
	public struct IConditionGroups : IFlatbufferObject
	{
		// Token: 0x17008D25 RID: 36133
		// (get) Token: 0x0601EC1D RID: 125981 RVA: 0x0044F223 File Offset: 0x0044D423
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC1E RID: 125982 RVA: 0x0044F230 File Offset: 0x0044D430
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC1F RID: 125983 RVA: 0x0044F238 File Offset: 0x0044D438
		public static IConditionGroups GetRootAsIConditionGroups(ByteBuffer _bb)
		{
			return IConditionGroups.GetRootAsIConditionGroups(_bb, default(IConditionGroups));
		}

		// Token: 0x0601EC20 RID: 125984 RVA: 0x0044F254 File Offset: 0x0044D454
		public static IConditionGroups GetRootAsIConditionGroups(ByteBuffer _bb, IConditionGroups obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC21 RID: 125985 RVA: 0x0044F271 File Offset: 0x0044D471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC22 RID: 125986 RVA: 0x0044F280 File Offset: 0x0044D480
		public IConditionGroups __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D26 RID: 36134
		// (get) Token: 0x0601EC23 RID: 125987 RVA: 0x0044F290 File Offset: 0x0044D490
		public EConditionCount Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EC24 RID: 125988 RVA: 0x0044F2CC File Offset: 0x0044D4CC
		public IConditionGroup? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008D27 RID: 36135
		// (get) Token: 0x0601EC25 RID: 125989 RVA: 0x0044F32C File Offset: 0x0044D52C
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601EC26 RID: 125990 RVA: 0x0044F357 File Offset: 0x0044D557
		public static Offset<IConditionGroups> CreateIConditionGroups(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditionGroups.AddConditions(builder, ConditionsOffset);
			IConditionGroups.AddType(builder, Type);
			return IConditionGroups.EndIConditionGroups(builder);
		}

		// Token: 0x0601EC27 RID: 125991 RVA: 0x0044F374 File Offset: 0x0044D574
		public static void StartIConditionGroups(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EC28 RID: 125992 RVA: 0x0044F37D File Offset: 0x0044D57D
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EC29 RID: 125993 RVA: 0x0044F388 File Offset: 0x0044D588
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0601EC2A RID: 125994 RVA: 0x0044F398 File Offset: 0x0044D598
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EC2B RID: 125995 RVA: 0x0044F3D8 File Offset: 0x0044D5D8
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC2C RID: 125996 RVA: 0x0044F3F2 File Offset: 0x0044D5F2
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC2D RID: 125997 RVA: 0x0044F410 File Offset: 0x0044D610
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EC2E RID: 125998 RVA: 0x0044F429 File Offset: 0x0044D629
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EC2F RID: 125999 RVA: 0x0044F434 File Offset: 0x0044D634
		public static Offset<IConditionGroups> EndIConditionGroups(FlatBufferBuilder builder)
		{
			return new Offset<IConditionGroups>(builder.EndTable());
		}

		// Token: 0x0601EC30 RID: 126000 RVA: 0x0044F444 File Offset: 0x0044D644
		public IConditionGroupsT UnPack()
		{
			IConditionGroupsT conditionGroupsT = new IConditionGroupsT();
			this.UnPackTo(conditionGroupsT);
			return conditionGroupsT;
		}

		// Token: 0x0601EC31 RID: 126001 RVA: 0x0044F460 File Offset: 0x0044D660
		public void UnPackTo(IConditionGroupsT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<IConditionGroupT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601EC32 RID: 126002 RVA: 0x0044F4CC File Offset: 0x0044D6CC
		public static Offset<IConditionGroups> Pack(FlatBufferBuilder builder, IConditionGroupsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionGroups>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IConditionGroup>[] array = new Offset<IConditionGroup>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionGroup.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IConditionGroups.CreateConditionsVector(builder, array);
			}
			return IConditionGroups.CreateIConditionGroups(builder, _o.Type, conditionsOffset);
		}

		// Token: 0x0400D572 RID: 54642
		private Table __p;
	}
}
