using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F34 RID: 24372
	public class ISkyboxTrigger_UnionUnion
	{
		// Token: 0x1700B45E RID: 46174
		// (get) Token: 0x06028ED8 RID: 167640 RVA: 0x005975D1 File Offset: 0x005957D1
		// (set) Token: 0x06028ED9 RID: 167641 RVA: 0x005975D9 File Offset: 0x005957D9
		public ISkyboxTrigger_Union Type { get; set; }

		// Token: 0x1700B45F RID: 46175
		// (get) Token: 0x06028EDA RID: 167642 RVA: 0x005975E2 File Offset: 0x005957E2
		// (set) Token: 0x06028EDB RID: 167643 RVA: 0x005975EA File Offset: 0x005957EA
		public object Value { get; set; }

		// Token: 0x06028EDC RID: 167644 RVA: 0x005975F3 File Offset: 0x005957F3
		public ISkyboxTrigger_UnionUnion()
		{
			this.Type = ISkyboxTrigger_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028EDD RID: 167645 RVA: 0x00597609 File Offset: 0x00595809
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028EDE RID: 167646 RVA: 0x0059761B File Offset: 0x0059581B
		public ISkyboxTriggerT AsISkyboxTrigger()
		{
			return this.As<ISkyboxTriggerT>();
		}

		// Token: 0x06028EDF RID: 167647 RVA: 0x00597623 File Offset: 0x00595823
		public static ISkyboxTrigger_UnionUnion FromISkyboxTrigger(ISkyboxTriggerT _iskyboxtrigger)
		{
			return new ISkyboxTrigger_UnionUnion
			{
				Type = ISkyboxTrigger_Union.ISkyboxTrigger,
				Value = _iskyboxtrigger
			};
		}

		// Token: 0x06028EE0 RID: 167648 RVA: 0x00597638 File Offset: 0x00595838
		public ISkyboxDistanceTriggerT AsISkyboxDistanceTrigger()
		{
			return this.As<ISkyboxDistanceTriggerT>();
		}

		// Token: 0x06028EE1 RID: 167649 RVA: 0x00597640 File Offset: 0x00595840
		public static ISkyboxTrigger_UnionUnion FromISkyboxDistanceTrigger(ISkyboxDistanceTriggerT _iskyboxdistancetrigger)
		{
			return new ISkyboxTrigger_UnionUnion
			{
				Type = ISkyboxTrigger_Union.ISkyboxDistanceTrigger,
				Value = _iskyboxdistancetrigger
			};
		}

		// Token: 0x06028EE2 RID: 167650 RVA: 0x00597655 File Offset: 0x00595855
		public ISkyboxGlobalTriggerT AsISkyboxGlobalTrigger()
		{
			return this.As<ISkyboxGlobalTriggerT>();
		}

		// Token: 0x06028EE3 RID: 167651 RVA: 0x0059765D File Offset: 0x0059585D
		public static ISkyboxTrigger_UnionUnion FromISkyboxGlobalTrigger(ISkyboxGlobalTriggerT _iskyboxglobaltrigger)
		{
			return new ISkyboxTrigger_UnionUnion
			{
				Type = ISkyboxTrigger_Union.ISkyboxGlobalTrigger,
				Value = _iskyboxglobaltrigger
			};
		}

		// Token: 0x06028EE4 RID: 167652 RVA: 0x00597674 File Offset: 0x00595874
		public static int Pack(FlatBufferBuilder builder, ISkyboxTrigger_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISkyboxTrigger_Union.ISkyboxTrigger:
				return ISkyboxTrigger.Pack(builder, _o.AsISkyboxTrigger()).Value;
			case ISkyboxTrigger_Union.ISkyboxDistanceTrigger:
				return ISkyboxDistanceTrigger.Pack(builder, _o.AsISkyboxDistanceTrigger()).Value;
			case ISkyboxTrigger_Union.ISkyboxGlobalTrigger:
				return ISkyboxGlobalTrigger.Pack(builder, _o.AsISkyboxGlobalTrigger()).Value;
			default:
				return 0;
			}
		}
	}
}
