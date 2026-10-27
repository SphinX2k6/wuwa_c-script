using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EFA RID: 3834
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckSpringFestivalGameplayType
	{
		// Token: 0x06005496 RID: 21654 RVA: 0x000CF99C File Offset: 0x000CDB9C
		private ICheckSpringFestivalGameplayType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckSpringFestivalGameplayType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckSpringFestivalGameplayType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckSpringFestivalGameplayType_SetValue());
			}
			return result;
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x000CF9D4 File Offset: 0x000CDBD4
		public static ICheckSpringFestivalGameplayType Create([Nullable(2)] ICheckSpringFestivalGameplayType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckSpringFestivalGameplayType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x000CF9E7 File Offset: 0x000CDBE7
		public static ICheckSpringFestivalGameplayType CreateFromSetValue([Nullable(2)] ICheckSpringFestivalGameplayType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckSpringFestivalGameplayType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x000CF9FA File Offset: 0x000CDBFA
		public ICheckSpringFestivalGameplayType_SetValue ToSetValue()
		{
			return new ICheckSpringFestivalGameplayType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x0600549A RID: 21658 RVA: 0x000CFA0D File Offset: 0x000CDC0D
		// (set) Token: 0x0600549B RID: 21659 RVA: 0x000CFA38 File Offset: 0x000CDC38
		public virtual ESpringFestivalGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpringFestivalGameplayType.MixDrinks;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400333C RID: 13116
		[Nullable(2)]
		protected ICheckSpringFestivalGameplayType FbInstance;

		// Token: 0x0400333D RID: 13117
		[Nullable(2)]
		protected ICheckSpringFestivalGameplayType_SetValue PocoInterface;
	}
}
