using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B2 RID: 1458
	[NullableContext(1)]
	[Nullable(0)]
	public class IOnThrowTriggerTimeCondition : IBulletCreateCondition
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x00056D9C File Offset: 0x00054F9C
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

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00056DD4 File Offset: 0x00054FD4
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

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00056DE7 File Offset: 0x00054FE7
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

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00056DFA File Offset: 0x00054FFA
		public new IOnThrowTriggerTimeCondition_SetValue ToSetValue()
		{
			return new IOnThrowTriggerTimeCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId,
				TriggerTime = this.TriggerTime
			};
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00056E25 File Offset: 0x00055025
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00056E50 File Offset: 0x00055050
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00056E5E File Offset: 0x0005505E
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x00056E8A File Offset: 0x0005508A
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

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00056E98 File Offset: 0x00055098
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00056EC7 File Offset: 0x000550C7
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

		// Token: 0x040015DD RID: 5597
		[Nullable(2)]
		protected new IOnThrowTriggerTimeCondition FbInstance;

		// Token: 0x040015DE RID: 5598
		[Nullable(2)]
		protected new IOnThrowTriggerTimeCondition_SetValue PocoInterface;
	}
}
