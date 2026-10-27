using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E1 RID: 30689
	public class TToggleMapMarkStateUnion
	{
		// Token: 0x1700E6D9 RID: 59097
		// (get) Token: 0x06037A9A RID: 227994 RVA: 0x00786EF2 File Offset: 0x007850F2
		// (set) Token: 0x06037A9B RID: 227995 RVA: 0x00786EFA File Offset: 0x007850FA
		public TToggleMapMarkState Type { get; set; }

		// Token: 0x1700E6DA RID: 59098
		// (get) Token: 0x06037A9C RID: 227996 RVA: 0x00786F03 File Offset: 0x00785103
		// (set) Token: 0x06037A9D RID: 227997 RVA: 0x00786F0B File Offset: 0x0078510B
		public object Value { get; set; }

		// Token: 0x06037A9E RID: 227998 RVA: 0x00786F14 File Offset: 0x00785114
		public TToggleMapMarkStateUnion()
		{
			this.Type = TToggleMapMarkState.NONE;
			this.Value = null;
		}

		// Token: 0x06037A9F RID: 227999 RVA: 0x00786F2A File Offset: 0x0078512A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037AA0 RID: 228000 RVA: 0x00786F3C File Offset: 0x0078513C
		public IDisableMapMarkT AsIDisableMapMark()
		{
			return this.As<IDisableMapMarkT>();
		}

		// Token: 0x06037AA1 RID: 228001 RVA: 0x00786F44 File Offset: 0x00785144
		public static TToggleMapMarkStateUnion FromIDisableMapMark(IDisableMapMarkT _idisablemapmark)
		{
			return new TToggleMapMarkStateUnion
			{
				Type = TToggleMapMarkState.IDisableMapMark,
				Value = _idisablemapmark
			};
		}

		// Token: 0x06037AA2 RID: 228002 RVA: 0x00786F59 File Offset: 0x00785159
		public IHideMapMarkT AsIHideMapMark()
		{
			return this.As<IHideMapMarkT>();
		}

		// Token: 0x06037AA3 RID: 228003 RVA: 0x00786F61 File Offset: 0x00785161
		public static TToggleMapMarkStateUnion FromIHideMapMark(IHideMapMarkT _ihidemapmark)
		{
			return new TToggleMapMarkStateUnion
			{
				Type = TToggleMapMarkState.IHideMapMark,
				Value = _ihidemapmark
			};
		}

		// Token: 0x06037AA4 RID: 228004 RVA: 0x00786F76 File Offset: 0x00785176
		public IShowMapMarkT AsIShowMapMark()
		{
			return this.As<IShowMapMarkT>();
		}

		// Token: 0x06037AA5 RID: 228005 RVA: 0x00786F7E File Offset: 0x0078517E
		public static TToggleMapMarkStateUnion FromIShowMapMark(IShowMapMarkT _ishowmapmark)
		{
			return new TToggleMapMarkStateUnion
			{
				Type = TToggleMapMarkState.IShowMapMark,
				Value = _ishowmapmark
			};
		}

		// Token: 0x06037AA6 RID: 228006 RVA: 0x00786F94 File Offset: 0x00785194
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
