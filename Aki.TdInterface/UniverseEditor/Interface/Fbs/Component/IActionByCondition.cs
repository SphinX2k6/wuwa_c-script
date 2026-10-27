using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E41 RID: 20033
	public struct IActionByCondition : IFlatbufferObject
	{
		// Token: 0x17008F5D RID: 36701
		// (get) Token: 0x0601F6E4 RID: 128740 RVA: 0x00460E28 File Offset: 0x0045F028
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F6E5 RID: 128741 RVA: 0x00460E35 File Offset: 0x0045F035
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F6E6 RID: 128742 RVA: 0x00460E3C File Offset: 0x0045F03C
		public static IActionByCondition GetRootAsIActionByCondition(ByteBuffer _bb)
		{
			return IActionByCondition.GetRootAsIActionByCondition(_bb, default(IActionByCondition));
		}

		// Token: 0x0601F6E7 RID: 128743 RVA: 0x00460E58 File Offset: 0x0045F058
		public static IActionByCondition GetRootAsIActionByCondition(ByteBuffer _bb, IActionByCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F6E8 RID: 128744 RVA: 0x00460E75 File Offset: 0x0045F075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F6E9 RID: 128745 RVA: 0x00460E84 File Offset: 0x0045F084
		public IActionByCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F5E RID: 36702
		// (get) Token: 0x0601F6EA RID: 128746 RVA: 0x00460E94 File Offset: 0x0045F094
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

		// Token: 0x0601F6EB RID: 128747 RVA: 0x00460EF4 File Offset: 0x0045F0F4
		public IActionInfo? ActiveActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008F5F RID: 36703
		// (get) Token: 0x0601F6EC RID: 128748 RVA: 0x00460F54 File Offset: 0x0045F154
		public int ActiveActionsLength
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

		// Token: 0x0601F6ED RID: 128749 RVA: 0x00460F7F File Offset: 0x0045F17F
		public static Offset<IActionByCondition> CreateIActionByCondition(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActiveActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IActionByCondition.AddActiveActions(builder, ActiveActionsOffset);
			IActionByCondition.AddCondition(builder, ConditionOffset);
			return IActionByCondition.EndIActionByCondition(builder);
		}

		// Token: 0x0601F6EE RID: 128750 RVA: 0x00460F9C File Offset: 0x0045F19C
		public static void StartIActionByCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F6EF RID: 128751 RVA: 0x00460FA5 File Offset: 0x0045F1A5
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x0601F6F0 RID: 128752 RVA: 0x00460FB5 File Offset: 0x0045F1B5
		public static void AddActiveActions(FlatBufferBuilder builder, VectorOffset activeActionsOffset)
		{
			builder.AddOffset(1, activeActionsOffset.Value, 0);
		}

		// Token: 0x0601F6F1 RID: 128753 RVA: 0x00460FC8 File Offset: 0x0045F1C8
		public static VectorOffset CreateActiveActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F6F2 RID: 128754 RVA: 0x00461008 File Offset: 0x0045F208
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F6F3 RID: 128755 RVA: 0x00461022 File Offset: 0x0045F222
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F6F4 RID: 128756 RVA: 0x00461040 File Offset: 0x0045F240
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F6F5 RID: 128757 RVA: 0x00461059 File Offset: 0x0045F259
		public static void StartActiveActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F6F6 RID: 128758 RVA: 0x00461064 File Offset: 0x0045F264
		public static Offset<IActionByCondition> EndIActionByCondition(FlatBufferBuilder builder)
		{
			return new Offset<IActionByCondition>(builder.EndTable());
		}

		// Token: 0x0601F6F7 RID: 128759 RVA: 0x00461074 File Offset: 0x0045F274
		public IActionByConditionT UnPack()
		{
			IActionByConditionT actionByConditionT = new IActionByConditionT();
			this.UnPackTo(actionByConditionT);
			return actionByConditionT;
		}

		// Token: 0x0601F6F8 RID: 128760 RVA: 0x00461090 File Offset: 0x0045F290
		public void UnPackTo(IActionByConditionT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.ActiveActions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActiveActionsLength; i++)
			{
				_o.ActiveActions.Add((this.ActiveActions(i) != null) ? this.ActiveActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601F6F9 RID: 128761 RVA: 0x00461120 File Offset: 0x0045F320
		public static Offset<IActionByCondition> Pack(FlatBufferBuilder builder, IActionByConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionByCondition>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset activeActionsOffset = default(VectorOffset);
			if (_o.ActiveActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActiveActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActiveActions[i]);
				}
				activeActionsOffset = IActionByCondition.CreateActiveActionsVector(builder, array);
			}
			return IActionByCondition.CreateIActionByCondition(builder, conditionOffset, activeActionsOffset);
		}

		// Token: 0x0400DBDB RID: 56283
		private Table __p;
	}
}
