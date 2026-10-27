using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EFC RID: 3836
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckSpringFestivalGuessJokerCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x0600549E RID: 21662 RVA: 0x000CFA58 File Offset: 0x000CDC58
		private ICheckSpringFestivalGuessJokerCompleted_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckSpringFestivalGuessJokerCompleted 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckSpringFestivalGuessJokerCompleted_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckSpringFestivalGuessJokerCompleted_SetValue());
			}
			return result;
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x000CFA90 File Offset: 0x000CDC90
		public static ICheckSpringFestivalGuessJokerCompleted Create([Nullable(2)] ICheckSpringFestivalGuessJokerCompleted instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckSpringFestivalGuessJokerCompleted
			{
				FbInstance = instance
			};
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x000CFAA3 File Offset: 0x000CDCA3
		public static ICheckSpringFestivalGuessJokerCompleted CreateFromSetValue([Nullable(2)] ICheckSpringFestivalGuessJokerCompleted_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckSpringFestivalGuessJokerCompleted
			{
				PocoInterface = value
			};
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x000CFAB6 File Offset: 0x000CDCB6
		public new ICheckSpringFestivalGuessJokerCompleted_SetValue ToSetValue()
		{
			return new ICheckSpringFestivalGuessJokerCompleted_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x000CFAD5 File Offset: 0x000CDCD5
		// (set) Token: 0x060054A3 RID: 21667 RVA: 0x000CFB00 File Offset: 0x000CDD00
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

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x000CFB10 File Offset: 0x000CDD10
		// (set) Token: 0x060054A5 RID: 21669 RVA: 0x000CFB4A File Offset: 0x000CDD4A
		public virtual int? Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				ICheckSpringFestivalGuessJokerCompleted_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400333F RID: 13119
		[Nullable(2)]
		protected new ICheckSpringFestivalGuessJokerCompleted FbInstance;

		// Token: 0x04003340 RID: 13120
		[Nullable(2)]
		protected new ICheckSpringFestivalGuessJokerCompleted_SetValue PocoInterface;
	}
}
