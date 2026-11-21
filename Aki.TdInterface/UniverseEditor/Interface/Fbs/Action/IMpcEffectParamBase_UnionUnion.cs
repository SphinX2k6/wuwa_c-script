using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D5 RID: 29397
	public class IMpcEffectParamBase_UnionUnion
	{
		// Token: 0x1700D791 RID: 55185
		// (get) Token: 0x0603340B RID: 209931 RVA: 0x006EA129 File Offset: 0x006E8329
		// (set) Token: 0x0603340C RID: 209932 RVA: 0x006EA131 File Offset: 0x006E8331
		public IMpcEffectParamBase_Union Type { get; set; }

		// Token: 0x1700D792 RID: 55186
		// (get) Token: 0x0603340D RID: 209933 RVA: 0x006EA13A File Offset: 0x006E833A
		// (set) Token: 0x0603340E RID: 209934 RVA: 0x006EA142 File Offset: 0x006E8342
		public object Value { get; set; }

		// Token: 0x0603340F RID: 209935 RVA: 0x006EA14B File Offset: 0x006E834B
		public IMpcEffectParamBase_UnionUnion()
		{
			this.Type = IMpcEffectParamBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033410 RID: 209936 RVA: 0x006EA161 File Offset: 0x006E8361
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033411 RID: 209937 RVA: 0x006EA173 File Offset: 0x006E8373
		public IMpcEffectParamBaseT AsIMpcEffectParamBase()
		{
			return this.As<IMpcEffectParamBaseT>();
		}

		// Token: 0x06033412 RID: 209938 RVA: 0x006EA17B File Offset: 0x006E837B
		public static IMpcEffectParamBase_UnionUnion FromIMpcEffectParamBase(IMpcEffectParamBaseT _impceffectparambase)
		{
			return new IMpcEffectParamBase_UnionUnion
			{
				Type = IMpcEffectParamBase_Union.IMpcEffectParamBase,
				Value = _impceffectparambase
			};
		}

		// Token: 0x06033413 RID: 209939 RVA: 0x006EA190 File Offset: 0x006E8390
		public IPostProcessVolumeCenterPositionT AsIPostProcessVolumeCenterPosition()
		{
			return this.As<IPostProcessVolumeCenterPositionT>();
		}

		// Token: 0x06033414 RID: 209940 RVA: 0x006EA198 File Offset: 0x006E8398
		public static IMpcEffectParamBase_UnionUnion FromIPostProcessVolumeCenterPosition(IPostProcessVolumeCenterPositionT _ipostprocessvolumecenterposition)
		{
			return new IMpcEffectParamBase_UnionUnion
			{
				Type = IMpcEffectParamBase_Union.IPostProcessVolumeCenterPosition,
				Value = _ipostprocessvolumecenterposition
			};
		}

		// Token: 0x06033415 RID: 209941 RVA: 0x006EA1B0 File Offset: 0x006E83B0
		public static int Pack(FlatBufferBuilder builder, IMpcEffectParamBase_UnionUnion _o)
		{
			IMpcEffectParamBase_Union type = _o.Type;
			if (type == IMpcEffectParamBase_Union.IMpcEffectParamBase)
			{
				return IMpcEffectParamBase.Pack(builder, _o.AsIMpcEffectParamBase()).Value;
			}
			if (type != IMpcEffectParamBase_Union.IPostProcessVolumeCenterPosition)
			{
				return 0;
			}
			return IPostProcessVolumeCenterPosition.Pack(builder, _o.AsIPostProcessVolumeCenterPosition()).Value;
		}
	}
}
