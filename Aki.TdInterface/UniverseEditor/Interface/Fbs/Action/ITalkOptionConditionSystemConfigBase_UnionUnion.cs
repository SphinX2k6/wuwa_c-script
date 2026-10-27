using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732C RID: 29484
	public class ITalkOptionConditionSystemConfigBase_UnionUnion
	{
		// Token: 0x1700DFF9 RID: 57337
		// (get) Token: 0x06035820 RID: 219168 RVA: 0x0074A339 File Offset: 0x00748539
		// (set) Token: 0x06035821 RID: 219169 RVA: 0x0074A341 File Offset: 0x00748541
		public ITalkOptionConditionSystemConfigBase_Union Type { get; set; }

		// Token: 0x1700DFFA RID: 57338
		// (get) Token: 0x06035822 RID: 219170 RVA: 0x0074A34A File Offset: 0x0074854A
		// (set) Token: 0x06035823 RID: 219171 RVA: 0x0074A352 File Offset: 0x00748552
		public object Value { get; set; }

		// Token: 0x06035824 RID: 219172 RVA: 0x0074A35B File Offset: 0x0074855B
		public ITalkOptionConditionSystemConfigBase_UnionUnion()
		{
			this.Type = ITalkOptionConditionSystemConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035825 RID: 219173 RVA: 0x0074A371 File Offset: 0x00748571
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035826 RID: 219174 RVA: 0x0074A383 File Offset: 0x00748583
		public ITalkOptionConditionSystemConfigBaseT AsITalkOptionConditionSystemConfigBase()
		{
			return this.As<ITalkOptionConditionSystemConfigBaseT>();
		}

		// Token: 0x06035827 RID: 219175 RVA: 0x0074A38B File Offset: 0x0074858B
		public static ITalkOptionConditionSystemConfigBase_UnionUnion FromITalkOptionConditionSystemConfigBase(ITalkOptionConditionSystemConfigBaseT _italkoptionconditionsystemconfigbase)
		{
			return new ITalkOptionConditionSystemConfigBase_UnionUnion
			{
				Type = ITalkOptionConditionSystemConfigBase_Union.ITalkOptionConditionSystemConfigBase,
				Value = _italkoptionconditionsystemconfigbase
			};
		}

		// Token: 0x06035828 RID: 219176 RVA: 0x0074A3A0 File Offset: 0x007485A0
		public ITalkOptionConditionSolarSchoolT AsITalkOptionConditionSolarSchool()
		{
			return this.As<ITalkOptionConditionSolarSchoolT>();
		}

		// Token: 0x06035829 RID: 219177 RVA: 0x0074A3A8 File Offset: 0x007485A8
		public static ITalkOptionConditionSystemConfigBase_UnionUnion FromITalkOptionConditionSolarSchool(ITalkOptionConditionSolarSchoolT _italkoptionconditionsolarschool)
		{
			return new ITalkOptionConditionSystemConfigBase_UnionUnion
			{
				Type = ITalkOptionConditionSystemConfigBase_Union.ITalkOptionConditionSolarSchool,
				Value = _italkoptionconditionsolarschool
			};
		}

		// Token: 0x0603582A RID: 219178 RVA: 0x0074A3C0 File Offset: 0x007485C0
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
