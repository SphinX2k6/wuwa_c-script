using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007817 RID: 30743
	public class TVisualNovelTransitionConfigUnion
	{
		// Token: 0x1700E6FD RID: 59133
		// (get) Token: 0x06037BE6 RID: 228326 RVA: 0x00789057 File Offset: 0x00787257
		// (set) Token: 0x06037BE7 RID: 228327 RVA: 0x0078905F File Offset: 0x0078725F
		public TVisualNovelTransitionConfig Type { get; set; }

		// Token: 0x1700E6FE RID: 59134
		// (get) Token: 0x06037BE8 RID: 228328 RVA: 0x00789068 File Offset: 0x00787268
		// (set) Token: 0x06037BE9 RID: 228329 RVA: 0x00789070 File Offset: 0x00787270
		public object Value { get; set; }

		// Token: 0x06037BEA RID: 228330 RVA: 0x00789079 File Offset: 0x00787279
		public TVisualNovelTransitionConfigUnion()
		{
			this.Type = TVisualNovelTransitionConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037BEB RID: 228331 RVA: 0x0078908F File Offset: 0x0078728F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037BEC RID: 228332 RVA: 0x007890A1 File Offset: 0x007872A1
		public IVisualNovelTransitionLocationT AsIVisualNovelTransitionLocation()
		{
			return this.As<IVisualNovelTransitionLocationT>();
		}

		// Token: 0x06037BED RID: 228333 RVA: 0x007890A9 File Offset: 0x007872A9
		public static TVisualNovelTransitionConfigUnion FromIVisualNovelTransitionLocation(IVisualNovelTransitionLocationT _ivisualnoveltransitionlocation)
		{
			return new TVisualNovelTransitionConfigUnion
			{
				Type = TVisualNovelTransitionConfig.IVisualNovelTransitionLocation,
				Value = _ivisualnoveltransitionlocation
			};
		}

		// Token: 0x06037BEE RID: 228334 RVA: 0x007890BE File Offset: 0x007872BE
		public IVisualNovelTransitionTimeT AsIVisualNovelTransitionTime()
		{
			return this.As<IVisualNovelTransitionTimeT>();
		}

		// Token: 0x06037BEF RID: 228335 RVA: 0x007890C6 File Offset: 0x007872C6
		public static TVisualNovelTransitionConfigUnion FromIVisualNovelTransitionTime(IVisualNovelTransitionTimeT _ivisualnoveltransitiontime)
		{
			return new TVisualNovelTransitionConfigUnion
			{
				Type = TVisualNovelTransitionConfig.IVisualNovelTransitionTime,
				Value = _ivisualnoveltransitiontime
			};
		}

		// Token: 0x06037BF0 RID: 228336 RVA: 0x007890DC File Offset: 0x007872DC
		public static int Pack(FlatBufferBuilder builder, TVisualNovelTransitionConfigUnion _o)
		{
			TVisualNovelTransitionConfig type = _o.Type;
			if (type == TVisualNovelTransitionConfig.IVisualNovelTransitionLocation)
			{
				return IVisualNovelTransitionLocation.Pack(builder, _o.AsIVisualNovelTransitionLocation()).Value;
			}
			if (type != TVisualNovelTransitionConfig.IVisualNovelTransitionTime)
			{
				return 0;
			}
			return IVisualNovelTransitionTime.Pack(builder, _o.AsIVisualNovelTransitionTime()).Value;
		}
	}
}
