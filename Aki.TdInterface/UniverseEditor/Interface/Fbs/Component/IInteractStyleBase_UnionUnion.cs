using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547A RID: 21626
	public class IInteractStyleBase_UnionUnion
	{
		// Token: 0x17009F29 RID: 40745
		// (get) Token: 0x06023927 RID: 145703 RVA: 0x004EB465 File Offset: 0x004E9665
		// (set) Token: 0x06023928 RID: 145704 RVA: 0x004EB46D File Offset: 0x004E966D
		public IInteractStyleBase_Union Type { get; set; }

		// Token: 0x17009F2A RID: 40746
		// (get) Token: 0x06023929 RID: 145705 RVA: 0x004EB476 File Offset: 0x004E9676
		// (set) Token: 0x0602392A RID: 145706 RVA: 0x004EB47E File Offset: 0x004E967E
		public object Value { get; set; }

		// Token: 0x0602392B RID: 145707 RVA: 0x004EB487 File Offset: 0x004E9687
		public IInteractStyleBase_UnionUnion()
		{
			this.Type = IInteractStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602392C RID: 145708 RVA: 0x004EB49D File Offset: 0x004E969D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602392D RID: 145709 RVA: 0x004EB4AF File Offset: 0x004E96AF
		public IInteractStyleBaseT AsIInteractStyleBase()
		{
			return this.As<IInteractStyleBaseT>();
		}

		// Token: 0x0602392E RID: 145710 RVA: 0x004EB4B7 File Offset: 0x004E96B7
		public static IInteractStyleBase_UnionUnion FromIInteractStyleBase(IInteractStyleBaseT _iinteractstylebase)
		{
			return new IInteractStyleBase_UnionUnion
			{
				Type = IInteractStyleBase_Union.IInteractStyleBase,
				Value = _iinteractstylebase
			};
		}

		// Token: 0x0602392F RID: 145711 RVA: 0x004EB4CC File Offset: 0x004E96CC
		public IInteractStylePanoramaT AsIInteractStylePanorama()
		{
			return this.As<IInteractStylePanoramaT>();
		}

		// Token: 0x06023930 RID: 145712 RVA: 0x004EB4D4 File Offset: 0x004E96D4
		public static IInteractStyleBase_UnionUnion FromIInteractStylePanorama(IInteractStylePanoramaT _iinteractstylepanorama)
		{
			return new IInteractStyleBase_UnionUnion
			{
				Type = IInteractStyleBase_Union.IInteractStylePanorama,
				Value = _iinteractstylepanorama
			};
		}

		// Token: 0x06023931 RID: 145713 RVA: 0x004EB4E9 File Offset: 0x004E96E9
		public IInteractStyleEntityPartT AsIInteractStyleEntityPart()
		{
			return this.As<IInteractStyleEntityPartT>();
		}

		// Token: 0x06023932 RID: 145714 RVA: 0x004EB4F1 File Offset: 0x004E96F1
		public static IInteractStyleBase_UnionUnion FromIInteractStyleEntityPart(IInteractStyleEntityPartT _iinteractstyleentitypart)
		{
			return new IInteractStyleBase_UnionUnion
			{
				Type = IInteractStyleBase_Union.IInteractStyleEntityPart,
				Value = _iinteractstyleentitypart
			};
		}

		// Token: 0x06023933 RID: 145715 RVA: 0x004EB508 File Offset: 0x004E9708
		public static int Pack(FlatBufferBuilder builder, IInteractStyleBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInteractStyleBase_Union.IInteractStyleBase:
				return IInteractStyleBase.Pack(builder, _o.AsIInteractStyleBase()).Value;
			case IInteractStyleBase_Union.IInteractStylePanorama:
				return IInteractStylePanorama.Pack(builder, _o.AsIInteractStylePanorama()).Value;
			case IInteractStyleBase_Union.IInteractStyleEntityPart:
				return IInteractStyleEntityPart.Pack(builder, _o.AsIInteractStyleEntityPart()).Value;
			default:
				return 0;
			}
		}
	}
}
