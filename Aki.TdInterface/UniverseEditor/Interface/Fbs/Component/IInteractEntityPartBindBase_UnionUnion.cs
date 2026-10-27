using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005447 RID: 21575
	public class IInteractEntityPartBindBase_UnionUnion
	{
		// Token: 0x17009EDB RID: 40667
		// (get) Token: 0x060237AF RID: 145327 RVA: 0x004E8EB9 File Offset: 0x004E70B9
		// (set) Token: 0x060237B0 RID: 145328 RVA: 0x004E8EC1 File Offset: 0x004E70C1
		public IInteractEntityPartBindBase_Union Type { get; set; }

		// Token: 0x17009EDC RID: 40668
		// (get) Token: 0x060237B1 RID: 145329 RVA: 0x004E8ECA File Offset: 0x004E70CA
		// (set) Token: 0x060237B2 RID: 145330 RVA: 0x004E8ED2 File Offset: 0x004E70D2
		public object Value { get; set; }

		// Token: 0x060237B3 RID: 145331 RVA: 0x004E8EDB File Offset: 0x004E70DB
		public IInteractEntityPartBindBase_UnionUnion()
		{
			this.Type = IInteractEntityPartBindBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060237B4 RID: 145332 RVA: 0x004E8EF1 File Offset: 0x004E70F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060237B5 RID: 145333 RVA: 0x004E8F03 File Offset: 0x004E7103
		public IInteractEntityPartBindBaseT AsIInteractEntityPartBindBase()
		{
			return this.As<IInteractEntityPartBindBaseT>();
		}

		// Token: 0x060237B6 RID: 145334 RVA: 0x004E8F0B File Offset: 0x004E710B
		public static IInteractEntityPartBindBase_UnionUnion FromIInteractEntityPartBindBase(IInteractEntityPartBindBaseT _iinteractentitypartbindbase)
		{
			return new IInteractEntityPartBindBase_UnionUnion
			{
				Type = IInteractEntityPartBindBase_Union.IInteractEntityPartBindBase,
				Value = _iinteractentitypartbindbase
			};
		}

		// Token: 0x060237B7 RID: 145335 RVA: 0x004E8F20 File Offset: 0x004E7120
		public IInteractEntityPartPrefabBindT AsIInteractEntityPartPrefabBind()
		{
			return this.As<IInteractEntityPartPrefabBindT>();
		}

		// Token: 0x060237B8 RID: 145336 RVA: 0x004E8F28 File Offset: 0x004E7128
		public static IInteractEntityPartBindBase_UnionUnion FromIInteractEntityPartPrefabBind(IInteractEntityPartPrefabBindT _iinteractentitypartprefabbind)
		{
			return new IInteractEntityPartBindBase_UnionUnion
			{
				Type = IInteractEntityPartBindBase_Union.IInteractEntityPartPrefabBind,
				Value = _iinteractentitypartprefabbind
			};
		}

		// Token: 0x060237B9 RID: 145337 RVA: 0x004E8F3D File Offset: 0x004E713D
		public IInteractEntityPartModelBindT AsIInteractEntityPartModelBind()
		{
			return this.As<IInteractEntityPartModelBindT>();
		}

		// Token: 0x060237BA RID: 145338 RVA: 0x004E8F45 File Offset: 0x004E7145
		public static IInteractEntityPartBindBase_UnionUnion FromIInteractEntityPartModelBind(IInteractEntityPartModelBindT _iinteractentitypartmodelbind)
		{
			return new IInteractEntityPartBindBase_UnionUnion
			{
				Type = IInteractEntityPartBindBase_Union.IInteractEntityPartModelBind,
				Value = _iinteractentitypartmodelbind
			};
		}

		// Token: 0x060237BB RID: 145339 RVA: 0x004E8F5C File Offset: 0x004E715C
		public static int Pack(FlatBufferBuilder builder, IInteractEntityPartBindBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInteractEntityPartBindBase_Union.IInteractEntityPartBindBase:
				return IInteractEntityPartBindBase.Pack(builder, _o.AsIInteractEntityPartBindBase()).Value;
			case IInteractEntityPartBindBase_Union.IInteractEntityPartPrefabBind:
				return IInteractEntityPartPrefabBind.Pack(builder, _o.AsIInteractEntityPartPrefabBind()).Value;
			case IInteractEntityPartBindBase_Union.IInteractEntityPartModelBind:
				return IInteractEntityPartModelBind.Pack(builder, _o.AsIInteractEntityPartModelBind()).Value;
			default:
				return 0;
			}
		}
	}
}
