using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BFD RID: 31741
	public class IToggleMapMarkState_UnionUnion
	{
		// Token: 0x1700EDBE RID: 60862
		// (get) Token: 0x06039360 RID: 234336 RVA: 0x007BA92D File Offset: 0x007B8B2D
		// (set) Token: 0x06039361 RID: 234337 RVA: 0x007BA935 File Offset: 0x007B8B35
		public IToggleMapMarkState_Union Type { get; set; }

		// Token: 0x1700EDBF RID: 60863
		// (get) Token: 0x06039362 RID: 234338 RVA: 0x007BA93E File Offset: 0x007B8B3E
		// (set) Token: 0x06039363 RID: 234339 RVA: 0x007BA946 File Offset: 0x007B8B46
		public object Value { get; set; }

		// Token: 0x06039364 RID: 234340 RVA: 0x007BA94F File Offset: 0x007B8B4F
		public IToggleMapMarkState_UnionUnion()
		{
			this.Type = IToggleMapMarkState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039365 RID: 234341 RVA: 0x007BA965 File Offset: 0x007B8B65
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039366 RID: 234342 RVA: 0x007BA977 File Offset: 0x007B8B77
		public IToggleMapMarkStateT AsIToggleMapMarkState()
		{
			return this.As<IToggleMapMarkStateT>();
		}

		// Token: 0x06039367 RID: 234343 RVA: 0x007BA97F File Offset: 0x007B8B7F
		public static IToggleMapMarkState_UnionUnion FromIToggleMapMarkState(IToggleMapMarkStateT _itogglemapmarkstate)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IToggleMapMarkState,
				Value = _itogglemapmarkstate
			};
		}

		// Token: 0x06039368 RID: 234344 RVA: 0x007BA994 File Offset: 0x007B8B94
		public IShowMapMarkT AsIShowMapMark()
		{
			return this.As<IShowMapMarkT>();
		}

		// Token: 0x06039369 RID: 234345 RVA: 0x007BA99C File Offset: 0x007B8B9C
		public static IToggleMapMarkState_UnionUnion FromIShowMapMark(IShowMapMarkT _ishowmapmark)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IShowMapMark,
				Value = _ishowmapmark
			};
		}

		// Token: 0x0603936A RID: 234346 RVA: 0x007BA9B1 File Offset: 0x007B8BB1
		public IHideMapMarkT AsIHideMapMark()
		{
			return this.As<IHideMapMarkT>();
		}

		// Token: 0x0603936B RID: 234347 RVA: 0x007BA9B9 File Offset: 0x007B8BB9
		public static IToggleMapMarkState_UnionUnion FromIHideMapMark(IHideMapMarkT _ihidemapmark)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IHideMapMark,
				Value = _ihidemapmark
			};
		}

		// Token: 0x0603936C RID: 234348 RVA: 0x007BA9CE File Offset: 0x007B8BCE
		public IDisableMapMarkT AsIDisableMapMark()
		{
			return this.As<IDisableMapMarkT>();
		}

		// Token: 0x0603936D RID: 234349 RVA: 0x007BA9D6 File Offset: 0x007B8BD6
		public static IToggleMapMarkState_UnionUnion FromIDisableMapMark(IDisableMapMarkT _idisablemapmark)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IDisableMapMark,
				Value = _idisablemapmark
			};
		}

		// Token: 0x0603936E RID: 234350 RVA: 0x007BA9EC File Offset: 0x007B8BEC
		public static int Pack(FlatBufferBuilder builder, IToggleMapMarkState_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IToggleMapMarkState_Union.IToggleMapMarkState:
				return IToggleMapMarkState.Pack(builder, _o.AsIToggleMapMarkState()).Value;
			case IToggleMapMarkState_Union.IShowMapMark:
				return IShowMapMark.Pack(builder, _o.AsIShowMapMark()).Value;
			case IToggleMapMarkState_Union.IHideMapMark:
				return IHideMapMark.Pack(builder, _o.AsIHideMapMark()).Value;
			case IToggleMapMarkState_Union.IDisableMapMark:
				return IDisableMapMark.Pack(builder, _o.AsIDisableMapMark()).Value;
			default:
				return 0;
			}
		}
	}
}
