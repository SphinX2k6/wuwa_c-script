using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D81 RID: 28033
	public class IPostAkEventType_UnionUnion
	{
		// Token: 0x1700D128 RID: 53544
		// (get) Token: 0x06031848 RID: 202824 RVA: 0x006B661D File Offset: 0x006B481D
		// (set) Token: 0x06031849 RID: 202825 RVA: 0x006B6625 File Offset: 0x006B4825
		public IPostAkEventType_Union Type { get; set; }

		// Token: 0x1700D129 RID: 53545
		// (get) Token: 0x0603184A RID: 202826 RVA: 0x006B662E File Offset: 0x006B482E
		// (set) Token: 0x0603184B RID: 202827 RVA: 0x006B6636 File Offset: 0x006B4836
		public object Value { get; set; }

		// Token: 0x0603184C RID: 202828 RVA: 0x006B663F File Offset: 0x006B483F
		public IPostAkEventType_UnionUnion()
		{
			this.Type = IPostAkEventType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603184D RID: 202829 RVA: 0x006B6655 File Offset: 0x006B4855
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603184E RID: 202830 RVA: 0x006B6667 File Offset: 0x006B4867
		public IPostAkEventTypeT AsIPostAkEventType()
		{
			return this.As<IPostAkEventTypeT>();
		}

		// Token: 0x0603184F RID: 202831 RVA: 0x006B666F File Offset: 0x006B486F
		public static IPostAkEventType_UnionUnion FromIPostAkEventType(IPostAkEventTypeT _ipostakeventtype)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventType,
				Value = _ipostakeventtype
			};
		}

		// Token: 0x06031850 RID: 202832 RVA: 0x006B6684 File Offset: 0x006B4884
		public IPostAkEventTargetedT AsIPostAkEventTargeted()
		{
			return this.As<IPostAkEventTargetedT>();
		}

		// Token: 0x06031851 RID: 202833 RVA: 0x006B668C File Offset: 0x006B488C
		public static IPostAkEventType_UnionUnion FromIPostAkEventTargeted(IPostAkEventTargetedT _ipostakeventtargeted)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventTargeted,
				Value = _ipostakeventtargeted
			};
		}

		// Token: 0x06031852 RID: 202834 RVA: 0x006B66A1 File Offset: 0x006B48A1
		public IPostAkEventGlobalT AsIPostAkEventGlobal()
		{
			return this.As<IPostAkEventGlobalT>();
		}

		// Token: 0x06031853 RID: 202835 RVA: 0x006B66A9 File Offset: 0x006B48A9
		public static IPostAkEventType_UnionUnion FromIPostAkEventGlobal(IPostAkEventGlobalT _ipostakeventglobal)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventGlobal,
				Value = _ipostakeventglobal
			};
		}

		// Token: 0x06031854 RID: 202836 RVA: 0x006B66BE File Offset: 0x006B48BE
		public IPostAkEventMapT AsIPostAkEventMap()
		{
			return this.As<IPostAkEventMapT>();
		}

		// Token: 0x06031855 RID: 202837 RVA: 0x006B66C6 File Offset: 0x006B48C6
		public static IPostAkEventType_UnionUnion FromIPostAkEventMap(IPostAkEventMapT _ipostakeventmap)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventMap,
				Value = _ipostakeventmap
			};
		}

		// Token: 0x06031856 RID: 202838 RVA: 0x006B66DB File Offset: 0x006B48DB
		public IPostAkEventMusicSubtitleT AsIPostAkEventMusicSubtitle()
		{
			return this.As<IPostAkEventMusicSubtitleT>();
		}

		// Token: 0x06031857 RID: 202839 RVA: 0x006B66E3 File Offset: 0x006B48E3
		public static IPostAkEventType_UnionUnion FromIPostAkEventMusicSubtitle(IPostAkEventMusicSubtitleT _ipostakeventmusicsubtitle)
		{
			return new IPostAkEventType_UnionUnion
			{
				Type = IPostAkEventType_Union.IPostAkEventMusicSubtitle,
				Value = _ipostakeventmusicsubtitle
			};
		}

		// Token: 0x06031858 RID: 202840 RVA: 0x006B66F8 File Offset: 0x006B48F8
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
