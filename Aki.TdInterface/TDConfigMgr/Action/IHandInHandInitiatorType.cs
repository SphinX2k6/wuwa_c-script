using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE9 RID: 6889
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInHandInitiatorType
	{
		// Token: 0x0600939C RID: 37788 RVA: 0x001566DC File Offset: 0x001548DC
		private IHandInHandInitiatorType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInHandInitiatorType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInHandInitiatorType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInHandInitiatorType_SetValue());
			}
			return result;
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x00156714 File Offset: 0x00154914
		public static IHandInHandInitiatorType Create([Nullable(2)] IHandInHandInitiatorType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInHandInitiatorType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x00156727 File Offset: 0x00154927
		public static IHandInHandInitiatorType CreateFromSetValue([Nullable(2)] IHandInHandInitiatorType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInHandInitiatorType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x0015673A File Offset: 0x0015493A
		public IHandInHandInitiatorType_SetValue ToSetValue()
		{
			return new IHandInHandInitiatorType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x060093A0 RID: 37792 RVA: 0x0015674D File Offset: 0x0015494D
		// (set) Token: 0x060093A1 RID: 37793 RVA: 0x00156778 File Offset: 0x00154978
		public virtual EHandInHandInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandInHandInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AAD RID: 23213
		[Nullable(2)]
		protected IHandInHandInitiatorType FbInstance;

		// Token: 0x04005AAE RID: 23214
		[Nullable(2)]
		protected IHandInHandInitiatorType_SetValue PocoInterface;
	}
}
