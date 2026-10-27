using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051BC RID: 20924
	public struct IEntityStateTrigger : IFlatbufferObject
	{
		// Token: 0x1700990A RID: 39178
		// (get) Token: 0x06021E62 RID: 138850 RVA: 0x004B3D36 File Offset: 0x004B1F36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021E63 RID: 138851 RVA: 0x004B3D43 File Offset: 0x004B1F43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021E64 RID: 138852 RVA: 0x004B3D4C File Offset: 0x004B1F4C
		public static IEntityStateTrigger GetRootAsIEntityStateTrigger(ByteBuffer _bb)
		{
			return IEntityStateTrigger.GetRootAsIEntityStateTrigger(_bb, default(IEntityStateTrigger));
		}

		// Token: 0x06021E65 RID: 138853 RVA: 0x004B3D68 File Offset: 0x004B1F68
		public static IEntityStateTrigger GetRootAsIEntityStateTrigger(ByteBuffer _bb, IEntityStateTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021E66 RID: 138854 RVA: 0x004B3D85 File Offset: 0x004B1F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021E67 RID: 138855 RVA: 0x004B3D94 File Offset: 0x004B1F94
		public IEntityStateTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700990B RID: 39179
		// (get) Token: 0x06021E68 RID: 138856 RVA: 0x004B3DA4 File Offset: 0x004B1FA4
		public IEntityGroupCondition? GroupCondition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEntityGroupCondition?(default(IEntityGroupCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021E69 RID: 138857 RVA: 0x004B3E04 File Offset: 0x004B2004
		public IActionInfo? SuccessActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700990C RID: 39180
		// (get) Token: 0x06021E6A RID: 138858 RVA: 0x004B3E64 File Offset: 0x004B2064
		public int SuccessActionsLength
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

		// Token: 0x06021E6B RID: 138859 RVA: 0x004B3E90 File Offset: 0x004B2090
		public IActionInfo? FailActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700990D RID: 39181
		// (get) Token: 0x06021E6C RID: 138860 RVA: 0x004B3EF0 File Offset: 0x004B20F0
		public int FailActionsLength
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

		// Token: 0x1700990E RID: 39182
		// (get) Token: 0x06021E6D RID: 138861 RVA: 0x004B3F1C File Offset: 0x004B211C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700990F RID: 39183
		// (get) Token: 0x06021E6E RID: 138862 RVA: 0x004B3F7C File Offset: 0x004B217C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021E6F RID: 138863 RVA: 0x004B3FB9 File Offset: 0x004B21B9
		public static Offset<IEntityStateTrigger> CreateIEntityStateTrigger(FlatBufferBuilder builder, Offset<IEntityGroupCondition> GroupConditionOffset = default(Offset<IEntityGroupCondition>), VectorOffset SuccessActionsOffset = default(VectorOffset), VectorOffset FailActionsOffset = default(VectorOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityStateTrigger.AddCondition(builder, ConditionOffset);
			IEntityStateTrigger.AddFailActions(builder, FailActionsOffset);
			IEntityStateTrigger.AddSuccessActions(builder, SuccessActionsOffset);
			IEntityStateTrigger.AddGroupCondition(builder, GroupConditionOffset);
			IEntityStateTrigger.AddNullMask(builder, NullMask);
			return IEntityStateTrigger.EndIEntityStateTrigger(builder);
		}

		// Token: 0x06021E70 RID: 138864 RVA: 0x004B3FED File Offset: 0x004B21ED
		public static void StartIEntityStateTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021E71 RID: 138865 RVA: 0x004B3FF6 File Offset: 0x004B21F6
		public static void AddGroupCondition(FlatBufferBuilder builder, Offset<IEntityGroupCondition> groupConditionOffset)
		{
			builder.AddOffset(0, groupConditionOffset.Value, 0);
		}

		// Token: 0x06021E72 RID: 138866 RVA: 0x004B4006 File Offset: 0x004B2206
		public static void AddSuccessActions(FlatBufferBuilder builder, VectorOffset successActionsOffset)
		{
			builder.AddOffset(1, successActionsOffset.Value, 0);
		}

		// Token: 0x06021E73 RID: 138867 RVA: 0x004B4018 File Offset: 0x004B2218
		public static VectorOffset CreateSuccessActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E74 RID: 138868 RVA: 0x004B4058 File Offset: 0x004B2258
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E75 RID: 138869 RVA: 0x004B4072 File Offset: 0x004B2272
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E76 RID: 138870 RVA: 0x004B4090 File Offset: 0x004B2290
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E77 RID: 138871 RVA: 0x004B40A9 File Offset: 0x004B22A9
		public static void StartSuccessActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E78 RID: 138872 RVA: 0x004B40B4 File Offset: 0x004B22B4
		public static void AddFailActions(FlatBufferBuilder builder, VectorOffset failActionsOffset)
		{
			builder.AddOffset(2, failActionsOffset.Value, 0);
		}

		// Token: 0x06021E79 RID: 138873 RVA: 0x004B40C4 File Offset: 0x004B22C4
		public static VectorOffset CreateFailActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E7A RID: 138874 RVA: 0x004B4104 File Offset: 0x004B2304
		public static VectorOffset CreateFailActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E7B RID: 138875 RVA: 0x004B411E File Offset: 0x004B231E
		public static VectorOffset CreateFailActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021E7C RID: 138876 RVA: 0x004B413C File Offset: 0x004B233C
		public static VectorOffset CreateFailActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021E7D RID: 138877 RVA: 0x004B4155 File Offset: 0x004B2355
		public static void StartFailActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021E7E RID: 138878 RVA: 0x004B4160 File Offset: 0x004B2360
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(3, conditionOffset.Value, 0);
		}

		// Token: 0x06021E7F RID: 138879 RVA: 0x004B4170 File Offset: 0x004B2370
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021E80 RID: 138880 RVA: 0x004B417B File Offset: 0x004B237B
		public static Offset<IEntityStateTrigger> EndIEntityStateTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateTrigger>(builder.EndTable());
		}

		// Token: 0x06021E81 RID: 138881 RVA: 0x004B4188 File Offset: 0x004B2388
		public IEntityStateTriggerT UnPack()
		{
			IEntityStateTriggerT entityStateTriggerT = new IEntityStateTriggerT();
			this.UnPackTo(entityStateTriggerT);
			return entityStateTriggerT;
		}

		// Token: 0x06021E82 RID: 138882 RVA: 0x004B41A4 File Offset: 0x004B23A4
		public void UnPackTo(IEntityStateTriggerT _o)
		{
			_o.GroupCondition = ((this.GroupCondition != null) ? this.GroupCondition.Value.UnPack() : null);
			_o.SuccessActions = new List<IActionInfoT>();
			for (int i = 0; i < this.SuccessActionsLength; i++)
			{
				_o.SuccessActions.Add((this.SuccessActions(i) != null) ? this.SuccessActions(i).Value.UnPack() : null);
			}
			_o.FailActions = new List<IActionInfoT>();
			for (int j = 0; j < this.FailActionsLength; j++)
			{
				_o.FailActions.Add((this.FailActions(j) != null) ? this.FailActions(j).Value.UnPack() : null);
			}
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021E83 RID: 138883 RVA: 0x004B42CC File Offset: 0x004B24CC
		public static Offset<IEntityStateTrigger> Pack(FlatBufferBuilder builder, IEntityStateTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateTrigger>);
			}
			Offset<IEntityGroupCondition> groupConditionOffset = (_o.GroupCondition == null) ? default(Offset<IEntityGroupCondition>) : IEntityGroupCondition.Pack(builder, _o.GroupCondition);
			VectorOffset successActionsOffset = default(VectorOffset);
			if (_o.SuccessActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.SuccessActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.SuccessActions[i]);
				}
				successActionsOffset = IEntityStateTrigger.CreateSuccessActionsVector(builder, array);
			}
			VectorOffset failActionsOffset = default(VectorOffset);
			if (_o.FailActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.FailActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.FailActions[j]);
				}
				failActionsOffset = IEntityStateTrigger.CreateFailActionsVector(builder, array2);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IEntityStateTrigger.CreateIEntityStateTrigger(builder, groupConditionOffset, successActionsOffset, failActionsOffset, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400E2B2 RID: 58034
		private Table __p;
	}
}
