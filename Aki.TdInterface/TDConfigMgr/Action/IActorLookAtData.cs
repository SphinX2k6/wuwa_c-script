using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FF RID: 6399
	public class IActorLookAtData
	{
		// Token: 0x06008645 RID: 34373 RVA: 0x0013F9D0 File Offset: 0x0013DBD0
		private IActorLookAtData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtData_SetValue());
			}
			return result;
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x0013FA08 File Offset: 0x0013DC08
		public static IActorLookAtData Create([Nullable(2)] IActorLookAtData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x0013FA1B File Offset: 0x0013DC1B
		public static IActorLookAtData CreateFromSetValue([Nullable(2)] IActorLookAtData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x0013FA2E File Offset: 0x0013DC2E
		public IActorLookAtData_SetValue ToSetValue()
		{
			return new IActorLookAtData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x06008649 RID: 34377 RVA: 0x0013FA41 File Offset: 0x0013DC41
		// (set) Token: 0x0600864A RID: 34378 RVA: 0x0013FA6C File Offset: 0x0013DC6C
		public virtual EActorLookAtMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorLookAtMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400552D RID: 21805
		[Nullable(2)]
		protected IActorLookAtData FbInstance;

		// Token: 0x0400552E RID: 21806
		[Nullable(2)]
		protected IActorLookAtData_SetValue PocoInterface;
	}
}
