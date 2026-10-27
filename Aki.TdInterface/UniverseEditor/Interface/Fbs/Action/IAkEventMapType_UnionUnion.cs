using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006186 RID: 24966
	public class IAkEventMapType_UnionUnion
	{
		// Token: 0x1700BA27 RID: 47655
		// (get) Token: 0x0602B010 RID: 176144 RVA: 0x005EECAD File Offset: 0x005ECEAD
		// (set) Token: 0x0602B011 RID: 176145 RVA: 0x005EECB5 File Offset: 0x005ECEB5
		public IAkEventMapType_Union Type { get; set; }

		// Token: 0x1700BA28 RID: 47656
		// (get) Token: 0x0602B012 RID: 176146 RVA: 0x005EECBE File Offset: 0x005ECEBE
		// (set) Token: 0x0602B013 RID: 176147 RVA: 0x005EECC6 File Offset: 0x005ECEC6
		public object Value { get; set; }

		// Token: 0x0602B014 RID: 176148 RVA: 0x005EECCF File Offset: 0x005ECECF
		public IAkEventMapType_UnionUnion()
		{
			this.Type = IAkEventMapType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B015 RID: 176149 RVA: 0x005EECE5 File Offset: 0x005ECEE5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B016 RID: 176150 RVA: 0x005EECF7 File Offset: 0x005ECEF7
		public IAkEventMapTypeT AsIAkEventMapType()
		{
			return this.As<IAkEventMapTypeT>();
		}

		// Token: 0x0602B017 RID: 176151 RVA: 0x005EECFF File Offset: 0x005ECEFF
		public static IAkEventMapType_UnionUnion FromIAkEventMapType(IAkEventMapTypeT _iakeventmaptype)
		{
			return new IAkEventMapType_UnionUnion
			{
				Type = IAkEventMapType_Union.IAkEventMapType,
				Value = _iakeventmaptype
			};
		}

		// Token: 0x0602B018 RID: 176152 RVA: 0x005EED14 File Offset: 0x005ECF14
		public IPlayMapMusicT AsIPlayMapMusic()
		{
			return this.As<IPlayMapMusicT>();
		}

		// Token: 0x0602B019 RID: 176153 RVA: 0x005EED1C File Offset: 0x005ECF1C
		public static IAkEventMapType_UnionUnion FromIPlayMapMusic(IPlayMapMusicT _iplaymapmusic)
		{
			return new IAkEventMapType_UnionUnion
			{
				Type = IAkEventMapType_Union.IPlayMapMusic,
				Value = _iplaymapmusic
			};
		}

		// Token: 0x0602B01A RID: 176154 RVA: 0x005EED34 File Offset: 0x005ECF34
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
