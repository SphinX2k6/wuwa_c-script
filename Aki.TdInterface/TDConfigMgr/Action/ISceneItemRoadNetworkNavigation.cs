using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FFF RID: 8191
	public class ISceneItemRoadNetworkNavigation : IRoadNetworkNavigationTarget
	{
		// Token: 0x0600ADED RID: 44525 RVA: 0x00188608 File Offset: 0x00186808
		private ISceneItemRoadNetworkNavigation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemRoadNetworkNavigation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemRoadNetworkNavigation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemRoadNetworkNavigation_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x00188640 File Offset: 0x00186840
		public static ISceneItemRoadNetworkNavigation Create([Nullable(2)] ISceneItemRoadNetworkNavigation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemRoadNetworkNavigation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADEF RID: 44527 RVA: 0x00188653 File Offset: 0x00186853
		public static ISceneItemRoadNetworkNavigation CreateFromSetValue([Nullable(2)] ISceneItemRoadNetworkNavigation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemRoadNetworkNavigation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADF0 RID: 44528 RVA: 0x00188666 File Offset: 0x00186866
		public new ISceneItemRoadNetworkNavigation_SetValue ToSetValue()
		{
			return new ISceneItemRoadNetworkNavigation_SetValue
			{
				Type = this.Type,
				TargetId = this.TargetId
			};
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x00188685 File Offset: 0x00186885
		// (set) Token: 0x0600ADF2 RID: 44530 RVA: 0x001886B0 File Offset: 0x001868B0
		public override ERoadNetworkNavigationTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoadNetworkNavigationTarget.SceneItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x001886BE File Offset: 0x001868BE
		// (set) Token: 0x0600ADF4 RID: 44532 RVA: 0x001886E9 File Offset: 0x001868E9
		public virtual int TargetId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetId;
			}
			set
			{
				this.GetOrCreatePoco().TargetId = value;
			}
		}

		// Token: 0x040067BD RID: 26557
		[Nullable(2)]
		protected new ISceneItemRoadNetworkNavigation FbInstance;

		// Token: 0x040067BE RID: 26558
		[Nullable(2)]
		protected new ISceneItemRoadNetworkNavigation_SetValue PocoInterface;
	}
}
