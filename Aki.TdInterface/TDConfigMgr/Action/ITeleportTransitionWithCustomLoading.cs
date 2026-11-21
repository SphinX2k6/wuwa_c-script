using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021EF RID: 8687
	public class ITeleportTransitionWithCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600BD4E RID: 48462 RVA: 0x001B5C28 File Offset: 0x001B3E28
		private ITeleportTransitionWithCustomLoading_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithCustomLoading 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithCustomLoading_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithCustomLoading_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x001B5C60 File Offset: 0x001B3E60
		public static ITeleportTransitionWithCustomLoading Create([Nullable(2)] ITeleportTransitionWithCustomLoading instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomLoading
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x001B5C73 File Offset: 0x001B3E73
		public static ITeleportTransitionWithCustomLoading CreateFromSetValue([Nullable(2)] ITeleportTransitionWithCustomLoading_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithCustomLoading
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x001B5C86 File Offset: 0x001B3E86
		public new ITeleportTransitionWithCustomLoading_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithCustomLoading_SetValue
			{
				Type = this.Type,
				ConfigId = this.ConfigId
			};
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600BD52 RID: 48466 RVA: 0x001B5CA5 File Offset: 0x001B3EA5
		// (set) Token: 0x0600BD53 RID: 48467 RVA: 0x001B5CD0 File Offset: 0x001B3ED0
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600BD54 RID: 48468 RVA: 0x001B5CDE File Offset: 0x001B3EDE
		// (set) Token: 0x0600BD55 RID: 48469 RVA: 0x001B5D09 File Offset: 0x001B3F09
		public virtual int ConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ConfigId;
			}
			set
			{
				this.GetOrCreatePoco().ConfigId = value;
			}
		}

		// Token: 0x040071A7 RID: 29095
		[Nullable(2)]
		protected new ITeleportTransitionWithCustomLoading FbInstance;

		// Token: 0x040071A8 RID: 29096
		[Nullable(2)]
		protected new ITeleportTransitionWithCustomLoading_SetValue PocoInterface;
	}
}
