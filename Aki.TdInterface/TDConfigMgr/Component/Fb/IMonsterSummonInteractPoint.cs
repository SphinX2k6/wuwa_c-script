using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC2 RID: 3266
	public class IMonsterSummonInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004AB0 RID: 19120 RVA: 0x000BADE8 File Offset: 0x000B8FE8
		[NullableContext(1)]
		public static IMonsterSummonInteractPoint Create(IMonsterSummonInteractPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterSummonInteractPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x000BAE07 File Offset: 0x000B9007
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x000BAE14 File Offset: 0x000B9014
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x000BAE24 File Offset: 0x000B9024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x04002AB1 RID: 10929
		private IMonsterSummonInteractPoint Instance;

		// Token: 0x04002AB2 RID: 10930
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002AB3 RID: 10931
		private bool _ActionsInited;
	}
}
