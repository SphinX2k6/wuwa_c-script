using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4A RID: 28234
	public class IRemoveEffectBase_UnionUnion
	{
		// Token: 0x1700D25A RID: 53850
		// (get) Token: 0x06031E40 RID: 204352 RVA: 0x006C0499 File Offset: 0x006BE699
		// (set) Token: 0x06031E41 RID: 204353 RVA: 0x006C04A1 File Offset: 0x006BE6A1
		public IRemoveEffectBase_Union Type { get; set; }

		// Token: 0x1700D25B RID: 53851
		// (get) Token: 0x06031E42 RID: 204354 RVA: 0x006C04AA File Offset: 0x006BE6AA
		// (set) Token: 0x06031E43 RID: 204355 RVA: 0x006C04B2 File Offset: 0x006BE6B2
		public object Value { get; set; }

		// Token: 0x06031E44 RID: 204356 RVA: 0x006C04BB File Offset: 0x006BE6BB
		public IRemoveEffectBase_UnionUnion()
		{
			this.Type = IRemoveEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031E45 RID: 204357 RVA: 0x006C04D1 File Offset: 0x006BE6D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031E46 RID: 204358 RVA: 0x006C04E3 File Offset: 0x006BE6E3
		public IRemoveEffectBaseT AsIRemoveEffectBase()
		{
			return this.As<IRemoveEffectBaseT>();
		}

		// Token: 0x06031E47 RID: 204359 RVA: 0x006C04EB File Offset: 0x006BE6EB
		public static IRemoveEffectBase_UnionUnion FromIRemoveEffectBase(IRemoveEffectBaseT _iremoveeffectbase)
		{
			return new IRemoveEffectBase_UnionUnion
			{
				Type = IRemoveEffectBase_Union.IRemoveEffectBase,
				Value = _iremoveeffectbase
			};
		}

		// Token: 0x06031E48 RID: 204360 RVA: 0x006C0500 File Offset: 0x006BE700
		public IRemoveScreenEffectT AsIRemoveScreenEffect()
		{
			return this.As<IRemoveScreenEffectT>();
		}

		// Token: 0x06031E49 RID: 204361 RVA: 0x006C0508 File Offset: 0x006BE708
		public static IRemoveEffectBase_UnionUnion FromIRemoveScreenEffect(IRemoveScreenEffectT _iremovescreeneffect)
		{
			return new IRemoveEffectBase_UnionUnion
			{
				Type = IRemoveEffectBase_Union.IRemoveScreenEffect,
				Value = _iremovescreeneffect
			};
		}

		// Token: 0x06031E4A RID: 204362 RVA: 0x006C0520 File Offset: 0x006BE720
		public static int Pack(FlatBufferBuilder builder, IRemoveEffectBase_UnionUnion _o)
		{
			IRemoveEffectBase_Union type = _o.Type;
			if (type == IRemoveEffectBase_Union.IRemoveEffectBase)
			{
				return IRemoveEffectBase.Pack(builder, _o.AsIRemoveEffectBase()).Value;
			}
			if (type != IRemoveEffectBase_Union.IRemoveScreenEffect)
			{
				return 0;
			}
			return IRemoveScreenEffect.Pack(builder, _o.AsIRemoveScreenEffect()).Value;
		}
	}
}
