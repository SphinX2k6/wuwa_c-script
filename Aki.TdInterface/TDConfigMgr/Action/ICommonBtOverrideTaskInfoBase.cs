using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A8B RID: 6795
	public class ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x06009055 RID: 36949 RVA: 0x001538AC File Offset: 0x00151AAC
		private ICommonBtOverrideTaskInfoBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtOverrideTaskInfoBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtOverrideTaskInfoBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtOverrideTaskInfoBase_SetValue());
			}
			return result;
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x001538E4 File Offset: 0x00151AE4
		public static ICommonBtOverrideTaskInfoBase Create([Nullable(2)] ICommonBtOverrideTaskInfoBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverrideTaskInfoBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x001538F7 File Offset: 0x00151AF7
		public static ICommonBtOverrideTaskInfoBase CreateFromSetValue([Nullable(2)] ICommonBtOverrideTaskInfoBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtOverrideTaskInfoBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x0015390A File Offset: 0x00151B0A
		public ICommonBtOverrideTaskInfoBase_SetValue ToSetValue()
		{
			return new ICommonBtOverrideTaskInfoBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x06009059 RID: 36953 RVA: 0x0015391D File Offset: 0x00151B1D
		// (set) Token: 0x0600905A RID: 36954 RVA: 0x00153948 File Offset: 0x00151B48
		public virtual ECommonBtPlaceholderTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonBtPlaceholderTargetType.Action;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A4F RID: 23119
		[Nullable(2)]
		protected ICommonBtOverrideTaskInfoBase FbInstance;

		// Token: 0x04005A50 RID: 23120
		[Nullable(2)]
		protected ICommonBtOverrideTaskInfoBase_SetValue PocoInterface;
	}
}
