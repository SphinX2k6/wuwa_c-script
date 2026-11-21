using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CCE RID: 7374
	public class IHookLockInteract : ILeisureInteractType
	{
		// Token: 0x06009C90 RID: 40080 RVA: 0x00168E34 File Offset: 0x00167034
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

		// Token: 0x06009C91 RID: 40081 RVA: 0x00168E6C File Offset: 0x0016706C
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

		// Token: 0x06009C92 RID: 40082 RVA: 0x00168E7F File Offset: 0x0016707F
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

		// Token: 0x06009C93 RID: 40083 RVA: 0x00168E92 File Offset: 0x00167092
		public new IHookLockInteract_SetValue ToSetValue()
		{
			return new IHookLockInteract_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x00168EB1 File Offset: 0x001670B1
		// (set) Token: 0x06009C95 RID: 40085 RVA: 0x00168EDC File Offset: 0x001670DC
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

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x00168EEA File Offset: 0x001670EA
		// (set) Token: 0x06009C97 RID: 40087 RVA: 0x00168F15 File Offset: 0x00167115
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

		// Token: 0x04005FB5 RID: 24501
		[Nullable(2)]
		protected new IHookLockInteract FbInstance;

		// Token: 0x04005FB6 RID: 24502
		[Nullable(2)]
		protected new IHookLockInteract_SetValue PocoInterface;
	}
}
