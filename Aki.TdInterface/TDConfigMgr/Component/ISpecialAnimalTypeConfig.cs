using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F4 RID: 1780
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpecialAnimalTypeConfig
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x00066AAC File Offset: 0x00064CAC
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

		// Token: 0x06002659 RID: 9817 RVA: 0x00066AE4 File Offset: 0x00064CE4
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

		// Token: 0x0600265A RID: 9818 RVA: 0x00066AF7 File Offset: 0x00064CF7
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

		// Token: 0x0600265B RID: 9819 RVA: 0x00066B0A File Offset: 0x00064D0A
		public ISpecialAnimalTypeConfig_SetValue ToSetValue()
		{
			return new ISpecialAnimalTypeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x00066B1D File Offset: 0x00064D1D
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x00066B48 File Offset: 0x00064D48
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

		// Token: 0x04001A0B RID: 6667
		[Nullable(2)]
		protected ISpecialAnimalTypeConfig FbInstance;

		// Token: 0x04001A0C RID: 6668
		[Nullable(2)]
		protected ISpecialAnimalTypeConfig_SetValue PocoInterface;
	}
}
