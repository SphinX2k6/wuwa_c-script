using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017AA RID: 6058
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddOrSubAlertValueChangeSpeed : IAlertValueSpeedChangeType
	{
		// Token: 0x06008033 RID: 32819 RVA: 0x00132014 File Offset: 0x00130214
		private IAddOrSubAlertValueChangeSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddOrSubAlertValueChangeSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddOrSubAlertValueChangeSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddOrSubAlertValueChangeSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x0013204C File Offset: 0x0013024C
		public static IAddOrSubAlertValueChangeSpeed Create([Nullable(2)] IAddOrSubAlertValueChangeSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValueChangeSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x0013205F File Offset: 0x0013025F
		public static IAddOrSubAlertValueChangeSpeed CreateFromSetValue([Nullable(2)] IAddOrSubAlertValueChangeSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddOrSubAlertValueChangeSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x00132072 File Offset: 0x00130272
		public new IAddOrSubAlertValueChangeSpeed_SetValue ToSetValue()
		{
			return new IAddOrSubAlertValueChangeSpeed_SetValue
			{
				Type = this.Type,
				DeltaValue = this.DeltaValue
			};
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x00132091 File Offset: 0x00130291
		// (set) Token: 0x06008038 RID: 32824 RVA: 0x001320BC File Offset: 0x001302BC
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

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x06008039 RID: 32825 RVA: 0x001320CA File Offset: 0x001302CA
		// (set) Token: 0x0600803A RID: 32826 RVA: 0x001320F9 File Offset: 0x001302F9
		public virtual float DeltaValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeltaValue;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DeltaValue;
			}
			set
			{
				this.GetOrCreatePoco().DeltaValue = value;
			}
		}

		// Token: 0x0400515C RID: 20828
		[Nullable(2)]
		protected new IAddOrSubAlertValueChangeSpeed FbInstance;

		// Token: 0x0400515D RID: 20829
		[Nullable(2)]
		protected new IAddOrSubAlertValueChangeSpeed_SetValue PocoInterface;
	}
}
