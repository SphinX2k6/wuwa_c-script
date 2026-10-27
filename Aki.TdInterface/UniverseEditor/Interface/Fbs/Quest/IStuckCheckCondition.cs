using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004148 RID: 16712
	public struct IStuckCheckCondition : IFlatbufferObject
	{
		// Token: 0x1700765F RID: 30303
		// (get) Token: 0x06018852 RID: 100434 RVA: 0x00388D74 File Offset: 0x00386F74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018853 RID: 100435 RVA: 0x00388D81 File Offset: 0x00386F81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018854 RID: 100436 RVA: 0x00388D88 File Offset: 0x00386F88
		public static IStuckCheckCondition GetRootAsIStuckCheckCondition(ByteBuffer _bb)
		{
			return IStuckCheckCondition.GetRootAsIStuckCheckCondition(_bb, default(IStuckCheckCondition));
		}

		// Token: 0x06018855 RID: 100437 RVA: 0x00388DA4 File Offset: 0x00386FA4
		public static IStuckCheckCondition GetRootAsIStuckCheckCondition(ByteBuffer _bb, IStuckCheckCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018856 RID: 100438 RVA: 0x00388DC1 File Offset: 0x00386FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018857 RID: 100439 RVA: 0x00388DD0 File Offset: 0x00386FD0
		public IStuckCheckCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018858 RID: 100440 RVA: 0x00388DE0 File Offset: 0x00386FE0
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007660 RID: 30304
		// (get) Token: 0x06018859 RID: 100441 RVA: 0x00388E20 File Offset: 0x00387020
		public int RangeEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601885A RID: 100442 RVA: 0x00388E4B File Offset: 0x0038704B
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601885B RID: 100443 RVA: 0x00388E5A File Offset: 0x0038705A
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x17007661 RID: 30305
		// (get) Token: 0x0601885C RID: 100444 RVA: 0x00388E68 File Offset: 0x00387068
		public float TriggerInterval
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007662 RID: 30306
		// (get) Token: 0x0601885D RID: 100445 RVA: 0x00388EA8 File Offset: 0x003870A8
		public int MaxTriggerTimes
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007663 RID: 30307
		// (get) Token: 0x0601885E RID: 100446 RVA: 0x00388EE4 File Offset: 0x003870E4
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

		// Token: 0x0601885F RID: 100447 RVA: 0x00388F44 File Offset: 0x00387144
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007664 RID: 30308
		// (get) Token: 0x06018860 RID: 100448 RVA: 0x00388FA8 File Offset: 0x003871A8
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018861 RID: 100449 RVA: 0x00388FD4 File Offset: 0x003871D4
		public static Offset<IStuckCheckCondition> CreateIStuckCheckCondition(FlatBufferBuilder builder, VectorOffset RangeEntitiesOffset = default(VectorOffset), float TriggerInterval = 0f, int MaxTriggerTimes = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IStuckCheckCondition.AddActions(builder, ActionsOffset);
			IStuckCheckCondition.AddCondition(builder, ConditionOffset);
			IStuckCheckCondition.AddMaxTriggerTimes(builder, MaxTriggerTimes);
			IStuckCheckCondition.AddTriggerInterval(builder, TriggerInterval);
			IStuckCheckCondition.AddRangeEntities(builder, RangeEntitiesOffset);
			return IStuckCheckCondition.EndIStuckCheckCondition(builder);
		}

		// Token: 0x06018862 RID: 100450 RVA: 0x00389008 File Offset: 0x00387208
		public static void StartIStuckCheckCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018863 RID: 100451 RVA: 0x00389011 File Offset: 0x00387211
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(0, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06018864 RID: 100452 RVA: 0x00389024 File Offset: 0x00387224
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018865 RID: 100453 RVA: 0x0038905B File Offset: 0x0038725B
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018866 RID: 100454 RVA: 0x00389075 File Offset: 0x00387275
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018867 RID: 100455 RVA: 0x00389093 File Offset: 0x00387293
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018868 RID: 100456 RVA: 0x003890AC File Offset: 0x003872AC
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018869 RID: 100457 RVA: 0x003890B7 File Offset: 0x003872B7
		public static void AddTriggerInterval(FlatBufferBuilder builder, float triggerInterval)
		{
			builder.AddFloat(1, triggerInterval, 0.0);
		}

		// Token: 0x0601886A RID: 100458 RVA: 0x003890CA File Offset: 0x003872CA
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(2, maxTriggerTimes, 0);
		}

		// Token: 0x0601886B RID: 100459 RVA: 0x003890D5 File Offset: 0x003872D5
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(3, conditionOffset.Value, 0);
		}

		// Token: 0x0601886C RID: 100460 RVA: 0x003890E5 File Offset: 0x003872E5
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(4, actionsOffset.Value, 0);
		}

		// Token: 0x0601886D RID: 100461 RVA: 0x003890F8 File Offset: 0x003872F8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601886E RID: 100462 RVA: 0x00389138 File Offset: 0x00387338
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601886F RID: 100463 RVA: 0x00389152 File Offset: 0x00387352
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018870 RID: 100464 RVA: 0x00389170 File Offset: 0x00387370
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018871 RID: 100465 RVA: 0x00389189 File Offset: 0x00387389
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018872 RID: 100466 RVA: 0x00389194 File Offset: 0x00387394
		public static Offset<IStuckCheckCondition> EndIStuckCheckCondition(FlatBufferBuilder builder)
		{
			return new Offset<IStuckCheckCondition>(builder.EndTable());
		}

		// Token: 0x06018873 RID: 100467 RVA: 0x003891A4 File Offset: 0x003873A4
		public IStuckCheckConditionT UnPack()
		{
			IStuckCheckConditionT stuckCheckConditionT = new IStuckCheckConditionT();
			this.UnPackTo(stuckCheckConditionT);
			return stuckCheckConditionT;
		}

		// Token: 0x06018874 RID: 100468 RVA: 0x003891C0 File Offset: 0x003873C0
		public void UnPackTo(IStuckCheckConditionT _o)
		{
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.TriggerInterval = this.TriggerInterval;
			_o.MaxTriggerTimes = this.MaxTriggerTimes;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int j = 0; j < this.ActionsLength; j++)
			{
				_o.Actions.Add((this.Actions(j) != null) ? this.Actions(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06018875 RID: 100469 RVA: 0x00389298 File Offset: 0x00387498
		public static Offset<IStuckCheckCondition> Pack(FlatBufferBuilder builder, IStuckCheckConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStuckCheckCondition>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IStuckCheckCondition.CreateRangeEntitiesVector(builder, data);
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
				actionsOffset = IStuckCheckCondition.CreateActionsVector(builder, array);
			}
			return IStuckCheckCondition.CreateIStuckCheckCondition(builder, rangeEntitiesOffset, _o.TriggerInterval, _o.MaxTriggerTimes, conditionOffset, actionsOffset);
		}

		// Token: 0x0400BD57 RID: 48471
		private Table __p;
	}
}
