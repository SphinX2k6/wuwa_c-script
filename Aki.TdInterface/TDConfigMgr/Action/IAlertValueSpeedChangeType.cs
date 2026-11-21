using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200195B RID: 6491
	public class IAlertValueSpeedChangeType
	{
		// Token: 0x06008A0D RID: 35341 RVA: 0x001486DC File Offset: 0x001468DC
		private IAlertValueSpeedChangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAlertValueSpeedChangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAlertValueSpeedChangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAlertValueSpeedChangeType_SetValue());
			}
			return result;
		}

		// Token: 0x06008A0E RID: 35342 RVA: 0x00148714 File Offset: 0x00146914
		public static IAlertValueSpeedChangeType Create([Nullable(2)] IAlertValueSpeedChangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAlertValueSpeedChangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A0F RID: 35343 RVA: 0x00148727 File Offset: 0x00146927
		public static IAlertValueSpeedChangeType CreateFromSetValue([Nullable(2)] IAlertValueSpeedChangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAlertValueSpeedChangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x0014873A File Offset: 0x0014693A
		public IAlertValueSpeedChangeType_SetValue ToSetValue()
		{
			return new IAlertValueSpeedChangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x06008A11 RID: 35345 RVA: 0x0014874D File Offset: 0x0014694D
		// (set) Token: 0x06008A12 RID: 35346 RVA: 0x00148778 File Offset: 0x00146978
		public virtual EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005779 RID: 22393
		[Nullable(2)]
		protected IAlertValueSpeedChangeType FbInstance;

		// Token: 0x0400577A RID: 22394
		[Nullable(2)]
		protected IAlertValueSpeedChangeType_SetValue PocoInterface;
	}
}
