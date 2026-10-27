using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002542 RID: 9538
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkCameraMotionPreset : IShowTalkCameraMotion
	{
		// Token: 0x0600D4A4 RID: 54436 RVA: 0x001F7D62 File Offset: 0x001F5F62
		public static IShowTalkCameraMotionPreset Create(IShowTalkCameraMotionPreset? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkCameraMotionPreset
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0600D4A5 RID: 54437 RVA: 0x001F7D81 File Offset: 0x001F5F81
		public override EShowTalkCameraMotionType Type
		{
			get
			{
				return (EShowTalkCameraMotionType)this.Instance.Type;
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600D4A6 RID: 54438 RVA: 0x001F7D8E File Offset: 0x001F5F8E
		public virtual string Sequence
		{
			get
			{
				return this.Instance.Sequence;
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600D4A7 RID: 54439 RVA: 0x001F7D9B File Offset: 0x001F5F9B
		[Nullable(2)]
		public virtual IFlowCameraShake CamShake
		{
			[NullableContext(2)]
			get
			{
				if (this._CamShakeInited)
				{
					return this._CamShakeCache;
				}
				this._CamShakeInited = true;
				this._CamShakeCache = IFlowCameraShake.Create(this.Instance.CamShake);
				return this._CamShakeCache;
			}
		}

		// Token: 0x0400748E RID: 29838
		private IShowTalkCameraMotionPreset Instance;

		// Token: 0x0400748F RID: 29839
		[Nullable(2)]
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x04007490 RID: 29840
		private bool _CamShakeInited;
	}
}
