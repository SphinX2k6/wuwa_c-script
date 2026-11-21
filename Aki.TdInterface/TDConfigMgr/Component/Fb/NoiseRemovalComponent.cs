using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F47 RID: 3911
	public class NoiseRemovalComponent : IComponentBase
	{
		// Token: 0x060057C5 RID: 22469 RVA: 0x000D6D40 File Offset: 0x000D4F40
		public static NoiseRemovalComponent Create(INoiseRemovalComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NoiseRemovalComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x060057C6 RID: 22470 RVA: 0x000D6D60 File Offset: 0x000D4F60
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x000D6D98 File Offset: 0x000D4F98
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x060057C8 RID: 22472 RVA: 0x000D6DB0 File Offset: 0x000D4FB0
		public virtual List<INoiseRemovalNode> Nodes
		{
			get
			{
				if (this._NodesInited)
				{
					return this._NodesCache;
				}
				this._NodesInited = true;
				int nodesLength = this.Instance.NodesLength;
				this._NodesCache = new List<INoiseRemovalNode>(nodesLength);
				for (int i = 0; i < nodesLength; i++)
				{
					this._NodesCache.Add(INoiseRemovalNode.Create(this.Instance.Nodes(i)));
				}
				return this._NodesCache;
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x060057C9 RID: 22473 RVA: 0x000D6E19 File Offset: 0x000D5019
		public virtual string CompleteState
		{
			get
			{
				return this.Instance.CompleteState;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x060057CA RID: 22474 RVA: 0x000D6E26 File Offset: 0x000D5026
		public virtual INoiseRemovalBoarderBase NoiseRemovalBoarder
		{
			get
			{
				if (this._NoiseRemovalBoarderInited)
				{
					return this._NoiseRemovalBoarderCache;
				}
				this._NoiseRemovalBoarderInited = true;
				this._NoiseRemovalBoarderCache = ComponentReadHelper.ReadNoiseRemovalComponent_NoiseRemovalBoarder(this.Instance);
				return this._NoiseRemovalBoarderCache;
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x000D6E58 File Offset: 0x000D5058
		public virtual int? RotationAngle
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RotationAngle);
			}
		}

		// Token: 0x04003266 RID: 12902
		private INoiseRemovalComponent Instance;

		// Token: 0x04003267 RID: 12903
		private List<INoiseRemovalNode> _NodesCache;

		// Token: 0x04003268 RID: 12904
		private bool _NodesInited;

		// Token: 0x04003269 RID: 12905
		private INoiseRemovalBoarderBase _NoiseRemovalBoarderCache;

		// Token: 0x0400326A RID: 12906
		private bool _NoiseRemovalBoarderInited;
	}
}
