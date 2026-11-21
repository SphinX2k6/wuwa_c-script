using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F1 RID: 26609
	public class IAkEventMapType_UnionUnion
	{
		// Token: 0x1700C3A5 RID: 50085
		// (get) Token: 0x0602D741 RID: 186177 RVA: 0x00639521 File Offset: 0x00637721
		// (set) Token: 0x0602D742 RID: 186178 RVA: 0x00639529 File Offset: 0x00637729
		public IAkEventMapType_Union Type { get; set; }

		// Token: 0x1700C3A6 RID: 50086
		// (get) Token: 0x0602D743 RID: 186179 RVA: 0x00639532 File Offset: 0x00637732
		// (set) Token: 0x0602D744 RID: 186180 RVA: 0x0063953A File Offset: 0x0063773A
		public object Value { get; set; }

		// Token: 0x0602D745 RID: 186181 RVA: 0x00639543 File Offset: 0x00637743
		public IAkEventMapType_UnionUnion()
		{
			this.Type = IAkEventMapType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D746 RID: 186182 RVA: 0x00639559 File Offset: 0x00637759
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D747 RID: 186183 RVA: 0x0063956B File Offset: 0x0063776B
		public IAkEventMapTypeT AsIAkEventMapType()
		{
			return this.As<IAkEventMapTypeT>();
		}

		// Token: 0x0602D748 RID: 186184 RVA: 0x00639573 File Offset: 0x00637773
		public static IAkEventMapType_UnionUnion FromIAkEventMapType(IAkEventMapTypeT _iakeventmaptype)
		{
			return new IAkEventMapType_UnionUnion
			{
				Type = IAkEventMapType_Union.IAkEventMapType,
				Value = _iakeventmaptype
			};
		}

		// Token: 0x0602D749 RID: 186185 RVA: 0x00639588 File Offset: 0x00637788
		public IPlayMapMusicT AsIPlayMapMusic()
		{
			return this.As<IPlayMapMusicT>();
		}

		// Token: 0x0602D74A RID: 186186 RVA: 0x00639590 File Offset: 0x00637790
		public static IAkEventMapType_UnionUnion FromIPlayMapMusic(IPlayMapMusicT _iplaymapmusic)
		{
			return new IAkEventMapType_UnionUnion
			{
				Type = IAkEventMapType_Union.IPlayMapMusic,
				Value = _iplaymapmusic
			};
		}

		// Token: 0x0602D74B RID: 186187 RVA: 0x006395A8 File Offset: 0x006377A8
		public static int Pack(FlatBufferBuilder builder, IAkEventMapType_UnionUnion _o)
		{
			IAkEventMapType_Union type = _o.Type;
			if (type == IAkEventMapType_Union.IAkEventMapType)
			{
				return IAkEventMapType.Pack(builder, _o.AsIAkEventMapType()).Value;
			}
			if (type != IAkEventMapType_Union.IPlayMapMusic)
			{
				return 0;
			}
			return IPlayMapMusic.Pack(builder, _o.AsIPlayMapMusic()).Value;
		}
	}
}
