using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062DA RID: 25306
	public class TSpawnMonsterStartConditionUnion
	{
		// Token: 0x1700BBA8 RID: 48040
		// (get) Token: 0x0602B019 RID: 176153 RVA: 0x005DD644 File Offset: 0x005DB844
		// (set) Token: 0x0602B01A RID: 176154 RVA: 0x005DD64C File Offset: 0x005DB84C
		public TSpawnMonsterStartCondition Type { get; set; }

		// Token: 0x1700BBA9 RID: 48041
		// (get) Token: 0x0602B01B RID: 176155 RVA: 0x005DD655 File Offset: 0x005DB855
		// (set) Token: 0x0602B01C RID: 176156 RVA: 0x005DD65D File Offset: 0x005DB85D
		public object Value { get; set; }

		// Token: 0x0602B01D RID: 176157 RVA: 0x005DD666 File Offset: 0x005DB866
		public TSpawnMonsterStartConditionUnion()
		{
			this.Type = TSpawnMonsterStartCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602B01E RID: 176158 RVA: 0x005DD67C File Offset: 0x005DB87C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B01F RID: 176159 RVA: 0x005DD68E File Offset: 0x005DB88E
		public IImmediateStartConditionT AsIImmediateStartCondition()
		{
			return this.As<IImmediateStartConditionT>();
		}

		// Token: 0x0602B020 RID: 176160 RVA: 0x005DD696 File Offset: 0x005DB896
		public static TSpawnMonsterStartConditionUnion FromIImmediateStartCondition(IImmediateStartConditionT _iimmediatestartcondition)
		{
			return new TSpawnMonsterStartConditionUnion
			{
				Type = TSpawnMonsterStartCondition.IImmediateStartCondition,
				Value = _iimmediatestartcondition
			};
		}

		// Token: 0x0602B021 RID: 176161 RVA: 0x005DD6AB File Offset: 0x005DB8AB
		public ITriggerRangeStartConditionT AsITriggerRangeStartCondition()
		{
			return this.As<ITriggerRangeStartConditionT>();
		}

		// Token: 0x0602B022 RID: 176162 RVA: 0x005DD6B3 File Offset: 0x005DB8B3
		public static TSpawnMonsterStartConditionUnion FromITriggerRangeStartCondition(ITriggerRangeStartConditionT _itriggerrangestartcondition)
		{
			return new TSpawnMonsterStartConditionUnion
			{
				Type = TSpawnMonsterStartCondition.ITriggerRangeStartCondition,
				Value = _itriggerrangestartcondition
			};
		}

		// Token: 0x0602B023 RID: 176163 RVA: 0x005DD6C8 File Offset: 0x005DB8C8
		public static int Pack(FlatBufferBuilder builder, TSpawnMonsterStartConditionUnion _o)
		{
			TSpawnMonsterStartCondition type = _o.Type;
			if (type == TSpawnMonsterStartCondition.IImmediateStartCondition)
			{
				return IImmediateStartCondition.Pack(builder, _o.AsIImmediateStartCondition()).Value;
			}
			if (type != TSpawnMonsterStartCondition.ITriggerRangeStartCondition)
			{
				return 0;
			}
			return ITriggerRangeStartCondition.Pack(builder, _o.AsITriggerRangeStartCondition()).Value;
		}
	}
}
