using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284B RID: 10315
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerDialogues : IInteractEffect
	{
		// Token: 0x0600E4A5 RID: 58533 RVA: 0x0021A59E File Offset: 0x0021879E
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

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x0600E4A6 RID: 58534 RVA: 0x0021A5BD File Offset: 0x002187BD
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x0600E4A7 RID: 58535 RVA: 0x0021A5CC File Offset: 0x002187CC
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

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x0600E4A8 RID: 58536 RVA: 0x0021A604 File Offset: 0x00218804
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

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x0600E4A9 RID: 58537 RVA: 0x0021A668 File Offset: 0x00218868
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

		// Token: 0x04007E7F RID: 32383
		private ITriggerDialogues Instance;

		// Token: 0x04007E80 RID: 32384
		private List<string> _TalksCache;

		// Token: 0x04007E81 RID: 32385
		private bool _TalksInited;

		// Token: 0x04007E82 RID: 32386
		[Nullable(2)]
		private IFocusObject _FocusObjectCache;

		// Token: 0x04007E83 RID: 32387
		private bool _FocusObjectInited;
	}
}
