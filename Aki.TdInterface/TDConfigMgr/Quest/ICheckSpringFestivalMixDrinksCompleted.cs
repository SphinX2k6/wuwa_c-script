using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001014 RID: 4116
	public class ICheckSpringFestivalMixDrinksCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x06005A24 RID: 23076 RVA: 0x000DBD10 File Offset: 0x000D9F10
		private ICheckSpringFestivalMixDrinksCompleted_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckSpringFestivalMixDrinksCompleted 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckSpringFestivalMixDrinksCompleted_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckSpringFestivalMixDrinksCompleted_SetValue());
			}
			return result;
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x000DBD48 File Offset: 0x000D9F48
		public static ICheckSpringFestivalMixDrinksCompleted Create([Nullable(2)] ICheckSpringFestivalMixDrinksCompleted instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckSpringFestivalMixDrinksCompleted
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x000DBD5B File Offset: 0x000D9F5B
		public static ICheckSpringFestivalMixDrinksCompleted CreateFromSetValue([Nullable(2)] ICheckSpringFestivalMixDrinksCompleted_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckSpringFestivalMixDrinksCompleted
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x000DBD6E File Offset: 0x000D9F6E
		public new ICheckSpringFestivalMixDrinksCompleted_SetValue ToSetValue()
		{
			return new ICheckSpringFestivalMixDrinksCompleted_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06005A28 RID: 23080 RVA: 0x000DBD8D File Offset: 0x000D9F8D
		// (set) Token: 0x06005A29 RID: 23081 RVA: 0x000DBDB8 File Offset: 0x000D9FB8
		public override ESpringFestivalGameplayType Type
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

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06005A2A RID: 23082 RVA: 0x000DBDC8 File Offset: 0x000D9FC8
		// (set) Token: 0x06005A2B RID: 23083 RVA: 0x000DBE02 File Offset: 0x000DA002
		public virtual int? Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				ICheckSpringFestivalMixDrinksCompleted_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04003650 RID: 13904
		[Nullable(2)]
		protected new ICheckSpringFestivalMixDrinksCompleted FbInstance;

		// Token: 0x04003651 RID: 13905
		[Nullable(2)]
		protected new ICheckSpringFestivalMixDrinksCompleted_SetValue PocoInterface;
	}
}
