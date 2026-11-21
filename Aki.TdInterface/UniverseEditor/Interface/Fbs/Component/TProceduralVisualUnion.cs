using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062BF RID: 25279
	public class TProceduralVisualUnion
	{
		// Token: 0x1700BB96 RID: 48022
		// (get) Token: 0x0602AF9D RID: 176029 RVA: 0x005DCB2E File Offset: 0x005DAD2E
		// (set) Token: 0x0602AF9E RID: 176030 RVA: 0x005DCB36 File Offset: 0x005DAD36
		public TProceduralVisual Type { get; set; }

		// Token: 0x1700BB97 RID: 48023
		// (get) Token: 0x0602AF9F RID: 176031 RVA: 0x005DCB3F File Offset: 0x005DAD3F
		// (set) Token: 0x0602AFA0 RID: 176032 RVA: 0x005DCB47 File Offset: 0x005DAD47
		public object Value { get; set; }

		// Token: 0x0602AFA1 RID: 176033 RVA: 0x005DCB50 File Offset: 0x005DAD50
		public TProceduralVisualUnion()
		{
			this.Type = TProceduralVisual.NONE;
			this.Value = null;
		}

		// Token: 0x0602AFA2 RID: 176034 RVA: 0x005DCB66 File Offset: 0x005DAD66
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AFA3 RID: 176035 RVA: 0x005DCB78 File Offset: 0x005DAD78
		public IProceduralVisualLookAtT AsIProceduralVisualLookAt()
		{
			return this.As<IProceduralVisualLookAtT>();
		}

		// Token: 0x0602AFA4 RID: 176036 RVA: 0x005DCB80 File Offset: 0x005DAD80
		public static TProceduralVisualUnion FromIProceduralVisualLookAt(IProceduralVisualLookAtT _iproceduralvisuallookat)
		{
			return new TProceduralVisualUnion
			{
				Type = TProceduralVisual.IProceduralVisualLookAt,
				Value = _iproceduralvisuallookat
			};
		}

		// Token: 0x0602AFA5 RID: 176037 RVA: 0x005DCB95 File Offset: 0x005DAD95
		public ISearchlightRotateT AsISearchlightRotate()
		{
			return this.As<ISearchlightRotateT>();
		}

		// Token: 0x0602AFA6 RID: 176038 RVA: 0x005DCB9D File Offset: 0x005DAD9D
		public static TProceduralVisualUnion FromISearchlightRotate(ISearchlightRotateT _isearchlightrotate)
		{
			return new TProceduralVisualUnion
			{
				Type = TProceduralVisual.ISearchlightRotate,
				Value = _isearchlightrotate
			};
		}

		// Token: 0x0602AFA7 RID: 176039 RVA: 0x005DCBB4 File Offset: 0x005DADB4
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
