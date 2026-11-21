using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200801C RID: 32796
	public class TToggleMapMarkStateUnion
	{
		// Token: 0x1700F335 RID: 62261
		// (get) Token: 0x0603B02D RID: 241709 RVA: 0x007EC6A2 File Offset: 0x007EA8A2
		// (set) Token: 0x0603B02E RID: 241710 RVA: 0x007EC6AA File Offset: 0x007EA8AA
		public TToggleMapMarkState Type { get; set; }

		// Token: 0x1700F336 RID: 62262
		// (get) Token: 0x0603B02F RID: 241711 RVA: 0x007EC6B3 File Offset: 0x007EA8B3
		// (set) Token: 0x0603B030 RID: 241712 RVA: 0x007EC6BB File Offset: 0x007EA8BB
		public object Value { get; set; }

		// Token: 0x0603B031 RID: 241713 RVA: 0x007EC6C4 File Offset: 0x007EA8C4
		public TToggleMapMarkStateUnion()
		{
			this.Type = TToggleMapMarkState.NONE;
			this.Value = null;
		}

		// Token: 0x0603B032 RID: 241714 RVA: 0x007EC6DA File Offset: 0x007EA8DA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B033 RID: 241715 RVA: 0x007EC6EC File Offset: 0x007EA8EC
		public IDisableMapMarkT AsIDisableMapMark()
		{
			return this.As<IDisableMapMarkT>();
		}

		// Token: 0x0603B034 RID: 241716 RVA: 0x007EC6F4 File Offset: 0x007EA8F4
		public static TToggleMapMarkStateUnion FromIDisableMapMark(IDisableMapMarkT _idisablemapmark)
		{
			return new TToggleMapMarkStateUnion
			{
				Type = TToggleMapMarkState.IDisableMapMark,
				Value = _idisablemapmark
			};
		}

		// Token: 0x0603B035 RID: 241717 RVA: 0x007EC709 File Offset: 0x007EA909
		public IHideMapMarkT AsIHideMapMark()
		{
			return this.As<IHideMapMarkT>();
		}

		// Token: 0x0603B036 RID: 241718 RVA: 0x007EC711 File Offset: 0x007EA911
		public static TToggleMapMarkStateUnion FromIHideMapMark(IHideMapMarkT _ihidemapmark)
		{
			return new TToggleMapMarkStateUnion
			{
				Type = TToggleMapMarkState.IHideMapMark,
				Value = _ihidemapmark
			};
		}

		// Token: 0x0603B037 RID: 241719 RVA: 0x007EC726 File Offset: 0x007EA926
		public IShowMapMarkT AsIShowMapMark()
		{
			return this.As<IShowMapMarkT>();
		}

		// Token: 0x0603B038 RID: 241720 RVA: 0x007EC72E File Offset: 0x007EA92E
		public static TToggleMapMarkStateUnion FromIShowMapMark(IShowMapMarkT _ishowmapmark)
		{
			return new TToggleMapMarkStateUnion
			{
				Type = TToggleMapMarkState.IShowMapMark,
				Value = _ishowmapmark
			};
		}

		// Token: 0x0603B039 RID: 241721 RVA: 0x007EC744 File Offset: 0x007EA944
		public static int Pack(FlatBufferBuilder builder, TToggleMapMarkStateUnion _o)
		{
			switch (_o.Type)
			{
			case TToggleMapMarkState.IDisableMapMark:
				return IDisableMapMark.Pack(builder, _o.AsIDisableMapMark()).Value;
			case TToggleMapMarkState.IHideMapMark:
				return IHideMapMark.Pack(builder, _o.AsIHideMapMark()).Value;
			case TToggleMapMarkState.IShowMapMark:
				return IShowMapMark.Pack(builder, _o.AsIShowMapMark()).Value;
			default:
				return 0;
			}
		}
	}
}
