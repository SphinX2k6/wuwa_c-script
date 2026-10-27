using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284C RID: 10316
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerVoiceDialogues : IInteractEffect
	{
		// Token: 0x0600E4AB RID: 58539 RVA: 0x0021A6A4 File Offset: 0x002188A4
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

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x0021A6C3 File Offset: 0x002188C3
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x0600E4AD RID: 58541 RVA: 0x0021A6D0 File Offset: 0x002188D0
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

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x0600E4AE RID: 58542 RVA: 0x0021A706 File Offset: 0x00218906
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

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x0600E4AF RID: 58543 RVA: 0x0021A73C File Offset: 0x0021893C
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

		// Token: 0x04007E84 RID: 32388
		private ITriggerVoiceDialogues Instance;

		// Token: 0x04007E85 RID: 32389
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04007E86 RID: 32390
		private bool _FlowInited;
	}
}
