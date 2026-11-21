using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA1 RID: 6817
	public class ICommonTipFirstComplete : ICommonTipType
	{
		// Token: 0x060090DF RID: 37087 RVA: 0x00154754 File Offset: 0x00152954
		private ICommonTipFirstComplete_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipFirstComplete 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipFirstComplete_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipFirstComplete_SetValue());
			}
			return result;
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x0015478C File Offset: 0x0015298C
		public static ICommonTipFirstComplete Create([Nullable(2)] ICommonTipFirstComplete instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipFirstComplete
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x0015479F File Offset: 0x0015299F
		public static ICommonTipFirstComplete CreateFromSetValue([Nullable(2)] ICommonTipFirstComplete_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipFirstComplete
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x001547B2 File Offset: 0x001529B2
		public new ICommonTipFirstComplete_SetValue ToSetValue()
		{
			return new ICommonTipFirstComplete_SetValue
			{
				Type = this.Type,
				TidText = this.TidText,
				EdTidText = this.EdTidText
			};
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x060090E3 RID: 37091 RVA: 0x001547DD File Offset: 0x001529DD
		// (set) Token: 0x060090E4 RID: 37092 RVA: 0x00154808 File Offset: 0x00152A08
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x060090E5 RID: 37093 RVA: 0x00154816 File Offset: 0x00152A16
		// (set) Token: 0x060090E6 RID: 37094 RVA: 0x00154841 File Offset: 0x00152A41
		public virtual string TidText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidText;
			}
			set
			{
				this.GetOrCreatePoco().TidText = value;
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x060090E7 RID: 37095 RVA: 0x0015484F File Offset: 0x00152A4F
		// (set) Token: 0x060090E8 RID: 37096 RVA: 0x00154866 File Offset: 0x00152A66
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidText = value;
			}
		}

		// Token: 0x04005A89 RID: 23177
		[Nullable(2)]
		protected new ICommonTipFirstComplete FbInstance;

		// Token: 0x04005A8A RID: 23178
		[Nullable(2)]
		protected new ICommonTipFirstComplete_SetValue PocoInterface;
	}
}
