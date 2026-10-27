using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001916 RID: 6422
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipEnterInRange : ICommonTipType
	{
		// Token: 0x060089A7 RID: 35239 RVA: 0x00144CE4 File Offset: 0x00142EE4
		private ICommonTipEnterInRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipEnterInRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipEnterInRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipEnterInRange_SetValue());
			}
			return result;
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x00144D1C File Offset: 0x00142F1C
		public static ICommonTipEnterInRange Create([Nullable(2)] ICommonTipEnterInRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipEnterInRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x00144D2F File Offset: 0x00142F2F
		public static ICommonTipEnterInRange CreateFromSetValue([Nullable(2)] ICommonTipEnterInRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipEnterInRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x00144D42 File Offset: 0x00142F42
		public new ICommonTipEnterInRange_SetValue ToSetValue()
		{
			return new ICommonTipEnterInRange_SetValue
			{
				Type = this.Type,
				TidText = this.TidText,
				EdTidText = this.EdTidText
			};
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x060089AB RID: 35243 RVA: 0x00144D6D File Offset: 0x00142F6D
		// (set) Token: 0x060089AC RID: 35244 RVA: 0x00144D98 File Offset: 0x00142F98
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

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x00144DA6 File Offset: 0x00142FA6
		// (set) Token: 0x060089AE RID: 35246 RVA: 0x00144DD1 File Offset: 0x00142FD1
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

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x060089AF RID: 35247 RVA: 0x00144DDF File Offset: 0x00142FDF
		// (set) Token: 0x060089B0 RID: 35248 RVA: 0x00144DF6 File Offset: 0x00142FF6
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

		// Token: 0x04005634 RID: 22068
		[Nullable(2)]
		protected new ICommonTipEnterInRange FbInstance;

		// Token: 0x04005635 RID: 22069
		[Nullable(2)]
		protected new ICommonTipEnterInRange_SetValue PocoInterface;
	}
}
