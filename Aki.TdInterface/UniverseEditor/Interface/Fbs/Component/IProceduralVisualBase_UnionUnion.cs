using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005794 RID: 22420
	public class IProceduralVisualBase_UnionUnion
	{
		// Token: 0x1700A733 RID: 42803
		// (get) Token: 0x0602595B RID: 153947 RVA: 0x0052F14C File Offset: 0x0052D34C
		// (set) Token: 0x0602595C RID: 153948 RVA: 0x0052F154 File Offset: 0x0052D354
		public IProceduralVisualBase_Union Type { get; set; }

		// Token: 0x1700A734 RID: 42804
		// (get) Token: 0x0602595D RID: 153949 RVA: 0x0052F15D File Offset: 0x0052D35D
		// (set) Token: 0x0602595E RID: 153950 RVA: 0x0052F165 File Offset: 0x0052D365
		public object Value { get; set; }

		// Token: 0x0602595F RID: 153951 RVA: 0x0052F16E File Offset: 0x0052D36E
		public IProceduralVisualBase_UnionUnion()
		{
			this.Type = IProceduralVisualBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025960 RID: 153952 RVA: 0x0052F184 File Offset: 0x0052D384
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025961 RID: 153953 RVA: 0x0052F196 File Offset: 0x0052D396
		public IProceduralVisualBaseT AsIProceduralVisualBase()
		{
			return this.As<IProceduralVisualBaseT>();
		}

		// Token: 0x06025962 RID: 153954 RVA: 0x0052F19E File Offset: 0x0052D39E
		public static IProceduralVisualBase_UnionUnion FromIProceduralVisualBase(IProceduralVisualBaseT _iproceduralvisualbase)
		{
			return new IProceduralVisualBase_UnionUnion
			{
				Type = IProceduralVisualBase_Union.IProceduralVisualBase,
				Value = _iproceduralvisualbase
			};
		}

		// Token: 0x06025963 RID: 153955 RVA: 0x0052F1B3 File Offset: 0x0052D3B3
		public IProceduralVisualLookAtT AsIProceduralVisualLookAt()
		{
			return this.As<IProceduralVisualLookAtT>();
		}

		// Token: 0x06025964 RID: 153956 RVA: 0x0052F1BB File Offset: 0x0052D3BB
		public static IProceduralVisualBase_UnionUnion FromIProceduralVisualLookAt(IProceduralVisualLookAtT _iproceduralvisuallookat)
		{
			return new IProceduralVisualBase_UnionUnion
			{
				Type = IProceduralVisualBase_Union.IProceduralVisualLookAt,
				Value = _iproceduralvisuallookat
			};
		}

		// Token: 0x06025965 RID: 153957 RVA: 0x0052F1D0 File Offset: 0x0052D3D0
		public ISearchlightRotateT AsISearchlightRotate()
		{
			return this.As<ISearchlightRotateT>();
		}

		// Token: 0x06025966 RID: 153958 RVA: 0x0052F1D8 File Offset: 0x0052D3D8
		public static IProceduralVisualBase_UnionUnion FromISearchlightRotate(ISearchlightRotateT _isearchlightrotate)
		{
			return new IProceduralVisualBase_UnionUnion
			{
				Type = IProceduralVisualBase_Union.ISearchlightRotate,
				Value = _isearchlightrotate
			};
		}

		// Token: 0x06025967 RID: 153959 RVA: 0x0052F1F0 File Offset: 0x0052D3F0
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
