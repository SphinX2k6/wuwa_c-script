using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EFE RID: 3838
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckSpringFestivalMixDrinksCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x060054A8 RID: 21672 RVA: 0x000CFB68 File Offset: 0x000CDD68
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

		// Token: 0x060054A9 RID: 21673 RVA: 0x000CFBA0 File Offset: 0x000CDDA0
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

		// Token: 0x060054AA RID: 21674 RVA: 0x000CFBB3 File Offset: 0x000CDDB3
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

		// Token: 0x060054AB RID: 21675 RVA: 0x000CFBC6 File Offset: 0x000CDDC6
		public new ICheckSpringFestivalMixDrinksCompleted_SetValue ToSetValue()
		{
			return new ICheckSpringFestivalMixDrinksCompleted_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x000CFBE5 File Offset: 0x000CDDE5
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x000CFC10 File Offset: 0x000CDE10
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

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x000CFC20 File Offset: 0x000CDE20
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x000CFC5A File Offset: 0x000CDE5A
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

		// Token: 0x04003343 RID: 13123
		[Nullable(2)]
		protected new ICheckSpringFestivalMixDrinksCompleted FbInstance;

		// Token: 0x04003344 RID: 13124
		[Nullable(2)]
		protected new ICheckSpringFestivalMixDrinksCompleted_SetValue PocoInterface;
	}
}
