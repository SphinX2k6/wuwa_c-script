using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B1E RID: 11038
	public class ITriggerDialogues : IInteractEffect
	{
		// Token: 0x0600F2CA RID: 62154 RVA: 0x00237402 File Offset: 0x00235602
		public static ITriggerDialogues Create(ITriggerDialogues? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerDialogues
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x0600F2CB RID: 62155 RVA: 0x00237421 File Offset: 0x00235621
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x0600F2CC RID: 62156 RVA: 0x00237430 File Offset: 0x00235630
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

		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x0600F2CD RID: 62157 RVA: 0x00237468 File Offset: 0x00235668
		public virtual List<string> Talks
		{
			get
			{
				if (this._TalksInited)
				{
					return this._TalksCache;
				}
				this._TalksInited = true;
				int talksLength = this.Instance.TalksLength;
				this._TalksCache = new List<string>(talksLength);
				for (int i = 0; i < talksLength; i++)
				{
					this._TalksCache.Add(this.Instance.Talks(i));
				}
				return this._TalksCache;
			}
		}

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x0600F2CE RID: 62158 RVA: 0x002374CC File Offset: 0x002356CC
		[Nullable(2)]
		public virtual IFocusObject FocusObject
		{
			[NullableContext(2)]
			get
			{
				if (this._FocusObjectInited)
				{
					return this._FocusObjectCache;
				}
				this._FocusObjectInited = true;
				this._FocusObjectCache = IFocusObject.Create(this.Instance.FocusObject);
				return this._FocusObjectCache;
			}
		}

		// Token: 0x0400853C RID: 34108
		private ITriggerDialogues Instance;

		// Token: 0x0400853D RID: 34109
		private List<string> _TalksCache;

		// Token: 0x0400853E RID: 34110
		private bool _TalksInited;

		// Token: 0x0400853F RID: 34111
		[Nullable(2)]
		private IFocusObject _FocusObjectCache;

		// Token: 0x04008540 RID: 34112
		private bool _FocusObjectInited;
	}
}
