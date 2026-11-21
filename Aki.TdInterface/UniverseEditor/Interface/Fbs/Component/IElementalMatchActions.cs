using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005694 RID: 22164
	public struct IElementalMatchActions : IFlatbufferObject
	{
		// Token: 0x17009F6D RID: 40813
		// (get) Token: 0x060237A2 RID: 145314 RVA: 0x004E16FF File Offset: 0x004DF8FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060237A3 RID: 145315 RVA: 0x004E170C File Offset: 0x004DF90C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060237A4 RID: 145316 RVA: 0x004E1714 File Offset: 0x004DF914
		public static IElementalMatchActions GetRootAsIElementalMatchActions(ByteBuffer _bb)
		{
			return IElementalMatchActions.GetRootAsIElementalMatchActions(_bb, default(IElementalMatchActions));
		}

		// Token: 0x060237A5 RID: 145317 RVA: 0x004E1730 File Offset: 0x004DF930
		public static IElementalMatchActions GetRootAsIElementalMatchActions(ByteBuffer _bb, IElementalMatchActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060237A6 RID: 145318 RVA: 0x004E174D File Offset: 0x004DF94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060237A7 RID: 145319 RVA: 0x004E175C File Offset: 0x004DF95C
		public IElementalMatchActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F6E RID: 40814
		// (get) Token: 0x060237A8 RID: 145320 RVA: 0x004E176C File Offset: 0x004DF96C
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

		// Token: 0x060237A9 RID: 145321 RVA: 0x004E17CC File Offset: 0x004DF9CC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F6F RID: 40815
		// (get) Token: 0x060237AA RID: 145322 RVA: 0x004E182C File Offset: 0x004DFA2C
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

		// Token: 0x17009F70 RID: 40816
		// (get) Token: 0x060237AB RID: 145323 RVA: 0x004E1858 File Offset: 0x004DFA58
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060237AC RID: 145324 RVA: 0x004E1894 File Offset: 0x004DFA94
		public static Offset<IElementalMatchActions> CreateIElementalMatchActions(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IElementalMatchActions.AddActions(builder, ActionsOffset);
			IElementalMatchActions.AddCondition(builder, ConditionOffset);
			IElementalMatchActions.AddNullMask(builder, NullMask);
			return IElementalMatchActions.EndIElementalMatchActions(builder);
		}

		// Token: 0x060237AD RID: 145325 RVA: 0x004E18B8 File Offset: 0x004DFAB8
		public static void StartIElementalMatchActions(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060237AE RID: 145326 RVA: 0x004E18C1 File Offset: 0x004DFAC1
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060237AF RID: 145327 RVA: 0x004E18D1 File Offset: 0x004DFAD1
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060237B0 RID: 145328 RVA: 0x004E18E4 File Offset: 0x004DFAE4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060237B1 RID: 145329 RVA: 0x004E1924 File Offset: 0x004DFB24
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060237B2 RID: 145330 RVA: 0x004E193E File Offset: 0x004DFB3E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060237B3 RID: 145331 RVA: 0x004E195C File Offset: 0x004DFB5C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060237B4 RID: 145332 RVA: 0x004E1975 File Offset: 0x004DFB75
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060237B5 RID: 145333 RVA: 0x004E1980 File Offset: 0x004DFB80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060237B6 RID: 145334 RVA: 0x004E198B File Offset: 0x004DFB8B
		public static Offset<IElementalMatchActions> EndIElementalMatchActions(FlatBufferBuilder builder)
		{
			return new Offset<IElementalMatchActions>(builder.EndTable());
		}

		// Token: 0x060237B7 RID: 145335 RVA: 0x004E1998 File Offset: 0x004DFB98
		public IElementalMatchActionsT UnPack()
		{
			IElementalMatchActionsT elementalMatchActionsT = new IElementalMatchActionsT();
			this.UnPackTo(elementalMatchActionsT);
			return elementalMatchActionsT;
		}

		// Token: 0x060237B8 RID: 145336 RVA: 0x004E19B4 File Offset: 0x004DFBB4
		public void UnPackTo(IElementalMatchActionsT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060237B9 RID: 145337 RVA: 0x004E1A50 File Offset: 0x004DFC50
		public static Offset<IElementalMatchActions> Pack(FlatBufferBuilder builder, IElementalMatchActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalMatchActions>);
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
				actionsOffset = IElementalMatchActions.CreateActionsVector(builder, array);
			}
			return IElementalMatchActions.CreateIElementalMatchActions(builder, conditionOffset, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400EDAF RID: 60847
		private Table __p;
	}
}
