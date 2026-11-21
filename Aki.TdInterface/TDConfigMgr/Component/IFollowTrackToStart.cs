using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000401 RID: 1025
	public class IFollowTrackToStart : IFollowTrackEndType
	{
		// Token: 0x06001449 RID: 5193 RVA: 0x0004152C File Offset: 0x0003F72C
		private IFollowTrackToStart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowTrackToStart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowTrackToStart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowTrackToStart_SetValue());
			}
			return result;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00041564 File Offset: 0x0003F764
		public static IFollowTrackToStart Create([Nullable(2)] IFollowTrackToStart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackToStart
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00041577 File Offset: 0x0003F777
		public static IFollowTrackToStart CreateFromSetValue([Nullable(2)] IFollowTrackToStart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowTrackToStart
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0004158A File Offset: 0x0003F78A
		public new IFollowTrackToStart_SetValue ToSetValue()
		{
			return new IFollowTrackToStart_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0004159D File Offset: 0x0003F79D
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x000415C8 File Offset: 0x0003F7C8
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

		// Token: 0x04001026 RID: 4134
		[Nullable(2)]
		protected new IFollowTrackToStart FbInstance;

		// Token: 0x04001027 RID: 4135
		[Nullable(2)]
		protected new IFollowTrackToStart_SetValue PocoInterface;
	}
}
