using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230E RID: 8974
	public class IWindProtagonistParkour2 : ILeisureInteractType
	{
		// Token: 0x0600C38C RID: 50060 RVA: 0x001C1318 File Offset: 0x001BF518
		private IWindProtagonistParkour2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour2_SetValue());
			}
			return result;
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x001C1350 File Offset: 0x001BF550
		public static IWindProtagonistParkour2 Create([Nullable(2)] IWindProtagonistParkour2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x001C1363 File Offset: 0x001BF563
		public static IWindProtagonistParkour2 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x001C1376 File Offset: 0x001BF576
		public new IWindProtagonistParkour2_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0600C390 RID: 50064 RVA: 0x001C1389 File Offset: 0x001BF589
		// (set) Token: 0x0600C391 RID: 50065 RVA: 0x001C13B4 File Offset: 0x001BF5B4
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007492 RID: 29842
		[Nullable(2)]
		protected new IWindProtagonistParkour2 FbInstance;

		// Token: 0x04007493 RID: 29843
		[Nullable(2)]
		protected new IWindProtagonistParkour2_SetValue PocoInterface;
	}
}
