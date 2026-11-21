using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000795 RID: 1941
	public class ISpecialAnimalTypeConfig
	{
		// Token: 0x06002978 RID: 10616 RVA: 0x0006DB1C File Offset: 0x0006BD1C
		private ISpecialAnimalTypeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialAnimalTypeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialAnimalTypeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialAnimalTypeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0006DB54 File Offset: 0x0006BD54
		public static ISpecialAnimalTypeConfig Create([Nullable(2)] ISpecialAnimalTypeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialAnimalTypeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0006DB67 File Offset: 0x0006BD67
		public static ISpecialAnimalTypeConfig CreateFromSetValue([Nullable(2)] ISpecialAnimalTypeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialAnimalTypeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0006DB7A File Offset: 0x0006BD7A
		public ISpecialAnimalTypeConfig_SetValue ToSetValue()
		{
			return new ISpecialAnimalTypeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x0006DB8D File Offset: 0x0006BD8D
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x0006DBB8 File Offset: 0x0006BDB8
		public virtual ESpecialAnimalType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialAnimalType.CollectAnimal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001C0A RID: 7178
		[Nullable(2)]
		protected ISpecialAnimalTypeConfig FbInstance;

		// Token: 0x04001C0B RID: 7179
		[Nullable(2)]
		protected ISpecialAnimalTypeConfig_SetValue PocoInterface;
	}
}
