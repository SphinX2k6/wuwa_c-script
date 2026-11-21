using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005541 RID: 21825
	public struct IConditionAction : IFlatbufferObject
	{
		// Token: 0x17009C09 RID: 39945
		// (get) Token: 0x060229F1 RID: 141809 RVA: 0x004C4BDF File Offset: 0x004C2DDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060229F2 RID: 141810 RVA: 0x004C4BEC File Offset: 0x004C2DEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060229F3 RID: 141811 RVA: 0x004C4BF4 File Offset: 0x004C2DF4
		public static IConditionAction GetRootAsIConditionAction(ByteBuffer _bb)
		{
			return IConditionAction.GetRootAsIConditionAction(_bb, default(IConditionAction));
		}

		// Token: 0x060229F4 RID: 141812 RVA: 0x004C4C10 File Offset: 0x004C2E10
		public static IConditionAction GetRootAsIConditionAction(ByteBuffer _bb, IConditionAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060229F5 RID: 141813 RVA: 0x004C4C2D File Offset: 0x004C2E2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060229F6 RID: 141814 RVA: 0x004C4C3C File Offset: 0x004C2E3C
		public IConditionAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C0A RID: 39946
		// (get) Token: 0x060229F7 RID: 141815 RVA: 0x004C4C4C File Offset: 0x004C2E4C
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

		// Token: 0x060229F8 RID: 141816 RVA: 0x004C4CAC File Offset: 0x004C2EAC
		public IActionInfo? Action(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C0B RID: 39947
		// (get) Token: 0x060229F9 RID: 141817 RVA: 0x004C4D0C File Offset: 0x004C2F0C
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

		// Token: 0x060229FA RID: 141818 RVA: 0x004C4D37 File Offset: 0x004C2F37
		public static Offset<IConditionAction> CreateIConditionAction(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditionAction.AddAction(builder, ActionOffset);
			IConditionAction.AddCondition(builder, ConditionOffset);
			return IConditionAction.EndIConditionAction(builder);
		}

		// Token: 0x060229FB RID: 141819 RVA: 0x004C4D54 File Offset: 0x004C2F54
		public static void StartIConditionAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060229FC RID: 141820 RVA: 0x004C4D5D File Offset: 0x004C2F5D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060229FD RID: 141821 RVA: 0x004C4D6D File Offset: 0x004C2F6D
		public static void AddAction(FlatBufferBuilder builder, VectorOffset actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x060229FE RID: 141822 RVA: 0x004C4D80 File Offset: 0x004C2F80
		public static VectorOffset CreateActionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060229FF RID: 141823 RVA: 0x004C4DC0 File Offset: 0x004C2FC0
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022A00 RID: 141824 RVA: 0x004C4DDA File Offset: 0x004C2FDA
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022A01 RID: 141825 RVA: 0x004C4DF8 File Offset: 0x004C2FF8
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022A02 RID: 141826 RVA: 0x004C4E11 File Offset: 0x004C3011
		public static void StartActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022A03 RID: 141827 RVA: 0x004C4E1C File Offset: 0x004C301C
		public static Offset<IConditionAction> EndIConditionAction(FlatBufferBuilder builder)
		{
			return new Offset<IConditionAction>(builder.EndTable());
		}

		// Token: 0x06022A04 RID: 141828 RVA: 0x004C4E2C File Offset: 0x004C302C
		public IConditionActionT UnPack()
		{
			IConditionActionT conditionActionT = new IConditionActionT();
			this.UnPackTo(conditionActionT);
			return conditionActionT;
		}

		// Token: 0x06022A05 RID: 141829 RVA: 0x004C4E48 File Offset: 0x004C3048
		public void UnPackTo(IConditionActionT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Action = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionLength; i++)
			{
				_o.Action.Add((this.Action(i) != null) ? this.Action(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06022A06 RID: 141830 RVA: 0x004C4ED8 File Offset: 0x004C30D8
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

		// Token: 0x0400EB90 RID: 60304
		private Table __p;
	}
}
