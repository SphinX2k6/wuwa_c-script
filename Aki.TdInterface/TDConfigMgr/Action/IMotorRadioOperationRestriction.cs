using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C20 RID: 7200
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorRadioOperationRestriction
	{
		// Token: 0x06009A7F RID: 39551 RVA: 0x00163560 File Offset: 0x00161760
		private IMotorRadioOperationRestriction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorRadioOperationRestriction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorRadioOperationRestriction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorRadioOperationRestriction_SetValue());
			}
			return result;
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x00163598 File Offset: 0x00161798
		public static IMotorRadioOperationRestriction Create([Nullable(2)] IMotorRadioOperationRestriction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioOperationRestriction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x001635AB File Offset: 0x001617AB
		public static IMotorRadioOperationRestriction CreateFromSetValue([Nullable(2)] IMotorRadioOperationRestriction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorRadioOperationRestriction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x001635BE File Offset: 0x001617BE
		public IMotorRadioOperationRestriction_SetValue ToSetValue()
		{
			return new IMotorRadioOperationRestriction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x06009A83 RID: 39555 RVA: 0x001635D1 File Offset: 0x001617D1
		// (set) Token: 0x06009A84 RID: 39556 RVA: 0x001635FC File Offset: 0x001617FC
		public virtual EMotorRadioOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005DF7 RID: 24055
		[Nullable(2)]
		protected IMotorRadioOperationRestriction FbInstance;

		// Token: 0x04005DF8 RID: 24056
		[Nullable(2)]
		protected IMotorRadioOperationRestriction_SetValue PocoInterface;
	}
}
