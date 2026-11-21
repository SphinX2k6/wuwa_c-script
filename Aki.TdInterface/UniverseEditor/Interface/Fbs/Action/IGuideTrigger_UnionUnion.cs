using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5D RID: 28509
	public class IGuideTrigger_UnionUnion
	{
		// Token: 0x1700D0E6 RID: 53478
		// (get) Token: 0x06031580 RID: 202112 RVA: 0x006B167B File Offset: 0x006AF87B
		// (set) Token: 0x06031581 RID: 202113 RVA: 0x006B1683 File Offset: 0x006AF883
		public IGuideTrigger_Union Type { get; set; }

		// Token: 0x1700D0E7 RID: 53479
		// (get) Token: 0x06031582 RID: 202114 RVA: 0x006B168C File Offset: 0x006AF88C
		// (set) Token: 0x06031583 RID: 202115 RVA: 0x006B1694 File Offset: 0x006AF894
		public object Value { get; set; }

		// Token: 0x06031584 RID: 202116 RVA: 0x006B169D File Offset: 0x006AF89D
		public IGuideTrigger_UnionUnion()
		{
			this.Type = IGuideTrigger_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031585 RID: 202117 RVA: 0x006B16B3 File Offset: 0x006AF8B3
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031586 RID: 202118 RVA: 0x006B16C5 File Offset: 0x006AF8C5
		public IGuideTriggerT AsIGuideTrigger()
		{
			return this.As<IGuideTriggerT>();
		}

		// Token: 0x06031587 RID: 202119 RVA: 0x006B16CD File Offset: 0x006AF8CD
		public static IGuideTrigger_UnionUnion FromIGuideTrigger(IGuideTriggerT _iguidetrigger)
		{
			return new IGuideTrigger_UnionUnion
			{
				Type = IGuideTrigger_Union.IGuideTrigger,
				Value = _iguidetrigger
			};
		}

		// Token: 0x06031588 RID: 202120 RVA: 0x006B16E2 File Offset: 0x006AF8E2
		public ICompleteGuideT AsICompleteGuide()
		{
			return this.As<ICompleteGuideT>();
		}

		// Token: 0x06031589 RID: 202121 RVA: 0x006B16EA File Offset: 0x006AF8EA
		public static IGuideTrigger_UnionUnion FromICompleteGuide(ICompleteGuideT _icompleteguide)
		{
			return new IGuideTrigger_UnionUnion
			{
				Type = IGuideTrigger_Union.ICompleteGuide,
				Value = _icompleteguide
			};
		}

		// Token: 0x0603158A RID: 202122 RVA: 0x006B1700 File Offset: 0x006AF900
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
