using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A81 RID: 6785
	public class ICommonBtClientOverrideData
	{
		// Token: 0x06009021 RID: 36897 RVA: 0x0015324C File Offset: 0x0015144C
		private ICommonBtClientOverrideData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtClientOverrideData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtClientOverrideData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtClientOverrideData_SetValue());
			}
			return result;
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x00153284 File Offset: 0x00151484
		public static ICommonBtClientOverrideData Create([Nullable(2)] ICommonBtClientOverrideData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtClientOverrideData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x00153297 File Offset: 0x00151497
		public static ICommonBtClientOverrideData CreateFromSetValue([Nullable(2)] ICommonBtClientOverrideData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtClientOverrideData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009024 RID: 36900 RVA: 0x001532AA File Offset: 0x001514AA
		public ICommonBtClientOverrideData_SetValue ToSetValue()
		{
			return new ICommonBtClientOverrideData_SetValue
			{
				TaskId = this.TaskId,
				Data = this.Data
			};
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x06009025 RID: 36901 RVA: 0x001532C9 File Offset: 0x001514C9
		// (set) Token: 0x06009026 RID: 36902 RVA: 0x001532F4 File Offset: 0x001514F4
		public virtual int TaskId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TaskId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TaskId;
			}
			set
			{
				this.GetOrCreatePoco().TaskId = value;
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x06009027 RID: 36903 RVA: 0x00153302 File Offset: 0x00151502
		// (set) Token: 0x06009028 RID: 36904 RVA: 0x0015332D File Offset: 0x0015152D
		public virtual string Data
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Data;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Data;
			}
			set
			{
				this.GetOrCreatePoco().Data = value;
			}
		}

		// Token: 0x04005A34 RID: 23092
		[Nullable(2)]
		protected ICommonBtClientOverrideData FbInstance;

		// Token: 0x04005A35 RID: 23093
		[Nullable(2)]
		protected ICommonBtClientOverrideData_SetValue PocoInterface;
	}
}
