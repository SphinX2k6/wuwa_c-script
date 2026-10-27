using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE2 RID: 20450
	public struct IConditionAction : IFlatbufferObject
	{
		// Token: 0x17009428 RID: 37928
		// (get) Token: 0x06020AD1 RID: 133841 RVA: 0x0048B18F File Offset: 0x0048938F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020AD2 RID: 133842 RVA: 0x0048B19C File Offset: 0x0048939C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020AD3 RID: 133843 RVA: 0x0048B1A4 File Offset: 0x004893A4
		public static IConditionAction GetRootAsIConditionAction(ByteBuffer _bb)
		{
			return IConditionAction.GetRootAsIConditionAction(_bb, default(IConditionAction));
		}

		// Token: 0x06020AD4 RID: 133844 RVA: 0x0048B1C0 File Offset: 0x004893C0
		public static IConditionAction GetRootAsIConditionAction(ByteBuffer _bb, IConditionAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020AD5 RID: 133845 RVA: 0x0048B1DD File Offset: 0x004893DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020AD6 RID: 133846 RVA: 0x0048B1EC File Offset: 0x004893EC
		public IConditionAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009429 RID: 37929
		// (get) Token: 0x06020AD7 RID: 133847 RVA: 0x0048B1FC File Offset: 0x004893FC
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

		// Token: 0x06020AD8 RID: 133848 RVA: 0x0048B25C File Offset: 0x0048945C
		public IActionInfo? Action(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700942A RID: 37930
		// (get) Token: 0x06020AD9 RID: 133849 RVA: 0x0048B2BC File Offset: 0x004894BC
		public int ActionLength
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

		// Token: 0x06020ADA RID: 133850 RVA: 0x0048B2E7 File Offset: 0x004894E7
		public static Offset<IConditionAction> CreateIConditionAction(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditionAction.AddAction(builder, ActionOffset);
			IConditionAction.AddCondition(builder, ConditionOffset);
			return IConditionAction.EndIConditionAction(builder);
		}

		// Token: 0x06020ADB RID: 133851 RVA: 0x0048B304 File Offset: 0x00489504
		public static void StartIConditionAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020ADC RID: 133852 RVA: 0x0048B30D File Offset: 0x0048950D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06020ADD RID: 133853 RVA: 0x0048B31D File Offset: 0x0048951D
		public static void AddAction(FlatBufferBuilder builder, VectorOffset actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x06020ADE RID: 133854 RVA: 0x0048B330 File Offset: 0x00489530
		public static VectorOffset CreateActionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020ADF RID: 133855 RVA: 0x0048B370 File Offset: 0x00489570
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020AE0 RID: 133856 RVA: 0x0048B38A File Offset: 0x0048958A
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020AE1 RID: 133857 RVA: 0x0048B3A8 File Offset: 0x004895A8
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020AE2 RID: 133858 RVA: 0x0048B3C1 File Offset: 0x004895C1
		public static void StartActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020AE3 RID: 133859 RVA: 0x0048B3CC File Offset: 0x004895CC
		public static Offset<IConditionAction> EndIConditionAction(FlatBufferBuilder builder)
		{
			return new Offset<IConditionAction>(builder.EndTable());
		}

		// Token: 0x06020AE4 RID: 133860 RVA: 0x0048B3DC File Offset: 0x004895DC
		public IConditionActionT UnPack()
		{
			IConditionActionT conditionActionT = new IConditionActionT();
			this.UnPackTo(conditionActionT);
			return conditionActionT;
		}

		// Token: 0x06020AE5 RID: 133861 RVA: 0x0048B3F8 File Offset: 0x004895F8
		public void UnPackTo(IConditionActionT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Action = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionLength; i++)
			{
				_o.Action.Add((this.Action(i) != null) ? this.Action(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06020AE6 RID: 133862 RVA: 0x0048B488 File Offset: 0x00489688
		public static Offset<IConditionAction> Pack(FlatBufferBuilder builder, IConditionActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionAction>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionOffset = default(VectorOffset);
			if (_o.Action != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Action.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Action[i]);
				}
				actionOffset = IConditionAction.CreateActionVector(builder, array);
			}
			return IConditionAction.CreateIConditionAction(builder, conditionOffset, actionOffset);
		}

		// Token: 0x0400DF9A RID: 57242
		private Table __p;
	}
}
