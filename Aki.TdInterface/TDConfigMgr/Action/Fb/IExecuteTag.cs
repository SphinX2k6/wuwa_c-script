using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002847 RID: 10311
	[NullableContext(1)]
	[Nullable(0)]
	public class IExecuteTag : IInteractEffect
	{
		// Token: 0x0600E493 RID: 58515 RVA: 0x0021A30B File Offset: 0x0021850B
		public static IExecuteTag Create(IExecuteTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecuteTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x0600E494 RID: 58516 RVA: 0x0021A32A File Offset: 0x0021852A
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x0600E495 RID: 58517 RVA: 0x0021A338 File Offset: 0x00218538
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

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x0600E496 RID: 58518 RVA: 0x0021A370 File Offset: 0x00218570
		public virtual List<int> Tags
		{
			get
			{
				if (this._TagsInited)
				{
					return this._TagsCache;
				}
				this._TagsInited = true;
				int tagsLength = this.Instance.TagsLength;
				this._TagsCache = new List<int>(tagsLength);
				for (int i = 0; i < tagsLength; i++)
				{
					this._TagsCache.Add(this.Instance.Tags(i));
				}
				return this._TagsCache;
			}
		}

		// Token: 0x04007E71 RID: 32369
		private IExecuteTag Instance;

		// Token: 0x04007E72 RID: 32370
		private List<int> _TagsCache;

		// Token: 0x04007E73 RID: 32371
		private bool _TagsInited;
	}
}
