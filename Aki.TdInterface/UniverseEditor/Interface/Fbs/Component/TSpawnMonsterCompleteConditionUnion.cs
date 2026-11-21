using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062D7 RID: 25303
	public class TSpawnMonsterCompleteConditionUnion
	{
		// Token: 0x1700BBA6 RID: 48038
		// (get) Token: 0x0602B00B RID: 176139 RVA: 0x005DD4FA File Offset: 0x005DB6FA
		// (set) Token: 0x0602B00C RID: 176140 RVA: 0x005DD502 File Offset: 0x005DB702
		public TSpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x1700BBA7 RID: 48039
		// (get) Token: 0x0602B00D RID: 176141 RVA: 0x005DD50B File Offset: 0x005DB70B
		// (set) Token: 0x0602B00E RID: 176142 RVA: 0x005DD513 File Offset: 0x005DB713
		public object Value { get; set; }

		// Token: 0x0602B00F RID: 176143 RVA: 0x005DD51C File Offset: 0x005DB71C
		public TSpawnMonsterCompleteConditionUnion()
		{
			this.Type = TSpawnMonsterCompleteCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602B010 RID: 176144 RVA: 0x005DD532 File Offset: 0x005DB732
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B011 RID: 176145 RVA: 0x005DD544 File Offset: 0x005DB744
		public IAllKillConditionT AsIAllKillCondition()
		{
			return this.As<IAllKillConditionT>();
		}

		// Token: 0x0602B012 RID: 176146 RVA: 0x005DD54C File Offset: 0x005DB74C
		public static TSpawnMonsterCompleteConditionUnion FromIAllKillCondition(IAllKillConditionT _iallkillcondition)
		{
			return new TSpawnMonsterCompleteConditionUnion
			{
				Type = TSpawnMonsterCompleteCondition.IAllKillCondition,
				Value = _iallkillcondition
			};
		}

		// Token: 0x0602B013 RID: 176147 RVA: 0x005DD561 File Offset: 0x005DB761
		public IDurationConditionT AsIDurationCondition()
		{
			return this.As<IDurationConditionT>();
		}

		// Token: 0x0602B014 RID: 176148 RVA: 0x005DD569 File Offset: 0x005DB769
		public static TSpawnMonsterCompleteConditionUnion FromIDurationCondition(IDurationConditionT _idurationcondition)
		{
			return new TSpawnMonsterCompleteConditionUnion
			{
				Type = TSpawnMonsterCompleteCondition.IDurationCondition,
				Value = _idurationcondition
			};
		}

		// Token: 0x0602B015 RID: 176149 RVA: 0x005DD57E File Offset: 0x005DB77E
		public IQuantityRefillConditionT AsIQuantityRefillCondition()
		{
			return this.As<IQuantityRefillConditionT>();
		}

		// Token: 0x0602B016 RID: 176150 RVA: 0x005DD586 File Offset: 0x005DB786
		public static TSpawnMonsterCompleteConditionUnion FromIQuantityRefillCondition(IQuantityRefillConditionT _iquantityrefillcondition)
		{
			return new TSpawnMonsterCompleteConditionUnion
			{
				Type = TSpawnMonsterCompleteCondition.IQuantityRefillCondition,
				Value = _iquantityrefillcondition
			};
		}

		// Token: 0x0602B017 RID: 176151 RVA: 0x005DD59C File Offset: 0x005DB79C
		public static int Pack(FlatBufferBuilder builder, TSpawnMonsterCompleteConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TSpawnMonsterCompleteCondition.IAllKillCondition:
				return IAllKillCondition.Pack(builder, _o.AsIAllKillCondition()).Value;
			case TSpawnMonsterCompleteCondition.IDurationCondition:
				return IDurationCondition.Pack(builder, _o.AsIDurationCondition()).Value;
			case TSpawnMonsterCompleteCondition.IQuantityRefillCondition:
				return IQuantityRefillCondition.Pack(builder, _o.AsIQuantityRefillCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
