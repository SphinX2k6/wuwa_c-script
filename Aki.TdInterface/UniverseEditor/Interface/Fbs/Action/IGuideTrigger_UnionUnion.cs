using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BC RID: 26812
	public class IGuideTrigger_UnionUnion
	{
		// Token: 0x1700C700 RID: 50944
		// (get) Token: 0x0602EC46 RID: 191558 RVA: 0x006621FF File Offset: 0x006603FF
		// (set) Token: 0x0602EC47 RID: 191559 RVA: 0x00662207 File Offset: 0x00660407
		public IGuideTrigger_Union Type { get; set; }

		// Token: 0x1700C701 RID: 50945
		// (get) Token: 0x0602EC48 RID: 191560 RVA: 0x00662210 File Offset: 0x00660410
		// (set) Token: 0x0602EC49 RID: 191561 RVA: 0x00662218 File Offset: 0x00660418
		public object Value { get; set; }

		// Token: 0x0602EC4A RID: 191562 RVA: 0x00662221 File Offset: 0x00660421
		public IGuideTrigger_UnionUnion()
		{
			this.Type = IGuideTrigger_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EC4B RID: 191563 RVA: 0x00662237 File Offset: 0x00660437
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EC4C RID: 191564 RVA: 0x00662249 File Offset: 0x00660449
		public IGuideTriggerT AsIGuideTrigger()
		{
			return this.As<IGuideTriggerT>();
		}

		// Token: 0x0602EC4D RID: 191565 RVA: 0x00662251 File Offset: 0x00660451
		public static IGuideTrigger_UnionUnion FromIGuideTrigger(IGuideTriggerT _iguidetrigger)
		{
			return new IGuideTrigger_UnionUnion
			{
				Type = IGuideTrigger_Union.IGuideTrigger,
				Value = _iguidetrigger
			};
		}

		// Token: 0x0602EC4E RID: 191566 RVA: 0x00662266 File Offset: 0x00660466
		public ICompleteGuideT AsICompleteGuide()
		{
			return this.As<ICompleteGuideT>();
		}

		// Token: 0x0602EC4F RID: 191567 RVA: 0x0066226E File Offset: 0x0066046E
		public static IGuideTrigger_UnionUnion FromICompleteGuide(ICompleteGuideT _icompleteguide)
		{
			return new IGuideTrigger_UnionUnion
			{
				Type = IGuideTrigger_Union.ICompleteGuide,
				Value = _icompleteguide
			};
		}

		// Token: 0x0602EC50 RID: 191568 RVA: 0x00662284 File Offset: 0x00660484
		public static int Pack(FlatBufferBuilder builder, IGuideTrigger_UnionUnion _o)
		{
			IGuideTrigger_Union type = _o.Type;
			if (type == IGuideTrigger_Union.IGuideTrigger)
			{
				return IGuideTrigger.Pack(builder, _o.AsIGuideTrigger()).Value;
			}
			if (type != IGuideTrigger_Union.ICompleteGuide)
			{
				return 0;
			}
			return ICompleteGuide.Pack(builder, _o.AsICompleteGuide()).Value;
		}
	}
}
