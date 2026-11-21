using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E65 RID: 32357
	public class TCameraShakeConfigUnion
	{
		// Token: 0x1700F20B RID: 61963
		// (get) Token: 0x0603A723 RID: 239395 RVA: 0x007DE71C File Offset: 0x007DC91C
		// (set) Token: 0x0603A724 RID: 239396 RVA: 0x007DE724 File Offset: 0x007DC924
		public TCameraShakeConfig Type { get; set; }

		// Token: 0x1700F20C RID: 61964
		// (get) Token: 0x0603A725 RID: 239397 RVA: 0x007DE72D File Offset: 0x007DC92D
		// (set) Token: 0x0603A726 RID: 239398 RVA: 0x007DE735 File Offset: 0x007DC935
		public object Value { get; set; }

		// Token: 0x0603A727 RID: 239399 RVA: 0x007DE73E File Offset: 0x007DC93E
		public TCameraShakeConfigUnion()
		{
			this.Type = TCameraShakeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603A728 RID: 239400 RVA: 0x007DE754 File Offset: 0x007DC954
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A729 RID: 239401 RVA: 0x007DE766 File Offset: 0x007DC966
		public IConstantCameraShakeT AsIConstantCameraShake()
		{
			return this.As<IConstantCameraShakeT>();
		}

		// Token: 0x0603A72A RID: 239402 RVA: 0x007DE76E File Offset: 0x007DC96E
		public static TCameraShakeConfigUnion FromIConstantCameraShake(IConstantCameraShakeT _iconstantcamerashake)
		{
			return new TCameraShakeConfigUnion
			{
				Type = TCameraShakeConfig.IConstantCameraShake,
				Value = _iconstantcamerashake
			};
		}

		// Token: 0x0603A72B RID: 239403 RVA: 0x007DE783 File Offset: 0x007DC983
		public ILinearOverRangeCameraShakeT AsILinearOverRangeCameraShake()
		{
			return this.As<ILinearOverRangeCameraShakeT>();
		}

		// Token: 0x0603A72C RID: 239404 RVA: 0x007DE78B File Offset: 0x007DC98B
		public static TCameraShakeConfigUnion FromILinearOverRangeCameraShake(ILinearOverRangeCameraShakeT _ilinearoverrangecamerashake)
		{
			return new TCameraShakeConfigUnion
			{
				Type = TCameraShakeConfig.ILinearOverRangeCameraShake,
				Value = _ilinearoverrangecamerashake
			};
		}

		// Token: 0x0603A72D RID: 239405 RVA: 0x007DE7A0 File Offset: 0x007DC9A0
		public static int Pack(FlatBufferBuilder builder, TCameraShakeConfigUnion _o)
		{
			TCameraShakeConfig type = _o.Type;
			if (type == TCameraShakeConfig.IConstantCameraShake)
			{
				return IConstantCameraShake.Pack(builder, _o.AsIConstantCameraShake()).Value;
			}
			if (type != TCameraShakeConfig.ILinearOverRangeCameraShake)
			{
				return 0;
			}
			return ILinearOverRangeCameraShake.Pack(builder, _o.AsILinearOverRangeCameraShake()).Value;
		}
	}
}
