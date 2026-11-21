using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037C RID: 892
	public class IEntityState
	{
		// Token: 0x0600115E RID: 4446 RVA: 0x0003B410 File Offset: 0x00039610
		private IEntityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityState_SetValue());
			}
			return result;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0003B448 File Offset: 0x00039648
		public static IEntityState Create([Nullable(2)] IEntityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0003B45B File Offset: 0x0003965B
		public static IEntityState CreateFromSetValue([Nullable(2)] IEntityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0003B46E File Offset: 0x0003966E
		public IEntityState_SetValue ToSetValue()
		{
			return new IEntityState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0003B48D File Offset: 0x0003968D
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x0003B4B8 File Offset: 0x000396B8
		public virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0003B4C6 File Offset: 0x000396C6
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0003B4F1 File Offset: 0x000396F1
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04000E8D RID: 3725
		[Nullable(2)]
		protected IEntityState FbInstance;

		// Token: 0x04000E8E RID: 3726
		[Nullable(2)]
		protected IEntityState_SetValue PocoInterface;
	}
}
