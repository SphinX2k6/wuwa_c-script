using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA5 RID: 6821
	public class ICommonTipId : ICommonTipType
	{
		// Token: 0x060090F7 RID: 37111 RVA: 0x001549B4 File Offset: 0x00152BB4
		private ICommonTipId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipId_SetValue());
			}
			return result;
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x001549EC File Offset: 0x00152BEC
		public static ICommonTipId Create([Nullable(2)] ICommonTipId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipId
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x001549FF File Offset: 0x00152BFF
		public static ICommonTipId CreateFromSetValue([Nullable(2)] ICommonTipId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipId
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x00154A12 File Offset: 0x00152C12
		public new ICommonTipId_SetValue ToSetValue()
		{
			return new ICommonTipId_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x060090FB RID: 37115 RVA: 0x00154A31 File Offset: 0x00152C31
		// (set) Token: 0x060090FC RID: 37116 RVA: 0x00154A5C File Offset: 0x00152C5C
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

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x060090FD RID: 37117 RVA: 0x00154A6A File Offset: 0x00152C6A
		// (set) Token: 0x060090FE RID: 37118 RVA: 0x00154A95 File Offset: 0x00152C95
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005A93 RID: 23187
		[Nullable(2)]
		protected new ICommonTipId FbInstance;

		// Token: 0x04005A94 RID: 23188
		[Nullable(2)]
		protected new ICommonTipId_SetValue PocoInterface;
	}
}
