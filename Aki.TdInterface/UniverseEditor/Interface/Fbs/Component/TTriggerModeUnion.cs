using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCA RID: 23754
	public class TTriggerModeUnion
	{
		// Token: 0x1700B264 RID: 45668
		// (get) Token: 0x06028A7B RID: 166523 RVA: 0x00595ECA File Offset: 0x005940CA
		// (set) Token: 0x06028A7C RID: 166524 RVA: 0x00595ED2 File Offset: 0x005940D2
		public TTriggerMode Type { get; set; }

		// Token: 0x1700B265 RID: 45669
		// (get) Token: 0x06028A7D RID: 166525 RVA: 0x00595EDB File Offset: 0x005940DB
		// (set) Token: 0x06028A7E RID: 166526 RVA: 0x00595EE3 File Offset: 0x005940E3
		public object Value { get; set; }

		// Token: 0x06028A7F RID: 166527 RVA: 0x00595EEC File Offset: 0x005940EC
		public TTriggerModeUnion()
		{
			this.Type = TTriggerMode.NONE;
			this.Value = null;
		}

		// Token: 0x06028A80 RID: 166528 RVA: 0x00595F02 File Offset: 0x00594102
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A81 RID: 166529 RVA: 0x00595F14 File Offset: 0x00594114
		public ISkyboxDistanceTriggerT AsISkyboxDistanceTrigger()
		{
			return this.As<ISkyboxDistanceTriggerT>();
		}

		// Token: 0x06028A82 RID: 166530 RVA: 0x00595F1C File Offset: 0x0059411C
		public static TTriggerModeUnion FromISkyboxDistanceTrigger(ISkyboxDistanceTriggerT _iskyboxdistancetrigger)
		{
			return new TTriggerModeUnion
			{
				Type = TTriggerMode.ISkyboxDistanceTrigger,
				Value = _iskyboxdistancetrigger
			};
		}

		// Token: 0x06028A83 RID: 166531 RVA: 0x00595F31 File Offset: 0x00594131
		public ISkyboxGlobalTriggerT AsISkyboxGlobalTrigger()
		{
			return this.As<ISkyboxGlobalTriggerT>();
		}

		// Token: 0x06028A84 RID: 166532 RVA: 0x00595F39 File Offset: 0x00594139
		public static TTriggerModeUnion FromISkyboxGlobalTrigger(ISkyboxGlobalTriggerT _iskyboxglobaltrigger)
		{
			return new TTriggerModeUnion
			{
				Type = TTriggerMode.ISkyboxGlobalTrigger,
				Value = _iskyboxglobaltrigger
			};
		}

		// Token: 0x06028A85 RID: 166533 RVA: 0x00595F50 File Offset: 0x00594150
		public static int Pack(FlatBufferBuilder builder, TTriggerModeUnion _o)
		{
			TTriggerMode type = _o.Type;
			if (type == TTriggerMode.ISkyboxDistanceTrigger)
			{
				return ISkyboxDistanceTrigger.Pack(builder, _o.AsISkyboxDistanceTrigger()).Value;
			}
			if (type != TTriggerMode.ISkyboxGlobalTrigger)
			{
				return 0;
			}
			return ISkyboxGlobalTrigger.Pack(builder, _o.AsISkyboxGlobalTrigger()).Value;
		}
	}
}
