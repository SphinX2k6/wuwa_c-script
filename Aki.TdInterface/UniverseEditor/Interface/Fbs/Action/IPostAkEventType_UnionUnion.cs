using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FC RID: 29948
	public class IPostAkEventType_UnionUnion
	{
		// Token: 0x1700DC70 RID: 56432
		// (get) Token: 0x06034844 RID: 215108 RVA: 0x00711D05 File Offset: 0x0070FF05
		// (set) Token: 0x06034845 RID: 215109 RVA: 0x00711D0D File Offset: 0x0070FF0D
		public IPostAkEventType_Union Type { get; set; }

		// Token: 0x1700DC71 RID: 56433
		// (get) Token: 0x06034846 RID: 215110 RVA: 0x00711D16 File Offset: 0x0070FF16
		// (set) Token: 0x06034847 RID: 215111 RVA: 0x00711D1E File Offset: 0x0070FF1E
		public object Value { get; set; }

		// Token: 0x06034848 RID: 215112 RVA: 0x00711D27 File Offset: 0x0070FF27
		public IPostAkEventType_UnionUnion()
		{
			this.Type = IPostAkEventType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034849 RID: 215113 RVA: 0x00711D3D File Offset: 0x0070FF3D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603484A RID: 215114 RVA: 0x00711D4F File Offset: 0x0070FF4F
		public IPostAkEventTypeT AsIPostAkEventType()
		{
			return this.As<IPostAkEventTypeT>();
		}

		// Token: 0x0603484B RID: 215115 RVA: 0x00711D57 File Offset: 0x0070FF57
		public static IPostAkEventType_UnionUnion FromIPostAkEventType(IPostAkEventTypeT _ipostakeventtype)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventType,
				Value = _ipostakeventtype
			};
		}

		// Token: 0x0603484C RID: 215116 RVA: 0x00711D6C File Offset: 0x0070FF6C
		public IPostAkEventTargetedT AsIPostAkEventTargeted()
		{
			return this.As<IPostAkEventTargetedT>();
		}

		// Token: 0x0603484D RID: 215117 RVA: 0x00711D74 File Offset: 0x0070FF74
		public static IPostAkEventType_UnionUnion FromIPostAkEventTargeted(IPostAkEventTargetedT _ipostakeventtargeted)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventTargeted,
				Value = _ipostakeventtargeted
			};
		}

		// Token: 0x0603484E RID: 215118 RVA: 0x00711D89 File Offset: 0x0070FF89
		public IPostAkEventGlobalT AsIPostAkEventGlobal()
		{
			return this.As<IPostAkEventGlobalT>();
		}

		// Token: 0x0603484F RID: 215119 RVA: 0x00711D91 File Offset: 0x0070FF91
		public static IPostAkEventType_UnionUnion FromIPostAkEventGlobal(IPostAkEventGlobalT _ipostakeventglobal)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventGlobal,
				Value = _ipostakeventglobal
			};
		}

		// Token: 0x06034850 RID: 215120 RVA: 0x00711DA6 File Offset: 0x0070FFA6
		public IPostAkEventMapT AsIPostAkEventMap()
		{
			return this.As<IPostAkEventMapT>();
		}

		// Token: 0x06034851 RID: 215121 RVA: 0x00711DAE File Offset: 0x0070FFAE
		public static IPostAkEventType_UnionUnion FromIPostAkEventMap(IPostAkEventMapT _ipostakeventmap)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventMap,
				Value = _ipostakeventmap
			};
		}

		// Token: 0x06034852 RID: 215122 RVA: 0x00711DC3 File Offset: 0x0070FFC3
		public IPostAkEventMusicSubtitleT AsIPostAkEventMusicSubtitle()
		{
			return this.As<IPostAkEventMusicSubtitleT>();
		}

		// Token: 0x06034853 RID: 215123 RVA: 0x00711DCB File Offset: 0x0070FFCB
		public static IPostAkEventType_UnionUnion FromIPostAkEventMusicSubtitle(IPostAkEventMusicSubtitleT _ipostakeventmusicsubtitle)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventMusicSubtitle,
				Value = _ipostakeventmusicsubtitle
			};
		}

		// Token: 0x06034854 RID: 215124 RVA: 0x00711DE0 File Offset: 0x0070FFE0
		public static int Pack(FlatBufferBuilder builder, IPostAkEventType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPostAkEventType_Union.IPostAkEventType:
				return IPostAkEventType.Pack(builder, _o.AsIPostAkEventType()).Value;
			case IPostAkEventType_Union.IPostAkEventTargeted:
				return IPostAkEventTargeted.Pack(builder, _o.AsIPostAkEventTargeted()).Value;
			case IPostAkEventType_Union.IPostAkEventGlobal:
				return IPostAkEventGlobal.Pack(builder, _o.AsIPostAkEventGlobal()).Value;
			case IPostAkEventType_Union.IPostAkEventMap:
				return IPostAkEventMap.Pack(builder, _o.AsIPostAkEventMap()).Value;
			case IPostAkEventType_Union.IPostAkEventMusicSubtitle:
				return IPostAkEventMusicSubtitle.Pack(builder, _o.AsIPostAkEventMusicSubtitle()).Value;
			default:
				return 0;
			}
		}
	}
}
