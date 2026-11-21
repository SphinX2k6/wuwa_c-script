using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B1F RID: 11039
	public class ITriggerVoiceDialogues : IInteractEffect
	{
		// Token: 0x0600F2D0 RID: 62160 RVA: 0x00237508 File Offset: 0x00235708
		public static ITriggerVoiceDialogues Create(ITriggerVoiceDialogues? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerVoiceDialogues
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x0600F2D1 RID: 62161 RVA: 0x00237527 File Offset: 0x00235727
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x0600F2D2 RID: 62162 RVA: 0x00237534 File Offset: 0x00235734
		public override float? DelayTime
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

		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x0600F2D3 RID: 62163 RVA: 0x0023756A File Offset: 0x0023576A
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x0600F2D4 RID: 62164 RVA: 0x002375A0 File Offset: 0x002357A0
		public virtual bool? ShowTalker
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowTalker);
			}
		}

		// Token: 0x04008541 RID: 34113
		private ITriggerVoiceDialogues Instance;

		// Token: 0x04008542 RID: 34114
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04008543 RID: 34115
		private bool _FlowInited;
	}
}
