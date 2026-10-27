using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007413 RID: 29715
	public class IToggleMapMarkState_UnionUnion
	{
		// Token: 0x1700E1A9 RID: 57769
		// (get) Token: 0x06035FAD RID: 221101 RVA: 0x007581B9 File Offset: 0x007563B9
		// (set) Token: 0x06035FAE RID: 221102 RVA: 0x007581C1 File Offset: 0x007563C1
		public IToggleMapMarkState_Union Type { get; set; }

		// Token: 0x1700E1AA RID: 57770
		// (get) Token: 0x06035FAF RID: 221103 RVA: 0x007581CA File Offset: 0x007563CA
		// (set) Token: 0x06035FB0 RID: 221104 RVA: 0x007581D2 File Offset: 0x007563D2
		public object Value { get; set; }

		// Token: 0x06035FB1 RID: 221105 RVA: 0x007581DB File Offset: 0x007563DB
		public IToggleMapMarkState_UnionUnion()
		{
			this.Type = IToggleMapMarkState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035FB2 RID: 221106 RVA: 0x007581F1 File Offset: 0x007563F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035FB3 RID: 221107 RVA: 0x00758203 File Offset: 0x00756403
		public IToggleMapMarkStateT AsIToggleMapMarkState()
		{
			return this.As<IToggleMapMarkStateT>();
		}

		// Token: 0x06035FB4 RID: 221108 RVA: 0x0075820B File Offset: 0x0075640B
		public static IToggleMapMarkState_UnionUnion FromIToggleMapMarkState(IToggleMapMarkStateT _itogglemapmarkstate)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IToggleMapMarkState,
				Value = _itogglemapmarkstate
			};
		}

		// Token: 0x06035FB5 RID: 221109 RVA: 0x00758220 File Offset: 0x00756420
		public IShowMapMarkT AsIShowMapMark()
		{
			return this.As<IShowMapMarkT>();
		}

		// Token: 0x06035FB6 RID: 221110 RVA: 0x00758228 File Offset: 0x00756428
		public static IToggleMapMarkState_UnionUnion FromIShowMapMark(IShowMapMarkT _ishowmapmark)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IShowMapMark,
				Value = _ishowmapmark
			};
		}

		// Token: 0x06035FB7 RID: 221111 RVA: 0x0075823D File Offset: 0x0075643D
		public IHideMapMarkT AsIHideMapMark()
		{
			return this.As<IHideMapMarkT>();
		}

		// Token: 0x06035FB8 RID: 221112 RVA: 0x00758245 File Offset: 0x00756445
		public static IToggleMapMarkState_UnionUnion FromIHideMapMark(IHideMapMarkT _ihidemapmark)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IHideMapMark,
				Value = _ihidemapmark
			};
		}

		// Token: 0x06035FB9 RID: 221113 RVA: 0x0075825A File Offset: 0x0075645A
		public IDisableMapMarkT AsIDisableMapMark()
		{
			return this.As<IDisableMapMarkT>();
		}

		// Token: 0x06035FBA RID: 221114 RVA: 0x00758262 File Offset: 0x00756462
		public static IToggleMapMarkState_UnionUnion FromIDisableMapMark(IDisableMapMarkT _idisablemapmark)
		{
			return new IToggleMapMarkState_UnionUnion
			{
				Type = IToggleMapMarkState_Union.IDisableMapMark,
				Value = _idisablemapmark
			};
		}

		// Token: 0x06035FBB RID: 221115 RVA: 0x00758278 File Offset: 0x00756478
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
