using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E4 RID: 30180
	public class IVisualNovelTransitionConfigBase_UnionUnion
	{
		// Token: 0x1700E544 RID: 58692
		// (get) Token: 0x06036F90 RID: 225168 RVA: 0x00775B95 File Offset: 0x00773D95
		// (set) Token: 0x06036F91 RID: 225169 RVA: 0x00775B9D File Offset: 0x00773D9D
		public IVisualNovelTransitionConfigBase_Union Type { get; set; }

		// Token: 0x1700E545 RID: 58693
		// (get) Token: 0x06036F92 RID: 225170 RVA: 0x00775BA6 File Offset: 0x00773DA6
		// (set) Token: 0x06036F93 RID: 225171 RVA: 0x00775BAE File Offset: 0x00773DAE
		public object Value { get; set; }

		// Token: 0x06036F94 RID: 225172 RVA: 0x00775BB7 File Offset: 0x00773DB7
		public IVisualNovelTransitionConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelTransitionConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036F95 RID: 225173 RVA: 0x00775BCD File Offset: 0x00773DCD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036F96 RID: 225174 RVA: 0x00775BDF File Offset: 0x00773DDF
		public IVisualNovelTransitionConfigBaseT AsIVisualNovelTransitionConfigBase()
		{
			return this.As<IVisualNovelTransitionConfigBaseT>();
		}

		// Token: 0x06036F97 RID: 225175 RVA: 0x00775BE7 File Offset: 0x00773DE7
		public static IVisualNovelTransitionConfigBase_UnionUnion FromIVisualNovelTransitionConfigBase(IVisualNovelTransitionConfigBaseT _ivisualnoveltransitionconfigbase)
		{
			return new IVisualNovelTransitionConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionConfigBase,
				Value = _ivisualnoveltransitionconfigbase
			};
		}

		// Token: 0x06036F98 RID: 225176 RVA: 0x00775BFC File Offset: 0x00773DFC
		public IVisualNovelTransitionLocationT AsIVisualNovelTransitionLocation()
		{
			return this.As<IVisualNovelTransitionLocationT>();
		}

		// Token: 0x06036F99 RID: 225177 RVA: 0x00775C04 File Offset: 0x00773E04
		public static IVisualNovelTransitionConfigBase_UnionUnion FromIVisualNovelTransitionLocation(IVisualNovelTransitionLocationT _ivisualnoveltransitionlocation)
		{
			return new IVisualNovelTransitionConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionLocation,
				Value = _ivisualnoveltransitionlocation
			};
		}

		// Token: 0x06036F9A RID: 225178 RVA: 0x00775C19 File Offset: 0x00773E19
		public IVisualNovelTransitionTimeT AsIVisualNovelTransitionTime()
		{
			return this.As<IVisualNovelTransitionTimeT>();
		}

		// Token: 0x06036F9B RID: 225179 RVA: 0x00775C21 File Offset: 0x00773E21
		public static IVisualNovelTransitionConfigBase_UnionUnion FromIVisualNovelTransitionTime(IVisualNovelTransitionTimeT _ivisualnoveltransitiontime)
		{
			return new IVisualNovelTransitionConfigBase_UnionUnion
			{
				Type = IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionTime,
				Value = _ivisualnoveltransitiontime
			};
		}

		// Token: 0x06036F9C RID: 225180 RVA: 0x00775C38 File Offset: 0x00773E38
		public static int Pack(FlatBufferBuilder builder, IVisualNovelTransitionConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionConfigBase:
				return IVisualNovelTransitionConfigBase.Pack(builder, _o.AsIVisualNovelTransitionConfigBase()).Value;
			case IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionLocation:
				return IVisualNovelTransitionLocation.Pack(builder, _o.AsIVisualNovelTransitionLocation()).Value;
			case IVisualNovelTransitionConfigBase_Union.IVisualNovelTransitionTime:
				return IVisualNovelTransitionTime.Pack(builder, _o.AsIVisualNovelTransitionTime()).Value;
			default:
				return 0;
			}
		}
	}
}
