using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E4B RID: 3659
	[NullableContext(1)]
	[Nullable(0)]
	public class NoiseRemovalComponent : IComponentBase
	{
		// Token: 0x0600529E RID: 21150 RVA: 0x000CB478 File Offset: 0x000C9678
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

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x000CB498 File Offset: 0x000C9698
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

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x060052A0 RID: 21152 RVA: 0x000CB4D0 File Offset: 0x000C96D0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x000CB4E8 File Offset: 0x000C96E8
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

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x060052A2 RID: 21154 RVA: 0x000CB551 File Offset: 0x000C9751
		public virtual string CompleteState
		{
			get
			{
				return this.Instance.CompleteState;
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x060052A3 RID: 21155 RVA: 0x000CB55E File Offset: 0x000C975E
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

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x060052A4 RID: 21156 RVA: 0x000CB590 File Offset: 0x000C9790
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

		// Token: 0x04002F9E RID: 12190
		private INoiseRemovalComponent Instance;

		// Token: 0x04002F9F RID: 12191
		private List<INoiseRemovalNode> _NodesCache;

		// Token: 0x04002FA0 RID: 12192
		private bool _NodesInited;

		// Token: 0x04002FA1 RID: 12193
		private INoiseRemovalBoarderBase _NoiseRemovalBoarderCache;

		// Token: 0x04002FA2 RID: 12194
		private bool _NoiseRemovalBoarderInited;
	}
}
