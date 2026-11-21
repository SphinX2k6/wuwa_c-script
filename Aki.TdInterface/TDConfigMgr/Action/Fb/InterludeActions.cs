using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002995 RID: 10645
	[NullableContext(2)]
	[Nullable(0)]
	public class InterludeActions : ActionParams
	{
		// Token: 0x0600EBFF RID: 60415 RVA: 0x0022BF9A File Offset: 0x0022A19A
		[NullableContext(0)]
		public static InterludeActions Create(IInterludeActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InterludeActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x0600EC00 RID: 60416 RVA: 0x0022BFBC File Offset: 0x0022A1BC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> InterludeActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._InterludeActionListInited)
				{
					return this._InterludeActionListCache;
				}
				this._InterludeActionListInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int interludeActionListLength = this.Instance.InterludeActionListLength;
				this._InterludeActionListCache = new List<ActionInfo>(interludeActionListLength);
				for (int i = 0; i < interludeActionListLength; i++)
				{
					this._InterludeActionListCache.Add(ActionInfo.Create(this.Instance.InterludeActionList(i)));
				}
				return this._InterludeActionListCache;
			}
		}

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x0600EC01 RID: 60417 RVA: 0x0022C038 File Offset: 0x0022A238
		public virtual List<int> DestroyEntityIds
		{
			get
			{
				if (this._DestroyEntityIdsInited)
				{
					return this._DestroyEntityIdsCache;
				}
				this._DestroyEntityIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int destroyEntityIdsLength = this.Instance.DestroyEntityIdsLength;
				this._DestroyEntityIdsCache = new List<int>(destroyEntityIdsLength);
				for (int i = 0; i < destroyEntityIdsLength; i++)
				{
					this._DestroyEntityIdsCache.Add(this.Instance.DestroyEntityIds(i));
				}
				return this._DestroyEntityIdsCache;
			}
		}

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x0600EC02 RID: 60418 RVA: 0x0022C0AD File Offset: 0x0022A2AD
		public virtual bool IsFadeIn
		{
			get
			{
				return this.Instance.IsFadeIn;
			}
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x0600EC03 RID: 60419 RVA: 0x0022C0BA File Offset: 0x0022A2BA
		public virtual bool IsFadeOut
		{
			get
			{
				return this.Instance.IsFadeOut;
			}
		}

		// Token: 0x040081F1 RID: 33265
		private IInterludeActions Instance;

		// Token: 0x040081F2 RID: 33266
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _InterludeActionListCache;

		// Token: 0x040081F3 RID: 33267
		private bool _InterludeActionListInited;

		// Token: 0x040081F4 RID: 33268
		private List<int> _DestroyEntityIdsCache;

		// Token: 0x040081F5 RID: 33269
		private bool _DestroyEntityIdsInited;
	}
}
