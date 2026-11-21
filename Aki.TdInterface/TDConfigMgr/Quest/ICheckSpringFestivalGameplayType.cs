using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001010 RID: 4112
	public class ICheckSpringFestivalGameplayType
	{
		// Token: 0x06005A12 RID: 23058 RVA: 0x000DBB44 File Offset: 0x000D9D44
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

		// Token: 0x06005A13 RID: 23059 RVA: 0x000DBB7C File Offset: 0x000D9D7C
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

		// Token: 0x06005A14 RID: 23060 RVA: 0x000DBB8F File Offset: 0x000D9D8F
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

		// Token: 0x06005A15 RID: 23061 RVA: 0x000DBBA2 File Offset: 0x000D9DA2
		public ICheckSpringFestivalGameplayType_SetValue ToSetValue()
		{
			return new ICheckSpringFestivalGameplayType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06005A16 RID: 23062 RVA: 0x000DBBB5 File Offset: 0x000D9DB5
		// (set) Token: 0x06005A17 RID: 23063 RVA: 0x000DBBE0 File Offset: 0x000D9DE0
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

		// Token: 0x04003649 RID: 13897
		[Nullable(2)]
		protected ICheckSpringFestivalGameplayType FbInstance;

		// Token: 0x0400364A RID: 13898
		[Nullable(2)]
		protected ICheckSpringFestivalGameplayType_SetValue PocoInterface;
	}
}
