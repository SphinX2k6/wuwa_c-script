using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E9 RID: 10217
	public class IShowTalkCameraMotionPreset : IShowTalkCameraMotion
	{
		// Token: 0x0600E204 RID: 57860 RVA: 0x002137C2 File Offset: 0x002119C2
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

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x0600E205 RID: 57861 RVA: 0x002137E1 File Offset: 0x002119E1
		public override EShowTalkCameraMotionType Type
		{
			get
			{
				return (EShowTalkCameraMotionType)this.Instance.Type;
			}
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x0600E206 RID: 57862 RVA: 0x002137EE File Offset: 0x002119EE
		public virtual string Sequence
		{
			get
			{
				return this.Instance.Sequence;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x0600E207 RID: 57863 RVA: 0x002137FB File Offset: 0x002119FB
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

		// Token: 0x04007AE3 RID: 31459
		private IShowTalkCameraMotionPreset Instance;

		// Token: 0x04007AE4 RID: 31460
		[Nullable(2)]
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x04007AE5 RID: 31461
		private bool _CamShakeInited;
	}
}
