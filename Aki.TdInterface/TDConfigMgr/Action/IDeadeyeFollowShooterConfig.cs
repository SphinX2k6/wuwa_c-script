using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001978 RID: 6520
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeadeyeFollowShooterConfig
	{
		// Token: 0x06008BA9 RID: 35753 RVA: 0x00148368 File Offset: 0x00146568
		private IDeadeyeFollowShooterConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadeyeFollowShooterConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadeyeFollowShooterConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadeyeFollowShooterConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x001483A0 File Offset: 0x001465A0
		public static IDeadeyeFollowShooterConfig Create([Nullable(2)] IDeadeyeFollowShooterConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFollowShooterConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BAB RID: 35755 RVA: 0x001483B3 File Offset: 0x001465B3
		public static IDeadeyeFollowShooterConfig CreateFromSetValue([Nullable(2)] IDeadeyeFollowShooterConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadeyeFollowShooterConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BAC RID: 35756 RVA: 0x001483C6 File Offset: 0x001465C6
		public IDeadeyeFollowShooterConfig_SetValue ToSetValue()
		{
			return new IDeadeyeFollowShooterConfig_SetValue
			{
				DeadeyeShooterDa = this.DeadeyeShooterDa
			};
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x001483D9 File Offset: 0x001465D9
		// (set) Token: 0x06008BAE RID: 35758 RVA: 0x00148404 File Offset: 0x00146604
		public virtual string DeadeyeShooterDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeadeyeShooterDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.DeadeyeShooterDa;
			}
			set
			{
				this.GetOrCreatePoco().DeadeyeShooterDa = value;
			}
		}

		// Token: 0x04005714 RID: 22292
		[Nullable(2)]
		protected IDeadeyeFollowShooterConfig FbInstance;

		// Token: 0x04005715 RID: 22293
		[Nullable(2)]
		protected IDeadeyeFollowShooterConfig_SetValue PocoInterface;
	}
}
