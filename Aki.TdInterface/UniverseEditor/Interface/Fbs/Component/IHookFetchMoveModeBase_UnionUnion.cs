using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005940 RID: 22848
	public class IHookFetchMoveModeBase_UnionUnion
	{
		// Token: 0x1700A5C2 RID: 42434
		// (get) Token: 0x060252B2 RID: 152242 RVA: 0x00519B31 File Offset: 0x00517D31
		// (set) Token: 0x060252B3 RID: 152243 RVA: 0x00519B39 File Offset: 0x00517D39
		public IHookFetchMoveModeBase_Union Type { get; set; }

		// Token: 0x1700A5C3 RID: 42435
		// (get) Token: 0x060252B4 RID: 152244 RVA: 0x00519B42 File Offset: 0x00517D42
		// (set) Token: 0x060252B5 RID: 152245 RVA: 0x00519B4A File Offset: 0x00517D4A
		public object Value { get; set; }

		// Token: 0x060252B6 RID: 152246 RVA: 0x00519B53 File Offset: 0x00517D53
		public IHookFetchMoveModeBase_UnionUnion()
		{
			this.Type = IHookFetchMoveModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060252B7 RID: 152247 RVA: 0x00519B69 File Offset: 0x00517D69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060252B8 RID: 152248 RVA: 0x00519B7B File Offset: 0x00517D7B
		public IHookFetchMoveModeBaseT AsIHookFetchMoveModeBase()
		{
			return this.As<IHookFetchMoveModeBaseT>();
		}

		// Token: 0x060252B9 RID: 152249 RVA: 0x00519B83 File Offset: 0x00517D83
		public static IHookFetchMoveModeBase_UnionUnion FromIHookFetchMoveModeBase(IHookFetchMoveModeBaseT _ihookfetchmovemodebase)
		{
			return new IHookFetchMoveModeBase_UnionUnion
			{
				Type = IHookFetchMoveModeBase_Union.IHookFetchMoveModeBase,
				Value = _ihookfetchmovemodebase
			};
		}

		// Token: 0x060252BA RID: 152250 RVA: 0x00519B98 File Offset: 0x00517D98
		public IHookFetchMoveUniformT AsIHookFetchMoveUniform()
		{
			return this.As<IHookFetchMoveUniformT>();
		}

		// Token: 0x060252BB RID: 152251 RVA: 0x00519BA0 File Offset: 0x00517DA0
		public static IHookFetchMoveModeBase_UnionUnion FromIHookFetchMoveUniform(IHookFetchMoveUniformT _ihookfetchmoveuniform)
		{
			return new IHookFetchMoveModeBase_UnionUnion
			{
				Type = IHookFetchMoveModeBase_Union.IHookFetchMoveUniform,
				Value = _ihookfetchmoveuniform
			};
		}

		// Token: 0x060252BC RID: 152252 RVA: 0x00519BB8 File Offset: 0x00517DB8
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
