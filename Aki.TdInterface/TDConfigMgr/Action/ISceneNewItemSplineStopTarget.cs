using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002001 RID: 8193
	public class ISceneNewItemSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600ADF7 RID: 44535 RVA: 0x00188708 File Offset: 0x00186908
		private ISceneNewItemSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneNewItemSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneNewItemSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneNewItemSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x00188740 File Offset: 0x00186940
		public static ISceneNewItemSplineStopTarget Create([Nullable(2)] ISceneNewItemSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneNewItemSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x00188753 File Offset: 0x00186953
		public static ISceneNewItemSplineStopTarget CreateFromSetValue([Nullable(2)] ISceneNewItemSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneNewItemSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADFA RID: 44538 RVA: 0x00188766 File Offset: 0x00186966
		public new ISceneNewItemSplineStopTarget_SetValue ToSetValue()
		{
			return new ISceneNewItemSplineStopTarget_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x00188785 File Offset: 0x00186985
		// (set) Token: 0x0600ADFC RID: 44540 RVA: 0x001887B0 File Offset: 0x001869B0
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x001887BE File Offset: 0x001869BE
		// (set) Token: 0x0600ADFE RID: 44542 RVA: 0x001887E9 File Offset: 0x001869E9
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x040067C1 RID: 26561
		[Nullable(2)]
		protected new ISceneNewItemSplineStopTarget FbInstance;

		// Token: 0x040067C2 RID: 26562
		[Nullable(2)]
		protected new ISceneNewItemSplineStopTarget_SetValue PocoInterface;
	}
}
