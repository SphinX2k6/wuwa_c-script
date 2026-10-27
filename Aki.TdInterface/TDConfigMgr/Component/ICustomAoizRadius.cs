using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000297 RID: 663
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomAoizRadius
	{
		// Token: 0x06000C5F RID: 3167 RVA: 0x00030104 File Offset: 0x0002E304
		private ICustomAoizRadius_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomAoizRadius 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomAoizRadius_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomAoizRadius_SetValue());
			}
			return result;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0003013C File Offset: 0x0002E33C
		public static ICustomAoizRadius Create([Nullable(2)] ICustomAoizRadius instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAoizRadius
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003014F File Offset: 0x0002E34F
		public static ICustomAoizRadius CreateFromSetValue([Nullable(2)] ICustomAoizRadius_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomAoizRadius
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00030162 File Offset: 0x0002E362
		public ICustomAoizRadius_SetValue ToSetValue()
		{
			return new ICustomAoizRadius_SetValue
			{
				Up = this.Up,
				Down = this.Down
			};
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00030184 File Offset: 0x0002E384
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x000301BE File Offset: 0x0002E3BE
		public virtual int? Up
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Up;
				}
				ICustomAoizRadius_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Up;
			}
			set
			{
				this.GetOrCreatePoco().Up = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x000301CC File Offset: 0x0002E3CC
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00030206 File Offset: 0x0002E406
		public virtual int? Down
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Down;
				}
				ICustomAoizRadius_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Down;
			}
			set
			{
				this.GetOrCreatePoco().Down = value;
			}
		}

		// Token: 0x04000BA5 RID: 2981
		[Nullable(2)]
		protected ICustomAoizRadius FbInstance;

		// Token: 0x04000BA6 RID: 2982
		[Nullable(2)]
		protected ICustomAoizRadius_SetValue PocoInterface;
	}
}
