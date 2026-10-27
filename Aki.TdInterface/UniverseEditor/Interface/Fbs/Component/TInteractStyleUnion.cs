using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4C RID: 23628
	public class TInteractStyleUnion
	{
		// Token: 0x1700B210 RID: 45584
		// (get) Token: 0x06028819 RID: 165913 RVA: 0x005926EA File Offset: 0x005908EA
		// (set) Token: 0x0602881A RID: 165914 RVA: 0x005926F2 File Offset: 0x005908F2
		public TInteractStyle Type { get; set; }

		// Token: 0x1700B211 RID: 45585
		// (get) Token: 0x0602881B RID: 165915 RVA: 0x005926FB File Offset: 0x005908FB
		// (set) Token: 0x0602881C RID: 165916 RVA: 0x00592703 File Offset: 0x00590903
		public object Value { get; set; }

		// Token: 0x0602881D RID: 165917 RVA: 0x0059270C File Offset: 0x0059090C
		public TInteractStyleUnion()
		{
			this.Type = TInteractStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0602881E RID: 165918 RVA: 0x00592722 File Offset: 0x00590922
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602881F RID: 165919 RVA: 0x00592734 File Offset: 0x00590934
		public IInteractStyleEntityPartT AsIInteractStyleEntityPart()
		{
			return this.As<IInteractStyleEntityPartT>();
		}

		// Token: 0x06028820 RID: 165920 RVA: 0x0059273C File Offset: 0x0059093C
		public static TInteractStyleUnion FromIInteractStyleEntityPart(IInteractStyleEntityPartT _iinteractstyleentitypart)
		{
			return new TInteractStyleUnion
			{
				Type = TInteractStyle.IInteractStyleEntityPart,
				Value = _iinteractstyleentitypart
			};
		}

		// Token: 0x06028821 RID: 165921 RVA: 0x00592751 File Offset: 0x00590951
		public IInteractStylePanoramaT AsIInteractStylePanorama()
		{
			return this.As<IInteractStylePanoramaT>();
		}

		// Token: 0x06028822 RID: 165922 RVA: 0x00592759 File Offset: 0x00590959
		public static TInteractStyleUnion FromIInteractStylePanorama(IInteractStylePanoramaT _iinteractstylepanorama)
		{
			return new TInteractStyleUnion
			{
				Type = TInteractStyle.IInteractStylePanorama,
				Value = _iinteractstylepanorama
			};
		}

		// Token: 0x06028823 RID: 165923 RVA: 0x00592770 File Offset: 0x00590970
		public static int Pack(FlatBufferBuilder builder, TInteractStyleUnion _o)
		{
			TInteractStyle type = _o.Type;
			if (type == TInteractStyle.IInteractStyleEntityPart)
			{
				return IInteractStyleEntityPart.Pack(builder, _o.AsIInteractStyleEntityPart()).Value;
			}
			if (type != TInteractStyle.IInteractStylePanorama)
			{
				return 0;
			}
			return IInteractStylePanorama.Pack(builder, _o.AsIInteractStylePanorama()).Value;
		}
	}
}
