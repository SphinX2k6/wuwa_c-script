using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002312 RID: 8978
	public class IWindProtagonistParkour4 : ILeisureInteractType
	{
		// Token: 0x0600C39C RID: 50076 RVA: 0x001C1490 File Offset: 0x001BF690
		private IWindProtagonistParkour4_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour4 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour4_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour4_SetValue());
			}
			return result;
		}

		// Token: 0x0600C39D RID: 50077 RVA: 0x001C14C8 File Offset: 0x001BF6C8
		public static IWindProtagonistParkour4 Create([Nullable(2)] IWindProtagonistParkour4 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour4
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x001C14DB File Offset: 0x001BF6DB
		public static IWindProtagonistParkour4 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour4_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour4
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x001C14EE File Offset: 0x001BF6EE
		public new IWindProtagonistParkour4_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour4_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x0600C3A0 RID: 50080 RVA: 0x001C1501 File Offset: 0x001BF701
		// (set) Token: 0x0600C3A1 RID: 50081 RVA: 0x001C152C File Offset: 0x001BF72C
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

		// Token: 0x04007498 RID: 29848
		[Nullable(2)]
		protected new IWindProtagonistParkour4 FbInstance;

		// Token: 0x04007499 RID: 29849
		[Nullable(2)]
		protected new IWindProtagonistParkour4_SetValue PocoInterface;
	}
}
