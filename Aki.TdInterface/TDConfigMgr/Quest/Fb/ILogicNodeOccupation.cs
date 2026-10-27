using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001465 RID: 5221
	[NullableContext(1)]
	[Nullable(0)]
	public class ILogicNodeOccupation
	{
		// Token: 0x060076D1 RID: 30417 RVA: 0x0011C045 File Offset: 0x0011A245
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

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x060076D2 RID: 30418 RVA: 0x0011C064 File Offset: 0x0011A264
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

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x060076D3 RID: 30419 RVA: 0x0011C0C8 File Offset: 0x0011A2C8
		public virtual string TidDesc
		{
			get
			{
				return this.Instance.TidDesc;
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x060076D4 RID: 30420 RVA: 0x0011C0D8 File Offset: 0x0011A2D8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> ExitActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x060076D5 RID: 30421 RVA: 0x0011C154 File Offset: 0x0011A354
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> ReenterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x060076D6 RID: 30422 RVA: 0x0011C1D0 File Offset: 0x0011A3D0
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

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x060076D7 RID: 30423 RVA: 0x0011C248 File Offset: 0x0011A448
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

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x060076D8 RID: 30424 RVA: 0x0011C27E File Offset: 0x0011A47E
		[Nullable(2)]
		public virtual string EdTidDesc
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004511 RID: 17681
		private ILogicNodeOccupation Instance;

		// Token: 0x04004512 RID: 17682
		private List<string> _OccupationsCache;

		// Token: 0x04004513 RID: 17683
		private bool _OccupationsInited;

		// Token: 0x04004514 RID: 17684
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitActionsCache;

		// Token: 0x04004515 RID: 17685
		private bool _ExitActionsInited;

		// Token: 0x04004516 RID: 17686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ReenterActionsCache;

		// Token: 0x04004517 RID: 17687
		private bool _ReenterActionsInited;

		// Token: 0x04004518 RID: 17688
		[Nullable(2)]
		private List<int> _BanInteractEntitiesCache;

		// Token: 0x04004519 RID: 17689
		private bool _BanInteractEntitiesInited;
	}
}
