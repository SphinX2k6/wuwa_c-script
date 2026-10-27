using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FFD RID: 20477
	public struct ICondtionListener : IFlatbufferObject
	{
		// Token: 0x1700945F RID: 37983
		// (get) Token: 0x06020BCF RID: 134095 RVA: 0x0048D61C File Offset: 0x0048B81C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020BD0 RID: 134096 RVA: 0x0048D629 File Offset: 0x0048B829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020BD1 RID: 134097 RVA: 0x0048D630 File Offset: 0x0048B830
		public static ICondtionListener GetRootAsICondtionListener(ByteBuffer _bb)
		{
			return ICondtionListener.GetRootAsICondtionListener(_bb, default(ICondtionListener));
		}

		// Token: 0x06020BD2 RID: 134098 RVA: 0x0048D64C File Offset: 0x0048B84C
		public static ICondtionListener GetRootAsICondtionListener(ByteBuffer _bb, ICondtionListener obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020BD3 RID: 134099 RVA: 0x0048D669 File Offset: 0x0048B869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020BD4 RID: 134100 RVA: 0x0048D678 File Offset: 0x0048B878
		public ICondtionListener __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009460 RID: 37984
		// (get) Token: 0x06020BD5 RID: 134101 RVA: 0x0048D688 File Offset: 0x0048B888
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020BD6 RID: 134102 RVA: 0x0048D6E8 File Offset: 0x0048B8E8
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009461 RID: 37985
		// (get) Token: 0x06020BD7 RID: 134103 RVA: 0x0048D748 File Offset: 0x0048B948
		public int ActionsLength
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

		// Token: 0x17009462 RID: 37986
		// (get) Token: 0x06020BD8 RID: 134104 RVA: 0x0048D774 File Offset: 0x0048B974
		public bool PendingConditionAvailable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020BD9 RID: 134105 RVA: 0x0048D7B4 File Offset: 0x0048B9B4
		public IConditionAction? ConditionAction(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009463 RID: 37987
		// (get) Token: 0x06020BDA RID: 134106 RVA: 0x0048D818 File Offset: 0x0048BA18
		public int ConditionActionLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009464 RID: 37988
		// (get) Token: 0x06020BDB RID: 134107 RVA: 0x0048D844 File Offset: 0x0048BA44
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

		// Token: 0x06020BDC RID: 134108 RVA: 0x0048D881 File Offset: 0x0048BA81
		public static Offset<ICondtionListener> CreateICondtionListener(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), bool PendingConditionAvailable = false, VectorOffset ConditionActionOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICondtionListener.AddConditionAction(builder, ConditionActionOffset);
			ICondtionListener.AddActions(builder, ActionsOffset);
			ICondtionListener.AddCondition(builder, ConditionOffset);
			ICondtionListener.AddNullMask(builder, NullMask);
			ICondtionListener.AddPendingConditionAvailable(builder, PendingConditionAvailable);
			return ICondtionListener.EndICondtionListener(builder);
		}

		// Token: 0x06020BDD RID: 134109 RVA: 0x0048D8B5 File Offset: 0x0048BAB5
		public static void StartICondtionListener(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020BDE RID: 134110 RVA: 0x0048D8BE File Offset: 0x0048BABE
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06020BDF RID: 134111 RVA: 0x0048D8CE File Offset: 0x0048BACE
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06020BE0 RID: 134112 RVA: 0x0048D8E0 File Offset: 0x0048BAE0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020BE1 RID: 134113 RVA: 0x0048D920 File Offset: 0x0048BB20
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020BE2 RID: 134114 RVA: 0x0048D93A File Offset: 0x0048BB3A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020BE3 RID: 134115 RVA: 0x0048D958 File Offset: 0x0048BB58
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020BE4 RID: 134116 RVA: 0x0048D971 File Offset: 0x0048BB71
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020BE5 RID: 134117 RVA: 0x0048D97C File Offset: 0x0048BB7C
		public static void AddPendingConditionAvailable(FlatBufferBuilder builder, bool pendingConditionAvailable)
		{
			builder.AddBool(2, pendingConditionAvailable, false);
		}

		// Token: 0x06020BE6 RID: 134118 RVA: 0x0048D987 File Offset: 0x0048BB87
		public static void AddConditionAction(FlatBufferBuilder builder, VectorOffset conditionActionOffset)
		{
			builder.AddOffset(3, conditionActionOffset.Value, 0);
		}

		// Token: 0x06020BE7 RID: 134119 RVA: 0x0048D998 File Offset: 0x0048BB98
		public static VectorOffset CreateConditionActionVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020BE8 RID: 134120 RVA: 0x0048D9D8 File Offset: 0x0048BBD8
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020BE9 RID: 134121 RVA: 0x0048D9F2 File Offset: 0x0048BBF2
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020BEA RID: 134122 RVA: 0x0048DA10 File Offset: 0x0048BC10
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020BEB RID: 134123 RVA: 0x0048DA29 File Offset: 0x0048BC29
		public static void StartConditionActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020BEC RID: 134124 RVA: 0x0048DA34 File Offset: 0x0048BC34
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020BED RID: 134125 RVA: 0x0048DA3F File Offset: 0x0048BC3F
		public static Offset<ICondtionListener> EndICondtionListener(FlatBufferBuilder builder)
		{
			return new Offset<ICondtionListener>(builder.EndTable());
		}

		// Token: 0x06020BEE RID: 134126 RVA: 0x0048DA4C File Offset: 0x0048BC4C
		public ICondtionListenerT UnPack()
		{
			ICondtionListenerT condtionListenerT = new ICondtionListenerT();
			this.UnPackTo(condtionListenerT);
			return condtionListenerT;
		}

		// Token: 0x06020BEF RID: 134127 RVA: 0x0048DA68 File Offset: 0x0048BC68
		public void UnPackTo(ICondtionListenerT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.PendingConditionAvailable = this.PendingConditionAvailable;
			_o.ConditionAction = new List<IConditionActionT>();
			for (int j = 0; j < this.ConditionActionLength; j++)
			{
				_o.ConditionAction.Add((this.ConditionAction(j) != null) ? this.ConditionAction(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020BF0 RID: 134128 RVA: 0x0048DB6C File Offset: 0x0048BD6C
		public static Offset<ICondtionListener> Pack(FlatBufferBuilder builder, ICondtionListenerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICondtionListener>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ICondtionListener.CreateActionsVector(builder, array);
			}
			VectorOffset conditionActionOffset = default(VectorOffset);
			if (_o.ConditionAction != null)
			{
				Offset<IConditionAction>[] array2 = new Offset<IConditionAction>[_o.ConditionAction.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionAction.Pack(builder, _o.ConditionAction[j]);
				}
				conditionActionOffset = ICondtionListener.CreateConditionActionVector(builder, array2);
			}
			return ICondtionListener.CreateICondtionListener(builder, conditionOffset, actionsOffset, _o.PendingConditionAvailable, conditionActionOffset, _o.NullMask);
		}

		// Token: 0x0400DFBA RID: 57274
		private Table __p;
	}
}
