using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC9 RID: 6857
	public class ICreatePrefabConfig
	{
		// Token: 0x060091BB RID: 37307 RVA: 0x00155E54 File Offset: 0x00154054
		private ICreatePrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICreatePrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICreatePrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICreatePrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x00155E8C File Offset: 0x0015408C
		public static ICreatePrefabConfig Create([Nullable(2)] ICreatePrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreatePrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x00155E9F File Offset: 0x0015409F
		public static ICreatePrefabConfig CreateFromSetValue([Nullable(2)] ICreatePrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICreatePrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x00155EB2 File Offset: 0x001540B2
		public ICreatePrefabConfig_SetValue ToSetValue()
		{
			return new ICreatePrefabConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x060091BF RID: 37311 RVA: 0x00155EC5 File Offset: 0x001540C5
		// (set) Token: 0x060091C0 RID: 37312 RVA: 0x00155EF0 File Offset: 0x001540F0
		public virtual ECreatePrefabType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECreatePrefabType.PrefabId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AE7 RID: 23271
		[Nullable(2)]
		protected ICreatePrefabConfig FbInstance;

		// Token: 0x04005AE8 RID: 23272
		[Nullable(2)]
		protected ICreatePrefabConfig_SetValue PocoInterface;
	}
}
