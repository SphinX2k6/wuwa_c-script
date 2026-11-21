using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE9 RID: 32233
	public class IVisualNovelStopScreenEffectConfigBase_UnionUnion
	{
		// Token: 0x1700F178 RID: 61816
		// (get) Token: 0x0603A3FF RID: 238591 RVA: 0x007D97E9 File Offset: 0x007D79E9
		// (set) Token: 0x0603A400 RID: 238592 RVA: 0x007D97F1 File Offset: 0x007D79F1
		public IVisualNovelStopScreenEffectConfigBase_Union Type { get; set; }

		// Token: 0x1700F179 RID: 61817
		// (get) Token: 0x0603A401 RID: 238593 RVA: 0x007D97FA File Offset: 0x007D79FA
		// (set) Token: 0x0603A402 RID: 238594 RVA: 0x007D9802 File Offset: 0x007D7A02
		public object Value { get; set; }

		// Token: 0x0603A403 RID: 238595 RVA: 0x007D980B File Offset: 0x007D7A0B
		public IVisualNovelStopScreenEffectConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelStopScreenEffectConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603A404 RID: 238596 RVA: 0x007D9821 File Offset: 0x007D7A21
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A405 RID: 238597 RVA: 0x007D9833 File Offset: 0x007D7A33
		public IVisualNovelStopScreenEffectConfigBaseT AsIVisualNovelStopScreenEffectConfigBase()
		{
			return this.As<IVisualNovelStopScreenEffectConfigBaseT>();
		}

		// Token: 0x0603A406 RID: 238598 RVA: 0x007D983B File Offset: 0x007D7A3B
		public static IVisualNovelStopScreenEffectConfigBase_UnionUnion FromIVisualNovelStopScreenEffectConfigBase(IVisualNovelStopScreenEffectConfigBaseT _ivisualnovelstopscreeneffectconfigbase)
		{
			return new IVisualNovelStopScreenEffectConfigBase_UnionUnion
			{
				Type = IVisualNovelStopScreenEffectConfigBase_Union.IVisualNovelStopScreenEffectConfigBase,
				Value = _ivisualnovelstopscreeneffectconfigbase
			};
		}

		// Token: 0x0603A407 RID: 238599 RVA: 0x007D9850 File Offset: 0x007D7A50
		public IVisualNovelStopScreenEffectPersistentT AsIVisualNovelStopScreenEffectPersistent()
		{
			return this.As<IVisualNovelStopScreenEffectPersistentT>();
		}

		// Token: 0x0603A408 RID: 238600 RVA: 0x007D9858 File Offset: 0x007D7A58
		public static IVisualNovelStopScreenEffectConfigBase_UnionUnion FromIVisualNovelStopScreenEffectPersistent(IVisualNovelStopScreenEffectPersistentT _ivisualnovelstopscreeneffectpersistent)
		{
			return new IVisualNovelStopScreenEffectConfigBase_UnionUnion
			{
				Type = IVisualNovelStopScreenEffectConfigBase_Union.IVisualNovelStopScreenEffectPersistent,
				Value = _ivisualnovelstopscreeneffectpersistent
			};
		}

		// Token: 0x0603A409 RID: 238601 RVA: 0x007D9870 File Offset: 0x007D7A70
		public static int Pack(FlatBufferBuilder builder, IVisualNovelStopScreenEffectConfigBase_UnionUnion _o)
		{
			IVisualNovelStopScreenEffectConfigBase_Union type = _o.Type;
			if (type == IVisualNovelStopScreenEffectConfigBase_Union.IVisualNovelStopScreenEffectConfigBase)
			{
				return IVisualNovelStopScreenEffectConfigBase.Pack(builder, _o.AsIVisualNovelStopScreenEffectConfigBase()).Value;
			}
			if (type != IVisualNovelStopScreenEffectConfigBase_Union.IVisualNovelStopScreenEffectPersistent)
			{
				return 0;
			}
			return IVisualNovelStopScreenEffectPersistent.Pack(builder, _o.AsIVisualNovelStopScreenEffectPersistent()).Value;
		}
	}
}
