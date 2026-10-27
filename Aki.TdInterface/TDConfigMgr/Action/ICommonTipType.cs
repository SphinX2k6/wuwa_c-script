using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001928 RID: 6440
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipType
	{
		// Token: 0x06008A15 RID: 35349 RVA: 0x0014580C File Offset: 0x00143A0C
		private ICommonTipType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipType_SetValue());
			}
			return result;
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x00145844 File Offset: 0x00143A44
		public static ICommonTipType Create([Nullable(2)] ICommonTipType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x00145857 File Offset: 0x00143A57
		public static ICommonTipType CreateFromSetValue([Nullable(2)] ICommonTipType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x0014586A File Offset: 0x00143A6A
		public ICommonTipType_SetValue ToSetValue()
		{
			return new ICommonTipType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x06008A19 RID: 35353 RVA: 0x0014587D File Offset: 0x00143A7D
		// (set) Token: 0x06008A1A RID: 35354 RVA: 0x001458A8 File Offset: 0x00143AA8
		public virtual ECommonTipType Type
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

		// Token: 0x04005662 RID: 22114
		[Nullable(2)]
		protected ICommonTipType FbInstance;

		// Token: 0x04005663 RID: 22115
		[Nullable(2)]
		protected ICommonTipType_SetValue PocoInterface;
	}
}
