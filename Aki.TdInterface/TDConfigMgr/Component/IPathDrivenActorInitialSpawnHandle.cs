using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000669 RID: 1641
	public class IPathDrivenActorInitialSpawnHandle
	{
		// Token: 0x06002278 RID: 8824 RVA: 0x0005F1AC File Offset: 0x0005D3AC
		private IPathDrivenActorInitialSpawnHandle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathDrivenActorInitialSpawnHandle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathDrivenActorInitialSpawnHandle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathDrivenActorInitialSpawnHandle_SetValue());
			}
			return result;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0005F1E4 File Offset: 0x0005D3E4
		public static IPathDrivenActorInitialSpawnHandle Create([Nullable(2)] IPathDrivenActorInitialSpawnHandle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnHandle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0005F1F7 File Offset: 0x0005D3F7
		public static IPathDrivenActorInitialSpawnHandle CreateFromSetValue([Nullable(2)] IPathDrivenActorInitialSpawnHandle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnHandle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x0005F20A File Offset: 0x0005D40A
		public IPathDrivenActorInitialSpawnHandle_SetValue ToSetValue()
		{
			return new IPathDrivenActorInitialSpawnHandle_SetValue
			{
				Index = this.Index,
				HandleType = this.HandleType
			};
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x0005F229 File Offset: 0x0005D429
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x0005F254 File Offset: 0x0005D454
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x0005F262 File Offset: 0x0005D462
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x0005F28D File Offset: 0x0005D48D
		public virtual EPathDrivenActorInitialSpawnHandleType HandleType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandleType;
				}
				if (this.PocoInterface == null)
				{
					return EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
				}
				return this.PocoInterface.HandleType;
			}
			set
			{
				this.GetOrCreatePoco().HandleType = value;
			}
		}

		// Token: 0x0400182E RID: 6190
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnHandle FbInstance;

		// Token: 0x0400182F RID: 6191
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnHandle_SetValue PocoInterface;
	}
}
