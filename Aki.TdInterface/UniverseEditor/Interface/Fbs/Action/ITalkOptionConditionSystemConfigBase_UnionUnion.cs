using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B04 RID: 31492
	public class ITalkOptionConditionSystemConfigBase_UnionUnion
	{
		// Token: 0x1700EBF5 RID: 60405
		// (get) Token: 0x06038B53 RID: 232275 RVA: 0x007ABEC1 File Offset: 0x007AA0C1
		// (set) Token: 0x06038B54 RID: 232276 RVA: 0x007ABEC9 File Offset: 0x007AA0C9
		public ITalkOptionConditionSystemConfigBase_Union Type { get; set; }

		// Token: 0x1700EBF6 RID: 60406
		// (get) Token: 0x06038B55 RID: 232277 RVA: 0x007ABED2 File Offset: 0x007AA0D2
		// (set) Token: 0x06038B56 RID: 232278 RVA: 0x007ABEDA File Offset: 0x007AA0DA
		public object Value { get; set; }

		// Token: 0x06038B57 RID: 232279 RVA: 0x007ABEE3 File Offset: 0x007AA0E3
		public ITalkOptionConditionSystemConfigBase_UnionUnion()
		{
			this.Type = ITalkOptionConditionSystemConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038B58 RID: 232280 RVA: 0x007ABEF9 File Offset: 0x007AA0F9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038B59 RID: 232281 RVA: 0x007ABF0B File Offset: 0x007AA10B
		public ITalkOptionConditionSystemConfigBaseT AsITalkOptionConditionSystemConfigBase()
		{
			return this.As<ITalkOptionConditionSystemConfigBaseT>();
		}

		// Token: 0x06038B5A RID: 232282 RVA: 0x007ABF13 File Offset: 0x007AA113
		public static ITalkOptionConditionSystemConfigBase_UnionUnion FromITalkOptionConditionSystemConfigBase(ITalkOptionConditionSystemConfigBaseT _italkoptionconditionsystemconfigbase)
		{
			return new ITalkOptionConditionSystemConfigBase_UnionUnion
			{
				Type = ITalkOptionConditionSystemConfigBase_Union.ITalkOptionConditionSystemConfigBase,
				Value = _italkoptionconditionsystemconfigbase
			};
		}

		// Token: 0x06038B5B RID: 232283 RVA: 0x007ABF28 File Offset: 0x007AA128
		public ITalkOptionConditionSolarSchoolT AsITalkOptionConditionSolarSchool()
		{
			return this.As<ITalkOptionConditionSolarSchoolT>();
		}

		// Token: 0x06038B5C RID: 232284 RVA: 0x007ABF30 File Offset: 0x007AA130
		public static ITalkOptionConditionSystemConfigBase_UnionUnion FromITalkOptionConditionSolarSchool(ITalkOptionConditionSolarSchoolT _italkoptionconditionsolarschool)
		{
			return new ITalkOptionConditionSystemConfigBase_UnionUnion
			{
				Type = ITalkOptionConditionSystemConfigBase_Union.ITalkOptionConditionSolarSchool,
				Value = _italkoptionconditionsolarschool
			};
		}

		// Token: 0x06038B5D RID: 232285 RVA: 0x007ABF48 File Offset: 0x007AA148
		public static int Pack(FlatBufferBuilder builder, ITalkOptionConditionSystemConfigBase_UnionUnion _o)
		{
			ITalkOptionConditionSystemConfigBase_Union type = _o.Type;
			if (type == ITalkOptionConditionSystemConfigBase_Union.ITalkOptionConditionSystemConfigBase)
			{
				return ITalkOptionConditionSystemConfigBase.Pack(builder, _o.AsITalkOptionConditionSystemConfigBase()).Value;
			}
			if (type != ITalkOptionConditionSystemConfigBase_Union.ITalkOptionConditionSolarSchool)
			{
				return 0;
			}
			return ITalkOptionConditionSolarSchool.Pack(builder, _o.AsITalkOptionConditionSolarSchool()).Value;
		}
	}
}
