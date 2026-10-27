using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000845 RID: 2117
	[NullableContext(1)]
	[Nullable(0)]
	public class NoiseRemovalComponent : IComponentBase
	{
		// Token: 0x06002E73 RID: 11891 RVA: 0x00078080 File Offset: 0x00076280
		private NoiseRemovalComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("NoiseRemovalComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			NoiseRemovalComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new NoiseRemovalComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000780B8 File Offset: 0x000762B8
		public static NoiseRemovalComponent Create([Nullable(2)] NoiseRemovalComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NoiseRemovalComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000780CB File Offset: 0x000762CB
		public static NoiseRemovalComponent CreateFromSetValue([Nullable(2)] NoiseRemovalComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new NoiseRemovalComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000780E0 File Offset: 0x000762E0
		public new NoiseRemovalComponent_SetValue ToSetValue()
		{
			return new NoiseRemovalComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Nodes = this.Nodes,
				CompleteState = this.CompleteState,
				NoiseRemovalBoarder = this.NoiseRemovalBoarder,
				RotationAngle = this.RotationAngle
			};
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x0007813C File Offset: 0x0007633C
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00078176 File Offset: 0x00076376
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				NoiseRemovalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00078184 File Offset: 0x00076384
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x000781AE File Offset: 0x000763AE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x000781BC File Offset: 0x000763BC
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x0007824F File Offset: 0x0007644F
		public virtual List<INoiseRemovalNode> Nodes
		{
			get
			{
				if (this._NodesInited)
				{
					return this._NodesCache;
				}
				this._NodesInited = true;
				if (this.FbInstance != null)
				{
					List<INoiseRemovalNode> nodes = this.FbInstance.Nodes;
					if (nodes != null)
					{
						this._NodesCache = new List<INoiseRemovalNode>(nodes.Count);
						for (int i = 0; i < nodes.Count; i++)
						{
							this._NodesCache.Add(INoiseRemovalNode.Create(nodes[i]));
						}
					}
				}
				else
				{
					NoiseRemovalComponent_SetValue pocoInterface = this.PocoInterface;
					this._NodesCache = ((pocoInterface != null) ? pocoInterface.Nodes : null);
				}
				return this._NodesCache;
			}
			set
			{
				this.GetOrCreatePoco().Nodes = value;
				this._NodesInited = false;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x00078264 File Offset: 0x00076464
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x0007828F File Offset: 0x0007648F
		public virtual string CompleteState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompleteState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CompleteState;
			}
			set
			{
				this.GetOrCreatePoco().CompleteState = value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x0007829D File Offset: 0x0007649D
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x000782C4 File Offset: 0x000764C4
		[Nullable(2)]
		public virtual INoiseRemovalBoarderBase NoiseRemovalBoarder
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NoiseRemovalBoarder;
				}
				NoiseRemovalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NoiseRemovalBoarder;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().NoiseRemovalBoarder = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x000782D4 File Offset: 0x000764D4
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x0007830E File Offset: 0x0007650E
		public virtual int? RotationAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationAngle;
				}
				NoiseRemovalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RotationAngle;
			}
			set
			{
				this.GetOrCreatePoco().RotationAngle = value;
			}
		}

		// Token: 0x04001EA7 RID: 7847
		[Nullable(2)]
		protected new NoiseRemovalComponent FbInstance;

		// Token: 0x04001EA8 RID: 7848
		[Nullable(2)]
		protected new NoiseRemovalComponent_SetValue PocoInterface;

		// Token: 0x04001EA9 RID: 7849
		private List<INoiseRemovalNode> _NodesCache;

		// Token: 0x04001EAA RID: 7850
		private bool _NodesInited;
	}
}
