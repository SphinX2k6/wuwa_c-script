using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF9 RID: 7417
	public class IInteractionConfirmBoxType
	{
		// Token: 0x06009D69 RID: 40297 RVA: 0x0016A678 File Offset: 0x00168878
		private IInteractionConfirmBoxType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractionConfirmBoxType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractionConfirmBoxType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractionConfirmBoxType_SetValue());
			}
			return result;
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x0016A6B0 File Offset: 0x001688B0
		public static IInteractionConfirmBoxType Create([Nullable(2)] IInteractionConfirmBoxType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractionConfirmBoxType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x0016A6C3 File Offset: 0x001688C3
		public static IInteractionConfirmBoxType CreateFromSetValue([Nullable(2)] IInteractionConfirmBoxType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractionConfirmBoxType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x0016A6D6 File Offset: 0x001688D6
		public IInteractionConfirmBoxType_SetValue ToSetValue()
		{
			return new IInteractionConfirmBoxType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x06009D6D RID: 40301 RVA: 0x0016A6E9 File Offset: 0x001688E9
		// (set) Token: 0x06009D6E RID: 40302 RVA: 0x0016A714 File Offset: 0x00168914
		public virtual EInteractionConfirmBoxType Type
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

		// Token: 0x04006018 RID: 24600
		[Nullable(2)]
		protected IInteractionConfirmBoxType FbInstance;

		// Token: 0x04006019 RID: 24601
		[Nullable(2)]
		protected IInteractionConfirmBoxType_SetValue PocoInterface;
	}
}
