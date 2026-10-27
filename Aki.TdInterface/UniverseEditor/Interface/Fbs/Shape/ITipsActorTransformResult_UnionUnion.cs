using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C62 RID: 15458
	public class ITipsActorTransformResult_UnionUnion
	{
		// Token: 0x17006AA2 RID: 27298
		// (get) Token: 0x0601562D RID: 87597 RVA: 0x00317C56 File Offset: 0x00315E56
		// (set) Token: 0x0601562E RID: 87598 RVA: 0x00317C5E File Offset: 0x00315E5E
		public ITipsActorTransformResult_Union Type { get; set; }

		// Token: 0x17006AA3 RID: 27299
		// (get) Token: 0x0601562F RID: 87599 RVA: 0x00317C67 File Offset: 0x00315E67
		// (set) Token: 0x06015630 RID: 87600 RVA: 0x00317C6F File Offset: 0x00315E6F
		public object Value { get; set; }

		// Token: 0x06015631 RID: 87601 RVA: 0x00317C78 File Offset: 0x00315E78
		public ITipsActorTransformResult_UnionUnion()
		{
			this.Type = ITipsActorTransformResult_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015632 RID: 87602 RVA: 0x00317C8E File Offset: 0x00315E8E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015633 RID: 87603 RVA: 0x00317CA0 File Offset: 0x00315EA0
		public ITipsActorTransformResultT AsITipsActorTransformResult()
		{
			return this.As<ITipsActorTransformResultT>();
		}

		// Token: 0x06015634 RID: 87604 RVA: 0x00317CA8 File Offset: 0x00315EA8
		public static ITipsActorTransformResult_UnionUnion FromITipsActorTransformResult(ITipsActorTransformResultT _itipsactortransformresult)
		{
			return new ITipsActorTransformResult_UnionUnion
			{
				Type = ITipsActorTransformResult_Union.ITipsActorTransformResult,
				Value = _itipsactortransformresult
			};
		}

		// Token: 0x06015635 RID: 87605 RVA: 0x00317CBD File Offset: 0x00315EBD
		public IAbsoluteTipsActorTransformResultT AsIAbsoluteTipsActorTransformResult()
		{
			return this.As<IAbsoluteTipsActorTransformResultT>();
		}

		// Token: 0x06015636 RID: 87606 RVA: 0x00317CC5 File Offset: 0x00315EC5
		public static ITipsActorTransformResult_UnionUnion FromIAbsoluteTipsActorTransformResult(IAbsoluteTipsActorTransformResultT _iabsolutetipsactortransformresult)
		{
			return new ITipsActorTransformResult_UnionUnion
			{
				Type = ITipsActorTransformResult_Union.IAbsoluteTipsActorTransformResult,
				Value = _iabsolutetipsactortransformresult
			};
		}

		// Token: 0x06015637 RID: 87607 RVA: 0x00317CDA File Offset: 0x00315EDA
		public IRelativeTipsActorTransformResultT AsIRelativeTipsActorTransformResult()
		{
			return this.As<IRelativeTipsActorTransformResultT>();
		}

		// Token: 0x06015638 RID: 87608 RVA: 0x00317CE2 File Offset: 0x00315EE2
		public static ITipsActorTransformResult_UnionUnion FromIRelativeTipsActorTransformResult(IRelativeTipsActorTransformResultT _irelativetipsactortransformresult)
		{
			return new ITipsActorTransformResult_UnionUnion
			{
				Type = ITipsActorTransformResult_Union.IRelativeTipsActorTransformResult,
				Value = _irelativetipsactortransformresult
			};
		}

		// Token: 0x06015639 RID: 87609 RVA: 0x00317CF8 File Offset: 0x00315EF8
		public static int Pack(FlatBufferBuilder builder, ITipsActorTransformResult_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITipsActorTransformResult_Union.ITipsActorTransformResult:
				return ITipsActorTransformResult.Pack(builder, _o.AsITipsActorTransformResult()).Value;
			case ITipsActorTransformResult_Union.IAbsoluteTipsActorTransformResult:
				return IAbsoluteTipsActorTransformResult.Pack(builder, _o.AsIAbsoluteTipsActorTransformResult()).Value;
			case ITipsActorTransformResult_Union.IRelativeTipsActorTransformResult:
				return IRelativeTipsActorTransformResult.Pack(builder, _o.AsIRelativeTipsActorTransformResult()).Value;
			default:
				return 0;
			}
		}
	}
}
