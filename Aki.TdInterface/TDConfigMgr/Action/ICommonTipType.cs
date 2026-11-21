using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AB1 RID: 6833
	public class ICommonTipType
	{
		// Token: 0x06009141 RID: 37185 RVA: 0x0015514C File Offset: 0x0015334C
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

		// Token: 0x06009142 RID: 37186 RVA: 0x00155184 File Offset: 0x00153384
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

		// Token: 0x06009143 RID: 37187 RVA: 0x00155197 File Offset: 0x00153397
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

		// Token: 0x06009144 RID: 37188 RVA: 0x001551AA File Offset: 0x001533AA
		public ICommonTipType_SetValue ToSetValue()
		{
			return new ICommonTipType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x06009145 RID: 37189 RVA: 0x001551BD File Offset: 0x001533BD
		// (set) Token: 0x06009146 RID: 37190 RVA: 0x001551E8 File Offset: 0x001533E8
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

		// Token: 0x04005AB2 RID: 23218
		[Nullable(2)]
		protected ICommonTipType FbInstance;

		// Token: 0x04005AB3 RID: 23219
		[Nullable(2)]
		protected ICommonTipType_SetValue PocoInterface;
	}
}
