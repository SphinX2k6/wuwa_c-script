using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B05 RID: 6917
	public class IDefaultLookAtType
	{
		// Token: 0x060092E9 RID: 37609 RVA: 0x00157EB4 File Offset: 0x001560B4
		private IDefaultLookAtType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDefaultLookAtType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDefaultLookAtType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDefaultLookAtType_SetValue());
			}
			return result;
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x00157EEC File Offset: 0x001560EC
		public static IDefaultLookAtType Create([Nullable(2)] IDefaultLookAtType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultLookAtType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x00157EFF File Offset: 0x001560FF
		public static IDefaultLookAtType CreateFromSetValue([Nullable(2)] IDefaultLookAtType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDefaultLookAtType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x00157F12 File Offset: 0x00156112
		public IDefaultLookAtType_SetValue ToSetValue()
		{
			return new IDefaultLookAtType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x060092ED RID: 37613 RVA: 0x00157F25 File Offset: 0x00156125
		// (set) Token: 0x060092EE RID: 37614 RVA: 0x00157F50 File Offset: 0x00156150
		public virtual EDefaultLookAtType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B6C RID: 23404
		[Nullable(2)]
		protected IDefaultLookAtType FbInstance;

		// Token: 0x04005B6D RID: 23405
		[Nullable(2)]
		protected IDefaultLookAtType_SetValue PocoInterface;
	}
}
