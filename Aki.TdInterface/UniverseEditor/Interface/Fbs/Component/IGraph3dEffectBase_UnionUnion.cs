using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005313 RID: 21267
	public class IGraph3dEffectBase_UnionUnion
	{
		// Token: 0x17009C26 RID: 39974
		// (get) Token: 0x06022BD8 RID: 142296 RVA: 0x004D0385 File Offset: 0x004CE585
		// (set) Token: 0x06022BD9 RID: 142297 RVA: 0x004D038D File Offset: 0x004CE58D
		public IGraph3dEffectBase_Union Type { get; set; }

		// Token: 0x17009C27 RID: 39975
		// (get) Token: 0x06022BDA RID: 142298 RVA: 0x004D0396 File Offset: 0x004CE596
		// (set) Token: 0x06022BDB RID: 142299 RVA: 0x004D039E File Offset: 0x004CE59E
		public object Value { get; set; }

		// Token: 0x06022BDC RID: 142300 RVA: 0x004D03A7 File Offset: 0x004CE5A7
		public IGraph3dEffectBase_UnionUnion()
		{
			this.Type = IGraph3dEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022BDD RID: 142301 RVA: 0x004D03BD File Offset: 0x004CE5BD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022BDE RID: 142302 RVA: 0x004D03CF File Offset: 0x004CE5CF
		public IGraph3dEffectBaseT AsIGraph3dEffectBase()
		{
			return this.As<IGraph3dEffectBaseT>();
		}

		// Token: 0x06022BDF RID: 142303 RVA: 0x004D03D7 File Offset: 0x004CE5D7
		public static IGraph3dEffectBase_UnionUnion FromIGraph3dEffectBase(IGraph3dEffectBaseT _igraph3deffectbase)
		{
			return new IGraph3dEffectBase_UnionUnion
			{
				Type = IGraph3dEffectBase_Union.IGraph3dEffectBase,
				Value = _igraph3deffectbase
			};
		}

		// Token: 0x06022BE0 RID: 142304 RVA: 0x004D03EC File Offset: 0x004CE5EC
		public IFireBoxFishEffectT AsIFireBoxFishEffect()
		{
			return this.As<IFireBoxFishEffectT>();
		}

		// Token: 0x06022BE1 RID: 142305 RVA: 0x004D03F4 File Offset: 0x004CE5F4
		public static IGraph3dEffectBase_UnionUnion FromIFireBoxFishEffect(IFireBoxFishEffectT _ifireboxfisheffect)
		{
			return new IGraph3dEffectBase_UnionUnion
			{
				Type = IGraph3dEffectBase_Union.IFireBoxFishEffect,
				Value = _ifireboxfisheffect
			};
		}

		// Token: 0x06022BE2 RID: 142306 RVA: 0x004D040C File Offset: 0x004CE60C
		public static int Pack(FlatBufferBuilder builder, IGraph3dEffectBase_UnionUnion _o)
		{
			IGraph3dEffectBase_Union type = _o.Type;
			if (type == IGraph3dEffectBase_Union.IGraph3dEffectBase)
			{
				return IGraph3dEffectBase.Pack(builder, _o.AsIGraph3dEffectBase()).Value;
			}
			if (type != IGraph3dEffectBase_Union.IFireBoxFishEffect)
			{
				return 0;
			}
			return IFireBoxFishEffect.Pack(builder, _o.AsIFireBoxFishEffect()).Value;
		}
	}
}
