using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003FF RID: 1023
	public class IFollowTrackToSplineDestination : IFollowTrackEndType
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x0004142C File Offset: 0x0003F62C
		private IFollowTrackToSplineDestination_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowTrackToSplineDestination 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowTrackToSplineDestination_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowTrackToSplineDestination_SetValue());
			}
			return result;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00041464 File Offset: 0x0003F664
		public static IFollowTrackToSplineDestination Create([Nullable(2)] IFollowTrackToSplineDestination instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackToSplineDestination
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00041477 File Offset: 0x0003F677
		public static IFollowTrackToSplineDestination CreateFromSetValue([Nullable(2)] IFollowTrackToSplineDestination_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowTrackToSplineDestination
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0004148A File Offset: 0x0003F68A
		public new IFollowTrackToSplineDestination_SetValue ToSetValue()
		{
			return new IFollowTrackToSplineDestination_SetValue
			{
				Type = this.Type,
				ChangeSelfState = this.ChangeSelfState
			};
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x000414A9 File Offset: 0x0003F6A9
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x000414D4 File Offset: 0x0003F6D4
		public override EFollowTrackEndType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFollowTrackEndType.ToStart;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x000414E2 File Offset: 0x0003F6E2
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x0004150D File Offset: 0x0003F70D
		public virtual string ChangeSelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ChangeSelfState;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSelfState = value;
			}
		}

		// Token: 0x04001022 RID: 4130
		[Nullable(2)]
		protected new IFollowTrackToSplineDestination FbInstance;

		// Token: 0x04001023 RID: 4131
		[Nullable(2)]
		protected new IFollowTrackToSplineDestination_SetValue PocoInterface;
	}
}
