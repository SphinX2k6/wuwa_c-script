using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005899 RID: 22681
	public class IGraph3dEffectBase_UnionUnion
	{
		// Token: 0x1700A45E RID: 42078
		// (get) Token: 0x06024C8C RID: 150668 RVA: 0x0050D259 File Offset: 0x0050B459
		// (set) Token: 0x06024C8D RID: 150669 RVA: 0x0050D261 File Offset: 0x0050B461
		public IGraph3dEffectBase_Union Type { get; set; }

		// Token: 0x1700A45F RID: 42079
		// (get) Token: 0x06024C8E RID: 150670 RVA: 0x0050D26A File Offset: 0x0050B46A
		// (set) Token: 0x06024C8F RID: 150671 RVA: 0x0050D272 File Offset: 0x0050B472
		public object Value { get; set; }

		// Token: 0x06024C90 RID: 150672 RVA: 0x0050D27B File Offset: 0x0050B47B
		public IGraph3dEffectBase_UnionUnion()
		{
			this.Type = IGraph3dEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024C91 RID: 150673 RVA: 0x0050D291 File Offset: 0x0050B491
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024C92 RID: 150674 RVA: 0x0050D2A3 File Offset: 0x0050B4A3
		public IGraph3dEffectBaseT AsIGraph3dEffectBase()
		{
			return this.As<IGraph3dEffectBaseT>();
		}

		// Token: 0x06024C93 RID: 150675 RVA: 0x0050D2AB File Offset: 0x0050B4AB
		public static IGraph3dEffectBase_UnionUnion FromIGraph3dEffectBase(IGraph3dEffectBaseT _igraph3deffectbase)
		{
			return new IGraph3dEffectBase_UnionUnion
			{
				Type = IGraph3dEffectBase_Union.IGraph3dEffectBase,
				Value = _igraph3deffectbase
			};
		}

		// Token: 0x06024C94 RID: 150676 RVA: 0x0050D2C0 File Offset: 0x0050B4C0
		public IFireBoxFishEffectT AsIFireBoxFishEffect()
		{
			return this.As<IFireBoxFishEffectT>();
		}

		// Token: 0x06024C95 RID: 150677 RVA: 0x0050D2C8 File Offset: 0x0050B4C8
		public static IGraph3dEffectBase_UnionUnion FromIFireBoxFishEffect(IFireBoxFishEffectT _ifireboxfisheffect)
		{
			return new IGraph3dEffectBase_UnionUnion
			{
				Type = IGraph3dEffectBase_Union.IFireBoxFishEffect,
				Value = _ifireboxfisheffect
			};
		}

		// Token: 0x06024C96 RID: 150678 RVA: 0x0050D2E0 File Offset: 0x0050B4E0
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
