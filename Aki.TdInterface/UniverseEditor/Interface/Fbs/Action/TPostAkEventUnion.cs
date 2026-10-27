using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775A RID: 30554
	public class TPostAkEventUnion
	{
		// Token: 0x1700E67F RID: 59007
		// (get) Token: 0x06037802 RID: 227330 RVA: 0x00783184 File Offset: 0x00781384
		// (set) Token: 0x06037803 RID: 227331 RVA: 0x0078318C File Offset: 0x0078138C
		public TPostAkEvent Type { get; set; }

		// Token: 0x1700E680 RID: 59008
		// (get) Token: 0x06037804 RID: 227332 RVA: 0x00783195 File Offset: 0x00781395
		// (set) Token: 0x06037805 RID: 227333 RVA: 0x0078319D File Offset: 0x0078139D
		public object Value { get; set; }

		// Token: 0x06037806 RID: 227334 RVA: 0x007831A6 File Offset: 0x007813A6
		public TPostAkEventUnion()
		{
			this.Type = TPostAkEvent.NONE;
			this.Value = null;
		}

		// Token: 0x06037807 RID: 227335 RVA: 0x007831BC File Offset: 0x007813BC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037808 RID: 227336 RVA: 0x007831CE File Offset: 0x007813CE
		public IPostAkEventGlobalT AsIPostAkEventGlobal()
		{
			return this.As<IPostAkEventGlobalT>();
		}

		// Token: 0x06037809 RID: 227337 RVA: 0x007831D6 File Offset: 0x007813D6
		public static TPostAkEventUnion FromIPostAkEventGlobal(IPostAkEventGlobalT _ipostakeventglobal)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventGlobal,
				Value = _ipostakeventglobal
			};
		}

		// Token: 0x0603780A RID: 227338 RVA: 0x007831EB File Offset: 0x007813EB
		public IPostAkEventMapT AsIPostAkEventMap()
		{
			return this.As<IPostAkEventMapT>();
		}

		// Token: 0x0603780B RID: 227339 RVA: 0x007831F3 File Offset: 0x007813F3
		public static TPostAkEventUnion FromIPostAkEventMap(IPostAkEventMapT _ipostakeventmap)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventMap,
				Value = _ipostakeventmap
			};
		}

		// Token: 0x0603780C RID: 227340 RVA: 0x00783208 File Offset: 0x00781408
		public IPostAkEventMusicSubtitleT AsIPostAkEventMusicSubtitle()
		{
			return this.As<IPostAkEventMusicSubtitleT>();
		}

		// Token: 0x0603780D RID: 227341 RVA: 0x00783210 File Offset: 0x00781410
		public static TPostAkEventUnion FromIPostAkEventMusicSubtitle(IPostAkEventMusicSubtitleT _ipostakeventmusicsubtitle)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventMusicSubtitle,
				Value = _ipostakeventmusicsubtitle
			};
		}

		// Token: 0x0603780E RID: 227342 RVA: 0x00783225 File Offset: 0x00781425
		public IPostAkEventTargetedT AsIPostAkEventTargeted()
		{
			return this.As<IPostAkEventTargetedT>();
		}

		// Token: 0x0603780F RID: 227343 RVA: 0x0078322D File Offset: 0x0078142D
		public static TPostAkEventUnion FromIPostAkEventTargeted(IPostAkEventTargetedT _ipostakeventtargeted)
		{
			return new TPostAkEventUnion
			{
				Type = TPostAkEvent.IPostAkEventTargeted,
				Value = _ipostakeventtargeted
			};
		}

		// Token: 0x06037810 RID: 227344 RVA: 0x00783244 File Offset: 0x00781444
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
