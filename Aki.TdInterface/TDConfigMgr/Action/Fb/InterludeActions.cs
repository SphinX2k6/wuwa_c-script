using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D1 RID: 9937
	[NullableContext(2)]
	[Nullable(0)]
	public class InterludeActions : ActionParams
	{
		// Token: 0x0600DE23 RID: 56867 RVA: 0x0020F75A File Offset: 0x0020D95A
		[NullableContext(1)]
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

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x0600DE24 RID: 56868 RVA: 0x0020F77C File Offset: 0x0020D97C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> InterludeActionList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x0600DE25 RID: 56869 RVA: 0x0020F7F8 File Offset: 0x0020D9F8
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

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x0600DE26 RID: 56870 RVA: 0x0020F86D File Offset: 0x0020DA6D
		public virtual bool IsFadeIn
		{
			get
			{
				return this.Instance.IsFadeIn;
			}
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x0600DE27 RID: 56871 RVA: 0x0020F87A File Offset: 0x0020DA7A
		public virtual bool IsFadeOut
		{
			get
			{
				return this.Instance.IsFadeOut;
			}
		}

		// Token: 0x04007B51 RID: 31569
		private IInterludeActions Instance;

		// Token: 0x04007B52 RID: 31570
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _InterludeActionListCache;

		// Token: 0x04007B53 RID: 31571
		private bool _InterludeActionListInited;

		// Token: 0x04007B54 RID: 31572
		private List<int> _DestroyEntityIdsCache;

		// Token: 0x04007B55 RID: 31573
		private bool _DestroyEntityIdsInited;
	}
}
