using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E8 RID: 2280
	public class NoiseRemovalComponent : IComponentBase
	{
		// Token: 0x060031A9 RID: 12713 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
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

		// Token: 0x060031AA RID: 12714 RVA: 0x0007F4DC File Offset: 0x0007D6DC
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

		// Token: 0x060031AB RID: 12715 RVA: 0x0007F4EF File Offset: 0x0007D6EF
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

		// Token: 0x060031AC RID: 12716 RVA: 0x0007F504 File Offset: 0x0007D704
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

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x0007F560 File Offset: 0x0007D760
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x0007F59A File Offset: 0x0007D79A
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

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x0007F5A8 File Offset: 0x0007D7A8
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x0007F5D2 File Offset: 0x0007D7D2
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

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x0007F5E0 File Offset: 0x0007D7E0
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x0007F673 File Offset: 0x0007D873
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

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x0007F688 File Offset: 0x0007D888
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x0007F6B3 File Offset: 0x0007D8B3
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

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x0007F6C1 File Offset: 0x0007D8C1
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
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

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x0007F6F8 File Offset: 0x0007D8F8
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x0007F732 File Offset: 0x0007D932
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

		// Token: 0x040020B6 RID: 8374
		[Nullable(2)]
		protected new NoiseRemovalComponent FbInstance;

		// Token: 0x040020B7 RID: 8375
		[Nullable(2)]
		protected new NoiseRemovalComponent_SetValue PocoInterface;

		// Token: 0x040020B8 RID: 8376
		private List<INoiseRemovalNode> _NodesCache;

		// Token: 0x040020B9 RID: 8377
		private bool _NodesInited;
	}
}
