using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200805B RID: 32859
	public class TVisualNovelTransitionConfigUnion
	{
		// Token: 0x1700F35F RID: 62303
		// (get) Token: 0x0603B1A3 RID: 242083 RVA: 0x007EEBD0 File Offset: 0x007ECDD0
		// (set) Token: 0x0603B1A4 RID: 242084 RVA: 0x007EEBD8 File Offset: 0x007ECDD8
		public TVisualNovelTransitionConfig Type { get; set; }

		// Token: 0x1700F360 RID: 62304
		// (get) Token: 0x0603B1A5 RID: 242085 RVA: 0x007EEBE1 File Offset: 0x007ECDE1
		// (set) Token: 0x0603B1A6 RID: 242086 RVA: 0x007EEBE9 File Offset: 0x007ECDE9
		public object Value { get; set; }

		// Token: 0x0603B1A7 RID: 242087 RVA: 0x007EEBF2 File Offset: 0x007ECDF2
		public TVisualNovelTransitionConfigUnion()
		{
			this.Type = TVisualNovelTransitionConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603B1A8 RID: 242088 RVA: 0x007EEC08 File Offset: 0x007ECE08
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B1A9 RID: 242089 RVA: 0x007EEC1A File Offset: 0x007ECE1A
		public IVisualNovelTransitionLocationT AsIVisualNovelTransitionLocation()
		{
			return this.As<IVisualNovelTransitionLocationT>();
		}

		// Token: 0x0603B1AA RID: 242090 RVA: 0x007EEC22 File Offset: 0x007ECE22
		public static TVisualNovelTransitionConfigUnion FromIVisualNovelTransitionLocation(IVisualNovelTransitionLocationT _ivisualnoveltransitionlocation)
		{
			return new TVisualNovelTransitionConfigUnion
			{
				Type = TVisualNovelTransitionConfig.IVisualNovelTransitionLocation,
				Value = _ivisualnoveltransitionlocation
			};
		}

		// Token: 0x0603B1AB RID: 242091 RVA: 0x007EEC37 File Offset: 0x007ECE37
		public IVisualNovelTransitionTimeT AsIVisualNovelTransitionTime()
		{
			return this.As<IVisualNovelTransitionTimeT>();
		}

		// Token: 0x0603B1AC RID: 242092 RVA: 0x007EEC3F File Offset: 0x007ECE3F
		public static TVisualNovelTransitionConfigUnion FromIVisualNovelTransitionTime(IVisualNovelTransitionTimeT _ivisualnoveltransitiontime)
		{
			return new TVisualNovelTransitionConfigUnion
			{
				Type = TVisualNovelTransitionConfig.IVisualNovelTransitionTime,
				Value = _ivisualnoveltransitiontime
			};
		}

		// Token: 0x0603B1AD RID: 242093 RVA: 0x007EEC54 File Offset: 0x007ECE54
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
