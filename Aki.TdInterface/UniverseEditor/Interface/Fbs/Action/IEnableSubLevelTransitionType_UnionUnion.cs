using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D08 RID: 27912
	public class IEnableSubLevelTransitionType_UnionUnion
	{
		// Token: 0x1700CCC9 RID: 52425
		// (get) Token: 0x06030222 RID: 197154 RVA: 0x0068BEF9 File Offset: 0x0068A0F9
		// (set) Token: 0x06030223 RID: 197155 RVA: 0x0068BF01 File Offset: 0x0068A101
		public IEnableSubLevelTransitionType_Union Type { get; set; }

		// Token: 0x1700CCCA RID: 52426
		// (get) Token: 0x06030224 RID: 197156 RVA: 0x0068BF0A File Offset: 0x0068A10A
		// (set) Token: 0x06030225 RID: 197157 RVA: 0x0068BF12 File Offset: 0x0068A112
		public object Value { get; set; }

		// Token: 0x06030226 RID: 197158 RVA: 0x0068BF1B File Offset: 0x0068A11B
		public IEnableSubLevelTransitionType_UnionUnion()
		{
			this.Type = IEnableSubLevelTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030227 RID: 197159 RVA: 0x0068BF31 File Offset: 0x0068A131
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030228 RID: 197160 RVA: 0x0068BF43 File Offset: 0x0068A143
		public IEnableSubLevelTransitionTypeT AsIEnableSubLevelTransitionType()
		{
			return this.As<IEnableSubLevelTransitionTypeT>();
		}

		// Token: 0x06030229 RID: 197161 RVA: 0x0068BF4B File Offset: 0x0068A14B
		public static IEnableSubLevelTransitionType_UnionUnion FromIEnableSubLevelTransitionType(IEnableSubLevelTransitionTypeT _ienablesubleveltransitiontype)
		{
			return new IEnableSubLevelTransitionType_UnionUnion
			{
				Type = IEnableSubLevelTransitionType_Union.IEnableSubLevelTransitionType,
				Value = _ienablesubleveltransitiontype
			};
		}

		// Token: 0x0603022A RID: 197162 RVA: 0x0068BF60 File Offset: 0x0068A160
		public IEnableSubLevelTransitionWithSceneCaptureT AsIEnableSubLevelTransitionWithSceneCapture()
		{
			return this.As<IEnableSubLevelTransitionWithSceneCaptureT>();
		}

		// Token: 0x0603022B RID: 197163 RVA: 0x0068BF68 File Offset: 0x0068A168
		public static IEnableSubLevelTransitionType_UnionUnion FromIEnableSubLevelTransitionWithSceneCapture(IEnableSubLevelTransitionWithSceneCaptureT _ienablesubleveltransitionwithscenecapture)
		{
			return new IEnableSubLevelTransitionType_UnionUnion
			{
				Type = IEnableSubLevelTransitionType_Union.IEnableSubLevelTransitionWithSceneCapture,
				Value = _ienablesubleveltransitionwithscenecapture
			};
		}

		// Token: 0x0603022C RID: 197164 RVA: 0x0068BF80 File Offset: 0x0068A180
		public static int Pack(FlatBufferBuilder builder, IEnableSubLevelTransitionType_UnionUnion _o)
		{
			IEnableSubLevelTransitionType_Union type = _o.Type;
			if (type == IEnableSubLevelTransitionType_Union.IEnableSubLevelTransitionType)
			{
				return IEnableSubLevelTransitionType.Pack(builder, _o.AsIEnableSubLevelTransitionType()).Value;
			}
			if (type != IEnableSubLevelTransitionType_Union.IEnableSubLevelTransitionWithSceneCapture)
			{
				return 0;
			}
			return IEnableSubLevelTransitionWithSceneCapture.Pack(builder, _o.AsIEnableSubLevelTransitionWithSceneCapture()).Value;
		}
	}
}
