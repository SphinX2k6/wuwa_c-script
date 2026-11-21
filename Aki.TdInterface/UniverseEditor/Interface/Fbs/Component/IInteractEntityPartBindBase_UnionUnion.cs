using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CD RID: 22989
	public class IInteractEntityPartBindBase_UnionUnion
	{
		// Token: 0x1700A715 RID: 42773
		// (get) Token: 0x06025867 RID: 153703 RVA: 0x00525F2D File Offset: 0x0052412D
		// (set) Token: 0x06025868 RID: 153704 RVA: 0x00525F35 File Offset: 0x00524135
		public IInteractEntityPartBindBase_Union Type { get; set; }

		// Token: 0x1700A716 RID: 42774
		// (get) Token: 0x06025869 RID: 153705 RVA: 0x00525F3E File Offset: 0x0052413E
		// (set) Token: 0x0602586A RID: 153706 RVA: 0x00525F46 File Offset: 0x00524146
		public object Value { get; set; }

		// Token: 0x0602586B RID: 153707 RVA: 0x00525F4F File Offset: 0x0052414F
		public IInteractEntityPartBindBase_UnionUnion()
		{
			this.Type = IInteractEntityPartBindBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602586C RID: 153708 RVA: 0x00525F65 File Offset: 0x00524165
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602586D RID: 153709 RVA: 0x00525F77 File Offset: 0x00524177
		public IInteractEntityPartBindBaseT AsIInteractEntityPartBindBase()
		{
			return this.As<IInteractEntityPartBindBaseT>();
		}

		// Token: 0x0602586E RID: 153710 RVA: 0x00525F7F File Offset: 0x0052417F
		public static IInteractEntityPartBindBase_UnionUnion FromIInteractEntityPartBindBase(IInteractEntityPartBindBaseT _iinteractentitypartbindbase)
		{
			return new IInteractEntityPartBindBase_UnionUnion
			{
				Type = IInteractEntityPartBindBase_Union.IInteractEntityPartBindBase,
				Value = _iinteractentitypartbindbase
			};
		}

		// Token: 0x0602586F RID: 153711 RVA: 0x00525F94 File Offset: 0x00524194
		public IInteractEntityPartPrefabBindT AsIInteractEntityPartPrefabBind()
		{
			return this.As<IInteractEntityPartPrefabBindT>();
		}

		// Token: 0x06025870 RID: 153712 RVA: 0x00525F9C File Offset: 0x0052419C
		public static IInteractEntityPartBindBase_UnionUnion FromIInteractEntityPartPrefabBind(IInteractEntityPartPrefabBindT _iinteractentitypartprefabbind)
		{
			return new IInteractEntityPartBindBase_UnionUnion
			{
				Type = IInteractEntityPartBindBase_Union.IInteractEntityPartPrefabBind,
				Value = _iinteractentitypartprefabbind
			};
		}

		// Token: 0x06025871 RID: 153713 RVA: 0x00525FB1 File Offset: 0x005241B1
		public IInteractEntityPartModelBindT AsIInteractEntityPartModelBind()
		{
			return this.As<IInteractEntityPartModelBindT>();
		}

		// Token: 0x06025872 RID: 153714 RVA: 0x00525FB9 File Offset: 0x005241B9
		public static IInteractEntityPartBindBase_UnionUnion FromIInteractEntityPartModelBind(IInteractEntityPartModelBindT _iinteractentitypartmodelbind)
		{
			return new IInteractEntityPartBindBase_UnionUnion
			{
				Type = IInteractEntityPartBindBase_Union.IInteractEntityPartModelBind,
				Value = _iinteractentitypartmodelbind
			};
		}

		// Token: 0x06025873 RID: 153715 RVA: 0x00525FD0 File Offset: 0x005241D0
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
