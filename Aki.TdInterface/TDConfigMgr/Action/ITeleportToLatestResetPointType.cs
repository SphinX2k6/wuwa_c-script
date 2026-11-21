using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E1 RID: 8673
	public class ITeleportToLatestResetPointType
	{
		// Token: 0x0600BCFA RID: 48378 RVA: 0x001B5254 File Offset: 0x001B3454
		private ITeleportToLatestResetPointType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportToLatestResetPointType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportToLatestResetPointType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportToLatestResetPointType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCFB RID: 48379 RVA: 0x001B528C File Offset: 0x001B348C
		public static ITeleportToLatestResetPointType Create([Nullable(2)] ITeleportToLatestResetPointType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x001B529F File Offset: 0x001B349F
		public static ITeleportToLatestResetPointType CreateFromSetValue([Nullable(2)] ITeleportToLatestResetPointType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x001B52B2 File Offset: 0x001B34B2
		public ITeleportToLatestResetPointType_SetValue ToSetValue()
		{
			return new ITeleportToLatestResetPointType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600BCFE RID: 48382 RVA: 0x001B52C5 File Offset: 0x001B34C5
		// (set) Token: 0x0600BCFF RID: 48383 RVA: 0x001B52F0 File Offset: 0x001B34F0
		public virtual ETeleportToLatestResetPointType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportToLatestResetPointType.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400717E RID: 29054
		[Nullable(2)]
		protected ITeleportToLatestResetPointType FbInstance;

		// Token: 0x0400717F RID: 29055
		[Nullable(2)]
		protected ITeleportToLatestResetPointType_SetValue PocoInterface;
	}
}
