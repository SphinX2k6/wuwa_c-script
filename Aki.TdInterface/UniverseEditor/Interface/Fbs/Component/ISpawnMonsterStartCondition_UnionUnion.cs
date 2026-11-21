using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F73 RID: 24435
	public class ISpawnMonsterStartCondition_UnionUnion
	{
		// Token: 0x1700B4F6 RID: 46326
		// (get) Token: 0x06029133 RID: 168243 RVA: 0x0059C209 File Offset: 0x0059A409
		// (set) Token: 0x06029134 RID: 168244 RVA: 0x0059C211 File Offset: 0x0059A411
		public ISpawnMonsterStartCondition_Union Type { get; set; }

		// Token: 0x1700B4F7 RID: 46327
		// (get) Token: 0x06029135 RID: 168245 RVA: 0x0059C21A File Offset: 0x0059A41A
		// (set) Token: 0x06029136 RID: 168246 RVA: 0x0059C222 File Offset: 0x0059A422
		public object Value { get; set; }

		// Token: 0x06029137 RID: 168247 RVA: 0x0059C22B File Offset: 0x0059A42B
		public ISpawnMonsterStartCondition_UnionUnion()
		{
			this.Type = ISpawnMonsterStartCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029138 RID: 168248 RVA: 0x0059C241 File Offset: 0x0059A441
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029139 RID: 168249 RVA: 0x0059C253 File Offset: 0x0059A453
		public ISpawnMonsterStartConditionT AsISpawnMonsterStartCondition()
		{
			return this.As<ISpawnMonsterStartConditionT>();
		}

		// Token: 0x0602913A RID: 168250 RVA: 0x0059C25B File Offset: 0x0059A45B
		public static ISpawnMonsterStartCondition_UnionUnion FromISpawnMonsterStartCondition(ISpawnMonsterStartConditionT _ispawnmonsterstartcondition)
		{
			return new ISpawnMonsterStartCondition_UnionUnion
			{
				Type = ISpawnMonsterStartCondition_Union.ISpawnMonsterStartCondition,
				Value = _ispawnmonsterstartcondition
			};
		}

		// Token: 0x0602913B RID: 168251 RVA: 0x0059C270 File Offset: 0x0059A470
		public IImmediateStartConditionT AsIImmediateStartCondition()
		{
			return this.As<IImmediateStartConditionT>();
		}

		// Token: 0x0602913C RID: 168252 RVA: 0x0059C278 File Offset: 0x0059A478
		public static ISpawnMonsterStartCondition_UnionUnion FromIImmediateStartCondition(IImmediateStartConditionT _iimmediatestartcondition)
		{
			return new ISpawnMonsterStartCondition_UnionUnion
			{
				Type = ISpawnMonsterStartCondition_Union.IImmediateStartCondition,
				Value = _iimmediatestartcondition
			};
		}

		// Token: 0x0602913D RID: 168253 RVA: 0x0059C28D File Offset: 0x0059A48D
		public ITriggerRangeStartConditionT AsITriggerRangeStartCondition()
		{
			return this.As<ITriggerRangeStartConditionT>();
		}

		// Token: 0x0602913E RID: 168254 RVA: 0x0059C295 File Offset: 0x0059A495
		public static ISpawnMonsterStartCondition_UnionUnion FromITriggerRangeStartCondition(ITriggerRangeStartConditionT _itriggerrangestartcondition)
		{
			return new ISpawnMonsterStartCondition_UnionUnion
			{
				Type = ISpawnMonsterStartCondition_Union.ITriggerRangeStartCondition,
				Value = _itriggerrangestartcondition
			};
		}

		// Token: 0x0602913F RID: 168255 RVA: 0x0059C2AC File Offset: 0x0059A4AC
		public static int Pack(FlatBufferBuilder builder, ISpawnMonsterStartCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISpawnMonsterStartCondition_Union.ISpawnMonsterStartCondition:
				return ISpawnMonsterStartCondition.Pack(builder, _o.AsISpawnMonsterStartCondition()).Value;
			case ISpawnMonsterStartCondition_Union.IImmediateStartCondition:
				return IImmediateStartCondition.Pack(builder, _o.AsIImmediateStartCondition()).Value;
			case ISpawnMonsterStartCondition_Union.ITriggerRangeStartCondition:
				return ITriggerRangeStartCondition.Pack(builder, _o.AsITriggerRangeStartCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
