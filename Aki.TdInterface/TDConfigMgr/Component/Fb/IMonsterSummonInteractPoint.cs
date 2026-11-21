using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA4 RID: 3492
	public class IMonsterSummonInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004F5E RID: 20318 RVA: 0x000C57F8 File Offset: 0x000C39F8
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

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x000C5817 File Offset: 0x000C3A17
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x000C5824 File Offset: 0x000C3A24
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06004F61 RID: 20321 RVA: 0x000C5834 File Offset: 0x000C3A34
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04002D2B RID: 11563
		private IMonsterSummonInteractPoint Instance;

		// Token: 0x04002D2C RID: 11564
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002D2D RID: 11565
		private bool _ActionsInited;
	}
}
