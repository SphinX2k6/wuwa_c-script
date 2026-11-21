using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677C RID: 26492
	public class IActorVisibilityEffectType_UnionUnion
	{
		// Token: 0x1700C099 RID: 49305
		// (get) Token: 0x0602CE6A RID: 183914 RVA: 0x00623805 File Offset: 0x00621A05
		// (set) Token: 0x0602CE6B RID: 183915 RVA: 0x0062380D File Offset: 0x00621A0D
		public IActorVisibilityEffectType_Union Type { get; set; }

		// Token: 0x1700C09A RID: 49306
		// (get) Token: 0x0602CE6C RID: 183916 RVA: 0x00623816 File Offset: 0x00621A16
		// (set) Token: 0x0602CE6D RID: 183917 RVA: 0x0062381E File Offset: 0x00621A1E
		public object Value { get; set; }

		// Token: 0x0602CE6E RID: 183918 RVA: 0x00623827 File Offset: 0x00621A27
		public IActorVisibilityEffectType_UnionUnion()
		{
			this.Type = IActorVisibilityEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CE6F RID: 183919 RVA: 0x0062383D File Offset: 0x00621A3D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CE70 RID: 183920 RVA: 0x0062384F File Offset: 0x00621A4F
		public IActorVisibilityEffectTypeT AsIActorVisibilityEffectType()
		{
			return this.As<IActorVisibilityEffectTypeT>();
		}

		// Token: 0x0602CE71 RID: 183921 RVA: 0x00623857 File Offset: 0x00621A57
		public static IActorVisibilityEffectType_UnionUnion FromIActorVisibilityEffectType(IActorVisibilityEffectTypeT _iactorvisibilityeffecttype)
		{
			return new IActorVisibilityEffectType_UnionUnion
			{
				Type = IActorVisibilityEffectType_Union.IActorVisibilityEffectType,
				Value = _iactorvisibilityeffecttype
			};
		}

		// Token: 0x0602CE72 RID: 183922 RVA: 0x0062386C File Offset: 0x00621A6C
		public IActorVisibilityEffectDefaultT AsIActorVisibilityEffectDefault()
		{
			return this.As<IActorVisibilityEffectDefaultT>();
		}

		// Token: 0x0602CE73 RID: 183923 RVA: 0x00623874 File Offset: 0x00621A74
		public static IActorVisibilityEffectType_UnionUnion FromIActorVisibilityEffectDefault(IActorVisibilityEffectDefaultT _iactorvisibilityeffectdefault)
		{
			return new IActorVisibilityEffectType_UnionUnion
			{
				Type = IActorVisibilityEffectType_Union.IActorVisibilityEffectDefault,
				Value = _iactorvisibilityeffectdefault
			};
		}

		// Token: 0x0602CE74 RID: 183924 RVA: 0x0062388C File Offset: 0x00621A8C
		public static int Pack(FlatBufferBuilder builder, IActorVisibilityEffectType_UnionUnion _o)
		{
			IActorVisibilityEffectType_Union type = _o.Type;
			if (type == IActorVisibilityEffectType_Union.IActorVisibilityEffectType)
			{
				return IActorVisibilityEffectType.Pack(builder, _o.AsIActorVisibilityEffectType()).Value;
			}
			if (type != IActorVisibilityEffectType_Union.IActorVisibilityEffectDefault)
			{
				return 0;
			}
			return IActorVisibilityEffectDefault.Pack(builder, _o.AsIActorVisibilityEffectDefault()).Value;
		}
	}
}
