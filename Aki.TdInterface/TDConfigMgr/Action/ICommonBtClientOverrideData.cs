using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FA RID: 6394
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtClientOverrideData
	{
		// Token: 0x06008903 RID: 35075 RVA: 0x00143AC4 File Offset: 0x00141CC4
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

		// Token: 0x06008904 RID: 35076 RVA: 0x00143AFC File Offset: 0x00141CFC
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

		// Token: 0x06008905 RID: 35077 RVA: 0x00143B0F File Offset: 0x00141D0F
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

		// Token: 0x06008906 RID: 35078 RVA: 0x00143B22 File Offset: 0x00141D22
		public ICommonBtClientOverrideData_SetValue ToSetValue()
		{
			return new ICommonBtClientOverrideData_SetValue
			{
				TaskId = this.TaskId,
				Data = this.Data
			};
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x06008907 RID: 35079 RVA: 0x00143B41 File Offset: 0x00141D41
		// (set) Token: 0x06008908 RID: 35080 RVA: 0x00143B6C File Offset: 0x00141D6C
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

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x06008909 RID: 35081 RVA: 0x00143B7A File Offset: 0x00141D7A
		// (set) Token: 0x0600890A RID: 35082 RVA: 0x00143BA5 File Offset: 0x00141DA5
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

		// Token: 0x040055EA RID: 21994
		[Nullable(2)]
		protected ICommonBtClientOverrideData FbInstance;

		// Token: 0x040055EB RID: 21995
		[Nullable(2)]
		protected ICommonBtClientOverrideData_SetValue PocoInterface;
	}
}
