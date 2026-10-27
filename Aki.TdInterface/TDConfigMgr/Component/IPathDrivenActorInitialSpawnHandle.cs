using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D8 RID: 1496
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathDrivenActorInitialSpawnHandle
	{
		// Token: 0x06001FAC RID: 8108 RVA: 0x00058B20 File Offset: 0x00056D20
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

		// Token: 0x06001FAD RID: 8109 RVA: 0x00058B58 File Offset: 0x00056D58
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

		// Token: 0x06001FAE RID: 8110 RVA: 0x00058B6B File Offset: 0x00056D6B
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

		// Token: 0x06001FAF RID: 8111 RVA: 0x00058B7E File Offset: 0x00056D7E
		public IPathDrivenActorInitialSpawnHandle_SetValue ToSetValue()
		{
			return new IPathDrivenActorInitialSpawnHandle_SetValue
			{
				Index = this.Index,
				HandleType = this.HandleType
			};
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00058B9D File Offset: 0x00056D9D
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x00058BC8 File Offset: 0x00056DC8
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

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x00058BD6 File Offset: 0x00056DD6
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00058C01 File Offset: 0x00056E01
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

		// Token: 0x04001657 RID: 5719
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnHandle FbInstance;

		// Token: 0x04001658 RID: 5720
		[Nullable(2)]
		protected IPathDrivenActorInitialSpawnHandle_SetValue PocoInterface;
	}
}
