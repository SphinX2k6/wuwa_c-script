using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F2 RID: 17138
	public struct IInitConditionActions : IFlatbufferObject
	{
		// Token: 0x17007555 RID: 30037
		// (get) Token: 0x06018102 RID: 98562 RVA: 0x0036EDE2 File Offset: 0x0036CFE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018103 RID: 98563 RVA: 0x0036EDEF File Offset: 0x0036CFEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018104 RID: 98564 RVA: 0x0036EDF8 File Offset: 0x0036CFF8
		public static IInitConditionActions GetRootAsIInitConditionActions(ByteBuffer _bb)
		{
			return IInitConditionActions.GetRootAsIInitConditionActions(_bb, default(IInitConditionActions));
		}

		// Token: 0x06018105 RID: 98565 RVA: 0x0036EE14 File Offset: 0x0036D014
		public static IInitConditionActions GetRootAsIInitConditionActions(ByteBuffer _bb, IInitConditionActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018106 RID: 98566 RVA: 0x0036EE31 File Offset: 0x0036D031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018107 RID: 98567 RVA: 0x0036EE40 File Offset: 0x0036D040
		public IInitConditionActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007556 RID: 30038
		// (get) Token: 0x06018108 RID: 98568 RVA: 0x0036EE50 File Offset: 0x0036D050
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

		// Token: 0x06018109 RID: 98569 RVA: 0x0036EEB0 File Offset: 0x0036D0B0
		public IActionInfo? Action(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007557 RID: 30039
		// (get) Token: 0x0601810A RID: 98570 RVA: 0x0036EF10 File Offset: 0x0036D110
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

		// Token: 0x0601810B RID: 98571 RVA: 0x0036EF3B File Offset: 0x0036D13B
		public static Offset<IInitConditionActions> CreateIInitConditionActions(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInitConditionActions.AddAction(builder, ActionOffset);
			IInitConditionActions.AddCondition(builder, ConditionOffset);
			return IInitConditionActions.EndIInitConditionActions(builder);
		}

		// Token: 0x0601810C RID: 98572 RVA: 0x0036EF58 File Offset: 0x0036D158
		public static void StartIInitConditionActions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601810D RID: 98573 RVA: 0x0036EF61 File Offset: 0x0036D161
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x0601810E RID: 98574 RVA: 0x0036EF71 File Offset: 0x0036D171
		public static void AddAction(FlatBufferBuilder builder, VectorOffset actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x0601810F RID: 98575 RVA: 0x0036EF84 File Offset: 0x0036D184
		public static VectorOffset CreateActionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018110 RID: 98576 RVA: 0x0036EFC4 File Offset: 0x0036D1C4
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018111 RID: 98577 RVA: 0x0036EFDE File Offset: 0x0036D1DE
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018112 RID: 98578 RVA: 0x0036EFFC File Offset: 0x0036D1FC
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018113 RID: 98579 RVA: 0x0036F015 File Offset: 0x0036D215
		public static void StartActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018114 RID: 98580 RVA: 0x0036F020 File Offset: 0x0036D220
		public static Offset<IInitConditionActions> EndIInitConditionActions(FlatBufferBuilder builder)
		{
			return new Offset<IInitConditionActions>(builder.EndTable());
		}

		// Token: 0x06018115 RID: 98581 RVA: 0x0036F030 File Offset: 0x0036D230
		public IInitConditionActionsT UnPack()
		{
			IInitConditionActionsT initConditionActionsT = new IInitConditionActionsT();
			this.UnPackTo(initConditionActionsT);
			return initConditionActionsT;
		}

		// Token: 0x06018116 RID: 98582 RVA: 0x0036F04C File Offset: 0x0036D24C
		public void UnPackTo(IInitConditionActionsT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Action = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionLength; i++)
			{
				_o.Action.Add((this.Action(i) != null) ? this.Action(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018117 RID: 98583 RVA: 0x0036F0DC File Offset: 0x0036D2DC
		public static Offset<IInitConditionActions> Pack(FlatBufferBuilder builder, IInitConditionActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitConditionActions>);
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
				actionOffset = IInitConditionActions.CreateActionVector(builder, array);
			}
			return IInitConditionActions.CreateIInitConditionActions(builder, conditionOffset, actionOffset);
		}

		// Token: 0x0400C260 RID: 49760
		private Table __p;
	}
}
