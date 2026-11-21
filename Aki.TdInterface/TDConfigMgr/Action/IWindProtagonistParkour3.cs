using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002310 RID: 8976
	public class IWindProtagonistParkour3 : ILeisureInteractType
	{
		// Token: 0x0600C394 RID: 50068 RVA: 0x001C13D4 File Offset: 0x001BF5D4
		private IWindProtagonistParkour3_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour3 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour3_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour3_SetValue());
			}
			return result;
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x001C140C File Offset: 0x001BF60C
		public static IWindProtagonistParkour3 Create([Nullable(2)] IWindProtagonistParkour3 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour3
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C396 RID: 50070 RVA: 0x001C141F File Offset: 0x001BF61F
		public static IWindProtagonistParkour3 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour3_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour3
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C397 RID: 50071 RVA: 0x001C1432 File Offset: 0x001BF632
		public new IWindProtagonistParkour3_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour3_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0600C398 RID: 50072 RVA: 0x001C1445 File Offset: 0x001BF645
		// (set) Token: 0x0600C399 RID: 50073 RVA: 0x001C1470 File Offset: 0x001BF670
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

		// Token: 0x04007495 RID: 29845
		[Nullable(2)]
		protected new IWindProtagonistParkour3 FbInstance;

		// Token: 0x04007496 RID: 29846
		[Nullable(2)]
		protected new IWindProtagonistParkour3_SetValue PocoInterface;
	}
}
