using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E9 RID: 8681
	public class ITeleportTransitionType
	{
		// Token: 0x0600BD32 RID: 48434 RVA: 0x001B592C File Offset: 0x001B3B2C
		private ITeleportTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x001B5964 File Offset: 0x001B3B64
		public static ITeleportTransitionType Create([Nullable(2)] ITeleportTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x001B5977 File Offset: 0x001B3B77
		public static ITeleportTransitionType CreateFromSetValue([Nullable(2)] ITeleportTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD35 RID: 48437 RVA: 0x001B598A File Offset: 0x001B3B8A
		public ITeleportTransitionType_SetValue ToSetValue()
		{
			return new ITeleportTransitionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600BD36 RID: 48438 RVA: 0x001B599D File Offset: 0x001B3B9D
		// (set) Token: 0x0600BD37 RID: 48439 RVA: 0x001B59C8 File Offset: 0x001B3BC8
		public virtual ETeleportTransitionType Type
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

		// Token: 0x0400719A RID: 29082
		[Nullable(2)]
		protected ITeleportTransitionType FbInstance;

		// Token: 0x0400719B RID: 29083
		[Nullable(2)]
		protected ITeleportTransitionType_SetValue PocoInterface;
	}
}
