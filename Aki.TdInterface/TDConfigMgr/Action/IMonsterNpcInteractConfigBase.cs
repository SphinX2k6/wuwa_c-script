using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF8 RID: 7160
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractConfigBase
	{
		// Token: 0x06009955 RID: 39253 RVA: 0x00160E58 File Offset: 0x0015F058
		private IMonsterNpcInteractConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x00160E90 File Offset: 0x0015F090
		public static IMonsterNpcInteractConfigBase Create([Nullable(2)] IMonsterNpcInteractConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x00160EA3 File Offset: 0x0015F0A3
		public static IMonsterNpcInteractConfigBase CreateFromSetValue([Nullable(2)] IMonsterNpcInteractConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x00160EB6 File Offset: 0x0015F0B6
		public IMonsterNpcInteractConfigBase_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x06009959 RID: 39257 RVA: 0x00160EC9 File Offset: 0x0015F0C9
		// (set) Token: 0x0600995A RID: 39258 RVA: 0x00160EF4 File Offset: 0x0015F0F4
		public virtual EMonsterNpcInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractType.TriggerHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D5E RID: 23902
		[Nullable(2)]
		protected IMonsterNpcInteractConfigBase FbInstance;

		// Token: 0x04005D5F RID: 23903
		[Nullable(2)]
		protected IMonsterNpcInteractConfigBase_SetValue PocoInterface;
	}
}
