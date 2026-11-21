using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005721 RID: 22305
	public struct IEntityStateTrigger : IFlatbufferObject
	{
		// Token: 0x1700A0F9 RID: 41209
		// (get) Token: 0x06023DBA RID: 146874 RVA: 0x004EDD9E File Offset: 0x004EBF9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023DBB RID: 146875 RVA: 0x004EDDAB File Offset: 0x004EBFAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023DBC RID: 146876 RVA: 0x004EDDB4 File Offset: 0x004EBFB4
		public static IEntityStateTrigger GetRootAsIEntityStateTrigger(ByteBuffer _bb)
		{
			return IEntityStateTrigger.GetRootAsIEntityStateTrigger(_bb, default(IEntityStateTrigger));
		}

		// Token: 0x06023DBD RID: 146877 RVA: 0x004EDDD0 File Offset: 0x004EBFD0
		public static IEntityStateTrigger GetRootAsIEntityStateTrigger(ByteBuffer _bb, IEntityStateTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023DBE RID: 146878 RVA: 0x004EDDED File Offset: 0x004EBFED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023DBF RID: 146879 RVA: 0x004EDDFC File Offset: 0x004EBFFC
		public IEntityStateTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0FA RID: 41210
		// (get) Token: 0x06023DC0 RID: 146880 RVA: 0x004EDE0C File Offset: 0x004EC00C
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

		// Token: 0x06023DC1 RID: 146881 RVA: 0x004EDE6C File Offset: 0x004EC06C
		public IActionInfo? SuccessActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0FB RID: 41211
		// (get) Token: 0x06023DC2 RID: 146882 RVA: 0x004EDECC File Offset: 0x004EC0CC
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

		// Token: 0x06023DC3 RID: 146883 RVA: 0x004EDEF8 File Offset: 0x004EC0F8
		public IActionInfo? FailActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0FC RID: 41212
		// (get) Token: 0x06023DC4 RID: 146884 RVA: 0x004EDF58 File Offset: 0x004EC158
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

		// Token: 0x1700A0FD RID: 41213
		// (get) Token: 0x06023DC5 RID: 146885 RVA: 0x004EDF84 File Offset: 0x004EC184
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

		// Token: 0x1700A0FE RID: 41214
		// (get) Token: 0x06023DC6 RID: 146886 RVA: 0x004EDFE4 File Offset: 0x004EC1E4
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

		// Token: 0x06023DC7 RID: 146887 RVA: 0x004EE021 File Offset: 0x004EC221
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

		// Token: 0x06023DC8 RID: 146888 RVA: 0x004EE055 File Offset: 0x004EC255
		public static void StartIEntityStateTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023DC9 RID: 146889 RVA: 0x004EE05E File Offset: 0x004EC25E
		public static void AddGroupCondition(FlatBufferBuilder builder, Offset<IEntityGroupCondition> groupConditionOffset)
		{
			builder.AddOffset(0, groupConditionOffset.Value, 0);
		}

		// Token: 0x06023DCA RID: 146890 RVA: 0x004EE06E File Offset: 0x004EC26E
		public static void AddSuccessActions(FlatBufferBuilder builder, VectorOffset successActionsOffset)
		{
			builder.AddOffset(1, successActionsOffset.Value, 0);
		}

		// Token: 0x06023DCB RID: 146891 RVA: 0x004EE080 File Offset: 0x004EC280
		public static VectorOffset CreateSuccessActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023DCC RID: 146892 RVA: 0x004EE0C0 File Offset: 0x004EC2C0
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DCD RID: 146893 RVA: 0x004EE0DA File Offset: 0x004EC2DA
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DCE RID: 146894 RVA: 0x004EE0F8 File Offset: 0x004EC2F8
		public static VectorOffset CreateSuccessActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023DCF RID: 146895 RVA: 0x004EE111 File Offset: 0x004EC311
		public static void StartSuccessActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023DD0 RID: 146896 RVA: 0x004EE11C File Offset: 0x004EC31C
		public static void AddFailActions(FlatBufferBuilder builder, VectorOffset failActionsOffset)
		{
			builder.AddOffset(2, failActionsOffset.Value, 0);
		}

		// Token: 0x06023DD1 RID: 146897 RVA: 0x004EE12C File Offset: 0x004EC32C
		public static VectorOffset CreateFailActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023DD2 RID: 146898 RVA: 0x004EE16C File Offset: 0x004EC36C
		public static VectorOffset CreateFailActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DD3 RID: 146899 RVA: 0x004EE186 File Offset: 0x004EC386
		public static VectorOffset CreateFailActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DD4 RID: 146900 RVA: 0x004EE1A4 File Offset: 0x004EC3A4
		public static VectorOffset CreateFailActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023DD5 RID: 146901 RVA: 0x004EE1BD File Offset: 0x004EC3BD
		public static void StartFailActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023DD6 RID: 146902 RVA: 0x004EE1C8 File Offset: 0x004EC3C8
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(3, conditionOffset.Value, 0);
		}

		// Token: 0x06023DD7 RID: 146903 RVA: 0x004EE1D8 File Offset: 0x004EC3D8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023DD8 RID: 146904 RVA: 0x004EE1E3 File Offset: 0x004EC3E3
		public static Offset<IEntityStateTrigger> EndIEntityStateTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateTrigger>(builder.EndTable());
		}

		// Token: 0x06023DD9 RID: 146905 RVA: 0x004EE1F0 File Offset: 0x004EC3F0
		public IEntityStateTriggerT UnPack()
		{
			IEntityStateTriggerT entityStateTriggerT = new IEntityStateTriggerT();
			this.UnPackTo(entityStateTriggerT);
			return entityStateTriggerT;
		}

		// Token: 0x06023DDA RID: 146906 RVA: 0x004EE20C File Offset: 0x004EC40C
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

		// Token: 0x06023DDB RID: 146907 RVA: 0x004EE334 File Offset: 0x004EC534
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

		// Token: 0x0400EEB0 RID: 61104
		private Table __p;
	}
}
