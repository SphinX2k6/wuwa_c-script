using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015BE RID: 5566
	public class ILogicNodeOccupation
	{
		// Token: 0x06007D9F RID: 32159 RVA: 0x0012AC5D File Offset: 0x00128E5D
		public static ILogicNodeOccupation Create(ILogicNodeOccupation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILogicNodeOccupation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x06007DA0 RID: 32160 RVA: 0x0012AC7C File Offset: 0x00128E7C
		public virtual List<string> Occupations
		{
			get
			{
				if (this._OccupationsInited)
				{
					return this._OccupationsCache;
				}
				this._OccupationsInited = true;
				int occupationsLength = this.Instance.OccupationsLength;
				this._OccupationsCache = new List<string>(occupationsLength);
				for (int i = 0; i < occupationsLength; i++)
				{
					this._OccupationsCache.Add(this.Instance.Occupations(i));
				}
				return this._OccupationsCache;
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x06007DA1 RID: 32161 RVA: 0x0012ACE0 File Offset: 0x00128EE0
		public virtual string TidDesc
		{
			get
			{
				return this.Instance.TidDesc;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x06007DA2 RID: 32162 RVA: 0x0012ACF0 File Offset: 0x00128EF0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> ExitActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ExitActionsInited)
				{
					return this._ExitActionsCache;
				}
				this._ExitActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int exitActionsLength = this.Instance.ExitActionsLength;
				this._ExitActionsCache = new List<ActionInfo>(exitActionsLength);
				for (int i = 0; i < exitActionsLength; i++)
				{
					this._ExitActionsCache.Add(ActionInfo.Create(this.Instance.ExitActions(i)));
				}
				return this._ExitActionsCache;
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x06007DA3 RID: 32163 RVA: 0x0012AD6C File Offset: 0x00128F6C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> ReenterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ReenterActionsInited)
				{
					return this._ReenterActionsCache;
				}
				this._ReenterActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int reenterActionsLength = this.Instance.ReenterActionsLength;
				this._ReenterActionsCache = new List<ActionInfo>(reenterActionsLength);
				for (int i = 0; i < reenterActionsLength; i++)
				{
					this._ReenterActionsCache.Add(ActionInfo.Create(this.Instance.ReenterActions(i)));
				}
				return this._ReenterActionsCache;
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x06007DA4 RID: 32164 RVA: 0x0012ADE8 File Offset: 0x00128FE8
		[Nullable(2)]
		public virtual List<int> BanInteractEntities
		{
			[NullableContext(2)]
			get
			{
				if (this._BanInteractEntitiesInited)
				{
					return this._BanInteractEntitiesCache;
				}
				this._BanInteractEntitiesInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int banInteractEntitiesLength = this.Instance.BanInteractEntitiesLength;
				this._BanInteractEntitiesCache = new List<int>(banInteractEntitiesLength);
				for (int i = 0; i < banInteractEntitiesLength; i++)
				{
					this._BanInteractEntitiesCache.Add(this.Instance.BanInteractEntities(i));
				}
				return this._BanInteractEntitiesCache;
			}
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x06007DA5 RID: 32165 RVA: 0x0012AE60 File Offset: 0x00129060
		public virtual bool? ReclaimOccupationWhenEnter
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ReclaimOccupationWhenEnter);
			}
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x06007DA6 RID: 32166 RVA: 0x0012AE96 File Offset: 0x00129096
		[Nullable(2)]
		public virtual string EdTidDesc
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040048AC RID: 18604
		private ILogicNodeOccupation Instance;

		// Token: 0x040048AD RID: 18605
		private List<string> _OccupationsCache;

		// Token: 0x040048AE RID: 18606
		private bool _OccupationsInited;

		// Token: 0x040048AF RID: 18607
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitActionsCache;

		// Token: 0x040048B0 RID: 18608
		private bool _ExitActionsInited;

		// Token: 0x040048B1 RID: 18609
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ReenterActionsCache;

		// Token: 0x040048B2 RID: 18610
		private bool _ReenterActionsInited;

		// Token: 0x040048B3 RID: 18611
		[Nullable(2)]
		private List<int> _BanInteractEntitiesCache;

		// Token: 0x040048B4 RID: 18612
		private bool _BanInteractEntitiesInited;
	}
}
