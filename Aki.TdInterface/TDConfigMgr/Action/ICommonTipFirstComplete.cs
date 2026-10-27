using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001918 RID: 6424
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipFirstComplete : ICommonTipType
	{
		// Token: 0x060089B3 RID: 35251 RVA: 0x00144E14 File Offset: 0x00143014
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

		// Token: 0x060089B4 RID: 35252 RVA: 0x00144E4C File Offset: 0x0014304C
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

		// Token: 0x060089B5 RID: 35253 RVA: 0x00144E5F File Offset: 0x0014305F
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

		// Token: 0x060089B6 RID: 35254 RVA: 0x00144E72 File Offset: 0x00143072
		public new ICommonTipFirstComplete_SetValue ToSetValue()
		{
			return new ICommonTipFirstComplete_SetValue
			{
				Type = this.Type,
				TidText = this.TidText,
				EdTidText = this.EdTidText
			};
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x060089B7 RID: 35255 RVA: 0x00144E9D File Offset: 0x0014309D
		// (set) Token: 0x060089B8 RID: 35256 RVA: 0x00144EC8 File Offset: 0x001430C8
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

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x060089B9 RID: 35257 RVA: 0x00144ED6 File Offset: 0x001430D6
		// (set) Token: 0x060089BA RID: 35258 RVA: 0x00144F01 File Offset: 0x00143101
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

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x060089BB RID: 35259 RVA: 0x00144F0F File Offset: 0x0014310F
		// (set) Token: 0x060089BC RID: 35260 RVA: 0x00144F26 File Offset: 0x00143126
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

		// Token: 0x04005639 RID: 22073
		[Nullable(2)]
		protected new ICommonTipFirstComplete FbInstance;

		// Token: 0x0400563A RID: 22074
		[Nullable(2)]
		protected new ICommonTipFirstComplete_SetValue PocoInterface;
	}
}
