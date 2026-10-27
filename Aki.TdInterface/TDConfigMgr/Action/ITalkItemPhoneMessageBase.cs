using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F4C RID: 8012
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemPhoneMessageBase
	{
		// Token: 0x0600AE4E RID: 44622 RVA: 0x00191830 File Offset: 0x0018FA30
		private ITalkItemPhoneMessageBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemPhoneMessageBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemPhoneMessageBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessageBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x00191868 File Offset: 0x0018FA68
		public static ITalkItemPhoneMessageBase Create([Nullable(2)] ITalkItemPhoneMessageBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x0019187B File Offset: 0x0018FA7B
		public static ITalkItemPhoneMessageBase CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessageBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x0019188E File Offset: 0x0018FA8E
		public ITalkItemPhoneMessageBase_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600AE52 RID: 44626 RVA: 0x001918A1 File Offset: 0x0018FAA1
		// (set) Token: 0x0600AE53 RID: 44627 RVA: 0x001918CC File Offset: 0x0018FACC
		public virtual EPhoneMessageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageType.Voice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040068CB RID: 26827
		[Nullable(2)]
		protected ITalkItemPhoneMessageBase FbInstance;

		// Token: 0x040068CC RID: 26828
		[Nullable(2)]
		protected ITalkItemPhoneMessageBase_SetValue PocoInterface;
	}
}
