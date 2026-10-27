using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007657 RID: 30295
	public class TCameraShakeConfigUnion
	{
		// Token: 0x1700E5CD RID: 58829
		// (get) Token: 0x0603727E RID: 225918 RVA: 0x0077A620 File Offset: 0x00778820
		// (set) Token: 0x0603727F RID: 225919 RVA: 0x0077A628 File Offset: 0x00778828
		public TCameraShakeConfig Type { get; set; }

		// Token: 0x1700E5CE RID: 58830
		// (get) Token: 0x06037280 RID: 225920 RVA: 0x0077A631 File Offset: 0x00778831
		// (set) Token: 0x06037281 RID: 225921 RVA: 0x0077A639 File Offset: 0x00778839
		public object Value { get; set; }

		// Token: 0x06037282 RID: 225922 RVA: 0x0077A642 File Offset: 0x00778842
		public TCameraShakeConfigUnion()
		{
			this.Type = TCameraShakeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037283 RID: 225923 RVA: 0x0077A658 File Offset: 0x00778858
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037284 RID: 225924 RVA: 0x0077A66A File Offset: 0x0077886A
		public IConstantCameraShakeT AsIConstantCameraShake()
		{
			return this.As<IConstantCameraShakeT>();
		}

		// Token: 0x06037285 RID: 225925 RVA: 0x0077A672 File Offset: 0x00778872
		public static TCameraShakeConfigUnion FromIConstantCameraShake(IConstantCameraShakeT _iconstantcamerashake)
		{
			return new TCameraShakeConfigUnion
			{
				Type = TCameraShakeConfig.IConstantCameraShake,
				Value = _iconstantcamerashake
			};
		}

		// Token: 0x06037286 RID: 225926 RVA: 0x0077A687 File Offset: 0x00778887
		public ILinearOverRangeCameraShakeT AsILinearOverRangeCameraShake()
		{
			return this.As<ILinearOverRangeCameraShakeT>();
		}

		// Token: 0x06037287 RID: 225927 RVA: 0x0077A68F File Offset: 0x0077888F
		public static TCameraShakeConfigUnion FromILinearOverRangeCameraShake(ILinearOverRangeCameraShakeT _ilinearoverrangecamerashake)
		{
			return new TCameraShakeConfigUnion
			{
				Type = TCameraShakeConfig.ILinearOverRangeCameraShake,
				Value = _ilinearoverrangecamerashake
			};
		}

		// Token: 0x06037288 RID: 225928 RVA: 0x0077A6A4 File Offset: 0x007788A4
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
