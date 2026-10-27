using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C3 RID: 9923
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSubLevelTransitionWithSceneCapture : IEnableSubLevelTransitionType
	{
		// Token: 0x0600DDED RID: 56813 RVA: 0x0020F19D File Offset: 0x0020D39D
		[NullableContext(1)]
		public static IEnableSubLevelTransitionWithSceneCapture Create(IEnableSubLevelTransitionWithSceneCapture? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionWithSceneCapture
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x0600DDEE RID: 56814 RVA: 0x0020F1BC File Offset: 0x0020D3BC
		public override EEnableSubLevelTransitionType Type
		{
			get
			{
				return (EEnableSubLevelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x0600DDEF RID: 56815 RVA: 0x0020F1C9 File Offset: 0x0020D3C9
		public virtual string SceneCaptureEffect
		{
			get
			{
				return this.Instance.SceneCaptureEffect;
			}
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x0600DDF0 RID: 56816 RVA: 0x0020F1D6 File Offset: 0x0020D3D6
		public virtual string ScreenEffect
		{
			get
			{
				return this.Instance.ScreenEffect;
			}
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x0600DDF1 RID: 56817 RVA: 0x0020F1E3 File Offset: 0x0020D3E3
		public virtual string ScreenEffectLoop
		{
			get
			{
				return this.Instance.ScreenEffectLoop;
			}
		}

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x0600DDF2 RID: 56818 RVA: 0x0020F1F0 File Offset: 0x0020D3F0
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x0020F228 File Offset: 0x0020D428
		public virtual bool? IsAllowInput
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAllowInput);
			}
		}

		// Token: 0x04007B39 RID: 31545
		private IEnableSubLevelTransitionWithSceneCapture Instance;
	}
}
