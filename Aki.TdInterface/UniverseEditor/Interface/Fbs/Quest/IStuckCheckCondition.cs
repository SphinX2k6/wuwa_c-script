using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200458C RID: 17804
	public struct IStuckCheckCondition : IFlatbufferObject
	{
		// Token: 0x17007C6E RID: 31854
		// (get) Token: 0x06019F1A RID: 106266 RVA: 0x003B3330 File Offset: 0x003B1530
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F1B RID: 106267 RVA: 0x003B333D File Offset: 0x003B153D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F1C RID: 106268 RVA: 0x003B3344 File Offset: 0x003B1544
		public static IStuckCheckCondition GetRootAsIStuckCheckCondition(ByteBuffer _bb)
		{
			return IStuckCheckCondition.GetRootAsIStuckCheckCondition(_bb, default(IStuckCheckCondition));
		}

		// Token: 0x06019F1D RID: 106269 RVA: 0x003B3360 File Offset: 0x003B1560
		public static IStuckCheckCondition GetRootAsIStuckCheckCondition(ByteBuffer _bb, IStuckCheckCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F1E RID: 106270 RVA: 0x003B337D File Offset: 0x003B157D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F1F RID: 106271 RVA: 0x003B338C File Offset: 0x003B158C
		public IStuckCheckCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019F20 RID: 106272 RVA: 0x003B339C File Offset: 0x003B159C
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C6F RID: 31855
		// (get) Token: 0x06019F21 RID: 106273 RVA: 0x003B33DC File Offset: 0x003B15DC
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

		// Token: 0x06019F22 RID: 106274 RVA: 0x003B3407 File Offset: 0x003B1607
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06019F23 RID: 106275 RVA: 0x003B3416 File Offset: 0x003B1616
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x17007C70 RID: 31856
		// (get) Token: 0x06019F24 RID: 106276 RVA: 0x003B3424 File Offset: 0x003B1624
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

		// Token: 0x17007C71 RID: 31857
		// (get) Token: 0x06019F25 RID: 106277 RVA: 0x003B3464 File Offset: 0x003B1664
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

		// Token: 0x17007C72 RID: 31858
		// (get) Token: 0x06019F26 RID: 106278 RVA: 0x003B34A0 File Offset: 0x003B16A0
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

		// Token: 0x06019F27 RID: 106279 RVA: 0x003B3500 File Offset: 0x003B1700
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007C73 RID: 31859
		// (get) Token: 0x06019F28 RID: 106280 RVA: 0x003B3564 File Offset: 0x003B1764
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

		// Token: 0x06019F29 RID: 106281 RVA: 0x003B3590 File Offset: 0x003B1790
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

		// Token: 0x06019F2A RID: 106282 RVA: 0x003B35C4 File Offset: 0x003B17C4
		public static void StartIStuckCheckCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06019F2B RID: 106283 RVA: 0x003B35CD File Offset: 0x003B17CD
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(0, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06019F2C RID: 106284 RVA: 0x003B35E0 File Offset: 0x003B17E0
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F2D RID: 106285 RVA: 0x003B3617 File Offset: 0x003B1817
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F2E RID: 106286 RVA: 0x003B3631 File Offset: 0x003B1831
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F2F RID: 106287 RVA: 0x003B364F File Offset: 0x003B184F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F30 RID: 106288 RVA: 0x003B3668 File Offset: 0x003B1868
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F31 RID: 106289 RVA: 0x003B3673 File Offset: 0x003B1873
		public static void AddTriggerInterval(FlatBufferBuilder builder, float triggerInterval)
		{
			builder.AddFloat(1, triggerInterval, 0.0);
		}

		// Token: 0x06019F32 RID: 106290 RVA: 0x003B3686 File Offset: 0x003B1886
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(2, maxTriggerTimes, 0);
		}

		// Token: 0x06019F33 RID: 106291 RVA: 0x003B3691 File Offset: 0x003B1891
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(3, conditionOffset.Value, 0);
		}

		// Token: 0x06019F34 RID: 106292 RVA: 0x003B36A1 File Offset: 0x003B18A1
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(4, actionsOffset.Value, 0);
		}

		// Token: 0x06019F35 RID: 106293 RVA: 0x003B36B4 File Offset: 0x003B18B4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F36 RID: 106294 RVA: 0x003B36F4 File Offset: 0x003B18F4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F37 RID: 106295 RVA: 0x003B370E File Offset: 0x003B190E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F38 RID: 106296 RVA: 0x003B372C File Offset: 0x003B192C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F39 RID: 106297 RVA: 0x003B3745 File Offset: 0x003B1945
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F3A RID: 106298 RVA: 0x003B3750 File Offset: 0x003B1950
		public static Offset<IStuckCheckCondition> EndIStuckCheckCondition(FlatBufferBuilder builder)
		{
			return new Offset<IStuckCheckCondition>(builder.EndTable());
		}

		// Token: 0x06019F3B RID: 106299 RVA: 0x003B3760 File Offset: 0x003B1960
		public IStuckCheckConditionT UnPack()
		{
			IStuckCheckConditionT stuckCheckConditionT = new IStuckCheckConditionT();
			this.UnPackTo(stuckCheckConditionT);
			return stuckCheckConditionT;
		}

		// Token: 0x06019F3C RID: 106300 RVA: 0x003B377C File Offset: 0x003B197C
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

		// Token: 0x06019F3D RID: 106301 RVA: 0x003B3854 File Offset: 0x003B1A54
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

		// Token: 0x0400C745 RID: 51013
		private Table __p;
	}
}
