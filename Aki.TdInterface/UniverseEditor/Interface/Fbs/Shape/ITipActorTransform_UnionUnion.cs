using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200406B RID: 16491
	public class ITipActorTransform_UnionUnion
	{
		// Token: 0x17007046 RID: 28742
		// (get) Token: 0x06016B0F RID: 92943 RVA: 0x0033E4CA File Offset: 0x0033C6CA
		// (set) Token: 0x06016B10 RID: 92944 RVA: 0x0033E4D2 File Offset: 0x0033C6D2
		public ITipActorTransform_Union Type { get; set; }

		// Token: 0x17007047 RID: 28743
		// (get) Token: 0x06016B11 RID: 92945 RVA: 0x0033E4DB File Offset: 0x0033C6DB
		// (set) Token: 0x06016B12 RID: 92946 RVA: 0x0033E4E3 File Offset: 0x0033C6E3
		public object Value { get; set; }

		// Token: 0x06016B13 RID: 92947 RVA: 0x0033E4EC File Offset: 0x0033C6EC
		public ITipActorTransform_UnionUnion()
		{
			this.Type = ITipActorTransform_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016B14 RID: 92948 RVA: 0x0033E502 File Offset: 0x0033C702
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016B15 RID: 92949 RVA: 0x0033E514 File Offset: 0x0033C714
		public ITipActorTransformT AsITipActorTransform()
		{
			return this.As<ITipActorTransformT>();
		}

		// Token: 0x06016B16 RID: 92950 RVA: 0x0033E51C File Offset: 0x0033C71C
		public static ITipActorTransform_UnionUnion FromITipActorTransform(ITipActorTransformT _itipactortransform)
		{
			return new ITipActorTransform_UnionUnion
			{
				Type = ITipActorTransform_Union.ITipActorTransform,
				Value = _itipactortransform
			};
		}

		// Token: 0x06016B17 RID: 92951 RVA: 0x0033E531 File Offset: 0x0033C731
		public IAbsoluteTipActorTransformT AsIAbsoluteTipActorTransform()
		{
			return this.As<IAbsoluteTipActorTransformT>();
		}

		// Token: 0x06016B18 RID: 92952 RVA: 0x0033E539 File Offset: 0x0033C739
		public static ITipActorTransform_UnionUnion FromIAbsoluteTipActorTransform(IAbsoluteTipActorTransformT _iabsolutetipactortransform)
		{
			return new ITipActorTransform_UnionUnion
			{
				Type = ITipActorTransform_Union.IAbsoluteTipActorTransform,
				Value = _iabsolutetipactortransform
			};
		}

		// Token: 0x06016B19 RID: 92953 RVA: 0x0033E54E File Offset: 0x0033C74E
		public IRelativeTipActorTransformT AsIRelativeTipActorTransform()
		{
			return this.As<IRelativeTipActorTransformT>();
		}

		// Token: 0x06016B1A RID: 92954 RVA: 0x0033E556 File Offset: 0x0033C756
		public static ITipActorTransform_UnionUnion FromIRelativeTipActorTransform(IRelativeTipActorTransformT _irelativetipactortransform)
		{
			return new ITipActorTransform_UnionUnion
			{
				Type = ITipActorTransform_Union.IRelativeTipActorTransform,
				Value = _irelativetipactortransform
			};
		}

		// Token: 0x06016B1B RID: 92955 RVA: 0x0033E56C File Offset: 0x0033C76C
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
