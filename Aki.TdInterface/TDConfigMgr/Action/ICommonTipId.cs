using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200191C RID: 6428
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipId : ICommonTipType
	{
		// Token: 0x060089CB RID: 35275 RVA: 0x00145074 File Offset: 0x00143274
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

		// Token: 0x060089CC RID: 35276 RVA: 0x001450AC File Offset: 0x001432AC
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

		// Token: 0x060089CD RID: 35277 RVA: 0x001450BF File Offset: 0x001432BF
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

		// Token: 0x060089CE RID: 35278 RVA: 0x001450D2 File Offset: 0x001432D2
		public new ICommonTipId_SetValue ToSetValue()
		{
			return new ICommonTipId_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x001450F1 File Offset: 0x001432F1
		// (set) Token: 0x060089D0 RID: 35280 RVA: 0x0014511C File Offset: 0x0014331C
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

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x060089D1 RID: 35281 RVA: 0x0014512A File Offset: 0x0014332A
		// (set) Token: 0x060089D2 RID: 35282 RVA: 0x00145155 File Offset: 0x00143355
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

		// Token: 0x04005643 RID: 22083
		[Nullable(2)]
		protected new ICommonTipId FbInstance;

		// Token: 0x04005644 RID: 22084
		[Nullable(2)]
		protected new ICommonTipId_SetValue PocoInterface;
	}
}
