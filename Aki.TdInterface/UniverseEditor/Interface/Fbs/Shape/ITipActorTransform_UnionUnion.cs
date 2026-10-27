using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C5C RID: 15452
	public class ITipActorTransform_UnionUnion
	{
		// Token: 0x17006A95 RID: 27285
		// (get) Token: 0x060155FB RID: 87547 RVA: 0x0031762A File Offset: 0x0031582A
		// (set) Token: 0x060155FC RID: 87548 RVA: 0x00317632 File Offset: 0x00315832
		public ITipActorTransform_Union Type { get; set; }

		// Token: 0x17006A96 RID: 27286
		// (get) Token: 0x060155FD RID: 87549 RVA: 0x0031763B File Offset: 0x0031583B
		// (set) Token: 0x060155FE RID: 87550 RVA: 0x00317643 File Offset: 0x00315843
		public object Value { get; set; }

		// Token: 0x060155FF RID: 87551 RVA: 0x0031764C File Offset: 0x0031584C
		public ITipActorTransform_UnionUnion()
		{
			this.Type = ITipActorTransform_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015600 RID: 87552 RVA: 0x00317662 File Offset: 0x00315862
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015601 RID: 87553 RVA: 0x00317674 File Offset: 0x00315874
		public ITipActorTransformT AsITipActorTransform()
		{
			return this.As<ITipActorTransformT>();
		}

		// Token: 0x06015602 RID: 87554 RVA: 0x0031767C File Offset: 0x0031587C
		public static ITipActorTransform_UnionUnion FromITipActorTransform(ITipActorTransformT _itipactortransform)
		{
			return new ITipActorTransform_UnionUnion
			{
				Type = ITipActorTransform_Union.ITipActorTransform,
				Value = _itipactortransform
			};
		}

		// Token: 0x06015603 RID: 87555 RVA: 0x00317691 File Offset: 0x00315891
		public IAbsoluteTipActorTransformT AsIAbsoluteTipActorTransform()
		{
			return this.As<IAbsoluteTipActorTransformT>();
		}

		// Token: 0x06015604 RID: 87556 RVA: 0x00317699 File Offset: 0x00315899
		public static ITipActorTransform_UnionUnion FromIAbsoluteTipActorTransform(IAbsoluteTipActorTransformT _iabsolutetipactortransform)
		{
			return new ITipActorTransform_UnionUnion
			{
				Type = ITipActorTransform_Union.IAbsoluteTipActorTransform,
				Value = _iabsolutetipactortransform
			};
		}

		// Token: 0x06015605 RID: 87557 RVA: 0x003176AE File Offset: 0x003158AE
		public IRelativeTipActorTransformT AsIRelativeTipActorTransform()
		{
			return this.As<IRelativeTipActorTransformT>();
		}

		// Token: 0x06015606 RID: 87558 RVA: 0x003176B6 File Offset: 0x003158B6
		public static ITipActorTransform_UnionUnion FromIRelativeTipActorTransform(IRelativeTipActorTransformT _irelativetipactortransform)
		{
			return new ITipActorTransform_UnionUnion
			{
				Type = ITipActorTransform_Union.IRelativeTipActorTransform,
				Value = _irelativetipactortransform
			};
		}

		// Token: 0x06015607 RID: 87559 RVA: 0x003176CC File Offset: 0x003158CC
		public static int Pack(FlatBufferBuilder builder, ITipActorTransform_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITipActorTransform_Union.ITipActorTransform:
				return ITipActorTransform.Pack(builder, _o.AsITipActorTransform()).Value;
			case ITipActorTransform_Union.IAbsoluteTipActorTransform:
				return IAbsoluteTipActorTransform.Pack(builder, _o.AsIAbsoluteTipActorTransform()).Value;
			case ITipActorTransform_Union.IRelativeTipActorTransform:
				return IRelativeTipActorTransform.Pack(builder, _o.AsIRelativeTipActorTransform()).Value;
			default:
				return 0;
			}
		}
	}
}
