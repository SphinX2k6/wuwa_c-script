using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C8 RID: 30152
	public class IRemoveEffectBase_UnionUnion
	{
		// Token: 0x1700DDA9 RID: 56745
		// (get) Token: 0x06034E56 RID: 216662 RVA: 0x0071BE21 File Offset: 0x0071A021
		// (set) Token: 0x06034E57 RID: 216663 RVA: 0x0071BE29 File Offset: 0x0071A029
		public IRemoveEffectBase_Union Type { get; set; }

		// Token: 0x1700DDAA RID: 56746
		// (get) Token: 0x06034E58 RID: 216664 RVA: 0x0071BE32 File Offset: 0x0071A032
		// (set) Token: 0x06034E59 RID: 216665 RVA: 0x0071BE3A File Offset: 0x0071A03A
		public object Value { get; set; }

		// Token: 0x06034E5A RID: 216666 RVA: 0x0071BE43 File Offset: 0x0071A043
		public IRemoveEffectBase_UnionUnion()
		{
			this.Type = IRemoveEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034E5B RID: 216667 RVA: 0x0071BE59 File Offset: 0x0071A059
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034E5C RID: 216668 RVA: 0x0071BE6B File Offset: 0x0071A06B
		public IRemoveEffectBaseT AsIRemoveEffectBase()
		{
			return this.As<IRemoveEffectBaseT>();
		}

		// Token: 0x06034E5D RID: 216669 RVA: 0x0071BE73 File Offset: 0x0071A073
		public static IRemoveEffectBase_UnionUnion FromIRemoveEffectBase(IRemoveEffectBaseT _iremoveeffectbase)
		{
			return new IRemoveEffectBase_UnionUnion
			{
				Type = IRemoveEffectBase_Union.IRemoveEffectBase,
				Value = _iremoveeffectbase
			};
		}

		// Token: 0x06034E5E RID: 216670 RVA: 0x0071BE88 File Offset: 0x0071A088
		public IRemoveScreenEffectT AsIRemoveScreenEffect()
		{
			return this.As<IRemoveScreenEffectT>();
		}

		// Token: 0x06034E5F RID: 216671 RVA: 0x0071BE90 File Offset: 0x0071A090
		public static IRemoveEffectBase_UnionUnion FromIRemoveScreenEffect(IRemoveScreenEffectT _iremovescreeneffect)
		{
			return new IRemoveEffectBase_UnionUnion
			{
				Type = IRemoveEffectBase_Union.IRemoveScreenEffect,
				Value = _iremovescreeneffect
			};
		}

		// Token: 0x06034E60 RID: 216672 RVA: 0x0071BEA8 File Offset: 0x0071A0A8
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
