using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000394 RID: 916
	public class IExploreSkillGraffitiPuzzle : IExploreSkillInteractType
	{
		// Token: 0x060011F0 RID: 4592 RVA: 0x0003C954 File Offset: 0x0003AB54
		private IExploreSkillGraffitiPuzzle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillGraffitiPuzzle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillGraffitiPuzzle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillGraffitiPuzzle_SetValue());
			}
			return result;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0003C98C File Offset: 0x0003AB8C
		public static IExploreSkillGraffitiPuzzle Create([Nullable(2)] IExploreSkillGraffitiPuzzle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillGraffitiPuzzle
			{
				FbInstance = instance
			};
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0003C99F File Offset: 0x0003AB9F
		public static IExploreSkillGraffitiPuzzle CreateFromSetValue([Nullable(2)] IExploreSkillGraffitiPuzzle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillGraffitiPuzzle
			{
				PocoInterface = value
			};
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0003C9B4 File Offset: 0x0003ABB4
		public new IExploreSkillGraffitiPuzzle_SetValue ToSetValue()
		{
			return new IExploreSkillGraffitiPuzzle_SetValue
			{
				Type = this.Type,
				PointPairs = this.PointPairs,
				AlignDuration = this.AlignDuration,
				HighlightEntityIds = this.HighlightEntityIds,
				HighlightTag = this.HighlightTag,
				Actions = this.Actions
			};
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0003CA0E File Offset: 0x0003AC0E
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0003CA39 File Offset: 0x0003AC39
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0003CA48 File Offset: 0x0003AC48
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0003CADB File Offset: 0x0003ACDB
		public virtual List<IGraffitiPointPair> PointPairs
		{
			get
			{
				if (this._PointPairsInited)
				{
					return this._PointPairsCache;
				}
				this._PointPairsInited = true;
				if (this.FbInstance != null)
				{
					List<IGraffitiPointPair> pointPairs = this.FbInstance.PointPairs;
					if (pointPairs != null)
					{
						this._PointPairsCache = new List<IGraffitiPointPair>(pointPairs.Count);
						for (int i = 0; i < pointPairs.Count; i++)
						{
							this._PointPairsCache.Add(IGraffitiPointPair.Create(pointPairs[i]));
						}
					}
				}
				else
				{
					IExploreSkillGraffitiPuzzle_SetValue pocoInterface = this.PocoInterface;
					this._PointPairsCache = ((pocoInterface != null) ? pocoInterface.PointPairs : null);
				}
				return this._PointPairsCache;
			}
			set
			{
				this.GetOrCreatePoco().PointPairs = value;
				this._PointPairsInited = false;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0003CAF0 File Offset: 0x0003ACF0
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0003CB1F File Offset: 0x0003AD1F
		public virtual float AlignDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AlignDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.AlignDuration;
			}
			set
			{
				this.GetOrCreatePoco().AlignDuration = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0003CB2D File Offset: 0x0003AD2D
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0003CB54 File Offset: 0x0003AD54
		public virtual List<int> HighlightEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HighlightEntityIds;
				}
				IExploreSkillGraffitiPuzzle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HighlightEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().HighlightEntityIds = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0003CB62 File Offset: 0x0003AD62
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0003CB8D File Offset: 0x0003AD8D
		public virtual int HighlightTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HighlightTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HighlightTag;
			}
			set
			{
				this.GetOrCreatePoco().HighlightTag = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0003CB9C File Offset: 0x0003AD9C
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0003CC2F File Offset: 0x0003AE2F
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IExploreSkillGraffitiPuzzle_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04000EEA RID: 3818
		[Nullable(2)]
		protected new IExploreSkillGraffitiPuzzle FbInstance;

		// Token: 0x04000EEB RID: 3819
		[Nullable(2)]
		protected new IExploreSkillGraffitiPuzzle_SetValue PocoInterface;

		// Token: 0x04000EEC RID: 3820
		private List<IGraffitiPointPair> _PointPairsCache;

		// Token: 0x04000EED RID: 3821
		private bool _PointPairsInited;

		// Token: 0x04000EEE RID: 3822
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000EEF RID: 3823
		private bool _ActionsInited;
	}
}
