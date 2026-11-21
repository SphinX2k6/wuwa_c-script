using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D9B RID: 23963
	public class IProceduralVisualBase_UnionUnion
	{
		// Token: 0x1700B057 RID: 45143
		// (get) Token: 0x06027E7B RID: 163451 RVA: 0x005752D8 File Offset: 0x005734D8
		// (set) Token: 0x06027E7C RID: 163452 RVA: 0x005752E0 File Offset: 0x005734E0
		public IProceduralVisualBase_Union Type { get; set; }

		// Token: 0x1700B058 RID: 45144
		// (get) Token: 0x06027E7D RID: 163453 RVA: 0x005752E9 File Offset: 0x005734E9
		// (set) Token: 0x06027E7E RID: 163454 RVA: 0x005752F1 File Offset: 0x005734F1
		public object Value { get; set; }

		// Token: 0x06027E7F RID: 163455 RVA: 0x005752FA File Offset: 0x005734FA
		public IProceduralVisualBase_UnionUnion()
		{
			this.Type = IProceduralVisualBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027E80 RID: 163456 RVA: 0x00575310 File Offset: 0x00573510
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027E81 RID: 163457 RVA: 0x00575322 File Offset: 0x00573522
		public IProceduralVisualBaseT AsIProceduralVisualBase()
		{
			return this.As<IProceduralVisualBaseT>();
		}

		// Token: 0x06027E82 RID: 163458 RVA: 0x0057532A File Offset: 0x0057352A
		public static IProceduralVisualBase_UnionUnion FromIProceduralVisualBase(IProceduralVisualBaseT _iproceduralvisualbase)
		{
			return new IProceduralVisualBase_UnionUnion
			{
				Type = IProceduralVisualBase_Union.IProceduralVisualBase,
				Value = _iproceduralvisualbase
			};
		}

		// Token: 0x06027E83 RID: 163459 RVA: 0x0057533F File Offset: 0x0057353F
		public IProceduralVisualLookAtT AsIProceduralVisualLookAt()
		{
			return this.As<IProceduralVisualLookAtT>();
		}

		// Token: 0x06027E84 RID: 163460 RVA: 0x00575347 File Offset: 0x00573547
		public static IProceduralVisualBase_UnionUnion FromIProceduralVisualLookAt(IProceduralVisualLookAtT _iproceduralvisuallookat)
		{
			return new IProceduralVisualBase_UnionUnion
			{
				Type = IProceduralVisualBase_Union.IProceduralVisualLookAt,
				Value = _iproceduralvisuallookat
			};
		}

		// Token: 0x06027E85 RID: 163461 RVA: 0x0057535C File Offset: 0x0057355C
		public ISearchlightRotateT AsISearchlightRotate()
		{
			return this.As<ISearchlightRotateT>();
		}

		// Token: 0x06027E86 RID: 163462 RVA: 0x00575364 File Offset: 0x00573564
		public static IProceduralVisualBase_UnionUnion FromISearchlightRotate(ISearchlightRotateT _isearchlightrotate)
		{
			return new IProceduralVisualBase_UnionUnion
			{
				Type = IProceduralVisualBase_Union.ISearchlightRotate,
				Value = _isearchlightrotate
			};
		}

		// Token: 0x06027E87 RID: 163463 RVA: 0x0057537C File Offset: 0x0057357C
		public static int Pack(FlatBufferBuilder builder, IProceduralVisualBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IProceduralVisualBase_Union.IProceduralVisualBase:
				return IProceduralVisualBase.Pack(builder, _o.AsIProceduralVisualBase()).Value;
			case IProceduralVisualBase_Union.IProceduralVisualLookAt:
				return IProceduralVisualLookAt.Pack(builder, _o.AsIProceduralVisualLookAt()).Value;
			case IProceduralVisualBase_Union.ISearchlightRotate:
				return ISearchlightRotate.Pack(builder, _o.AsISearchlightRotate()).Value;
			default:
				return 0;
			}
		}
	}
}
