using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA7 RID: 3495
	public class IExploreSkillGraffitiPuzzle : IExploreSkillInteractType
	{
		// Token: 0x06004F6D RID: 20333 RVA: 0x000C5A25 File Offset: 0x000C3C25
		public static IExploreSkillGraffitiPuzzle Create(IExploreSkillGraffitiPuzzle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillGraffitiPuzzle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06004F6E RID: 20334 RVA: 0x000C5A44 File Offset: 0x000C3C44
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06004F6F RID: 20335 RVA: 0x000C5A54 File Offset: 0x000C3C54
		public virtual List<IGraffitiPointPair> PointPairs
		{
			get
			{
				if (this._PointPairsInited)
				{
					return this._PointPairsCache;
				}
				this._PointPairsInited = true;
				int pointPairsLength = this.Instance.PointPairsLength;
				this._PointPairsCache = new List<IGraffitiPointPair>(pointPairsLength);
				for (int i = 0; i < pointPairsLength; i++)
				{
					this._PointPairsCache.Add(IGraffitiPointPair.Create(this.Instance.PointPairs(i)));
				}
				return this._PointPairsCache;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06004F70 RID: 20336 RVA: 0x000C5ABD File Offset: 0x000C3CBD
		public virtual float AlignDuration
		{
			get
			{
				return this.Instance.AlignDuration;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06004F71 RID: 20337 RVA: 0x000C5ACC File Offset: 0x000C3CCC
		public virtual List<int> HighlightEntityIds
		{
			get
			{
				if (this._HighlightEntityIdsInited)
				{
					return this._HighlightEntityIdsCache;
				}
				this._HighlightEntityIdsInited = true;
				int highlightEntityIdsLength = this.Instance.HighlightEntityIdsLength;
				this._HighlightEntityIdsCache = new List<int>(highlightEntityIdsLength);
				for (int i = 0; i < highlightEntityIdsLength; i++)
				{
					this._HighlightEntityIdsCache.Add(this.Instance.HighlightEntityIds(i));
				}
				return this._HighlightEntityIdsCache;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06004F72 RID: 20338 RVA: 0x000C5B30 File Offset: 0x000C3D30
		public virtual int HighlightTag
		{
			get
			{
				return this.Instance.HighlightTag;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x000C5B40 File Offset: 0x000C3D40
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x04002D38 RID: 11576
		private IExploreSkillGraffitiPuzzle Instance;

		// Token: 0x04002D39 RID: 11577
		private List<IGraffitiPointPair> _PointPairsCache;

		// Token: 0x04002D3A RID: 11578
		private bool _PointPairsInited;

		// Token: 0x04002D3B RID: 11579
		private List<int> _HighlightEntityIdsCache;

		// Token: 0x04002D3C RID: 11580
		private bool _HighlightEntityIdsInited;

		// Token: 0x04002D3D RID: 11581
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002D3E RID: 11582
		private bool _ActionsInited;
	}
}
