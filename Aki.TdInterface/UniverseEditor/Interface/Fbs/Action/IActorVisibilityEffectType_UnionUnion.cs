using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200611A RID: 24858
	public class IActorVisibilityEffectType_UnionUnion
	{
		// Token: 0x1700B72E RID: 46894
		// (get) Token: 0x0602A789 RID: 173961 RVA: 0x005D985D File Offset: 0x005D7A5D
		// (set) Token: 0x0602A78A RID: 173962 RVA: 0x005D9865 File Offset: 0x005D7A65
		public IActorVisibilityEffectType_Union Type { get; set; }

		// Token: 0x1700B72F RID: 46895
		// (get) Token: 0x0602A78B RID: 173963 RVA: 0x005D986E File Offset: 0x005D7A6E
		// (set) Token: 0x0602A78C RID: 173964 RVA: 0x005D9876 File Offset: 0x005D7A76
		public object Value { get; set; }

		// Token: 0x0602A78D RID: 173965 RVA: 0x005D987F File Offset: 0x005D7A7F
		public IActorVisibilityEffectType_UnionUnion()
		{
			this.Type = IActorVisibilityEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A78E RID: 173966 RVA: 0x005D9895 File Offset: 0x005D7A95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A78F RID: 173967 RVA: 0x005D98A7 File Offset: 0x005D7AA7
		public IActorVisibilityEffectTypeT AsIActorVisibilityEffectType()
		{
			return this.As<IActorVisibilityEffectTypeT>();
		}

		// Token: 0x0602A790 RID: 173968 RVA: 0x005D98AF File Offset: 0x005D7AAF
		public static IActorVisibilityEffectType_UnionUnion FromIActorVisibilityEffectType(IActorVisibilityEffectTypeT _iactorvisibilityeffecttype)
		{
			return new IActorVisibilityEffectType_UnionUnion
			{
				Type = IActorVisibilityEffectType_Union.IActorVisibilityEffectType,
				Value = _iactorvisibilityeffecttype
			};
		}

		// Token: 0x0602A791 RID: 173969 RVA: 0x005D98C4 File Offset: 0x005D7AC4
		public IActorVisibilityEffectDefaultT AsIActorVisibilityEffectDefault()
		{
			return this.As<IActorVisibilityEffectDefaultT>();
		}

		// Token: 0x0602A792 RID: 173970 RVA: 0x005D98CC File Offset: 0x005D7ACC
		public static IActorVisibilityEffectType_UnionUnion FromIActorVisibilityEffectDefault(IActorVisibilityEffectDefaultT _iactorvisibilityeffectdefault)
		{
			return new IActorVisibilityEffectType_UnionUnion
			{
				Type = IActorVisibilityEffectType_Union.IActorVisibilityEffectDefault,
				Value = _iactorvisibilityeffectdefault
			};
		}

		// Token: 0x0602A793 RID: 173971 RVA: 0x005D98E4 File Offset: 0x005D7AE4
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
