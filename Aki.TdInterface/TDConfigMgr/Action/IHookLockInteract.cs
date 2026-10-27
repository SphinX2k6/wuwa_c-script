using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B1F RID: 6943
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookLockInteract : ILeisureInteractType
	{
		// Token: 0x060094A6 RID: 38054 RVA: 0x00158158 File Offset: 0x00156358
		private IHookLockInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookLockInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookLockInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookLockInteract_SetValue());
			}
			return result;
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x00158190 File Offset: 0x00156390
		public static IHookLockInteract Create([Nullable(2)] IHookLockInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookLockInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x001581A3 File Offset: 0x001563A3
		public static IHookLockInteract CreateFromSetValue([Nullable(2)] IHookLockInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookLockInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x001581B6 File Offset: 0x001563B6
		public new IHookLockInteract_SetValue ToSetValue()
		{
			return new IHookLockInteract_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x060094AA RID: 38058 RVA: 0x001581D5 File Offset: 0x001563D5
		// (set) Token: 0x060094AB RID: 38059 RVA: 0x00158200 File Offset: 0x00156400
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

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x060094AC RID: 38060 RVA: 0x0015820E File Offset: 0x0015640E
		// (set) Token: 0x060094AD RID: 38061 RVA: 0x00158239 File Offset: 0x00156439
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04005B17 RID: 23319
		[Nullable(2)]
		protected new IHookLockInteract FbInstance;

		// Token: 0x04005B18 RID: 23320
		[Nullable(2)]
		protected new IHookLockInteract_SetValue PocoInterface;
	}
}
