using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019ED RID: 6637
	public class IChangeActorMPC : IModifyMaterialConfig
	{
		// Token: 0x06008D45 RID: 36165 RVA: 0x0014E4CC File Offset: 0x0014C6CC
		private IChangeActorMPC_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeActorMPC 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeActorMPC_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeActorMPC_SetValue());
			}
			return result;
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x0014E504 File Offset: 0x0014C704
		public static IChangeActorMPC Create([Nullable(2)] IChangeActorMPC instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeActorMPC
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x0014E517 File Offset: 0x0014C717
		public static IChangeActorMPC CreateFromSetValue([Nullable(2)] IChangeActorMPC_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeActorMPC
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x0014E52A File Offset: 0x0014C72A
		public new IChangeActorMPC_SetValue ToSetValue()
		{
			return new IChangeActorMPC_SetValue
			{
				Type = this.Type,
				MpcData = this.MpcData
			};
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x06008D49 RID: 36169 RVA: 0x0014E549 File Offset: 0x0014C749
		// (set) Token: 0x06008D4A RID: 36170 RVA: 0x0014E574 File Offset: 0x0014C774
		public override EModifyActorMaterialType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMaterialType.ChangeMaterialData;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x06008D4B RID: 36171 RVA: 0x0014E582 File Offset: 0x0014C782
		// (set) Token: 0x06008D4C RID: 36172 RVA: 0x0014E5AD File Offset: 0x0014C7AD
		public virtual string MpcData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MpcData;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MpcData;
			}
			set
			{
				this.GetOrCreatePoco().MpcData = value;
			}
		}

		// Token: 0x040058F4 RID: 22772
		[Nullable(2)]
		protected new IChangeActorMPC FbInstance;

		// Token: 0x040058F5 RID: 22773
		[Nullable(2)]
		protected new IChangeActorMPC_SetValue PocoInterface;
	}
}
