using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050D6 RID: 20694
	public struct IConditionGroups : IFlatbufferObject
	{
		// Token: 0x17009449 RID: 37961
		// (get) Token: 0x06020803 RID: 133123 RVA: 0x0048288B File Offset: 0x00480A8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020804 RID: 133124 RVA: 0x00482898 File Offset: 0x00480A98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020805 RID: 133125 RVA: 0x004828A0 File Offset: 0x00480AA0
		public static IConditionGroups GetRootAsIConditionGroups(ByteBuffer _bb)
		{
			return IConditionGroups.GetRootAsIConditionGroups(_bb, default(IConditionGroups));
		}

		// Token: 0x06020806 RID: 133126 RVA: 0x004828BC File Offset: 0x00480ABC
		public static IConditionGroups GetRootAsIConditionGroups(ByteBuffer _bb, IConditionGroups obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020807 RID: 133127 RVA: 0x004828D9 File Offset: 0x00480AD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020808 RID: 133128 RVA: 0x004828E8 File Offset: 0x00480AE8
		public IConditionGroups __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700944A RID: 37962
		// (get) Token: 0x06020809 RID: 133129 RVA: 0x004828F8 File Offset: 0x00480AF8
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

		// Token: 0x0602080A RID: 133130 RVA: 0x00482934 File Offset: 0x00480B34
		public IConditionGroup? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700944B RID: 37963
		// (get) Token: 0x0602080B RID: 133131 RVA: 0x00482994 File Offset: 0x00480B94
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

		// Token: 0x0602080C RID: 133132 RVA: 0x004829BF File Offset: 0x00480BBF
		public static Offset<IConditionGroups> CreateIConditionGroups(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditionGroups.AddConditions(builder, ConditionsOffset);
			IConditionGroups.AddType(builder, Type);
			return IConditionGroups.EndIConditionGroups(builder);
		}

		// Token: 0x0602080D RID: 133133 RVA: 0x004829DC File Offset: 0x00480BDC
		public static void StartIConditionGroups(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602080E RID: 133134 RVA: 0x004829E5 File Offset: 0x00480BE5
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602080F RID: 133135 RVA: 0x004829F0 File Offset: 0x00480BF0
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x06020810 RID: 133136 RVA: 0x00482A00 File Offset: 0x00480C00
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020811 RID: 133137 RVA: 0x00482A40 File Offset: 0x00480C40
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020812 RID: 133138 RVA: 0x00482A5A File Offset: 0x00480C5A
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020813 RID: 133139 RVA: 0x00482A78 File Offset: 0x00480C78
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020814 RID: 133140 RVA: 0x00482A91 File Offset: 0x00480C91
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020815 RID: 133141 RVA: 0x00482A9C File Offset: 0x00480C9C
		public static Offset<IConditionGroups> EndIConditionGroups(FlatBufferBuilder builder)
		{
			return new Offset<IConditionGroups>(builder.EndTable());
		}

		// Token: 0x06020816 RID: 133142 RVA: 0x00482AAC File Offset: 0x00480CAC
		public IConditionGroupsT UnPack()
		{
			IConditionGroupsT conditionGroupsT = new IConditionGroupsT();
			this.UnPackTo(conditionGroupsT);
			return conditionGroupsT;
		}

		// Token: 0x06020817 RID: 133143 RVA: 0x00482AC8 File Offset: 0x00480CC8
		public void UnPackTo(IConditionGroupsT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<IConditionGroupT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06020818 RID: 133144 RVA: 0x00482B34 File Offset: 0x00480D34
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

		// Token: 0x0400E089 RID: 57481
		private Table __p;
	}
}
