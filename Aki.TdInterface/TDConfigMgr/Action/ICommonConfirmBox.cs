using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A91 RID: 6801
	public class ICommonConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x06009079 RID: 36985 RVA: 0x00153C6C File Offset: 0x00151E6C
		private ICommonConfirmBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonConfirmBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonConfirmBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonConfirmBox_SetValue());
			}
			return result;
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x00153CA4 File Offset: 0x00151EA4
		public static ICommonConfirmBox Create([Nullable(2)] ICommonConfirmBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonConfirmBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x00153CB7 File Offset: 0x00151EB7
		public static ICommonConfirmBox CreateFromSetValue([Nullable(2)] ICommonConfirmBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonConfirmBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x00153CCA File Offset: 0x00151ECA
		public new ICommonConfirmBox_SetValue ToSetValue()
		{
			return new ICommonConfirmBox_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600907D RID: 36989 RVA: 0x00153CE9 File Offset: 0x00151EE9
		// (set) Token: 0x0600907E RID: 36990 RVA: 0x00153D14 File Offset: 0x00151F14
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0600907F RID: 36991 RVA: 0x00153D22 File Offset: 0x00151F22
		// (set) Token: 0x06009080 RID: 36992 RVA: 0x00153D4D File Offset: 0x00151F4D
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

		// Token: 0x04005A5E RID: 23134
		[Nullable(2)]
		protected new ICommonConfirmBox FbInstance;

		// Token: 0x04005A5F RID: 23135
		[Nullable(2)]
		protected new ICommonConfirmBox_SetValue PocoInterface;
	}
}
