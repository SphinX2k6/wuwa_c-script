using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BA RID: 21434
	public class IHookFetchMoveModeBase_UnionUnion
	{
		// Token: 0x17009D8A RID: 40330
		// (get) Token: 0x060231FE RID: 143870 RVA: 0x004DCC5D File Offset: 0x004DAE5D
		// (set) Token: 0x060231FF RID: 143871 RVA: 0x004DCC65 File Offset: 0x004DAE65
		public IHookFetchMoveModeBase_Union Type { get; set; }

		// Token: 0x17009D8B RID: 40331
		// (get) Token: 0x06023200 RID: 143872 RVA: 0x004DCC6E File Offset: 0x004DAE6E
		// (set) Token: 0x06023201 RID: 143873 RVA: 0x004DCC76 File Offset: 0x004DAE76
		public object Value { get; set; }

		// Token: 0x06023202 RID: 143874 RVA: 0x004DCC7F File Offset: 0x004DAE7F
		public IHookFetchMoveModeBase_UnionUnion()
		{
			this.Type = IHookFetchMoveModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023203 RID: 143875 RVA: 0x004DCC95 File Offset: 0x004DAE95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023204 RID: 143876 RVA: 0x004DCCA7 File Offset: 0x004DAEA7
		public IHookFetchMoveModeBaseT AsIHookFetchMoveModeBase()
		{
			return this.As<IHookFetchMoveModeBaseT>();
		}

		// Token: 0x06023205 RID: 143877 RVA: 0x004DCCAF File Offset: 0x004DAEAF
		public static IHookFetchMoveModeBase_UnionUnion FromIHookFetchMoveModeBase(IHookFetchMoveModeBaseT _ihookfetchmovemodebase)
		{
			return new IHookFetchMoveModeBase_UnionUnion
			{
				Type = IHookFetchMoveModeBase_Union.IHookFetchMoveModeBase,
				Value = _ihookfetchmovemodebase
			};
		}

		// Token: 0x06023206 RID: 143878 RVA: 0x004DCCC4 File Offset: 0x004DAEC4
		public IHookFetchMoveUniformT AsIHookFetchMoveUniform()
		{
			return this.As<IHookFetchMoveUniformT>();
		}

		// Token: 0x06023207 RID: 143879 RVA: 0x004DCCCC File Offset: 0x004DAECC
		public static IHookFetchMoveModeBase_UnionUnion FromIHookFetchMoveUniform(IHookFetchMoveUniformT _ihookfetchmoveuniform)
		{
			return new IHookFetchMoveModeBase_UnionUnion
			{
				Type = IHookFetchMoveModeBase_Union.IHookFetchMoveUniform,
				Value = _ihookfetchmoveuniform
			};
		}

		// Token: 0x06023208 RID: 143880 RVA: 0x004DCCE4 File Offset: 0x004DAEE4
		public static int Pack(FlatBufferBuilder builder, IHookFetchMoveModeBase_UnionUnion _o)
		{
			IHookFetchMoveModeBase_Union type = _o.Type;
			if (type == IHookFetchMoveModeBase_Union.IHookFetchMoveModeBase)
			{
				return IHookFetchMoveModeBase.Pack(builder, _o.AsIHookFetchMoveModeBase()).Value;
			}
			if (type != IHookFetchMoveModeBase_Union.IHookFetchMoveUniform)
			{
				return 0;
			}
			return IHookFetchMoveUniform.Pack(builder, _o.AsIHookFetchMoveUniform()).Value;
		}
	}
}
