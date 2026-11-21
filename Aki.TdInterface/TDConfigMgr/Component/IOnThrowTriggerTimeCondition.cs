using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200061D RID: 1565
	public class IOnThrowTriggerTimeCondition : IBulletCreateCondition
	{
		// Token: 0x060020D6 RID: 8406 RVA: 0x0005BDC8 File Offset: 0x00059FC8
		private IOnThrowTriggerTimeCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnThrowTriggerTimeCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnThrowTriggerTimeCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnThrowTriggerTimeCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0005BE00 File Offset: 0x0005A000
		public static IOnThrowTriggerTimeCondition Create([Nullable(2)] IOnThrowTriggerTimeCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnThrowTriggerTimeCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0005BE13 File Offset: 0x0005A013
		public static IOnThrowTriggerTimeCondition CreateFromSetValue([Nullable(2)] IOnThrowTriggerTimeCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnThrowTriggerTimeCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0005BE26 File Offset: 0x0005A026
		public new IOnThrowTriggerTimeCondition_SetValue ToSetValue()
		{
			return new IOnThrowTriggerTimeCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				TriggerTime = this.TriggerTime
			};
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x0005BE51 File Offset: 0x0005A051
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x0005BE7C File Offset: 0x0005A07C
		public override EBulletCreateCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBulletCreateCondition.OnHit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0005BE8A File Offset: 0x0005A08A
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0005BEB6 File Offset: 0x0005A0B6
		public override long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0005BEC4 File Offset: 0x0005A0C4
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0005BEF3 File Offset: 0x0005A0F3
		public virtual float TriggerTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TriggerTime;
			}
			set
			{
				this.GetOrCreatePoco().TriggerTime = value;
			}
		}

		// Token: 0x04001751 RID: 5969
		[Nullable(2)]
		protected new IOnThrowTriggerTimeCondition FbInstance;

		// Token: 0x04001752 RID: 5970
		[Nullable(2)]
		protected new IOnThrowTriggerTimeCondition_SetValue PocoInterface;
	}
}
