using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020AE RID: 8366
	public class ISkiConfigType
	{
		// Token: 0x0600B1AC RID: 45484 RVA: 0x0018F6E8 File Offset: 0x0018D8E8
		private ISkiConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkiConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkiConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkiConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x0018F720 File Offset: 0x0018D920
		public static ISkiConfigType Create([Nullable(2)] ISkiConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x0018F733 File Offset: 0x0018D933
		public static ISkiConfigType CreateFromSetValue([Nullable(2)] ISkiConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkiConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x0018F746 File Offset: 0x0018D946
		public ISkiConfigType_SetValue ToSetValue()
		{
			return new ISkiConfigType_SetValue
			{
				Type = this.Type,
				Target = this.Target
			};
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600B1B0 RID: 45488 RVA: 0x0018F765 File Offset: 0x0018D965
		// (set) Token: 0x0600B1B1 RID: 45489 RVA: 0x0018F790 File Offset: 0x0018D990
		public virtual ESkiConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkiConfig.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600B1B2 RID: 45490 RVA: 0x0018F79E File Offset: 0x0018D99E
		// (set) Token: 0x0600B1B3 RID: 45491 RVA: 0x0018F7C5 File Offset: 0x0018D9C5
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ISkiConfigType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x0400698F RID: 27023
		[Nullable(2)]
		protected ISkiConfigType FbInstance;

		// Token: 0x04006990 RID: 27024
		[Nullable(2)]
		protected ISkiConfigType_SetValue PocoInterface;
	}
}
