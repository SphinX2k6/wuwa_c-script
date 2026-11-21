using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001012 RID: 4114
	public class ICheckSpringFestivalGuessJokerCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x06005A1A RID: 23066 RVA: 0x000DBC00 File Offset: 0x000D9E00
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

		// Token: 0x06005A1B RID: 23067 RVA: 0x000DBC38 File Offset: 0x000D9E38
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

		// Token: 0x06005A1C RID: 23068 RVA: 0x000DBC4B File Offset: 0x000D9E4B
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

		// Token: 0x06005A1D RID: 23069 RVA: 0x000DBC5E File Offset: 0x000D9E5E
		public new ICheckSpringFestivalGuessJokerCompleted_SetValue ToSetValue()
		{
			return new ICheckSpringFestivalGuessJokerCompleted_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x000DBC7D File Offset: 0x000D9E7D
		// (set) Token: 0x06005A1F RID: 23071 RVA: 0x000DBCA8 File Offset: 0x000D9EA8
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

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06005A20 RID: 23072 RVA: 0x000DBCB8 File Offset: 0x000D9EB8
		// (set) Token: 0x06005A21 RID: 23073 RVA: 0x000DBCF2 File Offset: 0x000D9EF2
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

		// Token: 0x0400364C RID: 13900
		[Nullable(2)]
		protected new ICheckSpringFestivalGuessJokerCompleted FbInstance;

		// Token: 0x0400364D RID: 13901
		[Nullable(2)]
		protected new ICheckSpringFestivalGuessJokerCompleted_SetValue PocoInterface;
	}
}
