using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F86 RID: 32646
	public class TPostAkEventUnion
	{
		// Token: 0x1700F2D1 RID: 62161
		// (get) Token: 0x0603AD4B RID: 240971 RVA: 0x007E8254 File Offset: 0x007E6454
		// (set) Token: 0x0603AD4C RID: 240972 RVA: 0x007E825C File Offset: 0x007E645C
		public TPostAkEvent Type { get; set; }

		// Token: 0x1700F2D2 RID: 62162
		// (get) Token: 0x0603AD4D RID: 240973 RVA: 0x007E8265 File Offset: 0x007E6465
		// (set) Token: 0x0603AD4E RID: 240974 RVA: 0x007E826D File Offset: 0x007E646D
		public object Value { get; set; }

		// Token: 0x0603AD4F RID: 240975 RVA: 0x007E8276 File Offset: 0x007E6476
		public TPostAkEventUnion()
		{
			this.Type = TPostAkEvent.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD50 RID: 240976 RVA: 0x007E828C File Offset: 0x007E648C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD51 RID: 240977 RVA: 0x007E829E File Offset: 0x007E649E
		public IPostAkEventGlobalT AsIPostAkEventGlobal()
		{
			return this.As<IPostAkEventGlobalT>();
		}

		// Token: 0x0603AD52 RID: 240978 RVA: 0x007E82A6 File Offset: 0x007E64A6
		public static TPostAkEventUnion FromIPostAkEventGlobal(IPostAkEventGlobalT _ipostakeventglobal)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventGlobal,
				Value = _ipostakeventglobal
			};
		}

		// Token: 0x0603AD53 RID: 240979 RVA: 0x007E82BB File Offset: 0x007E64BB
		public IPostAkEventMapT AsIPostAkEventMap()
		{
			return this.As<IPostAkEventMapT>();
		}

		// Token: 0x0603AD54 RID: 240980 RVA: 0x007E82C3 File Offset: 0x007E64C3
		public static TPostAkEventUnion FromIPostAkEventMap(IPostAkEventMapT _ipostakeventmap)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventMap,
				Value = _ipostakeventmap
			};
		}

		// Token: 0x0603AD55 RID: 240981 RVA: 0x007E82D8 File Offset: 0x007E64D8
		public IPostAkEventMusicSubtitleT AsIPostAkEventMusicSubtitle()
		{
			return this.As<IPostAkEventMusicSubtitleT>();
		}

		// Token: 0x0603AD56 RID: 240982 RVA: 0x007E82E0 File Offset: 0x007E64E0
		public static TPostAkEventUnion FromIPostAkEventMusicSubtitle(IPostAkEventMusicSubtitleT _ipostakeventmusicsubtitle)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventMusicSubtitle,
				Value = _ipostakeventmusicsubtitle
			};
		}

		// Token: 0x0603AD57 RID: 240983 RVA: 0x007E82F5 File Offset: 0x007E64F5
		public IPostAkEventTargetedT AsIPostAkEventTargeted()
		{
			return this.As<IPostAkEventTargetedT>();
		}

		// Token: 0x0603AD58 RID: 240984 RVA: 0x007E82FD File Offset: 0x007E64FD
		public static TPostAkEventUnion FromIPostAkEventTargeted(IPostAkEventTargetedT _ipostakeventtargeted)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventTargeted,
				Value = _ipostakeventtargeted
			};
		}

		// Token: 0x0603AD59 RID: 240985 RVA: 0x007E8314 File Offset: 0x007E6514
		public static int Pack(FlatBufferBuilder builder, TPostAkEventUnion _o)
		{
			switch (_o.Type)
			{
			case TPostAkEvent.IPostAkEventGlobal:
				return IPostAkEventGlobal.Pack(builder, _o.AsIPostAkEventGlobal()).Value;
			case TPostAkEvent.IPostAkEventMap:
				return IPostAkEventMap.Pack(builder, _o.AsIPostAkEventMap()).Value;
			case TPostAkEvent.IPostAkEventMusicSubtitle:
				return IPostAkEventMusicSubtitle.Pack(builder, _o.AsIPostAkEventMusicSubtitle()).Value;
			case TPostAkEvent.IPostAkEventTargeted:
				return IPostAkEventTargeted.Pack(builder, _o.AsIPostAkEventTargeted()).Value;
			default:
				return 0;
			}
		}
	}
}
