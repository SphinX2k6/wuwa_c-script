using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B0 RID: 6320
	public class FollowShooterLeisureInteract : ActionParams
	{
		// Token: 0x06008493 RID: 33939 RVA: 0x0013C720 File Offset: 0x0013A920
		private FollowShooterLeisureInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FollowShooterLeisureInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FollowShooterLeisureInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FollowShooterLeisureInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x0013C758 File Offset: 0x0013A958
		public static FollowShooterLeisureInteract Create([Nullable(2)] FollowShooterLeisureInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowShooterLeisureInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x0013C76B File Offset: 0x0013A96B
		public static FollowShooterLeisureInteract CreateFromSetValue([Nullable(2)] FollowShooterLeisureInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FollowShooterLeisureInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x0013C77E File Offset: 0x0013A97E
		public FollowShooterLeisureInteract_SetValue ToSetValue()
		{
			return new FollowShooterLeisureInteract_SetValue
			{
				Id = this.Id,
				InteractType = this.InteractType
			};
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x06008497 RID: 33943 RVA: 0x0013C79D File Offset: 0x0013A99D
		// (set) Token: 0x06008498 RID: 33944 RVA: 0x0013C7C8 File Offset: 0x0013A9C8
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x06008499 RID: 33945 RVA: 0x0013C7D6 File Offset: 0x0013A9D6
		// (set) Token: 0x0600849A RID: 33946 RVA: 0x0013C7FD File Offset: 0x0013A9FD
		public virtual IFollowShooterLeisureInteractType InteractType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractType;
				}
				FollowShooterLeisureInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractType;
			}
			set
			{
				this.GetOrCreatePoco().InteractType = value;
			}
		}

		// Token: 0x0400545C RID: 21596
		[Nullable(2)]
		protected new FollowShooterLeisureInteract FbInstance;

		// Token: 0x0400545D RID: 21597
		[Nullable(2)]
		protected FollowShooterLeisureInteract_SetValue PocoInterface;
	}
}
