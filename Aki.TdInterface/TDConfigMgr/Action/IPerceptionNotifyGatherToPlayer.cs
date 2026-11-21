using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED3 RID: 7891
	public class IPerceptionNotifyGatherToPlayer : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600A7FD RID: 43005 RVA: 0x0017DEB0 File Offset: 0x0017C0B0
		private IPerceptionNotifyGatherToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerceptionNotifyGatherToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerceptionNotifyGatherToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerceptionNotifyGatherToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x0017DEE8 File Offset: 0x0017C0E8
		public static IPerceptionNotifyGatherToPlayer Create([Nullable(2)] IPerceptionNotifyGatherToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x0017DEFB File Offset: 0x0017C0FB
		public static IPerceptionNotifyGatherToPlayer CreateFromSetValue([Nullable(2)] IPerceptionNotifyGatherToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x0017DF0E File Offset: 0x0017C10E
		public new IPerceptionNotifyGatherToPlayer_SetValue ToSetValue()
		{
			return new IPerceptionNotifyGatherToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600A801 RID: 43009 RVA: 0x0017DF21 File Offset: 0x0017C121
		// (set) Token: 0x0600A802 RID: 43010 RVA: 0x0017DF4C File Offset: 0x0017C14C
		public override EBattleStatePerceptionBehavior Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400650D RID: 25869
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToPlayer FbInstance;

		// Token: 0x0400650E RID: 25870
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToPlayer_SetValue PocoInterface;
	}
}
