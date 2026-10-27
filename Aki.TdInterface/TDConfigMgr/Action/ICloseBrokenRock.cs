using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D8 RID: 6360
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseBrokenRock : ICloseUiGame
	{
		// Token: 0x06008863 RID: 34915 RVA: 0x00142A80 File Offset: 0x00140C80
		private ICloseBrokenRock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseBrokenRock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseBrokenRock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseBrokenRock_SetValue());
			}
			return result;
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x00142AB8 File Offset: 0x00140CB8
		public static ICloseBrokenRock Create([Nullable(2)] ICloseBrokenRock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseBrokenRock
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x00142ACB File Offset: 0x00140CCB
		public static ICloseBrokenRock CreateFromSetValue([Nullable(2)] ICloseBrokenRock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseBrokenRock
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008866 RID: 34918 RVA: 0x00142ADE File Offset: 0x00140CDE
		public new ICloseBrokenRock_SetValue ToSetValue()
		{
			return new ICloseBrokenRock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x06008867 RID: 34919 RVA: 0x00142AF1 File Offset: 0x00140CF1
		// (set) Token: 0x06008868 RID: 34920 RVA: 0x00142B1C File Offset: 0x00140D1C
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040055A9 RID: 21929
		[Nullable(2)]
		protected new ICloseBrokenRock FbInstance;

		// Token: 0x040055AA RID: 21930
		[Nullable(2)]
		protected new ICloseBrokenRock_SetValue PocoInterface;
	}
}
