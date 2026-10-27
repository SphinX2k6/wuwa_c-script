using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8E RID: 23694
	public class TProceduralVisualUnion
	{
		// Token: 0x1700B23C RID: 45628
		// (get) Token: 0x06028957 RID: 166231 RVA: 0x005943F6 File Offset: 0x005925F6
		// (set) Token: 0x06028958 RID: 166232 RVA: 0x005943FE File Offset: 0x005925FE
		public TProceduralVisual Type { get; set; }

		// Token: 0x1700B23D RID: 45629
		// (get) Token: 0x06028959 RID: 166233 RVA: 0x00594407 File Offset: 0x00592607
		// (set) Token: 0x0602895A RID: 166234 RVA: 0x0059440F File Offset: 0x0059260F
		public object Value { get; set; }

		// Token: 0x0602895B RID: 166235 RVA: 0x00594418 File Offset: 0x00592618
		public TProceduralVisualUnion()
		{
			this.Type = TProceduralVisual.NONE;
			this.Value = null;
		}

		// Token: 0x0602895C RID: 166236 RVA: 0x0059442E File Offset: 0x0059262E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602895D RID: 166237 RVA: 0x00594440 File Offset: 0x00592640
		public IProceduralVisualLookAtT AsIProceduralVisualLookAt()
		{
			return this.As<IProceduralVisualLookAtT>();
		}

		// Token: 0x0602895E RID: 166238 RVA: 0x00594448 File Offset: 0x00592648
		public static TProceduralVisualUnion FromIProceduralVisualLookAt(IProceduralVisualLookAtT _iproceduralvisuallookat)
		{
			return new TProceduralVisualUnion
			{
				Type = TProceduralVisual.IProceduralVisualLookAt,
				Value = _iproceduralvisuallookat
			};
		}

		// Token: 0x0602895F RID: 166239 RVA: 0x0059445D File Offset: 0x0059265D
		public ISearchlightRotateT AsISearchlightRotate()
		{
			return this.As<ISearchlightRotateT>();
		}

		// Token: 0x06028960 RID: 166240 RVA: 0x00594465 File Offset: 0x00592665
		public static TProceduralVisualUnion FromISearchlightRotate(ISearchlightRotateT _isearchlightrotate)
		{
			return new TProceduralVisualUnion
			{
				Type = TProceduralVisual.ISearchlightRotate,
				Value = _isearchlightrotate
			};
		}

		// Token: 0x06028961 RID: 166241 RVA: 0x0059447C File Offset: 0x0059267C
		public static int Pack(FlatBufferBuilder builder, TProceduralVisualUnion _o)
		{
			TProceduralVisual type = _o.Type;
			if (type == TProceduralVisual.IProceduralVisualLookAt)
			{
				return IProceduralVisualLookAt.Pack(builder, _o.AsIProceduralVisualLookAt()).Value;
			}
			if (type != TProceduralVisual.ISearchlightRotate)
			{
				return 0;
			}
			return ISearchlightRotate.Pack(builder, _o.AsISearchlightRotate()).Value;
		}
	}
}
