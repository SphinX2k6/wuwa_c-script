using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004071 RID: 16497
	public class ITipsActorTransformResult_UnionUnion
	{
		// Token: 0x17007053 RID: 28755
		// (get) Token: 0x06016B41 RID: 92993 RVA: 0x0033EAF6 File Offset: 0x0033CCF6
		// (set) Token: 0x06016B42 RID: 92994 RVA: 0x0033EAFE File Offset: 0x0033CCFE
		public ITipsActorTransformResult_Union Type { get; set; }

		// Token: 0x17007054 RID: 28756
		// (get) Token: 0x06016B43 RID: 92995 RVA: 0x0033EB07 File Offset: 0x0033CD07
		// (set) Token: 0x06016B44 RID: 92996 RVA: 0x0033EB0F File Offset: 0x0033CD0F
		public object Value { get; set; }

		// Token: 0x06016B45 RID: 92997 RVA: 0x0033EB18 File Offset: 0x0033CD18
		public ITipsActorTransformResult_UnionUnion()
		{
			this.Type = ITipsActorTransformResult_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016B46 RID: 92998 RVA: 0x0033EB2E File Offset: 0x0033CD2E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016B47 RID: 92999 RVA: 0x0033EB40 File Offset: 0x0033CD40
		public ITipsActorTransformResultT AsITipsActorTransformResult()
		{
			return this.As<ITipsActorTransformResultT>();
		}

		// Token: 0x06016B48 RID: 93000 RVA: 0x0033EB48 File Offset: 0x0033CD48
		public static ITipsActorTransformResult_UnionUnion FromITipsActorTransformResult(ITipsActorTransformResultT _itipsactortransformresult)
		{
			return new ITipsActorTransformResult_UnionUnion
			{
				Type = ITipsActorTransformResult_Union.ITipsActorTransformResult,
				Value = _itipsactortransformresult
			};
		}

		// Token: 0x06016B49 RID: 93001 RVA: 0x0033EB5D File Offset: 0x0033CD5D
		public IAbsoluteTipsActorTransformResultT AsIAbsoluteTipsActorTransformResult()
		{
			return this.As<IAbsoluteTipsActorTransformResultT>();
		}

		// Token: 0x06016B4A RID: 93002 RVA: 0x0033EB65 File Offset: 0x0033CD65
		public static ITipsActorTransformResult_UnionUnion FromIAbsoluteTipsActorTransformResult(IAbsoluteTipsActorTransformResultT _iabsolutetipsactortransformresult)
		{
			return new ITipsActorTransformResult_UnionUnion
			{
				Type = ITipsActorTransformResult_Union.IAbsoluteTipsActorTransformResult,
				Value = _iabsolutetipsactortransformresult
			};
		}

		// Token: 0x06016B4B RID: 93003 RVA: 0x0033EB7A File Offset: 0x0033CD7A
		public IRelativeTipsActorTransformResultT AsIRelativeTipsActorTransformResult()
		{
			return this.As<IRelativeTipsActorTransformResultT>();
		}

		// Token: 0x06016B4C RID: 93004 RVA: 0x0033EB82 File Offset: 0x0033CD82
		public static ITipsActorTransformResult_UnionUnion FromIRelativeTipsActorTransformResult(IRelativeTipsActorTransformResultT _irelativetipsactortransformresult)
		{
			return new ITipsActorTransformResult_UnionUnion
			{
				Type = ITipsActorTransformResult_Union.IRelativeTipsActorTransformResult,
				Value = _irelativetipsactortransformresult
			};
		}

		// Token: 0x06016B4D RID: 93005 RVA: 0x0033EB98 File Offset: 0x0033CD98
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
