using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD3 RID: 6867
	public class ICustomAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x060091E5 RID: 37349 RVA: 0x00156248 File Offset: 0x00154448
		private ICustomAlertValueChangeSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomAlertValueChangeSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomAlertValueChangeSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomAlertValueChangeSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x00156280 File Offset: 0x00154480
		public static ICustomAlertValueChangeSpeed Create([Nullable(2)] ICustomAlertValueChangeSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAlertValueChangeSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x060091E7 RID: 37351 RVA: 0x00156293 File Offset: 0x00154493
		public static ICustomAlertValueChangeSpeed CreateFromSetValue([Nullable(2)] ICustomAlertValueChangeSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomAlertValueChangeSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x060091E8 RID: 37352 RVA: 0x001562A6 File Offset: 0x001544A6
		public new ICustomAlertValueChangeSpeed_SetValue ToSetValue()
		{
			return new ICustomAlertValueChangeSpeed_SetValue
			{
				Type = this.Type,
				CustomValue = this.CustomValue
			};
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x060091E9 RID: 37353 RVA: 0x001562C5 File Offset: 0x001544C5
		// (set) Token: 0x060091EA RID: 37354 RVA: 0x001562F0 File Offset: 0x001544F0
		public override EValueChangeType Type
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

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x060091EB RID: 37355 RVA: 0x001562FE File Offset: 0x001544FE
		// (set) Token: 0x060091EC RID: 37356 RVA: 0x0015632D File Offset: 0x0015452D
		public virtual float CustomValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomValue;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.CustomValue;
			}
			set
			{
				this.GetOrCreatePoco().CustomValue = value;
			}
		}

		// Token: 0x04005AF7 RID: 23287
		[Nullable(2)]
		protected new ICustomAlertValueChangeSpeed FbInstance;

		// Token: 0x04005AF8 RID: 23288
		[Nullable(2)]
		protected new ICustomAlertValueChangeSpeed_SetValue PocoInterface;
	}
}
