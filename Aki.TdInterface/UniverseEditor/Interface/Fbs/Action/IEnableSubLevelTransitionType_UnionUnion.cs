using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200668E RID: 26254
	public class IEnableSubLevelTransitionType_UnionUnion
	{
		// Token: 0x1700C318 RID: 49944
		// (get) Token: 0x0602DA05 RID: 186885 RVA: 0x0063EC45 File Offset: 0x0063CE45
		// (set) Token: 0x0602DA06 RID: 186886 RVA: 0x0063EC4D File Offset: 0x0063CE4D
		public IEnableSubLevelTransitionType_Union Type { get; set; }

		// Token: 0x1700C319 RID: 49945
		// (get) Token: 0x0602DA07 RID: 186887 RVA: 0x0063EC56 File Offset: 0x0063CE56
		// (set) Token: 0x0602DA08 RID: 186888 RVA: 0x0063EC5E File Offset: 0x0063CE5E
		public object Value { get; set; }

		// Token: 0x0602DA09 RID: 186889 RVA: 0x0063EC67 File Offset: 0x0063CE67
		public IEnableSubLevelTransitionType_UnionUnion()
		{
			this.Type = IEnableSubLevelTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DA0A RID: 186890 RVA: 0x0063EC7D File Offset: 0x0063CE7D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DA0B RID: 186891 RVA: 0x0063EC8F File Offset: 0x0063CE8F
		public IEnableSubLevelTransitionTypeT AsIEnableSubLevelTransitionType()
		{
			return this.As<IEnableSubLevelTransitionTypeT>();
		}

		// Token: 0x0602DA0C RID: 186892 RVA: 0x0063EC97 File Offset: 0x0063CE97
		public static IEnableSubLevelTransitionType_UnionUnion FromIEnableSubLevelTransitionType(IEnableSubLevelTransitionTypeT _ienablesubleveltransitiontype)
		{
			return new IEnableSubLevelTransitionType_UnionUnion
			{
				Type = IEnableSubLevelTransitionType_Union.IEnableSubLevelTransitionType,
				Value = _ienablesubleveltransitiontype
			};
		}

		// Token: 0x0602DA0D RID: 186893 RVA: 0x0063ECAC File Offset: 0x0063CEAC
		public IEnableSubLevelTransitionWithSceneCaptureT AsIEnableSubLevelTransitionWithSceneCapture()
		{
			return this.As<IEnableSubLevelTransitionWithSceneCaptureT>();
		}

		// Token: 0x0602DA0E RID: 186894 RVA: 0x0063ECB4 File Offset: 0x0063CEB4
		public static IEnableSubLevelTransitionType_UnionUnion FromIEnableSubLevelTransitionWithSceneCapture(IEnableSubLevelTransitionWithSceneCaptureT _ienablesubleveltransitionwithscenecapture)
		{
			return new IEnableSubLevelTransitionType_UnionUnion
			{
				Type = IEnableSubLevelTransitionType_Union.IEnableSubLevelTransitionWithSceneCapture,
				Value = _ienablesubleveltransitionwithscenecapture
			};
		}

		// Token: 0x0602DA0F RID: 186895 RVA: 0x0063ECCC File Offset: 0x0063CECC
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
