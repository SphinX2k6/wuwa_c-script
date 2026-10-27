using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005927 RID: 22823
	public class ISkyboxTrigger_UnionUnion
	{
		// Token: 0x1700AB2A RID: 43818
		// (get) Token: 0x0602696E RID: 158062 RVA: 0x00550965 File Offset: 0x0054EB65
		// (set) Token: 0x0602696F RID: 158063 RVA: 0x0055096D File Offset: 0x0054EB6D
		public ISkyboxTrigger_Union Type { get; set; }

		// Token: 0x1700AB2B RID: 43819
		// (get) Token: 0x06026970 RID: 158064 RVA: 0x00550976 File Offset: 0x0054EB76
		// (set) Token: 0x06026971 RID: 158065 RVA: 0x0055097E File Offset: 0x0054EB7E
		public object Value { get; set; }

		// Token: 0x06026972 RID: 158066 RVA: 0x00550987 File Offset: 0x0054EB87
		public ISkyboxTrigger_UnionUnion()
		{
			this.Type = ISkyboxTrigger_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026973 RID: 158067 RVA: 0x0055099D File Offset: 0x0054EB9D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026974 RID: 158068 RVA: 0x005509AF File Offset: 0x0054EBAF
		public ISkyboxTriggerT AsISkyboxTrigger()
		{
			return this.As<ISkyboxTriggerT>();
		}

		// Token: 0x06026975 RID: 158069 RVA: 0x005509B7 File Offset: 0x0054EBB7
		public static ISkyboxTrigger_UnionUnion FromISkyboxTrigger(ISkyboxTriggerT _iskyboxtrigger)
		{
			return new ISkyboxTrigger_UnionUnion
			{
				Type = ISkyboxTrigger_Union.ISkyboxTrigger,
				Value = _iskyboxtrigger
			};
		}

		// Token: 0x06026976 RID: 158070 RVA: 0x005509CC File Offset: 0x0054EBCC
		public ISkyboxDistanceTriggerT AsISkyboxDistanceTrigger()
		{
			return this.As<ISkyboxDistanceTriggerT>();
		}

		// Token: 0x06026977 RID: 158071 RVA: 0x005509D4 File Offset: 0x0054EBD4
		public static ISkyboxTrigger_UnionUnion FromISkyboxDistanceTrigger(ISkyboxDistanceTriggerT _iskyboxdistancetrigger)
		{
			return new ISkyboxTrigger_UnionUnion
			{
				Type = ISkyboxTrigger_Union.ISkyboxDistanceTrigger,
				Value = _iskyboxdistancetrigger
			};
		}

		// Token: 0x06026978 RID: 158072 RVA: 0x005509E9 File Offset: 0x0054EBE9
		public ISkyboxGlobalTriggerT AsISkyboxGlobalTrigger()
		{
			return this.As<ISkyboxGlobalTriggerT>();
		}

		// Token: 0x06026979 RID: 158073 RVA: 0x005509F1 File Offset: 0x0054EBF1
		public static ISkyboxTrigger_UnionUnion FromISkyboxGlobalTrigger(ISkyboxGlobalTriggerT _iskyboxglobaltrigger)
		{
			return new ISkyboxTrigger_UnionUnion
			{
				Type = ISkyboxTrigger_Union.ISkyboxGlobalTrigger,
				Value = _iskyboxglobaltrigger
			};
		}

		// Token: 0x0602697A RID: 158074 RVA: 0x00550A08 File Offset: 0x0054EC08
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
